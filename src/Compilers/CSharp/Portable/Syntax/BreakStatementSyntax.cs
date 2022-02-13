// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class BreakStatementSyntax
    {
        public BreakStatementSyntax Update(SyntaxToken breakKeyword, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10745, 470, 534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10745, 473, 534);
                return f_10745_473_534(this, attributeLists: default, breakKeyword, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10745, 470, 534);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10745, 470, 534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10745, 470, 534);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax
            f_10745_473_534(Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            breakKeyword, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = this_param.Update(attributeLists: attributeLists, breakKeyword, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10745, 473, 534);
                return return_v;
            }

        }

        static BreakStatementSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10745, 310, 542);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10745, 310, 542);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10745, 310, 542);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10745, 310, 542);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static BreakStatementSyntax BreakStatement(SyntaxToken breakKeyword, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10745, 765, 837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10745, 768, 837);
                return f_10745_768_837(attributeLists: default, breakKeyword, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10745, 765, 837);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10745, 765, 837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10745, 765, 837);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax
            f_10745_768_837(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            breakKeyword, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = BreakStatement(attributeLists: attributeLists, breakKeyword, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10745, 768, 837);
                return return_v;
            }

        }
    }
}
