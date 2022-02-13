// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitLabeledStatement(BoundLabeledStatement node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10508,472,735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10508,572,599);

f_10508_572_598(node != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10508,615,661);

var 
rewrittenBody = f_10508_635_660(this, f_10508_650_659(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10508,675,724);

return f_10508_682_723(this, node, rewrittenBody);
DynAbs.Tracing.TraceSender.TraceExitMethod(10508,472,735);

int
f_10508_572_598(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10508, 572, 598);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10508_650_659(Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10508, 650, 659);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10508_635_660(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
node)
{
var return_v = this_param.VisitStatement( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10508, 635, 660);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10508_682_723(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
node,Microsoft.CodeAnalysis.CSharp.BoundStatement?
rewrittenBody)
{
var return_v = this_param.MakeLabeledStatement( node, rewrittenBody);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10508, 682, 723);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10508,472,735);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10508,472,735);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement MakeLabeledStatement(BoundLabeledStatement node, BoundStatement? rewrittenBody)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10508,747,1638);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10508,874,955);

BoundStatement 
labelStatement = f_10508_906_954(node.Syntax, f_10508_943_953(node))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10508,971,1279) || true) && (f_10508_975_990(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10508,971,1279);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10508,1024,1082);

var 
labeledSyntax = node.Syntax as LabeledStatementSyntax
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10508,1100,1264) || true) && (labeledSyntax != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10508,1100,1264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10508,1167,1245);

labelStatement = f_10508_1184_1244(_instrumenter, node, labelStatement);
DynAbs.Tracing.TraceSender.TraceExitCondition(10508,1100,1264);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10508,971,1279);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10508,1295,1529) || true) && (rewrittenBody == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10508,1295,1529);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10508,1492,1514);

return labelStatement;
DynAbs.Tracing.TraceSender.TraceExitCondition(10508,1295,1529);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10508,1545,1627);

return f_10508_1552_1626(node.Syntax, labelStatement, rewrittenBody);
DynAbs.Tracing.TraceSender.TraceExitMethod(10508,747,1638);

Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
f_10508_943_953(Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
this_param)
{
var return_v = this_param.Label;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10508, 943, 953);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
f_10508_906_954(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement( syntax, label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10508, 906, 954);
return return_v;
}


bool
f_10508_975_990(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10508, 975, 990);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10508_1184_1244(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
original,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewritten)
{
var return_v = this_param.InstrumentLabelStatement( original, rewritten);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10508, 1184, 1244);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatementList
f_10508_1552_1626(Microsoft.CodeAnalysis.SyntaxNode
syntax,params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
statements)
{
var return_v = BoundStatementList.Synthesized( syntax, statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10508, 1552, 1626);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10508,747,1638);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10508,747,1638);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
