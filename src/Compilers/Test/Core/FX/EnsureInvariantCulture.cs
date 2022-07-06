// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace Roslyn.Test.Utilities
{
public class EnsureInvariantCulture : IDisposable
{
private readonly CultureInfo _threadCulture;

private readonly int _threadId;

public EnsureInvariantCulture()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25090,530,778);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25090,462,476);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25090,508,517);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25090,586,635);

_threadId = f_25090_598_634(f_25090_598_618());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25090,649,693);

_threadCulture = f_25090_666_692();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25090,709,767);

CultureInfo.CurrentCulture = f_25090_738_766();
DynAbs.Tracing.TraceSender.TraceExitConstructor(25090,530,778);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25090,530,778);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25090,530,778);
}
		}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25090,790,1073);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25090,836,900);

f_25090_836_899(_threadId == f_25090_862_898(f_25090_862_882()));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25090,916,1062) || true) && (_threadId == f_25090_933_969(f_25090_933_953()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25090,916,1062);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25090,1003,1047);

CultureInfo.CurrentCulture = _threadCulture;
DynAbs.Tracing.TraceSender.TraceExitCondition(25090,916,1062);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25090,790,1073);

System.Threading.Thread
f_25090_862_882()
{
var return_v = Thread.CurrentThread;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25090, 862, 882);
return return_v;
}


int
f_25090_862_898(System.Threading.Thread
this_param)
{
var return_v = this_param.ManagedThreadId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25090, 862, 898);
return return_v;
}


int
f_25090_836_899(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25090, 836, 899);
return 0;
}


System.Threading.Thread
f_25090_933_953()
{
var return_v = Thread.CurrentThread;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25090, 933, 953);
return return_v;
}


int
f_25090_933_969(System.Threading.Thread
this_param)
{
var return_v = this_param.ManagedThreadId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25090, 933, 969);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25090,790,1073);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25090,790,1073);
}
		}

static EnsureInvariantCulture()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25090,367,1080);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25090,367,1080);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25090,367,1080);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25090,367,1080);

static System.Threading.Thread
f_25090_598_618()
{
var return_v = Thread.CurrentThread;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25090, 598, 618);
return return_v;
}


static int
f_25090_598_634(System.Threading.Thread
this_param)
{
var return_v = this_param.ManagedThreadId;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25090, 598, 634);
return return_v;
}


static System.Globalization.CultureInfo
f_25090_666_692()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25090, 666, 692);
return return_v;
}


static System.Globalization.CultureInfo
f_25090_738_766()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25090, 738, 766);
return return_v;
}

}
}
