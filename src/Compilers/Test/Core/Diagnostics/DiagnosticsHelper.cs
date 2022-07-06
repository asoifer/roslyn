// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.Text;
using Xunit;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
public static class DiagnosticsHelper
{
private static TextSpan FindSpan(string source, string pattern)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25072,500,827);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25072,588,629);

var 
match = f_25072_600_628(source, pattern)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25072,643,755);

f_25072_643_754(f_25072_655_668(match), "Could not find a match for \"" + pattern + "\" in:" + f_25072_725_744()+ source);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25072,769,816);

return f_25072_776_815(f_25072_789_800(match), f_25072_802_814(match));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25072,500,827);

System.Text.RegularExpressions.Match
f_25072_600_628(string
input,string
pattern)
{
var return_v = Regex.Match( input, pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25072, 600, 628);
return return_v;
}


bool
f_25072_655_668(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25072, 655, 668);
return return_v;
}


string
f_25072_725_744()
{
var return_v = Environment.NewLine ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25072, 725, 744);
return return_v;
}


int
f_25072_643_754(bool
condition,string
userMessage)
{
Assert.True( condition, userMessage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25072, 643, 754);
return 0;
}


int
f_25072_789_800(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Index;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25072, 789, 800);
return return_v;
}


int
f_25072_802_814(System.Text.RegularExpressions.Match
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25072, 802, 814);
return return_v;
}


Microsoft.CodeAnalysis.Text.TextSpan
f_25072_776_815(int
start,int
length)
{
var return_v = new Microsoft.CodeAnalysis.Text.TextSpan( start, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25072, 776, 815);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25072,500,827);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25072,500,827);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static void VerifyDiagnostics(IEnumerable<Diagnostic> actualDiagnostics, params string[] expectedDiagnosticIds)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25072,839,1329);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25072,983,1045);

var 
actualDiagnosticIds = f_25072_1009_1044(actualDiagnostics, d => d.Id)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25072,1059,1318);

f_25072_1059_1317(f_25072_1071_1127(expectedDiagnosticIds, actualDiagnosticIds), f_25072_1146_1165()+ "Expected: " + f_25072_1183_1223(", ", expectedDiagnosticIds)+
f_25072_1243_1262()+ "Actual: " + f_25072_1278_1316(", ", actualDiagnosticIds));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25072,839,1329);

System.Collections.Generic.IEnumerable<string>
f_25072_1009_1044(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
source,System.Func<Microsoft.CodeAnalysis.Diagnostic, string>
selector)
{
var return_v = source.Select<Microsoft.CodeAnalysis.Diagnostic,string>( selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25072, 1009, 1044);
return return_v;
}


bool
f_25072_1071_1127(string[]
first,System.Collections.Generic.IEnumerable<string>
second)
{
var return_v = first.SequenceEqual<string>( second);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25072, 1071, 1127);
return return_v;
}


string
f_25072_1146_1165()
{
var return_v =                 Environment.NewLine ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25072, 1146, 1165);
return return_v;
}


string
f_25072_1183_1223(string
separator,params string[]
value)
{
var return_v = string.Join( separator, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25072, 1183, 1223);
return return_v;
}


string
f_25072_1243_1262()
{
var return_v =                 Environment.NewLine ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25072, 1243, 1262);
return return_v;
}


string
f_25072_1278_1316(string
separator,System.Collections.Generic.IEnumerable<string>
values)
{
var return_v = string.Join( separator, values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25072, 1278, 1316);
return return_v;
}


int
f_25072_1059_1317(bool
condition,string
userMessage)
{
Assert.True( condition, userMessage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25072, 1059, 1317);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25072,839,1329);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25072,839,1329);
}
		}

public static void VerifyDiagnostics(SemanticModel model, string source, string pattern, params string[] expectedDiagnosticIds)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25072,1341,1594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25072,1493,1583);

f_25072_1493_1582(f_25072_1511_1558(model, f_25072_1532_1557(source, pattern)), expectedDiagnosticIds);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25072,1341,1594);

Microsoft.CodeAnalysis.Text.TextSpan
f_25072_1532_1557(string
source,string
pattern)
{
var return_v = FindSpan( source, pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25072, 1532, 1557);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
f_25072_1511_1558(Microsoft.CodeAnalysis.SemanticModel
this_param,Microsoft.CodeAnalysis.Text.TextSpan
span)
{
var return_v = this_param.GetDiagnostics( (Microsoft.CodeAnalysis.Text.TextSpan?)span);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25072, 1511, 1558);
return return_v;
}


int
f_25072_1493_1582(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
actualDiagnostics,params string[]
expectedDiagnosticIds)
{
VerifyDiagnostics( (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)actualDiagnostics, expectedDiagnosticIds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25072, 1493, 1582);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25072,1341,1594);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25072,1341,1594);
}
		}

static DiagnosticsHelper()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25072,446,1601);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25072,446,1601);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25072,446,1601);
}

}
}
