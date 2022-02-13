// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitBinaryOperator(BoundBinaryOperator node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,533,679);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,629,668);

return f_10482_636_667(this, node, null);
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,533,679);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_636_667(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
node,Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator?
applyParentUnaryOperator)
{
var return_v = this_param.VisitBinaryOperator( node, applyParentUnaryOperator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 636, 667);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,533,679);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,533,679);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode VisitUserDefinedConditionalLogicalOperator(BoundUserDefinedConditionalLogicalOperator node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,691,5069);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,3194,3219);

var 
syntax = node.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,3233,3270);

var 
operatorKind = f_10482_3252_3269(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,3284,3305);

var 
type = f_10482_3295_3304(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,3321,3378);

BoundExpression 
loweredLeft = f_10482_3351_3377(this, f_10482_3367_3376(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,3392,3451);

BoundExpression 
loweredRight = f_10482_3423_3450(this, f_10482_3439_3449(node))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,3467,3683) || true) && (_inExpressionLambda)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,3467,3683);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,3524,3668);

return f_10482_3531_3667(node, operatorKind, f_10482_3557_3577(node), f_10482_3579_3596(node), f_10482_3598_3616(node), f_10482_3618_3633(node), loweredLeft, loweredRight, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,3467,3683);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,3699,3738);

BoundAssignmentOperator 
tempAssignment
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,3752,3822);

var 
boundTemp = f_10482_3768_3821(_factory, loweredLeft, out tempAssignment)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,3868,4044);

var 
falseOperatorCall = f_10482_3892_4043(syntax, receiverOpt: null, (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 3941, 3990)||((f_10482_3941_3964(operatorKind)== BinaryOperatorKind.And &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 3993, 4011))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 4014, 4031)))?f_10482_3993_4011(node):f_10482_4014_4031(node), boundTemp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,4089,4247);

var 
andOperatorCall = f_10482_4111_4246(this, syntax, operatorKind & ~BinaryOperatorKind.Logical, boundTemp, loweredRight, type, f_10482_4225_4245(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,4315,4688);

BoundExpression 
conditionalExpression = f_10482_4355_4687(syntax: syntax, rewrittenCondition: falseOperatorCall, rewrittenConsequence: boundTemp, rewrittenAlternative: andOperatorCall, constantValueOpt: null, rewrittenType: type, isRef: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,4766,5058);

return f_10482_4773_5057(syntax: syntax, locals: f_10482_4850_4894(f_10482_4872_4893(boundTemp)), sideEffects: f_10482_4926_4980(tempAssignment), value: conditionalExpression, type: type);
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,691,5069);

Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10482_3252_3269(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 3252, 3269);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_3295_3304(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 3295, 3304);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_3367_3376(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 3367, 3376);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_3351_3377(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 3351, 3377);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_3439_3449(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
this_param)
{
var return_v = this_param.Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 3439, 3449);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_3423_3450(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 3423, 3450);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10482_3557_3577(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
this_param)
{
var return_v = this_param.LogicalOperator;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 3557, 3577);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10482_3579_3596(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
this_param)
{
var return_v = this_param.TrueOperator;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 3579, 3596);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10482_3598_3616(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
this_param)
{
var return_v = this_param.FalseOperator;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 3598, 3616);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LookupResultKind
f_10482_3618_3633(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
this_param)
{
var return_v = this_param.ResultKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 3618, 3633);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
f_10482_3531_3667(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
logicalOperator,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
trueOperator,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
falseOperator,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Update( operatorKind, logicalOperator, trueOperator, falseOperator, resultKind, left, right, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 3531, 3667);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10482_3768_3821(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 3768, 3821);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10482_3941_3964(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.Operator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 3941, 3964);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10482_3993_4011(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
this_param)
{
var return_v = this_param.FalseOperator ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 3993, 4011);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10482_4014_4031(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
this_param)
{
var return_v = this_param.TrueOperator;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 4014, 4031);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10482_3892_4043(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundLocal
arg0)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt: receiverOpt, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 3892, 4043);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10482_4225_4245(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
this_param)
{
var return_v = this_param.LogicalOperator;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 4225, 4245);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_4111_4246(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundLocal
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = this_param.LowerUserDefinedBinaryOperator( syntax, operatorKind, (Microsoft.CodeAnalysis.CSharp.BoundExpression)loweredLeft, loweredRight, type, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 4111, 4246);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_4355_4687(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundCall
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundLocal
rewrittenConsequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenAlternative,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
isRef)
{
var return_v = RewriteConditionalOperator( syntax: syntax, rewrittenCondition: (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenCondition, rewrittenConsequence: (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenConsequence, rewrittenAlternative: rewrittenAlternative, constantValueOpt: constantValueOpt, rewrittenType: rewrittenType, isRef: isRef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 4355, 4687);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10482_4872_4893(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 4872, 4893);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10482_4850_4894(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 4850, 4894);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10482_4926_4980(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 4926, 4980);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10482_4773_5057(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax: syntax, locals: locals, sideEffects: sideEffects, value: value, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 4773, 5057);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,691,5069);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,691,5069);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public BoundExpression VisitBinaryOperator(BoundBinaryOperator node, BoundUnaryOperator? applyParentUnaryOperator)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,5081,6468);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,5559,5619);

var 
stack = f_10482_5571_5618()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,5661,5675);

            for (BoundBinaryOperator? 
current = node
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,5635,5841) || true) && (current != null &&(DynAbs.Tracing.TraceSender.Expression_True(10482, 5677, 5725)&&f_10482_5696_5717(current)== null))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,5727,5772)
,current = f_10482_5737_5749(current)as BoundBinaryOperator,DynAbs.Tracing.TraceSender.TraceExitCondition(10482,5635,5841))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,5635,5841);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,5806,5826);

f_10482_5806_5825(                stack, current);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10482,1,207);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10482,1,207);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,5857,5922);

BoundExpression 
loweredLeft = f_10482_5887_5921(this, f_10482_5903_5920(f_10482_5903_5915(stack)))
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,5936,6395) || true) && (f_10482_5943_5954(stack)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,5936,6395);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,5992,6035);

BoundBinaryOperator 
original = f_10482_6023_6034(stack)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,6053,6116);

BoundExpression 
loweredRight = f_10482_6084_6115(this, f_10482_6100_6114(original))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,6134,6380);

loweredLeft = f_10482_6148_6379(this, original, original.Syntax, f_10482_6194_6215(original), loweredLeft, loweredRight, f_10482_6244_6257(original), f_10482_6259_6277(original), applyParentUnaryOperator: (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 6326, 6344)||(((f_10482_6327_6338(stack)== 0) &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 6347, 6371))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 6374, 6378)))?applyParentUnaryOperator :null);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,5936,6395);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10482,5936,6395);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10482,5936,6395);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,6411,6424);

f_10482_6411_6423(
            stack);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,6438,6457);

return loweredLeft;
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,5081,6468);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
f_10482_5571_5618()
{
var return_v = ArrayBuilder<BoundBinaryOperator>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 5571, 5618);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10482_5696_5717(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 5696, 5717);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_5737_5749(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
this_param)
{
var return_v = this_param.Left ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 5737, 5749);
return return_v;
}


int
f_10482_5806_5825(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
builder,Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
e)
{
builder.Push<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>( e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 5806, 5825);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10482_5903_5915(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
builder)
{
var return_v = builder.Peek<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 5903, 5915);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_5903_5920(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 5903, 5920);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_5887_5921(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 5887, 5921);
return return_v;
}


int
f_10482_5943_5954(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 5943, 5954);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10482_6023_6034(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
builder)
{
var return_v = builder.Pop<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 6023, 6034);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_6100_6114(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
this_param)
{
var return_v = this_param.Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 6100, 6114);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_6084_6115(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 6084, 6115);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10482_6194_6215(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 6194, 6215);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_6244_6257(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 6244, 6257);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10482_6259_6277(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
this_param)
{
var return_v = this_param.MethodOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 6259, 6277);
return return_v;
}


int
f_10482_6327_6338(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 6327, 6338);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_6148_6379(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
oldNode,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method,Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator?
applyParentUnaryOperator)
{
var return_v = this_param.MakeBinaryOperator( oldNode, syntax, operatorKind, loweredLeft, loweredRight, type, method, applyParentUnaryOperator: applyParentUnaryOperator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 6148, 6379);
return return_v;
}


int
f_10482_6411_6423(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 6411, 6423);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,5081,6468);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,5081,6468);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeBinaryOperator(
            SyntaxNode syntax,
            BinaryOperatorKind operatorKind,
            BoundExpression loweredLeft,
            BoundExpression loweredRight,
            TypeSymbol type,
            MethodSymbol? method,
            bool isPointerElementAccess = false,
            bool isCompoundAssignment = false,
            BoundUnaryOperator? applyParentUnaryOperator = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,6480,7118);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,6940,7107);

return f_10482_6947_7106(this, null, syntax, operatorKind, loweredLeft, loweredRight, type, method, isPointerElementAccess, isCompoundAssignment, applyParentUnaryOperator);
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,6480,7118);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_6947_7106(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator?
oldNode,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method,bool
isPointerElementAccess,bool
isCompoundAssignment,Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator?
applyParentUnaryOperator)
{
var return_v = this_param.MakeBinaryOperator( oldNode, syntax, operatorKind, loweredLeft, loweredRight, type, method, isPointerElementAccess, isCompoundAssignment, applyParentUnaryOperator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 6947, 7106);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,6480,7118);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,6480,7118);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

        private BoundExpression MakeBinaryOperator(
            BoundBinaryOperator? oldNode,
            SyntaxNode syntax,
            BinaryOperatorKind operatorKind,
            BoundExpression loweredLeft,
            BoundExpression loweredRight,
            TypeSymbol type,
            MethodSymbol? method,
            bool isPointerElementAccess = false,
            bool isCompoundAssignment = false,
            BoundUnaryOperator? applyParentUnaryOperator = null)
        {
            Debug.Assert(oldNode == null || (oldNode.Syntax == syntax));

            if (_inExpressionLambda)
            {
                switch (operatorKind.Operator() | operatorKind.OperandTypes())
                {
                    case BinaryOperatorKind.ObjectAndStringConcatenation:
                    case BinaryOperatorKind.StringAndObjectConcatenation:
                    case BinaryOperatorKind.StringConcatenation:
                        return RewriteStringConcatenation(syntax, operatorKind, loweredLeft, loweredRight, type);
                    case BinaryOperatorKind.DelegateCombination:
                        return RewriteDelegateOperation(syntax, operatorKind, loweredLeft, loweredRight, type, SpecialMember.System_Delegate__Combine);
                    case BinaryOperatorKind.DelegateRemoval:
                        return RewriteDelegateOperation(syntax, operatorKind, loweredLeft, loweredRight, type, SpecialMember.System_Delegate__Remove);
                    case BinaryOperatorKind.DelegateEqual:
                        return RewriteDelegateOperation(syntax, operatorKind, loweredLeft, loweredRight, type, SpecialMember.System_Delegate__op_Equality);
                    case BinaryOperatorKind.DelegateNotEqual:
                        return RewriteDelegateOperation(syntax, operatorKind, loweredLeft, loweredRight, type, SpecialMember.System_Delegate__op_Inequality);
                }
            }
            else
            // try to lower the expression.
            {
                if (operatorKind.IsDynamic())
                {
                    Debug.Assert(!isPointerElementAccess);

                    if (operatorKind.IsLogical())
                    {
                        return MakeDynamicLogicalBinaryOperator(syntax, operatorKind, loweredLeft, loweredRight, method, type, isCompoundAssignment, applyParentUnaryOperator);
                    }
                    else
                    {
                        Debug.Assert(method is null);
                        return _dynamicFactory.MakeDynamicBinaryOperator(operatorKind, loweredLeft, loweredRight, isCompoundAssignment, type).ToExpression();
                    }
                }

                if (operatorKind.IsLifted())
                {
                    return RewriteLiftedBinaryOperator(syntax, operatorKind, loweredLeft, loweredRight, type, method);
                }

                if (operatorKind.IsUserDefined())
                {
                    return LowerUserDefinedBinaryOperator(syntax, operatorKind, loweredLeft, loweredRight, type, method);
                }

                switch (operatorKind.OperatorWithLogical() | operatorKind.OperandTypes())
                {
                    case BinaryOperatorKind.NullableNullEqual:
                    case BinaryOperatorKind.NullableNullNotEqual:
                        return RewriteNullableNullEquality(syntax, operatorKind, loweredLeft, loweredRight, type);

                    case BinaryOperatorKind.ObjectAndStringConcatenation:
                    case BinaryOperatorKind.StringAndObjectConcatenation:
                    case BinaryOperatorKind.StringConcatenation:
                        return RewriteStringConcatenation(syntax, operatorKind, loweredLeft, loweredRight, type);

                    case BinaryOperatorKind.StringEqual:
                        return RewriteStringEquality(oldNode, syntax, operatorKind, loweredLeft, loweredRight, type, SpecialMember.System_String__op_Equality);

                    case BinaryOperatorKind.StringNotEqual:
                        return RewriteStringEquality(oldNode, syntax, operatorKind, loweredLeft, loweredRight, type, SpecialMember.System_String__op_Inequality);

                    case BinaryOperatorKind.DelegateCombination:
                        return RewriteDelegateOperation(syntax, operatorKind, loweredLeft, loweredRight, type, SpecialMember.System_Delegate__Combine);

                    case BinaryOperatorKind.DelegateRemoval:
                        return RewriteDelegateOperation(syntax, operatorKind, loweredLeft, loweredRight, type, SpecialMember.System_Delegate__Remove);

                    case BinaryOperatorKind.DelegateEqual:
                        return RewriteDelegateOperation(syntax, operatorKind, loweredLeft, loweredRight, type, SpecialMember.System_Delegate__op_Equality);

                    case BinaryOperatorKind.DelegateNotEqual:
                        return RewriteDelegateOperation(syntax, operatorKind, loweredLeft, loweredRight, type, SpecialMember.System_Delegate__op_Inequality);

                    case BinaryOperatorKind.LogicalBoolAnd:
                        if (loweredRight.ConstantValue == ConstantValue.True) return loweredLeft;
                        if (loweredLeft.ConstantValue == ConstantValue.True) return loweredRight;
                        if (loweredLeft.ConstantValue == ConstantValue.False) return loweredLeft;

                        if (loweredRight.Kind == BoundKind.Local || loweredRight.Kind == BoundKind.Parameter)
                        {
                            operatorKind &= ~BinaryOperatorKind.Logical;
                        }

                        goto default;

                    case BinaryOperatorKind.LogicalBoolOr:
                        if (loweredRight.ConstantValue == ConstantValue.False) return loweredLeft;
                        if (loweredLeft.ConstantValue == ConstantValue.False) return loweredRight;
                        if (loweredLeft.ConstantValue == ConstantValue.True) return loweredLeft;

                        if (loweredRight.Kind == BoundKind.Local || loweredRight.Kind == BoundKind.Parameter)
                        {
                            operatorKind &= ~BinaryOperatorKind.Logical;
                        }

                        goto default;

                    case BinaryOperatorKind.BoolAnd:
                        if (loweredRight.ConstantValue == ConstantValue.True) return loweredLeft;
                        if (loweredLeft.ConstantValue == ConstantValue.True) return loweredRight;

                        // Note that we are using IsDefaultValue instead of False.
                        // That is just to catch cases like default(bool) or others resulting in 
                        // a default bool value, that we know to be "false"
                        // bool? generally should not reach here, since it is handled by RewriteLiftedBinaryOperator.
                        // Regardless, the following code should handle default(bool?) correctly since
                        // default(bool?) & <expr> == default(bool?)  with sideeffects of <expr>
                        if (loweredLeft.IsDefaultValue())
                        {
                            return _factory.MakeSequence(loweredRight, loweredLeft);
                        }
                        if (loweredRight.IsDefaultValue())
                        {
                            return _factory.MakeSequence(loweredLeft, loweredRight);
                        }

                        goto default;

                    case BinaryOperatorKind.BoolOr:
                        if (loweredRight.ConstantValue == ConstantValue.False) return loweredLeft;
                        if (loweredLeft.ConstantValue == ConstantValue.False) return loweredRight;
                        goto default;

                    case BinaryOperatorKind.BoolEqual:
                        if (loweredLeft.ConstantValue == ConstantValue.True) return loweredRight;
                        if (loweredRight.ConstantValue == ConstantValue.True) return loweredLeft;

                        Debug.Assert(loweredLeft.Type is { });
                        Debug.Assert(loweredRight.Type is { });
                        if (loweredLeft.ConstantValue == ConstantValue.False)
                            return MakeUnaryOperator(UnaryOperatorKind.BoolLogicalNegation, syntax, null, loweredRight, loweredRight.Type);

                        if (loweredRight.ConstantValue == ConstantValue.False)
                            return MakeUnaryOperator(UnaryOperatorKind.BoolLogicalNegation, syntax, null, loweredLeft, loweredLeft.Type);

                        goto default;

                    case BinaryOperatorKind.BoolNotEqual:
                        if (loweredLeft.ConstantValue == ConstantValue.False) return loweredRight;
                        if (loweredRight.ConstantValue == ConstantValue.False) return loweredLeft;

                        Debug.Assert(loweredLeft.Type is { });
                        Debug.Assert(loweredRight.Type is { });
                        if (loweredLeft.ConstantValue == ConstantValue.True)
                            return MakeUnaryOperator(UnaryOperatorKind.BoolLogicalNegation, syntax, null, loweredRight, loweredRight.Type);

                        if (loweredRight.ConstantValue == ConstantValue.True)
                            return MakeUnaryOperator(UnaryOperatorKind.BoolLogicalNegation, syntax, null, loweredLeft, loweredLeft.Type);

                        goto default;

                    case BinaryOperatorKind.BoolXor:
                        if (loweredLeft.ConstantValue == ConstantValue.False) return loweredRight;
                        if (loweredRight.ConstantValue == ConstantValue.False) return loweredLeft;

                        Debug.Assert(loweredLeft.Type is { });
                        Debug.Assert(loweredRight.Type is { });
                        if (loweredLeft.ConstantValue == ConstantValue.True)
                            return MakeUnaryOperator(UnaryOperatorKind.BoolLogicalNegation, syntax, null, loweredRight, loweredRight.Type);

                        if (loweredRight.ConstantValue == ConstantValue.True)
                            return MakeUnaryOperator(UnaryOperatorKind.BoolLogicalNegation, syntax, null, loweredLeft, loweredLeft.Type);

                        goto default;

                    case BinaryOperatorKind.IntLeftShift:
                    case BinaryOperatorKind.UIntLeftShift:
                    case BinaryOperatorKind.IntRightShift:
                    case BinaryOperatorKind.UIntRightShift:
                        return RewriteBuiltInShiftOperation(oldNode, syntax, operatorKind, loweredLeft, loweredRight, type, 0x1F);

                    case BinaryOperatorKind.LongLeftShift:
                    case BinaryOperatorKind.ULongLeftShift:
                    case BinaryOperatorKind.LongRightShift:
                    case BinaryOperatorKind.ULongRightShift:
                        return RewriteBuiltInShiftOperation(oldNode, syntax, operatorKind, loweredLeft, loweredRight, type, 0x3F);

                    case BinaryOperatorKind.DecimalAddition:
                    case BinaryOperatorKind.DecimalSubtraction:
                    case BinaryOperatorKind.DecimalMultiplication:
                    case BinaryOperatorKind.DecimalDivision:
                    case BinaryOperatorKind.DecimalRemainder:
                    case BinaryOperatorKind.DecimalEqual:
                    case BinaryOperatorKind.DecimalNotEqual:
                    case BinaryOperatorKind.DecimalLessThan:
                    case BinaryOperatorKind.DecimalLessThanOrEqual:
                    case BinaryOperatorKind.DecimalGreaterThan:
                    case BinaryOperatorKind.DecimalGreaterThanOrEqual:
                        return RewriteDecimalBinaryOperation(syntax, loweredLeft, loweredRight, operatorKind);

                    case BinaryOperatorKind.PointerAndIntAddition:
                    case BinaryOperatorKind.PointerAndUIntAddition:
                    case BinaryOperatorKind.PointerAndLongAddition:
                    case BinaryOperatorKind.PointerAndULongAddition:
                    case BinaryOperatorKind.PointerAndIntSubtraction:
                    case BinaryOperatorKind.PointerAndUIntSubtraction:
                    case BinaryOperatorKind.PointerAndLongSubtraction:
                    case BinaryOperatorKind.PointerAndULongSubtraction:
                        if (loweredRight.IsDefaultValue())
                        {
                            return loweredLeft;
                        }
                        return RewritePointerNumericOperator(syntax, operatorKind, loweredLeft, loweredRight, type, isPointerElementAccess, isLeftPointer: true);

                    case BinaryOperatorKind.IntAndPointerAddition:
                    case BinaryOperatorKind.UIntAndPointerAddition:
                    case BinaryOperatorKind.LongAndPointerAddition:
                    case BinaryOperatorKind.ULongAndPointerAddition:
                        if (loweredLeft.IsDefaultValue())
                        {
                            return loweredRight;
                        }
                        return RewritePointerNumericOperator(syntax, operatorKind, loweredLeft, loweredRight, type, isPointerElementAccess, isLeftPointer: false);

                    case BinaryOperatorKind.PointerSubtraction:
                        return RewritePointerSubtraction(operatorKind, loweredLeft, loweredRight, type);

                    case BinaryOperatorKind.IntAddition:
                    case BinaryOperatorKind.UIntAddition:
                    case BinaryOperatorKind.LongAddition:
                    case BinaryOperatorKind.ULongAddition:
                        if (loweredLeft.IsDefaultValue())
                        {
                            return loweredRight;
                        }
                        if (loweredRight.IsDefaultValue())
                        {
                            return loweredLeft;
                        }
                        goto default;

                    case BinaryOperatorKind.IntSubtraction:
                    case BinaryOperatorKind.LongSubtraction:
                    case BinaryOperatorKind.UIntSubtraction:
                    case BinaryOperatorKind.ULongSubtraction:
                        if (loweredRight.IsDefaultValue())
                        {
                            return loweredLeft;
                        }
                        goto default;

                    case BinaryOperatorKind.IntMultiplication:
                    case BinaryOperatorKind.LongMultiplication:
                    case BinaryOperatorKind.UIntMultiplication:
                    case BinaryOperatorKind.ULongMultiplication:
                        if (loweredLeft.IsDefaultValue())
                        {
                            return _factory.MakeSequence(loweredRight, loweredLeft);
                        }
                        if (loweredRight.IsDefaultValue())
                        {
                            return _factory.MakeSequence(loweredLeft, loweredRight);
                        }
                        if (loweredLeft.ConstantValue?.UInt64Value == 1)
                        {
                            return loweredRight;
                        }
                        if (loweredRight.ConstantValue?.UInt64Value == 1)
                        {
                            return loweredLeft;
                        }
                        goto default;

                    case BinaryOperatorKind.IntGreaterThan:
                    case BinaryOperatorKind.IntLessThanOrEqual:
                        if (loweredLeft.Kind == BoundKind.ArrayLength && loweredRight.IsDefaultValue())
                        {
                            //array length is never negative
                            var newOp = operatorKind == BinaryOperatorKind.IntGreaterThan ?
                                                        BinaryOperatorKind.NotEqual :
                                                        BinaryOperatorKind.Equal;

                            operatorKind &= ~BinaryOperatorKind.OpMask;
                            operatorKind |= newOp;
                            loweredLeft = UnconvertArrayLength((BoundArrayLength)loweredLeft);
                        }
                        goto default;

                    case BinaryOperatorKind.IntLessThan:
                    case BinaryOperatorKind.IntGreaterThanOrEqual:
                        if (loweredRight.Kind == BoundKind.ArrayLength && loweredLeft.IsDefaultValue())
                        {
                            //array length is never negative
                            var newOp = operatorKind == BinaryOperatorKind.IntLessThan ?
                                                        BinaryOperatorKind.NotEqual :
                                                        BinaryOperatorKind.Equal;

                            operatorKind &= ~BinaryOperatorKind.OpMask;
                            operatorKind |= newOp;
                            loweredRight = UnconvertArrayLength((BoundArrayLength)loweredRight);
                        }
                        goto default;

                    case BinaryOperatorKind.IntEqual:
                    case BinaryOperatorKind.IntNotEqual:
                        if (loweredLeft.Kind == BoundKind.ArrayLength && loweredRight.IsDefaultValue())
                        {
                            loweredLeft = UnconvertArrayLength((BoundArrayLength)loweredLeft);
                        }
                        else if (loweredRight.Kind == BoundKind.ArrayLength && loweredLeft.IsDefaultValue())
                        {
                            loweredRight = UnconvertArrayLength((BoundArrayLength)loweredRight);
                        }

                        goto default;

                    default:
                        break;
                }
            }

            return (oldNode != null) ?
                oldNode.Update(operatorKind, oldNode.ConstantValueOpt, oldNode.MethodOpt, oldNode.ResultKind, loweredLeft, loweredRight, type) :
                new BoundBinaryOperator(syntax, operatorKind, null, null, LookupResultKind.Viable, loweredLeft, loweredRight, type);
        }

