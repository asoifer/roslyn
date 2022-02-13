// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitUnaryOperator(BoundUnaryOperator node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10532,1188,3027);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,1282,1746);

switch (f_10532_1290_1318(f_10532_1290_1307(node)))
            {

case UnaryOperatorKind.PrefixDecrement:
                case UnaryOperatorKind.PrefixIncrement:
                case UnaryOperatorKind.PostfixDecrement:
                case UnaryOperatorKind.PostfixIncrement:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,1282,1746);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,1586,1606);

f_10532_1586_1605(false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,1694,1731);

return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitUnaryOperator(node),10532,1701,1730);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,1282,1746);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,2071,2817) || true) && (f_10532_2075_2092(f_10532_2075_2087(node))== BoundKind.BinaryOperator)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,2071,2817);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,2322,2377);

var 
binaryOperator = (BoundBinaryOperator)f_10532_2364_2376(node)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,2395,2802) || true) && (f_10532_2399_2416(node)== UnaryOperatorKind.DynamicTrue &&(DynAbs.Tracing.TraceSender.Expression_True(10532, 2399, 2519)&&f_10532_2453_2480(binaryOperator)== BinaryOperatorKind.DynamicLogicalOr )||(DynAbs.Tracing.TraceSender.Expression_False(10532, 2399, 2666)||f_10532_2544_2561(node)== UnaryOperatorKind.DynamicFalse &&(DynAbs.Tracing.TraceSender.Expression_True(10532, 2544, 2666)&&f_10532_2599_2626(binaryOperator)== BinaryOperatorKind.DynamicLogicalAnd)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,2395,2802);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,2708,2783);

return f_10532_2715_2782(this, binaryOperator, applyParentUnaryOperator: node);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,2395,2802);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,2071,2817);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,2833,2896);

BoundExpression 
loweredOperand = f_10532_2866_2895(this, f_10532_2882_2894(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,2910,3016);

return f_10532_2917_3015(this, node, f_10532_2941_2958(node), node.Syntax, f_10532_2973_2987(node), loweredOperand, f_10532_3005_3014(node));
DynAbs.Tracing.TraceSender.TraceExitMethod(10532,1188,3027);

Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_1290_1307(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 1290, 1307);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_1290_1318(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.Operator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 1290, 1318);
return return_v;
}


int
f_10532_1586_1605(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 1586, 1605);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_2075_2087(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 2075, 2087);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10532_2075_2092(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 2075, 2092);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_2364_2376(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 2364, 2376);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_2399_2416(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
this_param)
{
var return_v = this_param.OperatorKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 2399, 2416);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10532_2453_2480(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
this_param)
{
var return_v = this_param.OperatorKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 2453, 2480);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_2544_2561(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
this_param)
{
var return_v = this_param.OperatorKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 2544, 2561);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10532_2599_2626(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
this_param)
{
var return_v = this_param.OperatorKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 2599, 2626);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_2715_2782(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
node,Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
applyParentUnaryOperator)
{
var return_v = this_param.VisitBinaryOperator( node, applyParentUnaryOperator: applyParentUnaryOperator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 2715, 2782);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_2882_2894(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 2882, 2894);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10532_2866_2895(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 2866, 2895);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_2941_2958(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 2941, 2958);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10532_2973_2987(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
this_param)
{
var return_v = this_param.MethodOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 2973, 2987);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_3005_3014(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 3005, 3014);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_2917_3015(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
oldNode,Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeUnaryOperator( oldNode, kind, syntax, method, loweredOperand, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 2917, 3015);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10532,1188,3027);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10532,1188,3027);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeUnaryOperator(
            UnaryOperatorKind kind,
            SyntaxNode syntax,
            MethodSymbol? method,
            BoundExpression loweredOperand,
            TypeSymbol type)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10532,3039,3371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,3285,3360);

return f_10532_3292_3359(this, null, kind, syntax, method, loweredOperand, type);
DynAbs.Tracing.TraceSender.TraceExitMethod(10532,3039,3371);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_3292_3359(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator?
oldNode,Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeUnaryOperator( oldNode, kind, syntax, method, loweredOperand, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 3292, 3359);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10532,3039,3371);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10532,3039,3371);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeUnaryOperator(
            BoundUnaryOperator? oldNode,
            UnaryOperatorKind kind,
            SyntaxNode syntax,
            MethodSymbol? method,
            BoundExpression loweredOperand,
            TypeSymbol type)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10532,3383,7934);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,3671,5751) || true) && (f_10532_3675_3691(kind))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,3671,5751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,3725,3912);

f_10532_3725_3911((kind == UnaryOperatorKind.DynamicTrue ||(DynAbs.Tracing.TraceSender.Expression_False(10532, 3739, 3818)||kind == UnaryOperatorKind.DynamicFalse)) &&(DynAbs.Tracing.TraceSender.Expression_True(10532, 3738, 3869)&&f_10532_3823_3839(type)== SpecialType.System_Boolean
)||(DynAbs.Tracing.TraceSender.Expression_False(10532, 3738, 3910)||f_10532_3894_3910(type)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,3930,3959);

f_10532_3930_3958(method is null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,4045,4090);

var 
constant = f_10532_4060_4089(loweredOperand)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,4108,4628) || true) && (constant == f_10532_4124_4142()||(DynAbs.Tracing.TraceSender.Expression_False(10532, 4112, 4177)||constant == f_10532_4158_4177()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,4108,4628);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,4219,4609);

switch (kind)
                    {

case UnaryOperatorKind.DynamicTrue:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,4219,4609);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,4346,4393);

return f_10532_4353_4392(_factory, f_10532_4370_4391(constant));
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,4219,4609);

case UnaryOperatorKind.DynamicLogicalNegation:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,4219,4609);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,4495,4586);

return f_10532_4502_4585(this, f_10532_4521_4561(_factory, f_10532_4538_4560_M(!constant.BooleanValue)), type, @checked: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,4219,4609);
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,4108,4628);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,4648,4739);

return f_10532_4655_4723(_dynamicFactory, kind, loweredOperand, type).ToExpression();
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,3671,5751);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,3671,5751);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,4773,5751) || true) && (f_10532_4777_4792(kind))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,4773,5751);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,4826,4987) || true) && (!_inExpressionLambda)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,4826,4987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,4892,4968);

return f_10532_4899_4967(this, kind, syntax, method, loweredOperand, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,4826,4987);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,4773,5751);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,4773,5751);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,5021,5751) || true) && (f_10532_5025_5045(kind))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,5021,5751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,5079,5107);

f_10532_5079_5106(method is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,5125,5219);

f_10532_5125_5218(f_10532_5138_5217(type, f_10532_5162_5179(method), TypeCompareKind.ConsiderEverything2));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,5237,5493) || true) && (!_inExpressionLambda ||(DynAbs.Tracing.TraceSender.Expression_False(10532, 5241, 5306)||kind == UnaryOperatorKind.UserDefinedTrue )||(DynAbs.Tracing.TraceSender.Expression_False(10532, 5241, 5352)||kind == UnaryOperatorKind.UserDefinedFalse))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,5237,5493);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,5394,5474);

return f_10532_5401_5473(syntax, receiverOpt: null, method, loweredOperand);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,5237,5493);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,5021,5751);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,5021,5751);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,5527,5751) || true) && (f_10532_5531_5546(kind)== UnaryOperatorKind.UnaryPlus)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,5527,5751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,5714,5736);

return loweredOperand;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,5527,5751);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,5021,5751);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,4773,5751);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,3671,5751);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,5767,7240) || true) && (kind == UnaryOperatorKind.EnumBitwiseComplement)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,5767,7240);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,5852,5917);

var 
underlyingType = f_10532_5873_5916(f_10532_5873_5892(loweredOperand))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,5935,5971);

f_10532_5935_5970(underlyingType is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,5989,6071);

var 
upconvertSpecialType = f_10532_6016_6070(f_10532_6043_6069(underlyingType))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,6089,6271);

var 
upconvertType = (DynAbs.Tracing.TraceSender.Conditional_F1(10532, 6109, 6159)||((upconvertSpecialType == f_10532_6133_6159(underlyingType)&&DynAbs.Tracing.TraceSender.Conditional_F2(10532, 6183, 6197))||DynAbs.Tracing.TraceSender.Conditional_F3(10532, 6221, 6270)))?                    underlyingType :f_10532_6221_6270(                    _compilation, upconvertSpecialType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,6293,6367);

var 
newOperand = f_10532_6310_6366(this, loweredOperand, upconvertType, false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,6385,6460);

UnaryOperatorKind 
newKind = f_10532_6413_6459(f_10532_6413_6428(kind), upconvertSpecialType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,6480,7099);

var 
newNode = (DynAbs.Tracing.TraceSender.Conditional_F1(10532, 6494, 6511)||(((oldNode != null) &&DynAbs.Tracing.TraceSender.Conditional_F2(10532, 6535, 6793))||DynAbs.Tracing.TraceSender.Conditional_F3(10532, 6817, 7098)))?f_10532_6535_6793(                    oldNode, newKind, newOperand, f_10532_6647_6671(oldNode), method, f_10532_6731_6752(newOperand), upconvertType):f_10532_6817_7098(syntax, newKind, newOperand, null, method, LookupResultKind.Viable, upconvertType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,7119,7225);

return f_10532_7126_7224(this, newNode.Syntax, newNode, Conversion.ExplicitEnumeration, type, @checked: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,5767,7240);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,7256,7649) || true) && (kind == UnaryOperatorKind.DecimalUnaryMinus)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,7256,7649);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,7337,7451);

method = (MethodSymbol)f_10532_7360_7450(f_10532_7360_7381(_compilation), SpecialMember.System_Decimal__op_UnaryNegation);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,7469,7634) || true) && (!_inExpressionLambda)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,7469,7634);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,7535,7615);

return f_10532_7542_7614(syntax, receiverOpt: null, method, loweredOperand);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,7469,7634);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,7256,7649);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,7665,7923);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10532, 7672, 7689)||(((oldNode != null) &&DynAbs.Tracing.TraceSender.Conditional_F2(10532, 7709, 7805))||DynAbs.Tracing.TraceSender.Conditional_F3(10532, 7825, 7922)))?f_10532_7709_7805(                oldNode, kind, loweredOperand, f_10532_7746_7770(oldNode), method, f_10532_7780_7798(oldNode), type):f_10532_7825_7922(syntax, kind, loweredOperand, null, method, LookupResultKind.Viable, type);
DynAbs.Tracing.TraceSender.TraceExitMethod(10532,3383,7934);

bool
f_10532_3675_3691(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.IsDynamic();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 3675, 3691);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10532_3823_3839(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 3823, 3839);
return return_v;
}


bool
f_10532_3894_3910(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsDynamic();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 3894, 3910);
return return_v;
}


int
f_10532_3725_3911(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 3725, 3911);
return 0;
}


int
f_10532_3930_3958(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 3930, 3958);
return 0;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10532_4060_4089(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = UnboxConstant( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 4060, 4089);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10532_4124_4142()
{
var return_v = ConstantValue.True ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 4124, 4142);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10532_4158_4177()
{
var return_v = ConstantValue.False;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 4158, 4177);
return return_v;
}


