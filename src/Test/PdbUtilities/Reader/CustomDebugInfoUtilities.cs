// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

extern alias DSR;

using System.Collections.Immutable;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using Microsoft.CodeAnalysis.Debugging;
using DSR::Microsoft.DiaSymReader;

namespace Roslyn.Test.PdbUtilities
{
    public static class CustomDebugInfoUtilities
    {
        public static byte[] GetCustomDebugInfoBytes(ISymUnmanagedReader3 reader, MethodDefinitionHandle handle, int methodVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24001, 548, 788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24001, 696, 777);

                return f_24001_703_776(reader, f_24001_729_760(handle), methodVersion);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24001, 548, 788);

                int
                f_24001_729_760(System.Reflection.Metadata.MethodDefinitionHandle
                handle)
                {
                    var return_v = MetadataTokens.GetToken((System.Reflection.Metadata.EntityHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24001, 729, 760);
                    return return_v;
                }


                byte[]
                f_24001_703_776(ISymUnmanagedReader3
                reader, int
                methodToken, int
                methodVersion)
                {
                    var return_v = reader.GetCustomDebugInfo(methodToken, methodVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24001, 703, 776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24001, 548, 788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24001, 548, 788);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<byte> GetEditAndContinueLocalSlotMapRecord(byte[] customDebugInfoBlob)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24001, 800, 1062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24001, 924, 1051);

                return f_24001_931_1050(customDebugInfoBlob, CustomDebugInfoKind.EditAndContinueLocalSlotMap);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24001, 800, 1062);

                System.Collections.Immutable.ImmutableArray<byte>
                f_24001_931_1050(byte[]
                customDebugInfo, Microsoft.CodeAnalysis.Debugging.CustomDebugInfoKind
                recordKind)
                {
                    var return_v = CustomDebugInfoReader.TryGetCustomDebugInfoRecord(customDebugInfo, recordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24001, 931, 1050);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24001, 800, 1062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24001, 800, 1062);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<byte> GetEditAndContinueLambdaMapRecord(byte[] customDebugInfoBlob)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24001, 1074, 1330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24001, 1195, 1319);

                return f_24001_1202_1318(customDebugInfoBlob, CustomDebugInfoKind.EditAndContinueLambdaMap);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24001, 1074, 1330);

                System.Collections.Immutable.ImmutableArray<byte>
                f_24001_1202_1318(byte[]
                customDebugInfo, Microsoft.CodeAnalysis.Debugging.CustomDebugInfoKind
                recordKind)
                {
                    var return_v = CustomDebugInfoReader.TryGetCustomDebugInfoRecord(customDebugInfo, recordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24001, 1202, 1318);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24001, 1074, 1330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24001, 1074, 1330);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CustomDebugInfoUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24001, 487, 1337);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24001, 487, 1337);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24001, 487, 1337);
        }

    }
}
