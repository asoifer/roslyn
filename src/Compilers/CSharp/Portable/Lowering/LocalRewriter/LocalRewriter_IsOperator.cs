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
public override BoundNode VisitIsOperator(BoundIsOperator node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10506,509,961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,597,662);

BoundExpression 
rewrittenOperand = f_10506_632_661(this, f_10506_648_660(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,676,760);

var 
rewrittenTargetType = (BoundTypeExpression)f_10506_723_759(this, f_10506_743_758(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,774,822);

TypeSymbol 
rewrittenType = f_10506_801_821(this, f_10506_811_820(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,838,950);

return f_10506_845_949(this, node, node.Syntax, rewrittenOperand, rewrittenTargetType, f_10506_918_933(node), rewrittenType);
DynAbs.Tracing.TraceSender.TraceExitMethod(10506,509,961);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10506_648_660(Microsoft.CodeAnalysis.CSharp.BoundIsOperator
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10506, 648, 660);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10506_632_661(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10506, 632, 661);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
f_10506_743_758(Microsoft.CodeAnalysis.CSharp.BoundIsOperator
this_param)
{
var return_v = this_param.TargetType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10506, 743, 758);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode
f_10506_723_759(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
node)
{
var return_v = this_param.VisitTypeExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10506, 723, 759);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10506_811_820(Microsoft.CodeAnalysis.CSharp.BoundIsOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10506, 811, 820);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10506_801_821(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.VisitType( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10506, 801, 821);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10506_918_933(Microsoft.CodeAnalysis.CSharp.BoundIsOperator
this_param)
{
var return_v = this_param.Conversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10506, 918, 933);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10506_845_949(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundIsOperator
oldNode,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
rewrittenTargetType,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType)
{
var return_v = this_param.MakeIsOperator( oldNode, syntax, rewrittenOperand, rewrittenTargetType, conversion, rewrittenType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10506, 845, 949);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10506,509,961);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10506,509,961);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeIsOperator(
            BoundIsOperator oldNode,
            SyntaxNode syntax,
            BoundExpression rewrittenOperand,
            BoundTypeExpression rewrittenTargetType,
            Conversion conversion,
            TypeSymbol rewrittenType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10506,973,3147);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,1283,1934) || true) && (f_10506_1287_1308(rewrittenOperand)== BoundKind.MethodGroup)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10506,1283,1934);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,1367,1420);

var 
methodGroup = (BoundMethodGroup)rewrittenOperand
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,1438,1490);

BoundExpression? 
receiver = f_10506_1466_1489(methodGroup)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,1508,1919) || true) && (receiver != null &&(DynAbs.Tracing.TraceSender.Expression_True(10506, 1512, 1572)&&f_10506_1532_1545(receiver)!= BoundKind.ThisReference))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10506,1508,1919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,1659,1755);

return f_10506_1666_1754(this, receiver.Syntax, receiver, f_10506_1719_1738(), rewrittenType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10506,1508,1919);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10506,1508,1919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,1837,1900);

return f_10506_1844_1899(this, syntax, f_10506_1864_1883(), rewrittenType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10506,1508,1919);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10506,1283,1934);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,1950,1990);

var 
operandType = f_10506_1968_1989(rewrittenOperand)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,2004,2046);

var 
targetType = f_10506_2021_2045(rewrittenTargetType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,2062,2137);

f_10506_2062_2136(operandType is { } ||(DynAbs.Tracing.TraceSender.Expression_False(10506, 2075, 2135)||f_10506_2097_2135(rewrittenOperand.ConstantValue!)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,2151,2183);

f_10506_2151_2182(targetType is { });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,2267,3032) || true) && (!_inExpressionLambda)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10506,2267,3032);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,2325,2464);

ConstantValue 
constantValue = f_10506_2355_2463(operandType, targetType, conversion.Kind, f_10506_2432_2462(rewrittenOperand))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,2484,3017) || true) && (constantValue != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10506,2484,3017);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,2551,2640);

return f_10506_2558_2639(this, syntax, rewrittenOperand, constantValue, rewrittenType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10506,2484,3017);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10506,2484,3017);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,2682,3017) || true) && (conversion.IsImplicit)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10506,2682,3017);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,2922,2998);

