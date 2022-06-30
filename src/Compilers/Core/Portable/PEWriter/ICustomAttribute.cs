// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using EmitContext = Microsoft.CodeAnalysis.Emit.EmitContext;

namespace Microsoft.Cci
{
    /// <summary>
    /// A metadata custom attribute.
    /// </summary>
    internal interface ICustomAttribute
    {

        ImmutableArray<IMetadataExpression> GetArguments(EmitContext context);

        IMethodReference Constructor(EmitContext context, bool reportDiagnostics);

        ImmutableArray<IMetadataNamedArgument> GetNamedArguments(EmitContext context);

        int ArgumentCount
        {
            get;
        }

        ushort NamedArgumentCount
        {
            get;
        }

        ITypeReference GetType(EmitContext context);

        bool AllowMultiple { get; }
    }
}
