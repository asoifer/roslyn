// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class MethodDeclarationSyntax
    {
        public int Arity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10782, 494, 629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10782, 530, 614);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10782, 537, 567) || ((f_10782_537_559(this) == null && DynAbs.Tracing.TraceSender.Conditional_F2(10782, 570, 571)) || DynAbs.Tracing.TraceSender.Conditional_F3(10782, 574, 613))) ? 0 : f_10782_574_596(this).Parameters.Count;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10782, 494, 629);

                    Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
                    f_10782_537_559(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.TypeParameterList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10782, 537, 559);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                    f_10782_574_596(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.TypeParameterList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10782, 574, 596);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10782, 453, 640);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10782, 453, 640);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static MethodDeclarationSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10782, 392, 647);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10782, 392, 647);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10782, 392, 647);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10782, 392, 647);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static MethodDeclarationSyntax MethodDeclaration(
                    SyntaxList<AttributeListSyntax> attributeLists,
                    SyntaxTokenList modifiers,
                    TypeSyntax returnType,
                    ExplicitInterfaceSpecifierSyntax explicitInterfaceSpecifier,
                    SyntaxToken identifier,
                    TypeParameterListSyntax typeParameterList,
                    ParameterListSyntax parameterList,
                    SyntaxList<TypeParameterConstraintClauseSyntax> constraintClauses,
                    BlockSyntax body,
                    SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10782, 753, 1736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10782, 1338, 1725);

                return f_10782_1345_1724(attributeLists, modifiers, returnType, explicitInterfaceSpecifier, identifier, typeParameterList, parameterList, constraintClauses, body, null, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10782, 753, 1736);

                Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                f_10782_1345_1724(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                returnType, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
                explicitInterfaceSpecifier, Microsoft.CodeAnalysis.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                typeParameterList, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                parameterList, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                constraintClauses, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                body, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                expressionBody, Microsoft.CodeAnalysis.SyntaxToken
                semicolonToken)
                {
                    var return_v = SyntaxFactory.MethodDeclaration(attributeLists, modifiers, returnType, explicitInterfaceSpecifier, identifier, typeParameterList, parameterList, constraintClauses, body, expressionBody, semicolonToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10782, 1345, 1724);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10782, 753, 1736);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10782, 753, 1736);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
