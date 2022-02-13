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
private BoundExpression MakeDynamicIndexerAccessReceiver(BoundDynamicIndexerAccess indexerAccess, BoundExpression loweredReceiver)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10505,594,1806);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,749,772);

BoundExpression 
result
=default(BoundExpression);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,788,860);

string? 
indexedPropertyName = f_10505_818_859(indexerAccess)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,874,1765) || true) && (indexedPropertyName != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10505,874,1765);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,1539,1659);

result = f_10505_1548_1643(_dynamicFactory, loweredReceiver, indexedPropertyName, resultIndexed: true).ToExpression();
DynAbs.Tracing.TraceSender.TraceExitCondition(10505,874,1765);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10505,874,1765);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,1725,1750);

result = loweredReceiver;
DynAbs.Tracing.TraceSender.TraceExitCondition(10505,874,1765);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,1781,1795);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10505,594,1806);

string?
f_10505_818_859(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.TryGetIndexedPropertyName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 818, 859);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
f_10505_1548_1643(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredReceiver,string
name,bool
resultIndexed)
{
var return_v = this_param.MakeDynamicGetMember( loweredReceiver, name, resultIndexed: resultIndexed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 1548, 1643);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10505,594,1806);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10505,594,1806);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode VisitDynamicIndexerAccess(BoundDynamicIndexerAccess node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10505,1818,2186);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,1926,1979);

var 
loweredReceiver = f_10505_1948_1978(this, f_10505_1964_1977(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,1993,2042);

var 
loweredArguments = f_10505_2016_2041(this, f_10505_2026_2040(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,2058,2175);

return f_10505_2065_2174(this, node, loweredReceiver, loweredArguments, f_10505_2126_2147(node), f_10505_2149_2173(node));
DynAbs.Tracing.TraceSender.TraceExitMethod(10505,1818,2186);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_1964_1977(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.Receiver;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 1964, 1977);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10505_1948_1978(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 1948, 1978);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10505_2026_2040(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 2026, 2040);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10505_2016_2041(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
list)
{
var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundExpression>( list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 2016, 2041);
return return_v;
}


System.Collections.Immutable.ImmutableArray<string>
f_10505_2126_2147(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.ArgumentNamesOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 2126, 2147);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
f_10505_2149_2173(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.ArgumentRefKindsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 2149, 2173);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_2065_2174(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
node,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredReceiver,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
loweredArguments,System.Collections.Immutable.ImmutableArray<string>
argumentNames,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
refKinds)
{
var return_v = this_param.MakeDynamicGetIndex( node, loweredReceiver, loweredArguments, argumentNames, refKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 2065, 2174);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10505,1818,2186);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10505,1818,2186);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeDynamicGetIndex(
            BoundDynamicIndexerAccess node,
            BoundExpression loweredReceiver,
            ImmutableArray<BoundExpression> loweredArguments,
            ImmutableArray<string> argumentNames,
            ImmutableArray<RefKind> refKinds)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10505,2198,3009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,2686,2755);

f_10505_2686_2754(this, loweredReceiver, f_10505_2717_2740(node), node.Syntax);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,2771,2998);

return f_10505_2778_2982(_dynamicFactory, f_10505_2832_2887(this, node, loweredReceiver), loweredArguments, argumentNames, refKinds).ToExpression();
DynAbs.Tracing.TraceSender.TraceExitMethod(10505,2198,3009);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
f_10505_2717_2740(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
this_param)
{
var return_v = this_param.ApplicableIndexers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 2717, 2740);
return return_v;
}


int
f_10505_2686_2754(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiver,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
properties,Microsoft.CodeAnalysis.SyntaxNode
syntaxNode)
{
this_param.EmbedIfNeedTo( receiver, properties, syntaxNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 2686, 2754);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_2832_2887(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
indexerAccess,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredReceiver)
{
var return_v = this_param.MakeDynamicIndexerAccessReceiver( indexerAccess, loweredReceiver);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 2832, 2887);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
f_10505_2778_2982(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredReceiver,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
loweredArguments,System.Collections.Immutable.ImmutableArray<string>
argumentNames,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
refKinds)
{
var return_v = this_param.MakeDynamicGetIndex( loweredReceiver, loweredArguments, argumentNames, refKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 2778, 2982);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10505,2198,3009);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10505,2198,3009);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode VisitIndexerAccess(BoundIndexerAccess node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10505,3021,3359);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,3115,3186);

f_10505_3115_3185(f_10505_3128_3150(f_10505_3128_3140(node))||(DynAbs.Tracing.TraceSender.Expression_False(10505, 3128, 3184)||f_10505_3154_3184(f_10505_3154_3166(node))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,3200,3273);

f_10505_3200_3272((object?)f_10505_3222_3263(f_10505_3222_3234(node))!= null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,3289,3348);

return f_10505_3296_3347(this, node, isLeftOfAssignment: false);
DynAbs.Tracing.TraceSender.TraceExitMethod(10505,3021,3359);

Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
f_10505_3128_3140(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.Indexer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 3128, 3140);
return return_v;
}


