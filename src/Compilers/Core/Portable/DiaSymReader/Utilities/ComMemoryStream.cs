// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices;
using STATSTG = System.Runtime.InteropServices.ComTypes.STATSTG;

namespace Microsoft.DiaSymReader
{
internal sealed unsafe class ComMemoryStream : IUnsafeComStream
{
internal const int 
STREAM_SEEK_SET = 0
;

internal const int 
STREAM_SEEK_CUR = 1
;

internal const int 
STREAM_SEEK_END = 2
;

private readonly int _chunkSize;

private readonly List<byte[]> _chunks ;

private int _position;

private int _length;

public ComMemoryStream(int chunkSize = 32768)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(743,1424,1528);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,1270,1280);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,1321,1349);
this._chunks = f_743_1331_1349();DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,1372,1381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,1404,1411);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,1494,1517);

_chunkSize = chunkSize;
DynAbs.Tracing.TraceSender.TraceExitConstructor(743,1424,1528);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(743,1424,1528);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(743,1424,1528);
}
		}

public void CopyTo(Stream stream)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(743,1540,2773);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,1787,1898) || true) && (f_743_1791_1805(stream))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(743,1787,1898);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,1839,1883);

f_743_1839_1882(                stream, f_743_1856_1871(stream)+ _length);
DynAbs.Tracing.TraceSender.TraceExitCondition(743,1787,1898);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,1914,1933);

int 
chunkIndex = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,1947,1976);

int 
remainingBytes = _length
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,1990,2762) || true) && (remainingBytes > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(743,1990,2762);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,2049,2065);

int 
bytesToCopy
=default(int);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,2083,2697) || true) && (chunkIndex < f_743_2100_2113(_chunks))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(743,2083,2697);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,2155,2187);

var 
chunk = f_743_2167_2186(_chunks, chunkIndex)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,2209,2262);

bytesToCopy = f_743_2223_2261(f_743_2232_2244(chunk), remainingBytes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,2284,2320);

f_743_2284_2319(                    stream, chunk, 0, bytesToCopy);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,2342,2355);

chunkIndex++;
DynAbs.Tracing.TraceSender.TraceExitCondition(743,2083,2697);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(743,2083,2697);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,2498,2527);

bytesToCopy = remainingBytes;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,2558,2563);
                    for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,2549,2678) || true) && (i < bytesToCopy)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,2582,2585)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(743,2549,2678))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(743,2549,2678);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,2635,2655);

f_743_2635_2654(                        stream, 0);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(743,1,130);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(743,1,130);
}DynAbs.Tracing.TraceSender.TraceExitCondition(743,2083,2697);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,2717,2747);

remainingBytes -= bytesToCopy;
DynAbs.Tracing.TraceSender.TraceExitCondition(743,1990,2762);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(743,1990,2762);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(743,1990,2762);
}DynAbs.Tracing.TraceSender.TraceExitMethod(743,1540,2773);

bool
f_743_1791_1805(System.IO.Stream
this_param)
{
var return_v = this_param.CanSeek;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(743, 1791, 1805);
return return_v;
}


long
f_743_1856_1871(System.IO.Stream
this_param)
{
var return_v = this_param.Position ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(743, 1856, 1871);
return return_v;
}


int
f_743_1839_1882(System.IO.Stream
this_param,long
value)
{
this_param.SetLength( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 1839, 1882);
return 0;
}


int
f_743_2100_2113(System.Collections.Generic.List<byte[]>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(743, 2100, 2113);
return return_v;
}


byte[]
f_743_2167_2186(System.Collections.Generic.List<byte[]>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(743, 2167, 2186);
return return_v;
}


int
f_743_2232_2244(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(743, 2232, 2244);
return return_v;
}


int
f_743_2223_2261(int
val1,int
val2)
{
var return_v = Math.Min( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 2223, 2261);
return return_v;
}


int
f_743_2284_2319(System.IO.Stream
this_param,byte[]
buffer,int
offset,int
count)
{
this_param.Write( buffer, offset, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 2284, 2319);
return 0;
}


int
f_743_2635_2654(System.IO.Stream
this_param,int
value)
{
this_param.WriteByte( (byte)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 2635, 2654);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(743,1540,2773);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(743,1540,2773);
}
		}

public IEnumerable<ArraySegment<byte>> GetChunks()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(743,2785,3776);

var listYield= new List<ArraySegment<Byte>>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,2860,2879);

int 
chunkIndex = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,2893,2922);

int 
remainingBytes = _length
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,2936,3765) || true) && (remainingBytes > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(743,2936,3765);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,2995,3011);

int 
bytesToCopy
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,3031,3044);

byte[] 
chunk
=default(byte[]);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,3062,3621) || true) && (chunkIndex < f_743_3079_3092(_chunks))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(743,3062,3621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,3134,3162);

