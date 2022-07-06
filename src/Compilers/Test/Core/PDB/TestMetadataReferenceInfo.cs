// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.IO;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.InternalUtilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Utilities;

namespace Roslyn.Test.Utilities.PDB
{
internal class TestMetadataReferenceInfo : IDisposable
{
public readonly Compilation Compilation;

public readonly TestMetadataReference MetadataReference;

public readonly MetadataReferenceInfo MetadataReferenceInfo;

private bool _disposedValue;

private readonly MemoryStream _emitStream;

private readonly PEReader _peReader;

public TestMetadataReferenceInfo(
            MemoryStream emitStream,
            Compilation compilation,
            TestMetadataReference metadataReference,
            string fullPath)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25126,970,1987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,674,685);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,734,751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,845,859);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,900,911);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,948,957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,1188,1213);

_emitStream = emitStream;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,1227,1264);

_peReader = f_25126_1239_1263(emitStream);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,1278,1304);

Compilation = compilation;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,1318,1356);

MetadataReference = metadataReference;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,1372,1423);

var 
metadataReader = f_25126_1393_1422(_peReader)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,1437,1497);

var 
moduleDefinition = f_25126_1460_1496(metadataReader)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,1513,1976);

MetadataReferenceInfo = f_25126_1537_1975(f_25126_1581_1625(f_25126_1581_1611(f_25126_1581_1600(_peReader))), f_25126_1644_1684(f_25126_1644_1672(f_25126_1644_1663(_peReader))), f_25126_1703_1738(fullPath), f_25126_1757_1802(                metadataReader, moduleDefinition.Mvid), metadataReference.Properties.Aliases, metadataReference.Properties.Kind, metadataReference.Properties.EmbedInteropTypes);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25126,970,1987);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25126,970,1987);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25126,970,1987);
}
		}

public static TestMetadataReferenceInfo Create(Compilation compilation, string fullPath, EmitOptions emitOptions)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25126,1999,2550);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,2137,2192);

var 
emitStream = f_25126_2154_2191(compilation, emitOptions)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,2208,2269);

var 
metadata = f_25126_2223_2268(emitStream)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,2283,2363);

var 
metadataReference = f_25126_2307_2362(metadata, fullPath: fullPath)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,2379,2539);

return f_25126_2386_2538(emitStream, compilation, metadataReference, fullPath);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25126,1999,2550);

System.IO.MemoryStream
f_25126_2154_2191(Microsoft.CodeAnalysis.Compilation
compilation,Microsoft.CodeAnalysis.Emit.EmitOptions
options)
{
var return_v = compilation.EmitToStream( options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25126, 2154, 2191);
return return_v;
}


Microsoft.CodeAnalysis.AssemblyMetadata
f_25126_2223_2268(System.IO.MemoryStream
peStream)
{
var return_v = AssemblyMetadata.CreateFromStream( (System.IO.Stream)peStream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25126, 2223, 2268);
return return_v;
}


Roslyn.Test.Utilities.TestMetadataReference
f_25126_2307_2362(Microsoft.CodeAnalysis.AssemblyMetadata
metadata,string
fullPath)
{
var return_v = new Roslyn.Test.Utilities.TestMetadataReference( (Microsoft.CodeAnalysis.Metadata)metadata, fullPath: fullPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25126, 2307, 2362);
return return_v;
}


Roslyn.Test.Utilities.PDB.TestMetadataReferenceInfo
f_25126_2386_2538(System.IO.MemoryStream
emitStream,Microsoft.CodeAnalysis.Compilation
compilation,Roslyn.Test.Utilities.TestMetadataReference
metadataReference,string
fullPath)
{
var return_v = new Roslyn.Test.Utilities.PDB.TestMetadataReferenceInfo( emitStream, compilation, metadataReference, fullPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25126, 2386, 2538);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25126,1999,2550);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25126,1999,2550);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected virtual void Dispose(bool disposing)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25126,2562,2892);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,2633,2881) || true) && (!_disposedValue)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25126,2633,2881);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,2686,2824) || true) && (disposing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25126,2686,2824);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,2741,2761);

f_25126_2741_2760(                    _peReader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,2783,2805);

f_25126_2783_2804(                    _emitStream);
DynAbs.Tracing.TraceSender.TraceExitCondition(25126,2686,2824);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,2844,2866);

