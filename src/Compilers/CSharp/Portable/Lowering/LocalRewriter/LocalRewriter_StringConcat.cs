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
private BoundExpression RewriteStringConcatenation(SyntaxNode syntax, BinaryOperatorKind operatorKind, BoundExpression loweredLeft, BoundExpression loweredRight, TypeSymbol type)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10525,1649,5801);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,1852,2107);

f_10525_1852_2106(operatorKind == BinaryOperatorKind.StringConcatenation ||(DynAbs.Tracing.TraceSender.Expression_False(10525, 1883, 2021)||                operatorKind == BinaryOperatorKind.StringAndObjectConcatenation )||(DynAbs.Tracing.TraceSender.Expression_False(10525, 1883, 2105)||                operatorKind == BinaryOperatorKind.ObjectAndStringConcatenation));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,2123,2295) || true) && (_inExpressionLambda)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,2123,2295);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,2180,2280);

return f_10525_2187_2279(this, syntax, operatorKind, loweredLeft, loweredRight, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,2123,2295);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,2390,2451);

loweredLeft = f_10525_2404_2450(this, syntax, loweredLeft);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,2465,2528);

loweredRight = f_10525_2480_2527(this, syntax, loweredRight);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,2544,2698);

f_10525_2544_2697(f_10525_2557_2573(loweredLeft)is { } &&(DynAbs.Tracing.TraceSender.Expression_True(10525, 2557, 2651)&&(f_10525_2585_2616(f_10525_2585_2601(loweredLeft))||(DynAbs.Tracing.TraceSender.Expression_False(10525, 2585, 2650)||f_10525_2620_2650(f_10525_2620_2636(loweredLeft)))) )||(DynAbs.Tracing.TraceSender.Expression_False(10525, 2557, 2696)||f_10525_2655_2688_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10525_2655_2680(loweredLeft), 10525, 2655, 2688)?.IsNull)== true));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,2712,2870);

f_10525_2712_2869(f_10525_2725_2742(loweredRight)is { } &&(DynAbs.Tracing.TraceSender.Expression_True(10525, 2725, 2822)&&(f_10525_2754_2786(f_10525_2754_2771(loweredRight))||(DynAbs.Tracing.TraceSender.Expression_False(10525, 2754, 2821)||f_10525_2790_2821(f_10525_2790_2807(loweredRight)))) )||(DynAbs.Tracing.TraceSender.Expression_False(10525, 2725, 2868)||f_10525_2826_2860_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10525_2826_2852(loweredRight), 10525, 2826, 2860)?.IsNull)== true));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,2940,3013);

var 
folded = f_10525_2953_3012(this, syntax, loweredLeft, loweredRight)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,3027,3108) || true) && (folded != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,3027,3108);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,3079,3093);

return folded;
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,3027,3108);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,3221,3311);

ArrayBuilder<BoundExpression> 
leftFlattened = f_10525_3267_3310()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,3325,3416);

ArrayBuilder<BoundExpression> 
rightFlattened = f_10525_3372_3415()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,3432,3477);

f_10525_3432_3476(this, loweredLeft, leftFlattened);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,3491,3538);

f_10525_3491_3537(this, loweredRight, rightFlattened);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,3554,3911) || true) && (f_10525_3558_3577(leftFlattened)&&(DynAbs.Tracing.TraceSender.Expression_True(10525, 3558, 3601)&&f_10525_3581_3601(rightFlattened)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,3554,3911);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,3635,3723);

folded = f_10525_3644_3722(this, syntax, f_10525_3677_3697(leftFlattened), f_10525_3699_3721(rightFlattened));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,3741,3896) || true) && (folded != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,3741,3896);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,3801,3828);

rightFlattened[0] = folded;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,3850,3877);

f_10525_3850_3876(                    leftFlattened);
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,3741,3896);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,3554,3911);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,3927,3966);

f_10525_3927_3965(
            leftFlattened, rightFlattened);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,3980,4002);

f_10525_3980_4001(            rightFlattened);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,4018,4041);

BoundExpression 
result
=default(BoundExpression);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,4057,5725);

switch (f_10525_4065_4084(leftFlattened))
            {

case 0:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,4057,5725);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,4147,4193);

result = f_10525_4156_4192(_factory, string.Empty);
DynAbs.Tracing.TraceSender.TraceBreak(10525,4215,4221);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,4057,5725);

case 1:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,4057,5725);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,4452,4478);

result = f_10525_4461_4477(leftFlattened, 0);
DynAbs.Tracing.TraceSender.TraceBreak(10525,4500,4506);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,4057,5725);

case 2:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,4057,5725);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,4555,4583);

var 
left = f_10525_4566_4582(leftFlattened, 0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,4605,4634);

var 
right = f_10525_4617_4633(leftFlattened, 1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,4656,4721);

result = f_10525_4665_4720(this, syntax, left, right);
DynAbs.Tracing.TraceSender.TraceBreak(10525,4743,4749);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,4057,5725);

case 3:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,4057,5725);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,4825,4854);

var 
first = f_10525_4837_4853(leftFlattened, 0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,4880,4910);

var 
second = f_10525_4893_4909(leftFlattened, 1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,4936,4965);

var 
third = f_10525_4948_4964(leftFlattened, 2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,4991,5067);

result = f_10525_5000_5066(this, syntax, first, second, third);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(10525,5112,5118);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,4057,5725);

case 4:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,4057,5725);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,5194,5223);

var 
first = f_10525_5206_5222(leftFlattened, 0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,5249,5279);

var 
second = f_10525_5262_5278(leftFlattened, 1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,5305,5334);

var 
third = f_10525_5317_5333(leftFlattened, 2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,5360,5390);

var 
fourth = f_10525_5373_5389(leftFlattened, 3)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,5416,5499);

result = f_10525_5425_5498(this, syntax, first, second, third, fourth);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(10525,5544,5550);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,4057,5725);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,4057,5725);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,5600,5682);

result = f_10525_5609_5681(this, syntax, f_10525_5653_5680(leftFlattened));
DynAbs.Tracing.TraceSender.TraceBreak(10525,5704,5710);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,4057,5725);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,5741,5762);

