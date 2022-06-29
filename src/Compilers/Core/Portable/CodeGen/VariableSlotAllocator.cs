// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal abstract class VariableSlotAllocator
    {
        public abstract void AddPreviousLocals(ArrayBuilder<Cci.ILocalDefinition> builder);

        public abstract LocalDefinition? GetPreviousLocal(
                    Cci.ITypeReference type,
                    ILocalSymbolInternal symbol,
                    string? name,
                    SynthesizedLocalKind kind,
                    LocalDebugId id,
                    LocalVariableAttributes pdbAttributes,
                    LocalSlotConstraints constraints,
                    ImmutableArray<bool> dynamicTransformFlags,
                    ImmutableArray<string> tupleElementNames);

        public abstract string? PreviousStateMachineTypeName { get; }

        public abstract bool TryGetPreviousHoistedLocalSlotIndex(
                    SyntaxNode currentDeclarator,
                    Cci.ITypeReference currentType,
                    SynthesizedLocalKind synthesizedKind,
                    LocalDebugId currentId,
                    DiagnosticBag diagnostics,
                    out int slotIndex);

        public abstract int PreviousHoistedLocalSlotCount { get; }

        public abstract bool TryGetPreviousAwaiterSlotIndex(Cci.ITypeReference currentType, DiagnosticBag diagnostics, out int slotIndex);

        public abstract int PreviousAwaiterSlotCount { get; }

        public abstract DebugId? MethodId { get; }

        public abstract bool TryGetPreviousClosure(SyntaxNode closureSyntax, out DebugId closureId);

        public abstract bool TryGetPreviousLambda(SyntaxNode lambdaOrLambdaBodySyntax, bool isLambdaBody, out DebugId lambdaId);

        public VariableSlotAllocator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(89, 415, 3838);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(89, 415, 3838);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(89, 415, 3838);
        }


        static VariableSlotAllocator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(89, 415, 3838);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(89, 415, 3838);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(89, 415, 3838);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(89, 415, 3838);
    }
}