bool
f_10532_4370_4391(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.BooleanValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 4370, 4391);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10532_4353_4392(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,bool
value)
{
var return_v = this_param.Literal( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 4353, 4392);
return return_v;
}


bool
f_10532_4538_4560_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 4538, 4560);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10532_4521_4561(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,bool
value)
{
var return_v = this_param.Literal( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 4521, 4561);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_4502_4585(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLiteral
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenOperand, rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 4502, 4585);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
f_10532_4655_4723(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
this_param,Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
resultType)
{
var return_v = this_param.MakeDynamicUnaryOperator( operatorKind, loweredOperand, resultType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 4655, 4723);
return return_v;
}


bool
f_10532_4777_4792(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.IsLifted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 4777, 4792);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_4899_4967(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.LowerLiftedUnaryOperator( kind, syntax, method, loweredOperand, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 4899, 4967);
return return_v;
}


bool
f_10532_5025_5045(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.IsUserDefined();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 5025, 5045);
return return_v;
}


int
f_10532_5079_5106(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 5079, 5106);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_5162_5179(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ReturnType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 5162, 5179);
return return_v;
}


bool
f_10532_5138_5217(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
left,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 5138, 5217);
return return_v;
}


int
f_10532_5125_5218(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 5125, 5218);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10532_5401_5473(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg0)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt: receiverOpt, method, arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 5401, 5473);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_5531_5546(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.Operator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 5531, 5546);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10532_5873_5892(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 5873, 5892);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
f_10532_5873_5916(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
type)
{
var return_v = type.GetEnumUnderlyingType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 5873, 5916);
return return_v;
}


int
f_10532_5935_5970(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 5935, 5970);
return 0;
}


Microsoft.CodeAnalysis.SpecialType
f_10532_6043_6069(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.SpecialType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 6043, 6069);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10532_6016_6070(Microsoft.CodeAnalysis.SpecialType
underlyingType)
{
var return_v = Binder.GetEnumPromotedType( underlyingType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 6016, 6070);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10532_6133_6159(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 6133, 6159);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10532_6221_6270(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 6221, 6270);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_6310_6366(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( rewrittenOperand, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rewrittenType, @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 6310, 6366);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_6413_6428(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.Operator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 6413, 6428);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_6413_6459(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind,Microsoft.CodeAnalysis.SpecialType
type)
{
var return_v = kind.WithType( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 6413, 6459);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10532_6647_6671(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
this_param)
{
var return_v = this_param.ConstantValueOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 6647, 6671);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LookupResultKind
f_10532_6731_6752(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ResultKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 6731, 6752);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
f_10532_6535_6793(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
this_param,Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
operand,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
methodOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = this_param.Update( operatorKind, operand, constantValueOpt, methodOpt, resultKind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 6535, 6793);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
f_10532_6817_7098(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
operand,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
methodOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator( syntax, operatorKind, operand, constantValueOpt, methodOpt, resultKind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 6817, 7098);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_7126_7224(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenOperand, conversion, rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 7126, 7224);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
f_10532_7360_7381(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 7360, 7381);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10532_7360_7450(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
this_param,Microsoft.CodeAnalysis.SpecialMember
member)
{
var return_v = this_param.GetSpecialTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 7360, 7450);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10532_7542_7614(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg0)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt: receiverOpt, method, arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 7542, 7614);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10532_7746_7770(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
this_param)
{
var return_v = this_param.ConstantValueOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 7746, 7770);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LookupResultKind
f_10532_7780_7798(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
this_param)
{
var return_v = this_param.ResultKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 7780, 7798);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
f_10532_7709_7805(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
this_param,Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
operand,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
methodOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Update( operatorKind, operand, constantValueOpt, methodOpt, resultKind, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 7709, 7805);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
f_10532_7825_7922(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
operand,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
methodOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator( syntax, operatorKind, operand, constantValueOpt, methodOpt, resultKind, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 7825, 7922);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10532,3383,7934);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10532,3383,7934);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression LowerLiftedUnaryOperator(
            UnaryOperatorKind kind,
            SyntaxNode syntax,
            MethodSymbol? method,
            BoundExpression loweredOperand,
            TypeSymbol type)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10532,7946,10705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,8345,8446);

BoundExpression? 
optimized = f_10532_8374_8445(this, kind, syntax, method, loweredOperand, type)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,8460,8547) || true) && (optimized != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,8460,8547);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,8515,8532);

return optimized;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,8460,8547);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,8842,8881);

BoundAssignmentOperator 
tempAssignment
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,8895,8975);

BoundLocal 
boundTemp = f_10532_8918_8974(_factory, loweredOperand, out tempAssignment)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,8989,9121);

MethodSymbol 
getValueOrDefault = f_10532_9022_9120(this, syntax, f_10532_9054_9068(boundTemp), SpecialMember.System_Nullable_T_GetValueOrDefault)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,9167,9235);

BoundExpression 
condition = f_10532_9195_9234(this, syntax, boundTemp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,9292,9393);

BoundExpression 
call_GetValueOrDefault = f_10532_9333_9392(syntax, boundTemp, getValueOrDefault)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,9458,9574);

BoundExpression 
consequence = f_10532_9488_9573(this, kind, syntax, method, type, call_GetValueOrDefault)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,9618,9689);

BoundExpression 
alternative = f_10532_9648_9688(syntax, type)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,9841,10204);

BoundExpression 
conditionalExpression = f_10532_9881_10203(syntax: syntax, rewrittenCondition: condition, rewrittenConsequence: consequence, rewrittenAlternative: alternative, constantValueOpt: null, rewrittenType: type, isRef: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,10389,10694);

return f_10532_10396_10693(syntax: syntax, locals: f_10532_10473_10530(f_10532_10508_10529(boundTemp)), sideEffects: f_10532_10562_10616(tempAssignment), value: conditionalExpression, type: type);
DynAbs.Tracing.TraceSender.TraceExitMethod(10532,7946,10705);

Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10532_8374_8445(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.OptimizeLiftedUnaryOperator( operatorKind, syntax, method, loweredOperand, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 8374, 8445);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10532_8918_8974(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 8918, 8974);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_9054_9068(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 9054, 9068);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10532_9022_9120(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
nullableType,Microsoft.CodeAnalysis.SpecialMember
member)
{
var return_v = this_param.UnsafeGetNullableMethod( syntax, nullableType, member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 9022, 9120);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_9195_9234(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
expression)
{
var return_v = this_param.MakeNullableHasValue( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 9195, 9234);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10532_9333_9392(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = BoundCall.Synthesized( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 9333, 9392);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_9488_9573(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundExpression
nonNullOperand)
{
var return_v = this_param.GetLiftedUnaryOperatorConsequence( kind, syntax, method, type, nonNullOperand);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 9488, 9573);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
f_10532_9648_9688(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression( syntax, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 9648, 9688);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_9881_10203(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenConsequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenAlternative,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
isRef)
{
var return_v = RewriteConditionalOperator( syntax: syntax, rewrittenCondition: rewrittenCondition, rewrittenConsequence: rewrittenConsequence, rewrittenAlternative: rewrittenAlternative, constantValueOpt: constantValueOpt, rewrittenType: rewrittenType, isRef: isRef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 9881, 10203);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10532_10508_10529(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 10508, 10529);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10532_10473_10530(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
var return_v = ImmutableArray.Create<LocalSymbol>( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 10473, 10530);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10532_10562_10616(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 10562, 10616);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10532_10396_10693(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax: syntax, locals: locals, sideEffects: sideEffects, value: value, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 10396, 10693);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10532,7946,10705);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10532,7946,10705);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression? OptimizeLiftedUnaryOperator(
            UnaryOperatorKind operatorKind,
            SyntaxNode syntax,
            MethodSymbol? method,
            BoundExpression loweredOperand,
            TypeSymbol type)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10532,10717,15961);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,10982,11120) || true) && (f_10532_10986_11023(loweredOperand))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,10982,11120);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,11057,11105);

return f_10532_11064_11104(syntax, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,10982,11120);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,11399,11467);

BoundExpression? 
neverNull = f_10532_11428_11466(loweredOperand)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,11481,11639) || true) && (neverNull != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,11481,11639);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,11536,11624);

return f_10532_11543_11623(this, operatorKind, syntax, method, type, neverNull);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,11481,11639);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,11655,11725);

var 
conditionalLeft = loweredOperand as BoundLoweredConditionalAccess
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,11970,12115);

var 
optimize = conditionalLeft != null &&(DynAbs.Tracing.TraceSender.Expression_True(10532, 11985, 12114)&&                (f_10532_12030_12057(conditionalLeft)== null ||(DynAbs.Tracing.TraceSender.Expression_False(10532, 12030, 12113)||f_10532_12069_12113(f_10532_12069_12096(conditionalLeft)))))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,12131,12686) || true) && (optimize)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,12131,12686);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,12177,12281);

var 
result = f_10532_12190_12280(this, operatorKind, syntax, method, f_10532_12245_12273(conditionalLeft!), type)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,12299,12332);

f_10532_12299_12331(f_10532_12312_12323(result)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,12352,12671);

return f_10532_12359_12670(conditionalLeft, f_10532_12404_12428(conditionalLeft), f_10532_12451_12484(conditionalLeft), whenNotNull: result, whenNullOpt: null, id: f_10532_12593_12611(conditionalLeft), type: f_10532_12640_12651(result));
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,12131,12686);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,14257,15922) || true) && (f_10532_14261_14280(loweredOperand)== BoundKind.Sequence)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,14257,15922);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,14336,14386);

BoundSequence 
seq = (BoundSequence)loweredOperand
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,14404,15907) || true) && (f_10532_14408_14422(f_10532_14408_14417(seq))== BoundKind.ConditionalOperator)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,14404,15907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,14497,14572);

BoundConditionalOperator 
conditional = (BoundConditionalOperator)f_10532_14562_14571(seq)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,14594,14691);

f_10532_14594_14690(f_10532_14607_14689(f_10532_14625_14633(seq), f_10532_14635_14651(conditional), TypeCompareKind.ConsiderEverything2));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,14713,14830);

f_10532_14713_14829(f_10532_14726_14828(f_10532_14744_14760(conditional), f_10532_14762_14790(f_10532_14762_14785(conditional)), TypeCompareKind.ConsiderEverything2));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,14852,14969);

f_10532_14852_14968(f_10532_14865_14967(f_10532_14883_14899(conditional), f_10532_14901_14929(f_10532_14901_14924(conditional)), TypeCompareKind.ConsiderEverything2));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,14993,15888) || true) && (f_10532_14997_15044(f_10532_15020_15043(conditional))!= null &&(DynAbs.Tracing.TraceSender.Expression_True(10532, 14997, 15102)&&f_10532_15056_15102(f_10532_15078_15101(conditional))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,14993,15888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,15152,15865);

return f_10532_15159_15864(syntax, f_10532_15244_15254(seq), f_10532_15285_15300(seq), f_10532_15331_15828(syntax, f_10532_15433_15454(conditional), f_10532_15489_15567(this, operatorKind, syntax, method, f_10532_15537_15560(conditional), type), f_10532_15602_15680(this, operatorKind, syntax, method, f_10532_15650_15673(conditional), type), ConstantValue.NotAvailable, type, isRef: false), type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,14993,15888);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,14404,15907);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,14257,15922);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,15938,15950);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(10532,10717,15961);

