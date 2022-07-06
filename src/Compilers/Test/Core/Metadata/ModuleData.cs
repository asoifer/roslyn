// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.Emit;
using Roslyn.Utilities;

namespace Roslyn.Test.Utilities
{

public readonly struct ModuleDataId
    {

public string SimpleName {get; }

public string FullName {get; }

public Guid Mvid {get; }

public ModuleDataId(Assembly assembly, Guid mvid)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25108,836,1027);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,910,947);

SimpleName = f_25108_923_946(f_25108_923_941(assembly));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,961,990);

FullName = f_25108_972_989(assembly);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,1004,1016);

Mvid = mvid;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25108,836,1027);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25108,836,1027);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25108,836,1027);
}
		}

public ModuleDataId(string simpleName, string fullName, Guid mvid)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25108,1039,1225);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,1130,1154);

SimpleName = simpleName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,1168,1188);

FullName = fullName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,1202,1214);

Mvid = mvid;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25108,1039,1225);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25108,1039,1225);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25108,1039,1225);
}
		}

public override string ToString()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25108,1237,1336);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,1295,1325);

return $"{FullName} - {Mvid}";
DynAbs.Tracing.TraceSender.TraceExitMethod(25108,1237,1336);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25108,1237,1336);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25108,1237,1336);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
static ModuleDataId(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25108,663,1343);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25108,663,1343);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25108,663,1343);
}

static System.Reflection.AssemblyName
f_25108_923_941(System.Reflection.Assembly
this_param)
{
var return_v = this_param.GetName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25108, 923, 941);
return return_v;
}


static string?
f_25108_923_946(System.Reflection.AssemblyName
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25108, 923, 946);
return return_v;
}


static string?
f_25108_972_989(System.Reflection.Assembly
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25108, 972, 989);
return return_v;
}

    }
[DebuggerDisplay("{GetDebuggerDisplay()}")]
    public sealed class ModuleData
{
public readonly ModuleDataId Id;

public readonly OutputKind Kind;

public readonly ImmutableArray<byte> Image;

public readonly ImmutableArray<byte> Pdb;

public readonly bool InMemoryModule;

public string SimpleName {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25108,1710,1726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,1713,1726);
return Id.SimpleName;DynAbs.Tracing.TraceSender.TraceExitMethod(25108,1710,1726);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25108,1710,1726);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25108,1710,1726);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public string FullName {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25108,1760,1774);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,1763,1774);
return Id.FullName;DynAbs.Tracing.TraceSender.TraceExitMethod(25108,1760,1774);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25108,1760,1774);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25108,1760,1774);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public Guid Mvid {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25108,1802,1812);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,1805,1812);
return Id.Mvid;DynAbs.Tracing.TraceSender.TraceExitMethod(25108,1802,1812);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25108,1802,1812);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25108,1802,1812);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public ModuleData(string netModuleName, ImmutableArray<byte> image, ImmutableArray<byte> pdb, bool inMemoryModule)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25108,1825,2208);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,1518,1522);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,1658,1672);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,1964,2037);

this.Id = f_25108_1974_2036(netModuleName, netModuleName, f_25108_2021_2035(image));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,2051,2084);

this.Kind = OutputKind.NetModule;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,2098,2117);

this.Image = image;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,2131,2146);

this.Pdb = pdb;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,2160,2197);

this.InMemoryModule = inMemoryModule;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25108,1825,2208);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25108,1825,2208);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25108,1825,2208);
}
		}

public ModuleData(AssemblyIdentity identity, OutputKind kind, ImmutableArray<byte> image, ImmutableArray<byte> pdb, bool inMemoryModule)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25108,2220,2621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,1518,1522);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,1658,1672);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,2381,2466);

this.Id = f_25108_2391_2465(f_25108_2408_2421(identity), f_25108_2423_2448(identity), f_25108_2450_2464(image));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,2480,2497);

this.Kind = kind;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,2511,2530);

this.Image = image;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,2544,2559);

this.Pdb = pdb;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,2573,2610);

this.InMemoryModule = inMemoryModule;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25108,2220,2621);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25108,2220,2621);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25108,2220,2621);
}
		}

public ModuleData(ModuleDataId id, OutputKind kind, ImmutableArray<byte> image, ImmutableArray<byte> pdb, bool inMemoryModule)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25108,2633,2952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,1518,1522);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,1658,1672);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,2784,2797);

this.Id = id;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,2811,2828);

this.Kind = kind;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,2842,2861);

this.Image = image;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,2875,2890);

this.Pdb = pdb;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,2904,2941);

this.InMemoryModule = inMemoryModule;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25108,2633,2952);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25108,2633,2952);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25108,2633,2952);
}
		}

private static Guid GetMvid(ImmutableArray<byte> image)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25108,2964,3200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,3044,3189);
using(var 
metadata = f_25108_3066_3103(image)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,3137,3174);

return f_25108_3144_3173(metadata);
DynAbs.Tracing.TraceSender.TraceExitUsing(25108,3044,3189);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25108,2964,3200);

Microsoft.CodeAnalysis.ModuleMetadata
f_25108_3066_3103(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25108, 3066, 3103);
return return_v;
}


System.Guid
f_25108_3144_3173(Microsoft.CodeAnalysis.ModuleMetadata
this_param)
{
var return_v = this_param.GetModuleVersionId();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25108, 3144, 3173);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25108,2964,3200);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25108,2964,3200);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string GetDebuggerDisplay()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25108,3212,3319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25108,3272,3308);

return f_25108_3279_3287()+ " {" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_25108_3297_3301()).ToString(),25108,3297,3301)+ "}";
DynAbs.Tracing.TraceSender.TraceExitMethod(25108,3212,3319);

string
f_25108_3279_3287()
{
var return_v = FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25108, 3279, 3287);
return return_v;
}


System.Guid
f_25108_3297_3301()
{
var return_v = Mvid;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25108, 3297, 3301);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25108,3212,3319);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25108,3212,3319);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static ModuleData()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25108,1351,3326);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25108,1351,3326);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25108,1351,3326);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25108,1351,3326);

static System.Guid
f_25108_2021_2035(System.Collections.Immutable.ImmutableArray<byte>
image)
{
var return_v = GetMvid( image);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25108, 2021, 2035);
return return_v;
}


static Roslyn.Test.Utilities.ModuleDataId
f_25108_1974_2036(string
simpleName,string
fullName,System.Guid
mvid)
{
var return_v = new Roslyn.Test.Utilities.ModuleDataId( simpleName, fullName, mvid);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25108, 1974, 2036);
return return_v;
}


static string
f_25108_2408_2421(Microsoft.CodeAnalysis.AssemblyIdentity
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25108, 2408, 2421);
return return_v;
}


static string
f_25108_2423_2448(Microsoft.CodeAnalysis.AssemblyIdentity
this_param)
{
var return_v = this_param.GetDisplayName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25108, 2423, 2448);
return return_v;
}


static System.Guid
f_25108_2450_2464(System.Collections.Immutable.ImmutableArray<byte>
image)
{
var return_v = GetMvid( image);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25108, 2450, 2464);
return return_v;
}


static Roslyn.Test.Utilities.ModuleDataId
f_25108_2391_2465(string
simpleName,string
fullName,System.Guid
mvid)
{
var return_v = new Roslyn.Test.Utilities.ModuleDataId( simpleName, fullName, mvid);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25108, 2391, 2465);
return return_v;
}

}
}
