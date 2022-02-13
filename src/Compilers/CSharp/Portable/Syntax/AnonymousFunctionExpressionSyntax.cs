// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class AnonymousFunctionExpressionSyntax
    {
        public CSharpSyntaxNode Body
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10735, 539, 584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10735, 542, 584);
                    return f_10735_542_547() ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?>(10735, 542, 584) ?? (CSharpSyntaxNode)ExpressionBody!); DynAbs.Tracing.TraceSender.TraceExitMethod(10735, 539, 584);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10735, 539, 584);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10735, 539, 584);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AnonymousFunctionExpressionSyntax WithBody(CSharpSyntaxNode body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10735, 683, 850);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10735, 686, 850);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10735, 686, 711) || ((body is BlockSyntax
                && DynAbs.Tracing.TraceSender.Conditional_F2(10735, 731, 772)) || DynAbs.Tracing.TraceSender.Conditional_F3(10735, 792, 850))) ? f_10735_731_772(f_10735_731_747(this, (BlockSyntax)body), null) : f_10735_792_850(f_10735_792_834(this, body), null); DynAbs.Tracing.TraceSender.TraceExitMethod(10735, 683, 850);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10735, 683, 850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10735, 683, 850);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
            f_10735_731_747(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
            this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            block)
            {
                var return_v = this_param.WithBlock(block);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10735, 731, 747);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
            f_10735_731_772(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
            this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
            expressionBody)
            {
                var return_v = this_param.WithExpressionBody(expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10735, 731, 772);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
            f_10735_792_834(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
            this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
            expressionBody)
            {
                var return_v = this_param.WithExpressionBody((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10735, 792, 834);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
            f_10735_792_850(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
            this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            block)
            {
                var return_v = this_param.WithBlock(block);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10735, 792, 850);
                return return_v;
            }

        }

        public abstract SyntaxToken AsyncKeyword { get; }

        public AnonymousFunctionExpressionSyntax WithAsyncKeyword(SyntaxToken asyncKeyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10735, 1021, 1058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10735, 1024, 1058);
                return f_10735_1024_1058(this, asyncKeyword); DynAbs.Tracing.TraceSender.TraceExitMethod(10735, 1021, 1058);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10735, 1021, 1058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10735, 1021, 1058);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
            f_10735_1024_1058(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxToken
            asyncKeyword)
            {
                var return_v = this_param.WithAsyncKeywordCore(asyncKeyword);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10735, 1024, 1058);
                return return_v;
            }

        }

        internal abstract AnonymousFunctionExpressionSyntax WithAsyncKeywordCore(SyntaxToken asyncKeyword);

        static AnonymousFunctionExpressionSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10735, 263, 1177);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10735, 263, 1177);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10735, 263, 1177);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10735, 263, 1177);

        Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        f_10735_542_547()
        {
            var return_v = Block;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10735, 542, 547);
            return return_v;
        }

    }
}
