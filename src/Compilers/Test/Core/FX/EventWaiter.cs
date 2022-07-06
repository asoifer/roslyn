// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Roslyn.Test.Utilities
{
public sealed class EventWaiter : IDisposable
{
private readonly ManualResetEvent _eventSignal ;

private Exception _capturedException;

public EventHandler<T> Wrap<T>(EventHandler<T> input)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25091,1342,1813);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25091,1420,1802);

return (sender, args) =>
            {
                try
                {
                    input(sender, args);
                }
                catch (Exception ex)
                {
                    _capturedException = ex;
                }
                finally
                {
                    _eventSignal.Set();
                }
            };
DynAbs.Tracing.TraceSender.TraceExitMethod(25091,1342,1813);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25091,1342,1813);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25091,1342,1813);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool WaitForEventToFire(TimeSpan timeout)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25091,2054,2244);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25091,2127,2170);

var 
result = f_25091_2140_2169(_eventSignal, timeout)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25091,2184,2205);

f_25091_2184_2204(            _eventSignal);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25091,2219,2233);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(25091,2054,2244);

bool
f_25091_2140_2169(System.Threading.ManualResetEvent
this_param,System.TimeSpan
timeout)
{
var return_v = this_param.WaitOne( timeout);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25091, 2140, 2169);
return return_v;
}


bool
f_25091_2184_2204(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Reset();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25091, 2184, 2204);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25091,2054,2244);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25091,2054,2244);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void WaitForEventToFire()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25091,2441,2588);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25091,2498,2521);

f_25091_2498_2520(            _eventSignal);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25091,2535,2556);

f_25091_2535_2555(            _eventSignal);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25091,2570,2577);

return;
DynAbs.Tracing.TraceSender.TraceExitMethod(25091,2441,2588);

bool
f_25091_2498_2520(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.WaitOne();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25091, 2498, 2520);
return return_v;
}


bool
f_25091_2535_2555(System.Threading.ManualResetEvent
this_param)
{
var return_v = this_param.Reset();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25091, 2535, 2555);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25091,2441,2588);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25091,2441,2588);
}
		}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25091,2747,2945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25091,2793,2816);

f_25091_2793_2815(            _eventSignal);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25091,2830,2934) || true) && (_capturedException != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25091,2830,2934);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25091,2894,2919);

throw _capturedException;
DynAbs.Tracing.TraceSender.TraceExitCondition(25091,2830,2934);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25091,2747,2945);

int
f_25091_2793_2815(System.Threading.ManualResetEvent
this_param)
{
this_param.Dispose();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25091, 2793, 2815);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25091,2747,2945);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25091,2747,2945);
}
		}

public EventWaiter()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25091,532,2952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25091,628,670);
this._eventSignal = f_25091_643_670(false);DynAbs.Tracing.TraceSender.TraceSimpleStatement(25091,699,717);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25091,532,2952);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25091,532,2952);
}


static EventWaiter()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25091,532,2952);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25091,532,2952);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25091,532,2952);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25091,532,2952);

System.Threading.ManualResetEvent
f_25091_643_670(bool
initialState)
{
var return_v = new System.Threading.ManualResetEvent( initialState);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25091, 643, 670);
return return_v;
}

}
}
