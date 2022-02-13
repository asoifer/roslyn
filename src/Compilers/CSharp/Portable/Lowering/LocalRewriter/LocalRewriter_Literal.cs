// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
internal partial class LocalRewriter
{
public override BoundNode VisitLiteral(BoundLiteral node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10509,572,800);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,654,694);

f_10509_654_693(f_10509_667_685(node)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,708,789);

return f_10509_715_788(this, node.Syntax, f_10509_740_758(node), f_10509_760_769(node), oldNodeOpt: node);
DynAbs.Tracing.TraceSender.TraceExitMethod(10509,572,800);

Microsoft.CodeAnalysis.ConstantValue?
f_10509_667_685(Microsoft.CodeAnalysis.CSharp.BoundLiteral
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10509, 667, 685);
return return_v;
}


int
f_10509_654_693(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 654, 693);
return 0;
}


Microsoft.CodeAnalysis.ConstantValue
f_10509_740_758(Microsoft.CodeAnalysis.CSharp.BoundLiteral
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10509, 740, 758);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10509_760_769(Microsoft.CodeAnalysis.CSharp.BoundLiteral
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10509, 760, 769);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10509_715_788(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
type,Microsoft.CodeAnalysis.CSharp.BoundLiteral
oldNodeOpt)
{
var return_v = this_param.MakeLiteral( syntax, constantValue, type, oldNodeOpt: oldNodeOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 715, 788);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10509,572,800);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10509,572,800);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeLiteral(SyntaxNode syntax, ConstantValue constantValue, TypeSymbol? type, BoundLiteral? oldNodeOpt = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10509,812,2048);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,971,1007);

f_10509_971_1006(constantValue != null);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,1023,2037) || true) && (f_10509_1027_1050(constantValue))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10509,1023,2037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,1129,1195);

f_10509_1129_1194(type is { SpecialType: SpecialType.System_Decimal });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,1213,1262);

return f_10509_1220_1261(this, syntax, constantValue);
DynAbs.Tracing.TraceSender.TraceExitCondition(10509,1023,2037);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10509,1023,2037);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,1296,2037) || true) && (f_10509_1300_1324(constantValue))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10509,1296,2037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,1600,1667);

f_10509_1600_1666(type is { SpecialType: SpecialType.System_DateTime });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,1685,1735);

return f_10509_1692_1734(this, syntax, constantValue);
DynAbs.Tracing.TraceSender.TraceExitCondition(10509,1296,2037);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10509,1296,2037);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,1769,2037) || true) && (oldNodeOpt != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10509,1769,2037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,1825,1871);

return f_10509_1832_1870(oldNodeOpt, constantValue, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10509,1769,2037);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10509,1769,2037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,1937,2022);

return f_10509_1944_2021(syntax, constantValue, type, hasErrors: f_10509_2001_2020(constantValue));
DynAbs.Tracing.TraceSender.TraceExitCondition(10509,1769,2037);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10509,1296,2037);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10509,1023,2037);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10509,812,2048);

int
f_10509_971_1006(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 971, 1006);
return 0;
}


bool
f_10509_1027_1050(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.IsDecimal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10509, 1027, 1050);
return return_v;
}


int
f_10509_1129_1194(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 1129, 1194);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10509_1220_1261(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue)
{
var return_v = this_param.MakeDecimalLiteral( syntax, constantValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 1220, 1261);
return return_v;
}


bool
f_10509_1300_1324(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.IsDateTime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10509, 1300, 1324);
return return_v;
}


int
f_10509_1600_1666(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 1600, 1666);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10509_1692_1734(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue)
{
var return_v = this_param.MakeDateTimeLiteral( syntax, constantValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 1692, 1734);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10509_1832_1870(Microsoft.CodeAnalysis.CSharp.BoundLiteral
this_param,Microsoft.CodeAnalysis.ConstantValue
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
type)
{
var return_v = this_param.Update( constantValueOpt, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 1832, 1870);
return return_v;
}


bool
f_10509_2001_2020(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.IsBad;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10509, 2001, 2020);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10509_1944_2021(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
type,bool
hasErrors)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLiteral( syntax, constantValueOpt, type, hasErrors: hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 1944, 2021);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10509,812,2048);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10509,812,2048);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeDecimalLiteral(SyntaxNode syntax, ConstantValue constantValue)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10509,2060,7290);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,2175,2211);

