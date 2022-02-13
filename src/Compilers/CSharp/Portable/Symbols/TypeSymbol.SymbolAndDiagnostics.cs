// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;

#pragma warning disable CS0660 // Warning is reported only for Full Solution Analysis

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal partial class TypeSymbol
    {
        protected class SymbolAndDiagnostics
        {
            public static readonly SymbolAndDiagnostics Empty;

            public readonly Symbol Symbol;

            public readonly ImmutableArray<Diagnostic> Diagnostics;

            public SymbolAndDiagnostics(Symbol symbol, ImmutableArray<Diagnostic> diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10174, 958, 1158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10174, 866, 872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10174, 1073, 1094);

                    this.Symbol = symbol;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10174, 1112, 1143);

                    this.Diagnostics = diagnostics;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10174, 958, 1158);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10174, 958, 1158);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10174, 958, 1158);
                }
            }

            static SymbolAndDiagnostics()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10174, 649, 1169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10174, 754, 826);
                Empty = f_10174_762_826(null, ImmutableArray<Diagnostic>.Empty); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10174, 649, 1169);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10174, 649, 1169);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10174, 649, 1169);

            static Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics
            f_10174_762_826(Microsoft.CodeAnalysis.CSharp.Symbol
            symbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
            diagnostics)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol.SymbolAndDiagnostics(symbol, diagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10174, 762, 826);
                return return_v;
            }

        }
    }
}