_disposedValue = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(25126,2633,2881);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25126,2562,2892);

int
f_25126_2741_2760(System.Reflection.PortableExecutable.PEReader
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25126, 2741, 2760);
return 0;
}


int
f_25126_2783_2804(System.IO.MemoryStream
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25126, 2783, 2804);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25126,2562,2892);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25126,2562,2892);
}
		}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25126,2904,3120);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,3044,3069);

f_25126_3044_3068(this, disposing: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25126,3083,3109);

f_25126_3083_3108(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(25126,2904,3120);

int
f_25126_3044_3068(Roslyn.Test.Utilities.PDB.TestMetadataReferenceInfo
this_param,bool
disposing)
{
this_param.Dispose( disposing: disposing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25126, 3044, 3068);
return 0;
}


int
f_25126_3083_3108(Roslyn.Test.Utilities.PDB.TestMetadataReferenceInfo
obj)
{
GC.SuppressFinalize( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25126, 3083, 3108);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25126,2904,3120);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25126,2904,3120);
}
		}

static TestMetadataReferenceInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25126,575,3127);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25126,575,3127);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25126,575,3127);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25126,575,3127);

static System.Reflection.PortableExecutable.PEReader
f_25126_1239_1263(System.IO.MemoryStream
peStream)
{
var return_v = new System.Reflection.PortableExecutable.PEReader( (System.IO.Stream)peStream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25126, 1239, 1263);
return return_v;
}


static System.Reflection.Metadata.MetadataReader
f_25126_1393_1422(System.Reflection.PortableExecutable.PEReader
peReader)
{
var return_v = peReader.GetMetadataReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25126, 1393, 1422);
return return_v;
}


static System.Reflection.Metadata.ModuleDefinition
f_25126_1460_1496(System.Reflection.Metadata.MetadataReader
this_param)
{
var return_v = this_param.GetModuleDefinition();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25126, 1460, 1496);
return return_v;
}


static System.Reflection.PortableExecutable.PEHeaders
f_25126_1581_1600(System.Reflection.PortableExecutable.PEReader
this_param)
{
var return_v = this_param.PEHeaders;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25126, 1581, 1600);
return return_v;
}


static System.Reflection.PortableExecutable.CoffHeader
f_25126_1581_1611(System.Reflection.PortableExecutable.PEHeaders
this_param)
{
var return_v = this_param.CoffHeader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25126, 1581, 1611);
return return_v;
}


static int
f_25126_1581_1625(System.Reflection.PortableExecutable.CoffHeader
this_param)
{
var return_v = this_param.TimeDateStamp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25126, 1581, 1625);
return return_v;
}


static System.Reflection.PortableExecutable.PEHeaders
f_25126_1644_1663(System.Reflection.PortableExecutable.PEReader
this_param)
{
var return_v = this_param.PEHeaders;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25126, 1644, 1663);
return return_v;
}


static System.Reflection.PortableExecutable.PEHeader?
f_25126_1644_1672(System.Reflection.PortableExecutable.PEHeaders
this_param)
{
var return_v = this_param.PEHeader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25126, 1644, 1672);
return return_v;
}


static int
f_25126_1644_1684(System.Reflection.PortableExecutable.PEHeader?
this_param)
{
var return_v = this_param.SizeOfImage;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25126, 1644, 1684);
return return_v;
}


static string?
f_25126_1703_1738(string
path)
{
var return_v = PathUtilities.GetFileName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25126, 1703, 1738);
return return_v;
}


static System.Guid
f_25126_1757_1802(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.GuidHandle
handle)
{
var return_v = this_param.GetGuid( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25126, 1757, 1802);
return return_v;
}


static Roslyn.Test.Utilities.PDB.MetadataReferenceInfo
f_25126_1537_1975(int
timestamp,int
imageSize,string
name,System.Guid
mvid,System.Collections.Immutable.ImmutableArray<string>
externAliases,Microsoft.CodeAnalysis.MetadataImageKind
kind,bool
embedInteropTypes)
{
var return_v = new Roslyn.Test.Utilities.PDB.MetadataReferenceInfo( timestamp, imageSize, name, mvid, externAliases, kind, embedInteropTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25126, 1537, 1975);
return return_v;
}

}
}
