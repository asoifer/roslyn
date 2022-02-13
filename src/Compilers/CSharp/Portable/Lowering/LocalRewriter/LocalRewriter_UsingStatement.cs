// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp
{
internal sealed partial class LocalRewriter
{
public override BoundNode VisitUsingStatement(BoundUsingStatement node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10533,1560,2976);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,1656,1714);

BoundStatement? 
rewrittenBody = f_10533_1688_1713(this, f_10533_1703_1712(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,1728,1763);

f_10533_1728_1762(rewrittenBody is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,1779,1962);

BoundBlock 
tryBlock = (DynAbs.Tracing.TraceSender.Conditional_F1(10533, 1801, 1838)||((f_10533_1801_1819(rewrittenBody)== BoundKind.Block
&&DynAbs.Tracing.TraceSender.Conditional_F2(10533, 1858, 1883))||DynAbs.Tracing.TraceSender.Conditional_F3(10533, 1903, 1961)))?(BoundBlock)rewrittenBody
:f_10533_1903_1961(node.Syntax, rewrittenBody)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,1978,2965) || true) && (f_10533_1982_2000(node)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,1978,2965);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,2042,2094);

return f_10533_2049_2093(this, node, tryBlock);
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,1978,2965);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,1978,2965);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,2160,2202);

f_10533_2160_2201(f_10533_2173_2193(node)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,2220,2356);

SyntaxToken 
awaitKeyword = (DynAbs.Tracing.TraceSender.Conditional_F1(10533, 2247, 2294)||((f_10533_2247_2265(node.Syntax)== SyntaxKind.UsingStatement &&DynAbs.Tracing.TraceSender.Conditional_F2(10533, 2297, 2345))||DynAbs.Tracing.TraceSender.Conditional_F3(10533, 2348, 2355)))?f_10533_2297_2345(((UsingStatementSyntax)node.Syntax)):default
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,2374,2950);

return f_10533_2381_2949(this, node.Syntax, tryBlock, f_10533_2542_2553(node), f_10533_2609_2647(f_10533_2609_2629(node)), f_10533_2703_2729(node), f_10533_2785_2811(node), f_10533_2867_2880(node), awaitKeyword);
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,1978,2965);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10533,1560,2976);

Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10533_1703_1712(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 1703, 1712);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10533_1688_1713(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundStatement
node)
{
var return_v = this_param.VisitStatement( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 1688, 1713);
return return_v;
}


int
f_10533_1728_1762(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 1728, 1762);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10533_1801_1819(Microsoft.CodeAnalysis.CSharp.BoundStatement
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 1801, 1819);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10533_1903_1961(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundStatement
statement)
{
var return_v = BoundBlock.SynthesizedNoLocals( syntax, statement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 1903, 1961);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10533_1982_2000(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
this_param)
{
var return_v = this_param.ExpressionOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 1982, 2000);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10533_2049_2093(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
node,Microsoft.CodeAnalysis.CSharp.BoundBlock
tryBlock)
{
var return_v = this_param.MakeExpressionUsingStatement( node, tryBlock);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 2049, 2093);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations?
f_10533_2173_2193(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
this_param)
{
var return_v = this_param.DeclarationsOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 2173, 2193);
return return_v;
}


int
f_10533_2160_2201(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 2160, 2201);
return 0;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10533_2247_2265(Microsoft.CodeAnalysis.SyntaxNode
node)
{
var return_v = node.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 2247, 2265);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxToken
f_10533_2297_2345(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
this_param)
{
var return_v = this_param.AwaitKeyword ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 2297, 2345);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10533_2542_2553(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
this_param)
{
var return_v = this_param.Locals;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 2542, 2553);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations
f_10533_2609_2629(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
this_param)
{
var return_v = this_param.DeclarationsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 2609, 2629);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration>
f_10533_2609_2647(Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations
this_param)
{
var return_v = this_param.LocalDeclarations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 2609, 2647);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10533_2703_2729(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
this_param)
{
var return_v = this_param.IDisposableConversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 2703, 2729);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo?
f_10533_2785_2811(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
this_param)
{
var return_v = this_param.PatternDisposeInfoOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 2785, 2811);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
f_10533_2867_2880(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
this_param)
{
var return_v = this_param.AwaitOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 2867, 2880);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10533_2381_2949(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundBlock
body,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration>
declarations,Microsoft.CodeAnalysis.CSharp.Conversion
iDisposableConversion,Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo?
patternDisposeInfo,Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
awaitOpt,Microsoft.CodeAnalysis.SyntaxToken
awaitKeyword)
{
var return_v = this_param.MakeDeclarationUsingStatement( syntax, body, locals, declarations, iDisposableConversion, patternDisposeInfo, awaitOpt, awaitKeyword);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 2381, 2949);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10533,1560,2976);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10533,1560,2976);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement MakeDeclarationUsingStatement(SyntaxNode syntax,
                                                       BoundBlock body,
                                                       ImmutableArray<LocalSymbol> locals,
                                                       ImmutableArray<BoundLocalDeclaration> declarations,
                                                       Conversion iDisposableConversion,
                                                       MethodArgumentInfo? patternDisposeInfo,
                                                       BoundAwaitableInfo? awaitOpt,
                                                       SyntaxToken awaitKeyword)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10533,2988,4434);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,3711,3746);

