// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
internal partial class MemberSemanticModel
{protected sealed class NodeMapBuilder : BoundTreeWalkerWithStackGuard
{
private NodeMapBuilder(OrderPreservingMultiDictionary<SyntaxNode, BoundNode> map, SyntaxTree tree, SyntaxNode thisSyntaxNodeOnly)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(10924,755,1033);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,1120,1124);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,1167,1172);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,1215,1234);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,917,928);

_map = map;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,946,959);

_tree = tree;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,977,1018);

_thisSyntaxNodeOnly = thisSyntaxNodeOnly;
DynAbs.Tracing.TraceSender.TraceExitConstructor(10924,755,1033);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10924,755,1033);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10924,755,1033);
}
		}

private readonly OrderPreservingMultiDictionary<SyntaxNode, BoundNode> _map;

private readonly SyntaxTree _tree;

private readonly SyntaxNode _thisSyntaxNodeOnly;

public static void AddToMap(BoundNode root, Dictionary<SyntaxNode, ImmutableArray<BoundNode>> map, SyntaxTree tree, SyntaxNode node = null)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10924,1674,7702);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,1846,1989);

f_10924_1846_1988(node == null ||(DynAbs.Tracing.TraceSender.Expression_False(10924, 1859, 1887)||root == null )||(DynAbs.Tracing.TraceSender.Expression_False(10924, 1859, 1924)||!(root.Syntax is StatementSyntax)), "individually added nodes are not supposed to be statements.");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,2009,2215) || true) && (root == null ||(DynAbs.Tracing.TraceSender.Expression_False(10924, 2013, 2057)||f_10924_2029_2057(map, root.Syntax)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10924,2009,2215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,2189,2196);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(10924,2009,2215);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,2235,2321);

var 
additionMap = f_10924_2253_2320()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,2339,2397);

var 
builder = f_10924_2353_2396(additionMap, tree, node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,2415,2435);

f_10924_2415_2434(                builder, root);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,2455,7648);
foreach(CSharpSyntaxNode key in f_10924_2488_2504_I(f_10924_2488_2504(additionMap)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10924,2455,7648);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,2546,7629) || true) && (f_10924_2550_2570(map, key))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10924,2546,7629);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,4073,4097);

var 
existing = f_10924_4088_4096(map, key)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,4123,4152);

var 
added = f_10924_4135_4151(additionMap, key)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,4178,4259);

f_10924_4178_4258(existing.Length == added.Length, "existing.Length == added.Length");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,4294,4299);
                        for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,4285,7472) || true) && (i < existing.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,4322,4325)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(10924,4285,7472))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10924,4285,7472);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,4897,7445) || true) && (f_10924_4901_4917(existing[i])!= f_10924_4921_4934(added[i]))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10924,4897,7445);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,5000,5069);

f_10924_5000_5068(!(key is StatementSyntax), "!(key is StatementSyntax)");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,5254,6914) || true) && (f_10924_5258_5274(existing[i])== BoundKind.TypeExpression &&(DynAbs.Tracing.TraceSender.Expression_True(10924, 5258, 5354)&&f_10924_5306_5319(added[i])== BoundKind.TypeOrValueExpression))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10924,5254,6914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,5428,5920);

f_10924_5428_5919(f_10924_5483_5623(f_10924_5501_5540(((BoundTypeExpression)existing[i])), f_10924_5542_5585(((BoundTypeOrValueExpression)added[i])), TypeCompareKind.ConsiderEverything2), f_10924_5666_5918(f_10924_5726_5775(), "((BoundTypeExpression)existing[{0}]).Type == ((BoundTypeOrValueExpression)added[{0}]).Type", i));
DynAbs.Tracing.TraceSender.TraceExitCondition(10924,5254,6914);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10924,5254,6914);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,5994,6914) || true) && (f_10924_5998_6014(existing[i])== BoundKind.TypeOrValueExpression &&(DynAbs.Tracing.TraceSender.Expression_True(10924, 5998, 6094)&&f_10924_6053_6066(added[i])== BoundKind.TypeExpression))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10924,5994,6914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,6168,6660);