chunk = f_743_3142_3161(_chunks, chunkIndex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,3184,3237);

bytesToCopy = f_743_3198_3236(f_743_3207_3219(chunk), remainingBytes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,3259,3272);

chunkIndex++;
DynAbs.Tracing.TraceSender.TraceExitCondition(743,3062,3621);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(743,3062,3621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,3518,3551);

chunk = new byte[remainingBytes];
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,3573,3602);

bytesToCopy = remainingBytes;
DynAbs.Tracing.TraceSender.TraceExitCondition(743,3062,3621);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,3641,3700);

listYield.Add(f_743_3654_3699(chunk, 0, bytesToCopy));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,3720,3750);

remainingBytes -= bytesToCopy;
DynAbs.Tracing.TraceSender.TraceExitCondition(743,2936,3765);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(743,2936,3765);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(743,2936,3765);
}DynAbs.Tracing.TraceSender.TraceExitMethod(743,2785,3776);

return listYield;

int
f_743_3079_3092(System.Collections.Generic.List<byte[]>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(743, 3079, 3092);
return return_v;
}


byte[]
f_743_3142_3161(System.Collections.Generic.List<byte[]>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(743, 3142, 3161);
return return_v;
}


int
f_743_3207_3219(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(743, 3207, 3219);
return return_v;
}


int
f_743_3198_3236(int
val1,int
val2)
{
var return_v = Math.Min( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 3198, 3236);
return return_v;
}


System.ArraySegment<byte>
f_743_3654_3699(byte[]
array,int
offset,int
count)
{
var return_v = new System.ArraySegment<byte>( array, offset, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 3654, 3699);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(743,2785,3776);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(743,2785,3776);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static unsafe void ZeroMemory(byte* dest, int count)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(743,3786,3985);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,3871,3884);

var 
p = dest
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,3898,3974) || true) && (count-- > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(743,3898,3974);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,3950,3959);

*p++ = 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(743,3898,3974);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(743,3898,3974);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(743,3898,3974);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(743,3786,3985);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(743,3786,3985);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(743,3786,3985);
}
		}

unsafe void IUnsafeComStream.Read(byte* pv, int cb, int* pcbRead)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(743,3997,5210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,4087,4127);

int 
chunkIndex = _position / _chunkSize
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,4141,4182);

int 
chunkOffset = _position % _chunkSize
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,4196,4221);

int 
destinationIndex = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,4235,4253);

int 
bytesRead = 0
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,4269,5094) || true) && (true)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(743,4269,5094);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,4314,4402);

int 
bytesToCopy = f_743_4332_4401(_length - _position, f_743_4362_4400(cb, _chunkSize - chunkOffset))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,4420,4507) || true) && (bytesToCopy == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(743,4420,4507);
DynAbs.Tracing.TraceSender.TraceBreak(743,4482,4488);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(743,4420,4507);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,4527,4840) || true) && (chunkIndex < f_743_4544_4557(_chunks))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(743,4527,4840);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,4599,4692);

f_743_4599_4691(f_743_4612_4631(_chunks, chunkIndex), chunkOffset, (pv + destinationIndex), bytesToCopy);
DynAbs.Tracing.TraceSender.TraceExitCondition(743,4527,4840);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(743,4527,4840);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,4774,4821);

f_743_4774_4820(pv + destinationIndex, bytesToCopy);
DynAbs.Tracing.TraceSender.TraceExitCondition(743,4527,4840);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,4860,4885);

bytesRead += bytesToCopy;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,4903,4928);

_position += bytesToCopy;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,4946,4964);

cb -= bytesToCopy;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,4982,5014);

destinationIndex += bytesToCopy;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,5032,5045);

chunkIndex++;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,5063,5079);

chunkOffset = 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(743,4269,5094);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(743,4269,5094);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(743,4269,5094);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,5110,5199) || true) && (pcbRead != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(743,5110,5199);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,5163,5184);

*pcbRead = bytesRead;
DynAbs.Tracing.TraceSender.TraceExitCondition(743,5110,5199);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(743,3997,5210);

int
f_743_4362_4400(int
val1,int
val2)
{
var return_v = Math.Min( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 4362, 4400);
return return_v;
}


int
f_743_4332_4401(int
val1,int
val2)
{
var return_v = Math.Min( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 4332, 4401);
return return_v;
}


int
f_743_4544_4557(System.Collections.Generic.List<byte[]>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(743, 4544, 4557);
return return_v;
}


byte[]
f_743_4612_4631(System.Collections.Generic.List<byte[]>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(743, 4612, 4631);
return return_v;
}


unsafe int
f_743_4599_4691(byte[]
source,int
startIndex,byte*
destination,int
length)
{
Marshal.Copy( source, startIndex, (System.IntPtr)destination, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 4599, 4691);
return 0;
}


