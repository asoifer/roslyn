// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
public partial class UnsafeStatementSyntax
{
public UnsafeStatementSyntax Update(SyntaxToken unsafeKeyword, BlockSyntax block)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10817,464,520);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10817,467,520);
return f_10817_467_520(this, attributeLists: default, unsafeKeyword, block);DynAbs.Tracing.TraceSender.TraceExitMethod(10817,464,520);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10817,464,520);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10817,464,520);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax
f_10817_467_520(Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax
this_param,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributeLists,Microsoft.CodeAnalysis.SyntaxToken
unsafeKeyword,Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
block)
{
var return_v = this_param.Update( attributeLists: attributeLists, unsafeKeyword, block);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10817, 467, 520);
return return_v;
}

		}

static UnsafeStatementSyntax()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10817,310,528);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10817,310,528);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10817,310,528);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10817,310,528);
}
}

namespace Microsoft.CodeAnalysis.CSharp
{
public partial class SyntaxFactory
{
public static UnsafeStatementSyntax UnsafeStatement(SyntaxToken unsafeKeyword, BlockSyntax block)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10817,745,810);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10817,748,810);
return f_10817_748_810(attributeLists: default, unsafeKeyword, block);DynAbs.Tracing.TraceSender.TraceExitMethod(10817,745,810);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10817,745,810);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10817,745,810);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax
f_10817_748_810(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributeLists,Microsoft.CodeAnalysis.SyntaxToken
unsafeKeyword,Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
block)
{
var return_v = UnsafeStatement( attributeLists: attributeLists, unsafeKeyword, block);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10817, 748, 810);
return return_v;
}

		}
}
}
