// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// An IErrorTypeSymbol is used when the compiler cannot determine a symbol object to return because
    /// of an error. For example, if a field is declared "Goo x;", and the type "Goo" cannot be
    /// found, an IErrorTypeSymbol is returned when asking the field "x" what it's type is.
    /// </summary>
    /// <remarks>
    /// This interface is reserved for implementation by its associated APIs. We reserve the right to
    /// change it in the future.
    /// </remarks>
    public interface IErrorTypeSymbol : INamedTypeSymbol
    {

ImmutableArray<ISymbol> CandidateSymbols {get; }

CandidateReason CandidateReason {get; }
    }
}
