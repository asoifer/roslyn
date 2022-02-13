// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitLockStatement(BoundLockStatement node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10511,712,8802);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,806,872);

LockStatementSyntax 
lockSyntax = (LockStatementSyntax)node.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,888,955);

BoundExpression 
rewrittenArgument = f_10511_924_954(this, f_10511_940_953(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,969,1027);

BoundStatement? 
rewrittenBody = f_10511_1001_1026(this, f_10511_1016_1025(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,1041,1076);

f_10511_1041_1075(rewrittenBody is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,1092,1142);

TypeSymbol? 
argumentType = f_10511_1119_1141(rewrittenArgument)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,1156,1760) || true) && (argumentType is null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10511,1156,1760);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,1337,1405);

f_10511_1337_1404(f_10511_1350_1381(rewrittenArgument)== f_10511_1385_1403());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,1423,1493);

argumentType = f_10511_1438_1492(_compilation, SpecialType.System_Object);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,1511,1680);

rewrittenArgument = f_10511_1531_1679(this, rewrittenArgument.Syntax, f_10511_1612_1643(rewrittenArgument), argumentType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10511,1156,1760);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,1776,2462) || true) && (f_10511_1780_1797(argumentType)== SymbolKind.TypeParameter)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10511,1776,2462);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,2045,2115);

argumentType = f_10511_2060_2114(_compilation, SpecialType.System_Object);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,2135,2447);

rewrittenArgument = f_10511_2155_2446(this, rewrittenArgument.Syntax, rewrittenArgument, Conversion.Boxing, argumentType, @checked: false, constantValueOpt: f_10511_2414_2445(rewrittenArgument));
DynAbs.Tracing.TraceSender.TraceExitCondition(10511,1776,2462);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,2478,2523);

BoundAssignmentOperator 
assignmentToLockTemp
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,2537,2686);

BoundLocal 
boundLockTemp = f_10511_2564_2685(_factory, rewrittenArgument, out assignmentToLockTemp, syntaxOpt: lockSyntax, kind: SynthesizedLocalKind.Lock)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,2702,2800);

BoundStatement 
boundLockTempInit = f_10511_2737_2799(lockSyntax, assignmentToLockTemp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,2814,2843);

BoundExpression 
exitCallExpr
=default(BoundExpression);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,2859,2883);

MethodSymbol 
exitMethod
=default(MethodSymbol);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,2897,3499) || true) && (f_10511_2901_3002(this, lockSyntax, WellKnownMember.System_Threading_Monitor__Exit, out exitMethod))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10511,2897,3499);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,3036,3216);

exitCallExpr = f_10511_3051_3215(lockSyntax, receiverOpt: null, exitMethod, boundLockTemp);
DynAbs.Tracing.TraceSender.TraceExitCondition(10511,2897,3499);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10511,2897,3499);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,3282,3484);

exitCallExpr = f_10511_3297_3483(lockSyntax, LookupResultKind.NotInvocable, ImmutableArray<Symbol?>.Empty, f_10511_3394_3447(boundLockTemp), ErrorTypeSymbol.UnknownResultType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10511,2897,3499);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,3515,3596);

BoundStatement 
exitCall = f_10511_3541_3595(lockSyntax, exitCallExpr)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,3612,3637);

MethodSymbol 
enterMethod
=default(MethodSymbol);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,3653,8791) || true) && ((f_10511_3658_3780(this, lockSyntax, WellKnownMember.System_Threading_Monitor__Enter2, out enterMethod, isOptional: true)||(DynAbs.Tracing.TraceSender.Expression_False(10511, 3658, 3905)||f_10511_3802_3905(this, lockSyntax, WellKnownMember.System_Threading_Monitor__Enter, out enterMethod))) &&(DynAbs.Tracing.TraceSender.Expression_True(10511, 3657, 4041)&&f_10511_4010_4036(enterMethod)== 2))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10511,3653,8791);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,4676,4754);

TypeSymbol 
boolType = f_10511_4698_4753(_compilation, SpecialType.System_Boolean)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,4772,4822);

BoundAssignmentOperator 
assignmentToLockTakenTemp
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,4842,5149);

BoundLocal 
boundLockTakenTemp = f_10511_4874_5148(_factory, f_10511_4917_4985(this, rewrittenArgument.Syntax, f_10511_4955_4974(), boolType), store: out assignmentToLockTakenTemp, syntaxOpt: lockSyntax, kind: SynthesizedLocalKind.LockTaken)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,5169,5277);

