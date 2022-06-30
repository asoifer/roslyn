// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Represents a .NET assembly, consisting of one or more modules.
    /// </summary>
    /// <remarks>
    /// This interface is reserved for implementation by its associated APIs. We reserve the right to
    /// change it in the future.
    /// </remarks>
    public interface IAssemblySymbol : ISymbol
    {

        bool IsInteractive { get; }

        AssemblyIdentity Identity { get; }

        INamespaceSymbol GlobalNamespace { get; }

        IEnumerable<IModuleSymbol> Modules { get; }

        ICollection<string> TypeNames { get; }

        ICollection<string> NamespaceNames { get; }

        bool GivesAccessTo(IAssemblySymbol toAssembly);

        INamedTypeSymbol? GetTypeByMetadataName(string fullyQualifiedMetadataName);

        bool MightContainExtensionMethods { get; }

        INamedTypeSymbol? ResolveForwardedType(string fullyQualifiedMetadataName);

        ImmutableArray<INamedTypeSymbol> GetForwardedTypes();

        AssemblyMetadata? GetMetadata();
    }
}
