// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.IO;
using Microsoft.CodeAnalysis;

namespace Roslyn.Test.Utilities
{
public class TestMetadataReference : PortableExecutableReference
{
private readonly Metadata _metadata;

private readonly string _display;

public TestMetadataReference(Metadata metadata = null, string fullPath = null, string display = null)
:base(f_25117_666_702_C(MetadataReferenceProperties.Assembly) ,fullPath)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25117,544,803);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25117,479,488);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25117,523,531);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25117,738,759);

_metadata = metadata;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25117,773,792);

_display = display;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25117,544,803);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25117,544,803);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25117,544,803);
}
		}

public override string Display
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25117,870,937);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25117,906,922);

return _display;
DynAbs.Tracing.TraceSender.TraceExitMethod(25117,870,937);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25117,815,948);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25117,815,948);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected override DocumentationProvider CreateDocumentationProvider()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25117,960,1103);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25117,1055,1092);

return f_25117_1062_1091();
DynAbs.Tracing.TraceSender.TraceExitMethod(25117,960,1103);

Microsoft.CodeAnalysis.DocumentationProvider
f_25117_1062_1091()
{
var return_v = DocumentationProvider.Default;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25117, 1062, 1091);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25117,960,1103);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25117,960,1103);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override Metadata GetMetadataImpl()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25117,1115,1333);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25117,1185,1289) || true) && (_metadata == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25117,1185,1289);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25117,1240,1274);

throw f_25117_1246_1273();
DynAbs.Tracing.TraceSender.TraceExitCondition(25117,1185,1289);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25117,1305,1322);

return _metadata;
DynAbs.Tracing.TraceSender.TraceExitMethod(25117,1115,1333);

System.IO.FileNotFoundException
f_25117_1246_1273()
{
var return_v = new System.IO.FileNotFoundException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25117, 1246, 1273);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25117,1115,1333);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25117,1115,1333);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override PortableExecutableReference WithPropertiesImpl(MetadataReferenceProperties properties)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25117,1345,1522);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25117,1475,1511);

throw f_25117_1481_1510();
DynAbs.Tracing.TraceSender.TraceExitMethod(25117,1345,1522);

System.NotImplementedException
f_25117_1481_1510()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25117, 1481, 1510);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25117,1345,1522);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25117,1345,1522);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static TestMetadataReference()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25117,372,1529);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25117,372,1529);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25117,372,1529);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25117,372,1529);

static Microsoft.CodeAnalysis.MetadataReferenceProperties
f_25117_666_702_C(Microsoft.CodeAnalysis.MetadataReferenceProperties
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(25117, 544, 803);
return return_v;
}

}
public class TestImageReference : PortableExecutableReference
{
private readonly ImmutableArray<byte> _metadataBytes;

private readonly string _display;

public TestImageReference(byte[] metadataBytes, string display)
:this(f_25117_1807_1843_C(f_25117_1807_1843(metadataBytes)) ,display)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25117,1723,1875);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25117,1723,1875);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25117,1723,1875);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25117,1723,1875);
}
		}

public TestImageReference(ImmutableArray<byte> metadataBytes, string display)
:base(f_25117_1985_2021_C(MetadataReferenceProperties.Assembly) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25117,1887,2122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25117,1702,1710);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25117,2047,2078);

_metadataBytes = metadataBytes;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25117,2092,2111);

_display = display;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25117,1887,2122);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25117,1887,2122);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25117,1887,2122);
}
		}

public override string Display
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25117,2189,2256);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25117,2225,2241);

return _display;
DynAbs.Tracing.TraceSender.TraceExitMethod(25117,2189,2256);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25117,2134,2267);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25117,2134,2267);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected override DocumentationProvider CreateDocumentationProvider()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25117,2279,2422);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25117,2374,2411);

return f_25117_2381_2410();
DynAbs.Tracing.TraceSender.TraceExitMethod(25117,2279,2422);

Microsoft.CodeAnalysis.DocumentationProvider
f_25117_2381_2410()
{
var return_v = DocumentationProvider.Default;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25117, 2381, 2410);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25117,2279,2422);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25117,2279,2422);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override Metadata GetMetadataImpl()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25117,2434,2571);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25117,2504,2560);

return f_25117_2511_2559(_metadataBytes);
DynAbs.Tracing.TraceSender.TraceExitMethod(25117,2434,2571);

Microsoft.CodeAnalysis.AssemblyMetadata
f_25117_2511_2559(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = AssemblyMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25117, 2511, 2559);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25117,2434,2571);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25117,2434,2571);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override PortableExecutableReference WithPropertiesImpl(MetadataReferenceProperties properties)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25117,2583,2760);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25117,2713,2749);

throw f_25117_2719_2748();
DynAbs.Tracing.TraceSender.TraceExitMethod(25117,2583,2760);

System.NotImplementedException
f_25117_2719_2748()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25117, 2719, 2748);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25117,2583,2760);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25117,2583,2760);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static TestImageReference()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25117,1537,2767);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25117,1537,2767);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25117,1537,2767);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25117,1537,2767);

static System.Collections.Immutable.ImmutableArray<byte>
f_25117_1807_1843(params byte[]
items)
{
var return_v = ImmutableArray.Create( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25117, 1807, 1843);
return return_v;
}


static System.Collections.Immutable.ImmutableArray<byte>
f_25117_1807_1843_C(System.Collections.Immutable.ImmutableArray<byte>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(25117, 1723, 1875);
return return_v;
}


static Microsoft.CodeAnalysis.MetadataReferenceProperties
f_25117_1985_2021_C(Microsoft.CodeAnalysis.MetadataReferenceProperties
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(25117, 1887, 2122);
return return_v;
}

}
}
