// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
internal partial class LocalRewriter
{
public override BoundNode VisitForEachStatement(BoundForEachStatement node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10498,1181,2531);
Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol? indexerGet = default(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?);
Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol? lengthGetter = default(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,1364,1443) || true) && (f_10498_1368_1382(node))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,1364,1443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,1416,1428);

return node;
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,1364,1443);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,1459,1539);

BoundExpression 
collectionExpression = f_10498_1498_1538(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,1553,1612);

TypeSymbol? 
nodeExpressionType = f_10498_1586_1611(collectionExpression)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,1626,1666);

f_10498_1626_1665(nodeExpressionType is { });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,1680,2520) || true) && (f_10498_1684_1707(nodeExpressionType)== SymbolKind.ArrayType)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,1680,2520);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,1765,1829);

ArrayTypeSymbol 
arrayType = (ArrayTypeSymbol)nodeExpressionType
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,1847,2130) || true) && (f_10498_1851_1870(arrayType))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,1847,2130);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,1912,1971);

return f_10498_1919_1970(this, node);
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,1847,2130);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,1847,2130);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,2053,2111);

return f_10498_2060_2110(this, node);
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,1847,2130);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,1680,2520);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,1680,2520);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,2164,2520) || true) && (f_10498_2168_2181(node)is null &&(DynAbs.Tracing.TraceSender.Expression_True(10498, 2168, 2290)&&f_10498_2193_2290(this, node.Syntax, nodeExpressionType, out indexerGet, out lengthGetter)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,2164,2520);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,2324,2392);

return f_10498_2331_2391(this, node, indexerGet, lengthGetter);
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,2164,2520);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,2164,2520);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,2458,2505);

return f_10498_2465_2504(this, node);
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,2164,2520);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,1680,2520);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10498,1181,2531);

bool
f_10498_1368_1382(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.HasErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 1368, 1382);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_1498_1538(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
node)
{
var return_v = GetUnconvertedCollectionExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 1498, 1538);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10498_1586_1611(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 1586, 1611);
return return_v;
}


int
f_10498_1626_1665(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 1626, 1665);
return 0;
}


Microsoft.CodeAnalysis.SymbolKind
f_10498_1684_1707(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 1684, 1707);
return return_v;
}


bool
f_10498_1851_1870(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
this_param)
{
var return_v = this_param.IsSZArray;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 1851, 1870);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_1919_1970(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
node)
{
var return_v = this_param.RewriteSingleDimensionalArrayForEachStatement( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 1919, 1970);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_2060_2110(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
node)
{
var return_v = this_param.RewriteMultiDimensionalArrayForEachStatement( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 2060, 2110);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
f_10498_2168_2181(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.AwaitOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 2168, 2181);
return return_v;
}


bool
f_10498_2193_2290(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
forEachSyntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
nodeExpressionType,out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
indexerGet,out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
lengthGet)
{
var return_v = this_param.CanRewriteForEachAsFor( forEachSyntax, nodeExpressionType, out indexerGet, out lengthGet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 2193, 2290);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_2331_2391(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
node,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
indexerGet,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
lengthGet)
{
var return_v = this_param.RewriteForEachStatementAsFor( node, indexerGet, lengthGet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 2331, 2391);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_2465_2504(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
node)
{
var return_v = this_param.RewriteEnumeratorForEachStatement( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 2465, 2504);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10498,1181,2531);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10498,1181,2531);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool CanRewriteForEachAsFor(SyntaxNode forEachSyntax, TypeSymbol nodeExpressionType, [NotNullWhen(true)] out MethodSymbol? indexerGet, [NotNullWhen(true)] out MethodSymbol? lengthGet)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10498,2543,4332);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,2759,2789);

lengthGet = indexerGet = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,2803,2862);

var 
origDefinition = f_10498_2824_2861(nodeExpressionType)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,2878,4260) || true) && (f_10498_2882_2908(origDefinition)== SpecialType.System_String)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,2878,4260);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,2971,3062);

lengthGet = f_10498_2983_3061(this, forEachSyntax, SpecialMember.System_String__Length);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,3080,3171);

indexerGet = f_10498_3093_3170(this, forEachSyntax, SpecialMember.System_String__Chars);
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,2878,4260);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,2878,4260);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,3205,4260) || true) && ((object)origDefinition == f_10498_3235_3298(this._compilation, WellKnownType.System_Span_T))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,3205,4260);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,3332,3383);

var 
spanType = (NamedTypeSymbol)nodeExpressionType
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,3401,3540);

lengthGet = (MethodSymbol?)f_10498_3514_3539(f_10498_3428_3513(_factory, WellKnownMember.System_Span_T__get_Length, isOptional: true), spanType);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,3558,3696);

indexerGet = (MethodSymbol?)f_10498_3670_3695(f_10498_3586_3669(_factory, WellKnownMember.System_Span_T__get_Item, isOptional: true), spanType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,3205,4260);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,3205,4260);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,3730,4260) || true) && ((object)origDefinition == f_10498_3760_3831(this._compilation, WellKnownType.System_ReadOnlySpan_T))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,3730,4260);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,3865,3916);

var 
spanType = (NamedTypeSymbol)nodeExpressionType
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,3934,4081);

lengthGet = (MethodSymbol?)f_10498_4055_4080(f_10498_3961_4054(_factory, WellKnownMember.System_ReadOnlySpan_T__get_Length, isOptional: true), spanType);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,4099,4245);

indexerGet = (MethodSymbol?)f_10498_4219_4244(f_10498_4127_4218(_factory, WellKnownMember.System_ReadOnlySpan_T__get_Item, isOptional: true), spanType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,3730,4260);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,3205,4260);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,2878,4260);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,4276,4321);

return lengthGet is { } &&(DynAbs.Tracing.TraceSender.Expression_True(10498, 4283, 4320)&&indexerGet is { });
DynAbs.Tracing.TraceSender.TraceExitMethod(10498,2543,4332);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10498_2824_2861(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.OriginalDefinition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 2824, 2861);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10498_2882_2908(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 2882, 2908);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10498_2983_3061(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.UnsafeGetSpecialTypeMethod( syntax, specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 2983, 3061);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10498_3093_3170(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.UnsafeGetSpecialTypeMethod( syntax, specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 3093, 3170);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10498_3235_3298(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownType
type)
{
var return_v = this_param.GetWellKnownType( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 3235, 3298);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_10498_3428_3513(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.WellKnownMember
wm,bool
isOptional)
{
var return_v = this_param?.WellKnownMember( wm, isOptional: isOptional);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 3428, 3513);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10498_3514_3539(Microsoft.CodeAnalysis.CSharp.Symbol
s,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
newOwner)
{
var return_v = s?.SymbolAsMember( newOwner);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 3514, 3539);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_10498_3586_3669(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.WellKnownMember
wm,bool
isOptional)
{
var return_v = this_param?.WellKnownMember( wm, isOptional: isOptional);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 3586, 3669);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10498_3670_3695(Microsoft.CodeAnalysis.CSharp.Symbol
s,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
newOwner)
{
var return_v = s?.SymbolAsMember( newOwner);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 3670, 3695);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10498_3760_3831(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownType
type)
{
var return_v = this_param.GetWellKnownType( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 3760, 3831);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_10498_3961_4054(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.WellKnownMember
wm,bool
isOptional)
{
var return_v = this_param?.WellKnownMember( wm, isOptional: isOptional);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 3961, 4054);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10498_4055_4080(Microsoft.CodeAnalysis.CSharp.Symbol
s,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
newOwner)
{
var return_v = s?.SymbolAsMember( newOwner);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 4055, 4080);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_10498_4127_4218(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.WellKnownMember
wm,bool
isOptional)
{
var return_v = this_param?.WellKnownMember( wm, isOptional: isOptional);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 4127, 4218);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10498_4219_4244(Microsoft.CodeAnalysis.CSharp.Symbol
s,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
newOwner)
{
var return_v = s?.SymbolAsMember( newOwner);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 4219, 4244);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10498,2543,4332);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10498,2543,4332);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement RewriteEnumeratorForEachStatement(BoundForEachStatement node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10498,4939,11765);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,5048,5110);

var 
forEachSyntax = (CommonForEachStatementSyntax)node.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,5124,5161);

bool 
isAsync = f_10498_5139_5152(node)!= null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,5177,5240);

ForEachEnumeratorInfo? 
enumeratorInfo = f_10498_5217_5239(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,5254,5291);

f_10498_5254_5290(enumeratorInfo != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,5307,5387);

BoundExpression 
collectionExpression = f_10498_5346_5386(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,5401,5477);

BoundExpression 
rewrittenExpression = f_10498_5439_5476(this, collectionExpression)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,5491,5549);

BoundStatement? 
rewrittenBody = f_10498_5523_5548(this, f_10498_5538_5547(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,5563,5598);

f_10498_5563_5597(rewrittenBody is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,5614,5686);

MethodArgumentInfo 
getEnumeratorInfo = enumeratorInfo.GetEnumeratorInfo
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,5700,5764);

TypeSymbol 
enumeratorType = f_10498_5728_5763(f_10498_5728_5752(getEnumeratorInfo))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,5778,5830);

TypeSymbol 
elementType = f_10498_5803_5829(enumeratorInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,5866,6005);

LocalSymbol 
enumeratorVar = f_10498_5894_6004(_factory, enumeratorType, syntax: forEachSyntax, kind: SynthesizedLocalKind.ForEachEnumerator)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,6053,6146);

BoundLocal 
boundEnumeratorVar = f_10498_6085_6145(forEachSyntax, enumeratorVar, enumeratorType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,6162,6336);

var 
receiver = f_10498_6177_6335(this, forEachSyntax, rewrittenExpression, f_10498_6242_6266(getEnumeratorInfo), enumeratorInfo.CollectionConversion, enumeratorInfo.CollectionType)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,6580,7056) || true) && (f_10498_6584_6626(f_10498_6584_6608(getEnumeratorInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,6580,7056);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,6660,6752);

var 
builder = f_10498_6674_6751(getEnumeratorInfo.Arguments.Length)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,6770,6792);

f_10498_6770_6791(                builder, receiver);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,6810,6899);

f_10498_6810_6898(                builder, f_10498_6827_6854(getEnumeratorInfo), 1, getEnumeratorInfo.Arguments.Length - 1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,6917,7005);

getEnumeratorInfo = getEnumeratorInfo with { Arguments = f_10498_6974_7002(builder)};
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,7025,7041);

receiver = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,6580,7056);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,7210,7718);

BoundExpression 
enumeratorVarInitValue = f_10498_7251_7717(this, getEnumeratorInfo, forEachSyntax, receiver, allowExtensionAndOptionalParameters: isAsync ||(DynAbs.Tracing.TraceSender.Expression_False(10498, 7364, 7417)||f_10498_7375_7417(f_10498_7375_7399(getEnumeratorInfo))), assertParametersAreOptional: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,7782,7892);

BoundStatement 
enumeratorVarDecl = f_10498_7817_7891(this, forEachSyntax, enumeratorVar, enumeratorVarInitValue)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,7908,7988);

f_10498_7908_7987(this, node, ref enumeratorVarDecl);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,8036,8798);

BoundExpression 
iterationVarAssignValue = f_10498_8078_8797(this, syntax: forEachSyntax, rewrittenOperand: f_10498_8173_8637(this, syntax: forEachSyntax, rewrittenOperand: f_10498_8276_8475(syntax: forEachSyntax, receiverOpt: boundEnumeratorVar, method: enumeratorInfo.CurrentPropertyGetter), conversion: enumeratorInfo.CurrentConversion, rewrittenType: elementType, @checked: f_10498_8624_8636(node)), conversion: f_10498_8668_8690(node), rewrittenType: f_10498_8724_8755(f_10498_8724_8750(node)), @checked: f_10498_8784_8796(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,8894,8967);

ImmutableArray<LocalSymbol> 
iterationVariables = f_10498_8943_8966(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,8981,9099);

BoundStatement 
iterationVarDecl = f_10498_9015_9098(this, node, iterationVariables, iterationVarAssignValue)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,9115,9193);

f_10498_9115_9192(this, node, ref iterationVarDecl);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,9441,9573);

var 
rewrittenBodyBlock = f_10498_9466_9572(iterationVariables, iterationVarDecl, rewrittenBody, forEachSyntax)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,9587,9872);

