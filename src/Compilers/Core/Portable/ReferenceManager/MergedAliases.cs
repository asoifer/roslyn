// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis
{
internal sealed class MergedAliases
{
public ArrayBuilder<string>? AliasesOpt;

public ArrayBuilder<string>? RecursiveAliasesOpt;

internal void Merge(MetadataReference reference)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(533,1324,2309);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,1397,1426);

ArrayBuilder<string> 
aliases
=default(ArrayBuilder<string>);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,1440,2181) || true) && (reference.Properties.HasRecursiveAliases)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(533,1440,2181);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,1518,1777) || true) && (RecursiveAliasesOpt == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(533,1518,1777);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,1591,1648);

RecursiveAliasesOpt = f_533_1613_1647();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,1670,1729);

f_533_1670_1728(                    RecursiveAliasesOpt, reference.Properties.Aliases);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,1751,1758);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(533,1518,1777);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,1797,1827);

aliases = RecursiveAliasesOpt;
DynAbs.Tracing.TraceSender.TraceExitCondition(533,1440,2181);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(533,1440,2181);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,1893,2125) || true) && (AliasesOpt == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(533,1893,2125);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,1957,2005);

AliasesOpt = f_533_1970_2004();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,2027,2077);

f_533_2027_2076(                    AliasesOpt, reference.Properties.Aliases);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,2099,2106);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(533,1893,2125);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,2145,2166);

aliases = AliasesOpt;
DynAbs.Tracing.TraceSender.TraceExitCondition(533,1440,2181);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,2197,2298);

f_533_2197_2297(aliases: aliases, newAliases: reference.Properties.Aliases);
DynAbs.Tracing.TraceSender.TraceExitMethod(533,1324,2309);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
f_533_1613_1647()
{
var return_v = ArrayBuilder<string>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(533, 1613, 1647);
return return_v;
}


int
f_533_1670_1728(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
this_param,System.Collections.Immutable.ImmutableArray<string>
items)
{
this_param.AddRange( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(533, 1670, 1728);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
f_533_1970_2004()
{
var return_v = ArrayBuilder<string>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(533, 1970, 2004);
return return_v;
}


int
f_533_2027_2076(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
this_param,System.Collections.Immutable.ImmutableArray<string>
items)
{
this_param.AddRange( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(533, 2027, 2076);
return 0;
}


int
f_533_2197_2297(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
aliases,System.Collections.Immutable.ImmutableArray<string>
newAliases)
{
Merge( aliases: aliases, newAliases: newAliases);
DynAbs.Tracing.TraceSender.TraceEndInvocation(533, 2197, 2297);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(533,1324,2309);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(533,1324,2309);
}
		}

internal static void Merge(ArrayBuilder<string> aliases, ImmutableArray<string> newAliases)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(533,2321,2657);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,2437,2594) || true) && (f_533_2441_2454(aliases)== 0 ^ newAliases.IsEmpty)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(533,2437,2594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,2514,2579);

f_533_2514_2578(aliases, MetadataReferenceProperties.GlobalAlias);
DynAbs.Tracing.TraceSender.TraceExitCondition(533,2437,2594);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,2610,2646);

f_533_2610_2645(aliases, newAliases);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(533,2321,2657);

int
f_533_2441_2454(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(533, 2441, 2454);
return return_v;
}


int
f_533_2514_2578(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
builder,string
item)
{
AddNonIncluded( builder, item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(533, 2514, 2578);
return 0;
}


int
f_533_2610_2645(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
builder,System.Collections.Immutable.ImmutableArray<string>
items)
{
AddNonIncluded( builder, items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(533, 2610, 2645);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(533,2321,2657);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(533,2321,2657);
}
		}

internal static ImmutableArray<string> Merge(ImmutableArray<string> aliasesOpt, ImmutableArray<string> newAliases)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(533,2669,3122);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,2808,2899) || true) && (aliasesOpt.IsDefault)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(533,2808,2899);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,2866,2884);

return newAliases;
DynAbs.Tracing.TraceSender.TraceExitCondition(533,2808,2899);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,2915,2980);

var 
result = f_533_2928_2979(aliasesOpt.Length)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,2994,3022);

f_533_2994_3021(            result, aliasesOpt);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,3036,3062);

f_533_3036_3061(result, newAliases);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,3076,3111);

return f_533_3083_3110(result);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(533,2669,3122);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
f_533_2928_2979(int
capacity)
{
var return_v = ArrayBuilder<string>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(533, 2928, 2979);
return return_v;
}


int
f_533_2994_3021(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
this_param,System.Collections.Immutable.ImmutableArray<string>
items)
{
this_param.AddRange( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(533, 2994, 3021);
return 0;
}


int
f_533_3036_3061(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
aliases,System.Collections.Immutable.ImmutableArray<string>
newAliases)
{
Merge( aliases, newAliases);
DynAbs.Tracing.TraceSender.TraceEndInvocation(533, 3036, 3061);
return 0;
}


System.Collections.Immutable.ImmutableArray<string>
f_533_3083_3110(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(533, 3083, 3110);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(533,2669,3122);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(533,2669,3122);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static void AddNonIncluded(ArrayBuilder<string> builder, string item)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(533,3134,3341);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,3236,3330) || true) && (!f_533_3241_3263(builder, item))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(533,3236,3330);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,3297,3315);

f_533_3297_3314(                builder, item);
DynAbs.Tracing.TraceSender.TraceExitCondition(533,3236,3330);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(533,3134,3341);

bool
f_533_3241_3263(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(533, 3241, 3263);
return return_v;
}


int
f_533_3297_3314(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(533, 3297, 3314);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(533,3134,3341);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(533,3134,3341);
}
		}

private static void AddNonIncluded(ArrayBuilder<string> builder, ImmutableArray<string> items)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(533,3353,3734);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,3472,3506);

int 
originalCount = f_533_3492_3505(builder)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,3522,3723);
foreach(var item in f_533_3543_3548_I(items) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(533,3522,3723);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,3582,3708) || true) && (f_533_3586_3625(builder, item, 0, originalCount)< 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(533,3582,3708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,3671,3689);

f_533_3671_3688(                    builder, item);
DynAbs.Tracing.TraceSender.TraceExitCondition(533,3582,3708);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(533,3522,3723);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(533,1,202);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(533,1,202);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(533,3353,3734);

int
f_533_3492_3505(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(533, 3492, 3505);
return return_v;
}


int
f_533_3586_3625(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
this_param,string
item,int
startIndex,int
count)
{
var return_v = this_param.IndexOf( item, startIndex, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(533, 3586, 3625);
return return_v;
}


int
f_533_3671_3688(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(533, 3671, 3688);
return 0;
}


System.Collections.Immutable.ImmutableArray<string>
f_533_3543_3548_I(System.Collections.Immutable.ImmutableArray<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(533, 3543, 3548);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(533,3353,3734);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(533,3353,3734);
}
		}

public MergedAliases()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(533,360,3741);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,441,451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(533,491,510);
DynAbs.Tracing.TraceSender.TraceExitConstructor(533,360,3741);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(533,360,3741);
}


static MergedAliases()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(533,360,3741);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(533,360,3741);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(533,360,3741);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(533,360,3741);
}
}
