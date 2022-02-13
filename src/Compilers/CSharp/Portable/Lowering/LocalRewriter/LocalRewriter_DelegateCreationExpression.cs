// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
internal partial class LocalRewriter
{
public override BoundNode VisitDelegateCreationExpression(BoundDelegateCreationExpression node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10492,465,1941);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10492,585,1197) || true) && (f_10492_589_619(f_10492_589_602(node)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10492,585,1197);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10492,653,706);

var 
loweredArgument = f_10492_675_705(this, f_10492_691_704(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10492,856,1029);

var 
loweredReceiver = f_10492_878_1013(_dynamicFactory, loweredArgument, isExplicit: false, isArrayIndex: false, isChecked: false, resultType: f_10492_1003_1012(node)).ToExpression()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10492,1049,1182);

return f_10492_1056_1181(node.Syntax, loweredReceiver, methodOpt: null, isExtensionMethod: false, type: f_10492_1171_1180(node));
DynAbs.Tracing.TraceSender.TraceExitCondition(10492,585,1197);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10492,1213,1863) || true) && (f_10492_1217_1235(f_10492_1217_1230(node))== BoundKind.MethodGroup)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10492,1213,1863);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10492,1294,1335);

var 
mg = (BoundMethodGroup)f_10492_1321_1334(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10492,1353,1381);

var 
method = f_10492_1366_1380(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10492,1399,1427);

f_10492_1399_1426(method is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10492,1445,1477);

var 
oldSyntax = f_10492_1461_1476(_factory)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10492,1495,1543);

_factory.Syntax = (f_10492_1514_1528(mg)??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10492, 1514, 1534)??mg)).Syntax;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10492,1561,1712);

var 
receiver = (DynAbs.Tracing.TraceSender.Conditional_F1(10492, 1576, 1637)||(((f_10492_1577_1609_M(!method.RequiresInstanceReceiver)&&(DynAbs.Tracing.TraceSender.Expression_True(10492, 1577, 1636)&&f_10492_1613_1636_M(!node.IsExtensionMethod))) &&DynAbs.Tracing.TraceSender.Conditional_F2(10492, 1640, 1676))||DynAbs.Tracing.TraceSender.Conditional_F3(10492, 1679, 1711)))?f_10492_1640_1676(_factory, f_10492_1654_1675(method)):f_10492_1679_1710(this, f_10492_1695_1709(mg))!
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10492,1730,1758);

_factory.Syntax = oldSyntax;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10492,1776,1848);

return f_10492_1783_1847(node, receiver, method, f_10492_1813_1835(node), f_10492_1837_1846(node));
DynAbs.Tracing.TraceSender.TraceExitCondition(10492,1213,1863);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10492,1879,1930);

return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitDelegateCreationExpression(node),10492,1886,1928)!;
DynAbs.Tracing.TraceSender.TraceExitMethod(10492,465,1941);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10492_589_602(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
this_param)
{
var return_v = this_param.Argument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10492, 589, 602);
return return_v;
}


bool
f_10492_589_619(Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = node.HasDynamicType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10492, 589, 619);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10492_691_704(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
this_param)
{
var return_v = this_param.Argument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10492, 691, 704);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10492_675_705(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10492, 675, 705);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10492_1003_1012(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10492, 1003, 1012);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
f_10492_878_1013(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
loweredOperand,bool
isExplicit,bool
isArrayIndex,bool
isChecked,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
resultType)
{
var return_v = this_param.MakeDynamicConversion( loweredOperand, isExplicit: isExplicit, isArrayIndex: isArrayIndex, isChecked: isChecked, resultType: resultType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10492, 878, 1013);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10492_1171_1180(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10492, 1171, 1180);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
f_10492_1056_1181(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
methodOpt,bool
isExtensionMethod,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression( syntax, argument, methodOpt: methodOpt, isExtensionMethod: isExtensionMethod, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10492, 1056, 1181);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10492_1217_1230(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
this_param)
{
var return_v = this_param.Argument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10492, 1217, 1230);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10492_1217_1235(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10492, 1217, 1235);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10492_1321_1334(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
this_param)
{
var return_v = this_param.Argument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10492, 1321, 1334);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10492_1366_1380(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
this_param)
{
var return_v = this_param.MethodOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10492, 1366, 1380);
return return_v;
}


int
f_10492_1399_1426(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10492, 1399, 1426);
return 0;
}


Microsoft.CodeAnalysis.SyntaxNode
f_10492_1461_1476(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.Syntax;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10492, 1461, 1476);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10492_1514_1528(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
this_param)
{
var return_v = this_param.ReceiverOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10492, 1514, 1528);
return return_v;
}


bool
f_10492_1577_1609_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10492, 1577, 1609);
return return_v;
}


bool
f_10492_1613_1636_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10492, 1613, 1636);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10492_1654_1675(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10492, 1654, 1675);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
f_10492_1640_1676(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
type)
{
var return_v = this_param.Type( (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10492, 1640, 1676);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10492_1695_1709(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
this_param)
{
var return_v = this_param.ReceiverOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10492, 1695, 1709);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10492_1679_1710(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10492, 1679, 1710);
return return_v;
}


bool
f_10492_1813_1835(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
this_param)
{
var return_v = this_param.IsExtensionMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10492, 1813, 1835);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10492_1837_1846(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10492, 1837, 1846);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
f_10492_1783_1847(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
methodOpt,bool
isExtensionMethod,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Update( argument, methodOpt, isExtensionMethod, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10492, 1783, 1847);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10492,465,1941);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10492,465,1941);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
