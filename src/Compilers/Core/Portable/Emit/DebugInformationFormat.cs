// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Emit
{
    public enum DebugInformationFormat
    {
        Pdb = 1,
        PortablePdb = 2,
        Embedded = 3,
    }
    internal static partial class DebugInformationFormatExtensions
    {
        internal static bool IsValid(this DebugInformationFormat value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(289, 456, 642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(289, 544, 631);

                return value >= DebugInformationFormat.Pdb && (DynAbs.Tracing.TraceSender.Expression_True(289, 551, 630) && value <= DebugInformationFormat.Embedded);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(289, 456, 642);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(289, 456, 642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(289, 456, 642);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsPortable(this DebugInformationFormat value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(289, 654, 851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(289, 745, 840);

                return value == DebugInformationFormat.PortablePdb || (DynAbs.Tracing.TraceSender.Expression_False(289, 752, 839) || value == DebugInformationFormat.Embedded);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(289, 654, 851);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(289, 654, 851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(289, 654, 851);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DebugInformationFormatExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(289, 377, 858);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(289, 377, 858);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(289, 377, 858);
        }

    }
}
