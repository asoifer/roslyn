// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.RuntimeMembers;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitEventAssignmentOperator(BoundEventAssignmentOperator node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10494,696,2383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,810,884);

BoundExpression? 
rewrittenReceiverOpt = f_10494_850_883(this, f_10494_866_882(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,898,965);

BoundExpression 
rewrittenArgument = f_10494_934_964(this, f_10494_950_963(node))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,981,1656) || true) && (rewrittenReceiverOpt != null &&(DynAbs.Tracing.TraceSender.Expression_True(10494, 985, 1055)&&f_10494_1017_1055(f_10494_1017_1046(f_10494_1017_1027(node))))&&(DynAbs.Tracing.TraceSender.Expression_True(10494, 985, 1102)&&f_10494_1059_1102(f_10494_1059_1084(f_10494_1059_1069(node)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,981,1656);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,1136,1179);

var 
@interface = f_10494_1153_1178(f_10494_1153_1163(node))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,1199,1641);
foreach(var attrData in f_10494_1224_1250_I(f_10494_1224_1250(@interface)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,1199,1641);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,1292,1622) || true) && (f_10494_1296_1383(attrData, @interface, AttributeDescription.ComEventInterfaceAttribute)&&(DynAbs.Tracing.TraceSender.Expression_True(10494, 1296, 1459)&&                        attrData.CommonConstructorArguments.Length == 2))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,1292,1622);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,1509,1599);

return f_10494_1516_1598(this, node, rewrittenReceiverOpt, rewrittenArgument);
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,1292,1622);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,1199,1641);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10494,1,443);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10494,1,443);
}DynAbs.Tracing.TraceSender.TraceExitCondition(10494,981,1656);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,1672,2023) || true) && (f_10494_1676_1708(f_10494_1676_1686(node)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,1672,2023);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,1742,1850);

EventAssignmentKind 
kind = (DynAbs.Tracing.TraceSender.Conditional_F1(10494, 1769, 1784)||((f_10494_1769_1784(node)&&DynAbs.Tracing.TraceSender.Conditional_F2(10494, 1787, 1815))||DynAbs.Tracing.TraceSender.Conditional_F3(10494, 1818, 1849)))?EventAssignmentKind.Addition :EventAssignmentKind.Subtraction
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,1868,2008);

return f_10494_1875_2007(this, node.Syntax, f_10494_1933_1943(node), kind, f_10494_1951_1965(node), rewrittenReceiverOpt, rewrittenArgument);
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,1672,2023);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,2039,2122);

var 
rewrittenArguments = f_10494_2064_2121(rewrittenArgument)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,2138,2226);

MethodSymbol? 
method = (DynAbs.Tracing.TraceSender.Conditional_F1(10494, 2161, 2176)||((f_10494_2161_2176(node)&&DynAbs.Tracing.TraceSender.Conditional_F2(10494, 2179, 2199))||DynAbs.Tracing.TraceSender.Conditional_F3(10494, 2202, 2225)))?f_10494_2179_2199(f_10494_2179_2189(node)):f_10494_2202_2225(f_10494_2202_2212(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,2240,2268);

f_10494_2240_2267(method is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,2282,2372);

return f_10494_2289_2371(this, node.Syntax, rewrittenReceiverOpt, method, rewrittenArguments, f_10494_2361_2370(node));
DynAbs.Tracing.TraceSender.TraceExitMethod(10494,696,2383);

Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10494_866_882(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
this_param)
{
var return_v = this_param.ReceiverOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 866, 882);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10494_850_883(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 850, 883);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10494_950_963(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
this_param)
{
var return_v = this_param.Argument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 950, 963);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10494_934_964(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 934, 964);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
f_10494_1017_1027(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
this_param)
{
var return_v = this_param.Event;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 1017, 1027);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
f_10494_1017_1046(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
this_param)
{
var return_v = this_param.ContainingAssembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 1017, 1046);
return return_v;
}


bool
f_10494_1017_1055(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
this_param)
{
var return_v = this_param.IsLinked ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 1017, 1055);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
f_10494_1059_1069(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
this_param)
{
var return_v = this_param.Event;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 1059, 1069);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10494_1059_1084(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 1059, 1084);
return return_v;
}


bool
f_10494_1059_1102(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = type.IsInterfaceType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 1059, 1102);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
f_10494_1153_1163(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
this_param)
{
var return_v = this_param.Event;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 1153, 1163);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10494_1153_1178(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 1153, 1178);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
f_10494_1224_1250(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.GetAttributes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 1224, 1250);
return return_v;
}


