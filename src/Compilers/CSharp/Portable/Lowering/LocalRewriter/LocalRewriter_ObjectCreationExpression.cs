// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitDynamicObjectCreationExpression(BoundDynamicObjectCreationExpression node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10515,538,1234);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,668,717);

var 
loweredArguments = f_10515_691_716(this, f_10515_701_715(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,731,914);

var 
constructorInvocation = f_10515_759_898(_dynamicFactory, node.Syntax, f_10515_821_830(node), loweredArguments, f_10515_850_871(node), f_10515_873_897(node)).ToExpression()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,930,1092) || true) && (f_10515_934_963(node)== null ||(DynAbs.Tracing.TraceSender.Expression_False(10515, 934, 1014)||f_10515_975_1014(f_10515_975_1004(node))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,930,1092);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,1048,1077);

return constructorInvocation;
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,930,1092);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,1108,1223);

return f_10515_1115_1222(this, node.Syntax, constructorInvocation, f_10515_1181_1210(node), f_10515_1212_1221(node));
DynAbs.Tracing.TraceSender.TraceExitMethod(10515,538,1234);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10515_701_715(Microsoft.CodeAnalysis.CSharp.BoundDynamicObjectCreationExpression
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 701, 715);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10515_691_716(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
list)
{
var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundExpression>( list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 691, 716);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10515_821_830(Microsoft.CodeAnalysis.CSharp.BoundDynamicObjectCreationExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 821, 830);
return return_v;
}


System.Collections.Immutable.ImmutableArray<string>
f_10515_850_871(Microsoft.CodeAnalysis.CSharp.BoundDynamicObjectCreationExpression
this_param)
{
var return_v = this_param.ArgumentNamesOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 850, 871);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
f_10515_873_897(Microsoft.CodeAnalysis.CSharp.BoundDynamicObjectCreationExpression
this_param)
{
var return_v = this_param.ArgumentRefKindsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 873, 897);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
f_10515_759_898(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
loweredArguments,System.Collections.Immutable.ImmutableArray<string>
argumentNames,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
refKinds)
{
var return_v = this_param.MakeDynamicConstructorInvocation( syntax, type, loweredArguments, argumentNames, refKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 759, 898);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
f_10515_934_963(Microsoft.CodeAnalysis.CSharp.BoundDynamicObjectCreationExpression
this_param)
{
var return_v = this_param.InitializerExpressionOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 934, 963);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
f_10515_975_1004(Microsoft.CodeAnalysis.CSharp.BoundDynamicObjectCreationExpression
this_param)
{
var return_v = this_param.InitializerExpressionOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 975, 1004);
return return_v;
}


bool
f_10515_975_1014(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
this_param)
{
var return_v = this_param.HasErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 975, 1014);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
f_10515_1181_1210(Microsoft.CodeAnalysis.CSharp.BoundDynamicObjectCreationExpression
this_param)
{
var return_v = this_param.InitializerExpressionOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 1181, 1210);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10515_1212_1221(Microsoft.CodeAnalysis.CSharp.BoundDynamicObjectCreationExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 1212, 1221);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10515_1115_1222(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenExpression,Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
initializerExpression,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeExpressionWithInitializer( syntax, rewrittenExpression, (Microsoft.CodeAnalysis.CSharp.BoundExpression)initializerExpression, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 1115, 1222);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10515,538,1234);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10515,538,1234);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode VisitObjectCreationExpression(BoundObjectCreationExpression node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10515,1246,4909);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,1362,1389);

f_10515_1362_1388(node != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,1718,1769);

var 
rewrittenArguments = f_10515_1743_1768(this, f_10515_1753_1767(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,2009,2043);

ImmutableArray<LocalSymbol> 
temps
=default(ImmutableArray<LocalSymbol>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,2057,2128);

ImmutableArray<RefKind> 
argumentRefKindsOpt = f_10515_2103_2127(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,2142,2421);

rewrittenArguments = f_10515_2163_2420(this, node.Syntax, rewrittenArguments, f_10515_2262_2278(node), f_10515_2297_2310(node), f_10515_2329_2349(node), ref argumentRefKindsOpt, out temps);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,2437,2477);

BoundExpression 
rewrittenObjectCreation
=default(BoundExpression);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,2493,3383) || true) && (_inExpressionLambda)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,2493,3383);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,2550,2693) || true) && (f_10515_2554_2577_M(!temps.IsDefaultOrEmpty))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,2550,2693);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,2619,2674);

