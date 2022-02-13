// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{
internal partial class LocalRewriter
{
public override BoundNode VisitTupleLiteral(BoundTupleLiteral node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10531,491,631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,583,620);

throw f_10531_589_619();
DynAbs.Tracing.TraceSender.TraceExitMethod(10531,491,631);

System.Exception
f_10531_589_619()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10531, 589, 619);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10531,491,631);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10531,491,631);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode VisitConvertedTupleLiteral(BoundConvertedTupleLiteral node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10531,643,798);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,753,787);

return f_10531_760_786(this, node);
DynAbs.Tracing.TraceSender.TraceExitMethod(10531,643,798);

Microsoft.CodeAnalysis.CSharp.BoundNode
f_10531_760_786(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundConvertedTupleLiteral
node)
{
var return_v = this_param.VisitTupleExpression( (Microsoft.CodeAnalysis.CSharp.BoundTupleExpression)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 760, 786);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10531,643,798);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10531,643,798);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundNode VisitTupleExpression(BoundTupleExpression node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10531,810,1068);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,900,979);

ImmutableArray<BoundExpression> 
rewrittenArguments = f_10531_953_978(this, f_10531_963_977(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,993,1057);

return f_10531_1000_1056(this, node, rewrittenArguments);
DynAbs.Tracing.TraceSender.TraceExitMethod(10531,810,1068);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10531_963_977(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10531, 963, 977);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10531_953_978(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
list)
{
var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundExpression>( list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 953, 978);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10531_1000_1056(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
node,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments)
{
var return_v = this_param.RewriteTupleCreationExpression( node, rewrittenArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 1000, 1056);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10531,810,1068);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10531,810,1068);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression RewriteTupleCreationExpression(BoundTupleExpression node, ImmutableArray<BoundExpression> rewrittenArguments)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10531,1499,1809);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,1657,1688);

f_10531_1657_1687(f_10531_1670_1679(node)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,1702,1798);

return f_10531_1709_1797(this, node.Syntax, f_10531_1767_1776(node), rewrittenArguments);
DynAbs.Tracing.TraceSender.TraceExitMethod(10531,1499,1809);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10531_1670_1679(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10531, 1670, 1679);
return return_v;
}


int
f_10531_1657_1687(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 1657, 1687);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10531_1767_1776(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10531, 1767, 1776);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10531_1709_1797(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments)
{
var return_v = this_param.MakeTupleCreationExpression( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)type, rewrittenArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 1709, 1797);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10531,1499,1809);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10531,1499,1809);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeTupleCreationExpression(SyntaxNode syntax, NamedTypeSymbol type, ImmutableArray<BoundExpression> rewrittenArguments)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10531,1821,6241);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,1990,2021);

f_10531_1990_2020(f_10531_2003_2019(type));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,2037,2138);

ArrayBuilder<NamedTypeSymbol> 
underlyingTupleTypeChain = f_10531_2094_2137()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,2152,2223);

f_10531_2152_2222(type, underlyingTupleTypeChain);

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,2344,2406);

NamedTypeSymbol 
smallestType = f_10531_2375_2405(underlyingTupleTypeChain)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,2424,2811);

ImmutableArray<BoundExpression> 
smallestCtorArguments = f_10531_2480_2810(rewrittenArguments, f_10531_2617_2647(underlyingTupleTypeChain)* (NamedTypeSymbol.ValueTupleRestPosition - 1), f_10531_2791_2809(smallestType))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,2829,3288);

var 
smallestCtor = (MethodSymbol?)f_10531_2863_3287(f_10531_2904_2935(smallestType), f_10531_3030_3078(f_10531_3059_3077(smallestType)), _diagnostics, syntax)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,3306,3427) || true) && (smallestCtor is null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10531,3306,3427);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,3372,3408);

return f_10531_3379_3407(_factory, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10531,3306,3427);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,3447,3518);

MethodSymbol 
smallestConstructor = f_10531_3482_3517(smallestCtor, smallestType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,3536,3670);

BoundObjectCreationExpression 
currentCreation = f_10531_3584_3669(syntax, smallestConstructor, smallestCtorArguments)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,3690,5500) || true) && (f_10531_3694_3724(underlyingTupleTypeChain)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10531,3690,5500);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,3770,3831);

NamedTypeSymbol 
tuple8Type = f_10531_3799_3830(underlyingTupleTypeChain)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,3853,4328);

var 
tuple8Ctor = (MethodSymbol?)f_10531_3885_4327(f_10531_3926_3955(tuple8Type), f_10531_4050_4118(NamedTypeSymbol.ValueTupleRestPosition), _diagnostics, syntax)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,4350,4481) || true) && (tuple8Ctor is null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10531,4350,4481);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,4422,4458);

return f_10531_4429_4457(_factory, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10531,4350,4481);
}
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10531,4603,5481);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,4654,5172);

ImmutableArray<BoundExpression> 
ctorArguments = f_10531_4702_5062(rewrittenArguments, (f_10531_4840_4870(underlyingTupleTypeChain)- 1) * (NamedTypeSymbol.ValueTupleRestPosition - 1), NamedTypeSymbol.ValueTupleRestPosition - 1)                                                                                      .Add(currentCreation)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,5200,5279);

MethodSymbol 
constructor = f_10531_5227_5278(tuple8Ctor, f_10531_5247_5277(underlyingTupleTypeChain))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,5305,5393);

currentCreation = f_10531_5323_5392(syntax, constructor, ctorArguments);
DynAbs.Tracing.TraceSender.TraceExitCondition(10531,4603,5481);
}
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,4603,5481) || true) && (f_10531_5445_5475(underlyingTupleTypeChain)> 0)
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10531,4603,5481);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10531,4603,5481);
}}DynAbs.Tracing.TraceSender.TraceExitCondition(10531,3690,5500);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,5520,6071);

