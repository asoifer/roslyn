// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

extern alias DSR;

using System;
using System.Collections.Immutable;
using System.IO;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.Debugging;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Test.Utilities;
using DSR::Microsoft.DiaSymReader;
using Roslyn.Test.PdbUtilities;

namespace Roslyn.Test.Utilities
{
    public static class PdbTestUtilities
    {
        public static ISymUnmanagedReader3 CreateSymReader(this CompilationVerifier verifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24005, 755, 1064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 865, 936);

                var
                pdbStream = f_24005_881_935(verifier.EmittedAssemblyPdb)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 950, 1053);

                return f_24005_957_1052(pdbStream, metadataReaderOpt: null, metadataMemoryOwnerOpt: null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24005, 755, 1064);

                Microsoft.CodeAnalysis.Collections.ImmutableMemoryStream
                f_24005_881_935(System.Collections.Immutable.ImmutableArray<byte>
                array)
                {
                    var return_v = new Microsoft.CodeAnalysis.Collections.ImmutableMemoryStream(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24005, 881, 935);
                    return return_v;
                }


                ISymUnmanagedReader5
                f_24005_957_1052(Microsoft.CodeAnalysis.Collections.ImmutableMemoryStream
                pdbStream, System.Reflection.Metadata.MetadataReader
                metadataReaderOpt, System.IDisposable
                metadataMemoryOwnerOpt)
                {
                    var return_v = SymReaderFactory.CreateReader((System.IO.Stream)pdbStream, metadataReaderOpt: metadataReaderOpt, metadataMemoryOwnerOpt: metadataMemoryOwnerOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24005, 957, 1052);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24005, 755, 1064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24005, 755, 1064);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static unsafe EditAndContinueMethodDebugInformation GetEncMethodDebugInfo(this ISymUnmanagedReader3 symReader, MethodDefinitionHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24005, 1076, 2548);
                System.Reflection.Metadata.CustomDebugInformation info = default(System.Reflection.Metadata.CustomDebugInformation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 1249, 1268);