throw f_10515_2625_2673(temps.Length);
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,2550,2693);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,2713,2942);

rewrittenObjectCreation = f_10515_2739_2941(node, rewrittenArguments, argumentRefKindsOpt, f_10515_2815_2892(this, f_10515_2862_2891(node)), changeTypeOpt: f_10515_2909_2940(f_10515_2909_2925(node)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,2962,3317) || true) && (f_10515_2966_2993(f_10515_2966_2975(node)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,2962,3317);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,3035,3181);

f_10515_3035_3180(f_10515_3048_3179(f_10515_3066_3094(rewrittenObjectCreation), f_10515_3096_3141(((NamedTypeSymbol)f_10515_3114_3123(node))), TypeCompareKind.ConsiderEverything2));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,3203,3298);

rewrittenObjectCreation = f_10515_3229_3297(this, rewrittenObjectCreation, f_10515_3273_3282(node), false, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,2962,3317);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,3337,3368);

return rewrittenObjectCreation;
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,2493,3383);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,3399,3581);

rewrittenObjectCreation = f_10515_3425_3580(node, rewrittenArguments, argumentRefKindsOpt, newInitializerExpression: null, changeTypeOpt: f_10515_3548_3579(f_10515_3548_3564(node)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,3676,3893) || true) && (f_10515_3680_3728(f_10515_3680_3696(node)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,3676,3893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,3762,3878);

rewrittenObjectCreation = f_10515_3788_3877(rewrittenObjectCreation.Syntax, rewrittenObjectCreation.Type!);
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,3676,3893);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,3909,4230) || true) && (f_10515_3913_3936_M(!temps.IsDefaultOrEmpty))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,3909,4230);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,3970,4215);

rewrittenObjectCreation = f_10515_3996_4214(node.Syntax, temps, ImmutableArray<BoundExpression>.Empty, rewrittenObjectCreation, f_10515_4204_4213(node));
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,3909,4230);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,4246,4585) || true) && (f_10515_4250_4277(f_10515_4250_4259(node)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,4246,4585);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,4311,4457);

f_10515_4311_4456(f_10515_4324_4455(f_10515_4342_4370(rewrittenObjectCreation), f_10515_4372_4417(((NamedTypeSymbol)f_10515_4390_4399(node))), TypeCompareKind.ConsiderEverything2));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,4475,4570);

rewrittenObjectCreation = f_10515_4501_4569(this, rewrittenObjectCreation, f_10515_4545_4554(node), false, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,4246,4585);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,4601,4765) || true) && (f_10515_4605_4634(node)== null ||(DynAbs.Tracing.TraceSender.Expression_False(10515, 4605, 4685)||f_10515_4646_4685(f_10515_4646_4675(node))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,4601,4765);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,4719,4750);

return rewrittenObjectCreation;
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,4601,4765);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,4781,4898);

return f_10515_4788_4897(this, node.Syntax, rewrittenObjectCreation, f_10515_4856_4885(node), f_10515_4887_4896(node));
DynAbs.Tracing.TraceSender.TraceExitMethod(10515,1246,4909);

int
f_10515_1362_1388(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 1362, 1388);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10515_1753_1767(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 1753, 1767);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10515_1743_1768(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
list)
{
var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundExpression>( list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 1743, 1768);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
f_10515_2103_2127(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.ArgumentRefKindsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 2103, 2127);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10515_2262_2278(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.Constructor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 2262, 2278);
return return_v;
}


bool
f_10515_2297_2310(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.Expanded;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 2297, 2310);
return return_v;
}


System.Collections.Immutable.ImmutableArray<int>
f_10515_2329_2349(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.ArgsToParamsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 2329, 2349);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10515_2163_2420(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
methodOrIndexer,bool
expanded,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKindsOpt,out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps)
{
var return_v = this_param.MakeArguments( syntax, rewrittenArguments, (Microsoft.CodeAnalysis.CSharp.Symbol)methodOrIndexer, expanded, argsToParamsOpt, ref argumentRefKindsOpt, out temps);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 2163, 2420);
return return_v;
}


bool
f_10515_2554_2577_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 2554, 2577);
return return_v;
}


