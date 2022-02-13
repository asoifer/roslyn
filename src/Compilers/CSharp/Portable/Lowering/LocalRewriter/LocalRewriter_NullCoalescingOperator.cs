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
public override BoundNode VisitNullCoalescingOperator(BoundNullCoalescingOperator node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10514,509,1010);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,621,687);

BoundExpression 
rewrittenLeft = f_10514_653_686(this, f_10514_669_685(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,701,769);

BoundExpression 
rewrittenRight = f_10514_734_768(this, f_10514_750_767(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,783,838);

TypeSymbol? 
rewrittenResultType = f_10514_817_837(this, f_10514_827_836(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,854,999);

return f_10514_861_998(this, node.Syntax, rewrittenLeft, rewrittenRight, f_10514_932_951(node), f_10514_953_976(node), rewrittenResultType);
DynAbs.Tracing.TraceSender.TraceExitMethod(10514,509,1010);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10514_669_685(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
this_param)
{
var return_v = this_param.LeftOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 669, 685);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10514_653_686(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 653, 686);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10514_750_767(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
this_param)
{
var return_v = this_param.RightOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 750, 767);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10514_734_768(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 734, 768);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10514_827_836(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 827, 836);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10514_817_837(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.VisitType( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 817, 837);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10514_932_951(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
this_param)
{
var return_v = this_param.LeftConversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 932, 951);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperatorResultKind
f_10514_953_976(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
this_param)
{
var return_v = this_param.OperatorResultKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 953, 976);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10514_861_998(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenRight,Microsoft.CodeAnalysis.CSharp.Conversion
leftConversion,Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperatorResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenResultType)
{
var return_v = this_param.MakeNullCoalescingOperator( syntax, rewrittenLeft, rewrittenRight, leftConversion, resultKind, rewrittenResultType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 861, 998);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10514,509,1010);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10514,509,1010);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeNullCoalescingOperator(
            SyntaxNode syntax,
            BoundExpression rewrittenLeft,
            BoundExpression rewrittenRight,
            Conversion leftConversion,
            BoundNullCoalescingOperatorResultKind resultKind,
            TypeSymbol? rewrittenResultType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10514,1022,9202);
Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol getValueOrDefault = default(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,1368,1404);

f_10514_1368_1403(rewrittenLeft != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,1418,1455);

f_10514_1418_1454(rewrittenRight != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,1469,1506);

f_10514_1469_1505(leftConversion.IsValid);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,1520,1561);

f_10514_1520_1560(rewrittenResultType is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,1575,1616);

f_10514_1575_1615(f_10514_1588_1607(rewrittenRight)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,1630,1795);

f_10514_1630_1794(f_10514_1643_1793(f_10514_1643_1662(rewrittenRight), rewrittenResultType, TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,1811,2700) || true) && (_inExpressionLambda)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10514,1811,2700);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,2088,2128);

f_10514_2088_2127(f_10514_2101_2119(rewrittenLeft)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,2146,2210);

TypeSymbol 
strippedLeftType = f_10514_2176_2209(f_10514_2176_2194(rewrittenLeft))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,2228,2342);

Conversion 
rewrittenConversion = f_10514_2261_2341(this, syntax, leftConversion, strippedLeftType, rewrittenResultType)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,2360,2533) || true) && (f_10514_2364_2391_M(!rewrittenConversion.Exists))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10514,2360,2533);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,2433,2514);

return f_10514_2440_2513(syntax, rewrittenResultType, rewrittenLeft, rewrittenRight);
DynAbs.Tracing.TraceSender.TraceExitCondition(10514,2360,2533);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,2553,2685);

return f_10514_2560_2684(syntax, rewrittenLeft, rewrittenRight, rewrittenConversion, resultKind, rewrittenResultType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10514,1811,2700);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,2716,2820);

var 
isUnconstrainedTypeParameter = f_10514_2751_2769(rewrittenLeft)is { IsReferenceType: false, IsValueType: false }
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,3292,3786) || true) && (!isUnconstrainedTypeParameter)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10514,3292,3786);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,3359,3476) || true) && (f_10514_3363_3393(rewrittenLeft))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10514,3359,3476);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,3435,3457);