bool
f_10505_3128_3150(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
this_param)
{
var return_v = this_param.IsIndexer ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 3128, 3150);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
f_10505_3154_3166(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.Indexer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 3154, 3166);
return return_v;
}


bool
f_10505_3154_3184(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
this_param)
{
var return_v = this_param.IsIndexedProperty;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 3154, 3184);
return return_v;
}


int
f_10505_3115_3185(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 3115, 3185);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
f_10505_3222_3234(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.Indexer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 3222, 3234);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10505_3222_3263(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
property)
{
var return_v = property.GetOwnOrInheritedGetMethod();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 3222, 3263);
return return_v;
}


int
f_10505_3200_3272(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 3200, 3272);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_3296_3347(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
node,bool
isLeftOfAssignment)
{
var return_v = this_param.VisitIndexerAccess( node, isLeftOfAssignment: isLeftOfAssignment);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 3296, 3347);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10505,3021,3359);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10505,3021,3359);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression VisitIndexerAccess(BoundIndexerAccess node, bool isLeftOfAssignment)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10505,3371,4674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,3488,3526);

PropertySymbol 
indexer = f_10505_3513_3525(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,3540,3601);

f_10505_3540_3600(f_10505_3553_3570(indexer)||(DynAbs.Tracing.TraceSender.Expression_False(10505, 3553, 3599)||f_10505_3574_3599(indexer)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,3655,3726);

BoundExpression? 
rewrittenReceiver = f_10505_3692_3725(this, f_10505_3708_3724(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,3740,3779);

f_10505_3740_3778(rewrittenReceiver is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,4131,4210);

ImmutableArray<BoundExpression> 
rewrittenArguments = f_10505_4184_4209(this, f_10505_4194_4208(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,4226,4663);

return f_10505_4233_4662(this, node.Syntax, rewrittenReceiver, indexer, rewrittenArguments, f_10505_4398_4419(node), f_10505_4438_4462(node), f_10505_4481_4494(node), f_10505_4513_4533(node), f_10505_4552_4573(node), f_10505_4592_4601(node), node, isLeftOfAssignment);
DynAbs.Tracing.TraceSender.TraceExitMethod(10505,3371,4674);

Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
f_10505_3513_3525(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.Indexer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 3513, 3525);
return return_v;
}


bool
f_10505_3553_3570(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
this_param)
{
var return_v = this_param.IsIndexer ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 3553, 3570);
return return_v;
}


bool
f_10505_3574_3599(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
this_param)
{
var return_v = this_param.IsIndexedProperty;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 3574, 3599);
return return_v;
}


int
f_10505_3540_3600(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 3540, 3600);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10505_3708_3724(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.ReceiverOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 3708, 3724);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10505_3692_3725(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 3692, 3725);
return return_v;
}


int
f_10505_3740_3778(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 3740, 3778);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10505_4194_4208(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 4194, 4208);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10505_4184_4209(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
list)
{
var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundExpression>( list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 4184, 4209);
return return_v;
}


System.Collections.Immutable.ImmutableArray<string>
f_10505_4398_4419(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.ArgumentNamesOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 4398, 4419);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
f_10505_4438_4462(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.ArgumentRefKindsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 4438, 4462);
return return_v;
}


bool
f_10505_4481_4494(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.Expanded;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 4481, 4494);
return return_v;
}


System.Collections.Immutable.ImmutableArray<int>
f_10505_4513_4533(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.ArgsToParamsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 4513, 4533);
return return_v;
}


Microsoft.CodeAnalysis.BitVector
f_10505_4552_4573(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.DefaultArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 4552, 4573);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10505_4592_4601(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 4592, 4601);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_4233_4662(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenReceiver,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
indexer,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments,System.Collections.Immutable.ImmutableArray<string>
argumentNamesOpt,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKindsOpt,bool
expanded,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,Microsoft.CodeAnalysis.BitVector
defaultArguments,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
oldNodeOpt,bool
isLeftOfAssignment)
{
var return_v = this_param.MakeIndexerAccess( syntax, rewrittenReceiver, indexer, rewrittenArguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, type, oldNodeOpt, isLeftOfAssignment);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 4233, 4662);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10505,3371,4674);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10505,3371,4674);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeIndexerAccess(
            SyntaxNode syntax,
            BoundExpression rewrittenReceiver,
            PropertySymbol indexer,
            ImmutableArray<BoundExpression> rewrittenArguments,
            ImmutableArray<string> argumentNamesOpt,
            ImmutableArray<RefKind> argumentRefKindsOpt,
            bool expanded,
            ImmutableArray<int> argsToParamsOpt,
            BitVector defaultArguments,
            TypeSymbol type,
            BoundIndexerAccess? oldNodeOpt,
            bool isLeftOfAssignment)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10505,4686,7429);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,5279,7418) || true) && (isLeftOfAssignment &&(DynAbs.Tracing.TraceSender.Expression_True(10505, 5283, 5336)&&f_10505_5305_5320(indexer)== RefKind.None))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10505,5279,7418);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,5595,5992);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10505, 5602, 5620)||((oldNodeOpt != null &&DynAbs.Tracing.TraceSender.Conditional_F2(10505, 5644, 5799))||DynAbs.Tracing.TraceSender.Conditional_F3(10505, 5823, 5991)))?f_10505_5644_5799(                    oldNodeOpt, rewrittenReceiver, indexer, rewrittenArguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, type):f_10505_5823_5991(syntax, rewrittenReceiver, indexer, rewrittenArguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10505,5279,7418);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10505,5279,7418);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,6058,6111);