f_10525_5741_5761(
            leftFlattened);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,5776,5790);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10525,1649,5801);

int
f_10525_1852_2106(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 1852, 2106);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_2187_2279(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.RewriteStringConcatInExpressionLambda( syntax, operatorKind, loweredLeft, loweredRight, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 2187, 2279);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_2404_2450(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expr)
{
var return_v = this_param.ConvertConcatExprToString( syntax, expr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 2404, 2450);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_2480_2527(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expr)
{
var return_v = this_param.ConvertConcatExprToString( syntax, expr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 2480, 2527);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10525_2557_2573(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 2557, 2573);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_2585_2601(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 2585, 2601);
return return_v;
}


bool
f_10525_2585_2616(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsStringType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 2585, 2616);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_2620_2636(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 2620, 2636);
return return_v;
}


bool
f_10525_2620_2650(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsErrorType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 2620, 2650);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10525_2655_2680(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 2655, 2680);
return return_v;
}


bool?
f_10525_2655_2688_M(bool?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 2655, 2688);
return return_v;
}


int
f_10525_2544_2697(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 2544, 2697);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10525_2725_2742(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 2725, 2742);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_2754_2771(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 2754, 2771);
return return_v;
}


bool
f_10525_2754_2786(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsStringType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 2754, 2786);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_2790_2807(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 2790, 2807);
return return_v;
}


bool
f_10525_2790_2821(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsErrorType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 2790, 2821);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10525_2826_2852(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 2826, 2852);
return return_v;
}


bool?
f_10525_2826_2860_M(bool?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 2826, 2860);
return return_v;
}


int
f_10525_2712_2869(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 2712, 2869);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10525_2953_3012(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight)
{
var return_v = this_param.TryFoldTwoConcatOperands( syntax, loweredLeft, loweredRight);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 2953, 3012);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10525_3267_3310()
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 3267, 3310);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10525_3372_3415()
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 3372, 3415);
return return_v;
}


int
f_10525_3432_3476(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
lowered,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
flattened)
{
this_param.FlattenConcatArg( lowered, flattened);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 3432, 3476);
return 0;
}


int
f_10525_3491_3537(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
lowered,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
flattened)
{
this_param.FlattenConcatArg( lowered, flattened);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 3491, 3537);
return 0;
}


bool
f_10525_3558_3577(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.Any();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 3558, 3577);
return return_v;
}


bool
f_10525_3581_3601(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.Any();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 3581, 3601);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_3677_3697(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.Last();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 3677, 3697);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_3699_3721(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.First();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 3699, 3721);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10525_3644_3722(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight)
{
var return_v = this_param.TryFoldTwoConcatOperands( syntax, loweredLeft, loweredRight);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 3644, 3722);
return return_v;
}


int
f_10525_3850_3876(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
this_param.RemoveLast();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 3850, 3876);
return 0;
}


int
f_10525_3927_3965(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
items)
{
this_param.AddRange( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 3927, 3965);
return 0;
}


int
f_10525_3980_4001(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 3980, 4001);
return 0;
}


int
f_10525_4065_4084(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 4065, 4084);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10525_4156_4192(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,string
stringValue)
{
var return_v = this_param.StringLiteral( stringValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 4156, 4192);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_4461_4477(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 4461, 4477);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_4566_4582(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 4566, 4582);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_4617_4633(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 4617, 4633);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_4665_4720(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight)
{
var return_v = this_param.RewriteStringConcatenationTwoExprs( syntax, loweredLeft, loweredRight);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 4665, 4720);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_4837_4853(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 4837, 4853);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_4893_4909(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 4893, 4909);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_4948_4964(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 4948, 4964);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_5000_5066(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredFirst,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredSecond,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredThird)
{
var return_v = this_param.RewriteStringConcatenationThreeExprs( syntax, loweredFirst, loweredSecond, loweredThird);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 5000, 5066);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_5206_5222(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 5206, 5222);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_5262_5278(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 5262, 5278);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_5317_5333(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 5317, 5333);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_5373_5389(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 5373, 5389);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_5425_5498(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredFirst,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredSecond,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredThird,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredFourth)
{
var return_v = this_param.RewriteStringConcatenationFourExprs( syntax, loweredFirst, loweredSecond, loweredThird, loweredFourth);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 5425, 5498);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10525_5653_5680(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 5653, 5680);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_5609_5681(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
loweredArgs)
{
var return_v = this_param.RewriteStringConcatenationManyExprs( syntax, loweredArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 5609, 5681);
return return_v;
}


int
f_10525_5741_5761(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 5741, 5761);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10525,1649,5801);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10525,1649,5801);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void FlattenConcatArg(BoundExpression lowered, ArrayBuilder<BoundExpression> flattened)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10525,6121,6550);
System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression> arguments = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,6241,6539) || true) && (f_10525_6245_6299(this, lowered, out arguments))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,6241,6539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,6333,6363);

f_10525_6333_6362(                flattened, arguments);
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,6241,6539);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,6241,6539);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,6501,6524);

f_10525_6501_6523(                // fallback - if nothing above worked, leave arg as-is
                flattened, lowered);
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,6241,6539);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10525,6121,6550);

bool
f_10525_6245_6299(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
lowered,out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments)
{
var return_v = this_param.TryExtractStringConcatArgs( lowered, out arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 6245, 6299);
return return_v;
}


int
f_10525_6333_6362(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
items)
{
this_param.AddRange( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 6333, 6362);
return 0;
}


int
f_10525_6501_6523(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 6501, 6523);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10525,6121,6550);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10525,6121,6550);
}
		}

private bool TryExtractStringConcatArgs(BoundExpression lowered, out ImmutableArray<BoundExpression> arguments)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10525,6875,9824);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,7011,9750);

switch (f_10525_7019_7031(lowered))
            {

case BoundKind.Call:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,7011,9750);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,7107,7142);

var 
boundCall = (BoundCall)lowered
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,7164,7194);

