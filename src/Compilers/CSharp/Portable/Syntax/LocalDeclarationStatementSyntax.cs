// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class LocalDeclarationStatementSyntax
    {
        public LocalDeclarationStatementSyntax Update(SyntaxTokenList modifiers, VariableDeclarationSyntax declaration, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10778, 532, 627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10778, 535, 627);
                return f_10778_535_627(this, awaitKeyword: default, usingKeyword: default, modifiers, declaration, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10778, 532, 627);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10778, 532, 627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10778, 532, 627);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
            f_10778_535_627(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxToken
            awaitKeyword, Microsoft.CodeAnalysis.SyntaxToken
            usingKeyword, Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
            declaration, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = this_param.Update(awaitKeyword: awaitKeyword, usingKeyword: usingKeyword, modifiers, declaration, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10778, 535, 627);
                return return_v;
            }

        }

        public LocalDeclarationStatementSyntax Update(SyntaxToken awaitKeyword, SyntaxToken usingKeyword, SyntaxTokenList modifiers, VariableDeclarationSyntax declaration, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10778, 845, 947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10778, 848, 947);
                return f_10778_848_947(this, attributeLists: default, awaitKeyword, usingKeyword, modifiers, declaration, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10778, 845, 947);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10778, 845, 947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10778, 845, 947);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
            f_10778_848_947(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            awaitKeyword, Microsoft.CodeAnalysis.SyntaxToken
            usingKeyword, Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
            declaration, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = this_param.Update(attributeLists: attributeLists, awaitKeyword, usingKeyword, modifiers, declaration, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10778, 848, 947);
                return return_v;
            }

        }
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static LocalDeclarationStatementSyntax LocalDeclarationStatement(SyntaxTokenList modifiers, VariableDeclarationSyntax declaration, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10778, 1240, 1354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10778, 1243, 1354);
                return f_10778_1243_1354(awaitKeyword: default, usingKeyword: default, modifiers, declaration, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10778, 1240, 1354);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10778, 1240, 1354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10778, 1240, 1354);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
            f_10778_1243_1354(Microsoft.CodeAnalysis.SyntaxToken
            awaitKeyword, Microsoft.CodeAnalysis.SyntaxToken
            usingKeyword, Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
            declaration, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = LocalDeclarationStatement(awaitKeyword: awaitKeyword, usingKeyword: usingKeyword, modifiers, declaration, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10778, 1243, 1354);
                return return_v;
            }

        }

        public static LocalDeclarationStatementSyntax LocalDeclarationStatement(SyntaxToken awaitKeyword, SyntaxToken usingKeyword, SyntaxTokenList modifiers, VariableDeclarationSyntax declaration, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10778, 1598, 1719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10778, 1601, 1719);
                return f_10778_1601_1719(attributeLists: default, awaitKeyword, usingKeyword, modifiers, declaration, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10778, 1598, 1719);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10778, 1598, 1719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10778, 1598, 1719);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
            f_10778_1601_1719(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            awaitKeyword, Microsoft.CodeAnalysis.SyntaxToken
            usingKeyword, Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
            declaration, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = LocalDeclarationStatement(attributeLists: attributeLists, awaitKeyword, usingKeyword, modifiers, declaration, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10778, 1601, 1719);
                return return_v;
            }

        }

        public static LocalDeclarationStatementSyntax LocalDeclarationStatement(SyntaxTokenList modifiers, VariableDeclarationSyntax declaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10778, 1883, 1960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10778, 1886, 1960);
                return f_10778_1886_1960(attributeLists: default, modifiers, declaration); DynAbs.Tracing.TraceSender.TraceExitMethod(10778, 1883, 1960);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10778, 1883, 1960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10778, 1883, 1960);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
            f_10778_1886_1960(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
            declaration)
            {
                var return_v = LocalDeclarationStatement(attributeLists: attributeLists, modifiers, declaration);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10778, 1886, 1960);
                return return_v;
            }

        }
    }
}