var 
getMethod = f_10505_6074_6110(indexer)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,6129,6165);

f_10505_6129_6164(getMethod is not null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,6462,6496);

ImmutableArray<LocalSymbol> 
temps
=default(ImmutableArray<LocalSymbol>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,6514,6853);

rewrittenArguments = f_10505_6535_6852(this, syntax, rewrittenArguments, indexer, expanded, argsToParamsOpt, ref argumentRefKindsOpt, out temps, enableCallerInfo: ThreeState.True);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,6873,6985);

BoundExpression 
call = f_10505_6896_6984(this, syntax, rewrittenReceiver, indexer, rewrittenArguments, getMethod)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,7005,7403) || true) && (temps.IsDefaultOrEmpty)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10505,7005,7403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,7073,7085);

return call;
DynAbs.Tracing.TraceSender.TraceExitCondition(10505,7005,7403);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10505,7005,7403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,7167,7384);

return f_10505_7174_7383(syntax, temps, ImmutableArray<BoundExpression>.Empty, call, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10505,7005,7403);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10505,5279,7418);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10505,4686,7429);

Microsoft.CodeAnalysis.RefKind
f_10505_5305_5320(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
this_param)
{
var return_v = this_param.RefKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 5305, 5320);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
f_10505_5644_5799(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
indexer,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments,System.Collections.Immutable.ImmutableArray<string>
argumentNamesOpt,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKindsOpt,bool
expanded,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,Microsoft.CodeAnalysis.BitVector
defaultArguments,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Update( receiverOpt, indexer, arguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 5644, 5799);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
f_10505_5823_5991(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
indexer,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments,System.Collections.Immutable.ImmutableArray<string>
argumentNamesOpt,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKindsOpt,bool
expanded,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,Microsoft.CodeAnalysis.BitVector
defaultArguments,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess( syntax, receiverOpt, indexer, arguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 5823, 5991);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10505_6074_6110(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
property)
{
var return_v = property.GetOwnOrInheritedGetMethod();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 6074, 6110);
return return_v;
}


int
f_10505_6129_6164(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 6129, 6164);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10505_6535_6852(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
methodOrIndexer,bool
expanded,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKindsOpt,out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps,Microsoft.CodeAnalysis.ThreeState
enableCallerInfo)
{
var return_v = this_param.MakeArguments( syntax, rewrittenArguments, (Microsoft.CodeAnalysis.CSharp.Symbol)methodOrIndexer, expanded, argsToParamsOpt, ref argumentRefKindsOpt, out temps, enableCallerInfo: enableCallerInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 6535, 6852);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_6896_6984(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenReceiver,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
property,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
getMethodOpt)
{
var return_v = this_param.MakePropertyGetAccess( syntax, rewrittenReceiver, property, rewrittenArguments, getMethodOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 6896, 6984);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10505_7174_7383(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax, locals, sideEffects, value, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 7174, 7383);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10505,4686,7429);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10505,4686,7429);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode VisitIndexOrRangePatternIndexerAccess(BoundIndexOrRangePatternIndexerAccess node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10505,7441,7662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,7573,7651);

return f_10505_7580_7650(this, node, isLeftOfAssignment: false);
DynAbs.Tracing.TraceSender.TraceExitMethod(10505,7441,7662);

Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10505_7580_7650(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
node,bool
isLeftOfAssignment)
{
var return_v = this_param.VisitIndexOrRangePatternIndexerAccess( node, isLeftOfAssignment: isLeftOfAssignment);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 7580, 7650);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10505,7441,7662);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10505,7441,7662);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundSequence VisitIndexOrRangePatternIndexerAccess(BoundIndexOrRangePatternIndexerAccess node, bool isLeftOfAssignment)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10505,7674,8897);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,7827,8886) || true) && (f_10505_7831_8015(f_10505_7867_7885(f_10505_7867_7880(node)), f_10505_7904_7961(                _compilation, WellKnownType.System_Index), TypeCompareKind.ConsiderEverything))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10505,7827,8886);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,8049,8361);

