// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roslyn.Test.Utilities
{
public static class StringExtensions
{
public static string NormalizeLineEndings(this string input)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25097,445,706);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25097,530,666) || true) && (f_25097_534_554(input, "\n")&&(DynAbs.Tracing.TraceSender.Expression_True(25097, 534, 581)&&!f_25097_559_581(input, "\r\n")))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25097,530,666);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25097,615,651);

input = f_25097_623_650(input, "\n", "\r\n");
DynAbs.Tracing.TraceSender.TraceExitCondition(25097,530,666);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25097,682,695);

return input;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25097,445,706);

bool
f_25097_534_554(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25097, 534, 554);
return return_v;
}


bool
f_25097_559_581(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25097, 559, 581);
return return_v;
}


string
f_25097_623_650(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25097, 623, 650);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25097,445,706);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25097,445,706);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static StringExtensions()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25097,392,713);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25097,392,713);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25097,392,713);
}

}
}