f_10509_2175_2210(constantValue != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,2225,2263);

f_10509_2225_2262(f_10509_2238_2261(constantValue));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,2279,2318);

var 
value = f_10509_2291_2317(constantValue)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,2332,2348);

bool 
isNegative
=default(bool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,2362,2373);

byte 
scale
=default(byte);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,2387,2407);

uint 
low
=default(uint),
mid
=default(uint),
high
=default(uint);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,2421,2490);

f_10509_2421_2489(            value, out isNegative, out scale, out low, out mid, out high);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,2506,2558);

var 
arguments = f_10509_2522_2557()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,2572,2593);

SpecialMember 
member
=default(SpecialMember);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,2698,6576) || true) && (scale == 0 &&(DynAbs.Tracing.TraceSender.Expression_True(10509, 2702, 2737)&&int.MinValue <= value )&&(DynAbs.Tracing.TraceSender.Expression_True(10509, 2702, 2762)&&value <= int.MaxValue))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10509,2698,6576);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,2932,2973);

var 
curMethod = f_10509_2948_2972(_factory)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,2991,3022);

f_10509_2991_3021(curMethod is { });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,3040,4257) || true) && ((f_10509_3045_3065(curMethod)!= MethodKind.SharedConstructor ||(DynAbs.Tracing.TraceSender.Expression_False(10509, 3045, 3187)||f_10509_3121_3157(f_10509_3121_3145(curMethod))!= SpecialType.System_Decimal)) &&(DynAbs.Tracing.TraceSender.Expression_True(10509, 3044, 3232)&&                   !_inExpressionLambda))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10509,3040,4257);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,3274,3298);

Symbol? 
useField = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,3322,3919) || true) && (value == decimal.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10509,3322,3919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,3397,3478);

useField = f_10509_3408_3477(_compilation, SpecialMember.System_Decimal__Zero);
DynAbs.Tracing.TraceSender.TraceExitCondition(10509,3322,3919);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10509,3322,3919);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,3528,3919) || true) && (value == decimal.One)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10509,3528,3919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,3602,3682);

useField = f_10509_3613_3681(_compilation, SpecialMember.System_Decimal__One);
DynAbs.Tracing.TraceSender.TraceExitCondition(10509,3528,3919);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10509,3528,3919);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,3732,3919) || true) && (value == decimal.MinusOne)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10509,3732,3919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,3811,3896);

useField = f_10509_3822_3895(_compilation, SpecialMember.System_Decimal__MinusOne);
DynAbs.Tracing.TraceSender.TraceExitCondition(10509,3732,3919);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10509,3528,3919);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10509,3322,3919);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,3943,4238) || true) && (useField is { HasUseSiteError: false, ContainingType: { HasUseSiteError: false } })
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10509,3943,4238);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,4079,4119);

var 
fieldSymbol = (FieldSymbol)useField
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,4145,4215);

return f_10509_4152_4214(syntax, null, fieldSymbol, constantValue);
DynAbs.Tracing.TraceSender.TraceExitCondition(10509,3943,4238);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10509,3040,4257);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,4314,4363);

member = SpecialMember.System_Decimal__CtorInt32;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,4381,4510);

f_10509_4381_4509(                arguments, f_10509_4395_4508(syntax, f_10509_4420_4452(value), f_10509_4454_4507(_compilation, SpecialType.System_Int32)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10509,2698,6576);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10509,2698,6576);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,4544,6576) || true) && (scale == 0 &&(DynAbs.Tracing.TraceSender.Expression_True(10509, 4548, 4584)&&uint.MinValue <= value )&&(DynAbs.Tracing.TraceSender.Expression_True(10509, 4548, 4610)&&value <= uint.MaxValue))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10509,4544,6576);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,4682,4732);

member = SpecialMember.System_Decimal__CtorUInt32;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,4750,4881);

f_10509_4750_4880(                arguments, f_10509_4764_4879(syntax, f_10509_4789_4822(value), f_10509_4824_4878(_compilation, SpecialType.System_UInt32)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10509,4544,6576);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10509,4544,6576);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,4915,6576) || true) && (scale == 0 &&(DynAbs.Tracing.TraceSender.Expression_True(10509, 4919, 4955)&&long.MinValue <= value )&&(DynAbs.Tracing.TraceSender.Expression_True(10509, 4919, 4981)&&value <= long.MaxValue))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10509,4915,6576);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,5053,5102);

