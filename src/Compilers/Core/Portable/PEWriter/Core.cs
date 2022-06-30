// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using Microsoft.CodeAnalysis.Symbols;
using EmitContext = Microsoft.CodeAnalysis.Emit.EmitContext;

namespace Microsoft.Cci
{
    /// <summary>
    /// An object corresponding to a metadata entity such as a type or a field.
    /// </summary>
    internal interface IDefinition : IReference
    {
    }

    /// <summary>
    /// An object corresponding to reference to a metadata entity such as a type or a field.
    /// </summary>
    internal interface IReference
    {

        IEnumerable<ICustomAttribute> GetAttributes(EmitContext context);

        void Dispatch(MetadataVisitor visitor);

        IDefinition? AsDefinition(EmitContext context);

        ISymbolInternal? GetInternalSymbol();
    }
}
