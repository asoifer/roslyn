// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Roslyn.Test.Utilities
{
public static class EqualityUnit
{
public static EqualityUnit<T> Create<T>(T value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25048,318,436);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25048,391,425);

return f_25048_398_424(value);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25048,318,436);

Roslyn.Test.Utilities.EqualityUnit<T>
f_25048_398_424(T
value)
{
var return_v = new Roslyn.Test.Utilities.EqualityUnit<T>( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25048, 398, 424);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25048,318,436);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25048,318,436);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static EqualityUnit()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25048,269,443);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25048,269,443);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25048,269,443);
}

}
}
