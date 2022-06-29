// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis
{
    internal abstract class SemanticModelProvider
    {
        public abstract SemanticModel GetSemanticModel(SyntaxTree tree, Compilation compilation, bool ignoreAccessibility = false);

        public SemanticModelProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(163, 467, 850);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(163, 467, 850);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(163, 467, 850);
        }


        static SemanticModelProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(163, 467, 850);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(163, 467, 850);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(163, 467, 850);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(163, 467, 850);
    }
}
