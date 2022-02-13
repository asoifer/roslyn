// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
public partial class UsingStatementSyntax
{
public UsingStatementSyntax Update(SyntaxToken usingKeyword, SyntaxToken openParenToken, VariableDeclarationSyntax declaration, ExpressionSyntax expression, SyntaxToken closeParenToken, StatementSyntax statement)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10818,594,709);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10818,597,709);
return f_10818_597_709(this, awaitKeyword: default, usingKeyword, openParenToken, declaration, expression, closeParenToken, statement);DynAbs.Tracing.TraceSender.TraceExitMethod(10818,594,709);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10818,594,709);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10818,594,709);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
f_10818_597_709(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
this_param,Microsoft.CodeAnalysis.SyntaxToken
awaitKeyword,Microsoft.CodeAnalysis.SyntaxToken
usingKeyword,Microsoft.CodeAnalysis.SyntaxToken
openParenToken,Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
declaration,Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
expression,Microsoft.CodeAnalysis.SyntaxToken
closeParenToken,Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
statement)
{
var return_v = this_param.Update( awaitKeyword: awaitKeyword, usingKeyword, openParenToken, declaration, expression, closeParenToken, statement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10818, 597, 709);
return return_v;
}

		}

public UsingStatementSyntax Update(SyntaxToken awaitKeyword, SyntaxToken usingKeyword, SyntaxToken openParenToken, VariableDeclarationSyntax declaration, ExpressionSyntax expression, SyntaxToken closeParenToken, StatementSyntax statement)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10818,974,1105);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10818,977,1105);
return f_10818_977_1105(this, attributeLists: default, awaitKeyword, usingKeyword, openParenToken, declaration, expression, closeParenToken, statement);DynAbs.Tracing.TraceSender.TraceExitMethod(10818,974,1105);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10818,974,1105);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10818,974,1105);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
f_10818_977_1105(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
this_param,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributeLists,Microsoft.CodeAnalysis.SyntaxToken
awaitKeyword,Microsoft.CodeAnalysis.SyntaxToken
usingKeyword,Microsoft.CodeAnalysis.SyntaxToken
openParenToken,Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
declaration,Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
expression,Microsoft.CodeAnalysis.SyntaxToken
closeParenToken,Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
statement)
{
var return_v = this_param.Update( attributeLists: attributeLists, awaitKeyword, usingKeyword, openParenToken, declaration, expression, closeParenToken, statement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10818, 977, 1105);
return return_v;
}

		}

static UsingStatementSyntax()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10818,310,1113);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10818,310,1113);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10818,310,1113);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10818,310,1113);
}
}

namespace Microsoft.CodeAnalysis.CSharp
{
public partial class SyntaxFactory
{
public static UsingStatementSyntax UsingStatement(SyntaxToken usingKeyword, SyntaxToken openParenToken, VariableDeclarationSyntax declaration, ExpressionSyntax expression, SyntaxToken closeParenToken, StatementSyntax statement)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10818,1460,1583);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10818,1463,1583);
return f_10818_1463_1583(awaitKeyword: default, usingKeyword, openParenToken, declaration, expression, closeParenToken, statement);DynAbs.Tracing.TraceSender.TraceExitMethod(10818,1460,1583);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10818,1460,1583);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10818,1460,1583);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
f_10818_1463_1583(Microsoft.CodeAnalysis.SyntaxToken
awaitKeyword,Microsoft.CodeAnalysis.SyntaxToken
usingKeyword,Microsoft.CodeAnalysis.SyntaxToken
openParenToken,Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
declaration,Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
expression,Microsoft.CodeAnalysis.SyntaxToken
closeParenToken,Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
statement)
{
var return_v = UsingStatement( awaitKeyword: awaitKeyword, usingKeyword, openParenToken, declaration, expression, closeParenToken, statement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10818, 1463, 1583);
return return_v;
}

		}

public static UsingStatementSyntax UsingStatement(SyntaxToken awaitKeyword, SyntaxToken usingKeyword, SyntaxToken openParenToken, VariableDeclarationSyntax declaration, ExpressionSyntax expression, SyntaxToken closeParenToken, StatementSyntax statement)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10818,1863,2002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10818,1866,2002);
return f_10818_1866_2002(attributeLists: default, awaitKeyword, usingKeyword, openParenToken, declaration, expression, closeParenToken, statement);DynAbs.Tracing.TraceSender.TraceExitMethod(10818,1863,2002);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10818,1863,2002);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10818,1863,2002);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
f_10818_1866_2002(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributeLists,Microsoft.CodeAnalysis.SyntaxToken
awaitKeyword,Microsoft.CodeAnalysis.SyntaxToken
usingKeyword,Microsoft.CodeAnalysis.SyntaxToken
openParenToken,Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
declaration,Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
expression,Microsoft.CodeAnalysis.SyntaxToken
closeParenToken,Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
statement)
{
var return_v = UsingStatement( attributeLists: attributeLists, awaitKeyword, usingKeyword, openParenToken, declaration, expression, closeParenToken, statement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10818, 1866, 2002);
return return_v;
}

		}

public static UsingStatementSyntax UsingStatement(VariableDeclarationSyntax declaration, ExpressionSyntax expression, StatementSyntax statement)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10818,2173,2251);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10818,2176,2251);
return f_10818_2176_2251(attributeLists: default, declaration, expression, statement);DynAbs.Tracing.TraceSender.TraceExitMethod(10818,2173,2251);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10818,2173,2251);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10818,2173,2251);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
f_10818_2176_2251(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributeLists,Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
declaration,Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
expression,Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
statement)
{
var return_v = UsingStatement( attributeLists: attributeLists, declaration, expression, statement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10818, 2176, 2251);
return return_v;
}

		}
}
}
