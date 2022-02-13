// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class IfStatementSyntax
    {
        public IfStatementSyntax Update(SyntaxToken ifKeyword, SyntaxToken openParenToken, ExpressionSyntax condition, SyntaxToken closeParenToken, StatementSyntax statement, ElseClauseSyntax @else)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10773, 569, 676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10773, 572, 676);
                return f_10773_572_676(this, attributeLists: default, ifKeyword, openParenToken, condition, closeParenToken, statement, @else); DynAbs.Tracing.TraceSender.TraceExitMethod(10773, 569, 676);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10773, 569, 676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10773, 569, 676);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax
            f_10773_572_676(Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            ifKeyword, Microsoft.CodeAnalysis.SyntaxToken
            openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            condition, Microsoft.CodeAnalysis.SyntaxToken
            closeParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement, Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax
            @else)
            {
                var return_v = this_param.Update(attributeLists: attributeLists, ifKeyword, openParenToken, condition, closeParenToken, statement, @else);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10773, 572, 676);
                return return_v;
            }

        }

        static IfStatementSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10773, 310, 684);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10773, 310, 684);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10773, 310, 684);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10773, 310, 684);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static IfStatementSyntax IfStatement(ExpressionSyntax condition, StatementSyntax statement, ElseClauseSyntax @else)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10773, 926, 994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10773, 929, 994);
                return f_10773_929_994(attributeLists: default, condition, statement, @else); DynAbs.Tracing.TraceSender.TraceExitMethod(10773, 926, 994);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10773, 926, 994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10773, 926, 994);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax
            f_10773_929_994(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            condition, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement, Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax
            @else)
            {
                var return_v = IfStatement(attributeLists: attributeLists, condition, statement, @else);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10773, 929, 994);
                return return_v;
            }

        }

        public static IfStatementSyntax IfStatement(SyntaxToken ifKeyword, SyntaxToken openParenToken, ExpressionSyntax condition, SyntaxToken closeParenToken, StatementSyntax statement, ElseClauseSyntax @else)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10773, 1223, 1335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10773, 1226, 1335);
                return f_10773_1226_1335(attributeLists: default, ifKeyword, openParenToken, condition, closeParenToken, statement, @else); DynAbs.Tracing.TraceSender.TraceExitMethod(10773, 1223, 1335);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10773, 1223, 1335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10773, 1223, 1335);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax
            f_10773_1226_1335(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            ifKeyword, Microsoft.CodeAnalysis.SyntaxToken
            openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            condition, Microsoft.CodeAnalysis.SyntaxToken
            closeParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement, Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax
            @else)
            {
                var return_v = IfStatement(attributeLists: attributeLists, ifKeyword, openParenToken, condition, closeParenToken, statement, @else);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10773, 1226, 1335);
                return return_v;
            }

        }
    }
}
