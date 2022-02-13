// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class FixedStatementSyntax
    {
        public FixedStatementSyntax Update(SyntaxToken fixedKeyword, SyntaxToken openParenToken, VariableDeclarationSyntax declaration, SyntaxToken closeParenToken, StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10765, 565, 670);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10765, 568, 670);
                return f_10765_568_670(this, attributeLists: default, fixedKeyword, openParenToken, declaration, closeParenToken, statement); DynAbs.Tracing.TraceSender.TraceExitMethod(10765, 565, 670);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10765, 565, 670);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10765, 565, 670);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax
            f_10765_568_670(Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            fixedKeyword, Microsoft.CodeAnalysis.SyntaxToken
            openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
            declaration, Microsoft.CodeAnalysis.SyntaxToken
            closeParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement)
            {
                var return_v = this_param.Update(attributeLists: attributeLists, fixedKeyword, openParenToken, declaration, closeParenToken, statement);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10765, 568, 670);
                return return_v;
            }

        }

        static FixedStatementSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10765, 310, 678);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10765, 310, 678);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10765, 310, 678);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10765, 310, 678);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static FixedStatementSyntax FixedStatement(SyntaxToken fixedKeyword, SyntaxToken openParenToken, VariableDeclarationSyntax declaration, SyntaxToken closeParenToken, StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10765, 996, 1109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10765, 999, 1109);
                return f_10765_999_1109(attributeLists: default, fixedKeyword, openParenToken, declaration, closeParenToken, statement); DynAbs.Tracing.TraceSender.TraceExitMethod(10765, 996, 1109);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10765, 996, 1109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10765, 996, 1109);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax
            f_10765_999_1109(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            fixedKeyword, Microsoft.CodeAnalysis.SyntaxToken
            openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
            declaration, Microsoft.CodeAnalysis.SyntaxToken
            closeParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement)
            {
                var return_v = FixedStatement(attributeLists: attributeLists, fixedKeyword, openParenToken, declaration, closeParenToken, statement);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10765, 999, 1109);
                return return_v;
            }

        }
    }
}