currentCreation = f_10531_5538_6070(currentCreation, f_10531_5583_5610(currentCreation), f_10531_5633_5658(currentCreation), f_10531_5681_5713(currentCreation), f_10531_5736_5771(currentCreation), f_10531_5794_5818(currentCreation), f_10531_5841_5872(currentCreation), f_10531_5895_5927(currentCreation), f_10531_5950_5979(currentCreation), f_10531_6002_6042(currentCreation), type);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,6091,6114);

return currentCreation;
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(10531,6143,6230);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10531,6183,6215);

f_10531_6183_6214(                underlyingTupleTypeChain);
DynAbs.Tracing.TraceSender.TraceExitFinally(10531,6143,6230);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(10531,1821,6241);

bool
f_10531_2003_2019(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.IsTupleType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10531, 2003, 2019);
return return_v;
}


int
f_10531_1990_2020(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 1990, 2020);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
f_10531_2094_2137()
{
var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 2094, 2137);
return return_v;
}


int
f_10531_2152_2222(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
underlyingTupleType,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
underlyingTupleTypeChain)
{
NamedTypeSymbol.GetUnderlyingTypeChain( underlyingTupleType, underlyingTupleTypeChain);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 2152, 2222);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10531_2375_2405(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
builder)
{
var return_v = builder.Pop<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 2375, 2405);
return return_v;
}


int
f_10531_2617_2647(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10531, 2617, 2647);
return return_v;
}


int
f_10531_2791_2809(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.Arity;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10531, 2791, 2809);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10531_2480_2810(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
items,int
start,int
length)
{
var return_v = ImmutableArray.Create( items, start, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 2480, 2810);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10531_2904_2935(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.OriginalDefinition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10531, 2904, 2935);
return return_v;
}


int
f_10531_3059_3077(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.Arity;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10531, 3059, 3077);
return return_v;
}


Microsoft.CodeAnalysis.WellKnownMember
f_10531_3030_3078(int
arity)
{
var return_v = NamedTypeSymbol.GetTupleCtor( arity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 3030, 3078);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_10531_2863_3287(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type,Microsoft.CodeAnalysis.WellKnownMember
relativeMember,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.SyntaxNode
syntax)
{
var return_v = NamedTypeSymbol.GetWellKnownMemberInType( type, relativeMember, diagnostics, syntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 2863, 3287);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBadExpression
f_10531_3379_3407(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = this_param.BadExpression( (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 3379, 3407);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10531_3482_3517(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
newOwner)
{
var return_v = this_param.AsMember( newOwner);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 3482, 3517);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
f_10531_3584_3669(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
constructor,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression( syntax, constructor, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 3584, 3669);
return return_v;
}


int
f_10531_3694_3724(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10531, 3694, 3724);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10531_3799_3830(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
builder)
{
var return_v = builder.Peek<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 3799, 3830);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10531_3926_3955(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.OriginalDefinition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10531, 3926, 3955);
return return_v;
}


Microsoft.CodeAnalysis.WellKnownMember
f_10531_4050_4118(int
arity)
{
var return_v = NamedTypeSymbol.GetTupleCtor( arity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 4050, 4118);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_10531_3885_4327(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type,Microsoft.CodeAnalysis.WellKnownMember
relativeMember,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.SyntaxNode
syntax)
{
var return_v = NamedTypeSymbol.GetWellKnownMemberInType( type, relativeMember, diagnostics, syntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 3885, 4327);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBadExpression
f_10531_4429_4457(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = this_param.BadExpression( (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 4429, 4457);
return return_v;
}


int
f_10531_4840_4870(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10531, 4840, 4870);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10531_4702_5062(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
items,int
start,int
length)
{
var return_v = ImmutableArray.Create( items, start, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 4702, 5062);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10531_5247_5277(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
builder)
{
var return_v = builder.Pop<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 5247, 5277);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10531_5227_5278(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
newOwner)
{
var return_v = this_param.AsMember( newOwner);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 5227, 5278);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
f_10531_5323_5392(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
constructor,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression( syntax, constructor, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 5323, 5392);
return return_v;
}


int
f_10531_5445_5475(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10531, 5445, 5475);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10531_5583_5610(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.Constructor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10531, 5583, 5610);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10531_5633_5658(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10531, 5633, 5658);
return return_v;
}


System.Collections.Immutable.ImmutableArray<string>
f_10531_5681_5713(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.ArgumentNamesOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10531, 5681, 5713);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
f_10531_5736_5771(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.ArgumentRefKindsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10531, 5736, 5771);
return return_v;
}


bool
f_10531_5794_5818(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.Expanded;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10531, 5794, 5818);
return return_v;
}


System.Collections.Immutable.ImmutableArray<int>
f_10531_5841_5872(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.ArgsToParamsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10531, 5841, 5872);
return return_v;
}


Microsoft.CodeAnalysis.BitVector
f_10531_5895_5927(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.DefaultArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10531, 5895, 5927);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10531_5950_5979(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10531, 5950, 5979);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
f_10531_6002_6042(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.InitializerExpressionOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10531, 6002, 6042);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
f_10531_5538_6070(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
constructor,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments,System.Collections.Immutable.ImmutableArray<string>
argumentNamesOpt,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKindsOpt,bool
expanded,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,Microsoft.CodeAnalysis.BitVector
defaultArguments,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
initializerExpressionOpt,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = this_param.Update( constructor, arguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, constantValueOpt, initializerExpressionOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 5538, 6070);
return return_v;
}


int
f_10531_6183_6214(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10531, 6183, 6214);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10531,1821,6241);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10531,1821,6241);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
