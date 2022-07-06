// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;

namespace Roslyn.Test.Utilities
{
internal class TestMetadataReferenceResolver : MetadataReferenceResolver
{
private readonly RelativePathResolver _pathResolver;

private readonly Dictionary<string, PortableExecutableReference> _assemblyNames;

private readonly Dictionary<string, PortableExecutableReference> _files;

public TestMetadataReferenceResolver(
            RelativePathResolver pathResolver = null,
            Dictionary<string, PortableExecutableReference> assemblyNames = null,
            Dictionary<string, PortableExecutableReference> files = null)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25118,739,1242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25118,541,554);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25118,630,644);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25118,720,726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25118,1014,1043);

_pathResolver = pathResolver;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25118,1057,1145);

_assemblyNames = assemblyNames ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PortableExecutableReference>?>(25118, 1074, 1144)??f_25118_1091_1144());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25118,1159,1231);

_files = files ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PortableExecutableReference>?>(25118, 1168, 1230)??f_25118_1177_1230());
DynAbs.Tracing.TraceSender.TraceExitConstructor(25118,739,1242);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25118,739,1242);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25118,739,1242);
}
		}

public override ImmutableArray<PortableExecutableReference> ResolveReference(string reference, string baseFilePath, MetadataReferenceProperties properties)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25118,1254,2193);
Microsoft.CodeAnalysis.PortableExecutableReference result = default(Microsoft.CodeAnalysis.PortableExecutableReference);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25118,1434,1486);

Dictionary<string, PortableExecutableReference> 
map
=default(Dictionary<string, PortableExecutableReference>);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25118,1502,2032) || true) && (f_25118_1506_1541(reference))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25118,1502,2032);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25118,1575,1897) || true) && (_pathResolver != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25118,1575,1897);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25118,1642,1705);

reference = f_25118_1654_1704(_pathResolver, reference, baseFilePath);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25118,1727,1878) || true) && (reference == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25118,1727,1878);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25118,1798,1855);

return ImmutableArray<PortableExecutableReference>.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(25118,1727,1878);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25118,1575,1897);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25118,1917,1930);

map = _files;
DynAbs.Tracing.TraceSender.TraceExitCondition(25118,1502,2032);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25118,1502,2032);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25118,1996,2017);

map = _assemblyNames;
DynAbs.Tracing.TraceSender.TraceExitCondition(25118,1502,2032);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25118,2048,2182);

return (DynAbs.Tracing.TraceSender.Conditional_F1(25118, 2055, 2097)||((f_25118_2055_2097(map, reference, out result)&&DynAbs.Tracing.TraceSender.Conditional_F2(25118, 2100, 2129))||DynAbs.Tracing.TraceSender.Conditional_F3(25118, 2132, 2181)))?f_25118_2100_2129(result):ImmutableArray<PortableExecutableReference>.Empty;
DynAbs.Tracing.TraceSender.TraceExitMethod(25118,1254,2193);

bool
f_25118_1506_1541(string
assemblyDisplayNameOrPath)
{
var return_v = PathUtilities.IsFilePath( assemblyDisplayNameOrPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25118, 1506, 1541);
return return_v;
}


string
f_25118_1654_1704(Microsoft.CodeAnalysis.RelativePathResolver
this_param,string
reference,string
baseFilePath)
{
var return_v = this_param.ResolvePath( reference, baseFilePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25118, 1654, 1704);
return return_v;
}


bool
f_25118_2055_2097(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PortableExecutableReference>
this_param,string
key,out Microsoft.CodeAnalysis.PortableExecutableReference
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25118, 2055, 2097);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PortableExecutableReference>
f_25118_2100_2129(Microsoft.CodeAnalysis.PortableExecutableReference
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25118, 2100, 2129);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25118,1254,2193);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25118,1254,2193);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override bool Equals(object other) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25118,2247,2254);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25118,2250,2254);
return true;DynAbs.Tracing.TraceSender.TraceExitMethod(25118,2247,2254);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25118,2247,2254);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25118,2247,2254);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override int GetHashCode() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25118,2299,2303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25118,2302,2303);
return 1;DynAbs.Tracing.TraceSender.TraceExitMethod(25118,2299,2303);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25118,2299,2303);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25118,2299,2303);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static TestMetadataReferenceResolver()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25118,414,2311);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25118,414,2311);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25118,414,2311);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25118,414,2311);

static System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PortableExecutableReference>
f_25118_1091_1144()
{
var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PortableExecutableReference>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25118, 1091, 1144);
return return_v;
}


static System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PortableExecutableReference>
f_25118_1177_1230()
{
var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PortableExecutableReference>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25118, 1177, 1230);
return return_v;
}

}
}
