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
public override BoundNode VisitContinueStatement(BoundContinueStatement node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10489,445,853);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10489,547,635);

BoundStatement 
result = f_10489_571_634(node.Syntax, f_10489_607_617(node), f_10489_619_633(node))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10489,649,812) || true) && (f_10489_653_668(this)&&(DynAbs.Tracing.TraceSender.Expression_True(10489, 653, 698)&&f_10489_672_698_M(!node.WasCompilerGenerated)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10489,649,812);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10489,732,797);

result = f_10489_741_796(_instrumenter, node, result);
DynAbs.Tracing.TraceSender.TraceExitCondition(10489,649,812);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10489,828,842);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10489,445,853);

Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10489_607_617(Microsoft.CodeAnalysis.CSharp.BoundContinueStatement
this_param)
{
var return_v = this_param.Label;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10489, 607, 617);
return return_v;
}


bool
f_10489_619_633(Microsoft.CodeAnalysis.CSharp.BoundContinueStatement
this_param)
{
var return_v = this_param.HasErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10489, 619, 633);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
f_10489_571_634(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label,bool
hasErrors)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundGotoStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label, hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10489, 571, 634);
return return_v;
}


bool
f_10489_653_668(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10489, 653, 668);
return return_v;
}


bool
f_10489_672_698_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10489, 672, 698);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10489_741_796(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundContinueStatement
original,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewritten)
{
var return_v = this_param.InstrumentContinueStatement( original, rewritten);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10489, 741, 796);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10489,445,853);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10489,445,853);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
