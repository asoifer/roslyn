// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class LambdaExpressionSyntax
    {
        public new LambdaExpressionSyntax WithBody(CSharpSyntaxNode body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10776, 423, 590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10776, 426, 590);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10776, 426, 451) || ((body is BlockSyntax
                && DynAbs.Tracing.TraceSender.Conditional_F2(10776, 471, 512)) || DynAbs.Tracing.TraceSender.Conditional_F3(10776, 532, 590))) ? f_10776_471_512(f_10776_471_487(this, (BlockSyntax)body), null) : f_10776_532_590(f_10776_532_574(this, body), null); DynAbs.Tracing.TraceSender.TraceExitMethod(10776, 423, 590);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10776, 423, 590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10776, 423, 590);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.LambdaExpressionSyntax
            f_10776_471_487(Microsoft.CodeAnalysis.CSharp.Syntax.LambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            block)
            {
                var return_v = this_param.WithBlock(block);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10776, 471, 487);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.LambdaExpressionSyntax
            f_10776_471_512(Microsoft.CodeAnalysis.CSharp.Syntax.LambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
            expressionBody)
            {
                var return_v = this_param.WithExpressionBody(expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10776, 471, 512);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.LambdaExpressionSyntax
            f_10776_532_574(Microsoft.CodeAnalysis.CSharp.Syntax.LambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
            expressionBody)
            {
                var return_v = this_param.WithExpressionBody((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10776, 532, 574);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.LambdaExpressionSyntax
            f_10776_532_590(Microsoft.CodeAnalysis.CSharp.Syntax.LambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            block)
            {
                var return_v = this_param.WithBlock(block);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10776, 532, 590);
                return return_v;
            }

        }

        public new LambdaExpressionSyntax WithAsyncKeyword(SyntaxToken asyncKeyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10776, 693, 754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10776, 696, 754);
                return (LambdaExpressionSyntax)f_10776_720_754(this, asyncKeyword); DynAbs.Tracing.TraceSender.TraceExitMethod(10776, 693, 754);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10776, 693, 754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10776, 693, 754);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
            f_10776_720_754(Microsoft.CodeAnalysis.CSharp.Syntax.LambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxToken
            asyncKeyword)
            {
                var return_v = this_param.WithAsyncKeywordCore(asyncKeyword);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10776, 720, 754);
                return return_v;
            }

        }

        static LambdaExpressionSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10776, 284, 762);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10776, 284, 762);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10776, 284, 762);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10776, 284, 762);
    }
}