f_10533_3711_3745(declarations != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,3762,3787);

BoundBlock 
result = body
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,3810,3837);
            for (int 
i = declarations.Length - 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,3801,4078) || true) && (i >= 0)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,3847,3850)
,i--,DynAbs.Tracing.TraceSender.TraceExitCondition(10533,3801,4078)) //NB: inner-to-outer = right-to-left

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,3801,4078);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,3921,4063);

result = f_10533_3930_4062(this, syntax, declarations[i], result, iDisposableConversion, awaitKeyword, awaitOpt, patternDisposeInfo);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10533,1,278);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10533,1,278);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,4286,4423);

return f_10533_4293_4422(syntax, locals, f_10533_4376_4421(result));
DynAbs.Tracing.TraceSender.TraceExitMethod(10533,2988,4434);

int
f_10533_3711_3745(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 3711, 3745);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10533_3930_4062(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
usingSyntax,Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
localDeclaration,Microsoft.CodeAnalysis.CSharp.BoundBlock
tryBlock,Microsoft.CodeAnalysis.CSharp.Conversion
iDisposableConversion,Microsoft.CodeAnalysis.SyntaxToken
awaitKeywordOpt,Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
awaitOpt,Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo?
patternDisposeInfo)
{
var return_v = this_param.RewriteDeclarationUsingStatement( usingSyntax, localDeclaration, tryBlock, iDisposableConversion, awaitKeywordOpt, awaitOpt, patternDisposeInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 3930, 4062);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10533_4376_4421(Microsoft.CodeAnalysis.CSharp.BoundBlock
item)
{
var return_v = ImmutableArray.Create<BoundStatement>( (Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 4376, 4421);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10533_4293_4422(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock( syntax, locals, statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 4293, 4422);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10533,2988,4434);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10533,2988,4434);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement MakeLocalUsingDeclarationStatement(BoundUsingLocalDeclarations usingDeclarations, ImmutableArray<BoundStatement> statements)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10533,4573,5751);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,4745,4844);

LocalDeclarationStatementSyntax 
syntax = (LocalDeclarationStatementSyntax)usingDeclarations.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,4858,4946);

BoundBlock 
body = f_10533_4876_4945(syntax, ImmutableArray<LocalSymbol>.Empty, statements)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,4962,5702);

var 
usingStatement = f_10533_4983_5701(this, syntax, body, ImmutableArray<LocalSymbol>.Empty, f_10533_5254_5289(usingDeclarations), f_10533_5355_5394(usingDeclarations), f_10533_5460_5499(usingDeclarations), awaitOpt: f_10533_5575_5601(usingDeclarations), awaitKeyword: f_10533_5681_5700(syntax))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,5718,5740);

return usingStatement;
DynAbs.Tracing.TraceSender.TraceExitMethod(10533,4573,5751);

Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10533_4876_4945(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock( (Microsoft.CodeAnalysis.SyntaxNode)syntax, locals, statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 4876, 4945);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration>
f_10533_5254_5289(Microsoft.CodeAnalysis.CSharp.BoundUsingLocalDeclarations
this_param)
{
var return_v = this_param.LocalDeclarations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 5254, 5289);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10533_5355_5394(Microsoft.CodeAnalysis.CSharp.BoundUsingLocalDeclarations
this_param)
{
var return_v = this_param.IDisposableConversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 5355, 5394);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo?
f_10533_5460_5499(Microsoft.CodeAnalysis.CSharp.BoundUsingLocalDeclarations
this_param)
{
var return_v = this_param.PatternDisposeInfoOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 5460, 5499);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
f_10533_5575_5601(Microsoft.CodeAnalysis.CSharp.BoundUsingLocalDeclarations
this_param)
{
var return_v = this_param.AwaitOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 5575, 5601);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxToken
f_10533_5681_5700(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
this_param)
{
var return_v = this_param.AwaitKeyword;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 5681, 5700);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10533_4983_5701(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundBlock
body,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration>
declarations,Microsoft.CodeAnalysis.CSharp.Conversion
iDisposableConversion,Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo?
patternDisposeInfo,Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
awaitOpt,Microsoft.CodeAnalysis.SyntaxToken
awaitKeyword)
{
var return_v = this_param.MakeDeclarationUsingStatement( (Microsoft.CodeAnalysis.SyntaxNode)syntax, body, locals, declarations, iDisposableConversion, patternDisposeInfo, awaitOpt: awaitOpt, awaitKeyword: awaitKeyword);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 4983, 5701);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10533,4573,5751);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10533,4573,5751);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundBlock MakeExpressionUsingStatement(BoundUsingStatement node, BoundBlock tryBlock)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10533,5892,10505);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,6011,6052);

