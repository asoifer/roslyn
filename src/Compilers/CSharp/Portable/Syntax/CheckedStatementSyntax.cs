// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class CheckedStatementSyntax
    {
        public CheckedStatementSyntax Update(SyntaxToken keyword, BlockSyntax block)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10746, 460, 510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10746, 463, 510);
                return f_10746_463_510(this, attributeLists: default, keyword, block); DynAbs.Tracing.TraceSender.TraceExitMethod(10746, 460, 510);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10746, 460, 510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10746, 460, 510);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax
            f_10746_463_510(Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            keyword, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            block)
            {
                var return_v = this_param.Update(attributeLists: attributeLists, keyword, block);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10746, 463, 510);
                return return_v;
            }

        }

        static CheckedStatementSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10746, 310, 518);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10746, 310, 518);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10746, 310, 518);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10746, 310, 518);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static CheckedStatementSyntax CheckedStatement(SyntaxKind kind, SyntaxToken keyword, BlockSyntax block)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10746, 748, 814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10746, 751, 814);
                return f_10746_751_814(kind, attributeLists: default, keyword, block); DynAbs.Tracing.TraceSender.TraceExitMethod(10746, 748, 814);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10746, 748, 814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10746, 748, 814);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax
            f_10746_751_814(Microsoft.CodeAnalysis.CSharp.SyntaxKind
            kind, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            keyword, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            block)
            {
                var return_v = CheckedStatement(kind, attributeLists: attributeLists, keyword, block);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10746, 751, 814);
                return return_v;
            }

        }
    }
}
