// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Operations;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitDynamicInvocation(BoundDynamicInvocation node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10485,688,861);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,790,850);

return f_10485_797_849(this, node, resultDiscarded: false);
DynAbs.Tracing.TraceSender.TraceExitMethod(10485,688,861);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_797_849(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation
node,bool
resultDiscarded)
{
var return_v = this_param.VisitDynamicInvocation( node, resultDiscarded: resultDiscarded);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 797, 849);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,688,861);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,688,861);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public BoundExpression VisitDynamicInvocation(BoundDynamicInvocation node, bool resultDiscarded)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10485,873,4642);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,994,1043);

var 
loweredArguments = f_10485_1017_1042(this, f_10485_1027_1041(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,1059,1084);

bool 
hasImplicitReceiver
=default(bool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,1098,1130);

BoundExpression 
loweredReceiver
=default(BoundExpression);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,1144,1194);

ImmutableArray<TypeWithAnnotations> 
typeArguments
=default(ImmutableArray<TypeWithAnnotations>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,1208,1220);

string 
name
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,1234,4217);

switch (f_10485_1242_1262(f_10485_1242_1257(node)))
            {

case BoundKind.MethodGroup:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,1234,4217);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,1387,1452);

BoundMethodGroup 
methodGroup = (BoundMethodGroup)f_10485_1436_1451(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,1474,1519);

typeArguments = f_10485_1490_1518(methodGroup);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,1541,1565);

name = f_10485_1548_1564(methodGroup);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,1587,1678);

hasImplicitReceiver = (f_10485_1610_1627(methodGroup)& BoundMethodGroupFlags.HasImplicitReceiver) != 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,1792,1905);

f_10485_1792_1904(f_10485_1805_1828(methodGroup)== null ||(DynAbs.Tracing.TraceSender.Expression_False(10485, 1805, 1903)||f_10485_1840_1868(f_10485_1840_1863(methodGroup))!= BoundKind.TypeOrValueExpression));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,1929,3112) || true) && (f_10485_1933_1956(methodGroup)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,1929,3112);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,2113,2192);

NamedTypeSymbol 
firstContainer = f_10485_2146_2191(node.ApplicableMethods.First())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,2218,2385);

f_10485_2218_2384(node.ApplicableMethods.All(m => !m.RequiresInstanceReceiver && TypeSymbol.Equals(m.ContainingType, firstContainer, TypeCompareKind.ConsiderEverything2)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,2413,2490);

loweredReceiver = f_10485_2431_2489(node.Syntax, null, firstContainer);
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,1929,3112);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,1929,3112);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,2540,3112) || true) && (hasImplicitReceiver &&(DynAbs.Tracing.TraceSender.Expression_True(10485, 2544, 2629)&&f_10485_2567_2590(_factory)is { RequiresInstanceReceiver: false }))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,2540,3112);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,2781,2823);

f_10485_2781_2822(f_10485_2794_2814(_factory)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,2849,2932);

loweredReceiver = f_10485_2867_2931(node.Syntax, null, f_10485_2910_2930(_factory));
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,2540,3112);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,2540,3112);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,3030,3089);

loweredReceiver = f_10485_3048_3088(this, f_10485_3064_3087(methodGroup));
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,2540,3112);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,1929,3112);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,3319,3384);

f_10485_3319_3383(this, loweredReceiver, f_10485_3350_3369(methodGroup), node.Syntax);
DynAbs.Tracing.TraceSender.TraceBreak(10485,3408,3414);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,1234,4217);

case BoundKind.DynamicMemberAccess:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,1234,4217);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,3533,3594);

var 
memberAccess = (BoundDynamicMemberAccess)f_10485_3578_3593(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,3616,3641);

name = f_10485_3623_3640(memberAccess);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,3663,3709);

typeArguments = f_10485_3679_3708(memberAccess);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,3731,3788);

loweredReceiver = f_10485_3749_3787(this, f_10485_3765_3786(memberAccess));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,3810,3838);

hasImplicitReceiver = false;
DynAbs.Tracing.TraceSender.TraceBreak(10485,3860,3866);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,1234,4217);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,1234,4217);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,3960,4017);

var 
loweredExpression = f_10485_3984_4016(this, f_10485_4000_4015(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,4039,4202);

return f_10485_4046_4186(_dynamicFactory, loweredExpression, loweredArguments, f_10485_4121_4142(node), f_10485_4144_4168(node), resultDiscarded).ToExpression();
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,1234,4217);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,4233,4271);

f_10485_4233_4270(loweredReceiver != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,4285,4631);

return f_10485_4292_4615(_dynamicFactory, name, loweredReceiver, typeArguments, loweredArguments, f_10485_4478_4499(node), f_10485_4518_4542(node), hasImplicitReceiver, resultDiscarded).ToExpression();
DynAbs.Tracing.TraceSender.TraceExitMethod(10485,873,4642);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10485_1027_1041(Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 1027, 1041);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10485_1017_1042(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
list)
{
var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundExpression>( list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 1017, 1042);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_1242_1257(Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 1242, 1257);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10485_1242_1262(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 1242, 1262);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_1436_1451(Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 1436, 1451);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
f_10485_1490_1518(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
this_param)
{
var return_v = this_param.TypeArgumentsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 1490, 1518);
return return_v;
}


string
f_10485_1548_1564(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 1548, 1564);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundMethodGroupFlags?
f_10485_1610_1627(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
this_param)
{
var return_v = this_param.Flags ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 1610, 1627);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10485_1805_1828(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
this_param)
{
var return_v = this_param.ReceiverOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 1805, 1828);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_1840_1863(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
this_param)
{
var return_v = this_param.ReceiverOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 1840, 1863);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10485_1840_1868(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 1840, 1868);
return return_v;
}


int
f_10485_1792_1904(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 1792, 1904);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10485_1933_1956(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
this_param)
{
var return_v = this_param.ReceiverOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 1933, 1956);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10485_2146_2191(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 2146, 2191);
return return_v;
}


int
f_10485_2218_2384(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 2218, 2384);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
f_10485_2431_2489(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol?
aliasOpt,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTypeExpression( syntax, aliasOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 2431, 2489);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10485_2567_2590(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.TopLevelMethod ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 2567, 2590);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
f_10485_2794_2814(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.CurrentType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 2794, 2814);
return return_v;
}


int
f_10485_2781_2822(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 2781, 2822);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10485_2910_2930(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.CurrentType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 2910, 2930);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
f_10485_2867_2931(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol?
aliasOpt,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTypeExpression( syntax, aliasOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 2867, 2931);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_3064_3087(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
this_param)
{
var return_v = this_param.ReceiverOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 3064, 3087);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10485_3048_3088(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 3048, 3088);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
f_10485_3350_3369(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 3350, 3369);
return return_v;
}


int
f_10485_3319_3383(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiver,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
methods,Microsoft.CodeAnalysis.SyntaxNode
syntaxNode)
{
this_param.EmbedIfNeedTo( receiver, methods, syntaxNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 3319, 3383);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_3578_3593(Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 3578, 3593);
return return_v;
}


string
f_10485_3623_3640(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 3623, 3640);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
f_10485_3679_3708(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
this_param)
{
var return_v = this_param.TypeArgumentsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 3679, 3708);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_3765_3786(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
this_param)
{
var return_v = this_param.Receiver;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 3765, 3786);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10485_3749_3787(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 3749, 3787);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_4000_4015(Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 4000, 4015);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10485_3984_4016(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 3984, 4016);
return return_v;
}


System.Collections.Immutable.ImmutableArray<string>
f_10485_4121_4142(Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation
this_param)
{
var return_v = this_param.ArgumentNamesOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 4121, 4142);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
f_10485_4144_4168(Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation
this_param)
{
var return_v = this_param.ArgumentRefKindsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 4144, 4168);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
f_10485_4046_4186(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredReceiver,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
loweredArguments,System.Collections.Immutable.ImmutableArray<string>
argumentNames,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
refKinds,bool
resultDiscarded)
{
var return_v = this_param.MakeDynamicInvocation( loweredReceiver, loweredArguments, argumentNames, refKinds, resultDiscarded);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 4046, 4186);
return return_v;
}


int
f_10485_4233_4270(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 4233, 4270);
return 0;
}


System.Collections.Immutable.ImmutableArray<string>
f_10485_4478_4499(Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation
this_param)
{
var return_v = this_param.ArgumentNamesOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 4478, 4499);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
f_10485_4518_4542(Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation
this_param)
{
var return_v = this_param.ArgumentRefKindsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 4518, 4542);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
f_10485_4292_4615(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
this_param,string
name,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredReceiver,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
typeArgumentsWithAnnotations,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
loweredArguments,System.Collections.Immutable.ImmutableArray<string>
argumentNames,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
refKinds,bool
hasImplicitReceiver,bool
resultDiscarded)
{
var return_v = this_param.MakeDynamicMemberInvocation( name, loweredReceiver, typeArgumentsWithAnnotations, loweredArguments, argumentNames, refKinds, hasImplicitReceiver, resultDiscarded);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 4292, 4615);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,873,4642);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,873,4642);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void EmbedIfNeedTo(BoundExpression receiver, ImmutableArray<MethodSymbol> methods, SyntaxNode syntaxNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10485,4654,5515);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,4959,4988);

var 
module = f_10485_4972_4987(this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,5002,5504) || true) && (module != null &&(DynAbs.Tracing.TraceSender.Expression_True(10485, 5006, 5040)&&receiver != null )&&(DynAbs.Tracing.TraceSender.Expression_True(10485, 5006, 5064)&&f_10485_5044_5057(receiver)is { }))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,5002,5504);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,5098,5146);

var 
assembly = f_10485_5113_5145(f_10485_5113_5126(receiver))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,5166,5489) || true) && ((object)assembly != null &&(DynAbs.Tracing.TraceSender.Expression_True(10485, 5170, 5215)&&f_10485_5198_5215(assembly)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,5166,5489);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,5257,5470);
foreach(var m in f_10485_5275_5282_I(methods) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,5257,5470);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,5332,5447);

f_10485_5332_5446(f_10485_5332_5362(module), f_10485_5383_5419(f_10485_5383_5403(m)), syntaxNode, _diagnostics);
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,5257,5470);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10485,1,214);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10485,1,214);
}DynAbs.Tracing.TraceSender.TraceExitCondition(10485,5166,5489);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,5002,5504);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10485,4654,5515);

Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
f_10485_4972_4987(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.EmitModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 4972, 4987);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10485_5044_5057(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 5044, 5057);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10485_5113_5126(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 5113, 5126);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
f_10485_5113_5145(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.ContainingAssembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 5113, 5145);
return return_v;
}


bool
f_10485_5198_5215(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
this_param)
{
var return_v = this_param.IsLinked;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 5198, 5215);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
f_10485_5332_5362(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
this_param)
{
var return_v = this_param.EmbeddedTypesManagerOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 5332, 5362);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10485_5383_5403(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.OriginalDefinition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 5383, 5403);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
f_10485_5383_5419(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.GetCciAdapter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 5383, 5419);
return return_v;
}