f_10533_6011_6051(f_10533_6024_6042(node)!= null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,6066,6109);

f_10533_6066_6108(f_10533_6079_6099(node)== null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,7011,7085);

BoundExpression 
rewrittenExpression = f_10533_7049_7084(this, f_10533_7065_7083(node))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,7099,7356) || true) && (f_10533_7103_7136(rewrittenExpression)== f_10533_7140_7158())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,7099,7356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,7192,7226);

f_10533_7192_7225(node.Locals.IsEmpty);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,7325,7341);

return tryBlock;
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,7099,7356);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,8109,8155);

f_10533_8109_8154(f_10533_8122_8146(rewrittenExpression)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,8169,8222);

TypeSymbol 
expressionType = f_10533_8197_8221(rewrittenExpression)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,8236,8293);

SyntaxNode 
expressionSyntax = rewrittenExpression.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,8307,8376);

UsingStatementSyntax 
usingSyntax = (UsingStatementSyntax)node.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,8392,8431);

BoundAssignmentOperator 
tempAssignment
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,8445,8466);

BoundLocal 
boundTemp
=default(BoundLocal);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,8480,9708) || true) && (expressionType is null ||(DynAbs.Tracing.TraceSender.Expression_False(10533, 8484, 8536)||f_10533_8510_8536(expressionType)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,8480,9708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,8721,8947);

TypeSymbol 
iDisposableType = (DynAbs.Tracing.TraceSender.Conditional_F1(10533, 8750, 8771)||((f_10533_8750_8763(node)is null &&DynAbs.Tracing.TraceSender.Conditional_F2(10533, 8795, 8854))||DynAbs.Tracing.TraceSender.Conditional_F3(10533, 8878, 8946)))?f_10533_8795_8854(                    _compilation, SpecialType.System_IDisposable):f_10533_8878_8946(                    _compilation, WellKnownType.System_IAsyncDisposable)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,8967,9332);

BoundExpression 
tempInit = f_10533_8994_9331(this, expressionSyntax, rewrittenExpression, Conversion.GetTrivialConversion(node.IDisposableConversion.Kind), iDisposableType, @checked: false, constantValueOpt: f_10533_9297_9330(rewrittenExpression))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,9352,9449);

boundTemp = f_10533_9364_9448(_factory, tempInit, out tempAssignment, kind: SynthesizedLocalKind.Using);
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,8480,9708);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,8480,9708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,9561,9693);

boundTemp = f_10533_9573_9692(_factory, rewrittenExpression, out tempAssignment, syntaxOpt: usingSyntax, kind: SynthesizedLocalKind.Using);
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,8480,9708);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,9724,9824);

BoundStatement 
expressionStatement = f_10533_9761_9823(expressionSyntax, tempAssignment)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,9838,9998) || true) && (f_10533_9842_9857(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,9838,9998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,9891,9983);

expressionStatement = f_10533_9913_9982(_instrumenter, node, expressionStatement);
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,9838,9998);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,10014,10177);

BoundStatement 
tryFinally = f_10533_10042_10176(this, usingSyntax, tryBlock, boundTemp, f_10533_10108_10132(usingSyntax), f_10533_10134_10147(node), f_10533_10149_10175(node))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,10267,10494);

return f_10533_10274_10493(syntax: usingSyntax, locals: node.Locals.Add(f_10533_10369_10390(boundTemp)), statements: f_10533_10422_10492(expressionStatement, tryFinally));
DynAbs.Tracing.TraceSender.TraceExitMethod(10533,5892,10505);

Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10533_6024_6042(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
this_param)
{
var return_v = this_param.ExpressionOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 6024, 6042);
return return_v;
}


int
f_10533_6011_6051(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 6011, 6051);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations?
f_10533_6079_6099(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
this_param)
{
var return_v = this_param.DeclarationsOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 6079, 6099);
return return_v;
}


int
f_10533_6066_6108(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 6066, 6108);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10533_7065_7083(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
this_param)
{
var return_v = this_param.ExpressionOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 7065, 7083);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10533_7049_7084(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = this_param.VisitExpression( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 7049, 7084);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10533_7103_7136(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 7103, 7136);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10533_7140_7158()
{
var return_v = ConstantValue.Null;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 7140, 7158);
return return_v;
}


int
f_10533_7192_7225(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 7192, 7225);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10533_8122_8146(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 8122, 8146);
return return_v;
}


int
f_10533_8109_8154(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 8109, 8154);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10533_8197_8221(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 8197, 8221);
return return_v;
}


