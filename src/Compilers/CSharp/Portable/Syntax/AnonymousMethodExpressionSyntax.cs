// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class AnonymousMethodExpressionSyntax
    {
        public new AnonymousMethodExpressionSyntax WithBody(CSharpSyntaxNode body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10736, 488, 655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10736, 491, 655);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10736, 491, 516) || ((body is BlockSyntax
                && DynAbs.Tracing.TraceSender.Conditional_F2(10736, 536, 577)) || DynAbs.Tracing.TraceSender.Conditional_F3(10736, 597, 655))) ? f_10736_536_577(f_10736_536_552(this, (BlockSyntax)body), null) : f_10736_597_655(f_10736_597_639(this, body), null); DynAbs.Tracing.TraceSender.TraceExitMethod(10736, 488, 655);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10736, 488, 655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10736, 488, 655);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            f_10736_536_552(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            block)
            {
                var return_v = this_param.WithBlock(block);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10736, 536, 552);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            f_10736_536_577(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
            expressionBody)
            {
                var return_v = this_param.WithExpressionBody(expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10736, 536, 577);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            f_10736_597_639(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
            expressionBody)
            {
                var return_v = this_param.WithExpressionBody((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10736, 597, 639);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            f_10736_597_655(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            block)
            {
                var return_v = this_param.WithBlock(block);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10736, 597, 655);
                return return_v;
            }

        }

        public AnonymousMethodExpressionSyntax Update(SyntaxToken asyncKeyword, SyntaxToken delegateKeyword, ParameterListSyntax parameterList, CSharpSyntaxNode body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10736, 840, 1055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10736, 843, 1055);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10736, 843, 868) || ((body is BlockSyntax
                && DynAbs.Tracing.TraceSender.Conditional_F2(10736, 888, 953)) || DynAbs.Tracing.TraceSender.Conditional_F3(10736, 973, 1055))) ? f_10736_888_953(this, asyncKeyword, delegateKeyword, parameterList, (BlockSyntax)body, null) : f_10736_973_1055(this, asyncKeyword, delegateKeyword, parameterList, null, body); DynAbs.Tracing.TraceSender.TraceExitMethod(10736, 840, 1055);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10736, 840, 1055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10736, 840, 1055);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            f_10736_888_953(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxToken
            asyncKeyword, Microsoft.CodeAnalysis.SyntaxToken
            delegateKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            block, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expressionBody)
            {
                var return_v = this_param.Update(asyncKeyword, delegateKeyword, parameterList, block, expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10736, 888, 953);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            f_10736_973_1055(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxToken
            asyncKeyword, Microsoft.CodeAnalysis.SyntaxToken
            delegateKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            block, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
            expressionBody)
            {
                var return_v = this_param.Update(asyncKeyword, delegateKeyword, parameterList, block, (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10736, 973, 1055);
                return return_v;
            }

        }

        public override SyntaxToken AsyncKeyword
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10736, 1122, 1179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10736, 1125, 1179);
                    return this.Modifiers.FirstOrDefault(SyntaxKind.AsyncKeyword); DynAbs.Tracing.TraceSender.TraceExitMethod(10736, 1122, 1179);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10736, 1122, 1179);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10736, 1122, 1179);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override AnonymousFunctionExpressionSyntax WithAsyncKeywordCore(SyntaxToken asyncKeyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10736, 1291, 1324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10736, 1294, 1324);
                return f_10736_1294_1324(this, asyncKeyword); DynAbs.Tracing.TraceSender.TraceExitMethod(10736, 1291, 1324);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10736, 1291, 1324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10736, 1291, 1324);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            f_10736_1294_1324(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxToken
            asyncKeyword)
            {
                var return_v = this_param.WithAsyncKeyword(asyncKeyword);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10736, 1294, 1324);
                return return_v;
            }

        }

        public new AnonymousMethodExpressionSyntax WithAsyncKeyword(SyntaxToken asyncKeyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10736, 1434, 1537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10736, 1437, 1537);
                return f_10736_1437_1537(this, asyncKeyword, f_10736_1463_1483(this), f_10736_1485_1503(this), f_10736_1505_1515(this), f_10736_1517_1536(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10736, 1434, 1537);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10736, 1434, 1537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10736, 1434, 1537);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxToken
            f_10736_1463_1483(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            this_param)
            {
                var return_v = this_param.DelegateKeyword;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10736, 1463, 1483);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax?
            f_10736_1485_1503(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            this_param)
            {
                var return_v = this_param.ParameterList;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10736, 1485, 1503);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            f_10736_1505_1515(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            this_param)
            {
                var return_v = this_param.Block;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10736, 1505, 1515);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
            f_10736_1517_1536(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            this_param)
            {
                var return_v = this_param.ExpressionBody;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10736, 1517, 1536);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            f_10736_1437_1537(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxToken
            asyncKeyword, Microsoft.CodeAnalysis.SyntaxToken
            delegateKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax?
            parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            block, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
            expressionBody)
            {
                var return_v = this_param.Update(asyncKeyword, delegateKeyword, parameterList, block, expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10736, 1437, 1537);
                return return_v;
            }

        }

        public AnonymousMethodExpressionSyntax Update(SyntaxToken asyncKeyword, SyntaxToken delegateKeyword, ParameterListSyntax parameterList, BlockSyntax block, ExpressionSyntax expressionBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10736, 1751, 1854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10736, 1754, 1854);
                return f_10736_1754_1854(this, f_10736_1761_1798(asyncKeyword), delegateKeyword, parameterList, block, expressionBody); DynAbs.Tracing.TraceSender.TraceExitMethod(10736, 1751, 1854);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10736, 1751, 1854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10736, 1751, 1854);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxTokenList
            f_10736_1761_1798(Microsoft.CodeAnalysis.SyntaxToken
            token)
            {
                var return_v = SyntaxFactory.TokenList(token);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10736, 1761, 1798);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            f_10736_1754_1854(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            this_param, Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.SyntaxToken
            delegateKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            block, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expressionBody)
            {
                var return_v = this_param.Update(modifiers, delegateKeyword, parameterList, block, expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10736, 1754, 1854);
                return return_v;
            }

        }

        static AnonymousMethodExpressionSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10736, 331, 1862);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10736, 331, 1862);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10736, 331, 1862);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10736, 331, 1862);
    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public partial class SyntaxFactory
    {
        public static AnonymousMethodExpressionSyntax AnonymousMethodExpression()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10736, 2143, 2367);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10736, 2146, 2367);
                return f_10736_2146_2367(asyncKeyword: default, f_10736_2230_2263(SyntaxKind.DelegateKeyword), parameterList: null, f_10736_2320_2327(), expressionBody: null); DynAbs.Tracing.TraceSender.TraceExitMethod(10736, 2143, 2367);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10736, 2143, 2367);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10736, 2143, 2367);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxToken
            f_10736_2230_2263(Microsoft.CodeAnalysis.CSharp.SyntaxKind
            kind)
            {
                var return_v = Token(kind);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10736, 2230, 2263);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            f_10736_2320_2327()
            {
                var return_v = Block();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10736, 2320, 2327);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            f_10736_2146_2367(Microsoft.CodeAnalysis.SyntaxToken
            asyncKeyword, Microsoft.CodeAnalysis.SyntaxToken
            delegateKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            block, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expressionBody)
            {
                var return_v = AnonymousMethodExpression(asyncKeyword: asyncKeyword, delegateKeyword, parameterList: parameterList, block, expressionBody: expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10736, 2146, 2367);
                return return_v;
            }

        }

        public static AnonymousMethodExpressionSyntax AnonymousMethodExpression(SyntaxToken asyncKeyword, SyntaxToken delegateKeyword, ParameterListSyntax parameterList, BlockSyntax block, ExpressionSyntax expressionBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10736, 2607, 2715);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10736, 2610, 2715);
                return f_10736_2610_2715(f_10736_2636_2659(asyncKeyword), delegateKeyword, parameterList, block, expressionBody); DynAbs.Tracing.TraceSender.TraceExitMethod(10736, 2607, 2715);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10736, 2607, 2715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10736, 2607, 2715);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxTokenList
            f_10736_2636_2659(Microsoft.CodeAnalysis.SyntaxToken
            token)
            {
                var return_v = TokenList(token);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10736, 2636, 2659);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
            f_10736_2610_2715(Microsoft.CodeAnalysis.SyntaxTokenList
            modifiers, Microsoft.CodeAnalysis.SyntaxToken
            delegateKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
            block, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            expressionBody)
            {
                var return_v = AnonymousMethodExpression(modifiers, delegateKeyword, parameterList, block, expressionBody);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10736, 2610, 2715);
                return return_v;
            }

        }

        static SyntaxFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10736, 1917, 2723);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 1060, 1180);
            CarriageReturnLineFeed = Syntax.InternalSyntax.SyntaxFactory.CarriageReturnLineFeed; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 1328, 1420);
            LineFeed = Syntax.InternalSyntax.SyntaxFactory.LineFeed; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 1574, 1678);
            CarriageReturn = Syntax.InternalSyntax.SyntaxFactory.CarriageReturn; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 1824, 1910);
            Space = Syntax.InternalSyntax.SyntaxFactory.Space; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 2053, 2135);
            Tab = Syntax.InternalSyntax.SyntaxFactory.Tab; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 2475, 2609);
            ElasticCarriageReturnLineFeed = Syntax.InternalSyntax.SyntaxFactory.ElasticCarriageReturnLineFeed; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 2928, 3034);
            ElasticLineFeed = Syntax.InternalSyntax.SyntaxFactory.ElasticLineFeed; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 3359, 3477);
            ElasticCarriageReturn = Syntax.InternalSyntax.SyntaxFactory.ElasticCarriageReturn; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 3780, 3880);
            ElasticSpace = Syntax.InternalSyntax.SyntaxFactory.ElasticSpace; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 4181, 4277);
            ElasticTab = Syntax.InternalSyntax.SyntaxFactory.ElasticTab; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 4616, 4721);
            ElasticMarker = Syntax.InternalSyntax.SyntaxFactory.ElasticZeroSpace; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10736, 1917, 2723);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10736, 1917, 2723);
        }

    }
}