return f_10506_2929_2997(this, syntax, rewrittenOperand, BinaryOperatorKind.NotEqual);
DynAbs.Tracing.TraceSender.TraceExitCondition(10506,2682,3017);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10506,2484,3017);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10506,2267,3032);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,3048,3136);

return f_10506_3055_3135(oldNode, rewrittenOperand, rewrittenTargetType, conversion, rewrittenType);
DynAbs.Tracing.TraceSender.TraceExitMethod(10506,973,3147);

Microsoft.CodeAnalysis.CSharp.BoundKind
f_10506_1287_1308(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10506, 1287, 1308);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10506_1466_1489(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
this_param)
{
var return_v = this_param.ReceiverOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10506, 1466, 1489);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10506_1532_1545(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10506, 1532, 1545);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10506_1719_1738()
{
var return_v = ConstantValue.False;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10506, 1719, 1738);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10506_1666_1754(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredOperand,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.RewriteConstantIsOperator( syntax, loweredOperand, constantValue, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10506, 1666, 1754);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10506_1864_1883()
{
var return_v = ConstantValue.False;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10506, 1864, 1883);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10506_1844_1899(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeLiteral( syntax, constantValue, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10506, 1844, 1899);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10506_1968_1989(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10506, 1968, 1989);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10506_2021_2045(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10506, 2021, 2045);
return return_v;
}


bool
f_10506_2097_2135(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.IsNull;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10506, 2097, 2135);
return return_v;
}


int
f_10506_2062_2136(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10506, 2062, 2136);
return 0;
}


int
f_10506_2151_2182(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10506, 2151, 2182);
return 0;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10506_2432_2462(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10506, 2432, 2462);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10506_2355_2463(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
operandType,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
targetType,Microsoft.CodeAnalysis.CSharp.ConversionKind
conversionKind,Microsoft.CodeAnalysis.ConstantValue?
operandConstantValue)
{
var return_v = Binder.GetIsOperatorConstantResult( operandType, targetType, conversionKind, operandConstantValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10506, 2355, 2463);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10506_2558_2639(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredOperand,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.RewriteConstantIsOperator( syntax, loweredOperand, constantValue, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10506, 2558, 2639);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10506_2929_2997(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenExpr,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind)
{
var return_v = this_param.MakeNullCheck( syntax, rewrittenExpr, operatorKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10506, 2929, 2997);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundIsOperator
f_10506_3055_3135(Microsoft.CodeAnalysis.CSharp.BoundIsOperator
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
operand,Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
targetType,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Update( operand, targetType, conversion, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10506, 3055, 3135);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10506,973,3147);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10506,973,3147);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression RewriteConstantIsOperator(
            SyntaxNode syntax,
            BoundExpression loweredOperand,
            ConstantValue constantValue,
            TypeSymbol type)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10506,3159,3849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,3383,3473);

f_10506_3383_3472(constantValue == f_10506_3413_3431()||(DynAbs.Tracing.TraceSender.Expression_False(10506, 3396, 3471)||constantValue == f_10506_3452_3471()));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,3487,3522);

f_10506_3487_3521((object)type != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10506,3538,3838);

return f_10506_3545_3837(syntax: syntax, locals: ImmutableArray<LocalSymbol>.Empty, sideEffects: f_10506_3687_3741(loweredOperand), value: f_10506_3767_3807(this, syntax, constantValue, type), type: type);
DynAbs.Tracing.TraceSender.TraceExitMethod(10506,3159,3849);

Microsoft.CodeAnalysis.ConstantValue
f_10506_3413_3431()
{
var return_v = ConstantValue.True ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10506, 3413, 3431);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10506_3452_3471()
{
var return_v = ConstantValue.False;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10506, 3452, 3471);
return return_v;
}


int
f_10506_3383_3472(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10506, 3383, 3472);
return 0;
}


int
f_10506_3487_3521(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10506, 3487, 3521);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10506_3687_3741(Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10506, 3687, 3741);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10506_3767_3807(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeLiteral( syntax, constantValue, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10506, 3767, 3807);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10506_3545_3837(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax: syntax, locals: locals, sideEffects: sideEffects, value: value, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10506, 3545, 3837);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10506,3159,3849);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10506,3159,3849);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
