// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Reflection.Metadata;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Represents a method or method-like symbol (including constructor,
    /// destructor, operator, or property/event accessor).
    /// </summary>
    /// <remarks>
    /// This interface is reserved for implementation by its associated APIs. We reserve the right to
    /// change it in the future.
    /// </remarks>
    public interface IMethodSymbol : ISymbol
    {

MethodKind MethodKind {get; }

int Arity {get; }

bool IsGenericMethod {get; }

bool IsExtensionMethod {get; }

bool IsAsync {get; }

bool IsVararg {get; }

bool IsCheckedBuiltin {get; }

bool HidesBaseMethodsByName {get; }

bool ReturnsVoid {get; }

bool ReturnsByRef {get; }

bool ReturnsByRefReadonly {get; }

RefKind RefKind {get; }

ITypeSymbol ReturnType {get; }

NullableAnnotation ReturnNullableAnnotation {get; }

ImmutableArray<ITypeSymbol> TypeArguments {get; }

ImmutableArray<NullableAnnotation> TypeArgumentNullableAnnotations {get; }

ImmutableArray<ITypeParameterSymbol> TypeParameters {get; }

ImmutableArray<IParameterSymbol> Parameters {get; }

IMethodSymbol ConstructedFrom {get; }

bool IsReadOnly {get; }

bool IsInitOnly {get; }

new IMethodSymbol OriginalDefinition {get; }

IMethodSymbol? OverriddenMethod {get; }

ITypeSymbol? ReceiverType {get; }

NullableAnnotation ReceiverNullableAnnotation {get; }

IMethodSymbol? ReducedFrom {get; }

ITypeSymbol? GetTypeInferredDuringReduction(ITypeParameterSymbol reducedFromTypeParameter);

IMethodSymbol? ReduceExtensionMethod(ITypeSymbol receiverType);

ImmutableArray<IMethodSymbol> ExplicitInterfaceImplementations {get; }

ImmutableArray<CustomModifier> ReturnTypeCustomModifiers {get; }

ImmutableArray<CustomModifier> RefCustomModifiers {get; }

ImmutableArray<AttributeData> GetReturnTypeAttributes();

SignatureCallingConvention CallingConvention {get; }

ImmutableArray<INamedTypeSymbol> UnmanagedCallingConventionTypes {get; }

ISymbol? AssociatedSymbol {get; }

IMethodSymbol Construct(params ITypeSymbol[] typeArguments);

IMethodSymbol Construct(ImmutableArray<ITypeSymbol> typeArguments, ImmutableArray<NullableAnnotation> typeArgumentNullableAnnotations);

IMethodSymbol? PartialDefinitionPart {get; }

IMethodSymbol? PartialImplementationPart {get; }

DllImportData? GetDllImportData();

INamedTypeSymbol? AssociatedAnonymousDelegate {get; }

bool IsConditional {get; }
    }
}