                const int
                S_OK = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 1284, 2183) || true) && (symReader is ISymUnmanagedReader4 symReader4)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24005, 1284, 2183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 1366, 1445);

                    // LAFHIS: Le tuve que agregar los tipos de datos luego del out para la declaración
                    int
                    hr = f_24005_1375_1444(symReader4, out byte* metadata, out int size)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 1463, 1495);

                    f_24005_1463_1494(hr);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 1515, 2168) || true) && (hr == S_OK)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24005, 1515, 2168);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 1571, 1622);

                        var
                        pdbReader = f_24005_1587_1621(metadata, size)
                        ;

                        ImmutableArray<byte> GetCdiBytes(Guid kind)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(24005, 1690, 1856);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 1718, 1856);
                                return (DynAbs.Tracing.TraceSender.Conditional_F1(24005, 1718, 1785) || ((f_24005_1718_1785(pdbReader, handle, kind, out info) && DynAbs.Tracing.TraceSender.Conditional_F2(24005, 1788, 1824)) || DynAbs.Tracing.TraceSender.Conditional_F3(24005, 1827, 1856))) ? f_24005_1788_1824(pdbReader, info.Value) : default(ImmutableArray<byte>); DynAbs.Tracing.TraceSender.TraceExitMethod(24005, 1690, 1856);
                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24005, 1690, 1856);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24005, 1690, 1856);
                            }
                            throw new System.Exception("Slicer error: unreachable code");
                        }

                        System.Collections.Immutable.ImmutableArray<byte>
                        f_24005_1978_2035(System.Guid
                        kind)
                        {
                            var return_v = GetCdiBytes(kind);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(24005, 1978, 2035);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<byte>
                        f_24005_2083_2147(System.Guid
                        kind)
                        {
                            var return_v = GetCdiBytes(kind);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(24005, 2083, 2147);
                            return return_v;
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 1881, 2149);

                        return EditAndContinueMethodDebugInformation.Create(compressedSlotMap: f_24005_1978_2035(PortableCustomDebugInfoKinds.EncLocalSlotMap), compressedLambdaMap: f_24005_2083_2147(PortableCustomDebugInfoKinds.EncLambdaAndClosureMap));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24005, 1515, 2168);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24005, 1284, 2183);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 2199, 2295);

                var
                cdi = f_24005_2209_2294(symReader, handle, methodVersion: 1)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 2309, 2487) || true) && (cdi == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(24005, 2309, 2487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 2358, 2472);

                    return EditAndContinueMethodDebugInformation.Create(default(ImmutableArray<byte>), default(ImmutableArray<byte>));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(24005, 2309, 2487);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 2503, 2537);

                return f_24005_2510_2536(cdi);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24005, 1076, 2548);

                unsafe int
                f_24005_1375_1444(ISymUnmanagedReader4
                this_param, out byte*
                metadata, out int
                size)
                {
                    var return_v = this_param.GetPortableDebugMetadata(out metadata, out size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24005, 1375, 1444);
                    return return_v;
                }


                int
                f_24005_1463_1494(int
                errorCode)
                {
                    Marshal.ThrowExceptionForHR(errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24005, 1463, 1494);
                    return 0;
                }


                unsafe System.Reflection.Metadata.MetadataReader
                f_24005_1587_1621(byte*
                metadata, int
                length)
                {
                    var return_v = new System.Reflection.Metadata.MetadataReader(metadata, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24005, 1587, 1621);
                    return return_v;
                }


                bool
                f_24005_1718_1785(System.Reflection.Metadata.MetadataReader
                reader, System.Reflection.Metadata.MethodDefinitionHandle
                handle, System.Guid
                kind, out System.Reflection.Metadata.CustomDebugInformation
                customDebugInfo)
                {
                    var return_v = TryGetCustomDebugInformation(reader, (System.Reflection.Metadata.EntityHandle)handle, kind, out customDebugInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24005, 1718, 1785);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_24005_1788_1824(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = this_param.GetBlobContent(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24005, 1788, 1824);
                    return return_v;
                }


                byte[]
                f_24005_2209_2294(ISymUnmanagedReader3
                reader, System.Reflection.Metadata.MethodDefinitionHandle
                handle, int
                methodVersion)
                {
                    var return_v = CustomDebugInfoUtilities.GetCustomDebugInfoBytes(reader, handle, methodVersion: methodVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24005, 2209, 2294);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation
                f_24005_2510_2536(byte[]
                customDebugInfoBlob)
                {
                    var return_v = GetEncMethodDebugInfo(customDebugInfoBlob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24005, 2510, 2536);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24005, 1076, 2548);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24005, 1076, 2548);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryGetCustomDebugInformation(MetadataReader reader, EntityHandle handle, Guid kind, out CustomDebugInformation customDebugInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24005, 2648, 3483);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 2820, 2842);

                bool
                foundAny = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 2856, 2906);

                customDebugInfo = default(CustomDebugInformation);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 2920, 3442);
                    foreach (var infoHandle in f_24005_2947_2987_I(f_24005_2947_2987(reader, handle)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24005, 2920, 3442);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 3021, 3077);

                        var
                        info = f_24005_3032_3076(reader, infoHandle)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 3095, 3130);

                        var
                        id = f_24005_3104_3129(reader, info.Kind)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 3148, 3427) || true) && (id == kind)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24005, 3148, 3427);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 3204, 3325) || true) && (foundAny)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(24005, 3204, 3325);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 3266, 3302);

                                throw f_24005_3272_3301();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(24005, 3204, 3325);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 3347, 3370);

                            customDebugInfo = info;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 3392, 3408);

                            foundAny = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(24005, 3148, 3427);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24005, 2920, 3442);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(24005, 1, 523);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(24005, 1, 523);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 3456, 3472);

                return foundAny;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24005, 2648, 3483);

                System.Reflection.Metadata.CustomDebugInformationHandleCollection
                f_24005_2947_2987(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.EntityHandle
                handle)
                {
                    var return_v = this_param.GetCustomDebugInformation(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24005, 2947, 2987);
                    return return_v;
                }


                System.Reflection.Metadata.CustomDebugInformation
                f_24005_3032_3076(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.CustomDebugInformationHandle
                handle)
                {
                    var return_v = this_param.GetCustomDebugInformation(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24005, 3032, 3076);
                    return return_v;
                }


                System.Guid
                f_24005_3104_3129(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.GuidHandle
                handle)
                {
                    var return_v = this_param.GetGuid(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24005, 3104, 3129);
                    return return_v;
                }


                System.BadImageFormatException
                f_24005_3272_3301()
                {
                    var return_v = new System.BadImageFormatException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24005, 3272, 3301);
                    return return_v;
                }


                System.Reflection.Metadata.CustomDebugInformationHandleCollection
                f_24005_2947_2987_I(System.Reflection.Metadata.CustomDebugInformationHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24005, 2947, 2987);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24005, 2648, 3483);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24005, 2648, 3483);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static EditAndContinueMethodDebugInformation GetEncMethodDebugInfo(byte[] customDebugInfoBlob)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24005, 3495, 3884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 3621, 3873);

                return EditAndContinueMethodDebugInformation.Create(f_24005_3691_3773(customDebugInfoBlob), f_24005_3792_3871(customDebugInfoBlob));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24005, 3495, 3884);

                System.Collections.Immutable.ImmutableArray<byte>
                f_24005_3691_3773(byte[]
                customDebugInfoBlob)
                {
                    var return_v = CustomDebugInfoUtilities.GetEditAndContinueLocalSlotMapRecord(customDebugInfoBlob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24005, 3691, 3773);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_24005_3792_3871(byte[]
                customDebugInfoBlob)
                {
                    var return_v = CustomDebugInfoUtilities.GetEditAndContinueLambdaMapRecord(customDebugInfoBlob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24005, 3792, 3871);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24005, 3495, 3884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24005, 3495, 3884);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetTokenToLocationMap(Compilation compilation, bool maskToken = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24005, 3896, 4341);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 4012, 4330);
                using (var
                exebits = f_24005_4033_4051()
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 4085, 4315);
                    using (var
                    pdbbits = f_24005_4106_4124()
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 4166, 4201);

                        f_24005_4166_4200(compilation, exebits, pdbbits);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24005, 4223, 4296);

                        return f_24005_4230_4295(pdbbits, maskToken);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(24005, 4085, 4315);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(24005, 4012, 4330);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24005, 3896, 4341);

                System.IO.MemoryStream
                f_24005_4033_4051()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24005, 4033, 4051);
                    return return_v;
                }


                System.IO.MemoryStream
                f_24005_4106_4124()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24005, 4106, 4124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitResult
                f_24005_4166_4200(Microsoft.CodeAnalysis.Compilation
                this_param, System.IO.MemoryStream
                peStream, System.IO.MemoryStream
                pdbStream)
                {
                    var return_v = this_param.Emit((System.IO.Stream)peStream, (System.IO.Stream)pdbStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24005, 4166, 4200);
                    return return_v;
                }


                string
                f_24005_4230_4295(System.IO.MemoryStream
                read, bool
                maskToken)
                {
                    var return_v = Token2SourceLineExporter.TokenToSourceMap2Xml((System.IO.Stream)read, maskToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24005, 4230, 4295);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24005, 3896, 4341);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24005, 3896, 4341);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PdbTestUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24005, 702, 4348);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24005, 702, 4348);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24005, 702, 4348);
        }

    }
}
