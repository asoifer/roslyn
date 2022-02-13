// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitCompoundAssignmentOperator(BoundCompoundAssignmentOperator node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10486,518,700);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,638,689);

return f_10486_645_688(this, node, true);
DynAbs.Tracing.TraceSender.TraceExitMethod(10486,518,700);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_645_688(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
node,bool
used)
{
var return_v = this_param.VisitCompoundAssignmentOperator( node, used);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 645, 688);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10486,518,700);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10486,518,700);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression VisitCompoundAssignmentOperator(BoundCompoundAssignmentOperator node, bool used)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10486,712,7929);
Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator isEventAssignment = default(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator);
Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator receiverAssignment = default(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator);
Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator nonEventStore = default(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator);
Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator possibleHandlerAssignment = default(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,841,952);

f_10486_841_951(f_10486_854_950(f_10486_872_887(f_10486_872_882(node)), node.Operator.RightType, TypeCompareKind.ConsiderEverything2));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,966,1025);

BoundExpression 
loweredRight = f_10486_997_1024(this, f_10486_1013_1023(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,1041,1093);

var 
temps = f_10486_1053_1092()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,1107,1164);

var 
stores = f_10486_1120_1163()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,1180,1210);

var 
kind = node.Operator.Kind
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,1224,1258);

bool 
isChecked = f_10486_1241_1257(kind)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,1272,1306);

bool 
isDynamic = f_10486_1289_1305(kind)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,1320,1357);

var 
binaryOperator = f_10486_1341_1356(kind)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,1509,1610);

BoundExpression 
transformedLHS = f_10486_1542_1609(this, f_10486_1573_1582(node), stores, temps, isDynamic)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,1624,1665);

var 
lhsRead = f_10486_1638_1664(this, transformedLHS)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,1679,1715);

BoundExpression 
rewrittenAssignment
=default(BoundExpression);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,1731,5709) || true) && (f_10486_1735_1749(f_10486_1735_1744(node))== BoundKind.DynamicMemberAccess &&(DynAbs.Tracing.TraceSender.Expression_True(10486, 1735, 1902)&&                (binaryOperator == BinaryOperatorKind.Addition ||(DynAbs.Tracing.TraceSender.Expression_False(10486, 1804, 1901)||binaryOperator == BinaryOperatorKind.Subtraction))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,1731,5709);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,3015,3072);

var 
eventTemps = f_10486_3032_3071()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,3090,3149);

var 
sequence = f_10486_3105_3148()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,3232,3292);

var 
memberAccess = (BoundDynamicMemberAccess)transformedLHS
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,3394,3573);

var 
isEvent = f_10486_3408_3572(_factory, f_10486_3429_3509(_dynamicFactory, f_10486_3468_3485(memberAccess), f_10486_3487_3508(memberAccess)).ToExpression(), out isEventAssignment)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,3591,3627);

f_10486_3591_3626(                eventTemps, f_10486_3606_3625(isEvent));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,3645,3677);

f_10486_3645_3676(                sequence, isEventAssignment);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,3784,3872);

lhsRead = f_10486_3794_3871(_factory, lhsRead, out receiverAssignment);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,3890,3940);

f_10486_3890_3939(                eventTemps, f_10486_3905_3938(((BoundLocal)lhsRead)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,3958,4172);

var 
storeNonEvent = f_10486_3978_4171(_factory, f_10486_3999_4127(_factory, f_10486_4020_4041(_factory, isEvent), receiverAssignment, f_10486_4063_4101(_factory, f_10486_4077_4100(receiverAssignment)), f_10486_4103_4126(receiverAssignment)), out nonEventStore)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,4190,4232);

f_10486_4190_4231(                eventTemps, f_10486_4205_4230(storeNonEvent));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,4250,4278);

f_10486_4250_4277(                sequence, nonEventStore);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,4346,4695) || true) && (f_10486_4350_4390(loweredRight))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,4346,4695);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,4432,4537);

loweredRight = f_10486_4447_4536(_factory, loweredRight, out possibleHandlerAssignment);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,4559,4614);

f_10486_4559_4613(                    eventTemps, f_10486_4574_4612(((BoundLocal)loweredRight)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,4636,4676);

f_10486_4636_4675(                    sequence, possibleHandlerAssignment);
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,4346,4695);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,4760,5028);

var 
invokeEventAccessor = f_10486_4786_5027(_dynamicFactory, ((DynAbs.Tracing.TraceSender.Conditional_F1(10486, 4860, 4905)||((binaryOperator == BinaryOperatorKind.Addition &&DynAbs.Tracing.TraceSender.Conditional_F2(10486, 4908, 4914))||DynAbs.Tracing.TraceSender.Conditional_F3(10486, 4917, 4926)))?"add_" :"remove_") + f_10486_4930_4947(memberAccess), f_10486_4970_4991(memberAccess), loweredRight)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,5114,5163);

rewrittenAssignment = f_10486_5136_5162(lhsRead);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,5181,5227);

f_10486_5181_5226(f_10486_5194_5218(rewrittenAssignment)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,5285,5414);

var 
condition = f_10486_5301_5413(_factory, isEvent, invokeEventAccessor.ToExpression(), rewrittenAssignment, f_10486_5388_5412(rewrittenAssignment))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,5434,5579);

rewrittenAssignment = f_10486_5456_5578(node.Syntax, f_10486_5487_5518(eventTemps), f_10486_5520_5549(sequence), condition, condition.Type!);
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,1731,5709);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,1731,5709);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,5645,5694);

rewrittenAssignment = f_10486_5667_5693(lhsRead);
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,1731,5709);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,5725,5771);

f_10486_5725_5770(f_10486_5738_5762(rewrittenAssignment)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,5785,6135);

BoundExpression 
result = (DynAbs.Tracing.TraceSender.Conditional_F1(10486, 5810, 5849)||(((f_10486_5811_5822(temps)== 0 &&(DynAbs.Tracing.TraceSender.Expression_True(10486, 5811, 5848)&&f_10486_5831_5843(stores)== 0)) &&DynAbs.Tracing.TraceSender.Conditional_F2(10486, 5869, 5888))||DynAbs.Tracing.TraceSender.Conditional_F3(10486, 5908, 6134)))?                rewrittenAssignment :f_10486_5908_6134(node.Syntax, f_10486_5982_6001(                    temps), f_10486_6024_6044(                    stores), rewrittenAssignment, f_10486_6109_6133(rewrittenAssignment))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,6151,6164);

f_10486_6151_6163(
            temps);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,6178,6192);

f_10486_6178_6191(            stores);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,6206,6220);

return result;

BoundExpression rewriteAssignment(BoundExpression leftRead)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10486,6236,7918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,6328,6360);

SyntaxNode 
syntax = node.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,6837,7146);

BoundExpression 
opLHS = (DynAbs.Tracing.TraceSender.Conditional_F1(10486, 6861, 6870)||((isDynamic &&DynAbs.Tracing.TraceSender.Conditional_F2(10486, 6873, 6881))||DynAbs.Tracing.TraceSender.Conditional_F3(10486, 6884, 7145)))?leftRead :f_10486_6884_7145(this, syntax: syntax, rewrittenOperand: leftRead, conversion: f_10486_7023_7042(node), rewrittenType: node.Operator.LeftType, @checked: isChecked)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,7166,7336);

BoundExpression 
operand = f_10486_7192_7335(this, syntax, node.Operator.Kind, opLHS, loweredRight, node.Operator.ReturnType, node.Operator.Method, isCompoundAssignment: true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,7356,7392);

f_10486_7356_7391(f_10486_7369_7383(f_10486_7369_7378(node))is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,7410,7742);

BoundExpression 
opFinal = f_10486_7436_7741(this, syntax: syntax, rewrittenOperand: operand, conversion: f_10486_7574_7594(node), rewrittenType: f_10486_7632_7646(f_10486_7632_7641(node)), explicitCastInCode: isDynamic, @checked: isChecked)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,7762,7903);

return f_10486_7769_7902(this, syntax, transformedLHS, opFinal, f_10486_7825_7839(f_10486_7825_7834(node)), used: used, isChecked: isChecked, isCompoundAssignment: true);
DynAbs.Tracing.TraceSender.TraceExitMethod(10486,6236,7918);

Microsoft.CodeAnalysis.CSharp.Conversion
f_10486_7023_7042(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
this_param)
{
var return_v = this_param.LeftConversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 7023, 7042);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_6884_7145(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( syntax: syntax, rewrittenOperand: rewrittenOperand, conversion: conversion, rewrittenType: rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 6884, 7145);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_7192_7335(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,bool
isCompoundAssignment)
{
var return_v = this_param.MakeBinaryOperator( syntax, operatorKind, loweredLeft, loweredRight, type, method, isCompoundAssignment: isCompoundAssignment);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 7192, 7335);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_7369_7378(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 7369, 7378);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10486_7369_7383(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 7369, 7383);
return return_v;
}


int
f_10486_7356_7391(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 7356, 7391);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10486_7574_7594(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
this_param)
{
var return_v = this_param.FinalConversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 7574, 7594);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_7632_7641(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 7632, 7641);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_7632_7646(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 7632, 7646);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_7436_7741(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
explicitCastInCode,bool
@checked)
{
var return_v = this_param.MakeConversionNode( syntax: syntax, rewrittenOperand: rewrittenOperand, conversion: conversion, rewrittenType: rewrittenType, explicitCastInCode: explicitCastInCode, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 7436, 7741);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_7825_7834(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 7825, 7834);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_7825_7839(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 7825, 7839);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_7769_7902(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,bool
used,bool
isChecked,bool
isCompoundAssignment)
{
var return_v = this_param.MakeAssignmentOperator( syntax, rewrittenLeft, rewrittenRight, type, used: used, isChecked: isChecked, isCompoundAssignment: isCompoundAssignment);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 7769, 7902);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10486,6236,7918);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10486,6236,7918);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
DynAbs.Tracing.TraceSender.TraceExitMethod(10486,712,7929);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_872_882(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
this_param)
{
var return_v = this_param.Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 872, 882);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10486_872_887(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 872, 887);
return return_v;
}


