// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class EnumMemberDeclarationSyntax
    {
        public EnumMemberDeclarationSyntax Update(SyntaxList<AttributeListSyntax> attributeLists, SyntaxToken identifier, EqualsValueClauseSyntax equalsValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10762, 492, 563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10762, 495, 563);
                return f_10762_495_563(this, attributeLists, f_10762_523_537(this), identifier, equalsValue); DynAbs.Tracing.TraceSender.TraceExitMethod(10762, 492, 563);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10762, 492, 563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10762, 492, 563);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxTokenList
            f_10762_523_537(Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
            this_param)
            {
                var return_v = this_param.Modifiers;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10762, 523, 537);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
            f_10762_495_563(Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.SyntaxToken
            identifier, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
            equalsValue)
            {
                var return_v = this_param.Update(attributeLists, modifiers, identifier, equalsValue);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10762, 495, 563);
                return return_v;
            }

        }

        static EnumMemberDeclarationSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10762, 263, 571);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10762, 263, 571);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10762, 263, 571);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10762, 263, 571);
    }
}