bool
f_10532_10986_11023(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableNeverHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 10986, 11023);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
f_10532_11064_11104(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression( syntax, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 11064, 11104);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10532_11428_11466(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableAlwaysHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 11428, 11466);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_11543_11623(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundExpression
nonNullOperand)
{
var return_v = this_param.GetLiftedUnaryOperatorConsequence( kind, syntax, method, type, nonNullOperand);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 11543, 11623);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10532_12030_12057(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.WhenNullOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 12030, 12057);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_12069_12096(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.WhenNullOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 12069, 12096);
return return_v;
}


bool
f_10532_12069_12113(Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = node.IsDefaultValue();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 12069, 12113);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_12245_12273(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.WhenNotNull;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 12245, 12273);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_12190_12280(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.LowerLiftedUnaryOperator( kind, syntax, method, loweredOperand, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 12190, 12280);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10532_12312_12323(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 12312, 12323);
return return_v;
}


int
f_10532_12299_12331(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 12299, 12331);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_12404_12428(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.Receiver;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 12404, 12428);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10532_12451_12484(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.HasValueMethodOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 12451, 12484);
return return_v;
}


int
f_10532_12593_12611(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param)
{
var return_v = this_param.Id;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 12593, 12611);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_12640_12651(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type
;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 12640, 12651);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
f_10532_12359_12670(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
hasValueMethodOpt,Microsoft.CodeAnalysis.CSharp.BoundExpression
whenNotNull,Microsoft.CodeAnalysis.CSharp.BoundExpression?
whenNullOpt,int
id,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Update( receiver, hasValueMethodOpt, whenNotNull: whenNotNull, whenNullOpt: whenNullOpt, id: id, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 12359, 12670);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10532_14261_14280(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 14261, 14280);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_14408_14417(Microsoft.CodeAnalysis.CSharp.BoundSequence
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 14408, 14417);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10532_14408_14422(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 14408, 14422);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_14562_14571(Microsoft.CodeAnalysis.CSharp.BoundSequence
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 14562, 14571);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_14625_14633(Microsoft.CodeAnalysis.CSharp.BoundSequence
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 14625, 14633);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_14635_14651(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 14635, 14651);
return return_v;
}


bool
f_10532_14607_14689(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
left,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 14607, 14689);
return return_v;
}


int
f_10532_14594_14690(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 14594, 14690);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_14744_14760(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 14744, 14760);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_14762_14785(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Consequence;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 14762, 14785);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10532_14762_14790(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 14762, 14790);
return return_v;
}


bool
f_10532_14726_14828(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
left,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 14726, 14828);
return return_v;
}


int
f_10532_14713_14829(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 14713, 14829);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_14883_14899(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 14883, 14899);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_14901_14924(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Alternative;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 14901, 14924);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10532_14901_14929(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 14901, 14929);
return return_v;
}


bool
f_10532_14865_14967(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
left,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 14865, 14967);
return return_v;
}


int
f_10532_14852_14968(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 14852, 14968);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_15020_15043(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Consequence;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 15020, 15043);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10532_14997_15044(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableAlwaysHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 14997, 15044);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_15078_15101(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Alternative;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 15078, 15101);
return return_v;
}


bool
f_10532_15056_15102(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableNeverHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 15056, 15102);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10532_15244_15254(Microsoft.CodeAnalysis.CSharp.BoundSequence
this_param)
{
var return_v = this_param.Locals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 15244, 15254);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10532_15285_15300(Microsoft.CodeAnalysis.CSharp.BoundSequence
this_param)
{
var return_v = this_param.SideEffects;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 15285, 15300);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_15433_15454(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Condition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 15433, 15454);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_15537_15560(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Consequence;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 15537, 15560);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_15489_15567(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeUnaryOperator( kind, syntax, method, loweredOperand, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 15489, 15567);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_15650_15673(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
this_param)
{
var return_v = this_param.Alternative;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 15650, 15673);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_15602_15680(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeUnaryOperator( kind, syntax, method, loweredOperand, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 15602, 15680);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_15331_15828(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenConsequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenAlternative,Microsoft.CodeAnalysis.ConstantValue
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
isRef)
{
var return_v = RewriteConditionalOperator( syntax, rewrittenCondition, rewrittenConsequence, rewrittenAlternative, constantValueOpt, rewrittenType, isRef: isRef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 15331, 15828);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10532_15159_15864(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax, locals, sideEffects, value, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 15159, 15864);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10532,10717,15961);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10532,10717,15961);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression GetLiftedUnaryOperatorConsequence(UnaryOperatorKind kind, SyntaxNode syntax, MethodSymbol? method, TypeSymbol type, BoundExpression nonNullOperand)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10532,15973,16886);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,16169,16266);

MethodSymbol 
ctor = f_10532_16189_16265(this, syntax, type, SpecialMember.System_Nullable_T__ctor)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,16327,16619);

BoundExpression 
unliftedOp = f_10532_16356_16618(this, oldNode: null, kind: f_10532_16430_16445(kind), syntax: syntax, method: method, loweredOperand: nonNullOperand, type: f_10532_16585_16617(type))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,16688,16842);

BoundExpression 
consequence = f_10532_16718_16841(syntax, ctor, unliftedOp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,16856,16875);

return consequence;
DynAbs.Tracing.TraceSender.TraceExitMethod(10532,15973,16886);

Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10532_16189_16265(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
nullableType,Microsoft.CodeAnalysis.SpecialMember
member)
{
var return_v = this_param.UnsafeGetNullableMethod( syntax, nullableType, member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 16189, 16265);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_16430_16445(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.Unlifted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 16430, 16445);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_16585_16617(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.GetNullableUnderlyingType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 16585, 16617);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_16356_16618(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator?
oldNode,Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeUnaryOperator( oldNode: oldNode, kind: kind, syntax: syntax, method: method, loweredOperand: loweredOperand, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 16356, 16618);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
f_10532_16718_16841(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
constructor,params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
arguments)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression( syntax, constructor, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 16718, 16841);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10532,15973,16886);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10532,15973,16886);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsIncrement(BoundIncrementOperator node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10532,16898,17137);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,16983,17021);

var 
op = f_10532_16992_17020(f_10532_16992_17009(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,17035,17126);

return op == UnaryOperatorKind.PostfixIncrement ||(DynAbs.Tracing.TraceSender.Expression_False(10532, 17042, 17125)||op == UnaryOperatorKind.PrefixIncrement);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10532,16898,17137);

Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_16992_17009(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 16992, 17009);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_16992_17020(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.Operator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 16992, 17020);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10532,16898,17137);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10532,16898,17137);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsPrefix(BoundIncrementOperator node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10532,17149,17384);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,17231,17269);

var 
op = f_10532_17240_17268(f_10532_17240_17257(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,17283,17373);

return op == UnaryOperatorKind.PrefixIncrement ||(DynAbs.Tracing.TraceSender.Expression_False(10532, 17290, 17372)||op == UnaryOperatorKind.PrefixDecrement);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10532,17149,17384);

Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_17240_17257(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 17240, 17257);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_17240_17268(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.Operator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 17240, 17268);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10532,17149,17384);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10532,17149,17384);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode VisitIncrementOperator(BoundIncrementOperator node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10532,19300,22692);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,19402,19433);

bool 
isPrefix = f_10532_19418_19432(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,19447,19494);

bool 
isDynamic = f_10532_19464_19493(f_10532_19464_19481(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,19508,19555);

bool 
isChecked = f_10532_19525_19554(f_10532_19525_19542(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,19571,19651);

ArrayBuilder<LocalSymbol> 
tempSymbols = f_10532_19611_19650()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,19665,19758);

ArrayBuilder<BoundExpression> 
tempInitializers = f_10532_19714_19757()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,19774,19806);

SyntaxNode 
syntax = node.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,19958,20078);

BoundExpression 
transformedLHS = f_10532_19991_20077(this, f_10532_20022_20034(node), tempInitializers, tempSymbols, isDynamic)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,20092,20138);

TypeSymbol? 
operandType = f_10532_20118_20137(transformedLHS)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,20193,20226);

f_10532_20193_20225(operandType is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,20240,20333);

f_10532_20240_20332(f_10532_20253_20331(operandType, f_10532_20284_20293(node), TypeCompareKind.ConsiderEverything2));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,20349,20413);

LocalSymbol 
tempSymbol = f_10532_20374_20412(_factory, operandType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,20427,20455);

f_10532_20427_20454(            tempSymbols, tempSymbol);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,20574,20770);

BoundExpression 
boundTemp = f_10532_20602_20769(syntax: syntax, localSymbol: tempSymbol, constantValueOpt: null, type: operandType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,20893,21016);

var 
newValue = f_10532_20908_21015(this, node, rewrittenValueToIncrement: ((DynAbs.Tracing.TraceSender.Conditional_F1(10532, 20964, 20972)||((isPrefix &&DynAbs.Tracing.TraceSender.Conditional_F2(10532, 20975, 21001))||DynAbs.Tracing.TraceSender.Conditional_F3(10532, 21004, 21013)))?f_10532_20975_21001(this, transformedLHS):boundTemp))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,22240,22681) || true) && (f_10532_22244_22285(transformedLHS))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,22240,22681);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,22319,22458);

return f_10532_22326_22457(this, isPrefix, isChecked, tempSymbols, tempInitializers, syntax, transformedLHS, operandType, boundTemp, newValue);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,22240,22681);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,22240,22681);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,22524,22666);

return f_10532_22531_22665(this, isPrefix, isChecked, tempSymbols, tempInitializers, syntax, transformedLHS, operandType, boundTemp, newValue);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,22240,22681);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10532,19300,22692);

bool
f_10532_19418_19432(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
node)
{
var return_v = IsPrefix( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 19418, 19432);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_19464_19481(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 19464, 19481);
return return_v;
}


bool
f_10532_19464_19493(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.IsDynamic();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 19464, 19493);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_19525_19542(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 19525, 19542);
return return_v;
}


bool
f_10532_19525_19554(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.IsChecked();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 19525, 19554);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10532_19611_19650()
{
var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 19611, 19650);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10532_19714_19757()
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 19714, 19757);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_20022_20034(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 20022, 20034);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_19991_20077(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
originalLHS,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
stores,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps,bool
isDynamicAssignment)
{
var return_v = this_param.TransformCompoundAssignmentLHS( originalLHS, stores, temps, isDynamicAssignment);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 19991, 20077);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10532_20118_20137(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 20118, 20137);
return return_v;
}


int
f_10532_20193_20225(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 20193, 20225);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_20284_20293(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 20284, 20293);
return return_v;
}


bool
f_10532_20253_20331(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
left,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 20253, 20331);
return return_v;
}


int
f_10532_20240_20332(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 20240, 20332);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10532_20374_20412(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.SynthesizedLocal( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 20374, 20412);
return return_v;
}