return f_10505_8056_8360(this, node.Syntax, f_10505_8143_8156(node), f_10505_8179_8205(node), f_10505_8244_8262(node), f_10505_8285_8298(node), isLeftOfAssignment: isLeftOfAssignment);
DynAbs.Tracing.TraceSender.TraceExitCondition(10505,7827,8886);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10505,7827,8886);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,8427,8638);

f_10505_8427_8637(f_10505_8440_8636(f_10505_8480_8498(f_10505_8480_8493(node)), f_10505_8521_8578(                    _compilation, WellKnownType.System_Range), TypeCompareKind.ConsiderEverything));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,8656,8871);

return f_10505_8663_8870(this, f_10505_8716_8729(node), f_10505_8752_8778(node), f_10505_8815_8833(node), f_10505_8856_8869(node));
DynAbs.Tracing.TraceSender.TraceExitCondition(10505,7827,8886);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10505,7674,8897);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_7867_7880(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
this_param)
{
var return_v = this_param.Argument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 7867, 7880);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10505_7867_7885(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 7867, 7885);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10505_7904_7961(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownType
type)
{
var return_v = this_param.GetWellKnownType( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 7904, 7961);
return return_v;
}


bool
f_10505_7831_8015(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
left,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 7831, 8015);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_8143_8156(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
this_param)
{
var return_v = this_param.Receiver;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 8143, 8156);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
f_10505_8179_8205(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
this_param)
{
var return_v = this_param.LengthOrCountProperty;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 8179, 8205);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10505_8244_8262(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
this_param)
{
var return_v = this_param.PatternSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 8244, 8262);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_8285_8298(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
this_param)
{
var return_v = this_param.Argument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 8285, 8298);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10505_8056_8360(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
lengthOrCountProperty,Microsoft.CodeAnalysis.CSharp.Symbol
intIndexer,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,bool
isLeftOfAssignment)
{
var return_v = this_param.VisitIndexPatternIndexerAccess( syntax, receiver, lengthOrCountProperty, (Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol)intIndexer, argument, isLeftOfAssignment: isLeftOfAssignment);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 8056, 8360);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_8480_8493(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
this_param)
{
var return_v = this_param.Argument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 8480, 8493);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10505_8480_8498(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 8480, 8498);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10505_8521_8578(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownType
type)
{
var return_v = this_param.GetWellKnownType( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 8521, 8578);
return return_v;
}


bool
f_10505_8440_8636(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
left,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 8440, 8636);
return return_v;
}


int
f_10505_8427_8637(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 8427, 8637);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_8716_8729(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
this_param)
{
var return_v = this_param.Receiver;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 8716, 8729);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
f_10505_8752_8778(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
this_param)
{
var return_v = this_param.LengthOrCountProperty;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 8752, 8778);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10505_8815_8833(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
this_param)
{
var return_v = this_param.PatternSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 8815, 8833);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_8856_8869(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
this_param)
{
var return_v = this_param.Argument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 8856, 8869);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10505_8663_8870(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
lengthOrCountProperty,Microsoft.CodeAnalysis.CSharp.Symbol
sliceMethod,Microsoft.CodeAnalysis.CSharp.BoundExpression
rangeArg)
{
var return_v = this_param.VisitRangePatternIndexerAccess( receiver, lengthOrCountProperty, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)sliceMethod, rangeArg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 8663, 8870);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10505,7674,8897);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10505,7674,8897);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundSequence VisitIndexPatternIndexerAccess(
            SyntaxNode syntax,
            BoundExpression receiver,
            PropertySymbol lengthOrCountProperty,
            PropertySymbol intIndexer,
            BoundExpression argument,
            bool isLeftOfAssignment)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10505,8911,11549);
Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator receiverStore = default(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator);
Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator lengthStore = default(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator);
bool usedLength = default(bool);
Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator indexStore = default(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,9444,9461);

var 
F = _factory
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,9477,9512);

f_10505_9477_9511(f_10505_9490_9503(receiver)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,9526,9835);

var 
receiverLocal = f_10505_9546_9834(F, f_10505_9578_9603(this, receiver), out receiverStore, (DynAbs.Tracing.TraceSender.Conditional_F1(10505, 9775, 9804)||((f_10505_9775_9804(f_10505_9775_9788(receiver))&&DynAbs.Tracing.TraceSender.Conditional_F2(10505, 9807, 9819))||DynAbs.Tracing.TraceSender.Conditional_F3(10505, 9822, 9833)))?RefKind.None :RefKind.Ref)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,9849,9952);

var 
lengthLocal = f_10505_9867_9951(F, f_10505_9881_9929(F, receiverLocal, lengthOrCountProperty), out lengthStore)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,9966,10130);

var 
indexLocal = f_10505_9983_10129(F, f_10505_10015_10091(this, argument, lengthLocal, out usedLength), out indexStore)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,10401,10455);

var 
locals = f_10505_10414_10454(3)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,10469,10532);

var 
sideEffects = f_10505_10487_10531(3)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,10548,10586);