private BoundExpression RewriteLiftedBinaryOperator(SyntaxNode syntax, BinaryOperatorKind operatorKind, BoundExpression loweredLeft, BoundExpression loweredRight, TypeSymbol type, MethodSymbol? method)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,25990,28515);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,26216,26283);

var 
conditionalLeft = loweredLeft as BoundLoweredConditionalAccess
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,26528,26848);

var 
optimize = conditionalLeft != null &&(DynAbs.Tracing.TraceSender.Expression_True(10482, 26543, 26634)&&                operatorKind != BinaryOperatorKind.LiftedBoolOr )&&(DynAbs.Tracing.TraceSender.Expression_True(10482, 26543, 26686)&&operatorKind != BinaryOperatorKind.LiftedBoolAnd )&&(DynAbs.Tracing.TraceSender.Expression_True(10482, 26543, 26741)&&                !f_10482_26708_26741(loweredRight))&&(DynAbs.Tracing.TraceSender.Expression_True(10482, 26543, 26847)&&                (f_10482_26763_26790(conditionalLeft)== null ||(DynAbs.Tracing.TraceSender.Expression_False(10482, 26763, 26846)||f_10482_26802_26846(f_10482_26802_26829(conditionalLeft)))))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,26864,26968) || true) && (optimize)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,26864,26968);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,26910,26953);

loweredLeft = f_10482_26924_26952(conditionalLeft!);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,26864,26968);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,26984,27469);

var 
result = (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 26997, 27024)||((f_10482_26997_27024(operatorKind)&&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 27056, 27338))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 27370, 27468)))?(DynAbs.Tracing.TraceSender.Conditional_F1(10482, 27056, 27084)||((f_10482_27056_27084(                            operatorKind)&&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 27120, 27217))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 27253, 27338)))?f_10482_27120_27217(this, syntax, operatorKind, loweredLeft, loweredRight, method):f_10482_27253_27338(this, syntax, operatorKind, loweredLeft, loweredRight):f_10482_27370_27468(this, syntax, operatorKind, loweredLeft, loweredRight, type, method)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,27485,28474) || true) && (optimize)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,27485,28474);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,27531,27567);

BoundExpression? 
whenNullOpt = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,27726,28109) || true) && (f_10482_27730_27753(operatorKind)== BinaryOperatorKind.NotEqual ||(DynAbs.Tracing.TraceSender.Expression_False(10482, 27730, 27860)||f_10482_27809_27832(                    operatorKind)== BinaryOperatorKind.Equal))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,27726,28109);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,27902,27940);

f_10482_27902_27939(f_10482_27915_27931(loweredLeft)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,27962,28090);

whenNullOpt = f_10482_27976_28089(this, syntax, operatorKind, f_10482_28026_28060(_factory, f_10482_28043_28059(loweredLeft)), loweredRight, type, method);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,27726,28109);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,28129,28459);

result = f_10482_28138_28458(conditionalLeft!, f_10482_28184_28208(conditionalLeft), f_10482_28231_28264(conditionalLeft), whenNotNull: result, whenNullOpt: whenNullOpt, id: f_10482_28380_28398(conditionalLeft), type: result.Type!);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,27485,28474);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,28490,28504);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,25990,28515);

bool
f_10482_26708_26741(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = ReadIsSideeffecting( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 26708, 26741);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_26763_26790(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.WhenNullOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 26763, 26790);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_26802_26829(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.WhenNullOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 26802, 26829);
return return_v;
}


bool
f_10482_26802_26846(Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = node.IsDefaultValue();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 26802, 26846);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_26924_26952(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.WhenNotNull;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 26924, 26952);
return return_v;
}


bool
f_10482_26997_27024(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.IsComparison();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 26997, 27024);
return return_v;
}


bool
f_10482_27056_27084(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.IsUserDefined();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 27056, 27084);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_27120_27217(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.LowerLiftedUserDefinedComparisonOperator( syntax, kind, loweredLeft, loweredRight, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 27120, 27217);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_27253_27338(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight)
{
var return_v = this_param.LowerLiftedBuiltInComparisonOperator( syntax, kind, loweredLeft, loweredRight);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 27253, 27338);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_27370_27468(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.LowerLiftedBinaryArithmeticOperator( syntax, kind, loweredLeft, loweredRight, type, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 27370, 27468);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10482_27730_27753(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.Operator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 27730, 27753);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10482_27809_27832(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.Operator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 27809, 27832);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10482_27915_27931(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 27915, 27931);
return return_v;
}


int
f_10482_27902_27939(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 27902, 27939);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_28043_28059(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 28043, 28059);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_28026_28060(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Default( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 28026, 28060);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_27976_28089(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.RewriteLiftedBinaryOperator( syntax, operatorKind, loweredLeft, loweredRight, type, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 27976, 28089);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_28184_28208(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.Receiver;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 28184, 28208);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10482_28231_28264(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.HasValueMethodOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 28231, 28264);
return return_v;
}


int
f_10482_28380_28398(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 28380, 28398);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
f_10482_28138_28458(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
hasValueMethodOpt,Microsoft.CodeAnalysis.CSharp.BoundExpression
whenNotNull,Microsoft.CodeAnalysis.CSharp.BoundExpression?
whenNullOpt,int
id,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Update( receiver, hasValueMethodOpt, whenNotNull: whenNotNull, whenNullOpt: whenNullOpt, id: id, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 28138, 28458);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,25990,28515);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,25990,28515);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression UnconvertArrayLength(BoundArrayLength arrLength)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,28804,29008);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,28901,28997);

return f_10482_28908_28996(arrLength, f_10482_28925_28945(arrLength), f_10482_28947_28995(_factory, SpecialType.System_UIntPtr));
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,28804,29008);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_28925_28945(Microsoft.CodeAnalysis.CSharp.BoundArrayLength
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 28925, 28945);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10482_28947_28995(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.SpecialType
st)
{
var return_v = this_param.SpecialType( st);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 28947, 28995);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundArrayLength
f_10482_28908_28996(Microsoft.CodeAnalysis.CSharp.BoundArrayLength
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = this_param.Update( expression, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 28908, 28996);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,28804,29008);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,28804,29008);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeDynamicLogicalBinaryOperator(
            SyntaxNode syntax,
            BinaryOperatorKind operatorKind,
            BoundExpression loweredLeft,
            BoundExpression loweredRight,
            MethodSymbol? leftTruthOperator,
            TypeSymbol type,
            bool isCompoundAssignment,
            BoundUnaryOperator? applyParentUnaryOperator)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,29020,34774);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,29440,29556);

f_10482_29440_29555(f_10482_29453_29476(operatorKind)== BinaryOperatorKind.And ||(DynAbs.Tracing.TraceSender.Expression_False(10482, 29453, 29554)||f_10482_29506_29529(operatorKind)== BinaryOperatorKind.Or));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,30202,30265);

bool 
isAnd = f_10482_30215_30238(operatorKind)== BinaryOperatorKind.And
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,30343,30433);

var 
testOperator = (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 30362, 30367)||((isAnd &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 30370, 30400))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 30403, 30432)))?UnaryOperatorKind.DynamicFalse :UnaryOperatorKind.DynamicTrue
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,30585,30689);

f_10482_30585_30688(applyParentUnaryOperator == null ||(DynAbs.Tracing.TraceSender.Expression_False(10482, 30598, 30687)||f_10482_30634_30671(applyParentUnaryOperator)== testOperator));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,30705,30791);

ConstantValue? 
constantLeft = f_10482_30735_30760(loweredLeft)??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.ConstantValue?>(10482, 30735, 30790)??f_10482_30764_30790(loweredLeft))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,30805,31599) || true) && (testOperator == UnaryOperatorKind.DynamicFalse &&(DynAbs.Tracing.TraceSender.Expression_True(10482, 30809, 30894)&&constantLeft == f_10482_30875_30894())||(DynAbs.Tracing.TraceSender.Expression_False(10482, 30809, 30998)||                testOperator == UnaryOperatorKind.DynamicTrue &&(DynAbs.Tracing.TraceSender.Expression_True(10482, 30915, 30998)&&constantLeft == f_10482_30980_30998())))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,30805,31599);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,31032,31072);

f_10482_31032_31071(leftTruthOperator == null);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,31092,31584) || true) && (applyParentUnaryOperator != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,31092,31584);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,31282,31312);

return f_10482_31289_31311(_factory, true);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,31092,31584);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,31092,31584);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,31503,31565);

return f_10482_31510_31564(this, loweredLeft, type, @checked: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,31092,31584);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,30805,31599);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,31615,31638);

BoundExpression 
result
=default(BoundExpression);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,31652,31722);

var 
boolean = f_10482_31666_31721(_compilation, SpecialType.System_Boolean)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,31915,31955);

BoundAssignmentOperator? 
tempAssignment
=default(BoundAssignmentOperator?);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,31969,31986);

BoundLocal? 
temp
=default(BoundLocal?);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,32000,32503) || true) && (constantLeft == null &&(DynAbs.Tracing.TraceSender.Expression_True(10482, 32004, 32063)&&f_10482_32028_32044(loweredLeft)!= BoundKind.Local )&&(DynAbs.Tracing.TraceSender.Expression_True(10482, 32004, 32106)&&f_10482_32067_32083(loweredLeft)!= BoundKind.Parameter))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,32000,32503);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,32140,32175);

BoundAssignmentOperator 
assignment
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,32193,32255);

var 
local = f_10482_32205_32254(_factory, loweredLeft, out assignment)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,32273,32293);

loweredLeft = local;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,32311,32339);

tempAssignment = assignment;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,32357,32370);

temp = local;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,32000,32503);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,32000,32503);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,32436,32458);

tempAssignment = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,32476,32488);

temp = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,32000,32503);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,32519,32654);

var 
op = f_10482_32528_32638(_dynamicFactory, operatorKind, loweredLeft, loweredRight, isCompoundAssignment, type).ToExpression()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,32735,32983);

bool 
leftTestIsConstantFalse = testOperator == UnaryOperatorKind.DynamicFalse &&(DynAbs.Tracing.TraceSender.Expression_True(10482, 32766, 32850)&&constantLeft == f_10482_32832_32850())||(DynAbs.Tracing.TraceSender.Expression_False(10482, 32766, 32982)||                                           testOperator == UnaryOperatorKind.DynamicTrue &&(DynAbs.Tracing.TraceSender.Expression_True(10482, 32898, 32982)&&constantLeft == f_10482_32963_32982()))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,32999,34468) || true) && (applyParentUnaryOperator != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,32999,34468);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,33250,33342);

result = f_10482_33259_33326(_dynamicFactory, testOperator, op, boolean).ToExpression();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,33360,33685) || true) && (!leftTestIsConstantFalse)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,33360,33685);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,33430,33562);

BoundExpression 
leftTest = f_10482_33457_33561(this, syntax, loweredLeft, boolean, leftTruthOperator, negative: isAnd)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,33584,33666);

result = f_10482_33593_33665(_factory, BinaryOperatorKind.LogicalOr, boolean, leftTest, result);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,33360,33685);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,32999,34468);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,32999,34468);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,33909,34453) || true) && (leftTestIsConstantFalse)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,33909,34453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,33978,33990);

result = op;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,33909,34453);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,33909,34453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,34118,34250);

BoundExpression 
leftTest = f_10482_34145_34249(this, syntax, loweredLeft, boolean, leftTruthOperator, negative: isAnd)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,34272,34347);

var 
convertedLeft = f_10482_34292_34346(this, loweredLeft, type, @checked: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,34369,34434);

result = f_10482_34378_34433(_factory, leftTest, convertedLeft, op, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,33909,34453);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,32999,34468);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,34484,34733) || true) && (tempAssignment != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,34484,34733);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,34544,34570);

f_10482_34544_34569(temp is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,34588,34718);

return f_10482_34595_34717(_factory, f_10482_34613_34652(f_10482_34635_34651(temp)), f_10482_34654_34708(tempAssignment), result);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,34484,34733);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,34749,34763);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,29020,34774);

Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10482_29453_29476(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.Operator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 29453, 29476);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10482_29506_29529(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.Operator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 29506, 29529);
return return_v;
}


int
f_10482_29440_29555(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 29440, 29555);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10482_30215_30238(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.Operator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 30215, 30238);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10482_30634_30671(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
this_param)
{
var return_v = this_param.OperatorKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 30634, 30671);
return return_v;
}


int
f_10482_30585_30688(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 30585, 30688);
return 0;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10482_30735_30760(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 30735, 30760);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10482_30764_30790(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = UnboxConstant( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 30764, 30790);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10482_30875_30894()
{
var return_v = ConstantValue.False ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 30875, 30894);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10482_30980_30998()
{
var return_v = ConstantValue.True;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 30980, 30998);
return return_v;
}