Microsoft.Cci.IMethodReference
f_10485_5332_5446(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
methodSymbol,Microsoft.CodeAnalysis.SyntaxNode
syntaxNodeOpt,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics)
{
var return_v = this_param.EmbedMethodIfNeedTo( methodSymbol, syntaxNodeOpt, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 5332, 5446);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
f_10485_5275_5282_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 5275, 5282);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,4654,5515);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,4654,5515);
}
		}

private void EmbedIfNeedTo(BoundExpression receiver, ImmutableArray<PropertySymbol> properties, SyntaxNode syntaxNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10485,5527,6383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,5837,5866);

var 
module = f_10485_5850_5865(this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,5880,6372) || true) && (module != null &&(DynAbs.Tracing.TraceSender.Expression_True(10485, 5884, 5927)&&receiver is { Type: { } }))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,5880,6372);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,5961,6009);

var 
assembly = f_10485_5976_6008(f_10485_5976_5989(receiver))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,6029,6357) || true) && ((object)assembly != null &&(DynAbs.Tracing.TraceSender.Expression_True(10485, 6033, 6078)&&f_10485_6061_6078(assembly)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,6029,6357);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,6120,6338);
foreach(var p in f_10485_6138_6148_I(properties) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,6120,6338);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,6198,6315);

f_10485_6198_6314(f_10485_6198_6228(module), f_10485_6251_6287(f_10485_6251_6271(p)), syntaxNode, _diagnostics);
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,6120,6338);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10485,1,219);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10485,1,219);
}DynAbs.Tracing.TraceSender.TraceExitCondition(10485,6029,6357);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,5880,6372);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10485,5527,6383);

Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
f_10485_5850_5865(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.EmitModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 5850, 5865);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10485_5976_5989(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 5976, 5989);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
f_10485_5976_6008(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.ContainingAssembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 5976, 6008);
return return_v;
}


bool
f_10485_6061_6078(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
this_param)
{
var return_v = this_param.IsLinked;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 6061, 6078);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
f_10485_6198_6228(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
this_param)
{
var return_v = this_param.EmbeddedTypesManagerOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 6198, 6228);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
f_10485_6251_6271(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
this_param)
{
var return_v = this_param.OriginalDefinition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 6251, 6271);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
f_10485_6251_6287(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
this_param)
{
var return_v = this_param.GetCciAdapter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 6251, 6287);
return return_v;
}


int
f_10485_6198_6314(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbolAdapter
propertySymbol,Microsoft.CodeAnalysis.SyntaxNode
syntaxNodeOpt,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics)
{
this_param.EmbedPropertyIfNeedTo( propertySymbol, syntaxNodeOpt, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 6198, 6314);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
f_10485_6138_6148_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 6138, 6148);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,5527,6383);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,5527,6383);
}
		}

public override BoundNode VisitCall(BoundCall node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10485,6395,7605);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,6471,6498);

f_10485_6471_6497(node != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,6551,6622);

BoundExpression? 
rewrittenReceiver = f_10485_6588_6621(this, f_10485_6604_6620(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,6974,7025);

var 
rewrittenArguments = f_10485_6999_7024(this, f_10485_7009_7023(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,7041,7594);

return f_10485_7048_7593(this, syntax: node.Syntax, rewrittenReceiver: rewrittenReceiver, method: f_10485_7176_7187(node), rewrittenArguments: rewrittenArguments, argumentRefKindsOpt: f_10485_7284_7308(node), expanded: f_10485_7337_7350(node), invokedAsExtensionMethod: f_10485_7395_7424(node), argsToParamsOpt: f_10485_7460_7480(node), resultKind: f_10485_7511_7526(node), type: f_10485_7551_7560(node), nodeOpt: node);
DynAbs.Tracing.TraceSender.TraceExitMethod(10485,6395,7605);

int
f_10485_6471_6497(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 6471, 6497);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10485_6604_6620(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.ReceiverOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 6604, 6620);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10485_6588_6621(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 6588, 6621);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10485_7009_7023(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 7009, 7023);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10485_6999_7024(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
list)
{
var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundExpression>( list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 6999, 7024);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10485_7176_7187(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 7176, 7187);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
f_10485_7284_7308(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.ArgumentRefKindsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 7284, 7308);
return return_v;
}


bool
f_10485_7337_7350(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.Expanded;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 7337, 7350);
return return_v;
}


bool
f_10485_7395_7424(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.InvokedAsExtensionMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 7395, 7424);
return return_v;
}


System.Collections.Immutable.ImmutableArray<int>
f_10485_7460_7480(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.ArgsToParamsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 7460, 7480);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LookupResultKind
f_10485_7511_7526(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.ResultKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 7511, 7526);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10485_7551_7560(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 7551, 7560);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_7048_7593(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
rewrittenReceiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKindsOpt,bool
expanded,bool
invokedAsExtensionMethod,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundCall
nodeOpt)
{
var return_v = this_param.MakeCall( syntax: syntax, rewrittenReceiver: rewrittenReceiver, method: method, rewrittenArguments: rewrittenArguments, argumentRefKindsOpt: argumentRefKindsOpt, expanded: expanded, invokedAsExtensionMethod: invokedAsExtensionMethod, argsToParamsOpt: argsToParamsOpt, resultKind: resultKind, type: type, nodeOpt: nodeOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 7048, 7593);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,6395,7605);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,6395,7605);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeCall(
            SyntaxNode syntax,
            BoundExpression? rewrittenReceiver,
            MethodSymbol method,
            ImmutableArray<BoundExpression> rewrittenArguments,
            ImmutableArray<RefKind> argumentRefKindsOpt,
            bool expanded,
            bool invokedAsExtensionMethod,
            ImmutableArray<int> argsToParamsOpt,
            LookupResultKind resultKind,
            TypeSymbol type,
            BoundCall? nodeOpt = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10485,7617,8940);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,8416,8450);

ImmutableArray<LocalSymbol> 
temps
=default(ImmutableArray<LocalSymbol>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,8464,8761);

rewrittenArguments = f_10485_8485_8760(this, syntax, rewrittenArguments, method, expanded, argsToParamsOpt, ref argumentRefKindsOpt, out temps, invokedAsExtensionMethod);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,8777,8929);

return f_10485_8784_8928(this, nodeOpt, syntax, rewrittenReceiver, method, rewrittenArguments, argumentRefKindsOpt, invokedAsExtensionMethod, resultKind, type, temps);
DynAbs.Tracing.TraceSender.TraceExitMethod(10485,7617,8940);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10485_8485_8760(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
methodOrIndexer,bool
expanded,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKindsOpt,out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps,bool
invokedAsExtensionMethod)
{
var return_v = this_param.MakeArguments( syntax, rewrittenArguments, (Microsoft.CodeAnalysis.CSharp.Symbol)methodOrIndexer, expanded, argsToParamsOpt, ref argumentRefKindsOpt, out temps, invokedAsExtensionMethod);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 8485, 8760);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_8784_8928(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundCall?
node,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
rewrittenReceiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKinds,bool
invokedAsExtensionMethod,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps)
{
var return_v = this_param.MakeCall( node, syntax, rewrittenReceiver, method, rewrittenArguments, argumentRefKinds, invokedAsExtensionMethod, resultKind, type, temps);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 8784, 8928);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,7617,8940);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,7617,8940);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeCall(
            BoundCall? node,
            SyntaxNode syntax,
            BoundExpression? rewrittenReceiver,
            MethodSymbol method,
            ImmutableArray<BoundExpression> rewrittenArguments,
            ImmutableArray<RefKind> argumentRefKinds,
            bool invokedAsExtensionMethod,
            LookupResultKind resultKind,
            TypeSymbol type,
            ImmutableArray<LocalSymbol> temps = default(ImmutableArray<LocalSymbol>))
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10485,8952,12112);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,9478,9513);

BoundExpression 
rewrittenBoundCall
=default(BoundExpression);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,9529,11722) || true) && (f_10485_9533_9548(method)&&(DynAbs.Tracing.TraceSender.Expression_True(10485, 9533, 9605)&&f_10485_9569_9605(f_10485_9569_9590(method)))&&(DynAbs.Tracing.TraceSender.Expression_True(10485, 9533, 9646)&&                !_inExpressionLambda )&&(DynAbs.Tracing.TraceSender.Expression_True(10485, 9533, 9772)&&                (object)method == (object)f_10485_9693_9772(_compilation, SpecialMember.System_Object__ReferenceEquals)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,9529,11722);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,9806,9851);

f_10485_9806_9850(rewrittenArguments.Length == 2);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,10078,10408);

rewrittenBoundCall = f_10485_10099_10407(syntax, BinaryOperatorKind.ObjectEqual, null, null, resultKind, rewrittenArguments[0], rewrittenArguments[1], type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,9529,11722);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,9529,11722);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,10442,11722) || true) && (node == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,10442,11722);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,10492,11120);

rewrittenBoundCall = f_10485_10513_11119(syntax, rewrittenReceiver, method, rewrittenArguments, default(ImmutableArray<string>), argumentRefKinds, isDelegateCall: false, expanded: false, invokedAsExtensionMethod: invokedAsExtensionMethod, argsToParamsOpt: default(ImmutableArray<int>), defaultArguments: default(BitVector), resultKind: resultKind, type: type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,10442,11722);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,10442,11722);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,11186,11707);

rewrittenBoundCall = f_10485_11207_11706(node, rewrittenReceiver, method, rewrittenArguments, default(ImmutableArray<string>), argumentRefKinds, f_10485_11444_11463(node), false, f_10485_11514_11543(node), default(ImmutableArray<int>), default(BitVector), f_10485_11658_11673(node), f_10485_11696_11705(node));
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,10442,11722);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,9529,11722);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,11738,12059) || true) && (f_10485_11742_11765_M(!temps.IsDefaultOrEmpty))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,11738,12059);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,11799,12044);

return f_10485_11806_12043(syntax, locals: temps, sideEffects: ImmutableArray<BoundExpression>.Empty, value: rewrittenBoundCall, type: type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,11738,12059);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,12075,12101);

return rewrittenBoundCall;
DynAbs.Tracing.TraceSender.TraceExitMethod(10485,8952,12112);

bool
f_10485_9533_9548(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.IsStatic ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 9533, 9548);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10485_9569_9590(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 9569, 9590);
return return_v;
}


bool
f_10485_9569_9605(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = type.IsObjectType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 9569, 9605);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10485_9693_9772(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialMember
specialMember)
{
var return_v = this_param.GetSpecialTypeMember( specialMember);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 9693, 9772);
return return_v;
}