int
f_10532_20427_20454(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 20427, 20454);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10532_20602_20769(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
localSymbol,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLocal( syntax: syntax, localSymbol: localSymbol, constantValueOpt: constantValueOpt, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 20602, 20769);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_20975_21001(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
transformedExpression)
{
var return_v = this_param.MakeRValue( transformedExpression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 20975, 21001);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_20908_21015(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
node,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenValueToIncrement)
{
var return_v = this_param.MakeIncrementOperator( node, rewrittenValueToIncrement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 20908, 21015);
return return_v;
}


bool
f_10532_22244_22285(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = IsIndirectOrInstanceField( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 22244, 22285);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode
f_10532_22326_22457(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,bool
isPrefix,bool
isChecked,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
tempSymbols,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
tempInitializers,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
operand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
operandType,Microsoft.CodeAnalysis.CSharp.BoundExpression
boundTemp,Microsoft.CodeAnalysis.CSharp.BoundExpression
newValue)
{
var return_v = this_param.RewriteWithRefOperand( isPrefix, isChecked, tempSymbols, tempInitializers, syntax, operand, operandType, boundTemp, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 22326, 22457);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode
f_10532_22531_22665(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,bool
isPrefix,bool
isChecked,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
tempSymbols,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
tempInitializers,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
transformedLHS,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
operandType,Microsoft.CodeAnalysis.CSharp.BoundExpression
boundTemp,Microsoft.CodeAnalysis.CSharp.BoundExpression
newValue)
{
var return_v = this_param.RewriteWithNotRefOperand( isPrefix, isChecked, tempSymbols, tempInitializers, syntax, transformedLHS, operandType, boundTemp, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 22531, 22665);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10532,19300,22692);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10532,19300,22692);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsIndirectOrInstanceField(BoundExpression expression)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10532,22704,23297);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,22802,23257);

switch (f_10532_22810_22825(expression))
            {

case BoundKind.Local:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,22802,23257);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,22902,22970);

return f_10532_22909_22953(f_10532_22909_22945(((BoundLocal)expression)))!= RefKind.None;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,22802,23257);

case BoundKind.Parameter:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,22802,23257);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,23037,23113);

return f_10532_23044_23096(f_10532_23044_23088(((BoundParameter)expression)))!= RefKind.None;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,22802,23257);

case BoundKind.FieldAccess:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,22802,23257);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,23182,23242);

return f_10532_23189_23241_M(!f_10532_23190_23232(((BoundFieldAccess)expression)).IsStatic);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,22802,23257);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,23273,23286);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10532,22704,23297);

Microsoft.CodeAnalysis.CSharp.BoundKind
f_10532_22810_22825(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 22810, 22825);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10532_22909_22945(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 22909, 22945);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_10532_22909_22953(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.RefKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 22909, 22953);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
f_10532_23044_23088(Microsoft.CodeAnalysis.CSharp.BoundParameter
this_param)
{
var return_v = this_param.ParameterSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 23044, 23088);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_10532_23044_23096(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.RefKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 23044, 23096);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
f_10532_23190_23232(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
this_param)
{
var return_v = this_param.FieldSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 23190, 23232);
return return_v;
}


bool
f_10532_23189_23241_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 23189, 23241);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10532,22704,23297);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10532,22704,23297);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundNode RewriteWithNotRefOperand(
            bool isPrefix,
            bool isChecked,
            ArrayBuilder<LocalSymbol> tempSymbols,
            ArrayBuilder<BoundExpression> tempInitializers,
            SyntaxNode syntax,
            BoundExpression transformedLHS,
            TypeSymbol operandType,
            BoundExpression boundTemp,
            BoundExpression newValue)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10532,23309,24908);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,23923,24371);

ImmutableArray<BoundExpression> 
assignments = f_10532_23969_24370(f_10532_24026_24194(this, syntax, boundTemp, (DynAbs.Tracing.TraceSender.Conditional_F1(10532, 24068, 24076)||((isPrefix &&DynAbs.Tracing.TraceSender.Conditional_F2(10532, 24079, 24087))||DynAbs.Tracing.TraceSender.Conditional_F3(10532, 24090, 24116)))?newValue :f_10532_24090_24116(this, transformedLHS), operandType, used: false, isChecked: isChecked, isCompoundAssignment: false), f_10532_24213_24369(this, syntax, transformedLHS, (DynAbs.Tracing.TraceSender.Conditional_F1(10532, 24260, 24268)||((isPrefix &&DynAbs.Tracing.TraceSender.Conditional_F2(10532, 24271, 24280))||DynAbs.Tracing.TraceSender.Conditional_F3(10532, 24283, 24291)))?boundTemp :newValue, operandType, used: false, isChecked: isChecked, isCompoundAssignment: false))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,24619,24897);

return f_10532_24626_24896(syntax: syntax, locals: f_10532_24703_24735(tempSymbols), sideEffects: f_10532_24767_24804(tempInitializers).Concat(assignments), value: boundTemp, type: operandType);
DynAbs.Tracing.TraceSender.TraceExitMethod(10532,23309,24908);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_24090_24116(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
transformedExpression)
{
var return_v = this_param.MakeRValue( transformedExpression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 24090, 24116);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_24026_24194(Microsoft.CodeAnalysis.CSharp.LocalRewriter
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
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 24026, 24194);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_24213_24369(Microsoft.CodeAnalysis.CSharp.LocalRewriter
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
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 24213, 24369);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10532_23969_24370(Microsoft.CodeAnalysis.CSharp.BoundExpression
item1,Microsoft.CodeAnalysis.CSharp.BoundExpression
item2)
{
var return_v = ImmutableArray.Create<BoundExpression>( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 23969, 24370);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10532_24703_24735(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 24703, 24735);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10532_24767_24804(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 24767, 24804);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10532_24626_24896(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax: syntax, locals: locals, sideEffects: sideEffects, value: value, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 24626, 24896);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10532,23309,24908);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10532,23309,24908);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundNode RewriteWithRefOperand(
            bool isPrefix,
            bool isChecked,
            ArrayBuilder<LocalSymbol> tempSymbols,
            ArrayBuilder<BoundExpression> tempInitializers,
            SyntaxNode syntax,
            BoundExpression operand,
            TypeSymbol operandType,
            BoundExpression boundTemp,
            BoundExpression newValue)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10532,24920,26914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,25341,25399);

var 
tempValue = (DynAbs.Tracing.TraceSender.Conditional_F1(10532, 25357, 25365)||((isPrefix &&DynAbs.Tracing.TraceSender.Conditional_F2(10532, 25368, 25376))||DynAbs.Tracing.TraceSender.Conditional_F3(10532, 25379, 25398)))?newValue :f_10532_25379_25398(this, operand)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,25413,25449);

f_10532_25413_25448(f_10532_25426_25440(tempValue)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,25463,25614);

var 
tempAssignment = f_10532_25484_25613(this, syntax, boundTemp, tempValue, operandType, used: false, isChecked: isChecked, isCompoundAssignment: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,25630,25681);

var 
operandValue = (DynAbs.Tracing.TraceSender.Conditional_F1(10532, 25649, 25657)||((isPrefix &&DynAbs.Tracing.TraceSender.Conditional_F2(10532, 25660, 25669))||DynAbs.Tracing.TraceSender.Conditional_F3(10532, 25672, 25680)))?boundTemp :newValue
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,25695,25982);

var 
tempAssignedAndOperandValue = f_10532_25729_25981(syntax, ImmutableArray<LocalSymbol>.Empty, f_10532_25854_25908(tempAssignment), operandValue, f_10532_25966_25980(tempValue))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,26151,26333);

BoundExpression 
operandAssignment = f_10532_26187_26332(this, syntax, operand, tempAssignedAndOperandValue, operandType, used: false, isChecked: isChecked, isCompoundAssignment: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,26591,26631);

f_10532_26591_26630(
            // prefix:  Seq{operand initializers; operand = Seq{temp = (T)(operand + 1);  temp;}          result: temp}
            // postfix: Seq{operand initializers; operand = Seq{temp = operand;        ;  (T)(temp + 1);} result: temp}
            tempInitializers, operandAssignment);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,26645,26903);

return f_10532_26652_26902(syntax: syntax, locals: f_10532_26729_26761(tempSymbols), sideEffects: f_10532_26793_26830(tempInitializers), value: boundTemp, type: operandType);
DynAbs.Tracing.TraceSender.TraceExitMethod(10532,24920,26914);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_25379_25398(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
transformedExpression)
{
var return_v = this_param.MakeRValue( transformedExpression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 25379, 25398);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10532_25426_25440(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 25426, 25440);
return return_v;
}


int
f_10532_25413_25448(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 25413, 25448);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_25484_25613(Microsoft.CodeAnalysis.CSharp.LocalRewriter
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
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 25484, 25613);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10532_25854_25908(Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 25854, 25908);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_25966_25980(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 25966, 25980);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10532_25729_25981(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax, locals, sideEffects, value, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 25729, 25981);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_26187_26332(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenLeft,Microsoft.CodeAnalysis.CSharp.BoundSequence
rewrittenRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,bool
used,bool
isChecked,bool
isCompoundAssignment)
{
var return_v = this_param.MakeAssignmentOperator( syntax, rewrittenLeft, (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenRight, type, used: used, isChecked: isChecked, isCompoundAssignment: isCompoundAssignment);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 26187, 26332);
return return_v;
}


int
f_10532_26591_26630(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 26591, 26630);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10532_26729_26761(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 26729, 26761);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10532_26793_26830(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 26793, 26830);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10532_26652_26902(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax: syntax, locals: locals, sideEffects: sideEffects, value: value, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 26652, 26902);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10532,24920,26914);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10532,24920,26914);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeIncrementOperator(BoundIncrementOperator node, BoundExpression rewrittenValueToIncrement)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10532,26926,28212);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,27068,27270) || true) && (f_10532_27072_27101(f_10532_27072_27089(node)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,27068,27270);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,27135,27255);

return f_10532_27142_27239(_dynamicFactory, f_10532_27183_27200(node), rewrittenValueToIncrement, f_10532_27229_27238(node)).ToExpression();
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,27068,27270);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,27286,27309);

BoundExpression 
result
=default(BoundExpression);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,27323,27653) || true) && (f_10532_27327_27359(f_10532_27327_27344(node))== UnaryOperatorKind.UserDefined)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,27323,27653);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,27426,27501);

result = f_10532_27435_27500(this, node, rewrittenValueToIncrement);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,27323,27653);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,27323,27653);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,27567,27638);

result = f_10532_27576_27637(this, node, rewrittenValueToIncrement);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,27323,27653);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,27802,28171) || true) && (f_10532_27806_27839_M(!node.ResultConversion.IsIdentity))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,27802,28171);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,27873,28156);

result = f_10532_27882_28155(this, syntax: node.Syntax, rewrittenOperand: result, conversion: f_10532_28024_28045(node), rewrittenType: f_10532_28083_28092(node), @checked: f_10532_28125_28154(f_10532_28125_28142(node)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,27802,28171);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,28187,28201);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10532,26926,28212);

Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_27072_27089(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 27072, 27089);
return return_v;
}