System.Exception
f_10515_2625_2673(int
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 2625, 2673);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
f_10515_2862_2891(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.InitializerExpressionOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 2862, 2891);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
f_10515_2815_2892(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
initializerExpressionOpt)
{
var return_v = this_param.MakeObjectCreationInitializerForExpressionTree( initializerExpressionOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 2815, 2892);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10515_2909_2925(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.Constructor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 2909, 2925);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10515_2909_2940(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 2909, 2940);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
f_10515_2739_2941(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
newArguments,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
newRefKinds,Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
newInitializerExpression,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
changeTypeOpt)
{
var return_v = this_param.UpdateArgumentsAndInitializer( newArguments, newRefKinds, newInitializerExpression, changeTypeOpt: (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)changeTypeOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 2739, 2941);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10515_2966_2975(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 2966, 2975);
return return_v;
}


bool
f_10515_2966_2993(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsInterfaceType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 2966, 2993);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10515_3066_3094(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 3066, 3094);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10515_3114_3123(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 3114, 3123);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10515_3096_3141(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.ComImportCoClass;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 3096, 3141);
return return_v;
}


bool
f_10515_3048_3179(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
left,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 3048, 3179);
return return_v;
}


int
f_10515_3035_3180(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 3035, 3180);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10515_3273_3282(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 3273, 3282);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10515_3229_3297(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked,bool
acceptFailingConversion)
{
var return_v = this_param.MakeConversionNode( rewrittenOperand, rewrittenType, @checked, acceptFailingConversion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 3229, 3297);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10515_3548_3564(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.Constructor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 3548, 3564);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10515_3548_3579(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 3548, 3579);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
f_10515_3425_3580(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
newArguments,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
newRefKinds,Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
newInitializerExpression,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
changeTypeOpt)
{
var return_v = this_param.UpdateArgumentsAndInitializer( newArguments, newRefKinds, newInitializerExpression: newInitializerExpression, changeTypeOpt: (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)changeTypeOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 3425, 3580);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10515_3680_3696(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.Constructor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 3680, 3696);
return return_v;
}


bool
f_10515_3680_3728(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = method.IsDefaultValueTypeConstructor();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 3680, 3728);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
f_10515_3788_3877(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression( syntax, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 3788, 3877);
return return_v;
}


bool
f_10515_3913_3936_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 3913, 3936);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10515_4204_4213(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 4204, 4213);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10515_3996_4214(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax, locals, sideEffects, value, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 3996, 4214);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10515_4250_4259(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 4250, 4259);
return return_v;
}


bool
f_10515_4250_4277(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsInterfaceType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 4250, 4277);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10515_4342_4370(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 4342, 4370);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10515_4390_4399(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 4390, 4399);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10515_4372_4417(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.ComImportCoClass;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 4372, 4417);
return return_v;
}


bool
f_10515_4324_4455(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
left,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
right,Microsoft.CodeAnalysis.TypeCompareKind
comparison)
{
var return_v = TypeSymbol.Equals( left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 4324, 4455);
return return_v;
}


int
f_10515_4311_4456(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 4311, 4456);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10515_4545_4554(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 4545, 4554);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10515_4501_4569(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked,bool
acceptFailingConversion)
{
var return_v = this_param.MakeConversionNode( rewrittenOperand, rewrittenType, @checked, acceptFailingConversion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 4501, 4569);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
f_10515_4605_4634(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.InitializerExpressionOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 4605, 4634);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
f_10515_4646_4675(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.InitializerExpressionOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 4646, 4675);
return return_v;
}


bool
f_10515_4646_4685(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
this_param)
{
var return_v = this_param.HasErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 4646, 4685);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
f_10515_4856_4885(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.InitializerExpressionOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 4856, 4885);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10515_4887_4896(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 4887, 4896);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10515_4788_4897(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenExpression,Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
initializerExpression,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeExpressionWithInitializer( syntax, rewrittenExpression, (Microsoft.CodeAnalysis.CSharp.BoundExpression)initializerExpression, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 4788, 4897);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10515,1246,4909);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10515,1246,4909);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode VisitWithExpression(BoundWithExpression withExpr)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10515,4921,6122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,5021,5069);

f_10515_5021_5068(f_10515_5047_5067(withExpr));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,5083,5138);

f_10515_5083_5137(f_10515_5096_5131(f_10515_5096_5116(withExpr))== 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,5152,5248);

f_10515_5152_5247(f_10515_5165_5246(f_10515_5165_5182(withExpr).Type!, f_10515_5196_5209(withExpr), TypeCompareKind.ConsiderEverything));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,5715,5914);

