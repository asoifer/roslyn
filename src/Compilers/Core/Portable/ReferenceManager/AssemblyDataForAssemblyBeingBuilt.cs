// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
internal partial class CommonReferenceManager<TCompilation, TAssemblySymbol>
{protected sealed class AssemblyDataForAssemblyBeingBuilt : AssemblyData
{
private readonly AssemblyIdentity _assemblyIdentity;

private readonly ImmutableArray<AssemblyData> _referencedAssemblyData;

private readonly ImmutableArray<AssemblyIdentity> _referencedAssemblies;

public AssemblyDataForAssemblyBeingBuilt(
                AssemblyIdentity identity,
                ImmutableArray<AssemblyData> referencedAssemblyData,
                ImmutableArray<PEModule> modules)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(525,1020,2080);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,658,675);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,1259,1290);

f_525_1259_1289(identity != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,1308,1356);

f_525_1308_1355(f_525_1321_1354_M(!referencedAssemblyData.IsDefault));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,1376,1405);

_assemblyIdentity = identity;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,1425,1474);

_referencedAssemblyData = referencedAssemblyData;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,1494,1596);

var 
refs = f_525_1505_1595(referencedAssemblyData.Length + modules.Length)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,1633,1770);
foreach(AssemblyData data in f_525_1663_1685_I(referencedAssemblyData) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(525,1633,1770);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,1727,1751);

f_525_1727_1750(                    refs, f_525_1736_1749(data));
DynAbs.Tracing.TraceSender.TraceExitCondition(525,1633,1770);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(525,1,138);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(525,1,138);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,1852,1857);

                // add assembly names from modules:
                for (int 
i = 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,1843,1995) || true) && (i <= modules.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,1880,1883)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(525,1843,1995))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(525,1843,1995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,1925,1976);

f_525_1925_1975(                    refs, f_525_1939_1974(modules[i - 1]));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(525,1,153);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(525,1,153);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,2015,2065);

_referencedAssemblies = f_525_2039_2064(refs);
DynAbs.Tracing.TraceSender.TraceExitConstructor(525,1020,2080);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(525,1020,2080);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(525,1020,2080);
}
		}

public override AssemblyIdentity Identity
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(525,2170,2258);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,2214,2239);

return _assemblyIdentity;
DynAbs.Tracing.TraceSender.TraceExitMethod(525,2170,2258);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(525,2096,2273);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(525,2096,2273);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override ImmutableArray<AssemblyIdentity> AssemblyReferences
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(525,2389,2481);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,2433,2462);

return _referencedAssemblies;
DynAbs.Tracing.TraceSender.TraceExitMethod(525,2389,2481);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(525,2289,2496);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(525,2289,2496);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override IEnumerable<TAssemblySymbol> AvailableSymbols
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(525,2606,2706);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,2650,2687);

throw f_525_2656_2686();
DynAbs.Tracing.TraceSender.TraceExitMethod(525,2606,2706);

System.Exception
f_525_2656_2686()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(525, 2656, 2686);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(525,2512,2721);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(525,2512,2721);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override AssemblyReferenceBinding[] BindAssemblyReferences(
                ImmutableArray<AssemblyData> assemblies,
                AssemblyIdentityComparer assemblyIdentityComparer)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(525,2737,4057);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,2962,3043);

var 
boundReferences = new AssemblyReferenceBinding[_referencedAssemblies.Length]
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,3072,3077);

                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,3063,3363) || true) && (i < _referencedAssemblyData.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,3115,3118)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(525,3063,3363))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(525,3063,3363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,3160,3237);

f_525_3160_3236(f_525_3173_3235(_referencedAssemblyData[i], assemblies[i + 1]));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,3259,3344);

boundReferences[i] = f_525_3280_3343(f_525_3309_3335(assemblies[i + 1]), i + 1);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(525,1,301);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(525,1,301);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,3500,3535);

const int 
definitionStartIndex = 1
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,3631,3665);

                // resolve references coming from linked modules:
                for (int 
i = _referencedAssemblyData.Length
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,3622,3999) || true) && (i < _referencedAssemblies.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,3701,3704)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(525,3622,3999))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(525,3622,3999);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,3746,3980);

