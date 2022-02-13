// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
private BoundExpression RewriteInterpolatedStringConversion(BoundConversion conversion)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10526,436,1984);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,548,625);

f_10526_548_624(f_10526_561_586(conversion)== ConversionKind.InterpolatedString);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,639,662);

BoundExpression 
format
=default(BoundExpression);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,676,718);

ArrayBuilder<BoundExpression> 
expressions
=default(ArrayBuilder<BoundExpression>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,732,835);

f_10526_732_834(this, f_10526_786_804(conversion), out format, out expressions);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,849,879);

f_10526_849_878(            expressions, 0, format);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,893,1008);

var 
stringFactory = f_10526_913_1007(_factory, WellKnownType.System_Runtime_CompilerServices_FormattableStringFactory)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,1422,1672);

var 
result = f_10526_1435_1671(_factory, stringFactory, "Create", f_10526_1480_1512(expressions), allowUnexpandedForm: false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,1686,1943) || true) && (f_10526_1690_1710_M(!result.HasAnyErrors))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10526,1686,1943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,1744,1777);

result = f_10526_1753_1776(this, result);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,1871,1928);

result = f_10526_1880_1927(this, result, f_10526_1911_1926(conversion));
DynAbs.Tracing.TraceSender.TraceExitCondition(10526,1686,1943);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,1959,1973);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10526,436,1984);

Microsoft.CodeAnalysis.CSharp.ConversionKind
f_10526_561_586(Microsoft.CodeAnalysis.CSharp.BoundConversion
this_param)
{
var return_v = this_param.ConversionKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 561, 586);
return return_v;
}


int
f_10526_548_624(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 548, 624);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10526_786_804(Microsoft.CodeAnalysis.CSharp.BoundConversion
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 786, 804);
return return_v;
}


int
f_10526_732_834(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node,out Microsoft.CodeAnalysis.CSharp.BoundExpression
format,out Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
expressions)
{
this_param.MakeInterpolatedStringFormat( (Microsoft.CodeAnalysis.CSharp.BoundInterpolatedString)node, out format, out expressions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 732, 834);
return 0;
}


int
f_10526_849_878(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,int
index,Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
this_param.Insert( index, item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 849, 878);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10526_913_1007(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.WellKnownType
wt)
{
var return_v = this_param.WellKnownType( wt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 913, 1007);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10526_1480_1512(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 1480, 1512);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10526_1435_1671(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
receiver,string
name,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
args,bool
allowUnexpandedForm)
{
var return_v = this_param.StaticCall( (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)receiver, name, args, allowUnexpandedForm: allowUnexpandedForm);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 1435, 1671);
return return_v;
}


bool
f_10526_1690_1710_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 1690, 1710);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10526_1753_1776(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 1753, 1776);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10526_1911_1926(Microsoft.CodeAnalysis.CSharp.BoundConversion
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 1911, 1926);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10526_1880_1927(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType)
{
var return_v = this_param.MakeImplicitConversion( rewrittenOperand, rewrittenType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 1880, 1927);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10526,436,1984);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10526,436,1984);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool CanLowerToStringConcatenation(BoundInterpolatedString node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10526,1996,2714);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,2093,2675);
foreach(var part in f_10526_2114_2124_I(f_10526_2114_2124(node)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10526,2093,2675);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,2158,2660) || true) && (part is BoundStringInsert fillin)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10526,2158,2660);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,2296,2641) || true) && (_inExpressionLambda ||(DynAbs.Tracing.TraceSender.Expression_False(10526, 2300, 2364)||f_10526_2348_2364(fillin))||(DynAbs.Tracing.TraceSender.Expression_False(10526, 2300, 2452)||f_10526_2393_2423_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10526_2393_2410(f_10526_2393_2405(fillin)), 10526, 2393, 2423)?.SpecialType)!= SpecialType.System_String )||(DynAbs.Tracing.TraceSender.Expression_False(10526, 2300, 2505)||f_10526_2481_2497(fillin)!= null )||(DynAbs.Tracing.TraceSender.Expression_False(10526, 2300, 2555)||f_10526_2534_2547(fillin)!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10526,2296,2641);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,2605,2618);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10526,2296,2641);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10526,2158,2660);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10526,2093,2675);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10526,1,583);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10526,1,583);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,2691,2703);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(10526,1996,2714);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10526_2114_2124(Microsoft.CodeAnalysis.CSharp.BoundInterpolatedString
this_param)
{
var return_v = this_param.Parts;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 2114, 2124);
return return_v;
}