bool
f_10494_1296_1383(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
targetSymbol,Microsoft.CodeAnalysis.AttributeDescription
description)
{
var return_v = this_param.IsTargetAttribute( (Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 1296, 1383);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10494_1516_1598(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
node,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenReceiver,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenArgument)
{
var return_v = this_param.RewriteNoPiaEventAssignmentOperator( node, rewrittenReceiver, rewrittenArgument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 1516, 1598);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
f_10494_1224_1250_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 1224, 1250);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
f_10494_1676_1686(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
this_param)
{
var return_v = this_param.Event;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 1676, 1686);
return return_v;
}


bool
f_10494_1676_1708(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
this_param)
{
var return_v = this_param.IsWindowsRuntimeEvent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 1676, 1708);
return return_v;
}


bool
f_10494_1769_1784(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
this_param)
{
var return_v = this_param.IsAddition ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 1769, 1784);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
f_10494_1933_1943(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
this_param)
{
var return_v = this_param.Event;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 1933, 1943);
return return_v;
}


bool
f_10494_1951_1965(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
this_param)
{
var return_v = this_param.IsDynamic;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 1951, 1965);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10494_1875_2007(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
eventSymbol,Microsoft.CodeAnalysis.CSharp.LocalRewriter.EventAssignmentKind
kind,bool
isDynamic,Microsoft.CodeAnalysis.CSharp.BoundExpression?
rewrittenReceiverOpt,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenArgument)
{
var return_v = this_param.RewriteWindowsRuntimeEventAssignmentOperator( syntax, eventSymbol, kind, isDynamic, rewrittenReceiverOpt, rewrittenArgument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 1875, 2007);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10494_2064_2121(Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 2064, 2121);
return return_v;
}


bool
f_10494_2161_2176(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
this_param)
{
var return_v = this_param.IsAddition ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 2161, 2176);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
f_10494_2179_2189(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
this_param)
{
var return_v = this_param.Event;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 2179, 2189);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10494_2179_2199(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
this_param)
{
var return_v = this_param.AddMethod ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 2179, 2199);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
f_10494_2202_2212(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
this_param)
{
var return_v = this_param.Event;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 2202, 2212);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10494_2202_2225(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
this_param)
{
var return_v = this_param.RemoveMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 2202, 2225);
return return_v;
}


int
f_10494_2240_2267(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 2240, 2267);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10494_2361_2370(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 2361, 2370);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10494_2289_2371(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
rewrittenReceiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeCall( syntax, rewrittenReceiver, method, rewrittenArguments, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 2289, 2371);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10494,696,2383);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10494,696,2383);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

        private enum EventAssignmentKind
        {
            Assignment,
            Addition,
            Subtraction,
        }

private BoundExpression RewriteWindowsRuntimeEventAssignmentOperator(SyntaxNode syntax, EventSymbol eventSymbol, EventAssignmentKind kind, bool isDynamic, BoundExpression? rewrittenReceiverOpt, BoundExpression rewrittenArgument)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10494,3448,8878);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,3701,3748);

BoundAssignmentOperator? 
tempAssignment = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,3762,3791);

BoundLocal? 
boundTemp = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,3805,3871);

f_10494_3805_3870(f_10494_3818_3838(eventSymbol)||(DynAbs.Tracing.TraceSender.Expression_False(10494, 3818, 3869)||rewrittenReceiverOpt is { }));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,3885,4088) || true) && (f_10494_3889_3910_M(!eventSymbol.IsStatic)&&(DynAbs.Tracing.TraceSender.Expression_True(10494, 3889, 3963)&&f_10494_3914_3963(rewrittenReceiverOpt!)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,3885,4088);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,3997,4073);

boundTemp = f_10494_4009_4072(_factory, rewrittenReceiverOpt!, out tempAssignment);
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,3885,4088);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,4104,4239);

NamedTypeSymbol 
tokenType = f_10494_4132_4238(_factory, WellKnownType.System_Runtime_InteropServices_WindowsRuntime_EventRegistrationToken)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,4253,4389);

NamedTypeSymbol 
marshalType = f_10494_4283_4388(_factory, WellKnownType.System_Runtime_InteropServices_WindowsRuntime_WindowsRuntimeMarshal)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,4405,4509);

NamedTypeSymbol 
actionType = f_10494_4434_4508(f_10494_4434_4487(_factory, WellKnownType.System_Action_T), tokenType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,4525,4565);

TypeSymbol 
eventType = f_10494_4548_4564(eventSymbol)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,4581,4686);

BoundExpression 
delegateCreationArgument = boundTemp ??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundLocal?>(10494, 4624, 4685)??rewrittenReceiverOpt ??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10494, 4637, 4685)??f_10494_4661_4685(_factory, eventType)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,4702,5006);

BoundDelegateCreationExpression 
removeDelegate = f_10494_4751_5005(syntax: syntax, argument: delegateCreationArgument, methodOpt: f_10494_4902_4926(eventSymbol), isExtensionMethod: false, type: actionType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,5022,5056);