BoundStatement 
boundLockTakenTempInit = f_10511_5209_5276(lockSyntax, assignmentToLockTakenTemp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,5297,5636);

BoundStatement 
enterCall = f_10511_5324_5635(lockSyntax, f_10511_5408_5634(lockSyntax, receiverOpt: null, enterMethod, boundLockTemp, boundLockTakenTemp))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,5656,5856);

exitCall = f_10511_5667_5855(lockSyntax, boundLockTakenTemp, exitCall, null, f_10511_5840_5854(node));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,5876,6687);

return f_10511_5883_6686(lockSyntax, f_10511_5953_6033(f_10511_5975_6000(boundLockTemp), f_10511_6002_6032(boundLockTakenTemp)), f_10511_6056_6685(f_10511_6104_6156(this, node, boundLockTempInit), boundLockTakenTempInit, f_10511_6232_6684(lockSyntax, f_10511_6325_6499(lockSyntax, f_10511_6368_6498(enterCall, rewrittenBody)), ImmutableArray<BoundCatchBlock>.Empty, f_10511_6598_6683(lockSyntax, exitCall))));
DynAbs.Tracing.TraceSender.TraceExitCondition(10511,3653,8791);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10511,3653,8791);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,7299,7329);

BoundExpression 
enterCallExpr
=default(BoundExpression);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,7349,7994) || true) && ((object)enterMethod != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10511,7349,7994);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,7422,7468);

f_10511_7422_7467(f_10511_7435_7461(enterMethod)== 1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,7492,7690);

enterCallExpr = f_10511_7508_7689(lockSyntax, receiverOpt: null, enterMethod, boundLockTemp);
DynAbs.Tracing.TraceSender.TraceExitCondition(10511,7349,7994);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10511,7349,7994);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,7772,7975);

enterCallExpr = f_10511_7788_7974(lockSyntax, LookupResultKind.NotInvocable, ImmutableArray<Symbol?>.Empty, f_10511_7885_7938(boundLockTemp), ErrorTypeSymbol.UnknownResultType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10511,7349,7994);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,8014,8140);

BoundStatement 
enterCall = f_10511_8041_8139(lockSyntax, enterCallExpr)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,8160,8776);

return f_10511_8167_8775(lockSyntax, f_10511_8237_8285(f_10511_8259_8284(boundLockTemp)), f_10511_8308_8774(f_10511_8356_8408(this, node, boundLockTempInit), enterCall, f_10511_8471_8773(lockSyntax, f_10511_8564_8621(lockSyntax, rewrittenBody), ImmutableArray<BoundCatchBlock>.Empty, f_10511_8720_8772(lockSyntax, exitCall))));
DynAbs.Tracing.TraceSender.TraceExitCondition(10511,3653,8791);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10511,712,8802);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10511_940_953(Microsoft.CodeAnalysis.CSharp.BoundLockStatement
this_param)
{
var return_v = this_param.Argument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10511, 940, 953);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10511_924_954(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 924, 954);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10511_1016_1025(Microsoft.CodeAnalysis.CSharp.BoundLockStatement
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10511, 1016, 1025);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10511_1001_1026(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
node)
{
var return_v = this_param.VisitStatement( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 1001, 1026);
return return_v;
}


int
f_10511_1041_1075(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 1041, 1075);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10511_1119_1141(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10511, 1119, 1141);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10511_1350_1381(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10511, 1350, 1381);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10511_1385_1403()
{
var return_v = ConstantValue.Null;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10511, 1385, 1403);
return return_v;
}


int
f_10511_1337_1404(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 1337, 1404);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10511_1438_1492(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 1438, 1492);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10511_1612_1643(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10511, 1612, 1643);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10511_1531_1679(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeLiteral( syntax, constantValue, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 1531, 1679);
return return_v;
}


