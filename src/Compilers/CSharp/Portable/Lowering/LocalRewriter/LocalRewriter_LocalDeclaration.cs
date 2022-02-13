// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode? VisitLocalDeclaration(BoundLocalDeclaration node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10510,461,695);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10510,562,684);

return f_10510_569_683(this, node, node.Syntax, f_10510_612_628(node), f_10510_630_666(this, f_10510_646_665(node)), f_10510_668_682(node));
DynAbs.Tracing.TraceSender.TraceExitMethod(10510,461,695);

Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10510_612_628(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10510, 612, 628);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10510_646_665(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
this_param)
{
var return_v = this_param.InitializerOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10510, 646, 665);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10510_630_666(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression?
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10510, 630, 666);
return return_v;
}


bool
f_10510_668_682(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
this_param)
{
var return_v = this_param.HasErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10510, 668, 682);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10510_569_683(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
originalOpt,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
localSymbol,Microsoft.CodeAnalysis.CSharp.BoundExpression?
rewrittenInitializer,bool
hasErrors)
{
var return_v = this_param.RewriteLocalDeclaration( originalOpt, syntax, localSymbol, rewrittenInitializer, hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10510, 569, 683);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10510,461,695);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10510,461,695);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement? RewriteLocalDeclaration(BoundLocalDeclaration? originalOpt, SyntaxNode syntax, LocalSymbol localSymbol, BoundExpression? rewrittenInitializer, bool hasErrors = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10510,707,3215);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10510,1201,1294) || true) && (rewrittenInitializer == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10510,1201,1294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10510,1267,1279);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10510,1201,1294);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10510,1734,2139) || true) && (f_10510_1738_1757(localSymbol))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10510,1734,2139);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10510,1791,2124) || true) && (f_10510_1795_1828_M(!f_10510_1796_1812(localSymbol).IsReferenceType)&&(DynAbs.Tracing.TraceSender.Expression_True(10510, 1795, 1865)&&f_10510_1832_1857(localSymbol)== null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10510,1791,2124);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10510,1994,2011);

hasErrors = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10510,1791,2124);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10510,1791,2124);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10510,2093,2105);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10510,1791,2124);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10510,1734,2139);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10510,2338,2403);

var 
localDeclaration = syntax as LocalDeclarationStatementSyntax
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10510,2417,2545) || true) && (localDeclaration != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10510,2417,2545);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10510,2479,2530);

syntax = f_10510_2488_2526(f_10510_2488_2516(localDeclaration))[0];
DynAbs.Tracing.TraceSender.TraceExitCondition(10510,2417,2545);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10510,2561,3090);

BoundStatement 
rewrittenLocalDeclaration = f_10510_2604_3089(syntax, f_10510_2676_3060(syntax, f_10510_2755_2937(syntax, localSymbol, null, f_10510_2898_2914(localSymbol)), rewrittenInitializer, f_10510_3003_3019(localSymbol), f_10510_3042_3059(localSymbol)), hasErrors)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10510,3106,3204);

return f_10510_3113_3203(this, originalOpt, localSymbol, rewrittenLocalDeclaration);
DynAbs.Tracing.TraceSender.TraceExitMethod(10510,707,3215);

bool
f_10510_1738_1757(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.IsConst;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10510, 1738, 1757);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10510_1796_1812(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10510, 1796, 1812);
return return_v;
}


bool
f_10510_1795_1828_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10510, 1795, 1828);
return return_v;
}


object
f_10510_1832_1857(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10510, 1832, 1857);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
f_10510_2488_2516(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
this_param)
{
var return_v = this_param.Declaration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10510, 2488, 2516);
return return_v;
}


Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
f_10510_2488_2526(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
this_param)
{
var return_v = this_param.Variables;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10510, 2488, 2526);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10510_2898_2914(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.Type
;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10510, 2898, 2914);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10510_2755_2937(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
localSymbol,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLocal( syntax, localSymbol, constantValueOpt, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10510, 2755, 2937);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10510_3003_3019(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10510, 3003, 3019);
return return_v;
}


