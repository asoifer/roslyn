// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static LocalFunctionStatementSyntax LocalFunctionStatement(SyntaxTokenList modifiers, TypeSyntax returnType, SyntaxToken identifier, TypeParameterListSyntax typeParameterList, ParameterListSyntax parameterList, SyntaxList<TypeParameterConstraintClauseSyntax> constraintClauses, BlockSyntax body, ArrowExpressionClauseSyntax expressionBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10779, 423, 995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10779, 794, 984);

                return f_10779_801_983(attributeLists: default, modifiers, returnType, identifier, typeParameterList, parameterList, constraintClauses, body, expressionBody, semicolonToken: default);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10779, 423, 995);

                Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                f_10779_801_983(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                returnType, Microsoft.CodeAnalysis.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                typeParameterList, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                parameterList, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                constraintClauses, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                body, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                expressionBody, Microsoft.CodeAnalysis.SyntaxToken
                semicolonToken)
                {
                    var return_v = LocalFunctionStatement(attributeLists: attributeLists, modifiers, returnType, identifier, typeParameterList, parameterList, constraintClauses, body, expressionBody, semicolonToken: semicolonToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10779, 801, 983);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10779, 423, 995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10779, 423, 995);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static LocalFunctionStatementSyntax LocalFunctionStatement(SyntaxTokenList modifiers, TypeSyntax returnType, SyntaxToken identifier, TypeParameterListSyntax typeParameterList, ParameterListSyntax parameterList, SyntaxList<TypeParameterConstraintClauseSyntax> constraintClauses, BlockSyntax body, ArrowExpressionClauseSyntax expressionBody, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10779, 1076, 1667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10779, 1475, 1656);

                return f_10779_1482_1655(attributeLists: default, modifiers, returnType, identifier, typeParameterList, parameterList, constraintClauses, body, expressionBody, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10779, 1076, 1667);

                Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                f_10779_1482_1655(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                returnType, Microsoft.CodeAnalysis.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                typeParameterList, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                parameterList, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                constraintClauses, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                body, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                expressionBody, Microsoft.CodeAnalysis.SyntaxToken
                semicolonToken)
                {
                    var return_v = LocalFunctionStatement(attributeLists: attributeLists, modifiers, returnType, identifier, typeParameterList, parameterList, constraintClauses, body, expressionBody, semicolonToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10779, 1482, 1655);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10779, 1076, 1667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10779, 1076, 1667);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class LocalFunctionStatementSyntax
    {
        public LocalFunctionStatementSyntax Update(SyntaxTokenList modifiers, TypeSyntax returnType, SyntaxToken identifier, TypeParameterListSyntax typeParameterList, ParameterListSyntax parameterList, SyntaxList<TypeParameterConstraintClauseSyntax> constraintClauses, BlockSyntax body, ArrowExpressionClauseSyntax expressionBody, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10779, 1871, 2423);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10779, 2247, 2412);

                return f_10779_2254_2411(this, attributeLists: default, modifiers, returnType, identifier, typeParameterList, parameterList, constraintClauses, body, expressionBody, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10779, 1871, 2423);

                Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                f_10779_2254_2411(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                returnType, Microsoft.CodeAnalysis.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                typeParameterList, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                parameterList, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                constraintClauses, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                body, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                expressionBody, Microsoft.CodeAnalysis.SyntaxToken
                semicolonToken)
                {
                    var return_v = this_param.Update(attributeLists: attributeLists, modifiers, returnType, identifier, typeParameterList, parameterList, constraintClauses, body, expressionBody, semicolonToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10779, 2254, 2411);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10779, 1871, 2423);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10779, 1871, 2423);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LocalFunctionStatementSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10779, 1736, 2430);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10779, 1736, 2430);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10779, 1736, 2430);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10779, 1736, 2430);
    }
}
