// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis;

namespace Roslyn.Test.Utilities
{
internal static class ExceptionHelper
{
internal static string GetMessageFromResult(IEnumerable<Diagnostic> diagnostics, string directory)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25032,426,857);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,549,588);

StringBuilder 
sb = f_25032_568_587()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,602,652);

f_25032_602_651(            sb, "Emit Failed, binaries saved to: ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,666,691);

f_25032_666_690(            sb, directory);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,705,811);
foreach(var d in f_25032_723_734_I(diagnostics) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25032,705,811);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,768,796);

f_25032_768_795(                sb, f_25032_782_794(d));
DynAbs.Tracing.TraceSender.TraceExitCondition(25032,705,811);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25032,1,107);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25032,1,107);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,825,846);

return f_25032_832_845(sb);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25032,426,857);

System.Text.StringBuilder
f_25032_568_587()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 568, 587);
return return_v;
}


System.Text.StringBuilder
f_25032_602_651(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 602, 651);
return return_v;
}


System.Text.StringBuilder
f_25032_666_690(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 666, 690);
return return_v;
}


string
f_25032_782_794(Microsoft.CodeAnalysis.Diagnostic
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 782, 794);
return return_v;
}


System.Text.StringBuilder
f_25032_768_795(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 768, 795);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
f_25032_723_734_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 723, 734);
return return_v;
}


string
f_25032_832_845(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 832, 845);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25032,426,857);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25032,426,857);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string GetMessageFromResult(string output, string exePath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25032,869,1244);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,968,1007);

StringBuilder 
sb = f_25032_987_1006()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,1021,1037);

f_25032_1021_1036(            sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,1051,1095);

f_25032_1051_1094(            sb, "PeVerify failed for assembly '");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,1109,1128);

f_25032_1109_1127(            sb, exePath);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,1142,1162);

f_25032_1142_1161(            sb, "':");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,1176,1198);

f_25032_1176_1197(            sb, output);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,1212,1233);

return f_25032_1219_1232(sb);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25032,869,1244);

System.Text.StringBuilder
f_25032_987_1006()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 987, 1006);
return return_v;
}


System.Text.StringBuilder
f_25032_1021_1036(System.Text.StringBuilder
this_param)
{
var return_v = this_param.AppendLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 1021, 1036);
return return_v;
}


System.Text.StringBuilder
f_25032_1051_1094(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 1051, 1094);
return return_v;
}


System.Text.StringBuilder
f_25032_1109_1127(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 1109, 1127);
return return_v;
}


System.Text.StringBuilder
f_25032_1142_1161(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 1142, 1161);
return return_v;
}


System.Text.StringBuilder
f_25032_1176_1197(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 1176, 1197);
return return_v;
}


string
f_25032_1219_1232(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 1219, 1232);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25032,869,1244);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25032,869,1244);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string GetMessageFromException(Exception executionException, string exePath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25032,1256,1674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,1373,1412);

StringBuilder 
sb = f_25032_1392_1411()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,1426,1442);

f_25032_1426_1441(            sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,1456,1501);

f_25032_1456_1500(            sb, "Execution failed for assembly '");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,1515,1534);

f_25032_1515_1533(            sb, exePath);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,1548,1568);

f_25032_1548_1567(            sb, "'.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,1582,1628);

f_25032_1582_1627(            sb, "Exception: " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (executionException).ToString(),25032,1608,1626));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,1642,1663);

return f_25032_1649_1662(sb);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25032,1256,1674);

System.Text.StringBuilder
f_25032_1392_1411()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 1392, 1411);
return return_v;
}


System.Text.StringBuilder
f_25032_1426_1441(System.Text.StringBuilder
this_param)
{
var return_v = this_param.AppendLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 1426, 1441);
return return_v;
}


System.Text.StringBuilder
f_25032_1456_1500(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 1456, 1500);
return return_v;
}


System.Text.StringBuilder
f_25032_1515_1533(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 1515, 1533);
return return_v;
}


System.Text.StringBuilder
f_25032_1548_1567(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 1548, 1567);
return return_v;
}


System.Text.StringBuilder
f_25032_1582_1627(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 1582, 1627);
return return_v;
}


string
f_25032_1649_1662(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 1649, 1662);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25032,1256,1674);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25032,1256,1674);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string GetMessageFromResult(string expectedOutput, string actualOutput, string exePath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25032,1686,2438);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,1814,1853);

StringBuilder 
sb = f_25032_1833_1852()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,1867,1883);

f_25032_1867_1882(            sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,1897,1942);

f_25032_1897_1941(            sb, "Execution failed for assembly '");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,1956,1975);

f_25032_1956_1974(            sb, exePath);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,1989,2009);

f_25032_1989_2008(            sb, "'.");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,2023,2392) || true) && (expectedOutput != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25032,2023,2392);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,2083,2107);

f_25032_2083_2106(                sb, "Expected: ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,2125,2155);

f_25032_2125_2154(                sb, expectedOutput);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,2173,2197);

f_25032_2173_2196(                sb, "Actual:   ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,2215,2243);

f_25032_2215_2242(                sb, actualOutput);
DynAbs.Tracing.TraceSender.TraceExitCondition(25032,2023,2392);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25032,2023,2392);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,2309,2331);

f_25032_2309_2330(                sb, "Output: ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,2349,2377);

f_25032_2349_2376(                sb, actualOutput);
DynAbs.Tracing.TraceSender.TraceExitCondition(25032,2023,2392);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25032,2406,2427);

return f_25032_2413_2426(sb);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25032,1686,2438);

System.Text.StringBuilder
f_25032_1833_1852()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 1833, 1852);
return return_v;
}


System.Text.StringBuilder
f_25032_1867_1882(System.Text.StringBuilder
this_param)
{
var return_v = this_param.AppendLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 1867, 1882);
return return_v;
}


System.Text.StringBuilder
f_25032_1897_1941(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 1897, 1941);
return return_v;
}


System.Text.StringBuilder
f_25032_1956_1974(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 1956, 1974);
return return_v;
}


System.Text.StringBuilder
f_25032_1989_2008(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 1989, 2008);
return return_v;
}


System.Text.StringBuilder
f_25032_2083_2106(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 2083, 2106);
return return_v;
}


System.Text.StringBuilder
f_25032_2125_2154(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 2125, 2154);
return return_v;
}


System.Text.StringBuilder
f_25032_2173_2196(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 2173, 2196);
return return_v;
}


System.Text.StringBuilder
f_25032_2215_2242(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 2215, 2242);
return return_v;
}


System.Text.StringBuilder
f_25032_2309_2330(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 2309, 2330);
return return_v;
}


System.Text.StringBuilder
f_25032_2349_2376(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 2349, 2376);
return return_v;
}


string
f_25032_2413_2426(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25032, 2413, 2426);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25032,1686,2438);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25032,1686,2438);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static ExceptionHelper()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25032,372,2445);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25032,372,2445);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25032,372,2445);
}

}
}