bool
f_10486_854_950(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
left,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 854, 950);
return return_v;
}


int
f_10486_841_951(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 841, 951);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_1013_1023(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
this_param)
{
var return_v = this_param.Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 1013, 1023);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10486_997_1024(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 997, 1024);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10486_1053_1092()
{
var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 1053, 1092);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10486_1120_1163()
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 1120, 1163);
return return_v;
}


bool
f_10486_1241_1257(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.IsChecked();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 1241, 1257);
return return_v;
}


bool
f_10486_1289_1305(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.IsDynamic();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 1289, 1305);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10486_1341_1356(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.Operator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 1341, 1356);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_1573_1582(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 1573, 1582);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_1542_1609(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
originalLHS,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
stores,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps,bool
isDynamicAssignment)
{
var return_v = this_param.TransformCompoundAssignmentLHS( originalLHS, stores, temps, isDynamicAssignment);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 1542, 1609);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_1638_1664(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
transformedExpression)
{
var return_v = this_param.MakeRValue( transformedExpression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 1638, 1664);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_1735_1744(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 1735, 1744);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10486_1735_1749(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 1735, 1749);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10486_3032_3071()
{
var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 3032, 3071);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10486_3105_3148()
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 3105, 3148);
return return_v;
}


string
f_10486_3468_3485(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 3468, 3485);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_3487_3508(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
this_param)
{
var return_v = this_param.Receiver;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 3487, 3508);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
f_10486_3429_3509(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
this_param,string
name,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredReceiver)
{
var return_v = this_param.MakeDynamicIsEventTest( name, loweredReceiver);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 3429, 3509);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10486_3408_3572(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 3408, 3572);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10486_3606_3625(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 3606, 3625);
return return_v;
}


int
f_10486_3591_3626(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 3591, 3626);
return 0;
}


int
f_10486_3645_3676(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 3645, 3676);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10486_3794_3871(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 3794, 3871);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10486_3905_3938(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 3905, 3938);
return return_v;
}


int
f_10486_3890_3939(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 3890, 3939);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_4020_4041(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
expression)
{
var return_v = this_param.Not( (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 4020, 4041);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_4077_4100(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 4077, 4100);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_4063_4101(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Null( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 4063, 4101);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_4103_4126(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 4103, 4126);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_3999_4127(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
condition,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
consequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
alternative,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Conditional( condition, (Microsoft.CodeAnalysis.CSharp.BoundExpression)consequence, alternative, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 3999, 4127);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10486_3978_4171(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 3978, 4171);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10486_4205_4230(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 4205, 4230);
return return_v;
}


int
f_10486_4190_4231(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 4190, 4231);
return 0;
}


int
f_10486_4250_4277(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 4250, 4277);
return 0;
}


bool
f_10486_4350_4390(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = CanChangeValueBetweenReads( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 4350, 4390);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10486_4447_4536(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 4447, 4536);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10486_4574_4612(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 4574, 4612);
return return_v;
}


int
f_10486_4559_4613(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 4559, 4613);
return 0;
}


int
f_10486_4636_4675(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 4636, 4675);
return 0;
}


string
f_10486_4930_4947(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 4930, 4947);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_4970_4991(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
this_param)
{
var return_v = this_param.Receiver;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 4970, 4991);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
f_10486_4786_5027(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
this_param,string
accessorName,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredReceiver,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredHandler)
{
var return_v = this_param.MakeDynamicEventAccessorInvocation( accessorName, loweredReceiver, loweredHandler);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 4786, 5027);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_5136_5162(Microsoft.CodeAnalysis.CSharp.BoundExpression
leftRead)
{
var return_v = rewriteAssignment( leftRead);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 5136, 5162);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10486_5194_5218(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 5194, 5218);
return return_v;
}


int
f_10486_5181_5226(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 5181, 5226);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_5388_5412(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 5388, 5412);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_5301_5413(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
condition,Microsoft.CodeAnalysis.CSharp.BoundExpression
consequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
alternative,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Conditional( (Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, consequence, alternative, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 5301, 5413);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10486_5487_5518(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 5487, 5518);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10486_5520_5549(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 5520, 5549);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10486_5456_5578(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax, locals, sideEffects, value, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 5456, 5578);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_5667_5693(Microsoft.CodeAnalysis.CSharp.BoundExpression
leftRead)
{
var return_v = rewriteAssignment( leftRead);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 5667, 5693);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10486_5738_5762(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 5738, 5762);
return return_v;
}


int
f_10486_5725_5770(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 5725, 5770);
return 0;
}


int
f_10486_5811_5822(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 5811, 5822);
return return_v;
}


int
f_10486_5831_5843(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 5831, 5843);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10486_5982_6001(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
var return_v = this_param.ToImmutable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 5982, 6001);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10486_6024_6044(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 6024, 6044);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_6109_6133(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 6109, 6133);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10486_5908_6134(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax, locals, sideEffects, value, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 5908, 6134);
return return_v;
}


int
f_10486_6151_6163(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 6151, 6163);
return 0;
}


int
f_10486_6178_6191(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 6178, 6191);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10486,712,7929);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10486,712,7929);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression? TransformPropertyOrEventReceiver(Symbol propertyOrEvent, BoundExpression? receiverOpt, ArrayBuilder<BoundExpression> stores, ArrayBuilder<LocalSymbol> temps)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10486,7941,11138);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,8148,8250);

f_10486_8148_8249(f_10486_8161_8181(propertyOrEvent)== SymbolKind.Property ||(DynAbs.Tracing.TraceSender.Expression_False(10486, 8161, 8248)||f_10486_8208_8228(propertyOrEvent)== SymbolKind.Event));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,9381,9544) || true) && (receiverOpt == null ||(DynAbs.Tracing.TraceSender.Expression_False(10486, 9385, 9432)||f_10486_9408_9432(propertyOrEvent))||(DynAbs.Tracing.TraceSender.Expression_False(10486, 9385, 9476)||!f_10486_9437_9476(receiverOpt)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,9381,9544);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,9510,9529);

return receiverOpt;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,9381,9544);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,9560,9619);

f_10486_9560_9618(f_10486_9573_9589(receiverOpt)!= BoundKind.TypeExpression);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,9635,9700);

BoundExpression 
rewrittenReceiver = f_10486_9671_9699(this, receiverOpt)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,9716,9757);

BoundAssignmentOperator 
assignmentToTemp
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,10650,10694);

f_10486_10650_10693(f_10486_10663_10685(rewrittenReceiver)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,10708,10835);

var 
variableRepresentsLocation = f_10486_10741_10775(f_10486_10741_10763(rewrittenReceiver))||(DynAbs.Tracing.TraceSender.Expression_False(10486, 10741, 10834)||f_10486_10779_10806(f_10486_10779_10801(rewrittenReceiver))== SymbolKind.TypeParameter)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,10851,10998);

var 
receiverTemp = f_10486_10870_10997(_factory, rewrittenReceiver, out assignmentToTemp, refKind: (DynAbs.Tracing.TraceSender.Conditional_F1(10486, 10941, 10967)||((variableRepresentsLocation &&DynAbs.Tracing.TraceSender.Conditional_F2(10486, 10970, 10981))||DynAbs.Tracing.TraceSender.Conditional_F3(10486, 10984, 10996)))?RefKind.Ref :RefKind.None)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,11012,11041);

f_10486_11012_11040(            stores, assignmentToTemp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,11055,11091);

f_10486_11055_11090(            temps, f_10486_11065_11089(receiverTemp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,11107,11127);

return receiverTemp;
DynAbs.Tracing.TraceSender.TraceExitMethod(10486,7941,11138);

Microsoft.CodeAnalysis.SymbolKind
f_10486_8161_8181(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 8161, 8181);
return return_v;
}


Microsoft.CodeAnalysis.SymbolKind
f_10486_8208_8228(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 8208, 8228);
return return_v;
}


int
f_10486_8148_8249(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 8148, 8249);
return 0;
}


bool
f_10486_9408_9432(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.IsStatic ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 9408, 9432);
return return_v;
}


bool
f_10486_9437_9476(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = CanChangeValueBetweenReads( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 9437, 9476);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10486_9573_9589(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 9573, 9589);
return return_v;
}


int
f_10486_9560_9618(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 9560, 9618);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10486_9671_9699(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 9671, 9699);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10486_10663_10685(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 10663, 10685);
return return_v;
}


int
f_10486_10650_10693(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 10650, 10693);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_10741_10763(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 10741, 10763);
return return_v;
}


bool
f_10486_10741_10775(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.IsValueType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 10741, 10775);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_10779_10801(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 10779, 10801);
return return_v;
}


Microsoft.CodeAnalysis.SymbolKind
f_10486_10779_10806(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 10779, 10806);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10486_10870_10997(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store,Microsoft.CodeAnalysis.RefKind
refKind)
{
var return_v = this_param.StoreToTemp( argument, out store, refKind: refKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 10870, 10997);
return return_v;
}


int
f_10486_11012_11040(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 11012, 11040);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10486_11065_11089(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 11065, 11089);
return return_v;
}


