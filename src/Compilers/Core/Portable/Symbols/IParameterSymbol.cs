// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Represents a parameter of a method or property.
    /// </summary>
    /// <remarks>
    /// This interface is reserved for implementation by its associated APIs. We reserve the right to
    /// change it in the future.
    /// </remarks>
    public interface IParameterSymbol : ISymbol
    {

RefKind RefKind {get; }

bool IsParams {get; }

bool IsOptional {get; }

bool IsThis {get; }

bool IsDiscard {get; }

ITypeSymbol Type {get; }

NullableAnnotation NullableAnnotation {get; }

ImmutableArray<CustomModifier> CustomModifiers {get; }

ImmutableArray<CustomModifier> RefCustomModifiers {get; }

int Ordinal {get; }

bool HasExplicitDefaultValue {get; }

object? ExplicitDefaultValue {get; }

new IParameterSymbol OriginalDefinition {get; }
    }
}