bool
f_10533_8510_8536(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsDynamic();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 8510, 8536);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
f_10533_8750_8763(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
this_param)
{
var return_v = this_param.AwaitOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 8750, 8763);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10533_8795_8854(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 8795, 8854);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10533_8878_8946(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownType
type)
{
var return_v = this_param.GetWellKnownType( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 8878, 8946);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10533_9297_9330(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 9297, 9330);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10533_8994_9331(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt)
{
var return_v = this_param.MakeConversionNode( syntax, rewrittenOperand, conversion, rewrittenType, @checked: @checked, constantValueOpt: constantValueOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 8994, 9331);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10533_9364_9448(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store,Microsoft.CodeAnalysis.SynthesizedLocalKind
kind)
{
var return_v = this_param.StoreToTemp( argument, out store, kind: kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 9364, 9448);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10533_9573_9692(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store,Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
syntaxOpt,Microsoft.CodeAnalysis.SynthesizedLocalKind
kind)
{
var return_v = this_param.StoreToTemp( argument, out store, syntaxOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxOpt, kind: kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 9573, 9692);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10533_9761_9823(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
expression)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 9761, 9823);
return return_v;
}


bool
f_10533_9842_9857(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param)
{
var return_v = this_param.Instrument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 9842, 9857);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10533_9913_9982(Microsoft.CodeAnalysis.CSharp.Instrumenter
this_param,Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
original,Microsoft.CodeAnalysis.CSharp.BoundStatement
usingTargetCapture)
{
var return_v = this_param.InstrumentUsingTargetCapture( original, usingTargetCapture);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 9913, 9982);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxToken
f_10533_10108_10132(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
this_param)
{
var return_v = this_param.AwaitKeyword;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 10108, 10132);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
f_10533_10134_10147(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
this_param)
{
var return_v = this_param.AwaitOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 10134, 10147);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo?
f_10533_10149_10175(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
this_param)
{
var return_v = this_param.PatternDisposeInfoOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 10149, 10175);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10533_10042_10176(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
syntax,Microsoft.CodeAnalysis.CSharp.BoundBlock
tryBlock,Microsoft.CodeAnalysis.CSharp.BoundLocal
local,Microsoft.CodeAnalysis.SyntaxToken
awaitKeywordOpt,Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
awaitOpt,Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo?
patternDisposeInfo)
{
var return_v = this_param.RewriteUsingStatementTryFinally( (Microsoft.CodeAnalysis.SyntaxNode)syntax, tryBlock, local, awaitKeywordOpt, awaitOpt, patternDisposeInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 10042, 10176);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10533_10369_10390(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 10369, 10390);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10533_10422_10492(Microsoft.CodeAnalysis.CSharp.BoundStatement
item1,Microsoft.CodeAnalysis.CSharp.BoundStatement
item2)
{
var return_v = ImmutableArray.Create<BoundStatement>( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 10422, 10492);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10533_10274_10493(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock( syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, locals: locals, statements: statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 10274, 10493);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10533,5892,10505);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10533,5892,10505);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundBlock RewriteDeclarationUsingStatement(
            SyntaxNode usingSyntax,
            BoundLocalDeclaration localDeclaration,
            BoundBlock tryBlock,
            Conversion iDisposableConversion,
            SyntaxToken awaitKeywordOpt,
            BoundAwaitableInfo? awaitOpt,
            MethodArgumentInfo? patternDisposeInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10533,10953,14420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,11339,11392);

f_10533_11339_11391(f_10533_11352_11383(localDeclaration)is { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,11406,11461);

SyntaxNode 
declarationSyntax = localDeclaration.Syntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,11477,11532);

LocalSymbol 
localSymbol = f_10533_11503_11531(localDeclaration)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,11546,11586);

TypeSymbol 
localType = f_10533_11569_11585(localSymbol)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,11600,11640);

f_10533_11600_11639((object)localType != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,11715,11844);

BoundLocal 
boundLocal = f_10533_11739_11843(declarationSyntax, localSymbol, f_10533_11786_11831(f_10533_11786_11817(localDeclaration)), localType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,11860,11932);

BoundStatement? 
rewrittenDeclaration = f_10533_11899_11931(this, localDeclaration)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,11946,11988);

f_10533_11946_11987(rewrittenDeclaration is { });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,12383,12635) || true) && (f_10533_12387_12411(boundLocal)== f_10533_12415_12433())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,12383,12635);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,12537,12620);

return f_10533_12544_12619(usingSyntax, rewrittenDeclaration, tryBlock);
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,12383,12635);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,12651,14409) || true) && (f_10533_12655_12676(localType))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,12651,14409);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,12710,12931);

TypeSymbol 
iDisposableType = (DynAbs.Tracing.TraceSender.Conditional_F1(10533, 12739, 12755)||((awaitOpt is null &&DynAbs.Tracing.TraceSender.Conditional_F2(10533, 12779, 12838))||DynAbs.Tracing.TraceSender.Conditional_F3(10533, 12862, 12930)))?f_10533_12779_12838(                    _compilation, SpecialType.System_IDisposable):f_10533_12862_12930(                    _compilation, WellKnownType.System_IAsyncDisposable)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,12951,13191);

BoundExpression 
tempInit = f_10533_12978_13190(this, declarationSyntax, boundLocal, iDisposableConversion, iDisposableType, @checked: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,13211,13250);

