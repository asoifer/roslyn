// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using Microsoft.CodeAnalysis.Text;

namespace Roslyn.Test.Utilities
{
public sealed class ProcessResult
{
public int ExitCode {get; }

public string Output {get; }

public string Errors {get; }

public ProcessResult(int exitCode, string output, string errors)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25095,600,780);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25095,482,510);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25095,520,549);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25095,559,588);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25095,689,709);

ExitCode = exitCode;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25095,723,739);

Output = output;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25095,753,769);

Errors = errors;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25095,600,780);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25095,600,780);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25095,600,780);
}
		}

public override string ToString()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25095,792,1225);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25095,850,1214);

return "EXIT CODE: " +
DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_25095_893_906(this)).ToString(),25095,893,906)+
f_25095_929_948()+
                   "OUTPUT STREAM:" +
f_25095_1010_1029()+
f_25095_1052_1063(this)+
f_25095_1086_1105()+
                   "ERRORS:" +
f_25095_1160_1179()+
f_25095_1202_1213(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(25095,792,1225);

int
f_25095_893_906(Roslyn.Test.Utilities.ProcessResult
this_param)
{
var return_v = this_param.ExitCode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25095, 893, 906);
return return_v;
}


string
f_25095_929_948()
{
var return_v =                    Environment.NewLine ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25095, 929, 948);
return return_v;
}


string
f_25095_1010_1029()
{
var return_v =                    Environment.NewLine ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25095, 1010, 1029);
return return_v;
}


string
f_25095_1052_1063(Roslyn.Test.Utilities.ProcessResult
this_param)
{
var return_v = this_param.Output ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25095, 1052, 1063);
return return_v;
}


string
f_25095_1086_1105()
{
var return_v =                    Environment.NewLine ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25095, 1086, 1105);
return return_v;
}


string
f_25095_1160_1179()
{
var return_v =                    Environment.NewLine ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25095, 1160, 1179);
return return_v;
}


string
f_25095_1202_1213(Roslyn.Test.Utilities.ProcessResult
this_param)
{
var return_v = this_param.Errors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25095, 1202, 1213);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25095,792,1225);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25095,792,1225);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool ContainsErrors
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(25095,1288,1360);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25095,1294,1358);

return f_25095_1301_1314(this)!= 0 ||(DynAbs.Tracing.TraceSender.Expression_False(25095, 1301, 1357)||!f_25095_1324_1357(f_25095_1345_1356(this)));
DynAbs.Tracing.TraceSender.TraceExitMethod(25095,1288,1360);

int
f_25095_1301_1314(Roslyn.Test.Utilities.ProcessResult
this_param)
{
var return_v = this_param.ExitCode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25095, 1301, 1314);
return return_v;
}


string
f_25095_1345_1356(Roslyn.Test.Utilities.ProcessResult
this_param)
{
var return_v = this_param.Errors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25095, 1345, 1356);
return return_v;
}


bool
f_25095_1324_1357(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25095, 1324, 1357);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25095,1237,1371);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25095,1237,1371);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

static ProcessResult()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25095,432,1378);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25095,432,1378);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25095,432,1378);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25095,432,1378);
}
}