unsafe int
f_743_4774_4820(byte*
dest,int
count)
{
ZeroMemory( dest, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 4774, 4820);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(743,3997,5210);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(743,3997,5210);
}
		}

private int SetPosition(int newPos)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(743,5222,5534);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,5282,5356) || true) && (newPos < 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(743,5282,5356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,5330,5341);

newPos = 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(743,5282,5356);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,5372,5391);

_position = newPos;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,5407,5493) || true) && (newPos > _length)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(743,5407,5493);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,5461,5478);

_length = newPos;
DynAbs.Tracing.TraceSender.TraceExitCondition(743,5407,5493);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,5509,5523);

return newPos;
DynAbs.Tracing.TraceSender.TraceExitMethod(743,5222,5534);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(743,5222,5534);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(743,5222,5534);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

unsafe void IUnsafeComStream.Seek(long dlibMove, int origin, long* plibNewPosition)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(743,5546,6419);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,5654,5670);

int 
newPosition
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,5686,6285);

switch (origin)
            {

case STREAM_SEEK_SET:
DynAbs.Tracing.TraceSender.TraceEnterCondition(743,5686,6285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,5777,5818);

newPosition = f_743_5791_5817(this, dlibMove);
DynAbs.Tracing.TraceSender.TraceBreak(743,5840,5846);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(743,5686,6285);

case STREAM_SEEK_CUR:
DynAbs.Tracing.TraceSender.TraceEnterCondition(743,5686,6285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,5909,5962);

newPosition = f_743_5923_5961(this, _position + (int)dlibMove);
DynAbs.Tracing.TraceSender.TraceBreak(743,5984,5990);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(743,5686,6285);

case STREAM_SEEK_END:
DynAbs.Tracing.TraceSender.TraceEnterCondition(743,5686,6285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,6053,6104);

newPosition = f_743_6067_6103(this, _length + (int)dlibMove);
DynAbs.Tracing.TraceSender.TraceBreak(743,6126,6132);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(743,5686,6285);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(743,5686,6285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,6182,6270);

throw f_743_6188_6269($"{nameof(origin)} ({origin}) is invalid.", nameof(origin));
DynAbs.Tracing.TraceSender.TraceExitCondition(743,5686,6285);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,6301,6408) || true) && (plibNewPosition != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(743,6301,6408);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,6362,6393);

*plibNewPosition = newPosition;
DynAbs.Tracing.TraceSender.TraceExitCondition(743,6301,6408);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(743,5546,6419);

int
f_743_5791_5817(Microsoft.DiaSymReader.ComMemoryStream
this_param,long
newPos)
{
var return_v = this_param.SetPosition( (int)newPos);
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 5791, 5817);
return return_v;
}


int
f_743_5923_5961(Microsoft.DiaSymReader.ComMemoryStream
this_param,int
newPos)
{
var return_v = this_param.SetPosition( newPos);
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 5923, 5961);
return return_v;
}


int
f_743_6067_6103(Microsoft.DiaSymReader.ComMemoryStream
this_param,int
newPos)
{
var return_v = this_param.SetPosition( newPos);
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 6067, 6103);
return return_v;
}


System.ArgumentException
f_743_6188_6269(string
message,string
paramName)
{
var return_v = new System.ArgumentException( message, paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 6188, 6269);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(743,5546,6419);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(743,5546,6419);
}
		}

void IUnsafeComStream.SetSize(long libNewSize)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(743,6431,6539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,6502,6528);

_length = (int)libNewSize;
DynAbs.Tracing.TraceSender.TraceExitMethod(743,6431,6539);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(743,6431,6539);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(743,6431,6539);
}
		}

void IUnsafeComStream.Stat(out STATSTG pstatstg, int grfStatFlag)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(743,6551,6741);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,6641,6730);

pstatstg = new STATSTG()
            {
                cbSize = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => _length,743,6652,6729)
            };
DynAbs.Tracing.TraceSender.TraceExitMethod(743,6551,6741);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(743,6551,6741);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(743,6551,6741);
}
		}

unsafe void IUnsafeComStream.Write(byte* pv, int cb, int* pcbWritten)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(743,6753,7797);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,6847,6887);

int 
chunkIndex = _position / _chunkSize
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,6901,6942);

int 
chunkOffset = _position % _chunkSize
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,6956,6977);

int 
bytesWritten = 0
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,6991,7618) || true) && (true)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(743,6991,7618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,7036,7093);

int 
bytesToCopy = f_743_7054_7092(cb, _chunkSize - chunkOffset)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,7111,7198) || true) && (bytesToCopy == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(743,7111,7198);
DynAbs.Tracing.TraceSender.TraceBreak(743,7173,7179);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(743,7111,7198);
}
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,7218,7347) || true) && (chunkIndex >= f_743_7239_7252(_chunks))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(743,7218,7347);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,7294,7328);

