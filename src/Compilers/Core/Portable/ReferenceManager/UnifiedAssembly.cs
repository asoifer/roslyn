// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.Symbols;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{

internal struct UnifiedAssembly<TAssemblySymbol>
        where TAssemblySymbol : class, IAssemblySymbolInternal
    {

internal readonly AssemblyIdentity OriginalReference;

internal readonly TAssemblySymbol TargetAssembly;

public UnifiedAssembly(TAssemblySymbol targetAssembly, AssemblyIdentity originalReference)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(535,1092,1419);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(535,1207,1247);

f_535_1207_1246(originalReference != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(535,1261,1298);

f_535_1261_1297(targetAssembly != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(535,1314,1357);

this.OriginalReference = originalReference;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(535,1371,1408);

this.TargetAssembly = targetAssembly;
DynAbs.Tracing.TraceSender.TraceExitConstructor(535,1092,1419);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(535,1092,1419);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(535,1092,1419);
}
		}
static UnifiedAssembly(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(535,688,1426);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(535,688,1426);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(535,688,1426);
}

static int
f_535_1207_1246(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(535, 1207, 1246);
return 0;
}


static int
f_535_1261_1297(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(535, 1261, 1297);
return 0;
}

    }
}
