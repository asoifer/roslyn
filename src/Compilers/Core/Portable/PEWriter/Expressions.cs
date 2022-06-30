// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.Cci
{
    /// <summary>
    /// An expression that can be represented directly in metadata.
    /// </summary>
    internal interface IMetadataExpression
    {

        void Dispatch(MetadataVisitor visitor);

        ITypeReference Type { get; }
    }

    /// <summary>
    /// An expression that represents a (name, value) pair and that is typically used in method calls, custom attributes and object initializers.
    /// </summary>
    internal interface IMetadataNamedArgument : IMetadataExpression
    {

        string ArgumentName { get; }

        IMetadataExpression ArgumentValue { get; }

        bool IsField { get; }
    }
}
