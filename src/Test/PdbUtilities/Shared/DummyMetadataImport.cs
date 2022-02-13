// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using Microsoft.DiaSymReader.PortablePdb;
using System.Reflection;

namespace Roslyn.Test.PdbUtilities
{
    internal sealed class DummyMetadataImport : IMetadataImport, IDisposable
    {
        private readonly MetadataReader _metadataReaderOpt;

        private readonly IDisposable _metadataOwnerOpt;

        private readonly List<GCHandle> _pinnedBuffers;

        public DummyMetadataImport(MetadataReader metadataReaderOpt, IDisposable metadataOwnerOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(24011, 814, 1082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 669, 687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 727, 744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 787, 801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 929, 968);

                _metadataReaderOpt = metadataReaderOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 982, 1020);

                _pinnedBuffers = f_24011_999_1019();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 1034, 1071);

                _metadataOwnerOpt = metadataOwnerOpt;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(24011, 814, 1082);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 814, 1082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 814, 1082);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 1094, 1205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 1140, 1166);

                f_24011_1140_1165(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 1180, 1194);

                f_24011_1180_1193(this, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 1094, 1205);

                int
                f_24011_1140_1165(Roslyn.Test.PdbUtilities.DummyMetadataImport
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 1140, 1165);
                    return 0;
                }


                int
                f_24011_1180_1193(Roslyn.Test.PdbUtilities.DummyMetadataImport
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 1180, 1193);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 1094, 1205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 1094, 1205);
            }
        }

        private void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 1217, 1446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 1278, 1307);

                f_24011_1296_1306(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_metadataOwnerOpt, 24011, 1278, 1306));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 1323, 1435);
                    foreach (var pinnedBuffer in f_24011_1352_1366_I(_pinnedBuffers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24011, 1323, 1435);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 1400, 1420);

                        pinnedBuffer.Free();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24011, 1323, 1435);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(24011, 1, 113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(24011, 1, 113);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 1217, 1446);

                int
                f_24011_1296_1306(System.IDisposable
                this_param)
                {
                    this_param?.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 1296, 1306);
                    return 0;
                }


                System.Collections.Generic.List<System.Runtime.InteropServices.GCHandle>
                f_24011_1352_1366_I(System.Collections.Generic.List<System.Runtime.InteropServices.GCHandle>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 1352, 1366);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 1217, 1446);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 1217, 1446);
            }
        }

        ~DummyMetadataImport()
        {
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 1505, 1520);

            f_24011_1505_1519(this, false);
        }

        [PreserveSig]
        public unsafe int GetSigFromToken(
                    int tkSignature,    // Signature token.
                    out byte* ppvSig,   // return pointer to signature blob
                    out int pcbSig)     // return size of signature
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 1543, 2533);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 1808, 1945) || true) && (_metadataReaderOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24011, 1808, 1945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 1872, 1930);

                    throw f_24011_1878_1929("Metadata not available");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24011, 1808, 1945);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 1961, 2076);

                var
                sig = f_24011_1971_2075(_metadataReaderOpt, f_24011_2040_2074(tkSignature))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 2090, 2153);

                var
                signature = f_24011_2106_2152(_metadataReaderOpt, sig.Signature)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 2169, 2240);

                GCHandle
                pinnedBuffer = GCHandle.Alloc(signature, GCHandleType.Pinned)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 2254, 2304);

                ppvSig = (byte*)pinnedBuffer.AddrOfPinnedObject();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 2318, 2344);

                pcbSig = f_24011_2327_2343(signature);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 2413, 2446);

                f_24011_2413_2445(
#pragma warning disable RS0042 // Do not copy value
            _pinnedBuffers, pinnedBuffer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 2513, 2522);

                return 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 1543, 2533);

                System.NotSupportedException
                f_24011_1878_1929(string
                message)
                {
                    var return_v = new System.NotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 1878, 1929);
                    return return_v;
                }


                System.Reflection.Metadata.Handle
                f_24011_2040_2074(int
                token)
                {
                    var return_v = MetadataTokens.Handle(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 2040, 2074);
                    return return_v;
                }


                System.Reflection.Metadata.StandaloneSignature
                f_24011_1971_2075(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.Handle
                handle)
                {
                    var return_v = this_param.GetStandaloneSignature((System.Reflection.Metadata.StandaloneSignatureHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 1971, 2075);
                    return return_v;
                }


                byte[]
                f_24011_2106_2152(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobBytes(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 2106, 2152);
                    return return_v;
                }


                int
                f_24011_2327_2343(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24011, 2327, 2343);
                    return return_v;
                }


                int
                f_24011_2413_2445(System.Collections.Generic.List<System.Runtime.InteropServices.GCHandle>
                this_param, System.Runtime.InteropServices.GCHandle
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 2413, 2445);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 1543, 2533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 1543, 2533);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void GetTypeDefProps(
                    int typeDefinition,
                    [MarshalAs(UnmanagedType.LPWStr), Out] StringBuilder qualifiedName,
                    int qualifiedNameBufferLength,
                    out int qualifiedNameLength,
                    [MarshalAs(UnmanagedType.U4)] out TypeAttributes attributes,
                    out int baseType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 2545, 4086);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 2903, 3040) || true) && (_metadataReaderOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24011, 2903, 3040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 2967, 3025);

                    throw f_24011_2973_3024("Metadata not available");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24011, 2903, 3040);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 3056, 3129);

                var
                handle = (TypeDefinitionHandle)f_24011_3091_3128(typeDefinition)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 3143, 3202);

                var
                typeDef = f_24011_3157_3201(_metadataReaderOpt, handle)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 3218, 3960) || true) && (qualifiedName != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24011, 3218, 3960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 3277, 3299);

                    f_24011_3277_3298(qualifiedName);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 3319, 3526) || true) && (f_24011_3323_3347_M(!typeDef.Namespace.IsNil))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24011, 3319, 3526);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 3389, 3459);

                        f_24011_3389_3458(qualifiedName, f_24011_3410_3457(_metadataReaderOpt, typeDef.Namespace));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 3481, 3507);

                        f_24011_3481_3506(qualifiedName, '.');
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24011, 3319, 3526);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 3546, 3611);

                    f_24011_3546_3610(
                                    qualifiedName, f_24011_3567_3609(_metadataReaderOpt, typeDef.Name));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 3629, 3672);

                    qualifiedNameLength = f_24011_3651_3671(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24011, 3218, 3960);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24011, 3218, 3960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 3738, 3945);

                    qualifiedNameLength =
                                        ((DynAbs.Tracing.TraceSender.Conditional_F1(24011, 3782, 3805) || ((typeDef.Namespace.IsNil && DynAbs.Tracing.TraceSender.Conditional_F2(24011, 3808, 3809)) || DynAbs.Tracing.TraceSender.Conditional_F3(24011, 3812, 3870))) ? 0 : f_24011_3812_3866(f_24011_3812_3859(_metadataReaderOpt, typeDef.Namespace)) + 1) +
                    f_24011_3895_3944(f_24011_3895_3937(_metadataReaderOpt, typeDef.Name));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24011, 3218, 3960);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 3976, 4029);

                baseType = f_24011_3987_4028(typeDef.BaseType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 4043, 4075);

                attributes = typeDef.Attributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 2545, 4086);

                System.NotSupportedException
                f_24011_2973_3024(string
                message)
                {
                    var return_v = new System.NotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 2973, 3024);
                    return return_v;
                }


                System.Reflection.Metadata.Handle
                f_24011_3091_3128(int
                token)
                {
                    var return_v = MetadataTokens.Handle(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 3091, 3128);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_24011_3157_3201(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 3157, 3201);
                    return return_v;
                }


                System.Text.StringBuilder
                f_24011_3277_3298(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 3277, 3298);
                    return return_v;
                }


                bool
                f_24011_3323_3347_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24011, 3323, 3347);
                    return return_v;
                }


                string
                f_24011_3410_3457(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 3410, 3457);
                    return return_v;
                }


                System.Text.StringBuilder
                f_24011_3389_3458(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 3389, 3458);
                    return return_v;
                }


                System.Text.StringBuilder
                f_24011_3481_3506(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 3481, 3506);
                    return return_v;
                }


                string
                f_24011_3567_3609(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 3567, 3609);
                    return return_v;
                }


                System.Text.StringBuilder
                f_24011_3546_3610(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 3546, 3610);
                    return return_v;
                }


                int
                f_24011_3651_3671(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24011, 3651, 3671);
                    return return_v;
                }


                string
                f_24011_3812_3859(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 3812, 3859);
                    return return_v;
                }


                int
                f_24011_3812_3866(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24011, 3812, 3866);
                    return return_v;
                }


                string
                f_24011_3895_3937(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 3895, 3937);
                    return return_v;
                }


                int
                f_24011_3895_3944(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24011, 3895, 3944);
                    return return_v;
                }


                int
                f_24011_3987_4028(System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = MetadataTokens.GetToken(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 3987, 4028);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 2545, 4086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 2545, 4086);
            }
        }

        public void GetTypeRefProps(
                    int typeReference,
                    out int resolutionScope,
                    [MarshalAs(UnmanagedType.LPWStr), Out] StringBuilder qualifiedName,
                    int qualifiedNameBufferLength,
                    out int qualifiedNameLength)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 4098, 5536);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 4388, 4525) || true) && (_metadataReaderOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24011, 4388, 4525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 4452, 4510);

                    throw f_24011_4458_4509("Metadata not available");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24011, 4388, 4525);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 4541, 4612);

                var
                handle = (TypeReferenceHandle)f_24011_4575_4611(typeReference)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 4626, 4684);

                var
                typeRef = f_24011_4640_4683(_metadataReaderOpt, handle)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 4700, 5442) || true) && (qualifiedName != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24011, 4700, 5442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 4759, 4781);

                    f_24011_4759_4780(qualifiedName);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 4801, 5008) || true) && (f_24011_4805_4829_M(!typeRef.Namespace.IsNil))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24011, 4801, 5008);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 4871, 4941);

                        f_24011_4871_4940(qualifiedName, f_24011_4892_4939(_metadataReaderOpt, typeRef.Namespace));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 4963, 4989);

                        f_24011_4963_4988(qualifiedName, '.');
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24011, 4801, 5008);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 5028, 5093);

                    f_24011_5028_5092(
                                    qualifiedName, f_24011_5049_5091(_metadataReaderOpt, typeRef.Name));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 5111, 5154);

                    qualifiedNameLength = f_24011_5133_5153(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24011, 4700, 5442);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24011, 4700, 5442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 5220, 5427);

                    qualifiedNameLength =
                                        ((DynAbs.Tracing.TraceSender.Conditional_F1(24011, 5264, 5287) || ((typeRef.Namespace.IsNil && DynAbs.Tracing.TraceSender.Conditional_F2(24011, 5290, 5291)) || DynAbs.Tracing.TraceSender.Conditional_F3(24011, 5294, 5352))) ? 0 : f_24011_5294_5348(f_24011_5294_5341(_metadataReaderOpt, typeRef.Namespace)) + 1) +
                    f_24011_5377_5426(f_24011_5377_5419(_metadataReaderOpt, typeRef.Name));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24011, 4700, 5442);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 5458, 5525);

                resolutionScope = f_24011_5476_5524(typeRef.ResolutionScope);
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 4098, 5536);

                System.NotSupportedException
                f_24011_4458_4509(string
                message)
                {
                    var return_v = new System.NotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 4458, 4509);
                    return return_v;
                }


                System.Reflection.Metadata.Handle
                f_24011_4575_4611(int
                token)
                {
                    var return_v = MetadataTokens.Handle(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 4575, 4611);
                    return return_v;
                }


                System.Reflection.Metadata.TypeReference
                f_24011_4640_4683(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeReferenceHandle
                handle)
                {
                    var return_v = this_param.GetTypeReference(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 4640, 4683);
                    return return_v;
                }


                System.Text.StringBuilder
                f_24011_4759_4780(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 4759, 4780);
                    return return_v;
                }


                bool
                f_24011_4805_4829_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24011, 4805, 4829);
                    return return_v;
                }


                string
                f_24011_4892_4939(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 4892, 4939);
                    return return_v;
                }


                System.Text.StringBuilder
                f_24011_4871_4940(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 4871, 4940);
                    return return_v;
                }


                System.Text.StringBuilder
                f_24011_4963_4988(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 4963, 4988);
                    return return_v;
                }


                string
                f_24011_5049_5091(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 5049, 5091);
                    return return_v;
                }


                System.Text.StringBuilder
                f_24011_5028_5092(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 5028, 5092);
                    return return_v;
                }


                int
                f_24011_5133_5153(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24011, 5133, 5153);
                    return return_v;
                }


                string
                f_24011_5294_5341(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 5294, 5341);
                    return return_v;
                }


                int
                f_24011_5294_5348(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24011, 5294, 5348);
                    return return_v;
                }


                string
                f_24011_5377_5419(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 5377, 5419);
                    return return_v;
                }


                int
                f_24011_5377_5426(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(24011, 5377, 5426);
                    return return_v;
                }


                int
                f_24011_5476_5524(System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = MetadataTokens.GetToken(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 5476, 5524);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 4098, 5536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 4098, 5536);
            }
        }

        public void CloseEnum(uint handleEnum)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 5583, 5693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 5646, 5682);

                throw f_24011_5652_5681();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 5583, 5693);

                System.NotImplementedException
                f_24011_5652_5681()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 5652, 5681);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 5583, 5693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 5583, 5693);
            }
        }

        public uint CountEnum(uint handleEnum)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 5705, 5815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 5768, 5804);

                throw f_24011_5774_5803();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 5705, 5815);

                System.NotImplementedException
                f_24011_5774_5803()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 5774, 5803);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 5705, 5815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 5705, 5815);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint EnumCustomAttributes(ref uint handlePointerEnum, uint tk, uint tokenType, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] uint[] arrayCustomAttributes, uint countMax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 5827, 6084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 6037, 6073);

                throw f_24011_6043_6072();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 5827, 6084);

                System.NotImplementedException
                f_24011_6043_6072()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 6043, 6072);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 5827, 6084);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 5827, 6084);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public unsafe uint EnumEvents(ref uint handlePointerEnum, uint td, uint* arrayEvents, uint countMax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 6096, 6268);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 6221, 6257);

                throw f_24011_6227_6256();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 6096, 6268);

                System.NotImplementedException
                f_24011_6227_6256()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 6227, 6256);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 6096, 6268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 6096, 6268);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public unsafe uint EnumFields(ref uint handlePointerEnum, uint cl, uint* arrayFields, uint countMax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 6280, 6452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 6405, 6441);

                throw f_24011_6411_6440();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 6280, 6452);

                System.NotImplementedException
                f_24011_6411_6440()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 6411, 6440);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 6280, 6452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 6280, 6452);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint EnumFieldsWithName(ref uint handlePointerEnum, uint cl, string stringName, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] uint[] arrayFields, uint countMax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 6464, 6712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 6665, 6701);

                throw f_24011_6671_6700();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 6464, 6712);

                System.NotImplementedException
                f_24011_6671_6700()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 6671, 6700);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 6464, 6712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 6464, 6712);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint EnumInterfaceImpls(ref uint handlePointerEnum, uint td, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] uint[] arrayImpls, uint countMax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 6724, 6952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 6905, 6941);

                throw f_24011_6911_6940();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 6724, 6952);

                System.NotImplementedException
                f_24011_6911_6940()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 6911, 6940);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 6724, 6952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 6724, 6952);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint EnumMemberRefs(ref uint handlePointerEnum, uint tokenParent, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] uint[] arrayMemberRefs, uint countMax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 6964, 7202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 7155, 7191);

                throw f_24011_7161_7190();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 6964, 7202);

                System.NotImplementedException
                f_24011_7161_7190()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 7161, 7190);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 6964, 7202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 6964, 7202);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint EnumMembers(ref uint handlePointerEnum, uint cl, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] uint[] arrayMembers, uint countMax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 7214, 7437);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 7390, 7426);

                throw f_24011_7396_7425();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 7214, 7437);

                System.NotImplementedException
                f_24011_7396_7425()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 7396, 7425);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 7214, 7437);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 7214, 7437);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint EnumMembersWithName(ref uint handlePointerEnum, uint cl, string stringName, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] uint[] arrayMembers, uint countMax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 7449, 7699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 7652, 7688);

                throw f_24011_7658_7687();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 7449, 7699);

                System.NotImplementedException
                f_24011_7658_7687()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 7658, 7687);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 7449, 7699);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 7449, 7699);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint EnumMethodImpls(ref uint handlePointerEnum, uint td, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] uint[] arrayMethodBody, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] uint[] arrayMethodDecl, uint countMax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 7711, 8020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 7973, 8009);

                throw f_24011_7979_8008();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 7711, 8020);

                System.NotImplementedException
                f_24011_7979_8008()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 7979, 8008);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 7711, 8020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 7711, 8020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public unsafe uint EnumMethods(ref uint handlePointerEnum, uint cl, uint* arrayMethods, uint countMax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 8032, 8206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 8159, 8195);

                throw f_24011_8165_8194();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 8032, 8206);

                System.NotImplementedException
                f_24011_8165_8194()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 8165, 8194);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 8032, 8206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 8032, 8206);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint EnumMethodSemantics(ref uint handlePointerEnum, uint mb, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] uint[] arrayEventProp, uint countMax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 8218, 8451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 8404, 8440);

                throw f_24011_8410_8439();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 8218, 8451);

                System.NotImplementedException
                f_24011_8410_8439()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 8410, 8439);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 8218, 8451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 8218, 8451);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint EnumMethodsWithName(ref uint handlePointerEnum, uint cl, string stringName, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] uint[] arrayMethods, uint countMax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 8463, 8713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 8666, 8702);

                throw f_24011_8672_8701();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 8463, 8713);

                System.NotImplementedException
                f_24011_8672_8701()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 8672, 8701);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 8463, 8713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 8463, 8713);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint EnumModuleRefs(ref uint handlePointerEnum, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] uint[] arrayModuleRefs, uint cmax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 8725, 8941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 8894, 8930);

                throw f_24011_8900_8929();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 8725, 8941);

                System.NotImplementedException
                f_24011_8900_8929()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 8900, 8929);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 8725, 8941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 8725, 8941);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint EnumParams(ref uint handlePointerEnum, uint mb, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] uint[] arrayParams, uint countMax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 8953, 9174);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 9127, 9163);

                throw f_24011_9133_9162();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 8953, 9174);

                System.NotImplementedException
                f_24011_9133_9162()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 9133, 9162);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 8953, 9174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 8953, 9174);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint EnumPermissionSets(ref uint handlePointerEnum, uint tk, uint dwordActions, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] uint[] arrayPermission, uint countMax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 9186, 9438);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 9391, 9427);

                throw f_24011_9397_9426();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 9186, 9438);

                System.NotImplementedException
                f_24011_9397_9426()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 9397, 9426);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 9186, 9438);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 9186, 9438);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public unsafe uint EnumProperties(ref uint handlePointerEnum, uint td, uint* arrayProperties, uint countMax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 9450, 9630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 9583, 9619);

                throw f_24011_9589_9618();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 9450, 9630);

                System.NotImplementedException
                f_24011_9589_9618()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 9589, 9618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 9450, 9630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 9450, 9630);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint EnumSignatures(ref uint handlePointerEnum, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] uint[] arraySignatures, uint cmax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 9642, 9858);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 9811, 9847);

                throw f_24011_9817_9846();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 9642, 9858);

                System.NotImplementedException
                f_24011_9817_9846()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 9817, 9846);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 9642, 9858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 9642, 9858);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint EnumTypeDefs(ref uint handlePointerEnum, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] uint[] arrayTypeDefs, uint countMax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 9870, 10086);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 10039, 10075);

                throw f_24011_10045_10074();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 9870, 10086);

                System.NotImplementedException
                f_24011_10045_10074()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 10045, 10074);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 9870, 10086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 9870, 10086);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint EnumTypeRefs(ref uint handlePointerEnum, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] uint[] arrayTypeRefs, uint countMax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 10098, 10314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 10267, 10303);

                throw f_24011_10273_10302();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 10098, 10314);

                System.NotImplementedException
                f_24011_10273_10302()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 10273, 10302);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 10098, 10314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 10098, 10314);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint EnumTypeSpecs(ref uint handlePointerEnum, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] uint[] arrayTypeSpecs, uint cmax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 10326, 10540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 10493, 10529);

                throw f_24011_10499_10528();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 10326, 10540);

                System.NotImplementedException
                f_24011_10499_10528()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 10499, 10528);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 10326, 10540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 10326, 10540);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint EnumUnresolvedMethods(ref uint handlePointerEnum, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] uint[] arrayMethods, uint countMax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 10552, 10776);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 10729, 10765);

                throw f_24011_10735_10764();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 10552, 10776);

                System.NotImplementedException
                f_24011_10735_10764()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 10735, 10764);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 10552, 10776);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 10552, 10776);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint EnumUserStrings(ref uint handlePointerEnum, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] uint[] arrayStrings, uint cmax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 10788, 11002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 10955, 10991);

                throw f_24011_10961_10990();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 10788, 11002);

                System.NotImplementedException
                f_24011_10961_10990()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 10961, 10990);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 10788, 11002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 10788, 11002);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint FindField(uint td, string stringName, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] voidPointerSigBlob, uint byteCountSigBlob)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 11014, 11240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 11193, 11229);

                throw f_24011_11199_11228();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 11014, 11240);

                System.NotImplementedException
                f_24011_11199_11228()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 11199, 11228);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 11014, 11240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 11014, 11240);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint FindMember(uint td, string stringName, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] voidPointerSigBlob, uint byteCountSigBlob)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 11252, 11479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 11432, 11468);

                throw f_24011_11438_11467();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 11252, 11479);

                System.NotImplementedException
                f_24011_11438_11467()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 11438, 11467);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 11252, 11479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 11252, 11479);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint FindMemberRef(uint td, string stringName, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] voidPointerSigBlob, uint byteCountSigBlob)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 11491, 11721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 11674, 11710);

                throw f_24011_11680_11709();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 11491, 11721);

                System.NotImplementedException
                f_24011_11680_11709()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 11680, 11709);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 11491, 11721);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 11491, 11721);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint FindMethod(uint td, string stringName, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] voidPointerSigBlob, uint byteCountSigBlob)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 11733, 11960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 11913, 11949);

                throw f_24011_11919_11948();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 11733, 11960);

                System.NotImplementedException
                f_24011_11919_11948()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 11919, 11948);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 11733, 11960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 11733, 11960);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint FindTypeDefByName(string stringTypeDef, uint tokenEnclosingClass)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 11972, 12121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 12074, 12110);

                throw f_24011_12080_12109();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 11972, 12121);

                System.NotImplementedException
                f_24011_12080_12109()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 12080, 12109);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 11972, 12121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 11972, 12121);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint FindTypeRef(uint tokenResolutionScope, string stringName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 12133, 12274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 12227, 12263);

                throw f_24011_12233_12262();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 12133, 12274);

                System.NotImplementedException
                f_24011_12233_12262()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 12233, 12262);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 12133, 12274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 12133, 12274);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint GetClassLayout(uint td, out uint pdwPackSize, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ulong[] arrayFieldOffset, uint countMax, out uint countPointerFieldOffset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 12286, 12545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 12498, 12534);

                throw f_24011_12504_12533();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 12286, 12545);

                System.NotImplementedException
                f_24011_12504_12533()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 12504, 12533);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 12286, 12545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 12286, 12545);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public unsafe uint GetCustomAttributeByName(uint tokenObj, string stringName, out void* ppData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 12557, 12724);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 12677, 12713);

                throw f_24011_12683_12712();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 12557, 12724);

                System.NotImplementedException
                f_24011_12683_12712()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 12683, 12712);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 12557, 12724);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 12557, 12724);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public unsafe uint GetCustomAttributeProps(uint cv, out uint ptkObj, out uint ptkType, out void* ppBlob)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 12736, 12912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 12865, 12901);

                throw f_24011_12871_12900();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 12736, 12912);

                System.NotImplementedException
                f_24011_12871_12900()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 12871, 12900);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 12736, 12912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 12736, 12912);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint GetEventProps(uint ev, out uint pointerClass, StringBuilder stringEvent, uint cchEvent, out uint pchEvent, out uint pdwEventFlags, out uint ptkEventType, out uint pmdAddOn, out uint pmdRemoveOn, out uint pmdFire, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 11)] uint[] rmdOtherMethod, uint countMax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 12924, 13314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 13267, 13303);

                throw f_24011_13273_13302();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 12924, 13314);

                System.NotImplementedException
                f_24011_13273_13302()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 13273, 13302);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 12924, 13314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 12924, 13314);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public unsafe uint GetFieldMarshal(uint tk, out byte* ppvNativeType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 13326, 13466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 13419, 13455);

                throw f_24011_13425_13454();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 13326, 13466);

                System.NotImplementedException
                f_24011_13425_13454()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 13425, 13454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 13326, 13466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 13326, 13466);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public unsafe uint GetFieldProps(uint mb, out uint pointerClass, StringBuilder stringField, uint cchField, out uint pchField, out uint pdwAttr, out byte* ppvSigBlob, out uint pcbSigBlob, out uint pdwCPlusTypeFlag, out void* ppValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 13478, 13782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 13735, 13771);

                throw f_24011_13741_13770();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 13478, 13782);

                System.NotImplementedException
                f_24011_13741_13770()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 13741, 13770);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 13478, 13782);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 13478, 13782);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint GetInterfaceImplProps(uint impl, out uint pointerClass)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 13794, 13933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 13886, 13922);

                throw f_24011_13892_13921();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 13794, 13933);

                System.NotImplementedException
                f_24011_13892_13921()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 13892, 13921);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 13794, 13933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 13794, 13933);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public unsafe uint GetMemberProps(uint mb, out uint pointerClass, StringBuilder stringMember, uint cchMember, out uint pchMember, out uint pdwAttr, out byte* ppvSigBlob, out uint pcbSigBlob, out uint pulCodeRVA, out uint pdwImplFlags, out uint pdwCPlusTypeFlag, out void* ppValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 13945, 14297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 14250, 14286);

                throw f_24011_14256_14285();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 13945, 14297);

                System.NotImplementedException
                f_24011_14256_14285()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 14256, 14285);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 13945, 14297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 13945, 14297);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public unsafe uint GetMemberRefProps(uint mr, ref uint ptk, StringBuilder stringMember, uint cchMember, out uint pchMember, out byte* ppvSigBlob)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 14309, 14526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 14479, 14515);

                throw f_24011_14485_14514();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 14309, 14526);

                System.NotImplementedException
                f_24011_14485_14514()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 14485, 14514);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 14309, 14526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 14309, 14526);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint GetMethodProps(uint mb, out uint pointerClass, IntPtr stringMethod, uint cchMethod, out uint pchMethod, IntPtr pdwAttr, IntPtr ppvSigBlob, IntPtr pcbSigBlob, IntPtr pulCodeRVA)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 14538, 14798);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 14751, 14787);

                throw f_24011_14757_14786();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 14538, 14798);

                System.NotImplementedException
                f_24011_14757_14786()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 14757, 14786);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 14538, 14798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 14538, 14798);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint GetMethodSemantics(uint mb, uint tokenEventProp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 14810, 14942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 14895, 14931);

                throw f_24011_14901_14930();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 14810, 14942);

                System.NotImplementedException
                f_24011_14901_14930()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 14901, 14930);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 14810, 14942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 14810, 14942);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint GetModuleFromScope()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 14954, 15058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 15011, 15047);

                throw f_24011_15017_15046();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 14954, 15058);

                System.NotImplementedException
                f_24011_15017_15046()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 15017, 15046);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 14954, 15058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 14954, 15058);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint GetModuleRefProps(uint mur, StringBuilder stringName, uint cchName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 15070, 15221);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 15174, 15210);

                throw f_24011_15180_15209();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 15070, 15221);

                System.NotImplementedException
                f_24011_15180_15209()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 15180, 15209);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 15070, 15221);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 15070, 15221);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint GetNameFromToken(uint tk)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 15233, 15342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 15295, 15331);

                throw f_24011_15301_15330();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 15233, 15342);

                System.NotImplementedException
                f_24011_15301_15330()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 15301, 15330);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 15233, 15342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 15233, 15342);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public unsafe uint GetNativeCallConvFromSig(void* voidPointerSig, uint byteCountSig)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 15354, 15510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 15463, 15499);

                throw f_24011_15469_15498();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 15354, 15510);

                System.NotImplementedException
                f_24011_15469_15498()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 15469, 15498);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 15354, 15510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 15354, 15510);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint GetNestedClassProps(uint typeDefNestedClass)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 15522, 15650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 15603, 15639);

                throw f_24011_15609_15638();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 15522, 15650);

                System.NotImplementedException
                f_24011_15609_15638()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 15609, 15638);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 15522, 15650);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 15522, 15650);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetParamForMethodIndex(uint md, uint ulongParamSeq, out uint pointerParam)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 15662, 15819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 15772, 15808);

                throw f_24011_15778_15807();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 15662, 15819);

                System.NotImplementedException
                f_24011_15778_15807()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 15778, 15807);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 15662, 15819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 15662, 15819);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public unsafe uint GetParamProps(uint tk, out uint pmd, out uint pulSequence, StringBuilder stringName, uint cchName, out uint pchName, out uint pdwAttr, out uint pdwCPlusTypeFlag, out void* ppValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 15831, 16102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 16055, 16091);

                throw f_24011_16061_16090();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 15831, 16102);

                System.NotImplementedException
                f_24011_16061_16090()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 16061, 16090);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 15831, 16102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 15831, 16102);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public unsafe uint GetPermissionSetProps(uint pm, out uint pdwAction, out void* ppvPermission)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 16114, 16280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 16233, 16269);

                throw f_24011_16239_16268();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 16114, 16280);

                System.NotImplementedException
                f_24011_16239_16268()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 16239, 16268);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 16114, 16280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 16114, 16280);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint GetPinvokeMap(uint tk, out uint pdwMappingFlags, StringBuilder stringImportName, uint cchImportName, out uint pchImportName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 16292, 16500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 16453, 16489);

                throw f_24011_16459_16488();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 16292, 16500);

                System.NotImplementedException
                f_24011_16459_16488()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 16459, 16488);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 16292, 16500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 16292, 16500);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public unsafe uint GetPropertyProps(uint prop, out uint pointerClass, StringBuilder stringProperty, uint cchProperty, out uint pchProperty, out uint pdwPropFlags, out byte* ppvSig, out uint bytePointerSig, out uint pdwCPlusTypeFlag, out void* ppDefaultValue, out uint pcchDefaultValue, out uint pmdSetter, out uint pmdGetter, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 14)] uint[] rmdOtherMethod, uint countMax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 16512, 17003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 16956, 16992);

                throw f_24011_16962_16991();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 16512, 17003);

                System.NotImplementedException
                f_24011_16962_16991()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 16962, 16991);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 16512, 17003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 16512, 17003);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint GetRVA(uint tk, out uint pulCodeRVA)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 17015, 17135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 17088, 17124);

                throw f_24011_17094_17123();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 17015, 17135);

                System.NotImplementedException
                f_24011_17094_17123()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 17094, 17123);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 17015, 17135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 17015, 17135);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Guid GetScopeProps(StringBuilder stringName, uint cchName, out uint pchName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 17147, 17302);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 17255, 17291);

                throw f_24011_17261_17290();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 17147, 17302);

                System.NotImplementedException
                f_24011_17261_17290()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 17261, 17290);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 17147, 17302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 17147, 17302);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public unsafe uint GetTypeSpecFromToken(uint typespec, out byte* ppvSig)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 17314, 17458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 17411, 17447);

                throw f_24011_17417_17446();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 17314, 17458);

                System.NotImplementedException
                f_24011_17417_17446()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 17417, 17446);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 17314, 17458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 17314, 17458);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint GetUserString(uint stk, StringBuilder stringString, uint cchString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 17470, 17621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 17574, 17610);

                throw f_24011_17580_17609();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 17470, 17621);

                System.NotImplementedException
                f_24011_17580_17609()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 17580, 17609);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 17470, 17621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 17470, 17621);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int IsGlobal(uint pd)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 17633, 17733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 17686, 17722);

                throw f_24011_17692_17721();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 17633, 17733);

                System.NotImplementedException
                f_24011_17692_17721()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 17692, 17721);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 17633, 17733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 17633, 17733);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: MarshalAs(UnmanagedType.Bool)]
        public bool IsValidToken(uint tk)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 17745, 17899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 17852, 17888);

                throw f_24011_17858_17887();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 17745, 17899);

                System.NotImplementedException
                f_24011_17858_17887()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 17858, 17887);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 17745, 17899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 17745, 17899);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void ResetEnum(uint handleEnum, uint ulongPos)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 17911, 18036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 17989, 18025);

                throw f_24011_17995_18024();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 17911, 18036);

                System.NotImplementedException
                f_24011_17995_18024()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 17995, 18024);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 17911, 18036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 17911, 18036);
            }
        }

        public uint ResolveTypeRef(uint tr, [In] ref Guid riid, [MarshalAs(UnmanagedType.Interface)] out object ppIScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24011, 18048, 18233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24011, 18186, 18222);

                throw f_24011_18192_18221();
                DynAbs.Tracing.TraceSender.TraceExitMethod(24011, 18048, 18233);

                System.NotImplementedException
                f_24011_18192_18221()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 18192, 18221);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24011, 18048, 18233);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 18048, 18233);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DummyMetadataImport()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24011, 548, 18262);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24011, 548, 18262);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24011, 548, 18262);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(24011, 548, 18262);

        System.Collections.Generic.List<System.Runtime.InteropServices.GCHandle>
        f_24011_999_1019()
        {
            var return_v = new System.Collections.Generic.List<System.Runtime.InteropServices.GCHandle>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 999, 1019);
            return return_v;
        }


        int
        f_24011_1505_1519(Roslyn.Test.PdbUtilities.DummyMetadataImport
        this_param, bool
        disposing)
        {
            this_param.Dispose(disposing);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24011, 1505, 1519);
            return 0;
        }

    }
}