bool
f_10526_2348_2364(Microsoft.CodeAnalysis.CSharp.BoundStringInsert
this_param)
{
var return_v = this_param.HasErrors ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 2348, 2364);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10526_2393_2405(Microsoft.CodeAnalysis.CSharp.BoundStringInsert
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 2393, 2405);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10526_2393_2410(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 2393, 2410);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType?
f_10526_2393_2423_M(Microsoft.CodeAnalysis.SpecialType?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 2393, 2423);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10526_2481_2497(Microsoft.CodeAnalysis.CSharp.BoundStringInsert
this_param)
{
var return_v = this_param.Alignment ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 2481, 2497);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral?
f_10526_2534_2547(Microsoft.CodeAnalysis.CSharp.BoundStringInsert
this_param)
{
var return_v = this_param.Format ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 2534, 2547);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10526_2114_2124_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 2114, 2124);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10526,1996,2714);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10526,1996,2714);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void MakeInterpolatedStringFormat(BoundInterpolatedString node, out BoundExpression format, out ArrayBuilder<BoundExpression> expressions)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10526,2726,4958);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,2897,2927);

_factory.Syntax = node.Syntax;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,2941,2971);

int 
n = node.Parts.Length - 1
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,2985,3038);

var 
formatString = f_10526_3004_3037()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,3052,3093);

var 
stringBuilder = formatString.Builder
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,3107,3170);

expressions = f_10526_3121_3169(n + 1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,3184,3211);

int 
nextFormatPosition = 0
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,3234,3239);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,3225,4867) || true) && (i <= n)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,3249,3252)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(10526,3225,4867))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10526,3225,4867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,3286,3311);

var 
part = f_10526_3297_3307(node)[i]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,3329,3368);

var 
fillin = part as BoundStringInsert
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,3386,4852) || true) && (fillin == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10526,3386,4852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,3446,3511);

f_10526_3446_3510(part is BoundLiteral &&(DynAbs.Tracing.TraceSender.Expression_True(10526, 3459, 3509)&&f_10526_3483_3501(part)!= null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,3590,3643);

f_10526_3590_3642(                    // this is one of the literal parts
                    stringBuilder, f_10526_3611_3641(f_10526_3611_3629(part)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10526,3386,4852);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10526,3386,4852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,3785,3840);

f_10526_3785_3839(f_10526_3785_3810(                    // this is one of the expression holes
                    stringBuilder, '{'), nextFormatPosition++);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,3862,4148) || true) && (f_10526_3866_3882(fillin)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(10526, 3866, 3921)&&f_10526_3894_3921_M(!f_10526_3895_3911(fillin).HasErrors)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10526,3862,4148);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,3971,4023);

f_10526_3971_4022(f_10526_3984_4014(f_10526_3984_4000(fillin))is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,4049,4125);

f_10526_4049_4124(f_10526_4049_4074(                        stringBuilder, ','), f_10526_4082_4123(f_10526_4082_4112(f_10526_4082_4098(fillin))));
DynAbs.Tracing.TraceSender.TraceExitCondition(10526,3862,4148);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,4170,4445) || true) && (f_10526_4174_4187(fillin)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(10526, 4174, 4223)&&f_10526_4199_4223_M(!f_10526_4200_4213(fillin).HasErrors)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10526,4170,4445);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,4273,4322);

f_10526_4273_4321(f_10526_4286_4313(f_10526_4286_4299(fillin))is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,4348,4422);

f_10526_4348_4421(f_10526_4348_4373(                        stringBuilder, ':'), f_10526_4381_4420(f_10526_4381_4408(f_10526_4381_4394(fillin))));
DynAbs.Tracing.TraceSender.TraceExitCondition(10526,4170,4445);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,4467,4493);

f_10526_4467_4492(                    stringBuilder, '}');
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,4515,4540);

var 
value = f_10526_4527_4539(fillin)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,4562,4755) || true) && (f_10526_4566_4586_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10526_4566_4576(value), 10526, 4566, 4586)?.TypeKind)== TypeKind.Dynamic)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10526,4562,4755);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,4656,4732);

