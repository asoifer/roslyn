// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis
{
    public abstract class ControlFlowAnalysis
    {
        public abstract ImmutableArray<SyntaxNode> EntryPoints { get; }

        public abstract ImmutableArray<SyntaxNode> ExitPoints { get; }

        public abstract bool EndPointIsReachable { get; }

        public abstract bool StartPointIsReachable { get; }

        public abstract ImmutableArray<SyntaxNode> ReturnStatements { get; }

        public abstract bool Succeeded { get; }

        public ControlFlowAnalysis()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(148, 535, 1945);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(148, 535, 1945);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(148, 535, 1945);
        }


        static ControlFlowAnalysis()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(148, 535, 1945);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(148, 535, 1945);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(148, 535, 1945);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(148, 535, 1945);
    }
}
