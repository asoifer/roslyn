// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
public partial class TryStatementSyntax
{
public TryStatementSyntax Update(SyntaxToken tryKeyword, BlockSyntax block, SyntaxList<CatchClauseSyntax> catches, FinallyClauseSyntax @finally)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10814,524,596);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10814,527,596);
return f_10814_527_596(this, attributeLists: default, tryKeyword, block, catches, @finally);DynAbs.Tracing.TraceSender.TraceExitMethod(10814,524,596);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10814,524,596);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10814,524,596);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax
f_10814_527_596(Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax
this_param,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributeLists,Microsoft.CodeAnalysis.SyntaxToken
tryKeyword,Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
block,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax>
catches,Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax
@finally)
{
var return_v = this_param.Update( attributeLists: attributeLists, tryKeyword, block, catches, @finally);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10814, 527, 596);
return return_v;
}

		}

static TryStatementSyntax()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10814,310,604);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10814,310,604);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10814,310,604);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10814,310,604);
}
}

namespace Microsoft.CodeAnalysis.CSharp
{
public partial class SyntaxFactory
{
public static TryStatementSyntax TryStatement(BlockSyntax block, SyntaxList<CatchClauseSyntax> catches, FinallyClauseSyntax @finally)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10814,857,923);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10814,860,923);
return f_10814_860_923(attributeLists: default, block, catches, @finally);DynAbs.Tracing.TraceSender.TraceExitMethod(10814,857,923);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10814,857,923);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10814,857,923);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax
f_10814_860_923(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributeLists,Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
block,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax>
catches,Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax
@finally)
{
var return_v = TryStatement( attributeLists: attributeLists, block, catches, @finally);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10814, 860, 923);
return return_v;
}

		}

public static TryStatementSyntax TryStatement(SyntaxToken tryKeyword, BlockSyntax block, SyntaxList<CatchClauseSyntax> catches, FinallyClauseSyntax @finally)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10814,1107,1185);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10814,1110,1185);
return f_10814_1110_1185(attributeLists: default, tryKeyword, block, catches, @finally);DynAbs.Tracing.TraceSender.TraceExitMethod(10814,1107,1185);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10814,1107,1185);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10814,1107,1185);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax
f_10814_1110_1185(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributeLists,Microsoft.CodeAnalysis.SyntaxToken
tryKeyword,Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
block,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax>
catches,Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax
@finally)
{
var return_v = TryStatement( attributeLists: attributeLists, tryKeyword, block, catches, @finally);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10814, 1110, 1185);
return return_v;
}

		}
}
}