member = SpecialMember.System_Decimal__CtorInt64;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,5120,5250);

f_10509_5120_5249(                arguments, f_10509_5134_5248(syntax, f_10509_5159_5192(value), f_10509_5194_5247(_compilation, SpecialType.System_Int64)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10509,4915,6576);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10509,4915,6576);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,5284,6576) || true) && (scale == 0 &&(DynAbs.Tracing.TraceSender.Expression_True(10509, 5288, 5325)&&ulong.MinValue <= value )&&(DynAbs.Tracing.TraceSender.Expression_True(10509, 5288, 5352)&&value <= ulong.MaxValue))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10509,5284,6576);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,5425,5475);

member = SpecialMember.System_Decimal__CtorUInt64;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,5493,5625);

f_10509_5493_5624(                arguments, f_10509_5507_5623(syntax, f_10509_5532_5566(value), f_10509_5568_5622(_compilation, SpecialType.System_UInt64)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10509,5284,6576);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10509,5284,6576);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,5780,5850);

member = SpecialMember.System_Decimal__CtorInt32Int32Int32BooleanByte;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,5868,5990);

f_10509_5868_5989(                arguments, f_10509_5882_5988(syntax, f_10509_5907_5932(low), f_10509_5934_5987(_compilation, SpecialType.System_Int32)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,6008,6130);

f_10509_6008_6129(                arguments, f_10509_6022_6128(syntax, f_10509_6047_6072(mid), f_10509_6074_6127(_compilation, SpecialType.System_Int32)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,6148,6271);

f_10509_6148_6270(                arguments, f_10509_6162_6269(syntax, f_10509_6187_6213(high), f_10509_6215_6268(_compilation, SpecialType.System_Int32)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,6289,6420);

f_10509_6289_6419(                arguments, f_10509_6303_6418(syntax, f_10509_6328_6360(isNegative), f_10509_6362_6417(_compilation, SpecialType.System_Boolean)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,6438,6561);

f_10509_6438_6560(                arguments, f_10509_6452_6559(syntax, f_10509_6477_6504(scale), f_10509_6506_6558(_compilation, SpecialType.System_Byte)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10509,5284,6576);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10509,4915,6576);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10509,4544,6576);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10509,2698,6576);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,6592,6668);

var 
ctor = (MethodSymbol)f_10509_6617_6667(f_10509_6617_6638(_compilation), member)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,6682,6717);

f_10509_6682_6716((object)ctor != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,6731,6807);

f_10509_6731_6806(f_10509_6744_6775(f_10509_6744_6763(ctor))== SpecialType.System_Decimal);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,6823,7279);

return f_10509_6830_7278(syntax, ctor, f_10509_6896_6926(arguments), argumentNamesOpt: default(ImmutableArray<string>), argumentRefKindsOpt: default(ImmutableArray<RefKind>), expanded: false, argsToParamsOpt: default(ImmutableArray<int>), defaultArguments: default(BitVector), constantValueOpt: constantValue, initializerExpressionOpt: null, type: f_10509_7258_7277(ctor));
DynAbs.Tracing.TraceSender.TraceExitMethod(10509,2060,7290);

int
f_10509_2175_2210(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 2175, 2210);
return 0;
}


bool
f_10509_2238_2261(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.IsDecimal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10509, 2238, 2261);
return return_v;
}


int
f_10509_2225_2262(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 2225, 2262);
return 0;
}


decimal
f_10509_2291_2317(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.DecimalValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10509, 2291, 2317);
return return_v;
}


int
f_10509_2421_2489(decimal
value,out bool
isNegative,out byte
scale,out uint
low,out uint
mid,out uint
high)
{
value.GetBits( out isNegative, out scale, out low, out mid, out high);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 2421, 2489);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10509_2522_2557()
{
var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 2522, 2557);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10509_2948_2972(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.CurrentFunction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10509, 2948, 2972);
return return_v;
}


int
f_10509_2991_3021(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 2991, 3021);
return 0;
}


