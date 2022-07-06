// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis
{
public sealed class ThrowingTraceListener : TraceListener
{
public override void Fail(string? message, string? detailMessage)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25043,833,1152);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25043,923,1141);

throw f_25043_929_1140(((DynAbs.Tracing.TraceSender.Conditional_F1(25043, 978, 1007)||((f_25043_978_1007(message)&&DynAbs.Tracing.TraceSender.Conditional_F2(25043, 1010, 1028))||DynAbs.Tracing.TraceSender.Conditional_F3(25043, 1031, 1038)))?"Assertion failed" :message) +
                ((DynAbs.Tracing.TraceSender.Conditional_F1(25043, 1060, 1095)||((f_25043_1060_1095(detailMessage)&&DynAbs.Tracing.TraceSender.Conditional_F2(25043, 1098, 1100))||DynAbs.Tracing.TraceSender.Conditional_F3(25043, 1103, 1138)))?"" :f_25043_1103_1122()+ detailMessage));
DynAbs.Tracing.TraceSender.TraceExitMethod(25043,833,1152);

bool
f_25043_978_1007(string?
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25043, 978, 1007);
return return_v;
}


bool
f_25043_1060_1095(string?
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25043, 1060, 1095);
return return_v;
}


string
f_25043_1103_1122()
{
var return_v = Environment.NewLine ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25043, 1103, 1122);
return return_v;
}


System.InvalidOperationException
f_25043_929_1140(string
message)
{
var return_v = new System.InvalidOperationException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25043, 929, 1140);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25043,833,1152);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25043,833,1152);
}
		}

public override void Write(object? o)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25043,1164,1223);
DynAbs.Tracing.TraceSender.TraceExitMethod(25043,1164,1223);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25043,1164,1223);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25043,1164,1223);
}
		}

public override void Write(object? o, string? category)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25043,1235,1312);
DynAbs.Tracing.TraceSender.TraceExitMethod(25043,1235,1312);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25043,1235,1312);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25043,1235,1312);
}
		}

public override void Write(string? message)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25043,1324,1389);
DynAbs.Tracing.TraceSender.TraceExitMethod(25043,1324,1389);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25043,1324,1389);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25043,1324,1389);
}
		}

public override void Write(string? message, string? category)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25043,1401,1484);
DynAbs.Tracing.TraceSender.TraceExitMethod(25043,1401,1484);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25043,1401,1484);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25043,1401,1484);
}
		}

public override void WriteLine(object? o)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25043,1496,1559);
DynAbs.Tracing.TraceSender.TraceExitMethod(25043,1496,1559);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25043,1496,1559);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25043,1496,1559);
}
		}

public override void WriteLine(object? o, string? category)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25043,1571,1652);
DynAbs.Tracing.TraceSender.TraceExitMethod(25043,1571,1652);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25043,1571,1652);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25043,1571,1652);
}
		}

public override void WriteLine(string? message)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25043,1664,1733);
DynAbs.Tracing.TraceSender.TraceExitMethod(25043,1664,1733);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25043,1664,1733);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25043,1664,1733);
}
		}

public override void WriteLine(string? message, string? category)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25043,1745,1832);
DynAbs.Tracing.TraceSender.TraceExitMethod(25043,1745,1832);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25043,1745,1832);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25043,1745,1832);
}
		}

public ThrowingTraceListener()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25043,759,1839);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25043,759,1839);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25043,759,1839);
}


static ThrowingTraceListener()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25043,759,1839);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25043,759,1839);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25043,759,1839);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25043,759,1839);
}
}