int
f_10485_9806_9850(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 9806, 9850);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
f_10485_10099_10407(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
methodOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.BoundExpression
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator( syntax, operatorKind, constantValueOpt, methodOpt, resultKind, left, right, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 10099, 10407);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10485_10513_11119(Microsoft.CodeAnalysis.SyntaxNode
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
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundCall( syntax, receiverOpt, method, arguments, argumentNamesOpt, argumentRefKindsOpt, isDelegateCall: isDelegateCall, expanded: expanded, invokedAsExtensionMethod: invokedAsExtensionMethod, argsToParamsOpt: argsToParamsOpt, defaultArguments: defaultArguments, resultKind: resultKind, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 10513, 11119);
return return_v;
}


bool
f_10485_11444_11463(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.IsDelegateCall;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 11444, 11463);
return return_v;
}


bool
f_10485_11514_11543(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.InvokedAsExtensionMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 11514, 11543);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LookupResultKind
f_10485_11658_11673(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.ResultKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 11658, 11673);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10485_11696_11705(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 11696, 11705);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10485_11207_11706(Microsoft.CodeAnalysis.CSharp.BoundCall
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
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
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Update( receiverOpt, method, arguments, argumentNamesOpt, argumentRefKindsOpt, isDelegateCall, expanded, invokedAsExtensionMethod, argsToParamsOpt, defaultArguments, resultKind, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 11207, 11706);
return return_v;
}


bool
f_10485_11742_11765_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 11742, 11765);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10485_11806_12043(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax, locals: locals, sideEffects: sideEffects, value: value, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 11806, 12043);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,8952,12112);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,8952,12112);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeCall(SyntaxNode syntax, BoundExpression? rewrittenReceiver, MethodSymbol method, ImmutableArray<BoundExpression> rewrittenArguments, TypeSymbol type)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10485,12124,12763);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,12326,12752);

return f_10485_12333_12751(this, node: null, syntax: syntax, rewrittenReceiver: rewrittenReceiver, method: method, rewrittenArguments: rewrittenArguments, argumentRefKinds: default(ImmutableArray<RefKind>), invokedAsExtensionMethod: false, resultKind: LookupResultKind.Viable, type: type);
DynAbs.Tracing.TraceSender.TraceExitMethod(10485,12124,12763);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_12333_12751(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundCall?
node,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
rewrittenReceiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKinds,bool
invokedAsExtensionMethod,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeCall( node: node, syntax: syntax, rewrittenReceiver: rewrittenReceiver, method: method, rewrittenArguments: rewrittenArguments, argumentRefKinds: argumentRefKinds, invokedAsExtensionMethod: invokedAsExtensionMethod, resultKind: resultKind, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 12333, 12751);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,12124,12763);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,12124,12763);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsSafeForReordering(BoundExpression expression, RefKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10485,12775,17370);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,13236,13261);

var 
current = expression
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,13275,17359) || true) && (true)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,13275,17359);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,13320,13426) || true) && (f_10485_13324_13345(current)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,13320,13426);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,13395,13407);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,13320,13426);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,13446,17344);

switch (f_10485_13454_13466(current))
                {

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,13446,17344);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,13542,13555);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,13446,17344);

case BoundKind.Parameter:
                    case BoundKind.Local:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,13446,17344);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,13837,13865);

return kind != RefKind.None;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,13446,17344);

case BoundKind.PassByCopy:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,13446,17344);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,13939,14011);

return f_10485_13946_14010(f_10485_13966_14003(((BoundPassByCopy)current)), kind);
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,13446,17344);

case BoundKind.Conversion:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,13446,17344);
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,14116,14164);

BoundConversion 
conv = (BoundConversion)current
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,14194,17262);

switch (f_10485_14202_14221(conv))
                            {

case ConversionKind.AnonymousFunction:
                                case ConversionKind.ImplicitConstant:
                                case ConversionKind.MethodGroup:
                                case ConversionKind.NullLiteral:
                                case ConversionKind.DefaultLiteral:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,14194,17262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,14635,14647);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,14194,17262);

case ConversionKind.Boxing:
                                case ConversionKind.ImplicitDynamic:
                                case ConversionKind.ExplicitDynamic:
                                case ConversionKind.ExplicitEnumeration:
                                case ConversionKind.ExplicitNullable:
                                case ConversionKind.ExplicitNumeric:
                                case ConversionKind.ExplicitReference:
                                case ConversionKind.Identity:
                                case ConversionKind.ImplicitEnumeration:
                                case ConversionKind.ImplicitNullable:
                                case ConversionKind.ImplicitNumeric:
                                case ConversionKind.ImplicitReference:
                                case ConversionKind.Unboxing:
                                case ConversionKind.ExplicitPointerToInteger:
                                case ConversionKind.ExplicitPointerToPointer:
                                case ConversionKind.ImplicitPointerToVoid:
                                case ConversionKind.ImplicitNullToPointer:
                                case ConversionKind.ExplicitIntegerToPointer:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,14194,17262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,15977,16000);

current = f_10485_15987_15999(conv);
DynAbs.Tracing.TraceSender.TraceBreak(10485,16038,16044);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,14194,17262);

case ConversionKind.ExplicitUserDefined:
                                case ConversionKind.ImplicitUserDefined:
                                // expression trees rewrite this later.
                                // it is a kind of user defined conversions on IntPtr and in some cases can fail
                                case ConversionKind.IntPtr:
                                case ConversionKind.ImplicitThrow:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,14194,17262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,16548,16561);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,14194,17262);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,14194,17262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,17010,17082);

f_10485_17010_17081(false, "Unexpected conversion kind" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_10485_17061_17080(conv)).ToString(),10485,17061,17080));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,17218,17231);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,14194,17262);
                            }
DynAbs.Tracing.TraceSender.TraceBreak(10485,17292,17298);

break;
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,13446,17344);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,13275,17359);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10485,13275,17359);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10485,13275,17359);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10485,12775,17370);

Microsoft.CodeAnalysis.ConstantValue?
f_10485_13324_13345(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 13324, 13345);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10485_13454_13466(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 13454, 13466);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_13966_14003(Microsoft.CodeAnalysis.CSharp.BoundPassByCopy
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 13966, 14003);
return return_v;
}


bool
f_10485_13946_14010(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression,Microsoft.CodeAnalysis.RefKind
kind)
{
var return_v = IsSafeForReordering( expression, kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 13946, 14010);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.ConversionKind
f_10485_14202_14221(Microsoft.CodeAnalysis.CSharp.BoundConversion
this_param)
{
var return_v = this_param.ConversionKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 14202, 14221);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_15987_15999(Microsoft.CodeAnalysis.CSharp.BoundConversion
this_param)
{
var return_v = this_param.Operand;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 15987, 15999);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.ConversionKind
f_10485_17061_17080(Microsoft.CodeAnalysis.CSharp.BoundConversion
this_param)
{
var return_v = this_param.ConversionKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 17061, 17080);
return return_v;
}


int
f_10485_17010_17081(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 17010, 17081);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,12775,17370);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,12775,17370);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private ImmutableArray<BoundExpression> MakeArguments(
            SyntaxNode syntax,
            ImmutableArray<BoundExpression> rewrittenArguments,
            Symbol methodOrIndexer,
            bool expanded,
            ImmutableArray<int> argsToParamsOpt,
            ref ImmutableArray<RefKind> argumentRefKindsOpt,
            out ImmutableArray<LocalSymbol> temps,
            bool invokedAsExtensionMethod = false,
            ThreeState enableCallerInfo = ThreeState.Unknown)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10485,17834,25064);
bool isComReceiver = default(bool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,18866,18953);

ArrayBuilder<LocalSymbol> 
temporariesBuilder = f_10485_18913_18952()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,18967,19066);

rewrittenArguments = f_10485_18988_19065(_factory, rewrittenArguments, temporariesBuilder);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,19080,19157);

ImmutableArray<ParameterSymbol> 
parameters = f_10485_19125_19156(methodOrIndexer)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,19173,19558) || true) && (f_10485_19177_19313(rewrittenArguments, methodOrIndexer, expanded, argsToParamsOpt, invokedAsExtensionMethod, false, out isComReceiver))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,19173,19558);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,19347,19395);

temps = f_10485_19355_19394(temporariesBuilder);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,19413,19497);

argumentRefKindsOpt = f_10485_19435_19496(argumentRefKindsOpt, parameters);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,19517,19543);

return rewrittenArguments;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,19173,19558);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,22384,22459);

BoundExpression[] 
actualArguments = new BoundExpression[parameters.Length]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,22560,22691);

ArrayBuilder<BoundAssignmentOperator> 
storesToTemps = f_10485_22614_22690(rewrittenArguments.Length)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,22705,22805);

ArrayBuilder<RefKind> 
refKinds = f_10485_22738_22804(parameters.Length, RefKind.None)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,23092,23484);

f_10485_23092_23483(this, expanded, argsToParamsOpt, parameters, argumentRefKindsOpt, rewrittenArguments, forceLambdaSpilling: false, actualArguments, refKinds, storesToTemps);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,23778,23850);

f_10485_23778_23849(actualArguments, storesToTemps, temporariesBuilder);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,23961,24204) || true) && (expanded)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,23961,24204);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,24007,24189);

actualArguments[f_10485_24023_24045(actualArguments)- 1] = f_10485_24053_24188(this, syntax, methodOrIndexer, argsToParamsOpt, rewrittenArguments, parameters, actualArguments[f_10485_24160_24182(actualArguments)- 1]);
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,23961,24204);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,24220,24372) || true) && (isComReceiver)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,24220,24372);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,24271,24357);

f_10485_24271_24356(this, parameters, actualArguments, refKinds, temporariesBuilder);
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,24220,24372);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,24388,24436);

temps = f_10485_24396_24435(temporariesBuilder);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,24450,24471);

f_10485_24450_24470(            storesToTemps);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,24835,24885);

argumentRefKindsOpt = f_10485_24857_24884(refKinds);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,24899,24915);

f_10485_24899_24914(            refKinds);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,24931,24996);

f_10485_24931_24995(f_10485_24944_24994(actualArguments, static arg => arg is not null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,25010,25053);

return f_10485_25017_25052(actualArguments);
DynAbs.Tracing.TraceSender.TraceExitMethod(10485,17834,25064);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10485_18913_18952()
{
var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 18913, 18952);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10485_18988_19065(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
builder)
{
var return_v = this_param.MakeTempsForDiscardArguments( arguments, builder);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 18988, 19065);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
f_10485_19125_19156(Microsoft.CodeAnalysis.CSharp.Symbol
member)
{
var return_v = member.GetParameters();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 19125, 19156);
return return_v;
}


