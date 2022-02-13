// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitConvertedStackAllocExpression(BoundConvertedStackAllocExpression stackAllocNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10524,498,701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,634,690);

return f_10524_641_689(this, stackAllocNode);
DynAbs.Tracing.TraceSender.TraceExitMethod(10524,498,701);

Microsoft.CodeAnalysis.CSharp.BoundNode
f_10524_641_689(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundConvertedStackAllocExpression
stackAllocNode)
{
var return_v = this_param.VisitStackAllocArrayCreationBase( (Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreationBase)stackAllocNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 641, 689);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10524,498,701);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10524,498,701);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode VisitStackAllocArrayCreation(BoundStackAllocArrayCreation stackAllocNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10524,713,904);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,837,893);

return f_10524_844_892(this, stackAllocNode);
DynAbs.Tracing.TraceSender.TraceExitMethod(10524,713,904);

Microsoft.CodeAnalysis.CSharp.BoundNode
f_10524_844_892(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreation
stackAllocNode)
{
var return_v = this_param.VisitStackAllocArrayCreationBase( (Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreationBase)stackAllocNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 844, 892);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10524,713,904);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10524,713,904);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundNode VisitStackAllocArrayCreationBase(BoundStackAllocArrayCreationBase stackAllocNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10524,916,4870);
Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol spanConstructor = default(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol);
Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator tempAssignment = default(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,1040,1099);

var 
rewrittenCount = f_10524_1061_1098(this, f_10524_1077_1097(stackAllocNode))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,1113,1144);

var 
type = f_10524_1124_1143(stackAllocNode)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,1158,1184);

f_10524_1158_1183(type is { });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,1200,1380) || true) && (f_10524_1204_1244_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10524_1204_1232(rewrittenCount), 10524, 1204, 1244)?.Int32Value)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10524,1200,1380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,1335,1365);

return f_10524_1342_1364(_factory, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10524,1200,1380);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,1396,1441);

var 
elementType = f_10524_1414_1440(stackAllocNode)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,1457,1508);

var 
initializerOpt = f_10524_1478_1507(stackAllocNode)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,1522,1676) || true) && (initializerOpt != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10524,1522,1676);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,1582,1661);

initializerOpt = f_10524_1599_1660(initializerOpt, f_10524_1621_1659(this, f_10524_1631_1658(initializerOpt)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10524,1522,1676);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,1692,4859) || true) && (f_10524_1696_1716(type))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10524,1692,4859);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,1750,1824);

var 
stackSize = f_10524_1766_1823(this, rewrittenCount, elementType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,1842,1957);

return f_10524_1849_1956(stackAllocNode.Syntax, elementType, stackSize, initializerOpt, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10524,1692,4859);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10524,1692,4859);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,1991,4859) || true) && (f_10524_1995_2134(f_10524_2013_2036(type), f_10524_2038_2096(_compilation, WellKnownType.System_Span_T), TypeCompareKind.ConsiderEverything2))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10524,1991,4859);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,2168,2205);

var 
spanType = (NamedTypeSymbol)type
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,2223,2285);

var 
sideEffects = f_10524_2241_2284()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,2303,2356);

var 
locals = f_10524_2316_2355()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,2374,2487);

var 
countTemp = f_10524_2390_2486(this, rewrittenCount, sideEffects, locals, SynthesizedLocalKind.Spill)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,2505,2574);

var 
stackSize = f_10524_2521_2573(this, countTemp, elementType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,2592,2784);

stackAllocNode = f_10524_2609_2783(stackAllocNode.Syntax, elementType, stackSize, initializerOpt, f_10524_2733_2782(_compilation, elementType));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,2804,2836);

BoundExpression 
constructorCall
=default(BoundExpression);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,2854,3612) || true) && (f_10524_2858_2977(this, stackAllocNode.Syntax, WellKnownMember.System_Span_T__ctor, out spanConstructor))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10524,2854,3612);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,3019,3133);

constructorCall = f_10524_3037_3132(_factory, f_10524_3064_3104(spanConstructor, spanType), stackAllocNode, countTemp);
DynAbs.Tracing.TraceSender.TraceExitCondition(10524,2854,3612);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10524,2854,3612);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,3215,3593);

constructorCall = f_10524_3233_3592(syntax: stackAllocNode.Syntax, resultKind: LookupResultKind.NotInvocable, symbols: ImmutableArray<Symbol?>.Empty, childBoundNodes: ImmutableArray<BoundExpression>.Empty, type: ErrorTypeSymbol.UnknownResultType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10524,2854,3612);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,4151,4173);

_needsSpilling = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,4191,4324);

