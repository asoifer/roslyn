// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class DoStatementSyntax
    {
        public DoStatementSyntax Update(SyntaxToken doKeyword, StatementSyntax statement, SyntaxToken whileKeyword, SyntaxToken openParenToken, ExpressionSyntax condition, SyntaxToken closeParenToken, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10760, 599, 729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10760, 602, 729);
                return f_10760_602_729(this, attributeLists: default, doKeyword, statement, whileKeyword, openParenToken, condition, closeParenToken, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10760, 599, 729);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10760, 599, 729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10760, 599, 729);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax
            f_10760_602_729(Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            doKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement, Microsoft.CodeAnalysis.SyntaxToken
            whileKeyword, Microsoft.CodeAnalysis.SyntaxToken
            openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            condition, Microsoft.CodeAnalysis.SyntaxToken
            closeParenToken, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = this_param.Update(attributeLists: attributeLists, doKeyword, statement, whileKeyword, openParenToken, condition, closeParenToken, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10760, 602, 729);
                return return_v;
            }

        }

        static DoStatementSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10760, 310, 737);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10760, 310, 737);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10760, 310, 737);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10760, 310, 737);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static DoStatementSyntax DoStatement(SyntaxToken doKeyword, StatementSyntax statement, SyntaxToken whileKeyword, SyntaxToken openParenToken, ExpressionSyntax condition, SyntaxToken closeParenToken, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10760, 1089, 1224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10760, 1092, 1224);
                return f_10760_1092_1224(attributeLists: default, doKeyword, statement, whileKeyword, openParenToken, condition, closeParenToken, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10760, 1089, 1224);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10760, 1089, 1224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10760, 1089, 1224);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax
            f_10760_1092_1224(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            doKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement, Microsoft.CodeAnalysis.SyntaxToken
            whileKeyword, Microsoft.CodeAnalysis.SyntaxToken
            openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            condition, Microsoft.CodeAnalysis.SyntaxToken
            closeParenToken, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = DoStatement(attributeLists: attributeLists, doKeyword, statement, whileKeyword, openParenToken, condition, closeParenToken, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10760, 1092, 1224);
                return return_v;
            }

        }
    }
}