var 
cloneCall = f_10515_5731_5913(_factory, f_10515_5766_5779(withExpr), f_10515_5798_5912(                _factory, f_10515_5834_5868(this, f_10515_5850_5867(withExpr)), f_10515_5891_5911(withExpr)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,5930,6111);

return f_10515_5937_6110(this, withExpr.Syntax, cloneCall, f_10515_6047_6077(withExpr), f_10515_6096_6109(withExpr));
DynAbs.Tracing.TraceSender.TraceExitMethod(10515,4921,6122);

Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10515_5047_5067(Microsoft.CodeAnalysis.CSharp.BoundWithExpression
this_param)
{
var return_v = this_param.CloneMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 5047, 5067);
return return_v;
}


int
f_10515_5021_5068(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
value)
{
RoslynDebug.AssertNotNull( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 5021, 5068);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10515_5096_5116(Microsoft.CodeAnalysis.CSharp.BoundWithExpression
this_param)
{
var return_v = this_param.CloneMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 5096, 5116);
return return_v;
}


int
f_10515_5096_5131(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ParameterCount ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 5096, 5131);
return return_v;
}


int
f_10515_5083_5137(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 5083, 5137);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10515_5165_5182(Microsoft.CodeAnalysis.CSharp.BoundWithExpression
this_param)
{
var return_v = this_param.Receiver;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 5165, 5182);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10515_5196_5209(Microsoft.CodeAnalysis.CSharp.BoundWithExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 5196, 5209);
return return_v;
}


bool
f_10515_5165_5246(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
t2,Microsoft.CodeAnalysis.TypeCompareKind
compareKind)
{
var return_v = this_param.Equals( t2, compareKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 5165, 5246);
return return_v;
}


int
f_10515_5152_5247(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 5152, 5247);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10515_5766_5779(Microsoft.CodeAnalysis.CSharp.BoundWithExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 5766, 5779);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10515_5850_5867(Microsoft.CodeAnalysis.CSharp.BoundWithExpression
this_param)
{
var return_v = this_param.Receiver;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 5850, 5867);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10515_5834_5868(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 5834, 5868);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10515_5891_5911(Microsoft.CodeAnalysis.CSharp.BoundWithExpression
this_param)
{
var return_v = this_param.CloneMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 5891, 5911);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10515_5798_5912(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = this_param.Call( receiver, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 5798, 5912);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10515_5731_5913(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundCall
arg)
{
var return_v = this_param.Convert( type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 5731, 5913);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
f_10515_6047_6077(Microsoft.CodeAnalysis.CSharp.BoundWithExpression
this_param)
{
var return_v = this_param.InitializerExpression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 6047, 6077);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10515_6096_6109(Microsoft.CodeAnalysis.CSharp.BoundWithExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 6096, 6109);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10515_5937_6110(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenExpression,Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
initializerExpression,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeExpressionWithInitializer( syntax, rewrittenExpression, (Microsoft.CodeAnalysis.CSharp.BoundExpression)initializerExpression, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 5937, 6110);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10515,4921,6122);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10515,4921,6122);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[return: NotNullIfNotNull("initializerExpressionOpt")]
        private BoundObjectInitializerExpressionBase? MakeObjectCreationInitializerForExpressionTree(BoundObjectInitializerExpressionBase? initializerExpressionOpt)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10515,6134,6876);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,6379,6837) || true) && (initializerExpressionOpt != null &&(DynAbs.Tracing.TraceSender.Expression_True(10515, 6383, 6454)&&f_10515_6419_6454_M(!initializerExpressionOpt.HasErrors)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,6379,6837);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,6623,6729);

var 
rewrittenInitializers = f_10515_6651_6728(this, initializerExpressionOpt)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,6747,6822);

return f_10515_6754_6821(initializerExpressionOpt, rewrittenInitializers);
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,6379,6837);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,6853,6865);

return null;
DynAbs.Tracing.TraceSender.TraceExitMethod(10515,6134,6876);

bool
f_10515_6419_6454_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 6419, 6454);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10515_6651_6728(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
initializerExpression)
{
var return_v = this_param.MakeObjectOrCollectionInitializersForExpressionTree( (Microsoft.CodeAnalysis.CSharp.BoundExpression)initializerExpression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 6651, 6728);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
f_10515_6754_6821(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
initializerExpression,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
newInitializers)
{
var return_v = UpdateInitializers( initializerExpression, newInitializers);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 6754, 6821);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10515,6134,6876);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10515,6134,6876);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeExpressionWithInitializer(
            SyntaxNode syntax,
            BoundExpression rewrittenExpression,
            BoundExpression initializerExpression,
            TypeSymbol type)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10515,6986,9127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,7229,7264);

f_10515_7229_7263(!_inExpressionLambda);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,7278,7358);