bool
f_10485_19177_19313(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments,Microsoft.CodeAnalysis.CSharp.Symbol
methodOrIndexer,bool
expanded,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,bool
invokedAsExtensionMethod,bool
ignoreComReceiver,out bool
isComReceiver)
{
var return_v = CanSkipRewriting( rewrittenArguments, methodOrIndexer, expanded, argsToParamsOpt, invokedAsExtensionMethod, ignoreComReceiver, out isComReceiver);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 19177, 19313);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10485_19355_19394(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 19355, 19394);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
f_10485_19435_19496(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKindsOpt,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
parameters)
{
var return_v = GetEffectiveArgumentRefKinds( argumentRefKindsOpt, parameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 19435, 19496);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
f_10485_22614_22690(int
capacity)
{
var return_v = ArrayBuilder<BoundAssignmentOperator>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 22614, 22690);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
f_10485_22738_22804(int
capacity,Microsoft.CodeAnalysis.RefKind
fillWithValue)
{
var return_v = ArrayBuilder<RefKind>.GetInstance( capacity, fillWithValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 22738, 22804);
return return_v;
}


int
f_10485_23092_23483(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,bool
expanded,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
parameters,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKinds,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments,bool
forceLambdaSpilling,Microsoft.CodeAnalysis.CSharp.BoundExpression[]
arguments,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
refKinds,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
storesToTemps)
{
this_param.BuildStoresToTemps( expanded, argsToParamsOpt, parameters, argumentRefKinds, rewrittenArguments, forceLambdaSpilling: forceLambdaSpilling, arguments, refKinds, storesToTemps);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 23092, 23483);
return 0;
}


int
f_10485_23778_23849(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
arguments,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
storesToTemps,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temporariesBuilder)
{
OptimizeTemporaries( arguments, storesToTemps, temporariesBuilder);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 23778, 23849);
return 0;
}


int
f_10485_24023_24045(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 24023, 24045);
return return_v;
}


int
f_10485_24160_24182(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 24160, 24182);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_24053_24188(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbol
methodOrIndexer,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
parameters,Microsoft.CodeAnalysis.CSharp.BoundExpression
tempStoreArgument)
{
var return_v = this_param.BuildParamsArray( syntax, methodOrIndexer, argsToParamsOpt, rewrittenArguments, parameters, tempStoreArgument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 24053, 24188);
return return_v;
}


int
f_10485_24271_24356(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
parameters,Microsoft.CodeAnalysis.CSharp.BoundExpression[]
actualArguments,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
argsRefKindsBuilder,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temporariesBuilder)
{
this_param.RewriteArgumentsForComCall( parameters, actualArguments, argsRefKindsBuilder, temporariesBuilder);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 24271, 24356);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10485_24396_24435(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 24396, 24435);
return return_v;
}


int
f_10485_24450_24470(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 24450, 24470);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
f_10485_24857_24884(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
refKinds)
{
var return_v = GetRefKindsOrNull( refKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 24857, 24884);
return return_v;
}


int
f_10485_24899_24914(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 24899, 24914);
return 0;
}


bool
f_10485_24944_24994(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
source,System.Func<Microsoft.CodeAnalysis.CSharp.BoundExpression, bool>
predicate)
{
var return_v = source.All<Microsoft.CodeAnalysis.CSharp.BoundExpression>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 24944, 24994);
return return_v;
}


int
f_10485_24931_24995(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 24931, 24995);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10485_25017_25052(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
items)
{
var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.BoundExpression>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 25017, 25052);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,17834,25064);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,17834,25064);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static ImmutableArray<RefKind> GetEffectiveArgumentRefKinds(ImmutableArray<RefKind> argumentRefKindsOpt, ImmutableArray<ParameterSymbol> parameters)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10485,25678,27453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,25859,25905);

ArrayBuilder<RefKind>? 
refKindsBuilder = null
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,25928,25933);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,25919,27040) || true) && (i < parameters.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,25958,25961)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(10485,25919,27040))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,25919,27040);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,25995,26036);

var 
paramRefKind = f_10485_26014_26035(parameters[i])
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,26054,27025) || true) && (paramRefKind == RefKind.In)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,26054,27025);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,26126,26213);

var 
argRefKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10485, 26143, 26172)||((argumentRefKindsOpt.IsDefault &&DynAbs.Tracing.TraceSender.Conditional_F2(10485, 26175, 26187))||DynAbs.Tracing.TraceSender.Conditional_F3(10485, 26190, 26212)))?RefKind.None :argumentRefKindsOpt[i]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,26237,26890) || true) && (refKindsBuilder == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,26237,26890);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,26314,26867) || true) && (f_10485_26318_26348_M(!argumentRefKindsOpt.IsDefault))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,26314,26867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,26406,26449);

f_10485_26406_26448(f_10485_26419_26447_M(!argumentRefKindsOpt.IsEmpty));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,26479,26550);

refKindsBuilder = f_10485_26497_26549(parameters.Length);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,26580,26626);

f_10485_26580_26625(                            refKindsBuilder, argumentRefKindsOpt);
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,26314,26867);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,26314,26867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,26740,26840);

refKindsBuilder = f_10485_26758_26839(parameters.Length, fillWithValue: RefKind.None);
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,26314,26867);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,26237,26890);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,26914,27006);

refKindsBuilder[i] = (DynAbs.Tracing.TraceSender.Conditional_F1(10485, 26935, 26961)||((argRefKind == RefKind.None &&DynAbs.Tracing.TraceSender.Conditional_F2(10485, 26964, 26976))||DynAbs.Tracing.TraceSender.Conditional_F3(10485, 26979, 27005)))?paramRefKind :RefKindExtensions.StrictIn;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,26054,27025);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10485,1,1122);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10485,1,1122);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,27056,27191) || true) && (refKindsBuilder != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,27056,27191);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,27117,27176);

argumentRefKindsOpt = f_10485_27139_27175(refKindsBuilder);
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,27056,27191);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,27306,27401);

f_10485_27306_27400(argumentRefKindsOpt.IsDefault ||(DynAbs.Tracing.TraceSender.Expression_False(10485, 27319, 27399)||argumentRefKindsOpt.Length >= parameters.Length));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,27415,27442);

return argumentRefKindsOpt;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10485,25678,27453);

Microsoft.CodeAnalysis.RefKind
f_10485_26014_26035(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.RefKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 26014, 26035);
return return_v;
}


bool
f_10485_26318_26348_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 26318, 26348);
return return_v;
}


bool
f_10485_26419_26447_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 26419, 26447);
return return_v;
}


int
f_10485_26406_26448(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 26406, 26448);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
f_10485_26497_26549(int
capacity)
{
var return_v = ArrayBuilder<RefKind>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 26497, 26549);
return return_v;
}


int
f_10485_26580_26625(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
items)
{
this_param.AddRange( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 26580, 26625);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
f_10485_26758_26839(int
capacity,Microsoft.CodeAnalysis.RefKind
fillWithValue)
{
var return_v = ArrayBuilder<RefKind>.GetInstance( capacity, fillWithValue: fillWithValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 26758, 26839);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
f_10485_27139_27175(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 27139, 27175);
return return_v;
}


int
f_10485_27306_27400(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 27306, 27400);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,25678,27453);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,25678,27453);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static ImmutableArray<IArgumentOperation> MakeArgumentsInEvaluationOrder(
            CSharpOperationFactory operationFactory,
            CSharpCompilation compilation,
            SyntaxNode syntax,
            ImmutableArray<BoundExpression> arguments,
            Symbol methodOrIndexer,
            bool expanded,
            ImmutableArray<int> argsToParamsOpt,
            BitVector defaultArguments,
            bool invokedAsExtensionMethod)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10485,27465,30293);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,28306,29978) || true) && (f_10485_28310_28420(arguments, methodOrIndexer, expanded, argsToParamsOpt, invokedAsExtensionMethod, true, out _))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,28306,29978);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,28632,28709);

ImmutableArray<ParameterSymbol> 
parameters = f_10485_28677_28708(methodOrIndexer)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,28727,28842);

ArrayBuilder<IArgumentOperation> 
argumentsBuilder = f_10485_28779_28841(arguments.Length)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,28862,28872);

int 
i = 0
;
try {                for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,28890,29221) || true) && (i < parameters.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,28920,28923)
,++i,DynAbs.Tracing.TraceSender.TraceExitCondition(10485,28890,29221))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,28890,29221);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,28965,29056);

var 
argumentKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10485, 28984, 29003)||((defaultArguments[i] &&DynAbs.Tracing.TraceSender.Conditional_F2(10485, 29006, 29031))||DynAbs.Tracing.TraceSender.Conditional_F3(10485, 29034, 29055)))?ArgumentKind.DefaultValue :ArgumentKind.Explicit
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,29078,29202);

f_10485_29078_29201(                    argumentsBuilder, f_10485_29099_29200(operationFactory, argumentKind, f_10485_29154_29185(parameters[i]), arguments[i]));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10485,1,332);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10485,1,332);
}try {
                // TODO: In case of __arglist, we will have more arguments than parameters, 
                //       set the parameter to null for __arglist argument for now.
                //       https://github.com/dotnet/roslyn/issues/19673
                for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,29491,29794) || true) && (i < arguments.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,29520,29523)
,++i,DynAbs.Tracing.TraceSender.TraceExitCondition(10485,29491,29794))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,29491,29794);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,29565,29656);

var 
argumentKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10485, 29584, 29603)||((defaultArguments[i] &&DynAbs.Tracing.TraceSender.Conditional_F2(10485, 29606, 29631))||DynAbs.Tracing.TraceSender.Conditional_F3(10485, 29634, 29655)))?ArgumentKind.DefaultValue :ArgumentKind.Explicit
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,29678,29775);

f_10485_29678_29774(                    argumentsBuilder, f_10485_29699_29773(operationFactory, argumentKind, null, arguments[i]));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10485,1,304);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10485,1,304);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,29814,29898);

f_10485_29814_29897(f_10485_29827_29856(methodOrIndexer)^ parameters.Length == arguments.Length);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,29918,29963);

return f_10485_29925_29962(argumentsBuilder);
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,28306,29978);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,29994,30282);

return f_10485_30001_30281(operationFactory, syntax, methodOrIndexer, expanded, argsToParamsOpt, defaultArguments, arguments, compilation);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10485,27465,30293);

bool
f_10485_28310_28420(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments,Microsoft.CodeAnalysis.CSharp.Symbol
methodOrIndexer,bool
expanded,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,bool
invokedAsExtensionMethod,bool
ignoreComReceiver,out bool
isComReceiver)
{
var return_v = CanSkipRewriting( rewrittenArguments, methodOrIndexer, expanded, argsToParamsOpt, invokedAsExtensionMethod, ignoreComReceiver, out isComReceiver);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 28310, 28420);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
f_10485_28677_28708(Microsoft.CodeAnalysis.CSharp.Symbol
member)
{
var return_v = member.GetParameters();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 28677, 28708);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
f_10485_28779_28841(int
capacity)
{
var return_v = ArrayBuilder<IArgumentOperation>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 28779, 28841);
return return_v;
}


Microsoft.CodeAnalysis.IParameterSymbol?
f_10485_29154_29185(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
symbol)
{
var return_v = symbol.GetPublicSymbol();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 29154, 29185);
return return_v;
}


