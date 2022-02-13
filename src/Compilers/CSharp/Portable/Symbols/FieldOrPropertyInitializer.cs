// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    /// <summary>
    /// Represents a field initializer, a property initializer, or a global statement in script code.
    /// </summary>
    internal struct FieldOrPropertyInitializer
    {
        /// <summary>
        /// The field being initialized (possibly a backing field of a property), or null if this is a top-level statement in script code.
        /// </summary>
        internal readonly FieldSymbol FieldOpt;

        /// <summary>
        /// A reference to <see cref="EqualsValueClauseSyntax"/>,
        /// or top-level <see cref="StatementSyntax"/> in script code,
        /// or <see cref="ParameterSyntax"/> for an initialization of a generated property based on record parameter.
        /// </summary>
        internal readonly SyntaxReference Syntax;

        public FieldOrPropertyInitializer(FieldSymbol fieldOpt, SyntaxNode syntax)
        {
            // LAFHIS
            var a1 = syntax.IsKind(SyntaxKind.EqualsValueClause);
            var a2 = syntax.IsKind(SyntaxKind.Parameter);
            var a3 = fieldOpt != null;
            var a4 = syntax is StatementSyntax;

            Debug.Assert(((a1 || a2) && a3) || a4);

            FieldOpt = fieldOpt;
            Syntax = syntax.GetReference();
        }
    }
}
