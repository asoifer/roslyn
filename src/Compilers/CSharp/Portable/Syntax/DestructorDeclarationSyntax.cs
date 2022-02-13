// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class DestructorDeclarationSyntax
    {
        public DestructorDeclarationSyntax Update(
                    SyntaxList<AttributeListSyntax> attributeLists,
                    SyntaxTokenList modifiers,
                    SyntaxToken tildeToken,
                    SyntaxToken identifier,
                    ParameterListSyntax parameterList,
                    BlockSyntax body,
                    SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10758, 808, 1064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10758, 811, 1064);
                return f_10758_811_1064(this, attributeLists, modifiers, tildeToken, identifier, parameterList, body, expressionBody: null, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10758, 808, 1064);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10758, 808, 1064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10758, 808, 1064);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
            f_10758_811_1064(Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.SyntaxToken
            tildeToken, Microsoft.CodeAnalysis.SyntaxToken
            identifier, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            body, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
            expressionBody, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = this_param.Update(attributeLists, modifiers, tildeToken, identifier, parameterList, body, expressionBody: expressionBody, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10758, 811, 1064);
                return return_v;
            }

        }

        static DestructorDeclarationSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10758, 392, 1072);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10758, 392, 1072);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10758, 392, 1072);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10758, 392, 1072);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static DestructorDeclarationSyntax DestructorDeclaration(
                    SyntaxList<AttributeListSyntax> attributeLists,
                    SyntaxTokenList modifiers,
                    SyntaxToken identifier,
                    ParameterListSyntax parameterList,
                    BlockSyntax body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10758, 1473, 1782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10758, 1476, 1782);
                return f_10758_1476_1782(attributeLists, modifiers, f_10758_1577_1619(SyntaxKind.TildeToken), identifier, parameterList, body, expressionBody: null, default(SyntaxToken)); DynAbs.Tracing.TraceSender.TraceExitMethod(10758, 1473, 1782);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10758, 1473, 1782);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10758, 1473, 1782);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxToken
            f_10758_1577_1619(Microsoft.CodeAnalysis.CSharp.SyntaxKind
            kind)
            {
                var return_v = SyntaxFactory.Token(kind);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10758, 1577, 1619);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
            f_10758_1476_1782(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.SyntaxToken
            tildeToken, Microsoft.CodeAnalysis.SyntaxToken
            identifier, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            body, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
            expressionBody, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = DestructorDeclaration(attributeLists, modifiers, tildeToken, identifier, parameterList, body, expressionBody: expressionBody, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10758, 1476, 1782);
                return return_v;
            }

        }

        public static DestructorDeclarationSyntax DestructorDeclaration(
                    SyntaxList<AttributeListSyntax> attributeLists,
                    SyntaxTokenList modifiers,
                    SyntaxToken tildeToken,
                    SyntaxToken identifier,
                    ParameterListSyntax parameterList,
                    BlockSyntax body,
                    SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10758, 2168, 2439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10758, 2171, 2439);
                return f_10758_2171_2439(attributeLists, modifiers, tildeToken, identifier, parameterList, body, expressionBody: null, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10758, 2168, 2439);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10758, 2168, 2439);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10758, 2168, 2439);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
            f_10758_2171_2439(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.SyntaxToken
            tildeToken, Microsoft.CodeAnalysis.SyntaxToken
            identifier, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            body, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
            expressionBody, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = DestructorDeclaration(attributeLists, modifiers, tildeToken, identifier, parameterList, body, expressionBody: expressionBody, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10758, 2171, 2439);
                return return_v;
            }

        }

        public static DestructorDeclarationSyntax DestructorDeclaration(
                    SyntaxList<AttributeListSyntax> attributeLists,
                    SyntaxTokenList modifiers,
                    SyntaxToken identifier,
                    ParameterListSyntax parameterList,
                    ArrowExpressionClauseSyntax expressionBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10758, 2773, 3082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10758, 2776, 3082);
                return f_10758_2776_3082(attributeLists, modifiers, f_10758_2877_2919(SyntaxKind.TildeToken), identifier, parameterList, body: null, expressionBody, default(SyntaxToken)); DynAbs.Tracing.TraceSender.TraceExitMethod(10758, 2773, 3082);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10758, 2773, 3082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10758, 2773, 3082);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxToken
            f_10758_2877_2919(Microsoft.CodeAnalysis.CSharp.SyntaxKind
            kind)
            {
                var return_v = SyntaxFactory.Token(kind);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10758, 2877, 2919);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
            f_10758_2776_3082(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.SyntaxToken
            tildeToken, Microsoft.CodeAnalysis.SyntaxToken
            identifier, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            body, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
            expressionBody, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = DestructorDeclaration(attributeLists, modifiers, tildeToken, identifier, parameterList, body: body, expressionBody, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10758, 2776, 3082);
                return return_v;
            }

        }

        public static DestructorDeclarationSyntax DestructorDeclaration(
                    SyntaxList<AttributeListSyntax> attributeLists,
                    SyntaxTokenList modifiers,
                    SyntaxToken tildeToken,
                    SyntaxToken identifier,
                    ParameterListSyntax parameterList,
                    ArrowExpressionClauseSyntax expressionBody,
                    SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10758, 3494, 3765);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10758, 3497, 3765);
                return f_10758_3497_3765(attributeLists, modifiers, tildeToken, identifier, parameterList, body: null, expressionBody, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10758, 3494, 3765);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10758, 3494, 3765);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10758, 3494, 3765);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
            f_10758_3497_3765(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.SyntaxToken
            tildeToken, Microsoft.CodeAnalysis.SyntaxToken
            identifier, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            body, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
            expressionBody, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = DestructorDeclaration(attributeLists, modifiers, tildeToken, identifier, parameterList, body: body, expressionBody, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10758, 3497, 3765);
                return return_v;
            }

        }
    }
}
