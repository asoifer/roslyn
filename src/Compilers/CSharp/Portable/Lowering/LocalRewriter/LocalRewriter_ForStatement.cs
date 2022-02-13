// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitForStatement(BoundForStatement node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10499,534,1627);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,626,653);

f_10499_626_652(node != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,669,729);

var 
rewrittenInitializer = f_10499_696_728(this, f_10499_711_727(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,743,800);

var 
rewrittenCondition = f_10499_768_799(this, f_10499_784_798(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,814,870);

var 
rewrittenIncrement = f_10499_839_869(this, f_10499_854_868(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,884,930);

var 
rewrittenBody = f_10499_904_929(this, f_10499_919_928(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,944,979);

f_10499_944_978(rewrittenBody is { });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,1203,1404) || true) && (rewrittenCondition != null &&(DynAbs.Tracing.TraceSender.Expression_True(10499, 1207, 1252)&&f_10499_1237_1252(this)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10499,1203,1404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,1286,1389);

rewrittenCondition = f_10499_1307_1388(_instrumenter, node, rewrittenCondition, _factory);
DynAbs.Tracing.TraceSender.TraceExitCondition(10499,1203,1404);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,1420,1616);

return f_10499_1427_1615(this, node, rewrittenInitializer, rewrittenCondition, rewrittenIncrement, rewrittenBody);
DynAbs.Tracing.TraceSender.TraceExitMethod(10499,534,1627);

int
f_10499_626_652(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 626, 652);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10499_711_727(Microsoft.CodeAnalysis.CSharp.BoundForStatement
this_param)
{
var return_v = this_param.Initializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 711, 727);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10499_696_728(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement?
node)
{
var return_v = this_param.VisitStatement( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 696, 728);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10499_784_798(Microsoft.CodeAnalysis.CSharp.BoundForStatement
this_param)
{
var return_v = this_param.Condition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 784, 798);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10499_768_799(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 768, 799);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10499_854_868(Microsoft.CodeAnalysis.CSharp.BoundForStatement
this_param)
{
var return_v = this_param.Increment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 854, 868);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10499_839_869(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement?
node)
{
var return_v = this_param.VisitStatement( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 839, 869);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10499_919_928(Microsoft.CodeAnalysis.CSharp.BoundForStatement
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 919, 928);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10499_904_929(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
node)
{
var return_v = this_param.VisitStatement( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 904, 929);
return return_v;
}


int
f_10499_944_978(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 944, 978);
return 0;
}


bool
f_10499_1237_1252(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 1237, 1252);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10499_1307_1388(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForStatement
original,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
factory)
{
var return_v = this_param.InstrumentForStatementCondition( original, rewrittenCondition, factory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 1307, 1388);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10499_1427_1615(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForStatement
node,Microsoft.CodeAnalysis.CSharp.BoundStatement?
rewrittenInitializer,Microsoft.CodeAnalysis.CSharp.BoundExpression?
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundStatement?
rewrittenIncrement,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenBody)
{
var return_v = this_param.RewriteForStatement( node, rewrittenInitializer, rewrittenCondition, rewrittenIncrement, rewrittenBody);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 1427, 1615);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10499,534,1627);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10499,534,1627);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement RewriteForStatementWithoutInnerLocals(
            BoundLoopStatement original,
            ImmutableArray<LocalSymbol> outerLocals,
            BoundStatement? rewrittenInitializer,
            BoundExpression? rewrittenCondition,
            BoundStatement? rewrittenIncrement,
            BoundStatement rewrittenBody,
            GeneratedLabelSymbol breakLabel,
            GeneratedLabelSymbol continueLabel,
            bool hasErrors)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10499,1639,6895);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,2138,2239);

f_10499_2138_2238(f_10499_2151_2164(original)== BoundKind.ForStatement ||(DynAbs.Tracing.TraceSender.Expression_False(10499, 2151, 2237)||f_10499_2194_2207(original)== BoundKind.ForEachStatement));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,2253,2289);

f_10499_2253_2288(rewrittenBody != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,3395,3431);

