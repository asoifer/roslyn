// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitFromEndIndexExpression(BoundFromEndIndexExpression node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10504,436,3352);
Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol nullableCtor = default(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10504,548,585);

f_10504_548_584(f_10504_561_575(node)!= null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10504,601,687);

NamedTypeSymbol 
booleanType = f_10504_631_686(_compilation, SpecialType.System_Boolean)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10504,701,793);

BoundExpression 
fromEnd = f_10504_727_792(this, node.Syntax, f_10504_752_778(true), booleanType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10504,809,865);

BoundExpression 
operand = f_10504_835_864(this, f_10504_851_863(node))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10504,881,1060) || true) && (f_10504_885_915(operand))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10504,881,1060);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10504,949,1045);

operand = f_10504_959_1044(operand.Syntax, f_10504_1002_1043(operand.Type!));
DynAbs.Tracing.TraceSender.TraceExitCondition(10504,881,1060);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10504,1076,1129);

operand = f_10504_1086_1117(operand)??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10504, 1086, 1128)??operand);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10504,1145,1313) || true) && (!f_10504_1150_1176(f_10504_1150_1159(node)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10504,1145,1313);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10504,1210,1298);

return f_10504_1217_1297(node.Syntax, f_10504_1264_1278(node), operand, fromEnd);
DynAbs.Tracing.TraceSender.TraceExitCondition(10504,1145,1313);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10504,1329,1417);

ArrayBuilder<BoundExpression> 
sideeffects = f_10504_1373_1416()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10504,1431,1506);

ArrayBuilder<LocalSymbol> 
locals = f_10504_1466_1505()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10504,1555,1627);

operand = f_10504_1565_1626(this, operand, sideeffects, locals);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10504,1641,1716);

BoundExpression 
condition = f_10504_1669_1715(this, operand.Syntax, operand)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10504,1782,1886);

BoundExpression 
boundOperandGetValueOrDefault = f_10504_1830_1885(this, operand.Syntax, operand)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10504,1900,2035);

BoundExpression 
indexCreation = f_10504_1932_2034(node.Syntax, f_10504_1979_1993(node), boundOperandGetValueOrDefault, fromEnd)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10504,2051,2273) || true) && (!f_10504_2056_2170(this, node.Syntax, f_10504_2090_2099(node), SpecialMember.System_Nullable_T__ctor, out nullableCtor))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10504,2051,2273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10504,2204,2258);

return f_10504_2211_2257(node.Syntax, f_10504_2238_2247(node), operand);
DynAbs.Tracing.TraceSender.TraceExitCondition(10504,2051,2273);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10504,2353,2459);

BoundExpression 
consequence = f_10504_2383_2458(node.Syntax, nullableCtor, indexCreation)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10504,2499,2580);

BoundExpression 
alternative = f_10504_2529_2579(node.Syntax, f_10504_2569_2578(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10504,2689,3062);

BoundExpression 
conditionalExpression = f_10504_2729_3061(syntax: node.Syntax, rewrittenCondition: condition, rewrittenConsequence: consequence, rewrittenAlternative: alternative, constantValueOpt: null, rewrittenType: f_10504_3020_3029(node), isRef: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10504,3078,3341);

return f_10504_3085_3340(syntax: node.Syntax, locals: f_10504_3167_3194(locals), sideEffects: f_10504_3226_3258(sideeffects), value: conditionalExpression, type: f_10504_3330_3339(node));
DynAbs.Tracing.TraceSender.TraceExitMethod(10504,436,3352);

Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10504_561_575(Microsoft.CodeAnalysis.CSharp.BoundFromEndIndexExpression
this_param)
{
var return_v = this_param.MethodOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10504, 561, 575);
return return_v;
}


