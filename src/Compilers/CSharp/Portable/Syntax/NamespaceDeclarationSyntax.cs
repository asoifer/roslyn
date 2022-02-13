// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class NamespaceDeclarationSyntax
    {
        internal new InternalSyntax.NamespaceDeclarationSyntax Green
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10783, 541, 653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10783, 577, 638);

                    return (InternalSyntax.NamespaceDeclarationSyntax)DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Green, 10783, 627, 637);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10783, 541, 653);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10783, 456, 664);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10783, 456, 664);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public NamespaceDeclarationSyntax Update(SyntaxToken namespaceKeyword, NameSyntax name, SyntaxToken openBraceToken, SyntaxList<ExternAliasDirectiveSyntax> externs, SyntaxList<UsingDirectiveSyntax> usings, SyntaxList<MemberDeclarationSyntax> members, SyntaxToken closeBraceToken, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10783, 996, 1146);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10783, 999, 1146);
                return f_10783_999_1146(this, f_10783_1011_1030(this), f_10783_1032_1046(this), namespaceKeyword, name, openBraceToken, externs, usings, members, closeBraceToken, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10783, 996, 1146);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10783, 996, 1146);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10783, 996, 1146);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            f_10783_1011_1030(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
            this_param)
            {
                var return_v = this_param.AttributeLists;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10783, 1011, 1030);
                return return_v;
            }


            Microsoft.CodeAnalysis.SyntaxTokenList
            f_10783_1032_1046(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
            this_param)
            {
                var return_v = this_param.Modifiers;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10783, 1032, 1046);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
            f_10783_999_1146(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.SyntaxToken
            namespaceKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
            name, Microsoft.CodeAnalysis.SyntaxToken
            openBraceToken, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax>
            externs, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>
            usings, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
            members, Microsoft.CodeAnalysis.SyntaxToken
            closeBraceToken, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = this_param.Update(attributeLists, modifiers, namespaceKeyword, name, openBraceToken, externs, usings, members, closeBraceToken, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10783, 999, 1146);
                return return_v;
            }

        }

        static NamespaceDeclarationSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10783, 392, 1154);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10783, 392, 1154);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10783, 392, 1154);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10783, 392, 1154);
    }
}