bool
f_10510_3042_3059(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.IsRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10510, 3042, 3059);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
f_10510_2676_3060(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
left,Microsoft.CodeAnalysis.CSharp.BoundExpression
right,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,bool
isRef)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right, type, isRef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10510, 2676, 3060);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10510_2604_3089(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
expression,bool
hasErrors)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10510, 2604, 3089);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10510_3113_3203(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration?
originalOpt,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
localSymbol,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenLocalDeclaration)
{
var return_v = this_param.InstrumentLocalDeclarationIfNecessary( originalOpt, localSymbol, rewrittenLocalDeclaration);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10510, 3113, 3203);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10510,707,3215);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10510,707,3215);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement InstrumentLocalDeclarationIfNecessary(BoundLocalDeclaration? originalOpt, LocalSymbol localSymbol, BoundStatement rewrittenLocalDeclaration)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10510,3227,4064);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10510,3466,4004) || true) && (f_10510_3470_3485(this)&&(DynAbs.Tracing.TraceSender.Expression_True(10510, 3470, 3531)&&f_10510_3489_3522_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(originalOpt, 10510, 3489, 3522)?.WasCompilerGenerated)== false )&&(DynAbs.Tracing.TraceSender.Expression_True(10510, 3470, 3555)&&f_10510_3535_3555_M(!localSymbol.IsConst))&&(DynAbs.Tracing.TraceSender.Expression_True(10510, 3470, 3843)&&                (f_10510_3577_3602(originalOpt.Syntax)== SyntaxKind.VariableDeclarator ||(DynAbs.Tracing.TraceSender.Expression_False(10510, 3577, 3842)||                    (f_10510_3661_3686(originalOpt.Syntax)== SyntaxKind.LocalDeclarationStatement &&(DynAbs.Tracing.TraceSender.Expression_True(10510, 3661, 3841)&&f_10510_3755_3820(((LocalDeclarationStatementSyntax)originalOpt.Syntax)).Variables.Count == 1))))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10510,3466,4004);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10510,3877,3989);

rewrittenLocalDeclaration = f_10510_3905_3988(_instrumenter, originalOpt, rewrittenLocalDeclaration);
DynAbs.Tracing.TraceSender.TraceExitCondition(10510,3466,4004);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10510,4020,4053);

return rewrittenLocalDeclaration;
DynAbs.Tracing.TraceSender.TraceExitMethod(10510,3227,4064);

bool
f_10510_3470_3485(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10510, 3470, 3485);
return return_v;
}


bool?
f_10510_3489_3522_M(bool?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10510, 3489, 3522);
return return_v;
}


bool
f_10510_3535_3555_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10510, 3535, 3555);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10510_3577_3602(Microsoft.CodeAnalysis.SyntaxNode
node)
{
var return_v = node.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10510, 3577, 3602);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10510_3661_3686(Microsoft.CodeAnalysis.SyntaxNode
node)
{
var return_v = node.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10510, 3661, 3686);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
f_10510_3755_3820(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
this_param)
{
var return_v = this_param.Declaration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10510, 3755, 3820);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10510_3905_3988(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
original,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewritten)
{
var return_v = this_param.InstrumentLocalInitialization( original, rewritten);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10510, 3905, 3988);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10510,3227,4064);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10510,3227,4064);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public sealed override BoundNode VisitOutVariablePendingInference(OutVariablePendingInference node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10510,4076,4248);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10510,4200,4237);

throw f_10510_4206_4236();
DynAbs.Tracing.TraceSender.TraceExitMethod(10510,4076,4248);

System.Exception
f_10510_4206_4236()
{
var return_v = ExceptionUtilities.Unreachable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10510, 4206, 4236);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10510,4076,4248);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10510,4076,4248);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
