// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Represents a type other than an array, a pointer, a type parameter.
    /// </summary>
    /// <remarks>
    /// This interface is reserved for implementation by its associated APIs. We reserve the right to
    /// change it in the future.
    /// </remarks>
    public interface INamedTypeSymbol : ITypeSymbol
    {

int Arity {get; }

bool IsGenericType {get; }

bool IsUnboundGenericType {get; }

bool IsScriptClass {get; }

bool IsImplicitClass {get; }

bool IsComImport {get; }

IEnumerable<string> MemberNames {get; }

ImmutableArray<ITypeParameterSymbol> TypeParameters {get; }

ImmutableArray<ITypeSymbol> TypeArguments {get; }

ImmutableArray<NullableAnnotation> TypeArgumentNullableAnnotations {get; }

ImmutableArray<CustomModifier> GetTypeArgumentCustomModifiers(int ordinal);

new INamedTypeSymbol OriginalDefinition {get; }

IMethodSymbol? DelegateInvokeMethod {get; }

INamedTypeSymbol? EnumUnderlyingType {get; }

INamedTypeSymbol ConstructedFrom {get; }

INamedTypeSymbol Construct(params ITypeSymbol[] typeArguments);

INamedTypeSymbol Construct(ImmutableArray<ITypeSymbol> typeArguments, ImmutableArray<NullableAnnotation> typeArgumentNullableAnnotations);

INamedTypeSymbol ConstructUnboundGenericType();

ImmutableArray<IMethodSymbol> InstanceConstructors {get; }

ImmutableArray<IMethodSymbol> StaticConstructors {get; }

ImmutableArray<IMethodSymbol> Constructors {get; }

ISymbol? AssociatedSymbol {get; }

bool MightContainExtensionMethods {get; }

INamedTypeSymbol? TupleUnderlyingType {get; }

ImmutableArray<IFieldSymbol> TupleElements {get; }

bool IsSerializable {get; }

INamedTypeSymbol? NativeIntegerUnderlyingType {get; }
    }
}
