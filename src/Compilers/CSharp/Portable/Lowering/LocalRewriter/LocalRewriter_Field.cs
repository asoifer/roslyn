// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitFieldAccess(BoundFieldAccess node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10496,364,677);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,454,525);

BoundExpression? 
rewrittenReceiver = f_10496_491_524(this, f_10496_507_523(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,539,666);

return f_10496_546_665(this, node.Syntax, rewrittenReceiver, f_10496_594_610(node), f_10496_612_630(node), f_10496_632_647(node), f_10496_649_658(node), node);
DynAbs.Tracing.TraceSender.TraceExitMethod(10496,364,677);

Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10496_507_523(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
this_param)
{
var return_v = this_param.ReceiverOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10496, 507, 523);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10496_491_524(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10496, 491, 524);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
f_10496_594_610(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
this_param)
{
var return_v = this_param.FieldSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10496, 594, 610);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10496_612_630(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10496, 612, 630);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LookupResultKind
f_10496_632_647(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
this_param)
{
var return_v = this_param.ResultKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10496, 632, 647);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10496_649_658(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10496, 649, 658);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10496_546_665(Microsoft.CodeAnalysis.CSharp.LocalRewriter
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
DynAbs.Tracing.TraceSender.TraceEndInvocation(10496, 546, 665);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10496,364,677);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10496,364,677);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeFieldAccess(
            SyntaxNode syntax,
            BoundExpression? rewrittenReceiver,
            FieldSymbol fieldSymbol,
            ConstantValue? constantValueOpt,
            LookupResultKind resultKind,
            TypeSymbol type,
            BoundFieldAccess? oldNodeOpt = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10496,689,1766);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,1041,1200) || true) && (f_10496_1045_1083(f_10496_1045_1071(fieldSymbol)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10496,1041,1200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,1117,1185);

return f_10496_1124_1184(this, syntax, fieldSymbol, rewrittenReceiver);
DynAbs.Tracing.TraceSender.TraceExitCondition(10496,1041,1200);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,1216,1481);

BoundExpression 
result = (DynAbs.Tracing.TraceSender.Conditional_F1(10496, 1241, 1259)||((oldNodeOpt != null &&DynAbs.Tracing.TraceSender.Conditional_F2(10496, 1279, 1364))||DynAbs.Tracing.TraceSender.Conditional_F3(10496, 1384, 1480)))?f_10496_1279_1364(                oldNodeOpt, rewrittenReceiver, fieldSymbol, constantValueOpt, resultKind, type):f_10496_1384_1480(syntax, rewrittenReceiver, fieldSymbol, constantValueOpt, resultKind, type)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,1497,1725) || true) && (f_10496_1501_1530(fieldSymbol))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10496,1497,1725);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,1645,1710);

result = f_10496_1654_1709(syntax, result, type, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10496,1497,1725);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,1741,1755);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10496,689,1766);

Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10496_1045_1071(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10496, 1045, 1071);
return return_v;
}


bool
f_10496_1045_1083(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.IsTupleType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10496, 1045, 1083);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10496_1124_1184(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
tupleField,Microsoft.CodeAnalysis.CSharp.BoundExpression?
rewrittenReceiver)
{
var return_v = this_param.MakeTupleFieldAccess( syntax, tupleField, rewrittenReceiver);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10496, 1124, 1184);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
f_10496_1279_1364(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
fieldSymbol,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
typeSymbol)
{
var return_v = this_param.Update( receiver, fieldSymbol, constantValueOpt, resultKind, typeSymbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10496, 1279, 1364);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
f_10496_1384_1480(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
fieldSymbol,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundFieldAccess( syntax, receiver, fieldSymbol, constantValueOpt, resultKind, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10496, 1384, 1480);
return return_v;
}


bool
f_10496_1501_1530(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
this_param)
{
var return_v = this_param.IsFixedSizeBuffer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10496, 1501, 1530);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
f_10496_1654_1709(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
operand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,bool
hasErrors)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator( syntax, operand, type, hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10496, 1654, 1709);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10496,689,1766);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10496,689,1766);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeTupleFieldAccess(
            SyntaxNode syntax,
            FieldSymbol tupleField,
            BoundExpression? rewrittenReceiver)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10496,2085,4421);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,2273,2315);