int
f_10486_11055_11090(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 11055, 11090);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10486,7941,11138);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10486,7941,11138);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundDynamicMemberAccess TransformDynamicMemberAccess(BoundDynamicMemberAccess memberAccess, ArrayBuilder<BoundExpression> stores, ArrayBuilder<LocalSymbol> temps)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10486,11150,12042);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,11346,11469) || true) && (!f_10486_11351_11400(f_10486_11378_11399(memberAccess)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,11346,11469);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,11434,11454);

return memberAccess;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,11346,11469);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,11525,11588);

var 
rewrittenReceiver = f_10486_11549_11587(this, f_10486_11565_11586(memberAccess))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,11602,11643);

BoundAssignmentOperator 
assignmentToTemp
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,11657,11738);

var 
receiverTemp = f_10486_11676_11737(_factory, rewrittenReceiver, out assignmentToTemp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,11752,11781);

f_10486_11752_11780(            stores, assignmentToTemp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,11795,11831);

f_10486_11795_11830(            temps, f_10486_11805_11829(receiverTemp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,11847,12031);

return f_10486_11854_12030(memberAccess.Syntax, receiverTemp, f_10486_11918_11947(memberAccess), f_10486_11949_11966(memberAccess), f_10486_11968_11988(memberAccess), f_10486_11990_12010(memberAccess), f_10486_12012_12029(memberAccess));
DynAbs.Tracing.TraceSender.TraceExitMethod(10486,11150,12042);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_11378_11399(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
this_param)
{
var return_v = this_param.Receiver;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 11378, 11399);
return return_v;
}


bool
f_10486_11351_11400(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = CanChangeValueBetweenReads( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 11351, 11400);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_11565_11586(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
this_param)
{
var return_v = this_param.Receiver;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 11565, 11586);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10486_11549_11587(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 11549, 11587);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10486_11676_11737(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 11676, 11737);
return return_v;
}


int
f_10486_11752_11780(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 11752, 11780);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10486_11805_11829(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 11805, 11829);
return return_v;
}


int
f_10486_11795_11830(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 11795, 11830);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
f_10486_11918_11947(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
this_param)
{
var return_v = this_param.TypeArgumentsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 11918, 11947);
return return_v;
}


string
f_10486_11949_11966(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 11949, 11966);
return return_v;
}


bool
f_10486_11968_11988(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
this_param)
{
var return_v = this_param.Invoked;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 11968, 11988);
return return_v;
}


bool
f_10486_11990_12010(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
this_param)
{
var return_v = this_param.Indexed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 11990, 12010);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_12012_12029(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 12012, 12029);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
f_10486_11854_12030(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
receiver,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
typeArgumentsOpt,string
name,bool
invoked,bool
indexed,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, typeArgumentsOpt, name, invoked, indexed, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 11854, 12030);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10486,11150,12042);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10486,11150,12042);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundIndexerAccess TransformIndexerAccess(BoundIndexerAccess indexerAccess, ArrayBuilder<BoundExpression> stores, ArrayBuilder<LocalSymbol> temps)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10486,12054,20484);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,12233,12277);

var 
receiverOpt = f_10486_12251_12276(indexerAccess)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,12291,12325);

f_10486_12291_12324(receiverOpt != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,12341,12377);

BoundExpression 
transformedReceiver
=default(BoundExpression);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,12391,14161) || true) && (f_10486_12395_12434(receiverOpt))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,12391,14161);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,12468,12533);

BoundExpression 
rewrittenReceiver = f_10486_12504_12532(this, receiverOpt)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,12553,12594);

BoundAssignmentOperator 
assignmentToTemp
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,13519,13563);

f_10486_13519_13562(f_10486_13532_13554(rewrittenReceiver)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,13581,13708);

var 
variableRepresentsLocation = f_10486_13614_13648(f_10486_13614_13636(rewrittenReceiver))||(DynAbs.Tracing.TraceSender.Expression_False(10486, 13614, 13707)||f_10486_13652_13679(f_10486_13652_13674(rewrittenReceiver))== SymbolKind.TypeParameter)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,13728,13875);

var 
receiverTemp = f_10486_13747_13874(_factory, rewrittenReceiver, out assignmentToTemp, refKind: (DynAbs.Tracing.TraceSender.Conditional_F1(10486, 13818, 13844)||((variableRepresentsLocation &&DynAbs.Tracing.TraceSender.Conditional_F2(10486, 13847, 13858))||DynAbs.Tracing.TraceSender.Conditional_F3(10486, 13861, 13873)))?RefKind.Ref :RefKind.None)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,13893,13928);

transformedReceiver = receiverTemp;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,13946,13975);

f_10486_13946_13974(                stores, assignmentToTemp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,13993,14029);

f_10486_13993_14028(                temps, f_10486_14003_14027(receiverTemp));
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,12391,14161);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,12391,14161);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,14095,14146);

transformedReceiver = f_10486_14117_14145(this, receiverOpt);
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,12391,14161);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,16395,16483);

ImmutableArray<BoundExpression> 
rewrittenArguments = f_10486_16448_16482(this, f_10486_16458_16481(indexerAccess))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,16499,16540);

SyntaxNode 
syntax = indexerAccess.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,16554,16601);

PropertySymbol 
indexer = f_10486_16579_16600(indexerAccess)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,16615,16692);

ImmutableArray<RefKind> 
argumentRefKinds = f_10486_16658_16691(indexerAccess)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,16706,16745);

bool 
expanded = f_10486_16722_16744(indexerAccess)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,16759,16827);

ImmutableArray<int> 
argsToParamsOpt = f_10486_16797_16826(indexerAccess)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,16843,16907);

ImmutableArray<ParameterSymbol> 
parameters = f_10486_16888_16906(indexer)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,16921,16996);

BoundExpression[] 
actualArguments = new BoundExpression[parameters.Length]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,17097,17228);

ArrayBuilder<BoundAssignmentOperator> 
storesToTemps = f_10486_17151_17227(rewrittenArguments.Length)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,17242,17342);

ArrayBuilder<RefKind> 
refKinds = f_10486_17275_17341(parameters.Length, RefKind.None)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,17629,18029);

f_10486_17629_18028(this, expanded, argsToParamsOpt, parameters, argumentRefKinds, rewrittenArguments, forceLambdaSpilling: true, actualArguments, refKinds, storesToTemps);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,18140,18653) || true) && (expanded)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,18140,18653);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,18186,18338);

BoundExpression 
array = f_10486_18210_18337(this, syntax, indexer, argsToParamsOpt, rewrittenArguments, parameters, actualArguments[f_10486_18309_18331(actualArguments)- 1])
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,18356,18392);

BoundAssignmentOperator 
storeToTemp
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,18410,18471);

var 
boundTemp = f_10486_18426_18470(_factory, array, out storeToTemp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,18489,18513);

f_10486_18489_18512(                stores, storeToTemp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,18531,18564);

f_10486_18531_18563(                temps, f_10486_18541_18562(boundTemp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,18582,18638);

actualArguments[f_10486_18598_18620(actualArguments)- 1] = boundTemp;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,18140,18653);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,18889,18981);

var 
accessor = f_10486_18904_18940(indexer)??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?>(10486, 18904, 18980)??f_10486_18944_18980(indexer))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,18995,19030);

f_10486_18995_19029(accessor is not null);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,19234,19394) || true) && (f_10486_19238_19272(f_10486_19238_19260(indexer)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,19234,19394);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,19306,19379);

f_10486_19306_19378(this, parameters, actualArguments, refKinds, temps);
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,19234,19394);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,19410,19475);

f_10486_19410_19474(f_10486_19423_19473(actualArguments, static arg => arg is not null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,19489,19546);

rewrittenArguments = f_10486_19510_19545(actualArguments);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,19562,19777);
foreach(BoundAssignmentOperator tempAssignment in f_10486_19613_19626_I(storesToTemps) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,19562,19777);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,19660,19717);

f_10486_19660_19716(                temps, f_10486_19670_19715(((BoundLocal)f_10486_19683_19702(tempAssignment))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,19735,19762);

f_10486_19735_19761(                stores, tempAssignment);
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,19562,19777);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10486,1,216);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10486,1,216);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,19793,19814);

f_10486_19793_19813(
            storesToTemps);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,19828,19875);

argumentRefKinds = f_10486_19847_19874(refKinds);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,19889,19905);

f_10486_19889_19904(            refKinds);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,20023,20473);

return f_10486_20030_20472(syntax, transformedReceiver, indexer, rewrittenArguments, argumentNamesOpt: default(ImmutableArray<string>), argumentRefKinds, expanded: false, argsToParamsOpt: default(ImmutableArray<int>), defaultArguments: default(BitVector), f_10486_20453_20471(indexerAccess));
DynAbs.Tracing.TraceSender.TraceExitMethod(10486,12054,20484);

Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10486_12251_12276(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.ReceiverOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 12251, 12276);
return return_v;
}


int
f_10486_12291_12324(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 12291, 12324);
return 0;
}


bool
f_10486_12395_12434(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = CanChangeValueBetweenReads( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 12395, 12434);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10486_12504_12532(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 12504, 12532);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10486_13532_13554(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 13532, 13554);
return return_v;
}


int
f_10486_13519_13562(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 13519, 13562);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_13614_13636(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 13614, 13636);
return return_v;
}


bool
f_10486_13614_13648(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.IsValueType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 13614, 13648);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_13652_13674(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 13652, 13674);
return return_v;
}


Microsoft.CodeAnalysis.SymbolKind
f_10486_13652_13679(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 13652, 13679);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10486_13747_13874(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store,Microsoft.CodeAnalysis.RefKind
refKind)
{
var return_v = this_param.StoreToTemp( argument, out store, refKind: refKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 13747, 13874);
return return_v;
}