BoundAssignmentOperator 
tempAssignment
=default(BoundAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,13268,13376);

BoundLocal 
boundTemp = f_10533_13291_13375(_factory, tempInit, out tempAssignment, kind: SynthesizedLocalKind.Using)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,13396,13537);

BoundStatement 
tryFinally = f_10533_13424_13536(this, usingSyntax, tryBlock, boundTemp, awaitKeywordOpt, awaitOpt, patternDisposeInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,13557,14010);

return f_10533_13564_14009(syntax: usingSyntax, locals: f_10533_13651_13708(f_10533_13686_13707(boundTemp)), statements: f_10533_13796_14008(rewrittenDeclaration, f_10533_13907_13970(declarationSyntax, tempAssignment), tryFinally));
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,12651,14409);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,12651,14409);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,14076,14218);

BoundStatement 
tryFinally = f_10533_14104_14217(this, usingSyntax, tryBlock, boundLocal, awaitKeywordOpt, awaitOpt, patternDisposeInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,14309,14394);

return f_10533_14316_14393(usingSyntax, rewrittenDeclaration, tryFinally);
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,12651,14409);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10533,10953,14420);

Microsoft.CodeAnalysis.CSharp.BoundExpression?
f_10533_11352_11383(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
this_param)
{
var return_v = this_param.InitializerOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 11352, 11383);
return return_v;
}


int
f_10533_11339_11391(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 11339, 11391);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10533_11503_11531(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 11503, 11531);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10533_11569_11585(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 11569, 11585);
return return_v;
}


int
f_10533_11600_11639(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 11600, 11639);
return 0;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10533_11786_11817(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
this_param)
{
var return_v = this_param.InitializerOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 11786, 11817);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10533_11786_11831(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 11786, 11831);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10533_11739_11843(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
localSymbol,Microsoft.CodeAnalysis.ConstantValue?
constantValueOpt,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLocal( syntax, localSymbol, constantValueOpt, type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 11739, 11843);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement?
f_10533_11899_11931(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
node)
{
var return_v = this_param.VisitStatement( (Microsoft.CodeAnalysis.CSharp.BoundStatement)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 11899, 11931);
return return_v;
}


int
f_10533_11946_11987(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 11946, 11987);
return 0;
}


Microsoft.CodeAnalysis.ConstantValue?
f_10533_12387_12411(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 12387, 12411);
return return_v;
}


Microsoft.CodeAnalysis.ConstantValue
f_10533_12415_12433()
{
var return_v = ConstantValue.Null;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 12415, 12433);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10533_12544_12619(Microsoft.CodeAnalysis.SyntaxNode
syntax,params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
statements)
{
var return_v = BoundBlock.SynthesizedNoLocals( syntax, statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 12544, 12619);
return return_v;
}


bool
f_10533_12655_12676(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsDynamic();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 12655, 12676);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10533_12779_12838(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SpecialType
specialType)
{
var return_v = this_param.GetSpecialType( specialType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 12779, 12838);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10533_12862_12930(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownType
type)
{
var return_v = this_param.GetWellKnownType( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 12862, 12930);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10533_12978_13190(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
rewrittenOperand,Microsoft.CodeAnalysis.CSharp.Conversion
conversion,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
rewrittenType,bool
@checked)
{
var return_v = this_param.MakeConversionNode( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenOperand, conversion, rewrittenType, @checked: @checked);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 12978, 13190);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundLocal
f_10533_13291_13375(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
argument,out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
store,Microsoft.CodeAnalysis.SynthesizedLocalKind
kind)
{
var return_v = this_param.StoreToTemp( argument, out store, kind: kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 13291, 13375);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10533_13424_13536(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundBlock
tryBlock,Microsoft.CodeAnalysis.CSharp.BoundLocal
local,Microsoft.CodeAnalysis.SyntaxToken
awaitKeywordOpt,Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
awaitOpt,Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo?
patternDisposeInfo)
{
var return_v = this_param.RewriteUsingStatementTryFinally( syntax, tryBlock, local, awaitKeywordOpt, awaitOpt, patternDisposeInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 13424, 13536);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
f_10533_13686_13707(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.LocalSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 13686, 13707);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
f_10533_13651_13708(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
item)
{
var return_v = ImmutableArray.Create<LocalSymbol>( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 13651, 13708);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10533_13907_13970(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
expression)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 13907, 13970);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
f_10533_13796_14008(Microsoft.CodeAnalysis.CSharp.BoundStatement
item1,Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
item2,Microsoft.CodeAnalysis.CSharp.BoundStatement
item3)
{
var return_v = ImmutableArray.Create<BoundStatement>( item1, (Microsoft.CodeAnalysis.CSharp.BoundStatement)item2, item3);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 13796, 14008);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10533_13564_14009(Microsoft.CodeAnalysis.SyntaxNode
syntax,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
locals,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
statements)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock( syntax: syntax, locals: locals, statements: statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 13564, 14009);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10533_14104_14217(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundBlock
tryBlock,Microsoft.CodeAnalysis.CSharp.BoundLocal
local,Microsoft.CodeAnalysis.SyntaxToken
awaitKeywordOpt,Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
awaitOpt,Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo?
patternDisposeInfo)
{
var return_v = this_param.RewriteUsingStatementTryFinally( syntax, tryBlock, local, awaitKeywordOpt, awaitOpt, patternDisposeInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 14104, 14217);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10533_14316_14393(Microsoft.CodeAnalysis.SyntaxNode
syntax,params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
statements)
{
var return_v = BoundBlock.SynthesizedNoLocals( syntax, statements);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 14316, 14393);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10533,10953,14420);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10533,10953,14420);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundStatement RewriteUsingStatementTryFinally(
            SyntaxNode syntax,
            BoundBlock tryBlock,
            BoundLocal local,
            SyntaxToken awaitKeywordOpt,
            BoundAwaitableInfo? awaitOpt,
            MethodArgumentInfo? patternDisposeInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10533,14432,21454);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,18732,18797);

f_10533_18732_18796((awaitKeywordOpt == default) == (awaitOpt is null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,18811,18846);

BoundExpression 
disposedExpression
=default(BoundExpression);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,18860,18915);

bool 
isNullableValueType = f_10533_18887_18914(f_10533_18887_18897(local))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,18931,19391) || true) && (isNullableValueType)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,18931,19391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,18988,19116);

