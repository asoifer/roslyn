// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
public static class VersionTestHelpers
{
public static void GetDefaultVersion(DateTime time, out int days, out int seconds)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25067,357,679);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25067,464,520);

days = (int)(time - f_25067_484_508(2000, 1, 1)).TotalDays;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25067,570,617);

seconds = (int)time.TimeOfDay.TotalSeconds / 2;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25067,357,679);

System.DateTime
f_25067_484_508(int
year,int
month,int
day)
{
var return_v = new System.DateTime( year, month, day);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25067, 484, 508);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25067,357,679);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25067,357,679);
}
		}

static VersionTestHelpers()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25067,302,686);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25067,302,686);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25067,302,686);
}

}
}