f_10505_10548_10585(
            locals, f_10505_10559_10584(receiverLocal));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,10600,10631);

f_10505_10600_10630(            sideEffects, receiverStore);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,10647,10793) || true) && (usedLength)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10505,10647,10793);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,10695,10731);

f_10505_10695_10730(                locals, f_10505_10706_10729(lengthLocal));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,10749,10778);

f_10505_10749_10777(                sideEffects, lengthStore);
DynAbs.Tracing.TraceSender.TraceExitCondition(10505,10647,10793);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,10809,10844);

f_10505_10809_10843(
            locals, f_10505_10820_10842(indexLocal));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,10858,10886);

f_10505_10858_10885(            sideEffects, indexStore);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,10902,11538);

return (BoundSequence)f_10505_10924_11537(F, f_10505_10953_10973(                locals), f_10505_10992_11017(                sideEffects), f_10505_11036_11536(this, syntax, receiverLocal, intIndexer, f_10505_11174_11224(indexLocal), default, default, expanded: false, argsToParamsOpt: default, defaultArguments: default, f_10505_11440_11455(intIndexer), oldNodeOpt: null, isLeftOfAssignment));
DynAbs.Tracing.TraceSender.TraceExitMethod(10505,8911,11549);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10505_9490_9503(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 9490, 9503);
return return_v;
}


int
f_10505_9477_9511(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 9477, 9511);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10505_9578_9603(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 9578, 9603);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10505_9775_9788(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 9775, 9788);
return return_v;
}


bool
f_10505_9775_9804(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.IsReferenceType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 9775, 9804);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10505_9546_9834(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store,Microsoft.CodeAnalysis.RefKind
refKind)
{
var return_v = this_param.StoreToTemp( argument, out store, refKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 9546, 9834);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_9881_9929(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
property)
{
var return_v = this_param.Property( (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 9881, 9929);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10505_9867_9951(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 9867, 9951);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_10015_10091(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
unloweredExpr,Microsoft.CodeAnalysis.CSharp.BoundLocal
lengthAccess,out bool
usedLength)
{
var return_v = this_param.MakePatternIndexOffsetExpression( unloweredExpr, (Microsoft.CodeAnalysis.CSharp.BoundExpression)lengthAccess, out usedLength);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 10015, 10091);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10505_9983_10129(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 9983, 10129);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10505_10414_10454(int
capacity)
{
var return_v = ArrayBuilder<LocalSymbol>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 10414, 10454);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10505_10487_10531(int
capacity)
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 10487, 10531);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10505_10559_10584(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 10559, 10584);
return return_v;
}


int
f_10505_10548_10585(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 10548, 10585);
return 0;
}


int
f_10505_10600_10630(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 10600, 10630);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10505_10706_10729(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 10706, 10729);
return return_v;
}


int
f_10505_10695_10730(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 10695, 10730);
return 0;
}


int
f_10505_10749_10777(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 10749, 10777);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10505_10820_10842(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 10820, 10842);
return return_v;
}


int
f_10505_10809_10843(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 10809, 10843);
return 0;
}


int
f_10505_10858_10885(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 10858, 10885);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10505_10953_10973(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
var return_v = this_param.ToImmutable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 10953, 10973);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10505_10992_11017(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 10992, 11017);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10505_11174_11224(Microsoft.CodeAnalysis.CSharp.BoundLocal
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 11174, 11224);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10505_11440_11455(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 11440, 11455);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_11036_11536(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
rewrittenReceiver,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
indexer,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments,System.Collections.Immutable.ImmutableArray<string>
argumentNamesOpt,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKindsOpt,bool
expanded,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,Microsoft.CodeAnalysis.BitVector
defaultArguments,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess?
oldNodeOpt,bool
isLeftOfAssignment)
{
var return_v = this_param.MakeIndexerAccess( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenReceiver, indexer, rewrittenArguments, argumentNamesOpt, argumentRefKindsOpt, expanded: expanded, argsToParamsOpt: argsToParamsOpt, defaultArguments: defaultArguments, type, oldNodeOpt: oldNodeOpt, isLeftOfAssignment);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 11036, 11536);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_10924_11537(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
result)
{
var return_v = this_param.Sequence( locals, sideEffects, result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 10924, 11537);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10505,8911,11549);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10505,8911,11549);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakePatternIndexOffsetExpression(
            BoundExpression unloweredExpr,
            BoundExpression lengthAccess,
            out bool usedLength)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10505,12475,14072);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,12678,12877);

f_10505_12678_12876(f_10505_12691_12875(f_10505_12727_12745(unloweredExpr), f_10505_12764_12821(                _compilation, WellKnownType.System_Index), TypeCompareKind.ConsiderEverything));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,12893,12910);

var 
F = _factory
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,12926,14061) || true) && (unloweredExpr is BoundFromEndIndexExpression hatExpression)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10505,12926,14061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,13179,13270);

