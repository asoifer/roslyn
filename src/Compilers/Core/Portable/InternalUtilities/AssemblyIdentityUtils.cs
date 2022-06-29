// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.IO;

namespace Microsoft.CodeAnalysis
{
    internal static class AssemblyIdentityUtils
    {
        public static AssemblyIdentity? TryGetAssemblyIdentity(string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(308, 487, 1902);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(308, 619, 735);

                    using var
                    stream = f_308_638_734(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(308, 753, 795);

                    using var
                    peReader = f_308_774_794(stream)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(308, 815, 865);

                    var
                    metadataReader = f_308_836_864(peReader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(308, 885, 964);

                    AssemblyDefinition
                    assemblyDefinition = f_308_925_963(metadataReader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(308, 984, 1048);

                    string
                    name = f_308_998_1047(metadataReader, assemblyDefinition.Name)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(308, 1066, 1111);

                    Version
                    version = assemblyDefinition.Version
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(308, 1131, 1187);

                    StringHandle
                    cultureHandle = assemblyDefinition.Culture
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(308, 1205, 1299);

                    string?
                    cultureName = (DynAbs.Tracing.TraceSender.Conditional_F1(308, 1227, 1249) || (((f_308_1228_1248_M(!cultureHandle.IsNil)) && DynAbs.Tracing.TraceSender.Conditional_F2(308, 1252, 1291)) || DynAbs.Tracing.TraceSender.Conditional_F3(308, 1294, 1298))) ? f_308_1252_1291(metadataReader, cultureHandle) : null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(308, 1317, 1364);

                    AssemblyFlags
                    flags = assemblyDefinition.Flags
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(308, 1384, 1443);

                    bool
                    hasPublicKey = (flags & AssemblyFlags.PublicKey) != 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(308, 1461, 1519);

                    BlobHandle
                    publicKeyHandle = assemblyDefinition.PublicKey
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(308, 1537, 1719);

                    ImmutableArray<byte>
                    publicKeyOrToken = (DynAbs.Tracing.TraceSender.Conditional_F1(308, 1577, 1599) || ((f_308_1577_1599_M(!publicKeyHandle.IsNil) && DynAbs.Tracing.TraceSender.Conditional_F2(308, 1623, 1687)) || DynAbs.Tracing.TraceSender.Conditional_F3(308, 1711, 1718))) ? f_308_1623_1687(f_308_1623_1667(metadataReader, publicKeyHandle)) : default
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(308, 1737, 1825);

                    return f_308_1744_1824(name, version, cultureName, publicKeyOrToken, hasPublicKey);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(308, 1854, 1863);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(308, 1854, 1863);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(308, 1879, 1891);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(308, 487, 1902);

                System.IO.FileStream
                f_308_638_734(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share)
                {
                    var return_v = new System.IO.FileStream(path, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(308, 638, 734);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEReader
                f_308_774_794(System.IO.FileStream
                peStream)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEReader((System.IO.Stream)peStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(308, 774, 794);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_308_836_864(System.Reflection.PortableExecutable.PEReader
                peReader)
                {
                    var return_v = peReader.GetMetadataReader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(308, 836, 864);
                    return return_v;
                }


                System.Reflection.Metadata.AssemblyDefinition
                f_308_925_963(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.GetAssemblyDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(308, 925, 963);
                    return return_v;
                }


                string
                f_308_998_1047(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(308, 998, 1047);
                    return return_v;
                }


                bool
                f_308_1228_1248_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(308, 1228, 1248);
                    return return_v;
                }


                string
                f_308_1252_1291(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(308, 1252, 1291);
                    return return_v;
                }


                bool
                f_308_1577_1599_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(308, 1577, 1599);
                    return return_v;
                }


                byte[]
                f_308_1623_1667(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobBytes(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(308, 1623, 1667);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_308_1623_1687(byte[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<byte>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(308, 1623, 1687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_308_1744_1824(string
                name, System.Version
                version, string?
                cultureName, System.Collections.Immutable.ImmutableArray<byte>
                publicKeyOrToken, bool
                hasPublicKey)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyIdentity(name, version, cultureName, publicKeyOrToken, hasPublicKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(308, 1744, 1824);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(308, 487, 1902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(308, 487, 1902);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AssemblyIdentityUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(308, 427, 1909);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(308, 427, 1909);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(308, 427, 1909);
        }

    }
}
