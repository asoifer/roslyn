// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitNullCoalescingAssignmentOperator(BoundNullCoalescingAssignmentOperator node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10513,473,7282);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,605,636);

f_10513_605_635(f_10513_618_627(node)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,650,682);

SyntaxNode 
syntax = node.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,696,748);

var 
temps = f_10513_708_747()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,762,819);

var 
stores = f_10513_775_818()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,833,876);

f_10513_833_875(f_10513_846_867(f_10513_846_862(node))is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,1023,1155);

BoundExpression 
transformedLHS = f_10513_1056_1154(this, f_10513_1087_1103(node), stores, temps, f_10513_1120_1153(f_10513_1120_1136(node)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,1169,1210);

f_10513_1169_1209(f_10513_1182_1201(transformedLHS)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,1224,1265);

var 
lhsRead = f_10513_1238_1264(this, transformedLHS)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,1279,1345);

BoundExpression 
loweredRight = f_10513_1310_1344(this, f_10513_1326_1343(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,1361,1536);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10513, 1368, 1402)||((f_10513_1368_1402(node)&&DynAbs.Tracing.TraceSender.Conditional_F2(10513, 1426, 1471))||DynAbs.Tracing.TraceSender.Conditional_F3(10513, 1495, 1535)))?f_10513_1426_1471():f_10513_1495_1535();

BoundExpression rewriteNullCoalscingAssignmentStandard()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10513,1552,3177);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,2258,2430);

BoundExpression 
assignment = f_10513_2287_2429(this, syntax, transformedLHS, loweredRight, f_10513_2348_2369(f_10513_2348_2364(node)), used: true, isChecked: false, isCompoundAssignment: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,2513,2701);

BoundExpression 
conditionalExpression = f_10513_2553_2700(this, syntax, lhsRead, assignment, Conversion.Identity, BoundNullCoalescingOperatorResultKind.LeftType, f_10513_2678_2699(f_10513_2678_2694(node)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,2719,2767);

f_10513_2719_2766(f_10513_2732_2758(conditionalExpression)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,2787,3162);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10513, 2794, 2833)||(((f_10513_2795_2806(temps)== 0 &&(DynAbs.Tracing.TraceSender.Expression_True(10513, 2795, 2832)&&f_10513_2815_2827(stores)== 0)) &&DynAbs.Tracing.TraceSender.Conditional_F2(10513, 2857, 2878))||DynAbs.Tracing.TraceSender.Conditional_F3(10513, 2902, 3161)))?                    conditionalExpression :f_10513_2902_3161(syntax, f_10513_2979_3005(                        temps), f_10513_3032_3059(                        stores), conditionalExpression, f_10513_3134_3160(conditionalExpression));
DynAbs.Tracing.TraceSender.TraceExitMethod(10513,1552,3177);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_2348_2364(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
this_param)
{
var return_v = this_param.LeftOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 2348, 2364);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10513_2348_2369(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 2348, 2369);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_2287_2429(Microsoft.CodeAnalysis.CSharp.LocalRewriter
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
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 2287, 2429);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_2678_2694(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
this_param)
{
var return_v = this_param.LeftOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 2678, 2694);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10513_2678_2699(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 2678, 2699);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_2553_2700(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenRight,Microsoft.CodeAnalysis.CSharp.Conversion
leftConversion,Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperatorResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenResultType)
{
var return_v = this_param.MakeNullCoalescingOperator( syntax, rewrittenLeft, rewrittenRight, leftConversion, resultKind, rewrittenResultType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 2553, 2700);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10513_2732_2758(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 2732, 2758);
return return_v;
}


int
f_10513_2719_2766(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 2719, 2766);
return 0;
}


int
f_10513_2795_2806(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 2795, 2806);
return return_v;
}


int
f_10513_2815_2827(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 2815, 2827);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10513_2979_3005(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 2979, 3005);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10513_3032_3059(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 3032, 3059);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10513_3134_3160(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 3134, 3160);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10513_2902_3161(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax, locals, sideEffects, value, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 2902, 3161);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10513,1552,3177);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10513,1552,3177);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

BoundExpression rewriteNullCoalescingAssignmentForValueType()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10513,3356,7271);
Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol getValueOrDefault = default(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol);
Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol hasValue = default(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol);
Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator store = default(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator);
Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator getValueOrDefaultStore = default(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,3450,3503);

f_10513_3450_3502(f_10513_3463_3501(f_10513_3463_3484(f_10513_3463_3479(node))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,3521,3576);

f_10513_3521_3575(f_10513_3534_3574(f_10513_3534_3543(node), f_10513_3551_3573(f_10513_3551_3568(node))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,3844,3879);

var 
leftOperand = f_10513_3862_3878(node)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,3897,4255) || true) && (!f_10513_3902_4167(this, leftOperand.Syntax, f_10513_3986_4002(leftOperand), SpecialMember.System_Nullable_T_GetValueOrDefault, out getValueOrDefault))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10513,3897,4255);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,4209,4236);

