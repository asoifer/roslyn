// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.ComponentModel;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class PropertyDeclarationSyntax
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This member is obsolete.", true)]
        public SyntaxToken Semicolon
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10790, 580, 658);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10790, 616, 643);

                    return f_10790_623_642(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10790, 580, 658);

                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10790_623_642(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                    this_param)
                    {
                        var return_v = this_param.SemicolonToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10790, 623, 642);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10790, 418, 669);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10790, 418, 669);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This member is obsolete.", true)]
        public PropertyDeclarationSyntax WithSemicolon(SyntaxToken semicolon)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10790, 681, 937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10790, 884, 926);

                return f_10790_891_925(this, semicolon);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10790, 681, 937);

                Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                f_10790_891_925(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                semicolonToken)
                {
                    var return_v = this_param.WithSemicolonToken(semicolonToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10790, 891, 925);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10790, 681, 937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10790, 681, 937);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PropertyDeclarationSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10790, 355, 944);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10790, 355, 944);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10790, 355, 944);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10790, 355, 944);
    }
    public sealed partial class AccessorDeclarationSyntax : CSharpSyntaxNode
    {
        public AccessorDeclarationSyntax Update(SyntaxList<AttributeListSyntax> attributeLists, SyntaxTokenList modifiers, SyntaxToken keyword, BlockSyntax body, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10790, 1286, 1375);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10790, 1289, 1375);
                return f_10790_1289_1375(this, attributeLists, modifiers, keyword, body, expressionBody: null, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10790, 1286, 1375);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10790, 1286, 1375);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10790, 1286, 1375);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
            f_10790_1289_1375(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.SyntaxToken
            keyword, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            body, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
            expressionBody, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = this_param.Update(attributeLists, modifiers, keyword, body, expressionBody: expressionBody, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10790, 1289, 1375);
                return return_v;
            }

        }

        static AccessorDeclarationSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10790, 1002, 1383);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10790, 1002, 1383);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10790, 1002, 1383);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10790, 1002, 1383);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static AccessorDeclarationSyntax AccessorDeclaration(SyntaxKind kind, BlockSyntax body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10790, 1571, 1928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10790, 1690, 1917);

                return f_10790_1697_1916(kind, default(SyntaxList<AttributeListSyntax>), default(SyntaxTokenList), f_10790_1805_1865(f_10790_1825_1864(kind)), body, expressionBody: null, default(SyntaxToken));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10790, 1571, 1928);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10790_1825_1864(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = GetAccessorDeclarationKeywordKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10790, 1825, 1864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10790_1805_1865(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10790, 1805, 1865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                f_10790_1697_1916(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.SyntaxToken
                keyword, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                body, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                expressionBody, Microsoft.CodeAnalysis.SyntaxToken
                semicolonToken)
                {
                    var return_v = SyntaxFactory.AccessorDeclaration(kind, attributeLists, modifiers, keyword, body, expressionBody: expressionBody, semicolonToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10790, 1697, 1916);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10790, 1571, 1928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10790, 1571, 1928);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}