var 
method = f_10525_7177_7193(boundCall)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,7216,8659) || true) && (f_10525_7220_7235(method)&&(DynAbs.Tracing.TraceSender.Expression_True(10525, 7220, 7301)&&f_10525_7239_7272(f_10525_7239_7260(method))== SpecialType.System_String))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,7216,8659);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,7351,7922) || true) && ((object)method == (object)f_10525_7381_7463(_compilation, SpecialMember.System_String__ConcatStringString)||(DynAbs.Tracing.TraceSender.Expression_False(10525, 7355, 7610)||                            (object)method == (object)f_10525_7522_7610(_compilation, SpecialMember.System_String__ConcatStringStringString))||(DynAbs.Tracing.TraceSender.Expression_False(10525, 7355, 7763)||                            (object)method == (object)f_10525_7669_7763(_compilation, SpecialMember.System_String__ConcatStringStringStringString)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,7351,7922);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,7821,7853);

arguments = f_10525_7833_7852(boundCall);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,7883,7895);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,7351,7922);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,7950,8636) || true) && ((object)method == (object)f_10525_7980_8061(_compilation, SpecialMember.System_String__ConcatStringArray))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,7950,8636);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,8119,8175);

var 
args = f_10525_8130_8149(boundCall)[0] as BoundArrayCreation
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,8205,8609) || true) && (args != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,8205,8609);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,8287,8325);

var 
initializer = f_10525_8305_8324(args)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,8359,8578) || true) && (initializer != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,8359,8578);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,8456,8493);

arguments = f_10525_8468_8492(initializer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,8531,8543);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,8359,8578);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,8205,8609);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,7950,8636);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,7216,8659);
}
DynAbs.Tracing.TraceSender.TraceBreak(10525,8681,8687);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,7011,9750);

case BoundKind.NullCoalescingOperator:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,7011,9750);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,8767,8824);

var 
boundCoalesce = (BoundNullCoalescingOperator)lowered
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,8848,9707) || true) && (boundCoalesce.LeftConversion.IsIdentity)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,8848,9707);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,9317,9378);

var 
rightConstant = f_10525_9337_9377(f_10525_9337_9363(boundCoalesce))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,9404,9684) || true) && (rightConstant != null &&(DynAbs.Tracing.TraceSender.Expression_True(10525, 9408, 9455)&&f_10525_9433_9455(rightConstant))&&(DynAbs.Tracing.TraceSender.Expression_True(10525, 9408, 9496)&&f_10525_9459_9491(f_10525_9459_9484(rightConstant))== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,9404,9684);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,9554,9615);

arguments = f_10525_9566_9614(f_10525_9588_9613(boundCoalesce));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,9645,9657);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,9404,9684);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,8848,9707);
}
DynAbs.Tracing.TraceSender.TraceBreak(10525,9729,9735);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,7011,9750);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,9766,9786);

arguments = default;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,9800,9813);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(10525,6875,9824);

Microsoft.CodeAnalysis.CSharp.BoundKind
f_10525_7019_7031(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 7019, 7031);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10525_7177_7193(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 7177, 7193);
return return_v;
}


bool
f_10525_7220_7235(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.IsStatic ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 7220, 7235);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10525_7239_7260(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 7239, 7260);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10525_7239_7272(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 7239, 7272);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10525_7381_7463(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.GetSpecialTypeMember( specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 7381, 7463);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10525_7522_7610(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.GetSpecialTypeMember( specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 7522, 7610);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10525_7669_7763(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.GetSpecialTypeMember( specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 7669, 7763);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10525_7833_7852(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 7833, 7852);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10525_7980_8061(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.GetSpecialTypeMember( specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 7980, 8061);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10525_8130_8149(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 8130, 8149);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
f_10525_8305_8324(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
this_param)
{
var return_v = this_param.InitializerOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 8305, 8324);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10525_8468_8492(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
this_param)
{
var return_v = this_param.Initializers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 8468, 8492);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_9337_9363(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
this_param)
{
var return_v = this_param.RightOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 9337, 9363);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10525_9337_9377(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 9337, 9377);
return return_v;
}


bool
f_10525_9433_9455(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.IsString ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 9433, 9455);
return return_v;
}


string
f_10525_9459_9484(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.StringValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 9459, 9484);
return return_v;
}


int
f_10525_9459_9491(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 9459, 9491);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_9588_9613(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
this_param)
{
var return_v = this_param.LeftOperand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 9588, 9613);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10525_9566_9614(Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 9566, 9614);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10525,6875,9824);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10525,6875,9824);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression? TryFoldTwoConcatOperands(SyntaxNode syntax, BoundExpression loweredLeft, BoundExpression loweredRight)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10525,9990,11329);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,10192,10234);

var 
leftConst = f_10525_10208_10233(loweredLeft)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,10248,10292);

var 
rightConst = f_10525_10265_10291(loweredRight)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,10308,10738) || true) && (leftConst != null &&(DynAbs.Tracing.TraceSender.Expression_True(10525, 10312, 10351)&&rightConst != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,10308,10738);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,10500,10576);

ConstantValue? 
concatenated = f_10525_10530_10575(leftConst, rightConst)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,10594,10723) || true) && (concatenated != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,10594,10723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,10660,10704);

return f_10525_10667_10703(_factory, concatenated);
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,10594,10723);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,10308,10738);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,10795,11290) || true) && (f_10525_10799_10839(loweredLeft))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,10795,11290);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,10873,11017) || true) && (f_10525_10877_10918(loweredRight))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,10873,11017);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,10960,10998);

return f_10525_10967_10997(_factory, string.Empty);
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,10873,11017);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,11037,11100);

return f_10525_11044_11099(this, syntax, loweredRight);
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,10795,11290);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,10795,11290);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,11134,11290) || true) && (f_10525_11138_11179(loweredRight))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,11134,11290);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,11213,11275);

return f_10525_11220_11274(this, syntax, loweredLeft);
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,11134,11290);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,10795,11290);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,11306,11318);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(10525,9990,11329);