int
f_10482_31032_31071(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 31032, 31071);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10482_31289_31311(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,bool
value)
{
var return_v = this_param.Literal( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 31289, 31311);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_31510_31564(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( rewrittenOperand, rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 31510, 31564);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10482_31666_31721(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 31666, 31721);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10482_32028_32044(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 32028, 32044);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10482_32067_32083(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 32067, 32083);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10482_32205_32254(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 32205, 32254);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
f_10482_32528_32638(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,bool
isCompoundAssignment,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
resultType)
{
var return_v = this_param.MakeDynamicBinaryOperator( operatorKind, loweredLeft, loweredRight, isCompoundAssignment, resultType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 32528, 32638);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10482_32832_32850()
{
var return_v = ConstantValue.True ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 32832, 32850);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10482_32963_32982()
{
var return_v = ConstantValue.False;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 32963, 32982);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
f_10482_33259_33326(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
this_param,Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredOperand,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
resultType)
{
var return_v = this_param.MakeDynamicUnaryOperator( operatorKind, loweredOperand, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)resultType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 33259, 33326);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_33457_33561(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
boolean,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
leftTruthOperator,bool
negative)
{
var return_v = this_param.MakeTruthTestForDynamicLogicalOperator( syntax, loweredLeft, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)boolean, leftTruthOperator, negative: negative);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 33457, 33561);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10482_33593_33665(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.Binary( kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 33593, 33665);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_34145_34249(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
boolean,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
leftTruthOperator,bool
negative)
{
var return_v = this_param.MakeTruthTestForDynamicLogicalOperator( syntax, loweredLeft, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)boolean, leftTruthOperator, negative: negative);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 34145, 34249);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_34292_34346(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( rewrittenOperand, rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 34292, 34346);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_34378_34433(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
condition,Microsoft.CodeAnalysis.CSharp.BoundExpression
consequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
alternative,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Conditional( condition, consequence, alternative, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 34378, 34433);
return return_v;
}


int
f_10482_34544_34569(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 34544, 34569);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10482_34635_34651(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 34635, 34651);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10482_34613_34652(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 34613, 34652);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10482_34654_34708(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 34654, 34708);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_34595_34717(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
result)
{
var return_v = this_param.Sequence( locals, sideEffects, result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 34595, 34717);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,29020,34774);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,29020,34774);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static ConstantValue? UnboxConstant(BoundExpression expression)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10482,34786,35231);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,34882,35192) || true) && (f_10482_34886_34901(expression)== BoundKind.Conversion)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,34882,35192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,34959,35004);

var 
conversion = (BoundConversion)expression
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,35022,35177) || true) && (f_10482_35026_35051(conversion)== ConversionKind.Boxing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,35022,35177);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,35118,35158);

return f_10482_35125_35157(f_10482_35125_35143(conversion));
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,35022,35177);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,34882,35192);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,35208,35220);

return null;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10482,34786,35231);

Microsoft.CodeAnalysis.CSharp.BoundKind
f_10482_34886_34901(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 34886, 34901);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.ConversionKind
f_10482_35026_35051(Microsoft.CodeAnalysis.CSharp.BoundConversion
this_param)
{
var return_v = this_param.ConversionKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 35026, 35051);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_35125_35143(Microsoft.CodeAnalysis.CSharp.BoundConversion
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 35125, 35143);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10482_35125_35157(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 35125, 35157);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,34786,35231);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,34786,35231);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeTruthTestForDynamicLogicalOperator(SyntaxNode syntax, BoundExpression loweredLeft, TypeSymbol boolean, MethodSymbol? leftTruthOperator, bool negative)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,35243,37167);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,35446,35745) || true) && (f_10482_35450_35478(loweredLeft))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,35446,35745);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,35512,35552);

f_10482_35512_35551(leftTruthOperator == null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,35570,35730);

return f_10482_35577_35714(_dynamicFactory, (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 35618, 35626)||((negative &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 35629, 35659))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 35662, 35691)))?UnaryOperatorKind.DynamicFalse :UnaryOperatorKind.DynamicTrue, loweredLeft, boolean).ToExpression();
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,35446,35745);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,36061,36112);

HashSet<DiagnosticInfo>? 
useSiteDiagnostics = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,36126,36247);

var 
conversion = f_10482_36143_36246(f_10482_36143_36167(_compilation), loweredLeft, boolean, ref useSiteDiagnostics)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,36261,36318);

f_10482_36261_36317(            _diagnostics, loweredLeft.Syntax, useSiteDiagnostics);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,36332,36998) || true) && (conversion.IsImplicit)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,36332,36998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,36391,36431);

f_10482_36391_36430(leftTruthOperator == null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,36451,36525);

var 
converted = f_10482_36467_36524(this, loweredLeft, boolean, @checked: false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,36543,36983) || true) && (negative)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,36543,36983);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,36597,36865);

return new BoundUnaryOperator(syntax, UnaryOperatorKind.BoolLogicalNegation, converted, ConstantValue.NotAvailable, MethodSymbol.None, LookupResultKind.Viable, boolean)
                    {
                        WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true,10482,36604,36864)
                    };
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,36543,36983);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,36543,36983);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,36947,36964);

return converted;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,36543,36983);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,36332,36998);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,37014,37054);

f_10482_37014_37053(leftTruthOperator != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,37068,37156);

return f_10482_37075_37155(syntax, receiverOpt: null, leftTruthOperator, loweredLeft);
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,35243,37167);

bool
f_10482_35450_35478(Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = node.HasDynamicType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 35450, 35478);
return return_v;
}


int
f_10482_35512_35551(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 35512, 35551);
return 0;
}


Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
f_10482_35577_35714(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
this_param,Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
resultType)
{
var return_v = this_param.MakeDynamicUnaryOperator( operatorKind, loweredOperand, resultType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 35577, 35714);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversions
f_10482_36143_36167(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.Conversions;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 36143, 36167);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10482_36143_36246(Microsoft.CodeAnalysis.CSharp.Conversions
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
sourceExpression,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
destination,ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
useSiteDiagnostics)
{
var return_v = this_param.ClassifyConversionFromExpression( sourceExpression, destination, ref useSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 36143, 36246);
return return_v;
}


bool
f_10482_36261_36317(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.SyntaxNode
node,System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
useSiteDiagnostics)
{
var return_v = diagnostics.Add( node, useSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 36261, 36317);
return return_v;
}


int
f_10482_36391_36430(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 36391, 36430);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_36467_36524(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( rewrittenOperand, rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 36467, 36524);
return return_v;
}


int
f_10482_37014_37053(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 37014, 37053);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10482_37075_37155(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg0)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt: receiverOpt, method, arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 37075, 37155);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,35243,37167);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,35243,37167);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression LowerUserDefinedBinaryOperator(
            SyntaxNode syntax,
            BinaryOperatorKind operatorKind,
            BoundExpression loweredLeft,
            BoundExpression loweredRight,
            TypeSymbol type,
            MethodSymbol? method)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,37179,38034);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,37487,37527);

f_10482_37487_37526(!f_10482_37501_37525(operatorKind));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,37543,37717) || true) && (f_10482_37547_37570(operatorKind))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,37543,37717);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,37604,37702);

return f_10482_37611_37701(this, syntax, operatorKind, loweredLeft, loweredRight, type, method);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,37543,37717);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,37782,37810);

f_10482_37782_37809(method is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,37824,37918);

f_10482_37824_37917(f_10482_37837_37916(f_10482_37855_37872(method), type, TypeCompareKind.ConsiderEverything2));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,37932,38023);

return f_10482_37939_38022(syntax, receiverOpt: null, method, loweredLeft, loweredRight);
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,37179,38034);

bool
f_10482_37501_37525(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.IsLogical();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 37501, 37525);
return return_v;
}


int
f_10482_37487_37526(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 37487, 37526);
return 0;
}


bool
f_10482_37547_37570(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.IsLifted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 37547, 37570);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_37611_37701(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.RewriteLiftedBinaryOperator( syntax, operatorKind, loweredLeft, loweredRight, type, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 37611, 37701);
return return_v;
}


int
f_10482_37782_37809(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 37782, 37809);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_37855_37872(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ReturnType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 37855, 37872);
return return_v;
}


bool
f_10482_37837_37916(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
left,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 37837, 37916);
return return_v;
}


int
f_10482_37824_37917(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 37824, 37917);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10482_37939_38022(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg0,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg1)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt: receiverOpt, method, arg0, arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 37939, 38022);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,37179,38034);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,37179,38034);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression? TrivialLiftedComparisonOperatorOptimizations(
            SyntaxNode syntax,
            BinaryOperatorKind kind,
            BoundExpression left,
            BoundExpression right,
            MethodSymbol? method)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,38046,42179);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,38317,38344);

f_10482_38317_38343(left != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,38358,38386);

f_10482_38358_38385(right != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,38555,38605);

bool 
leftAlwaysNull = f_10482_38577_38604(left)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,38619,38671);

bool 
rightAlwaysNull = f_10482_38642_38670(right)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,38687,38765);

TypeSymbol 
boolType = f_10482_38709_38764(_compilation, SpecialType.System_Boolean)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,38781,38971) || true) && (leftAlwaysNull &&(DynAbs.Tracing.TraceSender.Expression_True(10482, 38785, 38818)&&rightAlwaysNull))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,38781,38971);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,38852,38956);

return f_10482_38859_38955(this, syntax, f_10482_38879_38944(f_10482_38900_38915(kind)== BinaryOperatorKind.Equal), boolType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,38781,38971);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,39099,39159);

BoundExpression? 
leftNonNull = f_10482_39130_39158(left)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,39173,39235);

BoundExpression? 
rightNonNull = f_10482_39205_39234(right)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,39251,39633) || true) && (leftNonNull != null &&(DynAbs.Tracing.TraceSender.Expression_True(10482, 39255, 39298)&&rightNonNull != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,39251,39633);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,39332,39618);

return f_10482_39339_39617(this, syntax: syntax, operatorKind: f_10482_39431_39446(kind), loweredLeft: leftNonNull, loweredRight: rightNonNull, type: boolType, method: method);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,39251,39633);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,39876,39926);

BinaryOperatorKind 
operatorKind = f_10482_39910_39925(kind)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,39942,40847) || true) && (leftAlwaysNull &&(DynAbs.Tracing.TraceSender.Expression_True(10482, 39946, 39984)&&rightNonNull != null )||(DynAbs.Tracing.TraceSender.Expression_False(10482, 39946, 40026)||rightAlwaysNull &&(DynAbs.Tracing.TraceSender.Expression_True(10482, 39988, 40026)&&leftNonNull != null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,39942,40847);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,40060,40182);

BoundExpression 
result = f_10482_40085_40181(this, syntax, f_10482_40105_40170(operatorKind == BinaryOperatorKind.NotEqual), boolType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,40202,40273);

BoundExpression? 
nonNull = (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 40229, 40243)||((leftAlwaysNull &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 40246, 40258))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 40261, 40272)))?rightNonNull :leftNonNull
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,40291,40320);

f_10482_40291_40319(nonNull is { });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,40340,40798) || true) && (f_10482_40344_40372(nonNull))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,40340,40798);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,40414,40779);

result = f_10482_40423_40778(syntax: syntax, locals: ImmutableArray<LocalSymbol>.Empty, sideEffects: f_10482_40625_40672(nonNull), value: result, type: boolType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,40340,40798);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,40818,40832);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,39942,40847);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,41211,42140) || true) && (leftAlwaysNull ||(DynAbs.Tracing.TraceSender.Expression_False(10482, 41215, 41248)||rightAlwaysNull))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,41211,42140);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,41282,41340);

BoundExpression 
maybeNull = (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 41310, 41324)||((leftAlwaysNull &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 41327, 41332))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 41335, 41339)))?right :left
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,41360,42125) || true) && (operatorKind == BinaryOperatorKind.Equal ||(DynAbs.Tracing.TraceSender.Expression_False(10482, 41364, 41451)||operatorKind == BinaryOperatorKind.NotEqual))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,41360,42125);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,41493,41564);

BoundExpression 
callHasValue = f_10482_41524_41563(this, syntax, maybeNull)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,41586,41814);

BoundExpression 
result = (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 41611, 41651)||((operatorKind == BinaryOperatorKind.Equal &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 41679, 41773))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 41801, 41813)))?f_10482_41679_41773(this, UnaryOperatorKind.BoolLogicalNegation, syntax, null, callHasValue, boolType):                        callHasValue
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,41836,41850);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,41360,42125);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,41360,42125);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,41932,42033);

BoundExpression 
falseExpr = f_10482_41960_42032(this, syntax, operatorKind == BinaryOperatorKind.NotEqual)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,42055,42106);

return f_10482_42062_42105(_factory, maybeNull, falseExpr);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,41360,42125);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,41211,42140);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,42156,42168);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,38046,42179);

int
f_10482_38317_38343(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 38317, 38343);
return 0;
}


int
f_10482_38358_38385(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 38358, 38385);
return 0;
}


bool
f_10482_38577_38604(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableNeverHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 38577, 38604);
return return_v;
}


bool
f_10482_38642_38670(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableNeverHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 38642, 38670);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10482_38709_38764(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 38709, 38764);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10482_38900_38915(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.Operator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 38900, 38915);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10482_38879_38944(bool
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 38879, 38944);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_38859_38955(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeLiteral( syntax, constantValue, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 38859, 38955);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_39130_39158(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableAlwaysHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 39130, 39158);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_39205_39234(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableAlwaysHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 39205, 39234);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10482_39431_39446(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.Unlifted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 39431, 39446);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_39339_39617(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.MakeBinaryOperator( syntax: syntax, operatorKind: operatorKind, loweredLeft: loweredLeft, loweredRight: loweredRight, type: type, method: method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 39339, 39617);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10482_39910_39925(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.Operator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 39910, 39925);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10482_40105_40170(bool
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 40105, 40170);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_40085_40181(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeLiteral( syntax, constantValue, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 40085, 40181);
return return_v;
}


int
f_10482_40291_40319(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 40291, 40319);
return 0;
}


bool
f_10482_40344_40372(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = ReadIsSideeffecting( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 40344, 40372);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10482_40625_40672(Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 40625, 40672);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10482_40423_40778(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax: syntax, locals: locals, sideEffects: sideEffects, value: value, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 40423, 40778);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_41524_41563(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.MakeNullableHasValue( syntax, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 41524, 41563);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_41679_41773(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeUnaryOperator( kind, syntax, method, loweredOperand, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 41679, 41773);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_41960_42032(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,bool
value)
{
var return_v = this_param.MakeBooleanConstant( syntax, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 41960, 42032);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_42062_42105(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
parts)
{
var return_v = this_param.MakeSequence( parts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 42062, 42105);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,38046,42179);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,38046,42179);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeOptimizedGetValueOrDefault(SyntaxNode syntax, BoundExpression expression)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,42191,42782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,42317,42354);

f_10482_42317_42353(f_10482_42330_42345(expression)is { });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,42502,42737) || true) && (f_10482_42506_42538(f_10482_42506_42521(expression)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,42502,42737);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,42572,42722);

return f_10482_42579_42721(syntax, expression, f_10482_42621_42720(this, syntax, f_10482_42653_42668(expression), SpecialMember.System_Nullable_T_GetValueOrDefault));
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,42502,42737);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,42753,42771);

return expression;
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,42191,42782);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10482_42330_42345(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 42330, 42345);
return return_v;
}


int
f_10482_42317_42353(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 42317, 42353);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_42506_42521(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 42506, 42521);
return return_v;
}


bool
f_10482_42506_42538(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsNullableType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 42506, 42538);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_42653_42668(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 42653, 42668);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10482_42621_42720(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
nullableType,Microsoft.CodeAnalysis.SpecialMember
member)
{
var return_v = this_param.UnsafeGetNullableMethod( syntax, nullableType, member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 42621, 42720);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10482_42579_42721(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 42579, 42721);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,42191,42782);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,42191,42782);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeBooleanConstant(SyntaxNode syntax, bool value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,42794,43017);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,42893,43006);

return f_10482_42900_43005(this, syntax, f_10482_42920_42947(value), f_10482_42949_43004(_compilation, SpecialType.System_Boolean));
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,42794,43017);

Microsoft.CodeAnalysis.ConstantValue
f_10482_42920_42947(bool
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 42920, 42947);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10482_42949_43004(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 42949, 43004);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_42900_43005(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = this_param.MakeLiteral( syntax, constantValue, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 42900, 43005);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,42794,43017);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,42794,43017);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeOptimizedHasValue(SyntaxNode syntax, BoundExpression expression)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,43029,43544);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,43146,43183);

f_10482_43146_43182(f_10482_43159_43174(expression)is { });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,43343,43476) || true) && (f_10482_43347_43379(f_10482_43347_43362(expression)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,43343,43476);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,43413,43461);

return f_10482_43420_43460(this, syntax, expression);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,43343,43476);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,43492,43533);

return f_10482_43499_43532(this, syntax, true);
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,43029,43544);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10482_43159_43174(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 43159, 43174);
return return_v;
}


int
f_10482_43146_43182(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 43146, 43182);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_43347_43362(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 43347, 43362);
return return_v;
}


bool
f_10482_43347_43379(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsNullableType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 43347, 43379);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_43420_43460(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.MakeNullableHasValue( syntax, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 43420, 43460);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_43499_43532(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,bool
value)
{
var return_v = this_param.MakeBooleanConstant( syntax, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 43499, 43532);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,43029,43544);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,43029,43544);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeNullableHasValue(SyntaxNode syntax, BoundExpression expression)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,43556,43879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,43672,43709);

f_10482_43672_43708(f_10482_43685_43700(expression)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,43723,43868);

return f_10482_43730_43867(syntax, expression, f_10482_43772_43866(this, syntax, f_10482_43804_43819(expression), SpecialMember.System_Nullable_T_get_HasValue));
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,43556,43879);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10482_43685_43700(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 43685, 43700);
return return_v;
}


int
f_10482_43672_43708(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 43672, 43708);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_43804_43819(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 43804, 43819);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10482_43772_43866(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
nullableType,Microsoft.CodeAnalysis.SpecialMember
member)
{
var return_v = this_param.UnsafeGetNullableMethod( syntax, nullableType, member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 43772, 43866);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10482_43730_43867(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 43730, 43867);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,43556,43879);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,43556,43879);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression LowerLiftedBuiltInComparisonOperator(
            SyntaxNode syntax,
            BinaryOperatorKind kind,
            BoundExpression loweredLeft,
            BoundExpression loweredRight)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,43891,50657);
Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator tempAssignmentX = default(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator);
Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator tempAssignmentY = default(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,45086,45207);

BoundExpression? 
optimized = f_10482_45115_45206(this, syntax, kind, loweredLeft, loweredRight, null)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,45221,45308) || true) && (optimized != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,45221,45308);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,45276,45293);

return optimized;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,45221,45308);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,46981,47045);

BoundExpression? 
xNonNull = f_10482_47009_47044(loweredLeft)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,47059,47124);

BoundExpression? 
yNonNull = f_10482_47087_47123(loweredRight)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,47140,47255);

BoundLocal 
boundTempX = f_10482_47164_47254(_factory, xNonNull ??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10482, 47185, 47208)??loweredLeft), out tempAssignmentX)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,47269,47385);

BoundLocal 
boundTempY = f_10482_47293_47384(_factory, yNonNull ??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10482, 47314, 47338)??loweredRight), out tempAssignmentY)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,47401,47494);