BoundExpression 
rewrittenCondition = f_10498_9624_9871(this, methodArgumentInfo: enumeratorInfo.MoveNextInfo, syntax: forEachSyntax, receiver: boundEnumeratorVar, allowExtensionAndOptionalParameters: isAsync)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,9886,10156) || true) && (isAsync)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,9886,10156);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,9931,9981);

f_10498_9931_9980(f_10498_9944_9957(node)is { GetResult: { } });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,9999,10141);

rewrittenCondition = f_10498_10020_10140(this, forEachSyntax, rewrittenCondition, f_10498_10078_10091(node), f_10498_10093_10127(f_10498_10093_10116(f_10498_10093_10106(node))), used: true);
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,9886,10156);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,10172,10473);

BoundStatement 
whileLoop = f_10498_10199_10472(this, loop: node, rewrittenCondition, rewrittenBody: rewrittenBodyBlock, breakLabel: f_10498_10369_10384(node), continueLabel: f_10498_10418_10436(node), hasErrors: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,10489,10511);

BoundStatement 
result
=default(BoundStatement);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,10527,11663) || true) && (enumeratorInfo.NeedsDisposal)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,10527,11663);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,10593,10725);

BoundStatement 
tryFinally = f_10498_10621_10724(this, forEachSyntax, enumeratorInfo, enumeratorType, boundEnumeratorVar, whileLoop)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,10862,11101);

result = f_10498_10871_11100(syntax: forEachSyntax, locals: f_10498_10960_10996(enumeratorVar), statements: f_10498_11031_11099(enumeratorVarDecl, tryFinally));
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,10527,11663);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,10527,11663);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,11410,11648);

result = f_10498_11419_11647(syntax: forEachSyntax, locals: f_10498_11508_11544(enumeratorVar), statements: f_10498_11579_11646(enumeratorVarDecl, whileLoop));
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,10527,11663);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,11679,11724);

f_10498_11679_11723(this, node, ref result);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,11740,11754);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10498,4939,11765);

Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
f_10498_5139_5152(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.AwaitOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 5139, 5152);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo?
f_10498_5217_5239(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.EnumeratorInfoOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 5217, 5239);
return return_v;
}


int
f_10498_5254_5290(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 5254, 5290);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_5346_5386(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
node)
{
var return_v = GetUnconvertedCollectionExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 5346, 5386);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10498_5439_5476(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 5439, 5476);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_5538_5547(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 5538, 5547);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10498_5523_5548(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
node)
{
var return_v = this_param.VisitStatement( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 5523, 5548);
return return_v;
}


int
f_10498_5563_5597(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 5563, 5597);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10498_5728_5752(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 5728, 5752);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10498_5728_5763(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ReturnType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 5728, 5763);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10498_5803_5829(Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo
this_param)
{
var return_v = this_param.ElementType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 5803, 5829);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10498_5894_6004(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.SynthesizedLocalKind
kind)
{
var return_v = this_param.SynthesizedLocal( type, syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, kind: kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 5894, 6004);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10498_6085_6145(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = MakeBoundLocal( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, local, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 6085, 6145);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10498_6242_6266(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 6242, 6266);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_6177_6335(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.Conversion
receiverConversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
convertedReceiverType)
{
var return_v = this_param.ConvertReceiverForInvocation( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, receiver, method, receiverConversion, convertedReceiverType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 6177, 6335);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10498_6584_6608(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 6584, 6608);
return return_v;
}


bool
f_10498_6584_6626(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.IsExtensionMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 6584, 6626);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10498_6674_6751(int
capacity)
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 6674, 6751);
return return_v;
}


int
f_10498_6770_6791(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 6770, 6791);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10498_6827_6854(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 6827, 6854);
return return_v;
}


int
f_10498_6810_6898(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
items,int
start,int
length)
{
this_param.AddRange( items, start, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 6810, 6898);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10498_6974_7002(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 6974, 7002);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10498_7375_7399(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 7375, 7399);
return return_v;
}


bool
f_10498_7375_7417(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.IsExtensionMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 7375, 7417);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_7251_7717(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
methodArgumentInfo,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiver,bool
allowExtensionAndOptionalParameters,bool
assertParametersAreOptional)
{
var return_v = this_param.SynthesizeCall( methodArgumentInfo, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, receiver, allowExtensionAndOptionalParameters: allowExtensionAndOptionalParameters, assertParametersAreOptional: assertParametersAreOptional);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 7251, 7717);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_7817_7891(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenInitialValue)
{
var return_v = this_param.MakeLocalDeclaration( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, local, rewrittenInitialValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 7817, 7891);
return return_v;
}


int
f_10498_7908_7987(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
original,ref Microsoft.CodeAnalysis.CSharp.BoundStatement
collectionVarDecl)
{
this_param.InstrumentForEachStatementCollectionVarDeclaration( original, ref collectionVarDecl);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 7908, 7987);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10498_8276_8475(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = BoundCall.Synthesized( syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, receiverOpt: (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, method: method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 8276, 8475);
return return_v;
}


bool
f_10498_8624_8636(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.Checked;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 8624, 8636);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_8173_8637(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundCall
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, rewrittenOperand: (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenOperand, conversion: conversion, rewrittenType: rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 8173, 8637);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10498_8668_8690(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.ElementConversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 8668, 8690);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
f_10498_8724_8750(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.IterationVariableType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 8724, 8750);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10498_8724_8755(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 8724, 8755);
return return_v;
}


bool
f_10498_8784_8796(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.Checked;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 8784, 8796);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_8078_8797(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, rewrittenOperand: rewrittenOperand, conversion: conversion, rewrittenType: rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 8078, 8797);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10498_8943_8966(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.IterationVariables;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 8943, 8966);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_9015_9098(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
forEachBound,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
iterationVariables,Microsoft.CodeAnalysis.CSharp.BoundExpression
iterationVarValue)
{
var return_v = this_param.LocalOrDeconstructionDeclaration( forEachBound, iterationVariables, iterationVarValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 9015, 9098);
return return_v;
}


int
f_10498_9115_9192(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
original,ref Microsoft.CodeAnalysis.CSharp.BoundStatement
iterationVarDecl)
{
this_param.InstrumentForEachStatementIterationVarDeclaration( original, ref iterationVarDecl);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 9115, 9192);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10498_9466_9572(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
iterationVariables,Microsoft.CodeAnalysis.CSharp.BoundStatement
iteratorVariableInitialization,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenBody,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
forEachSyntax)
{
var return_v = CreateBlockDeclaringIterationVariables( iterationVariables, iteratorVariableInitialization, rewrittenBody, forEachSyntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 9466, 9572);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_9624_9871(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
methodArgumentInfo,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
receiver,bool
allowExtensionAndOptionalParameters)
{
var return_v = this_param.SynthesizeCall( methodArgumentInfo: methodArgumentInfo, syntax: (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, receiver: (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, allowExtensionAndOptionalParameters: allowExtensionAndOptionalParameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 9624, 9871);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
f_10498_9944_9957(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.AwaitOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 9944, 9957);
return return_v;
}


int
f_10498_9931_9980(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 9931, 9980);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
f_10498_10078_10091(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.AwaitOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 10078, 10091);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
f_10498_10093_10106(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.AwaitOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 10093, 10106);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10498_10093_10116(Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
this_param)
{
var return_v = this_param.GetResult;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 10093, 10116);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10498_10093_10127(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ReturnType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 10093, 10127);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_10020_10140(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenExpression,Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
awaitableInfo,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,bool
used)
{
var return_v = this_param.RewriteAwaitExpression( (Microsoft.CodeAnalysis.SyntaxNode)syntax, rewrittenExpression, awaitableInfo, type, used: used);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 10020, 10140);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10498_10369_10384(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.BreakLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 10369, 10384);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10498_10418_10436(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.ContinueLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 10418, 10436);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_10199_10472(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
loop,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundBlock
rewrittenBody,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
breakLabel,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
continueLabel,bool
hasErrors)
{
var return_v = this_param.RewriteWhileStatement( loop: (Microsoft.CodeAnalysis.CSharp.BoundLoopStatement)loop, rewrittenCondition, rewrittenBody: (Microsoft.CodeAnalysis.CSharp.BoundStatement)rewrittenBody, breakLabel: breakLabel, continueLabel: continueLabel, hasErrors: hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 10199, 10472);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_10621_10724(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
forEachSyntax,Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo
enumeratorInfo,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
enumeratorType,Microsoft.CodeAnalysis.CSharp.BoundLocal
boundEnumeratorVar,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenBody)
{
var return_v = this_param.WrapWithTryFinallyDispose( forEachSyntax, enumeratorInfo, enumeratorType, boundEnumeratorVar, rewrittenBody);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 10621, 10724);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10498_10960_10996(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 10960, 10996);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10498_11031_11099(Microsoft.CodeAnalysis.CSharp.BoundStatement
item1,Microsoft.CodeAnalysis.CSharp.BoundStatement
item2)
{
var return_v = ImmutableArray.Create<BoundStatement>( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 11031, 11099);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10498_10871_11100(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock( syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, locals: locals, statements: statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 10871, 11100);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10498_11508_11544(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 11508, 11544);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10498_11579_11646(Microsoft.CodeAnalysis.CSharp.BoundStatement
item1,Microsoft.CodeAnalysis.CSharp.BoundStatement
item2)
{
var return_v = ImmutableArray.Create<BoundStatement>( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 11579, 11646);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10498_11419_11647(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock( syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, locals: locals, statements: statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 11419, 11647);
return return_v;
}


int
f_10498_11679_11723(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
original,ref Microsoft.CodeAnalysis.CSharp.BoundStatement
result)
{
this_param.InstrumentForEachStatement( original, ref result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 11679, 11723);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10498,4939,11765);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10498,4939,11765);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool TryGetDisposeMethod(CommonForEachStatementSyntax forEachSyntax, ForEachEnumeratorInfo enumeratorInfo, out MethodSymbol disposeMethod)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10498,11777,12414);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,11948,12244) || true) && (enumeratorInfo.IsAsync)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,11948,12244);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,12008,12174);

disposeMethod = (MethodSymbol)f_10498_12038_12173(_compilation, WellKnownMember.System_IAsyncDisposable__DisposeAsync, _diagnostics, syntax: forEachSyntax);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,12192,12229);

return (object)disposeMethod != null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,11948,12244);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,12260,12403);

return f_10498_12267_12402(_compilation, SpecialMember.System_IDisposable__Dispose, forEachSyntax, _diagnostics, out disposeMethod);
DynAbs.Tracing.TraceSender.TraceExitMethod(10498,11777,12414);

Microsoft.CodeAnalysis.CSharp.Symbol
f_10498_12038_12173(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.WellKnownMember
member,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax)
{
var return_v = Binder.GetWellKnownTypeMember( compilation, member, diagnostics, syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 12038, 12173);
return return_v;
}


bool
f_10498_12267_12402(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SpecialMember
specialMember,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
symbol)
{
var return_v = Binder.TryGetSpecialTypeMember( compilation, specialMember, (Microsoft.CodeAnalysis.SyntaxNode)syntax, diagnostics, out symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 12267, 12402);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10498,11777,12414);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10498,11777,12414);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement WrapWithTryFinallyDispose(
            CommonForEachStatementSyntax forEachSyntax,
            ForEachEnumeratorInfo enumeratorInfo,
            TypeSymbol enumeratorType,
            BoundLocal boundEnumeratorVar,
            BoundStatement rewrittenBody)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10498,12783,22485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,13092,13135);

f_10498_13092_13134(enumeratorInfo.NeedsDisposal);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,13151,13197);

NamedTypeSymbol? 
idisposableTypeSymbol = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,13211,13235);

bool 
isImplicit = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,13249,13321);

MethodSymbol? 
disposeMethod = f_10498_13279_13320_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(enumeratorInfo.PatternDisposeInfo, 10498, 13279, 13320)?.Method)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,13354,14059) || true) && (disposeMethod is null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,13354,14059);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,13413,13483);

f_10498_13413_13482(this, forEachSyntax, enumeratorInfo, out disposeMethod);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,13522,13575);

idisposableTypeSymbol = f_10498_13546_13574(disposeMethod);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,13593,13639);

f_10498_13593_13638(f_10498_13606_13630(_factory)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,13657,13751);

var 
conversions = f_10498_13675_13750(f_10498_13695_13749(f_10498_13695_13738(f_10498_13695_13719(_factory))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,13771,13822);

HashSet<DiagnosticInfo>? 
useSiteDiagnostics = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,13840,13974);

