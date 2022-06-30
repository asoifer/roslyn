// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.Symbols
{
    /// <summary>
    /// Interface implemented by the compiler's internal representation of a symbol.
    /// An object implementing this interface might also implement <see cref="ISymbol"/> (as is done in VB),
    /// or the compiler's symbols might be wrapped to implement ISymbol (as is done in C#).
    /// </summary>
    internal interface ISymbolInternal
    {

SymbolKind Kind {get; }

string Name {get; }

string MetadataName {get; }

Compilation DeclaringCompilation {get; }

bool Equals(ISymbolInternal? other, TypeCompareKind compareKind);

ISymbolInternal ContainingSymbol {get; }

IAssemblySymbolInternal ContainingAssembly {get; }

IModuleSymbolInternal ContainingModule {get; }

INamedTypeSymbolInternal ContainingType {get; }

INamespaceSymbolInternal ContainingNamespace {get; }

bool IsDefinition {get; }

ImmutableArray<Location> Locations {get; }

bool IsImplicitlyDeclared {get; }

Accessibility DeclaredAccessibility {get; }

bool IsStatic {get; }

bool IsVirtual {get; }

bool IsOverride {get; }

bool IsAbstract {get; }

ISymbol GetISymbol();

Cci.IReference GetCciAdapter();
    }
}
