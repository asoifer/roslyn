// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.ComponentModel;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class EventDeclarationSyntax
    {
        public EventDeclarationSyntax Update(SyntaxList<AttributeListSyntax> attributeLists, SyntaxTokenList modifiers, SyntaxToken eventKeyword, TypeSyntax type, ExplicitInterfaceSpecifierSyntax explicitInterfaceSpecifier, SyntaxToken identifier, AccessorListSyntax accessorList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10763, 415, 863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10763, 712, 852);

                return f_10763_719_851(this, attributeLists, modifiers, eventKeyword, type, explicitInterfaceSpecifier, identifier, accessorList, semicolonToken: default);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10763, 415, 863);

                Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
                f_10763_719_851(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
                this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.SyntaxToken
                eventKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
                explicitInterfaceSpecifier, Microsoft.CodeAnalysis.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax
                accessorList, Microsoft.CodeAnalysis.SyntaxToken
                semicolonToken)
                {
                    var return_v = this_param.Update(attributeLists, modifiers, eventKeyword, type, explicitInterfaceSpecifier, identifier, accessorList, semicolonToken: semicolonToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10763, 719, 851);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10763, 415, 863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10763, 415, 863);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EventDeclarationSyntax Update(SyntaxList<AttributeListSyntax> attributeLists, SyntaxTokenList modifiers, SyntaxToken eventKeyword, TypeSyntax type, ExplicitInterfaceSpecifierSyntax explicitInterfaceSpecifier, SyntaxToken identifier, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10763, 875, 1315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10763, 1167, 1304);

                return f_10763_1174_1303(this, attributeLists, modifiers, eventKeyword, type, explicitInterfaceSpecifier, identifier, accessorList: null, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10763, 875, 1315);

                Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
                f_10763_1174_1303(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
                this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.SyntaxToken
                eventKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
                explicitInterfaceSpecifier, Microsoft.CodeAnalysis.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax?
                accessorList, Microsoft.CodeAnalysis.SyntaxToken
                semicolonToken)
                {
                    var return_v = this_param.Update(attributeLists, modifiers, eventKeyword, type, explicitInterfaceSpecifier, identifier, accessorList: accessorList, semicolonToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10763, 1174, 1303);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10763, 875, 1315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10763, 875, 1315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EventDeclarationSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10763, 355, 1322);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10763, 355, 1322);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10763, 355, 1322);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10763, 355, 1322);
    }
}