f_10924_6168_6659(f_10924_6223_6363(f_10924_6241_6287(((BoundTypeOrValueExpression)existing[i])), f_10924_6289_6325(((BoundTypeExpression)added[i])), TypeCompareKind.ConsiderEverything2), f_10924_6406_6658(f_10924_6466_6515(), "((BoundTypeOrValueExpression)existing[{0}]).Type == ((BoundTypeExpression)added[{0}]).Type", i));
DynAbs.Tracing.TraceSender.TraceExitCondition(10924,5994,6914);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10924,5994,6914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,6806,6879);

f_10924_6806_6878(false, "New bound node does not match existing bound node");
DynAbs.Tracing.TraceSender.TraceExitCondition(10924,5994,6914);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10924,5254,6914);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10924,4897,7445);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10924,4897,7445);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,7044,7414);

f_10924_7044_7413((object)existing[i] == added[i] ||(DynAbs.Tracing.TraceSender.Expression_False(10924, 7095, 7155)||!(key is StatementSyntax)), f_10924_7194_7412(f_10924_7250_7299(), "(object)existing[{0}] == added[{0}] || !(key is StatementSyntax)", i));
DynAbs.Tracing.TraceSender.TraceExitCondition(10924,4897,7445);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10924,1,3188);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10924,1,3188);
}DynAbs.Tracing.TraceSender.TraceExitCondition(10924,2546,7629);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10924,2546,7629);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,7578,7606);

map[key] = f_10924_7589_7605(additionMap, key);
DynAbs.Tracing.TraceSender.TraceExitCondition(10924,2546,7629);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10924,2455,7648);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10924,1,5194);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10924,1,5194);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,7668,7687);

f_10924_7668_7686(
                additionMap);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10924,1674,7702);

int
f_10924_1846_1988(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 1846, 1988);
return 0;
}


bool
f_10924_2029_2057(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>>
this_param,Microsoft.CodeAnalysis.SyntaxNode
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 2029, 2057);
return return_v;
}


Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.BoundNode>
f_10924_2253_2320()
{
var return_v = OrderPreservingMultiDictionary<SyntaxNode, BoundNode>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 2253, 2320);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.NodeMapBuilder
f_10924_2353_2396(Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.BoundNode>
map,Microsoft.CodeAnalysis.SyntaxTree
tree,Microsoft.CodeAnalysis.SyntaxNode?
thisSyntaxNodeOnly)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.NodeMapBuilder( map, tree, thisSyntaxNodeOnly);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 2353, 2396);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode
f_10924_2415_2434(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.NodeMapBuilder
this_param,Microsoft.CodeAnalysis.CSharp.BoundNode
node)
{
var return_v = this_param.Visit( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 2415, 2434);
return return_v;
}


System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.BoundNode>.ValueSet>.KeyCollection
f_10924_2488_2504(Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.BoundNode>
this_param)
{
var return_v = this_param.Keys;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 2488, 2504);
return return_v;
}


bool
f_10924_2550_2570(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>>
this_param,Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
key)
{
var return_v = this_param.ContainsKey( (Microsoft.CodeAnalysis.SyntaxNode)key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 2550, 2570);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
f_10924_4088_4096(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>>
this_param,Microsoft.CodeAnalysis.SyntaxNode
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 4088, 4096);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
f_10924_4135_4151(Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.BoundNode>
this_param,Microsoft.CodeAnalysis.SyntaxNode
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 4135, 4151);
return return_v;
}


int
f_10924_4178_4258(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 4178, 4258);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10924_4901_4917(Microsoft.CodeAnalysis.CSharp.BoundNode
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 4901, 4917);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10924_4921_4934(Microsoft.CodeAnalysis.CSharp.BoundNode
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 4921, 4934);
return return_v;
}