BoundExpression? 
clearCall = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,5070,6021) || true) && (kind == EventAssignmentKind.Assignment)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,5070,6021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,5146,5171);

MethodSymbol 
clearMethod
=default(MethodSymbol);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,5189,6006) || true) && (f_10494_5193_5352(this, syntax, WellKnownMember.System_Runtime_InteropServices_WindowsRuntime_WindowsRuntimeMarshal__RemoveAllEventHandlers, out clearMethod))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,5189,6006);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,5394,5709);

clearCall = f_10494_5406_5708(this, syntax: syntax, rewrittenReceiver: null, method: clearMethod, rewrittenArguments: f_10494_5598_5652(removeDelegate), type: f_10494_5685_5707(clearMethod));
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,5189,6006);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,5189,6006);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,5791,5987);

clearCall = f_10494_5803_5986(syntax, LookupResultKind.NotInvocable, ImmutableArray<Symbol?>.Empty, f_10494_5896_5950(removeDelegate), ErrorTypeSymbol.UnknownResultType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,5189,6006);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,5070,6021);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,6037,6086);

ImmutableArray<BoundExpression> 
marshalArguments
=default(ImmutableArray<BoundExpression>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,6100,6123);

WellKnownMember 
helper
=default(WellKnownMember);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,6137,7227) || true) && (kind == EventAssignmentKind.Subtraction)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,6137,7227);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,6214,6329);

helper = WellKnownMember.System_Runtime_InteropServices_WindowsRuntime_WindowsRuntimeMarshal__RemoveEventHandler_T;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,6347,6440);

marshalArguments = f_10494_6366_6439(removeDelegate, rewrittenArgument);
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,6137,7227);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,6137,7227);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,6506,6619);

NamedTypeSymbol 
func2Type = f_10494_6534_6618(f_10494_6534_6586(_factory, WellKnownType.System_Func_T2), eventType, tokenType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,6639,6956);

BoundDelegateCreationExpression 
addDelegate = f_10494_6685_6955(syntax: syntax, argument: delegateCreationArgument, methodOpt: f_10494_6848_6869(eventSymbol), isExtensionMethod: false, type: func2Type)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,6976,7088);

helper = WellKnownMember.System_Runtime_InteropServices_WindowsRuntime_WindowsRuntimeMarshal__AddEventHandler_T;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,7106,7212);

marshalArguments = f_10494_7125_7211(addDelegate, removeDelegate, rewrittenArgument);
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,6137,7227);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,7243,7271);

BoundExpression 
marshalCall
=default(BoundExpression);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,7287,7314);

MethodSymbol 
marshalMethod
=default(MethodSymbol);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,7328,8001) || true) && (f_10494_7332_7392(this, syntax, helper, out marshalMethod))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,7328,8001);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,7426,7477);

marshalMethod = f_10494_7442_7476(marshalMethod, eventType);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,7497,7760);

marshalCall = f_10494_7511_7759(this, syntax: syntax, rewrittenReceiver: null, method: marshalMethod, rewrittenArguments: marshalArguments, type: f_10494_7734_7758(marshalMethod));
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,7328,8001);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,7328,8001);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,7826,7986);

marshalCall = f_10494_7840_7985(syntax, LookupResultKind.NotInvocable, ImmutableArray<Symbol?>.Empty, marshalArguments, ErrorTypeSymbol.UnknownResultType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,7328,8001);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,8073,8183) || true) && (boundTemp == null &&(DynAbs.Tracing.TraceSender.Expression_True(10494, 8077, 8115)&&clearCall == null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,8073,8183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,8149,8168);

return marshalCall;
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,8073,8183);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,8199,8389);

ImmutableArray<LocalSymbol> 
tempSymbols = (DynAbs.Tracing.TraceSender.Conditional_F1(10494, 8241, 8258)||((boundTemp == null
&&DynAbs.Tracing.TraceSender.Conditional_F2(10494, 8278, 8311))||DynAbs.Tracing.TraceSender.Conditional_F3(10494, 8331, 8388)))?ImmutableArray<LocalSymbol>.Empty
:f_10494_8331_8388(f_10494_8366_8387(boundTemp))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,8405,8494);

ArrayBuilder<BoundExpression> 
sideEffects = f_10494_8449_8493(2)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,8519,8569) || true) && (clearCall != null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,8519,8569);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,8542,8569);

f_10494_8542_8568(sideEffects, clearCall);
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,8519,8569);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,8583,8643) || true) && (tempAssignment != null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,8583,8643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,8611,8643);

f_10494_8611_8642(sideEffects, tempAssignment);
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,8583,8643);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,8657,8739);