isImplicit = f_10498_13853_13962(conversions, enumeratorType, idisposableTypeSymbol, ref useSiteDiagnostics).IsImplicit;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,13992,14044);

f_10498_13992_14043(                _diagnostics, forEachSyntax, useSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,13354,14059);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,14075,14487);

f_10498_14075_14486(_diagnostics, disposeMethod, forEachSyntax, hasBaseReceiver: false, containingMember: f_10498_14292_14316(_factory), containingType: f_10498_14382_14402(_factory), location: enumeratorInfo.Location);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,14503,14530);

BoundBlock 
finallyBlockOpt
=default(BoundBlock);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,14544,21718) || true) && (isImplicit ||(DynAbs.Tracing.TraceSender.Expression_False(10498, 14548, 14606)||!(enumeratorInfo.PatternDisposeInfo is null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,14544,21718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,14640,14795);

Conversion 
receiverConversion = (DynAbs.Tracing.TraceSender.Conditional_F1(10498, 14672, 14701)||((f_10498_14672_14701(enumeratorType)&&DynAbs.Tracing.TraceSender.Conditional_F2(10498, 14725, 14742))||DynAbs.Tracing.TraceSender.Conditional_F3(10498, 14766, 14794)))?                    Conversion.Boxing :                    Conversion.ImplicitReference
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,14815,14840);

BoundExpression 
receiver
=default(BoundExpression);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,14858,14886);

BoundExpression 
disposeCall
=default(BoundExpression);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,14904,14956);

var 
disposeInfo = enumeratorInfo.PatternDisposeInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,14974,15464) || true) && (disposeInfo is null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,14974,15464);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,15039,15082);

f_10498_15039_15081(idisposableTypeSymbol is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,15104,15178);

disposeInfo = f_10498_15118_15177(disposeMethod);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,15200,15333);

receiver = f_10498_15211_15332(this, forEachSyntax, boundEnumeratorVar, disposeMethod, receiverConversion, idisposableTypeSymbol);
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,14974,15464);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,14974,15464);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,15415,15445);

receiver = boundEnumeratorVar;
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,14974,15464);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,15618,15701);

disposeCall = f_10498_15632_15700(this, disposeInfo, forEachSyntax, receiver);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,15721,15757);

BoundStatement 
disposeCallStatement
=default(BoundStatement);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,15775,15841);

var 
disposeAwaitableInfoOpt = enumeratorInfo.DisposeAwaitableInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,15859,16380) || true) && (disposeAwaitableInfoOpt != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,15859,16380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,15984,16074);

disposeCallStatement = f_10498_16007_16073(this, forEachSyntax, disposeCall, disposeAwaitableInfoOpt);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,16096,16131);

_sawAwaitInExceptionHandler = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,15859,16380);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,15859,16380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,16281,16361);

disposeCallStatement = f_10498_16304_16360(forEachSyntax, disposeCall);
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,15859,16380);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,16400,16440);

BoundStatement 
alwaysOrMaybeDisposeStmt
=default(BoundStatement);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,16458,18427) || true) && (f_10498_16462_16488(enumeratorType))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,16458,18427);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,16607,16700);

f_10498_16607_16699(f_10498_16620_16665(f_10498_16620_16653(enumeratorType))!= SpecialType.System_Nullable_T);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,16801,16849);

alwaysOrMaybeDisposeStmt = disposeCallStatement;
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,16458,18427);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,16458,18427);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,17135,18408);

alwaysOrMaybeDisposeStmt = f_10498_17162_18407(syntax: forEachSyntax, rewrittenCondition: f_10498_17275_18238(forEachSyntax, operatorKind: BinaryOperatorKind.NotEqual, left: f_10498_17421_17803(this, syntax: forEachSyntax, rewrittenOperand: boundEnumeratorVar, conversion: enumeratorInfo.EnumeratorConversion, rewrittenType: f_10498_17698_17752(_compilation, SpecialType.System_Object), @checked: false), right: f_10498_17841_17980(this, forEachSyntax, constantValue: f_10498_17916_17934(), type: null), constantValueOpt: null, methodOpt: null, resultKind: LookupResultKind.Viable, type: f_10498_18182_18237(_compilation, SpecialType.System_Boolean)), rewrittenConsequence: disposeCallStatement, rewrittenAlternativeOpt: null, hasErrors: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,16458,18427);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,18447,18641);

finallyBlockOpt = f_10498_18465_18640(forEachSyntax, locals: ImmutableArray<LocalSymbol>.Empty, statements: f_10498_18592_18639(alwaysOrMaybeDisposeStmt));
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,14544,21718);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,14544,21718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,18914,18953);

f_10498_18914_18952(f_10498_18927_18951_M(!enumeratorType.IsSealed));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,18971,19009);

f_10498_18971_19008(!enumeratorInfo.IsAsync);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,19027,19070);

f_10498_19027_19069(idisposableTypeSymbol is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,19088,19123);

f_10498_19088_19122(disposeMethod is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,19177,19254);

LocalSymbol 
disposableVar = f_10498_19205_19253(_factory, idisposableTypeSymbol)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,19310,19410);

BoundLocal 
boundDisposableVar = f_10498_19342_19409(forEachSyntax, disposableVar, idisposableTypeSymbol)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,19430,19603);

BoundTypeExpression 
boundIDisposableTypeExpr = f_10498_19477_19602(forEachSyntax, aliasOpt: null, type: idisposableTypeSymbol)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,19660,20009);

BoundExpression 
disposableVarInitValue = f_10498_19701_20008(forEachSyntax, operand: boundEnumeratorVar, targetType: boundIDisposableTypeExpr, conversion: Conversion.ExplicitReference, type: idisposableTypeSymbol)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,20083,20193);

BoundStatement 
disposableVarDecl = f_10498_20118_20192(this, forEachSyntax, disposableVar, disposableVarInitValue)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,20245,20376);

BoundExpression 
disposeCall = f_10498_20275_20375(syntax: forEachSyntax, receiverOpt: boundDisposableVar, method: disposeMethod)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,20394,20501);

BoundStatement 
disposeCallStatement = f_10498_20432_20500(forEachSyntax, expression: disposeCall)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,20569,21383);

BoundStatement 
ifStmt = f_10498_20593_21382(syntax: forEachSyntax, rewrittenCondition: f_10498_20698_21225(forEachSyntax, operatorKind: BinaryOperatorKind.NotEqual, left: boundDisposableVar, right: f_10498_20910_20983(this, forEachSyntax, constantValue: f_10498_20952_20970(), type: null), constantValueOpt: null, methodOpt: null, resultKind: LookupResultKind.Viable, type: f_10498_21169_21224(_compilation, SpecialType.System_Boolean)), rewrittenConsequence: disposeCallStatement, rewrittenAlternativeOpt: null, hasErrors: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,21505,21703);

finallyBlockOpt = f_10498_21523_21702(forEachSyntax, locals: f_10498_21582_21618(disposableVar), statements: f_10498_21653_21701(disposableVarDecl, ifStmt));
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,14544,21718);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,22048,22442);

BoundStatement 
tryFinally = f_10498_22076_22441(forEachSyntax, tryBlock: f_10498_22140_22320(forEachSyntax, locals: ImmutableArray<LocalSymbol>.Empty, statements: f_10498_22267_22319(rewrittenBody)), catchBlocks: ImmutableArray<BoundCatchBlock>.Empty, finallyBlockOpt: finallyBlockOpt)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,22456,22474);

return tryFinally;
DynAbs.Tracing.TraceSender.TraceExitMethod(10498,12783,22485);

int
f_10498_13092_13134(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 13092, 13134);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10498_13279_13320_M(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 13279, 13320);
return return_v;
}


bool
f_10498_13413_13482(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
forEachSyntax,Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo
enumeratorInfo,out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
disposeMethod)
{
var return_v = this_param.TryGetDisposeMethod( forEachSyntax, enumeratorInfo, out disposeMethod);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 13413, 13482);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10498_13546_13574(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 13546, 13574);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10498_13606_13630(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.CurrentFunction ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 13606, 13630);
return return_v;
}


int
f_10498_13593_13638(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 13593, 13638);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10498_13695_13719(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.CurrentFunction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 13695, 13719);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
f_10498_13695_13738(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ContainingAssembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 13695, 13738);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
f_10498_13695_13749(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
this_param)
{
var return_v = this_param.CorLibrary;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 13695, 13749);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.TypeConversions
f_10498_13675_13750(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
corLibrary)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.TypeConversions( corLibrary);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 13675, 13750);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10498_13853_13962(Microsoft.CodeAnalysis.CSharp.TypeConversions
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
source,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
destination,ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
useSiteDiagnostics)
{
var return_v = this_param.ClassifyImplicitConversionFromType( source, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)destination, ref useSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 13853, 13962);
return return_v;
}


bool
f_10498_13992_14043(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
node,System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
useSiteDiagnostics)
{
var return_v = diagnostics.Add( (Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 13992, 14043);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10498_14292_14316(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.CurrentFunction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 14292, 14316);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
f_10498_14382_14402(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.CurrentType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 14382, 14402);
return return_v;
}


int
f_10498_14075_14486(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
symbol,Microsoft.CodeAnalysis.SyntaxNode
node,bool
hasBaseReceiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
containingMember,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
containingType,Microsoft.CodeAnalysis.CSharp.BinderFlags
location)
{
Binder.ReportDiagnosticsIfObsolete( diagnostics, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)node, hasBaseReceiver: hasBaseReceiver, containingMember: (Microsoft.CodeAnalysis.CSharp.Symbol?)containingMember, containingType: containingType, location: location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 14075, 14486);
return 0;
}


bool
f_10498_14672_14701(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsStructType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 14672, 14701);
return return_v;
}