int
f_10924_5000_5068(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 5000, 5068);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10924_5258_5274(Microsoft.CodeAnalysis.CSharp.BoundNode
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 5258, 5274);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10924_5306_5319(Microsoft.CodeAnalysis.CSharp.BoundNode
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 5306, 5319);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10924_5501_5540(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 5501, 5540);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10924_5542_5585(Microsoft.CodeAnalysis.CSharp.BoundTypeOrValueExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 5542, 5585);
return return_v;
}


bool
f_10924_5483_5623(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
left,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 5483, 5623);
return return_v;
}


System.Globalization.CultureInfo
f_10924_5726_5775()
{
var return_v =                                             System.Globalization.CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 5726, 5775);
return return_v;
}


string
f_10924_5666_5918(System.Globalization.CultureInfo
provider,string
format,int
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 5666, 5918);
return return_v;
}


int
f_10924_5428_5919(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 5428, 5919);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10924_5998_6014(Microsoft.CodeAnalysis.CSharp.BoundNode
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 5998, 6014);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10924_6053_6066(Microsoft.CodeAnalysis.CSharp.BoundNode
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 6053, 6066);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10924_6241_6287(Microsoft.CodeAnalysis.CSharp.BoundTypeOrValueExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 6241, 6287);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10924_6289_6325(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 6289, 6325);
return return_v;
}


bool
f_10924_6223_6363(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
left,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 6223, 6363);
return return_v;
}


System.Globalization.CultureInfo
f_10924_6466_6515()
{
var return_v =                                             System.Globalization.CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 6466, 6515);
return return_v;
}


string
f_10924_6406_6658(System.Globalization.CultureInfo
provider,string
format,int
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 6406, 6658);
return return_v;
}


int
f_10924_6168_6659(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 6168, 6659);
return 0;
}


int
f_10924_6806_6878(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 6806, 6878);
return 0;
}


System.Globalization.CultureInfo
f_10924_7250_7299()
{
var return_v =                                         System.Globalization.CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 7250, 7299);
return return_v;
}


string
f_10924_7194_7412(System.Globalization.CultureInfo
provider,string
format,int
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 7194, 7412);
return return_v;
}


int
f_10924_7044_7413(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 7044, 7413);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
f_10924_7589_7605(Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.BoundNode>
this_param,Microsoft.CodeAnalysis.SyntaxNode
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 7589, 7605);
return return_v;
}


System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.BoundNode>.ValueSet>.KeyCollection
f_10924_2488_2504_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.BoundNode>.ValueSet>.KeyCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 2488, 2504);
return return_v;
}


int
f_10924_7668_7686(Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.BoundNode>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 7668, 7686);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10924,1674,7702);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10924,1674,7702);
}
		}

public override BoundNode Visit(BoundNode node)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10924,7718,12757);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,8322,8439) || true) && (node == null ||(DynAbs.Tracing.TraceSender.Expression_False(10924, 8326, 8366)||f_10924_8342_8357(node)!= _tree))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10924,8322,8439);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,8408,8420);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10924,8322,8439);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,8459,8484);

BoundNode 
current = node
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,10261,10417) || true) && (f_10924_10265_10274(node)== BoundKind.UnboundLambda)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10924,10261,10417);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,10343,10398);

current = f_10924_10353_10397(((UnboundLambda)node));
DynAbs.Tracing.TraceSender.TraceExitCondition(10924,10261,10417);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,11202,11323) || true) && (f_10924_11206_11228(this, current))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10924,11202,11323);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,11270,11304);

f_10924_11270_11303(                    _map, current.Syntax, current);
DynAbs.Tracing.TraceSender.TraceExitCondition(10924,11202,11323);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,11625,11668);

var 
binOp = current as BoundBinaryOperator
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,11688,12710) || true) && (binOp != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10924,11688,12710);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,11747,11803);

var 
stack = f_10924_11759_11802()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,11827,11851);

