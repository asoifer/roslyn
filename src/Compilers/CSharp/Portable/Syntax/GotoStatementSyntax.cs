// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class GotoStatementSyntax
    {
        public GotoStatementSyntax Update(SyntaxToken gotoKeyword, SyntaxToken caseOrDefaultKeyword, ExpressionSyntax expression, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10771, 530, 627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10771, 533, 627);
                return f_10771_533_627(this, attributeLists: default, gotoKeyword, caseOrDefaultKeyword, expression, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10771, 530, 627);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10771, 530, 627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10771, 530, 627);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax
            f_10771_533_627(Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            gotoKeyword, Microsoft.CodeAnalysis.SyntaxToken
            caseOrDefaultKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expression, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = this_param.Update(attributeLists: attributeLists, gotoKeyword, caseOrDefaultKeyword, expression, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10771, 533, 627);
                return return_v;
            }

        }

        static GotoStatementSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10771, 310, 635);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10771, 310, 635);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10771, 310, 635);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10771, 310, 635);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static GotoStatementSyntax GotoStatement(SyntaxKind kind, SyntaxToken caseOrDefaultKeyword, ExpressionSyntax expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10771, 882, 963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10771, 885, 963);
                return f_10771_885_963(kind, attributeLists: default, caseOrDefaultKeyword, expression); DynAbs.Tracing.TraceSender.TraceExitMethod(10771, 882, 963);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10771, 882, 963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10771, 882, 963);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax
            f_10771_885_963(Microsoft.CodeAnalysis.CSharp.SyntaxKind
            kind, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            caseOrDefaultKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expression)
            {
                var return_v = GotoStatement(kind, attributeLists: attributeLists, caseOrDefaultKeyword, expression);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10771, 885, 963);
                return return_v;
            }

        }

        public static GotoStatementSyntax GotoStatement(SyntaxKind kind, SyntaxToken gotoKeyword, SyntaxToken caseOrDefaultKeyword, ExpressionSyntax expression, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10771, 1170, 1280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10771, 1173, 1280);
                return f_10771_1173_1280(kind, attributeLists: default, gotoKeyword, caseOrDefaultKeyword, expression, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10771, 1170, 1280);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10771, 1170, 1280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10771, 1170, 1280);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax
            f_10771_1173_1280(Microsoft.CodeAnalysis.CSharp.SyntaxKind
            kind, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            gotoKeyword, Microsoft.CodeAnalysis.SyntaxToken
            caseOrDefaultKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expression, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = GotoStatement(kind, attributeLists: attributeLists, gotoKeyword, caseOrDefaultKeyword, expression, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10771, 1173, 1280);
                return return_v;
            }

        }
    }
}