Microsoft.CodeAnalysis.ConstantValue?
f_10525_10208_10233(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 10208, 10233);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10525_10265_10291(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 10265, 10291);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10525_10530_10575(Microsoft.CodeAnalysis.ConstantValue
leftConst,Microsoft.CodeAnalysis.ConstantValue
rightConst)
{
var return_v = TryFoldTwoConcatConsts( leftConst, rightConst);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 10530, 10575);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10525_10667_10703(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.ConstantValue
stringConst)
{
var return_v = this_param.StringLiteral( stringConst);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 10667, 10703);
return return_v;
}


bool
f_10525_10799_10839(Microsoft.CodeAnalysis.CSharp.BoundExpression
operand)
{
var return_v = IsNullOrEmptyStringConstant( operand);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 10799, 10839);
return return_v;
}


bool
f_10525_10877_10918(Microsoft.CodeAnalysis.CSharp.BoundExpression
operand)
{
var return_v = IsNullOrEmptyStringConstant( operand);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 10877, 10918);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10525_10967_10997(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,string
value)
{
var return_v = this_param.Literal( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 10967, 10997);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_11044_11099(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredOperand)
{
var return_v = this_param.RewriteStringConcatenationOneExpr( syntax, loweredOperand);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 11044, 11099);
return return_v;
}


bool
f_10525_11138_11179(Microsoft.CodeAnalysis.CSharp.BoundExpression
operand)
{
var return_v = IsNullOrEmptyStringConstant( operand);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 11138, 11179);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_11220_11274(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredOperand)
{
var return_v = this_param.RewriteStringConcatenationOneExpr( syntax, loweredOperand);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 11220, 11274);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10525,9990,11329);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10525,9990,11329);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsNullOrEmptyStringConstant(BoundExpression operand)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10525,11341,11596);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,11438,11585);

return (f_10525_11446_11467(operand)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(10525, 11446, 11534)&&f_10525_11479_11534(f_10525_11500_11533(f_10525_11500_11521(operand))))) ||(DynAbs.Tracing.TraceSender.Expression_False(10525, 11445, 11584)||f_10525_11560_11584(                    operand));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10525,11341,11596);

Microsoft.CodeAnalysis.ConstantValue?
f_10525_11446_11467(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 11446, 11467);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10525_11500_11521(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 11500, 11521);
return return_v;
}


string?
f_10525_11500_11533(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.StringValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 11500, 11533);
return return_v;
}


bool
f_10525_11479_11534(string?
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 11479, 11534);
return return_v;
}


bool
f_10525_11560_11584(Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = node.IsDefaultValue();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 11560, 11584);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10525,11341,11596);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10525,11341,11596);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static ConstantValue? TryFoldTwoConcatConsts(ConstantValue leftConst, ConstantValue rightConst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10525,11863,12880);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,11991,12027);

var 
leftVal = f_10525_12005_12026(leftConst)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,12041,12079);

var 
rightVal = f_10525_12056_12078(rightConst)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,12095,12382) || true) && (f_10525_12099_12124_M(!leftConst.IsDefaultValue)&&(DynAbs.Tracing.TraceSender.Expression_True(10525, 12099, 12154)&&f_10525_12128_12154_M(!rightConst.IsDefaultValue)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,12095,12382);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,12188,12236);

f_10525_12188_12235(leftVal is { } &&(DynAbs.Tracing.TraceSender.Expression_True(10525, 12201, 12234)&&rightVal is { }));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,12254,12367) || true) && (f_10525_12258_12272(leftVal)+ f_10525_12275_12290(rightVal)< 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,12254,12367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,12336,12348);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,12254,12367);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,12095,12382);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,12821,12869);

return f_10525_12828_12868(leftVal + rightVal);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10525,11863,12880);

string?
f_10525_12005_12026(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.StringValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 12005, 12026);
return return_v;
}


string?
f_10525_12056_12078(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.StringValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 12056, 12078);
return return_v;
}


bool
f_10525_12099_12124_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 12099, 12124);
return return_v;
}


bool
f_10525_12128_12154_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 12128, 12154);
return return_v;
}


int
f_10525_12188_12235(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 12188, 12235);
return 0;
}


int
f_10525_12258_12272(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 12258, 12272);
return return_v;
}


int
f_10525_12275_12290(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 12275, 12290);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10525_12828_12868(string
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 12828, 12868);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10525,11863,12880);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10525,11863,12880);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression RewriteStringConcatenationOneExpr(SyntaxNode syntax, BoundExpression loweredOperand)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10525,13040,13650);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,13386,13639) || true) && (f_10525_13390_13439(this, loweredOperand, out _))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,13386,13639);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,13473,13495);

return loweredOperand;
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,13386,13639);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,13386,13639);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,13561,13624);

return f_10525_13568_13623(_factory, loweredOperand, f_10525_13602_13622(_factory, ""));
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,13386,13639);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10525,13040,13650);

bool
f_10525_13390_13439(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
lowered,out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments)
{
var return_v = this_param.TryExtractStringConcatArgs( lowered, out arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 13390, 13439);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10525_13602_13622(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,string
value)
{
var return_v = this_param.Literal( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 13602, 13622);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_13568_13623(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundLiteral
right)
{
var return_v = this_param.Coalesce( left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 13568, 13623);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10525,13040,13650);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10525,13040,13650);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression RewriteStringConcatenationTwoExprs(SyntaxNode syntax, BoundExpression loweredLeft, BoundExpression loweredRight)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10525,13662,14324);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,13823,13924);

