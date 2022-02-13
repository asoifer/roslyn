// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class ForEachStatementSyntax
    {
        public ForEachStatementSyntax Update(SyntaxToken forEachKeyword, SyntaxToken openParenToken, TypeSyntax type, SyntaxToken identifier, SyntaxToken inKeyword, ExpressionSyntax expression, SyntaxToken closeParenToken, StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10766, 625, 758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10766, 628, 758);
                return f_10766_628_758(this, awaitKeyword: default, forEachKeyword, openParenToken, type, identifier, inKeyword, expression, closeParenToken, statement); DynAbs.Tracing.TraceSender.TraceExitMethod(10766, 625, 758);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10766, 625, 758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10766, 625, 758);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
            f_10766_628_758(Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxToken
            awaitKeyword, Microsoft.CodeAnalysis.SyntaxToken
            forEachKeyword, Microsoft.CodeAnalysis.SyntaxToken
            openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
            type, Microsoft.CodeAnalysis.SyntaxToken
            identifier, Microsoft.CodeAnalysis.SyntaxToken
            inKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expression, Microsoft.CodeAnalysis.SyntaxToken
            closeParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement)
            {
                var return_v = this_param.Update(awaitKeyword: awaitKeyword, forEachKeyword, openParenToken, type, identifier, inKeyword, expression, closeParenToken, statement);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10766, 628, 758);
                return return_v;
            }

        }

        public ForEachStatementSyntax Update(SyntaxToken awaitKeyword, SyntaxToken forEachKeyword, SyntaxToken openParenToken, TypeSyntax type, SyntaxToken identifier, SyntaxToken inKeyword, ExpressionSyntax expression, SyntaxToken closeParenToken, StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10766, 1052, 1201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10766, 1055, 1201);
                return f_10766_1055_1201(this, attributeLists: default, awaitKeyword, forEachKeyword, openParenToken, type, identifier, inKeyword, expression, closeParenToken, statement); DynAbs.Tracing.TraceSender.TraceExitMethod(10766, 1052, 1201);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10766, 1052, 1201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10766, 1052, 1201);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
            f_10766_1055_1201(Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            awaitKeyword, Microsoft.CodeAnalysis.SyntaxToken
            forEachKeyword, Microsoft.CodeAnalysis.SyntaxToken
            openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
            type, Microsoft.CodeAnalysis.SyntaxToken
            identifier, Microsoft.CodeAnalysis.SyntaxToken
            inKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expression, Microsoft.CodeAnalysis.SyntaxToken
            closeParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement)
            {
                var return_v = this_param.Update(attributeLists: attributeLists, awaitKeyword, forEachKeyword, openParenToken, type, identifier, inKeyword, expression, closeParenToken, statement);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10766, 1055, 1201);
                return return_v;
            }

        }

        static ForEachStatementSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10766, 310, 1209);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10766, 310, 1209);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10766, 310, 1209);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10766, 310, 1209);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static ForEachStatementSyntax ForEachStatement(SyntaxToken forEachKeyword, SyntaxToken openParenToken, TypeSyntax type, SyntaxToken identifier, SyntaxToken inKeyword, ExpressionSyntax expression, SyntaxToken closeParenToken, StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10766, 1587, 1730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10766, 1590, 1730);
                return f_10766_1590_1730(awaitKeyword: default, forEachKeyword, openParenToken, type, identifier, inKeyword, expression, closeParenToken, statement); DynAbs.Tracing.TraceSender.TraceExitMethod(10766, 1587, 1730);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10766, 1587, 1730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10766, 1587, 1730);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
            f_10766_1590_1730(Microsoft.CodeAnalysis.SyntaxToken
            awaitKeyword, Microsoft.CodeAnalysis.SyntaxToken
            forEachKeyword, Microsoft.CodeAnalysis.SyntaxToken
            openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
            type, Microsoft.CodeAnalysis.SyntaxToken
            identifier, Microsoft.CodeAnalysis.SyntaxToken
            inKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expression, Microsoft.CodeAnalysis.SyntaxToken
            closeParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement)
            {
                var return_v = ForEachStatement(awaitKeyword: awaitKeyword, forEachKeyword, openParenToken, type, identifier, inKeyword, expression, closeParenToken, statement);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10766, 1590, 1730);
                return return_v;
            }

        }

        public static ForEachStatementSyntax ForEachStatement(SyntaxToken awaitKeyword, SyntaxToken forEachKeyword, SyntaxToken openParenToken, TypeSyntax type, SyntaxToken identifier, SyntaxToken inKeyword, ExpressionSyntax expression, SyntaxToken closeParenToken, StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10766, 2041, 2200);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10766, 2044, 2200);
                return f_10766_2044_2200(attributeLists: default, awaitKeyword, forEachKeyword, openParenToken, type, identifier, inKeyword, expression, closeParenToken, statement); DynAbs.Tracing.TraceSender.TraceExitMethod(10766, 2041, 2200);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10766, 2041, 2200);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10766, 2041, 2200);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
            f_10766_2044_2200(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            awaitKeyword, Microsoft.CodeAnalysis.SyntaxToken
            forEachKeyword, Microsoft.CodeAnalysis.SyntaxToken
            openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
            type, Microsoft.CodeAnalysis.SyntaxToken
            identifier, Microsoft.CodeAnalysis.SyntaxToken
            inKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expression, Microsoft.CodeAnalysis.SyntaxToken
            closeParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement)
            {
                var return_v = ForEachStatement(attributeLists: attributeLists, awaitKeyword, forEachKeyword, openParenToken, type, identifier, inKeyword, expression, closeParenToken, statement);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10766, 2044, 2200);
                return return_v;
            }

        }
    }
}