f_10515_7278_7357(initializerExpression != null &&(DynAbs.Tracing.TraceSender.Expression_True(10515, 7291, 7356)&&f_10515_7324_7356_M(!initializerExpression.HasErrors)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,7455,7501);

BoundAssignmentOperator 
boundAssignmentToTemp
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,7515,7603);

BoundLocal 
value = f_10515_7534_7602(_factory, rewrittenExpression, out boundAssignmentToTemp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,7685,7747);

ArrayBuilder<BoundExpression>? 
dynamicSiteInitializers = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,7761,7801);

ArrayBuilder<LocalSymbol>? 
temps = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,7815,7912);

ArrayBuilder<BoundExpression>? 
loweredInitializers = f_10515_7868_7911()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,7928,8053);

f_10515_7928_8052(this, ref dynamicSiteInitializers, ref temps, loweredInitializers, value, initializerExpression);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,8069,8128);

int 
dynamicSiteCount = f_10515_8092_8122_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(dynamicSiteInitializers, 10515, 8092, 8122)?.Count)??(DynAbs.Tracing.TraceSender.Expression_Null<int?>(10515, 8092, 8127)??0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,8142,8252);

var 
sideEffects = f_10515_8160_8251(1 + dynamicSiteCount + f_10515_8225_8250(loweredInitializers))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,8266,8305);

f_10515_8266_8304(            sideEffects, boundAssignmentToTemp);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,8321,8491) || true) && (dynamicSiteCount > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,8321,8491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,8379,8426);

f_10515_8379_8425(                sideEffects, dynamicSiteInitializers!);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,8444,8476);

f_10515_8444_8475(                dynamicSiteInitializers!);
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,8321,8491);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,8507,8549);

f_10515_8507_8548(
            sideEffects, loweredInitializers);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,8563,8590);

f_10515_8563_8589(            loweredInitializers);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,8606,8641);

ImmutableArray<LocalSymbol> 
locals
=default(ImmutableArray<LocalSymbol>);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,8655,8926) || true) && (temps == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,8655,8926);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,8706,8756);

locals = f_10515_8715_8755(f_10515_8737_8754(value));
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,8655,8926);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,8655,8926);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,8822,8857);

f_10515_8822_8856(                temps, 0, f_10515_8838_8855(value));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,8875,8911);

locals = f_10515_8884_8910(temps);
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,8655,8926);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,8942,9116);

return f_10515_8949_9115(syntax, locals, f_10515_9035_9067(                sideEffects), value, type);
DynAbs.Tracing.TraceSender.TraceExitMethod(10515,6986,9127);

int
f_10515_7229_7263(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 7229, 7263);
return 0;
}


bool
f_10515_7324_7356_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 7324, 7356);
return return_v;
}


int
f_10515_7278_7357(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 7278, 7357);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10515_7534_7602(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 7534, 7602);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10515_7868_7911()
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 7868, 7911);
return return_v;
}


int
f_10515_7928_8052(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>?
dynamicSiteInitializers,ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>?
temps,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
result,Microsoft.CodeAnalysis.CSharp.BoundLocal
rewrittenReceiver,Microsoft.CodeAnalysis.CSharp.BoundExpression
initializerExpression)
{
this_param.AddObjectOrCollectionInitializers( ref dynamicSiteInitializers, ref temps, result, (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenReceiver, initializerExpression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 7928, 8052);
return 0;
}


int?
f_10515_8092_8122_M(int?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 8092, 8122);
return return_v;
}


int
f_10515_8225_8250(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 8225, 8250);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10515_8160_8251(int
capacity)
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 8160, 8251);
return return_v;
}


int
f_10515_8266_8304(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 8266, 8304);
return 0;
}


int
f_10515_8379_8425(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
items)
{
this_param.AddRange( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 8379, 8425);
return 0;
}


int
f_10515_8444_8475(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 8444, 8475);
return 0;
}


int
f_10515_8507_8548(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
items)
{
this_param.AddRange( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 8507, 8548);
return 0;
}


int
f_10515_8563_8589(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 8563, 8589);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10515_8737_8754(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 8737, 8754);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10515_8715_8755(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 8715, 8755);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10515_8838_8855(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 8838, 8855);
return return_v;
}