var 
tupleType = f_10496_2289_2314(tupleField)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,2331,2375);

NamedTypeSymbol 
currentLinkType = tupleType
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,2389,2451);

FieldSymbol 
underlyingField = f_10496_2419_2450(tupleField)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,2467,2668) || true) && ((object)underlyingField == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10496,2467,2668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,2606,2653);

return f_10496_2613_2652(_factory, f_10496_2636_2651(tupleField));
DynAbs.Tracing.TraceSender.TraceExitCondition(10496,2467,2668);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,2684,2943) || true) && (f_10496_2688_2711_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(rewrittenReceiver, 10496, 2688, 2711)?.Kind)== BoundKind.DefaultExpression)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10496,2684,2943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,2869,2928);

return f_10496_2876_2927(syntax, f_10496_2911_2926(tupleField));
DynAbs.Tracing.TraceSender.TraceExitCondition(10496,2684,2943);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,2959,4274) || true) && (!f_10496_2964_3067(f_10496_2982_3012(underlyingField), currentLinkType, TypeCompareKind.ConsiderEverything2))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10496,2959,4274);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,3101,3253);

WellKnownMember 
wellKnownTupleRest = f_10496_3138_3252(NamedTypeSymbol.ValueTupleRestPosition, NamedTypeSymbol.ValueTupleRestPosition)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,3271,3425);

var 
tupleRestField = (FieldSymbol?)f_10496_3306_3424(f_10496_3347_3381(currentLinkType), wellKnownTupleRest, _diagnostics, syntax)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,3445,3650) || true) && (tupleRestField is null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10496,3445,3650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,3584,3631);

return f_10496_3591_3630(_factory, f_10496_3614_3629(tupleField));
DynAbs.Tracing.TraceSender.TraceExitCondition(10496,3445,3650);
}
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10496,3725,4259);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,3768,3841);

FieldSymbol 
nestedFieldSymbol = f_10496_3800_3840(tupleRestField, currentLinkType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,3863,3936);

rewrittenReceiver = f_10496_3883_3935(_factory, rewrittenReceiver, nestedFieldSymbol);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,3960,4109);

currentLinkType = (NamedTypeSymbol)f_10496_3995_4059(currentLinkType)[NamedTypeSymbol.ValueTupleRestPosition - 1].Type;
DynAbs.Tracing.TraceSender.TraceExitCondition(10496,3725,4259);
}
                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,3725,4259) || true) && (!f_10496_4154_4257(f_10496_4172_4202(underlyingField), currentLinkType, TypeCompareKind.ConsiderEverything2))
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10496,3725,4259);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10496,3725,4259);
}}DynAbs.Tracing.TraceSender.TraceExitCondition(10496,2959,4274);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,4352,4410);

return f_10496_4359_4409(_factory, rewrittenReceiver, underlyingField);
DynAbs.Tracing.TraceSender.TraceExitMethod(10496,2085,4421);

Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10496_2289_2314(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10496, 2289, 2314);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
f_10496_2419_2450(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
this_param)
{
var return_v = this_param.TupleUnderlyingField;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10496, 2419, 2450);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10496_2636_2651(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10496, 2636, 2651);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBadExpression
f_10496_2613_2652(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.BadExpression( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10496, 2613, 2652);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind?
f_10496_2688_2711_M(Microsoft.CodeAnalysis.CSharp.BoundKind?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10496, 2688, 2711);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10496_2911_2926(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10496, 2911, 2926);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
f_10496_2876_2927(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression( syntax, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10496, 2876, 2927);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10496_2982_3012(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10496, 2982, 3012);
return return_v;
}


bool
f_10496_2964_3067(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
left,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10496, 2964, 3067);
return return_v;
}