f_10505_13179_13269(f_10505_13192_13213(hatExpression)is { Type: { SpecialType: SpecialType.System_Int32 } });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,13288,13306);

usedLength = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,13324,13399);

return f_10505_13331_13398(F, lengthAccess, f_10505_13359_13397(this, f_10505_13375_13396(hatExpression)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10505,12926,14061);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10505,12926,14061);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,13433,14061) || true) && (unloweredExpr is BoundConversion { Operand: { Type: { SpecialType: SpecialType.System_Int32 } } operand })
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10505,13433,14061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,13710,13729);

usedLength = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,13747,13779);

return f_10505_13754_13778(this, operand);
DynAbs.Tracing.TraceSender.TraceExitCondition(10505,13433,14061);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10505,13433,14061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,13845,13863);

usedLength = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,13881,14046);

return f_10505_13888_14045(F, f_10505_13917_13947(this, unloweredExpr), WellKnownMember.System_Index__GetOffset, lengthAccess);
DynAbs.Tracing.TraceSender.TraceExitCondition(10505,13433,14061);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10505,12926,14061);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10505,12475,14072);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10505_12727_12745(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 12727, 12745);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10505_12764_12821(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownType
type)
{
var return_v = this_param.GetWellKnownType( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 12764, 12821);
return return_v;
}


bool
f_10505_12691_12875(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
left,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 12691, 12875);
return return_v;
}


int
f_10505_12678_12876(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 12678, 12876);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_13192_13213(Microsoft.CodeAnalysis.CSharp.BoundFromEndIndexExpression
this_param)
{
var return_v = this_param.Operand ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 13192, 13213);
return return_v;
}


int
f_10505_13179_13269(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 13179, 13269);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_13375_13396(Microsoft.CodeAnalysis.CSharp.BoundFromEndIndexExpression
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 13375, 13396);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10505_13359_13397(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 13359, 13397);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10505_13331_13398(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.IntSubtract( left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 13331, 13398);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10505_13754_13778(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 13754, 13778);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10505_13917_13947(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 13917, 13947);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10505_13888_14045(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiver,Microsoft.CodeAnalysis.WellKnownMember
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg0)
{
var return_v = this_param.Call( receiver, method, arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 13888, 14045);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10505,12475,14072);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10505,12475,14072);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundSequence VisitRangePatternIndexerAccess(
            BoundExpression receiver,
            PropertySymbol lengthOrCountProperty,
            MethodSymbol sliceMethod,
            BoundExpression rangeArg)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10505,14084,19848);
Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator receiverStore = default(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator);
Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator lengthStore = default(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator);
Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator startStore = default(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator);
bool usedLengthTemp = default(bool);
Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator rangeStore = default(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator);
Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator rangeSizeStore = default(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,14330,14524);

f_10505_14330_14523(f_10505_14343_14522(f_10505_14379_14392(rangeArg), f_10505_14411_14468(                _compilation, WellKnownType.System_Range), TypeCompareKind.ConsiderEverything));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,14904,14921);

var 
F = _factory
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,14937,14997);

var 
localsBuilder = f_10505_14957_14996()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,15011,15080);

var 
sideEffectsBuilder = f_10505_15036_15079()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,15096,15180);

var 
receiverLocal = f_10505_15116_15179(F, f_10505_15130_15155(this, receiver), out receiverStore)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,15194,15297);

var 
lengthLocal = f_10505_15212_15296(F, f_10505_15226_15274(F, receiverLocal, lengthOrCountProperty), out lengthStore)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,15313,15358);

f_10505_15313_15357(
            localsBuilder, f_10505_15331_15356(receiverLocal));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,15372,15410);

f_10505_15372_15409(            sideEffectsBuilder, receiverStore);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,15426,15452);

BoundExpression 
startExpr
=default(BoundExpression);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,15466,15496);

BoundExpression 
rangeSizeExpr
=default(BoundExpression);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,15510,19597) || true) && (rangeArg is BoundRangeExpression rangeExpr)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10505,15510,19597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,16136,16160);

bool 
usedLength = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,16180,16759) || true) && (f_10505_16184_16208(rangeExpr)is BoundExpression left)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10505,16180,16759);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,16274,16465);

var 
startLocal = f_10505_16291_16464(F, f_10505_16331_16418(this, f_10505_16364_16388(rangeExpr), lengthLocal, out usedLength), out startStore)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,16489,16531);

f_10505_16489_16530(
                    localsBuilder, f_10505_16507_16529(startLocal));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,16553,16588);

f_10505_16553_16587(                    sideEffectsBuilder, startStore);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,16610,16633);

startExpr = startLocal;
DynAbs.Tracing.TraceSender.TraceExitCondition(10505,16180,16759);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10505,16180,16759);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,16715,16740);

startExpr = f_10505_16727_16739(F, 0);
DynAbs.Tracing.TraceSender.TraceExitCondition(10505,16180,16759);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,16779,16803);