int
f_10515_8822_8856(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,int
index,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Insert( index, item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 8822, 8856);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10515_8884_8910(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 8884, 8910);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10515_9035_9067(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 9035, 9067);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10515_8949_9115(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundLocal
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax, locals, sideEffects, (Microsoft.CodeAnalysis.CSharp.BoundExpression)value, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 8949, 9115);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10515,6986,9127);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10515,6986,9127);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode VisitNewT(BoundNewT node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10515,9139,9798);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,9215,9396) || true) && (_inExpressionLambda)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,9215,9396);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,9272,9381);

return f_10515_9279_9380(node, f_10515_9291_9368(this, f_10515_9338_9367(node)), f_10515_9370_9379(node));
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,9215,9396);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,9412,9486);

var 
rewrittenNewT = f_10515_9432_9485(this, node.Syntax, f_10515_9475_9484(node))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,9500,9654) || true) && (f_10515_9504_9533(node)== null ||(DynAbs.Tracing.TraceSender.Expression_False(10515, 9504, 9584)||f_10515_9545_9584(f_10515_9545_9574(node))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,9500,9654);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,9618,9639);

return rewrittenNewT;
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,9500,9654);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,9670,9787);

return f_10515_9677_9786(this, node.Syntax, rewrittenNewT, f_10515_9735_9764(node), rewrittenNewT.Type!);
DynAbs.Tracing.TraceSender.TraceExitMethod(10515,9139,9798);

Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
f_10515_9338_9367(Microsoft.CodeAnalysis.CSharp.BoundNewT
this_param)
{
var return_v = this_param.InitializerExpressionOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 9338, 9367);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
f_10515_9291_9368(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
initializerExpressionOpt)
{
var return_v = this_param.MakeObjectCreationInitializerForExpressionTree( initializerExpressionOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 9291, 9368);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10515_9370_9379(Microsoft.CodeAnalysis.CSharp.BoundNewT
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 9370, 9379);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNewT
f_10515_9279_9380(Microsoft.CodeAnalysis.CSharp.BoundNewT
this_param,Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
initializerExpressionOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Update( initializerExpressionOpt, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 9279, 9380);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10515_9475_9484(Microsoft.CodeAnalysis.CSharp.BoundNewT
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 9475, 9484);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10515_9432_9485(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
typeParameter)
{
var return_v = this_param.MakeNewT( syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)typeParameter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 9432, 9485);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
f_10515_9504_9533(Microsoft.CodeAnalysis.CSharp.BoundNewT
this_param)
{
var return_v = this_param.InitializerExpressionOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 9504, 9533);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
f_10515_9545_9574(Microsoft.CodeAnalysis.CSharp.BoundNewT
this_param)
{
var return_v = this_param.InitializerExpressionOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 9545, 9574);
return return_v;
}


bool
f_10515_9545_9584(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
this_param)
{
var return_v = this_param.HasErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 9545, 9584);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
f_10515_9735_9764(Microsoft.CodeAnalysis.CSharp.BoundNewT
this_param)
{
var return_v = this_param.InitializerExpressionOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 9735, 9764);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10515_9677_9786(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenExpression,Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
initializerExpression,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeExpressionWithInitializer( syntax, rewrittenExpression, (Microsoft.CodeAnalysis.CSharp.BoundExpression)initializerExpression, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 9677, 9786);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10515,9139,9798);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10515,9139,9798);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeNewT(SyntaxNode syntax, TypeParameterSymbol typeParameter)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10515,9810,11536);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,10447,10467);

MethodSymbol 
method
=default(MethodSymbol);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,10483,10719) || true) && (!f_10515_10488_10590(this, syntax, WellKnownMember.System_Activator__CreateInstance_T, out method))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,10483,10719);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,10624,10704);

return f_10515_10631_10703(syntax, type: typeParameter, hasErrors: true);
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,10483,10719);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,10735,10772);

f_10515_10735_10771((object)method != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,10786,10862);

method = f_10515_10795_10861(method, f_10515_10812_10860(typeParameter));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,10878,11483);

var 
createInstanceCall = f_10515_10903_11482(syntax, null, method, ImmutableArray<BoundExpression>.Empty, default(ImmutableArray<string>), default(ImmutableArray<RefKind>), isDelegateCall: false, expanded: false, invokedAsExtensionMethod: false, argsToParamsOpt: default(ImmutableArray<int>), defaultArguments: default(BitVector), resultKind: LookupResultKind.Viable, type: typeParameter)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,11499,11525);

return createInstanceCall;
DynAbs.Tracing.TraceSender.TraceExitMethod(10515,9810,11536);

