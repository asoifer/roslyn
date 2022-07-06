// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis.Diagnostics;
using Xunit;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
public class OptionsDiagnosticAnalyzer<TLanguageKindEnum> : TestDiagnosticAnalyzer<TLanguageKindEnum> where TLanguageKindEnum : struct
{
private readonly AnalyzerOptions _expectedOptions;

private readonly Dictionary<string, AnalyzerOptions> _mismatchedOptions ;

public OptionsDiagnosticAnalyzer(AnalyzerOptions expectedOptions)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25077,805,1074);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25077,650,666);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25077,730,792);
this._mismatchedOptions = f_25077_751_792();DynAbs.Tracing.TraceSender.TraceSimpleStatement(25077,895,930);

_expectedOptions = expectedOptions;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25077,944,1063);

f_25077_944_1062(f_25077_957_1012(f_25077_957_1002(expectedOptions))== typeof(CompilerAnalyzerConfigOptionsProvider));
DynAbs.Tracing.TraceSender.TraceExitConstructor(25077,805,1074);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25077,805,1074);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25077,805,1074);
}
		}

protected override void OnAbstractMember(string AbstractMemberName, SyntaxNode node = null, ISymbol symbol = null, [CallerMemberName] string callerName = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25077,1086,1267);
DynAbs.Tracing.TraceSender.TraceExitMethod(25077,1086,1267);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25077,1086,1267);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25077,1086,1267);
}
		}

        protected override void OnOptions(AnalyzerOptions options, [CallerMemberName] string callerName = null)
        {
            if (AreEqual(options, _expectedOptions))
            {
                return;
            }

            if (_mismatchedOptions.ContainsKey(callerName))
            {
                _mismatchedOptions[callerName] = options;
            }
            else
            {
                _mismatchedOptions.Add(callerName, options);
            }
        }

private bool AreEqual(AnalyzerOptions actual, AnalyzerOptions expected)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25077,1787,2315);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25077,1883,2013) || true) && (actual.AdditionalFiles.Length != expected.AdditionalFiles.Length)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25077,1883,2013);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25077,1985,1998);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(25077,1883,2013);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25077,2038,2043);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25077,2029,2276) || true) && (i < actual.AdditionalFiles.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25077,2080,2083)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(25077,2029,2276))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25077,2029,2276);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25077,2117,2261) || true) && (f_25077_2121_2151(f_25077_2121_2143(actual)[i])!= f_25077_2155_2187(f_25077_2155_2179(expected)[i]))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25077,2117,2261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25077,2229,2242);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(25077,2117,2261);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25077,1,248);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25077,1,248);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25077,2292,2304);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(25077,1787,2315);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
f_25077_2121_2143(Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
this_param)
{
var return_v = this_param.AdditionalFiles;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25077, 2121, 2143);
return return_v;
}


string
f_25077_2121_2151(Microsoft.CodeAnalysis.AdditionalText
this_param)
{
var return_v = this_param.Path ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25077, 2121, 2151);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
f_25077_2155_2179(Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
this_param)
{
var return_v = this_param.AdditionalFiles;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25077, 2155, 2179);
return return_v;
}


string
f_25077_2155_2187(Microsoft.CodeAnalysis.AdditionalText
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25077, 2155, 2187);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25077,1787,2315);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25077,1787,2315);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void VerifyAnalyzerOptions()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25077,2327,2581);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25077,2387,2570);

f_25077_2387_2569(f_25077_2399_2423(_mismatchedOptions)== 0, f_25077_2455_2568(                        _mismatchedOptions, "Mismatched calls: ", (s, m) => s + "\r\nfrom : " + m.Key + ", options :" + m.Value));
DynAbs.Tracing.TraceSender.TraceExitMethod(25077,2327,2581);

int
f_25077_2399_2423(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25077, 2399, 2423);
return return_v;
}


string
f_25077_2455_2568(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions>
source,string
seed,System.Func<string, System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions>, string>
func)
{
var return_v = source.Aggregate<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions>,string>( seed, func);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25077, 2455, 2568);
return return_v;
}


int
f_25077_2387_2569(bool
condition,string
userMessage)
{
Assert.True( condition, userMessage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25077, 2387, 2569);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25077,2327,2581);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25077,2327,2581);
}
		}

static OptionsDiagnosticAnalyzer()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25077,466,2588);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25077,466,2588);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25077,466,2588);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25077,466,2588);

System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions>
f_25077_751_792()
{
var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25077, 751, 792);
return return_v;
}


static Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptionsProvider
f_25077_957_1002(Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
this_param)
{
var return_v = this_param.AnalyzerConfigOptionsProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25077, 957, 1002);
return return_v;
}


static System.Type
f_25077_957_1012(Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptionsProvider
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25077, 957, 1012);
return return_v;
}


static int
f_25077_944_1062(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25077, 944, 1062);
return 0;
}

}
}
