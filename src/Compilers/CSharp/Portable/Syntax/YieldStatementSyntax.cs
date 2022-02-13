// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
public partial class YieldStatementSyntax
{
public YieldStatementSyntax Update(SyntaxToken yieldKeyword, SyntaxToken returnOrBreakKeyword, ExpressionSyntax expression, SyntaxToken semicolonToken)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10821,533,631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10821,536,631);
return f_10821_536_631(this, attributeLists: default, yieldKeyword, returnOrBreakKeyword, expression, semicolonToken);DynAbs.Tracing.TraceSender.TraceExitMethod(10821,533,631);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10821,533,631);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10821,533,631);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax
f_10821_536_631(Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax
this_param,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributeLists,Microsoft.CodeAnalysis.SyntaxToken
yieldKeyword,Microsoft.CodeAnalysis.SyntaxToken
returnOrBreakKeyword,Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
expression,Microsoft.CodeAnalysis.SyntaxToken
semicolonToken)
{
var return_v = this_param.Update( attributeLists: attributeLists, yieldKeyword, returnOrBreakKeyword, expression, semicolonToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10821, 536, 631);
return return_v;
}

		}

static YieldStatementSyntax()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10821,310,639);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10821,310,639);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10821,310,639);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10821,310,639);
}
}

namespace Microsoft.CodeAnalysis.CSharp
{
public partial class SyntaxFactory
{
public static YieldStatementSyntax YieldStatement(SyntaxKind kind, SyntaxToken yieldKeyword, SyntaxToken returnOrBreakKeyword, ExpressionSyntax expression, SyntaxToken semicolonToken)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10821,942,1054);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10821,945,1054);
return f_10821_945_1054(kind, attributeLists: default, yieldKeyword, returnOrBreakKeyword, expression, semicolonToken);DynAbs.Tracing.TraceSender.TraceExitMethod(10821,942,1054);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10821,942,1054);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10821,942,1054);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax
f_10821_945_1054(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributeLists,Microsoft.CodeAnalysis.SyntaxToken
yieldKeyword,Microsoft.CodeAnalysis.SyntaxToken
returnOrBreakKeyword,Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
expression,Microsoft.CodeAnalysis.SyntaxToken
semicolonToken)
{
var return_v = YieldStatement( kind, attributeLists: attributeLists, yieldKeyword, returnOrBreakKeyword, expression, semicolonToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10821, 945, 1054);
return return_v;
}

		}
}
}