return f_10513_4216_4235(node);
DynAbs.Tracing.TraceSender.TraceExitCondition(10513,3897,4255);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,4275,4619) || true) && (!f_10513_4280_4531(this, leftOperand.Syntax, f_10513_4364_4380(leftOperand), SpecialMember.System_Nullable_T_get_HasValue, out hasValue))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10513,4275,4619);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,4573,4600);

return f_10513_4580_4599(node);
DynAbs.Tracing.TraceSender.TraceExitCondition(10513,4275,4619);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,4939,5018);

f_10513_4939_5017(!_inExpressionLambda &&(DynAbs.Tracing.TraceSender.Expression_True(10513, 4952, 5016)&&f_10513_4976_4988(lhsRead)!= BoundKind.PropertyAccess));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,5240,5527) || true) && (f_10513_5244_5256(lhsRead)== BoundKind.Call)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10513,5240,5527);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,5316,5375);

var 
lhsTemp = f_10513_5330_5374(_factory, lhsRead, out store)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,5397,5415);

f_10513_5397_5414(                    stores, store);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,5437,5468);

f_10513_5437_5467(                    temps, f_10513_5447_5466(lhsTemp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,5490,5508);

lhsRead = lhsTemp;
DynAbs.Tracing.TraceSender.TraceExitCondition(10513,5240,5527);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,5602,5784);

var 
tmp = f_10513_5612_5783(_factory, f_10513_5633_5702(leftOperand.Syntax, lhsRead, getValueOrDefault), out getValueOrDefaultStore)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,5804,5839);

f_10513_5804_5838(
                stores, getValueOrDefaultStore);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,5857,5884);

f_10513_5857_5883(                temps, f_10513_5867_5882(tmp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,5944,6089);

var 
tmpAssignment = f_10513_5964_6088(this, node.Syntax, tmp, loweredRight, f_10513_6019_6028(node), used: true, isChecked: false, isCompoundAssignment: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,6151,6576);

var 
transformedLhsAssignment =
f_10513_6203_6575(this, node.Syntax, transformedLHS, f_10513_6331_6392(this, tmp, f_10513_6355_6374(transformedLHS), @checked: false), f_10513_6419_6440(f_10513_6419_6435(node)), used: true, isChecked: false, isCompoundAssignment: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,6633,6716);

var 
lhsReadHasValue = f_10513_6655_6715(leftOperand.Syntax, lhsRead, hasValue)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,6795,6935);

var 
alternative = f_10513_6813_6934(_factory, ImmutableArray<LocalSymbol>.Empty, f_10513_6866_6928(tmpAssignment, transformedLhsAssignment), tmp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,7065,7145);

var 
ternary = f_10513_7079_7144(_factory, lhsReadHasValue, tmp, alternative, f_10513_7135_7143(tmp))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10513,7165,7256);

return f_10513_7172_7255(_factory, f_10513_7190_7216(temps), f_10513_7218_7245(stores), ternary);
DynAbs.Tracing.TraceSender.TraceExitMethod(10513,3356,7271);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_3463_3479(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
this_param)
{
var return_v = this_param.LeftOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 3463, 3479);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10513_3463_3484(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 3463, 3484);
return return_v;
}


bool
f_10513_3463_3501(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsNullableType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 3463, 3501);
return return_v;
}


int
f_10513_3450_3502(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 3450, 3502);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10513_3534_3543(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 3534, 3543);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_3551_3568(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
this_param)
{
var return_v = this_param.RightOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 3551, 3568);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10513_3551_3573(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 3551, 3573);
return return_v;
}


bool
f_10513_3534_3574(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
obj)
{
var return_v = this_param.Equals( (object?)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 3534, 3574);
return return_v;
}


int
f_10513_3521_3575(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 3521, 3575);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_3862_3878(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
this_param)
{
var return_v = this_param.LeftOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 3862, 3878);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10513_3986_4002(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 3986, 4002);
return return_v;
}


