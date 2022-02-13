// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using Microsoft.DiaSymReader;

namespace Roslyn.Test.PdbUtilities
{
    internal static class SymWriterTestUtilities
    {
        public static readonly Func<ISymWriterMetadataProvider, SymUnmanagedWriter> ThrowingFactory;

        static SymWriterTestUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24016, 320, 588);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24016, 457, 580);
            ThrowingFactory = _ => throw new SymUnmanagedWriterException("xxx", new NotSupportedException(), "<lib name>"); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24016, 320, 588);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24016, 320, 588);
        }

    }
}
