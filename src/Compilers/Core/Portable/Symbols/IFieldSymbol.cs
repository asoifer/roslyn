// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Represents a field in a class, struct or enum.
    /// </summary>
    /// <remarks>
    /// This interface is reserved for implementation by its associated APIs. We reserve the right to
    /// change it in the future.
    /// </remarks>
    public interface IFieldSymbol : ISymbol
    {

ISymbol? AssociatedSymbol {get; }

bool IsConst {get; }

bool IsReadOnly {get; }

bool IsVolatile {get; }

bool IsFixedSizeBuffer {get; }

ITypeSymbol Type {get; }

NullableAnnotation NullableAnnotation {get; }

[MemberNotNullWhen(true, nameof(ConstantValue))]
        bool HasConstantValue {get; }

object? ConstantValue {get; }

ImmutableArray<CustomModifier> CustomModifiers {get; }

new IFieldSymbol OriginalDefinition {get; }

IFieldSymbol? CorrespondingTupleField {get; }
    }
}
