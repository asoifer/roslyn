// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Syntax.InternalSyntax;
using InternalSyntax = Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public static class SyntaxExtensions
{
public static SyntaxTriviaList GetLeadingTrivia(this SyntaxNode node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26003,593,760);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,687,749);

return f_26003_694_734(node, includeSkipped: true).LeadingTrivia;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26003,593,760);

Microsoft.CodeAnalysis.SyntaxToken
f_26003_694_734(Microsoft.CodeAnalysis.SyntaxNode
this_param,bool
includeSkipped)
{
var return_v = this_param.GetFirstToken( includeSkipped:includeSkipped);
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 694, 734);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26003,593,760);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26003,593,760);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static SyntaxTriviaList GetTrailingTrivia(this SyntaxNode node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26003,772,940);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,867,929);

return f_26003_874_913(node, includeSkipped: true).TrailingTrivia;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26003,772,940);

Microsoft.CodeAnalysis.SyntaxToken
f_26003_874_913(Microsoft.CodeAnalysis.SyntaxNode
this_param,bool
includeSkipped)
{
var return_v = this_param.GetLastToken( includeSkipped:includeSkipped);
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 874, 913);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26003,772,940);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26003,772,940);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static ImmutableArray<DiagnosticInfo> Errors(this SyntaxNode node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26003,952,1116);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,1052,1105);

return f_26003_1059_1104(f_26003_1059_1069(node), errorsOnly: true);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26003,952,1116);

Microsoft.CodeAnalysis.GreenNode
f_26003_1059_1069(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Green;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(26003, 1059, 1069);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticInfo>
f_26003_1059_1104(Microsoft.CodeAnalysis.GreenNode
node,bool
errorsOnly)
{
var return_v = node.ErrorsOrWarnings( errorsOnly:errorsOnly);
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 1059, 1104);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26003,952,1116);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26003,952,1116);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static ImmutableArray<DiagnosticInfo> Warnings(this SyntaxNode node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26003,1128,1295);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,1230,1284);

return f_26003_1237_1283(f_26003_1237_1247(node), errorsOnly: false);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26003,1128,1295);

Microsoft.CodeAnalysis.GreenNode
f_26003_1237_1247(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Green;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(26003, 1237, 1247);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticInfo>
f_26003_1237_1283(Microsoft.CodeAnalysis.GreenNode
node,bool
errorsOnly)
{
var return_v = node.ErrorsOrWarnings( errorsOnly:errorsOnly);
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 1237, 1283);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26003,1128,1295);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26003,1128,1295);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static ImmutableArray<DiagnosticInfo> ErrorsAndWarnings(this SyntaxNode node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26003,1307,1467);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,1418,1456);

return f_26003_1425_1455(f_26003_1425_1435(node));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26003,1307,1467);

Microsoft.CodeAnalysis.GreenNode
f_26003_1425_1435(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Green;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(26003, 1425, 1435);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticInfo>
f_26003_1425_1455(Microsoft.CodeAnalysis.GreenNode
node)
{
var return_v = node.ErrorsAndWarnings();
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 1425, 1455);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26003,1307,1467);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26003,1307,1467);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static SyntaxTriviaList GetLeadingTrivia(this SyntaxToken token)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26003,1539,1673);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,1635,1662);

return token.LeadingTrivia;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26003,1539,1673);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26003,1539,1673);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26003,1539,1673);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static SyntaxTriviaList GetTrailingTrivia(this SyntaxToken token)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26003,1685,1821);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,1782,1810);

return token.TrailingTrivia;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26003,1685,1821);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26003,1685,1821);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26003,1685,1821);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static ImmutableArray<DiagnosticInfo> Errors(this SyntaxToken token)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26003,1833,2041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,1935,2030);

return f_26003_1942_2029(((Syntax.InternalSyntax.CSharpSyntaxNode)token.Node), errorsOnly: true);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26003,1833,2041);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticInfo>
f_26003_1942_2029(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode?
node,bool
errorsOnly)
{
var return_v = node.ErrorsOrWarnings( errorsOnly:errorsOnly);
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 1942, 2029);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26003,1833,2041);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26003,1833,2041);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static ImmutableArray<DiagnosticInfo> Warnings(this SyntaxToken token)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26003,2053,2264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,2157,2253);

