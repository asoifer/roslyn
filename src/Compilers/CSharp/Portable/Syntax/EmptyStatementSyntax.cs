// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class EmptyStatementSyntax
    {
        public EmptyStatementSyntax Update(SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10761, 444, 494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10761, 447, 494);
                return f_10761_447_494(this, attributeLists: default, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10761, 444, 494);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10761, 444, 494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10761, 444, 494);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.EmptyStatementSyntax
            f_10761_447_494(Microsoft.CodeAnalysis.CSharp.Syntax.EmptyStatementSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = this_param.Update(attributeLists: attributeLists, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10761, 447, 494);
                return return_v;
            }

        }

        static EmptyStatementSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10761, 310, 502);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10761, 310, 502);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10761, 310, 502);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10761, 310, 502);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static EmptyStatementSyntax EmptyStatement(SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10761, 699, 757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10761, 702, 757);
                return f_10761_702_757(attributeLists: default, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10761, 699, 757);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10761, 699, 757);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10761, 699, 757);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.EmptyStatementSyntax
            f_10761_702_757(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = EmptyStatement(attributeLists: attributeLists, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10761, 702, 757);
                return return_v;
            }

        }
    }
}