bool
f_10532_27072_27101(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.IsDynamic();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 27072, 27101);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_27183_27200(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 27183, 27200);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_27229_27238(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 27229, 27238);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
f_10532_27142_27239(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
this_param,Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
resultType)
{
var return_v = this_param.MakeDynamicUnaryOperator( operatorKind, loweredOperand, resultType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 27142, 27239);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_27327_27344(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 27327, 27344);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_27327_27359(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.OperandTypes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 27327, 27359);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_27435_27500(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
node,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenValueToIncrement)
{
var return_v = this_param.MakeUserDefinedIncrementOperator( node, rewrittenValueToIncrement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 27435, 27500);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_27576_27637(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
node,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenValueToIncrement)
{
var return_v = this_param.MakeBuiltInIncrementOperator( node, rewrittenValueToIncrement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 27576, 27637);
return return_v;
}


bool
f_10532_27806_27839_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 27806, 27839);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10532_28024_28045(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.ResultConversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 28024, 28045);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_28083_28092(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 28083, 28092);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_28125_28142(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 28125, 28142);
return return_v;
}


bool
f_10532_28125_28154(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.IsChecked();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 28125, 28154);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_27882_28155(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( syntax: syntax, rewrittenOperand: rewrittenOperand, conversion: conversion, rewrittenType: rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 27882, 28155);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10532,26926,28212);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10532,26926,28212);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeUserDefinedIncrementOperator(BoundIncrementOperator node, BoundExpression rewrittenValueToIncrement)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10532,28224,32291);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,28377,28413);

f_10532_28377_28412(f_10532_28390_28404(node)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,28427,28476);

f_10532_28427_28475(f_10532_28440_28469(f_10532_28440_28454(node))== 1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,28492,28537);

bool 
isLifted = f_10532_28508_28536(f_10532_28508_28525(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,28551,28597);

bool 
@checked = f_10532_28567_28596(f_10532_28567_28584(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,28613,28675);

BoundExpression 
rewrittenArgument = rewrittenValueToIncrement
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,28689,28721);

SyntaxNode 
syntax = node.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,28737,28790);

TypeSymbol 
type = f_10532_28755_28789(f_10532_28755_28769(node), 0)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,28804,29097) || true) && (isLifted)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,28804,29097);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,28850,28932);

type = f_10532_28857_28931(f_10532_28857_28915(_compilation, SpecialType.System_Nullable_T), type);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,28950,29082);

f_10532_28950_29081(f_10532_28963_29080(f_10532_28981_29015(f_10532_28981_28995(node), 0), f_10532_29017_29042(f_10532_29017_29031(node)), TypeCompareKind.ConsiderEverything2));
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,28804,29097);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,29113,29483) || true) && (f_10532_29117_29151_M(!node.OperandConversion.IsIdentity))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,29113,29483);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,29185,29468);

rewrittenArgument = f_10532_29205_29467(this, syntax: syntax, rewrittenOperand: rewrittenValueToIncrement, conversion: f_10532_29361_29383(node), rewrittenType: type, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,29113,29483);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,29499,29652) || true) && (!isLifted)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,29499,29652);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,29546,29637);

return f_10532_29553_29636(syntax, receiverOpt: null, f_10532_29602_29616(node), rewrittenArgument);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,29499,29652);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,30110,30149);

BoundAssignmentOperator 
tempAssignment
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,30163,30246);

BoundLocal 
boundTemp = f_10532_30186_30245(_factory, rewrittenArgument, out tempAssignment)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,30262,30384);

MethodSymbol 
getValueOrDefault = f_10532_30295_30383(this, syntax, type, SpecialMember.System_Nullable_T_GetValueOrDefault)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,30398,30495);

MethodSymbol 
ctor = f_10532_30418_30494(this, syntax, type, SpecialMember.System_Nullable_T__ctor)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,30541,30614);

BoundExpression 
condition = f_10532_30569_30613(this, node.Syntax, boundTemp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,30671,30772);

BoundExpression 
call_GetValueOrDefault = f_10532_30712_30771(syntax, boundTemp, getValueOrDefault)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,30843,30966);

BoundExpression 
userDefinedCall = f_10532_30877_30965(syntax, receiverOpt: null, f_10532_30926_30940(node), call_GetValueOrDefault)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,31045,31140);

BoundExpression 
consequence = f_10532_31075_31139(syntax, ctor, userDefinedCall)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,31184,31255);

BoundExpression 
alternative = f_10532_31214_31254(syntax, type)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,31417,31780);

BoundExpression 
conditionalExpression = f_10532_31457_31779(syntax: syntax, rewrittenCondition: condition, rewrittenConsequence: consequence, rewrittenAlternative: alternative, constantValueOpt: null, rewrittenType: type, isRef: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,31975,32280);

return f_10532_31982_32279(syntax: syntax, locals: f_10532_32059_32116(f_10532_32094_32115(boundTemp)), sideEffects: f_10532_32148_32202(tempAssignment), value: conditionalExpression, type: type);
DynAbs.Tracing.TraceSender.TraceExitMethod(10532,28224,32291);

Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10532_28390_28404(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.MethodOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 28390, 28404);
return return_v;
}


int
f_10532_28377_28412(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 28377, 28412);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10532_28440_28454(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.MethodOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 28440, 28454);
return return_v;
}


int
f_10532_28440_28469(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ParameterCount ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 28440, 28469);
return return_v;
}


int
f_10532_28427_28475(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 28427, 28475);
return 0;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_28508_28525(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 28508, 28525);
return return_v;
}


bool
f_10532_28508_28536(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.IsLifted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 28508, 28536);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_28567_28584(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 28567, 28584);
return return_v;
}


bool
f_10532_28567_28596(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.IsChecked();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 28567, 28596);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10532_28755_28769(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.MethodOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 28755, 28769);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_28755_28789(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param,int
index)
{
var return_v = this_param.GetParameterType( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 28755, 28789);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10532_28857_28915(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 28857, 28915);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10532_28857_28931(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param,params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
typeArguments)
{
var return_v = this_param.Construct( typeArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 28857, 28931);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10532_28981_28995(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.MethodOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 28981, 28995);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_28981_29015(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param,int
index)
{
var return_v = this_param.GetParameterType( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 28981, 29015);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10532_29017_29031(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.MethodOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 29017, 29031);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_29017_29042(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ReturnType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 29017, 29042);
return return_v;
}


bool
f_10532_28963_29080(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
left,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 28963, 29080);
return return_v;
}


int
f_10532_28950_29081(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 28950, 29081);
return 0;
}


bool
f_10532_29117_29151_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 29117, 29151);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10532_29361_29383(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.OperandConversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 29361, 29383);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_29205_29467(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( syntax: syntax, rewrittenOperand: rewrittenOperand, conversion: conversion, rewrittenType: rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 29205, 29467);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10532_29602_29616(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.MethodOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 29602, 29616);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10532_29553_29636(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg0)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt: receiverOpt, method, arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 29553, 29636);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10532_30186_30245(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 30186, 30245);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10532_30295_30383(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
nullableType,Microsoft.CodeAnalysis.SpecialMember
member)
{
var return_v = this_param.UnsafeGetNullableMethod( syntax, nullableType, member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 30295, 30383);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10532_30418_30494(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
nullableType,Microsoft.CodeAnalysis.SpecialMember
member)
{
var return_v = this_param.UnsafeGetNullableMethod( syntax, nullableType, member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 30418, 30494);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_30569_30613(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
expression)
{
var return_v = this_param.MakeNullableHasValue( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 30569, 30613);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10532_30712_30771(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = BoundCall.Synthesized( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 30712, 30771);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10532_30926_30940(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.MethodOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 30926, 30940);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10532_30877_30965(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg0)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt: receiverOpt, method, arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 30877, 30965);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
f_10532_31075_31139(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
constructor,params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
arguments)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression( syntax, constructor, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 31075, 31139);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
f_10532_31214_31254(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression( syntax, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 31214, 31254);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_31457_31779(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenConsequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenAlternative,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
isRef)
{
var return_v = RewriteConditionalOperator( syntax: syntax, rewrittenCondition: rewrittenCondition, rewrittenConsequence: rewrittenConsequence, rewrittenAlternative: rewrittenAlternative, constantValueOpt: constantValueOpt, rewrittenType: rewrittenType, isRef: isRef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 31457, 31779);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10532_32094_32115(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 32094, 32115);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10532_32059_32116(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
var return_v = ImmutableArray.Create<LocalSymbol>( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 32059, 32116);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10532_32148_32202(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 32148, 32202);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10532_31982_32279(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax: syntax, locals: locals, sideEffects: sideEffects, value: value, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 31982, 32279);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10532,28224,32291);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10532,28224,32291);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeBuiltInIncrementOperator(BoundIncrementOperator node, BoundExpression rewrittenValueToIncrement)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10532,32303,37652);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,32452,32475);

BoundExpression 
result
=default(BoundExpression);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,33296,33353);

TypeSymbol 
unaryOperandType = f_10532_33326_33352(this, node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,33539,33616);

BinaryOperatorKind 
binaryOperatorKind = f_10532_33579_33615(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,33630,33733);

binaryOperatorKind |= (DynAbs.Tracing.TraceSender.Conditional_F1(10532, 33652, 33669)||((f_10532_33652_33669(node)&&DynAbs.Tracing.TraceSender.Conditional_F2(10532, 33672, 33699))||DynAbs.Tracing.TraceSender.Conditional_F3(10532, 33702, 33732)))?BinaryOperatorKind.Addition :BinaryOperatorKind.Subtraction;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,33879,34000);

(TypeSymbol binaryOperandType, ConstantValue constantOne) = f_10532_33939_33999(_compilation, binaryOperatorKind);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,34016,34050);

f_10532_34016_34049(constantOne != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,34064,34122);

f_10532_34064_34121(f_10532_34077_34100(constantOne)!= SpecialType.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,34136,34200);

f_10532_34136_34199(f_10532_34149_34178(binaryOperandType)!= SpecialType.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,34214,34267);

f_10532_34214_34266(f_10532_34227_34260(binaryOperatorKind)!= 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,34301,34466);

BoundExpression 
boundOne = f_10532_34328_34465(this, syntax: node.Syntax, constantValue: constantOne, type: binaryOperandType)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,34482,34897) || true) && (f_10532_34486_34515(binaryOperatorKind))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,34482,34897);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,34549,34657);

binaryOperandType = f_10532_34569_34656(f_10532_34569_34627(_compilation, SpecialType.System_Nullable_T), binaryOperandType);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,34675,34790);

MethodSymbol 
ctor = f_10532_34695_34789(this, node.Syntax, binaryOperandType, SpecialMember.System_Nullable_T__ctor)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,34808,34882);

boundOne = f_10532_34819_34881(node.Syntax, ctor, boundOne);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,34482,34897);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,35018,35076);

BoundExpression 
binaryOperand = rewrittenValueToIncrement
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,35092,35138);

bool 
@checked = f_10532_35108_35137(f_10532_35108_35125(node))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,35319,35719) || true) && (f_10532_35323_35357_M(!node.OperandConversion.IsIdentity))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,35319,35719);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,35420,35704);

binaryOperand = f_10532_35436_35703(this, syntax: node.Syntax, rewrittenOperand: binaryOperand, conversion: f_10532_35585_35607(node), rewrittenType: unaryOperandType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,35319,35719);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,35841,36351) || true) && (f_10532_35845_35877(f_10532_35845_35862(node))== UnaryOperatorKind.Pointer)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,35841,36351);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,35940,36024);

