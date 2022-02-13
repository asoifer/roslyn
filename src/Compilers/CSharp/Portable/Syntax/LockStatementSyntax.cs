// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class LockStatementSyntax
    {
        public LockStatementSyntax Update(SyntaxToken lockKeyword, SyntaxToken openParenToken, ExpressionSyntax expression, SyntaxToken closeParenToken, StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10780, 552, 655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10780, 555, 655);
                return f_10780_555_655(this, attributeLists: default, lockKeyword, openParenToken, expression, closeParenToken, statement); DynAbs.Tracing.TraceSender.TraceExitMethod(10780, 552, 655);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10780, 552, 655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10780, 552, 655);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
            f_10780_555_655(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            lockKeyword, Microsoft.CodeAnalysis.SyntaxToken
            openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expression, Microsoft.CodeAnalysis.SyntaxToken
            closeParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement)
            {
                var return_v = this_param.Update(attributeLists: attributeLists, lockKeyword, openParenToken, expression, closeParenToken, statement);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10780, 555, 655);
                return return_v;
            }

        }

        static LockStatementSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10780, 310, 663);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10780, 310, 663);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10780, 310, 663);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10780, 310, 663);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static LockStatementSyntax LockStatement(SyntaxToken lockKeyword, SyntaxToken openParenToken, ExpressionSyntax expression, SyntaxToken closeParenToken, StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10780, 968, 1078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10780, 971, 1078);
                return f_10780_971_1078(attributeLists: default, lockKeyword, openParenToken, expression, closeParenToken, statement); DynAbs.Tracing.TraceSender.TraceExitMethod(10780, 968, 1078);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10780, 968, 1078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10780, 968, 1078);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
            f_10780_971_1078(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            lockKeyword, Microsoft.CodeAnalysis.SyntaxToken
            openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expression, Microsoft.CodeAnalysis.SyntaxToken
            closeParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement)
            {
                var return_v = LockStatement(attributeLists: attributeLists, lockKeyword, openParenToken, expression, closeParenToken, statement);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10780, 971, 1078);
                return return_v;
            }

        }
    }
}
