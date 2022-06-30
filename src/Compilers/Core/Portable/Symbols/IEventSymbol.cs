// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Represents an event.
    /// </summary>
    /// <remarks>
    /// This interface is reserved for implementation by its associated APIs. We reserve the right to
    /// change it in the future.
    /// </remarks>
    public interface IEventSymbol : ISymbol
    {

ITypeSymbol Type {get; }

NullableAnnotation NullableAnnotation {get; }

bool IsWindowsRuntimeEvent {get; }

IMethodSymbol? AddMethod {get; }

IMethodSymbol? RemoveMethod {get; }

IMethodSymbol? RaiseMethod {get; }

new IEventSymbol OriginalDefinition {get; }

IEventSymbol? OverriddenEvent {get; }

ImmutableArray<IEventSymbol> ExplicitInterfaceImplementations {get; }
    }
}
