// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.IO;
using Xunit;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
public sealed class CappedStringWriter : StringWriter
{
private readonly int _expectedLength;

private int _remaining;

public int Length {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25084,677,705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25084,680,705);
return f_25084_680_705(f_25084_680_698(this));DynAbs.Tracing.TraceSender.TraceExitMethod(25084,677,705);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25084,677,705);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25084,677,705);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public CappedStringWriter(int expectedLength)
:base(f_25084_784_833_C(f_25084_784_833()) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25084,718,1148);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25084,598,613);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25084,636,646);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25084,859,1137) || true) && (expectedLength < 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25084,859,1137);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25084,915,958);

_expectedLength = _remaining = 1024 * 1024;
DynAbs.Tracing.TraceSender.TraceExitCondition(25084,859,1137);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25084,859,1137);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25084,1024,1057);

_expectedLength = expectedLength;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25084,1075,1122);

_remaining = f_25084_1088_1121(256, expectedLength * 4);
DynAbs.Tracing.TraceSender.TraceExitCondition(25084,859,1137);
}
DynAbs.Tracing.TraceSender.TraceExitConstructor(25084,718,1148);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25084,718,1148);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25084,718,1148);
}
		}

private void CapReached()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25084,1160,1383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25084,1210,1372);

throw f_25084_1216_1371($"Test produced more output than expected ({_expectedLength} characters). Is it in an infinite loop? Output so far:\r\n{f_25084_1350_1368(this)}");
DynAbs.Tracing.TraceSender.TraceExitMethod(25084,1160,1383);

System.Text.StringBuilder
f_25084_1350_1368(Microsoft.CodeAnalysis.Test.Utilities.CappedStringWriter
this_param)
{
var return_v = this_param.GetStringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25084, 1350, 1368);
return return_v;
}


System.Exception
f_25084_1216_1371(string
message)
{
var return_v = new System.Exception( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25084, 1216, 1371);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25084,1160,1383);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25084,1160,1383);
}
		}

public override void Write(char value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25084,1395,1665);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25084,1458,1654) || true) && (1 <= _remaining)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25084,1458,1654);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25084,1511,1524);

_remaining--;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25084,1542,1560);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Write(value),25084,1542,1559);
DynAbs.Tracing.TraceSender.TraceExitCondition(25084,1458,1654);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25084,1458,1654);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25084,1626,1639);

f_25084_1626_1638(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(25084,1458,1654);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25084,1395,1665);

int
f_25084_1626_1638(Microsoft.CodeAnalysis.Test.Utilities.CappedStringWriter
this_param)
{
this_param.CapReached();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25084, 1626, 1638);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25084,1395,1665);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25084,1395,1665);
}
		}

public override void Write(char[] buffer, int index, int count)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25084,1677,1998);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25084,1765,1987) || true) && (count <= _remaining)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25084,1765,1987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25084,1822,1842);

_remaining -= count;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25084,1860,1893);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Write(buffer,index,count),25084,1860,1892);
DynAbs.Tracing.TraceSender.TraceExitCondition(25084,1765,1987);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25084,1765,1987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25084,1959,1972);

f_25084_1959_1971(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(25084,1765,1987);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25084,1677,1998);

int
f_25084_1959_1971(Microsoft.CodeAnalysis.Test.Utilities.CappedStringWriter
this_param)
{
this_param.CapReached();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25084, 1959, 1971);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25084,1677,1998);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25084,1677,1998);
}
		}

public override void Write(string value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25084,2010,2307);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25084,2075,2296) || true) && (f_25084_2079_2091(value)<= _remaining)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25084,2075,2296);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25084,2139,2166);

_remaining -= f_25084_2153_2165(value);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25084,2184,2202);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Write(value),25084,2184,2201);
DynAbs.Tracing.TraceSender.TraceExitCondition(25084,2075,2296);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25084,2075,2296);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25084,2268,2281);

f_25084_2268_2280(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(25084,2075,2296);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25084,2010,2307);

int
f_25084_2079_2091(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25084, 2079, 2091);
return return_v;
}


int
f_25084_2153_2165(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25084, 2153, 2165);
return return_v;
}


int
f_25084_2268_2280(Microsoft.CodeAnalysis.Test.Utilities.CappedStringWriter
this_param)
{
this_param.CapReached();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25084, 2268, 2280);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25084,2010,2307);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25084,2010,2307);
}
		}

static CappedStringWriter()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25084,507,2314);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25084,507,2314);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25084,507,2314);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25084,507,2314);

System.Text.StringBuilder
f_25084_680_698(Microsoft.CodeAnalysis.Test.Utilities.CappedStringWriter
this_param)
{
var return_v = this_param.GetStringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25084, 680, 698);
return return_v;
}


int
f_25084_680_705(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25084, 680, 705);
return return_v;
}


static System.Globalization.CultureInfo
f_25084_784_833()
{
var return_v = System.Globalization.CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25084, 784, 833);
return return_v;
}


static int
f_25084_1088_1121(int
val1,int
val2)
{
var return_v = Math.Max( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25084, 1088, 1121);
return return_v;
}


static System.IFormatProvider
f_25084_784_833_C(System.IFormatProvider
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(25084, 718, 1148);
return return_v;
}

}
}