value = f_10526_4664_4731(this, value, f_10526_4690_4713(_compilation), @checked: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10526,4562,4755);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,4779,4802);

f_10526_4779_4801(
                    expressions, value);
DynAbs.Tracing.TraceSender.TraceExitCondition(10526,3386,4852);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10526,1,1643);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10526,1,1643);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,4883,4947);

format = f_10526_4892_4946(_factory, f_10526_4915_4945(formatString));
DynAbs.Tracing.TraceSender.TraceExitMethod(10526,2726,4958);

Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
f_10526_3004_3037()
{
var return_v = PooledStringBuilder.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 3004, 3037);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10526_3121_3169(int
capacity)
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 3121, 3169);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10526_3297_3307(Microsoft.CodeAnalysis.CSharp.BoundInterpolatedString
this_param)
{
var return_v = this_param.Parts;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 3297, 3307);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10526_3483_3501(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 3483, 3501);
return return_v;
}


int
f_10526_3446_3510(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 3446, 3510);
return 0;
}


Microsoft.CodeAnalysis.ConstantValue
f_10526_3611_3629(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 3611, 3629);
return return_v;
}


string?
f_10526_3611_3641(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.StringValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 3611, 3641);
return return_v;
}


System.Text.StringBuilder
f_10526_3590_3642(System.Text.StringBuilder
this_param,string?
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 3590, 3642);
return return_v;
}


System.Text.StringBuilder
f_10526_3785_3810(System.Text.StringBuilder
this_param,char
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 3785, 3810);
return return_v;
}


System.Text.StringBuilder
f_10526_3785_3839(System.Text.StringBuilder
this_param,int
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 3785, 3839);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10526_3866_3882(Microsoft.CodeAnalysis.CSharp.BoundStringInsert
this_param)
{
var return_v = this_param.Alignment ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 3866, 3882);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10526_3895_3911(Microsoft.CodeAnalysis.CSharp.BoundStringInsert
this_param)
{
var return_v = this_param.Alignment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 3895, 3911);
return return_v;
}


bool
f_10526_3894_3921_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 3894, 3921);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10526_3984_4000(Microsoft.CodeAnalysis.CSharp.BoundStringInsert
this_param)
{
var return_v = this_param.Alignment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 3984, 4000);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10526_3984_4014(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 3984, 4014);
return return_v;
}


int
f_10526_3971_4022(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 3971, 4022);
return 0;
}


System.Text.StringBuilder
f_10526_4049_4074(System.Text.StringBuilder
this_param,char
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 4049, 4074);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10526_4082_4098(Microsoft.CodeAnalysis.CSharp.BoundStringInsert
this_param)
{
var return_v = this_param.Alignment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 4082, 4098);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10526_4082_4112(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 4082, 4112);
return return_v;
}


long
f_10526_4082_4123(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.Int64Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 4082, 4123);
return return_v;
}


System.Text.StringBuilder
f_10526_4049_4124(System.Text.StringBuilder
this_param,long
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 4049, 4124);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral?
f_10526_4174_4187(Microsoft.CodeAnalysis.CSharp.BoundStringInsert
this_param)
{
var return_v = this_param.Format ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 4174, 4187);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10526_4200_4213(Microsoft.CodeAnalysis.CSharp.BoundStringInsert
this_param)
{
var return_v = this_param.Format;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 4200, 4213);
return return_v;
}


bool
f_10526_4199_4223_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 4199, 4223);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10526_4286_4299(Microsoft.CodeAnalysis.CSharp.BoundStringInsert
this_param)
{
var return_v = this_param.Format;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 4286, 4299);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10526_4286_4313(Microsoft.CodeAnalysis.CSharp.BoundLiteral
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 4286, 4313);
return return_v;
}


int
f_10526_4273_4321(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 4273, 4321);
return 0;
}


System.Text.StringBuilder
f_10526_4348_4373(System.Text.StringBuilder
this_param,char
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 4348, 4373);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10526_4381_4394(Microsoft.CodeAnalysis.CSharp.BoundStringInsert
this_param)
{
var return_v = this_param.Format;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 4381, 4394);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10526_4381_4408(Microsoft.CodeAnalysis.CSharp.BoundLiteral
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 4381, 4408);
return return_v;
}


