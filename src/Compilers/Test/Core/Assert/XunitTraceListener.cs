// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable enable

using System.Diagnostics;
using System.Text;
using Xunit.Abstractions;

namespace Roslyn.Test.Utilities
{
public sealed class XunitTraceListener : TraceListener
{
private readonly ITestOutputHelper _logger;

private readonly StringBuilder _lineInProgress ;

private bool _disposed;

public XunitTraceListener(ITestOutputHelper logger)
		{
			try
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25054,582,667);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25054,450,457);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25054,499,536);
this._lineInProgress = f_25054_517_536();DynAbs.Tracing.TraceSender.TraceSimpleStatement(25054,560,569);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25054,650,666);
_logger = logger;DynAbs.Tracing.TraceSender.TraceExitConstructor(25054,582,667);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25054,582,667);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25054,582,667);
}
		}

public override bool IsThreadSafe
{get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25054,726,734);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25054,729,734);
return false;DynAbs.Tracing.TraceSender.TraceExitMethod(25054,726,734);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25054,726,734);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25054,726,734);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override void Write(string? message)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25054,804,838);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25054,807,838);
f_25054_807_838(_lineInProgress, message);DynAbs.Tracing.TraceSender.TraceExitMethod(25054,804,838);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25054,804,838);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25054,804,838);
}

System.Text.StringBuilder
f_25054_807_838(System.Text.StringBuilder
this_param,string?
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25054, 807, 838);
return return_v;
}

		}

public override void WriteLine(string? message)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25054,851,1095);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25054,923,1084) || true) && (!_disposed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25054,923,1084);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25054,971,1027);

f_25054_971_1026(                _logger, f_25054_989_1015(_lineInProgress)+ message);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25054,1045,1069);

f_25054_1045_1068(                _lineInProgress);
DynAbs.Tracing.TraceSender.TraceExitCondition(25054,923,1084);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25054,851,1095);

string
f_25054_989_1015(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25054, 989, 1015);
return return_v;
}


int
f_25054_971_1026(Xunit.Abstractions.ITestOutputHelper
this_param,string
message)
{
this_param.WriteLine( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25054, 971, 1026);
return 0;
}


System.Text.StringBuilder
f_25054_1045_1068(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25054, 1045, 1068);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25054,851,1095);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25054,851,1095);
}
		}

protected override void Dispose(bool disposing)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25054,1107,1245);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25054,1179,1196);

_disposed = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25054,1210,1234);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(disposing),25054,1210,1233);
DynAbs.Tracing.TraceSender.TraceExitMethod(25054,1107,1245);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25054,1107,1245);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25054,1107,1245);
}
		}

static XunitTraceListener()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25054,344,1252);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25054,344,1252);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25054,344,1252);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25054,344,1252);

System.Text.StringBuilder
f_25054_517_536()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25054, 517, 536);
return return_v;
}

}
}
