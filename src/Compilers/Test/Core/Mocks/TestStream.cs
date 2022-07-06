// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.IO;

namespace Roslyn.Test.Utilities
{
public class TestStream : Stream
{
private readonly bool? _canRead, _canSeek, _canWrite;

private readonly Func<byte[], int, int, int> _readFunc;

private readonly long? _length;

private readonly Func<long> _getPosition;

private readonly Action<long> _setPosition;

private readonly Stream _backingStream;

private readonly Action _dispose;

public TestStream(
            bool? canRead = null,
            bool? canSeek = null,
            bool? canWrite = null,
            Func<byte[], int, int, int> readFunc = null,
            long? length = null,
            Func<long> getPosition = null,
            Action<long> setPosition = null,
            Stream backingStream = null,
            Action dispose = null)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25122,720,1453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,376,384);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,386,394);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,396,405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,461,470);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,504,511);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,550,562);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,603,615);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,650,664);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,699,707);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,1129,1148);

_canRead = canRead;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,1162,1181);

_canSeek = canSeek;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,1195,1216);

_canWrite = canWrite;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,1230,1251);

_readFunc = readFunc;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,1265,1282);

_length = length;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,1296,1323);

_getPosition = getPosition;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,1337,1364);

_setPosition = setPosition;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,1378,1409);

_backingStream = backingStream;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,1423,1442);

_dispose = dispose;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25122,720,1453);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25122,720,1453);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25122,720,1453);
}
		}

public override bool CanRead {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25122,1494,1541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,1497,1541);
return _canRead ??(DynAbs.Tracing.TraceSender.Expression_Null<bool?>(25122, 1497, 1541)??f_25122_1509_1532_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_backingStream, 25122, 1509, 1532)?.CanRead)??(DynAbs.Tracing.TraceSender.Expression_Null<bool?>(25122, 1509, 1541)??false));DynAbs.Tracing.TraceSender.TraceExitMethod(25122,1494,1541);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25122,1494,1541);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25122,1494,1541);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override bool CanSeek {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25122,1583,1630);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,1586,1630);
return _canSeek ??(DynAbs.Tracing.TraceSender.Expression_Null<bool?>(25122, 1586, 1630)??f_25122_1598_1621_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_backingStream, 25122, 1598, 1621)?.CanSeek)??(DynAbs.Tracing.TraceSender.Expression_Null<bool?>(25122, 1598, 1630)??false));DynAbs.Tracing.TraceSender.TraceExitMethod(25122,1583,1630);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25122,1583,1630);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25122,1583,1630);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override bool CanWrite {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25122,1673,1722);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,1676,1722);
return _canWrite ??(DynAbs.Tracing.TraceSender.Expression_Null<bool?>(25122, 1676, 1722)??f_25122_1689_1713_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_backingStream, 25122, 1689, 1713)?.CanWrite)??(DynAbs.Tracing.TraceSender.Expression_Null<bool?>(25122, 1689, 1722)??false));DynAbs.Tracing.TraceSender.TraceExitMethod(25122,1673,1722);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25122,1673,1722);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25122,1673,1722);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override long Length {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25122,1763,1804);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,1766,1804);
return _length ??(DynAbs.Tracing.TraceSender.Expression_Null<long?>(25122, 1766, 1804)??f_25122_1777_1799_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_backingStream, 25122, 1777, 1799)?.Length)??(DynAbs.Tracing.TraceSender.Expression_Null<long?>(25122, 1777, 1804)??0));DynAbs.Tracing.TraceSender.TraceExitMethod(25122,1763,1804);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25122,1763,1804);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25122,1763,1804);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override long Position
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25122,1871,2306);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,1907,1976) || true) && (f_25122_1911_1919_M(!CanSeek))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25122,1907,1976);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,1942,1976);

throw f_25122_1948_1975();
DynAbs.Tracing.TraceSender.TraceExitCondition(25122,1907,1976);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,1994,2101) || true) && (_getPosition != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25122,1994,2101);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,2060,2082);

return f_25122_2067_2081(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(25122,1994,2101);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,2119,2237) || true) && (_backingStream != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25122,2119,2237);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,2187,2218);