Microsoft.CodeAnalysis.Operations.IArgumentOperation
f_10485_29099_29200(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
this_param,Microsoft.CodeAnalysis.Operations.ArgumentKind
kind,Microsoft.CodeAnalysis.IParameterSymbol
parameter,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.CreateArgumentOperation( kind, parameter, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 29099, 29200);
return return_v;
}


int
f_10485_29078_29201(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
this_param,Microsoft.CodeAnalysis.Operations.IArgumentOperation
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 29078, 29201);
return 0;
}


Microsoft.CodeAnalysis.Operations.IArgumentOperation
f_10485_29699_29773(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
this_param,Microsoft.CodeAnalysis.Operations.ArgumentKind
kind,Microsoft.CodeAnalysis.IParameterSymbol?
parameter,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.CreateArgumentOperation( kind, parameter, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 29699, 29773);
return return_v;
}


int
f_10485_29678_29774(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
this_param,Microsoft.CodeAnalysis.Operations.IArgumentOperation
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 29678, 29774);
return 0;
}


bool
f_10485_29827_29856(Microsoft.CodeAnalysis.CSharp.Symbol
member)
{
var return_v = member.GetIsVararg();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 29827, 29856);
return return_v;
}


int
f_10485_29814_29897(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 29814, 29897);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
f_10485_29925_29962(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 29925, 29962);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
f_10485_30001_30281(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
operationFactory,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbol
methodOrIndexer,bool
expanded,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,Microsoft.CodeAnalysis.BitVector
defaultArguments,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = BuildArgumentsInEvaluationOrder( operationFactory, syntax, methodOrIndexer, expanded, argsToParamsOpt, defaultArguments, arguments, compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 30001, 30281);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,27465,30293);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,27465,30293);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool CanSkipRewriting(
            ImmutableArray<BoundExpression> rewrittenArguments,
            Symbol methodOrIndexer,
            bool expanded,
            ImmutableArray<int> argsToParamsOpt,
            bool invokedAsExtensionMethod,
            bool ignoreComReceiver,
            out bool isComReceiver)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10485,30371,31961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,30731,30753);

isComReceiver = false;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,31056,31351) || true) && (f_10485_31060_31089(methodOrIndexer))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,31056,31351);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,31123,31206);

f_10485_31123_31205(rewrittenArguments.Length == f_10485_31165_31200(methodOrIndexer)+ 1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,31224,31264);

f_10485_31224_31263(argsToParamsOpt.IsDefault);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,31282,31306);

f_10485_31282_31305(!expanded);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,31324,31336);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,31056,31351);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,31367,31751) || true) && (!ignoreComReceiver)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,31367,31751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,31423,31659);

var 
receiverNamedType = (DynAbs.Tracing.TraceSender.Conditional_F1(10485, 31447, 31471)||((invokedAsExtensionMethod &&DynAbs.Tracing.TraceSender.Conditional_F2(10485, 31515, 31584))||DynAbs.Tracing.TraceSender.Conditional_F3(10485, 31628, 31658)))?f_10485_31515_31565(f_10485_31515_31557(((MethodSymbol)methodOrIndexer))[0])as NamedTypeSymbol :f_10485_31628_31658(methodOrIndexer)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,31677,31736);

isComReceiver = receiverNamedType is { IsComImport: true };
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,31367,31751);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,31767,31950);

return rewrittenArguments.Length == f_10485_31803_31838(methodOrIndexer)&&(DynAbs.Tracing.TraceSender.Expression_True(10485, 31774, 31884)&&                argsToParamsOpt.IsDefault )&&(DynAbs.Tracing.TraceSender.Expression_True(10485, 31774, 31914)&&                !expanded )&&(DynAbs.Tracing.TraceSender.Expression_True(10485, 31774, 31949)&&                !isComReceiver);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10485,30371,31961);

bool
f_10485_31060_31089(Microsoft.CodeAnalysis.CSharp.Symbol
member)
{
var return_v = member.GetIsVararg();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 31060, 31089);
return return_v;
}


int
f_10485_31165_31200(Microsoft.CodeAnalysis.CSharp.Symbol
member)
{
var return_v = member.GetParameterCount();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 31165, 31200);
return return_v;
}


int
f_10485_31123_31205(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 31123, 31205);
return 0;
}


int
f_10485_31224_31263(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 31224, 31263);
return 0;
}


int
f_10485_31282_31305(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 31282, 31305);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
f_10485_31515_31557(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 31515, 31557);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10485_31515_31565(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 31515, 31565);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10485_31628_31658(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 31628, 31658);
return return_v;
}


int
f_10485_31803_31838(Microsoft.CodeAnalysis.CSharp.Symbol
member)
{
var return_v = member.GetParameterCount();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 31803, 31838);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,30371,31961);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,30371,31961);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static ImmutableArray<RefKind> GetRefKindsOrNull(ArrayBuilder<RefKind> refKinds)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10485,31973,32350);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,32086,32285);
foreach(var refKind in f_10485_32110_32118_I(refKinds) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,32086,32285);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,32152,32270) || true) && (refKind != RefKind.None)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,32152,32270);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,32221,32251);

return f_10485_32228_32250(refKinds);
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,32152,32270);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,32086,32285);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10485,1,200);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10485,1,200);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,32299,32339);

return default(ImmutableArray<RefKind>);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10485,31973,32350);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
f_10485_32228_32250(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
this_param)
{
var return_v = this_param.ToImmutable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 32228, 32250);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
f_10485_32110_32118_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 32110, 32118);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,31973,32350);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,31973,32350);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void BuildStoresToTemps(
            bool expanded,
            ImmutableArray<int> argsToParamsOpt,
            ImmutableArray<ParameterSymbol> parameters,
            ImmutableArray<RefKind> argumentRefKinds,
            ImmutableArray<BoundExpression> rewrittenArguments,
            bool forceLambdaSpilling,
            /* out */ BoundExpression[] arguments,
            /* out */ ArrayBuilder<RefKind> refKinds,
            /* out */ ArrayBuilder<BoundAssignmentOperator> storesToTemps)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10485,32438,36845);
int paramArrayArgumentCount = default(int);
Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator assignment = default(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,32972,33021);

f_10485_32972_33020(f_10485_32985_32999(refKinds)== f_10485_33003_33019(arguments));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,33035,33074);

f_10485_33035_33073(f_10485_33048_33067(storesToTemps)== 0);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,33099,33104);

            for (int 
a = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,33090,36641) || true) && (a < rewrittenArguments.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,33137,33140)
,++a,DynAbs.Tracing.TraceSender.TraceExitCondition(10485,33090,36641))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,33090,36641);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,33174,33223);

BoundExpression 
argument = rewrittenArguments[a]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,33241,33303);

int 
p = (DynAbs.Tracing.TraceSender.Conditional_F1(10485, 33249, 33277)||(((f_10485_33250_33276_M(!argsToParamsOpt.IsDefault)) &&DynAbs.Tracing.TraceSender.Conditional_F2(10485, 33280, 33298))||DynAbs.Tracing.TraceSender.Conditional_F3(10485, 33301, 33302)))?argsToParamsOpt[a] :a
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,33321,33371);

RefKind 
argRefKind = argumentRefKinds.RefKinds(a)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,33389,33434);

RefKind 
paramRefKind = f_10485_33412_33433(parameters[p])
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,33454,33489);

f_10485_33454_33488(arguments[p] == null);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,34794,35074) || true) && (f_10485_34798_34925(p, a, expanded, f_10485_34838_34854(arguments), rewrittenArguments, argsToParamsOpt, out paramArrayArgumentCount)&&(DynAbs.Tracing.TraceSender.Expression_True(10485, 34798, 35006)&&a + paramArrayArgumentCount == rewrittenArguments.Length))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,34794,35074);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,35048,35055);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,34794,35074);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,35094,35701) || true) && ((!forceLambdaSpilling ||(DynAbs.Tracing.TraceSender.Expression_False(10485, 35099, 35152)||!f_10485_35124_35152(argument))) &&(DynAbs.Tracing.TraceSender.Expression_True(10485, 35098, 35219)&&f_10485_35178_35219(argument, argRefKind)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,35094,35701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,35261,35285);

arguments[p] = argument;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,35094,35701);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,35094,35701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,35367,35588);

var 
temp = f_10485_35378_35587(_factory, argument, out assignment, refKind: (DynAbs.Tracing.TraceSender.Conditional_F1(10485, 35534, 35560)||((paramRefKind == RefKind.In &&DynAbs.Tracing.TraceSender.Conditional_F2(10485, 35563, 35573))||DynAbs.Tracing.TraceSender.Conditional_F3(10485, 35576, 35586)))?RefKind.In :argRefKind)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,35610,35640);

f_10485_35610_35639(                    storesToTemps, assignment);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,35662,35682);

arguments[p] = temp;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,35094,35701);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,36317,36581) || true) && (paramRefKind == RefKind.In)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,36317,36581);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,36389,36458);

f_10485_36389_36457(argRefKind == RefKind.None ||(DynAbs.Tracing.TraceSender.Expression_False(10485, 36402, 36456)||argRefKind == RefKind.In));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,36480,36562);

argRefKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10485, 36493, 36519)||((argRefKind == RefKind.None &&DynAbs.Tracing.TraceSender.Conditional_F2(10485, 36522, 36532))||DynAbs.Tracing.TraceSender.Conditional_F3(10485, 36535, 36561)))?RefKind.In :RefKindExtensions.StrictIn;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,36317,36581);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,36601,36626);

refKinds[p] = argRefKind;
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10485,1,3552);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10485,1,3552);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,36657,36664);

return;

bool isLambdaConversion(BoundExpression expr)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10485,36743,36833);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,36746,36833);
return expr is BoundConversion conv &&(DynAbs.Tracing.TraceSender.Expression_True(10485, 36746, 36833)&&f_10485_36778_36797(conv)== ConversionKind.AnonymousFunction);DynAbs.Tracing.TraceSender.TraceExitMethod(10485,36743,36833);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,36743,36833);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,36743,36833);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
DynAbs.Tracing.TraceSender.TraceExitMethod(10485,32438,36845);

int
f_10485_32985_32999(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 32985, 32999);
return return_v;
}


int
f_10485_33003_33019(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 33003, 33019);
return return_v;
}


int
f_10485_32972_33020(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 32972, 33020);
return 0;
}


int
f_10485_33048_33067(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 33048, 33067);
return return_v;
}


int
f_10485_33035_33073(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 33035, 33073);
return 0;
}


bool
f_10485_33250_33276_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 33250, 33276);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_10485_33412_33433(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.RefKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 33412, 33433);
return return_v;
}


int
f_10485_33454_33488(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 33454, 33488);
return 0;
}


int
f_10485_34838_34854(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 34838, 34854);
return return_v;
}