int
f_10486_13946_13974(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 13946, 13974);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10486_14003_14027(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 14003, 14027);
return return_v;
}


int
f_10486_13993_14028(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 13993, 14028);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10486_14117_14145(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 14117, 14145);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10486_16458_16481(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 16458, 16481);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10486_16448_16482(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
list)
{
var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundExpression>( list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 16448, 16482);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
f_10486_16579_16600(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.Indexer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 16579, 16600);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
f_10486_16658_16691(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.ArgumentRefKindsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 16658, 16691);
return return_v;
}


bool
f_10486_16722_16744(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.Expanded;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 16722, 16744);
return return_v;
}


System.Collections.Immutable.ImmutableArray<int>
f_10486_16797_16826(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.ArgsToParamsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 16797, 16826);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
f_10486_16888_16906(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 16888, 16906);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
f_10486_17151_17227(int
capacity)
{
var return_v = ArrayBuilder<BoundAssignmentOperator>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 17151, 17227);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
f_10486_17275_17341(int
capacity,Microsoft.CodeAnalysis.RefKind
fillWithValue)
{
var return_v = ArrayBuilder<RefKind>.GetInstance( capacity, fillWithValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 17275, 17341);
return return_v;
}


int
f_10486_17629_18028(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,bool
expanded,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
parameters,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKinds,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments,bool
forceLambdaSpilling,Microsoft.CodeAnalysis.CSharp.BoundExpression[]
arguments,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
refKinds,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
storesToTemps)
{
this_param.BuildStoresToTemps( expanded, argsToParamsOpt, parameters, argumentRefKinds, rewrittenArguments, forceLambdaSpilling: forceLambdaSpilling, arguments, refKinds, storesToTemps);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 17629, 18028);
return 0;
}


int
f_10486_18309_18331(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 18309, 18331);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_18210_18337(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
methodOrIndexer,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
parameters,Microsoft.CodeAnalysis.CSharp.BoundExpression
tempStoreArgument)
{
var return_v = this_param.BuildParamsArray( syntax, (Microsoft.CodeAnalysis.CSharp.Symbol)methodOrIndexer, argsToParamsOpt, rewrittenArguments, parameters, tempStoreArgument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 18210, 18337);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10486_18426_18470(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 18426, 18470);
return return_v;
}


int
f_10486_18489_18512(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 18489, 18512);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10486_18541_18562(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 18541, 18562);
return return_v;
}


int
f_10486_18531_18563(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 18531, 18563);
return 0;
}


int
f_10486_18598_18620(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 18598, 18620);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10486_18904_18940(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
property)
{
var return_v = property.GetOwnOrInheritedGetMethod();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 18904, 18940);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10486_18944_18980(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
property)
{
var return_v = property.GetOwnOrInheritedSetMethod();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 18944, 18980);
return return_v;
}


int
f_10486_18995_19029(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 18995, 19029);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10486_19238_19260(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 19238, 19260);
return return_v;
}


bool
f_10486_19238_19272(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.IsComImport;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 19238, 19272);
return return_v;
}


int
f_10486_19306_19378(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
parameters,Microsoft.CodeAnalysis.CSharp.BoundExpression[]
actualArguments,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
argsRefKindsBuilder,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temporariesBuilder)
{
this_param.RewriteArgumentsForComCall( parameters, actualArguments, argsRefKindsBuilder, temporariesBuilder);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 19306, 19378);
return 0;
}


bool
f_10486_19423_19473(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
source,System.Func<Microsoft.CodeAnalysis.CSharp.BoundExpression, bool>
predicate)
{
var return_v = source.All<Microsoft.CodeAnalysis.CSharp.BoundExpression>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 19423, 19473);
return return_v;
}


int
f_10486_19410_19474(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 19410, 19474);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10486_19510_19545(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
items)
{
var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.BoundExpression>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 19510, 19545);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_19683_19702(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 19683, 19702);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10486_19670_19715(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 19670, 19715);
return return_v;
}


int
f_10486_19660_19716(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 19660, 19716);
return 0;
}


int
f_10486_19735_19761(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 19735, 19761);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
f_10486_19613_19626_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 19613, 19626);
return return_v;
}


int
f_10486_19793_19813(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 19793, 19813);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
f_10486_19847_19874(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
refKinds)
{
var return_v = GetRefKindsOrNull( refKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 19847, 19874);
return return_v;
}


int
f_10486_19889_19904(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 19889, 19904);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_20453_20471(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 20453, 20471);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
f_10486_20030_20472(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
indexer,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments,System.Collections.Immutable.ImmutableArray<string>
argumentNamesOpt,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKindsOpt,bool
expanded,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,Microsoft.CodeAnalysis.BitVector
defaultArguments,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess( syntax, receiverOpt, indexer, arguments, argumentNamesOpt: argumentNamesOpt, argumentRefKindsOpt, expanded: expanded, argsToParamsOpt: argsToParamsOpt, defaultArguments: defaultArguments, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 20030, 20472);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10486,12054,20484);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10486,12054,20484);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression TransformPatternIndexerAccess(
            BoundIndexOrRangePatternIndexerAccess indexerAccess,
            ArrayBuilder<BoundExpression> stores,
            ArrayBuilder<LocalSymbol> temps,
            bool isDynamicAssignment)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10486,20496,21492);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,21185,21279);

var 
sequence = f_10486_21200_21278(this, indexerAccess, isLeftOfAssignment: true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,21293,21331);

f_10486_21293_21330(            stores, f_10486_21309_21329(sequence));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,21345,21377);

f_10486_21345_21376(            temps, f_10486_21360_21375(sequence));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,21391,21481);

return f_10486_21398_21480(this, f_10486_21429_21443(sequence), stores, temps, isDynamicAssignment);
DynAbs.Tracing.TraceSender.TraceExitMethod(10486,20496,21492);

Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10486_21200_21278(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
node,bool
isLeftOfAssignment)
{
var return_v = this_param.VisitIndexOrRangePatternIndexerAccess( node, isLeftOfAssignment: isLeftOfAssignment);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 21200, 21278);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10486_21309_21329(Microsoft.CodeAnalysis.CSharp.BoundSequence
this_param)
{
var return_v = this_param.SideEffects;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 21309, 21329);
return return_v;
}


int
f_10486_21293_21330(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
items)
{
this_param.AddRange( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 21293, 21330);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10486_21360_21375(Microsoft.CodeAnalysis.CSharp.BoundSequence
this_param)
{
var return_v = this_param.Locals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 21360, 21375);
return return_v;
}


int
f_10486_21345_21376(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
items)
{
this_param.AddRange( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 21345, 21376);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_21429_21443(Microsoft.CodeAnalysis.CSharp.BoundSequence
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 21429, 21443);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_21398_21480(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
originalLHS,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
stores,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps,bool
isDynamicAssignment)
{
var return_v = this_param.TransformCompoundAssignmentLHS( originalLHS, stores, temps, isDynamicAssignment);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 21398, 21480);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10486,20496,21492);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10486,20496,21492);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool TransformCompoundAssignmentFieldOrEventAccessReceiver(Symbol fieldOrEvent, ref BoundExpression? receiver, ArrayBuilder<BoundExpression> stores, ArrayBuilder<LocalSymbol> temps)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10486,21734,23679);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,21948,22041);

f_10486_21948_22040(f_10486_21961_21978(fieldOrEvent)== SymbolKind.Field ||(DynAbs.Tracing.TraceSender.Expression_False(10486, 21961, 22039)||f_10486_22002_22019(fieldOrEvent)== SymbolKind.Event));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,22194,22280) || true) && (f_10486_22198_22219(fieldOrEvent))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,22194,22280);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,22253,22265);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,22194,22280);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,22296,22336);

f_10486_22296_22335(receiver is { Type: { } });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,22350,22567) || true) && (!f_10486_22355_22391(receiver))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,22350,22567);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,22425,22437);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,22350,22567);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,22350,22567);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,22471,22567) || true) && (f_10486_22475_22505_M(!f_10486_22476_22489(receiver).IsReferenceType))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,22471,22567);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,22539,22552);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,22471,22567);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,22350,22567);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,22583,22627);

f_10486_22583_22626(f_10486_22596_22625(f_10486_22596_22609(receiver)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,22641,22697);

f_10486_22641_22696(f_10486_22654_22667(receiver)!= BoundKind.TypeExpression);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,22711,22773);

BoundExpression 
rewrittenReceiver = f_10486_22747_22772(this, receiver)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,22789,22833);

f_10486_22789_22832(f_10486_22802_22824(rewrittenReceiver)is { });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,22847,23359) || true) && (f_10486_22851_22891(f_10486_22851_22873(rewrittenReceiver)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,22847,23359);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,22925,22980);

var 
memberContainingType = f_10486_22952_22979(fieldOrEvent)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,23271,23344);

rewrittenReceiver = f_10486_23291_23343(this, rewrittenReceiver, memberContainingType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,22847,23359);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,23375,23416);

BoundAssignmentOperator 
assignmentToTemp
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,23430,23511);

var 
receiverTemp = f_10486_23449_23510(_factory, rewrittenReceiver, out assignmentToTemp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,23525,23554);

f_10486_23525_23553(            stores, assignmentToTemp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,23568,23604);

f_10486_23568_23603(            temps, f_10486_23578_23602(receiverTemp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,23618,23642);

receiver = receiverTemp;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,23656,23668);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(10486,21734,23679);

Microsoft.CodeAnalysis.SymbolKind
f_10486_21961_21978(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 21961, 21978);
return return_v;
}