return f_25122_2194_2217(_backingStream);
DynAbs.Tracing.TraceSender.TraceExitCondition(25122,2119,2237);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,2255,2291);

throw f_25122_2261_2290();
DynAbs.Tracing.TraceSender.TraceExitMethod(25122,1871,2306);

bool
f_25122_1911_1919_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25122, 1911, 1919);
return return_v;
}


System.NotSupportedException
f_25122_1948_1975()
{
var return_v = new System.NotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25122, 1948, 1975);
return return_v;
}


long
f_25122_2067_2081(Roslyn.Test.Utilities.TestStream
this_param)
{
var return_v = this_param._getPosition();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25122, 2067, 2081);
return return_v;
}


long
f_25122_2194_2217(System.IO.Stream
this_param)
{
var return_v = this_param.Position;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25122, 2194, 2217);
return return_v;
}


System.NotImplementedException
f_25122_2261_2290()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25122, 2261, 2290);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25122,1817,2874);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25122,1817,2874);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25122,2322,2863);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,2358,2465) || true) && (f_25122_2362_2370_M(!CanSeek))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25122,2358,2465);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,2412,2446);

throw f_25122_2418_2445();
DynAbs.Tracing.TraceSender.TraceExitCondition(25122,2358,2465);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,2483,2848) || true) && (_setPosition != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25122,2483,2848);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,2549,2569);

f_25122_2549_2568(this, value);
DynAbs.Tracing.TraceSender.TraceExitCondition(25122,2483,2848);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25122,2483,2848);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,2611,2848) || true) && (_backingStream != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25122,2611,2848);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,2679,2711);

_backingStream.Position = value;
DynAbs.Tracing.TraceSender.TraceExitCondition(25122,2611,2848);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25122,2611,2848);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,2793,2829);

throw f_25122_2799_2828();
DynAbs.Tracing.TraceSender.TraceExitCondition(25122,2611,2848);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25122,2483,2848);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25122,2322,2863);

bool
f_25122_2362_2370_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25122, 2362, 2370);
return return_v;
}


System.NotSupportedException
f_25122_2418_2445()
{
var return_v = new System.NotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25122, 2418, 2445);
return return_v;
}


int
f_25122_2549_2568(Roslyn.Test.Utilities.TestStream
this_param,long
obj)
{
this_param._setPosition( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25122, 2549, 2568);
return 0;
}


System.NotImplementedException
f_25122_2799_2828()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25122, 2799, 2828);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25122,1817,2874);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25122,1817,2874);
}
		}}

public override void Flush()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25122,2886,3096);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,2939,3048) || true) && (_backingStream == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25122,2939,3048);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,2999,3033);

throw f_25122_3005_3032();
DynAbs.Tracing.TraceSender.TraceExitCondition(25122,2939,3048);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,3062,3085);

f_25122_3062_3084(            _backingStream);
DynAbs.Tracing.TraceSender.TraceExitMethod(25122,2886,3096);

System.NotSupportedException
f_25122_3005_3032()
{
var return_v = new System.NotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25122, 3005, 3032);
return return_v;
}


int
f_25122_3062_3084(System.IO.Stream
this_param)
{
this_param.Flush();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25122, 3062, 3084);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25122,2886,3096);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25122,2886,3096);
}
		}

public override int Read(byte[] buffer, int offset, int count)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25122,3108,3562);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,3195,3551) || true) && (_readFunc != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25122,3195,3551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,3250,3290);

return f_25122_3257_3289(this, buffer, offset, count);
DynAbs.Tracing.TraceSender.TraceExitCondition(25122,3195,3551);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25122,3195,3551);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,3324,3551) || true) && (_backingStream != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25122,3324,3551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,3384,3434);

return f_25122_3391_3433(_backingStream, buffer, offset, count);
DynAbs.Tracing.TraceSender.TraceExitCondition(25122,3324,3551);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25122,3324,3551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,3500,3536);

throw f_25122_3506_3535();
DynAbs.Tracing.TraceSender.TraceExitCondition(25122,3324,3551);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25122,3195,3551);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25122,3108,3562);

