// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal abstract class CryptographicHashProvider
    {
        private ImmutableArray<byte> _lazySHA1Hash;

        private ImmutableArray<byte> _lazySHA256Hash;

        private ImmutableArray<byte> _lazySHA384Hash;

        private ImmutableArray<byte> _lazySHA512Hash;

        private ImmutableArray<byte> _lazyMD5Hash;

        internal abstract ImmutableArray<byte> ComputeHash(HashAlgorithm algorithm);

        internal ImmutableArray<byte> GetHash(AssemblyHashAlgorithm algorithmId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10, 961, 2254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 1058, 2243);
                using (HashAlgorithm?
                algorithm = f_10_1092_1120(algorithmId)
                )
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 1222, 1341) || true) && (algorithm == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 1222, 1341);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 1285, 1322);

                        return f_10_1292_1321();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10, 1222, 1341);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 1361, 2228);

                    switch (algorithmId)
                    {

                        case AssemblyHashAlgorithm.None:
                        case AssemblyHashAlgorithm.Sha1:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 1361, 2228);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 1534, 1579);

                            return f_10_1541_1578(this, ref _lazySHA1Hash, algorithm);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10, 1361, 2228);

                        case AssemblyHashAlgorithm.Sha256:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 1361, 2228);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 1663, 1710);

                            return f_10_1670_1709(this, ref _lazySHA256Hash, algorithm);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10, 1361, 2228);

                        case AssemblyHashAlgorithm.Sha384:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 1361, 2228);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 1794, 1841);

                            return f_10_1801_1840(this, ref _lazySHA384Hash, algorithm);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10, 1361, 2228);

                        case AssemblyHashAlgorithm.Sha512:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 1361, 2228);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 1925, 1972);

                            return f_10_1932_1971(this, ref _lazySHA512Hash, algorithm);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10, 1361, 2228);

                        case AssemblyHashAlgorithm.MD5:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 1361, 2228);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 2053, 2097);

                            return f_10_2060_2096(this, ref _lazyMD5Hash, algorithm);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10, 1361, 2228);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 1361, 2228);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 2155, 2209);

                            throw f_10_2161_2208(algorithmId);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10, 1361, 2228);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10, 1058, 2243);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10, 961, 2254);

                System.Security.Cryptography.HashAlgorithm?
                f_10_1092_1120(System.Reflection.AssemblyHashAlgorithm
                algorithmId)
                {
                    var return_v = TryGetAlgorithm(algorithmId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 1092, 1120);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10_1292_1321()
                {
                    var return_v = ImmutableArray.Create<byte>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 1292, 1321);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10_1541_1578(Microsoft.CodeAnalysis.CryptographicHashProvider
                this_param, ref System.Collections.Immutable.ImmutableArray<byte>
                lazyHash, System.Security.Cryptography.HashAlgorithm
                algorithm)
                {
                    var return_v = this_param.GetHash(ref lazyHash, algorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 1541, 1578);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10_1670_1709(Microsoft.CodeAnalysis.CryptographicHashProvider
                this_param, ref System.Collections.Immutable.ImmutableArray<byte>
                lazyHash, System.Security.Cryptography.HashAlgorithm
                algorithm)
                {
                    var return_v = this_param.GetHash(ref lazyHash, algorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 1670, 1709);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10_1801_1840(Microsoft.CodeAnalysis.CryptographicHashProvider
                this_param, ref System.Collections.Immutable.ImmutableArray<byte>
                lazyHash, System.Security.Cryptography.HashAlgorithm
                algorithm)
                {
                    var return_v = this_param.GetHash(ref lazyHash, algorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 1801, 1840);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10_1932_1971(Microsoft.CodeAnalysis.CryptographicHashProvider
                this_param, ref System.Collections.Immutable.ImmutableArray<byte>
                lazyHash, System.Security.Cryptography.HashAlgorithm
                algorithm)
                {
                    var return_v = this_param.GetHash(ref lazyHash, algorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 1932, 1971);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10_2060_2096(Microsoft.CodeAnalysis.CryptographicHashProvider
                this_param, ref System.Collections.Immutable.ImmutableArray<byte>
                lazyHash, System.Security.Cryptography.HashAlgorithm
                algorithm)
                {
                    var return_v = this_param.GetHash(ref lazyHash, algorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 2060, 2096);
                    return return_v;
                }


                System.Exception
                f_10_2161_2208(System.Reflection.AssemblyHashAlgorithm
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 2161, 2208);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10, 961, 2254);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10, 961, 2254);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetHashSize(SourceHashAlgorithm algorithmId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10, 2266, 2694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 2355, 2683);

                switch (algorithmId)
                {

                    case SourceHashAlgorithm.Sha1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 2355, 2683);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 2460, 2475);

                        return 160 / 8;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10, 2355, 2683);

                    case SourceHashAlgorithm.Sha256:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 2355, 2683);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 2549, 2564);

                        return 256 / 8;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10, 2355, 2683);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 2355, 2683);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 2614, 2668);

                        throw f_10_2620_2667(algorithmId);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10, 2355, 2683);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10, 2266, 2694);

                System.Exception
                f_10_2620_2667(Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 2620, 2667);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10, 2266, 2694);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10, 2266, 2694);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static HashAlgorithm? TryGetAlgorithm(SourceHashAlgorithm algorithmId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10, 2706, 3121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 2810, 3110);

                switch (algorithmId)
                {

                    case SourceHashAlgorithm.Sha1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 2810, 3110);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 2915, 2936);

                        return f_10_2922_2935();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10, 2810, 3110);

                    case SourceHashAlgorithm.Sha256:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 2810, 3110);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 3010, 3033);

                        return f_10_3017_3032();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10, 2810, 3110);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 2810, 3110);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 3083, 3095);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10, 2810, 3110);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10, 2706, 3121);

                System.Security.Cryptography.SHA1
                f_10_2922_2935()
                {
                    var return_v = SHA1.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 2922, 2935);
                    return return_v;
                }


                System.Security.Cryptography.SHA256
                f_10_3017_3032()
                {
                    var return_v = SHA256.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 3017, 3032);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10, 2706, 3121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10, 2706, 3121);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static HashAlgorithmName GetAlgorithmName(SourceHashAlgorithm algorithmId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10, 3133, 3612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 3241, 3601);

                switch (algorithmId)
                {

                    case SourceHashAlgorithm.Sha1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 3241, 3601);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 3346, 3376);

                        return HashAlgorithmName.SHA1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10, 3241, 3601);

                    case SourceHashAlgorithm.Sha256:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 3241, 3601);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 3450, 3482);

                        return HashAlgorithmName.SHA256;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10, 3241, 3601);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 3241, 3601);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 3532, 3586);

                        throw f_10_3538_3585(algorithmId);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10, 3241, 3601);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10, 3133, 3612);

                System.Exception
                f_10_3538_3585(Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 3538, 3585);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10, 3133, 3612);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10, 3133, 3612);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static HashAlgorithm? TryGetAlgorithm(AssemblyHashAlgorithm algorithmId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10, 3624, 4386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 3730, 4375);

                switch (algorithmId)
                {

                    case AssemblyHashAlgorithm.None:
                    case AssemblyHashAlgorithm.Sha1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 3730, 4375);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 3887, 3908);

                        return f_10_3894_3907();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10, 3730, 4375);

                    case AssemblyHashAlgorithm.Sha256:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 3730, 4375);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 3984, 4007);

                        return f_10_3991_4006();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10, 3730, 4375);

                    case AssemblyHashAlgorithm.Sha384:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 3730, 4375);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 4083, 4106);

                        return f_10_4090_4105();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10, 3730, 4375);

                    case AssemblyHashAlgorithm.Sha512:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 3730, 4375);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 4182, 4205);

                        return f_10_4189_4204();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10, 3730, 4375);

                    case AssemblyHashAlgorithm.MD5:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 3730, 4375);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 4278, 4298);

                        return f_10_4285_4297();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10, 3730, 4375);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 3730, 4375);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 4348, 4360);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10, 3730, 4375);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10, 3624, 4386);

                System.Security.Cryptography.SHA1
                f_10_3894_3907()
                {
                    var return_v = SHA1.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 3894, 3907);
                    return return_v;
                }


                System.Security.Cryptography.SHA256
                f_10_3991_4006()
                {
                    var return_v = SHA256.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 3991, 4006);
                    return return_v;
                }


                System.Security.Cryptography.SHA384
                f_10_4090_4105()
                {
                    var return_v = SHA384.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 4090, 4105);
                    return return_v;
                }


                System.Security.Cryptography.SHA512
                f_10_4189_4204()
                {
                    var return_v = SHA512.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 4189, 4204);
                    return return_v;
                }


                System.Security.Cryptography.MD5
                f_10_4285_4297()
                {
                    var return_v = MD5.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 4285, 4297);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10, 3624, 4386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10, 3624, 4386);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsSupportedAlgorithm(AssemblyHashAlgorithm algorithmId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10, 4398, 4962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 4499, 4951);

                switch (algorithmId)
                {

                    case AssemblyHashAlgorithm.None:
                    case AssemblyHashAlgorithm.Sha1:
                    case AssemblyHashAlgorithm.Sha256:
                    case AssemblyHashAlgorithm.Sha384:
                    case AssemblyHashAlgorithm.Sha512:
                    case AssemblyHashAlgorithm.MD5:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 4499, 4951);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 4861, 4873);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10, 4499, 4951);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 4499, 4951);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 4923, 4936);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10, 4499, 4951);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10, 4398, 4962);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10, 4398, 4962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10, 4398, 4962);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<byte> GetHash(ref ImmutableArray<byte> lazyHash, HashAlgorithm algorithm)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10, 4974, 5326);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 5095, 5283) || true) && (lazyHash.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 5095, 5283);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 5151, 5268);

                    f_10_5151_5267(ref lazyHash, f_10_5213_5235(this, algorithm), default(ImmutableArray<byte>));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10, 5095, 5283);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 5299, 5315);

                return lazyHash;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10, 4974, 5326);

                System.Collections.Immutable.ImmutableArray<byte>
                f_10_5213_5235(Microsoft.CodeAnalysis.CryptographicHashProvider
                this_param, System.Security.Cryptography.HashAlgorithm
                algorithm)
                {
                    var return_v = this_param.ComputeHash(algorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 5213, 5235);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10_5151_5267(ref System.Collections.Immutable.ImmutableArray<byte>
                location, System.Collections.Immutable.ImmutableArray<byte>
                value, System.Collections.Immutable.ImmutableArray<byte>
                comparand)
                {
                    var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 5151, 5267);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10, 4974, 5326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10, 4974, 5326);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal const int
        Sha1HashSize = 20
        ;

        internal static ImmutableArray<byte> ComputeSha1(Stream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10, 5387, 5817);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 5475, 5756) || true) && (stream != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10, 5475, 5756);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 5527, 5560);

                    f_10_5527_5559(stream, 0, SeekOrigin.Begin);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 5578, 5741);
                    using (var
                    hashProvider = f_10_5604_5617()
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 5659, 5722);

                        return f_10_5666_5721(f_10_5688_5720(hashProvider, stream));
                        DynAbs.Tracing.TraceSender.TraceExitUsing(10, 5578, 5741);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10, 5475, 5756);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 5772, 5806);

                return ImmutableArray<byte>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10, 5387, 5817);

                long
                f_10_5527_5559(System.IO.Stream
                this_param, int
                offset, System.IO.SeekOrigin
                origin)
                {
                    var return_v = this_param.Seek((long)offset, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 5527, 5559);
                    return return_v;
                }


                System.Security.Cryptography.SHA1
                f_10_5604_5617()
                {
                    var return_v = SHA1.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 5604, 5617);
                    return return_v;
                }


                byte[]
                f_10_5688_5720(System.Security.Cryptography.SHA1
                this_param, System.IO.Stream
                inputStream)
                {
                    var return_v = this_param.ComputeHash(inputStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 5688, 5720);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10_5666_5721(params byte[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 5666, 5721);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10, 5387, 5817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10, 5387, 5817);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<byte> ComputeSha1(ImmutableArray<byte> bytes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10, 5829, 5977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 5930, 5966);

                return f_10_5937_5965(bytes.ToArray());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10, 5829, 5977);

                System.Collections.Immutable.ImmutableArray<byte>
                f_10_5937_5965(byte[]
                bytes)
                {
                    var return_v = ComputeSha1(bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 5937, 5965);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10, 5829, 5977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10, 5829, 5977);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<byte> ComputeSha1(byte[] bytes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10, 5989, 6237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 6076, 6226);
                using (var
                hashProvider = f_10_6102_6115()
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 6149, 6211);

                    return f_10_6156_6210(f_10_6178_6209(hashProvider, bytes));
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10, 6076, 6226);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10, 5989, 6237);

                System.Security.Cryptography.SHA1
                f_10_6102_6115()
                {
                    var return_v = SHA1.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 6102, 6115);
                    return return_v;
                }


                byte[]
                f_10_6178_6209(System.Security.Cryptography.SHA1
                this_param, byte[]
                buffer)
                {
                    var return_v = this_param.ComputeHash(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 6178, 6209);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10_6156_6210(params byte[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 6156, 6210);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10, 5989, 6237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10, 5989, 6237);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<byte> ComputeHash(HashAlgorithmName algorithmName, IEnumerable<Blob> bytes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10, 6249, 6626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 6380, 6615);
                using (var
                incrementalHash = f_10_6409_6450(algorithmName)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 6484, 6518);

                    f_10_6484_6517(incrementalHash, bytes);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 6536, 6600);

                    return f_10_6543_6599(f_10_6565_6598(incrementalHash));
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10, 6380, 6615);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10, 6249, 6626);

                System.Security.Cryptography.IncrementalHash
                f_10_6409_6450(System.Security.Cryptography.HashAlgorithmName
                hashAlgorithm)
                {
                    var return_v = IncrementalHash.CreateHash(hashAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 6409, 6450);
                    return return_v;
                }


                int
                f_10_6484_6517(System.Security.Cryptography.IncrementalHash
                hash, System.Collections.Generic.IEnumerable<System.Reflection.Metadata.Blob>
                blobs)
                {
                    hash.AppendData(blobs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 6484, 6517);
                    return 0;
                }


                byte[]
                f_10_6565_6598(System.Security.Cryptography.IncrementalHash
                this_param)
                {
                    var return_v = this_param.GetHashAndReset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 6565, 6598);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10_6543_6599(params byte[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 6543, 6599);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10, 6249, 6626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10, 6249, 6626);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<byte> ComputeHash(HashAlgorithmName algorithmName, IEnumerable<ArraySegment<byte>> bytes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10, 6638, 7029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 6783, 7018);
                using (var
                incrementalHash = f_10_6812_6853(algorithmName)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 6887, 6921);

                    f_10_6887_6920(incrementalHash, bytes);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 6939, 7003);

                    return f_10_6946_7002(f_10_6968_7001(incrementalHash));
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10, 6783, 7018);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10, 6638, 7029);

                System.Security.Cryptography.IncrementalHash
                f_10_6812_6853(System.Security.Cryptography.HashAlgorithmName
                hashAlgorithm)
                {
                    var return_v = IncrementalHash.CreateHash(hashAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 6812, 6853);
                    return return_v;
                }


                int
                f_10_6887_6920(System.Security.Cryptography.IncrementalHash
                hash, System.Collections.Generic.IEnumerable<System.ArraySegment<byte>>
                blobs)
                {
                    hash.AppendData(blobs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 6887, 6920);
                    return 0;
                }


                byte[]
                f_10_6968_7001(System.Security.Cryptography.IncrementalHash
                this_param)
                {
                    var return_v = this_param.GetHashAndReset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 6968, 7001);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10_6946_7002(params byte[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 6946, 7002);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10, 6638, 7029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10, 6638, 7029);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<byte> ComputeSourceHash(ImmutableArray<byte> bytes, SourceHashAlgorithm hashAlgorithm = SourceHashAlgorithmUtils.DefaultContentHashAlgorithm)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10, 7041, 7560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 7238, 7290);

                var
                algorithmName = f_10_7258_7289(hashAlgorithm)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 7304, 7549);
                using (var
                incrementalHash = f_10_7333_7374(algorithmName)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 7408, 7452);

                    f_10_7408_7451(incrementalHash, bytes.ToArray());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 7470, 7534);

                    return f_10_7477_7533(f_10_7499_7532(incrementalHash));
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10, 7304, 7549);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10, 7041, 7560);

                System.Security.Cryptography.HashAlgorithmName
                f_10_7258_7289(Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                algorithmId)
                {
                    var return_v = GetAlgorithmName(algorithmId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 7258, 7289);
                    return return_v;
                }


                System.Security.Cryptography.IncrementalHash
                f_10_7333_7374(System.Security.Cryptography.HashAlgorithmName
                hashAlgorithm)
                {
                    var return_v = IncrementalHash.CreateHash(hashAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 7333, 7374);
                    return return_v;
                }


                int
                f_10_7408_7451(System.Security.Cryptography.IncrementalHash
                this_param, byte[]
                data)
                {
                    this_param.AppendData(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 7408, 7451);
                    return 0;
                }


                byte[]
                f_10_7499_7532(System.Security.Cryptography.IncrementalHash
                this_param)
                {
                    var return_v = this_param.GetHashAndReset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 7499, 7532);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10_7477_7533(params byte[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 7477, 7533);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10, 7041, 7560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10, 7041, 7560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<byte> ComputeSourceHash(IEnumerable<Blob> bytes, SourceHashAlgorithm hashAlgorithm = SourceHashAlgorithmUtils.DefaultContentHashAlgorithm)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10, 7572, 7836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 7766, 7825);

                return f_10_7773_7824(f_10_7785_7816(hashAlgorithm), bytes);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10, 7572, 7836);

                System.Security.Cryptography.HashAlgorithmName
                f_10_7785_7816(Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                algorithmId)
                {
                    var return_v = GetAlgorithmName(algorithmId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 7785, 7816);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10_7773_7824(System.Security.Cryptography.HashAlgorithmName
                algorithmName, System.Collections.Generic.IEnumerable<System.Reflection.Metadata.Blob>
                bytes)
                {
                    var return_v = ComputeHash(algorithmName, bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10, 7773, 7824);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10, 7572, 7836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10, 7572, 7836);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CryptographicHashProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10, 535, 7843);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10, 535, 7843);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10, 535, 7843);
        }


        static CryptographicHashProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10, 535, 7843);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10, 5357, 5374);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10, 535, 7843);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10, 535, 7843);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10, 535, 7843);
    }
}
