// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
public partial class WhileStatementSyntax
{
public WhileStatementSyntax Update(SyntaxToken whileKeyword, SyntaxToken openParenToken, ExpressionSyntax condition, SyntaxToken closeParenToken, StatementSyntax statement)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10819,554,657);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10819,557,657);
return f_10819_557_657(this, attributeLists: default, whileKeyword, openParenToken, condition, closeParenToken, statement);DynAbs.Tracing.TraceSender.TraceExitMethod(10819,554,657);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10819,554,657);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10819,554,657);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax
f_10819_557_657(Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax
this_param,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributeLists,Microsoft.CodeAnalysis.SyntaxToken
whileKeyword,Microsoft.CodeAnalysis.SyntaxToken
openParenToken,Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
condition,Microsoft.CodeAnalysis.SyntaxToken
closeParenToken,Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
statement)
{
var return_v = this_param.Update( attributeLists: attributeLists, whileKeyword, openParenToken, condition, closeParenToken, statement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10819, 557, 657);
return return_v;
}

		}

static WhileStatementSyntax()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10819,310,665);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10819,310,665);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10819,310,665);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10819,310,665);
}
}

namespace Microsoft.CodeAnalysis.CSharp
{
public partial class SyntaxFactory
{
public static WhileStatementSyntax WhileStatement(SyntaxToken whileKeyword, SyntaxToken openParenToken, ExpressionSyntax condition, SyntaxToken closeParenToken, StatementSyntax statement)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10819,972,1083);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10819,975,1083);
return f_10819_975_1083(attributeLists: default, whileKeyword, openParenToken, condition, closeParenToken, statement);DynAbs.Tracing.TraceSender.TraceExitMethod(10819,972,1083);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10819,972,1083);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10819,972,1083);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax
f_10819_975_1083(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributeLists,Microsoft.CodeAnalysis.SyntaxToken
whileKeyword,Microsoft.CodeAnalysis.SyntaxToken
openParenToken,Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
condition,Microsoft.CodeAnalysis.SyntaxToken
closeParenToken,Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
statement)
{
var return_v = WhileStatement( attributeLists: attributeLists, whileKeyword, openParenToken, condition, closeParenToken, statement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10819, 975, 1083);
return return_v;
}

		}
}
}
