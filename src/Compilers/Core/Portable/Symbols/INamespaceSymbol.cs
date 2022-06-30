// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Represents a namespace.
    /// </summary>
    /// <remarks>
    /// This interface is reserved for implementation by its associated APIs. We reserve the right to
    /// change it in the future.
    /// </remarks>
    public interface INamespaceSymbol : INamespaceOrTypeSymbol
    {

new IEnumerable<INamespaceOrTypeSymbol> GetMembers();

new IEnumerable<INamespaceOrTypeSymbol> GetMembers(string name);

IEnumerable<INamespaceSymbol> GetNamespaceMembers();

bool IsGlobalNamespace {get; }

NamespaceKind NamespaceKind {get; }

Compilation? ContainingCompilation {get; }

ImmutableArray<INamespaceSymbol> ConstituentNamespaces {get; }
    }
}