string?
f_10526_4381_4420(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.StringValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 4381, 4420);
return return_v;
}


System.Text.StringBuilder
f_10526_4348_4421(System.Text.StringBuilder
this_param,string?
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 4348, 4421);
return return_v;
}


System.Text.StringBuilder
f_10526_4467_4492(System.Text.StringBuilder
this_param,char
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 4467, 4492);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10526_4527_4539(Microsoft.CodeAnalysis.CSharp.BoundStringInsert
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 4527, 4539);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10526_4566_4576(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 4566, 4576);
return return_v;
}


Microsoft.CodeAnalysis.TypeKind?
f_10526_4566_4586_M(Microsoft.CodeAnalysis.TypeKind?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 4566, 4586);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10526_4690_4713(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ObjectType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 4690, 4713);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10526_4664_4731(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( rewrittenOperand, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 4664, 4731);
return return_v;
}


int
f_10526_4779_4801(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 4779, 4801);
return 0;
}


string
f_10526_4915_4945(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
this_param)
{
var return_v = this_param.ToStringAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 4915, 4945);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10526_4892_4946(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,string
stringValue)
{
var return_v = this_param.StringLiteral( stringValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 4892, 4946);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10526,2726,4958);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10526,2726,4958);
}
		}

public override BoundNode VisitInterpolatedString(BoundInterpolatedString node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10526,4970,8825);
Microsoft.CodeAnalysis.CSharp.BoundExpression format = default(Microsoft.CodeAnalysis.CSharp.BoundExpression);
Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression> expressions = default(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,5074,5144);

f_10526_5074_5143(f_10526_5087_5096(node)is { SpecialType: SpecialType.System_String });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,5208,5232);

BoundExpression? 
result
=default(BoundExpression?);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,5248,8477) || true) && (f_10526_5252_5287(this, node))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10526,5248,8477);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,5764,5795);

int 
length = node.Parts.Length
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,5813,5957) || true) && (length == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10526,5813,5957);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,5904,5938);

return f_10526_5911_5937(_factory, "");
DynAbs.Tracing.TraceSender.TraceExitCondition(10526,5813,5957);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,5977,5991);

result = null;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,6018,6023);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,6009,6916) || true) && (i < length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,6037,6040)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(10526,6009,6916))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10526,6009,6916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,6082,6107);

var 
part = f_10526_6093_6103(node)[i]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,6129,6709) || true) && (part is BoundStringInsert fillin)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10526,6129,6709);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,6284,6304);

part = f_10526_6291_6303(fillin);
DynAbs.Tracing.TraceSender.TraceExitCondition(10526,6129,6709);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10526,6129,6709);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,6463,6544);

f_10526_6463_6543(part is BoundLiteral &&(DynAbs.Tracing.TraceSender.Expression_True(10526, 6476, 6542)&&f_10526_6500_6518(part)is { StringValue: { } }));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,6570,6686);

part = f_10526_6577_6685(_factory, f_10526_6600_6684(f_10526_6653_6683(f_10526_6653_6671(part))));
DynAbs.Tracing.TraceSender.TraceExitCondition(10526,6129,6709);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,6733,6897);

result = (DynAbs.Tracing.TraceSender.Conditional_F1(10526, 6742, 6756)||((result == null &&DynAbs.Tracing.TraceSender.Conditional_F2(10526, 6784, 6788))||DynAbs.Tracing.TraceSender.Conditional_F3(10526, 6816, 6896)))?                        part :f_10526_6816_6896(                        _factory, BinaryOperatorKind.StringConcatenation, f_10526_6872_6881(node), result, part);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10526,1,908);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10526,1,908);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,6936,7076) || true) && (length == 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10526,6936,7076);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,6993,7057);

result = f_10526_7002_7056(_factory, result!, f_10526_7029_7055(_factory, ""));
DynAbs.Tracing.TraceSender.TraceExitCondition(10526,6936,7076);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10526,5248,8477);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10526,5248,8477);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,7574,7684);

f_10526_7574_7683(this, node, out format, out expressions);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,8118,8148);