f_743_7294_7327(                    _chunks, new byte[_chunkSize]);
DynAbs.Tracing.TraceSender.TraceExitCondition(743,7218,7347);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(743,7218,7347);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(743,7218,7347);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,7367,7456);

f_743_7367_7455((pv + bytesWritten), f_743_7409_7428(_chunks, chunkIndex), chunkOffset, bytesToCopy);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,7474,7502);

bytesWritten += bytesToCopy;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,7520,7538);

cb -= bytesToCopy;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,7556,7569);

chunkIndex++;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,7587,7603);

chunkOffset = 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(743,6991,7618);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(743,6991,7618);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(743,6991,7618);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,7634,7672);

f_743_7634_7671(this, _position + bytesWritten);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,7688,7786) || true) && (pcbWritten != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(743,7688,7786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,7744,7771);

*pcbWritten = bytesWritten;
DynAbs.Tracing.TraceSender.TraceExitCondition(743,7688,7786);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(743,6753,7797);

int
f_743_7054_7092(int
val1,int
val2)
{
var return_v = Math.Min( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 7054, 7092);
return return_v;
}


int
f_743_7239_7252(System.Collections.Generic.List<byte[]>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(743, 7239, 7252);
return return_v;
}


int
f_743_7294_7327(System.Collections.Generic.List<byte[]>
this_param,byte[]
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 7294, 7327);
return 0;
}


byte[]
f_743_7409_7428(System.Collections.Generic.List<byte[]>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(743, 7409, 7428);
return return_v;
}


unsafe int
f_743_7367_7455(byte*
source,byte[]
destination,int
startIndex,int
length)
{
Marshal.Copy( (System.IntPtr)source, destination, startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 7367, 7455);
return 0;
}


int
f_743_7634_7671(Microsoft.DiaSymReader.ComMemoryStream
this_param,int
newPos)
{
var return_v = this_param.SetPosition( newPos);
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 7634, 7671);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(743,6753,7797);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(743,6753,7797);
}
		}

void IUnsafeComStream.Commit(int grfCommitFlags)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(743,7809,7879);
DynAbs.Tracing.TraceSender.TraceExitMethod(743,7809,7879);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(743,7809,7879);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(743,7809,7879);
}
		}

void IUnsafeComStream.Clone(out IStream ppstm)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(743,7891,8007);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,7962,7996);

throw f_743_7968_7995();
DynAbs.Tracing.TraceSender.TraceExitMethod(743,7891,8007);

System.NotSupportedException
f_743_7968_7995()
{
var return_v = new System.NotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 7968, 7995);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(743,7891,8007);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(743,7891,8007);
}
		}

void IUnsafeComStream.CopyTo(IStream pstm, long cb, int* pcbRead, int* pcbWritten)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(743,8019,8171);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,8126,8160);

throw f_743_8132_8159();
DynAbs.Tracing.TraceSender.TraceExitMethod(743,8019,8171);

System.NotSupportedException
f_743_8132_8159()
{
var return_v = new System.NotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 8132, 8159);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(743,8019,8171);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(743,8019,8171);
}
		}

void IUnsafeComStream.LockRegion(long libOffset, long cb, int lockType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(743,8183,8324);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,8279,8313);

throw f_743_8285_8312();
DynAbs.Tracing.TraceSender.TraceExitMethod(743,8183,8324);

System.NotSupportedException
f_743_8285_8312()
{
var return_v = new System.NotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 8285, 8312);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(743,8183,8324);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(743,8183,8324);
}
		}

void IUnsafeComStream.Revert()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(743,8336,8436);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,8391,8425);

throw f_743_8397_8424();
DynAbs.Tracing.TraceSender.TraceExitMethod(743,8336,8436);

System.NotSupportedException
f_743_8397_8424()
{
var return_v = new System.NotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 8397, 8424);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(743,8336,8436);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(743,8336,8436);
}
		}

void IUnsafeComStream.UnlockRegion(long libOffset, long cb, int lockType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(743,8448,8591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,8546,8580);

throw f_743_8552_8579();
DynAbs.Tracing.TraceSender.TraceExitMethod(743,8448,8591);

System.NotSupportedException
f_743_8552_8579()
{
var return_v = new System.NotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 8552, 8579);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(743,8448,8591);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(743,8448,8591);
}
		}

static ComMemoryStream()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(743,987,8598);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,1119,1138);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,1168,1187);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(743,1217,1236);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(743,987,8598);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(743,987,8598);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(743,987,8598);

System.Collections.Generic.List<byte[]>
f_743_1331_1349()
{
var return_v = new System.Collections.Generic.List<byte[]>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(743, 1331, 1349);
return return_v;
}

}
}

