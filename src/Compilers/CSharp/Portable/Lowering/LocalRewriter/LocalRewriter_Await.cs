// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitAwaitExpression(BoundAwaitExpression node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10480,401,550);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10480,499,539);

return f_10480_506_538(this, node, true);
DynAbs.Tracing.TraceSender.TraceExitMethod(10480,401,550);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10480_506_538(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
node,bool
used)
{
var return_v = this_param.VisitAwaitExpression( node, used);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10480, 506, 538);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10480,401,550);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10480,401,550);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public BoundExpression VisitAwaitExpression(BoundAwaitExpression node, bool used)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10480,562,766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10480,668,755);

return f_10480_675_754(this, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitAwaitExpression(node),10480,715,746)!, used);
DynAbs.Tracing.TraceSender.TraceExitMethod(10480,562,766);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10480_675_754(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundNode
rewrittenAwait,bool
used)
{
var return_v = this_param.RewriteAwaitExpression( (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenAwait, used);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10480, 675, 754);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10480,562,766);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10480,562,766);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression RewriteAwaitExpression(SyntaxNode syntax, BoundExpression rewrittenExpression, BoundAwaitableInfo awaitableInfo, TypeSymbol type, bool used)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10480,778,1122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10480,967,1111);

return f_10480_974_1110(this, new BoundAwaitExpression(syntax, rewrittenExpression, awaitableInfo, type) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true,10480,997,1103) }, used);
DynAbs.Tracing.TraceSender.TraceExitMethod(10480,778,1122);

Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10480_974_1110(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
rewrittenAwait,bool
used)
{
var return_v = this_param.RewriteAwaitExpression( (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenAwait, used);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10480, 974, 1110);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10480,778,1122);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10480,778,1122);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression RewriteAwaitExpression(BoundExpression rewrittenAwait, bool used)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10480,1267,2817);
Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator tempAssignment = default(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10480,1381,1398);

_sawAwait = true;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10480,1412,1564) || true) && (!used)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10480,1412,1564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10480,1527,1549);

return rewrittenAwait;
DynAbs.Tracing.TraceSender.TraceExitCondition(10480,1412,1564);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10480,2247,2269);

_needsSpilling = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10480,2283,2466);

var 
tempAccess = f_10480_2300_2465(_factory, rewrittenAwait, out tempAssignment, syntaxOpt: rewrittenAwait.Syntax, kind: SynthesizedLocalKind.Spill)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10480,2480,2806);

return f_10480_2487_2805(syntax: rewrittenAwait.Syntax, locals: f_10480_2584_2642(f_10480_2619_2641(tempAccess)), sideEffects: f_10480_2674_2728(tempAssignment), value: tempAccess, type: f_10480_2789_2804(tempAccess));
DynAbs.Tracing.TraceSender.TraceExitMethod(10480,1267,2817);

Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10480_2300_2465(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store,Microsoft.CodeAnalysis.SyntaxNode
syntaxOpt,Microsoft.CodeAnalysis.SynthesizedLocalKind
kind)
{
var return_v = this_param.StoreToTemp( argument, out store, syntaxOpt: syntaxOpt, kind: kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10480, 2300, 2465);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10480_2619_2641(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10480, 2619, 2641);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10480_2584_2642(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
var return_v = ImmutableArray.Create<LocalSymbol>( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10480, 2584, 2642);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10480_2674_2728(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
item)
{
var return_v = ImmutableArray.Create<BoundExpression>( (Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10480, 2674, 2728);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10480_2789_2804(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10480, 2789, 2804);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundSpillSequence
f_10480_2487_2805(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
sideEffects,Microsoft.CodeAnalysis.CSharp.BoundLocal
value,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSpillSequence( syntax: syntax, locals: locals, sideEffects: sideEffects, value: (Microsoft.CodeAnalysis.CSharp.BoundExpression)value, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10480, 2487, 2805);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10480,1267,2817);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10480,1267,2817);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
