// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class LabeledStatementSyntax
    {
        public LabeledStatementSyntax Update(SyntaxToken identifier, SyntaxToken colonToken, StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10775, 495, 564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10775, 498, 564);
                return f_10775_498_564(this, attributeLists: default, identifier, colonToken, statement); DynAbs.Tracing.TraceSender.TraceExitMethod(10775, 495, 564);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10775, 495, 564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10775, 495, 564);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax
            f_10775_498_564(Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            identifier, Microsoft.CodeAnalysis.SyntaxToken
            colonToken, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement)
            {
                var return_v = this_param.Update(attributeLists: attributeLists, identifier, colonToken, statement);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10775, 498, 564);
                return return_v;
            }

        }

        static LabeledStatementSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10775, 310, 572);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10775, 310, 572);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10775, 310, 572);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10775, 310, 572);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static LabeledStatementSyntax LabeledStatement(SyntaxToken identifier, SyntaxToken colonToken, StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10775, 820, 899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10775, 823, 899);
                return f_10775_823_899(attributeLists: default, identifier, colonToken, statement); DynAbs.Tracing.TraceSender.TraceExitMethod(10775, 820, 899);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10775, 820, 899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10775, 820, 899);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax
            f_10775_823_899(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxToken
            identifier, Microsoft.CodeAnalysis.SyntaxToken
            colonToken, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement)
            {
                var return_v = LabeledStatement(attributeLists: attributeLists, identifier, colonToken, statement);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10775, 823, 899);
                return return_v;
            }

        }
    }
}