int
f_10504_548_584(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 548, 584);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10504_631_686(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 631, 686);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10504_752_778(bool
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 752, 778);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10504_727_792(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = this_param.MakeLiteral( syntax, constantValue, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 727, 792);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10504_851_863(Microsoft.CodeAnalysis.CSharp.BoundFromEndIndexExpression
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10504, 851, 863);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10504_835_864(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 835, 864);
return return_v;
}


bool
f_10504_885_915(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableNeverHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 885, 915);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10504_1002_1043(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.GetNullableUnderlyingType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 1002, 1043);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
f_10504_959_1044(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression( syntax, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 959, 1044);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10504_1086_1117(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = NullableAlwaysHasValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 1086, 1117);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10504_1150_1159(Microsoft.CodeAnalysis.CSharp.BoundFromEndIndexExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10504, 1150, 1159);
return return_v;
}


bool
f_10504_1150_1176(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsNullableType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 1150, 1176);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10504_1264_1278(Microsoft.CodeAnalysis.CSharp.BoundFromEndIndexExpression
this_param)
{
var return_v = this_param.MethodOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10504, 1264, 1278);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
f_10504_1217_1297(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
constructor,params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
arguments)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression( syntax, constructor, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 1217, 1297);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10504_1373_1416()
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 1373, 1416);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10504_1466_1505()
{
var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 1466, 1505);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10504_1565_1626(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
operand,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideeffects,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals)
{
var return_v = this_param.CaptureExpressionInTempIfNeeded( operand, sideeffects, locals);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 1565, 1626);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10504_1669_1715(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.MakeOptimizedHasValue( syntax, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 1669, 1715);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10504_1830_1885(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.MakeOptimizedGetValueOrDefault( syntax, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 1830, 1885);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10504_1979_1993(Microsoft.CodeAnalysis.CSharp.BoundFromEndIndexExpression
this_param)
{
var return_v = this_param.MethodOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10504, 1979, 1993);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
f_10504_1932_2034(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
constructor,params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
arguments)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression( syntax, constructor, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 1932, 2034);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10504_2090_2099(Microsoft.CodeAnalysis.CSharp.BoundFromEndIndexExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10504, 2090, 2099);
return return_v;
}


bool
f_10504_2056_2170(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
nullableType,Microsoft.CodeAnalysis.SpecialMember
member,out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
result)
{
var return_v = this_param.TryGetNullableMethod( syntax, nullableType, member, out result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 2056, 2170);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10504_2238_2247(Microsoft.CodeAnalysis.CSharp.BoundFromEndIndexExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10504, 2238, 2247);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10504_2211_2257(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
resultType,Microsoft.CodeAnalysis.CSharp.BoundExpression
child)
{
var return_v = BadExpression( syntax, resultType, child);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 2211, 2257);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
f_10504_2383_2458(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
constructor,params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
arguments)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression( syntax, constructor, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 2383, 2458);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10504_2569_2578(Microsoft.CodeAnalysis.CSharp.BoundFromEndIndexExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10504, 2569, 2578);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
f_10504_2529_2579(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression( syntax, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 2529, 2579);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10504_3020_3029(Microsoft.CodeAnalysis.CSharp.BoundFromEndIndexExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10504, 3020, 3029);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10504_2729_3061(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenConsequence,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenAlternative,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
isRef)
{
var return_v = RewriteConditionalOperator( syntax: syntax, rewrittenCondition: rewrittenCondition, rewrittenConsequence: rewrittenConsequence, rewrittenAlternative: rewrittenAlternative, constantValueOpt: constantValueOpt, rewrittenType: rewrittenType, isRef: isRef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 2729, 3061);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10504_3167_3194(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 3167, 3194);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10504_3226_3258(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 3226, 3258);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10504_3330_3339(Microsoft.CodeAnalysis.CSharp.BoundFromEndIndexExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10504, 3330, 3339);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10504_3085_3340(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax: syntax, locals: locals, sideEffects: sideEffects, value: value, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10504, 3085, 3340);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10504,436,3352);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10504,436,3352);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