MethodSymbol 
getValueOrDefault = f_10533_19021_19115(this, syntax, f_10533_19053_19063(local), SpecialMember.System_Nullable_T_GetValueOrDefault)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,19180,19257);

disposedExpression = f_10533_19201_19256(syntax, local, getValueOrDefault);
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,18931,19391);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,18931,19391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,19349,19376);

disposedExpression = local;
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,18931,19391);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,19407,19532);

BoundExpression 
disposeCall = f_10533_19437_19531(this, syntax, disposedExpression, patternDisposeInfo, awaitOpt, awaitKeywordOpt)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,19598,19682);

BoundStatement 
disposeStatement = f_10533_19632_19681(syntax, disposeCall)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,19698,19727);

BoundExpression? 
ifCondition
=default(BoundExpression?);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,19743,20185) || true) && (isNullableValueType)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,19743,20185);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,19835,19885);

ifCondition = f_10533_19849_19884(this, syntax, local);
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,19743,20185);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,19743,20185);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,19919,20185) || true) && (f_10533_19923_19945(f_10533_19923_19933(local)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,19919,20185);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,19979,19998);

ifCondition = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,19919,20185);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,19919,20185);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,20098,20170);

ifCondition = f_10533_20112_20169(this, syntax, local, BinaryOperatorKind.NotEqual);
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,19919,20185);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,19743,20185);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,20201,20233);

BoundStatement 
finallyStatement
=default(BoundStatement);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,20249,20973) || true) && (ifCondition == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,20249,20973);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,20360,20396);

finallyStatement = disposeStatement;
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,20249,20973);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,20249,20973);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,20676,20958);

finallyStatement = f_10533_20695_20957(syntax: syntax, rewrittenCondition: ifCondition, rewrittenConsequence: disposeStatement, rewrittenAlternativeOpt: null, hasErrors: false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,20249,20973);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,21127,21409);

BoundStatement 
tryFinally = f_10533_21155_21408(syntax: syntax, tryBlock: tryBlock, catchBlocks: ImmutableArray<BoundCatchBlock>.Empty, finallyBlockOpt: f_10533_21351_21407(syntax, finallyStatement))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,21425,21443);

return tryFinally;
DynAbs.Tracing.TraceSender.TraceExitMethod(10533,14432,21454);

int
f_10533_18732_18796(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 18732, 18796);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10533_18887_18897(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 18887, 18897);
return return_v;
}


