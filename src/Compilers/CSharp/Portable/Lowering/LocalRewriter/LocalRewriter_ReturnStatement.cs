// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitReturnStatement(BoundReturnStatement node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10523,445,1777);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10523,543,619);

BoundStatement 
rewritten = (BoundStatement)DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitReturnStatement(node),10523,586,617)!
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10523,1323,1733) || true) && (f_10523_1327_1342(this)&&(DynAbs.Tracing.TraceSender.Expression_True(10523, 1327, 1615)&&                (f_10523_1364_1390_M(!node.WasCompilerGenerated)||(DynAbs.Tracing.TraceSender.Expression_False(10523, 1364, 1614)||                 ((DynAbs.Tracing.TraceSender.Conditional_F1(10523, 1413, 1439)||((f_10523_1413_1431(node)!= null &&DynAbs.Tracing.TraceSender.Conditional_F2(10523, 1467, 1499))||DynAbs.Tracing.TraceSender.Conditional_F3(10523, 1527, 1613)))?f_10523_1467_1499():                        (f_10523_1528_1546(node.Syntax)== SyntaxKind.Block &&(DynAbs.Tracing.TraceSender.Expression_True(10523, 1528, 1612)&&f_10523_1570_1603_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10523_1570_1594(_factory), 10523, 1570, 1603)?.IsAsync)== false)))))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10523,1323,1733);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10523,1649,1718);

rewritten = f_10523_1661_1717(_instrumenter, node, rewritten);
DynAbs.Tracing.TraceSender.TraceExitCondition(10523,1323,1733);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10523,1749,1766);

return rewritten;
DynAbs.Tracing.TraceSender.TraceExitMethod(10523,445,1777);

bool
f_10523_1327_1342(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10523, 1327, 1342);
return return_v;
}


bool
f_10523_1364_1390_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10523, 1364, 1390);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10523_1413_1431(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
this_param)
{
var return_v = this_param.ExpressionOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10523, 1413, 1431);
return return_v;
}


bool
f_10523_1467_1499()
{
var return_v = IsLambdaOrExpressionBodiedMember;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10523, 1467, 1499);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10523_1528_1546(Microsoft.CodeAnalysis.SyntaxNode
node)
{
var return_v = node.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10523, 1528, 1546);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10523_1570_1594(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.CurrentFunction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10523, 1570, 1594);
return return_v;
}


bool?
f_10523_1570_1603_M(bool?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10523, 1570, 1603);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10523_1661_1717(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
original,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewritten)
{
var return_v = this_param.InstrumentReturnStatement( original, rewritten);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10523, 1661, 1717);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10523,445,1777);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10523,445,1777);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool IsLambdaOrExpressionBodiedMember
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10523,1859,2434);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10523,1895,1933);

var 
method = f_10523_1908_1932(_factory)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10523,1951,2050) || true) && (method is LambdaSymbol)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10523,1951,2050);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10523,2019,2031);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10523,1951,2050);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10523,2097,2114);

var 
temp = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10523,2132,2389) || true) && (method is SourceMemberMethodSymbol)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10523,2132,2389);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10523,2193,2254);

temp = f_10523_2200_2253(((SourceMemberMethodSymbol)method));
DynAbs.Tracing.TraceSender.TraceExitCondition(10523,2132,2389);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10523,2132,2389);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10523,2277,2389) || true) && (method is LocalFunctionSymbol)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10523,2277,2389);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10523,2333,2389);

temp = f_10523_2340_2388(((LocalFunctionSymbol)method));
DynAbs.Tracing.TraceSender.TraceExitCondition(10523,2277,2389);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10523,2132,2389);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10523,2407,2419);

return temp;
DynAbs.Tracing.TraceSender.TraceExitMethod(10523,1859,2434);

Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10523_1908_1932(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.CurrentFunction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10523, 1908, 1932);
return return_v;
}


bool
f_10523_2200_2253(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
this_param)
{
var return_v = this_param.IsExpressionBodied;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10523, 2200, 2253);
return return_v;
}


bool
f_10523_2340_2388(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
this_param)
{
var return_v = this_param.IsExpressionBodied;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10523, 2340, 2388);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10523,1789,2445);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10523,1789,2445);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}
}
}