Microsoft.CodeAnalysis.MethodKind
f_10509_3045_3065(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.MethodKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10509, 3045, 3065);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10509_3121_3145(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10509, 3121, 3145);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10509_3121_3157(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10509, 3121, 3157);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10509_3408_3477(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.GetSpecialTypeMember( specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 3408, 3477);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10509_3613_3681(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.GetSpecialTypeMember( specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 3613, 3681);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10509_3822_3895(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.GetSpecialTypeMember( specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 3822, 3895);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
f_10509_4152_4214(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
fieldSymbol,Microsoft.CodeAnalysis.ConstantValue
constantValueOpt)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundFieldAccess( syntax, receiver, fieldSymbol, constantValueOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 4152, 4214);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10509_4420_4452(decimal
value)
{
var return_v = ConstantValue.Create( (int)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 4420, 4452);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10509_4454_4507(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 4454, 4507);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10509_4395_4508(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLiteral( syntax, constantValueOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 4395, 4508);
return return_v;
}


int
f_10509_4381_4509(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLiteral
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 4381, 4509);
return 0;
}


Microsoft.CodeAnalysis.ConstantValue
f_10509_4789_4822(decimal
value)
{
var return_v = ConstantValue.Create( (uint)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 4789, 4822);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10509_4824_4878(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 4824, 4878);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10509_4764_4879(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLiteral( syntax, constantValueOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 4764, 4879);
return return_v;
}


int
f_10509_4750_4880(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLiteral
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 4750, 4880);
return 0;
}


Microsoft.CodeAnalysis.ConstantValue
f_10509_5159_5192(decimal
value)
{
var return_v = ConstantValue.Create( (long)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 5159, 5192);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10509_5194_5247(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 5194, 5247);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10509_5134_5248(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLiteral( syntax, constantValueOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 5134, 5248);
return return_v;
}


int
f_10509_5120_5249(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLiteral
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 5120, 5249);
return 0;
}


Microsoft.CodeAnalysis.ConstantValue
f_10509_5532_5566(decimal
value)
{
var return_v = ConstantValue.Create( (ulong)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 5532, 5566);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10509_5568_5622(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 5568, 5622);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10509_5507_5623(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLiteral( syntax, constantValueOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 5507, 5623);
return return_v;
}


int
f_10509_5493_5624(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLiteral
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 5493, 5624);
return 0;
}


Microsoft.CodeAnalysis.ConstantValue
f_10509_5907_5932(uint
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 5907, 5932);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10509_5934_5987(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 5934, 5987);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10509_5882_5988(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLiteral( syntax, constantValueOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 5882, 5988);
return return_v;
}


int
f_10509_5868_5989(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLiteral
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 5868, 5989);
return 0;
}


Microsoft.CodeAnalysis.ConstantValue
f_10509_6047_6072(uint
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 6047, 6072);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10509_6074_6127(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 6074, 6127);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10509_6022_6128(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLiteral( syntax, constantValueOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 6022, 6128);
return return_v;
}


int
f_10509_6008_6129(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLiteral
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 6008, 6129);
return 0;
}


Microsoft.CodeAnalysis.ConstantValue
f_10509_6187_6213(uint
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 6187, 6213);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10509_6215_6268(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 6215, 6268);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10509_6162_6269(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLiteral( syntax, constantValueOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 6162, 6269);
return return_v;
}


int
f_10509_6148_6270(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLiteral
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 6148, 6270);
return 0;
}


Microsoft.CodeAnalysis.ConstantValue
f_10509_6328_6360(bool
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 6328, 6360);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10509_6362_6417(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 6362, 6417);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10509_6303_6418(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLiteral( syntax, constantValueOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 6303, 6418);
return return_v;
}


int
f_10509_6289_6419(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLiteral
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 6289, 6419);
return 0;
}


Microsoft.CodeAnalysis.ConstantValue
f_10509_6477_6504(byte
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 6477, 6504);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10509_6506_6558(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 6506, 6558);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10509_6452_6559(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLiteral( syntax, constantValueOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 6452, 6559);
return return_v;
}


int
f_10509_6438_6560(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLiteral
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 6438, 6560);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
f_10509_6617_6638(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10509, 6617, 6638);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10509_6617_6667(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
this_param,Microsoft.CodeAnalysis.SpecialMember
member)
{
var return_v = this_param.GetSpecialTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 6617, 6667);
return return_v;
}


int
f_10509_6682_6716(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 6682, 6716);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10509_6744_6763(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10509, 6744, 6763);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10509_6744_6775(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10509, 6744, 6775);
return return_v;
}


