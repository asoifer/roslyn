// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode? VisitMultipleLocalDeclarations(BoundMultipleLocalDeclarations node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10512,490,668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10512,609,657);

return f_10512_616_656(this, node);
DynAbs.Tracing.TraceSender.TraceExitMethod(10512,490,668);

Microsoft.CodeAnalysis.CSharp.BoundNode?
f_10512_616_656(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations
node)
{
var return_v = this_param.VisitMultipleLocalDeclarationsBase( (Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarationsBase)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10512, 616, 656);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10512,490,668);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10512,490,668);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override BoundNode? VisitUsingLocalDeclarations(BoundUsingLocalDeclarations node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10512,680,852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10512,793,841);

return f_10512_800_840(this, node);
DynAbs.Tracing.TraceSender.TraceExitMethod(10512,680,852);

Microsoft.CodeAnalysis.CSharp.BoundNode?
f_10512_800_840(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundUsingLocalDeclarations
node)
{
var return_v = this_param.VisitMultipleLocalDeclarationsBase( (Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarationsBase)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10512, 800, 840);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10512,680,852);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10512,680,852);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundNode? VisitMultipleLocalDeclarationsBase(BoundMultipleLocalDeclarationsBase node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10512,864,1821);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10512,983,1026);

ArrayBuilder<BoundStatement>? 
inits = null
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10512,1042,1467);
foreach(var decl in f_10512_1063_1085_I(f_10512_1063_1085(node)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10512,1042,1467);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10512,1119,1158);

var 
init = f_10512_1130_1157(this, decl)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10512,1178,1452) || true) && (init != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10512,1178,1452);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10512,1236,1377) || true) && (inits == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10512,1236,1377);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10512,1303,1354);

inits = f_10512_1311_1353();
DynAbs.Tracing.TraceSender.TraceExitCondition(10512,1236,1377);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10512,1401,1433);

f_10512_1401_1432(
                    inits, init);
DynAbs.Tracing.TraceSender.TraceExitCondition(10512,1178,1452);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10512,1042,1467);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10512,1,426);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10512,1,426);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10512,1483,1810) || true) && (inits != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10512,1483,1810);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10512,1534,1629);

return f_10512_1541_1628(node.Syntax, f_10512_1585_1599(node), f_10512_1601_1627(inits));
DynAbs.Tracing.TraceSender.TraceExitCondition(10512,1483,1810);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10512,1483,1810);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10512,1731,1743);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10512,1483,1810);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10512,864,1821);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration>
f_10512_1063_1085(Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarationsBase
this_param)
{
var return_v = this_param.LocalDeclarations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10512, 1063, 1085);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundNode?
f_10512_1130_1157(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
node)
{
var return_v = this_param.VisitLocalDeclaration( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10512, 1130, 1157);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10512_1311_1353()
{
var return_v = ArrayBuilder<BoundStatement>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10512, 1311, 1353);
return return_v;
}


int
f_10512_1401_1432(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param,Microsoft.CodeAnalysis.CSharp.BoundNode
item)
{
this_param.Add( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10512, 1401, 1432);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration>
f_10512_1063_1085_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10512, 1063, 1085);
return return_v;
}


bool
f_10512_1585_1599(Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarationsBase
this_param)
{
var return_v = this_param.HasErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10512, 1585, 1599);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10512_1601_1627(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10512, 1601, 1627);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatementList
f_10512_1541_1628(Microsoft.CodeAnalysis.SyntaxNode
syntax,bool
hasErrors,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = BoundStatementList.Synthesized( syntax, hasErrors, statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10512, 1541, 1628);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10512,864,1821);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10512,864,1821);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