return f_26003_2164_2252(((Syntax.InternalSyntax.CSharpSyntaxNode)token.Node), errorsOnly: false);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26003,2053,2264);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticInfo>
f_26003_2164_2252(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode?
node,bool
errorsOnly)
{
var return_v = node.ErrorsOrWarnings( errorsOnly:errorsOnly);
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 2164, 2252);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26003,2053,2264);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26003,2053,2264);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static ImmutableArray<DiagnosticInfo> ErrorsAndWarnings(this SyntaxToken token)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26003,2276,2480);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,2389,2469);

return f_26003_2396_2468(((Syntax.InternalSyntax.CSharpSyntaxNode)token.Node));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26003,2276,2480);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticInfo>
f_26003_2396_2468(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode?
node)
{
var return_v = node.ErrorsAndWarnings();
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 2396, 2468);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26003,2276,2480);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26003,2276,2480);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static ImmutableArray<DiagnosticInfo> Errors(this SyntaxNodeOrToken nodeOrToken)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26003,2558,2752);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,2672,2741);

return f_26003_2679_2740(nodeOrToken.UnderlyingNode, errorsOnly: true);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26003,2558,2752);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticInfo>
f_26003_2679_2740(Microsoft.CodeAnalysis.GreenNode?
node,bool
errorsOnly)
{
var return_v = node.ErrorsOrWarnings( errorsOnly:errorsOnly);
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 2679, 2740);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26003,2558,2752);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26003,2558,2752);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static ImmutableArray<DiagnosticInfo> Warnings(this SyntaxNodeOrToken nodeOrToken)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26003,2764,2961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,2880,2950);

return f_26003_2887_2949(nodeOrToken.UnderlyingNode, errorsOnly: false);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26003,2764,2961);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticInfo>
f_26003_2887_2949(Microsoft.CodeAnalysis.GreenNode?
node,bool
errorsOnly)
{
var return_v = node.ErrorsOrWarnings( errorsOnly:errorsOnly);
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 2887, 2949);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26003,2764,2961);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26003,2764,2961);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static ImmutableArray<DiagnosticInfo> ErrorsAndWarnings(this SyntaxNodeOrToken nodeOrToken)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26003,2973,3163);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,3098,3152);

return f_26003_3105_3151(nodeOrToken.UnderlyingNode);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26003,2973,3163);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticInfo>
f_26003_3105_3151(Microsoft.CodeAnalysis.GreenNode?
node)
{
var return_v = node.ErrorsAndWarnings();
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 3105, 3151);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26003,2973,3163);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26003,2973,3163);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static ImmutableArray<DiagnosticInfo> Errors(this SyntaxTrivia trivia)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26003,3236,3450);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,3340,3439);

return f_26003_3347_3438(((InternalSyntax.CSharpSyntaxNode)trivia.UnderlyingNode), errorsOnly: true);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26003,3236,3450);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticInfo>
f_26003_3347_3438(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode?
node,bool
errorsOnly)
{
var return_v = node.ErrorsOrWarnings( errorsOnly:errorsOnly);
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 3347, 3438);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26003,3236,3450);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26003,3236,3450);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static ImmutableArray<DiagnosticInfo> Warnings(this SyntaxTrivia trivia)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26003,3462,3679);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,3568,3668);

return f_26003_3575_3667(((InternalSyntax.CSharpSyntaxNode)trivia.UnderlyingNode), errorsOnly: false);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26003,3462,3679);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticInfo>
f_26003_3575_3667(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode?
node,bool
errorsOnly)
{
var return_v = node.ErrorsOrWarnings( errorsOnly:errorsOnly);
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 3575, 3667);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26003,3462,3679);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26003,3462,3679);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static ImmutableArray<DiagnosticInfo> ErrorsAndWarnings(this SyntaxTrivia trivia)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26003,3691,3901);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,3806,3890);