Microsoft.CodeAnalysis.WellKnownMember
f_10496_3138_3252(int
arity,int
position)
{
var return_v = NamedTypeSymbol.GetTupleTypeMember( arity, position);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10496, 3138, 3252);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10496_3347_3381(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.OriginalDefinition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10496, 3347, 3381);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_10496_3306_3424(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type,Microsoft.CodeAnalysis.WellKnownMember
relativeMember,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.SyntaxNode
syntax)
{
var return_v = NamedTypeSymbol.GetWellKnownMemberInType( type, relativeMember, diagnostics, syntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10496, 3306, 3424);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10496_3614_3629(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10496, 3614, 3629);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBadExpression
f_10496_3591_3630(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.BadExpression( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10496, 3591, 3630);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
f_10496_3800_3840(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
newOwner)
{
var return_v = this_param.AsMember( newOwner);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10496, 3800, 3840);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
f_10496_3883_3935(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
f)
{
var return_v = this_param.Field( receiver, f);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10496, 3883, 3935);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
f_10496_3995_4059(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10496, 3995, 4059);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10496_4172_4202(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10496, 4172, 4202);
return return_v;
}


bool
f_10496_4154_4257(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
left,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10496, 4154, 4257);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
f_10496_4359_4409(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
f)
{
var return_v = this_param.Field( receiver, f);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10496, 4359, 4409);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10496,2085,4421);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10496,2085,4421);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeTupleFieldAccessAndReportUseSiteDiagnostics(BoundExpression tuple, SyntaxNode syntax, FieldSymbol field)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10496,4433,5154);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,4735,4782);

field = f_10496_4743_4772(field)??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>(10496, 4743, 4781)??field);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,4798,4856);

DiagnosticInfo 
useSiteInfo = f_10496_4827_4855(field)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,4870,5077) || true) && ((object)useSiteInfo != null &&(DynAbs.Tracing.TraceSender.Expression_True(10496, 4874, 4953)&&f_10496_4905_4925(useSiteInfo)== DiagnosticSeverity.Error))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10496,4870,5077);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,4987,5062);

f_10496_4987_5061(useSiteInfo, _diagnostics, f_10496_5045_5060(syntax));
DynAbs.Tracing.TraceSender.TraceExitCondition(10496,4870,5077);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10496,5093,5143);

return f_10496_5100_5142(this, syntax, field, tuple);
DynAbs.Tracing.TraceSender.TraceExitMethod(10496,4433,5154);

Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
f_10496_4743_4772(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
this_param)
{
var return_v = this_param.CorrespondingTupleField ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10496, 4743, 4772);
return return_v;
}


Microsoft.CodeAnalysis.DiagnosticInfo
f_10496_4827_4855(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
this_param)
{
var return_v = this_param.GetUseSiteDiagnostic();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10496, 4827, 4855);
return return_v;
}


Microsoft.CodeAnalysis.DiagnosticSeverity
f_10496_4905_4925(Microsoft.CodeAnalysis.DiagnosticInfo
this_param)
{
var return_v = this_param.Severity ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10496, 4905, 4925);
return return_v;
}


Microsoft.CodeAnalysis.Location
f_10496_5045_5060(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Location;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10496, 5045, 5060);
return return_v;
}


bool
f_10496_4987_5061(Microsoft.CodeAnalysis.DiagnosticInfo
info,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.Location
location)
{
var return_v = Symbol.ReportUseSiteDiagnostic( info, diagnostics, location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10496, 4987, 5061);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10496_5100_5142(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
tupleField,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenReceiver)
{
var return_v = this_param.MakeTupleFieldAccess( syntax, tupleField, rewrittenReceiver);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10496, 5100, 5142);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10496,4433,5154);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10496,4433,5154);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
