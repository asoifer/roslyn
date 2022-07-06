// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;

namespace Roslyn.Test.Utilities
{
internal sealed class LazyToString
{
private readonly Func<object> _evaluator;

public LazyToString(Func<object> evaluator)
		{
			try
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25036,390,527);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25036,367,377);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25036,450,526);
_evaluator = evaluator ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Func<object>>(25036, 463, 526)??throw f_25036_482_526(nameof(evaluator)));DynAbs.Tracing.TraceSender.TraceExitConstructor(25036,390,527);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25036,390,527);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25036,390,527);
}
		}

public override string ToString()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25036,586,612);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25036,589,612);
return f_25036_589_612(f_25036_589_601(this));DynAbs.Tracing.TraceSender.TraceExitMethod(25036,586,612);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25036,586,612);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25036,586,612);
}
			throw new System.Exception("Slicer error: unreachable code");

object
f_25036_589_601(Roslyn.Test.Utilities.LazyToString
this_param)
{
var return_v = this_param._evaluator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25036, 589, 601);
return return_v;
}


string?
f_25036_589_612(object
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25036, 589, 612);
return return_v;
}

		}

static LazyToString()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25036,286,620);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25036,286,620);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25036,286,620);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25036,286,620);

static System.ArgumentNullException
f_25036_482_526(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25036, 482, 526);
return return_v;
}

}
}