f_10924_11827_11850(
                    stack, f_10924_11838_11849(binOp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,11873,11894);

current = f_10924_11883_11893(binOp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,11916,11955);

binOp = current as BoundBinaryOperator;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,11979,12375) || true) && (binOp != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10924,11979,12375);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,12049,12188) || true) && (f_10924_12053_12073(this, binOp))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10924,12049,12188);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,12131,12161);

f_10924_12131_12160(                            _map, binOp.Syntax, binOp);
DynAbs.Tracing.TraceSender.TraceExitCondition(10924,12049,12188);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,12216,12240);

f_10924_12216_12239(
                        stack, f_10924_12227_12238(binOp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,12266,12287);

current = f_10924_12276_12286(binOp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,12313,12352);

binOp = current as BoundBinaryOperator;
DynAbs.Tracing.TraceSender.TraceExitCondition(10924,11979,12375);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10924,11979,12375);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10924,11979,12375);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,12399,12414);

f_10924_12399_12413(this, current);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,12438,12552) || true) && (f_10924_12445_12456(stack)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10924,12438,12552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,12510,12529);

f_10924_12510_12528(this, f_10924_12516_12527(stack));
DynAbs.Tracing.TraceSender.TraceExitCondition(10924,12438,12552);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10924,12438,12552);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10924,12438,12552);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,12576,12589);

f_10924_12576_12588(
                    stack);
DynAbs.Tracing.TraceSender.TraceExitCondition(10924,11688,12710);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10924,11688,12710);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,12671,12691);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(current),10924,12671,12690);
DynAbs.Tracing.TraceSender.TraceExitCondition(10924,11688,12710);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,12730,12742);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(10924,7718,12757);

Microsoft.CodeAnalysis.SyntaxTree?
f_10924_8342_8357(Microsoft.CodeAnalysis.CSharp.BoundNode
this_param)
{
var return_v = this_param.SyntaxTree ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 8342, 8357);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10924_10265_10274(Microsoft.CodeAnalysis.CSharp.BoundNode
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 10265, 10274);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLambda
f_10924_10353_10397(Microsoft.CodeAnalysis.CSharp.UnboundLambda
this_param)
{
var return_v = this_param.BindForErrorRecovery();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 10353, 10397);
return return_v;
}


bool
f_10924_11206_11228(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.NodeMapBuilder
this_param,Microsoft.CodeAnalysis.CSharp.BoundNode
currentBoundNode)
{
var return_v = this_param.ShouldAddNode( currentBoundNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 11206, 11228);
return return_v;
}


int
f_10924_11270_11303(Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.BoundNode>
this_param,Microsoft.CodeAnalysis.SyntaxNode
k,Microsoft.CodeAnalysis.CSharp.BoundNode
v)
{
this_param.Add( k, v);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 11270, 11303);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10924_11759_11802()
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 11759, 11802);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10924_11838_11849(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
this_param)
{
var return_v = this_param.Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 11838, 11849);
return return_v;
}


int
f_10924_11827_11850(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
builder,Microsoft.CodeAnalysis.CSharp.BoundExpression
e)
{
builder.Push<Microsoft.CodeAnalysis.CSharp.BoundExpression>( e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 11827, 11850);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10924_11883_11893(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 11883, 11893);
return return_v;
}


bool
f_10924_12053_12073(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.NodeMapBuilder
this_param,Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
currentBoundNode)
{
var return_v = this_param.ShouldAddNode( (Microsoft.CodeAnalysis.CSharp.BoundNode)currentBoundNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 12053, 12073);
return return_v;
}


int
f_10924_12131_12160(Microsoft.CodeAnalysis.Collections.OrderPreservingMultiDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.BoundNode>
this_param,Microsoft.CodeAnalysis.SyntaxNode
k,Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
v)
{
this_param.Add( k, (Microsoft.CodeAnalysis.CSharp.BoundNode)v);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 12131, 12160);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10924_12227_12238(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
this_param)
{
var return_v = this_param.Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 12227, 12238);
return return_v;
}