bool
f_10513_3902_4167(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
nullableType,Microsoft.CodeAnalysis.SpecialMember
member,out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
result)
{
var return_v = this_param.TryGetNullableMethod( syntax, nullableType, member, out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 3902, 4167);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_4216_4235(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
node)
{
var return_v = BadExpression( (Microsoft.CodeAnalysis.CSharp.BoundExpression)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 4216, 4235);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10513_4364_4380(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 4364, 4380);
return return_v;
}


bool
f_10513_4280_4531(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
nullableType,Microsoft.CodeAnalysis.SpecialMember
member,out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
result)
{
var return_v = this_param.TryGetNullableMethod( syntax, nullableType, member, out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 4280, 4531);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_4580_4599(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
node)
{
var return_v = BadExpression( (Microsoft.CodeAnalysis.CSharp.BoundExpression)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 4580, 4599);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10513_4976_4988(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 4976, 4988);
return return_v;
}


int
f_10513_4939_5017(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 4939, 5017);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10513_5244_5256(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 5244, 5256);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10513_5330_5374(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 5330, 5374);
return return_v;
}


int
f_10513_5397_5414(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 5397, 5414);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10513_5447_5466(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 5447, 5466);
return return_v;
}


int
f_10513_5437_5467(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 5437, 5467);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10513_5633_5702(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 5633, 5702);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10513_5612_5783(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundCall
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( (Microsoft.CodeAnalysis.CSharp.BoundExpression)argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 5612, 5783);
return return_v;
}


int
f_10513_5804_5838(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 5804, 5838);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10513_5867_5882(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 5867, 5882);
return return_v;
}


int
f_10513_5857_5883(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 5857, 5883);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10513_6019_6028(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 6019, 6028);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_5964_6088(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
rewrittenLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,bool
used,bool
isChecked,bool
isCompoundAssignment)
{
var return_v = this_param.MakeAssignmentOperator( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenLeft, rewrittenRight, type, used: used, isChecked: isChecked, isCompoundAssignment: isCompoundAssignment);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 5964, 6088);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10513_6355_6374(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 6355, 6374);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_6331_6392(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenOperand, rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 6331, 6392);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_6419_6435(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
this_param)
{
var return_v = this_param.LeftOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 6419, 6435);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10513_6419_6440(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 6419, 6440);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_6203_6575(Microsoft.CodeAnalysis.CSharp.LocalRewriter
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
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 6203, 6575);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10513_6655_6715(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 6655, 6715);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10513_6866_6928(Microsoft.CodeAnalysis.CSharp.BoundExpression
item1,Microsoft.CodeAnalysis.CSharp.BoundExpression
item2)
{
var return_v = ImmutableArray.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 6866, 6928);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_6813_6934(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundLocal
result)
{
var return_v = this_param.Sequence( locals, sideEffects, (Microsoft.CodeAnalysis.CSharp.BoundExpression)result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 6813, 6934);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10513_7135_7143(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 7135, 7143);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_7079_7144(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundCall
condition,Microsoft.CodeAnalysis.CSharp.BoundLocal
consequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
alternative,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Conditional( (Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, (Microsoft.CodeAnalysis.CSharp.BoundExpression)consequence, alternative, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 7079, 7144);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10513_7190_7216(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 7190, 7216);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10513_7218_7245(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 7218, 7245);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_7172_7255(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
result)
{
var return_v = this_param.Sequence( locals, sideEffects, result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 7172, 7255);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10513,3356,7271);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10513,3356,7271);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
DynAbs.Tracing.TraceSender.TraceExitMethod(10513,473,7282);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10513_618_627(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 618, 627);
return return_v;
}


int
f_10513_605_635(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 605, 635);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10513_708_747()
{
var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 708, 747);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10513_775_818()
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 775, 818);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_846_862(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
this_param)
{
var return_v = this_param.LeftOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 846, 862);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10513_846_867(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 846, 867);
return return_v;
}


int
f_10513_833_875(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 833, 875);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_1087_1103(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
this_param)
{
var return_v = this_param.LeftOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 1087, 1103);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_1120_1136(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
this_param)
{
var return_v = this_param.LeftOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 1120, 1136);
return return_v;
}


bool
f_10513_1120_1153(Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = node.HasDynamicType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 1120, 1153);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_1056_1154(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
originalLHS,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
stores,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps,bool
isDynamicAssignment)
{
var return_v = this_param.TransformCompoundAssignmentLHS( originalLHS, stores, temps, isDynamicAssignment);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 1056, 1154);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10513_1182_1201(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 1182, 1201);
return return_v;
}


int
f_10513_1169_1209(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 1169, 1209);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_1238_1264(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
transformedExpression)
{
var return_v = this_param.MakeRValue( transformedExpression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 1238, 1264);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_1326_1343(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
this_param)
{
var return_v = this_param.RightOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 1326, 1343);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10513_1310_1344(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 1310, 1344);
return return_v;
}


bool
f_10513_1368_1402(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
this_param)
{
var return_v = this_param.IsNullableValueTypeAssignment ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10513, 1368, 1402);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_1426_1471()
{
var return_v = rewriteNullCoalescingAssignmentForValueType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 1426, 1471);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10513_1495_1535()
{
var return_v = rewriteNullCoalscingAssignmentStandard();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10513, 1495, 1535);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10513,473,7282);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10513,473,7282);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