return rewrittenRight;
DynAbs.Tracing.TraceSender.TraceExitCondition(10514,3359,3476);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,3496,3771) || true) && (f_10514_3500_3527(rewrittenLeft)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10514,3496,3771);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,3577,3627);

f_10514_3577_3626(f_10514_3590_3625_M(!f_10514_3591_3618(rewrittenLeft).IsNull));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,3651,3752);

return f_10514_3658_3751(this, rewrittenLeft, leftConversion, rewrittenResultType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10514,3496,3771);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10514,3292,3786);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,3965,4148) || true) && (f_10514_3969_3998(this, rewrittenLeft))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10514,3965,4148);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,4032,4133);

return f_10514_4039_4132(this, rewrittenLeft, leftConversion, rewrittenResultType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10514,3965,4148);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,4381,4421);

f_10514_4381_4420(f_10514_4394_4412(rewrittenLeft)is { });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,4435,4985) || true) && (f_10514_4439_4473(f_10514_4439_4457(rewrittenLeft))&&(DynAbs.Tracing.TraceSender.Expression_True(10514, 4439, 4519)&&                leftConversion.IsImplicit )&&(DynAbs.Tracing.TraceSender.Expression_True(10514, 4439, 4569)&&f_10514_4540_4569_M(!leftConversion.IsUserDefined)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10514,4435,4985);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,4603,4820) || true) && (f_10514_4607_4633_M(!leftConversion.IsIdentity))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10514,4603,4820);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,4675,4801);

rewrittenLeft = f_10514_4691_4800(this, rewrittenLeft.Syntax, rewrittenLeft, leftConversion, rewrittenResultType, @checked: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10514,4603,4820);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,4838,4970);

return f_10514_4845_4969(syntax, rewrittenLeft, rewrittenRight, Conversion.Identity, resultKind, rewrittenResultType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10514,4435,4985);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,5001,6531) || true) && (leftConversion.IsIdentity ||(DynAbs.Tracing.TraceSender.Expression_False(10514, 5005, 5088)||leftConversion.Kind == ConversionKind.ExplicitNullable))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10514,5001,6531);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,5122,5193);

var 
conditionalAccess = rewrittenLeft as BoundLoweredConditionalAccess
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,5211,6516) || true) && (conditionalAccess != null &&(DynAbs.Tracing.TraceSender.Expression_True(10514, 5215, 5360)&&                    (f_10514_5266_5295(conditionalAccess)== null ||(DynAbs.Tracing.TraceSender.Expression_False(10514, 5266, 5359)||f_10514_5307_5359(f_10514_5329_5358(conditionalAccess))))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10514,5211,6516);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,5402,5476);

var 
notNullAccess = f_10514_5422_5475(f_10514_5445_5474(conditionalAccess))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,5498,6497) || true) && (notNullAccess != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10514,5498,6497);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,5573,5619);

BoundExpression? 
whenNullOpt = rewrittenRight
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,5647,5815) || true) && (f_10514_5651_5684(f_10514_5651_5667(whenNullOpt)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10514,5647,5815);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,5742,5788);

notNullAccess = f_10514_5758_5787(conditionalAccess);
DynAbs.Tracing.TraceSender.TraceExitCondition(10514,5647,5815);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,5843,6041) || true) && (f_10514_5847_5875(whenNullOpt)&&(DynAbs.Tracing.TraceSender.Expression_True(10514, 5847, 5937)&&f_10514_5879_5907(f_10514_5879_5895(whenNullOpt))!= SpecialType.System_Decimal))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10514,5843,6041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,5995,6014);

whenNullOpt = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10514,5843,6041);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,6069,6474);

