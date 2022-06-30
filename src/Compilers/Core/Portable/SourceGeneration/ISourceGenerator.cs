// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Threading;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// The base interface required to implement a source generator
    /// </summary>
    /// <remarks>
    /// The lifetime of a generator is controlled by the compiler.
    /// State should not be stored directly on the generator, as there
    /// is no guarantee that the same instance will be used on a 
    /// subsequent generation pass.
    /// </remarks>
    public interface ISourceGenerator
    {

        void Initialize(GeneratorInitializationContext context);

        void Execute(GeneratorExecutionContext context);
    }
}


