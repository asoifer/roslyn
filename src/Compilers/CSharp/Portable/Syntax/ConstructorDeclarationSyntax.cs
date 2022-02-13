// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class ConstructorDeclarationSyntax
    {
        public ConstructorDeclarationSyntax Update(
                    SyntaxList<AttributeListSyntax> attributeLists,
                    SyntaxTokenList modifiers,
                    SyntaxToken identifier,
                    ParameterListSyntax parameterList,
                    ConstructorInitializerSyntax initializer,
                    BlockSyntax body,
                    SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10748, 828, 1085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10748, 831, 1085);
                return f_10748_831_1085(this, attributeLists, modifiers, identifier, parameterList, initializer, body, expressionBody: null, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10748, 828, 1085);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10748, 828, 1085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10748, 828, 1085);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
            f_10748_831_1085(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.SyntaxToken
            identifier, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
            initializer, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            body, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
            expressionBody, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = this_param.Update(attributeLists, modifiers, identifier, parameterList, initializer, body, expressionBody: expressionBody, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10748, 831, 1085);
                return return_v;
            }

        }

        static ConstructorDeclarationSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10748, 392, 1093);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10748, 392, 1093);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10748, 392, 1093);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10748, 392, 1093);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static ConstructorDeclarationSyntax ConstructorDeclaration(
                    SyntaxList<AttributeListSyntax> attributeLists,
                    SyntaxTokenList modifiers,
                    SyntaxToken identifier,
                    ParameterListSyntax parameterList,
                    ConstructorInitializerSyntax initializer,
                    BlockSyntax body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10748, 1551, 1830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10748, 1554, 1830);
                return f_10748_1554_1830(attributeLists, modifiers, identifier, parameterList, initializer, body, expressionBody: null, default(SyntaxToken)); DynAbs.Tracing.TraceSender.TraceExitMethod(10748, 1551, 1830);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10748, 1551, 1830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10748, 1551, 1830);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
            f_10748_1554_1830(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.SyntaxToken
            identifier, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
            initializer, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            body, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
            expressionBody, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = ConstructorDeclaration(attributeLists, modifiers, identifier, parameterList, initializer, body, expressionBody: expressionBody, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10748, 1554, 1830);
                return return_v;
            }

        }

        public static ConstructorDeclarationSyntax ConstructorDeclaration(
                    SyntaxList<AttributeListSyntax> attributeLists,
                    SyntaxTokenList modifiers,
                    SyntaxToken identifier,
                    ParameterListSyntax parameterList,
                    ConstructorInitializerSyntax initializer,
                    BlockSyntax body,
                    SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10748, 2236, 2509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10748, 2239, 2509);
                return f_10748_2239_2509(attributeLists, modifiers, identifier, parameterList, initializer, body, expressionBody: null, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10748, 2236, 2509);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10748, 2236, 2509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10748, 2236, 2509);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
            f_10748_2239_2509(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.SyntaxToken
            identifier, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
            initializer, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            body, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
            expressionBody, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = ConstructorDeclaration(attributeLists, modifiers, identifier, parameterList, initializer, body, expressionBody: expressionBody, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10748, 2239, 2509);
                return return_v;
            }

        }

        public static ConstructorDeclarationSyntax ConstructorDeclaration(
                    SyntaxList<AttributeListSyntax> attributeLists,
                    SyntaxTokenList modifiers,
                    SyntaxToken identifier,
                    ParameterListSyntax parameterList,
                    ConstructorInitializerSyntax initializer,
                    ArrowExpressionClauseSyntax expressionBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10748, 2900, 3179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10748, 2903, 3179);
                return f_10748_2903_3179(attributeLists, modifiers, identifier, parameterList, initializer, body: null, expressionBody, default(SyntaxToken)); DynAbs.Tracing.TraceSender.TraceExitMethod(10748, 2900, 3179);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10748, 2900, 3179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10748, 2900, 3179);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
            f_10748_2903_3179(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.SyntaxToken
            identifier, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
            initializer, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            body, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
            expressionBody, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = ConstructorDeclaration(attributeLists, modifiers, identifier, parameterList, initializer, body: body, expressionBody, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10748, 2903, 3179);
                return return_v;
            }

        }

        public static ConstructorDeclarationSyntax ConstructorDeclaration(
                    SyntaxList<AttributeListSyntax> attributeLists,
                    SyntaxTokenList modifiers,
                    SyntaxToken identifier,
                    ParameterListSyntax parameterList,
                    ConstructorInitializerSyntax initializer,
                    ArrowExpressionClauseSyntax expressionBody,
                    SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10748, 3611, 3884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10748, 3614, 3884);
                return f_10748_3614_3884(attributeLists, modifiers, identifier, parameterList, initializer, body: null, expressionBody, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10748, 3611, 3884);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10748, 3611, 3884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10748, 3611, 3884);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
            f_10748_3614_3884(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.SyntaxToken
            identifier, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
            initializer, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            body, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
            expressionBody, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = ConstructorDeclaration(attributeLists, modifiers, identifier, parameterList, initializer, body: body, expressionBody, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10748, 3614, 3884);
                return return_v;
            }

        }
    }
}
