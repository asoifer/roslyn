// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
public partial class ThrowStatementSyntax
{
public ThrowStatementSyntax Update(SyntaxToken throwKeyword, ExpressionSyntax expression, SyntaxToken semicolonToken)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10813,499,575);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10813,502,575);
return f_10813_502_575(this, attributeLists: default, throwKeyword, expression, semicolonToken);DynAbs.Tracing.TraceSender.TraceExitMethod(10813,499,575);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10813,499,575);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10813,499,575);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax
f_10813_502_575(Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax
this_param,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributeLists,Microsoft.CodeAnalysis.SyntaxToken
throwKeyword,Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
expression,Microsoft.CodeAnalysis.SyntaxToken
semicolonToken)
{
var return_v = this_param.Update( attributeLists: attributeLists, throwKeyword, expression, semicolonToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10813, 502, 575);
return return_v;
}

		}

static ThrowStatementSyntax()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10813,310,583);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10813,310,583);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10813,310,583);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10813,310,583);
}
}

namespace Microsoft.CodeAnalysis.CSharp
{
public partial class SyntaxFactory
{
public static ThrowStatementSyntax ThrowStatement(SyntaxToken throwKeyword, ExpressionSyntax expression, SyntaxToken semicolonToken)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10813,835,919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10813,838,919);
return f_10813_838_919(attributeLists: default, throwKeyword, expression, semicolonToken);DynAbs.Tracing.TraceSender.TraceExitMethod(10813,835,919);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10813,835,919);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10813,835,919);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax
f_10813_838_919(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributeLists,Microsoft.CodeAnalysis.SyntaxToken
throwKeyword,Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
expression,Microsoft.CodeAnalysis.SyntaxToken
semicolonToken)
{
var return_v = ThrowStatement( attributeLists: attributeLists, throwKeyword, expression, semicolonToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10813, 838, 919);
return return_v;
}

		}
}
}