SyntaxNode 
syntax = original.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,3445,3511);

var 
statementBuilder = f_10499_3468_3510()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,3525,3649) || true) && (rewrittenInitializer != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10499,3525,3649);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,3591,3634);

f_10499_3591_3633(                statementBuilder, rewrittenInitializer);
DynAbs.Tracing.TraceSender.TraceExitCondition(10499,3525,3649);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,3665,3716);

var 
startLabel = f_10499_3682_3715("start")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,4201,4248);

var 
endLabel = f_10499_4216_4247("end")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,4323,4389);

BoundStatement 
gotoEnd = f_10499_4348_4388(syntax, endLabel)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,4405,4852) || true) && (f_10499_4409_4424(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10499,4405,4852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,4786,4837);

gotoEnd = f_10499_4796_4836(gotoEnd);
DynAbs.Tracing.TraceSender.TraceExitCondition(10499,4405,4852);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,4868,4898);

f_10499_4868_4897(
            statementBuilder, gotoEnd);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,4961,5027);

f_10499_4961_5026(
            // start:
            //   body;
            statementBuilder, f_10499_4982_5025(syntax, startLabel));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,5043,5079);

f_10499_5043_5078(
            statementBuilder, rewrittenBody);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,5150,5219);

f_10499_5150_5218(
            // continue:
            //   increment;
            statementBuilder, f_10499_5171_5217(syntax, continueLabel));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,5233,5353) || true) && (rewrittenIncrement != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10499,5233,5353);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,5297,5338);

f_10499_5297_5337(                statementBuilder, rewrittenIncrement);
DynAbs.Tracing.TraceSender.TraceExitCondition(10499,5233,5353);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,5436,5500);

f_10499_5436_5499(
            // end:
            //   GotoIfTrue condition start;
            statementBuilder, f_10499_5457_5498(syntax, endLabel));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,5514,5548);

BoundStatement? 
branchBack = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,5562,5866) || true) && (rewrittenCondition != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10499,5562,5866);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,5626,5729);

branchBack = f_10499_5639_5728(rewrittenCondition.Syntax, rewrittenCondition, true, startLabel);
DynAbs.Tracing.TraceSender.TraceExitCondition(10499,5562,5866);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10499,5562,5866);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,5795,5851);

branchBack = f_10499_5808_5850(syntax, startLabel);
DynAbs.Tracing.TraceSender.TraceExitCondition(10499,5562,5866);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,5882,6579) || true) && (f_10499_5886_5901(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10499,5882,6579);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,5935,6564);

switch (f_10499_5943_5956(original))
                {

case BoundKind.ForEachStatement:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10499,5935,6564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,6056,6175);

branchBack = f_10499_6069_6174(_instrumenter, original, branchBack);
DynAbs.Tracing.TraceSender.TraceBreak(10499,6201,6207);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10499,5935,6564);

case BoundKind.ForStatement:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10499,5935,6564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,6283,6401);

branchBack = f_10499_6296_6400(_instrumenter, original, branchBack);
DynAbs.Tracing.TraceSender.TraceBreak(10499,6427,6433);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10499,5935,6564);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10499,5935,6564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,6489,6545);

throw f_10499_6495_6544(f_10499_6530_6543(original));
DynAbs.Tracing.TraceSender.TraceExitCondition(10499,5935,6564);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(10499,5882,6579);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,6595,6628);

f_10499_6595_6627(
            statementBuilder, branchBack);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,6667,6733);

f_10499_6667_6732(
            // break:
            statementBuilder, f_10499_6688_6731(syntax, breakLabel));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,6749,6804);

var 
statements = f_10499_6766_6803(statementBuilder)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,6818,6884);

return f_10499_6825_6883(syntax, outerLocals, statements, hasErrors);
DynAbs.Tracing.TraceSender.TraceExitMethod(10499,1639,6895);

Microsoft.CodeAnalysis.CSharp.BoundKind
f_10499_2151_2164(Microsoft.CodeAnalysis.CSharp.BoundLoopStatement
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 2151, 2164);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10499_2194_2207(Microsoft.CodeAnalysis.CSharp.BoundLoopStatement
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 2194, 2207);
return return_v;
}