f_10532_35940_36023(f_10532_35953_35986(binaryOperatorKind)== BinaryOperatorKind.PointerAndInt);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,36042,36109);

f_10532_36042_36108(f_10532_36055_36073(binaryOperand)is { TypeKind: TypeKind.Pointer });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,36127,36200);

f_10532_36127_36199(f_10532_36140_36153(boundOne)is { SpecialType: SpecialType.System_Int32 });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,36218,36336);

return f_10532_36225_36335(this, node.Syntax, binaryOperatorKind, binaryOperand, boundOne, f_10532_36302_36320(binaryOperand), method: null);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,35841,36351);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,36532,36611);

binaryOperand = f_10532_36548_36610(this, binaryOperand, binaryOperandType, @checked);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,36713,36735);

BoundExpression 
binOp
=default(BoundExpression);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,36749,37409) || true) && (f_10532_36753_36781(unaryOperandType)== SpecialType.System_Decimal)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,36749,37409);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,36845,36927);

binOp = f_10532_36853_36926(this, node.Syntax, binaryOperatorKind, binaryOperand);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,36749,37409);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,36749,37409);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,36961,37409) || true) && (f_10532_36965_36998(unaryOperandType)&&(DynAbs.Tracing.TraceSender.Expression_True(10532, 36965, 37088)&&f_10532_37002_37058(f_10532_37002_37046(unaryOperandType))== SpecialType.System_Decimal))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,36961,37409);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,37122,37210);

binOp = f_10532_37130_37209(this, node.Syntax, binaryOperatorKind, binaryOperand);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,36961,37409);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,36961,37409);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,37276,37394);

binOp = f_10532_37284_37393(this, node.Syntax, binaryOperatorKind, binaryOperand, boundOne, binaryOperandType, method: null);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,36961,37409);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,36749,37409);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,37550,37613);

result = f_10532_37559_37612(this, binOp, unaryOperandType, @checked);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,37627,37641);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10532,32303,37652);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_33326_33352(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
node)
{
var return_v = this_param.GetUnaryOperatorType( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 33326, 33352);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10532_33579_33615(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
node)
{
var return_v = GetCorrespondingBinaryOperator( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 33579, 33615);
return return_v;
}


bool
f_10532_33652_33669(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
node)
{
var return_v = IsIncrement( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 33652, 33669);
return return_v;
}


(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.ConstantValue)
f_10532_33939_33999(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
binaryOperatorKind)
{
var return_v = GetConstantOneForIncrement( compilation, binaryOperatorKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 33939, 33999);
return return_v;
}


int
f_10532_34016_34049(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 34016, 34049);
return 0;
}


Microsoft.CodeAnalysis.SpecialType
f_10532_34077_34100(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 34077, 34100);
return return_v;
}


int
f_10532_34064_34121(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 34064, 34121);
return 0;
}


Microsoft.CodeAnalysis.SpecialType
f_10532_34149_34178(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 34149, 34178);
return return_v;
}


int
f_10532_34136_34199(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 34136, 34199);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10532_34227_34260(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.OperandTypes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 34227, 34260);
return return_v;
}


int
f_10532_34214_34266(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 34214, 34266);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_34328_34465(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeLiteral( syntax: syntax, constantValue: constantValue, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 34328, 34465);
return return_v;
}


bool
f_10532_34486_34515(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.IsLifted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 34486, 34515);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10532_34569_34627(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 34569, 34627);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10532_34569_34656(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param,params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
typeArguments)
{
var return_v = this_param.Construct( typeArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 34569, 34656);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10532_34695_34789(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
nullableType,Microsoft.CodeAnalysis.SpecialMember
member)
{
var return_v = this_param.UnsafeGetNullableMethod( syntax, nullableType, member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 34695, 34789);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
f_10532_34819_34881(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
constructor,params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
arguments)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression( syntax, constructor, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 34819, 34881);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_35108_35125(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 35108, 35125);
return return_v;
}


bool
f_10532_35108_35137(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.IsChecked();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 35108, 35137);
return return_v;
}


bool
f_10532_35323_35357_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 35323, 35357);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10532_35585_35607(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.OperandConversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 35585, 35607);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_35436_35703(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( syntax: syntax, rewrittenOperand: rewrittenOperand, conversion: conversion, rewrittenType: rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 35436, 35703);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_35845_35862(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 35845, 35862);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_35845_35877(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.OperandTypes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 35845, 35877);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10532_35953_35986(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.OperandTypes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 35953, 35986);
return return_v;
}


int
f_10532_35940_36023(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 35940, 36023);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10532_36055_36073(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 36055, 36073);
return return_v;
}


int
f_10532_36042_36108(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 36042, 36108);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10532_36140_36153(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 36140, 36153);
return return_v;
}


int
f_10532_36127_36199(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 36127, 36199);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_36302_36320(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 36302, 36320);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_36225_36335(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.MakeBinaryOperator( syntax, operatorKind, loweredLeft, loweredRight, type, method: method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 36225, 36335);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_36548_36610(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( rewrittenOperand, rewrittenType, @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 36548, 36610);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10532_36753_36781(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 36753, 36781);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_36853_36926(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
oper,Microsoft.CodeAnalysis.CSharp.BoundExpression
operand)
{
var return_v = this_param.MakeDecimalIncDecOperator( syntax, oper, operand);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 36853, 36926);
return return_v;
}


bool
f_10532_36965_36998(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsNullableType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 36965, 36998);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_37002_37046(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.GetNullableUnderlyingType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 37002, 37046);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10532_37002_37058(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 37002, 37058);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_37130_37209(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
oper,Microsoft.CodeAnalysis.CSharp.BoundExpression
operand)
{
var return_v = this_param.MakeLiftedDecimalIncDecOperator( syntax, oper, operand);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 37130, 37209);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_37284_37393(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredLeft,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredRight,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
method)
{
var return_v = this_param.MakeBinaryOperator( syntax, operatorKind, loweredLeft, loweredRight, type, method: method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 37284, 37393);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_37559_37612(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( rewrittenOperand, rewrittenType, @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 37559, 37612);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10532,32303,37652);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10532,32303,37652);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private MethodSymbol GetDecimalIncDecOperator(BinaryOperatorKind oper)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10532,37664,38412);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,37759,37780);

SpecialMember 
member
=default(SpecialMember);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,37794,38179);

switch (f_10532_37802_37817(oper))
            {

case BinaryOperatorKind.Addition: DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,37794,38179);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,37885,37937);

member = SpecialMember.System_Decimal__op_Increment;
DynAbs.Tracing.TraceSender.TraceBreak(10532,37938,37944);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,37794,38179);

case BinaryOperatorKind.Subtraction: DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,37794,38179);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,37999,38051);

member = SpecialMember.System_Decimal__op_Decrement;
DynAbs.Tracing.TraceSender.TraceBreak(10532,38052,38058);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,37794,38179);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,37794,38179);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,38106,38164);

throw f_10532_38112_38163(f_10532_38147_38162(oper));
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,37794,38179);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,38195,38273);

var 
method = (MethodSymbol)f_10532_38222_38272(f_10532_38222_38243(_compilation), member)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,38287,38324);

f_10532_38287_38323((object)method != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,38387,38401);

return method;
DynAbs.Tracing.TraceSender.TraceExitMethod(10532,37664,38412);

Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10532_37802_37817(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.Operator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 37802, 37817);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10532_38147_38162(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.Operator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 38147, 38162);
return return_v;
}


System.Exception
f_10532_38112_38163(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 38112, 38163);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
f_10532_38222_38243(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 38222, 38243);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10532_38222_38272(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
this_param,Microsoft.CodeAnalysis.SpecialMember
member)
{
var return_v = this_param.GetSpecialTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 38222, 38272);
return return_v;
}


int
f_10532_38287_38323(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 38287, 38323);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10532,37664,38412);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10532,37664,38412);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeDecimalIncDecOperator(SyntaxNode syntax, BinaryOperatorKind oper, BoundExpression operand)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10532,38523,38905);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,38666,38740);

f_10532_38666_38739(f_10532_38679_38691(operand)is { SpecialType: SpecialType.System_Decimal });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,38754,38807);

MethodSymbol 
method = f_10532_38776_38806(this, oper)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,38821,38894);

return f_10532_38828_38893(syntax, receiverOpt: null, method, operand);
DynAbs.Tracing.TraceSender.TraceExitMethod(10532,38523,38905);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10532_38679_38691(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 38679, 38691);
return return_v;
}


int
f_10532_38666_38739(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 38666, 38739);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10532_38776_38806(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
oper)
{
var return_v = this_param.GetDecimalIncDecOperator( oper);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 38776, 38806);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10532_38828_38893(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg0)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt: receiverOpt, method, arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 38828, 38893);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10532,38523,38905);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10532,38523,38905);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeLiftedDecimalIncDecOperator(SyntaxNode syntax, BinaryOperatorKind oper, BoundExpression operand)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10532,38917,40621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,39066,39219);

f_10532_39066_39218(f_10532_39079_39091(operand)is { } &&(DynAbs.Tracing.TraceSender.Expression_True(10532, 39079, 39131)&&f_10532_39102_39131(f_10532_39102_39114(operand)))&&(DynAbs.Tracing.TraceSender.Expression_True(10532, 39079, 39217)&&f_10532_39135_39187(f_10532_39135_39175(f_10532_39135_39147(operand)))== SpecialType.System_Decimal));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,39349,39402);

MethodSymbol 
method = f_10532_39371_39401(this, oper)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,39416,39546);

MethodSymbol 
getValueOrDefault = f_10532_39449_39545(this, syntax, f_10532_39481_39493(operand), SpecialMember.System_Nullable_T_GetValueOrDefault)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,39560,39665);

MethodSymbol 
ctor = f_10532_39580_39664(this, syntax, f_10532_39612_39624(operand), SpecialMember.System_Nullable_T__ctor)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,39708,39774);

BoundExpression 
condition = f_10532_39736_39773(this, syntax, operand)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,39826,39915);

BoundExpression 
getValueCall = f_10532_39857_39914(syntax, operand, getValueOrDefault)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,39975,40075);

BoundExpression 
methodCall = f_10532_40004_40074(syntax, receiverOpt: null, method, getValueCall)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,40149,40239);

BoundExpression 
consequence = f_10532_40179_40238(syntax, ctor, methodCall)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,40287,40366);

BoundExpression 
alternative = f_10532_40317_40365(syntax, f_10532_40352_40364(operand))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,40475,40610);

return f_10532_40482_40609(syntax, condition, consequence, alternative, ConstantValue.NotAvailable, f_10532_40582_40594(operand), isRef: false);
DynAbs.Tracing.TraceSender.TraceExitMethod(10532,38917,40621);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10532_39079_39091(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 39079, 39091);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_39102_39114(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 39102, 39114);
return return_v;
}


bool
f_10532_39102_39131(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsNullableType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 39102, 39131);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_39135_39147(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 39135, 39147);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_39135_39175(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.GetNullableUnderlyingType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 39135, 39175);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10532_39135_39187(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 39135, 39187);
return return_v;
}


