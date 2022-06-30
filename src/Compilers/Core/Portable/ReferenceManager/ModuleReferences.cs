// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Symbols;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
internal sealed class ModuleReferences<TAssemblySymbol>
        where TAssemblySymbol : class, IAssemblySymbolInternal
{
public readonly ImmutableArray<AssemblyIdentity> Identities;

public readonly ImmutableArray<TAssemblySymbol> Symbols;

public readonly ImmutableArray<UnifiedAssembly<TAssemblySymbol>> UnifiedAssemblies;

public ModuleReferences(
            ImmutableArray<AssemblyIdentity> identities,
            ImmutableArray<TAssemblySymbol> symbols,
            ImmutableArray<UnifiedAssembly<TAssemblySymbol>> unifiedAssemblies)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(534,1671,2267);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(534,1913,1949);

f_534_1913_1948(f_534_1926_1947_M(!identities.IsDefault));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(534,1963,1996);

f_534_1963_1995(f_534_1976_1994_M(!symbols.IsDefault));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(534,2010,2060);

f_534_2010_2059(identities.Length == symbols.Length);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(534,2074,2117);

f_534_2074_2116(f_534_2087_2115_M(!unifiedAssemblies.IsDefault));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(534,2133,2162);

this.Identities = identities;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(534,2176,2199);

this.Symbols = symbols;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(534,2213,2256);

this.UnifiedAssemblies = unifiedAssemblies;
DynAbs.Tracing.TraceSender.TraceExitConstructor(534,1671,2267);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(534,1671,2267);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(534,1671,2267);
}
		}

static ModuleReferences()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(534,534,2274);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(534,534,2274);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(534,534,2274);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(534,534,2274);

bool
f_534_1926_1947_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(534, 1926, 1947);
return return_v;
}


static int
f_534_1913_1948(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(534, 1913, 1948);
return 0;
}


bool
f_534_1976_1994_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(534, 1976, 1994);
return return_v;
}


static int
f_534_1963_1995(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(534, 1963, 1995);
return 0;
}


static int
f_534_2010_2059(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(534, 2010, 2059);
return 0;
}


bool
f_534_2087_2115_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(534, 2087, 2115);
return return_v;
}


static int
f_534_2074_2116(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(534, 2074, 2116);
return 0;
}

}
}