int
f_10499_2138_2238(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 2138, 2238);
return 0;
}


int
f_10499_2253_2288(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 2253, 2288);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10499_3468_3510()
{
var return_v = ArrayBuilder<BoundStatement>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 3468, 3510);
return return_v;
}


int
f_10499_3591_3633(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 3591, 3633);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10499_3682_3715(string
name)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 3682, 3715);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10499_4216_4247(string
name)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 4216, 4247);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
f_10499_4348_4388(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundGotoStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 4348, 4388);
return return_v;
}


bool
f_10499_4409_4424(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 4409, 4424);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10499_4796_4836(Microsoft.CodeAnalysis.CSharp.BoundStatement
statementOpt)
{
var return_v = BoundSequencePoint.CreateHidden( statementOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 4796, 4836);
return return_v;
}


int
f_10499_4868_4897(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 4868, 4897);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
f_10499_4982_5025(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 4982, 5025);
return return_v;
}


int
f_10499_4961_5026(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 4961, 5026);
return 0;
}


int
f_10499_5043_5078(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 5043, 5078);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
f_10499_5171_5217(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 5171, 5217);
return return_v;
}


int
f_10499_5150_5218(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 5150, 5218);
return 0;
}


int
f_10499_5297_5337(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 5297, 5337);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
f_10499_5457_5498(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 5457, 5498);
return return_v;
}


int
f_10499_5436_5499(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 5436, 5499);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
f_10499_5639_5728(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
condition,bool
jumpIfTrue,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto( syntax, condition, jumpIfTrue, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 5639, 5728);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
f_10499_5808_5850(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundGotoStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 5808, 5850);
return return_v;
}


bool
f_10499_5886_5901(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 5886, 5901);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10499_5943_5956(Microsoft.CodeAnalysis.CSharp.BoundLoopStatement
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 5943, 5956);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10499_6069_6174(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLoopStatement
original,Microsoft.CodeAnalysis.CSharp.BoundStatement
branchBack)
{
var return_v = this_param.InstrumentForEachStatementConditionalGotoStart( (Microsoft.CodeAnalysis.CSharp.BoundForEachStatement)original, branchBack);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 6069, 6174);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10499_6296_6400(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLoopStatement
original,Microsoft.CodeAnalysis.CSharp.BoundStatement
branchBack)
{
var return_v = this_param.InstrumentForStatementConditionalGotoStartOrBreak( (Microsoft.CodeAnalysis.CSharp.BoundForStatement)original, branchBack);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 6296, 6400);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10499_6530_6543(Microsoft.CodeAnalysis.CSharp.BoundLoopStatement
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 6530, 6543);
return return_v;
}


System.Exception
f_10499_6495_6544(Microsoft.CodeAnalysis.CSharp.BoundKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 6495, 6544);
return return_v;
}


int
f_10499_6595_6627(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 6595, 6627);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
f_10499_6688_6731(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 6688, 6731);
return return_v;
}


int
f_10499_6667_6732(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 6667, 6732);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10499_6766_6803(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 6766, 6803);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10499_6825_6883(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements,bool
hasErrors)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock( syntax, locals, statements, hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 6825, 6883);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10499,1639,6895);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10499,1639,6895);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement RewriteForStatement(
            BoundForStatement node,
            BoundStatement? rewrittenInitializer,
            BoundExpression? rewrittenCondition,
            BoundStatement? rewrittenIncrement,
            BoundStatement rewrittenBody)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10499,6907,10564);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,7205,7650) || true) && (node.InnerLocals.IsEmpty)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10499,7205,7650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,7267,7635);

return f_10499_7274_7634(this, node, f_10499_7361_7377(node), rewrittenInitializer, rewrittenCondition, rewrittenIncrement, rewrittenBody, f_10499_7561_7576(node), f_10499_7599_7617(node), f_10499_7619_7633(node));
DynAbs.Tracing.TraceSender.TraceExitCondition(10499,7205,7650);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,8351,8387);