Microsoft.CodeAnalysis.SymbolKind
f_10486_22002_22019(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 22002, 22019);
return return_v;
}


int
f_10486_21948_22040(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 21948, 22040);
return 0;
}


bool
f_10486_22198_22219(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.IsStatic;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 22198, 22219);
return return_v;
}


int
f_10486_22296_22335(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 22296, 22335);
return 0;
}


bool
f_10486_22355_22391(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = CanChangeValueBetweenReads( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 22355, 22391);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_22476_22489(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 22476, 22489);
return return_v;
}


bool
f_10486_22475_22505_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 22475, 22505);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_22596_22609(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 22596, 22609);
return return_v;
}


bool
f_10486_22596_22625(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.IsReferenceType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 22596, 22625);
return return_v;
}


int
f_10486_22583_22626(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 22583, 22626);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10486_22654_22667(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 22654, 22667);
return return_v;
}


int
f_10486_22641_22696(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 22641, 22696);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10486_22747_22772(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 22747, 22772);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10486_22802_22824(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 22802, 22824);
return return_v;
}


int
f_10486_22789_22832(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 22789, 22832);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_22851_22873(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 22851, 22873);
return return_v;
}


bool
f_10486_22851_22891(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsTypeParameter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 22851, 22891);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10486_22952_22979(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 22952, 22979);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_23291_23343(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenReceiver,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
memberContainingType)
{
var return_v = this_param.BoxReceiver( rewrittenReceiver, memberContainingType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 23291, 23343);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10486_23449_23510(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 23449, 23510);
return return_v;
}


int
f_10486_23525_23553(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 23525, 23553);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10486_23578_23602(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 23578, 23602);
return return_v;
}


int
f_10486_23568_23603(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 23568, 23603);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10486,21734,23679);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10486,21734,23679);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundDynamicIndexerAccess TransformDynamicIndexerAccess(BoundDynamicIndexerAccess indexerAccess, ArrayBuilder<BoundExpression> stores, ArrayBuilder<LocalSymbol> temps)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10486,23691,25666);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,23891,23923);

BoundExpression 
loweredReceiver
=default(BoundExpression);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,23937,24435) || true) && (f_10486_23941_23991(f_10486_23968_23990(indexerAccess)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,23937,24435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,24025,24066);

BoundAssignmentOperator 
assignmentToTemp
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,24084,24179);

var 
temp = f_10486_24095_24178(_factory, f_10486_24116_24155(this, f_10486_24132_24154(indexerAccess)), out assignmentToTemp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,24197,24226);

f_10486_24197_24225(                stores, assignmentToTemp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,24244,24272);

f_10486_24244_24271(                temps, f_10486_24254_24270(temp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,24290,24313);

loweredReceiver = temp;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,23937,24435);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,23937,24435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,24379,24420);

loweredReceiver = f_10486_24397_24419(indexerAccess);
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,23937,24435);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,24451,24491);

var 
arguments = f_10486_24467_24490(indexerAccess)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,24505,24566);

var 
loweredArguments = new BoundExpression[arguments.Length]
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,24591,24596);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,24582,25284) || true) && (i < arguments.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,24620,24623)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(10486,24582,25284))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,24582,25284);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,24657,25269) || true) && (f_10486_24661_24701(arguments[i]))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,24657,25269);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,24743,24784);

BoundAssignmentOperator 
assignmentToTemp
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,24806,24983);

var 
temp = f_10486_24817_24982(_factory, f_10486_24838_24867(this, arguments[i]), out assignmentToTemp, (DynAbs.Tracing.TraceSender.Conditional_F1(10486, 24891, 24952)||((indexerAccess.ArgumentRefKindsOpt.RefKinds(i)!= RefKind.None &&DynAbs.Tracing.TraceSender.Conditional_F2(10486, 24955, 24966))||DynAbs.Tracing.TraceSender.Conditional_F3(10486, 24969, 24981)))?RefKind.Ref :RefKind.None)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,25005,25034);

f_10486_25005_25033(                    stores, assignmentToTemp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,25056,25084);

f_10486_25056_25083(                    temps, f_10486_25066_25082(temp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,25106,25133);

loweredArguments[i] = temp;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,24657,25269);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,24657,25269);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,25215,25250);

loweredArguments[i] = arguments[i];
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,24657,25269);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10486,1,703);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10486,1,703);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,25300,25655);

return f_10486_25307_25654(indexerAccess.Syntax, loweredReceiver, f_10486_25428_25464(                loweredArguments), f_10486_25483_25513(indexerAccess), f_10486_25532_25565(indexerAccess), f_10486_25584_25616(indexerAccess), f_10486_25635_25653(indexerAccess));
DynAbs.Tracing.TraceSender.TraceExitMethod(10486,23691,25666);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_23968_23990(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.Receiver;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 23968, 23990);
return return_v;
}


bool
f_10486_23941_23991(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = CanChangeValueBetweenReads( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 23941, 23991);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_24132_24154(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.Receiver;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 24132, 24154);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10486_24116_24155(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 24116, 24155);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10486_24095_24178(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 24095, 24178);
return return_v;
}


int
f_10486_24197_24225(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 24197, 24225);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10486_24254_24270(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 24254, 24270);
return return_v;
}


int
f_10486_24244_24271(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 24244, 24271);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_24397_24419(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.Receiver;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 24397, 24419);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10486_24467_24490(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 24467, 24490);
return return_v;
}


bool
f_10486_24661_24701(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = CanChangeValueBetweenReads( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 24661, 24701);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10486_24838_24867(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 24838, 24867);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10486_24817_24982(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store,Microsoft.CodeAnalysis.RefKind
refKind)
{
var return_v = this_param.StoreToTemp( argument, out store, refKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 24817, 24982);
return return_v;
}


int
f_10486_25005_25033(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 25005, 25033);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10486_25066_25082(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 25066, 25082);
return return_v;
}


int
f_10486_25056_25083(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 25056, 25083);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10486_25428_25464(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
items)
{
var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.BoundExpression>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 25428, 25464);
return return_v;
}


System.Collections.Immutable.ImmutableArray<string>
f_10486_25483_25513(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.ArgumentNamesOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 25483, 25513);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
f_10486_25532_25565(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.ArgumentRefKindsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 25532, 25565);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
f_10486_25584_25616(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.ApplicableIndexers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 25584, 25616);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_25635_25653(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 25635, 25653);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
f_10486_25307_25654(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiver,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments,System.Collections.Immutable.ImmutableArray<string>
argumentNamesOpt,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKindsOpt,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
applicableIndexers,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess( syntax, receiver, arguments, argumentNamesOpt, argumentRefKindsOpt, applicableIndexers, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 25307, 25654);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10486,23691,25666);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10486,23691,25666);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression TransformCompoundAssignmentLHS(BoundExpression originalLHS, ArrayBuilder<BoundExpression> stores, ArrayBuilder<LocalSymbol> temps, bool isDynamicAssignment)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10486,26794,37449);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,28291,36539);

switch (f_10486_28299_28315(originalLHS))
            {

case BoundKind.PropertyAccess:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,28291,36539);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,28607,28661);

var 
propertyAccess = (BoundPropertyAccess)originalLHS
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,28687,29221) || true) && (f_10486_28691_28728(f_10486_28691_28720(propertyAccess))== RefKind.None)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,28687,29221);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,28920,29194);

return f_10486_28927_29193(propertyAccess, f_10486_28949_29055(this, f_10486_28982_29011(propertyAccess), f_10486_29013_29039(propertyAccess), stores, temps), f_10486_29115_29144(propertyAccess), f_10486_29146_29171(propertyAccess), f_10486_29173_29192(propertyAccess));
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,28687,29221);
}
                    }
DynAbs.Tracing.TraceSender.TraceBreak(10486,29266,29272);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,28291,36539);

case BoundKind.IndexerAccess:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,28291,36539);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,29547,29599);

var 
indexerAccess = (BoundIndexerAccess)originalLHS
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,29625,29837) || true) && (f_10486_29629_29658(f_10486_29629_29650(indexerAccess))== RefKind.None)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,29625,29837);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,29732,29810);

return f_10486_29739_29809(this, originalLHS, stores, temps);
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,29625,29837);
}
                    }
DynAbs.Tracing.TraceSender.TraceBreak(10486,29882,29888);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,28291,36539);

case BoundKind.IndexOrRangePatternIndexerAccess:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,28291,36539);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,30005,30083);

var 
patternIndexerAccess = (BoundIndexOrRangePatternIndexerAccess)originalLHS
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,30109,30423);

RefKind 
refKind = f_10486_30127_30161(patternIndexerAccess)switch
                        {
                            PropertySymbol p when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,30225,30254) && DynAbs.Tracing.TraceSender.Expression_True(10486,30225,30254))
=> f_10486_30245_30254(p),
                            MethodSymbol m when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,30285,30312) && DynAbs.Tracing.TraceSender.Expression_True(10486,30285,30312))
=> f_10486_30303_30312(m),
                            var x when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,30343,30395) && DynAbs.Tracing.TraceSender.Expression_True(10486,30343,30395))
=> throw f_10486_30358_30395(x)                        }
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,30449,30656) || true) && (refKind == RefKind.None)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,30449,30656);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,30534,30629);

return f_10486_30541_30628(this, patternIndexerAccess, stores, temps, isDynamicAssignment);
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,30449,30656);
}
                    }
DynAbs.Tracing.TraceSender.TraceBreak(10486,30701,30707);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,28291,36539);

case BoundKind.FieldAccess:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,28291,36539);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,31211,31259);