int
f_10498_15039_15081(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 15039, 15081);
return 0;
}


Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
f_10498_15118_15177(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = MethodArgumentInfo.CreateParameterlessMethod( method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 15118, 15177);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_15211_15332(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.Conversion
receiverConversion,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
convertedReceiverType)
{
var return_v = this_param.ConvertReceiverForInvocation( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, receiverConversion, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)convertedReceiverType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 15211, 15332);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_15632_15700(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
methodArgumentInfo,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.MakeCallWithNoExplicitArgument( methodArgumentInfo, (Microsoft.CodeAnalysis.SyntaxNode)syntax, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 15632, 15700);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_16007_16073(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
forEachSyntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
disposeCall,Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
disposeAwaitableInfoOpt)
{
var return_v = this_param.WrapWithAwait( forEachSyntax, disposeCall, disposeAwaitableInfoOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 16007, 16073);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10498_16304_16360(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement( (Microsoft.CodeAnalysis.SyntaxNode)syntax, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 16304, 16360);
return return_v;
}


bool
f_10498_16462_16488(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.IsValueType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 16462, 16488);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10498_16620_16653(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.OriginalDefinition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 16620, 16653);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10498_16620_16665(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 16620, 16665);
return return_v;
}


int
f_10498_16607_16699(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 16607, 16699);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10498_17698_17752(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 17698, 17752);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_17421_17803(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, rewrittenOperand: (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenOperand, conversion: conversion, rewrittenType: (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 17421, 17803);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10498_17916_17934()
{
var return_v = ConstantValue.Null;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 17916, 17934);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_17841_17980(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
type)
{
var return_v = this_param.MakeLiteral( (Microsoft.CodeAnalysis.SyntaxNode)syntax, constantValue: constantValue, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 17841, 17980);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10498_18182_18237(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 18182, 18237);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10498_17275_18238(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
methodOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator( (Microsoft.CodeAnalysis.SyntaxNode)syntax, operatorKind: operatorKind, left: left, right: right, constantValueOpt: constantValueOpt, methodOpt: methodOpt, resultKind: resultKind, type: (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 17275, 18238);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_17162_18407(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenConsequence,Microsoft.CodeAnalysis.CSharp.BoundStatement?
rewrittenAlternativeOpt,bool
hasErrors)
{
var return_v = RewriteIfStatement( syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, rewrittenCondition: (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenCondition, rewrittenConsequence: rewrittenConsequence, rewrittenAlternativeOpt: rewrittenAlternativeOpt, hasErrors: hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 17162, 18407);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10498_18592_18639(Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 18592, 18639);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10498_18465_18640(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock( (Microsoft.CodeAnalysis.SyntaxNode)syntax, locals: locals, statements: statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 18465, 18640);
return return_v;
}


bool
f_10498_18927_18951_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 18927, 18951);
return return_v;
}


int
f_10498_18914_18952(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 18914, 18952);
return 0;
}


int
f_10498_18971_19008(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 18971, 19008);
return 0;
}


int
f_10498_19027_19069(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 19027, 19069);
return 0;
}


int
f_10498_19088_19122(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 19088, 19122);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10498_19205_19253(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = this_param.SynthesizedLocal( (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 19205, 19253);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10498_19342_19409(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = MakeBoundLocal( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, local, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 19342, 19409);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
f_10498_19477_19602(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol?
aliasOpt,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTypeExpression( (Microsoft.CodeAnalysis.SyntaxNode)syntax, aliasOpt: aliasOpt, type: (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 19477, 19602);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAsOperator
f_10498_19701_20008(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
operand,Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
targetType,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundAsOperator( (Microsoft.CodeAnalysis.SyntaxNode)syntax, operand: (Microsoft.CodeAnalysis.CSharp.BoundExpression)operand, targetType: targetType, conversion: conversion, type: (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 19701, 20008);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_20118_20192(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenInitialValue)
{
var return_v = this_param.MakeLocalDeclaration( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, local, rewrittenInitialValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 20118, 20192);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10498_20275_20375(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = BoundCall.Synthesized( syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, receiverOpt: (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, method: method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 20275, 20375);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10498_20432_20500(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement( (Microsoft.CodeAnalysis.SyntaxNode)syntax, expression: expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 20432, 20500);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10498_20952_20970()
{
var return_v = ConstantValue.Null;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 20952, 20970);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_20910_20983(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
type)
{
var return_v = this_param.MakeLiteral( (Microsoft.CodeAnalysis.SyntaxNode)syntax, constantValue: constantValue, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 20910, 20983);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10498_21169_21224(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 21169, 21224);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10498_20698_21225(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundLocal
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
methodOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator( (Microsoft.CodeAnalysis.SyntaxNode)syntax, operatorKind: operatorKind, left: (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right: right, constantValueOpt: constantValueOpt, methodOpt: methodOpt, resultKind: resultKind, type: (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 20698, 21225);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_20593_21382(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenConsequence,Microsoft.CodeAnalysis.CSharp.BoundStatement?
rewrittenAlternativeOpt,bool
hasErrors)
{
var return_v = RewriteIfStatement( syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, rewrittenCondition: (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenCondition, rewrittenConsequence: rewrittenConsequence, rewrittenAlternativeOpt: rewrittenAlternativeOpt, hasErrors: hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 20593, 21382);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10498_21582_21618(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 21582, 21618);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10498_21653_21701(Microsoft.CodeAnalysis.CSharp.BoundStatement
item1,Microsoft.CodeAnalysis.CSharp.BoundStatement
item2)
{
var return_v = ImmutableArray.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 21653, 21701);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10498_21523_21702(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock( (Microsoft.CodeAnalysis.SyntaxNode)syntax, locals: locals, statements: statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 21523, 21702);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10498_22267_22319(Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
var return_v = ImmutableArray.Create<BoundStatement>( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 22267, 22319);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10498_22140_22320(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock( (Microsoft.CodeAnalysis.SyntaxNode)syntax, locals: locals, statements: statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 22140, 22320);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundTryStatement
f_10498_22076_22441(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundBlock
tryBlock,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
catchBlocks,Microsoft.CodeAnalysis.CSharp.BoundBlock
finallyBlockOpt)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTryStatement( (Microsoft.CodeAnalysis.SyntaxNode)syntax, tryBlock: tryBlock, catchBlocks: catchBlocks, finallyBlockOpt: finallyBlockOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 22076, 22441);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10498,12783,22485);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10498,12783,22485);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement WrapWithAwait(CommonForEachStatementSyntax forEachSyntax, BoundExpression disposeCall, BoundAwaitableInfo disposeAwaitableInfoOpt)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10498,22604,23116);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,22782,22889);

TypeSymbol 
awaitExpressionType = f_10498_22815_22860_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10498_22815_22848(disposeAwaitableInfoOpt), 10498, 22815, 22860)?.ReturnType)??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10498, 22815, 22888)??f_10498_22864_22888(_compilation))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,22903,23029);

var 
awaitExpr = f_10498_22919_23028(this, forEachSyntax, disposeCall, disposeAwaitableInfoOpt, awaitExpressionType, used: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,23043,23105);

return f_10498_23050_23104(forEachSyntax, awaitExpr);
DynAbs.Tracing.TraceSender.TraceExitMethod(10498,22604,23116);

Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10498_22815_22848(Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
this_param)
{
var return_v = this_param.GetResult;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 22815, 22848);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10498_22815_22860_M(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 22815, 22860);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10498_22864_22888(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.DynamicType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 22864, 22888);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_22919_23028(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenExpression,Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
awaitableInfo,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,bool
used)
{
var return_v = this_param.RewriteAwaitExpression( (Microsoft.CodeAnalysis.SyntaxNode)syntax, rewrittenExpression, awaitableInfo, type, used: used);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 22919, 23028);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10498_23050_23104(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement( (Microsoft.CodeAnalysis.SyntaxNode)syntax, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 23050, 23104);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10498,22604,23116);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10498,22604,23116);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression ConvertReceiverForInvocation(CSharpSyntaxNode syntax, BoundExpression receiver, MethodSymbol method, Conversion receiverConversion, TypeSymbol convertedReceiverType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10498,23984,26261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,24198,24233);

f_10498_24198_24232(f_10498_24211_24224(receiver)is { });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,24247,26218) || true) && (f_10498_24251_24281_M(!f_10498_24252_24265(receiver).IsReferenceType)&&(DynAbs.Tracing.TraceSender.Expression_True(10498, 24251, 24318)&&f_10498_24285_24318(f_10498_24285_24306(method))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,24247,26218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,24352,24433);

f_10498_24352_24432(receiverConversion.IsImplicit &&(DynAbs.Tracing.TraceSender.Expression_True(10498, 24365, 24431)&&f_10498_24398_24431_M(!receiverConversion.IsUserDefined)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,24247,26218);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,24247,26218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,25872,25916);

f_10498_25872_25915(f_10498_25885_25914_M(!receiverConversion.IsNumeric));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,25936,26203);

receiver = f_10498_25947_26202(this, syntax: syntax, rewrittenOperand: receiver, conversion: receiverConversion, @checked: false, rewrittenType: convertedReceiverType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,24247,26218);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,26234,26250);

return receiver;
DynAbs.Tracing.TraceSender.TraceExitMethod(10498,23984,26261);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10498_24211_24224(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 24211, 24224);
return return_v;
}


int
f_10498_24198_24232(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 24198, 24232);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10498_24252_24265(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 24252, 24265);
return return_v;
}


bool
f_10498_24251_24281_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 24251, 24281);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10498_24285_24306(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 24285, 24306);
return return_v;
}


bool
f_10498_24285_24318(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.IsInterface;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 24285, 24318);
return return_v;
}


bool
f_10498_24398_24431_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 24398, 24431);
return return_v;
}


int
f_10498_24352_24432(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 24352, 24432);
return 0;
}


bool
f_10498_25885_25914_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 25885, 25914);
return return_v;
}


int
f_10498_25872_25915(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 25872, 25915);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_25947_26202(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,bool
@checked,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType)
{
var return_v = this_param.MakeConversionNode( syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, rewrittenOperand: rewrittenOperand, conversion: conversion, @checked: @checked, rewrittenType: rewrittenType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 25947, 26202);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10498,23984,26261);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10498,23984,26261);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression SynthesizeCall(MethodArgumentInfo methodArgumentInfo, CSharpSyntaxNode syntax, BoundExpression? receiver, bool allowExtensionAndOptionalParameters, bool assertParametersAreOptional = true)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10498,26273,27111);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,26510,26833) || true) && (allowExtensionAndOptionalParameters)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,26510,26833);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,26713,26818);

return f_10498_26720_26817(this, methodArgumentInfo, syntax, receiver, assertParametersAreOptional);
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,26510,26833);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,26911,26962);

f_10498_26911_26961(methodArgumentInfo.Arguments.IsEmpty);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,26976,27100);

return f_10498_26983_27099(syntax, receiver, f_10498_27023_27048(methodArgumentInfo), arguments: ImmutableArray<BoundExpression>.Empty);
DynAbs.Tracing.TraceSender.TraceExitMethod(10498,26273,27111);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_26720_26817(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
methodArgumentInfo,Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
expression,bool
assertParametersAreOptional)
{
var return_v = this_param.MakeCallWithNoExplicitArgument( methodArgumentInfo, (Microsoft.CodeAnalysis.SyntaxNode)syntax, expression, assertParametersAreOptional);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 26720, 26817);
return return_v;
}


int
f_10498_26911_26961(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 26911, 26961);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10498_27023_27048(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 27023, 27048);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10498_26983_27099(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments)
{
var return_v = BoundCall.Synthesized( (Microsoft.CodeAnalysis.SyntaxNode)syntax, receiverOpt, method, arguments: arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 26983, 27099);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10498,26273,27111);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10498,26273,27111);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement RewriteForEachStatementAsFor(BoundForEachStatement node, MethodSymbol indexerGet, MethodSymbol lengthGet)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10498,27736,32751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,27889,27951);

var 
forEachSyntax = (CommonForEachStatementSyntax)node.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,27967,28047);

BoundExpression 
collectionExpression = f_10498_28006_28046(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,28061,28139);

NamedTypeSymbol? 
collectionType = (NamedTypeSymbol?)f_10498_28113_28138(collectionExpression)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,28153,28189);

f_10498_28153_28188(collectionType is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,28205,28280);

TypeSymbol 
intType = f_10498_28226_28279(_compilation, SpecialType.System_Int32)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,28294,28372);

TypeSymbol 
boolType = f_10498_28316_28371(_compilation, SpecialType.System_Boolean)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,28388,28464);

BoundExpression 
rewrittenExpression = f_10498_28426_28463(this, collectionExpression)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,28478,28536);

BoundStatement? 
rewrittenBody = f_10498_28510_28535(this, f_10498_28525_28534(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,28550,28585);

f_10498_28550_28584(rewrittenBody is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,28630,28757);

LocalSymbol 
collectionTemp = f_10498_28659_28756(_factory, collectionType, forEachSyntax, kind: SynthesizedLocalKind.ForEachArray)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,28825,28928);

BoundStatement 
arrayVarDecl = f_10498_28855_28927(this, forEachSyntax, collectionTemp, rewrittenExpression)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,28944,29019);

f_10498_28944_29018(this, node, ref arrayVarDecl);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,29067,29156);

BoundLocal 
boundArrayVar = f_10498_29094_29155(forEachSyntax, collectionTemp, collectionType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,29194,29324);

LocalSymbol 
positionVar = f_10498_29220_29323(_factory, intType, syntax: forEachSyntax, kind: SynthesizedLocalKind.ForEachArrayIndex)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,29372,29454);

BoundLocal 
boundPositionVar = f_10498_29402_29453(forEachSyntax, positionVar, intType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,29497,29682);

BoundStatement 
positionVarDecl = f_10498_29530_29681(this, forEachSyntax, positionVar, f_10498_29596_29680(this, forEachSyntax, f_10498_29623_29670(SpecialType.System_Int32), intType))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,29722,30205);

BoundExpression 
iterationVarInitValue = f_10498_29762_30204(this, syntax: forEachSyntax, rewrittenOperand: f_10498_29857_30044(syntax: forEachSyntax, receiverOpt: boundArrayVar, indexerGet, boundPositionVar), conversion: f_10498_30075_30097(node), rewrittenType: f_10498_30131_30162(f_10498_30131_30157(node)), @checked: f_10498_30191_30203(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,30289,30362);

ImmutableArray<LocalSymbol> 
iterationVariables = f_10498_30338_30361(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,30376,30497);

BoundStatement 
iterationVariableDecl = f_10498_30415_30496(this, node, iterationVariables, iterationVarInitValue)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,30513,30596);

f_10498_30513_30595(this, node, ref iterationVariableDecl);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,30612,30786);

BoundStatement 
initializer = f_10498_30641_30785(forEachSyntax, statements: f_10498_30716_30784(arrayVarDecl, positionVarDecl))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,30827,30993);

