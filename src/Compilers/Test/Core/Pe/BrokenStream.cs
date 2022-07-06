// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.IO;

namespace Roslyn.Test.Utilities
{
internal class BrokenStream : Stream
{        public enum BreakHowType
        {
            ThrowOnSetPosition,
            ThrowOnWrite,
            ThrowOnSetLength,
            CancelOnWrite
        }

public BreakHowType BreakHow;

public Exception ThrownException {get; private set; }

public override bool CanRead
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(25127,691,711);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25127,697,709);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(25127,691,711);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25127,638,722);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25127,638,722);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override bool CanSeek
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(25127,787,807);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25127,793,805);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(25127,787,807);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25127,734,818);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25127,734,818);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override bool CanWrite
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(25127,884,904);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25127,890,902);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(25127,884,904);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25127,830,915);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25127,830,915);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override void Flush()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25127,927,977);
DynAbs.Tracing.TraceSender.TraceExitMethod(25127,927,977);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25127,927,977);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25127,927,977);
}
		}

public override long Length
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25127,1041,1101);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25127,1077,1086);

return 0;
DynAbs.Tracing.TraceSender.TraceExitMethod(25127,1041,1101);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25127,989,1112);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25127,989,1112);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override long Position
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25127,1178,1238);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25127,1214,1223);

return 0;
DynAbs.Tracing.TraceSender.TraceExitMethod(25127,1178,1238);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25127,1124,1512);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25127,1124,1512);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25127,1252,1501);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25127,1288,1486) || true) && (BreakHow == BreakHowType.ThrowOnSetPosition)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25127,1288,1486);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25127,1377,1423);

ThrownException = f_25127_1395_1422();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25127,1445,1467);

throw f_25127_1451_1466();
DynAbs.Tracing.TraceSender.TraceExitCondition(25127,1288,1486);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25127,1252,1501);

System.NotSupportedException
f_25127_1395_1422()
{
var return_v = new System.NotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25127, 1395, 1422);
return return_v;
}


System.Exception
f_25127_1451_1466()
{
var return_v = ThrownException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25127, 1451, 1466);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25127,1124,1512);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25127,1124,1512);
}
		}}

public override int Read(byte[] buffer, int offset, int count)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25127,1524,1631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25127,1611,1620);

return 0;
DynAbs.Tracing.TraceSender.TraceExitMethod(25127,1524,1631);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25127,1524,1631);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25127,1524,1631);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override long Seek(long offset, SeekOrigin origin)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25127,1643,1745);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25127,1725,1734);

return 0;
DynAbs.Tracing.TraceSender.TraceExitMethod(25127,1643,1745);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25127,1643,1745);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25127,1643,1745);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override void SetLength(long value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25127,1757,2005);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25127,1824,1994) || true) && (BreakHow == BreakHowType.ThrowOnSetLength)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25127,1824,1994);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25127,1903,1939);

ThrownException = f_25127_1921_1938();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25127,1957,1979);

throw f_25127_1963_1978();
DynAbs.Tracing.TraceSender.TraceExitCondition(25127,1824,1994);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25127,1757,2005);

System.IO.IOException
f_25127_1921_1938()
{
var return_v = new System.IO.IOException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25127, 1921, 1938);
return return_v;
}


System.Exception
f_25127_1963_1978()
{
var return_v = ThrownException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25127, 1963, 1978);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25127,1757,2005);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25127,1757,2005);
}
		}

public override void Write(byte[] buffer, int offset, int count)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25127,2017,2484);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25127,2106,2473) || true) && (BreakHow == BreakHowType.ThrowOnWrite)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25127,2106,2473);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25127,2181,2217);

ThrownException = f_25127_2199_2216();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25127,2235,2257);

throw f_25127_2241_2256();
DynAbs.Tracing.TraceSender.TraceExitCondition(25127,2106,2473);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25127,2106,2473);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25127,2291,2473) || true) && (BreakHow == BreakHowType.CancelOnWrite)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25127,2291,2473);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25127,2367,2418);

ThrownException = f_25127_2385_2417();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25127,2436,2458);

throw f_25127_2442_2457();
DynAbs.Tracing.TraceSender.TraceExitCondition(25127,2291,2473);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25127,2106,2473);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25127,2017,2484);

System.IO.IOException
f_25127_2199_2216()
{
var return_v = new System.IO.IOException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25127, 2199, 2216);
return return_v;
}


System.Exception
f_25127_2241_2256()
{
var return_v = ThrownException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25127, 2241, 2256);
return return_v;
}


System.OperationCanceledException
f_25127_2385_2417()
{
var return_v = new System.OperationCanceledException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25127, 2385, 2417);
return return_v;
}


System.Exception
f_25127_2442_2457()
{
var return_v = ThrownException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25127, 2442, 2457);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25127,2017,2484);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25127,2017,2484);
}
		}

public BrokenStream()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25127,304,2491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25127,553,561);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25127,572,626);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25127,304,2491);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25127,304,2491);
}


static BrokenStream()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25127,304,2491);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25127,304,2491);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25127,304,2491);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25127,304,2491);
}
}
