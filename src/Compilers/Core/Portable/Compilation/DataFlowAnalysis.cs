// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis
{
    public abstract class DataFlowAnalysis
    {
        public abstract ImmutableArray<ISymbol> VariablesDeclared { get; }

        public abstract ImmutableArray<ISymbol> DataFlowsIn { get; }

        public abstract ImmutableArray<ISymbol> DataFlowsOut { get; }

        public abstract ImmutableArray<ISymbol> DefinitelyAssignedOnEntry { get; }

        public abstract ImmutableArray<ISymbol> DefinitelyAssignedOnExit { get; }

        public abstract ImmutableArray<ISymbol> AlwaysAssigned { get; }

        public abstract ImmutableArray<ISymbol> ReadInside { get; }

        public abstract ImmutableArray<ISymbol> WrittenInside { get; }

        public abstract ImmutableArray<ISymbol> ReadOutside { get; }

        public abstract ImmutableArray<ISymbol> WrittenOutside { get; }

        public abstract ImmutableArray<ISymbol> Captured { get; }

        public abstract ImmutableArray<ISymbol> CapturedInside { get; }

        public abstract ImmutableArray<ISymbol> CapturedOutside { get; }

        public abstract ImmutableArray<ISymbol> UnsafeAddressTaken { get; }

        public abstract ImmutableArray<IMethodSymbol> UsedLocalFunctions { get; }

        public abstract bool Succeeded { get; }

        public DataFlowAnalysis()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(149, 780, 4772);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(149, 780, 4772);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(149, 780, 4772);
        }


        static DataFlowAnalysis()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(149, 780, 4772);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(149, 780, 4772);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(149, 780, 4772);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(149, 780, 4772);
    }
}