Microsoft.CodeAnalysis.SymbolKind
f_10511_1780_1797(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10511, 1780, 1797);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10511_2060_2114(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 2060, 2114);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10511_2414_2445(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10511, 2414, 2445);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10511_2155_2446(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt)
{
var return_v = this_param.MakeConversionNode( syntax, rewrittenOperand, conversion, rewrittenType, @checked: @checked, constantValueOpt: constantValueOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 2155, 2446);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10511_2564_2685(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store,Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntaxOpt,Microsoft.CodeAnalysis.SynthesizedLocalKind
kind)
{
var return_v = this_param.StoreToTemp( argument, out store, syntaxOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxOpt, kind: kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 2564, 2685);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10511_2737_2799(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
expression)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement( (Microsoft.CodeAnalysis.SyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 2737, 2799);
return return_v;
}


bool
f_10511_2901_3002(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntax,Microsoft.CodeAnalysis.WellKnownMember
member,out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
symbol)
{
var return_v = this_param.TryGetWellKnownTypeMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( (Microsoft.CodeAnalysis.SyntaxNode)syntax, member, out symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 2901, 3002);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10511_3051_3215(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundLocal
arg0)
{
var return_v = BoundCall.Synthesized( (Microsoft.CodeAnalysis.SyntaxNode)syntax, receiverOpt: receiverOpt, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 3051, 3215);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10511_3394_3447(Microsoft.CodeAnalysis.CSharp.BoundLocal
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 3394, 3447);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBadExpression
f_10511_3297_3483(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
symbols,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
childBoundNodes,Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression( (Microsoft.CodeAnalysis.SyntaxNode)syntax, resultKind, symbols, childBoundNodes, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 3297, 3483);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10511_3541_3595(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement( (Microsoft.CodeAnalysis.SyntaxNode)syntax, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 3541, 3595);
return return_v;
}


bool
f_10511_3658_3780(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntax,Microsoft.CodeAnalysis.WellKnownMember
member,out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
symbol,bool
isOptional)
{
var return_v = this_param.TryGetWellKnownTypeMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( (Microsoft.CodeAnalysis.SyntaxNode)syntax, member, out symbol, isOptional: isOptional);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 3658, 3780);
return return_v;
}


bool
f_10511_3802_3905(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntax,Microsoft.CodeAnalysis.WellKnownMember
member,out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
symbol)
{
var return_v = this_param.TryGetWellKnownTypeMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( (Microsoft.CodeAnalysis.SyntaxNode)syntax, member, out symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 3802, 3905);
return return_v;
}


int
f_10511_4010_4036(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ParameterCount ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10511, 4010, 4036);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10511_4698_4753(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 4698, 4753);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10511_4955_4974()
{
var return_v = ConstantValue.False;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10511, 4955, 4974);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10511_4917_4985(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeLiteral( syntax, constantValue, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 4917, 4985);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10511_4874_5148(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store,Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntaxOpt,Microsoft.CodeAnalysis.SynthesizedLocalKind
kind)
{
var return_v = this_param.StoreToTemp( argument, out store, syntaxOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxOpt, kind: kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 4874, 5148);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10511_5209_5276(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
expression)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement( (Microsoft.CodeAnalysis.SyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 5209, 5276);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10511_5408_5634(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundLocal
arg0,Microsoft.CodeAnalysis.CSharp.BoundLocal
arg1)
{
var return_v = BoundCall.Synthesized( (Microsoft.CodeAnalysis.SyntaxNode)syntax, receiverOpt: receiverOpt, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 5408, 5634);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10511_5324_5635(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundCall
expression)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement( (Microsoft.CodeAnalysis.SyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 5324, 5635);
return return_v;
}


bool
f_10511_5840_5854(Microsoft.CodeAnalysis.CSharp.BoundLockStatement
this_param)
{
var return_v = this_param.HasErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10511, 5840, 5854);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10511_5667_5855(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenConsequence,Microsoft.CodeAnalysis.CSharp.BoundStatement?
rewrittenAlternativeOpt,bool
hasErrors)
{
var return_v = RewriteIfStatement( (Microsoft.CodeAnalysis.SyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenCondition, rewrittenConsequence, rewrittenAlternativeOpt, hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 5667, 5855);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10511_5975_6000(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10511, 5975, 6000);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10511_6002_6032(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10511, 6002, 6032);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10511_5953_6033(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item1,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item2)
{
var return_v = ImmutableArray.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 5953, 6033);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10511_6104_6156(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLockStatement
original,Microsoft.CodeAnalysis.CSharp.BoundStatement
lockTargetCapture)
{
var return_v = this_param.InstrumentLockTargetCapture( original, lockTargetCapture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 6104, 6156);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10511_6368_6498(Microsoft.CodeAnalysis.CSharp.BoundStatement
item1,Microsoft.CodeAnalysis.CSharp.BoundStatement
item2)
{
var return_v = ImmutableArray.Create<BoundStatement>( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 6368, 6498);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10511_6325_6499(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = BoundBlock.SynthesizedNoLocals( (Microsoft.CodeAnalysis.SyntaxNode)syntax, statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 6325, 6499);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10511_6598_6683(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundStatement
statement)
{
var return_v = BoundBlock.SynthesizedNoLocals( (Microsoft.CodeAnalysis.SyntaxNode)syntax, statement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 6598, 6683);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundTryStatement
f_10511_6232_6684(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundBlock
tryBlock,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
catchBlocks,Microsoft.CodeAnalysis.CSharp.BoundBlock
finallyBlockOpt)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTryStatement( (Microsoft.CodeAnalysis.SyntaxNode)syntax, tryBlock, catchBlocks, finallyBlockOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 6232, 6684);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10511_6056_6685(Microsoft.CodeAnalysis.CSharp.BoundStatement
item1,Microsoft.CodeAnalysis.CSharp.BoundStatement
item2,Microsoft.CodeAnalysis.CSharp.BoundTryStatement
item3)
{
var return_v = ImmutableArray.Create( item1, item2, (Microsoft.CodeAnalysis.CSharp.BoundStatement)item3);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 6056, 6685);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10511_5883_6686(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock( (Microsoft.CodeAnalysis.SyntaxNode)syntax, locals, statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 5883, 6686);
return return_v;
}


int
f_10511_7435_7461(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ParameterCount ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10511, 7435, 7461);
return return_v;
}


int
f_10511_7422_7467(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 7422, 7467);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10511_7508_7689(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundLocal
arg0)
{
var return_v = BoundCall.Synthesized( (Microsoft.CodeAnalysis.SyntaxNode)syntax, receiverOpt: receiverOpt, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 7508, 7689);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10511_7885_7938(Microsoft.CodeAnalysis.CSharp.BoundLocal
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 7885, 7938);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBadExpression
f_10511_7788_7974(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
symbols,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
childBoundNodes,Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression( (Microsoft.CodeAnalysis.SyntaxNode)syntax, resultKind, symbols, childBoundNodes, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 7788, 7974);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10511_8041_8139(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement( (Microsoft.CodeAnalysis.SyntaxNode)syntax, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 8041, 8139);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10511_8259_8284(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10511, 8259, 8284);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10511_8237_8285(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 8237, 8285);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10511_8356_8408(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLockStatement
original,Microsoft.CodeAnalysis.CSharp.BoundStatement
lockTargetCapture)
{
var return_v = this_param.InstrumentLockTargetCapture( original, lockTargetCapture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 8356, 8408);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10511_8564_8621(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundStatement
statement)
{
var return_v = BoundBlock.SynthesizedNoLocals( (Microsoft.CodeAnalysis.SyntaxNode)syntax, statement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 8564, 8621);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10511_8720_8772(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundStatement
statement)
{
var return_v = BoundBlock.SynthesizedNoLocals( (Microsoft.CodeAnalysis.SyntaxNode)syntax, statement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 8720, 8772);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundTryStatement
f_10511_8471_8773(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundBlock
tryBlock,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
catchBlocks,Microsoft.CodeAnalysis.CSharp.BoundBlock
finallyBlockOpt)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTryStatement( (Microsoft.CodeAnalysis.SyntaxNode)syntax, tryBlock, catchBlocks, finallyBlockOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 8471, 8773);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10511_8308_8774(Microsoft.CodeAnalysis.CSharp.BoundStatement
item1,Microsoft.CodeAnalysis.CSharp.BoundStatement
item2,Microsoft.CodeAnalysis.CSharp.BoundTryStatement
item3)
{
var return_v = ImmutableArray.Create( item1, item2, (Microsoft.CodeAnalysis.CSharp.BoundStatement)item3);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 8308, 8774);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10511_8167_8775(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock( (Microsoft.CodeAnalysis.SyntaxNode)syntax, locals, statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 8167, 8775);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10511,712,8802);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10511,712,8802);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement InstrumentLockTargetCapture(BoundLockStatement original, BoundStatement lockTargetCapture)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10511,8814,9113);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10511,8952,9102);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10511, 8959, 8974)||((f_10511_8959_8974(this)&&DynAbs.Tracing.TraceSender.Conditional_F2(10511, 8994, 9064))||DynAbs.Tracing.TraceSender.Conditional_F3(10511, 9084, 9101)))?f_10511_8994_9064(                _instrumenter, original, lockTargetCapture):                lockTargetCapture;
DynAbs.Tracing.TraceSender.TraceExitMethod(10511,8814,9113);

bool
f_10511_8959_8974(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10511, 8959, 8974);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10511_8994_9064(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLockStatement
original,Microsoft.CodeAnalysis.CSharp.BoundStatement
lockTargetCapture)
{
var return_v = this_param.InstrumentLockTargetCapture( original, lockTargetCapture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10511, 8994, 9064);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10511,8814,9113);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10511,8814,9113);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