f_10494_8657_8738(f_10494_8670_8687(sideEffects), "Otherwise, we shouldn't be building a sequence");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,8755,8867);

return f_10494_8762_8866(syntax, tempSymbols, f_10494_8801_8833(sideEffects), marshalCall, marshalCall.Type!);
DynAbs.Tracing.TraceSender.TraceExitMethod(10494,3448,8878);

bool
f_10494_3818_3838(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
this_param)
{
var return_v = this_param.IsStatic ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 3818, 3838);
return return_v;
}


int
f_10494_3805_3870(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 3805, 3870);
return 0;
}


bool
f_10494_3889_3910_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 3889, 3910);
return return_v;
}


bool
f_10494_3914_3963(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = CanChangeValueBetweenReads( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 3914, 3963);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10494_4009_4072(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator?
store)
{
var return_v = this_param.StoreToTemp( argument, out store);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 4009, 4072);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10494_4132_4238(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.WellKnownType
wt)
{
var return_v = this_param.WellKnownType( wt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 4132, 4238);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10494_4283_4388(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.WellKnownType
wt)
{
var return_v = this_param.WellKnownType( wt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 4283, 4388);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10494_4434_4487(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.WellKnownType
wt)
{
var return_v = this_param.WellKnownType( wt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 4434, 4487);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10494_4434_4508(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param,params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
typeArguments)
{
var return_v = this_param.Construct( typeArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 4434, 4508);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10494_4548_4564(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 4548, 4564);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
f_10494_4661_4685(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Type( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 4661, 4685);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10494_4902_4926(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
this_param)
{
var return_v = this_param.RemoveMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 4902, 4926);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
f_10494_4751_5005(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
methodOpt,bool
isExtensionMethod,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression( syntax: syntax, argument: argument, methodOpt: methodOpt, isExtensionMethod: isExtensionMethod, type: (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 4751, 5005);
return return_v;
}


bool
f_10494_5193_5352(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.WellKnownMember
member,out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
symbol)
{
var return_v = this_param.TryGetWellKnownTypeMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( syntax, member, out symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 5193, 5352);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10494_5598_5652(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 5598, 5652);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10494_5685_5707(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ReturnType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 5685, 5707);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10494_5406_5708(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
rewrittenReceiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeCall( syntax: syntax, rewrittenReceiver: rewrittenReceiver, method: method, rewrittenArguments: rewrittenArguments, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 5406, 5708);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10494_5896_5950(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 5896, 5950);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBadExpression
f_10494_5803_5986(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
symbols,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
childBoundNodes,Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression( syntax, resultKind, symbols, childBoundNodes, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 5803, 5986);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10494_6366_6439(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
item1,Microsoft.CodeAnalysis.CSharp.BoundExpression
item2)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 6366, 6439);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10494_6534_6586(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.WellKnownType
wt)
{
var return_v = this_param.WellKnownType( wt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 6534, 6586);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10494_6534_6618(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param,params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
typeArguments)
{
var return_v = this_param.Construct( typeArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 6534, 6618);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10494_6848_6869(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
this_param)
{
var return_v = this_param.AddMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 6848, 6869);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
f_10494_6685_6955(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
methodOpt,bool
isExtensionMethod,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression( syntax: syntax, argument: argument, methodOpt: methodOpt, isExtensionMethod: isExtensionMethod, type: (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 6685, 6955);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10494_7125_7211(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
item1,Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
item2,Microsoft.CodeAnalysis.CSharp.BoundExpression
item3)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item1, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item2, item3);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 7125, 7211);
return return_v;
}


bool
f_10494_7332_7392(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.WellKnownMember
member,out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
symbol)
{
var return_v = this_param.TryGetWellKnownTypeMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( syntax, member, out symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 7332, 7392);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10494_7442_7476(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param,params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
typeArguments)
{
var return_v = this_param.Construct( typeArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 7442, 7476);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10494_7734_7758(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ReturnType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 7734, 7758);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10494_7511_7759(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
rewrittenReceiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeCall( syntax: syntax, rewrittenReceiver: rewrittenReceiver, method: method, rewrittenArguments: rewrittenArguments, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 7511, 7759);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBadExpression
f_10494_7840_7985(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
symbols,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
childBoundNodes,Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression( syntax, resultKind, symbols, childBoundNodes, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 7840, 7985);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10494_8366_8387(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 8366, 8387);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10494_8331_8388(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
var return_v = ImmutableArray.Create<LocalSymbol>( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 8331, 8388);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10494_8449_8493(int
capacity)
{
var return_v = ArrayBuilder<BoundExpression>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 8449, 8493);
return return_v;
}


int
f_10494_8542_8568(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 8542, 8568);
return 0;
}


int
f_10494_8611_8642(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 8611, 8642);
return 0;
}


bool
f_10494_8670_8687(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.Any();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 8670, 8687);
return return_v;
}


int
f_10494_8657_8738(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 8657, 8738);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10494_8801_8833(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 8801, 8833);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10494_8762_8866(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundExpression
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax, locals, sideEffects, value, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 8762, 8866);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10494,3448,8878);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10494,3448,8878);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression VisitWindowsRuntimeEventFieldAssignmentOperator(SyntaxNode syntax, BoundEventAccess left, BoundExpression rewrittenRight)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10494,8890,9692);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,9060,9095);

f_10494_9060_9094(f_10494_9073_9093(left));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,9111,9154);

EventSymbol 
eventSymbol = f_10494_9137_9153(left)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,9168,9213);

f_10494_9168_9212(f_10494_9181_9211(eventSymbol));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,9227,9275);

f_10494_9227_9274(f_10494_9240_9273(eventSymbol));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,9291,9365);

BoundExpression? 
rewrittenReceiverOpt = f_10494_9331_9364(this, f_10494_9347_9363(left))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,9381,9410);

const bool 
isDynamic = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,9424,9681);

return f_10494_9431_9680(this, syntax, eventSymbol, EventAssignmentKind.Assignment, isDynamic, rewrittenReceiverOpt, rewrittenRight);
DynAbs.Tracing.TraceSender.TraceExitMethod(10494,8890,9692);

bool
f_10494_9073_9093(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.IsUsableAsField;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 9073, 9093);
return return_v;
}