var 
tempAccess = f_10524_4208_4323(_factory, constructorCall, out tempAssignment, syntaxOpt: stackAllocNode.Syntax)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,4342,4374);

f_10524_4342_4373(                sideEffects, tempAssignment);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,4392,4427);

f_10524_4392_4426(                locals, f_10524_4403_4425(tempAccess));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,4445,4731);

return f_10524_4452_4730(syntax: stackAllocNode.Syntax, locals: f_10524_4557_4584(locals), sideEffects: f_10524_4620_4652(sideEffects), value: tempAccess, type: spanType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10524,1991,4859);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10524,1991,4859);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,4797,4844);

throw f_10524_4803_4843(type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10524,1991,4859);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10524,1692,4859);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10524,916,4870);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10524_1077_1097(Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreationBase
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10524, 1077, 1097);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10524_1061_1098(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 1061, 1098);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10524_1124_1143(Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreationBase
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10524, 1124, 1143);
return return_v;
}


int
f_10524_1158_1183(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 1158, 1183);
return 0;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10524_1204_1232(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10524, 1204, 1232);
return return_v;
}


int?
f_10524_1204_1244_M(int?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10524, 1204, 1244);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10524_1342_1364(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Default( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 1342, 1364);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10524_1414_1440(Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreationBase
this_param)
{
var return_v = this_param.ElementType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10524, 1414, 1440);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
f_10524_1478_1507(Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreationBase
this_param)
{
var return_v = this_param.InitializerOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10524, 1478, 1507);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10524_1631_1658(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
this_param)
{
var return_v = this_param.Initializers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10524, 1631, 1658);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10524_1621_1659(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
list)
{
var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundExpression>( list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 1621, 1659);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
f_10524_1599_1660(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
initializers)
{
var return_v = this_param.Update( initializers);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 1599, 1660);
return return_v;
}


bool
f_10524_1696_1716(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsPointerType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 1696, 1716);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10524_1766_1823(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
countExpression,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
elementType)
{
var return_v = this_param.RewriteStackAllocCountToSize( countExpression, elementType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 1766, 1823);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundConvertedStackAllocExpression
f_10524_1849_1956(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
elementType,Microsoft.CodeAnalysis.CSharp.BoundExpression
count,Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
initializerOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConvertedStackAllocExpression( syntax, elementType, count, initializerOpt, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 1849, 1956);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10524_2013_2036(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.OriginalDefinition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10524, 2013, 2036);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10524_2038_2096(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownType
type)
{
var return_v = this_param.GetWellKnownType( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 2038, 2096);
return return_v;
}


bool
f_10524_1995_2134(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
left,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 1995, 2134);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10524_2241_2284()
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 2241, 2284);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10524_2316_2355()
{
var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 2316, 2355);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10524_2390_2486(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
operand,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideeffects,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,Microsoft.CodeAnalysis.SynthesizedLocalKind
kind)
{
var return_v = this_param.CaptureExpressionInTempIfNeeded( operand, sideeffects, locals, kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 2390, 2486);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10524_2521_2573(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
countExpression,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
elementType)
{
var return_v = this_param.RewriteStackAllocCountToSize( countExpression, elementType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 2521, 2573);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
f_10524_2733_2782(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
elementType)
{
var return_v = this_param.CreatePointerTypeSymbol( elementType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 2733, 2782);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundConvertedStackAllocExpression
f_10524_2609_2783(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
elementType,Microsoft.CodeAnalysis.CSharp.BoundExpression
count,Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
initializerOpt,Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConvertedStackAllocExpression( syntax, elementType, count, initializerOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 2609, 2783);
return return_v;
}


bool
f_10524_2858_2977(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.WellKnownMember
member,out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
symbol)
{
var return_v = this_param.TryGetWellKnownTypeMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( syntax, member, out symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 2858, 2977);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10524_3064_3104(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
s,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
newOwner)
{
var return_v = s.SymbolAsMember( newOwner);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 3064, 3104);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
f_10524_3037_3132(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbol
ctor,params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
args)
{
var return_v = this_param.New( (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)ctor, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 3037, 3132);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBadExpression
f_10524_3233_3592(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
symbols,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
childBoundNodes,Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression( syntax: syntax, resultKind: resultKind, symbols: symbols, childBoundNodes: childBoundNodes, type: (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 3233, 3592);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10524_4208_4323(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store,Microsoft.CodeAnalysis.SyntaxNode
syntaxOpt)
{
var return_v = this_param.StoreToTemp( argument, out store, syntaxOpt: syntaxOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 4208, 4323);
return return_v;
}


int
f_10524_4342_4373(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 4342, 4373);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10524_4403_4425(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10524, 4403, 4425);
return return_v;
}


int
f_10524_4392_4426(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 4392, 4426);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10524_4557_4584(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 4557, 4584);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10524_4620_4652(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 4620, 4652);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSpillSequence
f_10524_4452_4730(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundLocal
value,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSpillSequence( syntax: syntax, locals: locals, sideEffects: sideEffects, value: (Microsoft.CodeAnalysis.CSharp.BoundExpression)value, type: (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 4452, 4730);
return return_v;
}


System.Exception
f_10524_4803_4843(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 4803, 4843);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10524,916,4870);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10524,916,4870);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression RewriteStackAllocCountToSize(BoundExpression countExpression, TypeSymbol elementType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10524,4882,7705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,5597,5667);

TypeSymbol 
uintType = f_10524_5619_5666(_factory, SpecialType.System_UInt32)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,5681,5755);

TypeSymbol 
uintPtrType = f_10524_5706_5754(_factory, SpecialType.System_UIntPtr)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,6157,6221);

BoundExpression 
sizeOfExpression = f_10524_6192_6220(_factory, elementType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,6237,6284);

var 
sizeConst = f_10524_6253_6283(sizeOfExpression)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,6298,6983) || true) && (sizeConst != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10524,6298,6983);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,6353,6385);

int 
size = f_10524_6364_6384(sizeConst)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,6403,6426);

f_10524_6403_6425(size > 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,6499,6546);

var 
countConst = f_10524_6516_6545(countExpression)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,6564,6968) || true) && (countConst != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10524,6564,6968);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,6628,6662);

