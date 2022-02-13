// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class GlobalStatementSyntax
    {
        public GlobalStatementSyntax Update(StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10770, 398, 460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10770, 401, 460);
                return f_10770_401_460(this, f_10770_413_432(this), f_10770_434_448(this), statement); DynAbs.Tracing.TraceSender.TraceExitMethod(10770, 398, 460);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10770, 398, 460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10770, 398, 460);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            f_10770_413_432(Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax
            this_param)
            {
                var return_v = this_param.AttributeLists;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10770, 413, 432);
                return return_v;
            }


            Microsoft.CodeAnalysis.SyntaxTokenList
            f_10770_434_448(Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax
            this_param)
            {
                var return_v = this_param.Modifiers;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10770, 434, 448);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax
            f_10770_401_460(Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
            statement)
            {
                var return_v = this_param.Update(attributeLists, modifiers, statement);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10770, 401, 460);
                return return_v;
            }

        }

        static GlobalStatementSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10770, 263, 468);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10770, 263, 468);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10770, 263, 468);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10770, 263, 468);
    }
}