return f_10514_6076_6473(conditionalAccess, f_10514_6131_6157(conditionalAccess), f_10514_6188_6223(conditionalAccess), whenNotNull: notNullAccess, whenNullOpt: whenNullOpt, id: f_10514_6370_6390(conditionalAccess), type: rewrittenResultType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10514,5498,6497);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10514,5211,6516);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10514,5001,6531);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,6666,7217) || true) && (f_10514_6670_6705(f_10514_6670_6688(rewrittenLeft))&&(DynAbs.Tracing.TraceSender.Expression_True(10514, 6670, 6784)&&f_10514_6726_6784(f_10514_6726_6767(rewrittenRight)))&&(DynAbs.Tracing.TraceSender.Expression_True(10514, 6670, 6913)&&f_10514_6805_6913(f_10514_6805_6824(rewrittenRight), f_10514_6832_6878(f_10514_6832_6850(rewrittenLeft)), TypeCompareKind.AllIgnoreOptions))&&(DynAbs.Tracing.TraceSender.Expression_True(10514, 6670, 7083)&&f_10514_6934_7083(this, rewrittenLeft.Syntax, f_10514_6977_6995(rewrittenLeft), SpecialMember.System_Nullable_T_GetValueOrDefault, out getValueOrDefault)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10514,6666,7217);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,7117,7202);

return f_10514_7124_7201(rewrittenLeft.Syntax, rewrittenLeft, getValueOrDefault);
DynAbs.Tracing.TraceSender.TraceExitCondition(10514,6666,7217);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,7404,7443);

BoundAssignmentOperator 
tempAssignment
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,7457,7536);

BoundLocal 
boundTemp = f_10514_7480_7535(_factory, rewrittenLeft, out tempAssignment)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,7581,7671);

BoundExpression 
nullCheck = f_10514_7609_7670(this, syntax, boundTemp, BinaryOperatorKind.NotEqual)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,7745,7867);

BoundExpression 
convertedLeft = f_10514_7777_7866(this, boundTemp, leftConversion, rewrittenResultType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,7881,8073);

f_10514_7881_8072(f_10514_7894_7917(convertedLeft)||(DynAbs.Tracing.TraceSender.Expression_False(10514, 7894, 8071)||f_10514_7921_8071(convertedLeft.Type!, rewrittenResultType, TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,8174,8557);

BoundExpression 
conditionalExpression = f_10514_8214_8556(syntax: syntax, rewrittenCondition: nullCheck, rewrittenConsequence: convertedLeft, rewrittenAlternative: rewrittenRight, constantValueOpt: null, rewrittenType: rewrittenResultType, isRef: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,8573,8631);

f_10514_8573_8630(f_10514_8586_8621(conditionalExpression)== null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,8695,8868);

f_10514_8695_8867(f_10514_8708_8866(conditionalExpression.Type!, rewrittenResultType, TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,8884,9191);

return f_10514_8891_9190(syntax: syntax, locals: f_10514_8968_9012(f_10514_8990_9011(boundTemp)), sideEffects: f_10514_9044_9098(tempAssignment), value: conditionalExpression, type: rewrittenResultType);
DynAbs.Tracing.TraceSender.TraceExitMethod(10514,1022,9202);

int
f_10514_1368_1403(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 1368, 1403);
return 0;
}


int
f_10514_1418_1454(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 1418, 1454);
return 0;
}


int
f_10514_1469_1505(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 1469, 1505);
return 0;
}


int
f_10514_1520_1560(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 1520, 1560);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10514_1588_1607(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 1588, 1607);
return return_v;
}


int
f_10514_1575_1615(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 1575, 1615);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10514_1643_1662(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 1643, 1662);
return return_v;
}


bool
f_10514_1643_1793(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
t2,Microsoft.CodeAnalysis.TypeCompareKind
compareKind)
{
var return_v = this_param.Equals( t2, compareKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 1643, 1793);
return return_v;
}


int
f_10514_1630_1794(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 1630, 1794);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10514_2101_2119(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 2101, 2119);
return return_v;
}


int
f_10514_2088_2127(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 2088, 2127);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10514_2176_2194(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 2176, 2194);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10514_2176_2209(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.StrippedType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 2176, 2209);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10514_2261_2341(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
fromType,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
toType)
{
var return_v = this_param.TryMakeConversion( syntax, conversion, fromType, toType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 2261, 2341);
return return_v;
}