int
f_10494_9060_9094(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 9060, 9094);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
f_10494_9137_9153(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.EventSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 9137, 9153);
return return_v;
}


bool
f_10494_9181_9211(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
this_param)
{
var return_v = this_param.HasAssociatedField;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 9181, 9211);
return return_v;
}


int
f_10494_9168_9212(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 9168, 9212);
return 0;
}


bool
f_10494_9240_9273(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
this_param)
{
var return_v = this_param.IsWindowsRuntimeEvent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 9240, 9273);
return return_v;
}


int
f_10494_9227_9274(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 9227, 9274);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10494_9347_9363(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.ReceiverOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 9347, 9363);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10494_9331_9364(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 9331, 9364);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10494_9431_9680(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
eventSymbol,Microsoft.CodeAnalysis.CSharp.LocalRewriter.EventAssignmentKind
kind,bool
isDynamic,Microsoft.CodeAnalysis.CSharp.BoundExpression?
rewrittenReceiverOpt,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenArgument)
{
var return_v = this_param.RewriteWindowsRuntimeEventAssignmentOperator( syntax, eventSymbol, kind, isDynamic, rewrittenReceiverOpt, rewrittenArgument);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 9431, 9680);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10494,8890,9692);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10494,8890,9692);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode VisitEventAccess(BoundEventAccess node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10494,9704,10198);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,9930,9965);

f_10494_9930_9964(f_10494_9943_9963(node));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,9981,10052);

BoundExpression? 
rewrittenReceiver = f_10494_10018_10051(this, f_10494_10034_10050(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,10066,10187);

return f_10494_10073_10186(this, node.Syntax, rewrittenReceiver, f_10494_10121_10137(node), f_10494_10139_10157(node), f_10494_10159_10174(node), f_10494_10176_10185(node));
DynAbs.Tracing.TraceSender.TraceExitMethod(10494,9704,10198);

bool
f_10494_9943_9963(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.IsUsableAsField;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 9943, 9963);
return return_v;
}


int
f_10494_9930_9964(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 9930, 9964);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10494_10034_10050(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.ReceiverOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 10034, 10050);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10494_10018_10051(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 10018, 10051);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
f_10494_10121_10137(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.EventSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 10121, 10137);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10494_10139_10157(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 10139, 10157);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LookupResultKind
f_10494_10159_10174(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.ResultKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 10159, 10174);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10494_10176_10185(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 10176, 10185);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10494_10073_10186(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
rewrittenReceiver,Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
eventSymbol,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeEventAccess( syntax, rewrittenReceiver, eventSymbol, constantValueOpt, resultKind, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 10073, 10186);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10494,9704,10198);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10494,9704,10198);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeEventAccess(
            SyntaxNode syntax,
            BoundExpression? rewrittenReceiver,
            EventSymbol eventSymbol,
            ConstantValue? constantValueOpt,
            LookupResultKind resultKind,
            TypeSymbol type)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10494,10210,13661);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,10512,10557);

f_10494_10512_10556(f_10494_10525_10555(eventSymbol));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,10573,10628);

FieldSymbol? 
fieldSymbol = f_10494_10600_10627(eventSymbol)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,10642,10675);

