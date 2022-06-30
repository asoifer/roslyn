// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Represents a property or indexer.
    /// </summary>
    /// <remarks>
    /// This interface is reserved for implementation by its associated APIs. We reserve the right to
    /// change it in the future.
    /// </remarks>
    public interface IPropertySymbol : ISymbol
    {

bool IsIndexer {get; }

bool IsReadOnly {get; }

bool IsWriteOnly {get; }

bool IsWithEvents {get; }

bool ReturnsByRef {get; }

bool ReturnsByRefReadonly {get; }

RefKind RefKind {get; }

ITypeSymbol Type {get; }

NullableAnnotation NullableAnnotation {get; }

ImmutableArray<IParameterSymbol> Parameters {get; }

IMethodSymbol? GetMethod {get; }

IMethodSymbol? SetMethod {get; }

new IPropertySymbol OriginalDefinition {get; }

IPropertySymbol? OverriddenProperty {get; }

ImmutableArray<IPropertySymbol> ExplicitInterfaceImplementations {get; }

ImmutableArray<CustomModifier> RefCustomModifiers {get; }

ImmutableArray<CustomModifier> TypeCustomModifiers {get; }
    }
}