var 
count = f_10524_6640_6661(countConst)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,6684,6728);

long 
folded = unchecked((uint)count * size)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,6752,6949) || true) && (folded < uint.MaxValue)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10524,6752,6949);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,6828,6926);

return f_10524_6835_6925(_factory, uintPtrType, f_10524_6865_6895(_factory, folded), Conversion.IntegerToPointer);
DynAbs.Tracing.TraceSender.TraceExitCondition(10524,6752,6949);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10524,6564,6968);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10524,6298,6983);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,6999,7104);

BoundExpression 
convertedCount = f_10524_7032_7103(_factory, uintType, countExpression, Conversion.ExplicitNumeric)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,7118,7210);

convertedCount = f_10524_7135_7209(_factory, uintPtrType, convertedCount, Conversion.IntegerToPointer);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,7282,7383) || true) && (f_10524_7286_7307_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(sizeConst, 10524, 7286, 7307)?.Int32Value)== 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10524,7282,7383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,7346,7368);

return convertedCount;
DynAbs.Tracing.TraceSender.TraceExitCondition(10524,7282,7383);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,7399,7506);

BinaryOperatorKind 
multiplicationKind = BinaryOperatorKind.Checked | BinaryOperatorKind.UIntMultiplication
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,7554,7663);

BoundExpression 
product = f_10524_7580_7662(_factory, multiplicationKind, uintPtrType, convertedCount, sizeOfExpression)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10524,7679,7694);

return product;
DynAbs.Tracing.TraceSender.TraceExitMethod(10524,4882,7705);

Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10524_5619_5666(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.SpecialType
st)
{
var return_v = this_param.SpecialType( st);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 5619, 5666);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10524_5706_5754(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.SpecialType
st)
{
var return_v = this_param.SpecialType( st);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 5706, 5754);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10524_6192_6220(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Sizeof( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 6192, 6220);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10524_6253_6283(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10524, 6253, 6283);
return return_v;
}


int
f_10524_6364_6384(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.Int32Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10524, 6364, 6384);
return return_v;
}


int
f_10524_6403_6425(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 6403, 6425);
return 0;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10524_6516_6545(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10524, 6516, 6545);
return return_v;
}


int
f_10524_6640_6661(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.Int32Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10524, 6640, 6661);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10524_6865_6895(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,long
value)
{
var return_v = this_param.Literal( (uint)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 6865, 6895);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10524_6835_6925(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundLiteral
arg,Microsoft.CodeAnalysis.CSharp.Conversion
conversion)
{
var return_v = this_param.Convert( type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg, conversion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 6835, 6925);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10524_7032_7103(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg,Microsoft.CodeAnalysis.CSharp.Conversion
conversion)
{
var return_v = this_param.Convert( type, arg, conversion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 7032, 7103);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10524_7135_7209(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg,Microsoft.CodeAnalysis.CSharp.Conversion
conversion)
{
var return_v = this_param.Convert( type, arg, conversion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 7135, 7209);
return return_v;
}


int?
f_10524_7286_7307_M(int?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10524, 7286, 7307);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10524_7580_7662(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
kind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.Binary( kind, type, left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10524, 7580, 7662);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10524,4882,7705);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10524,4882,7705);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