int
f_10532_39066_39218(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 39066, 39218);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10532_39371_39401(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
oper)
{
var return_v = this_param.GetDecimalIncDecOperator( oper);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 39371, 39401);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_39481_39493(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 39481, 39493);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10532_39449_39545(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
nullableType,Microsoft.CodeAnalysis.SpecialMember
member)
{
var return_v = this_param.UnsafeGetNullableMethod( syntax, nullableType, member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 39449, 39545);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_39612_39624(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 39612, 39624);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10532_39580_39664(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
nullableType,Microsoft.CodeAnalysis.SpecialMember
member)
{
var return_v = this_param.UnsafeGetNullableMethod( syntax, nullableType, member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 39580, 39664);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_39736_39773(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.MakeNullableHasValue( syntax, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 39736, 39773);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10532_39857_39914(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 39857, 39914);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10532_40004_40074(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg0)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt: receiverOpt, method, arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 40004, 40074);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
f_10532_40179_40238(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
constructor,params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
arguments)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression( syntax, constructor, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 40179, 40238);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_40352_40364(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 40352, 40364);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
f_10532_40317_40365(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression( syntax, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 40317, 40365);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_40582_40594(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 40582, 40594);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_40482_40609(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenConsequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenAlternative,Microsoft.CodeAnalysis.ConstantValue
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
isRef)
{
var return_v = RewriteConditionalOperator( syntax, rewrittenCondition, rewrittenConsequence, rewrittenAlternative, constantValueOpt, rewrittenType, isRef: isRef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 40482, 40609);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10532,38917,40621);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10532,38917,40621);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeRValue(BoundExpression transformedExpression)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10532,40944,42581);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,41042,42570);

switch (f_10532_41050_41076(transformedExpression))
            {

case BoundKind.PropertyAccess:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,41042,42570);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,41162,41226);

var 
propertyAccess = (BoundPropertyAccess)transformedExpression
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,41248,41382);

return f_10532_41255_41381(this, transformedExpression.Syntax, f_10532_41307_41333(propertyAccess), f_10532_41335_41364(propertyAccess), propertyAccess);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,41042,42570);

case BoundKind.DynamicMemberAccess:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,41042,42570);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,41459,41533);

var 
dynamicMemberAccess = (BoundDynamicMemberAccess)transformedExpression
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,41555,41692);

return f_10532_41562_41676(_dynamicFactory, f_10532_41599_41627(dynamicMemberAccess), f_10532_41629_41653(dynamicMemberAccess), resultIndexed: false).ToExpression();
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,41042,42570);

case BoundKind.IndexerAccess:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,41042,42570);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,41763,41825);

var 
indexerAccess = (BoundIndexerAccess)transformedExpression
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,41847,41981);

return f_10532_41854_41980(this, transformedExpression.Syntax, f_10532_41906_41931(indexerAccess), f_10532_41933_41954(indexerAccess), f_10532_41956_41979(indexerAccess));
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,41042,42570);

case BoundKind.DynamicIndexerAccess:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,41042,42570);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,42059,42135);

var 
dynamicIndexerAccess = (BoundDynamicIndexerAccess)transformedExpression
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,42157,42476);

return f_10532_42164_42475(this, dynamicIndexerAccess, f_10532_42257_42286(dynamicIndexerAccess), f_10532_42313_42343(dynamicIndexerAccess), f_10532_42370_42407(dynamicIndexerAccess), f_10532_42434_42474(dynamicIndexerAccess));
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,41042,42570);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,41042,42570);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,42526,42555);

return transformedExpression;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,41042,42570);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(10532,40944,42581);

Microsoft.CodeAnalysis.CSharp.BoundKind
f_10532_41050_41076(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 41050, 41076);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10532_41307_41333(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
this_param)
{
var return_v = this_param.ReceiverOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 41307, 41333);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
f_10532_41335_41364(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
this_param)
{
var return_v = this_param.PropertySymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 41335, 41364);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_41255_41381(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
rewrittenReceiver,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
property,Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
oldNodeOpt)
{
var return_v = this_param.MakePropertyGetAccess( syntax, rewrittenReceiver, property, oldNodeOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 41255, 41381);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_41599_41627(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
this_param)
{
var return_v = this_param.Receiver;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 41599, 41627);
return return_v;
}


string
f_10532_41629_41653(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 41629, 41653);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
f_10532_41562_41676(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredReceiver,string
name,bool
resultIndexed)
{
var return_v = this_param.MakeDynamicGetMember( loweredReceiver, name, resultIndexed: resultIndexed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 41562, 41676);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10532_41906_41931(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.ReceiverOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 41906, 41931);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
f_10532_41933_41954(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.Indexer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 41933, 41954);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10532_41956_41979(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 41956, 41979);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_41854_41980(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
rewrittenReceiver,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
property,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments)
{
var return_v = this_param.MakePropertyGetAccess( syntax, rewrittenReceiver, property, rewrittenArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 41854, 41980);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_42257_42286(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.Receiver;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 42257, 42286);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10532_42313_42343(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 42313, 42343);
return return_v;
}


System.Collections.Immutable.ImmutableArray<string>
f_10532_42370_42407(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.ArgumentNamesOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 42370, 42407);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
f_10532_42434_42474(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.ArgumentRefKindsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 42434, 42474);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10532_42164_42475(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
node,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredReceiver,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
loweredArguments,System.Collections.Immutable.ImmutableArray<string>
argumentNames,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
refKinds)
{
var return_v = this_param.MakeDynamicGetIndex( node, loweredReceiver, loweredArguments, argumentNames, refKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 42164, 42475);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10532,40944,42581);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10532,40944,42581);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private TypeSymbol GetUnaryOperatorType(BoundIncrementOperator node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10532,43097,46158);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,43190,43248);

UnaryOperatorKind 
kind = f_10532_43215_43247(f_10532_43215_43232(node))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,43472,43572) || true) && (kind == UnaryOperatorKind.Enum)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,43472,43572);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,43540,43557);

return f_10532_43547_43556(node);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,43472,43572);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,43588,43612);

SpecialType 
specialType
=default(SpecialType);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,43628,45862);

switch (kind)
            {

case UnaryOperatorKind.Int:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,43628,45862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,43723,43762);

specialType = SpecialType.System_Int32;
DynAbs.Tracing.TraceSender.TraceBreak(10532,43784,43790);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,43628,45862);

case UnaryOperatorKind.SByte:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,43628,45862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,43859,43898);

specialType = SpecialType.System_SByte;
DynAbs.Tracing.TraceSender.TraceBreak(10532,43920,43926);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,43628,45862);

case UnaryOperatorKind.Short:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,43628,45862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,43995,44034);

specialType = SpecialType.System_Int16;
DynAbs.Tracing.TraceSender.TraceBreak(10532,44056,44062);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,43628,45862);

case UnaryOperatorKind.Byte:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,43628,45862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,44130,44168);

specialType = SpecialType.System_Byte;
DynAbs.Tracing.TraceSender.TraceBreak(10532,44190,44196);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,43628,45862);

case UnaryOperatorKind.UShort:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,43628,45862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,44266,44306);

specialType = SpecialType.System_UInt16;
DynAbs.Tracing.TraceSender.TraceBreak(10532,44328,44334);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,43628,45862);

case UnaryOperatorKind.Char:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,43628,45862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,44402,44440);

specialType = SpecialType.System_Char;
DynAbs.Tracing.TraceSender.TraceBreak(10532,44462,44468);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,43628,45862);

case UnaryOperatorKind.UInt:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,43628,45862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,44536,44576);

specialType = SpecialType.System_UInt32;
DynAbs.Tracing.TraceSender.TraceBreak(10532,44598,44604);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,43628,45862);

case UnaryOperatorKind.Long:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,43628,45862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,44672,44711);

specialType = SpecialType.System_Int64;
DynAbs.Tracing.TraceSender.TraceBreak(10532,44733,44739);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,43628,45862);

case UnaryOperatorKind.ULong:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,43628,45862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,44808,44848);

specialType = SpecialType.System_UInt64;
DynAbs.Tracing.TraceSender.TraceBreak(10532,44870,44876);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,43628,45862);

case UnaryOperatorKind.NInt:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,43628,45862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,44944,44984);

specialType = SpecialType.System_IntPtr;
DynAbs.Tracing.TraceSender.TraceBreak(10532,45006,45012);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,43628,45862);

case UnaryOperatorKind.NUInt:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,43628,45862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,45081,45122);

specialType = SpecialType.System_UIntPtr;
DynAbs.Tracing.TraceSender.TraceBreak(10532,45144,45150);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,43628,45862);

case UnaryOperatorKind.Float:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,43628,45862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,45219,45259);

specialType = SpecialType.System_Single;
DynAbs.Tracing.TraceSender.TraceBreak(10532,45281,45287);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,43628,45862);

case UnaryOperatorKind.Double:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,43628,45862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,45357,45397);

specialType = SpecialType.System_Double;
DynAbs.Tracing.TraceSender.TraceBreak(10532,45419,45425);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,43628,45862);

case UnaryOperatorKind.Decimal:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,43628,45862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,45496,45537);

specialType = SpecialType.System_Decimal;
DynAbs.Tracing.TraceSender.TraceBreak(10532,45559,45565);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,43628,45862);

case UnaryOperatorKind.Pointer:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,43628,45862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,45636,45653);

return f_10532_45643_45652(node);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,43628,45862);

case UnaryOperatorKind.UserDefined:
                case UnaryOperatorKind.Bool:
                default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,43628,45862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,45800,45847);

throw f_10532_45806_45846(kind);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,43628,45862);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,45878,45942);

NamedTypeSymbol 
type = f_10532_45901_45941(_compilation, specialType)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,45956,46119) || true) && (f_10532_45960_45988(f_10532_45960_45977(node)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,45956,46119);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,46022,46104);

type = f_10532_46029_46103(f_10532_46029_46087(_compilation, SpecialType.System_Nullable_T), type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,45956,46119);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,46135,46147);

return type;
DynAbs.Tracing.TraceSender.TraceExitMethod(10532,43097,46158);

Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_43215_43232(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 43215, 43232);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_43215_43247(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.OperandTypes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 43215, 43247);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_43547_43556(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 43547, 43556);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_45643_45652(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 45643, 45652);
return return_v;
}


System.Exception
f_10532_45806_45846(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 45806, 45846);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10532_45901_45941(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 45901, 45941);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_45960_45977(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 45960, 45977);
return return_v;
}


bool
f_10532_45960_45988(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.IsLifted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 45960, 45988);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10532_46029_46087(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 46029, 46087);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10532_46029_46103(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param,params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
typeArguments)
{
var return_v = this_param.Construct( typeArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 46029, 46103);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10532,43097,46158);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10532,43097,46158);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static BinaryOperatorKind GetCorrespondingBinaryOperator(BoundIncrementOperator node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10532,46170,51412);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,46660,46716);

UnaryOperatorKind 
unaryOperatorKind = f_10532_46698_46715(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,46730,46756);

BinaryOperatorKind 
result
=default(BinaryOperatorKind);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,46772,50723);

