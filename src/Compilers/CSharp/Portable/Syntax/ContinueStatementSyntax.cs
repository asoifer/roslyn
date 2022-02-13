// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class ContinueStatementSyntax
    {
        public ContinueStatementSyntax Update(SyntaxToken continueKeyword, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10749, 479, 546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10749, 482, 546);
                return f_10749_482_546(this, attributeLists: default, continueKeyword, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10749, 479, 546);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10749, 479, 546);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10749, 479, 546);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax
            f_10749_482_546(Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            continueKeyword, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = this_param.Update(attributeLists: attributeLists, continueKeyword, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10749, 482, 546);
                return return_v;
            }

        }

        static ContinueStatementSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10749, 310, 554);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10749, 310, 554);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10749, 310, 554);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10749, 310, 554);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static ContinueStatementSyntax ContinueStatement(SyntaxToken continueKeyword, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10749, 786, 864);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10749, 789, 864);
                return f_10749_789_864(attributeLists: default, continueKeyword, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10749, 786, 864);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10749, 786, 864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10749, 786, 864);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax
            f_10749_789_864(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            continueKeyword, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = ContinueStatement(attributeLists: attributeLists, continueKeyword, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10749, 789, 864);
                return return_v;
            }

        }
    }
}
