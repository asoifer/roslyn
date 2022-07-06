// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
public static class ImmutableArrayTestExtensions
{
private const int 
BufferSize = 4096
;

internal static void WriteToFile(this ImmutableArray<byte> bytes, string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25092,895,1163);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25092,998,1105);

using var 
fileStream = f_25092_1021_1104(path, FileMode.Create, FileAccess.Write, FileShare.Read, BufferSize)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25092,1119,1152);

WriteToStream(bytes,fileStream);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25092,895,1163);

System.IO.FileStream
f_25092_1021_1104(string
path,System.IO.FileMode
mode,System.IO.FileAccess
access,System.IO.FileShare
share,int
bufferSize)
{
var return_v = new System.IO.FileStream( path, mode, access, share, bufferSize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25092, 1021, 1104);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25092,895,1163);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25092,895,1163);
}
		}

internal static void WriteToStream(this ImmutableArray<byte> bytes, Stream stream)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25092,1175,1781);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25092,1282,1310);

const int 
bufferSize = 4096
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25092,1390,1448);

var 
buffer = new byte[f_25092_1412_1446(bufferSize, bytes.Length)]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25092,1464,1479);

int 
offset = 0
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25092,1493,1770) || true) && (offset < bytes.Length)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25092,1493,1770);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25092,1555,1612);

int 
length = f_25092_1568_1611(bufferSize, bytes.Length - offset)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25092,1630,1670);

bytes.CopyTo(offset,buffer,0,length);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25092,1688,1720);

f_25092_1688_1719(                stream, buffer, 0, length);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25092,1738,1755);

offset += length;
DynAbs.Tracing.TraceSender.TraceExitCondition(25092,1493,1770);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25092,1493,1770);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25092,1493,1770);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25092,1175,1781);

int
f_25092_1412_1446(int
val1,int
val2)
{
var return_v = Math.Min( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25092, 1412, 1446);
return return_v;
}


int
f_25092_1568_1611(int
val1,int
val2)
{
var return_v = Math.Min( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25092, 1568, 1611);
return return_v;
}


int
f_25092_1688_1719(System.IO.Stream
this_param,byte[]
buffer,int
offset,int
count)
{
this_param.Write( buffer, offset, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25092, 1688, 1719);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25092,1175,1781);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25092,1175,1781);
}
		}

static ImmutableArrayTestExtensions()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25092,548,1788);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25092,631,648);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25092,548,1788);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25092,548,1788);
}

}
}