BoundExpression 
endExpr
=default(BoundExpression);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,16821,17295) || true) && (f_10505_16825_16850(rangeExpr)is BoundExpression right)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10505,16821,17295);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,16917,17081);

endExpr = f_10505_16927_17080(this, right, lengthLocal, out usedLengthTemp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,17103,17132);

usedLength |= usedLengthTemp;
DynAbs.Tracing.TraceSender.TraceExitCondition(10505,16821,17295);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10505,16821,17295);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,17214,17232);

usedLength = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,17254,17276);

endExpr = lengthLocal;
DynAbs.Tracing.TraceSender.TraceExitCondition(10505,16821,17295);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,17315,17762) || true) && (usedLength)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10505,17315,17762);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,17630,17679);

f_10505_17630_17678(                    // If we used the length, it needs to be calculated after the receiver (the
                    // first bound node in the builder) and before the first use, which could be the
                    // second or third node in the builder
                    localsBuilder, 1, f_10505_17654_17677(lengthLocal));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,17701,17743);

f_10505_17701_17742(                    sideEffectsBuilder, 1, lengthStore);
DynAbs.Tracing.TraceSender.TraceExitCondition(10505,17315,17762);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,17782,17915);

var 
rangeSizeLocal = f_10505_17803_17914(F, f_10505_17839_17872(                    F, endExpr, startExpr), out rangeStore)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,17935,17981);

f_10505_17935_17980(
                localsBuilder, f_10505_17953_17979(rangeSizeLocal));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,17999,18034);

f_10505_17999_18033(                sideEffectsBuilder, rangeStore);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,18052,18083);

rangeSizeExpr = rangeSizeLocal;
DynAbs.Tracing.TraceSender.TraceExitCondition(10505,15510,19597);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10505,15510,19597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,18149,18227);

var 
rangeLocal = f_10505_18166_18226(F, f_10505_18180_18205(this, rangeArg), out rangeStore)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,18247,18290);

f_10505_18247_18289(
                localsBuilder, f_10505_18265_18288(lengthLocal));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,18308,18344);

f_10505_18308_18343(                sideEffectsBuilder, lengthStore);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,18362,18404);

f_10505_18362_18403(                localsBuilder, f_10505_18380_18402(rangeLocal));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,18422,18457);

f_10505_18422_18456(                sideEffectsBuilder, rangeStore);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,18477,18808);

var 
startLocal = f_10505_18494_18807(F, f_10505_18530_18765(                    F, f_10505_18563_18641(                        F, rangeLocal, f_10505_18582_18640(F, WellKnownMember.System_Range__get_Start)), f_10505_18668_18726(                        F, WellKnownMember.System_Index__GetOffset), lengthLocal), out startStore)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,18828,18870);

f_10505_18828_18869(
                localsBuilder, f_10505_18846_18868(startLocal));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,18888,18923);

f_10505_18888_18922(                sideEffectsBuilder, startStore);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,18941,18964);

startExpr = startLocal;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,18984,19410);

var 
rangeSizeLocal = f_10505_19005_19409(F, f_10505_19041_19363(                    F, f_10505_19081_19326(                        F, f_10505_19118_19194(                            F, rangeLocal, f_10505_19137_19193(F, WellKnownMember.System_Range__get_End)), f_10505_19225_19283(                            F, WellKnownMember.System_Index__GetOffset), lengthLocal), startExpr), out rangeSizeStore)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,19430,19476);

f_10505_19430_19475(
                localsBuilder, f_10505_19448_19474(rangeSizeLocal));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,19494,19533);

f_10505_19494_19532(                sideEffectsBuilder, rangeSizeStore);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,19551,19582);

rangeSizeExpr = rangeSizeLocal;
DynAbs.Tracing.TraceSender.TraceExitCondition(10505,15510,19597);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10505,19613,19837);

return (BoundSequence)f_10505_19635_19836(F, f_10505_19664_19698(                localsBuilder), f_10505_19717_19756(                sideEffectsBuilder), f_10505_19775_19835(                F, receiverLocal, sliceMethod, startExpr, rangeSizeExpr));
DynAbs.Tracing.TraceSender.TraceExitMethod(10505,14084,19848);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10505_14379_14392(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 14379, 14392);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10505_14411_14468(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownType
type)
{
var return_v = this_param.GetWellKnownType( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 14411, 14468);
return return_v;
}


bool
f_10505_14343_14522(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
left,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 14343, 14522);
return return_v;
}


int
f_10505_14330_14523(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 14330, 14523);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10505_14957_14996()
{
var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 14957, 14996);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10505_15036_15079()
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 15036, 15079);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10505_15130_15155(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 15130, 15155);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10505_15116_15179(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 15116, 15179);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_15226_15274(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
property)
{
var return_v = this_param.Property( (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, property);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 15226, 15274);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10505_15212_15296(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 15212, 15296);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10505_15331_15356(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 15331, 15356);
return return_v;
}


int
f_10505_15313_15357(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 15313, 15357);
return 0;
}


