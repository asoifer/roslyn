// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class ModuleCompilationState : ModuleCompilationState<NamedTypeSymbol, MethodSymbol>
    {
        public ModuleCompilationState()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10627, 325, 439);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10627, 325, 439);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10627, 325, 439);
        }


        static ModuleCompilationState()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10627, 325, 439);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10627, 325, 439);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10627, 325, 439);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10627, 325, 439);
    }
}
