// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Represents a symbol (namespace, class, method, parameter, etc.)
    /// exposed by the compiler.
    /// </summary>
    /// <remarks>
    /// This interface is reserved for implementation by its associated APIs. We reserve the right to
    /// change it in the future.
    /// </remarks>
    [InternalImplementationOnly]
    public interface ISymbol : IEquatable<ISymbol?>
    {

SymbolKind Kind {get; }

string Language {get; }

string Name {get; }

string MetadataName {get; }

ISymbol ContainingSymbol {get; }

IAssemblySymbol ContainingAssembly {get; }

IModuleSymbol ContainingModule {get; }

INamedTypeSymbol ContainingType {get; }

INamespaceSymbol ContainingNamespace {get; }

bool IsDefinition {get; }

bool IsStatic {get; }

bool IsVirtual {get; }

bool IsOverride {get; }

bool IsAbstract {get; }

bool IsSealed {get; }

bool IsExtern {get; }

bool IsImplicitlyDeclared {get; }

bool CanBeReferencedByName {get; }

ImmutableArray<Location> Locations {get; }

ImmutableArray<SyntaxReference> DeclaringSyntaxReferences {get; }

ImmutableArray<AttributeData> GetAttributes();

Accessibility DeclaredAccessibility {get; }

ISymbol OriginalDefinition {get; }

void Accept(SymbolVisitor visitor);

TResult? Accept<TResult>(SymbolVisitor<TResult> visitor);

string? GetDocumentationCommentId();

string? GetDocumentationCommentXml(CultureInfo? preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default);

string ToDisplayString(SymbolDisplayFormat? format = null);

ImmutableArray<SymbolDisplayPart> ToDisplayParts(SymbolDisplayFormat? format = null);

string ToMinimalDisplayString(
            SemanticModel semanticModel,
            int position,
            SymbolDisplayFormat? format = null);

ImmutableArray<SymbolDisplayPart> ToMinimalDisplayParts(
            SemanticModel semanticModel,
            int position,
            SymbolDisplayFormat? format = null);

bool HasUnsupportedMetadata {get; }

bool Equals([NotNullWhen(returnValue: true)] ISymbol? other, SymbolEqualityComparer equalityComparer);
    }
}
