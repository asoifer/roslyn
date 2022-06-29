// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis
{
    public enum Platform
    {
        /// <summary>
        /// AnyCPU (default) compiles the assembly to run on any platform.
        /// </summary>
        AnyCpu = 0,

        /// <summary>
        /// x86 compiles the assembly to be run by the 32-bit, x86-compatible common language runtime.
        /// </summary>
        X86 = 1,

        /// <summary>
        /// x64 compiles the assembly to be run by the 64-bit common language runtime on a computer that supports the AMD64 or EM64T instruction set.
        /// </summary>
        X64 = 2,

        /// <summary>
        /// Itanium compiles the assembly to be run by the 64-bit common language runtime on a computer with an Itanium processor.
        /// </summary>
        Itanium = 3,

        /// <summary>
        /// Compiles your assembly to run on any platform. Your application runs in 32-bit mode on systems that support both 64-bit and 32-bit applications.
        /// </summary>
        AnyCpu32BitPreferred = 4,

        /// <summary>
        /// Compiles your assembly to run on a computer that has an Advanced RISC Machine (ARM) processor.
        /// </summary>
        Arm = 5,

        /// <summary>
        /// Compiles your assembly to run on a computer that has an Advanced RISC Machine 64 bit (ARM64) processor.
        /// </summary>
        Arm64 = 6,
    };
    internal static partial class EnumBounds
    {
        internal static bool IsValid(this Platform value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(159, 1688, 1832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(159, 1762, 1821);

                return value >= Platform.AnyCpu && (DynAbs.Tracing.TraceSender.Expression_True(159, 1769, 1820) && value <= Platform.Arm64);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(159, 1688, 1832);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(159, 1688, 1832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(159, 1688, 1832);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool Requires64Bit(this Platform value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(159, 1844, 2020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(159, 1924, 2009);

                return value == Platform.X64 || (DynAbs.Tracing.TraceSender.Expression_False(159, 1931, 1981) || value == Platform.Itanium) || (DynAbs.Tracing.TraceSender.Expression_False(159, 1931, 2008) || value == Platform.Arm64);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(159, 1844, 2020);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(159, 1844, 2020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(159, 1844, 2020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool Requires32Bit(this Platform value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(159, 2032, 2152);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(159, 2112, 2141);

                return value == Platform.X86;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(159, 2032, 2152);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(159, 2032, 2152);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(159, 2032, 2152);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
