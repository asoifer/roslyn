// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class ParenthesizedLambdaExpressionSyntax
    {
        public new ParenthesizedLambdaExpressionSyntax WithBody(CSharpSyntaxNode body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10789, 475, 642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10789, 478, 642);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10789, 478, 503) || ((body is BlockSyntax
                && DynAbs.Tracing.TraceSender.Conditional_F2(10789, 523, 564)) || DynAbs.Tracing.TraceSender.Conditional_F3(10789, 584, 642))) ? f_10789_523_564(f_10789_523_539(this, (BlockSyntax)body), null) : f_10789_584_642(f_10789_584_626(this, body), null); DynAbs.Tracing.TraceSender.TraceExitMethod(10789, 475, 642);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10789, 475, 642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10789, 475, 642);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            f_10789_523_539(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            block)
            {
                var return_v = this_param.WithBlock(block);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10789, 523, 539);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            f_10789_523_564(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
            expressionBody)
            {
                var return_v = this_param.WithExpressionBody(expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10789, 523, 564);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            f_10789_584_626(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
            expressionBody)
            {
                var return_v = this_param.WithExpressionBody((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10789, 584, 626);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            f_10789_584_642(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            block)
            {
                var return_v = this_param.WithBlock(block);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10789, 584, 642);
                return return_v;
            }

        }

        public ParenthesizedLambdaExpressionSyntax Update(SyntaxToken asyncKeyword, ParameterListSyntax parameterList, SyntaxToken arrowToken, CSharpSyntaxNode body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10789, 826, 1031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10789, 829, 1031);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10789, 829, 854) || ((body is BlockSyntax
                && DynAbs.Tracing.TraceSender.Conditional_F2(10789, 874, 934)) || DynAbs.Tracing.TraceSender.Conditional_F3(10789, 954, 1031))) ? f_10789_874_934(this, asyncKeyword, parameterList, arrowToken, (BlockSyntax)body, null) : f_10789_954_1031(this, asyncKeyword, parameterList, arrowToken, null, body); DynAbs.Tracing.TraceSender.TraceExitMethod(10789, 826, 1031);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10789, 826, 1031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10789, 826, 1031);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            f_10789_874_934(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxToken
            asyncKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            parameterList, Microsoft.CodeAnalysis.SyntaxToken
            arrowToken, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            block, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
            expressionBody)
            {
                var return_v = this_param.Update(asyncKeyword, parameterList, arrowToken, block, expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10789, 874, 934);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            f_10789_954_1031(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxToken
            asyncKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            parameterList, Microsoft.CodeAnalysis.SyntaxToken
            arrowToken, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            block, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
            expressionBody)
            {
                var return_v = this_param.Update(asyncKeyword, parameterList, arrowToken, block, (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10789, 954, 1031);
                return return_v;
            }

        }

        public override SyntaxToken AsyncKeyword
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10789, 1098, 1155);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10789, 1101, 1155);
                    return this.Modifiers.FirstOrDefault(SyntaxKind.AsyncKeyword); DynAbs.Tracing.TraceSender.TraceExitMethod(10789, 1098, 1155);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10789, 1098, 1155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10789, 1098, 1155);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override AnonymousFunctionExpressionSyntax WithAsyncKeywordCore(SyntaxToken asyncKeyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10789, 1280, 1313);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10789, 1283, 1313);
                return f_10789_1283_1313(this, asyncKeyword); DynAbs.Tracing.TraceSender.TraceExitMethod(10789, 1280, 1313);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10789, 1280, 1313);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10789, 1280, 1313);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            f_10789_1283_1313(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxToken
            asyncKeyword)
            {
                var return_v = this_param.WithAsyncKeyword(asyncKeyword);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10789, 1283, 1313);
                return return_v;
            }

        }

        public new ParenthesizedLambdaExpressionSyntax WithAsyncKeyword(SyntaxToken asyncKeyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10789, 1429, 1527);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10789, 1432, 1527);
                return f_10789_1432_1527(this, asyncKeyword, f_10789_1458_1476(this), f_10789_1478_1493(this), f_10789_1495_1505(this), f_10789_1507_1526(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10789, 1429, 1527);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10789, 1429, 1527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10789, 1429, 1527);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            f_10789_1458_1476(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            this_param)
            {
                var return_v = this_param.ParameterList;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10789, 1458, 1476);
                return return_v;
            }


            Microsoft.CodeAnalysis.SyntaxToken
            f_10789_1478_1493(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            this_param)
            {
                var return_v = this_param.ArrowToken;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10789, 1478, 1493);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            f_10789_1495_1505(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            this_param)
            {
                var return_v = this_param.Block;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10789, 1495, 1505);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
            f_10789_1507_1526(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            this_param)
            {
                var return_v = this_param.ExpressionBody;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10789, 1507, 1526);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            f_10789_1432_1527(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxToken
            asyncKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            parameterList, Microsoft.CodeAnalysis.SyntaxToken
            arrowToken, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            block, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
            expressionBody)
            {
                var return_v = this_param.Update(asyncKeyword, parameterList, arrowToken, block, expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10789, 1432, 1527);
                return return_v;
            }

        }

        public ParenthesizedLambdaExpressionSyntax Update(SyntaxToken asyncKeyword, ParameterListSyntax parameterList, SyntaxToken arrowToken, BlockSyntax? block, ExpressionSyntax? expressionBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10789, 1742, 1840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10789, 1745, 1840);
                return f_10789_1745_1840(this, f_10789_1752_1789(asyncKeyword), parameterList, arrowToken, block, expressionBody); DynAbs.Tracing.TraceSender.TraceExitMethod(10789, 1742, 1840);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10789, 1742, 1840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10789, 1742, 1840);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxTokenList
            f_10789_1752_1789(Microsoft.CodeAnalysis.SyntaxToken
            token)
            {
                var return_v = SyntaxFactory.TokenList(token);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10789, 1752, 1789);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            f_10789_1745_1840(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            parameterList, Microsoft.CodeAnalysis.SyntaxToken
            arrowToken, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            block, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
            expressionBody)
            {
                var return_v = this_param.Update(modifiers, parameterList, arrowToken, block, expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10789, 1745, 1840);
                return return_v;
            }

        }

        static ParenthesizedLambdaExpressionSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10789, 310, 1848);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10789, 310, 1848);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10789, 310, 1848);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10789, 310, 1848);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static ParenthesizedLambdaExpressionSyntax ParenthesizedLambdaExpression(SyntaxToken asyncKeyword, ParameterListSyntax parameterList, SyntaxToken arrowToken, BlockSyntax? block, ExpressionSyntax? expressionBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10789, 2186, 2293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10789, 2189, 2293);
                return f_10789_2189_2293(f_10789_2219_2242(asyncKeyword), parameterList, arrowToken, block, expressionBody); DynAbs.Tracing.TraceSender.TraceExitMethod(10789, 2186, 2293);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10789, 2186, 2293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10789, 2186, 2293);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxTokenList
            f_10789_2219_2242(Microsoft.CodeAnalysis.SyntaxToken
            token)
            {
                var return_v = TokenList(token);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10789, 2219, 2242);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            f_10789_2189_2293(Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            parameterList, Microsoft.CodeAnalysis.SyntaxToken
            arrowToken, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            block, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
            expressionBody)
            {
                var return_v = ParenthesizedLambdaExpression(modifiers, parameterList, arrowToken, block, expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10789, 2189, 2293);
                return return_v;
            }

        }

        public static ParenthesizedLambdaExpressionSyntax ParenthesizedLambdaExpression(ParameterListSyntax parameterList, BlockSyntax? block, ExpressionSyntax? expressionBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10789, 2488, 2584);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10789, 2491, 2584);
                return f_10789_2491_2584(default(SyntaxTokenList), parameterList, block, expressionBody); DynAbs.Tracing.TraceSender.TraceExitMethod(10789, 2488, 2584);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10789, 2488, 2584);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10789, 2488, 2584);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
            f_10789_2491_2584(Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            block, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
            expressionBody)
            {
                var return_v = ParenthesizedLambdaExpression(modifiers, parameterList, block, expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10789, 2491, 2584);
                return return_v;
            }

        }
    }
}