int
f_10924_12216_12239(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
builder,Microsoft.CodeAnalysis.CSharp.BoundExpression
e)
{
builder.Push<Microsoft.CodeAnalysis.CSharp.BoundExpression>( e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 12216, 12239);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10924_12276_12286(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 12276, 12286);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode
f_10924_12399_12413(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.NodeMapBuilder
this_param,Microsoft.CodeAnalysis.CSharp.BoundNode
node)
{
var return_v = this_param.Visit( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 12399, 12413);
return return_v;
}


int
f_10924_12445_12456(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 12445, 12456);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10924_12516_12527(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
builder)
{
var return_v = builder.Pop<Microsoft.CodeAnalysis.CSharp.BoundExpression>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 12516, 12527);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode
f_10924_12510_12528(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.NodeMapBuilder
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.Visit( (Microsoft.CodeAnalysis.CSharp.BoundNode)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 12510, 12528);
return return_v;
}


int
f_10924_12576_12588(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 12576, 12588);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10924,7718,12757);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10924,7718,12757);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool ShouldAddNode(BoundNode currentBoundNode)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10924,12980,13540);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,13124,13239) || true) && (f_10924_13128_13165(currentBoundNode))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10924,13124,13239);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,13207,13220);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10924,13124,13239);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,13338,13493) || true) && (_thisSyntaxNodeOnly != null &&(DynAbs.Tracing.TraceSender.Expression_True(10924, 13342, 13419)&&currentBoundNode.Syntax != _thisSyntaxNodeOnly))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10924,13338,13493);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,13461,13474);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10924,13338,13493);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,13513,13525);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(10924,12980,13540);

bool
f_10924_13128_13165(Microsoft.CodeAnalysis.CSharp.BoundNode
this_param)
{
var return_v = this_param.WasCompilerGenerated;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 13128, 13165);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10924,12980,13540);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10924,12980,13540);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode VisitQueryClause(BoundQueryClause node)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10924,13556,13767);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,13654,13677);

f_10924_13654_13676(                this, f_10924_13665_13675(node));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,13695,13722);

f_10924_13695_13721(this, node);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,13740,13752);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(10924,13556,13767);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10924_13665_13675(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 13665, 13675);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode
f_10924_13654_13676(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.NodeMapBuilder
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.Visit( (Microsoft.CodeAnalysis.CSharp.BoundNode)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 13654, 13676);
return return_v;
}


int
f_10924_13695_13721(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel.NodeMapBuilder
this_param,Microsoft.CodeAnalysis.CSharp.BoundQueryClause
queryClause)
{
this_param.VisitUnoptimizedForm( queryClause);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10924, 13695, 13721);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10924,13556,13767);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10924,13556,13767);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode VisitRangeVariable(BoundRangeVariable node)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10924,13783,13912);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,13885,13897);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(10924,13783,13912);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10924,13783,13912);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10924,13783,13912);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode VisitAwaitableInfo(BoundAwaitableInfo node)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10924,13928,14057);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,14030,14042);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(10924,13928,14057);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10924,13928,14057);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10924,13928,14057);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode VisitBinaryOperator(BoundBinaryOperator node)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10924,14073,14229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,14177,14214);

throw f_10924_14183_14213();
DynAbs.Tracing.TraceSender.TraceExitMethod(10924,14073,14229);

System.Exception
f_10924_14183_14213()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10924, 14183, 14213);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10924,14073,14229);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10924,14073,14229);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override bool ConvertInsufficientExecutionStackExceptionToCancelledByStackGuardException()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10924,14245,14406);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10924,14378,14391);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(10924,14245,14406);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10924,14245,14406);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10924,14245,14406);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static NodeMapBuilder()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10924,661,14417);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10924,661,14417);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10924,661,14417);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10924,661,14417);
}
}
}