f_10494_10642_10674(fieldSymbol is { });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,10691,10877) || true) && (f_10494_10695_10729_M(!eventSymbol.IsWindowsRuntimeEvent))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,10691,10877);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,10763,10862);

return f_10494_10770_10861(this, syntax, rewrittenReceiver, fieldSymbol, constantValueOpt, resultKind, type);
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,10691,10877);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,10893,10955);

NamedTypeSymbol 
fieldType = (NamedTypeSymbol)f_10494_10938_10954(fieldSymbol)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,10969,11031);

f_10494_10969_11030(f_10494_10982_10996(fieldType)== "EventRegistrationTokenTable");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,11075,11335);

BoundFieldAccess 
fieldAccess = new BoundFieldAccess(
                syntax,
(DynAbs.Tracing.TraceSender.Conditional_F1(10494, 11170, 11190)||((f_10494_11170_11190(fieldSymbol)&&DynAbs.Tracing.TraceSender.Conditional_F2(10494, 11193, 11197))||DynAbs.Tracing.TraceSender.Conditional_F3(10494, 11200, 11217)))?null :rewrittenReceiver,
                fieldSymbol,
                constantValueOpt: null)
            { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true,10494,11106,11334) }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,11351,11383);

BoundExpression 
getOrCreateCall
=default(BoundExpression);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,11399,11430);

MethodSymbol 
getOrCreateMethod
=default(MethodSymbol);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,11444,12338) || true) && (f_10494_11448_11637(this, syntax, WellKnownMember.System_Runtime_InteropServices_WindowsRuntime_EventRegistrationTokenTable_T__GetOrCreateEventRegistrationTokenTable, out getOrCreateMethod))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,11444,12338);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,11671,11729);

getOrCreateMethod = f_10494_11691_11728(getOrCreateMethod, fieldType);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,11860,12058);

getOrCreateCall = f_10494_11878_12057(syntax, receiverOpt: null, method: getOrCreateMethod, arg0: fieldAccess);
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,11444,12338);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,11444,12338);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,12124,12323);

getOrCreateCall = f_10494_12142_12322(syntax, LookupResultKind.NotInvocable, ImmutableArray<Symbol?>.Empty, f_10494_12235_12286(fieldAccess), ErrorTypeSymbol.UnknownResultType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,11444,12338);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,12354,12392);

PropertySymbol 
invocationListProperty
=default(PropertySymbol);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,12406,13459) || true) && (f_10494_12410_12580(this, syntax, WellKnownMember.System_Runtime_InteropServices_WindowsRuntime_EventRegistrationTokenTable_T__InvocationList, out invocationListProperty))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,12406,13459);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,12614,12685);

MethodSymbol 
invocationListAccessor = f_10494_12652_12684(invocationListProperty)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,12705,13444) || true) && ((object)invocationListAccessor == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,12705,13444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,12789,13021);

string 
accessorName = f_10494_12811_13020(f_10494_12856_12883(invocationListProperty), getNotSet: true, isWinMdOutput: f_10494_12967_13019(invocationListProperty))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,13043,13191);

f_10494_13043_13190(                    _diagnostics, f_10494_13060_13172(ErrorCode.ERR_MissingPredefinedMember, f_10494_13120_13157(invocationListProperty), accessorName), f_10494_13174_13189(syntax));
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,12705,13444);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,12705,13444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,13273,13341);

invocationListAccessor = f_10494_13298_13340(invocationListAccessor, fieldType);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,13363,13425);

return f_10494_13370_13424(_factory, getOrCreateCall, invocationListAccessor);
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,12705,13444);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,12406,13459);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,13475,13650);

return f_10494_13482_13649(syntax, LookupResultKind.NotInvocable, ImmutableArray<Symbol?>.Empty, f_10494_13575_13613(getOrCreateCall), ErrorTypeSymbol.UnknownResultType);
DynAbs.Tracing.TraceSender.TraceExitMethod(10494,10210,13661);

bool
f_10494_10525_10555(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
this_param)
{
var return_v = this_param.HasAssociatedField;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 10525, 10555);
return return_v;
}


int
f_10494_10512_10556(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 10512, 10556);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
f_10494_10600_10627(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
this_param)
{
var return_v = this_param.AssociatedField;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 10600, 10627);
return return_v;
}


int
f_10494_10642_10674(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 10642, 10674);
return 0;
}


bool
f_10494_10695_10729_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 10695, 10729);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10494_10770_10861(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
rewrittenReceiver,Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
fieldSymbol,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.MakeFieldAccess( syntax, rewrittenReceiver, fieldSymbol, constantValueOpt, resultKind, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 10770, 10861);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10494_10938_10954(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 10938, 10954);
return return_v;
}