f_10525_13823_13923(f_10525_13836_13860(loweredLeft)||(DynAbs.Tracing.TraceSender.Expression_False(10525, 13836, 13922)||f_10525_13864_13880(loweredLeft)is { } &&(DynAbs.Tracing.TraceSender.Expression_True(10525, 13864, 13922)&&f_10525_13891_13922(f_10525_13891_13907(loweredLeft)))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,13938,14042);

f_10525_13938_14041(f_10525_13951_13976(loweredRight)||(DynAbs.Tracing.TraceSender.Expression_False(10525, 13951, 14040)||f_10525_13980_13997(loweredRight)is { } &&(DynAbs.Tracing.TraceSender.Expression_True(10525, 13980, 14040)&&f_10525_14008_14040(f_10525_14008_14025(loweredRight)))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,14058,14155);

var 
method = f_10525_14071_14154(this, syntax, SpecialMember.System_String__ConcatStringString)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,14169,14206);

f_10525_14169_14205((object)method != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,14222,14313);

return f_10525_14229_14312(syntax, receiverOpt: null, method, loweredLeft, loweredRight);
DynAbs.Tracing.TraceSender.TraceExitMethod(10525,13662,14324);

bool
f_10525_13836_13860(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.HasAnyErrors ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 13836, 13860);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10525_13864_13880(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 13864, 13880);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_13891_13907(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 13891, 13907);
return return_v;
}


bool
f_10525_13891_13922(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsStringType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 13891, 13922);
return return_v;
}


int
f_10525_13823_13923(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 13823, 13923);
return 0;
}


bool
f_10525_13951_13976(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.HasAnyErrors ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 13951, 13976);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10525_13980_13997(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 13980, 13997);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_14008_14025(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 14008, 14025);
return return_v;
}


bool
f_10525_14008_14040(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsStringType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 14008, 14040);
return return_v;
}


int
f_10525_13938_14041(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 13938, 14041);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10525_14071_14154(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.UnsafeGetSpecialTypeMethod( syntax, specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 14071, 14154);
return return_v;
}


int
f_10525_14169_14205(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 14169, 14205);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10525_14229_14312(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg0,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg1)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt: receiverOpt, method, arg0, arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 14229, 14312);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10525,13662,14324);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10525,13662,14324);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression RewriteStringConcatenationThreeExprs(SyntaxNode syntax, BoundExpression loweredFirst, BoundExpression loweredSecond, BoundExpression loweredThird)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10525,14336,15201);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,14531,14635);

f_10525_14531_14634(f_10525_14544_14569(loweredFirst)||(DynAbs.Tracing.TraceSender.Expression_False(10525, 14544, 14633)||f_10525_14573_14590(loweredFirst)is { } &&(DynAbs.Tracing.TraceSender.Expression_True(10525, 14573, 14633)&&f_10525_14601_14633(f_10525_14601_14618(loweredFirst)))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,14649,14756);

f_10525_14649_14755(f_10525_14662_14688(loweredSecond)||(DynAbs.Tracing.TraceSender.Expression_False(10525, 14662, 14754)||f_10525_14692_14710(loweredSecond)is { } &&(DynAbs.Tracing.TraceSender.Expression_True(10525, 14692, 14754)&&f_10525_14721_14754(f_10525_14721_14739(loweredSecond)))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,14770,14874);

f_10525_14770_14873(f_10525_14783_14808(loweredThird)||(DynAbs.Tracing.TraceSender.Expression_False(10525, 14783, 14872)||f_10525_14812_14829(loweredThird)is { } &&(DynAbs.Tracing.TraceSender.Expression_True(10525, 14812, 14872)&&f_10525_14840_14872(f_10525_14840_14857(loweredThird)))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,14890,14993);

var 
method = f_10525_14903_14992(this, syntax, SpecialMember.System_String__ConcatStringStringString)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,15007,15044);

f_10525_15007_15043((object)method != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,15060,15190);

return f_10525_15067_15189(syntax, receiverOpt: null, method, f_10525_15124_15188(loweredFirst, loweredSecond, loweredThird));
DynAbs.Tracing.TraceSender.TraceExitMethod(10525,14336,15201);

bool
f_10525_14544_14569(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.HasAnyErrors ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 14544, 14569);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10525_14573_14590(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 14573, 14590);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_14601_14618(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 14601, 14618);
return return_v;
}


bool
f_10525_14601_14633(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsStringType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 14601, 14633);
return return_v;
}


int
f_10525_14531_14634(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 14531, 14634);
return 0;
}


bool
f_10525_14662_14688(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.HasAnyErrors ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 14662, 14688);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10525_14692_14710(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 14692, 14710);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_14721_14739(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 14721, 14739);
return return_v;
}


bool
f_10525_14721_14754(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsStringType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 14721, 14754);
return return_v;
}


int
f_10525_14649_14755(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 14649, 14755);
return 0;
}


bool
f_10525_14783_14808(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.HasAnyErrors ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 14783, 14808);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10525_14812_14829(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 14812, 14829);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_14840_14857(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 14840, 14857);
return return_v;
}


bool
f_10525_14840_14872(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsStringType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 14840, 14872);
return return_v;
}


int
f_10525_14770_14873(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 14770, 14873);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10525_14903_14992(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.UnsafeGetSpecialTypeMethod( syntax, specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 14903, 14992);
return return_v;
}


int
f_10525_15007_15043(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 15007, 15043);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10525_15124_15188(Microsoft.CodeAnalysis.CSharp.BoundExpression
item1,Microsoft.CodeAnalysis.CSharp.BoundExpression
item2,Microsoft.CodeAnalysis.CSharp.BoundExpression
item3)
{
var return_v = ImmutableArray.Create( item1, item2, item3);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 15124, 15188);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10525_15067_15189(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt: receiverOpt, method, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 15067, 15189);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10525,14336,15201);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10525,14336,15201);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression RewriteStringConcatenationFourExprs(SyntaxNode syntax, BoundExpression loweredFirst, BoundExpression loweredSecond, BoundExpression loweredThird, BoundExpression loweredFourth)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10525,15213,16250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,15438,15542);

