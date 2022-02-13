// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitBreakStatement(BoundBreakStatement node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10484,445,844);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10484,541,629);

BoundStatement 
result = f_10484_565_628(node.Syntax, f_10484_601_611(node), f_10484_613_627(node))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10484,643,803) || true) && (f_10484_647_662(this)&&(DynAbs.Tracing.TraceSender.Expression_True(10484, 647, 692)&&f_10484_666_692_M(!node.WasCompilerGenerated)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10484,643,803);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10484,726,788);

result = f_10484_735_787(_instrumenter, node, result);
DynAbs.Tracing.TraceSender.TraceExitCondition(10484,643,803);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10484,819,833);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10484,445,844);

Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10484_601_611(Microsoft.CodeAnalysis.CSharp.BoundBreakStatement
this_param)
{
var return_v = this_param.Label;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10484, 601, 611);
return return_v;
}


bool
f_10484_613_627(Microsoft.CodeAnalysis.CSharp.BoundBreakStatement
this_param)
{
var return_v = this_param.HasErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10484, 613, 627);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
f_10484_565_628(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label,bool
hasErrors)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundGotoStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label, hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10484, 565, 628);
return return_v;
}


bool
f_10484_647_662(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10484, 647, 662);
return return_v;
}


bool
f_10484_666_692_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10484, 666, 692);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10484_735_787(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundBreakStatement
original,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewritten)
{
var return_v = this_param.InstrumentBreakStatement( original, rewritten);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10484, 735, 787);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10484,445,844);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10484,445,844);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
