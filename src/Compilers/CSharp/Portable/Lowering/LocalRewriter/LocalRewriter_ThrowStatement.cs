// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitThrowStatement(BoundThrowStatement node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10528,316,688);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10528,412,473);

var 
result = (BoundStatement)DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitThrowStatement(node),10528,441,471)!
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10528,487,647) || true) && (f_10528_491_506(this)&&(DynAbs.Tracing.TraceSender.Expression_True(10528, 491, 536)&&f_10528_510_536_M(!node.WasCompilerGenerated)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10528,487,647);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10528,570,632);

result = f_10528_579_631(_instrumenter, node, result);
DynAbs.Tracing.TraceSender.TraceExitCondition(10528,487,647);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10528,663,677);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10528,316,688);

bool
f_10528_491_506(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10528, 491, 506);
return return_v;
}


bool
f_10528_510_536_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10528, 510, 536);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10528_579_631(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundThrowStatement
original,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewritten)
{
var return_v = this_param.InstrumentThrowStatement( original, rewritten);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10528, 579, 631);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10528,316,688);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10528,316,688);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