BoundExpression 
arrayLength = f_10498_30857_30992(syntax: forEachSyntax, receiverOpt: boundArrayVar, lengthGet)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,31038,31438);

BoundExpression 
exitCondition = f_10498_31070_31437(syntax: forEachSyntax, operatorKind: BinaryOperatorKind.IntLessThan, left: boundPositionVar, right: arrayLength, constantValueOpt: null, methodOpt: null, resultKind: LookupResultKind.Viable, type: boolType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,31481,31580);

BoundStatement 
positionIncrement = f_10498_31516_31579(this, forEachSyntax, boundPositionVar, intType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,31741,31879);

BoundStatement 
loopBody = f_10498_31767_31878(iterationVariables, iterationVariableDecl, rewrittenBody, forEachSyntax)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,32114,32649);

BoundStatement 
result = f_10498_32138_32648(this, original: node, outerLocals: f_10498_32240_32303(collectionTemp, positionVar), rewrittenInitializer: initializer, rewrittenCondition: exitCondition, rewrittenIncrement: positionIncrement, rewrittenBody: loopBody, breakLabel: f_10498_32536_32551(node), continueLabel: f_10498_32585_32603(node), hasErrors: f_10498_32633_32647(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,32665,32710);

f_10498_32665_32709(this, node, ref result);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,32726,32740);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10498,27736,32751);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_28006_28046(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
node)
{
var return_v = GetUnconvertedCollectionExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 28006, 28046);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10498_28113_28138(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 28113, 28138);
return return_v;
}


int
f_10498_28153_28188(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 28153, 28188);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10498_28226_28279(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 28226, 28279);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10498_28316_28371(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 28316, 28371);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10498_28426_28463(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 28426, 28463);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_28525_28534(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 28525, 28534);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10498_28510_28535(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
node)
{
var return_v = this_param.VisitStatement( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 28510, 28535);
return return_v;
}


int
f_10498_28550_28584(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 28550, 28584);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10498_28659_28756(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.SynthesizedLocalKind
kind)
{
var return_v = this_param.SynthesizedLocal( (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, (Microsoft.CodeAnalysis.SyntaxNode)syntax, kind: kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 28659, 28756);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_28855_28927(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenInitialValue)
{
var return_v = this_param.MakeLocalDeclaration( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, local, rewrittenInitialValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 28855, 28927);
return return_v;
}


int
f_10498_28944_29018(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
original,ref Microsoft.CodeAnalysis.CSharp.BoundStatement
collectionVarDecl)
{
this_param.InstrumentForEachStatementCollectionVarDeclaration( original, ref collectionVarDecl);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 28944, 29018);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10498_29094_29155(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = MakeBoundLocal( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, local, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 29094, 29155);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10498_29220_29323(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.SynthesizedLocalKind
kind)
{
var return_v = this_param.SynthesizedLocal( type, syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, kind: kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 29220, 29323);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10498_29402_29453(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = MakeBoundLocal( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, local, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 29402, 29453);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10498_29623_29670(Microsoft.CodeAnalysis.SpecialType
st)
{
var return_v = ConstantValue.Default( st);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 29623, 29670);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_29596_29680(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeLiteral( (Microsoft.CodeAnalysis.SyntaxNode)syntax, constantValue, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 29596, 29680);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_29530_29681(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenInitialValue)
{
var return_v = this_param.MakeLocalDeclaration( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, local, rewrittenInitialValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 29530, 29681);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10498_29857_30044(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundLocal
arg0)
{
var return_v = BoundCall.Synthesized( syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, receiverOpt: (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 29857, 30044);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10498_30075_30097(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.ElementConversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 30075, 30097);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
f_10498_30131_30157(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.IterationVariableType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 30131, 30157);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10498_30131_30162(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 30131, 30162);
return return_v;
}


bool
f_10498_30191_30203(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.Checked;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 30191, 30203);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_29762_30204(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundCall
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, rewrittenOperand: (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenOperand, conversion: conversion, rewrittenType: rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 29762, 30204);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10498_30338_30361(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.IterationVariables;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 30338, 30361);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_30415_30496(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
forEachBound,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
iterationVariables,Microsoft.CodeAnalysis.CSharp.BoundExpression
iterationVarValue)
{
var return_v = this_param.LocalOrDeconstructionDeclaration( forEachBound, iterationVariables, iterationVarValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 30415, 30496);
return return_v;
}


int
f_10498_30513_30595(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
original,ref Microsoft.CodeAnalysis.CSharp.BoundStatement
iterationVarDecl)
{
this_param.InstrumentForEachStatementIterationVarDeclaration( original, ref iterationVarDecl);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 30513, 30595);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10498_30716_30784(Microsoft.CodeAnalysis.CSharp.BoundStatement
item1,Microsoft.CodeAnalysis.CSharp.BoundStatement
item2)
{
var return_v = ImmutableArray.Create<BoundStatement>( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 30716, 30784);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatementList
f_10498_30641_30785(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundStatementList( (Microsoft.CodeAnalysis.SyntaxNode)syntax, statements: statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 30641, 30785);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10498_30857_30992(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = BoundCall.Synthesized( syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, receiverOpt: (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 30857, 30992);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10498_31070_31437(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundLocal
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
methodOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator( syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, operatorKind: operatorKind, left: (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right: right, constantValueOpt: constantValueOpt, methodOpt: methodOpt, resultKind: resultKind, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 31070, 31437);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_31516_31579(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
boundPositionVar,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
intType)
{
var return_v = this_param.MakePositionIncrement( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, boundPositionVar, intType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 31516, 31579);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10498_31767_31878(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
iterationVariables,Microsoft.CodeAnalysis.CSharp.BoundStatement
iteratorVariableInitialization,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenBody,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
forEachSyntax)
{
var return_v = CreateBlockDeclaringIterationVariables( iterationVariables, iteratorVariableInitialization, rewrittenBody, forEachSyntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 31767, 31878);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10498_32240_32303(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item1,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item2)
{
var return_v = ImmutableArray.Create<LocalSymbol>( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 32240, 32303);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10498_32536_32551(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.BreakLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 32536, 32551);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10498_32585_32603(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.ContinueLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 32585, 32603);
return return_v;
}


bool
f_10498_32633_32647(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.HasErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 32633, 32647);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_32138_32648(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
original,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
outerLocals,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenInitializer,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenIncrement,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenBody,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
breakLabel,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
continueLabel,bool
hasErrors)
{
var return_v = this_param.RewriteForStatementWithoutInnerLocals( original: (Microsoft.CodeAnalysis.CSharp.BoundLoopStatement)original, outerLocals: outerLocals, rewrittenInitializer: rewrittenInitializer, rewrittenCondition: rewrittenCondition, rewrittenIncrement: rewrittenIncrement, rewrittenBody: rewrittenBody, breakLabel: breakLabel, continueLabel: continueLabel, hasErrors: hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 32138, 32648);
return return_v;
}


int
f_10498_32665_32709(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
original,ref Microsoft.CodeAnalysis.CSharp.BoundStatement
result)
{
this_param.InstrumentForEachStatement( original, ref result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 32665, 32709);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10498,27736,32751);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10498,27736,32751);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement LocalOrDeconstructionDeclaration(
            BoundForEachStatement forEachBound,
            ImmutableArray<LocalSymbol> iterationVariables,
            BoundExpression iterationVarValue)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10498,33144,34478);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,33383,33453);

var 
forEachSyntax = (CommonForEachStatementSyntax)forEachBound.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,33469,33501);

BoundStatement 
iterationVarDecl
=default(BoundStatement);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,33515,33592);

BoundForEachDeconstructStep? 
deconstruction = f_10498_33561_33591(forEachBound)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,33608,34427) || true) && (deconstruction == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,33608,34427);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,33711,33756);

f_10498_33711_33755(iterationVariables.Length == 1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,33774,33871);

iterationVarDecl = f_10498_33793_33870(this, forEachSyntax, iterationVariables[0], iterationVarValue);
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,33608,34427);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,33608,34427);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,33989,34046);

var 
assignment = f_10498_34006_34045(deconstruction)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,34066,34145);

f_10498_34066_34144(this, f_10498_34092_34124(deconstruction), iterationVarValue);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,34163,34227);

BoundExpression 
loweredAssignment = f_10498_34199_34226(this, assignment)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,34245,34331);

iterationVarDecl = f_10498_34264_34330(assignment.Syntax, loweredAssignment);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,34349,34412);

f_10498_34349_34411(this, f_10498_34378_34410(deconstruction));
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,33608,34427);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,34443,34467);

return iterationVarDecl;
DynAbs.Tracing.TraceSender.TraceExitMethod(10498,33144,34478);

Microsoft.CodeAnalysis.CSharp.BoundForEachDeconstructStep?
f_10498_33561_33591(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.DeconstructionOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 33561, 33591);
return return_v;
}


int
f_10498_33711_33755(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 33711, 33755);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_33793_33870(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenInitialValue)
{
var return_v = this_param.MakeLocalDeclaration( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, local, rewrittenInitialValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 33793, 33870);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
f_10498_34006_34045(Microsoft.CodeAnalysis.CSharp.BoundForEachDeconstructStep
this_param)
{
var return_v = this_param.DeconstructionAssignment;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 34006, 34045);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
f_10498_34092_34124(Microsoft.CodeAnalysis.CSharp.BoundForEachDeconstructStep
this_param)
{
var return_v = this_param.TargetPlaceholder;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 34092, 34124);
return return_v;
}


int
f_10498_34066_34144(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
placeholder,Microsoft.CodeAnalysis.CSharp.BoundExpression
value)
{
this_param.AddPlaceholderReplacement( (Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase)placeholder, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 34066, 34144);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10498_34199_34226(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
node)
{
var return_v = this_param.VisitExpression( (Microsoft.CodeAnalysis.CSharp.BoundExpression)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 34199, 34226);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10498_34264_34330(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement( syntax, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 34264, 34330);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
f_10498_34378_34410(Microsoft.CodeAnalysis.CSharp.BoundForEachDeconstructStep
this_param)
{
var return_v = this_param.TargetPlaceholder;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 34378, 34410);
return return_v;
}


int
f_10498_34349_34411(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
placeholder)
{
this_param.RemovePlaceholderReplacement( (Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase)placeholder);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 34349, 34411);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10498,33144,34478);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10498,33144,34478);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static BoundBlock CreateBlockDeclaringIterationVariables(
            ImmutableArray<LocalSymbol> iterationVariables,
            BoundStatement iteratorVariableInitialization,
            BoundStatement rewrittenBody,
            CommonForEachStatementSyntax forEachSyntax)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10498,34490,35660);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,35450,35649);

return f_10498_35457_35648(forEachSyntax, locals: iterationVariables, statements: f_10498_35579_35647(iteratorVariableInitialization, rewrittenBody));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10498,34490,35660);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10498_35579_35647(Microsoft.CodeAnalysis.CSharp.BoundStatement
item1,Microsoft.CodeAnalysis.CSharp.BoundStatement
item2)
{
var return_v = ImmutableArray.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 35579, 35647);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10498_35457_35648(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock( (Microsoft.CodeAnalysis.SyntaxNode)syntax, locals: locals, statements: statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 35457, 35648);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10498,34490,35660);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10498,34490,35660);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static BoundBlock CreateBlockDeclaringIterationVariables(
            ImmutableArray<LocalSymbol> iterationVariables,
            BoundStatement iteratorVariableInitialization,
            BoundStatement checkAndBreak,
            BoundStatement rewrittenBody,
            LabelSymbol continueLabel,
            CommonForEachStatementSyntax forEachSyntax)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10498,35672,37086);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,36721,37075);

return f_10498_36728_37074(forEachSyntax, locals: iterationVariables, statements: f_10498_36850_37073(iteratorVariableInitialization, checkAndBreak, rewrittenBody, f_10498_37019_37072(forEachSyntax, continueLabel)));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10498,35672,37086);

Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
f_10498_37019_37072(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement( (Microsoft.CodeAnalysis.SyntaxNode)syntax, label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 37019, 37072);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10498_36850_37073(Microsoft.CodeAnalysis.CSharp.BoundStatement
item1,Microsoft.CodeAnalysis.CSharp.BoundStatement
item2,Microsoft.CodeAnalysis.CSharp.BoundStatement
item3,Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
item4)
{
var return_v = ImmutableArray.Create( item1, item2, item3, (Microsoft.CodeAnalysis.CSharp.BoundStatement)item4);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 36850, 37073);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10498_36728_37074(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock( (Microsoft.CodeAnalysis.SyntaxNode)syntax, locals: locals, statements: statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 36728, 37074);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10498,35672,37086);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10498,35672,37086);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement RewriteSingleDimensionalArrayForEachStatement(BoundForEachStatement node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10498,37822,42916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,37943,38005);