var 
fieldAccess = (BoundFieldAccess)originalLHS
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,31285,31340);

BoundExpression? 
receiverOpt = f_10486_31316_31339(fieldAccess)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,31368,31733) || true) && (f_10486_31372_31482(this, f_10486_31426_31449(fieldAccess), ref receiverOpt, stores, temps))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,31368,31733);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,31540,31706);

return f_10486_31547_31705(this, fieldAccess.Syntax, receiverOpt, f_10486_31596_31619(fieldAccess), f_10486_31621_31649(fieldAccess), f_10486_31651_31673(fieldAccess), f_10486_31675_31691(fieldAccess), fieldAccess);
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,31368,31733);
}
                    }
DynAbs.Tracing.TraceSender.TraceBreak(10486,31778,31784);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,28291,36539);

case BoundKind.ArrayAccess:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,28291,36539);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,31880,31928);

var 
arrayAccess = (BoundArrayAccess)originalLHS
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,31954,33509) || true) && (isDynamicAssignment ||(DynAbs.Tracing.TraceSender.Expression_False(10486, 31958, 32027)||!f_10486_31982_32027(f_10486_31999_32026(f_10486_31999_32021(arrayAccess)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,31954,33509);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,33233,33292);

var 
loweredArray = f_10486_33252_33291(this, f_10486_33268_33290(arrayAccess))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,33322,33374);

var 
loweredIndices = f_10486_33343_33373(this, f_10486_33353_33372(arrayAccess))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,33406,33482);

return f_10486_33413_33481(this, loweredArray, loweredIndices, stores, temps);
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,31954,33509);
}
                    }
DynAbs.Tracing.TraceSender.TraceBreak(10486,33554,33560);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,28291,36539);

case BoundKind.DynamicMemberAccess:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,28291,36539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,33637,33727);

return f_10486_33644_33726(this, originalLHS, stores, temps);
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,28291,36539);

case BoundKind.DynamicIndexerAccess:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,28291,36539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,33805,33897);

return f_10486_33812_33896(this, originalLHS, stores, temps);
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,28291,36539);

case BoundKind.Local:
                case BoundKind.Parameter:
                case BoundKind.ThisReference: // a special kind of parameter
                case BoundKind.PseudoVariable:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,28291,36539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,34216,34235);

return originalLHS;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,28291,36539);

case BoundKind.Call:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,28291,36539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,34297,34367);

f_10486_34297_34366(f_10486_34310_34349(f_10486_34310_34341(((BoundCall)originalLHS)))!= RefKind.None);
DynAbs.Tracing.TraceSender.TraceBreak(10486,34389,34395);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,28291,36539);

case BoundKind.FunctionPointerInvocation:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,28291,36539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,34478,34588);

f_10486_34478_34587(f_10486_34491_34570(f_10486_34491_34562(f_10486_34491_34552(((BoundFunctionPointerInvocation)originalLHS))))!= RefKind.None);
DynAbs.Tracing.TraceSender.TraceBreak(10486,34610,34616);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,28291,36539);

case BoundKind.ConditionalOperator:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,28291,36539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,34693,34753);

f_10486_34693_34752(f_10486_34706_34751(((BoundConditionalOperator)originalLHS)));
DynAbs.Tracing.TraceSender.TraceBreak(10486,34775,34781);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,28291,36539);

case BoundKind.AssignmentOperator:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,28291,36539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,34857,34916);

f_10486_34857_34915(f_10486_34870_34914(((BoundAssignmentOperator)originalLHS)));
DynAbs.Tracing.TraceSender.TraceBreak(10486,34938,34944);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,28291,36539);

case BoundKind.PointerElementAccess:
                case BoundKind.PointerIndirectionOperator:
                case BoundKind.RefValueOperator:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,28291,36539);
DynAbs.Tracing.TraceSender.TraceBreak(10486,35132,35138);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,28291,36539);

case BoundKind.EventAccess:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,28291,36539);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,35234,35282);

var 
eventAccess = (BoundEventAccess)originalLHS
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,35308,35350);

f_10486_35308_35349(f_10486_35321_35348(eventAccess));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,35376,35431);

BoundExpression? 
receiverOpt = f_10486_35407_35430(eventAccess)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,35459,35987) || true) && (f_10486_35463_35508(f_10486_35463_35486(eventAccess)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,35459,35987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,35684,35960);

return f_10486_35691_35959(eventAccess, f_10486_35710_35807(this, f_10486_35743_35766(eventAccess), f_10486_35768_35791(eventAccess), stores, temps), f_10486_35864_35887(eventAccess), f_10486_35889_35916(eventAccess), f_10486_35918_35940(eventAccess), f_10486_35942_35958(eventAccess));
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,35459,35987);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,36015,36364) || true) && (f_10486_36019_36129(this, f_10486_36073_36096(eventAccess), ref receiverOpt, stores, temps))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,36015,36364);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,36187,36337);

return f_10486_36194_36336(this, eventAccess.Syntax, receiverOpt, f_10486_36243_36266(eventAccess), f_10486_36268_36293(eventAccess), f_10486_36295_36317(eventAccess), f_10486_36319_36335(eventAccess));
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,36015,36364);
}
                    }
DynAbs.Tracing.TraceSender.TraceBreak(10486,36409,36415);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,28291,36539);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,28291,36539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,36465,36524);

throw f_10486_36471_36523(f_10486_36506_36522(originalLHS));
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,28291,36539);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,37069,37134);

BoundExpression 
rewrittenVariable = f_10486_37105_37133(this, originalLHS)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,37150,37192);

BoundAssignmentOperator 
assignmentToTemp2
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,37206,37310);

var 
variableTemp = f_10486_37225_37309(_factory, rewrittenVariable, out assignmentToTemp2, refKind: RefKind.Ref)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,37324,37354);

f_10486_37324_37353(            stores, assignmentToTemp2);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,37368,37404);

f_10486_37368_37403(            temps, f_10486_37378_37402(variableTemp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,37418,37438);

return variableTemp;
DynAbs.Tracing.TraceSender.TraceExitMethod(10486,26794,37449);

Microsoft.CodeAnalysis.CSharp.BoundKind
f_10486_28299_28315(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 28299, 28315);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
f_10486_28691_28720(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
this_param)
{
var return_v = this_param.PropertySymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 28691, 28720);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_10486_28691_28728(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
this_param)
{
var return_v = this_param.RefKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 28691, 28728);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
f_10486_28982_29011(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
this_param)
{
var return_v = this_param.PropertySymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 28982, 29011);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10486_29013_29039(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
this_param)
{
var return_v = this_param.ReceiverOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 29013, 29039);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10486_28949_29055(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
propertyOrEvent,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
stores,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps)
{
var return_v = this_param.TransformPropertyOrEventReceiver( (Microsoft.CodeAnalysis.CSharp.Symbol)propertyOrEvent, receiverOpt, stores, temps);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 28949, 29055);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
f_10486_29115_29144(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
this_param)
{
var return_v = this_param.PropertySymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 29115, 29144);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LookupResultKind
f_10486_29146_29171(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
this_param)
{
var return_v = this_param.ResultKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 29146, 29171);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_29173_29192(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 29173, 29192);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
f_10486_28927_29193(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
propertySymbol,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Update( receiverOpt, propertySymbol, resultKind, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 28927, 29193);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
f_10486_29629_29650(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.Indexer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 29629, 29650);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_10486_29629_29658(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
this_param)
{
var return_v = this_param.RefKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 29629, 29658);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
f_10486_29739_29809(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
indexerAccess,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
stores,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps)
{
var return_v = this_param.TransformIndexerAccess( (Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess)indexerAccess, stores, temps);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 29739, 29809);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10486_30127_30161(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
this_param)
{
var return_v = this_param.PatternSymbol ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 30127, 30161);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_10486_30245_30254(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
this_param)
{
var return_v = this_param.RefKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 30245, 30254);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_10486_30303_30312(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.RefKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 30303, 30312);
return return_v;
}


System.Exception
f_10486_30358_30395(Microsoft.CodeAnalysis.CSharp.Symbol
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 30358, 30395);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_30541_30628(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
indexerAccess,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
stores,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps,bool
isDynamicAssignment)
{
var return_v = this_param.TransformPatternIndexerAccess( indexerAccess, stores, temps, isDynamicAssignment);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 30541, 30628);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10486_31316_31339(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
this_param)
{
var return_v = this_param.ReceiverOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 31316, 31339);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
f_10486_31426_31449(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
this_param)
{
var return_v = this_param.FieldSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 31426, 31449);
return return_v;
}


bool
f_10486_31372_31482(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
fieldOrEvent,ref Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiver,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
stores,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps)
{
var return_v = this_param.TransformCompoundAssignmentFieldOrEventAccessReceiver( (Microsoft.CodeAnalysis.CSharp.Symbol)fieldOrEvent, ref receiver, stores, temps);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 31372, 31482);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
f_10486_31596_31619(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
this_param)
{
var return_v = this_param.FieldSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 31596, 31619);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10486_31621_31649(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
this_param)
{
var return_v = this_param.ConstantValueOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 31621, 31649);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LookupResultKind
f_10486_31651_31673(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
this_param)
{
var return_v = this_param.ResultKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 31651, 31673);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_31675_31691(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 31675, 31691);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_31547_31705(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
rewrittenReceiver,Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
fieldSymbol,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
oldNodeOpt)
{
var return_v = this_param.MakeFieldAccess( syntax, rewrittenReceiver, fieldSymbol, constantValueOpt, resultKind, type, oldNodeOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 31547, 31705);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_31999_32021(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 31999, 32021);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10486_31999_32026(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 31999, 32026);
return return_v;
}