BoundExpression 
callX_GetValueOrDefault = f_10482_47443_47493(this, syntax, boundTempX)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,47508,47601);

BoundExpression 
callY_GetValueOrDefault = f_10482_47550_47600(this, syntax, boundTempY)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,47615,47690);

BoundExpression 
callX_HasValue = f_10482_47648_47689(this, syntax, boundTempX)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,47704,47779);

BoundExpression 
callY_HasValue = f_10482_47737_47778(this, syntax, boundTempY)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,47795,47827);

BinaryOperatorKind 
leftOperator
=default(BinaryOperatorKind);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,47841,47874);

BinaryOperatorKind 
rightOperator
=default(BinaryOperatorKind);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,47890,47940);

BinaryOperatorKind 
operatorKind = f_10482_47924_47939(kind)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,47954,48430);

switch (operatorKind)
            {

case BinaryOperatorKind.Equal:
                case BinaryOperatorKind.NotEqual:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,47954,48430);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,48111,48151);

leftOperator = BinaryOperatorKind.Equal;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,48173,48218);

rightOperator = BinaryOperatorKind.BoolEqual;
DynAbs.Tracing.TraceSender.TraceBreak(10482,48240,48246);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,47954,48430);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,47954,48430);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,48294,48322);

leftOperator = operatorKind;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,48344,48387);

rightOperator = BinaryOperatorKind.BoolAnd;
DynAbs.Tracing.TraceSender.TraceBreak(10482,48409,48415);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,47954,48430);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,48446,48524);

TypeSymbol 
boolType = f_10482_48468_48523(_compilation, SpecialType.System_Boolean)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,48613,48949);

BoundExpression 
leftExpression = f_10482_48646_48948(this, syntax: syntax, operatorKind: f_10482_48730_48772(leftOperator, f_10482_48752_48771(kind)), loweredLeft: callX_GetValueOrDefault, loweredRight: callY_GetValueOrDefault, type: boolType, method: null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,49016,49306);

BoundExpression 
rightExpression = f_10482_49050_49305(this, syntax: syntax, operatorKind: rightOperator, loweredLeft: callX_HasValue, loweredRight: callY_HasValue, type: boolType, method: null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,49466,49771);

BoundExpression 
binaryExpression = f_10482_49501_49770(this, syntax: syntax, operatorKind: BinaryOperatorKind.BoolAnd, loweredLeft: leftExpression, loweredRight: rightExpression, type: boolType, method: null)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,49937,50083) || true) && (operatorKind == BinaryOperatorKind.NotEqual)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,49937,50083);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,50018,50068);

binaryExpression = f_10482_50037_50067(_factory, binaryExpression);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,49937,50083);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,50299,50646);

return f_10482_50306_50645(syntax: syntax, locals: f_10482_50383_50465(f_10482_50418_50440(boundTempX), f_10482_50442_50464(boundTempY)), sideEffects: f_10482_50497_50569(tempAssignmentX, tempAssignmentY), value: binaryExpression, type: boolType);
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,43891,50657);

Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_45115_45206(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.TrivialLiftedComparisonOperatorOptimizations( syntax, kind, left, right, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 45115, 45206);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_47009_47044(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableAlwaysHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 47009, 47044);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_47087_47123(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableAlwaysHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 47087, 47123);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10482_47164_47254(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 47164, 47254);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10482_47293_47384(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 47293, 47384);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_47443_47493(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
expression)
{
var return_v = this_param.MakeOptimizedGetValueOrDefault( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 47443, 47493);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_47550_47600(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
expression)
{
var return_v = this_param.MakeOptimizedGetValueOrDefault( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 47550, 47600);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_47648_47689(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
expression)
{
var return_v = this_param.MakeOptimizedHasValue( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 47648, 47689);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_47737_47778(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
expression)
{
var return_v = this_param.MakeOptimizedHasValue( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 47737, 47778);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10482_47924_47939(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.Operator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 47924, 47939);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10482_48468_48523(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 48468, 48523);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10482_48752_48771(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.OperandTypes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 48752, 48771);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10482_48730_48772(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
type)
{
var return_v = kind.WithType( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 48730, 48772);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_48646_48948(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.MakeBinaryOperator( syntax: syntax, operatorKind: operatorKind, loweredLeft: loweredLeft, loweredRight: loweredRight, type: type, method: method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 48646, 48948);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_49050_49305(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.MakeBinaryOperator( syntax: syntax, operatorKind: operatorKind, loweredLeft: loweredLeft, loweredRight: loweredRight, type: type, method: method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 49050, 49305);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_49501_49770(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.MakeBinaryOperator( syntax: syntax, operatorKind: operatorKind, loweredLeft: loweredLeft, loweredRight: loweredRight, type: type, method: method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 49501, 49770);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_50037_50067(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.Not( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 50037, 50067);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10482_50418_50440(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 50418, 50440);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10482_50442_50464(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 50442, 50464);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10482_50383_50465(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item1,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item2)
{
var return_v = ImmutableArray.Create<LocalSymbol>( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 50383, 50465);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10482_50497_50569(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item1,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item2)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item1, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 50497, 50569);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10482_50306_50645(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax: syntax, locals: locals, sideEffects: sideEffects, value: value, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 50306, 50645);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,43891,50657);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,43891,50657);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression LowerLiftedUserDefinedComparisonOperator(
            SyntaxNode syntax,
            BinaryOperatorKind kind,
            BoundExpression loweredLeft,
            BoundExpression loweredRight,
            MethodSymbol? method)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,50669,57814);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,51058,51181);

BoundExpression? 
optimized = f_10482_51087_51180(this, syntax, kind, loweredLeft, loweredRight, method)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,51195,51282) || true) && (optimized != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,51195,51282);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,51250,51267);

return optimized;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,51195,51282);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,53256,53320);

BoundExpression? 
xNonNull = f_10482_53284_53319(loweredLeft)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,53334,53399);

BoundExpression? 
yNonNull = f_10482_53362_53398(loweredRight)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,53950,53990);

BoundAssignmentOperator 
tempAssignmentX
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,54004,54095);

BoundLocal 
boundTempX = f_10482_54028_54094(_factory, xNonNull ??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10482, 54049, 54072)??loweredLeft), out tempAssignmentX)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,54109,54149);

BoundAssignmentOperator 
tempAssignmentY
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,54163,54255);

BoundLocal 
boundTempY = f_10482_54187_54254(_factory, yNonNull ??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10482, 54208, 54232)??loweredRight), out tempAssignmentY)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,54271,54364);

BoundExpression 
callX_GetValueOrDefault = f_10482_54313_54363(this, syntax, boundTempX)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,54378,54471);

BoundExpression 
callY_GetValueOrDefault = f_10482_54420_54470(this, syntax, boundTempY)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,54485,54560);

BoundExpression 
callX_HasValue = f_10482_54518_54559(this, syntax, boundTempX)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,54574,54649);

BoundExpression 
callY_HasValue = f_10482_54607_54648(this, syntax, boundTempY)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,54714,54751);

BinaryOperatorKind 
conditionOperator
=default(BinaryOperatorKind);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,54765,54815);

BinaryOperatorKind 
operatorKind = f_10482_54799_54814(kind)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,54829,55201);

switch (operatorKind)
            {

case BinaryOperatorKind.Equal:
                case BinaryOperatorKind.NotEqual:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,54829,55201);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,54986,55035);

conditionOperator = BinaryOperatorKind.BoolEqual;
DynAbs.Tracing.TraceSender.TraceBreak(10482,55057,55063);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,54829,55201);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,54829,55201);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,55111,55158);

conditionOperator = BinaryOperatorKind.BoolAnd;
DynAbs.Tracing.TraceSender.TraceBreak(10482,55180,55186);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,54829,55201);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,55217,55295);

TypeSymbol 
boolType = f_10482_55239_55294(_compilation, SpecialType.System_Boolean)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,55311,55599);

BoundExpression 
condition = f_10482_55339_55598(this, syntax: syntax, operatorKind: conditionOperator, loweredLeft: callX_HasValue, loweredRight: callY_HasValue, type: boolType, method: null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,55686,55993);

BoundExpression 
unliftedOp = f_10482_55715_55992(this, syntax: syntax, operatorKind: f_10482_55799_55814(kind), loweredLeft: callX_GetValueOrDefault, loweredRight: callY_GetValueOrDefault, type: boolType, method: method)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,56009,56037);

BoundExpression 
consequence
=default(BoundExpression);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,56051,56911) || true) && (operatorKind == BinaryOperatorKind.Equal ||(DynAbs.Tracing.TraceSender.Expression_False(10482, 56055, 56142)||operatorKind == BinaryOperatorKind.NotEqual))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,56051,56911);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,56275,56730);

consequence = f_10482_56289_56729(syntax: syntax, rewrittenCondition: callX_HasValue, rewrittenConsequence: unliftedOp, rewrittenAlternative: f_10482_56509_56602(this, syntax, f_10482_56529_56591(operatorKind == BinaryOperatorKind.Equal), boolType), constantValueOpt: null, rewrittenType: boolType, isRef: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,56051,56911);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,56051,56911);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,56871,56896);

consequence = unliftedOp;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,56051,56911);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,56949,57052);

BoundExpression 
alternative = f_10482_56979_57051(this, syntax, operatorKind == BinaryOperatorKind.NotEqual)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,57068,57435);

BoundExpression 
conditionalExpression = f_10482_57108_57434(syntax: syntax, rewrittenCondition: condition, rewrittenConsequence: consequence, rewrittenAlternative: alternative, constantValueOpt: null, rewrittenType: boolType, isRef: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,57451,57803);

return f_10482_57458_57802(syntax: syntax, locals: f_10482_57535_57617(f_10482_57570_57592(boundTempX), f_10482_57594_57616(boundTempY)), sideEffects: f_10482_57649_57721(tempAssignmentX, tempAssignmentY), value: conditionalExpression, type: boolType);
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,50669,57814);

Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_51087_51180(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.TrivialLiftedComparisonOperatorOptimizations( syntax, kind, left, right, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 51087, 51180);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_53284_53319(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableAlwaysHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 53284, 53319);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_53362_53398(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableAlwaysHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 53362, 53398);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10482_54028_54094(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 54028, 54094);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10482_54187_54254(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 54187, 54254);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_54313_54363(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
expression)
{
var return_v = this_param.MakeOptimizedGetValueOrDefault( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 54313, 54363);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_54420_54470(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
expression)
{
var return_v = this_param.MakeOptimizedGetValueOrDefault( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 54420, 54470);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_54518_54559(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
expression)
{
var return_v = this_param.MakeOptimizedHasValue( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 54518, 54559);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_54607_54648(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
expression)
{
var return_v = this_param.MakeOptimizedHasValue( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 54607, 54648);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10482_54799_54814(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.Operator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 54799, 54814);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10482_55239_55294(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 55239, 55294);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_55339_55598(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.MakeBinaryOperator( syntax: syntax, operatorKind: operatorKind, loweredLeft: loweredLeft, loweredRight: loweredRight, type: type, method: method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 55339, 55598);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10482_55799_55814(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.Unlifted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 55799, 55814);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_55715_55992(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.MakeBinaryOperator( syntax: syntax, operatorKind: operatorKind, loweredLeft: loweredLeft, loweredRight: loweredRight, type: type, method: method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 55715, 55992);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10482_56529_56591(bool
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 56529, 56591);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_56509_56602(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeLiteral( syntax, constantValue, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 56509, 56602);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_56289_56729(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenConsequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenAlternative,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
isRef)
{
var return_v = RewriteConditionalOperator( syntax: syntax, rewrittenCondition: rewrittenCondition, rewrittenConsequence: rewrittenConsequence, rewrittenAlternative: rewrittenAlternative, constantValueOpt: constantValueOpt, rewrittenType: rewrittenType, isRef: isRef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 56289, 56729);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_56979_57051(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,bool
value)
{
var return_v = this_param.MakeBooleanConstant( syntax, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 56979, 57051);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_57108_57434(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenConsequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenAlternative,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
isRef)
{
var return_v = RewriteConditionalOperator( syntax: syntax, rewrittenCondition: rewrittenCondition, rewrittenConsequence: rewrittenConsequence, rewrittenAlternative: rewrittenAlternative, constantValueOpt: constantValueOpt, rewrittenType: rewrittenType, isRef: isRef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 57108, 57434);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10482_57570_57592(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 57570, 57592);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10482_57594_57616(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 57594, 57616);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10482_57535_57617(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item1,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item2)
{
var return_v = ImmutableArray.Create<LocalSymbol>( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 57535, 57617);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10482_57649_57721(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item1,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item2)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item1, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 57649, 57721);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10482_57458_57802(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax: syntax, locals: locals, sideEffects: sideEffects, value: value, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 57458, 57802);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,50669,57814);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,50669,57814);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression? TrivialLiftedBinaryArithmeticOptimizations(
            SyntaxNode syntax,
            BinaryOperatorKind kind,
            BoundExpression left,
            BoundExpression right,
            TypeSymbol type,
            MethodSymbol? method)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,57826,59310);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,58261,58288);

f_10482_58261_58287(left != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,58302,58330);

f_10482_58302_58329(right != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,58499,58549);

bool 
leftAlwaysNull = f_10482_58521_58548(left)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,58563,58615);

bool 
rightAlwaysNull = f_10482_58586_58614(right)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,58631,58797) || true) && (leftAlwaysNull &&(DynAbs.Tracing.TraceSender.Expression_True(10482, 58635, 58668)&&rightAlwaysNull))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,58631,58797);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,58734,58782);

return f_10482_58741_58781(syntax, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,58631,58797);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,58925,58985);

BoundExpression? 
leftNonNull = f_10482_58956_58984(left)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,58999,59061);

BoundExpression? 
rightNonNull = f_10482_59031_59060(right)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,59077,59271) || true) && (leftNonNull != null &&(DynAbs.Tracing.TraceSender.Expression_True(10482, 59081, 59124)&&rightNonNull != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,59077,59271);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,59158,59256);

return f_10482_59165_59255(this, syntax, kind, leftNonNull, rightNonNull, type, method);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,59077,59271);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,59287,59299);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,57826,59310);

int
f_10482_58261_58287(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 58261, 58287);
return 0;
}


int
f_10482_58302_58329(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 58302, 58329);
return 0;
}


bool
f_10482_58521_58548(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableNeverHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 58521, 58548);
return return_v;
}


bool
f_10482_58586_58614(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableNeverHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 58586, 58614);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
f_10482_58741_58781(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression( syntax, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 58741, 58781);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_58956_58984(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableAlwaysHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 58956, 58984);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_59031_59060(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableAlwaysHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 59031, 59060);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_59165_59255(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.MakeLiftedBinaryOperatorConsequence( syntax, kind, left, right, type, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 59165, 59255);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,57826,59310);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,57826,59310);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeLiftedBinaryOperatorConsequence(
            SyntaxNode syntax,
            BinaryOperatorKind kind,
            BoundExpression left,
            BoundExpression right,
            TypeSymbol type,
            MethodSymbol? method)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,59322,60273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,59684,59978);

BoundExpression 
unliftedOp = f_10482_59713_59977(this, syntax: syntax, operatorKind: f_10482_59797_59812(kind), loweredLeft: left, loweredRight: right, type: f_10482_59911_59943(type), method: method)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,60071,60262);

return f_10482_60078_60261(syntax, f_10482_60155_60231(this, syntax, type, SpecialMember.System_Nullable_T__ctor), unliftedOp);
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,59322,60273);

Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10482_59797_59812(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.Unlifted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 59797, 59812);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_59911_59943(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.GetNullableUnderlyingType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 59911, 59943);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_59713_59977(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.MakeBinaryOperator( syntax: syntax, operatorKind: operatorKind, loweredLeft: loweredLeft, loweredRight: loweredRight, type: type, method: method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 59713, 59977);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10482_60155_60231(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
nullableType,Microsoft.CodeAnalysis.SpecialMember
member)
{
var return_v = this_param.UnsafeGetNullableMethod( syntax, nullableType, member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 60155, 60231);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
f_10482_60078_60261(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
constructor,params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
arguments)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression( syntax, constructor, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 60078, 60261);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,59322,60273);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,59322,60273);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static BoundExpression? OptimizeLiftedArithmeticOperatorOneNull(
            SyntaxNode syntax,
            BoundExpression left,
            BoundExpression right,
            TypeSymbol type)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10482,60285,62081);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,60814,60864);

bool 
leftAlwaysNull = f_10482_60836_60863(left)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,60878,60930);

bool 
rightAlwaysNull = f_10482_60901_60929(right)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,60946,60997);

f_10482_60946_60996(!(leftAlwaysNull &&(DynAbs.Tracing.TraceSender.Expression_True(10482, 60961, 60994)&&rightAlwaysNull)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,61051,61152) || true) && (!(leftAlwaysNull ||(DynAbs.Tracing.TraceSender.Expression_False(10482, 61057, 61090)||rightAlwaysNull)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,61051,61152);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,61125,61137);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,61051,61152);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,61168,61230);

BoundExpression 
notAlwaysNull = (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 61200, 61214)||((leftAlwaysNull &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 61217, 61222))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 61225, 61229)))?right :left
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,61244,61311);

BoundExpression? 
neverNull = f_10482_61273_61310(notAlwaysNull)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,61325,61381);

BoundExpression 
sideEffect = neverNull ??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10482, 61354, 61380)??notAlwaysNull)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,61625,61758) || true) && (f_10482_61629_61653(sideEffect)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,61625,61758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,61695,61743);

return f_10482_61702_61742(syntax, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,61625,61758);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,61774,62070);

return f_10482_61781_62069(syntax: syntax, locals: ImmutableArray<LocalSymbol>.Empty, sideEffects: f_10482_61923_61973(sideEffect), value: f_10482_61999_62039(syntax, type), type: type);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10482,60285,62081);

bool
f_10482_60836_60863(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableNeverHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 60836, 60863);
return return_v;
}


bool
f_10482_60901_60929(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableNeverHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 60901, 60929);
return return_v;
}


int
f_10482_60946_60996(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 60946, 60996);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_61273_61310(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableAlwaysHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 61273, 61310);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10482_61629_61653(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 61629, 61653);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
f_10482_61702_61742(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression( syntax, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 61702, 61742);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10482_61923_61973(Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 61923, 61973);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
f_10482_61999_62039(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression( syntax, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 61999, 62039);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10482_61781_62069(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax: syntax, locals: locals, sideEffects: sideEffects, value: (Microsoft.CodeAnalysis.CSharp.BoundExpression)value, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 61781, 62069);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,60285,62081);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,60285,62081);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression LowerLiftedBinaryArithmeticOperator(
            SyntaxNode syntax,
            BinaryOperatorKind kind,
            BoundExpression loweredLeft,
            BoundExpression loweredRight,
            TypeSymbol type,
            MethodSymbol? method)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,62093,66191);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,62634,62749);

BoundExpression? 
optimized = f_10482_62663_62748(this, syntax, kind, loweredLeft, loweredRight, type, method)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,62763,62850) || true) && (optimized != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,62763,62850);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,62818,62835);

return optimized;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,62763,62850);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,63686,63748);

