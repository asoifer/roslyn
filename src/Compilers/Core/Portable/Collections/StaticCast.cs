// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis
{
    internal static class StaticCast<T>
    {
        internal static ImmutableArray<T> From<TDerived>(ImmutableArray<TDerived> from) where TDerived : class, T
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(114, 340, 697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(114, 616, 654);

                return ImmutableArray<T>.CastUp(from);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(114, 340, 697);
#pragma warning restore CS8634
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(114, 340, 697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114, 340, 697);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static StaticCast()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(114, 288, 704);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(114, 288, 704);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(114, 288, 704);
        }

    }
}