boundReferences[i] = f_525_3767_3979(_referencedAssemblies[i], assemblies, definitionStartIndex, assemblyIdentityComparer);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(525,1,378);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(525,1,378);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,4019,4042);

return boundReferences;
DynAbs.Tracing.TraceSender.TraceExitMethod(525,2737,4057);

bool
f_525_3173_3235(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
objA,Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
objB)
{
var return_v = ReferenceEquals( (object)objA, (object)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(525, 3173, 3235);
return return_v;
}


int
f_525_3160_3236(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(525, 3160, 3236);
return 0;
}


Microsoft.CodeAnalysis.AssemblyIdentity
f_525_3309_3335(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
this_param)
{
var return_v = this_param.Identity;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(525, 3309, 3335);
return return_v;
}


Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding
f_525_3280_3343(Microsoft.CodeAnalysis.AssemblyIdentity
referenceIdentity,int
definitionIndex)
{
var return_v = new Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding( referenceIdentity, definitionIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(525, 3280, 3343);
return return_v;
}


Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding
f_525_3767_3979(Microsoft.CodeAnalysis.AssemblyIdentity
reference,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
definitions,int
definitionStartIndex,Microsoft.CodeAnalysis.AssemblyIdentityComparer
assemblyIdentityComparer)
{
var return_v = ResolveReferencedAssembly( reference, definitions, definitionStartIndex, assemblyIdentityComparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(525, 3767, 3979);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(525,2737,4057);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(525,2737,4057);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override bool IsMatchingAssembly(TAssemblySymbol? assembly)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(525,4073,4224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,4172,4209);

throw f_525_4178_4208();
DynAbs.Tracing.TraceSender.TraceExitMethod(525,4073,4224);

System.Exception
f_525_4178_4208()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(525, 4178, 4208);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(525,4073,4224);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(525,4073,4224);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override bool ContainsNoPiaLocalTypes
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(525,4317,4417);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,4361,4398);

throw f_525_4367_4397();
DynAbs.Tracing.TraceSender.TraceExitMethod(525,4317,4417);

System.Exception
f_525_4367_4397()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(525, 4367, 4397);
return return_v;
}

                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(525,4240,4432);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(525,4240,4432);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override bool IsLinked
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(525,4510,4586);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,4554,4567);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(525,4510,4586);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(525,4448,4601);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(525,4448,4601);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override bool DeclaresTheObjectClass
{
get
		{
			try
                {
DynAbs.Tracing.TraceSender.TraceEnterMethod(525,4693,4769);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,4737,4750);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(525,4693,4769);
                }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(525,4617,4784);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(525,4617,4784);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override Compilation? SourceCompilation {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(525,4847,4854);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(525,4850,4854);
return null;DynAbs.Tracing.TraceSender.TraceExitMethod(525,4847,4854);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(525,4847,4854);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(525,4847,4854);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

static AssemblyDataForAssemblyBeingBuilt()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(525,528,4866);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(525,528,4866);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(525,528,4866);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(525,528,4866);

static int
f_525_1259_1289(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(525, 1259, 1289);
return 0;
}


bool
f_525_1321_1354_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(525, 1321, 1354);
return return_v;
}


static int
f_525_1308_1355(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(525, 1308, 1355);
return 0;
}


static Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AssemblyIdentity>
f_525_1505_1595(int
capacity)
{
var return_v = ArrayBuilder<AssemblyIdentity>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(525, 1505, 1595);
return return_v;
}


static Microsoft.CodeAnalysis.AssemblyIdentity
f_525_1736_1749(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
this_param)
{
var return_v = this_param.Identity;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(525, 1736, 1749);
return return_v;
}


static int
f_525_1727_1750(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AssemblyIdentity>
this_param,Microsoft.CodeAnalysis.AssemblyIdentity
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(525, 1727, 1750);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
f_525_1663_1685_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(525, 1663, 1685);
return return_v;
}


static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
f_525_1939_1974(Microsoft.CodeAnalysis.PEModule
this_param)
{
var return_v = this_param.ReferencedAssemblies;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(525, 1939, 1974);
return return_v;
}


static int
f_525_1925_1975(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AssemblyIdentity>
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
items)
{
this_param.AddRange( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(525, 1925, 1975);
return 0;
}


static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
f_525_2039_2064(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AssemblyIdentity>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(525, 2039, 2064);
return return_v;
}

}
}
}
