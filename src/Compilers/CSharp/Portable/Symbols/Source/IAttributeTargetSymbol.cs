// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    /// <summary>
    /// Implemented by symbols that can be targeted by an attribute declaration (i.e. source symbols).
    /// </summary>
    internal interface IAttributeTargetSymbol
    {

        IAttributeTargetSymbol AttributesOwner { get; }

        AttributeLocation AllowedAttributeLocations { get; }

        AttributeLocation DefaultAttributeLocation { get; }

        // TODO (tomat): 
        // Add DecodeWellKnownAttribute, etc.
    }
}
