// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class ForEachVariableStatementSyntax
    {
        public ForEachVariableStatementSyntax Update(SyntaxToken forEachKeyword, SyntaxToken openParenToken, ExpressionSyntax variable, SyntaxToken inKeyword, ExpressionSyntax expression, SyntaxToken closeParenToken, StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10767, 627, 752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10767, 630, 752);
                return f_10767_630_752(this, awaitKeyword: default, forEachKeyword, openParenToken, variable, inKeyword, expression, closeParenToken, statement); DynAbs.Tracing.TraceSender.TraceExitMethod(10767, 627, 752);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10767, 627, 752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10767, 627, 752);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ForEachVariableStatementSyntax
            f_10767_630_752(Microsoft.CodeAnalysis.CSharp.Syntax.ForEachVariableStatementSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxToken
            awaitKeyword, Microsoft.CodeAnalysis.SyntaxToken
            forEachKeyword, Microsoft.CodeAnalysis.SyntaxToken
            openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            variable, Microsoft.CodeAnalysis.SyntaxToken
            inKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expression, Microsoft.CodeAnalysis.SyntaxToken
            closeParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement)
            {
                var return_v = this_param.Update(awaitKeyword: awaitKeyword, forEachKeyword, openParenToken, variable, inKeyword, expression, closeParenToken, statement);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10767, 630, 752);
                return return_v;
            }

        }

        public ForEachVariableStatementSyntax Update(SyntaxToken awaitKeyword, SyntaxToken forEachKeyword, SyntaxToken openParenToken, ExpressionSyntax variable, SyntaxToken inKeyword, ExpressionSyntax expression, SyntaxToken closeParenToken, StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10767, 1040, 1181);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10767, 1043, 1181);
                return f_10767_1043_1181(this, attributeLists: default, awaitKeyword, forEachKeyword, openParenToken, variable, inKeyword, expression, closeParenToken, statement); DynAbs.Tracing.TraceSender.TraceExitMethod(10767, 1040, 1181);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10767, 1040, 1181);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10767, 1040, 1181);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ForEachVariableStatementSyntax
            f_10767_1043_1181(Microsoft.CodeAnalysis.CSharp.Syntax.ForEachVariableStatementSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            awaitKeyword, Microsoft.CodeAnalysis.SyntaxToken
            forEachKeyword, Microsoft.CodeAnalysis.SyntaxToken
            openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            variable, Microsoft.CodeAnalysis.SyntaxToken
            inKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expression, Microsoft.CodeAnalysis.SyntaxToken
            closeParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement)
            {
                var return_v = this_param.Update(attributeLists: attributeLists, awaitKeyword, forEachKeyword, openParenToken, variable, inKeyword, expression, closeParenToken, statement);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10767, 1043, 1181);
                return return_v;
            }

        }

        static ForEachVariableStatementSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10767, 310, 1189);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10767, 310, 1189);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10767, 310, 1189);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10767, 310, 1189);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static ForEachVariableStatementSyntax ForEachVariableStatement(SyntaxToken forEachKeyword, SyntaxToken openParenToken, ExpressionSyntax variable, SyntaxToken inKeyword, ExpressionSyntax expression, SyntaxToken closeParenToken, StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10767, 1569, 1712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10767, 1572, 1712);
                return f_10767_1572_1712(awaitKeyword: default, forEachKeyword, openParenToken, variable, inKeyword, expression, closeParenToken, statement); DynAbs.Tracing.TraceSender.TraceExitMethod(10767, 1569, 1712);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10767, 1569, 1712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10767, 1569, 1712);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ForEachVariableStatementSyntax
            f_10767_1572_1712(Microsoft.CodeAnalysis.SyntaxToken
            awaitKeyword, Microsoft.CodeAnalysis.SyntaxToken
            forEachKeyword, Microsoft.CodeAnalysis.SyntaxToken
            openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            variable, Microsoft.CodeAnalysis.SyntaxToken
            inKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expression, Microsoft.CodeAnalysis.SyntaxToken
            closeParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement)
            {
                var return_v = ForEachVariableStatement(awaitKeyword: awaitKeyword, forEachKeyword, openParenToken, variable, inKeyword, expression, closeParenToken, statement);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10767, 1572, 1712);
                return return_v;
            }

        }

        public static ForEachVariableStatementSyntax ForEachVariableStatement(SyntaxToken awaitKeyword, SyntaxToken forEachKeyword, SyntaxToken openParenToken, ExpressionSyntax variable, SyntaxToken inKeyword, ExpressionSyntax expression, SyntaxToken closeParenToken, StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10767, 2025, 2184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10767, 2028, 2184);
                return f_10767_2028_2184(attributeLists: default, awaitKeyword, forEachKeyword, openParenToken, variable, inKeyword, expression, closeParenToken, statement); DynAbs.Tracing.TraceSender.TraceExitMethod(10767, 2025, 2184);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10767, 2025, 2184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10767, 2025, 2184);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ForEachVariableStatementSyntax
            f_10767_2028_2184(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            awaitKeyword, Microsoft.CodeAnalysis.SyntaxToken
            forEachKeyword, Microsoft.CodeAnalysis.SyntaxToken
            openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            variable, Microsoft.CodeAnalysis.SyntaxToken
            inKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expression, Microsoft.CodeAnalysis.SyntaxToken
            closeParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement)
            {
                var return_v = ForEachVariableStatement(attributeLists: attributeLists, awaitKeyword, forEachKeyword, openParenToken, variable, inKeyword, expression, closeParenToken, statement);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10767, 2028, 2184);
                return return_v;
            }

        }
    }
}
