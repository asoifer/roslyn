// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitDoStatement(BoundDoStatement node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10493,509,3077);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10493,599,626);

f_10493_599_625(node != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10493,642,699);

var 
rewrittenCondition = f_10493_667_698(this, f_10493_683_697(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10493,713,759);

var 
rewrittenBody = f_10493_733_758(this, f_10493_748_757(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10493,773,808);

f_10493_773_807(rewrittenBody is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10493,822,873);

var 
startLabel = f_10493_839_872("start")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10493,889,914);

var 
syntax = node.Syntax
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10493,1138,1338) || true) && (f_10493_1142_1168_M(!node.WasCompilerGenerated)&&(DynAbs.Tracing.TraceSender.Expression_True(10493, 1142, 1187)&&f_10493_1172_1187(this)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10493,1138,1338);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10493,1221,1323);

rewrittenCondition = f_10493_1242_1322(_instrumenter, node, rewrittenCondition, _factory);
DynAbs.Tracing.TraceSender.TraceExitCondition(10493,1138,1338);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10493,1354,1463);

BoundStatement 
ifConditionGotoStart = f_10493_1392_1462(syntax, rewrittenCondition, true, startLabel)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10493,1479,1684) || true) && (f_10493_1483_1509_M(!node.WasCompilerGenerated)&&(DynAbs.Tracing.TraceSender.Expression_True(10493, 1483, 1528)&&f_10493_1513_1528(this)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10493,1479,1684);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10493,1562,1669);

ifConditionGotoStart = f_10493_1585_1668(_instrumenter, node, ifConditionGotoStart);
DynAbs.Tracing.TraceSender.TraceExitCondition(10493,1479,1684);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10493,2048,2472) || true) && (node.Locals.IsEmpty)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10493,2048,2472);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10493,2105,2457);

return f_10493_2112_2456(syntax, f_10493_2151_2165(node), f_10493_2188_2231(syntax, startLabel), rewrittenBody, f_10493_2290_2341(syntax, f_10493_2322_2340(node)), ifConditionGotoStart, f_10493_2407_2455(syntax, f_10493_2439_2454(node)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10493,2048,2472);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10493,2488,3066);

return f_10493_2495_3065(syntax, f_10493_2534_2548(node), f_10493_2567_2610(syntax, startLabel), f_10493_2629_2997(syntax, f_10493_2684_2695(node), f_10493_2729_2996(rewrittenBody, f_10493_2852_2903(syntax, f_10493_2884_2902(node)), ifConditionGotoStart)), f_10493_3016_3064(syntax, f_10493_3048_3063(node)));
DynAbs.Tracing.TraceSender.TraceExitMethod(10493,509,3077);

int
f_10493_599_625(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10493, 599, 625);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10493_683_697(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
this_param)
{
var return_v = this_param.Condition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10493, 683, 697);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10493_667_698(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10493, 667, 698);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10493_748_757(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10493, 748, 757);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10493_733_758(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
node)
{
var return_v = this_param.VisitStatement( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10493, 733, 758);
return return_v;
}


int
f_10493_773_807(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10493, 773, 807);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10493_839_872(string
name)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10493, 839, 872);
return return_v;
}


bool
f_10493_1142_1168_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10493, 1142, 1168);
return return_v;
}


bool
f_10493_1172_1187(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10493, 1172, 1187);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10493_1242_1322(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDoStatement
original,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
factory)
{
var return_v = this_param.InstrumentDoStatementCondition( original, rewrittenCondition, factory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10493, 1242, 1322);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
f_10493_1392_1462(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
condition,bool
jumpIfTrue,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto( syntax, condition, jumpIfTrue, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10493, 1392, 1462);
return return_v;
}


bool
f_10493_1483_1509_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10493, 1483, 1509);
return return_v;
}


bool
f_10493_1513_1528(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10493, 1513, 1528);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10493_1585_1668(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDoStatement
original,Microsoft.CodeAnalysis.CSharp.BoundStatement
ifConditionGotoStart)
{
var return_v = this_param.InstrumentDoStatementConditionalGotoStart( original, ifConditionGotoStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10493, 1585, 1668);
return return_v;
}


bool
f_10493_2151_2165(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
this_param)
{
var return_v = this_param.HasErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10493, 2151, 2165);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
f_10493_2188_2231(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10493, 2188, 2231);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10493_2322_2340(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
this_param)
{
var return_v = this_param.ContinueLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10493, 2322, 2340);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
f_10493_2290_2341(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10493, 2290, 2341);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10493_2439_2454(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
this_param)
{
var return_v = this_param.BreakLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10493, 2439, 2454);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
f_10493_2407_2455(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10493, 2407, 2455);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatementList
f_10493_2112_2456(Microsoft.CodeAnalysis.SyntaxNode
syntax,bool
hasErrors,params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
statements)
{
var return_v = BoundStatementList.Synthesized( syntax, hasErrors, statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10493, 2112, 2456);
return return_v;
}


bool
f_10493_2534_2548(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
this_param)
{
var return_v = this_param.HasErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10493, 2534, 2548);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
f_10493_2567_2610(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10493, 2567, 2610);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10493_2684_2695(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
this_param)
{
var return_v = this_param.Locals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10493, 2684, 2695);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10493_2884_2902(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
this_param)
{
var return_v = this_param.ContinueLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10493, 2884, 2902);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
f_10493_2852_2903(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10493, 2852, 2903);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10493_2729_2996(Microsoft.CodeAnalysis.CSharp.BoundStatement
item1,Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
item2,Microsoft.CodeAnalysis.CSharp.BoundStatement
item3)
{
var return_v = ImmutableArray.Create<BoundStatement>( item1, (Microsoft.CodeAnalysis.CSharp.BoundStatement)item2, item3);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10493, 2729, 2996);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10493_2629_2997(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock( syntax, locals, statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10493, 2629, 2997);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10493_3048_3063(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
this_param)
{
var return_v = this_param.BreakLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10493, 3048, 3063);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
f_10493_3016_3064(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10493, 3016, 3064);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatementList
f_10493_2495_3065(Microsoft.CodeAnalysis.SyntaxNode
syntax,bool
hasErrors,params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
statements)
{
var return_v = BoundStatementList.Synthesized( syntax, hasErrors, statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10493, 2495, 3065);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10493,509,3077);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10493,509,3077);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