var 
forEachSyntax = (CommonForEachStatementSyntax)node.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,38021,38101);

BoundExpression 
collectionExpression = f_10498_38060_38100(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,38115,38187);

f_10498_38115_38186(f_10498_38128_38153(collectionExpression)is { TypeKind: TypeKind.Array });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,38203,38274);

ArrayTypeSymbol 
arrayType = (ArrayTypeSymbol)f_10498_38248_38273(collectionExpression)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,38288,38335);

f_10498_38288_38334(arrayType is { IsSZArray: true });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,38351,38426);

TypeSymbol 
intType = f_10498_38372_38425(_compilation, SpecialType.System_Int32)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,38440,38518);

TypeSymbol 
boolType = f_10498_38462_38517(_compilation, SpecialType.System_Boolean)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,38534,38610);

BoundExpression 
rewrittenExpression = f_10498_38572_38609(this, collectionExpression)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,38624,38682);

BoundStatement? 
rewrittenBody = f_10498_38656_38681(this, f_10498_38671_38680(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,38696,38731);

f_10498_38696_38730(rewrittenBody is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,38769,38893);

LocalSymbol 
arrayVar = f_10498_38792_38892(_factory, arrayType, syntax: forEachSyntax, kind: SynthesizedLocalKind.ForEachArray)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,38954,39051);

BoundStatement 
arrayVarDecl = f_10498_38984_39050(this, forEachSyntax, arrayVar, rewrittenExpression)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,39067,39142);

f_10498_39067_39141(this, node, ref arrayVarDecl);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,39190,39268);

BoundLocal 
boundArrayVar = f_10498_39217_39267(forEachSyntax, arrayVar, arrayType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,39306,39436);

LocalSymbol 
positionVar = f_10498_39332_39435(_factory, intType, syntax: forEachSyntax, kind: SynthesizedLocalKind.ForEachArrayIndex)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,39484,39566);

BoundLocal 
boundPositionVar = f_10498_39514_39565(forEachSyntax, positionVar, intType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,39609,39794);

BoundStatement 
positionVarDecl = f_10498_39642_39793(this, forEachSyntax, positionVar, f_10498_39708_39792(this, forEachSyntax, f_10498_39735_39782(SpecialType.System_Int32), intType))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,39834,40381);

BoundExpression 
iterationVarInitValue = f_10498_39874_40380(this, syntax: forEachSyntax, rewrittenOperand: f_10498_39969_40220(syntax: forEachSyntax, expression: boundArrayVar, indices: f_10498_40113_40169(boundPositionVar), type: f_10498_40198_40219(arrayType)), conversion: f_10498_40251_40273(node), rewrittenType: f_10498_40307_40338(f_10498_40307_40333(node)), @checked: f_10498_40367_40379(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,40465,40538);

ImmutableArray<LocalSymbol> 
iterationVariables = f_10498_40514_40537(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,40552,40673);

BoundStatement 
iterationVariableDecl = f_10498_40591_40672(this, node, iterationVariables, iterationVarInitValue)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,40689,40772);

f_10498_40689_40771(this, node, ref iterationVariableDecl);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,40788,40962);

BoundStatement 
initializer = f_10498_40817_40961(forEachSyntax, statements: f_10498_40892_40960(arrayVarDecl, positionVarDecl))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,41003,41171);

BoundExpression 
arrayLength = f_10498_41033_41170(syntax: forEachSyntax, expression: boundArrayVar, type: intType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,41216,41616);

BoundExpression 
exitCondition = f_10498_41248_41615(syntax: forEachSyntax, operatorKind: BinaryOperatorKind.IntLessThan, left: boundPositionVar, right: arrayLength, constantValueOpt: null, methodOpt: null, resultKind: LookupResultKind.Viable, type: boolType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,41659,41758);

BoundStatement 
positionIncrement = f_10498_41694_41757(this, forEachSyntax, boundPositionVar, intType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,41919,42057);

BoundStatement 
loopBody = f_10498_41945_42056(iterationVariables, iterationVariableDecl, rewrittenBody, forEachSyntax)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,42285,42814);

BoundStatement 
result = f_10498_42309_42813(this, original: node, outerLocals: f_10498_42411_42468(arrayVar, positionVar), rewrittenInitializer: initializer, rewrittenCondition: exitCondition, rewrittenIncrement: positionIncrement, rewrittenBody: loopBody, breakLabel: f_10498_42701_42716(node), continueLabel: f_10498_42750_42768(node), hasErrors: f_10498_42798_42812(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,42830,42875);

f_10498_42830_42874(this, node, ref result);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,42891,42905);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10498,37822,42916);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_38060_38100(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
node)
{
var return_v = GetUnconvertedCollectionExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 38060, 38100);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10498_38128_38153(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 38128, 38153);
return return_v;
}


int
f_10498_38115_38186(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 38115, 38186);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10498_38248_38273(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 38248, 38273);
return return_v;
}


int
f_10498_38288_38334(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 38288, 38334);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10498_38372_38425(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 38372, 38425);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10498_38462_38517(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 38462, 38517);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10498_38572_38609(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 38572, 38609);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_38671_38680(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 38671, 38680);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10498_38656_38681(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
node)
{
var return_v = this_param.VisitStatement( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 38656, 38681);
return return_v;
}


int
f_10498_38696_38730(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 38696, 38730);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10498_38792_38892(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.SynthesizedLocalKind
kind)
{
var return_v = this_param.SynthesizedLocal( (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, kind: kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 38792, 38892);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_38984_39050(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenInitialValue)
{
var return_v = this_param.MakeLocalDeclaration( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, local, rewrittenInitialValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 38984, 39050);
return return_v;
}


int
f_10498_39067_39141(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
original,ref Microsoft.CodeAnalysis.CSharp.BoundStatement
collectionVarDecl)
{
this_param.InstrumentForEachStatementCollectionVarDeclaration( original, ref collectionVarDecl);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 39067, 39141);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10498_39217_39267(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local,Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
type)
{
var return_v = MakeBoundLocal( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, local, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 39217, 39267);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10498_39332_39435(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.SynthesizedLocalKind
kind)
{
var return_v = this_param.SynthesizedLocal( type, syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, kind: kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 39332, 39435);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10498_39514_39565(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = MakeBoundLocal( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, local, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 39514, 39565);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10498_39735_39782(Microsoft.CodeAnalysis.SpecialType
st)
{
var return_v = ConstantValue.Default( st);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 39735, 39782);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_39708_39792(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeLiteral( (Microsoft.CodeAnalysis.SyntaxNode)syntax, constantValue, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 39708, 39792);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_39642_39793(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenInitialValue)
{
var return_v = this_param.MakeLocalDeclaration( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, local, rewrittenInitialValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 39642, 39793);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10498_40113_40169(Microsoft.CodeAnalysis.CSharp.BoundLocal
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 40113, 40169);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10498_40198_40219(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
this_param)
{
var return_v = this_param.ElementType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 40198, 40219);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
f_10498_39969_40220(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
expression,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
indices,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundArrayAccess( syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, expression: (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, indices: indices, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 39969, 40220);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10498_40251_40273(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.ElementConversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 40251, 40273);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
f_10498_40307_40333(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.IterationVariableType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 40307, 40333);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10498_40307_40338(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 40307, 40338);
return return_v;
}


bool
f_10498_40367_40379(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.Checked;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 40367, 40379);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_39874_40380(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, rewrittenOperand: (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenOperand, conversion: conversion, rewrittenType: rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 39874, 40380);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10498_40514_40537(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.IterationVariables;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 40514, 40537);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_40591_40672(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
forEachBound,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
iterationVariables,Microsoft.CodeAnalysis.CSharp.BoundExpression
iterationVarValue)
{
var return_v = this_param.LocalOrDeconstructionDeclaration( forEachBound, iterationVariables, iterationVarValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 40591, 40672);
return return_v;
}


int
f_10498_40689_40771(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
original,ref Microsoft.CodeAnalysis.CSharp.BoundStatement
iterationVarDecl)
{
this_param.InstrumentForEachStatementIterationVarDeclaration( original, ref iterationVarDecl);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 40689, 40771);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10498_40892_40960(Microsoft.CodeAnalysis.CSharp.BoundStatement
item1,Microsoft.CodeAnalysis.CSharp.BoundStatement
item2)
{
var return_v = ImmutableArray.Create<BoundStatement>( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 40892, 40960);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatementList
f_10498_40817_40961(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundStatementList( (Microsoft.CodeAnalysis.SyntaxNode)syntax, statements: statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 40817, 40961);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundArrayLength
f_10498_41033_41170(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
expression,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundArrayLength( syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, expression: (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 41033, 41170);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10498_41248_41615(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundLocal
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
methodOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator( syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, operatorKind: operatorKind, left: (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right: right, constantValueOpt: constantValueOpt, methodOpt: methodOpt, resultKind: resultKind, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 41248, 41615);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_41694_41757(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
boundPositionVar,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
intType)
{
var return_v = this_param.MakePositionIncrement( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, boundPositionVar, intType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 41694, 41757);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10498_41945_42056(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
iterationVariables,Microsoft.CodeAnalysis.CSharp.BoundStatement
iteratorVariableInitialization,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenBody,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
forEachSyntax)
{
var return_v = CreateBlockDeclaringIterationVariables( iterationVariables, iteratorVariableInitialization, rewrittenBody, forEachSyntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 41945, 42056);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10498_42411_42468(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item1,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item2)
{
var return_v = ImmutableArray.Create<LocalSymbol>( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 42411, 42468);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10498_42701_42716(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.BreakLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 42701, 42716);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10498_42750_42768(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.ContinueLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 42750, 42768);
return return_v;
}


bool
f_10498_42798_42812(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.HasErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 42798, 42812);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_42309_42813(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
original,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
outerLocals,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenInitializer,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenIncrement,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenBody,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
breakLabel,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
continueLabel,bool
hasErrors)
{
var return_v = this_param.RewriteForStatementWithoutInnerLocals( original: (Microsoft.CodeAnalysis.CSharp.BoundLoopStatement)original, outerLocals: outerLocals, rewrittenInitializer: rewrittenInitializer, rewrittenCondition: rewrittenCondition, rewrittenIncrement: rewrittenIncrement, rewrittenBody: rewrittenBody, breakLabel: breakLabel, continueLabel: continueLabel, hasErrors: hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 42309, 42813);
return return_v;
}


int
f_10498_42830_42874(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
original,ref Microsoft.CodeAnalysis.CSharp.BoundStatement
result)
{
this_param.InstrumentForEachStatement( original, ref result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 42830, 42874);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10498,37822,42916);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10498,37822,42916);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement RewriteMultiDimensionalArrayForEachStatement(BoundForEachStatement node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10498,43951,53116);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,44071,44133);

var 
forEachSyntax = (CommonForEachStatementSyntax)node.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,44149,44229);

BoundExpression 
collectionExpression = f_10498_44188_44228(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,44243,44315);

f_10498_44243_44314(f_10498_44256_44281(collectionExpression)is { TypeKind: TypeKind.Array });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,44331,44402);

ArrayTypeSymbol 
arrayType = (ArrayTypeSymbol)f_10498_44376_44401(collectionExpression)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,44418,44444);

int 
rank = f_10498_44429_44443(arrayType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,44458,44493);

f_10498_44458_44492(f_10498_44471_44491_M(!arrayType.IsSZArray));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,44509,44584);

TypeSymbol 
intType = f_10498_44530_44583(_compilation, SpecialType.System_Int32)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,44598,44676);

TypeSymbol 
boolType = f_10498_44620_44675(_compilation, SpecialType.System_Boolean)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,44741,44861);

MethodSymbol 
getLowerBoundMethod = f_10498_44776_44860(this, forEachSyntax, SpecialMember.System_Array__GetLowerBound)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,44875,44995);

MethodSymbol 
getUpperBoundMethod = f_10498_44910_44994(this, forEachSyntax, SpecialMember.System_Array__GetUpperBound)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,45011,45087);

BoundExpression 
rewrittenExpression = f_10498_45049_45086(this, collectionExpression)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,45101,45159);

BoundStatement? 
rewrittenBody = f_10498_45133_45158(this, f_10498_45148_45157(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,45173,45208);

f_10498_45173_45207(rewrittenBody is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,45249,45373);

LocalSymbol 
arrayVar = f_10498_45272_45372(_factory, arrayType, syntax: forEachSyntax, kind: SynthesizedLocalKind.ForEachArray)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,45387,45465);

BoundLocal 
boundArrayVar = f_10498_45414_45464(forEachSyntax, arrayVar, arrayType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,45529,45626);

BoundStatement 
arrayVarDecl = f_10498_45559_45625(this, forEachSyntax, arrayVar, rewrittenExpression)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,45642,45717);

f_10498_45642_45716(this, node, ref arrayVarDecl);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,46134,46181);

LocalSymbol[] 
upperVar = new LocalSymbol[rank]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,46195,46245);

BoundLocal[] 
boundUpperVar = new BoundLocal[rank]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,46259,46316);

BoundStatement[] 
upperVarDecl = new BoundStatement[rank]
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,46339,46352);
            for (int 
dimension = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,46330,47395) || true) && (dimension < rank)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,46372,46383)
,dimension++,DynAbs.Tracing.TraceSender.TraceExitCondition(10498,46330,47395))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,46330,47395);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,46453,46579);