bool
f_10485_34798_34925(int
parameterIndex,int
argumentIndex,bool
expanded,int
parameterCount,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,out int
numberOfParamArrayArguments)
{
var return_v = IsBeginningOfParamArray( parameterIndex, argumentIndex, expanded, parameterCount, arguments, argsToParamsOpt, out numberOfParamArrayArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 34798, 34925);
return return_v;
}


bool
f_10485_35124_35152(Microsoft.CodeAnalysis.CSharp.BoundExpression
expr)
{
var return_v = isLambdaConversion( expr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 35124, 35152);
return return_v;
}


bool
f_10485_35178_35219(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression,Microsoft.CodeAnalysis.RefKind
kind)
{
var return_v = IsSafeForReordering( expression, kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 35178, 35219);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10485_35378_35587(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store,Microsoft.CodeAnalysis.RefKind
refKind)
{
var return_v = this_param.StoreToTemp( argument, out store, refKind: refKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 35378, 35587);
return return_v;
}


int
f_10485_35610_35639(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 35610, 35639);
return 0;
}


int
f_10485_36389_36457(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 36389, 36457);
return 0;
}


Microsoft.CodeAnalysis.CSharp.ConversionKind
f_10485_36778_36797(Microsoft.CodeAnalysis.CSharp.BoundConversion
this_param)
{
var return_v = this_param.ConversionKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 36778, 36797);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,32438,36845);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,32438,36845);
}
		}

private static ImmutableArray<IArgumentOperation> BuildArgumentsInEvaluationOrder(
            CSharpOperationFactory operationFactory,
            SyntaxNode syntax,
            Symbol methodOrIndexer,
            bool expanded,
            ImmutableArray<int> argsToParamsOpt,
            BitVector defaultArguments,
            ImmutableArray<BoundExpression> arguments,
            CSharpCompilation compilation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10485,36940,40433);
int paramArrayArgumentCount = default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,37389,37466);

ImmutableArray<ParameterSymbol> 
parameters = f_10485_37434_37465(methodOrIndexer)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,37482,37610);

ArrayBuilder<IArgumentOperation> 
argumentsInEvaluationBuilder = f_10485_37546_37609(parameters.Length)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,37626,37656);

bool 
visitedLastParam = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,37751,37756);

            // First, fill in all the explicitly provided arguments.
            for (int 
a = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,37742,39505) || true) && (a < arguments.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,37780,37783)
,++a,DynAbs.Tracing.TraceSender.TraceExitCondition(10485,37742,39505))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,37742,39505);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,37817,37857);

BoundExpression 
argument = arguments[a]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,37877,37939);

int 
p = (DynAbs.Tracing.TraceSender.Conditional_F1(10485, 37885, 37913)||(((f_10485_37886_37912_M(!argsToParamsOpt.IsDefault)) &&DynAbs.Tracing.TraceSender.Conditional_F2(10485, 37916, 37934))||DynAbs.Tracing.TraceSender.Conditional_F3(10485, 37937, 37938)))?argsToParamsOpt[a] :a
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,37957,37987);

var 
parameter = parameters[p]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,38007,38135) || true) && (!visitedLastParam)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,38007,38135);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,38070,38116);

visitedLastParam = p == parameters.Length - 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,38007,38135);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,38155,38247);

ArgumentKind 
kind = (DynAbs.Tracing.TraceSender.Conditional_F1(10485, 38175, 38194)||((defaultArguments[a] &&DynAbs.Tracing.TraceSender.Conditional_F2(10485, 38197, 38222))||DynAbs.Tracing.TraceSender.Conditional_F3(10485, 38225, 38246)))?ArgumentKind.DefaultValue :ArgumentKind.Explicit
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,38267,39350) || true) && (f_10485_38271_38390(p, a, expanded, parameters.Length, arguments, argsToParamsOpt, out paramArrayArgumentCount))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,38267,39350);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,38432,38498);

int 
firstNonParamArrayArgumentIndex = a + paramArrayArgumentCount
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,38520,38586);

f_10485_38520_38585(firstNonParamArrayArgumentIndex <= arguments.Length);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,38610,38641);

kind = ArgumentKind.ParamArray;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,38663,38773);

ArrayBuilder<BoundExpression> 
paramArray = f_10485_38706_38772(paramArrayArgumentCount)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,38806,38811);

                    for (int 
i = a
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,38797,38955) || true) && (i < firstNonParamArrayArgumentIndex)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,38850,38853)
,++i,DynAbs.Tracing.TraceSender.TraceExitCondition(10485,38797,38955))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,38797,38955);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,38903,38932);

f_10485_38903_38931(                        paramArray, arguments[i]);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10485,1,159);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10485,1,159);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,39140,39180);

a = firstNonParamArrayArgumentIndex - 1;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,39204,39331);

argument = f_10485_39215_39330(syntax, f_10485_39248_39262(parameter), f_10485_39264_39295(paramArray), compilation, localRewriter: null);
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,38267,39350);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,39370,39490);

f_10485_39370_39489(
                argumentsInEvaluationBuilder, f_10485_39403_39488(operationFactory, kind, f_10485_39450_39477(parameter), argument));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10485,1,1764);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10485,1,1764);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,39598,39658);

var 
lastParam = (DynAbs.Tracing.TraceSender.Conditional_F1(10485, 39614, 39633)||((f_10485_39614_39633_M(!parameters.IsEmpty)&&DynAbs.Tracing.TraceSender.Conditional_F2(10485, 39636, 39650))||DynAbs.Tracing.TraceSender.Conditional_F3(10485, 39653, 39657)))?parameters[^1] :null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,39672,40257) || true) && (expanded &&(DynAbs.Tracing.TraceSender.Expression_True(10485, 39676, 39707)&&lastParam is object )&&(DynAbs.Tracing.TraceSender.Expression_True(10485, 39676, 39728)&&!visitedLastParam))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,39672,40257);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,39762,39795);

f_10485_39762_39794(f_10485_39775_39793(lastParam));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,39891,40040);

BoundExpression 
argument = f_10485_39918_40039(syntax, f_10485_39951_39965(lastParam), ImmutableArray<BoundExpression>.Empty, compilation, localRewriter: null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,40058,40102);

ArgumentKind 
kind = ArgumentKind.ParamArray
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,40122,40242);

f_10485_40122_40241(
                argumentsInEvaluationBuilder, f_10485_40155_40240(operationFactory, kind, f_10485_40202_40229(lastParam), argument));
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,39672,40257);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,40273,40351);

f_10485_40273_40350(f_10485_40286_40349(argumentsInEvaluationBuilder, static arg => arg is not null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,40365,40422);

return f_10485_40372_40421(argumentsInEvaluationBuilder);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10485,36940,40433);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
f_10485_37434_37465(Microsoft.CodeAnalysis.CSharp.Symbol
member)
{
var return_v = member.GetParameters();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 37434, 37465);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
f_10485_37546_37609(int
capacity)
{
var return_v = ArrayBuilder<IArgumentOperation>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 37546, 37609);
return return_v;
}


bool
f_10485_37886_37912_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 37886, 37912);
return return_v;
}


bool
f_10485_38271_38390(int
parameterIndex,int
argumentIndex,bool
expanded,int
parameterCount,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,out int
numberOfParamArrayArguments)
{
var return_v = IsBeginningOfParamArray( parameterIndex, argumentIndex, expanded, parameterCount, arguments, argsToParamsOpt, out numberOfParamArrayArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 38271, 38390);
return return_v;
}


int
f_10485_38520_38585(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 38520, 38585);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10485_38706_38772(int
capacity)
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 38706, 38772);
return return_v;
}


int
f_10485_38903_38931(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 38903, 38931);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10485_39248_39262(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 39248, 39262);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10485_39264_39295(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 39264, 39295);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_39215_39330(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
paramArrayType,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arrayArgs,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.LocalRewriter?
localRewriter)
{
var return_v = CreateParamArrayArgument( syntax, paramArrayType, arrayArgs, compilation, localRewriter: localRewriter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 39215, 39330);
return return_v;
}


Microsoft.CodeAnalysis.IParameterSymbol?
f_10485_39450_39477(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
symbol)
{
var return_v = symbol.GetPublicSymbol();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 39450, 39477);
return return_v;
}


Microsoft.CodeAnalysis.Operations.IArgumentOperation
f_10485_39403_39488(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
this_param,Microsoft.CodeAnalysis.Operations.ArgumentKind
kind,Microsoft.CodeAnalysis.IParameterSymbol
parameter,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.CreateArgumentOperation( kind, parameter, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 39403, 39488);
return return_v;
}


int
f_10485_39370_39489(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
this_param,Microsoft.CodeAnalysis.Operations.IArgumentOperation
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 39370, 39489);
return 0;
}


bool
f_10485_39614_39633_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 39614, 39633);
return return_v;
}


bool
f_10485_39775_39793(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.IsParams;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 39775, 39793);
return return_v;
}


int
f_10485_39762_39794(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 39762, 39794);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10485_39951_39965(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 39951, 39965);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_39918_40039(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
paramArrayType,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arrayArgs,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.LocalRewriter?
localRewriter)
{
var return_v = CreateParamArrayArgument( syntax, paramArrayType, arrayArgs, compilation, localRewriter: localRewriter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 39918, 40039);
return return_v;
}


Microsoft.CodeAnalysis.IParameterSymbol?
f_10485_40202_40229(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
symbol)
{
var return_v = symbol.GetPublicSymbol();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 40202, 40229);
return return_v;
}


Microsoft.CodeAnalysis.Operations.IArgumentOperation
f_10485_40155_40240(Microsoft.CodeAnalysis.Operations.CSharpOperationFactory
this_param,Microsoft.CodeAnalysis.Operations.ArgumentKind
kind,Microsoft.CodeAnalysis.IParameterSymbol
parameter,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.CreateArgumentOperation( kind, parameter, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 40155, 40240);
return return_v;
}


int
f_10485_40122_40241(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
this_param,Microsoft.CodeAnalysis.Operations.IArgumentOperation
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 40122, 40241);
return 0;
}


bool
f_10485_40286_40349(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
builder,System.Func<Microsoft.CodeAnalysis.Operations.IArgumentOperation, bool>
predicate)
{
var return_v = builder.All<Microsoft.CodeAnalysis.Operations.IArgumentOperation>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 40286, 40349);
return return_v;
}


int
f_10485_40273_40350(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 40273, 40350);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
f_10485_40372_40421(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Operations.IArgumentOperation>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 40372, 40421);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,36940,40433);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,36940,40433);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsBeginningOfParamArray(
            int parameterIndex,
            int argumentIndex,
            bool expanded,
            int parameterCount,
            ImmutableArray<BoundExpression> arguments,
            ImmutableArray<int> argsToParamsOpt,
            out int numberOfParamArrayArguments)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10485,40742,41835);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,41093,41125);