bool
f_10514_2364_2391_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 2364, 2391);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10514_2440_2513(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
resultType,Microsoft.CodeAnalysis.CSharp.BoundExpression
child1,Microsoft.CodeAnalysis.CSharp.BoundExpression
child2)
{
var return_v = BadExpression( syntax, resultType, child1, child2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 2440, 2513);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
f_10514_2560_2684(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
leftOperand,Microsoft.CodeAnalysis.CSharp.BoundExpression
rightOperand,Microsoft.CodeAnalysis.CSharp.Conversion
leftConversion,Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperatorResultKind
operatorResultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator( syntax, leftOperand, rightOperand, leftConversion, operatorResultKind, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 2560, 2684);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10514_2751_2769(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 2751, 2769);
return return_v;
}


bool
f_10514_3363_3393(Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = node.IsDefaultValue();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 3363, 3393);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10514_3500_3527(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 3500, 3527);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10514_3591_3618(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 3591, 3618);
return return_v;
}


bool
f_10514_3590_3625_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 3590, 3625);
return return_v;
}


int
f_10514_3577_3626(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 3577, 3626);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10514_3658_3751(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenLeft,Microsoft.CodeAnalysis.CSharp.Conversion
leftConversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenResultType)
{
var return_v = this_param.GetConvertedLeftForNullCoalescingOperator( rewrittenLeft, leftConversion, rewrittenResultType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 3658, 3751);
return return_v;
}


bool
f_10514_3969_3998(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.IsStringConcat( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 3969, 3998);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10514_4039_4132(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenLeft,Microsoft.CodeAnalysis.CSharp.Conversion
leftConversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenResultType)
{
var return_v = this_param.GetConvertedLeftForNullCoalescingOperator( rewrittenLeft, leftConversion, rewrittenResultType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 4039, 4132);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10514_4394_4412(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 4394, 4412);
return return_v;
}


int
f_10514_4381_4420(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 4381, 4420);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10514_4439_4457(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 4439, 4457);
return return_v;
}


bool
f_10514_4439_4473(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.IsReferenceType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 4439, 4473);
return return_v;
}


bool
f_10514_4540_4569_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 4540, 4569);
return return_v;
}


bool
f_10514_4607_4633_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 4607, 4633);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10514_4691_4800(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( syntax, rewrittenOperand, conversion, rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 4691, 4800);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
f_10514_4845_4969(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
leftOperand,Microsoft.CodeAnalysis.CSharp.BoundExpression
rightOperand,Microsoft.CodeAnalysis.CSharp.Conversion
leftConversion,Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperatorResultKind
operatorResultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator( syntax, leftOperand, rightOperand, leftConversion, operatorResultKind, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 4845, 4969);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10514_5266_5295(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.WhenNullOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 5266, 5295);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10514_5329_5358(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.WhenNullOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 5329, 5358);
return return_v;
}


bool
f_10514_5307_5359(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableNeverHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 5307, 5359);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10514_5445_5474(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.WhenNotNull;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 5445, 5474);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10514_5422_5475(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableAlwaysHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 5422, 5475);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10514_5651_5667(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 5651, 5667);
return return_v;
}


bool
f_10514_5651_5684(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsNullableType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 5651, 5684);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10514_5758_5787(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.WhenNotNull;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 5758, 5787);
return return_v;
}


bool
f_10514_5847_5875(Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = node.IsDefaultValue();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 5847, 5875);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10514_5879_5895(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 5879, 5895);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10514_5879_5907(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 5879, 5907);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10514_6131_6157(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.Receiver;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 6131, 6157);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10514_6188_6223(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.HasValueMethodOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 6188, 6223);
return return_v;
}