var 
sideeffects = f_10482_63704_63747()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,63762,63815);

var 
locals = f_10482_63775_63814()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,63831,63900);

BoundExpression? 
leftNeverNull = f_10482_63864_63899(loweredLeft)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,63914,63985);

BoundExpression? 
rightNeverNull = f_10482_63948_63984(loweredRight)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,64001,64059);

BoundExpression 
boundTempX = leftNeverNull ??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10482, 64030, 64058)??loweredLeft)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,64073,64151);

boundTempX = f_10482_64086_64150(this, boundTempX, sideeffects, locals);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,64167,64227);

BoundExpression 
boundTempY = rightNeverNull ??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10482, 64196, 64226)??loweredRight)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,64241,64319);

boundTempY = f_10482_64254_64318(this, boundTempY, sideeffects, locals);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,64335,64428);

BoundExpression 
callX_GetValueOrDefault = f_10482_64377_64427(this, syntax, boundTempX)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,64442,64535);

BoundExpression 
callY_GetValueOrDefault = f_10482_64484_64534(this, syntax, boundTempY)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,64549,64624);

BoundExpression 
callX_HasValue = f_10482_64582_64623(this, syntax, boundTempX)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,64638,64713);

BoundExpression 
callY_HasValue = f_10482_64671_64712(this, syntax, boundTempY)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,64777,64855);

TypeSymbol 
boolType = f_10482_64799_64854(_compilation, SpecialType.System_Boolean)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,64869,65000);

BoundExpression 
condition = f_10482_64897_64999(this, syntax, BinaryOperatorKind.BoolAnd, callX_HasValue, callY_HasValue, boolType, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,65093,65237);

BoundExpression 
consequence = f_10482_65123_65236(this, syntax, kind, callX_GetValueOrDefault, callY_GetValueOrDefault, type, method)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,65281,65352);

BoundExpression 
alternative = f_10482_65311_65351(syntax, type)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,65548,65911);

BoundExpression 
conditionalExpression = f_10482_65588_65910(syntax: syntax, rewrittenCondition: condition, rewrittenConsequence: consequence, rewrittenAlternative: alternative, constantValueOpt: null, rewrittenType: type, isRef: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,65927,66180);

return f_10482_65934_66179(syntax: syntax, locals: f_10482_66011_66038(locals), sideEffects: f_10482_66070_66102(sideeffects), value: conditionalExpression, type: type);
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,62093,66191);

Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_62663_62748(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.OptimizeLiftedBinaryArithmetic( syntax, kind, left, right, type, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 62663, 62748);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10482_63704_63747()
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 63704, 63747);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10482_63775_63814()
{
var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 63775, 63814);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_63864_63899(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableAlwaysHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 63864, 63899);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_63948_63984(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableAlwaysHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 63948, 63984);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_64086_64150(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
operand,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideeffects,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals)
{
var return_v = this_param.CaptureExpressionInTempIfNeeded( operand, sideeffects, locals);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 64086, 64150);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_64254_64318(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
operand,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideeffects,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals)
{
var return_v = this_param.CaptureExpressionInTempIfNeeded( operand, sideeffects, locals);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 64254, 64318);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_64377_64427(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.MakeOptimizedGetValueOrDefault( syntax, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 64377, 64427);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_64484_64534(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.MakeOptimizedGetValueOrDefault( syntax, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 64484, 64534);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_64582_64623(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.MakeOptimizedHasValue( syntax, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 64582, 64623);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_64671_64712(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.MakeOptimizedHasValue( syntax, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 64671, 64712);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10482_64799_64854(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 64799, 64854);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_64897_64999(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.MakeBinaryOperator( syntax, operatorKind, loweredLeft, loweredRight, type, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 64897, 64999);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_65123_65236(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.MakeLiftedBinaryOperatorConsequence( syntax, kind, left, right, type, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 65123, 65236);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
f_10482_65311_65351(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression( syntax, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 65311, 65351);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_65588_65910(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenConsequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenAlternative,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
isRef)
{
var return_v = RewriteConditionalOperator( syntax: syntax, rewrittenCondition: rewrittenCondition, rewrittenConsequence: rewrittenConsequence, rewrittenAlternative: rewrittenAlternative, constantValueOpt: constantValueOpt, rewrittenType: rewrittenType, isRef: isRef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 65588, 65910);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10482_66011_66038(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 66011, 66038);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10482_66070_66102(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 66070, 66102);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10482_65934_66179(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax: syntax, locals: locals, sideEffects: sideEffects, value: value, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 65934, 66179);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,62093,66191);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,62093,66191);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression CaptureExpressionInTempIfNeeded(
            BoundExpression operand,
            ArrayBuilder<BoundExpression> sideeffects,
            ArrayBuilder<LocalSymbol> locals,
            SynthesizedLocalKind kind = SynthesizedLocalKind.LoweringTemp)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,66203,66909);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,66501,66867) || true) && (f_10482_66505_66540(operand))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,66501,66867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,66574,66613);

BoundAssignmentOperator 
tempAssignment
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,66631,66710);

var 
tempAccess = f_10482_66648_66709(_factory, operand, out tempAssignment, kind: kind)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,66728,66760);

f_10482_66728_66759(                sideeffects, tempAssignment);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,66778,66813);

f_10482_66778_66812(                locals, f_10482_66789_66811(tempAccess));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,66831,66852);

operand = tempAccess;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,66501,66867);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,66883,66898);

return operand;
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,66203,66909);

bool
f_10482_66505_66540(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = CanChangeValueBetweenReads( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 66505, 66540);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10482_66648_66709(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store,Microsoft.CodeAnalysis.SynthesizedLocalKind
kind)
{
var return_v = this_param.StoreToTemp( argument, out store, kind: kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 66648, 66709);
return return_v;
}


int
f_10482_66728_66759(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 66728, 66759);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10482_66789_66811(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 66789, 66811);
return return_v;
}


int
f_10482_66778_66812(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 66778, 66812);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,66203,66909);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,66203,66909);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression? OptimizeLiftedBinaryArithmetic(
            SyntaxNode syntax,
            BinaryOperatorKind kind,
            BoundExpression left,
            BoundExpression right,
            TypeSymbol type,
            MethodSymbol? method)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,66921,73992);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,67208,67321);

BoundExpression? 
optimized = f_10482_67237_67320(this, syntax, kind, left, right, type, method)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,67335,67422) || true) && (optimized != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,67335,67422);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,67390,67407);

return optimized;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,67335,67422);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,67536,67733) || true) && (kind == BinaryOperatorKind.LiftedBoolAnd ||(DynAbs.Tracing.TraceSender.Expression_False(10482, 67540, 67623)||kind == BinaryOperatorKind.LiftedBoolOr))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,67536,67733);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,67657,67718);

return f_10482_67664_67717(this, syntax, kind, left, right);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,67536,67733);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,67843,67922);

optimized = f_10482_67855_67921(syntax, left, right, type);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,67936,68023) || true) && (optimized != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,67936,68023);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,67991,68008);

return optimized;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,67936,68023);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,72170,72232);

BoundExpression? 
nonNullRight = f_10482_72202_72231(right)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,72246,73953) || true) && (nonNullRight != null &&(DynAbs.Tracing.TraceSender.Expression_True(10482, 72250, 72308)&&f_10482_72274_72300(nonNullRight)!= null )&&(DynAbs.Tracing.TraceSender.Expression_True(10482, 72250, 72343)&&f_10482_72312_72321(left)== BoundKind.Sequence))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,72246,73953);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,72377,72417);

BoundSequence 
seq = (BoundSequence)left
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,72435,73938) || true) && (f_10482_72439_72453(f_10482_72439_72448(seq))== BoundKind.ConditionalOperator)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,72435,73938);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,72528,72603);

BoundConditionalOperator 
conditional = (BoundConditionalOperator)f_10482_72593_72602(seq)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,72625,72722);

f_10482_72625_72721(f_10482_72638_72720(f_10482_72656_72664(seq), f_10482_72666_72682(conditional), TypeCompareKind.ConsiderEverything2));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,72744,72861);

f_10482_72744_72860(f_10482_72757_72859(f_10482_72775_72791(conditional), f_10482_72793_72821(f_10482_72793_72816(conditional)), TypeCompareKind.ConsiderEverything2));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,72883,73000);

f_10482_72883_72999(f_10482_72896_72998(f_10482_72914_72930(conditional), f_10482_72932_72960(f_10482_72932_72955(conditional)), TypeCompareKind.ConsiderEverything2));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,73024,73919) || true) && (f_10482_73028_73075(f_10482_73051_73074(conditional))!= null &&(DynAbs.Tracing.TraceSender.Expression_True(10482, 73028, 73133)&&f_10482_73087_73133(f_10482_73109_73132(conditional))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,73024,73919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,73183,73896);

return f_10482_73190_73895(syntax, f_10482_73275_73285(seq), f_10482_73316_73331(seq), f_10482_73362_73859(syntax, f_10482_73464_73485(conditional), f_10482_73520_73598(this, syntax, kind, f_10482_73553_73576(conditional), right, type, method), f_10482_73633_73711(this, syntax, kind, f_10482_73666_73689(conditional), right, type, method), ConstantValue.NotAvailable, type, isRef: false), type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,73024,73919);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,72435,73938);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,72246,73953);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,73969,73981);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,66921,73992);

Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_67237_67320(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.TrivialLiftedBinaryArithmeticOptimizations( syntax, kind, left, right, type, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 67237, 67320);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_67664_67717(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight)
{
var return_v = this_param.LowerLiftedBooleanOperator( syntax, kind, loweredLeft, loweredRight);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 67664, 67717);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_67855_67921(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = OptimizeLiftedArithmeticOperatorOneNull( syntax, left, right, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 67855, 67921);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_72202_72231(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableAlwaysHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 72202, 72231);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10482_72274_72300(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 72274, 72300);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10482_72312_72321(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 72312, 72321);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_72439_72448(Microsoft.CodeAnalysis.CSharp.BoundSequence
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 72439, 72448);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10482_72439_72453(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 72439, 72453);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_72593_72602(Microsoft.CodeAnalysis.CSharp.BoundSequence
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 72593, 72602);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_72656_72664(Microsoft.CodeAnalysis.CSharp.BoundSequence
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 72656, 72664);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_72666_72682(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 72666, 72682);
return return_v;
}


bool
f_10482_72638_72720(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
left,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 72638, 72720);
return return_v;
}


int
f_10482_72625_72721(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 72625, 72721);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_72775_72791(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 72775, 72791);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_72793_72816(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Consequence;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 72793, 72816);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10482_72793_72821(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 72793, 72821);
return return_v;
}


bool
f_10482_72757_72859(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
left,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 72757, 72859);
return return_v;
}


int
f_10482_72744_72860(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 72744, 72860);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_72914_72930(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 72914, 72930);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_72932_72955(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Alternative;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 72932, 72955);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10482_72932_72960(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 72932, 72960);
return return_v;
}


bool
f_10482_72896_72998(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
left,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 72896, 72998);
return return_v;
}


int
f_10482_72883_72999(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 72883, 72999);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_73051_73074(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Consequence;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 73051, 73074);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_73028_73075(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableAlwaysHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 73028, 73075);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_73109_73132(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Alternative;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 73109, 73132);
return return_v;
}


bool
f_10482_73087_73133(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableNeverHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 73087, 73133);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10482_73275_73285(Microsoft.CodeAnalysis.CSharp.BoundSequence
this_param)
{
var return_v = this_param.Locals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 73275, 73285);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10482_73316_73331(Microsoft.CodeAnalysis.CSharp.BoundSequence
this_param)
{
var return_v = this_param.SideEffects;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 73316, 73331);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_73464_73485(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Condition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 73464, 73485);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_73553_73576(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Consequence;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 73553, 73576);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_73520_73598(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.MakeBinaryOperator( syntax, operatorKind, loweredLeft, loweredRight, type, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 73520, 73598);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_73666_73689(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Alternative;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 73666, 73689);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_73633_73711(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.MakeBinaryOperator( syntax, operatorKind, loweredLeft, loweredRight, type, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 73633, 73711);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_73362_73859(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenConsequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenAlternative,Microsoft.CodeAnalysis.ConstantValue
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
isRef)
{
var return_v = RewriteConditionalOperator( syntax, rewrittenCondition, rewrittenConsequence, rewrittenAlternative, constantValueOpt, rewrittenType, isRef: isRef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 73362, 73859);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10482_73190_73895(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax, locals, sideEffects, value, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 73190, 73895);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,66921,73992);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,66921,73992);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeNewNullableBoolean(SyntaxNode syntax, bool? value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,74004,74785);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,74107,74197);

NamedTypeSymbol 
nullableType = f_10482_74138_74196(_compilation, SpecialType.System_Nullable_T)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,74211,74289);

TypeSymbol 
boolType = f_10482_74233_74288(_compilation, SpecialType.System_Boolean)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,74303,74371);

NamedTypeSymbol 
nullableBoolType = f_10482_74338_74370(nullableType, boolType)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,74385,74511) || true) && (value == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,74385,74511);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,74436,74496);

return f_10482_74443_74495(syntax, nullableBoolType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,74385,74511);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,74527,74774);

return f_10482_74534_74773(syntax, f_10482_74611_74699(this, syntax, nullableBoolType, SpecialMember.System_Nullable_T__ctor), f_10482_74718_74772(this, syntax, f_10482_74746_74771(value)));
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,74004,74785);

Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10482_74138_74196(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 74138, 74196);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10482_74233_74288(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 74233, 74288);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10482_74338_74370(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param,params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
typeArguments)
{
var return_v = this_param.Construct( typeArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 74338, 74370);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
f_10482_74443_74495(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 74443, 74495);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10482_74611_74699(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
nullableType,Microsoft.CodeAnalysis.SpecialMember
member)
{
var return_v = this_param.UnsafeGetNullableMethod( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)nullableType, member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 74611, 74699);
return return_v;
}


bool
f_10482_74746_74771(bool?
this_param)
{
var return_v = this_param.GetValueOrDefault();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 74746, 74771);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_74718_74772(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,bool
value)
{
var return_v = this_param.MakeBooleanConstant( syntax, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 74718, 74772);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
f_10482_74534_74773(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
constructor,params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
arguments)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression( syntax, constructor, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 74534, 74773);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,74004,74785);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,74004,74785);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression? OptimizeLiftedBooleanOperatorOneNull(
            SyntaxNode syntax,
            BinaryOperatorKind kind,
            BoundExpression left,
            BoundExpression right)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,74797,78661);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,75106,75156);

bool 
leftAlwaysNull = f_10482_75128_75155(left)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,75170,75222);

bool 
rightAlwaysNull = f_10482_75193_75221(right)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,75238,75289);

f_10482_75238_75288(!(leftAlwaysNull &&(DynAbs.Tracing.TraceSender.Expression_True(10482, 75253, 75286)&&rightAlwaysNull)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,75343,75444) || true) && (!(leftAlwaysNull ||(DynAbs.Tracing.TraceSender.Expression_False(10482, 75349, 75382)||rightAlwaysNull)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,75343,75444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,75417,75429);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,75343,75444);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,75930,75989);

BoundExpression 
alwaysNull = (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 75959, 75973)||((leftAlwaysNull &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 75976, 75980))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 75983, 75988)))?left :right
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,76003,76065);

BoundExpression 
notAlwaysNull = (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 76035, 76049)||((leftAlwaysNull &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 76052, 76057))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 76060, 76064)))?right :left
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,76079,76146);

BoundExpression? 
neverNull = f_10482_76108_76145(notAlwaysNull)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,76160,76197);

f_10482_76160_76196(f_10482_76173_76188(alwaysNull)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,76211,76290);

BoundExpression 
nullBool = f_10482_76238_76289(syntax, f_10482_76273_76288(alwaysNull))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,76306,76975) || true) && (neverNull != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,76306,76975);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,76361,76463);

BoundExpression 
newNullBool = f_10482_76391_76462(this, syntax, kind == BinaryOperatorKind.LiftedBoolOr)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,76483,76960);

return f_10482_76490_76959(syntax: syntax, rewrittenCondition: neverNull, rewrittenConsequence: (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 76650, 76690)||((kind == BinaryOperatorKind.LiftedBoolAnd &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 76693, 76701))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 76704, 76715)))?nullBool :newNullBool, rewrittenAlternative: (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 76760, 76800)||((kind == BinaryOperatorKind.LiftedBoolAnd &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 76803, 76814))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 76817, 76825)))?newNullBool :nullBool, constantValueOpt: null, rewrittenType: f_10482_76908_76923(alwaysNull), isRef: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,76306,76975);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,77419,77458);

BoundAssignmentOperator 
tempAssignment
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,77472,77551);

BoundLocal 
boundTemp = f_10482_77495_77550(_factory, notAlwaysNull, out tempAssignment)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,77565,77643);

BoundExpression 
condition = f_10482_77593_77642(this, syntax, boundTemp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,77657,77751);

BoundExpression 
consequence = (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 77687, 77727)||((kind == BinaryOperatorKind.LiftedBoolAnd &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 77730, 77738))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 77741, 77750)))?nullBool :boundTemp
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,77765,77859);

BoundExpression 
alternative = (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 77795, 77835)||((kind == BinaryOperatorKind.LiftedBoolAnd &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 77838, 77847))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 77850, 77858)))?boundTemp :nullBool
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,77873,78247);

BoundExpression 
conditionalExpression = f_10482_77913_78246(syntax: syntax, rewrittenCondition: condition, rewrittenConsequence: consequence, rewrittenAlternative: alternative, constantValueOpt: null, rewrittenType: f_10482_78199_78214(alwaysNull), isRef: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,78261,78309);

f_10482_78261_78308(f_10482_78274_78300(conditionalExpression)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,78323,78650);

return f_10482_78330_78649(syntax: syntax, locals: f_10482_78407_78464(f_10482_78442_78463(boundTemp)), sideEffects: f_10482_78496_78550(tempAssignment), value: conditionalExpression, type: f_10482_78622_78648(conditionalExpression));
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,74797,78661);

bool
f_10482_75128_75155(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableNeverHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 75128, 75155);
return return_v;
}


bool
f_10482_75193_75221(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableNeverHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 75193, 75221);
return return_v;
}


int
f_10482_75238_75288(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 75238, 75288);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_76108_76145(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableAlwaysHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 76108, 76145);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10482_76173_76188(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 76173, 76188);
return return_v;
}