switch (f_10532_46780_46812(unaryOperatorKind))
            {

case UnaryOperatorKind.Int:
                case UnaryOperatorKind.SByte:
                case UnaryOperatorKind.Short:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,46772,50723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,46989,47021);

result = BinaryOperatorKind.Int;
DynAbs.Tracing.TraceSender.TraceBreak(10532,47043,47049);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,46772,50723);

case UnaryOperatorKind.Byte:
                case UnaryOperatorKind.UShort:
                case UnaryOperatorKind.Char:
                case UnaryOperatorKind.UInt:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,46772,50723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,47257,47290);

result = BinaryOperatorKind.UInt;
DynAbs.Tracing.TraceSender.TraceBreak(10532,47312,47318);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,46772,50723);

case UnaryOperatorKind.Long:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,46772,50723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,47386,47419);

result = BinaryOperatorKind.Long;
DynAbs.Tracing.TraceSender.TraceBreak(10532,47441,47447);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,46772,50723);

case UnaryOperatorKind.ULong:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,46772,50723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,47516,47550);

result = BinaryOperatorKind.ULong;
DynAbs.Tracing.TraceSender.TraceBreak(10532,47572,47578);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,46772,50723);

case UnaryOperatorKind.NInt:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,46772,50723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,47646,47679);

result = BinaryOperatorKind.NInt;
DynAbs.Tracing.TraceSender.TraceBreak(10532,47701,47707);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,46772,50723);

case UnaryOperatorKind.NUInt:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,46772,50723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,47776,47810);

result = BinaryOperatorKind.NUInt;
DynAbs.Tracing.TraceSender.TraceBreak(10532,47832,47838);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,46772,50723);

case UnaryOperatorKind.Float:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,46772,50723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,47907,47941);

result = BinaryOperatorKind.Float;
DynAbs.Tracing.TraceSender.TraceBreak(10532,47963,47969);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,46772,50723);

case UnaryOperatorKind.Double:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,46772,50723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,48039,48074);

result = BinaryOperatorKind.Double;
DynAbs.Tracing.TraceSender.TraceBreak(10532,48096,48102);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,46772,50723);

case UnaryOperatorKind.Decimal: //Dev10 special cased this, but we'll let DecimalRewriter handle it
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,46772,50723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,48241,48277);

result = BinaryOperatorKind.Decimal;
DynAbs.Tracing.TraceSender.TraceBreak(10532,48299,48305);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,46772,50723);

case UnaryOperatorKind.Enum:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,46772,50723);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,48400,48439);

TypeSymbol? 
underlyingType = f_10532_48429_48438(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,48465,48501);

f_10532_48465_48500(underlyingType is { });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,48527,48707) || true) && (f_10532_48531_48562(underlyingType))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,48527,48707);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,48620,48680);

underlyingType = f_10532_48637_48679(underlyingType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,48527,48707);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,48733,48775);

f_10532_48733_48774(f_10532_48746_48773(underlyingType));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,48801,48857);

underlyingType = f_10532_48818_48856(underlyingType);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,48883,48919);

f_10532_48883_48918(underlyingType is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,49154,50294);

switch (f_10532_49162_49188(underlyingType))
                        {

case SpecialType.System_SByte:
                            case SpecialType.System_Int16:
                            case SpecialType.System_Int32:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,49154,50294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,49430,49462);

result = BinaryOperatorKind.Int;
DynAbs.Tracing.TraceSender.TraceBreak(10532,49496,49502);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,49154,50294);

case SpecialType.System_Byte:
                            case SpecialType.System_UInt16:
                            case SpecialType.System_UInt32:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,49154,50294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,49717,49750);

result = BinaryOperatorKind.UInt;
DynAbs.Tracing.TraceSender.TraceBreak(10532,49784,49790);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,49154,50294);

case SpecialType.System_Int64:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,49154,50294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,49884,49917);

result = BinaryOperatorKind.Long;
DynAbs.Tracing.TraceSender.TraceBreak(10532,49951,49957);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,49154,50294);

case SpecialType.System_UInt64:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,49154,50294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,50052,50086);

result = BinaryOperatorKind.ULong;
DynAbs.Tracing.TraceSender.TraceBreak(10532,50120,50126);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,49154,50294);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,49154,50294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,50198,50267);

throw f_10532_50204_50266(f_10532_50239_50265(underlyingType));
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,49154,50294);
                        }
                    }
DynAbs.Tracing.TraceSender.TraceBreak(10532,50339,50345);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,46772,50723);

case UnaryOperatorKind.Pointer:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,46772,50723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,50416,50458);

result = BinaryOperatorKind.PointerAndInt;
DynAbs.Tracing.TraceSender.TraceBreak(10532,50480,50486);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,46772,50723);

case UnaryOperatorKind.UserDefined:
                case UnaryOperatorKind.Bool:
                default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,46772,50723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,50633,50708);

throw f_10532_50639_50707(f_10532_50674_50706(unaryOperatorKind));
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,46772,50723);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,50739,51238);

switch (result)
            {

case BinaryOperatorKind.UInt:
                case BinaryOperatorKind.Int:
                case BinaryOperatorKind.ULong:
                case BinaryOperatorKind.Long:
                case BinaryOperatorKind.NUInt:
                case BinaryOperatorKind.NInt:
                case BinaryOperatorKind.PointerAndInt:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,50739,51238);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,51130,51195);

result |= (BinaryOperatorKind)f_10532_51160_51194(unaryOperatorKind);
DynAbs.Tracing.TraceSender.TraceBreak(10532,51217,51223);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,50739,51238);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,51254,51371) || true) && (f_10532_51258_51286(unaryOperatorKind))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,51254,51371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,51320,51356);

result |= BinaryOperatorKind.Lifted;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,51254,51371);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,51387,51401);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10532,46170,51412);

Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_46698_46715(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.OperatorKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 46698, 46715);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_46780_46812(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.OperandTypes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 46780, 46812);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_48429_48438(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 48429, 48438);
return return_v;
}


int
f_10532_48465_48500(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 48465, 48500);
return 0;
}


bool
f_10532_48531_48562(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsNullableType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 48531, 48562);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10532_48637_48679(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.GetNullableUnderlyingType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 48637, 48679);
return return_v;
}


bool
f_10532_48746_48773(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsEnumType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 48746, 48773);
return return_v;
}


int
f_10532_48733_48774(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 48733, 48774);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
f_10532_48818_48856(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.GetEnumUnderlyingType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 48818, 48856);
return return_v;
}


int
f_10532_48883_48918(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 48883, 48918);
return 0;
}


Microsoft.CodeAnalysis.SpecialType
f_10532_49162_49188(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 49162, 49188);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10532_50239_50265(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 50239, 50265);
return return_v;
}


System.Exception
f_10532_50204_50266(Microsoft.CodeAnalysis.SpecialType
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 50204, 50266);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_50674_50706(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.OperandTypes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 50674, 50706);
return return_v;
}


System.Exception
f_10532_50639_50707(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 50639, 50707);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
f_10532_51160_51194(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.OverflowChecks();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 51160, 51194);
return return_v;
}


bool
f_10532_51258_51286(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
kind)
{
var return_v = kind.IsLifted();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 51258, 51286);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10532,46170,51412);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10532,46170,51412);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static (TypeSymbol, ConstantValue) GetConstantOneForIncrement(
            CSharpCompilation compilation,
            BinaryOperatorKind binaryOperatorKind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10532,51424,53382);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,51615,51641);

ConstantValue 
constantOne
=default(ConstantValue);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,51655,53283);

switch (f_10532_51663_51696(binaryOperatorKind))
            {

case BinaryOperatorKind.PointerAndInt:
                case BinaryOperatorKind.Int:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,51655,53283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,51836,51874);

constantOne = f_10532_51850_51873(1);
DynAbs.Tracing.TraceSender.TraceBreak(10532,51896,51902);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,51655,53283);

case BinaryOperatorKind.UInt:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,51655,53283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,51971,52010);

constantOne = f_10532_51985_52009(1U);
DynAbs.Tracing.TraceSender.TraceBreak(10532,52032,52038);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,51655,53283);

case BinaryOperatorKind.Long:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,51655,53283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,52107,52146);

constantOne = f_10532_52121_52145(1L);
DynAbs.Tracing.TraceSender.TraceBreak(10532,52168,52174);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,51655,53283);

case BinaryOperatorKind.ULong:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,51655,53283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,52244,52284);

constantOne = f_10532_52258_52283(1LU);
DynAbs.Tracing.TraceSender.TraceBreak(10532,52306,52312);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,51655,53283);

case BinaryOperatorKind.NInt:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,51655,53283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,52381,52419);

constantOne = f_10532_52395_52418(1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,52441,52519);

return (f_10532_52449_52504(compilation, signed: true), constantOne);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,51655,53283);

case BinaryOperatorKind.NUInt:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,51655,53283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,52589,52628);

constantOne = f_10532_52603_52627(1U);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,52650,52729);

return (f_10532_52658_52714(compilation, signed: false), constantOne);
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,51655,53283);

case BinaryOperatorKind.Float:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,51655,53283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,52799,52838);

constantOne = f_10532_52813_52837(1f);
DynAbs.Tracing.TraceSender.TraceBreak(10532,52860,52866);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,51655,53283);

case BinaryOperatorKind.Double:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,51655,53283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,52937,52977);

constantOne = f_10532_52951_52976(1.0);
DynAbs.Tracing.TraceSender.TraceBreak(10532,52999,53005);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,51655,53283);

case BinaryOperatorKind.Decimal:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,51655,53283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,53077,53116);

constantOne = f_10532_53091_53115(1m);
DynAbs.Tracing.TraceSender.TraceBreak(10532,53138,53144);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,51655,53283);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10532,51655,53283);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,53192,53268);

throw f_10532_53198_53267(f_10532_53233_53266(binaryOperatorKind));
DynAbs.Tracing.TraceSender.TraceExitCondition(10532,51655,53283);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10532,53297,53371);

return (f_10532_53305_53356(compilation, f_10532_53332_53355(constantOne)), constantOne);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10532,51424,53382);

Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10532_51663_51696(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.OperandTypes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 51663, 51696);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10532_51850_51873(int
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 51850, 51873);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10532_51985_52009(uint
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 51985, 52009);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10532_52121_52145(long
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 52121, 52145);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10532_52258_52283(ulong
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 52258, 52283);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10532_52395_52418(int
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 52395, 52418);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10532_52449_52504(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,bool
signed)
{
var return_v = this_param.CreateNativeIntegerTypeSymbol( signed: signed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 52449, 52504);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10532_52603_52627(uint
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 52603, 52627);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10532_52658_52714(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,bool
signed)
{
var return_v = this_param.CreateNativeIntegerTypeSymbol( signed: signed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 52658, 52714);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10532_52813_52837(float
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 52813, 52837);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10532_52951_52976(double
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 52951, 52976);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10532_53091_53115(decimal
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 53091, 53115);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
f_10532_53233_53266(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind)
{
var return_v = kind.OperandTypes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 53233, 53266);
return return_v;
}


System.Exception
f_10532_53198_53267(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 53198, 53267);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10532_53332_53355(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.SpecialType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10532, 53332, 53355);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10532_53305_53356(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10532, 53305, 53356);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10532,51424,53382);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10532,51424,53382);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