string
f_10494_10982_10996(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.Name ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 10982, 10996);
return return_v;
}


int
f_10494_10969_11030(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 10969, 11030);
return 0;
}


bool
f_10494_11170_11190(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
this_param)
{
var return_v = this_param.IsStatic ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 11170, 11190);
return return_v;
}


bool
f_10494_11448_11637(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.WellKnownMember
member,out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
symbol)
{
var return_v = this_param.TryGetWellKnownTypeMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( syntax, member, out symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 11448, 11637);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10494_11691_11728(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
newOwner)
{
var return_v = this_param.AsMember( newOwner);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 11691, 11728);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10494_11878_12057(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression?
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
arg0)
{
var return_v = BoundCall.Synthesized( syntax, receiverOpt: receiverOpt, method: method, arg0: (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 11878, 12057);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10494_12235_12286(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 12235, 12286);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBadExpression
f_10494_12142_12322(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
symbols,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
childBoundNodes,Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression( syntax, resultKind, symbols, childBoundNodes, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 12142, 12322);
return return_v;
}


bool
f_10494_12410_12580(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.WellKnownMember
member,out Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
symbol)
{
var return_v = this_param.TryGetWellKnownTypeMember<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>( syntax, member, out symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 12410, 12580);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10494_12652_12684(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
this_param)
{
var return_v = this_param.GetMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 12652, 12684);
return return_v;
}


string
f_10494_12856_12883(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 12856, 12883);
return return_v;
}


bool
f_10494_12967_13019(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
symbol)
{
var return_v = symbol.IsCompilationOutputWinMdObj();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 12967, 13019);
return return_v;
}


string
f_10494_12811_13020(string
propertyName,bool
getNotSet,bool
isWinMdOutput)
{
var return_v = SourcePropertyAccessorSymbol.GetAccessorName( propertyName, getNotSet: getNotSet, isWinMdOutput: isWinMdOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 12811, 13020);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10494_13120_13157(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 13120, 13157);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10494_13060_13172(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,params object[]
args)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo( code, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 13060, 13172);
return return_v;
}


Microsoft.CodeAnalysis.Location
f_10494_13174_13189(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Location;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 13174, 13189);
return return_v;
}


int
f_10494_13043_13190(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
info,Microsoft.CodeAnalysis.Location
location)
{
diagnostics.Add( (Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 13043, 13190);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10494_13298_13340(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
newOwner)
{
var return_v = this_param.AsMember( newOwner);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 13298, 13340);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10494_13370_13424(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = this_param.Call( receiver, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 13370, 13424);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10494_13575_13613(Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 13575, 13613);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBadExpression
f_10494_13482_13649(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
symbols,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
childBoundNodes,Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression( syntax, resultKind, symbols, childBoundNodes, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 13482, 13649);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10494,10210,13661);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10494,10210,13661);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression RewriteNoPiaEventAssignmentOperator(BoundEventAssignmentOperator node, BoundExpression rewrittenReceiver, BoundExpression rewrittenArgument)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10494,13673,16242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,14091,14122);

BoundExpression? 
result = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,14138,14177);

SyntaxNode 
oldSyntax = f_10494_14161_14176(_factory)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,14191,14221);

_factory.Syntax = node.Syntax;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,14239,14347);

var 
ctor = f_10494_14250_14346(_factory, WellKnownMember.System_Runtime_InteropServices_ComAwareEventInfo__ctor)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,14363,15271) || true) && ((object)ctor != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,14363,15271);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,14421,14725);

var 
addRemove = f_10494_14437_14724(_factory, (DynAbs.Tracing.TraceSender.Conditional_F1(10494, 14462, 14477)||((f_10494_14462_14477(node)&&DynAbs.Tracing.TraceSender.Conditional_F2(10494, 14480, 14561))||DynAbs.Tracing.TraceSender.Conditional_F3(10494, 14639, 14723)))?WellKnownMember.System_Runtime_InteropServices_ComAwareEventInfo__AddEventHandler :                                                                          WellKnownMember.System_Runtime_InteropServices_ComAwareEventInfo__RemoveEventHandler)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,14745,15256) || true) && ((object)addRemove != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,14745,15256);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,14816,14950);

BoundExpression 
eventInfo = f_10494_14844_14949(_factory, ctor, f_10494_14863_14905(_factory, f_10494_14879_14904(f_10494_14879_14889(node))), f_10494_14907_14948(_factory, f_10494_14924_14947(f_10494_14924_14934(node))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,14972,15237);

result = f_10494_14981_15236(_factory, eventInfo, addRemove, f_10494_15060_15125(                                          _factory, f_10494_15077_15105(f_10494_15077_15097(addRemove)[0]), rewrittenReceiver), f_10494_15170_15235(                                          _factory, f_10494_15187_15215(f_10494_15187_15207(addRemove)[1]), rewrittenArgument));
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,14745,15256);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,14363,15271);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,15287,15315);