f_10525_15438_15541(f_10525_15451_15476(loweredFirst)||(DynAbs.Tracing.TraceSender.Expression_False(10525, 15451, 15540)||f_10525_15480_15497(loweredFirst)is { } &&(DynAbs.Tracing.TraceSender.Expression_True(10525, 15480, 15540)&&f_10525_15508_15540(f_10525_15508_15525(loweredFirst)))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,15556,15663);

f_10525_15556_15662(f_10525_15569_15595(loweredSecond)||(DynAbs.Tracing.TraceSender.Expression_False(10525, 15569, 15661)||f_10525_15599_15617(loweredSecond)is { } &&(DynAbs.Tracing.TraceSender.Expression_True(10525, 15599, 15661)&&f_10525_15628_15661(f_10525_15628_15646(loweredSecond)))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,15677,15781);

f_10525_15677_15780(f_10525_15690_15715(loweredThird)||(DynAbs.Tracing.TraceSender.Expression_False(10525, 15690, 15779)||f_10525_15719_15736(loweredThird)is { } &&(DynAbs.Tracing.TraceSender.Expression_True(10525, 15719, 15779)&&f_10525_15747_15779(f_10525_15747_15764(loweredThird)))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,15795,15902);

f_10525_15795_15901(f_10525_15808_15834(loweredFourth)||(DynAbs.Tracing.TraceSender.Expression_False(10525, 15808, 15900)||f_10525_15838_15856(loweredFourth)is { } &&(DynAbs.Tracing.TraceSender.Expression_True(10525, 15838, 15900)&&f_10525_15867_15900(f_10525_15867_15885(loweredFourth)))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,15918,16027);

var 
method = f_10525_15931_16026(this, syntax, SpecialMember.System_String__ConcatStringStringStringString)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,16041,16078);

f_10525_16041_16077((object)method != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,16094,16239);

return f_10525_16101_16238(syntax, receiverOpt: null, method, f_10525_16158_16237(loweredFirst, loweredSecond, loweredThird, loweredFourth));
DynAbs.Tracing.TraceSender.TraceExitMethod(10525,15213,16250);

bool
f_10525_15451_15476(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.HasAnyErrors ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 15451, 15476);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10525_15480_15497(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 15480, 15497);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_15508_15525(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 15508, 15525);
return return_v;
}


bool
f_10525_15508_15540(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsStringType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 15508, 15540);
return return_v;
}


int
f_10525_15438_15541(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 15438, 15541);
return 0;
}


bool
f_10525_15569_15595(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.HasAnyErrors ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 15569, 15595);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10525_15599_15617(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 15599, 15617);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_15628_15646(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 15628, 15646);
return return_v;
}


bool
f_10525_15628_15661(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsStringType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 15628, 15661);
return return_v;
}


int
f_10525_15556_15662(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 15556, 15662);
return 0;
}


bool
f_10525_15690_15715(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.HasAnyErrors ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 15690, 15715);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10525_15719_15736(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 15719, 15736);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_15747_15764(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 15747, 15764);
return return_v;
}


bool
f_10525_15747_15779(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsStringType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 15747, 15779);
return return_v;
}


int
f_10525_15677_15780(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 15677, 15780);
return 0;
}


bool
f_10525_15808_15834(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.HasAnyErrors ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 15808, 15834);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10525_15838_15856(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 15838, 15856);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_15867_15885(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 15867, 15885);
return return_v;
}


bool
f_10525_15867_15900(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsStringType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 15867, 15900);
return return_v;
}


int
f_10525_15795_15901(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 15795, 15901);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10525_15931_16026(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.UnsafeGetSpecialTypeMethod( syntax, specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 15931, 16026);
return return_v;
}


int
f_10525_16041_16077(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 16041, 16077);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10525_16158_16237(Microsoft.CodeAnalysis.CSharp.BoundExpression
item1,Microsoft.CodeAnalysis.CSharp.BoundExpression
item2,Microsoft.CodeAnalysis.CSharp.BoundExpression
item3,Microsoft.CodeAnalysis.CSharp.BoundExpression
item4)
{
var return_v = ImmutableArray.Create( item1, item2, item3, item4);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 16158, 16237);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10525_16101_16238(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt: receiverOpt, method, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 16101, 16238);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10525,15213,16250);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10525,15213,16250);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression RewriteStringConcatenationManyExprs(SyntaxNode syntax, ImmutableArray<BoundExpression> loweredArgs)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10525,16262,16924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,16410,16447);

f_10525_16410_16446(loweredArgs.Length > 4);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,16461,16551);

f_10525_16461_16550(loweredArgs.All(a => a.HasErrors || a.Type is { } && a.Type.IsStringType()));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,16567,16663);

var 
method = f_10525_16580_16662(this, syntax, SpecialMember.System_String__ConcatStringArray)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,16677,16714);

f_10525_16677_16713((object)method != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,16730,16826);

var 
array = f_10525_16742_16825(_factory, f_10525_16764_16811(_factory, SpecialType.System_String), loweredArgs)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,16842,16913);

return f_10525_16849_16912(syntax, receiverOpt: null, method, array);
DynAbs.Tracing.TraceSender.TraceExitMethod(10525,16262,16924);

int
f_10525_16410_16446(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 16410, 16446);
return 0;
}


int
f_10525_16461_16550(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 16461, 16550);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10525_16580_16662(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.UnsafeGetSpecialTypeMethod( syntax, specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 16580, 16662);
return return_v;
}


int
f_10525_16677_16713(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 16677, 16713);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10525_16764_16811(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.SpecialType
st)
{
var return_v = this_param.SpecialType( st);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 16764, 16811);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_16742_16825(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
elementType,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
elements)
{
var return_v = this_param.ArrayOrEmpty( (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)elementType, elements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 16742, 16825);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10525_16849_16912(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg0)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt: receiverOpt, method, arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 16849, 16912);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10525,16262,16924);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10525,16262,16924);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression RewriteStringConcatInExpressionLambda(SyntaxNode syntax, BinaryOperatorKind operatorKind, BoundExpression loweredLeft, BoundExpression loweredRight, TypeSymbol type)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10525,17192,17915);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,17406,17620);

SpecialMember 
member = (DynAbs.Tracing.TraceSender.Conditional_F1(10525, 17429, 17485)||(((operatorKind == BinaryOperatorKind.StringConcatenation) &&DynAbs.Tracing.TraceSender.Conditional_F2(10525, 17505, 17552))||DynAbs.Tracing.TraceSender.Conditional_F3(10525, 17572, 17619)))?                SpecialMember.System_String__ConcatStringString :                SpecialMember.System_String__ConcatObjectObject
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,17636,17692);

