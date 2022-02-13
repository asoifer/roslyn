// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Reflection.Metadata;
using Microsoft.CodeAnalysis;

namespace Roslyn.Test.Utilities
{
    internal static class PEModuleTestHelpers
    {
        internal static MetadataReader GetMetadataReader(this PEModule module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25021, 469, 604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25021, 564, 593);

                return f_25021_571_592(module);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25021, 469, 604);

                System.Reflection.Metadata.MetadataReader
                f_25021_571_592(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25021, 571, 592);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25021, 469, 604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25021, 469, 604);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static MetadataReader GetMetadataReader(this PEAssembly assembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25021, 616, 772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25021, 715, 761);

                return f_25021_722_760(f_25021_722_745(assembly));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25021, 616, 772);

                Microsoft.CodeAnalysis.PEModule
                f_25021_722_745(Microsoft.CodeAnalysis.PEAssembly
                this_param)
                {
                    var return_v = this_param.ManifestModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25021, 722, 745);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_25021_722_760(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25021, 722, 760);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25021, 616, 772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25021, 616, 772);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PEModuleTestHelpers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25021, 411, 779);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25021, 411, 779);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25021, 411, 779);
        }

    }
}
