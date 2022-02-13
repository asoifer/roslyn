// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class ExpressionStatementSyntax
    {
        public bool AllowsAnyExpression
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10764, 857, 1018);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10764, 893, 924);

                    var
                    semicolon = f_10764_909_923()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10764, 942, 1003);

                    return semicolon.IsMissing && (DynAbs.Tracing.TraceSender.Expression_True(10764, 949, 1002) && f_10764_972_1002_M(!semicolon.ContainsDiagnostics));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10764, 857, 1018);

                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10764_909_923()
                    {
                        var return_v = SemicolonToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10764, 909, 923);
                        return return_v;
                    }


                    bool
                    f_10764_972_1002_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10764, 972, 1002);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10764, 801, 1029);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10764, 801, 1029);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ExpressionStatementSyntax Update(ExpressionSyntax expression, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10764, 1151, 1213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10764, 1154, 1213);
                return f_10764_1154_1213(this, attributeLists: default, expression, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10764, 1151, 1213);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10764, 1151, 1213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10764, 1151, 1213);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax
            f_10764_1154_1213(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expression, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = this_param.Update(attributeLists: attributeLists, expression, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10764, 1154, 1213);
                return return_v;
            }

        }

        static ExpressionStatementSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10764, 310, 1221);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10764, 310, 1221);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10764, 310, 1221);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10764, 310, 1221);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static ExpressionStatementSyntax ExpressionStatement(ExpressionSyntax expression, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10764, 1457, 1532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10764, 1460, 1532);
                return f_10764_1460_1532(attributeLists: default, expression, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10764, 1457, 1532);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10764, 1457, 1532);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10764, 1457, 1532);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax
            f_10764_1460_1532(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
            attributeLists, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expression, Microsoft.CodeAnalysis.SyntaxToken
            semicolonToken)
            {
                var return_v = ExpressionStatement(attributeLists: attributeLists, expression, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10764, 1460, 1532);
                return return_v;
            }

        }
    }
}
