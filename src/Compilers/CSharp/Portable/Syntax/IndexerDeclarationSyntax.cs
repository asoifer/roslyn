// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.ComponentModel;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class IndexerDeclarationSyntax
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This member is obsolete.", true)]
        public SyntaxToken Semicolon
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10774, 579, 657);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10774, 615, 642);

                    return f_10774_622_641(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10774, 579, 657);

                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10774_622_641(Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.SemicolonToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10774, 622, 641);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10774, 417, 668);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10774, 417, 668);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This member is obsolete.", true)]
        public IndexerDeclarationSyntax WithSemicolon(SyntaxToken semicolon)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10774, 680, 935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10774, 882, 924);

                return f_10774_889_923(this, semicolon);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10774, 680, 935);

                Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax
                f_10774_889_923(Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                semicolonToken)
                {
                    var return_v = this_param.WithSemicolonToken(semicolonToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10774, 889, 923);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10774, 680, 935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10774, 680, 935);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static IndexerDeclarationSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10774, 355, 942);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10774, 355, 942);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10774, 355, 942);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10774, 355, 942);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static IndexerDeclarationSyntax IndexerDeclaration(
                    SyntaxList<AttributeListSyntax> attributeLists,
                    SyntaxTokenList modifiers,
                    TypeSyntax type,
                    ExplicitInterfaceSpecifierSyntax explicitInterfaceSpecifier,
                    BracketedParameterListSyntax parameterList,
                    AccessorListSyntax accessorList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10774, 1048, 1812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10774, 1439, 1801);

                return f_10774_1446_1800(attributeLists: attributeLists, modifiers: modifiers, type: type, explicitInterfaceSpecifier: explicitInterfaceSpecifier, parameterList: parameterList, accessorList: accessorList, expressionBody: null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10774, 1048, 1812);

                Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax
                f_10774_1446_1800(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
                explicitInterfaceSpecifier, Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax
                parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax
                accessorList, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                expressionBody)
                {
                    var return_v = SyntaxFactory.IndexerDeclaration(attributeLists: attributeLists, modifiers: modifiers, type: type, explicitInterfaceSpecifier: explicitInterfaceSpecifier, parameterList: parameterList, accessorList: accessorList, expressionBody: expressionBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10774, 1446, 1800);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10774, 1048, 1812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10774, 1048, 1812);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