f_10526_8118_8147(
                // The normal pattern for lowering is to lower subtrees before the enclosing tree. However we cannot lower
                // the arguments first in this situation because we do not know what conversions will be
                // produced for the arguments until after we've done overload resolution. So we produce the invocation
                // and then lower it along with its arguments.
                expressions, 0, format);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,8166,8193);

var 
stringType = f_10526_8183_8192(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,8211,8462);

result = f_10526_8220_8461(_factory, stringType, "Format", f_10526_8262_8294(expressions), allowUnexpandedForm: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10526,5248,8477);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,8493,8521);

f_10526_8493_8520(result is { });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,8535,8786) || true) && (f_10526_8539_8559_M(!result.HasAnyErrors))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10526,8535,8786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,8593,8626);

result = f_10526_8602_8625(this, result);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,8720,8771);

result = f_10526_8729_8770(this, result, f_10526_8760_8769(node));
DynAbs.Tracing.TraceSender.TraceExitCondition(10526,8535,8786);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10526,8800,8814);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10526,4970,8825);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10526_5087_5096(Microsoft.CodeAnalysis.CSharp.BoundInterpolatedString
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 5087, 5096);
return return_v;
}


int
f_10526_5074_5143(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 5074, 5143);
return 0;
}


bool
f_10526_5252_5287(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundInterpolatedString
node)
{
var return_v = this_param.CanLowerToStringConcatenation( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 5252, 5287);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10526_5911_5937(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,string
stringValue)
{
var return_v = this_param.StringLiteral( stringValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 5911, 5937);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10526_6093_6103(Microsoft.CodeAnalysis.CSharp.BoundInterpolatedString
this_param)
{
var return_v = this_param.Parts;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 6093, 6103);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10526_6291_6303(Microsoft.CodeAnalysis.CSharp.BoundStringInsert
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 6291, 6303);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10526_6500_6518(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 6500, 6518);
return return_v;
}


int
f_10526_6463_6543(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 6463, 6543);
return 0;
}


Microsoft.CodeAnalysis.ConstantValue
f_10526_6653_6671(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 6653, 6671);
return return_v;
}


string
f_10526_6653_6683(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.StringValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 6653, 6683);
return return_v;
}


string
f_10526_6600_6684(string
s)
{
var return_v = ConstantValueUtils.UnescapeInterpolatedStringLiteral( s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 6600, 6684);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10526_6577_6685(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,string
stringValue)
{
var return_v = this_param.StringLiteral( stringValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 6577, 6685);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10526_6872_6881(Microsoft.CodeAnalysis.CSharp.BoundInterpolatedString
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 6872, 6881);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10526_6816_6896(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.Binary( kind, type, left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 6816, 6896);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10526_7029_7055(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,string
stringValue)
{
var return_v = this_param.StringLiteral( stringValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 7029, 7055);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10526_7002_7056(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundLiteral
right)
{
var return_v = this_param.Coalesce( left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 7002, 7056);
return return_v;
}


int
f_10526_7574_7683(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundInterpolatedString
node,out Microsoft.CodeAnalysis.CSharp.BoundExpression
format,out Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
expressions)
{
this_param.MakeInterpolatedStringFormat( node, out format, out expressions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 7574, 7683);
return 0;
}


int
f_10526_8118_8147(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,int
index,Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
this_param.Insert( index, item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 8118, 8147);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10526_8183_8192(Microsoft.CodeAnalysis.CSharp.BoundInterpolatedString
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 8183, 8192);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10526_8262_8294(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 8262, 8294);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10526_8220_8461(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
receiver,string
name,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
args,bool
allowUnexpandedForm)
{
var return_v = this_param.StaticCall( receiver, name, args, allowUnexpandedForm: allowUnexpandedForm);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 8220, 8461);
return return_v;
}


int
f_10526_8493_8520(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 8493, 8520);
return 0;
}


bool
f_10526_8539_8559_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 8539, 8559);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10526_8602_8625(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 8602, 8625);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10526_8760_8769(Microsoft.CodeAnalysis.CSharp.BoundInterpolatedString
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10526, 8760, 8769);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10526_8729_8770(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType)
{
var return_v = this_param.MakeImplicitConversion( rewrittenOperand, rewrittenType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10526, 8729, 8770);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10526,4970,8825);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10526,4970,8825);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
