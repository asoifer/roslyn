// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class SwitchStatementSyntax
    {
        public SwitchStatementSyntax Update(SyntaxToken switchKeyword, SyntaxToken openParenToken, ExpressionSyntax expression, SyntaxToken closeParenToken, SyntaxToken openBraceToken, SyntaxList<SwitchSectionSyntax> sections, SyntaxToken closeBraceToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10801, 630, 767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10801, 633, 767);
                return f_10801_633_767(this, attributeLists: default, switchKeyword, openParenToken, expression, closeParenToken, openBraceToken, sections, closeBraceToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10801, 630, 767);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10801, 630, 767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10801, 630, 767);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
            f_10801_633_767(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            switchKeyword, Microsoft.CodeAnalysis.SyntaxToken
            openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expression, Microsoft.CodeAnalysis.SyntaxToken
            closeParenToken, Microsoft.CodeAnalysis.SyntaxToken
            openBraceToken, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>
            sections, Microsoft.CodeAnalysis.SyntaxToken
            closeBraceToken)
            {
                var return_v = this_param.Update(attributeLists: attributeLists, switchKeyword, openParenToken, expression, closeParenToken, openBraceToken, sections, closeBraceToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10801, 633, 767);
                return return_v;
            }

        }

        static SwitchStatementSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10801, 310, 775);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10801, 310, 775);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10801, 310, 775);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10801, 310, 775);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static SwitchStatementSyntax SwitchStatement(SyntaxToken switchKeyword, SyntaxToken openParenToken, ExpressionSyntax expression, SyntaxToken closeParenToken, SyntaxToken openBraceToken, SyntaxList<SwitchSectionSyntax> sections, SyntaxToken closeBraceToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10801, 1158, 1304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10801, 1161, 1304);
                return f_10801_1161_1304(attributeLists: default, switchKeyword, openParenToken, expression, closeParenToken, openBraceToken, sections, closeBraceToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10801, 1158, 1304);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10801, 1158, 1304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10801, 1158, 1304);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
            f_10801_1161_1304(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            switchKeyword, Microsoft.CodeAnalysis.SyntaxToken
            openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expression, Microsoft.CodeAnalysis.SyntaxToken
            closeParenToken, Microsoft.CodeAnalysis.SyntaxToken
            openBraceToken, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>
            sections, Microsoft.CodeAnalysis.SyntaxToken
            closeBraceToken)
            {
                var return_v = SwitchStatement(attributeLists: attributeLists, switchKeyword, openParenToken, expression, closeParenToken, openBraceToken, sections, closeBraceToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10801, 1161, 1304);
                return return_v;
            }

        }
    }
}