f_10499_8351_8386(rewrittenBody != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,8403,8435);

SyntaxNode 
syntax = node.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,8449,8515);

var 
statementBuilder = f_10499_8472_8514()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,8561,8685) || true) && (rewrittenInitializer != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10499,8561,8685);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,8627,8670);

f_10499_8627_8669(                statementBuilder, rewrittenInitializer);
DynAbs.Tracing.TraceSender.TraceExitCondition(10499,8561,8685);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,8701,8752);

var 
startLabel = f_10499_8718_8751("start")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,8791,8872);

BoundStatement 
startLabelStatement = f_10499_8828_8871(syntax, startLabel)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,8888,9026) || true) && (f_10499_8892_8902())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10499,8888,9026);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,8936,9011);

startLabelStatement = f_10499_8958_9010(startLabelStatement);
DynAbs.Tracing.TraceSender.TraceExitCondition(10499,8888,9026);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,9042,9084);

f_10499_9042_9083(
            statementBuilder, startLabelStatement);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,9100,9162);

var 
blockBuilder = f_10499_9119_9161()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,9223,9722) || true) && (rewrittenCondition != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10499,9223,9722);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,9287,9424);

BoundStatement 
ifNotConditionGotoBreak = f_10499_9328_9423(rewrittenCondition.Syntax, rewrittenCondition, false, f_10499_9407_9422(node))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,9444,9645) || true) && (f_10499_9448_9463(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10499,9444,9645);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,9505,9626);

ifNotConditionGotoBreak = f_10499_9531_9625(_instrumenter, node, ifNotConditionGotoBreak);
DynAbs.Tracing.TraceSender.TraceExitCondition(10499,9444,9645);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,9665,9707);

f_10499_9665_9706(
                blockBuilder, ifNotConditionGotoBreak);
DynAbs.Tracing.TraceSender.TraceExitCondition(10499,9223,9722);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,9760,9792);

f_10499_9760_9791(
            // body;
            blockBuilder, rewrittenBody);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,9863,9933);

f_10499_9863_9932(
            // continue:
            //   increment;
            blockBuilder, f_10499_9880_9931(syntax, f_10499_9912_9930(node)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,9947,10063) || true) && (rewrittenIncrement != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10499,9947,10063);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,10011,10048);

f_10499_10011_10047(                blockBuilder, rewrittenIncrement);
DynAbs.Tracing.TraceSender.TraceExitCondition(10499,9947,10063);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,10107,10168);

f_10499_10107_10167(
            // goto start;
            blockBuilder, f_10499_10124_10166(syntax, startLabel));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,10184,10282);

f_10499_10184_10281(
            statementBuilder, f_10499_10205_10280(syntax, f_10499_10228_10244(node), f_10499_10246_10279(blockBuilder)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,10321,10392);

f_10499_10321_10391(
            // break:
            statementBuilder, f_10499_10342_10390(syntax, f_10499_10374_10389(node)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,10408,10463);

var 
statements = f_10499_10425_10462(statementBuilder)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10499,10477,10553);

return f_10499_10484_10552(syntax, f_10499_10507_10523(node), statements, f_10499_10537_10551(node));
DynAbs.Tracing.TraceSender.TraceExitMethod(10499,6907,10564);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10499_7361_7377(Microsoft.CodeAnalysis.CSharp.BoundForStatement
this_param)
{
var return_v = this_param.OuterLocals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 7361, 7377);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10499_7561_7576(Microsoft.CodeAnalysis.CSharp.BoundForStatement
this_param)
{
var return_v = this_param.BreakLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 7561, 7576);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10499_7599_7617(Microsoft.CodeAnalysis.CSharp.BoundForStatement
this_param)
{
var return_v = this_param.ContinueLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 7599, 7617);
return return_v;
}