bool
f_10515_10488_10590(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.WellKnownMember
member,out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
symbol)
{
var return_v = this_param.TryGetWellKnownTypeMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( syntax, member, out symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 10488, 10590);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
f_10515_10631_10703(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
type,bool
hasErrors)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression( syntax, type: (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, hasErrors: hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 10631, 10703);
return return_v;
}


int
f_10515_10735_10771(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 10735, 10771);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
f_10515_10812_10860(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
item)
{
var return_v = ImmutableArray.Create<TypeSymbol>( (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 10812, 10860);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10515_10795_10861(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
typeArguments)
{
var return_v = this_param.Construct( typeArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 10795, 10861);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10515_10903_11482(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments,System.Collections.Immutable.ImmutableArray<string>
argumentNamesOpt,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKindsOpt,bool
isDelegateCall,bool
expanded,bool
invokedAsExtensionMethod,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,Microsoft.CodeAnalysis.BitVector
defaultArguments,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundCall( syntax, receiverOpt, method, arguments, argumentNamesOpt, argumentRefKindsOpt, isDelegateCall: isDelegateCall, expanded: expanded, invokedAsExtensionMethod: invokedAsExtensionMethod, argsToParamsOpt: argsToParamsOpt, defaultArguments: defaultArguments, resultKind: resultKind, type: (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 10903, 11482);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10515,9810,11536);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10515,9810,11536);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode VisitNoPiaObjectCreationExpression(BoundNoPiaObjectCreationExpression node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10515,11548,14768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,12285,12324);

SyntaxNode 
oldSyntax = f_10515_12308_12323(_factory)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,12338,12368);

_factory.Syntax = node.Syntax;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,12384,12455);

var 
ctor = f_10515_12395_12454(_factory, WellKnownMember.System_Guid__ctor)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,12469,12493);

BoundExpression 
newGuid
=default(BoundExpression);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,12509,12940) || true) && (ctor is { })
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,12509,12940);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,12558,12595);

f_10515_12558_12594(f_10515_12571_12586(node)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,12613,12677);

newGuid = f_10515_12623_12676(_factory, ctor, f_10515_12642_12675(_factory, f_10515_12659_12674(node)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,12509,12940);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,12509,12940);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,12743,12925);

newGuid = f_10515_12753_12924(node.Syntax, LookupResultKind.NotCreatable, ImmutableArray<Symbol?>.Empty, ImmutableArray<BoundExpression>.Empty, ErrorTypeSymbol.UnknownResultType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,12509,12940);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,12956,13096);

var 
getTypeFromCLSID = f_10515_12979_13095(_factory, WellKnownMember.System_Runtime_InteropServices_Marshal__GetTypeFromCLSID, isOptional: true)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,13112,13280) || true) && (getTypeFromCLSID is null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,13112,13280);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,13174,13265);

getTypeFromCLSID = f_10515_13193_13264(_factory, WellKnownMember.System_Type__GetTypeFromCLSID);
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,13112,13280);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,13296,13333);

BoundExpression 
callGetTypeFromCLSID
=default(BoundExpression);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,13349,13769) || true) && (getTypeFromCLSID is { })
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,13349,13769);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,13410,13480);

callGetTypeFromCLSID = f_10515_13433_13479(_factory, null, getTypeFromCLSID, newGuid);
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,13349,13769);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,13349,13769);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,13546,13754);

callGetTypeFromCLSID = f_10515_13569_13753(node.Syntax, LookupResultKind.OverloadResolutionFailure, ImmutableArray<Symbol?>.Empty, ImmutableArray<BoundExpression>.Empty, ErrorTypeSymbol.UnknownResultType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,13349,13769);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,13785,13881);

var 
createInstance = f_10515_13806_13880(_factory, WellKnownMember.System_Activator__CreateInstance)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,13895,13935);

BoundExpression 
rewrittenObjectCreation
=default(BoundExpression);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,13951,14400) || true) && ((object)createInstance != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,13951,14400);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,14019,14132);

rewrittenObjectCreation = f_10515_14045_14131(_factory, f_10515_14062_14071(node), f_10515_14073_14130(_factory, null, createInstance, callGetTypeFromCLSID));
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,13951,14400);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,13951,14400);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,14198,14385);

rewrittenObjectCreation = f_10515_14224_14384(node.Syntax, LookupResultKind.OverloadResolutionFailure, ImmutableArray<Symbol?>.Empty, ImmutableArray<BoundExpression>.Empty, f_10515_14374_14383(node));
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,13951,14400);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,14416,14444);

