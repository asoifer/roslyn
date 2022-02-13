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
public override BoundNode VisitAsOperator(BoundAsOperator node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10478,509,961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10478,597,662);

BoundExpression 
rewrittenOperand = f_10478_632_661(this, f_10478_648_660(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10478,676,760);

var 
rewrittenTargetType = (BoundTypeExpression)f_10478_723_759(this, f_10478_743_758(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10478,774,822);

TypeSymbol 
rewrittenType = f_10478_801_821(this, f_10478_811_820(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10478,838,950);

return f_10478_845_949(this, node, node.Syntax, rewrittenOperand, rewrittenTargetType, f_10478_918_933(node), rewrittenType);
DynAbs.Tracing.TraceSender.TraceExitMethod(10478,509,961);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10478_648_660(Microsoft.CodeAnalysis.CSharp.BoundAsOperator
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10478, 648, 660);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10478_632_661(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10478, 632, 661);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
f_10478_743_758(Microsoft.CodeAnalysis.CSharp.BoundAsOperator
this_param)
{
var return_v = this_param.TargetType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10478, 743, 758);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode
f_10478_723_759(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
node)
{
var return_v = this_param.VisitTypeExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10478, 723, 759);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10478_811_820(Microsoft.CodeAnalysis.CSharp.BoundAsOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10478, 811, 820);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10478_801_821(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.VisitType( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10478, 801, 821);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10478_918_933(Microsoft.CodeAnalysis.CSharp.BoundAsOperator
this_param)
{
var return_v = this_param.Conversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10478, 918, 933);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10478_845_949(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundAsOperator
oldNode,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
rewrittenTargetType,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType)
{
var return_v = this_param.MakeAsOperator( oldNode, syntax, rewrittenOperand, rewrittenTargetType, conversion, rewrittenType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10478, 845, 949);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10478,509,961);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10478,509,961);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode VisitTypeExpression(BoundTypeExpression node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10478,973,1194);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10478,1069,1113);

var 
result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitTypeExpression(node),10478,1082,1112)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10478,1127,1155);

f_10478_1127_1154(result is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10478,1169,1183);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10478,973,1194);

int
f_10478_1127_1154(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10478, 1127, 1154);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10478,973,1194);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10478,973,1194);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeAsOperator(
            BoundAsOperator oldNode,
            SyntaxNode syntax,
            BoundExpression rewrittenOperand,
            BoundTypeExpression rewrittenTargetType,
            Conversion conversion,
            TypeSymbol rewrittenType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10478,1206,3596);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10478,1582,1643);

f_10478_1582_1642(f_10478_1595_1641(f_10478_1595_1619(rewrittenTargetType), rewrittenType));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10478,1723,1798);

f_10478_1723_1797(f_10478_1736_1762_M(!rewrittenType.IsValueType)||(DynAbs.Tracing.TraceSender.Expression_False(10478, 1736, 1796)||f_10478_1766_1796(rewrittenType)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10478,1814,3481) || true) && (!_inExpressionLambda)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10478,1814,3481);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10478,1872,2024);

ConstantValue 
constantValue = f_10478_1902_2023(f_10478_1937_1958(rewrittenOperand), rewrittenType, conversion.Kind, f_10478_1992_2022(rewrittenOperand))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10478,2044,3083) || true) && (constantValue != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10478,2044,3083);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10478,2111,2146);

f_10478_2111_2145(f_10478_2124_2144(constantValue));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10478,2168,2328);

BoundExpression 
result = (DynAbs.Tracing.TraceSender.Conditional_F1(10478, 2193, 2223)||((f_10478_2193_2223(rewrittenType)&&DynAbs.Tracing.TraceSender.Conditional_F2(10478, 2226, 2275))||DynAbs.Tracing.TraceSender.Conditional_F3(10478, 2278, 2327)))?f_10478_2226_2275(syntax, rewrittenType):f_10478_2278_2327(this, syntax, constantValue, rewrittenType)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10478,2352,2723) || true) && (f_10478_2356_2386(rewrittenOperand)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10478,2352,2723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10478,2686,2700);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(10478,2352,2723);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10478,2747,3064);

return f_10478_2754_3063(syntax: syntax, locals: ImmutableArray<LocalSymbol>.Empty, sideEffects: f_10478_2920_2976(rewrittenOperand), value: result, type: rewrittenType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10478,2044,3083);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10478,3103,3466) || true) && (conversion.IsImplicit)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10478,3103,3466);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10478,3351,3447);

return f_10478_3358_3446(this, syntax, rewrittenOperand, conversion, rewrittenType, @checked: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10478,3103,3466);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10478,1814,3481);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10478,3497,3585);

return f_10478_3504_3584(oldNode, rewrittenOperand, rewrittenTargetType, conversion, rewrittenType);
DynAbs.Tracing.TraceSender.TraceExitMethod(10478,1206,3596);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10478_1595_1619(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10478, 1595, 1619);
return return_v;
}


bool
f_10478_1595_1641(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
obj)
{
var return_v = this_param.Equals( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10478, 1595, 1641);
return return_v;
}


int
f_10478_1582_1642(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10478, 1582, 1642);
return 0;
}


bool
f_10478_1736_1762_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10478, 1736, 1762);
return return_v;
}


bool
f_10478_1766_1796(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsNullableType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10478, 1766, 1796);
return return_v;
}


int
f_10478_1723_1797(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10478, 1723, 1797);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10478_1937_1958(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10478, 1937, 1958);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10478_1992_2022(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10478, 1992, 2022);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10478_1902_2023(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
operandType,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
targetType,Microsoft.CodeAnalysis.CSharp.ConversionKind
conversionKind,Microsoft.CodeAnalysis.ConstantValue?
operandConstantValue)
{
var return_v = Binder.GetAsOperatorConstantResult( operandType, targetType, conversionKind, operandConstantValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10478, 1902, 2023);
return return_v;
}


bool
f_10478_2124_2144(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.IsNull;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10478, 2124, 2144);
return return_v;
}


int
f_10478_2111_2145(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10478, 2111, 2145);
return 0;
}


bool
f_10478_2193_2223(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsNullableType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10478, 2193, 2223);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
f_10478_2226_2275(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression( syntax, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10478, 2226, 2275);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10478_2278_2327(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeLiteral( syntax, constantValue, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10478, 2278, 2327);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10478_2356_2386(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10478, 2356, 2386);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10478_2920_2976(Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10478, 2920, 2976);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10478_2754_3063(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax: syntax, locals: locals, sideEffects: sideEffects, value: value, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10478, 2754, 3063);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10478_3358_3446(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( syntax, rewrittenOperand, conversion, rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10478, 3358, 3446);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAsOperator
f_10478_3504_3584(Microsoft.CodeAnalysis.CSharp.BoundAsOperator
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
operand,Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
targetType,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Update( operand, targetType, conversion, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10478, 3504, 3584);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10478,1206,3596);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10478,1206,3596);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