int
f_10482_76160_76196(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 76160, 76196);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_76273_76288(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 76273, 76288);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
f_10482_76238_76289(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression( syntax, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 76238, 76289);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_76391_76462(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,bool
value)
{
var return_v = this_param.MakeNewNullableBoolean( syntax, (bool?)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 76391, 76462);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_76908_76923(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 76908, 76923);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_76490_76959(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenConsequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenAlternative,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
isRef)
{
var return_v = RewriteConditionalOperator( syntax: syntax, rewrittenCondition: rewrittenCondition, rewrittenConsequence: rewrittenConsequence, rewrittenAlternative: rewrittenAlternative, constantValueOpt: constantValueOpt, rewrittenType: rewrittenType, isRef: isRef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 76490, 76959);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10482_77495_77550(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 77495, 77550);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_77593_77642(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
expression)
{
var return_v = this_param.MakeOptimizedGetValueOrDefault( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 77593, 77642);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_78199_78214(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 78199, 78214);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_77913_78246(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenConsequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenAlternative,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
isRef)
{
var return_v = RewriteConditionalOperator( syntax: syntax, rewrittenCondition: rewrittenCondition, rewrittenConsequence: rewrittenConsequence, rewrittenAlternative: rewrittenAlternative, constantValueOpt: constantValueOpt, rewrittenType: rewrittenType, isRef: isRef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 77913, 78246);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10482_78274_78300(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 78274, 78300);
return return_v;
}


int
f_10482_78261_78308(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 78261, 78308);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10482_78442_78463(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 78442, 78463);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10482_78407_78464(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
var return_v = ImmutableArray.Create<LocalSymbol>( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 78407, 78464);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10482_78496_78550(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 78496, 78550);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_78622_78648(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 78622, 78648);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10482_78330_78649(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax: syntax, locals: locals, sideEffects: sideEffects, value: value, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 78330, 78649);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,74797,78661);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,74797,78661);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression? OptimizeLiftedBooleanOperatorOneNonNull(
            SyntaxNode syntax,
            BinaryOperatorKind kind,
            BoundExpression left,
            BoundExpression right)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,78673,81841);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,79542,79602);

BoundExpression? 
leftNonNull = f_10482_79573_79601(left)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,79616,79678);

BoundExpression? 
rightNonNull = f_10482_79648_79677(right)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,79694,79752);

f_10482_79694_79751(leftNonNull == null ||(DynAbs.Tracing.TraceSender.Expression_False(10482, 79707, 79750)||rightNonNull == null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,79832,79908);

f_10482_79832_79907(!f_10482_79846_79873(left)&&(DynAbs.Tracing.TraceSender.Expression_True(10482, 79845, 79906)&&!f_10482_79878_79906(right)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,79979,80087) || true) && (leftNonNull == null &&(DynAbs.Tracing.TraceSender.Expression_True(10482, 79983, 80026)&&rightNonNull == null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,79979,80087);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,80060,80072);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,79979,80087);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,80177,80217);

BoundAssignmentOperator 
tempAssignmentX
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,80231,80318);

BoundLocal 
boundTempX = f_10482_80255_80317(_factory, leftNonNull ??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10482, 80276, 80295)??left), out tempAssignmentX)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,80332,80372);

BoundAssignmentOperator 
tempAssignmentY
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,80386,80475);

BoundLocal 
boundTempY = f_10482_80410_80474(_factory, rightNonNull ??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10482, 80431, 80452)??right), out tempAssignmentY)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,80489,80565);

BoundExpression 
nonNullTemp = (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 80519, 80538)||((leftNonNull == null &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 80541, 80551))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 80554, 80564)))?boundTempY :boundTempX
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,80579,80657);

BoundExpression 
maybeNullTemp = (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 80611, 80630)||((leftNonNull == null &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 80633, 80643))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 80646, 80656)))?boundTempX :boundTempY
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,80671,80711);

BoundExpression 
condition = nonNullTemp
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,80725,80827);

BoundExpression 
newNullBool = f_10482_80755_80826(this, syntax, kind == BinaryOperatorKind.LiftedBoolOr)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,80841,80941);

BoundExpression 
consequence = (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 80871, 80910)||((kind == BinaryOperatorKind.LiftedBoolOr &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 80913, 80924))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 80927, 80940)))?newNullBool :maybeNullTemp
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,80955,81055);

BoundExpression 
alternative = (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 80985, 81024)||((kind == BinaryOperatorKind.LiftedBoolOr &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 81027, 81040))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 81043, 81054)))?maybeNullTemp :newNullBool
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,81069,81445);

BoundExpression 
conditionalExpression = f_10482_81109_81444(syntax: syntax, rewrittenCondition: condition, rewrittenConsequence: consequence, rewrittenAlternative: alternative, constantValueOpt: null, rewrittenType: newNullBool.Type!, isRef: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,81459,81830);

return f_10482_81466_81829(syntax: syntax, locals: f_10482_81543_81625(f_10482_81578_81600(boundTempX), f_10482_81602_81624(boundTempY)), sideEffects: f_10482_81657_81729(tempAssignmentX, tempAssignmentY), value: conditionalExpression, type: conditionalExpression.Type!);
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,78673,81841);

Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_79573_79601(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableAlwaysHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 79573, 79601);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_79648_79677(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableAlwaysHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 79648, 79677);
return return_v;
}


int
f_10482_79694_79751(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 79694, 79751);
return 0;
}


bool
f_10482_79846_79873(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableNeverHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 79846, 79873);
return return_v;
}


bool
f_10482_79878_79906(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableNeverHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 79878, 79906);
return return_v;
}


int
f_10482_79832_79907(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 79832, 79907);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10482_80255_80317(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 80255, 80317);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10482_80410_80474(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 80410, 80474);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_80755_80826(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,bool
value)
{
var return_v = this_param.MakeNewNullableBoolean( syntax, (bool?)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 80755, 80826);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_81109_81444(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenConsequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenAlternative,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
isRef)
{
var return_v = RewriteConditionalOperator( syntax: syntax, rewrittenCondition: rewrittenCondition, rewrittenConsequence: rewrittenConsequence, rewrittenAlternative: rewrittenAlternative, constantValueOpt: constantValueOpt, rewrittenType, isRef: isRef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 81109, 81444);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10482_81578_81600(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 81578, 81600);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10482_81602_81624(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 81602, 81624);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10482_81543_81625(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item1,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item2)
{
var return_v = ImmutableArray.Create<LocalSymbol>( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 81543, 81625);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10482_81657_81729(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item1,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item2)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item1, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 81657, 81729);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10482_81466_81829(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax: syntax, locals: locals, sideEffects: sideEffects, value: value, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 81466, 81829);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,78673,81841);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,78673,81841);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression LowerLiftedBooleanOperator(
            SyntaxNode syntax,
            BinaryOperatorKind kind,
            BoundExpression loweredLeft,
            BoundExpression loweredRight)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,81853,86342);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,82379,82486);

BoundExpression? 
optimized = f_10482_82408_82485(this, syntax, kind, loweredLeft, loweredRight)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,82500,82587) || true) && (optimized != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,82500,82587);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,82555,82572);

return optimized;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,82500,82587);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,82603,82696);

optimized = f_10482_82615_82695(this, syntax, kind, loweredLeft, loweredRight);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,82710,82797) || true) && (optimized != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,82710,82797);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,82765,82782);

return optimized;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,82710,82797);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,83234,83274);

BoundAssignmentOperator 
tempAssignmentX
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,83288,83367);

BoundLocal 
boundTempX = f_10482_83312_83366(_factory, loweredLeft, out tempAssignmentX)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,83381,83421);

BoundAssignmentOperator 
tempAssignmentY
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,83435,83515);

BoundLocal 
boundTempY = f_10482_83459_83514(_factory, loweredRight, out tempAssignmentY)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,83531,83609);

TypeSymbol 
boolType = f_10482_83553_83608(_compilation, SpecialType.System_Boolean)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,83625,83759);

MethodSymbol 
getValueOrDefaultX = f_10482_83659_83758(this, syntax, f_10482_83691_83706(boundTempX), SpecialMember.System_Nullable_T_GetValueOrDefault)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,83773,83907);

MethodSymbol 
getValueOrDefaultY = f_10482_83807_83906(this, syntax, f_10482_83839_83854(boundTempY), SpecialMember.System_Nullable_T_GetValueOrDefault)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,83965,84069);

BoundExpression 
callX_GetValueOrDefault = f_10482_84007_84068(syntax, boundTempX, getValueOrDefaultX)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,84125,84229);

BoundExpression 
callY_GetValueOrDefault = f_10482_84167_84228(syntax, boundTempY, getValueOrDefaultY)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,84274,84348);

BoundExpression 
callX_HasValue = f_10482_84307_84347(this, syntax, boundTempX)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,84424,84734);

BoundExpression 
innerOr = f_10482_84450_84733(this, syntax: syntax, operatorKind: BinaryOperatorKind.LogicalBoolOr, loweredLeft: callY_GetValueOrDefault, loweredRight: callX_HasValue, type: boolType, method: null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,84811,84926);

BoundExpression 
invert = f_10482_84836_84925(this, UnaryOperatorKind.BoolLogicalNegation, syntax, null, innerOr, boolType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,85024,85328);

BoundExpression 
condition = f_10482_85052_85327(this, syntax: syntax, operatorKind: BinaryOperatorKind.LogicalBoolOr, loweredLeft: callX_GetValueOrDefault, loweredRight: invert, type: boolType, method: null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,85344,85441);

BoundExpression 
consequence = (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 85374, 85414)||((kind == BinaryOperatorKind.LiftedBoolAnd &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 85417, 85427))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 85430, 85440)))?boundTempY :boundTempX
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,85455,85552);

BoundExpression 
alternative = (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 85485, 85525)||((kind == BinaryOperatorKind.LiftedBoolAnd &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 85528, 85538))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 85541, 85551)))?boundTempX :boundTempY
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,85568,85944);

BoundExpression 
conditionalExpression = f_10482_85608_85943(syntax: syntax, rewrittenCondition: condition, rewrittenConsequence: consequence, rewrittenAlternative: alternative, constantValueOpt: null, rewrittenType: alternative.Type!, isRef: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,85960,86331);

return f_10482_85967_86330(syntax: syntax, locals: f_10482_86044_86126(f_10482_86079_86101(boundTempX), f_10482_86103_86125(boundTempY)), sideEffects: f_10482_86158_86230(tempAssignmentX, tempAssignmentY), value: conditionalExpression, type: conditionalExpression.Type!);
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,81853,86342);

Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_82408_82485(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.OptimizeLiftedBooleanOperatorOneNull( syntax, kind, left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 82408, 82485);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_82615_82695(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.OptimizeLiftedBooleanOperatorOneNonNull( syntax, kind, left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 82615, 82695);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10482_83312_83366(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 83312, 83366);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10482_83459_83514(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 83459, 83514);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10482_83553_83608(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 83553, 83608);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_83691_83706(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 83691, 83706);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10482_83659_83758(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
nullableType,Microsoft.CodeAnalysis.SpecialMember
member)
{
var return_v = this_param.UnsafeGetNullableMethod( syntax, nullableType, member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 83659, 83758);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_83839_83854(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 83839, 83854);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10482_83807_83906(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
nullableType,Microsoft.CodeAnalysis.SpecialMember
member)
{
var return_v = this_param.UnsafeGetNullableMethod( syntax, nullableType, member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 83807, 83906);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10482_84007_84068(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = BoundCall.Synthesized( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 84007, 84068);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10482_84167_84228(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = BoundCall.Synthesized( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 84167, 84228);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_84307_84347(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
expression)
{
var return_v = this_param.MakeNullableHasValue( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 84307, 84347);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_84450_84733(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.MakeBinaryOperator( syntax: syntax, operatorKind: operatorKind, loweredLeft: loweredLeft, loweredRight: loweredRight, type: type, method: method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 84450, 84733);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_84836_84925(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeUnaryOperator( kind, syntax, method, loweredOperand, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 84836, 84925);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_85052_85327(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.MakeBinaryOperator( syntax: syntax, operatorKind: operatorKind, loweredLeft: loweredLeft, loweredRight: loweredRight, type: type, method: method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 85052, 85327);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_85608_85943(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenConsequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenAlternative,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
isRef)
{
var return_v = RewriteConditionalOperator( syntax: syntax, rewrittenCondition: rewrittenCondition, rewrittenConsequence: rewrittenConsequence, rewrittenAlternative: rewrittenAlternative, constantValueOpt: constantValueOpt, rewrittenType, isRef: isRef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 85608, 85943);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10482_86079_86101(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 86079, 86101);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10482_86103_86125(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 86103, 86125);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10482_86044_86126(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item1,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item2)
{
var return_v = ImmutableArray.Create<LocalSymbol>( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 86044, 86126);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10482_86158_86230(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item1,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item2)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item1, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 86158, 86230);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10482_85967_86330(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax: syntax, locals: locals, sideEffects: sideEffects, value: value, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 85967, 86330);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,81853,86342);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,81853,86342);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private MethodSymbol UnsafeGetNullableMethod(SyntaxNode syntax, TypeSymbol nullableType, SpecialMember member)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,86710,86945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,86845,86934);

return f_10482_86852_86933(syntax, nullableType, member, _compilation, _diagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,86710,86945);

Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10482_86852_86933(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
nullableType,Microsoft.CodeAnalysis.SpecialMember
member,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics)
{
var return_v = UnsafeGetNullableMethod( syntax, nullableType, member, compilation, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 86852, 86933);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,86710,86945);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,86710,86945);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static MethodSymbol UnsafeGetNullableMethod(SyntaxNode syntax, TypeSymbol nullableType, SpecialMember member, CSharpCompilation compilation, DiagnosticBag diagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10482,87313,87739);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,87513,87565);

var 
nullableType2 = nullableType as NamedTypeSymbol
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,87579,87614);

f_10482_87579_87613(nullableType2 is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,87628,87728);

return f_10482_87635_87727(f_10482_87635_87703(syntax, member, compilation, diagnostics), nullableType2);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10482,87313,87739);

int
f_10482_87579_87613(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 87579, 87613);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10482_87635_87703(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.SpecialMember
specialMember,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics)
{
var return_v = UnsafeGetSpecialTypeMethod( syntax, specialMember, compilation, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 87635, 87703);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10482_87635_87727(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
newOwner)
{
var return_v = this_param.AsMember( newOwner);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 87635, 87727);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,87313,87739);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,87313,87739);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool TryGetNullableMethod(SyntaxNode syntax, TypeSymbol nullableType, SpecialMember member, out MethodSymbol result)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,87751,88178);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,87900,87950);

var 
nullableType2 = (NamedTypeSymbol)nullableType
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,87964,88138) || true) && (f_10482_87968_88019(this, syntax, member, out result))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,87964,88138);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,88053,88093);

result = f_10482_88062_88092(result, nullableType2);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,88111,88123);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,87964,88138);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,88154,88167);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,87751,88178);

bool
f_10482_87968_88019(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.SpecialMember
specialMember,out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = this_param.TryGetSpecialTypeMethod( syntax, specialMember, out method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 87968, 88019);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10482_88062_88092(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
newOwner)
{
var return_v = this_param.AsMember( newOwner);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 88062, 88092);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,87751,88178);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,87751,88178);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression RewriteNullableNullEquality(
            SyntaxNode syntax,
            BinaryOperatorKind kind,
            BoundExpression loweredLeft,
            BoundExpression loweredRight,
            TypeSymbol returnType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,88190,91820);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,88943,88977);

f_10482_88943_88976(loweredLeft != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,88991,89026);

f_10482_88991_89025(loweredRight != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,89040,89081);

f_10482_89040_89080((object)returnType != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,89095,89162);

f_10482_89095_89161(f_10482_89108_89130(returnType)== SpecialType.System_Boolean);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,89176,89250);

f_10482_89176_89249(f_10482_89189_89216(loweredLeft)!= f_10482_89220_89248(loweredRight));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,89266,89351);

BoundExpression 
nullable = (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 89293, 89321)||((f_10482_89293_89321(loweredRight)&&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 89324, 89335))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 89338, 89350)))?loweredLeft :loweredRight
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,89489,89680) || true) && (f_10482_89493_89524(nullable))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,89489,89680);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,89558,89665);

return f_10482_89565_89664(this, syntax, f_10482_89585_89651(kind == BinaryOperatorKind.NullableNullEqual), returnType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,89489,89680);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,89696,89761);

BoundExpression? 
nonNullValue = f_10482_89728_89760(nullable)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,89775,90521) || true) && (nonNullValue != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,89775,90521);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,90146,90506);

return f_10482_90153_90505(syntax: syntax, locals: ImmutableArray<LocalSymbol>.Empty, sideEffects: f_10482_90307_90359(nonNullValue), value: f_10482_90389_90465(this, syntax, kind == BinaryOperatorKind.NullableNullNotEqual), type: returnType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,89775,90521);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,90573,90639);

var 
conditionalAccess = nullable as BoundLoweredConditionalAccess
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,90653,91424) || true) && (conditionalAccess != null &&(DynAbs.Tracing.TraceSender.Expression_True(10482, 90657, 90792)&&                (f_10482_90704_90733(conditionalAccess)== null ||(DynAbs.Tracing.TraceSender.Expression_False(10482, 90704, 90791)||f_10482_90745_90791(f_10482_90745_90774(conditionalAccess))))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,90653,91424);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,90826,91105);

BoundExpression 
whenNotNull = f_10482_90856_91104(this, syntax, kind, f_10482_90962_90991(conditionalAccess), (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 91014, 91041)||((f_10482_91014_91041(                    loweredLeft)&&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 91044, 91055))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 91058, 91070)))?loweredLeft :loweredRight, returnType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,91125,91228);

var 
whenNull = (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 91140, 91184)||((kind == BinaryOperatorKind.NullableNullEqual &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 91187, 91220))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 91223, 91227)))?f_10482_91187_91220(this, syntax, true):null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,91248,91409);

return f_10482_91255_91408(conditionalAccess, f_10482_91280_91306(conditionalAccess), f_10482_91308_91343(conditionalAccess), whenNotNull, whenNull, f_10482_91368_91388(conditionalAccess), whenNotNull.Type!);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,90653,91424);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,91440,91502);

BoundExpression 
call = f_10482_91463_91501(this, syntax, nullable)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,91516,91779);

BoundExpression 
result = (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 91541, 91588)||((kind == BinaryOperatorKind.NullableNullNotEqual &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 91608, 91612))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 91632, 91778)))?                call :f_10482_91632_91778(syntax, UnaryOperatorKind.BoolLogicalNegation, call, ConstantValue.NotAvailable, null, LookupResultKind.Viable, returnType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,91795,91809);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,88190,91820);

int
f_10482_88943_88976(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 88943, 88976);
return 0;
}


int
f_10482_88991_89025(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 88991, 89025);
return 0;
}


int
f_10482_89040_89080(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 89040, 89080);
return 0;
}


Microsoft.CodeAnalysis.SpecialType
f_10482_89108_89130(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 89108, 89130);
return return_v;
}


int
f_10482_89095_89161(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 89095, 89161);
return 0;
}


bool
f_10482_89189_89216(Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = node.IsLiteralNull();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 89189, 89216);
return return_v;
}


bool
f_10482_89220_89248(Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = node.IsLiteralNull();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 89220, 89248);
return return_v;
}


int
f_10482_89176_89249(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 89176, 89249);
return 0;
}


bool
f_10482_89293_89321(Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = node.IsLiteralNull();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 89293, 89321);
return return_v;
}