bool
f_10499_7619_7633(Microsoft.CodeAnalysis.CSharp.BoundForStatement
this_param)
{
var return_v = this_param.HasErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 7619, 7633);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10499_7274_7634(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForStatement
original,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
outerLocals,Microsoft.CodeAnalysis.CSharp.BoundStatement?
rewrittenInitializer,Microsoft.CodeAnalysis.CSharp.BoundExpression?
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundStatement?
rewrittenIncrement,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenBody,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
breakLabel,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
continueLabel,bool
hasErrors)
{
var return_v = this_param.RewriteForStatementWithoutInnerLocals( (Microsoft.CodeAnalysis.CSharp.BoundLoopStatement)original, outerLocals, rewrittenInitializer, rewrittenCondition, rewrittenIncrement, rewrittenBody, breakLabel, continueLabel, hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 7274, 7634);
return return_v;
}


int
f_10499_8351_8386(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 8351, 8386);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10499_8472_8514()
{
var return_v = ArrayBuilder<BoundStatement>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 8472, 8514);
return return_v;
}


int
f_10499_8627_8669(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 8627, 8669);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10499_8718_8751(string
name)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 8718, 8751);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
f_10499_8828_8871(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 8828, 8871);
return return_v;
}


bool
f_10499_8892_8902()
{
var return_v = Instrument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 8892, 8902);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10499_8958_9010(Microsoft.CodeAnalysis.CSharp.BoundStatement
statementOpt)
{
var return_v = BoundSequencePoint.CreateHidden( statementOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 8958, 9010);
return return_v;
}


int
f_10499_9042_9083(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 9042, 9083);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10499_9119_9161()
{
var return_v = ArrayBuilder<BoundStatement>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 9119, 9161);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10499_9407_9422(Microsoft.CodeAnalysis.CSharp.BoundForStatement
this_param)
{
var return_v = this_param.BreakLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 9407, 9422);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
f_10499_9328_9423(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
condition,bool
jumpIfTrue,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto( syntax, condition, jumpIfTrue, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 9328, 9423);
return return_v;
}


bool
f_10499_9448_9463(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 9448, 9463);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10499_9531_9625(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForStatement
original,Microsoft.CodeAnalysis.CSharp.BoundStatement
branchBack)
{
var return_v = this_param.InstrumentForStatementConditionalGotoStartOrBreak( original, branchBack);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 9531, 9625);
return return_v;
}


int
f_10499_9665_9706(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 9665, 9706);
return 0;
}


int
f_10499_9760_9791(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 9760, 9791);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10499_9912_9930(Microsoft.CodeAnalysis.CSharp.BoundForStatement
this_param)
{
var return_v = this_param.ContinueLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 9912, 9930);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
f_10499_9880_9931(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 9880, 9931);
return return_v;
}


int
f_10499_9863_9932(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 9863, 9932);
return 0;
}


int
f_10499_10011_10047(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 10011, 10047);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
f_10499_10124_10166(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundGotoStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 10124, 10166);
return return_v;
}


int
f_10499_10107_10167(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 10107, 10167);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10499_10228_10244(Microsoft.CodeAnalysis.CSharp.BoundForStatement
this_param)
{
var return_v = this_param.InnerLocals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 10228, 10244);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10499_10246_10279(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 10246, 10279);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10499_10205_10280(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock( syntax, locals, statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 10205, 10280);
return return_v;
}


int
f_10499_10184_10281(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundBlock
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 10184, 10281);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10499_10374_10389(Microsoft.CodeAnalysis.CSharp.BoundForStatement
this_param)
{
var return_v = this_param.BreakLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 10374, 10389);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
f_10499_10342_10390(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 10342, 10390);
return return_v;
}


int
f_10499_10321_10391(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 10321, 10391);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10499_10425_10462(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 10425, 10462);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10499_10507_10523(Microsoft.CodeAnalysis.CSharp.BoundForStatement
this_param)
{
var return_v = this_param.OuterLocals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 10507, 10523);
return return_v;
}


bool
f_10499_10537_10551(Microsoft.CodeAnalysis.CSharp.BoundForStatement
this_param)
{
var return_v = this_param.HasErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10499, 10537, 10551);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10499_10484_10552(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements,bool
hasErrors)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock( syntax, locals, statements, hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10499, 10484, 10552);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10499,6907,10564);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10499,6907,10564);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