numberOfParamArrayArguments = 0;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,41141,41795) || true) && (expanded &&(DynAbs.Tracing.TraceSender.Expression_True(10485, 41145, 41193)&&parameterIndex == parameterCount - 1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,41141,41795);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,41227,41269);

int 
remainingArgument = argumentIndex + 1
;
try {                for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,41287,41668) || true) && (remainingArgument < arguments.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,41332,41351)
,++remainingArgument,DynAbs.Tracing.TraceSender.TraceExitCondition(10485,41287,41668))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,41287,41668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,41393,41504);

int 
remainingParameter = (DynAbs.Tracing.TraceSender.Conditional_F1(10485, 41418, 41446)||(((f_10485_41419_41445_M(!argsToParamsOpt.IsDefault)) &&DynAbs.Tracing.TraceSender.Conditional_F2(10485, 41449, 41483))||DynAbs.Tracing.TraceSender.Conditional_F3(10485, 41486, 41503)))?argsToParamsOpt[remainingArgument] :remainingArgument
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,41526,41649) || true) && (remainingParameter != parameterCount - 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,41526,41649);
DynAbs.Tracing.TraceSender.TraceBreak(10485,41620,41626);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,41526,41649);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10485,1,382);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10485,1,382);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,41686,41750);

numberOfParamArrayArguments = remainingArgument - argumentIndex;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,41768,41780);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,41141,41795);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,41811,41824);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10485,40742,41835);

bool
f_10485_41419_41445_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 41419, 41445);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,40742,41835);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,40742,41835);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression BuildParamsArray(
            SyntaxNode syntax,
            Symbol methodOrIndexer,
            ImmutableArray<int> argsToParamsOpt,
            ImmutableArray<BoundExpression> rewrittenArguments,
            ImmutableArray<ParameterSymbol> parameters,
            BoundExpression tempStoreArgument)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10485,41847,45414);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,42202,42289);

ArrayBuilder<BoundExpression> 
paramArray = f_10485_42245_42288()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,42303,42343);

int 
paramsParam = parameters.Length - 1
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,42359,43132) || true) && (tempStoreArgument != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,42359,43132);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,42422,42456);

f_10485_42422_42455(                paramArray, tempStoreArgument);
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,42359,43132);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,42359,43132);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,42742,42747);
                for (int 
a = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,42733,43117) || true) && (a < rewrittenArguments.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,42780,42783)
,++a,DynAbs.Tracing.TraceSender.TraceExitCondition(10485,42733,43117))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,42733,43117);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,42825,42874);

BoundExpression 
argument = rewrittenArguments[a]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,42896,42958);

int 
p = (DynAbs.Tracing.TraceSender.Conditional_F1(10485, 42904, 42932)||(((f_10485_42905_42931_M(!argsToParamsOpt.IsDefault)) &&DynAbs.Tracing.TraceSender.Conditional_F2(10485, 42935, 42953))||DynAbs.Tracing.TraceSender.Conditional_F3(10485, 42956, 42957)))?argsToParamsOpt[a] :a
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,42980,43098) || true) && (p == paramsParam)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,42980,43098);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,43050,43075);

f_10485_43050_43074(                        paramArray, argument);
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,42980,43098);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10485,1,385);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10485,1,385);
}DynAbs.Tracing.TraceSender.TraceExitCondition(10485,42359,43132);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,43148,43198);

var 
paramArrayType = f_10485_43169_43197(parameters[paramsParam])
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,43212,43260);

var 
arrayArgs = f_10485_43228_43259(paramArray)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,43813,45300) || true) && (arrayArgs.Length == 0
&&(DynAbs.Tracing.TraceSender.Expression_True(10485, 43817, 43879)&&!_inExpressionLambda
)&&(DynAbs.Tracing.TraceSender.Expression_True(10485, 43817, 43937)&&paramArrayType is ArrayTypeSymbol ats // could be false if there's a semantic error, e.g. the params parameter type isn't an array
)&&(DynAbs.Tracing.TraceSender.Expression_True(10485, 43817, 44096)&&!f_10485_44052_44096(f_10485_44052_44067(ats))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,43813,45300);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,44130,44246);

MethodSymbol? 
arrayEmpty = f_10485_44157_44229(_compilation, WellKnownMember.System_Array__Empty)as MethodSymbol
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,44264,45285) || true) && (arrayEmpty != null)
) // will be null if Array.Empty<T> doesn't exist in reference assemblies

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,44264,45285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,44467,44541);

arrayEmpty = f_10485_44480_44540(arrayEmpty, f_10485_44501_44539(f_10485_44523_44538(ats)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,44563,45266);

return f_10485_44570_45265(syntax, null, arrayEmpty, ImmutableArray<BoundExpression>.Empty, default(ImmutableArray<string>), default(ImmutableArray<RefKind>), isDelegateCall: false, expanded: false, invokedAsExtensionMethod: false, argsToParamsOpt: default(ImmutableArray<int>), defaultArguments: default(BitVector), resultKind: LookupResultKind.Viable, type: f_10485_45243_45264(arrayEmpty));
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,44264,45285);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,43813,45300);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,45316,45403);

return f_10485_45323_45402(syntax, paramArrayType, arrayArgs, _compilation, this);
DynAbs.Tracing.TraceSender.TraceExitMethod(10485,41847,45414);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10485_42245_42288()
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 42245, 42288);
return return_v;
}


int
f_10485_42422_42455(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 42422, 42455);
return 0;
}


bool
f_10485_42905_42931_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 42905, 42931);
return return_v;
}


int
f_10485_43050_43074(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 43050, 43074);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10485_43169_43197(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 43169, 43197);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10485_43228_43259(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 43228, 43259);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10485_44052_44067(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
this_param)
{
var return_v = this_param.ElementType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 44052, 44067);
return return_v;
}


bool
f_10485_44052_44096(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsPointerOrFunctionPointer();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 44052, 44096);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_10485_44157_44229(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownMember
member)
{
var return_v = this_param.GetWellKnownTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 44157, 44229);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10485_44523_44538(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
this_param)
{
var return_v = this_param.ElementType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 44523, 44538);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
f_10485_44501_44539(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 44501, 44539);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10485_44480_44540(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
typeArguments)
{
var return_v = this_param.Construct( typeArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 44480, 44540);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10485_45243_45264(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ReturnType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 45243, 45264);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10485_44570_45265(Microsoft.CodeAnalysis.SyntaxNode
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
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundCall( syntax, receiverOpt, method, arguments, argumentNamesOpt, argumentRefKindsOpt, isDelegateCall: isDelegateCall, expanded: expanded, invokedAsExtensionMethod: invokedAsExtensionMethod, argsToParamsOpt: argsToParamsOpt, defaultArguments: defaultArguments, resultKind: resultKind, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 44570, 45265);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_45323_45402(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
paramArrayType,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arrayArgs,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.LocalRewriter
localRewriter)
{
var return_v = CreateParamArrayArgument( syntax, paramArrayType, arrayArgs, compilation, localRewriter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 45323, 45402);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,41847,45414);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,41847,45414);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static BoundExpression CreateParamArrayArgument(SyntaxNode syntax,
            TypeSymbol paramArrayType,
            ImmutableArray<BoundExpression> arrayArgs,
            CSharpCompilation compilation,
            LocalRewriter? localRewriter)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10485,45426,46224);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,45710,45786);

TypeSymbol 
int32Type = f_10485_45733_45785(compilation, SpecialType.System_Int32)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,45800,45914);

BoundExpression 
arraySize = f_10485_45828_45913(syntax, f_10485_45848_45886(arrayArgs.Length), int32Type, localRewriter)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,45930,46213);

return new BoundArrayCreation(
                syntax,
f_10485_46003_46035(arraySize),
                new BoundArrayInitialization(syntax, arrayArgs) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true,10485,46054,46133) },
                paramArrayType)
            { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true,10485,45937,46212) };
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10485,45426,46224);

Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10485_45733_45785(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 45733, 45785);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10485_45848_45886(int
value)
{
var return_v = ConstantValue.Create( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 45848, 45886);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_45828_45913(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.LocalRewriter?
localRewriter)
{
var return_v = MakeLiteral( syntax, constantValue, type, localRewriter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 45828, 45913);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10485_46003_46035(Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 46003, 46035);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,45426,46224);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,45426,46224);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static BoundExpression MakeLiteral(SyntaxNode syntax, ConstantValue constantValue, TypeSymbol type, LocalRewriter? localRewriter)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10485,46368,46849);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,46530,46838) || true) && (localRewriter != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,46530,46838);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,46589,46651);

return f_10485_46596_46650(localRewriter, syntax, constantValue, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,46530,46838);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,46530,46838);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,46717,46823);

return new BoundLiteral(syntax, constantValue, type, f_10485_46770_46789(constantValue)) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true,10485,46724,46822) };
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,46530,46838);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10485,46368,46849);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_46596_46650(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.ConstantValue
constantValue,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeLiteral( syntax, constantValue, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 46596, 46650);
return return_v;
}


bool
f_10485_46770_46789(Microsoft.CodeAnalysis.ConstantValue
this_param)
{
var return_v = this_param.IsBad;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 46770, 46789);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,46368,46849);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,46368,46849);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static void OptimizeTemporaries(
            BoundExpression[] arguments,
            ArrayBuilder<BoundAssignmentOperator> storesToTemps,
            ArrayBuilder<LocalSymbol> temporariesBuilder)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10485,46861,47783);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,47093,47125);

f_10485_47093_47124(arguments != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,47139,47175);

f_10485_47139_47174(storesToTemps != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,47189,47230);

f_10485_47189_47229(temporariesBuilder != null);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,47246,47772) || true) && (f_10485_47250_47269(storesToTemps)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,47246,47772);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,47307,47380);

int 
tempsNeeded = f_10485_47325_47379(arguments, storesToTemps)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,47398,47757) || true) && (tempsNeeded > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,47398,47757);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,47459,47738);
foreach(BoundAssignmentOperator s in f_10485_47497_47510_I(storesToTemps) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,47459,47738);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,47560,47715) || true) && (s != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,47560,47715);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,47631,47688);

f_10485_47631_47687(                            temporariesBuilder, f_10485_47654_47686(((BoundLocal)f_10485_47667_47673(s))));
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,47560,47715);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,47459,47738);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10485,1,280);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10485,1,280);
}DynAbs.Tracing.TraceSender.TraceExitCondition(10485,47398,47757);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,47246,47772);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10485,46861,47783);

int
f_10485_47093_47124(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 47093, 47124);
return 0;
}


int
f_10485_47139_47174(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 47139, 47174);
return 0;
}


int
f_10485_47189_47229(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 47189, 47229);
return 0;
}


int
f_10485_47250_47269(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 47250, 47269);
return return_v;
}


int
f_10485_47325_47379(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
arguments,Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
tempStores)
{
var return_v = MergeArgumentsAndSideEffects( arguments, tempStores);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 47325, 47379);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_47667_47673(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 47667, 47673);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10485_47654_47686(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 47654, 47686);
return return_v;
}


