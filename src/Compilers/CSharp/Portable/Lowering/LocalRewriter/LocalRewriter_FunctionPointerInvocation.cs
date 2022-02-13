// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable enable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode? VisitFunctionPointerInvocation(BoundFunctionPointerInvocation node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10500,421,1592);
System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol> temps = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10500,540,606);

var 
rewrittenExpression = f_10500_566_605(this, f_10500_582_604(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10500,620,666);

var 
rewrittenArgs = f_10500_640_665(this, f_10500_650_664(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10500,682,744);

MethodSymbol 
functionPointer = f_10500_713_743(f_10500_713_733(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10500,758,809);

var 
argumentRefKindsOpt = f_10500_784_808(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10500,823,1228);

rewrittenArgs = f_10500_839_1227(this, node.Syntax, rewrittenArgs, functionPointer, expanded: false, argsToParamsOpt: default, ref argumentRefKindsOpt, out temps, invokedAsExtensionMethod: false, enableCallerInfo: ThreeState.False);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10500,1244,1348);

node = f_10500_1251_1347(node, rewrittenExpression, rewrittenArgs, argumentRefKindsOpt, f_10500_1320_1335(node), f_10500_1337_1346(node));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10500,1364,1451) || true) && (temps.IsDefaultOrEmpty)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10500,1364,1451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10500,1424,1436);

return node;
DynAbs.Tracing.TraceSender.TraceExitCondition(10500,1364,1451);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10500,1467,1581);

return f_10500_1474_1580(node.Syntax, temps, sideEffects: ImmutableArray<BoundExpression>.Empty, node, f_10500_1570_1579(node));
DynAbs.Tracing.TraceSender.TraceExitMethod(10500,421,1592);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10500_582_604(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
this_param)
{
var return_v = this_param.InvokedExpression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10500, 582, 604);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10500_566_605(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10500, 566, 605);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10500_650_664(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10500, 650, 664);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10500_640_665(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
list)
{
var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundExpression>( list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10500, 640, 665);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
f_10500_713_733(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
this_param)
{
var return_v = this_param.FunctionPointer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10500, 713, 733);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
f_10500_713_743(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
this_param)
{
var return_v = this_param.Signature;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10500, 713, 743);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
f_10500_784_808(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
this_param)
{
var return_v = this_param.ArgumentRefKindsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10500, 784, 808);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10500_839_1227(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
rewrittenArguments,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
methodOrIndexer,bool
expanded,System.Collections.Immutable.ImmutableArray<int>
argsToParamsOpt,ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKindsOpt,out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
temps,bool
invokedAsExtensionMethod,Microsoft.CodeAnalysis.ThreeState
enableCallerInfo)
{
var return_v = this_param.MakeArguments( syntax, rewrittenArguments, (Microsoft.CodeAnalysis.CSharp.Symbol)methodOrIndexer, expanded: expanded, argsToParamsOpt: argsToParamsOpt, ref argumentRefKindsOpt, out temps, invokedAsExtensionMethod: invokedAsExtensionMethod, enableCallerInfo: enableCallerInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10500, 839, 1227);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.LookupResultKind
f_10500_1320_1335(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
this_param)
{
var return_v = this_param.ResultKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10500, 1320, 1335);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10500_1337_1346(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10500, 1337, 1346);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
f_10500_1251_1347(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
invokedExpression,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
arguments,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
argumentRefKindsOpt,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = this_param.Update( invokedExpression, arguments, argumentRefKindsOpt, resultKind, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10500, 1251, 1347);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10500_1570_1579(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10500, 1570, 1579);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSequence
f_10500_1474_1580(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence( syntax, locals, sideEffects: sideEffects, (Microsoft.CodeAnalysis.CSharp.BoundExpression)value, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10500, 1474, 1580);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10500,421,1592);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10500,421,1592);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