upperVar[dimension] = f_10498_46475_46578(_factory, intType, syntax: forEachSyntax, kind: SynthesizedLocalKind.ForEachArrayLimit);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,46597,46684);

boundUpperVar[dimension] = f_10498_46624_46683(forEachSyntax, upperVar[dimension], intType);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,46704,46979);

ImmutableArray<BoundExpression> 
dimensionArgument = f_10498_46756_46978(f_10498_46800_46977(this, forEachSyntax, constantValue: f_10498_46867_46936(dimension, ConstantValueTypeDiscriminator.Int32), type: intType))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,47046,47183);

BoundExpression 
currentDimensionUpperBound = f_10498_47091_47182(forEachSyntax, boundArrayVar, getUpperBoundMethod, dimensionArgument)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,47269,47380);

upperVarDecl[dimension] = f_10498_47295_47379(this, forEachSyntax, upperVar[dimension], currentDimensionUpperBound);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10498,1,1066);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10498,1,1066);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,47445,47495);

LocalSymbol[] 
positionVar = new LocalSymbol[rank]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,47509,47562);

BoundLocal[] 
boundPositionVar = new BoundLocal[rank]
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,47585,47598);
            for (int 
dimension = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,47576,47918) || true) && (dimension < rank)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,47618,47629)
,dimension++,DynAbs.Tracing.TraceSender.TraceExitCondition(10498,47576,47918))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,47576,47918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,47663,47792);

positionVar[dimension] = f_10498_47688_47791(_factory, intType, syntax: forEachSyntax, kind: SynthesizedLocalKind.ForEachArrayIndex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,47810,47903);

boundPositionVar[dimension] = f_10498_47840_47902(forEachSyntax, positionVar[dimension], intType);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10498,1,343);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10498,1,343);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,47970,48489);

BoundExpression 
iterationVarInitValue = f_10498_48010_48488(this, syntax: forEachSyntax, rewrittenOperand: f_10498_48105_48328(forEachSyntax, expression: boundArrayVar, indices: f_10498_48219_48277(boundPositionVar), type: f_10498_48306_48327(arrayType)), conversion: f_10498_48359_48381(node), rewrittenType: f_10498_48415_48446(f_10498_48415_48441(node)), @checked: f_10498_48475_48487(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,48599,48672);

ImmutableArray<LocalSymbol> 
iterationVariables = f_10498_48648_48671(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,48686,48802);

BoundStatement 
iterationVarDecl = f_10498_48720_48801(this, node, iterationVariables, iterationVarInitValue)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,48818,48896);

f_10498_48818_48895(this, node, ref iterationVarDecl);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,49082,49224);

BoundStatement 
innermostLoopBody = f_10498_49117_49223(iterationVariables, iterationVarDecl, rewrittenBody, forEachSyntax)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,49693,49724);

BoundStatement? 
forLoop = null
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,49747,49767);
            for (int 
dimension = rank - 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,49738,52685) || true) && (dimension >= 0)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,49785,49796)
,dimension--,DynAbs.Tracing.TraceSender.TraceExitCondition(10498,49738,52685))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,49738,52685);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,49830,50105);

ImmutableArray<BoundExpression> 
dimensionArgument = f_10498_49882_50104(f_10498_49926_50103(this, forEachSyntax, constantValue: f_10498_49993_50062(dimension, ConstantValueTypeDiscriminator.Int32), type: intType))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,50172,50309);

BoundExpression 
currentDimensionLowerBound = f_10498_50217_50308(forEachSyntax, boundArrayVar, getLowerBoundMethod, dimensionArgument)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,50395,50516);

BoundStatement 
positionVarDecl = f_10498_50428_50515(this, forEachSyntax, positionVar[dimension], currentDimensionLowerBound)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,50536,50754);

GeneratedLabelSymbol 
breakLabel = (DynAbs.Tracing.TraceSender.Conditional_F1(10498, 50570, 50584)||((dimension == 0 // outermost for-loop
&&DynAbs.Tracing.TraceSender.Conditional_F2(10498, 50630, 50645))||DynAbs.Tracing.TraceSender.Conditional_F3(10498, 50720, 50753)))?f_10498_50630_50645(node):f_10498_50720_50753("break")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,50883,51346);

BoundExpression 
exitCondition = f_10498_50915_51345(syntax: forEachSyntax, operatorKind: BinaryOperatorKind.IntLessThanOrEqual, left: boundPositionVar[dimension], right: boundUpperVar[dimension], constantValueOpt: null, methodOpt: null, resultKind: LookupResultKind.Viable, type: boolType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,51417,51527);

BoundStatement 
positionIncrement = f_10498_51452_51526(this, forEachSyntax, boundPositionVar[dimension], intType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,51547,51567);

BoundStatement 
body
=default(BoundStatement);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,51585,51620);

GeneratedLabelSymbol 
continueLabel
=default(GeneratedLabelSymbol);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,51640,52121) || true) && (forLoop == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,51640,52121);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,51744,51769);

body = innermostLoopBody;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,51791,51826);

continueLabel = f_10498_51807_51825(node);
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,51640,52121);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,51640,52121);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,51965,51980);

body = forLoop;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,52002,52055);

continueLabel = f_10498_52018_52054("continue");
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,51640,52121);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,52141,52670);

forLoop = f_10498_52151_52669(this, original: node, outerLocals: f_10498_52261_52306(positionVar[dimension]), rewrittenInitializer: positionVarDecl, rewrittenCondition: exitCondition, rewrittenIncrement: positionIncrement, rewrittenBody: body, breakLabel: breakLabel, continueLabel: continueLabel, hasErrors: f_10498_52654_52668(node));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10498,1,2948);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10498,1,2948);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,52701,52731);

f_10498_52701_52730(forLoop != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,52747,53014);

BoundStatement 
result = f_10498_52771_53013(forEachSyntax, f_10498_52836_52867(arrayVar).Concat(f_10498_52875_52903(upperVar)), f_10498_52923_52958(arrayVarDecl).Concat(f_10498_52966_52998(upperVarDecl)).Add(forLoop))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,53030,53075);

f_10498_53030_53074(this, node, ref result);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,53091,53105);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10498,43951,53116);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_44188_44228(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
node)
{
var return_v = GetUnconvertedCollectionExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 44188, 44228);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10498_44256_44281(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 44256, 44281);
return return_v;
}


int
f_10498_44243_44314(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 44243, 44314);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10498_44376_44401(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 44376, 44401);
return return_v;
}


int
f_10498_44429_44443(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
this_param)
{
var return_v = this_param.Rank;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 44429, 44443);
return return_v;
}


bool
f_10498_44471_44491_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 44471, 44491);
return return_v;
}


