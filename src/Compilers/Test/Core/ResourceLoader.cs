// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace Roslyn.Test.Utilities
{
internal static class ResourceLoader
{
private static Stream GetResourceStream(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25041,403,825);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25041,480,541);

var 
assembly = f_25041_495_540(f_25041_495_531(typeof(ResourceLoader)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25041,557,611);

var 
stream = f_25041_570_610(assembly, name)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25041,625,784) || true) && (stream == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25041,625,784);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25041,677,769);

throw f_25041_683_768($"Resource '{name}' not found in {f_25041_747_764(assembly)}.");
DynAbs.Tracing.TraceSender.TraceExitCondition(25041,625,784);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25041,800,814);

return stream;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25041,403,825);

System.Reflection.TypeInfo
f_25041_495_531(System.Type
type)
{
var return_v = type.GetTypeInfo();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25041, 495, 531);
return return_v;
}


System.Reflection.Assembly
f_25041_495_540(System.Reflection.TypeInfo
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25041, 495, 540);
return return_v;
}


System.IO.Stream?
f_25041_570_610(System.Reflection.Assembly
this_param,string
name)
{
var return_v = this_param.GetManifestResourceStream( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25041, 570, 610);
return return_v;
}


string?
f_25041_747_764(System.Reflection.Assembly
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25041, 747, 764);
return return_v;
}


System.InvalidOperationException
f_25041_683_768(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25041, 683, 768);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25041,403,825);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25041,403,825);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static byte[] GetResourceBlob(string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25041,837,1240);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25041,912,1229);
using(var 
stream = f_25041_932_955(name)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25041,989,1025);

var 
bytes = new byte[f_25041_1010_1023(stream)]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25041,1043,1181);
using(var 
memoryStream = f_25041_1069_1092(bytes)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25041,1134,1162);

f_25041_1134_1161(                    stream, memoryStream);
DynAbs.Tracing.TraceSender.TraceExitUsing(25041,1043,1181);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25041,1201,1214);

return bytes;
DynAbs.Tracing.TraceSender.TraceExitUsing(25041,912,1229);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25041,837,1240);

System.IO.Stream
f_25041_932_955(string
name)
{
var return_v = GetResourceStream( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25041, 932, 955);
return return_v;
}


long
f_25041_1010_1023(System.IO.Stream
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25041, 1010, 1023);
return return_v;
}


System.IO.MemoryStream
f_25041_1069_1092(byte[]
buffer)
{
var return_v = new System.IO.MemoryStream( buffer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25041, 1069, 1092);
return return_v;
}


int
f_25041_1134_1161(System.IO.Stream
this_param,System.IO.MemoryStream
destination)
{
this_param.CopyTo( (System.IO.Stream)destination);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25041, 1134, 1161);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25041,837,1240);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25041,837,1240);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static byte[] GetOrCreateResource(ref byte[] resource, string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25041,1252,1496);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25041,1351,1453) || true) && (resource == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25041,1351,1453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25041,1405,1438);

resource = f_25041_1416_1437(name);
DynAbs.Tracing.TraceSender.TraceExitCondition(25041,1351,1453);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25041,1469,1485);

return resource;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25041,1252,1496);

byte[]
f_25041_1416_1437(string
name)
{
var return_v = GetResourceBlob( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25041, 1416, 1437);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25041,1252,1496);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25041,1252,1496);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static string GetOrCreateResource(ref string resource, string name)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25041,1508,2037);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25041,1607,1994) || true) && (resource == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25041,1607,1994);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25041,1661,1979);
using(var 
stream = f_25041_1681_1704(name)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25041,1746,1960);
using(var 
streamReader = f_25041_1772_1851(stream, f_25041_1797_1810(), detectEncodingFromByteOrderMarks: true)
)                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25041,1901,1937);

resource = f_25041_1912_1936(streamReader);
DynAbs.Tracing.TraceSender.TraceExitUsing(25041,1746,1960);
                    }
DynAbs.Tracing.TraceSender.TraceExitUsing(25041,1661,1979);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(25041,1607,1994);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25041,2010,2026);

return resource;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25041,1508,2037);

System.IO.Stream
f_25041_1681_1704(string
name)
{
var return_v = GetResourceStream( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25041, 1681, 1704);
return return_v;
}


System.Text.Encoding
f_25041_1797_1810()
{
var return_v = Encoding.UTF8;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25041, 1797, 1810);
return return_v;
}


System.IO.StreamReader
f_25041_1772_1851(System.IO.Stream
stream,System.Text.Encoding
encoding,bool
detectEncodingFromByteOrderMarks)
{
var return_v = new System.IO.StreamReader( stream, encoding, detectEncodingFromByteOrderMarks: detectEncodingFromByteOrderMarks);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25041, 1772, 1851);
return return_v;
}


string
f_25041_1912_1936(System.IO.StreamReader
this_param)
{
var return_v = this_param.ReadToEnd();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25041, 1912, 1936);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25041,1508,2037);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25041,1508,2037);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static ResourceLoader()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25041,350,2044);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25041,350,2044);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25041,350,2044);
}

}
}