var 
method = f_10525_17649_17691(this, syntax, member)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,17706,17743);

f_10525_17706_17742((object)method != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,17759,17904);

return f_10525_17766_17903(syntax, operatorKind, constantValueOpt: null, method, default(LookupResultKind), loweredLeft, loweredRight, type);
DynAbs.Tracing.TraceSender.TraceExitMethod(10525,17192,17915);

Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10525_17649_17691(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.UnsafeGetSpecialTypeMethod( syntax, specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 17649, 17691);
return return_v;
}


int
f_10525_17706_17742(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 17706, 17742);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10525_17766_17903(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
methodOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator( syntax, operatorKind, constantValueOpt: constantValueOpt, methodOpt, resultKind, left, right, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 17766, 17903);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10525,17192,17915);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10525,17192,17915);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression ConvertConcatExprToString(SyntaxNode syntax, BoundExpression expr)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10525,18170,24889);
Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator store = default(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,18428,18706) || true) && (f_10525_18432_18441(expr)== BoundKind.Conversion)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,18428,18706);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,18499,18544);

BoundConversion 
conv = (BoundConversion)expr
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,18562,18691) || true) && (f_10525_18566_18585(conv)== ConversionKind.Boxing)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,18562,18691);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,18652,18672);

expr = f_10525_18659_18671(conv);
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,18562,18691);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,18428,18706);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,18722,18753);

f_10525_18722_18752(f_10525_18735_18744(expr)is { });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,19060,19416) || true) && (expr is { ConstantValue: { } cv })
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,19060,19416);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,19131,19401) || true) && (f_10525_19135_19149(cv)== SpecialType.System_Char)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,19131,19401);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,19218,19273);

return f_10525_19225_19272(_factory, f_10525_19248_19271(f_10525_19248_19260(cv)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,19131,19401);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,19131,19401);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,19315,19401) || true) && (f_10525_19319_19328(cv))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,19315,19401);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,19370,19382);

return expr;
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,19315,19401);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,19131,19401);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,19060,19416);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,19489,19578) || true) && (f_10525_19493_19517(f_10525_19493_19502(expr)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,19489,19578);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,19551,19563);

return expr;
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,19489,19578);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,19754,19855);

var 
objectToStringMethod = f_10525_19781_19854(this, syntax, SpecialMember.System_Object__ToString)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,20040,20082);

MethodSymbol? 
structToStringMethod = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,20096,20738) || true) && (f_10525_20100_20121(f_10525_20100_20109(expr))&&(DynAbs.Tracing.TraceSender.Expression_True(10525, 20100, 20153)&&!f_10525_20126_20153(f_10525_20126_20135(expr))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,20096,20738);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,20187,20225);

var 
type = (NamedTypeSymbol)f_10525_20215_20224(expr)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,20243,20312);

var 
typeToStringMembers = f_10525_20269_20311(type, f_10525_20285_20310(objectToStringMethod))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,20330,20723);
foreach(var member in f_10525_20353_20372_I(typeToStringMembers) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,20330,20723);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,20414,20704) || true) && (member is MethodSymbol toStringMethod &&(DynAbs.Tracing.TraceSender.Expression_True(10525, 20418, 20561)&&f_10525_20484_20529(                        toStringMethod, type)== (object)objectToStringMethod))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,20414,20704);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,20611,20649);

structToStringMethod = toStringMethod;
DynAbs.Tracing.TraceSender.TraceBreak(10525,20675,20681);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,20414,20704);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,20330,20723);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10525,1,394);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10525,1,394);
}DynAbs.Tracing.TraceSender.TraceExitCondition(10525,20096,20738);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,21184,21428) || true) && (structToStringMethod != null &&(DynAbs.Tracing.TraceSender.Expression_True(10525, 21188, 21309)&&(f_10525_21221_21242(f_10525_21221_21230(expr))!= SpecialType.None &&(DynAbs.Tracing.TraceSender.Expression_True(10525, 21221, 21308)&&!f_10525_21267_21308(expr, _compilation)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,21184,21428);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,21343,21413);

return f_10525_21350_21412(expr.Syntax, expr, structToStringMethod);
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,21184,21428);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,22215,22466);

bool 
callWithoutCopy = f_10525_22238_22263(f_10525_22238_22247(expr))||(DynAbs.Tracing.TraceSender.Expression_False(10525, 22238, 22310)||f_10525_22284_22302(expr)!= null )||(DynAbs.Tracing.TraceSender.Expression_False(10525, 22238, 22393)||                (structToStringMethod == null &&(DynAbs.Tracing.TraceSender.Expression_True(10525, 22332, 22392)&&!f_10525_22365_22392(f_10525_22365_22374(expr)))) )||(DynAbs.Tracing.TraceSender.Expression_False(10525, 22238, 22465)||f_10525_22414_22457_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(structToStringMethod, 10525, 22414, 22457)?.IsEffectivelyReadOnly)== true)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,22577,22877) || true) && (f_10525_22581_22602(f_10525_22581_22590(expr)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,22577,22877);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,22636,22774) || true) && (!callWithoutCopy)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,22636,22774);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,22698,22755);

expr = f_10525_22705_22754(expr.Syntax, expr, f_10525_22744_22753(expr));
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,22636,22774);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,22792,22862);

return f_10525_22799_22861(expr.Syntax, expr, objectToStringMethod);
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,22577,22877);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,22893,23751) || true) && (callWithoutCopy)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,22893,23751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,22946,22981);

return f_10525_22953_22980(expr);
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,22893,23751);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,22893,23751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,23459,23512);

var 
temp = f_10525_23470_23511(_factory, expr, out store)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,23530,23736);

return f_10525_23537_23735(_factory, f_10525_23577_23616(f_10525_23599_23615(temp)), f_10525_23639_23684(store), f_10525_23707_23734(temp));
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,22893,23751);
}

BoundExpression makeConditionalAccess(BoundExpression receiver)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10525,23767,24525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,23863,23926);

int 
currentConditionalAccessID = ++_currentConditionalAccessID
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,23946,24510);