bool
f_10486_31982_32027(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
type)
{
var return_v = IsInvariantArray( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 31982, 32027);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_33268_33290(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 33268, 33290);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10486_33252_33291(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 33252, 33291);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10486_33353_33372(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
this_param)
{
var return_v = this_param.Indices;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 33353, 33372);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10486_33343_33373(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
list)
{
var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundExpression>( list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 33343, 33373);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_33413_33481(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredExpression,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
loweredIndices,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
stores,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps)
{
var return_v = this_param.SpillArrayElementAccess( loweredExpression, loweredIndices, stores, temps);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 33413, 33481);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
f_10486_33644_33726(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
memberAccess,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
stores,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps)
{
var return_v = this_param.TransformDynamicMemberAccess( (Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess)memberAccess, stores, temps);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 33644, 33726);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
f_10486_33812_33896(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
indexerAccess,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
stores,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps)
{
var return_v = this_param.TransformDynamicIndexerAccess( (Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess)indexerAccess, stores, temps);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 33812, 33896);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10486_34310_34341(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 34310, 34341);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_10486_34310_34349(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.RefKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 34310, 34349);
return return_v;
}


int
f_10486_34297_34366(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 34297, 34366);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
f_10486_34491_34552(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
this_param)
{
var return_v = this_param.FunctionPointer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 34491, 34552);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
f_10486_34491_34562(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
this_param)
{
var return_v = this_param.Signature;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 34491, 34562);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_10486_34491_34570(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
this_param)
{
var return_v = this_param.RefKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 34491, 34570);
return return_v;
}


int
f_10486_34478_34587(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 34478, 34587);
return 0;
}


bool
f_10486_34706_34751(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.IsRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 34706, 34751);
return return_v;
}


int
f_10486_34693_34752(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 34693, 34752);
return 0;
}


bool
f_10486_34870_34914(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
this_param)
{
var return_v = this_param.IsRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 34870, 34914);
return return_v;
}


int
f_10486_34857_34915(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 34857, 34915);
return 0;
}


bool
f_10486_35321_35348(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.IsUsableAsField;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 35321, 35348);
return return_v;
}


int
f_10486_35308_35349(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 35308, 35349);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10486_35407_35430(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.ReceiverOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 35407, 35430);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
f_10486_35463_35486(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.EventSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 35463, 35486);
return return_v;
}


bool
f_10486_35463_35508(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
this_param)
{
var return_v = this_param.IsWindowsRuntimeEvent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 35463, 35508);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
f_10486_35743_35766(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.EventSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 35743, 35766);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10486_35768_35791(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.ReceiverOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 35768, 35791);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10486_35710_35807(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
propertyOrEvent,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
stores,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps)
{
var return_v = this_param.TransformPropertyOrEventReceiver( (Microsoft.CodeAnalysis.CSharp.Symbol)propertyOrEvent, receiverOpt, stores, temps);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 35710, 35807);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
f_10486_35864_35887(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.EventSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 35864, 35887);
return return_v;
}


bool
f_10486_35889_35916(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.IsUsableAsField;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 35889, 35916);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LookupResultKind
f_10486_35918_35940(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.ResultKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 35918, 35940);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_35942_35958(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 35942, 35958);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundEventAccess
f_10486_35691_35959(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
eventSymbol,bool
isUsableAsField,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Update( receiverOpt, eventSymbol, isUsableAsField, resultKind, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 35691, 35959);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
f_10486_36073_36096(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.EventSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 36073, 36096);
return return_v;
}


bool
f_10486_36019_36129(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
fieldOrEvent,ref Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiver,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
stores,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps)
{
var return_v = this_param.TransformCompoundAssignmentFieldOrEventAccessReceiver( (Microsoft.CodeAnalysis.CSharp.Symbol)fieldOrEvent, ref receiver, stores, temps);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 36019, 36129);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
f_10486_36243_36266(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.EventSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 36243, 36266);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10486_36268_36293(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 36268, 36293);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LookupResultKind
f_10486_36295_36317(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.ResultKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 36295, 36317);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_36319_36335(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 36319, 36335);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_36194_36336(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
rewrittenReceiver,Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
eventSymbol,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeEventAccess( syntax, rewrittenReceiver, eventSymbol, constantValueOpt, resultKind, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 36194, 36336);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10486_36506_36522(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 36506, 36522);
return return_v;
}


System.Exception
f_10486_36471_36523(Microsoft.CodeAnalysis.CSharp.BoundKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 36471, 36523);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10486_37105_37133(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 37105, 37133);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10486_37225_37309(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store,Microsoft.CodeAnalysis.RefKind
refKind)
{
var return_v = this_param.StoreToTemp( argument, out store, refKind: refKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 37225, 37309);
return return_v;
}


int
f_10486_37324_37353(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 37324, 37353);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10486_37378_37402(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 37378, 37402);
return return_v;
}


int
f_10486_37368_37403(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 37368, 37403);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10486,26794,37449);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10486,26794,37449);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsInvariantArray(TypeSymbol? type)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10486,37461,37655);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,37563,37644);

return (type is ArrayTypeSymbol) &&(DynAbs.Tracing.TraceSender.Expression_True(10486, 37570, 37643)&&f_10486_37599_37643(f_10486_37599_37634(((ArrayTypeSymbol)type))));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10486,37461,37655);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_37599_37634(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
this_param)
{
var return_v = this_param.ElementType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 37599, 37634);
return return_v;
}


bool
f_10486_37599_37643(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.IsSealed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 37599, 37643);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10486,37461,37655);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10486,37461,37655);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression BoxReceiver(BoundExpression rewrittenReceiver, NamedTypeSymbol memberContainingType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10486,37667,38094);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,37800,38083);

return f_10486_37807_38082(this, rewrittenReceiver.Syntax, rewrittenReceiver, Conversion.Boxing, memberContainingType, @checked: false, constantValueOpt: f_10486_38050_38081(rewrittenReceiver));
DynAbs.Tracing.TraceSender.TraceExitMethod(10486,37667,38094);

Microsoft.CodeAnalysis.ConstantValue?
f_10486_38050_38081(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 38050, 38081);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_37807_38082(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
rewrittenType,bool
@checked,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt)
{
var return_v = this_param.MakeConversionNode( syntax, rewrittenOperand, conversion, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rewrittenType, @checked: @checked, constantValueOpt: constantValueOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 37807, 38082);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10486,37667,38094);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10486,37667,38094);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression SpillArrayElementAccess(
            BoundExpression loweredExpression,
            ImmutableArray<BoundExpression> loweredIndices,
            ArrayBuilder<BoundExpression> stores,
            ArrayBuilder<LocalSymbol> temps)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10486,38106,39468);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,38385,38431);

BoundAssignmentOperator 
assignmentToArrayTemp
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,38445,38528);

var 
arrayTemp = f_10486_38461_38527(_factory, loweredExpression, out assignmentToArrayTemp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,38542,38576);

f_10486_38542_38575(            stores, assignmentToArrayTemp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,38590,38623);

f_10486_38590_38622(            temps, f_10486_38600_38621(arrayTemp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,38637,38668);

var 
boundTempArray = arrayTemp
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,38684,38750);

var 
boundTempIndices = new BoundExpression[loweredIndices.Length]
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,38773,38778);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,38764,39379) || true) && (i < f_10486_38784_38807(boundTempIndices))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,38809,38812)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(10486,38764,39379))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,38764,39379);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,38846,39364) || true) && (f_10486_38850_38895(loweredIndices[i]))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,38846,39364);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,38937,38978);

BoundAssignmentOperator 
assignmentToTemp
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,39000,39073);

var 
temp = f_10486_39011_39072(_factory, loweredIndices[i], out assignmentToTemp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,39095,39124);

f_10486_39095_39123(                    stores, assignmentToTemp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,39146,39174);

f_10486_39146_39173(                    temps, f_10486_39156_39172(temp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,39196,39223);

boundTempIndices[i] = temp;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,38846,39364);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,38846,39364);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,39305,39345);

boundTempIndices[i] = loweredIndices[i];
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,38846,39364);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10486,1,616);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10486,1,616);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,39395,39457);

return f_10486_39402_39456(_factory, boundTempArray, boundTempIndices);
DynAbs.Tracing.TraceSender.TraceExitMethod(10486,38106,39468);

Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10486_38461_38527(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 38461, 38527);
return return_v;
}


int
f_10486_38542_38575(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 38542, 38575);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10486_38600_38621(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 38600, 38621);
return return_v;
}


int
f_10486_38590_38622(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 38590, 38622);
return 0;
}


int
f_10486_38784_38807(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 38784, 38807);
return return_v;
}


bool
f_10486_38850_38895(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = CanChangeValueBetweenReads( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 38850, 38895);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10486_39011_39072(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 39011, 39072);
return return_v;
}


int
f_10486_39095_39123(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 39095, 39123);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10486_39156_39172(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 39156, 39172);
return return_v;
}


int
f_10486_39146_39173(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 39146, 39173);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
f_10486_39402_39456(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
array,params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
indices)
{
var return_v = this_param.ArrayAccess( (Microsoft.CodeAnalysis.CSharp.BoundExpression)array, indices);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 39402, 39456);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10486,38106,39468);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10486,38106,39468);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool CanChangeValueBetweenReads(
            BoundExpression expression,
            bool localsMayBeAssignedOrCaptured = true,
            bool structThisCanChangeValueBetweenReads = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10486,40118,41600);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,40352,40445) || true) && (f_10486_40356_40383(expression))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,40352,40445);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,40417,40430);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,40352,40445);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,40461,40628) || true) && (f_10486_40465_40489(expression)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,40461,40628);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,40531,40558);

