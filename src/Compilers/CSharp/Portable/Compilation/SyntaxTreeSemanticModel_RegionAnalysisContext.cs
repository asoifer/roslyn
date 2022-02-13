// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
internal partial class SyntaxTreeSemanticModel : CSharpSemanticModel
{
private RegionAnalysisContext RegionAnalysisContext(ExpressionSyntax expression)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10931,689,1654);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10931,794,943) || true) && (f_10931_801_818(expression)== SyntaxKind.ParenthesizedExpression)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10931,794,943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10931,875,943);

expression = f_10931_888_942(((ParenthesizedExpressionSyntax)expression));
DynAbs.Tracing.TraceSender.TraceExitCondition(10931,794,943);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10931,794,943);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10931,794,943);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10931,959,1004);

var 
memberModel = f_10931_977_1003(this, expression)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10931,1018,1318) || true) && (memberModel == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10931,1018,1318);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10931,1120,1215);

var 
node = f_10931_1131_1214(expression, ImmutableArray<BoundNode>.Empty, hasErrors: true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10931,1233,1303);

return f_10931_1240_1302(f_10931_1266_1277(), null, node, node, node);
DynAbs.Tracing.TraceSender.TraceExitCondition(10931,1018,1318);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10931,1334,1348);

Symbol 
member
=default(Symbol);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10931,1362,1422);

BoundNode 
boundNode = f_10931_1384_1421(memberModel, out member)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10931,1436,1515);

var 
first = f_10931_1448_1514(memberModel, expression, promoteToBindable: true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10931,1529,1546);

var 
last = first
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10931,1560,1643);

return f_10931_1567_1642(f_10931_1593_1609(this), member, boundNode, first, last);
DynAbs.Tracing.TraceSender.TraceExitMethod(10931,689,1654);

Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10931_801_818(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10931, 801, 818);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
f_10931_888_942(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10931, 888, 942);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
f_10931_977_1003(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
node)
{
var return_v = this_param.GetMemberModel( (Microsoft.CodeAnalysis.SyntaxNode)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10931, 977, 1003);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBadStatement
f_10931_1131_1214(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
childBoundNodes,bool
hasErrors)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadStatement( (Microsoft.CodeAnalysis.SyntaxNode)syntax, childBoundNodes, hasErrors: hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10931, 1131, 1214);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_10931_1266_1277()
{
var return_v = Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10931, 1266, 1277);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.RegionAnalysisContext
f_10931_1240_1302(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Symbol
member,Microsoft.CodeAnalysis.CSharp.BoundBadStatement
boundNode,Microsoft.CodeAnalysis.CSharp.BoundBadStatement
firstInRegion,Microsoft.CodeAnalysis.CSharp.BoundBadStatement
lastInRegion)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.RegionAnalysisContext( compilation, member, (Microsoft.CodeAnalysis.CSharp.BoundNode)boundNode, (Microsoft.CodeAnalysis.CSharp.BoundNode)firstInRegion, (Microsoft.CodeAnalysis.CSharp.BoundNode)lastInRegion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10931, 1240, 1302);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode
f_10931_1384_1421(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
memberModel,out Microsoft.CodeAnalysis.CSharp.Symbol
member)
{
var return_v = GetBoundRoot( memberModel, out member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10931, 1384, 1421);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode
f_10931_1448_1514(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
node,bool
promoteToBindable)
{
var return_v = this_param.GetUpperBoundNode( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, promoteToBindable: promoteToBindable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10931, 1448, 1514);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_10931_1593_1609(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10931, 1593, 1609);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.RegionAnalysisContext
f_10931_1567_1642(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Symbol
member,Microsoft.CodeAnalysis.CSharp.BoundNode
boundNode,Microsoft.CodeAnalysis.CSharp.BoundNode
firstInRegion,Microsoft.CodeAnalysis.CSharp.BoundNode
lastInRegion)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.RegionAnalysisContext( compilation, member, boundNode, firstInRegion, lastInRegion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10931, 1567, 1642);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10931,689,1654);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10931,689,1654);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private RegionAnalysisContext RegionAnalysisContext(StatementSyntax firstStatement, StatementSyntax lastStatement)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10931,1666,2571);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10931,1805,1854);

var 
memberModel = f_10931_1823_1853(this, firstStatement)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10931,1868,2172) || true) && (memberModel == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10931,1868,2172);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10931,1970,2069);

var 
node = f_10931_1981_2068(firstStatement, ImmutableArray<BoundNode>.Empty, hasErrors: true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10931,2087,2157);

return f_10931_2094_2156(f_10931_2120_2131(), null, node, node, node);
DynAbs.Tracing.TraceSender.TraceExitCondition(10931,1868,2172);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10931,2188,2202);

Symbol 
member
=default(Symbol);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10931,2216,2276);

BoundNode 
boundNode = f_10931_2238_2275(memberModel, out member)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10931,2290,2373);

var 
first = f_10931_2302_2372(memberModel, firstStatement, promoteToBindable: true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10931,2387,2468);

var 
last = f_10931_2398_2467(memberModel, lastStatement, promoteToBindable: true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10931,2482,2560);

return f_10931_2489_2559(f_10931_2515_2526(), member, boundNode, first, last);
DynAbs.Tracing.TraceSender.TraceExitMethod(10931,1666,2571);

Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
f_10931_1823_1853(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
node)
{
var return_v = this_param.GetMemberModel( (Microsoft.CodeAnalysis.SyntaxNode)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10931, 1823, 1853);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBadStatement
f_10931_1981_2068(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
childBoundNodes,bool
hasErrors)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadStatement( (Microsoft.CodeAnalysis.SyntaxNode)syntax, childBoundNodes, hasErrors: hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10931, 1981, 2068);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_10931_2120_2131()
{
var return_v = Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10931, 2120, 2131);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.RegionAnalysisContext
f_10931_2094_2156(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Symbol
member,Microsoft.CodeAnalysis.CSharp.BoundBadStatement
boundNode,Microsoft.CodeAnalysis.CSharp.BoundBadStatement
firstInRegion,Microsoft.CodeAnalysis.CSharp.BoundBadStatement
lastInRegion)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.RegionAnalysisContext( compilation, member, (Microsoft.CodeAnalysis.CSharp.BoundNode)boundNode, (Microsoft.CodeAnalysis.CSharp.BoundNode)firstInRegion, (Microsoft.CodeAnalysis.CSharp.BoundNode)lastInRegion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10931, 2094, 2156);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode
f_10931_2238_2275(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
memberModel,out Microsoft.CodeAnalysis.CSharp.Symbol
member)
{
var return_v = GetBoundRoot( memberModel, out member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10931, 2238, 2275);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode
f_10931_2302_2372(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
node,bool
promoteToBindable)
{
var return_v = this_param.GetUpperBoundNode( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, promoteToBindable: promoteToBindable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10931, 2302, 2372);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode
f_10931_2398_2467(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
node,bool
promoteToBindable)
{
var return_v = this_param.GetUpperBoundNode( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, promoteToBindable: promoteToBindable);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10931, 2398, 2467);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_10931_2515_2526()
{
var return_v = Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10931, 2515, 2526);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.RegionAnalysisContext
f_10931_2489_2559(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.Symbol
member,Microsoft.CodeAnalysis.CSharp.BoundNode
boundNode,Microsoft.CodeAnalysis.CSharp.BoundNode
firstInRegion,Microsoft.CodeAnalysis.CSharp.BoundNode
lastInRegion)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.RegionAnalysisContext( compilation, member, boundNode, firstInRegion, lastInRegion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10931, 2489, 2559);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10931,1666,2571);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10931,1666,2571);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
