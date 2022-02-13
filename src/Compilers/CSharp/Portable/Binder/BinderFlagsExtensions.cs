// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static class BinderFlagsExtensions
    {
        public static bool Includes(this BinderFlags self, BinderFlags other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10298, 443, 579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10298, 537, 568);

                return (self & other) == other;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10298, 443, 579);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10298, 443, 579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10298, 443, 579);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IncludesAny(this BinderFlags self, BinderFlags other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10298, 591, 726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10298, 688, 715);

                return (self & other) != 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10298, 591, 726);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10298, 591, 726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10298, 591, 726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BinderFlagsExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10298, 383, 733);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10298, 383, 733);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10298, 383, 733);
        }

    }
}
