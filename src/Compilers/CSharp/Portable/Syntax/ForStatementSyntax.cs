// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class ForStatementSyntax
    {
        public ForStatementSyntax Update(SyntaxToken forKeyword, SyntaxToken openParenToken, VariableDeclarationSyntax declaration, SeparatedSyntaxList<ExpressionSyntax> initializers, SyntaxToken firstSemicolonToken, ExpressionSyntax condition, SyntaxToken secondSemicolonToken, SeparatedSyntaxList<ExpressionSyntax> incrementors, SyntaxToken closeParenToken, StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10768, 758, 943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10768, 761, 943);
                return f_10768_761_943(this, attributeLists: default, forKeyword, openParenToken, declaration, initializers, firstSemicolonToken, condition, secondSemicolonToken, incrementors, closeParenToken, statement); DynAbs.Tracing.TraceSender.TraceExitMethod(10768, 758, 943);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10768, 758, 943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10768, 758, 943);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
            f_10768_761_943(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            forKeyword, Microsoft.CodeAnalysis.SyntaxToken
            openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
            declaration, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
            initializers, Microsoft.CodeAnalysis.SyntaxToken
            firstSemicolonToken, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            condition, Microsoft.CodeAnalysis.SyntaxToken
            secondSemicolonToken, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
            incrementors, Microsoft.CodeAnalysis.SyntaxToken
            closeParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement)
            {
                var return_v = this_param.Update(attributeLists: attributeLists, forKeyword, openParenToken, declaration, initializers, firstSemicolonToken, condition, secondSemicolonToken, incrementors, closeParenToken, statement);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10768, 761, 943);
                return return_v;
            }

        }

        static ForStatementSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10768, 310, 951);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10768, 310, 951);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10768, 310, 951);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10768, 310, 951);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static ForStatementSyntax ForStatement(VariableDeclarationSyntax declaration, SeparatedSyntaxList<ExpressionSyntax> initializers, ExpressionSyntax condition, SeparatedSyntaxList<ExpressionSyntax> incrementors, StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10768, 1314, 1417);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10768, 1317, 1417);
                return f_10768_1317_1417(attributeLists: default, declaration, initializers, condition, incrementors, statement); DynAbs.Tracing.TraceSender.TraceExitMethod(10768, 1314, 1417);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10768, 1314, 1417);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10768, 1314, 1417);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
            f_10768_1317_1417(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
            declaration, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
            initializers, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            condition, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
            incrementors, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement)
            {
                var return_v = ForStatement(attributeLists: attributeLists, declaration, initializers, condition, incrementors, statement);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10768, 1317, 1417);
                return return_v;
            }

        }

        public static ForStatementSyntax ForStatement(SyntaxToken forKeyword, SyntaxToken openParenToken, VariableDeclarationSyntax declaration, SeparatedSyntaxList<ExpressionSyntax> initializers, SyntaxToken firstSemicolonToken, ExpressionSyntax condition, SyntaxToken secondSemicolonToken, SeparatedSyntaxList<ExpressionSyntax> incrementors, SyntaxToken closeParenToken, StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10768, 1835, 2026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10768, 1838, 2026);
                return f_10768_1838_2026(attributeLists: default, forKeyword, openParenToken, declaration, initializers, firstSemicolonToken, condition, secondSemicolonToken, incrementors, closeParenToken, statement); DynAbs.Tracing.TraceSender.TraceExitMethod(10768, 1835, 2026);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10768, 1835, 2026);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10768, 1835, 2026);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
            f_10768_1838_2026(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            forKeyword, Microsoft.CodeAnalysis.SyntaxToken
            openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
            declaration, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
            initializers, Microsoft.CodeAnalysis.SyntaxToken
            firstSemicolonToken, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            condition, Microsoft.CodeAnalysis.SyntaxToken
            secondSemicolonToken, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
            incrementors, Microsoft.CodeAnalysis.SyntaxToken
            closeParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement)
            {
                var return_v = ForStatement(attributeLists: attributeLists, forKeyword, openParenToken, declaration, initializers, firstSemicolonToken, condition, secondSemicolonToken, incrementors, closeParenToken, statement);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10768, 1838, 2026);
                return return_v;
            }

        }
    }
}