int
f_10498_44458_44492(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 44458, 44492);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10498_44530_44583(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 44530, 44583);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10498_44620_44675(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 44620, 44675);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10498_44776_44860(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.UnsafeGetSpecialTypeMethod( (Microsoft.CodeAnalysis.SyntaxNode)syntax, specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 44776, 44860);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10498_44910_44994(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.UnsafeGetSpecialTypeMethod( (Microsoft.CodeAnalysis.SyntaxNode)syntax, specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 44910, 44994);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10498_45049_45086(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 45049, 45086);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_45148_45157(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 45148, 45157);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10498_45133_45158(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
node)
{
var return_v = this_param.VisitStatement( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 45133, 45158);
return return_v;
}


int
f_10498_45173_45207(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 45173, 45207);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10498_45272_45372(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.SynthesizedLocalKind
kind)
{
var return_v = this_param.SynthesizedLocal( (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, kind: kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 45272, 45372);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10498_45414_45464(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local,Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
type)
{
var return_v = MakeBoundLocal( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, local, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 45414, 45464);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_45559_45625(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenInitialValue)
{
var return_v = this_param.MakeLocalDeclaration( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, local, rewrittenInitialValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 45559, 45625);
return return_v;
}


int
f_10498_45642_45716(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
original,ref Microsoft.CodeAnalysis.CSharp.BoundStatement
collectionVarDecl)
{
this_param.InstrumentForEachStatementCollectionVarDeclaration( original, ref collectionVarDecl);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 45642, 45716);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10498_46475_46578(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.SynthesizedLocalKind
kind)
{
var return_v = this_param.SynthesizedLocal( type, syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, kind: kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 46475, 46578);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10498_46624_46683(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = MakeBoundLocal( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, local, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 46624, 46683);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10498_46867_46936(int
value,Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
discriminator)
{
var return_v = ConstantValue.Create( (object)value, discriminator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 46867, 46936);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_46800_46977(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeLiteral( (Microsoft.CodeAnalysis.SyntaxNode)syntax, constantValue: constantValue, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 46800, 46977);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10498_46756_46978(Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 46756, 46978);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10498_47091_47182(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments)
{
var return_v = BoundCall.Synthesized( (Microsoft.CodeAnalysis.SyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, method, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 47091, 47182);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_47295_47379(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenInitialValue)
{
var return_v = this_param.MakeLocalDeclaration( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, local, rewrittenInitialValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 47295, 47379);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10498_47688_47791(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.SynthesizedLocalKind
kind)
{
var return_v = this_param.SynthesizedLocal( type, syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, kind: kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 47688, 47791);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10498_47840_47902(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = MakeBoundLocal( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, local, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 47840, 47902);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10498_48219_48277(params Microsoft.CodeAnalysis.CSharp.BoundLocal[]
items)
{
var return_v = ImmutableArray.Create( (Microsoft.CodeAnalysis.CSharp.BoundExpression[])items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 48219, 48277);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10498_48306_48327(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
this_param)
{
var return_v = this_param.ElementType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 48306, 48327);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
f_10498_48105_48328(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
expression,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
indices,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundArrayAccess( (Microsoft.CodeAnalysis.SyntaxNode)syntax, expression: (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, indices: indices, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 48105, 48328);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10498_48359_48381(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.ElementConversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 48359, 48381);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
f_10498_48415_48441(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.IterationVariableType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 48415, 48441);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10498_48415_48446(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 48415, 48446);
return return_v;
}


bool
f_10498_48475_48487(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.Checked;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 48475, 48487);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_48010_48488(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, rewrittenOperand: (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenOperand, conversion: conversion, rewrittenType: rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 48010, 48488);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10498_48648_48671(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.IterationVariables;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 48648, 48671);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_48720_48801(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
forEachBound,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
iterationVariables,Microsoft.CodeAnalysis.CSharp.BoundExpression
iterationVarValue)
{
var return_v = this_param.LocalOrDeconstructionDeclaration( forEachBound, iterationVariables, iterationVarValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 48720, 48801);
return return_v;
}


int
f_10498_48818_48895(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
original,ref Microsoft.CodeAnalysis.CSharp.BoundStatement
iterationVarDecl)
{
this_param.InstrumentForEachStatementIterationVarDeclaration( original, ref iterationVarDecl);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 48818, 48895);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10498_49117_49223(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
iterationVariables,Microsoft.CodeAnalysis.CSharp.BoundStatement
iteratorVariableInitialization,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenBody,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
forEachSyntax)
{
var return_v = CreateBlockDeclaringIterationVariables( iterationVariables, iteratorVariableInitialization, rewrittenBody, forEachSyntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 49117, 49223);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10498_49993_50062(int
value,Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
discriminator)
{
var return_v = ConstantValue.Create( (object)value, discriminator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 49993, 50062);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_49926_50103(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeLiteral( (Microsoft.CodeAnalysis.SyntaxNode)syntax, constantValue: constantValue, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 49926, 50103);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10498_49882_50104(Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 49882, 50104);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10498_50217_50308(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments)
{
var return_v = BoundCall.Synthesized( (Microsoft.CodeAnalysis.SyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, method, arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 50217, 50308);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_50428_50515(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
local,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenInitialValue)
{
var return_v = this_param.MakeLocalDeclaration( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, local, rewrittenInitialValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 50428, 50515);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10498_50630_50645(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.BreakLabel // i.e. the one that break statements will jump to
;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 50630, 50645);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10498_50720_50753(string
name)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 50720, 50753);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10498_50915_51345(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundLocal
left,Microsoft.CodeAnalysis.CSharp.BoundLocal
right,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
methodOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator( syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, operatorKind: operatorKind, left: (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right: (Microsoft.CodeAnalysis.CSharp.BoundExpression)right, constantValueOpt: constantValueOpt, methodOpt: methodOpt, resultKind: resultKind, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 50915, 51345);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_51452_51526(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
boundPositionVar,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
intType)
{
var return_v = this_param.MakePositionIncrement( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, boundPositionVar, intType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 51452, 51526);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10498_51807_51825(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.ContinueLabel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 51807, 51825);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10498_52018_52054(string
name)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 52018, 52054);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10498_52261_52306(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 52261, 52306);
return return_v;
}


bool
f_10498_52654_52668(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.HasErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 52654, 52668);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_52151_52669(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
original,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
outerLocals,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenInitializer,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenIncrement,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenBody,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
breakLabel,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
continueLabel,bool
hasErrors)
{
var return_v = this_param.RewriteForStatementWithoutInnerLocals( original: (Microsoft.CodeAnalysis.CSharp.BoundLoopStatement)original, outerLocals: outerLocals, rewrittenInitializer: rewrittenInitializer, rewrittenCondition: rewrittenCondition, rewrittenIncrement: rewrittenIncrement, rewrittenBody: rewrittenBody, breakLabel: breakLabel, continueLabel: continueLabel, hasErrors: hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 52151, 52669);
return return_v;
}


int
f_10498_52701_52730(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 52701, 52730);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10498_52836_52867(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 52836, 52867);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10498_52875_52903(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol[]
items)
{
var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 52875, 52903);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10498_52923_52958(Microsoft.CodeAnalysis.CSharp.BoundStatement
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 52923, 52958);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10498_52966_52998(Microsoft.CodeAnalysis.CSharp.BoundStatement[]
items)
{
var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.BoundStatement>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 52966, 52998);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10498_52771_53013(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock( (Microsoft.CodeAnalysis.SyntaxNode)syntax, locals, statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 52771, 53013);
return return_v;
}


int
f_10498_53030_53074(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
original,ref Microsoft.CodeAnalysis.CSharp.BoundStatement
result)
{
this_param.InstrumentForEachStatement( original, ref result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 53030, 53074);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10498,43951,53116);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10498,43951,53116);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static BoundExpression GetUnconvertedCollectionExpression(BoundForEachStatement node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10498,53582,54129);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,53700,53738);

var 
boundExpression = f_10498_53722_53737(node)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,53752,53899) || true) && (f_10498_53756_53776(boundExpression)== BoundKind.Conversion)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,53752,53899);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,53834,53884);

return f_10498_53841_53883(((BoundConversion)boundExpression));
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,53752,53899);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,54095,54118);

return boundExpression;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10498,53582,54129);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_53722_53737(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 53722, 53737);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10498_53756_53776(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 53756, 53776);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_53841_53883(Microsoft.CodeAnalysis.CSharp.BoundConversion
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 53841, 53883);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10498,53582,54129);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10498,53582,54129);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static BoundLocal MakeBoundLocal(CSharpSyntaxNode syntax, LocalSymbol local, TypeSymbol type)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10498,54141,54415);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,54267,54404);

return f_10498_54274_54403(syntax, localSymbol: local, constantValueOpt: null, type: type);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10498,54141,54415);

Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10498_54274_54403(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
localSymbol,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLocal( (Microsoft.CodeAnalysis.SyntaxNode)syntax, localSymbol: localSymbol, constantValueOpt: constantValueOpt, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 54274, 54403);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10498,54141,54415);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10498,54141,54415);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement MakeLocalDeclaration(CSharpSyntaxNode syntax, LocalSymbol local, BoundExpression rewrittenInitialValue)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10498,54427,54865);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,54578,54784);

var 
result = f_10498_54591_54783(this, originalOpt: null, syntax: syntax, localSymbol: local, rewrittenInitializer: rewrittenInitialValue)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,54798,54826);

f_10498_54798_54825(result is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,54840,54854);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10498,54427,54865);

Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10498_54591_54783(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration?
originalOpt,Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
localSymbol,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenInitializer)
{
var return_v = this_param.RewriteLocalDeclaration( originalOpt: originalOpt, syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, localSymbol: localSymbol, rewrittenInitializer: rewrittenInitializer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 54591, 54783);
return return_v;
}


int
f_10498_54798_54825(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 54798, 54825);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10498,54427,54865);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10498,54427,54865);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement MakePositionIncrement(CSharpSyntaxNode syntax, BoundLocal boundPositionVar, TypeSymbol intType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10498,54946,56364);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,55423,56353);

return f_10498_55430_56352(statementOpt: f_10498_55494_56351(syntax, expression: f_10498_55564_56350(syntax, left: boundPositionVar, right: f_10498_55681_56309(syntax, operatorKind: BinaryOperatorKind.IntAddition, left: boundPositionVar, right: f_10498_55959_56099(this, syntax, constantValue: f_10498_56027_56050(1), type: intType), constantValueOpt: null, methodOpt: null, resultKind: LookupResultKind.Viable, type: intType), type: intType)));
DynAbs.Tracing.TraceSender.TraceExitMethod(10498,54946,56364);

Microsoft.CodeAnalysis.ConstantValue
f_10498_56027_56050(int
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 56027, 56050);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10498_55959_56099(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeLiteral( (Microsoft.CodeAnalysis.SyntaxNode)syntax, constantValue: constantValue, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 55959, 56099);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10498_55681_56309(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.CSharp.BoundLocal
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
methodOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator( (Microsoft.CodeAnalysis.SyntaxNode)syntax, operatorKind: operatorKind, left: (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right: right, constantValueOpt: constantValueOpt, methodOpt: methodOpt, resultKind: resultKind, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 55681, 56309);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
f_10498_55564_56350(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
left,Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
right,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator( (Microsoft.CodeAnalysis.SyntaxNode)syntax, left: (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right: (Microsoft.CodeAnalysis.CSharp.BoundExpression)right, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 55564, 56350);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10498_55494_56351(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
expression)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement( (Microsoft.CodeAnalysis.SyntaxNode)syntax, expression: (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 55494, 56351);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_55430_56352(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
statementOpt)
{
var return_v = BoundSequencePoint.CreateHidden( statementOpt: (Microsoft.CodeAnalysis.CSharp.BoundStatement)statementOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 55430, 56352);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10498,54946,56364);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10498,54946,56364);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void InstrumentForEachStatementCollectionVarDeclaration(BoundForEachStatement original, [NotNullIfNotNull("collectionVarDecl")] ref BoundStatement? collectionVarDecl)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10498,56376,56768);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,56575,56757) || true) && (f_10498_56579_56594(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,56575,56757);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,56628,56742);

collectionVarDecl = f_10498_56648_56741(_instrumenter, original, collectionVarDecl);
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,56575,56757);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10498,56376,56768);

bool
f_10498_56579_56594(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 56579, 56594);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10498_56648_56741(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
original,Microsoft.CodeAnalysis.CSharp.BoundStatement?
collectionVarDecl)
{
var return_v = this_param.InstrumentForEachStatementCollectionVarDeclaration( original, collectionVarDecl);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 56648, 56741);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10498,56376,56768);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10498,56376,56768);
}
		}

private void InstrumentForEachStatementIterationVarDeclaration(BoundForEachStatement original, ref BoundStatement iterationVarDecl)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10498,56780,57551);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,56936,57540) || true) && (f_10498_56940_56955(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,56936,57540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,56989,57080);

CommonForEachStatementSyntax 
forEachSyntax = (CommonForEachStatementSyntax)original.Syntax
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,57098,57525) || true) && (forEachSyntax is ForEachVariableStatementSyntax)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,57098,57525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,57191,57313);

iterationVarDecl = f_10498_57210_57312(_instrumenter, original, iterationVarDecl);
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,57098,57525);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,57098,57525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,57395,57506);

iterationVarDecl = f_10498_57414_57505(_instrumenter, original, iterationVarDecl);
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,57098,57525);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,56936,57540);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10498,56780,57551);

bool
f_10498_56940_56955(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 56940, 56955);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_57210_57312(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
original,Microsoft.CodeAnalysis.CSharp.BoundStatement
iterationVarDecl)
{
var return_v = this_param.InstrumentForEachStatementDeconstructionVariablesDeclaration( original, iterationVarDecl);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 57210, 57312);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_57414_57505(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
original,Microsoft.CodeAnalysis.CSharp.BoundStatement
iterationVarDecl)
{
var return_v = this_param.InstrumentForEachStatementIterationVarDeclaration( original, iterationVarDecl);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 57414, 57505);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10498,56780,57551);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10498,56780,57551);
}
		}

private void InstrumentForEachStatement(BoundForEachStatement original, ref BoundStatement result)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10498,57563,57833);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,57686,57822) || true) && (f_10498_57690_57705(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,57686,57822);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,57739,57807);

result = f_10498_57748_57806(_instrumenter, original, result);
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,57686,57822);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10498,57563,57833);

bool
f_10498_57690_57705(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 57690, 57705);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_57748_57806(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
original,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewritten)
{
var return_v = this_param.InstrumentForEachStatement( original, rewritten);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 57748, 57806);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10498,57563,57833);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10498,57563,57833);
}
		}

private BoundStatement MakeWhileTrueLoop(BoundForEachStatement loop, BoundBlock body)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10498,58065,58924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,58175,58233);

f_10498_58175_58232(f_10498_58188_58210(loop)is { IsAsync: true });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,58247,58279);

SyntaxNode 
syntax = loop.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,58293,58366);

GeneratedLabelSymbol 
startLabel = f_10498_58327_58365("still-true")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,58380,58461);

BoundStatement 
startLabelStatement = f_10498_58417_58460(syntax, startLabel)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,58477,58620) || true) && (f_10498_58481_58496(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10498,58477,58620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,58530,58605);

startLabelStatement = f_10498_58552_58604(startLabelStatement);
DynAbs.Tracing.TraceSender.TraceExitCondition(10498,58477,58620);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10498,58724,58913);

return f_10498_58731_58912(syntax, hasErrors: false, startLabelStatement, body, f_10498_58869_58911(syntax, startLabel));
DynAbs.Tracing.TraceSender.TraceExitMethod(10498,58065,58924);

Microsoft.CodeAnalysis.CSharp.ForEachEnumeratorInfo?
f_10498_58188_58210(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
this_param)
{
var return_v = this_param.EnumeratorInfoOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 58188, 58210);
return return_v;
}


int
f_10498_58175_58232(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 58175, 58232);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
f_10498_58327_58365(string
name)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 58327, 58365);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
f_10498_58417_58460(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 58417, 58460);
return return_v;
}


bool
f_10498_58481_58496(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10498, 58481, 58496);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10498_58552_58604(Microsoft.CodeAnalysis.CSharp.BoundStatement
statementOpt)
{
var return_v = BoundSequencePoint.CreateHidden( statementOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 58552, 58604);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
f_10498_58869_58911(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
label)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundGotoStatement( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 58869, 58911);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatementList
f_10498_58731_58912(Microsoft.CodeAnalysis.SyntaxNode
syntax,bool
hasErrors,params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
statements)
{
var return_v = BoundStatementList.Synthesized( syntax, hasErrors: hasErrors, statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10498, 58731, 58912);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10498,58065,58924);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10498,58065,58924);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
