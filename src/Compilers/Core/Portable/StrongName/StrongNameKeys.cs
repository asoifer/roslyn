// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;

namespace Microsoft.CodeAnalysis
{
    internal sealed class StrongNameKeys
    {
        internal readonly ImmutableArray<byte> KeyPair;

        internal readonly ImmutableArray<byte> PublicKey;

        internal readonly RSAParameters? PrivateKey;

        internal readonly Diagnostic? DiagnosticOpt;

        internal readonly string? KeyContainer;

        internal readonly string? KeyFilePath;

        internal readonly bool HasCounterSignature;

        internal static readonly StrongNameKeys None;

        private StrongNameKeys()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(563, 2573, 2619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 1104, 1114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 1277, 1290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 1762, 1774);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 2179, 2190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 2461, 2480);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(563, 2573, 2619);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(563, 2573, 2619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(563, 2573, 2619);
            }
        }

        internal StrongNameKeys(Diagnostic diagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(563, 2631, 2792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 1104, 1114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 1277, 1290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 1762, 1774);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 2179, 2190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 2461, 2480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 2702, 2735);

                f_563_2702_2734(diagnostic != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 2749, 2781);

                this.DiagnosticOpt = diagnostic;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(563, 2631, 2792);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(563, 2631, 2792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(563, 2631, 2792);
            }
        }

        internal StrongNameKeys(ImmutableArray<byte> keyPair, ImmutableArray<byte> publicKey, RSAParameters? privateKey, string? keyContainerName, string? keyFilePath, bool hasCounterSignature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(563, 2804, 3434);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 1104, 1114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 1277, 1290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 1762, 1774);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 2179, 2190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 2461, 2480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 3014, 3074);

                f_563_3014_3073(keyContainerName == null || (DynAbs.Tracing.TraceSender.Expression_False(563, 3027, 3072) || keyPair.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 3088, 3143);

                f_563_3088_3142(keyPair.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(563, 3101, 3141) || keyFilePath != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 3159, 3182);

                this.KeyPair = keyPair;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 3196, 3223);

                this.PublicKey = publicKey;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 3237, 3266);

                this.PrivateKey = privateKey;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 3280, 3317);

                this.KeyContainer = keyContainerName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 3331, 3362);

                this.KeyFilePath = keyFilePath;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 3376, 3423);

                this.HasCounterSignature = hasCounterSignature;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(563, 2804, 3434);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(563, 2804, 3434);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(563, 2804, 3434);
            }
        }

        internal static StrongNameKeys Create(ImmutableArray<byte> publicKey, RSAParameters? privateKey, bool hasCounterSignature, CommonMessageProvider messageProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(563, 3446, 4225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 3632, 3674);

                f_563_3632_3673(f_563_3645_3672_M(!publicKey.IsDefaultOrEmpty));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 3690, 4214) || true) && (f_563_3694_3737(publicKey))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(563, 3690, 4214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 3771, 3902);

                    return f_563_3778_3901(keyPair: default, publicKey, privateKey, keyContainerName: null, keyFilePath: null, hasCounterSignature);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(563, 3690, 4214);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(563, 3690, 4214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 3968, 4199);

                    return f_563_3975_4198(f_563_3994_4197(messageProvider, f_563_4027_4072(messageProvider), f_563_4074_4087(), nameof(CompilationOptions.CryptoPublicKey), f_563_4154_4196(publicKey.ToArray())));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(563, 3690, 4214);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(563, 3446, 4225);

                bool
                f_563_3645_3672_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(563, 3645, 3672);
                    return return_v;
                }


                int
                f_563_3632_3673(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 3632, 3673);
                    return 0;
                }


                bool
                f_563_3694_3737(System.Collections.Immutable.ImmutableArray<byte>
                bytes)
                {
                    var return_v = MetadataHelpers.IsValidPublicKey(bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 3694, 3737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_563_3778_3901(System.Collections.Immutable.ImmutableArray<byte>
                keyPair, System.Collections.Immutable.ImmutableArray<byte>
                publicKey, System.Security.Cryptography.RSAParameters?
                privateKey, string?
                keyContainerName, string?
                keyFilePath, bool
                hasCounterSignature)
                {
                    var return_v = new Microsoft.CodeAnalysis.StrongNameKeys(keyPair: keyPair, publicKey, privateKey, keyContainerName: keyContainerName, keyFilePath: keyFilePath, hasCounterSignature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 3778, 3901);
                    return return_v;
                }


                int
                f_563_4027_4072(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_BadCompilationOptionValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(563, 4027, 4072);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_563_4074_4087()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(563, 4074, 4087);
                    return return_v;
                }


                string
                f_563_4154_4196(byte[]
                value)
                {
                    var return_v = BitConverter.ToString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 4154, 4196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_563_3994_4197(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 3994, 4197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_563_3975_4198(Microsoft.CodeAnalysis.Diagnostic
                diagnostic)
                {
                    var return_v = new Microsoft.CodeAnalysis.StrongNameKeys(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 3975, 4198);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(563, 3446, 4225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(563, 3446, 4225);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static StrongNameKeys Create(string? keyFilePath, CommonMessageProvider messageProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(563, 4237, 4868);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 4359, 4457) || true) && (f_563_4363_4396(keyFilePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(563, 4359, 4457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 4430, 4442);

                    return None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(563, 4359, 4457);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 4509, 4581);

                    var
                    fileContent = f_563_4527_4580(f_563_4549_4579(keyFilePath))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 4599, 4673);

                    return f_563_4606_4672(fileContent, keyFilePath, hasCounterSignature: false);
                }
                catch (IOException ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(563, 4702, 4857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 4757, 4842);

                    return f_563_4764_4841(f_563_4783_4840(messageProvider, keyFilePath, f_563_4829_4839(ex)));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(563, 4702, 4857);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(563, 4237, 4868);

                bool
                f_563_4363_4396(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 4363, 4396);
                    return return_v;
                }


                byte[]
                f_563_4549_4579(string
                path)
                {
                    var return_v = File.ReadAllBytes(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 4549, 4579);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_563_4527_4580(params byte[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 4527, 4580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_563_4606_4672(System.Collections.Immutable.ImmutableArray<byte>
                keyFileContent, string
                keyFilePath, bool
                hasCounterSignature)
                {
                    var return_v = CreateHelper(keyFileContent, keyFilePath, hasCounterSignature: hasCounterSignature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 4606, 4672);
                    return return_v;
                }


                string
                f_563_4829_4839(System.IO.IOException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(563, 4829, 4839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_563_4783_4840(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, string
                path, string
                message)
                {
                    var return_v = GetKeyFileError(messageProvider, path, (object)message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 4783, 4840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_563_4764_4841(Microsoft.CodeAnalysis.Diagnostic
                diagnostic)
                {
                    var return_v = new Microsoft.CodeAnalysis.StrongNameKeys(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 4764, 4841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(563, 4237, 4868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(563, 4237, 4868);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Tuple<ImmutableArray<byte>, ImmutableArray<byte>, RSAParameters?>? s_lastSeenKeyPair;

        internal static StrongNameKeys CreateHelper(ImmutableArray<byte> keyFileContent, string keyFilePath, bool hasCounterSignature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(563, 5344, 6928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 5495, 5524);

                ImmutableArray<byte>
                keyPair
                = default(ImmutableArray<byte>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 5538, 5569);

                ImmutableArray<byte>
                publicKey
                = default(ImmutableArray<byte>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 5583, 5616);

                RSAParameters?
                privateKey = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 5673, 5711);

                var
                cachedKeyPair = s_lastSeenKeyPair
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 5725, 6803) || true) && (cachedKeyPair != null && (DynAbs.Tracing.TraceSender.Expression_True(563, 5729, 5791) && keyFileContent == f_563_5772_5791(cachedKeyPair)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(563, 5725, 6803);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 5825, 5855);

                    keyPair = f_563_5835_5854(cachedKeyPair);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 5873, 5905);

                    publicKey = f_563_5885_5904(cachedKeyPair);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 5923, 5956);

                    privateKey = f_563_5936_5955(cachedKeyPair);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(563, 5725, 6803);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(563, 5725, 6803);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 6022, 6534) || true) && (f_563_6026_6074(keyFileContent))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(563, 6022, 6534);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 6116, 6143);

                        publicKey = keyFileContent;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 6165, 6183);

                        keyPair = default;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(563, 6022, 6534);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(563, 6022, 6534);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 6225, 6534) || true) && (f_563_6229_6304(keyFileContent, out publicKey, out privateKey))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(563, 6225, 6534);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 6346, 6371);

                            keyPair = keyFileContent;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(563, 6225, 6534);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(563, 6225, 6534);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 6453, 6515);

                            throw f_563_6459_6514(f_563_6475_6513());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(563, 6225, 6534);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(563, 6022, 6534);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 6593, 6711);

                    cachedKeyPair = f_563_6609_6710(keyPair, publicKey, privateKey);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 6729, 6788);

                    f_563_6729_6787(ref s_lastSeenKeyPair, cachedKeyPair);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(563, 5725, 6803);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 6819, 6917);

                return f_563_6826_6916(keyPair, publicKey, privateKey, null, keyFilePath, hasCounterSignature);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(563, 5344, 6928);

                System.Collections.Immutable.ImmutableArray<byte>
                f_563_5772_5791(System.Tuple<System.Collections.Immutable.ImmutableArray<byte>, System.Collections.Immutable.ImmutableArray<byte>, System.Security.Cryptography.RSAParameters?>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(563, 5772, 5791);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_563_5835_5854(System.Tuple<System.Collections.Immutable.ImmutableArray<byte>, System.Collections.Immutable.ImmutableArray<byte>, System.Security.Cryptography.RSAParameters?>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(563, 5835, 5854);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_563_5885_5904(System.Tuple<System.Collections.Immutable.ImmutableArray<byte>, System.Collections.Immutable.ImmutableArray<byte>, System.Security.Cryptography.RSAParameters?>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(563, 5885, 5904);
                    return return_v;
                }


                System.Security.Cryptography.RSAParameters?
                f_563_5936_5955(System.Tuple<System.Collections.Immutable.ImmutableArray<byte>, System.Collections.Immutable.ImmutableArray<byte>, System.Security.Cryptography.RSAParameters?>
                this_param)
                {
                    var return_v = this_param.Item3;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(563, 5936, 5955);
                    return return_v;
                }


                bool
                f_563_6026_6074(System.Collections.Immutable.ImmutableArray<byte>
                bytes)
                {
                    var return_v = MetadataHelpers.IsValidPublicKey(bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 6026, 6074);
                    return return_v;
                }


                bool
                f_563_6229_6304(System.Collections.Immutable.ImmutableArray<byte>
                blob, out System.Collections.Immutable.ImmutableArray<byte>
                snKey, out System.Security.Cryptography.RSAParameters?
                privateKey)
                {
                    var return_v = CryptoBlobParser.TryParseKey(blob, out snKey, out privateKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 6229, 6304);
                    return return_v;
                }


                string
                f_563_6475_6513()
                {
                    var return_v = CodeAnalysisResources.InvalidPublicKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(563, 6475, 6513);
                    return return_v;
                }


                System.IO.IOException
                f_563_6459_6514(string
                message)
                {
                    var return_v = new System.IO.IOException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 6459, 6514);
                    return return_v;
                }


                System.Tuple<System.Collections.Immutable.ImmutableArray<byte>, System.Collections.Immutable.ImmutableArray<byte>, System.Security.Cryptography.RSAParameters?>
                f_563_6609_6710(System.Collections.Immutable.ImmutableArray<byte>
                item1, System.Collections.Immutable.ImmutableArray<byte>
                item2, System.Security.Cryptography.RSAParameters?
                item3)
                {
                    var return_v = new System.Tuple<System.Collections.Immutable.ImmutableArray<byte>, System.Collections.Immutable.ImmutableArray<byte>, System.Security.Cryptography.RSAParameters?>(item1, item2, item3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 6609, 6710);
                    return return_v;
                }


                System.Tuple<System.Collections.Immutable.ImmutableArray<byte>, System.Collections.Immutable.ImmutableArray<byte>, System.Security.Cryptography.RSAParameters?>?
                f_563_6729_6787(ref System.Tuple<System.Collections.Immutable.ImmutableArray<byte>, System.Collections.Immutable.ImmutableArray<byte>, System.Security.Cryptography.RSAParameters?>?
                location1, System.Tuple<System.Collections.Immutable.ImmutableArray<byte>, System.Collections.Immutable.ImmutableArray<byte>, System.Security.Cryptography.RSAParameters?>
                value)
                {
                    var return_v = Interlocked.Exchange(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 6729, 6787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_563_6826_6916(System.Collections.Immutable.ImmutableArray<byte>
                keyPair, System.Collections.Immutable.ImmutableArray<byte>
                publicKey, System.Security.Cryptography.RSAParameters?
                privateKey, string?
                keyContainerName, string
                keyFilePath, bool
                hasCounterSignature)
                {
                    var return_v = new Microsoft.CodeAnalysis.StrongNameKeys(keyPair, publicKey, privateKey, keyContainerName, keyFilePath, hasCounterSignature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 6826, 6916);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(563, 5344, 6928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(563, 5344, 6928);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static StrongNameKeys Create(StrongNameProvider? providerOpt, string? keyFilePath, string? keyContainerName, bool hasCounterSignature, CommonMessageProvider messageProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(563, 6940, 7741);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 7147, 7287) || true) && (f_563_7151_7184(keyFilePath) && (DynAbs.Tracing.TraceSender.Expression_True(563, 7151, 7226) && f_563_7188_7226(keyContainerName)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(563, 7147, 7287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 7260, 7272);

                    return None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(563, 7147, 7287);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 7303, 7615) || true) && (providerOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(563, 7303, 7615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 7360, 7544);

                    var
                    diagnostic = f_563_7377_7543(keyFilePath, keyContainerName, f_563_7417_7525(nameof(CodeAnalysisResources.AssemblySigningNotSupported)), messageProvider)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 7562, 7600);

                    return f_563_7569_7599(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(563, 7303, 7615);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 7631, 7730);

                return f_563_7638_7729(providerOpt, keyFilePath, keyContainerName, hasCounterSignature, messageProvider);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(563, 6940, 7741);

                bool
                f_563_7151_7184(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 7151, 7184);
                    return return_v;
                }


                bool
                f_563_7188_7226(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 7188, 7226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeAnalysisResourcesLocalizableErrorArgument
                f_563_7417_7525(string
                targetResourceId)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeAnalysisResourcesLocalizableErrorArgument(targetResourceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 7417, 7525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_563_7377_7543(string?
                keyFilePath, string?
                keyContainerName, Microsoft.CodeAnalysis.CodeAnalysisResourcesLocalizableErrorArgument
                message, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider)
                {
                    var return_v = GetError(keyFilePath, keyContainerName, (object)message, messageProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 7377, 7543);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_563_7569_7599(Microsoft.CodeAnalysis.Diagnostic
                diagnostic)
                {
                    var return_v = new Microsoft.CodeAnalysis.StrongNameKeys(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 7569, 7599);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_563_7638_7729(Microsoft.CodeAnalysis.StrongNameProvider
                this_param, string?
                keyFilePath, string?
                keyContainerName, bool
                hasCounterSignature, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider)
                {
                    var return_v = this_param.CreateKeys(keyFilePath, keyContainerName, hasCounterSignature, messageProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 7638, 7729);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(563, 6940, 7741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(563, 6940, 7741);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool CanSign
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(563, 7915, 8016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 7951, 8001);

                    return f_563_7958_7976_M(!KeyPair.IsDefault) || (DynAbs.Tracing.TraceSender.Expression_False(563, 7958, 8000) || KeyContainer != null);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(563, 7915, 8016);

                    bool
                    f_563_7958_7976_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(563, 7958, 7976);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(563, 7869, 8027);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(563, 7869, 8027);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool CanProvideStrongName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(563, 8233, 8323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 8269, 8308);

                    return f_563_8276_8283() || (DynAbs.Tracing.TraceSender.Expression_False(563, 8276, 8307) || f_563_8287_8307_M(!PublicKey.IsDefault));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(563, 8233, 8323);

                    bool
                    f_563_8276_8283()
                    {
                        var return_v = CanSign;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(563, 8276, 8283);
                        return return_v;
                    }


                    bool
                    f_563_8287_8307_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(563, 8287, 8307);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(563, 8174, 8334);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(563, 8174, 8334);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static Diagnostic GetError(string? keyFilePath, string? keyContainerName, object message, CommonMessageProvider messageProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(563, 8346, 8847);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 8508, 8836) || true) && (keyContainerName != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(563, 8508, 8836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 8570, 8639);

                    return f_563_8577_8638(messageProvider, keyContainerName, message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(563, 8508, 8836);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(563, 8508, 8836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 8705, 8741);

                    f_563_8705_8740(keyFilePath is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 8759, 8821);

                    return f_563_8766_8820(messageProvider, keyFilePath, message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(563, 8508, 8836);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(563, 8346, 8847);

                Microsoft.CodeAnalysis.Diagnostic
                f_563_8577_8638(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, string
                name, object
                message)
                {
                    var return_v = GetContainerError(messageProvider, name, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 8577, 8638);
                    return return_v;
                }


                int
                f_563_8705_8740(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 8705, 8740);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_563_8766_8820(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, string
                path, object
                message)
                {
                    var return_v = GetKeyFileError(messageProvider, path, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 8766, 8820);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(563, 8346, 8847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(563, 8346, 8847);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Diagnostic GetContainerError(CommonMessageProvider messageProvider, string name, object message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(563, 8859, 9124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 8996, 9113);

                return f_563_9003_9112(messageProvider, f_563_9036_9081(messageProvider), f_563_9083_9096(), name, message);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(563, 8859, 9124);

                int
                f_563_9036_9081(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_PublicKeyContainerFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(563, 9036, 9081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_563_9083_9096()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(563, 9083, 9096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_563_9003_9112(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 9003, 9112);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(563, 8859, 9124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(563, 8859, 9124);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Diagnostic GetKeyFileError(CommonMessageProvider messageProvider, string path, object message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(563, 9136, 9394);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 9271, 9383);

                return f_563_9278_9382(messageProvider, f_563_9311_9351(messageProvider), f_563_9353_9366(), path, message);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(563, 9136, 9394);

                int
                f_563_9311_9351(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_PublicKeyFileFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(563, 9311, 9351);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_563_9353_9366()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(563, 9353, 9366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_563_9278_9382(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 9278, 9382);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(563, 9136, 9394);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(563, 9136, 9394);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsValidPublicKeyString(string? publicKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(563, 9406, 9948);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 9493, 9619) || true) && (f_563_9497_9528(publicKey) || (DynAbs.Tracing.TraceSender.Expression_False(563, 9497, 9557) || f_563_9532_9548(publicKey) % 2 != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(563, 9493, 9619);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 9591, 9604);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(563, 9493, 9619);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 9635, 9909);
                    foreach (char c in f_563_9654_9663_I(publicKey))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(563, 9635, 9909);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 9697, 9894) || true) && (!(c >= '0' && (DynAbs.Tracing.TraceSender.Expression_True(563, 9703, 9723) && c <= '9')) && (DynAbs.Tracing.TraceSender.Expression_True(563, 9701, 9772) && !(c >= 'a' && (DynAbs.Tracing.TraceSender.Expression_True(563, 9751, 9771) && c <= 'f'))) && (DynAbs.Tracing.TraceSender.Expression_True(563, 9701, 9820) && !(c >= 'A' && (DynAbs.Tracing.TraceSender.Expression_True(563, 9799, 9819) && c <= 'F'))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(563, 9697, 9894);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 9862, 9875);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(563, 9697, 9894);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(563, 9635, 9909);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(563, 1, 275);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(563, 1, 275);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 9925, 9937);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(563, 9406, 9948);

                bool
                f_563_9497_9528(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 9497, 9528);
                    return return_v;
                }


                int
                f_563_9532_9548(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(563, 9532, 9548);
                    return return_v;
                }


                string
                f_563_9654_9663_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 9654, 9663);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(563, 9406, 9948);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(563, 9406, 9948);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static StrongNameKeys()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(563, 430, 9955);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 2533, 2560);
            None = f_563_2540_2560(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(563, 5249, 5266);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(563, 430, 9955);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(563, 430, 9955);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(563, 430, 9955);

        static Microsoft.CodeAnalysis.StrongNameKeys
        f_563_2540_2560()
        {
            var return_v = new Microsoft.CodeAnalysis.StrongNameKeys();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 2540, 2560);
            return return_v;
        }


        static int
        f_563_2702_2734(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 2702, 2734);
            return 0;
        }


        static int
        f_563_3014_3073(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 3014, 3073);
            return 0;
        }


        static int
        f_563_3088_3142(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(563, 3088, 3142);
            return 0;
        }

    }
}
