// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable


using System;
using System.IO;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;

namespace Roslyn.Test.Utilities.CoreClr
{
internal static class SharedConsole
{
private static TextWriter s_savedConsoleOut;

private static TextWriter s_savedConsoleError;

private static AsyncLocal<StringWriter> s_currentOut;

private static AsyncLocal<StringWriter> s_currentError;

internal static void OverrideConsole()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25142,745,1149);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,808,840);

s_savedConsoleOut = f_25142_828_839();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,854,890);

s_savedConsoleError = f_25142_876_889();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,906,952);

s_currentOut = f_25142_921_951();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,966,1014);

s_currentError = f_25142_983_1013();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,1030,1075);

f_25142_1030_1074(f_25142_1045_1073());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,1089,1138);

f_25142_1089_1137(f_25142_1106_1136());
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25142,745,1149);

System.IO.TextWriter
f_25142_828_839()
{
var return_v = Console.Out;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25142, 828, 839);
return return_v;
}


System.IO.TextWriter
f_25142_876_889()
{
var return_v = Console.Error;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25142, 876, 889);
return return_v;
}


System.Threading.AsyncLocal<System.IO.StringWriter>
f_25142_921_951()
{
var return_v = new System.Threading.AsyncLocal<System.IO.StringWriter>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25142, 921, 951);
return return_v;
}


System.Threading.AsyncLocal<System.IO.StringWriter>
f_25142_983_1013()
{
var return_v = new System.Threading.AsyncLocal<System.IO.StringWriter>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25142, 983, 1013);
return return_v;
}


Roslyn.Test.Utilities.CoreClr.SharedConsole.SharedConsoleOutWriter
f_25142_1045_1073()
{
var return_v = new Roslyn.Test.Utilities.CoreClr.SharedConsole.SharedConsoleOutWriter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25142, 1045, 1073);
return return_v;
}


int
f_25142_1030_1074(Roslyn.Test.Utilities.CoreClr.SharedConsole.SharedConsoleOutWriter
newOut)
{
Console.SetOut( (System.IO.TextWriter)newOut);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25142, 1030, 1074);
return 0;
}


Roslyn.Test.Utilities.CoreClr.SharedConsole.SharedConsoleErrorWriter
f_25142_1106_1136()
{
var return_v = new Roslyn.Test.Utilities.CoreClr.SharedConsole.SharedConsoleErrorWriter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25142, 1106, 1136);
return return_v;
}


int
f_25142_1089_1137(Roslyn.Test.Utilities.CoreClr.SharedConsole.SharedConsoleErrorWriter
newError)
{
Console.SetError( (System.IO.TextWriter)newError);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25142, 1089, 1137);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25142,745,1149);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25142,745,1149);
}
		}

public static void CaptureOutput(Action action, int expectedLength, out string output, out string errorOutput)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25142,1161,1994);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,1296,1354);

var 
outputWriter = f_25142_1315_1353(expectedLength)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,1368,1431);

var 
errorOutputWriter = f_25142_1392_1430(expectedLength)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,1447,1484);

var 
savedOutput = f_25142_1465_1483(s_currentOut)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,1498,1536);

var 
savedError = f_25142_1515_1535(s_currentError)
;

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,1588,1622);

s_currentOut.Value = outputWriter;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,1640,1681);

s_currentError.Value = errorOutputWriter;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,1699,1708);

f_25142_1699_1707(action);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(25142,1737,1877);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,1777,1810);

s_currentOut.Value = savedOutput;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,1828,1862);

s_currentError.Value = savedError;
DynAbs.Tracing.TraceSender.TraceExitFinally(25142,1737,1877);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,1893,1926);

output = f_25142_1902_1925(outputWriter);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,1940,1983);

errorOutput = f_25142_1954_1982(errorOutputWriter);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25142,1161,1994);

Microsoft.CodeAnalysis.Test.Utilities.CappedStringWriter
f_25142_1315_1353(int
expectedLength)
{
var return_v = new Microsoft.CodeAnalysis.Test.Utilities.CappedStringWriter( expectedLength);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25142, 1315, 1353);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CappedStringWriter
f_25142_1392_1430(int
expectedLength)
{
var return_v = new Microsoft.CodeAnalysis.Test.Utilities.CappedStringWriter( expectedLength);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25142, 1392, 1430);
return return_v;
}