int
f_10509_6731_6806(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 6731, 6806);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10509_6896_6926(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 6896, 6926);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10509_7258_7277(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10509, 7258, 7277);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
f_10509_6830_7278(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
constructor,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments,System.Collections.Immutable.ImmutableArray<string>
argumentNamesOpt,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKindsOpt,bool
expanded,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,Microsoft.CodeAnalysis.BitVector
defaultArguments,Microsoft.CodeAnalysis.ConstantValue
constantValueOpt,Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
initializerExpressionOpt,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression( syntax, constructor, arguments, argumentNamesOpt: argumentNamesOpt, argumentRefKindsOpt: argumentRefKindsOpt, expanded: expanded, argsToParamsOpt: argsToParamsOpt, defaultArguments: defaultArguments, constantValueOpt: constantValueOpt, initializerExpressionOpt: initializerExpressionOpt, type: (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 6830, 7278);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10509,2060,7290);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10509,2060,7290);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeDateTimeLiteral(SyntaxNode syntax, ConstantValue constantValue)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10509,7302,8591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,7418,7454);

f_10509_7418_7453(constantValue != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,7468,7507);

f_10509_7468_7506(f_10509_7481_7505(constantValue));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,7523,7575);

var 
arguments = f_10509_7539_7574()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,7589,7741);

f_10509_7589_7740(            arguments, f_10509_7603_7739(syntax, f_10509_7628_7683(constantValue.DateTimeValue.Ticks), f_10509_7685_7738(_compilation, SpecialType.System_Int64)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,7757,7867);

var 
ctor = (MethodSymbol)f_10509_7782_7866(f_10509_7782_7803(_compilation), SpecialMember.System_DateTime__CtorInt64)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,7881,7916);

f_10509_7881_7915((object)ctor != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,7930,8007);

f_10509_7930_8006(f_10509_7943_7974(f_10509_7943_7962(ctor))== SpecialType.System_DateTime);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10509,8111,8580);

return f_10509_8118_8579(syntax, ctor, f_10509_8184_8214(arguments), argumentNamesOpt: default(ImmutableArray<string>), argumentRefKindsOpt: default(ImmutableArray<RefKind>), expanded: false, argsToParamsOpt: default(ImmutableArray<int>), defaultArguments: default(BitVector), constantValueOpt: ConstantValue.NotAvailable, initializerExpressionOpt: null, type: f_10509_8559_8578(ctor));
DynAbs.Tracing.TraceSender.TraceExitMethod(10509,7302,8591);

int
f_10509_7418_7453(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 7418, 7453);
return 0;
}


bool
f_10509_7481_7505(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.IsDateTime;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10509, 7481, 7505);
return return_v;
}


int
f_10509_7468_7506(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 7468, 7506);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10509_7539_7574()
{
var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 7539, 7574);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10509_7628_7683(long
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 7628, 7683);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10509_7685_7738(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 7685, 7738);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10509_7603_7739(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLiteral( syntax, constantValueOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 7603, 7739);
return return_v;
}


int
f_10509_7589_7740(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundLiteral
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 7589, 7740);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
f_10509_7782_7803(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10509, 7782, 7803);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10509_7782_7866(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
this_param,Microsoft.CodeAnalysis.SpecialMember
member)
{
var return_v = this_param.GetSpecialTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 7782, 7866);
return return_v;
}


int
f_10509_7881_7915(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 7881, 7915);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10509_7943_7962(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10509, 7943, 7962);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10509_7943_7974(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10509, 7943, 7974);
return return_v;
}


int
f_10509_7930_8006(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 7930, 8006);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10509_8184_8214(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 8184, 8214);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10509_8559_8578(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10509, 8559, 8578);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
f_10509_8118_8579(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
constructor,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments,System.Collections.Immutable.ImmutableArray<string>
argumentNamesOpt,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKindsOpt,bool
expanded,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,Microsoft.CodeAnalysis.BitVector
defaultArguments,Microsoft.CodeAnalysis.ConstantValue
constantValueOpt,Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
initializerExpressionOpt,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression( syntax, constructor, arguments, argumentNamesOpt: argumentNamesOpt, argumentRefKindsOpt: argumentRefKindsOpt, expanded: expanded, argsToParamsOpt: argsToParamsOpt, defaultArguments: defaultArguments, constantValueOpt: constantValueOpt, initializerExpressionOpt: initializerExpressionOpt, type: (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10509, 8118, 8579);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10509,7302,8591);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10509,7302,8591);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
