// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitIfStatement(BoundIfStatement node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10503,554,1843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,644,671);

f_10503_644_670(node != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,685,742);

var 
rewrittenCondition = f_10503_710_741(this, f_10503_726_740(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,756,816);

var 
rewrittenConsequence = f_10503_783_815(this, f_10503_798_814(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,830,872);

f_10503_830_871(rewrittenConsequence is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,886,949);

var 
rewrittenAlternative = f_10503_913_948(this, f_10503_928_947(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,963,1007);

var 
syntax = (IfStatementSyntax)node.Syntax
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,1231,1431) || true) && (f_10503_1235_1250(this)&&(DynAbs.Tracing.TraceSender.Expression_True(10503, 1235, 1280)&&f_10503_1254_1280_M(!node.WasCompilerGenerated)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10503,1231,1431);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,1314,1416);

rewrittenCondition = f_10503_1335_1415(_instrumenter, node, rewrittenCondition, _factory);
DynAbs.Tracing.TraceSender.TraceExitCondition(10503,1231,1431);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,1447,1567);

var 
result = f_10503_1460_1566(syntax, rewrittenCondition, rewrittenConsequence, rewrittenAlternative, f_10503_1551_1565(node))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,1645,1802) || true) && (f_10503_1649_1664(this)&&(DynAbs.Tracing.TraceSender.Expression_True(10503, 1649, 1694)&&f_10503_1668_1694_M(!node.WasCompilerGenerated)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10503,1645,1802);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,1728,1787);

result = f_10503_1737_1786(_instrumenter, node, result);
DynAbs.Tracing.TraceSender.TraceExitCondition(10503,1645,1802);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,1818,1832);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10503,554,1843);

int
f_10503_644_670(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 644, 670);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10503_726_740(Microsoft.CodeAnalysis.CSharp.BoundIfStatement
this_param)
{
var return_v = this_param.Condition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10503, 726, 740);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10503_710_741(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 710, 741);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10503_798_814(Microsoft.CodeAnalysis.CSharp.BoundIfStatement
this_param)
{
var return_v = this_param.Consequence;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10503, 798, 814);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10503_783_815(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
node)
{
var return_v = this_param.VisitStatement( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 783, 815);
return return_v;
}


int
f_10503_830_871(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 830, 871);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10503_928_947(Microsoft.CodeAnalysis.CSharp.BoundIfStatement
this_param)
{
var return_v = this_param.AlternativeOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10503, 928, 947);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10503_913_948(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement?
node)
{
var return_v = this_param.VisitStatement( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 913, 948);
return return_v;
}


bool
f_10503_1235_1250(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10503, 1235, 1250);
return return_v;
}


bool
f_10503_1254_1280_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10503, 1254, 1280);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10503_1335_1415(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundIfStatement
original,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
factory)
{
var return_v = this_param.InstrumentIfStatementCondition( original, rewrittenCondition, factory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 1335, 1415);
return return_v;
}


bool
f_10503_1551_1565(Microsoft.CodeAnalysis.CSharp.BoundIfStatement
this_param)
{
var return_v = this_param.HasErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10503, 1551, 1565);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10503_1460_1566(Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenConsequence,Microsoft.CodeAnalysis.CSharp.BoundStatement?
rewrittenAlternativeOpt,bool
hasErrors)
{
var return_v = RewriteIfStatement( (Microsoft.CodeAnalysis.SyntaxNode)syntax, rewrittenCondition, rewrittenConsequence, rewrittenAlternativeOpt, hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 1460, 1566);
return return_v;
}


bool
f_10503_1649_1664(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10503, 1649, 1664);
return return_v;
}


bool
f_10503_1668_1694_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10503, 1668, 1694);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10503_1737_1786(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundIfStatement
original,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewritten)
{
var return_v = this_param.InstrumentIfStatement( original, rewritten);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 1737, 1786);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10503,554,1843);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10503,554,1843);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static BoundStatement RewriteIfStatement(
            SyntaxNode syntax,
            BoundExpression rewrittenCondition,
            BoundStatement rewrittenConsequence,
            BoundStatement? rewrittenAlternativeOpt,
            bool hasErrors)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10503,1855,4248);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,2143,2193);

var 
afterif = f_10503_2157_2192("afterif")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,2207,2264);

var 
builder = f_10503_2221_2263()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,2280,4235) || true) && (rewrittenAlternativeOpt == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10503,2280,4235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,2605,2706);