_factory.Syntax = oldSyntax;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,14460,14624) || true) && (f_10515_14464_14493(node)== null ||(DynAbs.Tracing.TraceSender.Expression_False(10515, 14464, 14544)||f_10515_14505_14544(f_10515_14505_14534(node))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10515,14460,14624);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,14578,14609);

return rewrittenObjectCreation;
DynAbs.Tracing.TraceSender.TraceExitCondition(10515,14460,14624);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10515,14640,14757);

return f_10515_14647_14756(this, node.Syntax, rewrittenObjectCreation, f_10515_14715_14744(node), f_10515_14746_14755(node));
DynAbs.Tracing.TraceSender.TraceExitMethod(10515,11548,14768);

Microsoft.CodeAnalysis.SyntaxNode
f_10515_12308_12323(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.Syntax;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 12308, 12323);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10515_12395_12454(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.WellKnownMember
wm)
{
var return_v = this_param.WellKnownMethod( wm);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 12395, 12454);
return return_v;
}


string?
f_10515_12571_12586(Microsoft.CodeAnalysis.CSharp.BoundNoPiaObjectCreationExpression
this_param)
{
var return_v = this_param.GuidString ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 12571, 12586);
return return_v;
}


int
f_10515_12558_12594(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 12558, 12594);
return 0;
}


string
f_10515_12659_12674(Microsoft.CodeAnalysis.CSharp.BoundNoPiaObjectCreationExpression
this_param)
{
var return_v = this_param.GuidString;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 12659, 12674);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10515_12642_12675(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,string
value)
{
var return_v = this_param.Literal( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 12642, 12675);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
f_10515_12623_12676(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
ctor,params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
args)
{
var return_v = this_param.New( ctor, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 12623, 12676);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBadExpression
f_10515_12753_12924(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
symbols,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
childBoundNodes,Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression( syntax, resultKind, symbols, childBoundNodes, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 12753, 12924);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10515_12979_13095(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.WellKnownMember
wm,bool
isOptional)
{
var return_v = this_param.WellKnownMethod( wm, isOptional: isOptional);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 12979, 13095);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10515_13193_13264(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.WellKnownMember
wm)
{
var return_v = this_param.WellKnownMethod( wm);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 13193, 13264);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10515_13433_13479(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg0)
{
var return_v = this_param.Call( receiver, method, arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 13433, 13479);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBadExpression
f_10515_13569_13753(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
symbols,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
childBoundNodes,Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression( syntax, resultKind, symbols, childBoundNodes, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 13569, 13753);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10515_13806_13880(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.WellKnownMember
wm)
{
var return_v = this_param.WellKnownMethod( wm);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 13806, 13880);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10515_14062_14071(Microsoft.CodeAnalysis.CSharp.BoundNoPiaObjectCreationExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 14062, 14071);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10515_14073_14130(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg0)
{
var return_v = this_param.Call( receiver, method, arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 14073, 14130);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10515_14045_14131(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundCall
arg)
{
var return_v = this_param.Convert( type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 14045, 14131);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10515_14374_14383(Microsoft.CodeAnalysis.CSharp.BoundNoPiaObjectCreationExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 14374, 14383);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBadExpression
f_10515_14224_14384(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
symbols,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
childBoundNodes,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression( syntax, resultKind, symbols, childBoundNodes, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 14224, 14384);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
f_10515_14464_14493(Microsoft.CodeAnalysis.CSharp.BoundNoPiaObjectCreationExpression
this_param)
{
var return_v = this_param.InitializerExpressionOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 14464, 14493);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
f_10515_14505_14534(Microsoft.CodeAnalysis.CSharp.BoundNoPiaObjectCreationExpression
this_param)
{
var return_v = this_param.InitializerExpressionOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 14505, 14534);
return return_v;
}


bool
f_10515_14505_14544(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
this_param)
{
var return_v = this_param.HasErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 14505, 14544);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
f_10515_14715_14744(Microsoft.CodeAnalysis.CSharp.BoundNoPiaObjectCreationExpression
this_param)
{
var return_v = this_param.InitializerExpressionOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 14715, 14744);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10515_14746_14755(Microsoft.CodeAnalysis.CSharp.BoundNoPiaObjectCreationExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10515, 14746, 14755);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10515_14647_14756(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenExpression,Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
initializerExpression,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeExpressionWithInitializer( syntax, rewrittenExpression, (Microsoft.CodeAnalysis.CSharp.BoundExpression)initializerExpression, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10515, 14647, 14756);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10515,11548,14768);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10515,11548,14768);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
