// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Moq;
using System.Linq;

namespace Roslyn.Test.Utilities
{
public static class MoqExtensions
{
public static void VerifyAndClear(this IInvocationList invocations, params (string Name, object[] Args)[] expectedInvocations)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25111,353,939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25111,504,706);

f_25111_504_705(f_25111_537_609(                expectedInvocations, i => $"{i.Name}: {string.Join(",", i.Args)}"), f_25111_628_704(                invocations, i => $"{i.Method.Name}: {string.Join(",", i.Arguments)}"));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25111,731,736);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25111,722,892) || true) && (i < f_25111_742_768(expectedInvocations))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25111,770,773)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(25111,722,892))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25111,722,892);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25111,807,877);

f_25111_807_876(expectedInvocations[i].Args, f_25111_851_875(f_25111_851_865(invocations, i)));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25111,1,171);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25111,1,171);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25111,908,928);

f_25111_908_927(
            invocations);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25111,353,939);

System.Collections.Generic.IEnumerable<string>
f_25111_537_609((string Name, object[] Args)[]
source,System.Func<(string Name, object[] Args), string>
selector)
{
var return_v = source.Select<(string Name, object[] Args),string>( selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25111, 537, 609);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_25111_628_704(Moq.IInvocationList
source,System.Func<Moq.IInvocation, string>
selector)
{
var return_v = source.Select<Moq.IInvocation,string>( selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25111, 628, 704);
return return_v;
}


bool
f_25111_504_705(System.Collections.Generic.IEnumerable<string>
expected,System.Collections.Generic.IEnumerable<string>
actual)
{
var return_v = AssertEx.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25111, 504, 705);
return return_v;
}


int
f_25111_742_768((string Name, object[] Args)[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25111, 742, 768);
return return_v;
}


Moq.IInvocation
f_25111_851_865(Moq.IInvocationList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25111, 851, 865);
return return_v;
}


System.Collections.Generic.IReadOnlyList<object>
f_25111_851_875(Moq.IInvocation
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25111, 851, 875);
return return_v;
}


bool
f_25111_807_876(object[]
expected,System.Collections.Generic.IReadOnlyList<object>
actual)
{
var return_v = AssertEx.Equal( (System.Collections.Generic.IEnumerable<object>)expected, (System.Collections.Generic.IEnumerable<object>)actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25111, 807, 876);
return return_v;
}


int
f_25111_908_927(Moq.IInvocationList
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25111, 908, 927);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25111,353,939);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25111,353,939);
}
		}

static MoqExtensions()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25111,303,946);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25111,303,946);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25111,303,946);
}

}
}