int
f_25122_3257_3289(Roslyn.Test.Utilities.TestStream
this_param,byte[]
arg1,int
arg2,int
arg3)
{
var return_v = this_param._readFunc( arg1, arg2, arg3);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25122, 3257, 3289);
return return_v;
}


int
f_25122_3391_3433(System.IO.Stream
this_param,byte[]
buffer,int
offset,int
count)
{
var return_v = this_param.Read( buffer, offset, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25122, 3391, 3433);
return return_v;
}


System.NotImplementedException
f_25122_3506_3535()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25122, 3506, 3535);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25122,3108,3562);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25122,3108,3562);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override long Seek(long offset, SeekOrigin origin)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25122,3574,3787);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,3656,3751) || true) && (f_25122_3660_3668_M(!CanSeek))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25122,3656,3751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,3702,3736);

throw f_25122_3708_3735();
DynAbs.Tracing.TraceSender.TraceExitCondition(25122,3656,3751);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,3767,3776);

return 0;
DynAbs.Tracing.TraceSender.TraceExitMethod(25122,3574,3787);

bool
f_25122_3660_3668_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25122, 3660, 3668);
return return_v;
}


System.NotSupportedException
f_25122_3708_3735()
{
var return_v = new System.NotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25122, 3708, 3735);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25122,3574,3787);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25122,3574,3787);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override void SetLength(long value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25122,3799,4032);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,3866,3975) || true) && (_backingStream == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25122,3866,3975);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,3926,3960);

throw f_25122_3932_3959();
DynAbs.Tracing.TraceSender.TraceExitCondition(25122,3866,3975);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,3989,4021);

f_25122_3989_4020(            _backingStream, value);
DynAbs.Tracing.TraceSender.TraceExitMethod(25122,3799,4032);

System.NotSupportedException
f_25122_3932_3959()
{
var return_v = new System.NotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25122, 3932, 3959);
return return_v;
}


int
f_25122_3989_4020(System.IO.Stream
this_param,long
value)
{
this_param.SetLength( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25122, 3989, 4020);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25122,3799,4032);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25122,3799,4032);
}
		}

public override void Write(byte[] buffer, int offset, int count)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25122,4044,4240);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,4133,4229) || true) && (f_25122_4137_4146_M(!CanWrite))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25122,4133,4229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,4180,4214);

throw f_25122_4186_4213();
DynAbs.Tracing.TraceSender.TraceExitCondition(25122,4133,4229);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25122,4044,4240);

bool
f_25122_4137_4146_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25122, 4137, 4146);
return return_v;
}


System.NotSupportedException
f_25122_4186_4213()
{
var return_v = new System.NotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25122, 4186, 4213);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25122,4044,4240);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25122,4044,4240);
}
		}

protected override void Dispose(bool disposing)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25122,4252,4545);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,4324,4496) || true) && (_dispose != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25122,4324,4496);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,4378,4389);

f_25122_4378_4388(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(25122,4324,4496);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25122,4324,4496);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,4455,4481);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_backingStream, 25122, 4455, 4480)?.Dispose(),25122,4470,4480);
DynAbs.Tracing.TraceSender.TraceExitCondition(25122,4324,4496);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25122,4510,4534);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(disposing),25122,4510,4533);
DynAbs.Tracing.TraceSender.TraceExitMethod(25122,4252,4545);

int
f_25122_4378_4388(Roslyn.Test.Utilities.TestStream
this_param)
{
this_param._dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25122, 4378, 4388);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25122,4252,4545);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25122,4252,4545);
}
		}

static TestStream()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25122,304,4552);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25122,304,4552);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25122,304,4552);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25122,304,4552);

bool?
f_25122_1509_1532_M(bool?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25122, 1509, 1532);
return return_v;
}


bool?
f_25122_1598_1621_M(bool?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25122, 1598, 1621);
return return_v;
}


bool?
f_25122_1689_1713_M(bool?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25122, 1689, 1713);
return return_v;
}


long?
f_25122_1777_1799_M(long?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25122, 1777, 1799);
return return_v;
}

}
}