_factory.Syntax = oldSyntax;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,15609,15638);

var 
module = f_10494_15622_15637(this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,15652,15861) || true) && (module != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,15652,15861);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,15704,15846);

f_10494_15704_15845(f_10494_15704_15734(module), f_10494_15754_15780(f_10494_15754_15764(node)), node.Syntax, _diagnostics, isUsedForComAwareEventBinding: true);
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,15652,15861);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,15877,15958) || true) && (result != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10494,15877,15958);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,15929,15943);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(10494,15877,15958);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10494,15974,16231);

return f_10494_15981_16230(node.Syntax, LookupResultKind.NotCreatable, f_10494_16048_16090(f_10494_16079_16089(node)), f_10494_16135_16194(rewrittenReceiver, rewrittenArgument), ErrorTypeSymbol.UnknownResultType);
DynAbs.Tracing.TraceSender.TraceExitMethod(10494,13673,16242);

Microsoft.CodeAnalysis.SyntaxNode
f_10494_14161_14176(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.Syntax;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 14161, 14176);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10494_14250_14346(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.WellKnownMember
wm)
{
var return_v = this_param.WellKnownMethod( wm);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 14250, 14346);
return return_v;
}


bool
f_10494_14462_14477(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
this_param)
{
var return_v = this_param.IsAddition ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 14462, 14477);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10494_14437_14724(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.WellKnownMember
wm)
{
var return_v = this_param.WellKnownMethod( wm);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 14437, 14724);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
f_10494_14879_14889(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
this_param)
{
var return_v = this_param.Event;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 14879, 14889);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10494_14879_14904(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 14879, 14904);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10494_14863_14905(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = this_param.Typeof( (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 14863, 14905);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
f_10494_14924_14934(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
this_param)
{
var return_v = this_param.Event;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 14924, 14934);
return return_v;
}


string
f_10494_14924_14947(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
this_param)
{
var return_v = this_param.MetadataName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 14924, 14947);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLiteral
f_10494_14907_14948(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,string
value)
{
var return_v = this_param.Literal( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 14907, 14948);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
f_10494_14844_14949(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
ctor,params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
args)
{
var return_v = this_param.New( ctor, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 14844, 14949);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
f_10494_15077_15097(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 15077, 15097);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10494_15077_15105(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 15077, 15105);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10494_15060_15125(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg)
{
var return_v = this_param.Convert( type, arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 15060, 15125);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
f_10494_15187_15207(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 15187, 15207);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10494_15187_15215(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 15187, 15215);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10494_15170_15235(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg)
{
var return_v = this_param.Convert( type, arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 15170, 15235);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10494_14981_15236(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
receiver,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg0,Microsoft.CodeAnalysis.CSharp.BoundExpression
arg1)
{
var return_v = this_param.Call( receiver, method, arg0, arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 14981, 15236);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
f_10494_15622_15637(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.EmitModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 15622, 15637);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
f_10494_15704_15734(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
this_param)
{
var return_v = this_param.EmbeddedTypesManagerOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 15704, 15734);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
f_10494_15754_15764(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
this_param)
{
var return_v = this_param.Event;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 15754, 15764);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
f_10494_15754_15780(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
this_param)
{
var return_v = this_param.GetCciAdapter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 15754, 15780);
return return_v;
}


int
f_10494_15704_15845(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbolAdapter
eventSymbol,Microsoft.CodeAnalysis.SyntaxNode
syntaxNodeOpt,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,bool
isUsedForComAwareEventBinding)
{
this_param.EmbedEventIfNeedTo( eventSymbol, syntaxNodeOpt, diagnostics, isUsedForComAwareEventBinding: isUsedForComAwareEventBinding);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 15704, 15845);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
f_10494_16079_16089(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
this_param)
{
var return_v = this_param.Event;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10494, 16079, 16089);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
f_10494_16048_16090(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
item)
{
var return_v = ImmutableArray.Create<Symbol?>( (Microsoft.CodeAnalysis.CSharp.Symbol)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 16048, 16090);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10494_16135_16194(Microsoft.CodeAnalysis.CSharp.BoundExpression
item1,Microsoft.CodeAnalysis.CSharp.BoundExpression
item2)
{
var return_v = ImmutableArray.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 16135, 16194);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBadExpression
f_10494_15981_16230(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
symbols,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
childBoundNodes,Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression( syntax, resultKind, symbols, childBoundNodes, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10494, 15981, 16230);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10494,13673,16242);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10494,13673,16242);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