int
f_10505_15372_15409(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 15372, 15409);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10505_16184_16208(Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
this_param)
{
var return_v = this_param.LeftOperandOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 16184, 16208);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_16364_16388(Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
this_param)
{
var return_v = this_param.LeftOperandOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 16364, 16388);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_16331_16418(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
unloweredExpr,Microsoft.CodeAnalysis.CSharp.BoundLocal
lengthAccess,out bool
usedLength)
{
var return_v = this_param.MakePatternIndexOffsetExpression( unloweredExpr, (Microsoft.CodeAnalysis.CSharp.BoundExpression)lengthAccess, out usedLength);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 16331, 16418);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10505_16291_16464(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 16291, 16464);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10505_16507_16529(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 16507, 16529);
return return_v;
}


int
f_10505_16489_16530(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 16489, 16530);
return 0;
}


int
f_10505_16553_16587(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 16553, 16587);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10505_16727_16739(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,int
value)
{
var return_v = this_param.Literal( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 16727, 16739);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10505_16825_16850(Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
this_param)
{
var return_v = this_param.RightOperandOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 16825, 16850);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_16927_17080(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
unloweredExpr,Microsoft.CodeAnalysis.CSharp.BoundLocal
lengthAccess,out bool
usedLength)
{
var return_v = this_param.MakePatternIndexOffsetExpression( unloweredExpr, (Microsoft.CodeAnalysis.CSharp.BoundExpression)lengthAccess, out usedLength);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 16927, 17080);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10505_17654_17677(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 17654, 17677);
return return_v;
}


int
f_10505_17630_17678(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,int
index,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Insert( index, item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 17630, 17678);
return 0;
}


int
f_10505_17701_17742(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,int
index,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Insert( index, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 17701, 17742);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10505_17839_17872(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.IntSubtract( left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 17839, 17872);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10505_17803_17914(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( (Microsoft.CodeAnalysis.CSharp.BoundExpression)argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 17803, 17914);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10505_17953_17979(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 17953, 17979);
return return_v;
}


int
f_10505_17935_17980(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 17935, 17980);
return 0;
}


int
f_10505_17999_18033(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 17999, 18033);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10505_18180_18205(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 18180, 18205);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10505_18166_18226(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 18166, 18226);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10505_18265_18288(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 18265, 18288);
return return_v;
}


int
f_10505_18247_18289(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 18247, 18289);
return 0;
}


int
f_10505_18308_18343(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 18308, 18343);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10505_18380_18402(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 18380, 18402);
return return_v;
}


int
f_10505_18362_18403(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 18362, 18403);
return 0;
}


int
f_10505_18422_18456(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 18422, 18456);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10505_18582_18640(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.WellKnownMember
wm)
{
var return_v = this_param.WellKnownMethod( wm);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 18582, 18640);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10505_18563_18641(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = this_param.Call( (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 18563, 18641);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10505_18668_18726(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.WellKnownMember
wm)
{
var return_v = this_param.WellKnownMethod( wm);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 18668, 18726);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10505_18530_18765(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundCall
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundLocal
arg0)
{
var return_v = this_param.Call( (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 18530, 18765);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10505_18494_18807(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundCall
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( (Microsoft.CodeAnalysis.CSharp.BoundExpression)argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 18494, 18807);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10505_18846_18868(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 18846, 18868);
return return_v;
}


int
f_10505_18828_18869(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 18828, 18869);
return 0;
}


int
f_10505_18888_18922(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 18888, 18922);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10505_19137_19193(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.WellKnownMember
wm)
{
var return_v = this_param.WellKnownMethod( wm);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 19137, 19193);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10505_19118_19194(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = this_param.Call( (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 19118, 19194);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10505_19225_19283(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.WellKnownMember
wm)
{
var return_v = this_param.WellKnownMethod( wm);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 19225, 19283);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10505_19081_19326(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundCall
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundLocal
arg0)
{
var return_v = this_param.Call( (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 19081, 19326);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10505_19041_19363(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundCall
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right)
{
var return_v = this_param.IntSubtract( (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 19041, 19363);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10505_19005_19409(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( (Microsoft.CodeAnalysis.CSharp.BoundExpression)argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 19005, 19409);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10505_19448_19474(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10505, 19448, 19474);
return return_v;
}


int
f_10505_19430_19475(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 19430, 19475);
return 0;
}


int
f_10505_19494_19532(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 19494, 19532);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10505_19664_19698(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 19664, 19698);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10505_19717_19756(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 19717, 19756);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10505_19775_19835(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocal
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg0,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg1)
{
var return_v = this_param.Call( (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, arg0, arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 19775, 19835);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10505_19635_19836(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundCall
result)
{
var return_v = this_param.Sequence( locals, sideEffects, (Microsoft.CodeAnalysis.CSharp.BoundExpression)result);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10505, 19635, 19836);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10505,14084,19848);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10505,14084,19848);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
