// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class ReturnStatementSyntax
    {
        public ReturnStatementSyntax Update(SyntaxToken returnKeyword, ExpressionSyntax expression, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10794, 502, 579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10794, 505, 579);
                return f_10794_505_579(this, attributeLists: default, returnKeyword, expression, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10794, 502, 579);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10794, 502, 579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10794, 502, 579);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax
            f_10794_505_579(Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            returnKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expression, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = this_param.Update(attributeLists: attributeLists, returnKeyword, expression, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10794, 505, 579);
                return return_v;
            }

        }

        static ReturnStatementSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10794, 310, 587);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10794, 310, 587);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10794, 310, 587);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10794, 310, 587);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static ReturnStatementSyntax ReturnStatement(SyntaxToken returnKeyword, ExpressionSyntax expression, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10794, 842, 928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10794, 845, 928);
                return f_10794_845_928(attributeLists: default, returnKeyword, expression, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10794, 842, 928);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10794, 842, 928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10794, 842, 928);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax
            f_10794_845_928(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            returnKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expression, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = ReturnStatement(attributeLists: attributeLists, returnKeyword, expression, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10794, 845, 928);
                return return_v;
            }

        }
    }
}