int
f_10485_47631_47687(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 47631, 47687);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
f_10485_47497_47510_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 47497, 47510);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,46861,47783);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,46861,47783);
}
		}

private static int MergeArgumentsAndSideEffects(
            BoundExpression[] arguments,
            ArrayBuilder<BoundAssignmentOperator> tempStores)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10485,48083,52521);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,48261,48293);

f_10485_48261_48292(arguments != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,48307,48340);

f_10485_48307_48339(tempStores != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,48356,48398);

int 
tempsRemainedInUse = f_10485_48381_48397(tempStores)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,49185,49213);

int 
firstUnclaimedStore = 0
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,49238,49243);

            for (int 
a = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,49229,52363) || true) && (a < f_10485_49249_49265(arguments))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,49267,49270)
,++a,DynAbs.Tracing.TraceSender.TraceExitCondition(10485,49229,52363))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,49229,52363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,49304,49332);

var 
argument = arguments[a]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,49868,52348) || true) && (f_10485_49872_49886_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(argument, 10485, 49872, 49886)?.Kind)== BoundKind.Local)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,49868,52348);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,49947,49975);

var 
correspondingStore = -1
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,50006,50029);
                    for (int 
i = firstUnclaimedStore
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,49997,50307) || true) && (i < f_10485_50035_50051(tempStores))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,50053,50056)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(10485,49997,50307))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,49997,50307);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,50106,50284) || true) && (f_10485_50110_50128(f_10485_50110_50123(tempStores, i))== argument)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,50106,50284);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,50198,50221);

correspondingStore = i;
DynAbs.Tracing.TraceSender.TraceBreak(10485,50251,50257);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,50106,50284);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10485,1,311);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10485,1,311);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,50368,52329) || true) && (correspondingStore != -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,50368,52329);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,50446,50495);

var 
value = f_10485_50458_50494(f_10485_50458_50488(tempStores, correspondingStore))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,50521,50553);

f_10485_50521_50552(f_10485_50534_50544(value)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,50778,50817);

tempStores[correspondingStore] = null!;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,50843,50864);

tempsRemainedInUse--;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,51002,52233) || true) && (correspondingStore == firstUnclaimedStore)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,51002,52233);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,51105,51126);

arguments[a] = value;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,51002,52233);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,51002,52233);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,51240,51320);

var 
sideeffects = new BoundExpression[correspondingStore - firstUnclaimedStore]
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,51359,51364);
                            for (int 
s = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,51350,51543) || true) && (s < f_10485_51370_51388(sideeffects))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,51390,51393)
,s++,DynAbs.Tracing.TraceSender.TraceExitCondition(10485,51350,51543))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,51350,51543);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,51459,51512);

sideeffects[s] = f_10485_51476_51511(tempStores, firstUnclaimedStore + s);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10485,1,194);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10485,1,194);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,51575,52206);

arguments[a] = f_10485_51590_52205(value.Syntax, ImmutableArray<LocalSymbol>.Empty, f_10485_52072_52103(                                        sideeffects), value, f_10485_52194_52204(value));
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,51002,52233);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,52261,52306);

firstUnclaimedStore = correspondingStore + 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,50368,52329);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,49868,52348);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10485,1,3135);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10485,1,3135);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,52379,52470);

f_10485_52379_52469(firstUnclaimedStore == f_10485_52415_52431(tempStores), "not all side-effects were claimed");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,52484,52510);

return tempsRemainedInUse;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10485,48083,52521);

int
f_10485_48261_48292(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 48261, 48292);
return 0;
}


int
f_10485_48307_48339(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 48307, 48339);
return 0;
}


int
f_10485_48381_48397(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 48381, 48397);
return return_v;
}


int
f_10485_49249_49265(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 49249, 49265);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind?
f_10485_49872_49886_M(Microsoft.CodeAnalysis.CSharp.BoundKind?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 49872, 49886);
return return_v;
}


int
f_10485_50035_50051(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 50035, 50051);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
f_10485_50110_50123(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 50110, 50123);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_50110_50128(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
this_param)
{
var return_v = this_param.Left ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 50110, 50128);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
f_10485_50458_50488(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 50458, 50488);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_50458_50494(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
this_param)
{
var return_v = this_param.Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 50458, 50494);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10485_50534_50544(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 50534, 50544);
return return_v;
}


int
f_10485_50521_50552(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 50521, 50552);
return 0;
}


int
f_10485_51370_51388(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 51370, 51388);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
f_10485_51476_51511(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 51476, 51511);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10485_52072_52103(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
items)
{
var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.BoundExpression>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 52072, 52103);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10485_52194_52204(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 52194, 52204);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10485_51590_52205(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax, locals, sideEffects, value, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 51590, 52205);
return return_v;
}


int
f_10485_52415_52431(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 52415, 52431);
return return_v;
}


int
f_10485_52379_52469(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 52379, 52469);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,48083,52521);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,48083,52521);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void RewriteArgumentsForComCall(
            ImmutableArray<ParameterSymbol> parameters,
            BoundExpression[] actualArguments, //already re-ordered to match parameters
            ArrayBuilder<RefKind> argsRefKindsBuilder,
            ArrayBuilder<LocalSymbol> temporariesBuilder)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10485,53267,55583);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,53593,53631);

f_10485_53593_53630(actualArguments != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,53645,53703);

f_10485_53645_53702(f_10485_53658_53680(actualArguments)== parameters.Length);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,53719,53761);

f_10485_53719_53760(argsRefKindsBuilder != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,53775,53836);

f_10485_53775_53835(f_10485_53788_53813(argsRefKindsBuilder)== parameters.Length);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,53852,53891);

var 
argsCount = f_10485_53868_53890(actualArguments)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,53916,53928);

            for (int 
argIndex = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,53907,55572) || true) && (argIndex < argsCount)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,53952,53962)
,++argIndex,DynAbs.Tracing.TraceSender.TraceExitCondition(10485,53907,55572))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,53907,55572);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,53996,54048);

RefKind 
paramRefKind = f_10485_54019_54047(parameters[argIndex])
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,54066,54117);

RefKind 
argRefKind = f_10485_54087_54116(argsRefKindsBuilder, argIndex)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,54270,54401) || true) && (argRefKind != RefKind.None ||(DynAbs.Tracing.TraceSender.Expression_False(10485, 54274, 54331)||paramRefKind != RefKind.Ref))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,54270,54401);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,54373,54382);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,54270,54401);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,54421,54462);

var 
argument = actualArguments[argIndex]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,54480,54916) || true) && (f_10485_54484_54497(argument)== BoundKind.Local)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,54480,54916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,54558,54620);

var 
localRefKind = f_10485_54577_54619(f_10485_54577_54611(((BoundLocal)argument)))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,54642,54830) || true) && (localRefKind == RefKind.Ref)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,54642,54830);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,54798,54807);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,54642,54830);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,54854,54897);

f_10485_54854_54896(localRefKind == RefKind.None);
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,54480,54916);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,54936,54982);

BoundAssignmentOperator 
boundAssignmentToTemp
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,55000,55081);

BoundLocal 
boundTemp = f_10485_55023_55080(_factory, argument, out boundAssignmentToTemp)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,55101,55429);

actualArguments[argIndex] = f_10485_55129_55428(argument.Syntax, locals: ImmutableArray<LocalSymbol>.Empty, sideEffects: f_10485_55284_55345(boundAssignmentToTemp), value: boundTemp, type: f_10485_55413_55427(boundTemp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,55447,55491);

argsRefKindsBuilder[argIndex] = RefKind.Ref;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,55511,55557);

f_10485_55511_55556(
                temporariesBuilder, f_10485_55534_55555(boundTemp));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10485,1,1666);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10485,1,1666);
}DynAbs.Tracing.TraceSender.TraceExitMethod(10485,53267,55583);

int
f_10485_53593_53630(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 53593, 53630);
return 0;
}


int
f_10485_53658_53680(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 53658, 53680);
return return_v;
}


int
f_10485_53645_53702(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 53645, 53702);
return 0;
}


int
f_10485_53719_53760(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 53719, 53760);
return 0;
}


int
f_10485_53788_53813(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 53788, 53813);
return return_v;
}


int
f_10485_53775_53835(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 53775, 53835);
return 0;
}


int
f_10485_53868_53890(Microsoft.CodeAnalysis.CSharp.BoundExpression[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 53868, 53890);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_10485_54019_54047(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.RefKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 54019, 54047);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_10485_54087_54116(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 54087, 54116);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10485_54484_54497(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 54484, 54497);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10485_54577_54611(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 54577, 54611);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_10485_54577_54619(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.RefKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 54577, 54619);
return return_v;
}


int
f_10485_54854_54896(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 54854, 54896);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10485_55023_55080(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 55023, 55080);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10485_55284_55345(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 55284, 55345);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10485_55413_55427(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 55413, 55427);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10485_55129_55428(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundLocal
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax, locals: locals, sideEffects: sideEffects, value: (Microsoft.CodeAnalysis.CSharp.BoundExpression)value, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 55129, 55428);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10485_55534_55555(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 55534, 55555);
return return_v;
}


int
f_10485_55511_55556(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 55511, 55556);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,53267,55583);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,53267,55583);
}
		}

public override BoundNode VisitDynamicMemberAccess(BoundDynamicMemberAccess node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10485,55595,56110);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,55741,55818) || true) && (f_10485_55745_55757(node))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10485,55741,55818);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,55791,55803);

return node;
DynAbs.Tracing.TraceSender.TraceExitCondition(10485,55741,55818);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,55871,55917);

f_10485_55871_55916(node.TypeArgumentsOpt.IsDefault);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,55931,55984);

var 
loweredReceiver = f_10485_55953_55983(this, f_10485_55969_55982(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10485,55998,56099);

return f_10485_56005_56083(_dynamicFactory, loweredReceiver, f_10485_56059_56068(node), f_10485_56070_56082(node)).ToExpression();
DynAbs.Tracing.TraceSender.TraceExitMethod(10485,55595,56110);

bool
f_10485_55745_55757(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
this_param)
{
var return_v = this_param.Invoked;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 55745, 55757);
return return_v;
}


int
f_10485_55871_55916(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 55871, 55916);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10485_55969_55982(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
this_param)
{
var return_v = this_param.Receiver;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 55969, 55982);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10485_55953_55983(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 55953, 55983);
return return_v;
}


string
f_10485_56059_56068(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 56059, 56068);
return return_v;
}


bool
f_10485_56070_56082(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
this_param)
{
var return_v = this_param.Indexed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10485, 56070, 56082);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
f_10485_56005_56083(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredReceiver,string
name,bool
resultIndexed)
{
var return_v = this_param.MakeDynamicGetMember( loweredReceiver, name, resultIndexed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10485, 56005, 56083);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10485,55595,56110);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10485,55595,56110);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