bool
f_10482_89493_89524(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableNeverHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 89493, 89524);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10482_89585_89651(bool
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 89585, 89651);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_89565_89664(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeLiteral( syntax, constantValue, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 89565, 89664);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_89728_89760(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableAlwaysHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 89728, 89760);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10482_90307_90359(Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 90307, 90359);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_90389_90465(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,bool
value)
{
var return_v = this_param.MakeBooleanConstant( syntax, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 90389, 90465);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10482_90153_90505(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax: syntax, locals: locals, sideEffects: sideEffects, value: value, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 90153, 90505);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10482_90704_90733(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.WhenNullOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 90704, 90733);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_90745_90774(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.WhenNullOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 90745, 90774);
return return_v;
}


bool
f_10482_90745_90791(Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = node.IsDefaultValue();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 90745, 90791);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_90962_90991(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.WhenNotNull;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 90962, 90991);
return return_v;
}


bool
f_10482_91014_91041(Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = node.IsLiteralNull();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 91014, 91041);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_90856_91104(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
returnType)
{
var return_v = this_param.RewriteNullableNullEquality( syntax, kind, loweredLeft, loweredRight, returnType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 90856, 91104);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_91187_91220(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,bool
value)
{
var return_v = this_param.MakeBooleanConstant( syntax, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 91187, 91220);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_91280_91306(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.Receiver;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 91280, 91306);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10482_91308_91343(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.HasValueMethodOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 91308, 91343);
return return_v;
}


int
f_10482_91368_91388(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 91368, 91388);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
f_10482_91255_91408(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
hasValueMethodOpt,Microsoft.CodeAnalysis.CSharp.BoundExpression
whenNotNull,Microsoft.CodeAnalysis.CSharp.BoundExpression?
whenNullOpt,int
id,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Update( receiver, hasValueMethodOpt, whenNotNull, whenNullOpt, id, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 91255, 91408);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_91463_91501(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.MakeNullableHasValue( syntax, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 91463, 91501);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
f_10482_91632_91778(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
operand,Microsoft.CodeAnalysis.ConstantValue
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
methodOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator( syntax, operatorKind, operand, constantValueOpt, methodOpt, resultKind, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 91632, 91778);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,88190,91820);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,88190,91820);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression RewriteStringEquality(BoundBinaryOperator? oldNode, SyntaxNode syntax, BinaryOperatorKind operatorKind, BoundExpression loweredLeft, BoundExpression loweredRight, TypeSymbol type, SpecialMember member)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,91832,92630);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,92082,92389) || true) && (oldNode != null &&(DynAbs.Tracing.TraceSender.Expression_True(10482, 92086, 92206)&&(f_10482_92106_92131(loweredLeft)== f_10482_92135_92153()||(DynAbs.Tracing.TraceSender.Expression_False(10482, 92106, 92205)||f_10482_92157_92183(loweredRight)== f_10482_92187_92205()))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,92082,92389);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,92240,92374);

return f_10482_92247_92373(oldNode, operatorKind, f_10482_92276_92300(oldNode), f_10482_92302_92319(oldNode), f_10482_92321_92339(oldNode), loweredLeft, loweredRight, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,92082,92389);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,92405,92461);

var 
method = f_10482_92418_92460(this, syntax, member)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,92475,92512);

f_10482_92475_92511((object)method != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,92528,92619);

return f_10482_92535_92618(syntax, receiverOpt: null, method, loweredLeft, loweredRight);
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,91832,92630);

Microsoft.CodeAnalysis.ConstantValue?
f_10482_92106_92131(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 92106, 92131);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10482_92135_92153()
{
var return_v = ConstantValue.Null ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 92135, 92153);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10482_92157_92183(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 92157, 92183);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10482_92187_92205()
{
var return_v = ConstantValue.Null;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 92187, 92205);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10482_92276_92300(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
this_param)
{
var return_v = this_param.ConstantValueOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 92276, 92300);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10482_92302_92319(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
this_param)
{
var return_v = this_param.MethodOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 92302, 92319);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LookupResultKind
f_10482_92321_92339(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
this_param)
{
var return_v = this_param.ResultKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 92321, 92339);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10482_92247_92373(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
methodOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Update( operatorKind, constantValueOpt, methodOpt, resultKind, left, right, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 92247, 92373);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10482_92418_92460(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.UnsafeGetSpecialTypeMethod( syntax, specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 92418, 92460);
return return_v;
}


int
f_10482_92475_92511(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 92475, 92511);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10482_92535_92618(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg0,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg1)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt: receiverOpt, method, arg0, arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 92535, 92618);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,91832,92630);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,91832,92630);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression RewriteDelegateOperation(SyntaxNode syntax, BinaryOperatorKind operatorKind, BoundExpression loweredLeft, BoundExpression loweredRight, TypeSymbol type, SpecialMember member)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,92642,94536);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,92865,92885);

MethodSymbol 
method
=default(MethodSymbol);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,92899,93886) || true) && (operatorKind == BinaryOperatorKind.DelegateEqual ||(DynAbs.Tracing.TraceSender.Expression_False(10482, 92903, 93006)||operatorKind == BinaryOperatorKind.DelegateNotEqual))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,92899,93886);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,93040,93114);

method = (MethodSymbol)f_10482_93063_93113(f_10482_93063_93084(_compilation), member);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,93132,93753) || true) && (f_10482_93136_93164(loweredRight)||(DynAbs.Tracing.TraceSender.Expression_False(10482, 93136, 93216)||f_10482_93189_93216(                    loweredLeft))||(DynAbs.Tracing.TraceSender.Expression_False(10482, 93136, 93332)||                    (object)(method = (MethodSymbol)f_10482_93273_93323(f_10482_93273_93294(_compilation), member)) == null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,93132,93753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,93481,93572);

operatorKind = (operatorKind & (~BinaryOperatorKind.Delegate)) | BinaryOperatorKind.Object;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,93594,93734);

return f_10482_93601_93733(syntax, operatorKind, constantValueOpt: null, null, LookupResultKind.Empty, loweredLeft, loweredRight, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,93132,93753);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,92899,93886);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,92899,93886);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,93819,93871);

method = f_10482_93828_93870(this, syntax, member);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,92899,93886);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,93902,93939);

f_10482_93902_93938((object)method != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,93953,94268);

BoundExpression 
call = (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 93976, 93995)||((_inExpressionLambda
&&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 94015, 94147))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 94167, 94267)))?f_10482_94015_94147(syntax, operatorKind, null, method, default(LookupResultKind), loweredLeft, loweredRight, f_10482_94129_94146(method)):(BoundExpression)f_10482_94184_94267(syntax, receiverOpt: null, method, loweredLeft, loweredRight)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,94282,94497);

BoundExpression 
result = (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 94307, 94367)||((f_10482_94307_94336(f_10482_94307_94324(method))== SpecialType.System_Delegate &&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 94387, 94472))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 94492, 94496)))?f_10482_94387_94472(this, syntax, call, Conversion.ExplicitReference, type, @checked: false):                call
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,94511,94525);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,92642,94536);

Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
f_10482_93063_93084(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 93063, 93084);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10482_93063_93113(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
this_param,Microsoft.CodeAnalysis.SpecialMember
member)
{
var return_v = this_param.GetSpecialTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 93063, 93113);
return return_v;
}


bool
f_10482_93136_93164(Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = node.IsLiteralNull();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 93136, 93164);
return return_v;
}


bool
f_10482_93189_93216(Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = node.IsLiteralNull();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 93189, 93216);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
f_10482_93273_93294(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 93273, 93294);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10482_93273_93323(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
this_param,Microsoft.CodeAnalysis.SpecialMember
member)
{
var return_v = this_param.GetSpecialTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 93273, 93323);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10482_93601_93733(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
methodOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator( syntax, operatorKind, constantValueOpt: constantValueOpt, methodOpt, resultKind, left, right, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 93601, 93733);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10482_93828_93870(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.UnsafeGetSpecialTypeMethod( syntax, specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 93828, 93870);
return return_v;
}


int
f_10482_93902_93938(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 93902, 93938);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_94129_94146(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ReturnType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 94129, 94146);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10482_94015_94147(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
methodOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator( syntax, operatorKind, constantValueOpt, methodOpt, resultKind, left, right, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 94015, 94147);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10482_94184_94267(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg0,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg1)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt: receiverOpt, method, arg0, arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 94184, 94267);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_94307_94324(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ReturnType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 94307, 94324);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10482_94307_94336(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 94307, 94336);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_94387_94472(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( syntax, rewrittenOperand, conversion, rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 94387, 94472);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,92642,94536);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,92642,94536);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression RewriteDecimalBinaryOperation(SyntaxNode syntax, BoundExpression loweredLeft, BoundExpression loweredRight, BinaryOperatorKind operatorKind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,94548,96738);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,94737,94815);

f_10482_94737_94814(f_10482_94750_94766(loweredLeft)is { SpecialType: SpecialType.System_Decimal });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,94829,94908);

f_10482_94829_94907(f_10482_94842_94859(loweredRight)is { SpecialType: SpecialType.System_Decimal });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,94924,94945);

SpecialMember 
member
=default(SpecialMember);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,94961,96453);

switch (operatorKind)
            {

case BinaryOperatorKind.DecimalAddition: DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,94961,96453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,95056,95107);

member = SpecialMember.System_Decimal__op_Addition;
DynAbs.Tracing.TraceSender.TraceBreak(10482,95108,95114);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,94961,96453);

case BinaryOperatorKind.DecimalSubtraction: DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,94961,96453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,95176,95230);

member = SpecialMember.System_Decimal__op_Subtraction;
DynAbs.Tracing.TraceSender.TraceBreak(10482,95231,95237);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,94961,96453);

case BinaryOperatorKind.DecimalMultiplication: DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,94961,96453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,95302,95353);

member = SpecialMember.System_Decimal__op_Multiply;
DynAbs.Tracing.TraceSender.TraceBreak(10482,95354,95360);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,94961,96453);

case BinaryOperatorKind.DecimalDivision: DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,94961,96453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,95419,95470);

member = SpecialMember.System_Decimal__op_Division;
DynAbs.Tracing.TraceSender.TraceBreak(10482,95471,95477);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,94961,96453);

case BinaryOperatorKind.DecimalRemainder: DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,94961,96453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,95537,95587);

member = SpecialMember.System_Decimal__op_Modulus;
DynAbs.Tracing.TraceSender.TraceBreak(10482,95588,95594);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,94961,96453);

case BinaryOperatorKind.DecimalEqual: DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,94961,96453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,95650,95701);

member = SpecialMember.System_Decimal__op_Equality;
DynAbs.Tracing.TraceSender.TraceBreak(10482,95702,95708);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,94961,96453);

case BinaryOperatorKind.DecimalNotEqual: DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,94961,96453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,95767,95820);

member = SpecialMember.System_Decimal__op_Inequality;
DynAbs.Tracing.TraceSender.TraceBreak(10482,95821,95827);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,94961,96453);

case BinaryOperatorKind.DecimalLessThan: DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,94961,96453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,95886,95937);

member = SpecialMember.System_Decimal__op_LessThan;
DynAbs.Tracing.TraceSender.TraceBreak(10482,95938,95944);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,94961,96453);

case BinaryOperatorKind.DecimalLessThanOrEqual: DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,94961,96453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,96010,96068);

member = SpecialMember.System_Decimal__op_LessThanOrEqual;
DynAbs.Tracing.TraceSender.TraceBreak(10482,96069,96075);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,94961,96453);

case BinaryOperatorKind.DecimalGreaterThan: DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,94961,96453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,96137,96191);

member = SpecialMember.System_Decimal__op_GreaterThan;
DynAbs.Tracing.TraceSender.TraceBreak(10482,96192,96198);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,94961,96453);

case BinaryOperatorKind.DecimalGreaterThanOrEqual: DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,94961,96453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,96267,96328);

member = SpecialMember.System_Decimal__op_GreaterThanOrEqual;
DynAbs.Tracing.TraceSender.TraceBreak(10482,96329,96335);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,94961,96453);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,94961,96453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,96383,96438);

throw f_10482_96389_96437(operatorKind);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,94961,96453);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,96513,96569);

var 
method = f_10482_96526_96568(this, syntax, member)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,96583,96620);

f_10482_96583_96619((object)method != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,96636,96727);

return f_10482_96643_96726(syntax, receiverOpt: null, method, loweredLeft, loweredRight);
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,94548,96738);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10482_94750_94766(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 94750, 94766);
return return_v;
}


int
f_10482_94737_94814(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 94737, 94814);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10482_94842_94859(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 94842, 94859);
return return_v;
}


int
f_10482_94829_94907(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 94829, 94907);
return 0;
}


System.Exception
f_10482_96389_96437(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 96389, 96437);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10482_96526_96568(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.UnsafeGetSpecialTypeMethod( syntax, specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 96526, 96568);
return return_v;
}


int
f_10482_96583_96619(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 96583, 96619);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10482_96643_96726(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg0,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg1)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt: receiverOpt, method, arg0, arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 96643, 96726);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,94548,96738);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,94548,96738);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeNullCheck(SyntaxNode syntax, BoundExpression rewrittenExpr, BinaryOperatorKind operatorKind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,96750,99096);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,96895,97137);

f_10482_96895_97136((operatorKind == BinaryOperatorKind.Equal) ||(DynAbs.Tracing.TraceSender.Expression_False(10482, 96908, 96999)||(operatorKind == BinaryOperatorKind.NotEqual) )||(DynAbs.Tracing.TraceSender.Expression_False(10482, 96908, 97074)||                (operatorKind == BinaryOperatorKind.NullableNullEqual) )||(DynAbs.Tracing.TraceSender.Expression_False(10482, 96908, 97135)||(operatorKind == BinaryOperatorKind.NullableNullNotEqual)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,97153,97195);

TypeSymbol? 
exprType = f_10482_97176_97194(rewrittenExpr)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,97293,97503);

f_10482_97293_97502(exprType is null ||(DynAbs.Tracing.TraceSender.Expression_False(10482, 97324, 97401)||f_10482_97361_97401(                exprType))||(DynAbs.Tracing.TraceSender.Expression_False(10482, 97324, 97443)||f_10482_97422_97443_M(!exprType.IsValueType))||(DynAbs.Tracing.TraceSender.Expression_False(10482, 97324, 97501)||f_10482_97464_97501(                exprType)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,97519,97597);

TypeSymbol 
boolType = f_10482_97541_97596(_compilation, SpecialType.System_Boolean)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,97660,98237) || true) && (f_10482_97664_97691(rewrittenExpr)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,97660,98237);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,97733,98222);

switch (operatorKind)
                {

case BinaryOperatorKind.Equal:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,97733,98222);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,97851,97986);

return f_10482_97858_97985(this, syntax, f_10482_97878_97974(f_10482_97899_97933(f_10482_97899_97926(rewrittenExpr)), ConstantValueTypeDiscriminator.Boolean), boolType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,97733,98222);

case BinaryOperatorKind.NotEqual:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,97733,98222);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,98067,98203);

return f_10482_98074_98202(this, syntax, f_10482_98094_98191(f_10482_98115_98150_M(!f_10482_98116_98143(rewrittenExpr).IsNull), ConstantValueTypeDiscriminator.Boolean), boolType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,97733,98222);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,97660,98237);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,98253,98332);

TypeSymbol 
objectType = f_10482_98277_98331(_compilation, SpecialType.System_Object)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,98348,98834) || true) && (exprType is { })
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,98348,98834);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,98401,98819) || true) && (f_10482_98405_98418(exprType)== SymbolKind.TypeParameter)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,98401,98819);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,98533,98639);

rewrittenExpr = f_10482_98549_98638(this, syntax, rewrittenExpr, Conversion.Boxing, objectType, @checked: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,98401,98819);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,98401,98819);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,98681,98819) || true) && (f_10482_98685_98710(exprType))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,98681,98819);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,98752,98800);

operatorKind |= BinaryOperatorKind.NullableNull;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,98681,98819);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,98401,98819);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,98348,98834);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,98850,99085);

return f_10482_98857_99084(this, syntax, operatorKind, rewrittenExpr, f_10482_98982_99033(this, syntax, f_10482_99002_99020(), objectType), boolType, null);
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,96750,99096);

int
f_10482_96895_97136(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 96895, 97136);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10482_97176_97194(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 97176, 97194);
return return_v;
}


bool
f_10482_97361_97401(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsNullableTypeOrTypeParameter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 97361, 97401);
return return_v;
}


bool
f_10482_97422_97443_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 97422, 97443);
return return_v;
}


bool
f_10482_97464_97501(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsPointerOrFunctionPointer();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 97464, 97501);
return return_v;
}


int
f_10482_97293_97502(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 97293, 97502);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10482_97541_97596(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 97541, 97596);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10482_97664_97691(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 97664, 97691);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10482_97899_97926(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 97899, 97926);
return return_v;
}


bool
f_10482_97899_97933(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.IsNull;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 97899, 97933);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10482_97878_97974(bool
value,Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
discriminator)
{
var return_v = ConstantValue.Create( (object)value, discriminator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 97878, 97974);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_97858_97985(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeLiteral( syntax, constantValue, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 97858, 97985);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10482_98116_98143(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 98116, 98143);
return return_v;
}


bool
f_10482_98115_98150_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 98115, 98150);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10482_98094_98191(bool
value,Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
discriminator)
{
var return_v = ConstantValue.Create( (object)value, discriminator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 98094, 98191);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_98074_98202(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeLiteral( syntax, constantValue, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 98074, 98202);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10482_98277_98331(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 98277, 98331);
return return_v;
}


Microsoft.CodeAnalysis.SymbolKind
f_10482_98405_98418(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 98405, 98418);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_98549_98638(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( syntax, rewrittenOperand, conversion, rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 98549, 98638);
return return_v;
}


bool
f_10482_98685_98710(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsNullableType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 98685, 98710);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10482_99002_99020()
{
var return_v = ConstantValue.Null;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 99002, 99020);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_98982_99033(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeLiteral( syntax, constantValue, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 98982, 99033);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_98857_99084(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.MakeBinaryOperator( syntax, operatorKind, loweredLeft, loweredRight, type, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 98857, 99084);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,96750,99096);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,96750,99096);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression RewriteBuiltInShiftOperation(
            BoundBinaryOperator? oldNode,
            SyntaxNode syntax,
            BinaryOperatorKind operatorKind,
            BoundExpression loweredLeft,
            BoundExpression loweredRight,
            TypeSymbol type,
            int rightMask)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,99341,101578);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,99683,99728);

SyntaxNode 
rightSyntax = loweredRight.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,99742,99805);

ConstantValue? 
rightConstantValue = f_10482_99778_99804(loweredRight)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,99819,99858);

f_10482_99819_99857(f_10482_99832_99849(loweredRight)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,99872,99913);

TypeSymbol 
rightType = f_10482_99895_99912(loweredRight)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,99927,99991);

f_10482_99927_99990(f_10482_99940_99961(rightType)== SpecialType.System_Int32);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,100007,100963) || true) && (rightConstantValue != null &&(DynAbs.Tracing.TraceSender.Expression_True(10482, 100011, 100070)&&f_10482_100041_100070(rightConstantValue)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,100007,100963);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,100104,100164);

int 
shiftAmount = f_10482_100122_100151(rightConstantValue)& rightMask
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,100182,100282) || true) && (shiftAmount == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,100182,100282);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,100244,100263);