bool
f_10533_18887_18914(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsNullableType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 18887, 18914);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10533_19053_19063(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 19053, 19063);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10533_19021_19115(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
nullableType,Microsoft.CodeAnalysis.SpecialMember
member)
{
var return_v = this_param.UnsafeGetNullableMethod( syntax, nullableType, member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 19021, 19115);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundCall
f_10533_19201_19256(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
receiverOpt,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = BoundCall.Synthesized( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 19201, 19256);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10533_19437_19531(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
disposedExpression,Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo?
disposeInfo,Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
awaitOpt,Microsoft.CodeAnalysis.SyntaxToken
awaitKeyword)
{
var return_v = this_param.GenerateDisposeCall( syntax, disposedExpression, disposeInfo, awaitOpt, awaitKeyword);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 19437, 19531);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
f_10533_19632_19681(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement( syntax, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 19632, 19681);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10533_19849_19884(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
expression)
{
var return_v = this_param.MakeNullableHasValue( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 19849, 19884);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10533_19923_19933(Microsoft.CodeAnalysis.CSharp.BoundLocal
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 19923, 19933);
return return_v;
}


bool
f_10533_19923_19945(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.IsValueType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 19923, 19945);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10533_20112_20169(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundLocal
rewrittenExpr,Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
operatorKind)
{
var return_v = this_param.MakeNullCheck( syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenExpr, operatorKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 20112, 20169);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundStatement
f_10533_20695_20957(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenCondition,Microsoft.CodeAnalysis.CSharp.BoundStatement
rewrittenConsequence,Microsoft.CodeAnalysis.CSharp.BoundStatement?
rewrittenAlternativeOpt,bool
hasErrors)
{
var return_v = RewriteIfStatement( syntax: syntax, rewrittenCondition: rewrittenCondition, rewrittenConsequence: rewrittenConsequence, rewrittenAlternativeOpt: rewrittenAlternativeOpt, hasErrors: hasErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 20695, 20957);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBlock
f_10533_21351_21407(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundStatement
statement)
{
var return_v = BoundBlock.SynthesizedNoLocals( syntax, statement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 21351, 21407);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundTryStatement
f_10533_21155_21408(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundBlock
tryBlock,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
catchBlocks,Microsoft.CodeAnalysis.CSharp.BoundBlock
finallyBlockOpt)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTryStatement( syntax: syntax, tryBlock: tryBlock, catchBlocks: catchBlocks, finallyBlockOpt: finallyBlockOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 21155, 21408);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10533,14432,21454);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10533,14432,21454);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression GenerateDisposeCall(
            SyntaxNode syntax,
            BoundExpression disposedExpression,
            MethodArgumentInfo? disposeInfo,
            BoundAwaitableInfo? awaitOpt,
            SyntaxToken awaitKeyword)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10533,21466,23855);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,21744,21802);

f_10533_21744_21801(awaitOpt is null ||(DynAbs.Tracing.TraceSender.Expression_False(10533, 21757, 21800)||awaitKeyword != default));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,21943,21993);

MethodSymbol? 
disposeMethod = f_10533_21973_21992_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(disposeInfo, 10533, 21973, 21992)?.Method)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,22007,22641) || true) && (disposeMethod is null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,22007,22641);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,22066,22626) || true) && (awaitOpt is null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,22066,22626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,22174,22303);

f_10533_22174_22302(_compilation, SpecialMember.System_IDisposable__Dispose, syntax, _diagnostics, out disposeMethod);
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,22066,22626);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,22066,22626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,22441,22607);

f_10533_22441_22606(this, syntax: null, WellKnownMember.System_IAsyncDisposable__DisposeAsync, out disposeMethod, location: awaitKeyword.GetLocation());
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,22066,22626);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,22007,22641);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,22657,22685);

BoundExpression 
disposeCall
=default(BoundExpression);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,22699,23809) || true) && (disposeMethod is null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,22699,23809);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,22758,22943);

disposeCall = f_10533_22772_22942(syntax, LookupResultKind.NotInvocable, ImmutableArray<Symbol?>.Empty, f_10533_22865_22906(disposedExpression), ErrorTypeSymbol.UnknownResultType);
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,22699,23809);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,22699,23809);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,23009,23265) || true) && (disposeInfo is null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,23009,23265);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,23172,23246);

disposeInfo = f_10533_23186_23245(disposeMethod);
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,23009,23265);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,23285,23371);

disposeCall = f_10533_23299_23370(this, disposeInfo, syntax, disposedExpression);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,23391,23794) || true) && (awaitOpt is object)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,23391,23794);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,23506,23541);

_sawAwaitInExceptionHandler = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,23565,23657);

TypeSymbol 
awaitExpressionType = f_10533_23598_23628_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10533_23598_23616(awaitOpt), 10533, 23598, 23628)?.ReturnType)??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10533, 23598, 23656)??f_10533_23632_23656(_compilation))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,23679,23775);

disposeCall = f_10533_23693_23774(this, syntax, disposeCall, awaitOpt, awaitExpressionType, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,23391,23794);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,22699,23809);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,23825,23844);

return disposeCall;
DynAbs.Tracing.TraceSender.TraceExitMethod(10533,21466,23855);

int
f_10533_21744_21801(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 21744, 21801);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10533_21973_21992_M(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 21973, 21992);
return return_v;
}


bool
f_10533_22174_22302(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SpecialMember
specialMember,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
symbol)
{
var return_v = Binder.TryGetSpecialTypeMember( compilation, specialMember, syntax, diagnostics, out symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 22174, 22302);
return return_v;
}