return f_10525_23953_24509(syntax, receiver, hasValueMethodOpt: null, whenNotNull: f_10525_24128_24332(syntax, f_10525_24209_24284(syntax, currentConditionalAccessID, f_10525_24274_24283(expr)), objectToStringMethod), whenNullOpt: null, id: currentConditionalAccessID, type: f_10525_24454_24508(_compilation, SpecialType.System_String));
DynAbs.Tracing.TraceSender.TraceExitMethod(10525,23767,24525);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_24274_24283(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 24274, 24283);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundConditionalReceiver
f_10525_24209_24284(Microsoft.CodeAnalysis.SyntaxNode
syntax,int
id,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConditionalReceiver( syntax, id, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 24209, 24284);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10525_24128_24332(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundConditionalReceiver
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = BoundCall.Synthesized( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 24128, 24332);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10525_24454_24508(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 24454, 24508);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
f_10525_23953_24509(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
hasValueMethodOpt,Microsoft.CodeAnalysis.CSharp.BoundCall
whenNotNull,Microsoft.CodeAnalysis.CSharp.BoundExpression?
whenNullOpt,int
id,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess( syntax, receiver, hasValueMethodOpt: hasValueMethodOpt, whenNotNull: (Microsoft.CodeAnalysis.CSharp.BoundExpression)whenNotNull, whenNullOpt: whenNullOpt, id: id, type: (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 23953, 24509);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10525,23767,24525);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10525,23767,24525);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static bool isFieldOfMarshalByRef(BoundExpression expr, CSharpCompilation compilation)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10525,24541,24878);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,24660,24832) || true) && (expr is BoundFieldAccess fieldAccess)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10525,24660,24832);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,24742,24813);

return f_10525_24749_24812(fieldAccess, compilation);
DynAbs.Tracing.TraceSender.TraceExitCondition(10525,24660,24832);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10525,24850,24863);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10525,24541,24878);

bool
f_10525_24749_24812(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
fieldAccess,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = DiagnosticsPass.IsNonAgileFieldAccess( fieldAccess, compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 24749, 24812);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10525,24541,24878);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10525,24541,24878);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
DynAbs.Tracing.TraceSender.TraceExitMethod(10525,18170,24889);

Microsoft.CodeAnalysis.CSharp.BoundKind
f_10525_18432_18441(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 18432, 18441);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.ConversionKind
f_10525_18566_18585(Microsoft.CodeAnalysis.CSharp.BoundConversion
this_param)
{
var return_v = this_param.ConversionKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 18566, 18585);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_18659_18671(Microsoft.CodeAnalysis.CSharp.BoundConversion
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 18659, 18671);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10525_18735_18744(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 18735, 18744);
return return_v;
}


int
f_10525_18722_18752(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 18722, 18752);
return 0;
}


Microsoft.CodeAnalysis.SpecialType
f_10525_19135_19149(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 19135, 19149);
return return_v;
}


char
f_10525_19248_19260(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.CharValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 19248, 19260);
return return_v;
}


string
f_10525_19248_19271(char
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 19248, 19271);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10525_19225_19272(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,string
stringValue)
{
var return_v = this_param.StringLiteral( stringValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 19225, 19272);
return return_v;
}


bool
f_10525_19319_19328(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.IsNull;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 19319, 19328);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_19493_19502(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 19493, 19502);
return return_v;
}


bool
f_10525_19493_19517(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsStringType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 19493, 19517);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10525_19781_19854(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.UnsafeGetSpecialTypeMethod( syntax, specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 19781, 19854);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_20100_20109(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 20100, 20109);
return return_v;
}


bool
f_10525_20100_20121(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.IsValueType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 20100, 20121);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_20126_20135(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 20126, 20135);
return return_v;
}


bool
f_10525_20126_20153(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsTypeParameter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 20126, 20153);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_20215_20224(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 20215, 20224);
return return_v;
}


string
f_10525_20285_20310(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 20285, 20310);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_10525_20269_20311(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param,string
name)
{
var return_v = this_param.GetMembers( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 20269, 20311);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10525_20484_20529(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
accessingTypeOpt)
{
var return_v = this_param.GetLeastOverriddenMethod( accessingTypeOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 20484, 20529);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_10525_20353_20372_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 20353, 20372);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_21221_21230(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 21221, 21230);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10525_21221_21242(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 21221, 21242);
return return_v;
}


bool
f_10525_21267_21308(Microsoft.CodeAnalysis.CSharp.BoundExpression
expr,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = isFieldOfMarshalByRef( expr, compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 21267, 21308);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10525_21350_21412(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 21350, 21412);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_22238_22247(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 22238, 22247);
return return_v;
}


bool
f_10525_22238_22263(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.IsReferenceType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 22238, 22263);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10525_22284_22302(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 22284, 22302);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_22365_22374(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 22365, 22374);
return return_v;
}


bool
f_10525_22365_22392(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsTypeParameter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 22365, 22392);
return return_v;
}


bool?
f_10525_22414_22457_M(bool?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 22414, 22457);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_22581_22590(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 22581, 22590);
return return_v;
}


bool
f_10525_22581_22602(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.IsValueType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 22581, 22602);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10525_22744_22753(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 22744, 22753);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundPassByCopy
f_10525_22705_22754(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundPassByCopy( syntax, expression, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 22705, 22754);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10525_22799_22861(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 22799, 22861);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_22953_22980(Microsoft.CodeAnalysis.CSharp.BoundExpression
receiver)
{
var return_v = makeConditionalAccess( receiver);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 22953, 22980);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10525_23470_23511(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 23470, 23511);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10525_23599_23615(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10525, 23599, 23615);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10525_23577_23616(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 23577, 23616);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10525_23639_23684(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 23639, 23684);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_23707_23734(Microsoft.CodeAnalysis.CSharp.BoundLocal
receiver)
{
var return_v = makeConditionalAccess( (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 23707, 23734);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10525_23537_23735(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
result)
{
var return_v = this_param.Sequence( locals, sideEffects, result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10525, 23537, 23735);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10525,18170,24889);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10525,18170,24889);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