int
f_10514_6370_6390(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 6370, 6390);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
f_10514_6076_6473(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
hasValueMethodOpt,Microsoft.CodeAnalysis.CSharp.BoundExpression
whenNotNull,Microsoft.CodeAnalysis.CSharp.BoundExpression?
whenNullOpt,int
id,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Update( receiver, hasValueMethodOpt, whenNotNull: whenNotNull, whenNullOpt: whenNullOpt, id: id, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 6076, 6473);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10514_6670_6688(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 6670, 6688);
return return_v;
}


bool
f_10514_6670_6705(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsNullableType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 6670, 6705);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10514_6726_6767(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = RemoveIdentityConversions( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 6726, 6767);
return return_v;
}


bool
f_10514_6726_6784(Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = node.IsDefaultValue();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 6726, 6784);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10514_6805_6824(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 6805, 6824);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10514_6832_6850(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 6832, 6850);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10514_6832_6878(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.GetNullableUnderlyingType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 6832, 6878);
return return_v;
}


bool
f_10514_6805_6913(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
t2,Microsoft.CodeAnalysis.TypeCompareKind
compareKind)
{
var return_v = this_param.Equals( t2, compareKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 6805, 6913);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10514_6977_6995(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 6977, 6995);
return return_v;
}


bool
f_10514_6934_7083(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
nullableType,Microsoft.CodeAnalysis.SpecialMember
member,out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
result)
{
var return_v = this_param.TryGetNullableMethod( syntax, nullableType, member, out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 6934, 7083);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10514_7124_7201(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 7124, 7201);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10514_7480_7535(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 7480, 7535);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10514_7609_7670(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
rewrittenExpr,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind)
{
var return_v = this_param.MakeNullCheck( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenExpr, operatorKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 7609, 7670);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10514_7777_7866(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
rewrittenLeft,Microsoft.CodeAnalysis.CSharp.Conversion
leftConversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenResultType)
{
var return_v = this_param.GetConvertedLeftForNullCoalescingOperator( (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenLeft, leftConversion, rewrittenResultType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 7777, 7866);
return return_v;
}


bool
f_10514_7894_7917(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.HasErrors ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 7894, 7917);
return return_v;
}


bool
f_10514_7921_8071(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
t2,Microsoft.CodeAnalysis.TypeCompareKind
compareKind)
{
var return_v = this_param.Equals( t2, compareKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 7921, 8071);
return return_v;
}


int
f_10514_7881_8072(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 7881, 8072);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10514_8214_8556(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenConsequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenAlternative,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
isRef)
{
var return_v = RewriteConditionalOperator( syntax: syntax, rewrittenCondition: rewrittenCondition, rewrittenConsequence: rewrittenConsequence, rewrittenAlternative: rewrittenAlternative, constantValueOpt: constantValueOpt, rewrittenType: rewrittenType, isRef: isRef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 8214, 8556);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10514_8586_8621(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 8586, 8621);
return return_v;
}


int
f_10514_8573_8630(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 8573, 8630);
return 0;
}


bool
f_10514_8708_8866(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
t2,Microsoft.CodeAnalysis.TypeCompareKind
compareKind)
{
var return_v = this_param.Equals( t2, compareKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 8708, 8866);
return return_v;
}


int
f_10514_8695_8867(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 8695, 8867);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10514_8990_9011(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 8990, 9011);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10514_8968_9012(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 8968, 9012);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10514_9044_9098(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 9044, 9098);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10514_8891_9190(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax: syntax, locals: locals, sideEffects: sideEffects, value: value, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 8891, 9190);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10514,1022,9202);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10514,1022,9202);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool IsStringConcat(BoundExpression expression)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10514,9214,10815);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,9294,9393) || true) && (f_10514_9298_9313(expression)!= BoundKind.Call)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10514,9294,9393);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,9365,9378);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10514,9294,9393);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,9409,9447);

var 
boundCall = (BoundCall)expression
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,9463,9493);

