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
public override BoundNode VisitYieldBreakStatement(BoundYieldBreakStatement node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10535,445,1299);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10535,551,617);

var 
result = (BoundStatement)DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitYieldBreakStatement(node),10535,580,615)!
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10535,984,1258) || true) && (f_10535_988_1003(this)&&(DynAbs.Tracing.TraceSender.Expression_True(10535, 988, 1142)&&                (f_10535_1025_1051_M(!node.WasCompilerGenerated)||(DynAbs.Tracing.TraceSender.Expression_False(10535, 1025, 1141)||(f_10535_1056_1074(node.Syntax)== SyntaxKind.Block &&(DynAbs.Tracing.TraceSender.Expression_True(10535, 1056, 1140)&&f_10535_1098_1131_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10535_1098_1122(_factory), 10535, 1098, 1131)?.IsAsync)== false))))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10535,984,1258);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10535,1176,1243);

result = f_10535_1185_1242(_instrumenter, node, result);
DynAbs.Tracing.TraceSender.TraceExitCondition(10535,984,1258);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10535,1274,1288);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10535,445,1299);

bool
f_10535_988_1003(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10535, 988, 1003);
return return_v;
}


bool
f_10535_1025_1051_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10535, 1025, 1051);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10535_1056_1074(Microsoft.CodeAnalysis.SyntaxNode
node)
{
var return_v = node.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10535, 1056, 1074);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10535_1098_1122(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param)
{
var return_v = this_param.CurrentFunction;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10535, 1098, 1122);
return return_v;
}


bool?
f_10535_1098_1131_M(bool?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10535, 1098, 1131);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10535_1185_1242(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundYieldBreakStatement
original,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewritten)
{
var return_v = this_param.InstrumentYieldBreakStatement( original, rewritten);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10535, 1185, 1242);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10535,445,1299);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10535,445,1299);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode VisitYieldReturnStatement(BoundYieldReturnStatement node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10535,1311,1707);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10535,1419,1486);

var 
result = (BoundStatement)DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitYieldReturnStatement(node),10535,1448,1484)!
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10535,1500,1666) || true) && (f_10535_1504_1519(this)&&(DynAbs.Tracing.TraceSender.Expression_True(10535, 1504, 1549)&&f_10535_1523_1549_M(!node.WasCompilerGenerated)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10535,1500,1666);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10535,1583,1651);

result = f_10535_1592_1650(_instrumenter, node, result);
DynAbs.Tracing.TraceSender.TraceExitCondition(10535,1500,1666);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10535,1682,1696);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(10535,1311,1707);

bool
f_10535_1504_1519(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10535, 1504, 1519);
return return_v;
}


bool
f_10535_1523_1549_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10535, 1523, 1549);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10535_1592_1650(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundYieldReturnStatement
original,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewritten)
{
var return_v = this_param.InstrumentYieldReturnStatement( original, rewritten);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10535, 1592, 1650);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10535,1311,1707);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10535,1311,1707);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