f_10503_2605_2705(                // if (condition) 
                //   consequence;  
                //
                // becomes
                //
                // GotoIfFalse condition afterif;
                // consequence;
                // afterif:

                builder, f_10503_2617_2704(rewrittenCondition.Syntax, rewrittenCondition, false, afterif));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,2724,2758);

f_10503_2724_2757(                builder, rewrittenConsequence);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,2776,2823);

f_10503_2776_2822(                builder, f_10503_2788_2821());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,2841,2895);

f_10503_2841_2894(                builder, f_10503_2853_2893(syntax, afterif));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,2913,2959);

var 
statements = f_10503_2930_2958(builder)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,2977,3038);

return f_10503_2984_3037(syntax, statements, hasErrors);
DynAbs.Tracing.TraceSender.TraceExitCondition(10503,2280,4235);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10503,2280,4235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,3508,3558);

var 
alt = f_10503_3518_3557("alternative")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,3578,3675);

f_10503_3578_3674(
                builder, f_10503_3590_3673(rewrittenCondition.Syntax, rewrittenCondition, false, alt));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,3693,3727);

f_10503_3693_3726(                builder, rewrittenConsequence);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,3745,3792);

f_10503_3745_3791(                builder, f_10503_3757_3790());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,3810,3863);

f_10503_3810_3862(                builder, f_10503_3822_3861(syntax, afterif));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,3881,3931);

f_10503_3881_3930(                builder, f_10503_3893_3929(syntax, alt));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,3949,3986);

f_10503_3949_3985(                builder, rewrittenAlternativeOpt);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,4004,4051);

f_10503_4004_4050(                builder, f_10503_4016_4049());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,4069,4123);

f_10503_4069_4122(                builder, f_10503_4081_4121(syntax, afterif));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10503,4141,4220);

return f_10503_4148_4219(syntax, f_10503_4179_4207(builder), hasErrors);
DynAbs.Tracing.TraceSender.TraceExitCondition(10503,2280,4235);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10503,1855,4248);

Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10503_2157_2192(string
name)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 2157, 2192);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10503_2221_2263()
{
var return_v = ArrayBuilder<BoundStatement>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 2221, 2263);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
f_10503_2617_2704(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
condition,bool
jumpIfTrue,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto( syntax, condition, jumpIfTrue, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 2617, 2704);
return return_v;
}


int
f_10503_2605_2705(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 2605, 2705);
return 0;
}


int
f_10503_2724_2757(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 2724, 2757);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10503_2788_2821()
{
var return_v = BoundSequencePoint.CreateHidden();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 2788, 2821);
return return_v;
}


int
f_10503_2776_2822(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 2776, 2822);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
f_10503_2853_2893(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 2853, 2893);
return return_v;
}


int
f_10503_2841_2894(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 2841, 2894);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10503_2930_2958(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 2930, 2958);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatementList
f_10503_2984_3037(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements,bool
hasErrors)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundStatementList( syntax, statements, hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 2984, 3037);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10503_3518_3557(string
name)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 3518, 3557);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
f_10503_3590_3673(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
condition,bool
jumpIfTrue,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto( syntax, condition, jumpIfTrue, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 3590, 3673);
return return_v;
}


int
f_10503_3578_3674(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 3578, 3674);
return 0;
}


int
f_10503_3693_3726(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 3693, 3726);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10503_3757_3790()
{
var return_v = BoundSequencePoint.CreateHidden();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 3757, 3790);
return return_v;
}


int
f_10503_3745_3791(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 3745, 3791);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
f_10503_3822_3861(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundGotoStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 3822, 3861);
return return_v;
}


int
f_10503_3810_3862(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 3810, 3862);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
f_10503_3893_3929(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 3893, 3929);
return return_v;
}


int
f_10503_3881_3930(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 3881, 3930);
return 0;
}


int
f_10503_3949_3985(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 3949, 3985);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10503_4016_4049()
{
var return_v = BoundSequencePoint.CreateHidden();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 4016, 4049);
return return_v;
}


int
f_10503_4004_4050(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 4004, 4050);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
f_10503_4081_4121(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 4081, 4121);
return return_v;
}


int
f_10503_4069_4122(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 4069, 4122);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10503_4179_4207(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 4179, 4207);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatementList
f_10503_4148_4219(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements,bool
hasErrors)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundStatementList( syntax, statements, hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10503, 4148, 4219);
return return_v;
}


        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10503,1855,4248);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10503,1855,4248);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