return loweredLeft;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,100182,100282);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,100302,100388);

loweredRight = f_10482_100317_100387(this, rightSyntax, f_10482_100342_100375(shiftAmount), rightType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,100007,100963);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,100007,100963);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,100454,100560);

BinaryOperatorKind 
andOperatorKind = (operatorKind & ~BinaryOperatorKind.OpMask) | BinaryOperatorKind.And
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,100578,100948);

loweredRight = f_10482_100593_100947(rightSyntax, andOperatorKind, null, null, LookupResultKind.Viable, loweredRight, f_10482_100846_100914(this, rightSyntax, f_10482_100871_100902(rightMask), rightType), rightType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,100007,100963);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,100979,101567);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 100986, 101001)||((oldNode == null
&&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 101021, 101305))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 101325, 101566)))?f_10482_101021_101305(syntax, operatorKind, null, null, LookupResultKind.Viable, loweredLeft, loweredRight, type):f_10482_101325_101566(oldNode, operatorKind, null, null, f_10482_101451_101469(oldNode), loweredLeft, loweredRight, type);
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,99341,101578);

Microsoft.CodeAnalysis.ConstantValue?
f_10482_99778_99804(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 99778, 99804);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10482_99832_99849(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 99832, 99849);
return return_v;
}


int
f_10482_99819_99857(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 99819, 99857);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_99895_99912(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 99895, 99912);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10482_99940_99961(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 99940, 99961);
return return_v;
}


int
f_10482_99927_99990(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 99927, 99990);
return 0;
}


bool
f_10482_100041_100070(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.IsIntegral;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 100041, 100070);
return return_v;
}


int
f_10482_100122_100151(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.Int32Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 100122, 100151);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10482_100342_100375(int
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 100342, 100375);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_100317_100387(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeLiteral( syntax, constantValue, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 100317, 100387);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10482_100871_100902(int
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 100871, 100902);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_100846_100914(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeLiteral( syntax, constantValue, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 100846, 100914);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10482_100593_100947(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
methodOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator( syntax, operatorKind, constantValueOpt, methodOpt, resultKind, left, right, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 100593, 100947);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10482_101021_101305(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
methodOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator( syntax, operatorKind, constantValueOpt, methodOpt, resultKind, left, right, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 101021, 101305);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LookupResultKind
f_10482_101451_101469(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
this_param)
{
var return_v = this_param.ResultKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 101451, 101469);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10482_101325_101566(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
methodOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Update( operatorKind, constantValueOpt, methodOpt, resultKind, left, right, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 101325, 101566);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,99341,101578);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,99341,101578);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression RewritePointerNumericOperator(
            SyntaxNode syntax,
            BinaryOperatorKind kind,
            BoundExpression loweredLeft,
            BoundExpression loweredRight,
            TypeSymbol returnType,
            bool isPointerElementAccess,
            bool isLeftPointer)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,101590,103344);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,101935,102451) || true) && (isLeftPointer)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,101935,102451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,101986,102051);

f_10482_101986_102050(f_10482_101999_102015(loweredLeft)is { TypeKind: TypeKind.Pointer });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,102069,102178);

loweredRight = f_10482_102084_102177(this, loweredRight, f_10482_102142_102158(loweredLeft), f_10482_102160_102176(kind));
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,101935,102451);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,101935,102451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,102244,102310);

f_10482_102244_102309(f_10482_102257_102274(loweredRight)is { TypeKind: TypeKind.Pointer });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,102328,102436);

loweredLeft = f_10482_102342_102435(this, loweredLeft, f_10482_102399_102416(loweredRight), f_10482_102418_102434(kind));
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,101935,102451);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,102467,102941) || true) && (isPointerElementAccess)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,102467,102941);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,102527,102588);

f_10482_102527_102587(f_10482_102540_102555(kind)== BinaryOperatorKind.Addition);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,102884,102926);

kind = kind & ~BinaryOperatorKind.Checked;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,102467,102941);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,102957,103333);

return f_10482_102964_103332(syntax, kind, ConstantValue.NotAvailable, null, LookupResultKind.Viable, loweredLeft, loweredRight, returnType);
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,101590,103344);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10482_101999_102015(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 101999, 102015);
return return_v;
}


int
f_10482_101986_102050(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 101986, 102050);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_102142_102158(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 102142, 102158);
return return_v;
}


bool
f_10482_102160_102176(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.IsChecked();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 102160, 102176);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_102084_102177(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
numericOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
pointerType,bool
isChecked)
{
var return_v = this_param.MakeSizeOfMultiplication( numericOperand, (Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol)pointerType, isChecked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 102084, 102177);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10482_102257_102274(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 102257, 102274);
return return_v;
}


int
f_10482_102244_102309(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 102244, 102309);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_102399_102416(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 102399, 102416);
return return_v;
}


bool
f_10482_102418_102434(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.IsChecked();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 102418, 102434);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_102342_102435(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
numericOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
pointerType,bool
isChecked)
{
var return_v = this_param.MakeSizeOfMultiplication( numericOperand, (Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol)pointerType, isChecked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 102342, 102435);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10482_102540_102555(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.Operator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 102540, 102555);
return return_v;
}


int
f_10482_102527_102587(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 102527, 102587);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10482_102964_103332(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.ConstantValue
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
methodOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator( syntax, operatorKind, constantValueOpt, methodOpt, resultKind, left, right, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 102964, 103332);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,101590,103344);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,101590,103344);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeSizeOfMultiplication(BoundExpression numericOperand, PointerTypeSymbol pointerType, bool isChecked)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,104245,112820);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,104397,104463);

var 
sizeOfExpression = f_10482_104420_104462(_factory, f_10482_104436_104461(pointerType))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,104477,104558);

f_10482_104477_104557(f_10482_104490_104511(sizeOfExpression)is { SpecialType: SpecialType.System_Int32 });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,104644,104955) || true) && (f_10482_104648_104689_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10482_104648_104676(numericOperand), 10482, 104648, 104689)?.UInt64Value)== 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,104644,104955);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,104916,104940);

return sizeOfExpression;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,104644,104955);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,104971,105012);

f_10482_104971_105011(f_10482_104984_105003(numericOperand)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,105026,105083);

var 
numericSpecialType = f_10482_105051_105082(f_10482_105051_105070(numericOperand))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,105195,108344) || true) && (f_10482_105199_105241_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10482_105199_105229(sizeOfExpression), 10482, 105199, 105241)?.Int32Value)== 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,105195,108344);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,105867,105916);

SpecialType 
destinationType = numericSpecialType
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,105934,108102);

switch (numericSpecialType)
                {

case SpecialType.System_Int32:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,105934,108102);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,106618,106978) || true) && (isChecked)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,106618,106978);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,106689,106733);

var 
constVal = f_10482_106704_106732(numericOperand)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,106763,106951) || true) && (constVal == null ||(DynAbs.Tracing.TraceSender.Expression_False(10482, 106767, 106810)||f_10482_106787_106806(constVal)< 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,106763,106951);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,106876,106920);

destinationType = SpecialType.System_IntPtr;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,106763,106951);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,106618,106978);
}
DynAbs.Tracing.TraceSender.TraceBreak(10482,107004,107010);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,105934,108102);

case SpecialType.System_UInt32:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,105934,108102);
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,107322,107366);

var 
constVal = f_10482_107337_107365(numericOperand)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,107396,107597) || true) && (constVal == null ||(DynAbs.Tracing.TraceSender.Expression_False(10482, 107400, 107455)||f_10482_107420_107440(constVal)> int.MaxValue))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,107396,107597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,107521,107566);

destinationType = SpecialType.System_UIntPtr;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,107396,107597);
}
                        }
DynAbs.Tracing.TraceSender.TraceBreak(10482,107650,107656);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,105934,108102);

case SpecialType.System_Int64:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,105934,108102);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,107734,107778);

destinationType = SpecialType.System_IntPtr;
DynAbs.Tracing.TraceSender.TraceBreak(10482,107804,107810);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,105934,108102);

case SpecialType.System_UInt64:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,105934,108102);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,107889,107934);

destinationType = SpecialType.System_UIntPtr;
DynAbs.Tracing.TraceSender.TraceBreak(10482,107960,107966);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,105934,108102);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,105934,108102);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,108022,108083);

throw f_10482_108028_108082(numericSpecialType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,105934,108102);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,108122,108329);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 108129, 108166)||((destinationType == numericSpecialType
&&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 108190, 108204))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 108228, 108328)))?numericOperand
:f_10482_108228_108328(_factory, f_10482_108245_108282(_factory, destinationType), numericOperand, Conversion.IntegerToPointer);
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,105195,108344);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,108360,108434);

BinaryOperatorKind 
multiplicationKind = BinaryOperatorKind.Multiplication
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,108450,108486);

TypeSymbol 
multiplicationResultType
=default(TypeSymbol);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,108500,108545);

TypeSymbol 
convertedMultiplicationResultType
=default(TypeSymbol);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,108559,112201);

switch (numericSpecialType)
            {

case SpecialType.System_Int32:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,108559,112201);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,108698,108773);

TypeSymbol 
nativeIntType = f_10482_108725_108772(_factory, SpecialType.System_IntPtr)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,109048,109153);

numericOperand = f_10482_109065_109152(_factory, nativeIntType, numericOperand, Conversion.IntegerToPointer, isChecked);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,109179,109224);

multiplicationKind |= BinaryOperatorKind.Int;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,109264,109305);

multiplicationResultType = nativeIntType;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,109331,109381);

convertedMultiplicationResultType = nativeIntType;
DynAbs.Tracing.TraceSender.TraceBreak(10482,109407,109413);

break;
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,108559,112201);

case SpecialType.System_UInt32:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,108559,112201);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,109534,109603);

TypeSymbol 
longType = f_10482_109556_109602(_factory, SpecialType.System_Int64)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,109629,109704);

TypeSymbol 
nativeIntType = f_10482_109656_109703(_factory, SpecialType.System_IntPtr)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,109867,109966);

numericOperand = f_10482_109884_109965(_factory, longType, numericOperand, Conversion.ExplicitNumeric, isChecked);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,109992,110095);

sizeOfExpression = f_10482_110011_110094(_factory, longType, sizeOfExpression, Conversion.ExplicitNumeric, isChecked);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,110121,110167);

multiplicationKind |= BinaryOperatorKind.Long;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,110193,110229);

multiplicationResultType = longType;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,110255,110305);

convertedMultiplicationResultType = nativeIntType;
DynAbs.Tracing.TraceSender.TraceBreak(10482,110331,110337);

break;
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,108559,112201);

case SpecialType.System_Int64:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,108559,112201);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,110457,110526);

TypeSymbol 
longType = f_10482_110479_110525(_factory, SpecialType.System_Int64)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,110552,110627);

TypeSymbol 
nativeIntType = f_10482_110579_110626(_factory, SpecialType.System_IntPtr)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,110793,110896);

sizeOfExpression = f_10482_110812_110895(_factory, longType, sizeOfExpression, Conversion.ExplicitNumeric, isChecked);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,110922,110968);

multiplicationKind |= BinaryOperatorKind.Long;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,110994,111030);

multiplicationResultType = longType;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,111056,111106);

convertedMultiplicationResultType = nativeIntType;
DynAbs.Tracing.TraceSender.TraceBreak(10482,111132,111138);

break;
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,108559,112201);

case SpecialType.System_UInt64:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,108559,112201);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,111259,111330);

TypeSymbol 
ulongType = f_10482_111282_111329(_factory, SpecialType.System_UInt64)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,111356,111433);

TypeSymbol 
nativeUIntType = f_10482_111384_111432(_factory, SpecialType.System_UIntPtr)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,111601,111705);

sizeOfExpression = f_10482_111620_111704(_factory, ulongType, sizeOfExpression, Conversion.ExplicitNumeric, isChecked);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,111731,111778);

multiplicationKind |= BinaryOperatorKind.ULong;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,111804,111841);

multiplicationResultType = ulongType;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,111867,111918);

convertedMultiplicationResultType = nativeUIntType;
DynAbs.Tracing.TraceSender.TraceBreak(10482,111998,112004);

break;
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,108559,112201);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,108559,112201);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,112102,112163);

throw f_10482_112108_112162(numericSpecialType);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,108559,112201);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,112217,112328) || true) && (isChecked)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10482,112217,112328);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,112264,112313);

multiplicationKind |= BinaryOperatorKind.Checked;
DynAbs.Tracing.TraceSender.TraceExitCondition(10482,112217,112328);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,112342,112459);

var 
multiplication = f_10482_112363_112458(_factory, multiplicationKind, multiplicationResultType, numericOperand, sizeOfExpression)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,112473,112746);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10482, 112480, 112595)||((f_10482_112480_112595(convertedMultiplicationResultType, multiplicationResultType, TypeCompareKind.ConsiderEverything2)&&DynAbs.Tracing.TraceSender.Conditional_F2(10482, 112615, 112629))||DynAbs.Tracing.TraceSender.Conditional_F3(10482, 112649, 112745)))?multiplication
:f_10482_112649_112745(_factory, convertedMultiplicationResultType, multiplication, Conversion.IntegerToPointer);
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,104245,112820);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_104436_104461(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
this_param)
{
var return_v = this_param.PointedAtType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 104436, 104461);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_104420_104462(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Sizeof( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 104420, 104462);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10482_104490_104511(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 104490, 104511);
return return_v;
}


int
f_10482_104477_104557(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 104477, 104557);
return 0;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10482_104648_104676(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 104648, 104676);
return return_v;
}


ulong?
f_10482_104648_104689_M(ulong?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 104648, 104689);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10482_104984_105003(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 104984, 105003);
return return_v;
}


int
f_10482_104971_105011(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 104971, 105011);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_105051_105070(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 105051, 105070);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10482_105051_105082(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 105051, 105082);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10482_105199_105229(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 105199, 105229);
return return_v;
}


int?
f_10482_105199_105241_M(int?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 105199, 105241);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10482_106704_106732(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 106704, 106732);
return return_v;
}


int
f_10482_106787_106806(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.Int32Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 106787, 106806);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10482_107337_107365(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 107337, 107365);
return return_v;
}


uint
f_10482_107420_107440(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.UInt32Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 107420, 107440);
return return_v;
}


System.Exception
f_10482_108028_108082(Microsoft.CodeAnalysis.SpecialType
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 108028, 108082);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10482_108245_108282(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.SpecialType
st)
{
var return_v = this_param.SpecialType( st);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 108245, 108282);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_108228_108328(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg,Microsoft.CodeAnalysis.CSharp.Conversion
conversion)
{
var return_v = this_param.Convert( (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, arg, conversion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 108228, 108328);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10482_108725_108772(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.SpecialType
st)
{
var return_v = this_param.SpecialType( st);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 108725, 108772);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_109065_109152(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,bool
isChecked)
{
var return_v = this_param.Convert( type, arg, conversion, isChecked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 109065, 109152);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10482_109556_109602(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.SpecialType
st)
{
var return_v = this_param.SpecialType( st);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 109556, 109602);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10482_109656_109703(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.SpecialType
st)
{
var return_v = this_param.SpecialType( st);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 109656, 109703);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_109884_109965(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,bool
isChecked)
{
var return_v = this_param.Convert( type, arg, conversion, isChecked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 109884, 109965);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_110011_110094(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,bool
isChecked)
{
var return_v = this_param.Convert( type, arg, conversion, isChecked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 110011, 110094);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10482_110479_110525(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.SpecialType
st)
{
var return_v = this_param.SpecialType( st);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 110479, 110525);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10482_110579_110626(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.SpecialType
st)
{
var return_v = this_param.SpecialType( st);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 110579, 110626);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_110812_110895(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,bool
isChecked)
{
var return_v = this_param.Convert( type, arg, conversion, isChecked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 110812, 110895);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10482_111282_111329(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.SpecialType
st)
{
var return_v = this_param.SpecialType( st);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 111282, 111329);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10482_111384_111432(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.SpecialType
st)
{
var return_v = this_param.SpecialType( st);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 111384, 111432);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_111620_111704(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,bool
isChecked)
{
var return_v = this_param.Convert( type, arg, conversion, isChecked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 111620, 111704);
return return_v;
}


System.Exception
f_10482_112108_112162(Microsoft.CodeAnalysis.SpecialType
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 112108, 112162);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10482_112363_112458(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.Binary( kind, type, left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 112363, 112458);
return return_v;
}


bool
f_10482_112480_112595(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
left,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 112480, 112595);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_112649_112745(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
arg,Microsoft.CodeAnalysis.CSharp.Conversion
conversion)
{
var return_v = this_param.Convert( type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg, conversion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 112649, 112745);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,104245,112820);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,104245,112820);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression RewritePointerSubtraction(
            BinaryOperatorKind kind,
            BoundExpression loweredLeft,
            BoundExpression loweredRight,
            TypeSymbol returnType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10482,112832,114285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,113066,113131);

f_10482_113066_113130(f_10482_113079_113095(loweredLeft)is { TypeKind: TypeKind.Pointer });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,113145,113211);

f_10482_113145_113210(f_10482_113158_113175(loweredRight)is { TypeKind: TypeKind.Pointer });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,113225,113290);

f_10482_113225_113289(f_10482_113238_113260(returnType)== SpecialType.System_Int64);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,113306,113374);

PointerTypeSymbol 
pointerType = (PointerTypeSymbol)f_10482_113357_113373(loweredLeft)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,113388,113454);

var 
sizeOfExpression = f_10482_113411_113453(_factory, f_10482_113427_113452(pointerType))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10482,113701,114274);

return f_10482_113708_114273(_factory, returnType, f_10482_113772_114226(                _factory, BinaryOperatorKind.Division, f_10482_113860_113907(                    _factory, SpecialType.System_IntPtr), f_10482_113930_114186(                    _factory, kind & ~BinaryOperatorKind.Checked, returnType, loweredLeft, loweredRight), sizeOfExpression), Conversion.PointerToInteger);
DynAbs.Tracing.TraceSender.TraceExitMethod(10482,112832,114285);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10482_113079_113095(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 113079, 113095);
return return_v;
}


int
f_10482_113066_113130(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 113066, 113130);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10482_113158_113175(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 113158, 113175);
return return_v;
}


int
f_10482_113145_113210(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 113145, 113210);
return 0;
}


Microsoft.CodeAnalysis.SpecialType
f_10482_113238_113260(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 113238, 113260);
return return_v;
}


int
f_10482_113225_113289(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 113225, 113289);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_113357_113373(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 113357, 113373);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10482_113427_113452(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
this_param)
{
var return_v = this_param.PointedAtType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10482, 113427, 113452);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_113411_113453(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Sizeof( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 113411, 113453);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10482_113860_113907(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.SpecialType
st)
{
var return_v = this_param.SpecialType( st);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 113860, 113907);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10482_113930_114186(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.Binary( kind, type, left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 113930, 114186);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10482_113772_114226(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.Binary( kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 113772, 114226);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10482_113708_114273(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
arg,Microsoft.CodeAnalysis.CSharp.Conversion
conversion)
{
var return_v = this_param.Convert( type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg, conversion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10482, 113708, 114273);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10482,112832,114285);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10482,112832,114285);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