System.IO.StringWriter?
f_25142_1465_1483(System.Threading.AsyncLocal<System.IO.StringWriter>
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25142, 1465, 1483);
return return_v;
}


System.IO.StringWriter?
f_25142_1515_1535(System.Threading.AsyncLocal<System.IO.StringWriter>
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25142, 1515, 1535);
return return_v;
}


int
f_25142_1699_1707(System.Action
this_param)
{
this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25142, 1699, 1707);
return 0;
}


string
f_25142_1902_1925(Microsoft.CodeAnalysis.Test.Utilities.CappedStringWriter
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25142, 1902, 1925);
return return_v;
}


string
f_25142_1954_1982(Microsoft.CodeAnalysis.Test.Utilities.CappedStringWriter
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25142, 1954, 1982);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25142,1161,1994);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25142,1161,1994);
}
		}
private sealed class SharedConsoleOutWriter : SharedConsoleWriter
{
public override TextWriter Underlying {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25142,2134,2176);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,2137,2176);
return f_25142_2137_2155(s_currentOut)??(DynAbs.Tracing.TraceSender.Expression_Null<System.IO.StringWriter?>(25142, 2137, 2176)??s_savedConsoleOut);DynAbs.Tracing.TraceSender.TraceExitMethod(25142,2134,2176);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25142,2134,2176);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25142,2134,2176);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public SharedConsoleOutWriter()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25142,2006,2188);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25142,2006,2188);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25142,2006,2188);
}


static SharedConsoleOutWriter()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25142,2006,2188);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25142,2006,2188);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25142,2006,2188);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25142,2006,2188);

System.IO.StringWriter?
f_25142_2137_2155(System.Threading.AsyncLocal<System.IO.StringWriter>
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25142, 2137, 2155);
return return_v;
}

}
private sealed class SharedConsoleErrorWriter : SharedConsoleWriter
{
public override TextWriter Underlying {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25142,2330,2376);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,2333,2376);
return f_25142_2333_2353(s_currentError)??(DynAbs.Tracing.TraceSender.Expression_Null<System.IO.StringWriter?>(25142, 2333, 2376)??s_savedConsoleError);DynAbs.Tracing.TraceSender.TraceExitMethod(25142,2330,2376);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25142,2330,2376);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25142,2330,2376);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public SharedConsoleErrorWriter()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25142,2200,2388);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25142,2200,2388);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25142,2200,2388);
}


static SharedConsoleErrorWriter()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25142,2200,2388);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25142,2200,2388);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25142,2200,2388);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25142,2200,2388);

System.IO.StringWriter?
f_25142_2333_2353(System.Threading.AsyncLocal<System.IO.StringWriter>
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25142, 2333, 2353);
return return_v;
}

}
private abstract class SharedConsoleWriter : TextWriter
{
public override Encoding Encoding {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25142,2514,2536);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,2517,2536);
return f_25142_2517_2536(f_25142_2517_2527());DynAbs.Tracing.TraceSender.TraceExitMethod(25142,2514,2536);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25142,2514,2536);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25142,2514,2536);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public abstract TextWriter Underlying {get; }

public override void Write(char value) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25142,2654,2680);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,2657,2680);
f_25142_2657_2680(f_25142_2657_2667(), value);DynAbs.Tracing.TraceSender.TraceExitMethod(25142,2654,2680);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25142,2654,2680);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25142,2654,2680);
}

System.IO.TextWriter
f_25142_2657_2667()
{
var return_v = Underlying;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25142, 2657, 2667);
return return_v;
}


int
f_25142_2657_2680(System.IO.TextWriter
this_param,char
value)
{
this_param.Write( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25142, 2657, 2680);
return 0;
}

		}

public SharedConsoleWriter()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25142,2400,2692);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25142,2400,2692);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25142,2400,2692);
}


static SharedConsoleWriter()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25142,2400,2692);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25142,2400,2692);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25142,2400,2692);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25142,2400,2692);

System.IO.TextWriter
f_25142_2517_2527()
{
var return_v = Underlying;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25142, 2517, 2527);
return return_v;
}


System.Text.Encoding
f_25142_2517_2536(System.IO.TextWriter
this_param)
{
var return_v = this_param.Encoding;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25142, 2517, 2536);
return return_v;
}

}

static SharedConsole()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25142,451,2699);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,529,546);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,583,602);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,655,667);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25142,718,732);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25142,451,2699);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25142,451,2699);
}

}
}

