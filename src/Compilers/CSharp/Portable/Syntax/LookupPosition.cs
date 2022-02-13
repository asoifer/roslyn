// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    internal static class LookupPosition
    {
        internal static bool IsInBlock(int position, BlockSyntax? blockOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 988, 1178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 1080, 1167);

                return blockOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10781, 1087, 1166) && f_10781_1107_1166(position, blockOpt, f_10781_1141_1165(blockOpt)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 988, 1178);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_1141_1165(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                this_param)
                {
                    var return_v = this_param.CloseBraceToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 1141, 1165);
                    return return_v;
                }


                bool
                f_10781_1107_1166(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                node, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBeforeToken(position, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 1107, 1166);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 988, 1178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 988, 1178);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsInExpressionBody(
                    int position,
                    ArrowExpressionClauseSyntax? expressionBodyOpt,
                    SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 1190, 1507);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 1384, 1496);

                return expressionBodyOpt != null
                && (DynAbs.Tracing.TraceSender.Expression_True(10781, 1391, 1495) && f_10781_1437_1495(position, expressionBodyOpt, semicolonToken));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 1190, 1507);

                bool
                f_10781_1437_1495(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                node, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBeforeToken(position, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 1437, 1495);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 1190, 1507);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 1190, 1507);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsInBody(int position, BlockSyntax? blockOpt, ArrowExpressionClauseSyntax? exprOpt, SyntaxToken semiOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 1519, 1783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 1668, 1772);

                return f_10781_1675_1721(position, exprOpt, semiOpt) || (DynAbs.Tracing.TraceSender.Expression_False(10781, 1675, 1771) || f_10781_1742_1771(position, blockOpt));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 1519, 1783);

                bool
                f_10781_1675_1721(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                expressionBodyOpt, Microsoft.CodeAnalysis.SyntaxToken
                semicolonToken)
                {
                    var return_v = IsInExpressionBody(position, expressionBodyOpt, semicolonToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 1675, 1721);
                    return return_v;
                }


                bool
                f_10781_1742_1771(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                blockOpt)
                {
                    var return_v = IsInBlock(position, blockOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 1742, 1771);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 1519, 1783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 1519, 1783);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsInBody(int position,
                    PropertyDeclarationSyntax property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10781, 2199, 2297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 2202, 2297);
                return f_10781_2202_2297(position, blockOpt: null, f_10781_2237_2271(property), f_10781_2273_2296(property)); DynAbs.Tracing.TraceSender.TraceExitMethod(10781, 2199, 2297);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 2199, 2297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 2199, 2297);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
            f_10781_2237_2271(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
            node)
            {
                var return_v = node.GetExpressionBodySyntax();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 2237, 2271);
                return return_v;
            }


            Microsoft.CodeAnalysis.SyntaxToken
            f_10781_2273_2296(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
            this_param)
            {
                var return_v = this_param.SemicolonToken;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 2273, 2296);
                return return_v;
            }


            bool
            f_10781_2202_2297(int
            position, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            blockOpt, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
            exprOpt, Microsoft.CodeAnalysis.SyntaxToken
            semiOpt)
            {
                var return_v = IsInBody(position, blockOpt: blockOpt, exprOpt, semiOpt);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 2202, 2297);
                return return_v;
            }

        }

        internal static bool IsInBody(int position,
                    IndexerDeclarationSyntax indexer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10781, 2712, 2808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 2715, 2808);
                return f_10781_2715_2808(position, blockOpt: null, f_10781_2750_2783(indexer), f_10781_2785_2807(indexer)); DynAbs.Tracing.TraceSender.TraceExitMethod(10781, 2712, 2808);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 2712, 2808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 2712, 2808);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
            f_10781_2750_2783(Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax
            node)
            {
                var return_v = node.GetExpressionBodySyntax();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 2750, 2783);
                return return_v;
            }


            Microsoft.CodeAnalysis.SyntaxToken
            f_10781_2785_2807(Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax
            this_param)
            {
                var return_v = this_param.SemicolonToken;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 2785, 2807);
                return return_v;
            }


            bool
            f_10781_2715_2808(int
            position, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            blockOpt, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
            exprOpt, Microsoft.CodeAnalysis.SyntaxToken
            semiOpt)
            {
                var return_v = IsInBody(position, blockOpt: blockOpt, exprOpt, semiOpt);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 2715, 2808);
                return return_v;
            }

        }

        internal static bool IsInBody(int position, AccessorDeclarationSyntax method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10781, 3070, 3161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 3073, 3161);
                return f_10781_3073_3161(position, f_10781_3092_3103(method), f_10781_3105_3137(method), f_10781_3139_3160(method)); DynAbs.Tracing.TraceSender.TraceExitMethod(10781, 3070, 3161);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 3070, 3161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 3070, 3161);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            f_10781_3092_3103(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
            this_param)
            {
                var return_v = this_param.Body;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 3092, 3103);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
            f_10781_3105_3137(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
            node)
            {
                var return_v = node.GetExpressionBodySyntax();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 3105, 3137);
                return return_v;
            }


            Microsoft.CodeAnalysis.SyntaxToken
            f_10781_3139_3160(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
            this_param)
            {
                var return_v = this_param.SemicolonToken;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 3139, 3160);
                return return_v;
            }


            bool
            f_10781_3073_3161(int
            position, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            blockOpt, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
            exprOpt, Microsoft.CodeAnalysis.SyntaxToken
            semiOpt)
            {
                var return_v = IsInBody(position, blockOpt, exprOpt, semiOpt);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 3073, 3161);
                return return_v;
            }

        }

        internal static bool IsInBody(int position, BaseMethodDeclarationSyntax method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10781, 3721, 3812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 3724, 3812);
                return f_10781_3724_3812(position, f_10781_3743_3754(method), f_10781_3756_3788(method), f_10781_3790_3811(method)); DynAbs.Tracing.TraceSender.TraceExitMethod(10781, 3721, 3812);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 3721, 3812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 3721, 3812);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            f_10781_3743_3754(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
            this_param)
            {
                var return_v = this_param.Body;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 3743, 3754);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
            f_10781_3756_3788(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
            node)
            {
                var return_v = node.GetExpressionBodySyntax();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 3756, 3788);
                return return_v;
            }


            Microsoft.CodeAnalysis.SyntaxToken
            f_10781_3790_3811(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
            this_param)
            {
                var return_v = this_param.SemicolonToken;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 3790, 3811);
                return return_v;
            }


            bool
            f_10781_3724_3812(int
            position, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            blockOpt, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
            exprOpt, Microsoft.CodeAnalysis.SyntaxToken
            semiOpt)
            {
                var return_v = IsInBody(position, blockOpt, exprOpt, semiOpt);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 3724, 3812);
                return return_v;
            }

        }

        internal static bool IsBetweenTokens(int position, SyntaxToken firstIncluded, SyntaxToken firstExcluded)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 3825, 4050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 3954, 4039);

                return position >= firstIncluded.SpanStart && (DynAbs.Tracing.TraceSender.Expression_True(10781, 3961, 4038) && f_10781_4000_4038(position, firstExcluded));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 3825, 4050);

                bool
                f_10781_4000_4038(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBeforeToken(position, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 4000, 4038);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 3825, 4050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 3825, 4050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsBeforeToken(int position, CSharpSyntaxNode node, SyntaxToken firstExcluded)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 4209, 4418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 4331, 4407);

                return f_10781_4338_4376(position, firstExcluded) && (DynAbs.Tracing.TraceSender.Expression_True(10781, 4338, 4406) && position >= f_10781_4392_4406(node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 4209, 4418);

                bool
                f_10781_4338_4376(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBeforeToken(position, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 4338, 4376);
                    return return_v;
                }


                int
                f_10781_4392_4406(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 4392, 4406);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 4209, 4418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 4209, 4418);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsBeforeToken(int position, SyntaxToken firstExcluded)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 4430, 4625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 4529, 4614);

                return firstExcluded.Kind() == SyntaxKind.None || (DynAbs.Tracing.TraceSender.Expression_False(10781, 4536, 4613) || position < firstExcluded.SpanStart);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 4430, 4625);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 4430, 4625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 4430, 4625);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsInAttributeSpecification(int position, SyntaxList<AttributeListSyntax> attributesSyntaxList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 4637, 5139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 4777, 4816);

                int
                count = attributesSyntaxList.Count
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 4830, 4906) || true) && (count == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 4830, 4906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 4878, 4891);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 4830, 4906);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 4922, 4980);

                var
                startToken = f_10781_4939_4979(attributesSyntaxList[0])
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 4994, 5059);

                var
                endToken = f_10781_5009_5058(attributesSyntaxList[count - 1])
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 5073, 5128);

                return f_10781_5080_5127(position, startToken, endToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 4637, 5139);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_4939_4979(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax
                this_param)
                {
                    var return_v = this_param.OpenBracketToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 4939, 4979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_5009_5058(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax
                this_param)
                {
                    var return_v = this_param.CloseBracketToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 5009, 5058);
                    return return_v;
                }


                bool
                f_10781_5080_5127(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBetweenTokens(position, firstIncluded, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 5080, 5127);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 4637, 5139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 4637, 5139);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsInTypeParameterList(int position, TypeDeclarationSyntax typeDecl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 5151, 5467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 5264, 5318);

                var
                typeParameterListOpt = f_10781_5291_5317(typeDecl)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 5332, 5456);

                return typeParameterListOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10781, 5339, 5455) && f_10781_5371_5455(position, typeParameterListOpt, f_10781_5417_5454(typeParameterListOpt)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 5151, 5467);

                Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
                f_10781_5291_5317(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.TypeParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 5291, 5317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_5417_5454(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                this_param)
                {
                    var return_v = this_param.GreaterThanToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 5417, 5454);
                    return return_v;
                }


                bool
                f_10781_5371_5455(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                node, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBeforeToken(position, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 5371, 5455);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 5151, 5467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 5151, 5467);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsInParameterList(int position, BaseMethodDeclarationSyntax methodDecl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 5479, 5743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 5596, 5641);

                var
                parameterList = f_10781_5616_5640(methodDecl)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 5655, 5732);

                return f_10781_5662_5731(position, parameterList, f_10781_5701_5730(parameterList));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 5479, 5743);

                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                f_10781_5616_5640(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 5616, 5640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_5701_5730(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                this_param)
                {
                    var return_v = this_param.CloseParenToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 5701, 5730);
                    return return_v;
                }


                bool
                f_10781_5662_5731(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                node, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBeforeToken(position, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 5662, 5731);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 5479, 5743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 5479, 5743);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsInParameterList(int position, ParameterListSyntax parameterList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10781, 5856, 5953);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 5859, 5953);
                return parameterList != null && (DynAbs.Tracing.TraceSender.Expression_True(10781, 5859, 5953) && f_10781_5884_5953(position, parameterList, f_10781_5923_5952(parameterList))); DynAbs.Tracing.TraceSender.TraceExitMethod(10781, 5856, 5953);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 5856, 5953);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 5856, 5953);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SyntaxToken
            f_10781_5923_5952(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            this_param)
            {
                var return_v = this_param.CloseParenToken;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 5923, 5952);
                return return_v;
            }


            bool
            f_10781_5884_5953(int
            position, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
            node, Microsoft.CodeAnalysis.SyntaxToken
            firstExcluded)
            {
                var return_v = IsBeforeToken(position, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, firstExcluded);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 5884, 5953);
                return return_v;
            }

        }

        internal static bool IsInMethodDeclaration(int position, BaseMethodDeclarationSyntax methodDecl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 5966, 6521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 6087, 6120);

                f_10781_6087_6119(methodDecl != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 6136, 6163);

                var
                body = f_10781_6147_6162(methodDecl)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 6177, 6312) || true) && (body == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 6177, 6312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 6227, 6297);

                    return f_10781_6234_6296(position, methodDecl, f_10781_6270_6295(methodDecl));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 6177, 6312);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 6328, 6510);

                return f_10781_6335_6392(position, methodDecl, f_10781_6371_6391(body)) || (DynAbs.Tracing.TraceSender.Expression_False(10781, 6335, 6509) || f_10781_6416_6509(position, f_10781_6445_6481(methodDecl), f_10781_6483_6508(methodDecl)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 5966, 6521);

                int
                f_10781_6087_6119(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 6087, 6119);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10781_6147_6162(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 6147, 6162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_6270_6295(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.SemicolonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 6270, 6295);
                    return return_v;
                }


                bool
                f_10781_6234_6296(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                node, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBeforeToken(position, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 6234, 6296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_6371_6391(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                this_param)
                {
                    var return_v = this_param.CloseBraceToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 6371, 6391);
                    return return_v;
                }


                bool
                f_10781_6335_6392(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                node, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBeforeToken(position, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 6335, 6392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10781_6445_6481(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                node)
                {
                    var return_v = node.GetExpressionBodySyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 6445, 6481);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_6483_6508(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.SemicolonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 6483, 6508);
                    return return_v;
                }


                bool
                f_10781_6416_6509(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                expressionBodyOpt, Microsoft.CodeAnalysis.SyntaxToken
                semicolonToken)
                {
                    var return_v = IsInExpressionBody(position, expressionBodyOpt, semicolonToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 6416, 6509);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 5966, 6521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 5966, 6521);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsInMethodDeclaration(int position, AccessorDeclarationSyntax accessorDecl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 6533, 6919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 6654, 6689);

                f_10781_6654_6688(accessorDecl != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 6705, 6734);

                var
                body = f_10781_6716_6733(accessorDecl)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 6748, 6838);

                SyntaxToken
                lastToken = (DynAbs.Tracing.TraceSender.Conditional_F1(10781, 6772, 6784) || ((body == null && DynAbs.Tracing.TraceSender.Conditional_F2(10781, 6787, 6814)) || DynAbs.Tracing.TraceSender.Conditional_F3(10781, 6817, 6837))) ? f_10781_6787_6814(accessorDecl) : f_10781_6817_6837(body)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 6852, 6908);

                return f_10781_6859_6907(position, accessorDecl, lastToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 6533, 6919);

                int
                f_10781_6654_6688(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 6654, 6688);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10781_6716_6733(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 6716, 6733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_6787_6814(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.SemicolonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 6787, 6814);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_6817_6837(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                this_param)
                {
                    var return_v = this_param.CloseBraceToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 6817, 6837);
                    return return_v;
                }


                bool
                f_10781_6859_6907(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                node, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBeforeToken(position, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 6859, 6907);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 6533, 6919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 6533, 6919);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsInDelegateDeclaration(int position, DelegateDeclarationSyntax delegateDecl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 6931, 7190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 7054, 7089);

                f_10781_7054_7088(delegateDecl != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 7105, 7179);

                return f_10781_7112_7178(position, delegateDecl, f_10781_7150_7177(delegateDecl));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 6931, 7190);

                int
                f_10781_7054_7088(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 7054, 7088);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_7150_7177(Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.SemicolonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 7150, 7177);
                    return return_v;
                }


                bool
                f_10781_7112_7178(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                node, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBeforeToken(position, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 7112, 7178);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 6931, 7190);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 6931, 7190);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsInTypeDeclaration(int position, BaseTypeDeclarationSyntax typeDecl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 7202, 7442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 7317, 7348);

                f_10781_7317_7347(typeDecl != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 7364, 7431);

                return f_10781_7371_7430(position, typeDecl, f_10781_7405_7429(typeDecl));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 7202, 7442);

                int
                f_10781_7317_7347(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 7317, 7347);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_7405_7429(Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.CloseBraceToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 7405, 7429);
                    return return_v;
                }


                bool
                f_10781_7371_7430(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
                node, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBeforeToken(position, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 7371, 7430);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 7202, 7442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 7202, 7442);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsInNamespaceDeclaration(int position, NamespaceDeclarationSyntax namespaceDecl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 7454, 7739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 7580, 7616);

                f_10781_7580_7615(namespaceDecl != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 7632, 7728);

                return f_10781_7639_7727(position, f_10781_7665_7695(namespaceDecl), f_10781_7697_7726(namespaceDecl));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 7454, 7739);

                int
                f_10781_7580_7615(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 7580, 7615);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_7665_7695(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.NamespaceKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 7665, 7695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_7697_7726(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.CloseBraceToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 7697, 7726);
                    return return_v;
                }


                bool
                f_10781_7639_7727(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBetweenTokens(position, firstIncluded, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 7639, 7727);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 7454, 7739);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 7454, 7739);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsInConstructorParameterScope(int position, ConstructorDeclarationSyntax constructorDecl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 7751, 8893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 7886, 7924);

                f_10781_7886_7923(constructorDecl != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 7940, 7989);

                var
                initializerOpt = f_10781_7961_7988(constructorDecl)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 8003, 8088);

                var
                hasBody = f_10781_8017_8037(constructorDecl) != null || (DynAbs.Tracing.TraceSender.Expression_False(10781, 8017, 8087) || f_10781_8049_8079(constructorDecl) != null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 8104, 8545) || true) && (!hasBody)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 8104, 8545);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 8150, 8267);

                    var
                    nextToken = (SyntaxToken)f_10781_8179_8266(SyntaxNavigator.Instance, constructorDecl, predicate: null, stepInto: null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 8285, 8530);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10781, 8292, 8314) || ((initializerOpt == null && DynAbs.Tracing.TraceSender.Conditional_F2(10781, 8338, 8442)) || DynAbs.Tracing.TraceSender.Conditional_F3(10781, 8466, 8529))) ? position >= f_10781_8350_8379(constructorDecl).CloseParenToken.Span.End && (DynAbs.Tracing.TraceSender.Expression_True(10781, 8338, 8442) && f_10781_8408_8442(position, nextToken)) : f_10781_8466_8529(position, f_10781_8492_8517(initializerOpt), nextToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 8104, 8545);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 8561, 8882);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10781, 8568, 8590) || ((initializerOpt == null && DynAbs.Tracing.TraceSender.Conditional_F2(10781, 8610, 8645)) || DynAbs.Tracing.TraceSender.Conditional_F3(10781, 8665, 8881))) ? f_10781_8610_8645(position, constructorDecl) : f_10781_8665_8881(position, f_10781_8691_8716(initializerOpt), (DynAbs.Tracing.TraceSender.Conditional_F1(10781, 8751, 8807) || ((constructorDecl.SemicolonToken.Kind() == SyntaxKind.None && DynAbs.Tracing.TraceSender.Conditional_F2(10781, 8810, 8847)) || DynAbs.Tracing.TraceSender.Conditional_F3(10781, 8850, 8880))) ? f_10781_8810_8847(constructorDecl.Body!) : f_10781_8850_8880(constructorDecl));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 7751, 8893);

                int
                f_10781_7886_7923(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 7886, 7923);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax?
                f_10781_7961_7988(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 7961, 7988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10781_8017_8037(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 8017, 8037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10781_8049_8079(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 8049, 8079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_8179_8266(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                node, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>?
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetNextToken((Microsoft.CodeAnalysis.SyntaxNode)node, predicate: predicate, stepInto: stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 8179, 8266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                f_10781_8350_8379(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 8350, 8379);
                    return return_v;
                }


                bool
                f_10781_8408_8442(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBeforeToken(position, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 8408, 8442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_8492_8517(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                this_param)
                {
                    var return_v = this_param.ColonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 8492, 8517);
                    return return_v;
                }


                bool
                f_10781_8466_8529(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBetweenTokens(position, firstIncluded, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 8466, 8529);
                    return return_v;
                }


                bool
                f_10781_8610_8645(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                method)
                {
                    var return_v = IsInBody(position, (Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 8610, 8645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_8691_8716(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                this_param)
                {
                    var return_v = this_param.ColonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 8691, 8716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_8810_8847(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                this_param)
                {
                    var return_v = this_param.CloseBraceToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 8810, 8847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_8850_8880(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.SemicolonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 8850, 8880);
                    return return_v;
                }


                bool
                f_10781_8665_8881(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBetweenTokens(position, firstIncluded, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 8665, 8881);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 7751, 8893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 7751, 8893);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsInMethodTypeParameterScope(int position, MethodDeclarationSyntax methodDecl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 8905, 10353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 9029, 9062);

                f_10781_9029_9061(methodDecl != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 9076, 9134);

                f_10781_9076_9133(f_10781_9089_9132(position, methodDecl));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 9150, 9324) || true) && (f_10781_9154_9182(methodDecl) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 9150, 9324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 9296, 9309);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 9150, 9324);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 9452, 9566) || true) && (f_10781_9456_9477(methodDecl).FullSpan.Contains(position))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 9452, 9566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 9539, 9551);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 9452, 9566);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 9660, 9789) || true) && (f_10781_9664_9727(position, f_10781_9701_9726(methodDecl)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 9660, 9789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 9761, 9774);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 9660, 9789);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 9805, 9876);

                var
                explicitInterfaceSpecifier = f_10781_9838_9875(methodDecl)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 9890, 10015);

                var
                firstNameToken = (DynAbs.Tracing.TraceSender.Conditional_F1(10781, 9911, 9945) || ((explicitInterfaceSpecifier == null && DynAbs.Tracing.TraceSender.Conditional_F2(10781, 9948, 9969)) || DynAbs.Tracing.TraceSender.Conditional_F3(10781, 9972, 10014))) ? f_10781_9948_9969(methodDecl) : f_10781_9972_10014(explicitInterfaceSpecifier)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 10031, 10077);

                var
                typeParams = f_10781_10048_10076(methodDecl)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 10091, 10204);

                var
                firstPostNameToken = (DynAbs.Tracing.TraceSender.Conditional_F1(10781, 10116, 10134) || ((typeParams == null && DynAbs.Tracing.TraceSender.Conditional_F2(10781, 10137, 10176)) || DynAbs.Tracing.TraceSender.Conditional_F3(10781, 10179, 10203))) ? f_10781_10137_10176(f_10781_10137_10161(methodDecl)) : f_10781_10179_10203(typeParams)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 10272, 10342);

                return !f_10781_10280_10341(position, firstNameToken, firstPostNameToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 8905, 10353);

                int
                f_10781_9029_9061(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 9029, 9061);
                    return 0;
                }


                bool
                f_10781_9089_9132(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                methodDecl)
                {
                    var return_v = IsInMethodDeclaration(position, (Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)methodDecl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 9089, 9132);
                    return return_v;
                }


                int
                f_10781_9076_9133(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 9076, 9133);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
                f_10781_9154_9182(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.TypeParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 9154, 9182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10781_9456_9477(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 9456, 9477);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10781_9701_9726(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 9701, 9726);
                    return return_v;
                }


                bool
                f_10781_9664_9727(int
                position, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                attributesSyntaxList)
                {
                    var return_v = IsInAttributeSpecification(position, attributesSyntaxList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 9664, 9727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                f_10781_9838_9875(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceSpecifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 9838, 9875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_9948_9969(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 9948, 9969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_9972_10014(Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
                this_param)
                {
                    var return_v = this_param.GetFirstToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 9972, 10014);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                f_10781_10048_10076(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.TypeParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 10048, 10076);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                f_10781_10137_10161(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 10137, 10161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_10137_10176(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                this_param)
                {
                    var return_v = this_param.OpenParenToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 10137, 10176);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_10179_10203(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                this_param)
                {
                    var return_v = this_param.LessThanToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 10179, 10203);
                    return return_v;
                }


                bool
                f_10781_10280_10341(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBetweenTokens(position, firstIncluded, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 10280, 10341);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 8905, 10353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 8905, 10353);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsInStatementScope(int position, StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 10616, 11288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 10721, 10753);

                f_10781_10721_10752(statement != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 10769, 10880) || true) && (f_10781_10773_10789(statement) == SyntaxKind.EmptyStatement)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 10769, 10880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 10852, 10865);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 10769, 10880);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 11044, 11110);

                SyntaxToken
                firstIncludedToken = f_10781_11077_11109(statement)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 11124, 11277);

                return firstIncludedToken != default(SyntaxToken) && (DynAbs.Tracing.TraceSender.Expression_True(10781, 11131, 11276) && f_10781_11197_11276(position, firstIncludedToken, f_10781_11243_11275(statement)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 10616, 11288);

                int
                f_10781_10721_10752(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 10721, 10752);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10781_10773_10789(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 10773, 10789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_11077_11109(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement)
                {
                    var return_v = GetFirstIncludedToken(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 11077, 11109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_11243_11275(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement)
                {
                    var return_v = GetFirstExcludedToken(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 11243, 11275);
                    return return_v;
                }


                bool
                f_10781_11197_11276(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBetweenTokens(position, firstIncluded, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 11197, 11276);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 10616, 11288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 10616, 11288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsInSwitchSectionScope(int position, SwitchSectionSyntax section)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 11556, 11761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 11667, 11697);

                f_10781_11667_11696(section != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 11711, 11750);

                return section.Span.Contains(position);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 11556, 11761);

                int
                f_10781_11667_11696(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 11667, 11696);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 11556, 11761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 11556, 11761);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsInCatchBlockScope(int position, CatchClauseSyntax catchClause)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 12024, 12297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 12134, 12168);

                f_10781_12134_12167(catchClause != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 12184, 12286);

                return f_10781_12191_12285(position, f_10781_12217_12249(f_10781_12217_12234(catchClause)), f_10781_12251_12284(f_10781_12251_12268(catchClause)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 12024, 12297);

                int
                f_10781_12134_12167(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 12134, 12167);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10781_12217_12234(Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax
                this_param)
                {
                    var return_v = this_param.Block;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 12217, 12234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_12217_12249(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                this_param)
                {
                    var return_v = this_param.OpenBraceToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 12217, 12249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10781_12251_12268(Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax
                this_param)
                {
                    var return_v = this_param.Block;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 12251, 12268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_12251_12284(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                this_param)
                {
                    var return_v = this_param.CloseBraceToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 12251, 12284);
                    return return_v;
                }


                bool
                f_10781_12191_12285(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBetweenTokens(position, firstIncluded, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 12191, 12285);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 12024, 12297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 12024, 12297);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsInCatchFilterScope(int position, CatchFilterClauseSyntax filterClause)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 12560, 12832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 12678, 12713);

                f_10781_12678_12712(filterClause != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 12729, 12821);

                return f_10781_12736_12820(position, f_10781_12762_12789(filterClause), f_10781_12791_12819(filterClause));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 12560, 12832);

                int
                f_10781_12678_12712(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 12678, 12712);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_12762_12789(Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax
                this_param)
                {
                    var return_v = this_param.OpenParenToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 12762, 12789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_12791_12819(Microsoft.CodeAnalysis.CSharp.Syntax.CatchFilterClauseSyntax
                this_param)
                {
                    var return_v = this_param.CloseParenToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 12791, 12819);
                    return return_v;
                }


                bool
                f_10781_12736_12820(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBetweenTokens(position, firstIncluded, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 12736, 12820);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 12560, 12832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 12560, 12832);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SyntaxToken GetFirstIncludedToken(StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 12844, 16390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 12944, 12976);

                f_10781_12944_12975(statement != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 12990, 16379);

                switch (f_10781_12998_13014(statement))
                {

                    case SyntaxKind.Block:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 13092, 13139);

                        return f_10781_13099_13138(((BlockSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    case SyntaxKind.BreakStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 13210, 13264);

                        return f_10781_13217_13263(((BreakStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    case SyntaxKind.CheckedStatement:
                    case SyntaxKind.UncheckedStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 13390, 13441);

                        return f_10781_13397_13440(((CheckedStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    case SyntaxKind.ContinueStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 13515, 13575);

                        return f_10781_13522_13574(((ContinueStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    case SyntaxKind.ExpressionStatement:
                    case SyntaxKind.LocalDeclarationStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 13711, 13744);

                        return f_10781_13718_13743(statement);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    case SyntaxKind.DoStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 13812, 13860);

                        return f_10781_13819_13859(((DoStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    case SyntaxKind.EmptyStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 13931, 13959);

                        return default(SyntaxToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    case SyntaxKind.FixedStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 14072, 14126);

                        return f_10781_14079_14125(((FixedStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    case SyntaxKind.ForEachStatement:
                    case SyntaxKind.ForEachVariableStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 14258, 14337);

                        return ((CommonForEachStatementSyntax)statement).OpenParenToken.GetNextToken();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    case SyntaxKind.ForStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 14406, 14475);

                        return ((ForStatementSyntax)statement).OpenParenToken.GetNextToken();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    case SyntaxKind.GotoDefaultStatement:
                    case SyntaxKind.GotoCaseStatement:
                    case SyntaxKind.GotoStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 14652, 14704);

                        return f_10781_14659_14703(((GotoStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    case SyntaxKind.IfStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 14772, 14820);

                        return f_10781_14779_14819(((IfStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    case SyntaxKind.LabeledStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 14893, 14947);

                        return f_10781_14900_14946(((LabeledStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    case SyntaxKind.LockStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 15017, 15069);

                        return f_10781_15024_15068(((LockStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    case SyntaxKind.ReturnStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 15141, 15197);

                        return f_10781_15148_15196(((ReturnStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    case SyntaxKind.SwitchStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 15269, 15338);

                        return f_10781_15276_15337(f_10781_15276_15321(((SwitchStatementSyntax)statement)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    case SyntaxKind.ThrowStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 15409, 15463);

                        return f_10781_15416_15462(((ThrowStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    case SyntaxKind.TryStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 15532, 15582);

                        return f_10781_15539_15581(((TryStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    case SyntaxKind.UnsafeStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 15654, 15710);

                        return f_10781_15661_15709(((UnsafeStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    case SyntaxKind.UsingStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 15781, 15835);

                        return f_10781_15788_15834(((UsingStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    case SyntaxKind.WhileStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 15906, 15960);

                        return f_10781_15913_15959(((WhileStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    case SyntaxKind.YieldReturnStatement:
                    case SyntaxKind.YieldBreakStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 16091, 16145);

                        return f_10781_16098_16144(((YieldStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    case SyntaxKind.LocalFunctionStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 16224, 16257);

                        return f_10781_16231_16256(statement);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 12990, 16379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 16305, 16364);

                        throw f_10781_16311_16363(f_10781_16346_16362(statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 12990, 16379);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 12844, 16390);

                int
                f_10781_12944_12975(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 12944, 12975);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10781_12998_13014(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 12998, 13014);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_13099_13138(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                this_param)
                {
                    var return_v = this_param.OpenBraceToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 13099, 13138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_13217_13263(Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax
                this_param)
                {
                    var return_v = this_param.BreakKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 13217, 13263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_13397_13440(Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax
                this_param)
                {
                    var return_v = this_param.Keyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 13397, 13440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_13522_13574(Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax
                this_param)
                {
                    var return_v = this_param.ContinueKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 13522, 13574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_13718_13743(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.GetFirstToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 13718, 13743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_13819_13859(Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax
                this_param)
                {
                    var return_v = this_param.DoKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 13819, 13859);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_14079_14125(Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax
                this_param)
                {
                    var return_v = this_param.FixedKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 14079, 14125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_14659_14703(Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax
                this_param)
                {
                    var return_v = this_param.GotoKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 14659, 14703);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_14779_14819(Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax
                this_param)
                {
                    var return_v = this_param.IfKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 14779, 14819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_14900_14946(Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 14900, 14946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_15024_15068(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
                this_param)
                {
                    var return_v = this_param.LockKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 15024, 15068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_15148_15196(Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax
                this_param)
                {
                    var return_v = this_param.ReturnKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 15148, 15196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10781_15276_15321(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 15276, 15321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_15276_15337(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.GetFirstToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 15276, 15337);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_15416_15462(Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax
                this_param)
                {
                    var return_v = this_param.ThrowKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 15416, 15462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_15539_15581(Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax
                this_param)
                {
                    var return_v = this_param.TryKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 15539, 15581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_15661_15709(Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax
                this_param)
                {
                    var return_v = this_param.UnsafeKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 15661, 15709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_15788_15834(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
                this_param)
                {
                    var return_v = this_param.UsingKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 15788, 15834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_15913_15959(Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax
                this_param)
                {
                    var return_v = this_param.WhileKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 15913, 15959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_16098_16144(Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax
                this_param)
                {
                    var return_v = this_param.YieldKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 16098, 16144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_16231_16256(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.GetFirstToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 16231, 16256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10781_16346_16362(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 16346, 16362);
                    return return_v;
                }


                System.Exception
                f_10781_16311_16363(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 16311, 16363);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 12844, 16390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 12844, 16390);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken GetFirstExcludedToken(StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 16402, 21331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 16503, 16535);

                f_10781_16503_16534(statement != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 16549, 21320);

                switch (f_10781_16557_16573(statement))
                {

                    case SyntaxKind.Block:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 16651, 16699);

                        return f_10781_16658_16698(((BlockSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.BreakStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 16770, 16826);

                        return f_10781_16777_16825(((BreakStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.CheckedStatement:
                    case SyntaxKind.UncheckedStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 16952, 17017);

                        return f_10781_16959_17016(f_10781_16959_17000(((CheckedStatementSyntax)statement)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.ContinueStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 17091, 17150);

                        return f_10781_17098_17149(((ContinueStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.LocalDeclarationStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 17232, 17299);

                        return f_10781_17239_17298(((LocalDeclarationStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.DoStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 17367, 17420);

                        return f_10781_17374_17419(((DoStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.EmptyStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 17491, 17547);

                        return f_10781_17498_17546(((EmptyStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.ExpressionStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 17623, 17684);

                        return f_10781_17630_17683(((ExpressionStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.FixedStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 17755, 17829);

                        return f_10781_17762_17828(f_10781_17784_17827(((FixedStatementSyntax)statement)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.ForEachStatement:
                    case SyntaxKind.ForEachVariableStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 17961, 18043);

                        return f_10781_17968_18042(f_10781_17990_18041(((CommonForEachStatementSyntax)statement)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.ForStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 18112, 18184);

                        return f_10781_18119_18183(f_10781_18141_18182(((ForStatementSyntax)statement)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.GotoDefaultStatement:
                    case SyntaxKind.GotoCaseStatement:
                    case SyntaxKind.GotoStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 18361, 18416);

                        return f_10781_18368_18415(((GotoStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.IfStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 18484, 18540);

                        IfStatementSyntax
                        ifStmt = (IfStatementSyntax)statement
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 18562, 18602);

                        ElseClauseSyntax?
                        elseOpt = f_10781_18590_18601(ifStmt)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 18624, 18709);

                        return f_10781_18631_18708((DynAbs.Tracing.TraceSender.Conditional_F1(10781, 18653, 18668) || ((elseOpt == null && DynAbs.Tracing.TraceSender.Conditional_F2(10781, 18671, 18687)) || DynAbs.Tracing.TraceSender.Conditional_F3(10781, 18690, 18707))) ? f_10781_18671_18687(ifStmt) : f_10781_18690_18707(elseOpt));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.LabeledStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 18782, 18858);

                        return f_10781_18789_18857(f_10781_18811_18856(((LabeledStatementSyntax)statement)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.LockStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 18928, 19001);

                        return f_10781_18935_19000(f_10781_18957_18999(((LockStatementSyntax)statement)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.ReturnStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 19073, 19130);

                        return f_10781_19080_19129(((ReturnStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.SwitchStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 19202, 19260);

                        return f_10781_19209_19259(((SwitchStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.ThrowStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 19331, 19387);

                        return f_10781_19338_19386(((ThrowStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.TryStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 19456, 19515);

                        TryStatementSyntax
                        tryStmt = (TryStatementSyntax)statement
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 19539, 19592);

                        FinallyClauseSyntax?
                        finallyClause = f_10781_19576_19591(tryStmt)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 19614, 19755) || true) && (finallyClause != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 19614, 19755);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 19689, 19732);

                            return f_10781_19696_19731(f_10781_19696_19715(finallyClause));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 19614, 19755);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 19779, 19842);

                        CatchClauseSyntax?
                        lastCatch = tryStmt.Catches.LastOrDefault()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 19864, 19997) || true) && (lastCatch != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 19864, 19997);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 19935, 19974);

                            return f_10781_19942_19973(f_10781_19942_19957(lastCatch));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 19864, 19997);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 20019, 20056);

                        return f_10781_20026_20055(f_10781_20026_20039(tryStmt));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.UnsafeStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 20128, 20192);

                        return f_10781_20135_20191(f_10781_20135_20175(((UnsafeStatementSyntax)statement)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.UsingStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 20263, 20337);

                        return f_10781_20270_20336(f_10781_20292_20335(((UsingStatementSyntax)statement)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.WhileStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 20408, 20482);

                        return f_10781_20415_20481(f_10781_20437_20480(((WhileStatementSyntax)statement)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.YieldReturnStatement:
                    case SyntaxKind.YieldBreakStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 20613, 20669);

                        return f_10781_20620_20668(((YieldStatementSyntax)statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    case SyntaxKind.LocalFunctionStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 20748, 20837);

                        LocalFunctionStatementSyntax
                        localFunctionStmt = (LocalFunctionStatementSyntax)statement
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 20859, 20973) || true) && (f_10781_20863_20885(localFunctionStmt) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 20859, 20973);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 20920, 20973);

                            return f_10781_20927_20972(f_10781_20949_20971(localFunctionStmt));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 20859, 20973);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 20995, 21122) || true) && (f_10781_20999_21031(localFunctionStmt) != default(SyntaxToken))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 20995, 21122);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 21082, 21122);

                            return f_10781_21089_21121(localFunctionStmt);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 20995, 21122);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 21144, 21198);

                        return f_10781_21151_21197(f_10781_21151_21182(localFunctionStmt));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 16549, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 21246, 21305);

                        throw f_10781_21252_21304(f_10781_21287_21303(statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 16549, 21320);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 16402, 21331);

                int
                f_10781_16503_16534(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 16503, 16534);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10781_16557_16573(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 16557, 16573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_16658_16698(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                this_param)
                {
                    var return_v = this_param.CloseBraceToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 16658, 16698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_16777_16825(Microsoft.CodeAnalysis.CSharp.Syntax.BreakStatementSyntax
                this_param)
                {
                    var return_v = this_param.SemicolonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 16777, 16825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10781_16959_17000(Microsoft.CodeAnalysis.CSharp.Syntax.CheckedStatementSyntax
                this_param)
                {
                    var return_v = this_param.Block;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 16959, 17000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_16959_17016(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                this_param)
                {
                    var return_v = this_param.CloseBraceToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 16959, 17016);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_17098_17149(Microsoft.CodeAnalysis.CSharp.Syntax.ContinueStatementSyntax
                this_param)
                {
                    var return_v = this_param.SemicolonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 17098, 17149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_17239_17298(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
                this_param)
                {
                    var return_v = this_param.SemicolonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 17239, 17298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_17374_17419(Microsoft.CodeAnalysis.CSharp.Syntax.DoStatementSyntax
                this_param)
                {
                    var return_v = this_param.SemicolonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 17374, 17419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_17498_17546(Microsoft.CodeAnalysis.CSharp.Syntax.EmptyStatementSyntax
                this_param)
                {
                    var return_v = this_param.SemicolonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 17498, 17546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_17630_17683(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax
                this_param)
                {
                    var return_v = this_param.SemicolonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 17630, 17683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10781_17784_17827(Microsoft.CodeAnalysis.CSharp.Syntax.FixedStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 17784, 17827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_17762_17828(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement)
                {
                    var return_v = GetFirstExcludedToken(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 17762, 17828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10781_17990_18041(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 17990, 18041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_17968_18042(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement)
                {
                    var return_v = GetFirstExcludedToken(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 17968, 18042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10781_18141_18182(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 18141, 18182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_18119_18183(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement)
                {
                    var return_v = GetFirstExcludedToken(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 18119, 18183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_18368_18415(Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax
                this_param)
                {
                    var return_v = this_param.SemicolonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 18368, 18415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax?
                f_10781_18590_18601(Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax
                this_param)
                {
                    var return_v = this_param.Else;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 18590, 18601);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10781_18671_18687(Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 18671, 18687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10781_18690_18707(Microsoft.CodeAnalysis.CSharp.Syntax.ElseClauseSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 18690, 18707);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_18631_18708(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement)
                {
                    var return_v = GetFirstExcludedToken(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 18631, 18708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10781_18811_18856(Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 18811, 18856);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_18789_18857(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement)
                {
                    var return_v = GetFirstExcludedToken(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 18789, 18857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10781_18957_18999(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 18957, 18999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_18935_19000(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement)
                {
                    var return_v = GetFirstExcludedToken(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 18935, 19000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_19080_19129(Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax
                this_param)
                {
                    var return_v = this_param.SemicolonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 19080, 19129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_19209_19259(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                this_param)
                {
                    var return_v = this_param.CloseBraceToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 19209, 19259);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_19338_19386(Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax
                this_param)
                {
                    var return_v = this_param.SemicolonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 19338, 19386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax?
                f_10781_19576_19591(Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax
                this_param)
                {
                    var return_v = this_param.Finally;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 19576, 19591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10781_19696_19715(Microsoft.CodeAnalysis.CSharp.Syntax.FinallyClauseSyntax
                this_param)
                {
                    var return_v = this_param.Block;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 19696, 19715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_19696_19731(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                this_param)
                {
                    var return_v = this_param.CloseBraceToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 19696, 19731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10781_19942_19957(Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax
                this_param)
                {
                    var return_v = this_param.Block;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 19942, 19957);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_19942_19973(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                this_param)
                {
                    var return_v = this_param.CloseBraceToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 19942, 19973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10781_20026_20039(Microsoft.CodeAnalysis.CSharp.Syntax.TryStatementSyntax
                this_param)
                {
                    var return_v = this_param.Block;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 20026, 20039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_20026_20055(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                this_param)
                {
                    var return_v = this_param.CloseBraceToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 20026, 20055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10781_20135_20175(Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax
                this_param)
                {
                    var return_v = this_param.Block;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 20135, 20175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_20135_20191(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                this_param)
                {
                    var return_v = this_param.CloseBraceToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 20135, 20191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10781_20292_20335(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 20292, 20335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_20270_20336(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement)
                {
                    var return_v = GetFirstExcludedToken(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 20270, 20336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10781_20437_20480(Microsoft.CodeAnalysis.CSharp.Syntax.WhileStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 20437, 20480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_20415_20481(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement)
                {
                    var return_v = GetFirstExcludedToken(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 20415, 20481);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_20620_20668(Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax
                this_param)
                {
                    var return_v = this_param.SemicolonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 20620, 20668);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10781_20863_20885(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 20863, 20885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10781_20949_20971(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 20949, 20971);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_20927_20972(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                statement)
                {
                    var return_v = GetFirstExcludedToken((Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 20927, 20972);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_20999_21031(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.SemicolonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 20999, 21031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_21089_21121(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.SemicolonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 21089, 21121);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                f_10781_21151_21182(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 21151, 21182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_21151_21197(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                this_param)
                {
                    var return_v = this_param.GetLastToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 21151, 21197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10781_21287_21303(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 21287, 21303);
                    return return_v;
                }


                System.Exception
                f_10781_21252_21304(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 21252, 21304);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 16402, 21331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 16402, 21331);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsInAnonymousFunctionOrQuery(int position, SyntaxNode lambdaExpressionOrQueryNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 21343, 23469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 21471, 21576);

                f_10781_21471_21575(f_10781_21484_21533(lambdaExpressionOrQueryNode) || (DynAbs.Tracing.TraceSender.Expression_False(10781, 21484, 21574) || f_10781_21537_21574(lambdaExpressionOrQueryNode)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 21592, 21618);

                SyntaxToken
                firstIncluded
                = default(SyntaxToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 21632, 21654);

                CSharpSyntaxNode
                body
                = default(CSharpSyntaxNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 21670, 23098);

                switch (f_10781_21678_21712(lambdaExpressionOrQueryNode))
                {

                    case SyntaxKind.SimpleLambdaExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 21670, 23098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 21807, 21903);

                        SimpleLambdaExpressionSyntax
                        simple = (SimpleLambdaExpressionSyntax)lambdaExpressionOrQueryNode
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 21925, 21959);

                        firstIncluded = f_10781_21941_21958(simple);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 21981, 22000);

                        body = f_10781_21988_21999(simple);
                        DynAbs.Tracing.TraceSender.TraceBreak(10781, 22022, 22028);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 21670, 23098);

                    case SyntaxKind.ParenthesizedLambdaExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 21670, 23098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 22116, 22233);

                        ParenthesizedLambdaExpressionSyntax
                        parenthesized = (ParenthesizedLambdaExpressionSyntax)lambdaExpressionOrQueryNode
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 22255, 22296);

                        firstIncluded = f_10781_22271_22295(parenthesized);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 22318, 22344);

                        body = f_10781_22325_22343(parenthesized);
                        DynAbs.Tracing.TraceSender.TraceBreak(10781, 22366, 22372);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 21670, 23098);

                    case SyntaxKind.AnonymousMethodExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 21670, 23098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 22456, 22556);

                        AnonymousMethodExpressionSyntax
                        anon = (AnonymousMethodExpressionSyntax)lambdaExpressionOrQueryNode
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 22578, 22596);

                        body = f_10781_22585_22595(anon);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 22618, 22677);

                        firstIncluded = f_10781_22634_22676(body, includeZeroWidth: true);
                        DynAbs.Tracing.TraceSender.TraceBreak(10781, 22699, 22705);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 21670, 23098);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10781, 21670, 23098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 22879, 22954);

                        firstIncluded = f_10781_22895_22938(lambdaExpressionOrQueryNode).GetNextToken();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 22976, 23083);

                        return f_10781_22983_23082(position, firstIncluded, f_10781_23024_23066(lambdaExpressionOrQueryNode).GetNextToken());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10781, 21670, 23098);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 23114, 23158);

                var
                bodyStatement = body as StatementSyntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 23172, 23379);

                var
                firstExcluded = (DynAbs.Tracing.TraceSender.Conditional_F1(10781, 23192, 23213) || ((bodyStatement != null && DynAbs.Tracing.TraceSender.Conditional_F2(10781, 23233, 23269)) || DynAbs.Tracing.TraceSender.Conditional_F3(10781, 23289, 23378))) ? f_10781_23233_23269(bodyStatement) : (SyntaxToken)f_10781_23302_23378(SyntaxNavigator.Instance, body, predicate: null, stepInto: null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 23395, 23458);

                return f_10781_23402_23457(position, firstIncluded, firstExcluded);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 21343, 23469);

                bool
                f_10781_21484_21533(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = syntax.IsAnonymousFunction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 21484, 21533);
                    return return_v;
                }


                bool
                f_10781_21537_21574(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = syntax.IsQuery();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 21537, 21574);
                    return return_v;
                }


                int
                f_10781_21471_21575(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 21471, 21575);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10781_21678_21712(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 21678, 21712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_21941_21958(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
                this_param)
                {
                    var return_v = this_param.ArrowToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 21941, 21958);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10781_21988_21999(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 21988, 21999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_22271_22295(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
                this_param)
                {
                    var return_v = this_param.ArrowToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 22271, 22295);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10781_22325_22343(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 22325, 22343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10781_22585_22595(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Block;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 22585, 22595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_22634_22676(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, bool
                includeZeroWidth)
                {
                    var return_v = this_param.GetFirstToken(includeZeroWidth: includeZeroWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 22634, 22676);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_22895_22938(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetFirstToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 22895, 22938);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_23024_23066(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLastToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 23024, 23066);
                    return return_v;
                }


                bool
                f_10781_22983_23082(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBetweenTokens(position, firstIncluded, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 22983, 23082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_23233_23269(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement)
                {
                    var return_v = GetFirstExcludedToken(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 23233, 23269);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_23302_23378(Microsoft.CodeAnalysis.SyntaxNavigator
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>?
                predicate, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>?
                stepInto)
                {
                    var return_v = this_param.GetNextToken((Microsoft.CodeAnalysis.SyntaxNode)node, predicate: predicate, stepInto: stepInto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 23302, 23378);
                    return return_v;
                }


                bool
                f_10781_23402_23457(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBetweenTokens(position, firstIncluded, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 23402, 23457);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 21343, 23469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 21343, 23469);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsInXmlAttributeValue(int position, XmlAttributeSyntax attribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10781, 23481, 23688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10781, 23592, 23677);

                return f_10781_23599_23676(position, f_10781_23625_23650(attribute), f_10781_23652_23675(attribute));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10781, 23481, 23688);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_23625_23650(Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax
                this_param)
                {
                    var return_v = this_param.StartQuoteToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 23625, 23650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10781_23652_23675(Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax
                this_param)
                {
                    var return_v = this_param.EndQuoteToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10781, 23652, 23675);
                    return return_v;
                }


                bool
                f_10781_23599_23676(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = IsBetweenTokens(position, firstIncluded, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10781, 23599, 23676);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10781, 23481, 23688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 23481, 23688);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LookupPosition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10781, 743, 23695);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10781, 743, 23695);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10781, 743, 23695);
        }

    }
}
