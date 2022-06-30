// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Reflection;

namespace Microsoft.Cci
{
    /// <summary>
    /// Represents a file referenced by an assembly.
    /// </summary>
    internal interface IFileReference
    {

        bool HasMetadata { get; }

        string? FileName { get; }

        ImmutableArray<byte> GetHashValue(AssemblyHashAlgorithm algorithmId);
    }
}
