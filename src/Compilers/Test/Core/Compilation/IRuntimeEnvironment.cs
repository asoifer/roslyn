// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Utilities;

namespace Roslyn.Test.Utilities
{
    public static class RuntimeEnvironmentFactory
    {
        private static readonly Lazy<IRuntimeEnvironmentFactory> s_lazyFactory;

        internal static IRuntimeEnvironment Create(IEnumerable<ModuleData> additionalDependencies = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25017, 994, 1185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 1116, 1174);

                return f_25017_1123_1173(f_25017_1123_1142(s_lazyFactory), additionalDependencies);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25017, 994, 1185);

                Roslyn.Test.Utilities.IRuntimeEnvironmentFactory
                f_25017_1123_1142(System.Lazy<Roslyn.Test.Utilities.IRuntimeEnvironmentFactory>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 1123, 1142);
                    return return_v;
                }


                Roslyn.Test.Utilities.IRuntimeEnvironment
                f_25017_1123_1173(Roslyn.Test.Utilities.IRuntimeEnvironmentFactory
                this_param, System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleData>?
                additionalDependencies)
                {
                    var return_v = this_param.Create(additionalDependencies);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 1123, 1173);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25017, 994, 1185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25017, 994, 1185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void CaptureOutput(Action action, int expectedLength, out string output, out string errorOutput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25017, 1197, 1518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 1332, 1507);
                using (var
                runtimeEnvironment = f_25017_1364_1372()
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 1406, 1492);

                    f_25017_1406_1491(runtimeEnvironment, action, expectedLength, out output, out errorOutput);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(25017, 1332, 1507);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25017, 1197, 1518);

                Roslyn.Test.Utilities.IRuntimeEnvironment
                f_25017_1364_1372()
                {
                    var return_v = Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 1364, 1372);
                    return return_v;
                }


                int
                f_25017_1406_1491(Roslyn.Test.Utilities.IRuntimeEnvironment
                this_param, System.Action
                action, int
                expectedLength, out string
                output, out string
                errorOutput)
                {
                    this_param.CaptureOutput(action, expectedLength, out output, out errorOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 1406, 1491);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25017, 1197, 1518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25017, 1197, 1518);
            }
        }

        static RuntimeEnvironmentFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25017, 763, 1525);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 882, 981);
            s_lazyFactory = f_25017_898_981(RuntimeUtilities.GetRuntimeEnvironmentFactory); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25017, 763, 1525);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25017, 763, 1525);
        }


        static System.Lazy<Roslyn.Test.Utilities.IRuntimeEnvironmentFactory>
        f_25017_898_981(System.Func<Roslyn.Test.Utilities.IRuntimeEnvironmentFactory>
        valueFactory)
        {
            var return_v = new System.Lazy<Roslyn.Test.Utilities.IRuntimeEnvironmentFactory>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 898, 981);
            return return_v;
        }

    }

    internal struct EmitOutput
    {

        internal ImmutableArray<byte> Assembly { get; }

        internal ImmutableArray<byte> Pdb { get; }

        internal EmitOutput(ImmutableArray<byte> assembly, ImmutableArray<byte> pdb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25017, 1687, 3064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 1788, 1808);

                Assembly = assembly;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 1824, 2677) || true) && (pdb.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 1824, 2677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 1974, 2662);

                    // LAFHIS
                    using (var
                    peReader = new System.Reflection.PortableExecutable.PEReader(Assembly)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 1996, 2018);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 2060, 2204);

                        DebugDirectoryEntry
                        portablePdbEntry = f_25017_2099_2128(peReader).FirstOrDefault(e => e.Type == DebugDirectoryEntryType.EmbeddedPortablePdb)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 2226, 2643) || true) && (portablePdbEntry.DataSize != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 2226, 2643);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 2310, 2620);
                            using (var
                            embeddedMetadataProvider = f_25017_2348_2416(peReader, portablePdbEntry)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 2474, 2534);

                                var
                                mdReader = f_25017_2489_2533(embeddedMetadataProvider)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 2564, 2593);

                                pdb = readMetadata(mdReader);
                                DynAbs.Tracing.TraceSender.TraceExitUsing(25017, 2310, 2620);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 2226, 2643);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(25017, 1974, 2662);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 1824, 2677);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 2693, 2703);

                Pdb = pdb;

                unsafe ImmutableArray<byte> readMetadata(MetadataReader mdReader)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25017, 2719, 3053);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 2817, 2854);

                        var
                        length = f_25017_2830_2853(mdReader)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 2872, 2901);

                        var
                        bytes = new byte[length]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 2919, 2984);

                        f_25017_2919_2983(f_25017_2940_2964(mdReader), bytes, 0, length);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 3002, 3038);

                        return f_25017_3009_3037(bytes);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25017, 2719, 3053);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25017, 2719, 3053);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25017, 2719, 3053);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25017, 1687, 3064);

                int
                f_25017_2830_2853(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.MetadataLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 2830, 2853);
                    return return_v;
                }


                unsafe byte*
                f_25017_2940_2964(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.MetadataPointer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 2940, 2964);
                    return return_v;
                }


                unsafe int
                f_25017_2919_2983(byte*
                source, byte[]
                destination, int
                startIndex, int
                length)
                {
                    Marshal.Copy((System.IntPtr)source, destination, startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 2919, 2983);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_25017_3009_3037(params byte[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 3009, 3037);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25017, 1687, 3064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25017, 1687, 3064);
            }
        }
        static EmitOutput()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25017, 1533, 3071);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25017, 1533, 3071);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25017, 1533, 3071);
        }

        System.Reflection.PortableExecutable.PEReader
        f_25017_1996_2018(System.Collections.Immutable.ImmutableArray<byte>
        peImage)
        {
            var return_v = new System.Reflection.PortableExecutable.PEReader(peImage);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 1996, 2018);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<System.Reflection.PortableExecutable.DebugDirectoryEntry>
        f_25017_2099_2128(System.Reflection.PortableExecutable.PEReader
        this_param)
        {
            var return_v = this_param.ReadDebugDirectory();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 2099, 2128);
            return return_v;
        }


        static System.Reflection.Metadata.MetadataReaderProvider
        f_25017_2348_2416(System.Reflection.PortableExecutable.PEReader
        this_param, System.Reflection.PortableExecutable.DebugDirectoryEntry
        entry)
        {
            var return_v = this_param.ReadEmbeddedPortablePdbDebugDirectoryData(entry);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 2348, 2416);
            return return_v;
        }


        static System.Reflection.Metadata.MetadataReader
        f_25017_2489_2533(System.Reflection.Metadata.MetadataReaderProvider
        this_param)
        {
            var return_v = this_param.GetMetadataReader();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 2489, 2533);
            return return_v;
        }

    }
    internal static class RuntimeEnvironmentUtilities
    {
        private static int s_dumpCount;

        private static IEnumerable<ModuleMetadata> EnumerateModules(Metadata metadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25017, 3188, 3485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 3291, 3474);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(25017, 3298, 3343) || (((f_25017_3299_3312(metadata) == MetadataImageKind.Assembly) && DynAbs.Tracing.TraceSender.Conditional_F2(25017, 3346, 3402)) || DynAbs.Tracing.TraceSender.Conditional_F3(25017, 3405, 3473))) ? f_25017_3346_3402(f_25017_3346_3387(((AssemblyMetadata)metadata))) : f_25017_3405_3473(metadata);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25017, 3188, 3485);

                Microsoft.CodeAnalysis.MetadataImageKind
                f_25017_3299_3312(Microsoft.CodeAnalysis.Metadata
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 3299, 3312);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>
                f_25017_3346_3387(Microsoft.CodeAnalysis.AssemblyMetadata
                this_param)
                {
                    var return_v = this_param.GetModules();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 3346, 3387);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ModuleMetadata>
                f_25017_3346_3402(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>
                source)
                {
                    var return_v = source.AsEnumerable<Microsoft.CodeAnalysis.ModuleMetadata>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 3346, 3402);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ModuleMetadata>
                f_25017_3405_3473(Microsoft.CodeAnalysis.Metadata
                value)
                {
                    var return_v = SpecializedCollections.SingletonEnumerable((Microsoft.CodeAnalysis.ModuleMetadata)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 3405, 3473);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25017, 3188, 3485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25017, 3188, 3485);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void EmitReferences(Compilation compilation, HashSet<string> fullNameSet, List<ModuleData> dependencies, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25017, 3656, 6132);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 3947, 6121);
                    foreach (var metadataReference in f_25017_3981_4003_I(f_25017_3981_4003(compilation)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 3947, 6121);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 4037, 4152) || true) && (metadataReference is CompilationReference)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 4037, 4152);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 4124, 4133);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 4037, 4152);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 4172, 4231);

                        var
                        peRef = (PortableExecutableReference)metadataReference
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 4249, 4290);

                        var
                        metadata = f_25017_4264_4289(peRef)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 4308, 4383);

                        var
                        isManifestModule = peRef.Properties.Kind == MetadataImageKind.Assembly
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 4401, 4536);

                        var
                        identity = (DynAbs.Tracing.TraceSender.Conditional_F1(25017, 4416, 4432) || ((isManifestModule
                        && DynAbs.Tracing.TraceSender.Conditional_F2(25017, 4456, 4507)) || DynAbs.Tracing.TraceSender.Conditional_F3(25017, 4531, 4535))) ? f_25017_4456_4507(f_25017_4456_4498(((AssemblyMetadata)metadata))) : null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 4707, 4848) || true) && (isManifestModule && (DynAbs.Tracing.TraceSender.Expression_True(25017, 4711, 4778) && f_25017_4731_4778(fullNameSet, f_25017_4752_4777(identity))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 4707, 4848);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 4820, 4829);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 4707, 4848);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 4868, 6106);
                            foreach (var module in f_25017_4891_4917_I(f_25017_4891_4917(metadata)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 4868, 6106);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 4959, 5044);

                                ImmutableArray<byte>
                                bytes = f_25017_4988_5030(f_25017_4988_5013(f_25017_4988_5001(module))).GetContent()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 5066, 5088);

                                ModuleData
                                moduleData
                                = default(ModuleData);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 5110, 5987) || true) && (isManifestModule)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 5110, 5987);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 5180, 5223);

                                    f_25017_5180_5222(fullNameSet, f_25017_5196_5221(identity));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 5249, 5601);

                                    moduleData = f_25017_5262_5600(identity, OutputKind.DynamicallyLinkedLibrary, bytes, pdb: default(ImmutableArray<byte>), inMemoryModule: true);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 5110, 5987);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 5110, 5987);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 5699, 5964);

                                    moduleData = f_25017_5712_5963(f_25017_5727_5738(module), bytes, pdb: default(ImmutableArray<byte>), inMemoryModule: true);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 5110, 5987);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 6011, 6040);

                                f_25017_6011_6039(
                                                    dependencies, moduleData);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 6062, 6087);

                                isManifestModule = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 4868, 6106);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25017, 1, 1239);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25017, 1, 1239);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 3947, 6121);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25017, 1, 2175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25017, 1, 2175);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25017, 3656, 6132);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                f_25017_3981_4003(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.References;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 3981, 4003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Metadata
                f_25017_4264_4289(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param)
                {
                    var return_v = this_param.GetMetadataNoCopy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 4264, 4289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEAssembly?
                f_25017_4456_4498(Microsoft.CodeAnalysis.AssemblyMetadata
                this_param)
                {
                    var return_v = this_param.GetAssembly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 4456, 4498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_25017_4456_4507(Microsoft.CodeAnalysis.PEAssembly?
                this_param)
                {
                    var return_v = this_param.Identity
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 4456, 4507);
                    return return_v;
                }


                string
                f_25017_4752_4777(Microsoft.CodeAnalysis.AssemblyIdentity?
                this_param)
                {
                    var return_v = this_param.GetDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 4752, 4777);
                    return return_v;
                }


                bool
                f_25017_4731_4778(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 4731, 4778);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ModuleMetadata>
                f_25017_4891_4917(Microsoft.CodeAnalysis.Metadata
                metadata)
                {
                    var return_v = EnumerateModules(metadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 4891, 4917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_25017_4988_5001(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 4988, 5001);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEReader
                f_25017_4988_5013(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.PEReaderOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 4988, 5013);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEMemoryBlock
                f_25017_4988_5030(System.Reflection.PortableExecutable.PEReader
                this_param)
                {
                    var return_v = this_param.GetEntireImage();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 4988, 5030);
                    return return_v;
                }


                string
                f_25017_5196_5221(Microsoft.CodeAnalysis.AssemblyIdentity?
                this_param)
                {
                    var return_v = this_param.GetDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 5196, 5221);
                    return return_v;
                }


                bool
                f_25017_5180_5222(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 5180, 5222);
                    return return_v;
                }


                Roslyn.Test.Utilities.ModuleData
                f_25017_5262_5600(Microsoft.CodeAnalysis.AssemblyIdentity
                identity, Microsoft.CodeAnalysis.OutputKind
                kind, System.Collections.Immutable.ImmutableArray<byte>
                image, System.Collections.Immutable.ImmutableArray<byte>
                pdb, bool
                inMemoryModule)
                {
                    var return_v = new Roslyn.Test.Utilities.ModuleData(identity, kind, image, pdb: pdb, inMemoryModule: inMemoryModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 5262, 5600);
                    return return_v;
                }


                string
                f_25017_5727_5738(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 5727, 5738);
                    return return_v;
                }


                Roslyn.Test.Utilities.ModuleData
                f_25017_5712_5963(string
                netModuleName, System.Collections.Immutable.ImmutableArray<byte>
                image, System.Collections.Immutable.ImmutableArray<byte>
                pdb, bool
                inMemoryModule)
                {
                    var return_v = new Roslyn.Test.Utilities.ModuleData(netModuleName, image, pdb: pdb, inMemoryModule: inMemoryModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 5712, 5963);
                    return return_v;
                }


                int
                f_25017_6011_6039(System.Collections.Generic.List<Roslyn.Test.Utilities.ModuleData>
                this_param, Roslyn.Test.Utilities.ModuleData
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 6011, 6039);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ModuleMetadata>
                f_25017_4891_4917_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ModuleMetadata>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 4891, 4917);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                f_25017_3981_4003_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 3981, 4003);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25017, 3656, 6132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25017, 3656, 6132);
            }
        }

        private static List<Compilation> FindReferencedCompilations(Compilation original)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25017, 6361, 7076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 6467, 6502);

                var
                list = f_25017_6478_6501()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 6516, 6597);

                var
                toVisit = f_25017_6530_6596(f_25017_6553_6595(original))
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 6613, 7037) || true) && (f_25017_6620_6633(toVisit) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 6613, 7037);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 6671, 6703);

                        var
                        current = f_25017_6685_6702(toVisit)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 6721, 6817) || true) && (f_25017_6725_6747(list, current))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 6721, 6817);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 6789, 6798);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 6721, 6817);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 6837, 6855);

                        f_25017_6837_6854(
                                        list, current);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 6875, 7022);
                            foreach (var other in f_25017_6897_6938_I(f_25017_6897_6938(current)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 6875, 7022);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 6980, 7003);

                                f_25017_6980_7002(toVisit, other);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 6875, 7022);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25017, 1, 148);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25017, 1, 148);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 6613, 7037);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25017, 6613, 7037);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25017, 6613, 7037);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 7053, 7065);

                return list;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25017, 6361, 7076);

                System.Collections.Generic.List<Microsoft.CodeAnalysis.Compilation>
                f_25017_6478_6501()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.Compilation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 6478, 6501);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.Compilation>
                f_25017_6553_6595(Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = FindDirectReferencedCompilations(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 6553, 6595);
                    return return_v;
                }


                System.Collections.Generic.Queue<Microsoft.CodeAnalysis.Compilation>
                f_25017_6530_6596(System.Collections.Generic.List<Microsoft.CodeAnalysis.Compilation>
                collection)
                {
                    var return_v = new System.Collections.Generic.Queue<Microsoft.CodeAnalysis.Compilation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Compilation>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 6530, 6596);
                    return return_v;
                }


                int
                f_25017_6620_6633(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.Compilation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 6620, 6633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_25017_6685_6702(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.Compilation>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 6685, 6702);
                    return return_v;
                }


                bool
                f_25017_6725_6747(System.Collections.Generic.List<Microsoft.CodeAnalysis.Compilation>
                this_param, Microsoft.CodeAnalysis.Compilation
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 6725, 6747);
                    return return_v;
                }


                int
                f_25017_6837_6854(System.Collections.Generic.List<Microsoft.CodeAnalysis.Compilation>
                this_param, Microsoft.CodeAnalysis.Compilation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 6837, 6854);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.Compilation>
                f_25017_6897_6938(Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = FindDirectReferencedCompilations(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 6897, 6938);
                    return return_v;
                }


                int
                f_25017_6980_7002(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.Compilation>
                this_param, Microsoft.CodeAnalysis.Compilation
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 6980, 7002);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.Compilation>
                f_25017_6897_6938_I(System.Collections.Generic.List<Microsoft.CodeAnalysis.Compilation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 6897, 6938);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25017, 6361, 7076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25017, 6361, 7076);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static List<Compilation> FindDirectReferencedCompilations(Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25017, 7088, 7678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 7203, 7238);

                var
                list = f_25017_7214_7237()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 7252, 7339);

                var
                previousCompilation = f_25017_7278_7338_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_25017_7278_7311(compilation), 25017, 7278, 7338)?.PreviousScriptCompilation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 7353, 7463) || true) && (previousCompilation != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 7353, 7463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 7418, 7448);

                    f_25017_7418_7447(list, previousCompilation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 7353, 7463);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 7479, 7639);
                    foreach (var reference in f_25017_7505_7558_I(f_25017_7505_7558(f_25017_7505_7527(compilation))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 7479, 7639);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 7592, 7624);

                        f_25017_7592_7623(list, f_25017_7601_7622(reference));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 7479, 7639);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25017, 1, 161);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25017, 1, 161);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 7655, 7667);

                return list;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25017, 7088, 7678);

                System.Collections.Generic.List<Microsoft.CodeAnalysis.Compilation>
                f_25017_7214_7237()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.Compilation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 7214, 7237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ScriptCompilationInfo?
                f_25017_7278_7311(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.ScriptCompilationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 7278, 7311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation?
                f_25017_7278_7338_M(Microsoft.CodeAnalysis.Compilation?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 7278, 7338);
                    return return_v;
                }


                int
                f_25017_7418_7447(System.Collections.Generic.List<Microsoft.CodeAnalysis.Compilation>
                this_param, Microsoft.CodeAnalysis.Compilation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 7418, 7447);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                f_25017_7505_7527(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.References;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 7505, 7527);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CompilationReference>
                f_25017_7505_7558(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                source)
                {
                    var return_v = source.OfType<Microsoft.CodeAnalysis.CompilationReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 7505, 7558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_25017_7601_7622(Microsoft.CodeAnalysis.CompilationReference
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 7601, 7622);
                    return return_v;
                }


                int
                f_25017_7592_7623(System.Collections.Generic.List<Microsoft.CodeAnalysis.Compilation>
                this_param, Microsoft.CodeAnalysis.Compilation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 7592, 7623);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CompilationReference>
                f_25017_7505_7558_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CompilationReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 7505, 7558);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25017, 7088, 7678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25017, 7088, 7678);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static EmitOutput? EmitCompilation(
                    Compilation compilation,
                    IEnumerable<ResourceDescription> manifestResources,
                    List<ModuleData> dependencies,
                    DiagnosticBag diagnostics,
                    CompilationTestData testData,
                    EmitOptions emitOptions
                )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25017, 7690, 9803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 8377, 8446);

                var
                referencedCompilations = f_25017_8406_8445(compilation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 8460, 8532);

                var
                fullNameSet = f_25017_8478_8531(f_25017_8498_8530())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 8548, 9371);
                    foreach (var referencedCompilation in f_25017_8586_8608_I(referencedCompilations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 8548, 9371);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 8642, 8738);

                        var
                        emitData = f_25017_8657_8737(referencedCompilation, null, diagnostics, null, emitOptions)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 8756, 9356) || true) && (emitData.HasValue)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 8756, 9356);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 8819, 9224);

                            var
                            moduleData = f_25017_8836_9223(f_25017_8851_8890(f_25017_8851_8881(referencedCompilation)), OutputKind.DynamicallyLinkedLibrary, emitData.Value.Assembly, pdb: default(ImmutableArray<byte>), inMemoryModule: true)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 9246, 9286);

                            f_25017_9246_9285(fullNameSet, moduleData.Id.FullName);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 9308, 9337);

                            f_25017_9308_9336(dependencies, moduleData);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 8756, 9356);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 8548, 9371);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25017, 1, 824);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25017, 1, 824);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 9490, 9681);
                    foreach (var current in f_25017_9514_9568_I(f_25017_9514_9568((new[] { compilation }), referencedCompilations)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 9490, 9681);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 9602, 9666);

                        f_25017_9602_9665(current, fullNameSet, dependencies, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 9490, 9681);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25017, 1, 192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25017, 1, 192);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 9697, 9792);

                return f_25017_9704_9791(compilation, manifestResources, diagnostics, testData, emitOptions);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25017, 7690, 9803);

                System.Collections.Generic.List<Microsoft.CodeAnalysis.Compilation>
                f_25017_8406_8445(Microsoft.CodeAnalysis.Compilation
                original)
                {
                    var return_v = FindReferencedCompilations(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 8406, 8445);
                    return return_v;
                }


                System.StringComparer
                f_25017_8498_8530()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 8498, 8530);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_25017_8478_8531(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 8478, 8531);
                    return return_v;
                }


                Roslyn.Test.Utilities.EmitOutput?
                f_25017_8657_8737(Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                manifestResources, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CodeGen.CompilationTestData
                testData, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions)
                {
                    var return_v = EmitCompilationCore(compilation, manifestResources, diagnostics, testData, emitOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 8657, 8737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IAssemblySymbol
                f_25017_8851_8881(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 8851, 8881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_25017_8851_8890(Microsoft.CodeAnalysis.IAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 8851, 8890);
                    return return_v;
                }


                Roslyn.Test.Utilities.ModuleData
                f_25017_8836_9223(Microsoft.CodeAnalysis.AssemblyIdentity
                identity, Microsoft.CodeAnalysis.OutputKind
                kind, System.Collections.Immutable.ImmutableArray<byte>
                image, System.Collections.Immutable.ImmutableArray<byte>
                pdb, bool
                inMemoryModule)
                {
                    var return_v = new Roslyn.Test.Utilities.ModuleData(identity, kind, image, pdb: pdb, inMemoryModule: inMemoryModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 8836, 9223);
                    return return_v;
                }


                bool
                f_25017_9246_9285(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 9246, 9285);
                    return return_v;
                }


                int
                f_25017_9308_9336(System.Collections.Generic.List<Roslyn.Test.Utilities.ModuleData>
                this_param, Roslyn.Test.Utilities.ModuleData
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 9308, 9336);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.Compilation>
                f_25017_8586_8608_I(System.Collections.Generic.List<Microsoft.CodeAnalysis.Compilation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 8586, 8608);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Compilation>
                f_25017_9514_9568(Microsoft.CodeAnalysis.Compilation[]
                first, System.Collections.Generic.List<Microsoft.CodeAnalysis.Compilation>
                second)
                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.Compilation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Compilation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 9514, 9568);
                    return return_v;
                }


                int
                f_25017_9602_9665(Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Generic.HashSet<string>
                fullNameSet, System.Collections.Generic.List<Roslyn.Test.Utilities.ModuleData>
                dependencies, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    EmitReferences(compilation, fullNameSet, dependencies, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 9602, 9665);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Compilation>
                f_25017_9514_9568_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Compilation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 9514, 9568);
                    return return_v;
                }


                Roslyn.Test.Utilities.EmitOutput?
                f_25017_9704_9791(Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                manifestResources, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CodeGen.CompilationTestData
                testData, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions)
                {
                    var return_v = EmitCompilationCore(compilation, manifestResources, diagnostics, testData, emitOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 9704, 9791);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25017, 7690, 9803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25017, 7690, 9803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static EmitOutput? EmitCompilationCore(
                    Compilation compilation,
                    IEnumerable<ResourceDescription> manifestResources,
                    DiagnosticBag diagnostics,
                    CompilationTestData testData,
                    EmitOptions emitOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25017, 9815, 12072);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 10135, 10271) || true) && (emitOptions == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 10135, 10271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 10177, 10271);

                    emitOptions = f_25017_10191_10270(EmitOptions.Default, DebugInformationFormat.Embedded);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 10135, 10271);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 10287, 10335);

                using var
                executableStream = f_25017_10316_10334()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 10351, 10391);

                var
                pdb = default(ImmutableArray<byte>)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 10405, 10450);

                var
                assembly = default(ImmutableArray<byte>)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 10464, 10580);

                var
                pdbStream = (DynAbs.Tracing.TraceSender.Conditional_F1(25017, 10480, 10551) || (((f_25017_10481_10515(emitOptions) != DebugInformationFormat.Embedded) && DynAbs.Tracing.TraceSender.Conditional_F2(25017, 10554, 10572)) || DynAbs.Tracing.TraceSender.Conditional_F3(25017, 10575, 10579))) ? f_25017_10554_10572() : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 10596, 10913);

                var
                embeddedTexts = f_25017_10616_10912(f_25017_10616_10875(f_25017_10616_10800(f_25017_10616_10712(f_25017_10616_10639(compilation), t => (filePath: t.FilePath, text: t.GetText())), t => t.text.CanBeEmbedded && !string.IsNullOrEmpty(t.filePath)), t => EmbeddedText.FromSource(t.filePath, t.text)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 10929, 10947);

                EmitResult
                result
                = default(EmitResult);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 10997, 11562);

                    result = f_25017_11006_11561(compilation, executableStream, metadataPEStream: null, pdbStream: pdbStream, xmlDocumentationStream: null, win32Resources: null, manifestResources: manifestResources, options: emitOptions, debugEntryPoint: null, sourceLinkStream: null, embeddedTexts, testData: testData, cancellationToken: default);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(25017, 11591, 11800);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 11631, 11785) || true) && (pdbStream != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 11631, 11785);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 11694, 11724);

                        pdb = f_25017_11700_11723(pdbStream);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 11746, 11766);

                        f_25017_11746_11765(pdbStream);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 11631, 11785);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(25017, 11591, 11800);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 11816, 11857);

                f_25017_11816_11856(
                            diagnostics, f_25017_11837_11855(result));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 11871, 11913);

                assembly = f_25017_11882_11912(executableStream);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 11929, 12033) || true) && (f_25017_11933_11947(result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 11929, 12033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 11981, 12018);

                    return f_25017_11988_12017(assembly, pdb);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 11929, 12033);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 12049, 12061);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25017, 9815, 12072);

                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_25017_10191_10270(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format)
                {
                    var return_v = this_param.WithDebugInformationFormat(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 10191, 10270);
                    return return_v;
                }


                System.IO.MemoryStream
                f_25017_10316_10334()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 10316, 10334);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                f_25017_10481_10515(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.DebugInformationFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 10481, 10515);
                    return return_v;
                }


                System.IO.MemoryStream
                f_25017_10554_10572()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 10554, 10572);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_25017_10616_10639(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 10616, 10639);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<(string filePath, Microsoft.CodeAnalysis.Text.SourceText text)>
                f_25017_10616_10712(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxTree, (string filePath, Microsoft.CodeAnalysis.Text.SourceText text)>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.SyntaxTree, (string filePath, Microsoft.CodeAnalysis.Text.SourceText text)>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 10616, 10712);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<(string filePath, Microsoft.CodeAnalysis.Text.SourceText text)>
                f_25017_10616_10800(System.Collections.Generic.IEnumerable<(string filePath, Microsoft.CodeAnalysis.Text.SourceText text)>
                source, System.Func<(string filePath, Microsoft.CodeAnalysis.Text.SourceText text), bool>
                predicate)
                {
                    var return_v = source.Where<(string filePath, Microsoft.CodeAnalysis.Text.SourceText text)>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 10616, 10800);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>
                f_25017_10616_10875(System.Collections.Generic.IEnumerable<(string filePath, Microsoft.CodeAnalysis.Text.SourceText text)>
                source, System.Func<(string filePath, Microsoft.CodeAnalysis.Text.SourceText text), Microsoft.CodeAnalysis.EmbeddedText>
                selector)
                {
                    var return_v = source.Select<(string filePath, Microsoft.CodeAnalysis.Text.SourceText text), Microsoft.CodeAnalysis.EmbeddedText>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 10616, 10875);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedText>
                f_25017_10616_10912(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>
                items)
                {
                    var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.EmbeddedText>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 10616, 10912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitResult
                f_25017_11006_11561(Microsoft.CodeAnalysis.Compilation
                this_param, System.IO.MemoryStream
                peStream, System.IO.Stream?
                metadataPEStream, System.IO.MemoryStream?
                pdbStream, System.IO.Stream?
                xmlDocumentationStream, System.IO.Stream?
                win32Resources, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                manifestResources, Microsoft.CodeAnalysis.Emit.EmitOptions
                options, Microsoft.CodeAnalysis.IMethodSymbol?
                debugEntryPoint, System.IO.Stream?
                sourceLinkStream, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedText>
                embeddedTexts, Microsoft.CodeAnalysis.CodeGen.CompilationTestData
                testData, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.Emit((System.IO.Stream)peStream, metadataPEStream: metadataPEStream, pdbStream: (System.IO.Stream?)pdbStream, xmlDocumentationStream: xmlDocumentationStream, win32Resources: win32Resources, manifestResources: manifestResources, options: options, debugEntryPoint: debugEntryPoint, sourceLinkStream: sourceLinkStream, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>)embeddedTexts, testData: testData, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 11006, 11561);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_25017_11700_11723(System.IO.MemoryStream
                stream)
                {
                    var return_v = stream.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 11700, 11723);
                    return return_v;
                }


                int
                f_25017_11746_11765(System.IO.MemoryStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 11746, 11765);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_25017_11837_11855(Microsoft.CodeAnalysis.Emit.EmitResult
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 11837, 11855);
                    return return_v;
                }


                int
                f_25017_11816_11856(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 11816, 11856);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_25017_11882_11912(System.IO.MemoryStream
                stream)
                {
                    var return_v = stream.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 11882, 11912);
                    return return_v;
                }


                bool
                f_25017_11933_11947(Microsoft.CodeAnalysis.Emit.EmitResult
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 11933, 11947);
                    return return_v;
                }


                Roslyn.Test.Utilities.EmitOutput
                f_25017_11988_12017(System.Collections.Immutable.ImmutableArray<byte>
                assembly, System.Collections.Immutable.ImmutableArray<byte>
                pdb)
                {
                    var return_v = new Roslyn.Test.Utilities.EmitOutput(assembly, pdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 11988, 12017);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25017, 9815, 12072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25017, 9815, 12072);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string DumpAssemblyData(IEnumerable<ModuleData> modules, out string dumpDirectory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25017, 12084, 15446);
                Microsoft.CodeAnalysis.AssemblyIdentity? identity = default(Microsoft.CodeAnalysis.AssemblyIdentity?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 12205, 12226);

                dumpDirectory = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 12242, 12271);

                var
                sb = f_25017_12251_12270()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 12285, 15400);
                    foreach (var module in f_25017_12308_12315_I(modules))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 12285, 15400);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 12503, 12590) || true) && (s_dumpCount > 10)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 12503, 12590);
                            DynAbs.Tracing.TraceSender.TraceBreak(25017, 12565, 12571);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 12503, 12590);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 12610, 15385) || true) && (module.InMemoryModule)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 12610, 15385);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 12677, 12716);

                            f_25017_12677_12715(ref s_dumpCount);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 12740, 13172) || true) && (dumpDirectory == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 12740, 13172);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 12815, 12845);

                                dumpDirectory = TempRoot.Root;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 12931, 12972);

                                    f_25017_12931_12971(dumpDirectory);
                                }
                                catch
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(25017, 13025, 13149);
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(25017, 13025, 13149);
                                    // Okay if directory already exists
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 12740, 13172);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 13196, 13212);

                            string
                            fileName
                            = default(string);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 13234, 13594) || true) && (module.Kind == OutputKind.NetModule)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 13234, 13594);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 13323, 13350);

                                fileName = f_25017_13334_13349(module);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 13234, 13594);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 13234, 13594);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 13448, 13520);

                                f_25017_13448_13519(f_25017_13485_13500(module), out identity);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 13546, 13571);

                                fileName = f_25017_13557_13570(identity);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 13234, 13594);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 13618, 13708);

                            string
                            pePath = f_25017_13634_13707(dumpDirectory, fileName + f_25017_13673_13706(module.Kind))
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 13782, 13815);

                                module.Image.WriteToFile(pePath);
                            }
                            catch (ArgumentException e)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(25017, 13860, 14021);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 13936, 13998);

                                pePath = $"<unable to write file: '{pePath}' -- {f_25017_13985_13994(e)}>";
                                DynAbs.Tracing.TraceSender.TraceExitCatch(25017, 13860, 14021);
                            }
                            catch (IOException e)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(25017, 14043, 14198);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 14113, 14175);

                                pePath = $"<unable to write file: '{pePath}' -- {f_25017_14162_14171(e)}>";
                                DynAbs.Tracing.TraceSender.TraceExitCatch(25017, 14043, 14198);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 14222, 14237);

                            string
                            pdbPath
                            = default(string);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 14259, 15077) || true) && (f_25017_14263_14291_M(!module.Pdb.IsDefaultOrEmpty))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 14259, 15077);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 14341, 14398);

                                pdbPath = f_25017_14351_14397(dumpDirectory, fileName + ".pdb");

                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 14486, 14518);

                                    module.Pdb.WriteToFile(pdbPath);
                                }
                                catch (ArgumentException e)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(25017, 14571, 14746);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 14655, 14719);

                                    pdbPath = $"<unable to write file: '{pdbPath}' -- {f_25017_14706_14715(e)}>";
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(25017, 14571, 14746);
                                }
                                catch (IOException e)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(25017, 14772, 14941);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 14850, 14914);

                                    pdbPath = $"<unable to write file: '{pdbPath}' -- {f_25017_14901_14910(e)}>";
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(25017, 14772, 14941);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 14259, 15077);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 14259, 15077);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 15039, 15054);

                                pdbPath = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 14259, 15077);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 15101, 15140);

                            f_25017_15101_15139(
                                                sb, "PE(" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (module.Kind).ToString(), 25017, 15119, 15130) + "): ");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 15162, 15184);

                            f_25017_15162_15183(sb, pePath);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 15206, 15366) || true) && (pdbPath != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25017, 15206, 15366);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 15275, 15294);

                                f_25017_15275_15293(sb, "PDB: ");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 15320, 15343);

                                f_25017_15320_15342(sb, pdbPath);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 15206, 15366);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 12610, 15385);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25017, 12285, 15400);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25017, 1, 3116);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25017, 1, 3116);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 15414, 15435);

                return f_25017_15421_15434(sb);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25017, 12084, 15446);

                System.Text.StringBuilder
                f_25017_12251_12270()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 12251, 12270);
                    return return_v;
                }


                int
                f_25017_12677_12715(ref int
                location)
                {
                    var return_v = Interlocked.Increment(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 12677, 12715);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_25017_12931_12971(string
                path)
                {
                    var return_v = Directory.CreateDirectory(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 12931, 12971);
                    return return_v;
                }


                string
                f_25017_13334_13349(Roslyn.Test.Utilities.ModuleData
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 13334, 13349);
                    return return_v;
                }


                string
                f_25017_13485_13500(Roslyn.Test.Utilities.ModuleData
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 13485, 13500);
                    return return_v;
                }


                bool
                f_25017_13448_13519(string
                displayName, out Microsoft.CodeAnalysis.AssemblyIdentity?
                identity)
                {
                    var return_v = AssemblyIdentity.TryParseDisplayName(displayName, out identity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 13448, 13519);
                    return return_v;
                }


                string
                f_25017_13557_13570(Microsoft.CodeAnalysis.AssemblyIdentity?
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 13557, 13570);
                    return return_v;
                }


                string
                f_25017_13673_13706(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.GetDefaultExtension();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 13673, 13706);
                    return return_v;
                }


                string
                f_25017_13634_13707(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 13634, 13707);
                    return return_v;
                }


                string
                f_25017_13985_13994(System.ArgumentException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 13985, 13994);
                    return return_v;
                }


                string
                f_25017_14162_14171(System.IO.IOException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 14162, 14171);
                    return return_v;
                }


                bool
                f_25017_14263_14291_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 14263, 14291);
                    return return_v;
                }


                string
                f_25017_14351_14397(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 14351, 14397);
                    return return_v;
                }


                string
                f_25017_14706_14715(System.ArgumentException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 14706, 14715);
                    return return_v;
                }


                string
                f_25017_14901_14910(System.IO.IOException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25017, 14901, 14910);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25017_15101_15139(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 15101, 15139);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25017_15162_15183(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 15162, 15183);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25017_15275_15293(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 15275, 15293);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25017_15320_15342(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 15320, 15342);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleData>
                f_25017_12308_12315_I(System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 12308, 12315);
                    return return_v;
                }


                string
                f_25017_15421_15434(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25017, 15421, 15434);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25017, 12084, 15446);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25017, 12084, 15446);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RuntimeEnvironmentUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25017, 3079, 15453);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25017, 3164, 3175);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25017, 3079, 15453);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25017, 3079, 15453);
        }

    }

    public interface IRuntimeEnvironmentFactory
    {

        IRuntimeEnvironment Create(IEnumerable<ModuleData> additionalDependencies);
    }

    public interface IRuntimeEnvironment : IDisposable
    {

        void Emit(Compilation mainCompilation, IEnumerable<ResourceDescription> manifestResources, EmitOptions emitOptions, bool usePdbForDebugging = false);

        int Execute(string moduleName, string[] args, string expectedOutput);

        ImmutableArray<byte> GetMainImage();

        ImmutableArray<byte> GetMainPdb();

        ImmutableArray<Diagnostic> GetDiagnostics();

        SortedSet<string> GetMemberSignaturesFromMetadata(string fullyQualifiedTypeName, string memberName);

        IList<ModuleData> GetAllModuleData();

        void Verify(Verification verification);

        string[] VerifyModules(string[] modulesToVerify);

        void CaptureOutput(Action action, int expectedLength, out string output, out string errorOutput);
    }

    internal interface IInternalRuntimeEnvironment
    {

        CompilationTestData GetCompilationTestData();
    }
}
