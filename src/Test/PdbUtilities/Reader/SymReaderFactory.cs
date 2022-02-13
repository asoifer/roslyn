// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

extern alias DSR;

using System;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using DSR::Microsoft.DiaSymReader;
using PortablePdb = Microsoft.DiaSymReader.PortablePdb;

namespace Roslyn.Test.PdbUtilities
{
    public static class SymReaderFactory
    {
        public static void Dispose(this ISymUnmanagedReader symReader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24008, 726, 773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24008, 729, 773);
                ((ISymUnmanagedDispose)symReader)?.Destroy(); 
                DynAbs.Tracing.TraceSender.TraceExitMethod(24008, 726, 773);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24008, 726, 773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24008, 726, 773);
            }
        }

        [DefaultDllImportSearchPaths(DllImportSearchPath.AssemblyDirectory | DllImportSearchPath.SafeDirectories)]
        [DllImport("Microsoft.DiaSymReader.Native.x86.dll", EntryPoint = "CreateSymReader")]
        private static extern void CreateSymReader32(ref Guid id, [MarshalAs(UnmanagedType.IUnknown)] out object symReader);

        [DefaultDllImportSearchPaths(DllImportSearchPath.AssemblyDirectory | DllImportSearchPath.SafeDirectories)]
        [DllImport("Microsoft.DiaSymReader.Native.amd64.dll", EntryPoint = "CreateSymReader")]
        private static extern void CreateSymReader64(ref Guid id, [MarshalAs(UnmanagedType.IUnknown)] out object symReader);

        private static ISymUnmanagedReader5 CreateNativeSymReader(Stream pdbStream, object metadataImporter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24008, 1464, 2050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24008, 1589, 1613);

                object
                symReader = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24008, 1629, 1654);

                var
                guid = default(Guid)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24008, 1668, 1889) || true) && (IntPtr.Size == 4)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24008, 1668, 1889);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24008, 1722, 1765);

                    f_24008_1722_1764(ref guid, out symReader);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24008, 1668, 1889);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24008, 1668, 1889);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24008, 1831, 1874);

                    f_24008_1831_1873(ref guid, out symReader);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24008, 1668, 1889);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24008, 1905, 1950);

                var
                reader = (ISymUnmanagedReader5)symReader
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24008, 1964, 2011);

                f_24008_1964_2010(reader, pdbStream, metadataImporter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24008, 2025, 2039);

                return reader;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24008, 1464, 2050);

                int
                f_24008_1722_1764(ref System.Guid
                id, out object
                symReader)
                {
                    CreateSymReader32(ref id, out symReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 1722, 1764);
                    return 0;
                }


                int
                f_24008_1831_1873(ref System.Guid
                id, out object
                symReader)
                {
                    CreateSymReader64(ref id, out symReader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 1831, 1873);
                    return 0;
                }


                int
                f_24008_1964_2010(ISymUnmanagedReader5
                reader, System.IO.Stream
                stream, object
                metadataImporter)
                {
                    reader.Initialize(stream, metadataImporter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 1964, 2010);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24008, 1464, 2050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24008, 1464, 2050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ISymUnmanagedReader5 CreatePortableSymReader(Stream pdbStream, object metadataImporter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24008, 2062, 2306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24008, 2189, 2295);

                return (ISymUnmanagedReader5)f_24008_2218_2294(f_24008_2218_2245(), pdbStream, metadataImporter);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24008, 2062, 2306);

                Microsoft.DiaSymReader.PortablePdb.SymBinder
                f_24008_2218_2245()
                {
                    var return_v = new Microsoft.DiaSymReader.PortablePdb.SymBinder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 2218, 2245);
                    return return_v;
                }


                ISymUnmanagedReader
                f_24008_2218_2294(PortablePdb.SymBinder
                binder, System.IO.Stream
                stream, object
                metadataImporter)
                {
                    var return_v = binder.GetReaderFromStream(stream, metadataImporter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 2218, 2294);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24008, 2062, 2306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24008, 2062, 2306);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ISymUnmanagedReader5 CreateReader(byte[] pdbImage, byte[] peImageOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24008, 2318, 2566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24008, 2433, 2555);

                return f_24008_2440_2554(f_24008_2453_2479(pdbImage), (DynAbs.Tracing.TraceSender.Conditional_F1(24008, 2481, 2501) || (((peImageOpt != null) && DynAbs.Tracing.TraceSender.Conditional_F2(24008, 2504, 2546)) || DynAbs.Tracing.TraceSender.Conditional_F3(24008, 2549, 2553))) ? f_24008_2504_2546(f_24008_2517_2545(peImageOpt)) : null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24008, 2318, 2566);

                System.IO.MemoryStream
                f_24008_2453_2479(byte[]
                buffer)
                {
                    var return_v = new System.IO.MemoryStream(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 2453, 2479);
                    return return_v;
                }


                System.IO.MemoryStream
                f_24008_2517_2545(byte[]
                buffer)
                {
                    var return_v = new System.IO.MemoryStream(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 2517, 2545);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEReader
                f_24008_2504_2546(System.IO.MemoryStream
                peStream)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEReader((System.IO.Stream)peStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 2504, 2546);
                    return return_v;
                }


                ISymUnmanagedReader5
                f_24008_2440_2554(System.IO.MemoryStream
                pdbStream, System.Reflection.PortableExecutable.PEReader?
                peReaderOpt)
                {
                    var return_v = CreateReader((System.IO.Stream)pdbStream, peReaderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 2440, 2554);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24008, 2318, 2566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24008, 2318, 2566);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ISymUnmanagedReader5 CreateReader(ImmutableArray<byte> pdbImage, ImmutableArray<byte> peImageOpt = default(ImmutableArray<byte>))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24008, 2578, 2873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24008, 2746, 2862);

                return f_24008_2753_2861(f_24008_2766_2802(pdbImage.ToArray()), (DynAbs.Tracing.TraceSender.Conditional_F1(24008, 2804, 2826) || (((peImageOpt.IsDefault) && DynAbs.Tracing.TraceSender.Conditional_F2(24008, 2829, 2833)) || DynAbs.Tracing.TraceSender.Conditional_F3(24008, 2836, 2860))) ? null : f_24008_2836_2860(peImageOpt));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24008, 2578, 2873);

                System.IO.MemoryStream
                f_24008_2766_2802(byte[]
                buffer)
                {
                    var return_v = new System.IO.MemoryStream(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 2766, 2802);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEReader
                f_24008_2836_2860(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEReader(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 2836, 2860);
                    return return_v;
                }


                ISymUnmanagedReader5
                f_24008_2753_2861(System.IO.MemoryStream
                pdbStream, System.Reflection.PortableExecutable.PEReader?
                peReaderOpt)
                {
                    var return_v = CreateReader((System.IO.Stream)pdbStream, peReaderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 2753, 2861);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24008, 2578, 2873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24008, 2578, 2873);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ISymUnmanagedReader5 CreateReader(Stream pdbStream, Stream peStreamOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24008, 2885, 3102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24008, 3002, 3091);

                return f_24008_3009_3090(pdbStream, (DynAbs.Tracing.TraceSender.Conditional_F1(24008, 3033, 3054) || (((peStreamOpt != null) && DynAbs.Tracing.TraceSender.Conditional_F2(24008, 3057, 3082)) || DynAbs.Tracing.TraceSender.Conditional_F3(24008, 3085, 3089))) ? f_24008_3057_3082(peStreamOpt) : null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24008, 2885, 3102);

                System.Reflection.PortableExecutable.PEReader
                f_24008_3057_3082(System.IO.Stream
                peStream)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEReader(peStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 3057, 3082);
                    return return_v;
                }


                ISymUnmanagedReader5
                f_24008_3009_3090(System.IO.Stream
                pdbStream, System.Reflection.PortableExecutable.PEReader?
                peReaderOpt)
                {
                    var return_v = CreateReader(pdbStream, peReaderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 3009, 3090);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24008, 2885, 3102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24008, 2885, 3102);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ISymUnmanagedReader5 CreateReader(Stream pdbStream, PEReader peReaderOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24008, 3114, 3315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24008, 3226, 3304);

                return f_24008_3233_3303(pdbStream, f_24008_3269_3289(peReaderOpt), peReaderOpt);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24008, 3114, 3315);

                System.Reflection.Metadata.MetadataReader
                f_24008_3269_3289(System.Reflection.PortableExecutable.PEReader
                peReader)
                {
                    var return_v = peReader?.GetMetadataReader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 3269, 3289);
                    return return_v;
                }


                ISymUnmanagedReader5
                f_24008_3233_3303(System.IO.Stream
                pdbStream, System.Reflection.Metadata.MetadataReader?
                metadataReaderOpt, System.Reflection.PortableExecutable.PEReader?
                metadataMemoryOwnerOpt)
                {
                    var return_v = CreateReader(pdbStream, metadataReaderOpt, (System.IDisposable?)metadataMemoryOwnerOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 3233, 3303);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24008, 3114, 3315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24008, 3114, 3315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ISymUnmanagedReader5 CreateReader(Stream pdbStream, MetadataReader metadataReaderOpt, IDisposable metadataMemoryOwnerOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24008, 3327, 3619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24008, 3487, 3608);

                return f_24008_3494_3607(pdbStream, metadataImporter: f_24008_3540_3606(metadataReaderOpt, metadataMemoryOwnerOpt));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24008, 3327, 3619);

                Roslyn.Test.PdbUtilities.DummyMetadataImport
                f_24008_3540_3606(System.Reflection.Metadata.MetadataReader
                metadataReaderOpt, System.IDisposable
                metadataOwnerOpt)
                {
                    var return_v = new Roslyn.Test.PdbUtilities.DummyMetadataImport(metadataReaderOpt, metadataOwnerOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 3540, 3606);
                    return return_v;
                }


                ISymUnmanagedReader5
                f_24008_3494_3607(System.IO.Stream
                pdbStream, Roslyn.Test.PdbUtilities.DummyMetadataImport
                metadataImporter)
                {
                    var return_v = CreateReaderImpl(pdbStream, metadataImporter: (object)metadataImporter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 3494, 3607);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24008, 3327, 3619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24008, 3327, 3619);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ISymUnmanagedReader5 CreateReaderImpl(Stream pdbStream, object metadataImporter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24008, 3631, 4237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24008, 3750, 3773);

                pdbStream.Position = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24008, 3787, 3926);

                bool
                isPortable = f_24008_3805_3825(pdbStream) == 'B' && (DynAbs.Tracing.TraceSender.Expression_True(24008, 3805, 3863) && f_24008_3836_3856(pdbStream) == 'S') && (DynAbs.Tracing.TraceSender.Expression_True(24008, 3805, 3894) && f_24008_3867_3887(pdbStream) == 'J') && (DynAbs.Tracing.TraceSender.Expression_True(24008, 3805, 3925) && f_24008_3898_3918(pdbStream) == 'B')
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24008, 3940, 3963);

                pdbStream.Position = 0;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24008, 3979, 4226) || true) && (isPortable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24008, 3979, 4226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24008, 4027, 4087);

                    return f_24008_4034_4086(pdbStream, metadataImporter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24008, 3979, 4226);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24008, 3979, 4226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24008, 4153, 4211);

                    return f_24008_4160_4210(pdbStream, metadataImporter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24008, 3979, 4226);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24008, 3631, 4237);

                int
                f_24008_3805_3825(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 3805, 3825);
                    return return_v;
                }


                int
                f_24008_3836_3856(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 3836, 3856);
                    return return_v;
                }


                int
                f_24008_3867_3887(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 3867, 3887);
                    return return_v;
                }


                int
                f_24008_3898_3918(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.ReadByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 3898, 3918);
                    return return_v;
                }


                ISymUnmanagedReader5
                f_24008_4034_4086(System.IO.Stream
                pdbStream, object
                metadataImporter)
                {
                    var return_v = CreatePortableSymReader(pdbStream, metadataImporter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 4034, 4086);
                    return return_v;
                }


                ISymUnmanagedReader5
                f_24008_4160_4210(System.IO.Stream
                pdbStream, object
                metadataImporter)
                {
                    var return_v = CreateNativeSymReader(pdbStream, metadataImporter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24008, 4160, 4210);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24008, 3631, 4237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24008, 3631, 4237);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SymReaderFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24008, 597, 4244);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24008, 597, 4244);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24008, 597, 4244);
        }

    }
}
