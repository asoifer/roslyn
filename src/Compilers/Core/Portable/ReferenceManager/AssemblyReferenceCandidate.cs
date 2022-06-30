// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis
{
internal partial class CommonReferenceManager<TCompilation, TAssemblySymbol>
{
private readonly struct AssemblyReferenceCandidate
        {

public readonly int DefinitionIndex;

public readonly TAssemblySymbol? AssemblySymbol;

public AssemblyReferenceCandidate(int definitionIndex, TAssemblySymbol symbol)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(527,1353,1555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(527,1464,1498);

DefinitionIndex = definitionIndex;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(527,1516,1540);

AssemblySymbol = symbol;
DynAbs.Tracing.TraceSender.TraceExitConstructor(527,1353,1555);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(527,1353,1555);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(527,1353,1555);
}
		}
static AssemblyReferenceCandidate(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(527,548,1566);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(527,548,1566);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(527,548,1566);
}
        }
}
}
