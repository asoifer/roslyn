// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Represents a local variable in method body.
    /// </summary>
    /// <remarks>
    /// This interface is reserved for implementation by its associated APIs. We reserve the right to
    /// change it in the future.
    /// </remarks>
    public interface ILocalSymbol : ISymbol
    {

ITypeSymbol Type {get; }

NullableAnnotation NullableAnnotation {get; }

bool IsConst {get; }

bool IsRef {get; }

RefKind RefKind {get; }

bool HasConstantValue {get; }

object? ConstantValue {get; }

bool IsFunctionValue {get; }

bool IsFixed {get; }
    }
}