var 
type = f_10486_40542_40557(expression)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,40576,40613);

return !f_10486_40584_40612(type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,40461,40628);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,40644,41589);

switch (f_10486_40652_40667(expression))
            {

case BoundKind.ThisReference:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,40644,41589);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,40752,40852);

return structThisCanChangeValueBetweenReads &&(DynAbs.Tracing.TraceSender.Expression_True(10486, 40759, 40851)&&f_10486_40799_40851(f_10486_40799_40836(((BoundThisReference)expression))));
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,40644,41589);

case BoundKind.BaseReference:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,40644,41589);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,40923,40936);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,40644,41589);

case BoundKind.Literal:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,40644,41589);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,41001,41028);

var 
type = f_10486_41012_41027(expression)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,41050,41087);

return !f_10486_41058_41086(type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,40644,41589);

case BoundKind.Parameter:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,40644,41589);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,41154,41263);

return localsMayBeAssignedOrCaptured ||(DynAbs.Tracing.TraceSender.Expression_False(10486, 41161, 41262)||f_10486_41194_41246(f_10486_41194_41238(((BoundParameter)expression)))!= RefKind.None);
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,40644,41589);

case BoundKind.Local:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,40644,41589);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,41326,41427);

return localsMayBeAssignedOrCaptured ||(DynAbs.Tracing.TraceSender.Expression_False(10486, 41333, 41426)||f_10486_41366_41410(f_10486_41366_41402(((BoundLocal)expression)))!= RefKind.None);
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,40644,41589);

case BoundKind.TypeExpression:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,40644,41589);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,41499,41512);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,40644,41589);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,40644,41589);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,41562,41574);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,40644,41589);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10486,40118,41600);

bool
f_10486_40356_40383(Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = node.IsDefaultValue();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 40356, 40383);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10486_40465_40489(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 40465, 40489);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10486_40542_40557(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 40542, 40557);
return return_v;
}


bool
f_10486_40584_40612(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
type)
{
var return_v = ConstantValueIsTrivial( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 40584, 40612);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10486_40652_40667(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 40652, 40667);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_40799_40836(Microsoft.CodeAnalysis.CSharp.BoundThisReference
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 40799, 40836);
return return_v;
}


bool
f_10486_40799_40851(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsStructType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 40799, 40851);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10486_41012_41027(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 41012, 41027);
return return_v;
}


bool
f_10486_41058_41086(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
type)
{
var return_v = ConstantValueIsTrivial( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 41058, 41086);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
f_10486_41194_41238(Microsoft.CodeAnalysis.CSharp.BoundParameter
this_param)
{
var return_v = this_param.ParameterSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 41194, 41238);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_10486_41194_41246(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.RefKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 41194, 41246);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10486_41366_41402(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 41366, 41402);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_10486_41366_41410(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.RefKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 41366, 41410);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10486,40118,41600);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10486,40118,41600);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool ReadIsSideeffecting(
            BoundExpression expression)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10486,41681,44222);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,41788,41886) || true) && (f_10486_41792_41816(expression)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,41788,41886);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,41858,41871);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,41788,41886);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,41902,41995) || true) && (f_10486_41906_41933(expression))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,41902,41995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,41967,41980);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,41902,41995);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,42011,44211);

switch (f_10486_42019_42034(expression))
            {

case BoundKind.ThisReference:
                case BoundKind.BaseReference:
                case BoundKind.Literal:
                case BoundKind.Parameter:
                case BoundKind.Local:
                case BoundKind.Lambda:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,42011,44211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,42329,42342);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,42011,44211);

case BoundKind.Conversion:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,42011,44211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,42410,42449);

var 
conv = (BoundConversion)expression
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,42471,42572);

return f_10486_42478_42509(conv)||(DynAbs.Tracing.TraceSender.Expression_False(10486, 42478, 42571)||f_10486_42538_42571(f_10486_42558_42570(conv)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,42011,44211);

case BoundKind.PassByCopy:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,42011,44211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,42640,42709);

return f_10486_42647_42708(f_10486_42667_42707(((BoundPassByCopy)expression)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,42011,44211);

case BoundKind.ObjectCreationExpression:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,42011,44211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,42904,42941);

f_10486_42904_42940(f_10486_42917_42932(expression)is { });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,42963,43248) || true) && (f_10486_42967_42999(f_10486_42967_42982(expression)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,42963,43248);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,43049,43109);

var 
objCreation = (BoundObjectCreationExpression)expression
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,43135,43225);

return objCreation.Arguments.Length == 1 &&(DynAbs.Tracing.TraceSender.Expression_True(10486, 43142, 43224)&&f_10486_43179_43224(f_10486_43199_43220(objCreation)[0]));
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,42963,43248);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,43272,43284);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,42011,44211);

case BoundKind.Call:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,42011,44211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,43346,43379);

var 
call = (BoundCall)expression
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,43401,43426);

var 
method = f_10486_43414_43425(call)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,43596,44098) || true) && (f_10486_43622_43639(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10486_43600_43621(method), 10486, 43600, 43639))== true)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,43596,44098);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,43697,44075) || true) && (f_10486_43701_43775(method, SpecialMember.System_Nullable_T_GetValueOrDefault)||(DynAbs.Tracing.TraceSender.Expression_False(10486, 43701, 43877)||f_10486_43808_43877(method, SpecialMember.System_Nullable_T_get_HasValue)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,43697,44075);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,43935,43973);

f_10486_43935_43972(f_10486_43948_43964(call)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,44003,44048);

return f_10486_44010_44047(f_10486_44030_44046(call));
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,43697,44075);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,43596,44098);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,44122,44134);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,42011,44211);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10486,42011,44211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,44184,44196);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10486,42011,44211);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10486,41681,44222);

Microsoft.CodeAnalysis.ConstantValue?
f_10486_41792_41816(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 41792, 41816);
return return_v;
}


bool
f_10486_41906_41933(Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = node.IsDefaultValue();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 41906, 41933);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10486_42019_42034(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 42019, 42034);
return return_v;
}


bool
f_10486_42478_42509(Microsoft.CodeAnalysis.CSharp.BoundConversion
this_param)
{
var return_v = this_param.ConversionHasSideEffects();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 42478, 42509);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_42558_42570(Microsoft.CodeAnalysis.CSharp.BoundConversion
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 42558, 42570);
return return_v;
}


bool
f_10486_42538_42571(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = ReadIsSideeffecting( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 42538, 42571);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_42667_42707(Microsoft.CodeAnalysis.CSharp.BoundPassByCopy
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 42667, 42707);
return return_v;
}


bool
f_10486_42647_42708(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = ReadIsSideeffecting( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 42647, 42708);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10486_42917_42932(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 42917, 42932);
return return_v;
}


int
f_10486_42904_42940(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 42904, 42940);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10486_42967_42982(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 42967, 42982);
return return_v;
}


bool
f_10486_42967_42999(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsNullableType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 42967, 42999);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10486_43199_43220(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 43199, 43220);
return return_v;
}


bool
f_10486_43179_43224(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = ReadIsSideeffecting( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 43179, 43224);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10486_43414_43425(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 43414, 43425);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10486_43600_43621(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 43600, 43621);
return return_v;
}


bool?
f_10486_43622_43639(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = type?.IsNullableType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 43622, 43639);
return return_v;
}


bool
f_10486_43701_43775(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = IsSpecialMember( method, specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 43701, 43775);
return return_v;
}


bool
f_10486_43808_43877(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = IsSpecialMember( method, specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 43808, 43877);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10486_43948_43964(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.ReceiverOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 43948, 43964);
return return_v;
}


int
f_10486_43935_43972(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 43935, 43972);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10486_44030_44046(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.ReceiverOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 44030, 44046);
return return_v;
}


bool
f_10486_44010_44047(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = ReadIsSideeffecting( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 44010, 44047);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10486,41681,44222);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10486,41681,44222);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsSpecialMember(MethodSymbol method, SpecialMember specialMember)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10486,44234,44484);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,44344,44379);

method = f_10486_44353_44378(method);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,44393,44473);

return f_10486_44400_44462_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10486_44400_44425(method), 10486, 44400, 44462).GetSpecialTypeMember(specialMember))== method;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10486,44234,44484);

Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10486_44353_44378(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.OriginalDefinition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 44353, 44378);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
f_10486_44400_44425(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ContainingAssembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 44400, 44425);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_10486_44400_44462_I(Microsoft.CodeAnalysis.CSharp.Symbol?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 44400, 44462);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10486,44234,44484);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10486,44234,44484);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool ConstantValueIsTrivial(TypeSymbol? type)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10486,44669,44916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10486,44754,44905);

return type is null ||(DynAbs.Tracing.TraceSender.Expression_False(10486, 44761, 44825)||f_10486_44794_44825(f_10486_44794_44810(type)))||(DynAbs.Tracing.TraceSender.Expression_False(10486, 44761, 44866)||f_10486_44846_44866(type))||(DynAbs.Tracing.TraceSender.Expression_False(10486, 44761, 44904)||f_10486_44887_44904(                type));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10486,44669,44916);

Microsoft.CodeAnalysis.SpecialType
f_10486_44794_44810(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 44794, 44810);
return return_v;
}


bool
f_10486_44794_44825(Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = specialType.IsClrInteger();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 44794, 44825);
return return_v;
}


bool
f_10486_44846_44866(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.IsReferenceType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10486, 44846, 44866);
return return_v;
}


bool
f_10486_44887_44904(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsEnumType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10486, 44887, 44904);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10486,44669,44916);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10486,44669,44916);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
