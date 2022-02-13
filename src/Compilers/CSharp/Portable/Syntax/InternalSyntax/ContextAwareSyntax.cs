// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    internal partial class ContextAwareSyntax
    {
        public GlobalStatementSyntax GlobalStatement(StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10822, 442, 516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10822, 445, 516);
                return f_10822_445_516(this, attributeLists: default, modifiers: default, statement); DynAbs.Tracing.TraceSender.TraceExitMethod(10822, 442, 516);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10822, 442, 516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10822, 442, 516);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.GlobalStatementSyntax
            f_10822_445_516(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ContextAwareSyntax
            this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
            modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.StatementSyntax
            statement)
            {
                var return_v = this_param.GlobalStatement(attributeLists: attributeLists, modifiers: modifiers, statement);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10822, 445, 516);
                return return_v;
            }

        }

        static ContextAwareSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10822, 299, 524);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10822, 299, 524);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10822, 299, 524);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10822, 299, 524);
    }
}
