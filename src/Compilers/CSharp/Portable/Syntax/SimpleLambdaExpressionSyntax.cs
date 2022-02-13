// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class SimpleLambdaExpressionSyntax
    {
        public new SimpleLambdaExpressionSyntax WithBody(CSharpSyntaxNode body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10795, 482, 649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10795, 485, 649);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10795, 485, 510) || ((body is BlockSyntax
                && DynAbs.Tracing.TraceSender.Conditional_F2(10795, 530, 571)) || DynAbs.Tracing.TraceSender.Conditional_F3(10795, 591, 649))) ? f_10795_530_571(f_10795_530_546(this, (BlockSyntax)body), null) : f_10795_591_649(f_10795_591_633(this, body), null); DynAbs.Tracing.TraceSender.TraceExitMethod(10795, 482, 649);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10795, 482, 649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10795, 482, 649);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            f_10795_530_546(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            block)
            {
                var return_v = this_param.WithBlock(block);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10795, 530, 546);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            f_10795_530_571(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
            expressionBody)
            {
                var return_v = this_param.WithExpressionBody(expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10795, 530, 571);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            f_10795_591_633(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
            expressionBody)
            {
                var return_v = this_param.WithExpressionBody((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10795, 591, 633);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            f_10795_591_649(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            block)
            {
                var return_v = this_param.WithBlock(block);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10795, 591, 649);
                return return_v;
            }

        }

        public SimpleLambdaExpressionSyntax Update(SyntaxToken asyncKeyword, ParameterSyntax parameter, SyntaxToken arrowToken, CSharpSyntaxNode body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10795, 818, 1015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10795, 821, 1015);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10795, 821, 846) || ((body is BlockSyntax
                && DynAbs.Tracing.TraceSender.Conditional_F2(10795, 866, 922)) || DynAbs.Tracing.TraceSender.Conditional_F3(10795, 942, 1015))) ? f_10795_866_922(this, asyncKeyword, parameter, arrowToken, (BlockSyntax)body, null) : f_10795_942_1015(this, asyncKeyword, parameter, arrowToken, null, body); DynAbs.Tracing.TraceSender.TraceExitMethod(10795, 818, 1015);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10795, 818, 1015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10795, 818, 1015);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            f_10795_866_922(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxToken
            asyncKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
            parameter, Microsoft.CodeAnalysis.SyntaxToken
            arrowToken, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            block, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expressionBody)
            {
                var return_v = this_param.Update(asyncKeyword, parameter, arrowToken, block, expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10795, 866, 922);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            f_10795_942_1015(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxToken
            asyncKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
            parameter, Microsoft.CodeAnalysis.SyntaxToken
            arrowToken, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            block, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
            expressionBody)
            {
                var return_v = this_param.Update(asyncKeyword, parameter, arrowToken, block, (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10795, 942, 1015);
                return return_v;
            }

        }

        public override SyntaxToken AsyncKeyword
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10795, 1082, 1139);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10795, 1085, 1139);
                    return this.Modifiers.FirstOrDefault(SyntaxKind.AsyncKeyword); DynAbs.Tracing.TraceSender.TraceExitMethod(10795, 1082, 1139);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10795, 1082, 1139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10795, 1082, 1139);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override AnonymousFunctionExpressionSyntax WithAsyncKeywordCore(SyntaxToken asyncKeyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10795, 1264, 1297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10795, 1267, 1297);
                return f_10795_1267_1297(this, asyncKeyword); DynAbs.Tracing.TraceSender.TraceExitMethod(10795, 1264, 1297);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10795, 1264, 1297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10795, 1264, 1297);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            f_10795_1267_1297(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxToken
            asyncKeyword)
            {
                var return_v = this_param.WithAsyncKeyword(asyncKeyword);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10795, 1267, 1297);
                return return_v;
            }

        }

        public new SimpleLambdaExpressionSyntax WithAsyncKeyword(SyntaxToken asyncKeyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10795, 1406, 1500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10795, 1409, 1500);
                return f_10795_1409_1500(this, asyncKeyword, f_10795_1435_1449(this), f_10795_1451_1466(this), f_10795_1468_1478(this), f_10795_1480_1499(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10795, 1406, 1500);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10795, 1406, 1500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10795, 1406, 1500);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
            f_10795_1435_1449(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            this_param)
            {
                var return_v = this_param.Parameter;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10795, 1435, 1449);
                return return_v;
            }


            Microsoft.CodeAnalysis.SyntaxToken
            f_10795_1451_1466(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            this_param)
            {
                var return_v = this_param.ArrowToken;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10795, 1451, 1466);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            f_10795_1468_1478(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            this_param)
            {
                var return_v = this_param.Block;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10795, 1468, 1478);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
            f_10795_1480_1499(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            this_param)
            {
                var return_v = this_param.ExpressionBody;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10795, 1480, 1499);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            f_10795_1409_1500(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxToken
            asyncKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
            parameter, Microsoft.CodeAnalysis.SyntaxToken
            arrowToken, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            block, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
            expressionBody)
            {
                var return_v = this_param.Update(asyncKeyword, parameter, arrowToken, block, expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10795, 1409, 1500);
                return return_v;
            }

        }

        public SimpleLambdaExpressionSyntax Update(SyntaxToken asyncKeyword, ParameterSyntax parameter, SyntaxToken arrowToken, BlockSyntax block, ExpressionSyntax expressionBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10795, 1698, 1792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10795, 1701, 1792);
                return f_10795_1701_1792(this, f_10795_1708_1745(asyncKeyword), parameter, arrowToken, block, expressionBody); DynAbs.Tracing.TraceSender.TraceExitMethod(10795, 1698, 1792);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10795, 1698, 1792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10795, 1698, 1792);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxTokenList
            f_10795_1708_1745(Microsoft.CodeAnalysis.SyntaxToken
            token)
            {
                var return_v = SyntaxFactory.TokenList(token);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10795, 1708, 1745);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            f_10795_1701_1792(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
            parameter, Microsoft.CodeAnalysis.SyntaxToken
            arrowToken, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            block, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expressionBody)
            {
                var return_v = this_param.Update(modifiers, parameter, arrowToken, block, expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10795, 1701, 1792);
                return return_v;
            }

        }

        static SimpleLambdaExpressionSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10795, 331, 1800);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10795, 331, 1800);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10795, 331, 1800);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10795, 331, 1800);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static SimpleLambdaExpressionSyntax SimpleLambdaExpression(SyntaxToken asyncKeyword, ParameterSyntax parameter, SyntaxToken arrowToken, BlockSyntax block, ExpressionSyntax expressionBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10795, 2114, 2210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10795, 2117, 2210);
                return f_10795_2117_2210(f_10795_2140_2163(asyncKeyword), parameter, arrowToken, block, expressionBody); DynAbs.Tracing.TraceSender.TraceExitMethod(10795, 2114, 2210);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10795, 2114, 2210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10795, 2114, 2210);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxTokenList
            f_10795_2140_2163(Microsoft.CodeAnalysis.SyntaxToken
            token)
            {
                var return_v = TokenList(token);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10795, 2140, 2163);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            f_10795_2117_2210(Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
            parameter, Microsoft.CodeAnalysis.SyntaxToken
            arrowToken, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            block, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expressionBody)
            {
                var return_v = SimpleLambdaExpression(modifiers, parameter, arrowToken, block, expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10795, 2117, 2210);
                return return_v;
            }

        }

        public static SimpleLambdaExpressionSyntax SimpleLambdaExpression(ParameterSyntax parameter, BlockSyntax block, ExpressionSyntax expressionBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10795, 2381, 2466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10795, 2384, 2466);
                return f_10795_2384_2466(default(SyntaxTokenList), parameter, block, expressionBody); DynAbs.Tracing.TraceSender.TraceExitMethod(10795, 2381, 2466);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10795, 2381, 2466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10795, 2381, 2466);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
            f_10795_2384_2466(Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
            parameter, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            block, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expressionBody)
            {
                var return_v = SimpleLambdaExpression(modifiers, parameter, block, expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10795, 2384, 2466);
                return return_v;
            }

        }
    }
}