bool
f_10533_22441_22606(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode?
syntax,Microsoft.CodeAnalysis.WellKnownMember
member,out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
symbol,Microsoft.CodeAnalysis.Location
location)
{
var return_v = this_param.TryGetWellKnownTypeMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( syntax: syntax, member, out symbol, location: location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 22441, 22606);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10533_22865_22906(Microsoft.CodeAnalysis.CSharp.BoundExpression
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 22865, 22906);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundBadExpression
f_10533_22772_22942(Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
symbols,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
childBoundNodes,Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
type)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression( syntax, resultKind, symbols, childBoundNodes, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 22772, 22942);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
f_10533_23186_23245(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = MethodArgumentInfo.CreateParameterlessMethod( method);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 23186, 23245);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10533_23299_23370(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
methodArgumentInfo,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = this_param.MakeCallWithNoExplicitArgument( methodArgumentInfo, syntax, expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 23299, 23370);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
f_10533_23598_23616(Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
this_param)
{
var return_v = this_param.GetResult;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 23598, 23616);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10533_23598_23628_M(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 23598, 23628);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10533_23632_23656(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.DynamicType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 23632, 23656);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10533_23693_23774(Microsoft.CodeAnalysis.CSharp.LocalRewriter
this_param,Microsoft.CodeAnalysis.SyntaxNode
syntax,Microsoft.CodeAnalysis.CSharp.BoundExpression
rewrittenExpression,Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
awaitableInfo,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type,bool
used)
{
var return_v = this_param.RewriteAwaitExpression( syntax, rewrittenExpression, awaitableInfo, type, used);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 23693, 23774);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10533,21466,23855);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10533,21466,23855);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BoundExpression MakeCallWithNoExplicitArgument(MethodArgumentInfo methodArgumentInfo, SyntaxNode syntax, BoundExpression? expression, bool assertParametersAreOptional = true)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10533,24071,25536);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,24278,24326);

MethodSymbol 
method = f_10533_24300_24325(methodArgumentInfo)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,24353,25037) || true) && (f_10533_24357_24381(method))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,24353,25037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,24415,24448);

f_10533_24415_24447(expression == null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,24466,24646);

f_10533_24466_24645(method.Parameters.AsSpan()[1..].All(assertParametersAreOptional,(p, assertOptional) => (p.IsOptional || p.IsParams || !assertOptional) && p.RefKind == RefKind.None));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,24664,24781);

f_10533_24664_24780(method.ParameterRefKinds.IsDefaultOrEmpty ||(DynAbs.Tracing.TraceSender.Expression_False(10533, 24677, 24779)||f_10533_24722_24746(method)[0] is RefKind.In or RefKind.None));
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,24353,25037);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10533,24353,25037);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,24847,24948);

f_10533_24847_24947(!assertParametersAreOptional ||(DynAbs.Tracing.TraceSender.Expression_False(10533, 24860, 24946)||method.Parameters.All(p => p.IsOptional || p.IsParams)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,24966,25022);

f_10533_24966_25021(method.ParameterRefKinds.IsDefaultOrEmpty);
DynAbs.Tracing.TraceSender.TraceExitCondition(10533,24353,25037);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10533,25061,25525);

return f_10533_25068_25524(this, syntax, expression, method, f_10533_25174_25202(methodArgumentInfo), argumentRefKindsOpt: default, expanded: f_10533_25278_25305(methodArgumentInfo), invokedAsExtensionMethod: f_10533_25350_25374(method), f_10533_25393_25427(methodArgumentInfo), resultKind: LookupResultKind.Viable, type: f_10533_25506_25523(method));
DynAbs.Tracing.TraceSender.TraceExitMethod(10533,24071,25536);

Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10533_24300_24325(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
this_param)
{
var return_v = this_param.Method;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 24300, 24325);
return return_v;
}


bool
f_10533_24357_24381(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.IsExtensionMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 24357, 24381);
return return_v;
}


int
f_10533_24415_24447(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 24415, 24447);
return 0;
}


int
f_10533_24466_24645(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 24466, 24645);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
f_10533_24722_24746(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ParameterRefKinds;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 24722, 24746);
return return_v;
}


int
f_10533_24664_24780(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 24664, 24780);
return 0;
}


int
f_10533_24847_24947(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 24847, 24947);
return 0;
}


int
f_10533_24966_25021(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 24966, 25021);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
f_10533_25174_25202(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 25174, 25202);
return return_v;
}


bool
f_10533_25278_25305(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
this_param)
{
var return_v = this_param.Expanded;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 25278, 25305);
return return_v;
}


bool
f_10533_25350_25374(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.IsExtensionMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 25350, 25374);
return return_v;
}


System.Collections.Immutable.ImmutableArray<int>
f_10533_25393_25427(Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo
this_param)
{
var return_v = this_param.ArgsToParamsOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 25393, 25427);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10533_25506_25523(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.ReturnType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10533, 25506, 25523);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundExpression
f_10533_25068_25524(Microsoft.CodeAnalysis.CSharp.LocalRewriter
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
type)
{
var return_v = this_param.MakeCall( syntax, rewrittenReceiver, method, rewrittenArguments, argumentRefKindsOpt: argumentRefKindsOpt, expanded: expanded, invokedAsExtensionMethod: invokedAsExtensionMethod, argsToParamsOpt, resultKind: resultKind, type: type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10533, 25068, 25524);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10533,24071,25536);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10533,24071,25536);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