var 
method = f_10514_9476_9492(boundCall)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,9509,10775) || true) && (f_10514_9513_9528(method)&&(DynAbs.Tracing.TraceSender.Expression_True(10514, 9513, 9594)&&f_10514_9532_9565(f_10514_9532_9553(method))== SpecialType.System_String))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10514,9509,10775);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,9628,10760) || true) && ((object)method == (object)f_10514_9658_9740(_compilation, SpecialMember.System_String__ConcatStringString)||(DynAbs.Tracing.TraceSender.Expression_False(10514, 9632, 9879)||                    (object)method == (object)f_10514_9791_9879(_compilation, SpecialMember.System_String__ConcatStringStringString))||(DynAbs.Tracing.TraceSender.Expression_False(10514, 9632, 10024)||                    (object)method == (object)f_10514_9930_10024(_compilation, SpecialMember.System_String__ConcatStringStringStringString))||(DynAbs.Tracing.TraceSender.Expression_False(10514, 9632, 10151)||                    (object)method == (object)f_10514_10075_10151(_compilation, SpecialMember.System_String__ConcatObject))||(DynAbs.Tracing.TraceSender.Expression_False(10514, 9632, 10284)||                    (object)method == (object)f_10514_10202_10284(_compilation, SpecialMember.System_String__ConcatObjectObject))||(DynAbs.Tracing.TraceSender.Expression_False(10514, 9632, 10423)||                    (object)method == (object)f_10514_10335_10423(_compilation, SpecialMember.System_String__ConcatObjectObjectObject))||(DynAbs.Tracing.TraceSender.Expression_False(10514, 9632, 10555)||                    (object)method == (object)f_10514_10474_10555(_compilation, SpecialMember.System_String__ConcatStringArray))||(DynAbs.Tracing.TraceSender.Expression_False(10514, 9632, 10687)||                    (object)method == (object)f_10514_10606_10687(_compilation, SpecialMember.System_String__ConcatObjectArray)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10514,9628,10760);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,10729,10741);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10514,9628,10760);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10514,9509,10775);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,10791,10804);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(10514,9214,10815);

Microsoft.CodeAnalysis.CSharp.BoundKind
f_10514_9298_9313(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 9298, 9313);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10514_9476_9492(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 9476, 9492);
return return_v;
}


bool
f_10514_9513_9528(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.IsStatic ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 9513, 9528);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10514_9532_9553(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 9532, 9553);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10514_9532_9565(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 9532, 9565);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10514_9658_9740(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.GetSpecialTypeMember( specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 9658, 9740);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10514_9791_9879(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.GetSpecialTypeMember( specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 9791, 9879);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10514_9930_10024(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.GetSpecialTypeMember( specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 9930, 10024);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10514_10075_10151(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.GetSpecialTypeMember( specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 10075, 10151);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10514_10202_10284(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.GetSpecialTypeMember( specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 10202, 10284);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10514_10335_10423(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.GetSpecialTypeMember( specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 10335, 10423);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10514_10474_10555(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.GetSpecialTypeMember( specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 10474, 10555);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10514_10606_10687(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.GetSpecialTypeMember( specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 10606, 10687);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10514,9214,10815);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10514,9214,10815);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static BoundExpression RemoveIdentityConversions(BoundExpression expression)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10514,10827,11341);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,10936,11296) || true) && (f_10514_10943_10958(expression)== BoundKind.Conversion)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10514,10936,11296);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,11016,11066);

var 
boundConversion = (BoundConversion)expression
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,11084,11224) || true) && (f_10514_11088_11118(boundConversion)!= ConversionKind.Identity)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10514,11084,11224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,11187,11205);

return expression;
DynAbs.Tracing.TraceSender.TraceExitCondition(10514,11084,11224);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,11244,11281);

expression = f_10514_11257_11280(boundConversion);
DynAbs.Tracing.TraceSender.TraceExitCondition(10514,10936,11296);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10514,10936,11296);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10514,10936,11296);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,11312,11330);

return expression;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10514,10827,11341);

