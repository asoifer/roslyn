// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Roslyn.Test.Utilities
{
public static class RegexExtensions
{
public static IEnumerable<Match> ToEnumerable(this MatchCollection collection)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25096,397,605);

var listYield= new List<Match>();
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25096,500,594);
foreach(Match m in f_25096_520_530_I(collection) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25096,500,594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25096,564,579);

listYield.Add(m);
DynAbs.Tracing.TraceSender.TraceExitCondition(25096,500,594);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25096,1,95);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25096,1,95);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25096,397,605);

return listYield;

System.Text.RegularExpressions.MatchCollection
f_25096_520_530_I(System.Text.RegularExpressions.MatchCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25096, 520, 530);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25096,397,605);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25096,397,605);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static RegexExtensions()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25096,345,612);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25096,345,612);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25096,345,612);
}

}
}
