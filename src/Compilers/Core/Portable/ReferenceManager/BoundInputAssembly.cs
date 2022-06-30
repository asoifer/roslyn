// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;

namespace Microsoft.CodeAnalysis
{
internal partial class CommonReferenceManager<TCompilation, TAssemblySymbol>
{
[DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
        internal struct BoundInputAssembly
        {

internal TAssemblySymbol? AssemblySymbol;

internal AssemblyReferenceBinding[]? ReferenceBinding;

            private string? GetDebuggerDisplay()
            {
                return AssemblySymbol == null ? "?" : AssemblySymbol.ToString();
            }
static BoundInputAssembly(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(528,488,1704);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(528,488,1704);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(528,488,1704);
}
        }
}
}
