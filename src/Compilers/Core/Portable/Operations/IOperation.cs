// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis.Operations;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Root type for representing the abstract semantics of C# and VB statements and expressions.
    /// </summary>
    /// <remarks>
    /// This interface is reserved for implementation by its associated APIs. We reserve the right to
    /// change it in the future.
    /// </remarks>
    [InternalImplementationOnly]
    public interface IOperation
    {

        IOperation? Parent { get; }

        OperationKind Kind { get; }

        SyntaxNode Syntax { get; }

        ITypeSymbol? Type { get; }

        Optional<object?> ConstantValue { get; }

        IEnumerable<IOperation> Children { get; }

        string Language { get; }

        void Accept(OperationVisitor visitor);

        TResult? Accept<TArgument, TResult>(OperationVisitor<TArgument, TResult> visitor, TArgument argument);

        bool IsImplicit { get; }

        SemanticModel? SemanticModel { get; }
    }
}
