// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Globalization;
using System.Threading;

namespace Roslyn.Test.Utilities
{
public class CultureContext : IDisposable
{
private readonly CultureInfo _threadCulture;

public CultureContext(CultureInfo cultureInfo)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25031,454,635);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25031,427,441);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25031,525,569);

_threadCulture = f_25031_542_568();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25031,583,624);

CultureInfo.CurrentCulture = cultureInfo;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25031,454,635);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25031,454,635);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25031,454,635);
}
		}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25031,647,748);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25031,693,737);

CultureInfo.CurrentCulture = _threadCulture;
DynAbs.Tracing.TraceSender.TraceExitMethod(25031,647,748);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25031,647,748);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25031,647,748);
}
		}

static CultureContext()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25031,340,755);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25031,340,755);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25031,340,755);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25031,340,755);

static System.Globalization.CultureInfo
f_25031_542_568()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25031, 542, 568);
return return_v;
}

}
}
