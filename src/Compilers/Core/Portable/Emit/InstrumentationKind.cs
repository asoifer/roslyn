// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Emit
{
    /// <summary>
    /// Specifies a kind of instrumentation to be applied in generated code.
    /// </summary>
    public enum InstrumentationKind
    {
        /// <summary>
        /// No instrumentation.
        /// </summary>
        None = 0,

        /// <summary>
        /// Instruments the binary to add test coverage.
        /// </summary>
        TestCoverage = 1,
    }
    internal static class InstrumentationKindExtensions
    {
        internal static bool IsValid(this InstrumentationKind value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(293, 725, 907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(293, 810, 896);

                return value >= InstrumentationKind.None && (DynAbs.Tracing.TraceSender.Expression_True(293, 817, 895) && value <= InstrumentationKind.TestCoverage);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(293, 725, 907);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(293, 725, 907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(293, 725, 907);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static InstrumentationKindExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(293, 657, 914);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(293, 657, 914);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(293, 657, 914);
        }

    }
}
