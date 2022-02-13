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
public override BoundNode VisitGotoStatement(BoundGotoStatement node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10501,445,1538);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10501,833,875);

BoundExpression? 
caseExpressionOpt = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10501,1185,1223);

BoundLabel? 
labelExpressionOpt = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10501,1237,1324);

BoundStatement 
result = f_10501_1261_1323(node, f_10501_1273_1283(node), caseExpressionOpt, labelExpressionOpt)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10501,1338,1497) || true) && (f_10501_1342_1357(this)&&(DynAbs.Tracing.TraceSender.Expression_True(10501, 1342, 1387)&&f_10501_1361_1387_M(!node.WasCompilerGenerated)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10501,1338,1497);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10501,1421,1482);

result = f_10501_1430_1481(_instrumenter, node, result);
DynAbs.Tracing.TraceSender.TraceExitCondition(10501,1338,1497);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10501,1513,1527);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10501,445,1538);

Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
f_10501_1273_1283(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
this_param)
{
var return_v = this_param.Label;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10501, 1273, 1283);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
f_10501_1261_1323(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
label,Microsoft.CodeAnalysis.CSharp.BoundExpression?
caseExpressionOpt,Microsoft.CodeAnalysis.CSharp.BoundLabel?
labelExpressionOpt)
{
var return_v = this_param.Update( label, caseExpressionOpt, labelExpressionOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10501, 1261, 1323);
return return_v;
}


bool
f_10501_1342_1357(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10501, 1342, 1357);
return return_v;
}


bool
f_10501_1361_1387_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10501, 1361, 1387);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10501_1430_1481(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
original,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewritten)
{
var return_v = this_param.InstrumentGotoStatement( original, rewritten);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10501, 1430, 1481);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10501,445,1538);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10501,445,1538);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode? VisitLabel(BoundLabel node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10501,1550,1946);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10501,1923,1935);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(10501,1550,1946);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10501,1550,1946);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10501,1550,1946);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
