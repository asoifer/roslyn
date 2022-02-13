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
public override BoundNode VisitExpressionStatement(BoundExpressionStatement node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10495,472,845);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10495,747,834);

return f_10495_754_786(this, node)??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundStatement?>(10495, 754, 833)??f_10495_790_833(node.Syntax));
DynAbs.Tracing.TraceSender.TraceExitMethod(10495,472,845);

Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10495_754_786(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
node)
{
var return_v = this_param.RewriteExpressionStatement( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10495, 754, 786);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatementList
f_10495_790_833(Microsoft.CodeAnalysis.SyntaxNode
syntax,params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
statements)
{
var return_v = BoundStatementList.Synthesized( syntax, statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10495, 790, 833);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10495,472,845);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10495,472,845);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement? RewriteExpressionStatement(BoundExpressionStatement node, bool suppressInstrumentation = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10495,857,1559);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10495,1001,1064);

var 
loweredExpression = f_10495_1025_1063(this, f_10495_1047_1062(node))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10495,1080,1548) || true) && (loweredExpression == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10495,1080,1548);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10495,1143,1155);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10495,1080,1548);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10495,1080,1548);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10495,1221,1276);

BoundStatement 
result = f_10495_1245_1275(node, loweredExpression)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10495,1294,1499) || true) && (!suppressInstrumentation &&(DynAbs.Tracing.TraceSender.Expression_True(10495, 1298, 1341)&&f_10495_1326_1341(this))&&(DynAbs.Tracing.TraceSender.Expression_True(10495, 1298, 1371)&&f_10495_1345_1371_M(!node.WasCompilerGenerated)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10495,1294,1499);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10495,1413,1480);

result = f_10495_1422_1479(_instrumenter, node, result);
DynAbs.Tracing.TraceSender.TraceExitCondition(10495,1294,1499);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10495,1519,1533);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(10495,1080,1548);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10495,857,1559);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10495_1047_1062(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10495, 1047, 1062);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10495_1025_1063(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.VisitUnusedExpression( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10495, 1025, 1063);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10495_1245_1275(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.Update( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10495, 1245, 1275);
return return_v;
}


bool
f_10495_1326_1341(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10495, 1326, 1341);
return return_v;
}


bool
f_10495_1345_1371_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10495, 1345, 1371);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10495_1422_1479(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
original,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewritten)
{
var return_v = this_param.InstrumentExpressionStatement( original, rewritten);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10495, 1422, 1479);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10495,857,1559);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10495,857,1559);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression? VisitUnusedExpression(BoundExpression expression)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10495,1571,3270);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10495,1670,1761) || true) && (f_10495_1674_1694(expression))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10495,1670,1761);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10495,1728,1746);

return expression;
DynAbs.Tracing.TraceSender.TraceExitCondition(10495,1670,1761);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10495,1777,3210);

switch (f_10495_1785_1800(expression))
            {

case BoundKind.AwaitExpression:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10495,1777,3210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10495,1887,1962);

return f_10495_1894_1961(this, expression, used: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10495,1777,3210);

case BoundKind.AssignmentOperator:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10495,1777,3210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10495,2132,2213);

return f_10495_2139_2212(this, expression, used: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10495,1777,3210);

case BoundKind.CompoundAssignmentOperator:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10495,1777,3210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10495,2297,2394);

return f_10495_2304_2393(this, expression, used: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10495,1777,3210);

case BoundKind.Call:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10495,1777,3210);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10495,2456,2769) || true) && (_allowOmissionOfConditionalCalls)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10495,2456,2769);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10495,2542,2575);

var 
call = (BoundCall)expression
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10495,2601,2746) || true) && (f_10495_2605_2649(f_10495_2605_2616(call), f_10495_2633_2648(call)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10495,2601,2746);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10495,2707,2719);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10495,2601,2746);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10495,2456,2769);
}
DynAbs.Tracing.TraceSender.TraceBreak(10495,2791,2797);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10495,1777,3210);

case BoundKind.DynamicInvocation:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10495,1777,3210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10495,2950,3039);

return f_10495_2957_3038(this, expression, resultDiscarded: true);
DynAbs.Tracing.TraceSender.TraceExitCondition(10495,1777,3210);

case BoundKind.ConditionalAccess:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10495,1777,3210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10495,3114,3195);

return f_10495_3121_3194(this, expression, used: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10495,1777,3210);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10495,3224,3259);

return f_10495_3231_3258(this, expression);
DynAbs.Tracing.TraceSender.TraceExitMethod(10495,1571,3270);

bool
f_10495_1674_1694(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.HasErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10495, 1674, 1694);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10495_1785_1800(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10495, 1785, 1800);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10495_1894_1961(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node,bool
used)
{
var return_v = this_param.VisitAwaitExpression( (Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression)node, used: used);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10495, 1894, 1961);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10495_2139_2212(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node,bool
used)
{
var return_v = this_param.VisitAssignmentOperator( (Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator)node, used: used);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10495, 2139, 2212);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10495_2304_2393(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node,bool
used)
{
var return_v = this_param.VisitCompoundAssignmentOperator( (Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator)node, used: used);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10495, 2304, 2393);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10495_2605_2616(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10495, 2605, 2616);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTree?
f_10495_2633_2648(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.SyntaxTree;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10495, 2633, 2648);
return return_v;
}


bool
f_10495_2605_2649(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param,Microsoft.CodeAnalysis.SyntaxTree?
syntaxTree)
{
var return_v = this_param.CallsAreOmitted( syntaxTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10495, 2605, 2649);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10495_2957_3038(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node,bool
resultDiscarded)
{
var return_v = this_param.VisitDynamicInvocation( (Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation)node, resultDiscarded: resultDiscarded);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10495, 2957, 3038);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10495_3121_3194(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node,bool
used)
{
var return_v = this_param.RewriteConditionalAccess( (Microsoft.CodeAnalysis.CSharp.BoundConditionalAccess)node, used: used);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10495, 3121, 3194);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10495_3231_3258(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10495, 3231, 3258);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10495,1571,3270);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10495,1571,3270);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
