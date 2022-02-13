// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
    public abstract class SemanticModelTestBase : CSharpTestBase
    {
        protected int GetPositionForBinding(SyntaxTree tree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21016, 677, 831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 754, 820);

                return f_21016_761_819(f_21016_761_809(f_21016_785_808(tree)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(21016, 677, 831);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21016, 677, 831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21016, 677, 831);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected int GetPositionForBinding(string code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21016, 843, 1036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 916, 945);

                const string
                tag = "/*pos*/"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 961, 1025);

                return f_21016_968_1011(code, tag, StringComparison.Ordinal) + f_21016_1014_1024(tag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21016, 843, 1036);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21016, 843, 1036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21016, 843, 1036);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected List<ExpressionSyntax> GetExprSyntaxList(SyntaxTree syntaxTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21016, 1048, 1210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 1146, 1199);

                return f_21016_1153_1198(this, f_21016_1171_1191(syntaxTree), null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21016, 1048, 1210);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21016, 1048, 1210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21016, 1048, 1210);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<ExpressionSyntax> GetExprSyntaxList(SyntaxNode node, List<ExpressionSyntax> exprSynList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21016, 1222, 1827);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 1348, 1433) || true) && (exprSynList == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21016, 1348, 1433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 1390, 1433);

                    exprSynList = f_21016_1404_1432();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21016, 1348, 1433);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 1449, 1568) || true) && (node is ExpressionSyntax)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21016, 1449, 1568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 1511, 1553);

                    f_21016_1511_1552(exprSynList, node as ExpressionSyntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21016, 1449, 1568);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 1584, 1781);
                    foreach (var child in f_21016_1606_1632_I(f_21016_1606_1632(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21016, 1584, 1781);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 1666, 1766) || true) && (child.IsNode)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21016, 1666, 1766);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 1705, 1766);

                            exprSynList = f_21016_1719_1765(this, child.AsNode(), exprSynList);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21016, 1666, 1766);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21016, 1584, 1781);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21016, 1, 198);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21016, 1, 198);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 1797, 1816);

                return exprSynList;
                DynAbs.Tracing.TraceSender.TraceExitMethod(21016, 1222, 1827);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21016, 1222, 1827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21016, 1222, 1827);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected ExpressionSyntax GetExprSyntaxForBinding(List<ExpressionSyntax> exprSynList, int index = 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21016, 1839, 3358);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 1965, 2050);

                var
                tagName = f_21016_1979_2049("bind{0}", (DynAbs.Tracing.TraceSender.Conditional_F1(21016, 2004, 2014) || ((index == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(21016, 2017, 2029)) || DynAbs.Tracing.TraceSender.Conditional_F3(21016, 2032, 2048))) ? String.Empty : f_21016_2032_2048(index))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 2064, 2119);

                var
                startComment = f_21016_2083_2118("/*<{0}>*/", tagName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 2133, 2187);

                var
                endComment = f_21016_2150_2186("/*</{0}>*/", tagName)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 2203, 3319);
                    foreach (var exprSyntax in f_21016_2230_2241_I(exprSynList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21016, 2203, 3319);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 2275, 2323);

                        string
                        exprFullText = f_21016_2297_2322(exprSyntax)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 2341, 2376);

                        exprFullText = f_21016_2356_2375(exprFullText);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 2396, 2839) || true) && (f_21016_2400_2463(exprFullText, startComment, StringComparison.Ordinal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21016, 2396, 2839);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 2505, 2820) || true) && (f_21016_2509_2542(exprFullText, endComment))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21016, 2505, 2820);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 2569, 2750) || true) && (f_21016_2573_2632(exprFullText, endComment, StringComparison.Ordinal))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21016, 2569, 2750);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 2663, 2681);

                                    return exprSyntax;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(21016, 2569, 2750);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21016, 2569, 2750);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 2741, 2750);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(21016, 2569, 2750);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21016, 2505, 2820);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21016, 2505, 2820);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 2802, 2820);

                                return exprSyntax;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21016, 2505, 2820);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21016, 2396, 2839);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 2859, 3304) || true) && (f_21016_2863_2922(exprFullText, endComment, StringComparison.Ordinal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21016, 2859, 3304);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 2964, 3285) || true) && (f_21016_2968_3003(exprFullText, startComment))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21016, 2964, 3285);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 3030, 3215) || true) && (f_21016_3034_3097(exprFullText, startComment, StringComparison.Ordinal))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21016, 3030, 3215);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 3128, 3146);

                                    return exprSyntax;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(21016, 3030, 3215);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21016, 3030, 3215);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 3206, 3215);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(21016, 3030, 3215);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21016, 2964, 3285);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21016, 2964, 3285);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 3267, 3285);

                                return exprSyntax;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21016, 2964, 3285);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21016, 2859, 3304);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21016, 2203, 3319);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21016, 1, 1117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21016, 1, 1117);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 3335, 3347);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(21016, 1839, 3358);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21016, 1839, 3358);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21016, 1839, 3358);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SymbolInfo BindFirstConstructorInitializer(string source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21016, 3370, 3908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 3468, 3512);

                var
                compilation = f_21016_3486_3511(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 3526, 3564);

                var
                tree = f_21016_3537_3560(compilation)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 3578, 3625);

                var
                model = f_21016_3590_3624(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 3639, 3730);

                var
                constructorInitializer = f_21016_3668_3729(tree.GetCompilationUnitRoot())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 3746, 3785);

                f_21016_3746_3784(constructorInitializer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 3801, 3897);

                return f_21016_3808_3896(model, f_21016_3839_3871(constructorInitializer), constructorInitializer);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21016, 3370, 3908);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21016, 3370, 3908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21016, 3370, 3908);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ConstructorInitializerSyntax GetFirstConstructorInitializer(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21016, 3920, 4445);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 4036, 4207);

                Func<SyntaxNode, bool>
                isConstructorInitializer = n =>
                                n.IsKind(SyntaxKind.BaseConstructorInitializer) || n.IsKind(SyntaxKind.ThisConstructorInitializer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 4221, 4342);

                var
                constructorInitializers = f_21016_4251_4341(f_21016_4251_4309(node, n => !(n is ExpressionSyntax)), isConstructorInitializer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 4356, 4434);

                return (ConstructorInitializerSyntax)f_21016_4393_4433(constructorInitializers);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21016, 3920, 4445);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21016, 3920, 4445);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21016, 3920, 4445);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected CompilationUtils.SemanticInfoSummary GetSemanticInfoForTest<TNode>(string testSrc, CSharpParseOptions parseOptions = null) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21016, 4457, 4787);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 4639, 4712);

                var
                compilation = f_21016_4657_4711<TNode>(testSrc, parseOptions: parseOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 4726, 4776);

                return f_21016_4733_4775<TNode>(this, compilation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21016, 4457, 4787);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21016, 4457, 4787);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21016, 4457, 4787);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CompilationUtils.SemanticInfoSummary GetSemanticInfoForTestExperimental<TNode>(string testSrc, MessageID feature, CSharpParseOptions parseOptions = null) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21016, 4799, 5194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 5011, 5119);

                var
                compilation = f_21016_5029_5118<TNode>(testSrc, feature, parseOptions: parseOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 5133, 5183);

                return f_21016_5140_5182<TNode>(this, compilation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21016, 4799, 5194);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21016, 4799, 5194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21016, 4799, 5194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected CompilationUtils.SemanticInfoSummary GetSemanticInfoForTest<TNode>(CSharpCompilation compilation) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21016, 5206, 5634);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 5363, 5401);

                var
                tree = f_21016_5374_5397<TNode>(compilation)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 5415, 5462);

                var
                model = f_21016_5427_5461<TNode>(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 5476, 5557);

                var
                syntaxToBind = f_21016_5495_5556<TNode>(f_21016_5532_5555<TNode>(tree))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 5573, 5623);

                return f_21016_5580_5622<TNode>(model, syntaxToBind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21016, 5206, 5634);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21016, 5206, 5634);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21016, 5206, 5634);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PreprocessingSymbolInfo GetPreprocessingSymbolInfoForTest(string testSrc, string subStrForPreprocessNameIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21016, 5646, 6261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 5790, 5835);

                var
                compilation = f_21016_5808_5834(testSrc)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 5849, 5887);

                var
                tree = f_21016_5860_5883(compilation)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 5901, 5948);

                var
                model = f_21016_5913_5947(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 5962, 6049);

                var
                position = f_21016_5977_6048(testSrc, subStrForPreprocessNameIndex, StringComparison.Ordinal)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 6063, 6176);

                var
                nameSyntaxToBind = f_21016_6086_6144(f_21016_6086_6100(tree), position, findInsideTrivia: true).Parent as IdentifierNameSyntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 6192, 6250);

                return f_21016_6199_6249(model, nameSyntaxToBind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21016, 5646, 6261);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21016, 5646, 6261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21016, 5646, 6261);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AliasSymbol GetAliasInfoForTest(string testSrc)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21016, 6273, 6464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 6354, 6399);

                var
                compilation = f_21016_6372_6398(testSrc)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 6413, 6453);

                return f_21016_6420_6452(this, compilation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21016, 6273, 6464);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21016, 6273, 6464);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21016, 6273, 6464);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AliasSymbol GetAliasInfoForTest(CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21016, 6476, 6877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 6572, 6610);

                var
                tree = f_21016_6583_6606(compilation)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 6624, 6671);

                var
                model = f_21016_6636_6670(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 6685, 6798);

                IdentifierNameSyntax
                syntaxToBind = f_21016_6721_6797(f_21016_6773_6796(tree))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 6814, 6866);

                return f_21016_6821_6865(f_21016_6821_6853(model, syntaxToBind));
                DynAbs.Tracing.TraceSender.TraceExitMethod(21016, 6476, 6877);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21016, 6476, 6877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21016, 6476, 6877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected CompilationUtils.SemanticInfoSummary GetSemanticInfoForTest(string testSrc)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21016, 6889, 7067);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21016, 6999, 7056);

                return f_21016_7006_7055(this, testSrc);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21016, 6889, 7067);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21016, 6889, 7067);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21016, 6889, 7067);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SemanticModelTestBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(21016, 600, 7074);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(21016, 600, 7074);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21016, 600, 7074);
        }


        static SemanticModelTestBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21016, 600, 7074);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21016, 600, 7074);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21016, 600, 7074);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(21016, 600, 7074);

        System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
        f_21016_785_808(Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = GetSyntaxNodeList(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 785, 808);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_21016_761_809(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
        synList)
        {
            var return_v = GetSyntaxNodeForBinding(synList);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 761, 809);
            return return_v;
        }


        int
        f_21016_761_819(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.SpanStart;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21016, 761, 819);
            return return_v;
        }


        int
        f_21016_968_1011(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.IndexOf(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 968, 1011);
            return return_v;
        }


        int
        f_21016_1014_1024(string
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21016, 1014, 1024);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_21016_1171_1191(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 1171, 1191);
            return return_v;
        }


        System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
        f_21016_1153_1198(Microsoft.CodeAnalysis.CSharp.UnitTests.SemanticModelTestBase
        this_param, Microsoft.CodeAnalysis.SyntaxNode
        node, System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
        exprSynList)
        {
            var return_v = this_param.GetExprSyntaxList(node, exprSynList);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 1153, 1198);
            return return_v;
        }


        System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
        f_21016_1404_1432()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 1404, 1432);
            return return_v;
        }


        int
        f_21016_1511_1552(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
        this_param, Microsoft.CodeAnalysis.SyntaxNode
        item)
        {
            this_param.Add((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 1511, 1552);
            return 0;
        }


        Microsoft.CodeAnalysis.ChildSyntaxList
        f_21016_1606_1632(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.ChildNodesAndTokens();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 1606, 1632);
            return return_v;
        }


        System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
        f_21016_1719_1765(Microsoft.CodeAnalysis.CSharp.UnitTests.SemanticModelTestBase
        this_param, Microsoft.CodeAnalysis.SyntaxNode?
        node, System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
        exprSynList)
        {
            var return_v = this_param.GetExprSyntaxList(node, exprSynList);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 1719, 1765);
            return return_v;
        }


        Microsoft.CodeAnalysis.ChildSyntaxList
        f_21016_1606_1632_I(Microsoft.CodeAnalysis.ChildSyntaxList
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 1606, 1632);
            return return_v;
        }


        string
        f_21016_2032_2048(int
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 2032, 2048);
            return return_v;
        }


        string
        f_21016_1979_2049(string
        format, string
        arg0)
        {
            var return_v = string.Format(format, (object)arg0);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 1979, 2049);
            return return_v;
        }


        string
        f_21016_2083_2118(string
        format, string
        arg0)
        {
            var return_v = string.Format(format, (object)arg0);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 2083, 2118);
            return return_v;
        }


        string
        f_21016_2150_2186(string
        format, string
        arg0)
        {
            var return_v = string.Format(format, (object)arg0);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 2150, 2186);
            return return_v;
        }


        string
        f_21016_2297_2322(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
        this_param)
        {
            var return_v = this_param.ToFullString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 2297, 2322);
            return return_v;
        }


        string
        f_21016_2356_2375(string
        this_param)
        {
            var return_v = this_param.Trim();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 2356, 2375);
            return return_v;
        }


        bool
        f_21016_2400_2463(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.StartsWith(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 2400, 2463);
            return return_v;
        }


        bool
        f_21016_2509_2542(string
        this_param, string
        value)
        {
            var return_v = this_param.Contains(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 2509, 2542);
            return return_v;
        }


        bool
        f_21016_2573_2632(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.EndsWith(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 2573, 2632);
            return return_v;
        }


        bool
        f_21016_2863_2922(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.EndsWith(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 2863, 2922);
            return return_v;
        }


        bool
        f_21016_2968_3003(string
        this_param, string
        value)
        {
            var return_v = this_param.Contains(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 2968, 3003);
            return return_v;
        }


        bool
        f_21016_3034_3097(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.StartsWith(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 3034, 3097);
            return return_v;
        }


        System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
        f_21016_2230_2241_I(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 2230, 2241);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21016_3486_3511(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 3486, 3511);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
        f_21016_3537_3560(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.SyntaxTrees;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21016, 3537, 3560);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SemanticModel
        f_21016_3590_3624(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 3590, 3624);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
        f_21016_3668_3729(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
        node)
        {
            var return_v = GetFirstConstructorInitializer((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 3668, 3729);
            return return_v;
        }


        static int
        f_21016_3746_3784(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
        @object)
        {
            Assert.NotNull((object)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 3746, 3784);
            return 0;
        }


        static int
        f_21016_3839_3871(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
        this_param)
        {
            var return_v = this_param.SpanStart;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21016, 3839, 3871);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolInfo
        f_21016_3808_3896(Microsoft.CodeAnalysis.SemanticModel
        semanticModel, int
        position, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
        constructorInitializer)
        {
            var return_v = semanticModel.GetSpeculativeSymbolInfo(position, constructorInitializer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 3808, 3896);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_21016_4251_4309(Microsoft.CodeAnalysis.SyntaxNode
        this_param, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
        descendIntoChildren)
        {
            var return_v = this_param.DescendantNodesAndSelf(descendIntoChildren);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 4251, 4309);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_21016_4251_4341(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
        predicate)
        {
            var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 4251, 4341);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_21016_4393_4433(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.FirstOrDefault<Microsoft.CodeAnalysis.SyntaxNode>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 4393, 4433);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21016_4657_4711<TNode>(string
        source, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        parseOptions) where TNode : SyntaxNode

        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions: parseOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 4657, 4711);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.CompilationUtils.SemanticInfoSummary
        f_21016_4733_4775<TNode>(Microsoft.CodeAnalysis.CSharp.UnitTests.SemanticModelTestBase
        this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation) where TNode : SyntaxNode

        {
            var return_v = this_param.GetSemanticInfoForTest<TNode>(compilation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 4733, 4775);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21016_5029_5118<TNode>(string
        source, Microsoft.CodeAnalysis.CSharp.MessageID
        feature, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
        parseOptions) where TNode : SyntaxNode

        {
            var return_v = CreateExperimentalCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, feature, parseOptions: parseOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 5029, 5118);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.CompilationUtils.SemanticInfoSummary
        f_21016_5140_5182<TNode>(Microsoft.CodeAnalysis.CSharp.UnitTests.SemanticModelTestBase
        this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation) where TNode : SyntaxNode

        {
            var return_v = this_param.GetSemanticInfoForTest<TNode>(compilation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 5140, 5182);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
        f_21016_5374_5397<TNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param) where TNode : SyntaxNode

        {
            var return_v = this_param.SyntaxTrees;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21016, 5374, 5397);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_21016_5427_5461<TNode>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree) where TNode : SyntaxNode

        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 5427, 5461);
            return return_v;
        }


        System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
        f_21016_5532_5555<TNode>(Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree) where TNode : SyntaxNode

        {
            var return_v = GetSyntaxNodeList(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 5532, 5555);
            return return_v;
        }


        TNode
        f_21016_5495_5556<TNode>(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
        synList) where TNode : SyntaxNode

        {
            var return_v = GetSyntaxNodeOfTypeForBinding<TNode>(synList);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 5495, 5556);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.CompilationUtils.SemanticInfoSummary
        f_21016_5580_5622<TNode>(Microsoft.CodeAnalysis.SemanticModel
        semanticModel, TNode
        node) where TNode : SyntaxNode

        {
            var return_v = semanticModel.GetSemanticInfoSummary((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 5580, 5622);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21016_5808_5834(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 5808, 5834);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
        f_21016_5860_5883(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.SyntaxTrees;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21016, 5860, 5883);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_21016_5913_5947(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 5913, 5947);
            return return_v;
        }


        int
        f_21016_5977_6048(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.IndexOf(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 5977, 6048);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_21016_6086_6100(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 6086, 6100);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxToken
        f_21016_6086_6144(Microsoft.CodeAnalysis.SyntaxNode
        this_param, int
        position, bool
        findInsideTrivia)
        {
            var return_v = this_param.FindToken(position, findInsideTrivia: findInsideTrivia);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 6086, 6144);
            return return_v;
        }


        Microsoft.CodeAnalysis.PreprocessingSymbolInfo
        f_21016_6199_6249(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax?
        nameSyntax)
        {
            var return_v = this_param.GetPreprocessingSymbolInfo((Microsoft.CodeAnalysis.SyntaxNode?)nameSyntax);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 6199, 6249);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21016_6372_6398(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 6372, 6398);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
        f_21016_6420_6452(Microsoft.CodeAnalysis.CSharp.UnitTests.SemanticModelTestBase
        this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation)
        {
            var return_v = this_param.GetAliasInfoForTest(compilation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 6420, 6452);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
        f_21016_6583_6606(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.SyntaxTrees;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21016, 6583, 6606);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_21016_6636_6670(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 6636, 6670);
            return return_v;
        }


        System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
        f_21016_6773_6796(Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = GetSyntaxNodeList(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 6773, 6796);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
        f_21016_6721_6797(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
        synList)
        {
            var return_v = GetSyntaxNodeOfTypeForBinding<IdentifierNameSyntax>(synList);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 6721, 6797);
            return return_v;
        }


        Microsoft.CodeAnalysis.IAliasSymbol?
        f_21016_6821_6853(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
        nameSyntax)
        {
            var return_v = this_param.GetAliasInfo((Microsoft.CodeAnalysis.SyntaxNode)nameSyntax);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 6821, 6853);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol?
        f_21016_6821_6865(Microsoft.CodeAnalysis.IAliasSymbol?
        symbol)
        {
            var return_v = symbol.GetSymbol();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 6821, 6865);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnitTests.CompilationUtils.SemanticInfoSummary
        f_21016_7006_7055(Microsoft.CodeAnalysis.CSharp.UnitTests.SemanticModelTestBase
        this_param, string
        testSrc)
        {
            var return_v = this_param.GetSemanticInfoForTest<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>(testSrc);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21016, 7006, 7055);
            return return_v;
        }

    }
}