return f_26003_3813_3889(((InternalSyntax.CSharpSyntaxNode)trivia.UnderlyingNode));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26003,3691,3901);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticInfo>
f_26003_3813_3889(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode?
node)
{
var return_v = node.ErrorsAndWarnings();
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 3813, 3889);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26003,3691,3901);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26003,3691,3901);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static ImmutableArray<DiagnosticInfo> ErrorsOrWarnings(this GreenNode node, bool errorsOnly)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26003,3933,4461);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,4058,4134);

ArrayBuilder<DiagnosticInfo> 
b = f_26003_4091_4133()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,4150,4193);

var 
l = f_26003_4158_4192(node)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,4209,4404);
foreach(var item in f_26003_4230_4231_I(l) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(26003,4209,4404);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,4265,4389) || true) && (f_26003_4269_4282(item)== ((DynAbs.Tracing.TraceSender.Conditional_F1(26003, 4287, 4297)||((errorsOnly &&DynAbs.Tracing.TraceSender.Conditional_F2(26003, 4300, 4324))||DynAbs.Tracing.TraceSender.Conditional_F3(26003, 4327, 4353)))?DiagnosticSeverity.Error :DiagnosticSeverity.Warning))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(26003,4265,4389);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,4377,4389);

f_26003_4377_4388(                    b, item);
DynAbs.Tracing.TraceSender.TraceExitCondition(26003,4265,4389);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(26003,4209,4404);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(26003,1,196);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(26003,1,196);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,4420,4450);

return f_26003_4427_4449(b);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26003,3933,4461);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DiagnosticInfo>
f_26003_4091_4133()
{
var return_v = ArrayBuilder<DiagnosticInfo>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 4091, 4133);
return return_v;
}


Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxDiagnosticInfoList
f_26003_4158_4192(Microsoft.CodeAnalysis.GreenNode
node)
{
var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxDiagnosticInfoList( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 4158, 4192);
return return_v;
}


Microsoft.CodeAnalysis.DiagnosticSeverity
f_26003_4269_4282(Microsoft.CodeAnalysis.DiagnosticInfo
this_param)
{
var return_v = this_param.Severity ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(26003, 4269, 4282);
return return_v;
}


int
f_26003_4377_4388(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DiagnosticInfo>
this_param,Microsoft.CodeAnalysis.DiagnosticInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 4377, 4388);
return 0;
}


Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxDiagnosticInfoList
f_26003_4230_4231_I(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxDiagnosticInfoList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 4230, 4231);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticInfo>
f_26003_4427_4449(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DiagnosticInfo>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 4427, 4449);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26003,3933,4461);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26003,3933,4461);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static ImmutableArray<DiagnosticInfo> ErrorsAndWarnings(this GreenNode node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(26003,4473,4873);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,4582,4658);

ArrayBuilder<DiagnosticInfo> 
b = f_26003_4615_4657()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,4674,4717);

var 
l = f_26003_4682_4716(node)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,4733,4816);
foreach(var item in f_26003_4754_4755_I(l) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(26003,4733,4816);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,4789,4801);

f_26003_4789_4800(                b, item);
DynAbs.Tracing.TraceSender.TraceExitCondition(26003,4733,4816);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(26003,1,84);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(26003,1,84);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(26003,4832,4862);

return f_26003_4839_4861(b);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(26003,4473,4873);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DiagnosticInfo>
f_26003_4615_4657()
{
var return_v = ArrayBuilder<DiagnosticInfo>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 4615, 4657);
return return_v;
}


Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxDiagnosticInfoList
f_26003_4682_4716(Microsoft.CodeAnalysis.GreenNode
node)
{
var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxDiagnosticInfoList( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 4682, 4716);
return return_v;
}


int
f_26003_4789_4800(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DiagnosticInfo>
this_param,Microsoft.CodeAnalysis.DiagnosticInfo
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 4789, 4800);
return 0;
}


Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxDiagnosticInfoList
f_26003_4754_4755_I(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxDiagnosticInfoList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 4754, 4755);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticInfo>
f_26003_4839_4861(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DiagnosticInfo>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(26003, 4839, 4861);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(26003,4473,4873);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26003,4473,4873);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static SyntaxExtensions()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(26003,501,4880);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(26003,501,4880);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(26003,501,4880);
}

}
}
