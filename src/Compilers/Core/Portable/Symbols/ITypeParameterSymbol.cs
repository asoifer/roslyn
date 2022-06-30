// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Represents a type parameter in a generic type or generic method.
    /// </summary>
    /// <remarks>
    /// This interface is reserved for implementation by its associated APIs. We reserve the right to
    /// change it in the future.
    /// </remarks>
    public interface ITypeParameterSymbol : ITypeSymbol
    {

int Ordinal {get; }

VarianceKind Variance {get; }

TypeParameterKind TypeParameterKind {get; }

IMethodSymbol? DeclaringMethod {get; }

INamedTypeSymbol? DeclaringType {get; }

bool HasReferenceTypeConstraint {get; }

NullableAnnotation ReferenceTypeConstraintNullableAnnotation {get; }

bool HasValueTypeConstraint {get; }

bool HasUnmanagedTypeConstraint {get; }

bool HasNotNullConstraint {get; }

bool HasConstructorConstraint {get; }

ImmutableArray<ITypeSymbol> ConstraintTypes {get; }

ImmutableArray<NullableAnnotation> ConstraintNullableAnnotations {get; }

new ITypeParameterSymbol OriginalDefinition {get; }

ITypeParameterSymbol? ReducedFrom {get; }
    }
}