Microsoft.CodeAnalysis.CSharp.BoundKind
f_10514_10943_10958(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 10943, 10958);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.ConversionKind
f_10514_11088_11118(Microsoft.CodeAnalysis.CSharp.BoundConversion
this_param)
{
var return_v = this_param.ConversionKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 11088, 11118);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10514_11257_11280(Microsoft.CodeAnalysis.CSharp.BoundConversion
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 11257, 11280);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10514,10827,11341);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10514,10827,11341);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression GetConvertedLeftForNullCoalescingOperator(BoundExpression rewrittenLeft, Conversion leftConversion, TypeSymbol rewrittenResultType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10514,11353,13268);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,11533,11569);

f_10514_11533_11568(rewrittenLeft != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,11583,11623);

f_10514_11583_11622(f_10514_11596_11614(rewrittenLeft)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,11637,11678);

f_10514_11637_11677(rewrittenResultType is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,11692,11729);

f_10514_11692_11728(leftConversion.IsValid);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,11745,11795);

TypeSymbol 
rewrittenLeftType = f_10514_11776_11794(rewrittenLeft)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,11809,11892);

f_10514_11809_11891(f_10514_11822_11856(rewrittenLeftType)||(DynAbs.Tracing.TraceSender.Expression_False(10514, 11822, 11890)||f_10514_11860_11890_M(!rewrittenLeftType.IsValueType)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,12386,13124) || true) && (!f_10514_12391_12485(rewrittenLeftType, rewrittenResultType, TypeCompareKind.ConsiderEverything2)&&(DynAbs.Tracing.TraceSender.Expression_True(10514, 12390, 12523)&&f_10514_12489_12523(rewrittenLeftType)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10514,12386,13124);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,12557,12633);

TypeSymbol 
strippedLeftType = f_10514_12587_12632(rewrittenLeftType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,12651,12800);

MethodSymbol 
getValueOrDefault = f_10514_12684_12799(this, rewrittenLeft.Syntax, rewrittenLeftType, SpecialMember.System_Nullable_T_GetValueOrDefault)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,12818,12912);

rewrittenLeft = f_10514_12834_12911(rewrittenLeft.Syntax, rewrittenLeft, getValueOrDefault);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,12930,13109) || true) && (f_10514_12934_13027(strippedLeftType, rewrittenResultType, TypeCompareKind.ConsiderEverything2))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10514,12930,13109);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,13069,13090);

return rewrittenLeft;
DynAbs.Tracing.TraceSender.TraceExitCondition(10514,12930,13109);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10514,12386,13124);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10514,13140,13257);

return f_10514_13147_13256(this, rewrittenLeft.Syntax, rewrittenLeft, leftConversion, rewrittenResultType, @checked: false);
DynAbs.Tracing.TraceSender.TraceExitMethod(10514,11353,13268);

int
f_10514_11533_11568(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 11533, 11568);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10514_11596_11614(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 11596, 11614);
return return_v;
}


int
f_10514_11583_11622(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 11583, 11622);
return 0;
}


int
f_10514_11637_11677(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 11637, 11677);
return 0;
}


int
f_10514_11692_11728(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 11692, 11728);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10514_11776_11794(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 11776, 11794);
return return_v;
}


bool
f_10514_11822_11856(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsNullableType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 11822, 11856);
return return_v;
}


bool
f_10514_11860_11890_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10514, 11860, 11890);
return return_v;
}


int
f_10514_11809_11891(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 11809, 11891);
return 0;
}


bool
f_10514_12391_12485(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
left,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 12391, 12485);
return return_v;
}


bool
f_10514_12489_12523(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsNullableType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 12489, 12523);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10514_12587_12632(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.GetNullableUnderlyingType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 12587, 12632);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10514_12684_12799(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
nullableType,Microsoft.CodeAnalysis.SpecialMember
member)
{
var return_v = this_param.UnsafeGetNullableMethod( syntax, nullableType, member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 12684, 12799);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10514_12834_12911(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 12834, 12911);
return return_v;
}


bool
f_10514_12934_13027(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
left,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 12934, 13027);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10514_13147_13256(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( syntax, rewrittenOperand, conversion, rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10514, 13147, 13256);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10514,11353,13268);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10514,11353,13268);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
