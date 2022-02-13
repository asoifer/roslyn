// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class BlockSyntax
    {
        public BlockSyntax Update(SyntaxToken openBraceToken, SyntaxList<StatementSyntax> statements, SyntaxToken closeBraceToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10744, 495, 574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10744, 498, 574);
                return f_10744_498_574(this, attributeLists: default, openBraceToken, statements, closeBraceToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10744, 495, 574);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10744, 495, 574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10744, 495, 574);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            f_10744_498_574(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            openBraceToken, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
            statements, Microsoft.CodeAnalysis.SyntaxToken
            closeBraceToken)
            {
                var return_v = this_param.Update(attributeLists: attributeLists, openBraceToken, statements, closeBraceToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10744, 498, 574);
                return return_v;
            }

        }

        static BlockSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10744, 310, 582);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10744, 310, 582);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10744, 310, 582);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10744, 310, 582);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static BlockSyntax Block(SyntaxToken openBraceToken, SyntaxList<StatementSyntax> statements, SyntaxToken closeBraceToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10744, 830, 908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10744, 833, 908);
                return f_10744_833_908(attributeLists: default, openBraceToken, statements, closeBraceToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10744, 830, 908);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10744, 830, 908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10744, 830, 908);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            f_10744_833_908(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            openBraceToken, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
            statements, Microsoft.CodeAnalysis.SyntaxToken
            closeBraceToken)
            {
                var return_v = Block(attributeLists: attributeLists, openBraceToken, statements, closeBraceToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10744, 833, 908);
                return return_v;
            }

        }
    }
}
