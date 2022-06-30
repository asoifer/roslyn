// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CodeAnalysis
{
    public static partial class SyntaxNodeExtensions
    {
        public static TRoot ReplaceSyntax<TRoot>(
                    this TRoot root,
                    IEnumerable<SyntaxNode> nodes,
                    Func<SyntaxNode, SyntaxNode, SyntaxNode> computeReplacementNode,
                    IEnumerable<SyntaxToken> tokens,
                    Func<SyntaxToken, SyntaxToken, SyntaxToken> computeReplacementToken,
                    IEnumerable<SyntaxTrivia> trivia,
                    Func<SyntaxTrivia, SyntaxTrivia, SyntaxTrivia> computeReplacementTrivia)
                    where TRoot : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 1746, 2553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 2263, 2542);

                return (TRoot)f_689_2277_2541(root, nodes: nodes, computeReplacementNode: computeReplacementNode, tokens: tokens, computeReplacementToken: computeReplacementToken, trivia: trivia, computeReplacementTrivia: computeReplacementTrivia);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 1746, 2553);

                Microsoft.CodeAnalysis.SyntaxNode
                f_689_2277_2541(TRoot
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                nodes, System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
                computeReplacementNode, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                tokens, System.Func<Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.SyntaxToken>
                computeReplacementToken, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                trivia, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.SyntaxTrivia>
                computeReplacementTrivia)
                {
                    var return_v = this_param.ReplaceCore<Microsoft.CodeAnalysis.SyntaxNode>(nodes: nodes, computeReplacementNode: computeReplacementNode, tokens: tokens, computeReplacementToken: computeReplacementToken, trivia: trivia, computeReplacementTrivia: computeReplacementTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 2277, 2541);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 1746, 2553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 1746, 2553);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TRoot ReplaceNodes<TRoot, TNode>(this TRoot root, IEnumerable<TNode> nodes, Func<TNode, TNode, SyntaxNode> computeReplacementNode)
                    where TRoot : SyntaxNode
                    where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 3322, 3671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 3567, 3660);

                return (TRoot)f_689_3581_3659(root, nodes: nodes, computeReplacementNode: computeReplacementNode);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 3322, 3671);

                Microsoft.CodeAnalysis.SyntaxNode
                f_689_3581_3659(TRoot
                this_param, System.Collections.Generic.IEnumerable<TNode>
                nodes, System.Func<TNode, TNode, Microsoft.CodeAnalysis.SyntaxNode>
                computeReplacementNode)
                {
                    var return_v = this_param.ReplaceCore<TNode>(nodes: nodes, computeReplacementNode: computeReplacementNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 3581, 3659);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 3322, 3671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 3322, 3671);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TRoot ReplaceNode<TRoot>(this TRoot root, SyntaxNode oldNode, SyntaxNode newNode)
                    where TRoot : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 4181, 4549);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 4339, 4422) || true) && (oldNode == newNode)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(689, 4339, 4422);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 4395, 4407);

                    return root;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(689, 4339, 4422);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 4438, 4538);

                return (TRoot)f_689_4452_4537(root, nodes: new[] { oldNode }, computeReplacementNode: (o, r) => newNode);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 4181, 4549);

                Microsoft.CodeAnalysis.SyntaxNode
                f_689_4452_4537(TRoot
                this_param, Microsoft.CodeAnalysis.SyntaxNode[]
                nodes, System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>?
                computeReplacementNode)
                {
                    var return_v = this_param.ReplaceCore<Microsoft.CodeAnalysis.SyntaxNode>(nodes: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>)nodes, computeReplacementNode: computeReplacementNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 4452, 4537);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 4181, 4549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 4181, 4549);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TRoot ReplaceNode<TRoot>(this TRoot root, SyntaxNode oldNode, IEnumerable<SyntaxNode> newNodes)
                    where TRoot : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 5087, 5330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 5259, 5319);

                return (TRoot)f_689_5273_5318(root, oldNode, newNodes);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 5087, 5330);

                Microsoft.CodeAnalysis.SyntaxNode
                f_689_5273_5318(TRoot
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                originalNode, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                replacementNodes)
                {
                    var return_v = this_param.ReplaceNodeInListCore(originalNode, replacementNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 5273, 5318);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 5087, 5330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 5087, 5330);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TRoot InsertNodesBefore<TRoot>(this TRoot root, SyntaxNode nodeInList, IEnumerable<SyntaxNode> newNodes)
                    where TRoot : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 5887, 6162);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 6068, 6151);

                return (TRoot)f_689_6082_6150(root, nodeInList, newNodes, insertBefore: true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 5887, 6162);

                Microsoft.CodeAnalysis.SyntaxNode
                f_689_6082_6150(TRoot
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                nodeInList, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                nodesToInsert, bool
                insertBefore)
                {
                    var return_v = this_param.InsertNodesInListCore(nodeInList, nodesToInsert, insertBefore: insertBefore);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 6082, 6150);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 5887, 6162);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 5887, 6162);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TRoot InsertNodesAfter<TRoot>(this TRoot root, SyntaxNode nodeInList, IEnumerable<SyntaxNode> newNodes)
                    where TRoot : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 6716, 6991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 6896, 6980);

                return (TRoot)f_689_6910_6979(root, nodeInList, newNodes, insertBefore: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 6716, 6991);

                Microsoft.CodeAnalysis.SyntaxNode
                f_689_6910_6979(TRoot
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                nodeInList, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                nodesToInsert, bool
                insertBefore)
                {
                    var return_v = this_param.InsertNodesInListCore(nodeInList, nodesToInsert, insertBefore: insertBefore);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 6910, 6979);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 6716, 6991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 6716, 6991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TRoot ReplaceToken<TRoot>(this TRoot root, SyntaxToken tokenInList, IEnumerable<SyntaxToken> newTokens)
                    where TRoot : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 7547, 7804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 7727, 7793);

                return (TRoot)f_689_7741_7792(root, tokenInList, newTokens);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 7547, 7804);

                Microsoft.CodeAnalysis.SyntaxNode
                f_689_7741_7792(TRoot
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                originalToken, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                newTokens)
                {
                    var return_v = this_param.ReplaceTokenInListCore(originalToken, newTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 7741, 7792);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 7547, 7804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 7547, 7804);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TRoot InsertTokensBefore<TRoot>(this TRoot root, SyntaxToken tokenInList, IEnumerable<SyntaxToken> newTokens)
                    where TRoot : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 8372, 8655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 8558, 8644);

                return (TRoot)f_689_8572_8643(root, tokenInList, newTokens, insertBefore: true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 8372, 8655);

                Microsoft.CodeAnalysis.SyntaxNode
                f_689_8572_8643(TRoot
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                originalToken, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                newTokens, bool
                insertBefore)
                {
                    var return_v = this_param.InsertTokensInListCore(originalToken, newTokens, insertBefore: insertBefore);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 8572, 8643);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 8372, 8655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 8372, 8655);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TRoot InsertTokensAfter<TRoot>(this TRoot root, SyntaxToken tokenInList, IEnumerable<SyntaxToken> newTokens)
                    where TRoot : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 9220, 9503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 9405, 9492);

                return (TRoot)f_689_9419_9491(root, tokenInList, newTokens, insertBefore: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 9220, 9503);

                Microsoft.CodeAnalysis.SyntaxNode
                f_689_9419_9491(TRoot
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                originalToken, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                newTokens, bool
                insertBefore)
                {
                    var return_v = this_param.InsertTokensInListCore(originalToken, newTokens, insertBefore: insertBefore);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 9419, 9491);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 9220, 9503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 9220, 9503);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TRoot ReplaceTrivia<TRoot>(this TRoot root, SyntaxTrivia oldTrivia, IEnumerable<SyntaxTrivia> newTrivia)
                    where TRoot : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 10028, 10285);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 10209, 10274);

                return (TRoot)f_689_10223_10273(root, oldTrivia, newTrivia);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 10028, 10285);

                Microsoft.CodeAnalysis.SyntaxNode
                f_689_10223_10273(TRoot
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                originalTrivia, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                newTrivia)
                {
                    var return_v = this_param.ReplaceTriviaInListCore(originalTrivia, newTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 10223, 10273);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 10028, 10285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 10028, 10285);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TRoot InsertTriviaBefore<TRoot>(this TRoot root, SyntaxTrivia trivia, IEnumerable<SyntaxTrivia> newTrivia)
                    where TRoot : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 10819, 11094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 11002, 11083);

                return (TRoot)f_689_11016_11082(root, trivia, newTrivia, insertBefore: true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 10819, 11094);

                Microsoft.CodeAnalysis.SyntaxNode
                f_689_11016_11082(TRoot
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                originalTrivia, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                newTrivia, bool
                insertBefore)
                {
                    var return_v = this_param.InsertTriviaInListCore(originalTrivia, newTrivia, insertBefore: insertBefore);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 11016, 11082);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 10819, 11094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 10819, 11094);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TRoot InsertTriviaAfter<TRoot>(this TRoot root, SyntaxTrivia trivia, IEnumerable<SyntaxTrivia> newTrivia)
                    where TRoot : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 11625, 11900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 11807, 11889);

                return (TRoot)f_689_11821_11888(root, trivia, newTrivia, insertBefore: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 11625, 11900);

                Microsoft.CodeAnalysis.SyntaxNode
                f_689_11821_11888(TRoot
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                originalTrivia, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                newTrivia, bool
                insertBefore)
                {
                    var return_v = this_param.InsertTriviaInListCore(originalTrivia, newTrivia, insertBefore: insertBefore);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 11821, 11888);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 11625, 11900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 11625, 11900);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TRoot ReplaceTokens<TRoot>(this TRoot root, IEnumerable<SyntaxToken> tokens, Func<SyntaxToken, SyntaxToken, SyntaxToken> computeReplacementToken)
                    where TRoot : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 12583, 12925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 12805, 12914);

                return (TRoot)f_689_12819_12913(root, tokens: tokens, computeReplacementToken: computeReplacementToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 12583, 12925);

                Microsoft.CodeAnalysis.SyntaxNode
                f_689_12819_12913(TRoot
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                tokens, System.Func<Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.SyntaxToken>
                computeReplacementToken)
                {
                    var return_v = this_param.ReplaceCore<Microsoft.CodeAnalysis.SyntaxNode>(tokens: tokens, computeReplacementToken: computeReplacementToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 12819, 12913);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 12583, 12925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 12583, 12925);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TRoot ReplaceToken<TRoot>(this TRoot root, SyntaxToken oldToken, SyntaxToken newToken)
                    where TRoot : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 13424, 13714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 13587, 13703);

                return (TRoot)f_689_13601_13702(root, tokens: new[] { oldToken }, computeReplacementToken: (o, r) => newToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 13424, 13714);

                Microsoft.CodeAnalysis.SyntaxNode
                f_689_13601_13702(TRoot
                this_param, Microsoft.CodeAnalysis.SyntaxToken[]
                tokens, System.Func<Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.SyntaxToken>?
                computeReplacementToken)
                {
                    var return_v = this_param.ReplaceCore<Microsoft.CodeAnalysis.SyntaxNode>(tokens: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>)tokens, computeReplacementToken: computeReplacementToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 13601, 13702);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 13424, 13714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 13424, 13714);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TRoot ReplaceTrivia<TRoot>(this TRoot root, IEnumerable<SyntaxTrivia> trivia, Func<SyntaxTrivia, SyntaxTrivia, SyntaxTrivia> computeReplacementTrivia)
                    where TRoot : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 14400, 14749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 14627, 14738);

                return (TRoot)f_689_14641_14737(root, trivia: trivia, computeReplacementTrivia: computeReplacementTrivia);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 14400, 14749);

                Microsoft.CodeAnalysis.SyntaxNode
                f_689_14641_14737(TRoot
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                trivia, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.SyntaxTrivia>
                computeReplacementTrivia)
                {
                    var return_v = this_param.ReplaceCore<Microsoft.CodeAnalysis.SyntaxNode>(trivia: trivia, computeReplacementTrivia: computeReplacementTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 14641, 14737);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 14400, 14749);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 14400, 14749);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TRoot ReplaceTrivia<TRoot>(this TRoot root, SyntaxTrivia trivia, SyntaxTrivia newTrivia)
                    where TRoot : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 15233, 15525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 15398, 15514);

                return (TRoot)f_689_15412_15513(root, trivia: new[] { trivia }, computeReplacementTrivia: (o, r) => newTrivia);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 15233, 15525);

                Microsoft.CodeAnalysis.SyntaxNode
                f_689_15412_15513(TRoot
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia[]
                trivia, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.SyntaxTrivia>?
                computeReplacementTrivia)
                {
                    var return_v = this_param.ReplaceCore<Microsoft.CodeAnalysis.SyntaxNode>(trivia: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>)trivia, computeReplacementTrivia: computeReplacementTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 15412, 15513);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 15233, 15525);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 15233, 15525);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TRoot? RemoveNode<TRoot>(this TRoot root,
                    SyntaxNode node,
                    SyntaxRemoveOptions options)
                    where TRoot : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 15993, 16255);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 16183, 16244);

                return (TRoot?)f_689_16198_16243(root, new[] { node }, options);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 15993, 16255);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_689_16198_16243(TRoot
                this_param, Microsoft.CodeAnalysis.SyntaxNode[]
                nodes, Microsoft.CodeAnalysis.SyntaxRemoveOptions
                options)
                {
                    var return_v = this_param.RemoveNodesCore((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>)nodes, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 16198, 16243);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 15993, 16255);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 15993, 16255);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TRoot? RemoveNodes<TRoot>(
                    this TRoot root,
                    IEnumerable<SyntaxNode> nodes,
                    SyntaxRemoveOptions options)
                    where TRoot : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 16726, 17008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 16945, 16997);

                return (TRoot?)f_689_16960_16996(root, nodes, options);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 16726, 17008);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_689_16960_16996(TRoot
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                nodes, Microsoft.CodeAnalysis.SyntaxRemoveOptions
                options)
                {
                    var return_v = this_param.RemoveNodesCore(nodes, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 16960, 16996);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 16726, 17008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 16726, 17008);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal const string
        DefaultIndentation = "    "
        ;

        internal const string
        DefaultEOL = "\r\n"
        ;

        public static TNode NormalizeWhitespace<TNode>(this TNode node, string indentation, bool elasticTrivia)
                    where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 17672, 17932);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 17838, 17921);

                return (TNode)f_689_17852_17920(node, indentation, DefaultEOL, elasticTrivia);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 17672, 17932);

                Microsoft.CodeAnalysis.SyntaxNode
                f_689_17852_17920(TNode
                this_param, string
                indentation, string
                eol, bool
                elasticTrivia)
                {
                    var return_v = this_param.NormalizeWhitespaceCore(indentation, eol, elasticTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 17852, 17920);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 17672, 17932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 17672, 17932);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TNode NormalizeWhitespace<TNode>(this TNode node, string indentation = DefaultIndentation, string eol = DefaultEOL, bool elasticTrivia = false)
                    where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 18599, 18906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 18819, 18895);

                return (TNode)f_689_18833_18894(node, indentation, eol, elasticTrivia);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 18599, 18906);

                Microsoft.CodeAnalysis.SyntaxNode
                f_689_18833_18894(TNode
                this_param, string
                indentation, string
                eol, bool
                elasticTrivia)
                {
                    var return_v = this_param.NormalizeWhitespaceCore(indentation, eol, elasticTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 18833, 18894);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 18599, 18906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 18599, 18906);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TSyntax WithTriviaFrom<TSyntax>(this TSyntax syntax, SyntaxNode node)
                    where TSyntax : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 19077, 19338);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 19225, 19327);

                return syntax.WithLeadingTrivia(f_689_19257_19280(node)).WithTrailingTrivia(f_689_19301_19325(node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 19077, 19338);

                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_689_19257_19280(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLeadingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 19257, 19280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_689_19301_19325(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetTrailingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 19301, 19325);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 19077, 19338);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 19077, 19338);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TSyntax WithoutTrivia<TSyntax>(this TSyntax syntax)
                    where TSyntax : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 19480, 19682);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 19610, 19671);

                return f_689_19617_19670(f_689_19617_19646(syntax));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 19480, 19682);

                TSyntax
                f_689_19617_19646(TSyntax
                node)
                {
                    var return_v = node.WithoutLeadingTrivia<TSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 19617, 19646);
                    return return_v;
                }


                TSyntax
                f_689_19617_19670(TSyntax
                node)
                {
                    var return_v = node.WithoutTrailingTrivia<TSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 19617, 19670);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 19480, 19682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 19480, 19682);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken WithoutTrivia(this SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(689, 19903, 20024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 19906, 20024);
                return token.WithTrailingTrivia(default(SyntaxTriviaList)).WithLeadingTrivia(default(SyntaxTriviaList)); DynAbs.Tracing.TraceSender.TraceExitMethod(689, 19903, 20024);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 19903, 20024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 19903, 20024);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TSyntax WithLeadingTrivia<TSyntax>(
                    this TSyntax node,
                    SyntaxTriviaList trivia) where TSyntax : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 20165, 20519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 20336, 20391);

                var
                first = f_689_20348_20390(node, includeZeroWidth: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 20405, 20452);

                var
                newFirst = first.WithLeadingTrivia(trivia)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 20466, 20508);

                return node.ReplaceToken(first, newFirst);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 20165, 20519);

                Microsoft.CodeAnalysis.SyntaxToken
                f_689_20348_20390(TSyntax
                this_param, bool
                includeZeroWidth)
                {
                    var return_v = this_param.GetFirstToken(includeZeroWidth: includeZeroWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 20348, 20390);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 20165, 20519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 20165, 20519);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TSyntax WithLeadingTrivia<TSyntax>(
                    this TSyntax node,
                    IEnumerable<SyntaxTrivia>? trivia) where TSyntax : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 20659, 21023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 20840, 20895);

                var
                first = f_689_20852_20894(node, includeZeroWidth: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 20909, 20956);

                var
                newFirst = first.WithLeadingTrivia(trivia)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 20970, 21012);

                return node.ReplaceToken(first, newFirst);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 20659, 21023);

                Microsoft.CodeAnalysis.SyntaxToken
                f_689_20852_20894(TSyntax
                this_param, bool
                includeZeroWidth)
                {
                    var return_v = this_param.GetFirstToken(includeZeroWidth: includeZeroWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 20852, 20894);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 20659, 21023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 20659, 21023);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TSyntax WithoutLeadingTrivia<TSyntax>(
                    this TSyntax node
                    ) where TSyntax : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 21162, 21387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 21312, 21376);

                return f_689_21319_21375(node, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 21162, 21387);

                TSyntax
                f_689_21319_21375(TSyntax
                node, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>?
                trivia)
                {
                    var return_v = node.WithLeadingTrivia<TSyntax>(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 21319, 21375);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 21162, 21387);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 21162, 21387);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TSyntax WithLeadingTrivia<TSyntax>(
                    this TSyntax node,
                    params SyntaxTrivia[]? trivia) where TSyntax : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 21527, 21781);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 21704, 21770);

                return f_689_21711_21769(node, trivia);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 21527, 21781);

                TSyntax
                f_689_21711_21769(TSyntax
                node, Microsoft.CodeAnalysis.SyntaxTrivia[]?
                trivia)
                {
                    var return_v = node.WithLeadingTrivia<TSyntax>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>?)trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 21711, 21769);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 21527, 21781);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 21527, 21781);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TSyntax WithTrailingTrivia<TSyntax>(
                    this TSyntax node,
                    SyntaxTriviaList trivia) where TSyntax : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 21922, 22272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 22094, 22147);

                var
                last = f_689_22105_22146(node, includeZeroWidth: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 22161, 22207);

                var
                newLast = last.WithTrailingTrivia(trivia)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 22221, 22261);

                return node.ReplaceToken(last, newLast);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 21922, 22272);

                Microsoft.CodeAnalysis.SyntaxToken
                f_689_22105_22146(TSyntax
                this_param, bool
                includeZeroWidth)
                {
                    var return_v = this_param.GetLastToken(includeZeroWidth: includeZeroWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 22105, 22146);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 21922, 22272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 21922, 22272);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TSyntax WithTrailingTrivia<TSyntax>(
                    this TSyntax node,
                    IEnumerable<SyntaxTrivia>? trivia) where TSyntax : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 22413, 22773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 22595, 22648);

                var
                last = f_689_22606_22647(node, includeZeroWidth: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 22662, 22708);

                var
                newLast = last.WithTrailingTrivia(trivia)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 22722, 22762);

                return node.ReplaceToken(last, newLast);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 22413, 22773);

                Microsoft.CodeAnalysis.SyntaxToken
                f_689_22606_22647(TSyntax
                this_param, bool
                includeZeroWidth)
                {
                    var return_v = this_param.GetLastToken(includeZeroWidth: includeZeroWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 22606, 22647);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 22413, 22773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 22413, 22773);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TSyntax WithoutTrailingTrivia<TSyntax>(this TSyntax node) where TSyntax : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 22913, 23112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 23036, 23101);

                return f_689_23043_23100(node, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 22913, 23112);

                TSyntax
                f_689_23043_23100(TSyntax
                node, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>?
                trivia)
                {
                    var return_v = node.WithTrailingTrivia<TSyntax>(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 23043, 23100);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 22913, 23112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 22913, 23112);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TSyntax WithTrailingTrivia<TSyntax>(
                    this TSyntax node,
                    params SyntaxTrivia[]? trivia) where TSyntax : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 23253, 23509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 23431, 23498);

                return f_689_23438_23497(node, trivia);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 23253, 23509);

                TSyntax
                f_689_23438_23497(TSyntax
                node, Microsoft.CodeAnalysis.SyntaxTrivia[]?
                trivia)
                {
                    var return_v = node.WithTrailingTrivia<TSyntax>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>?)trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 23438, 23497);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 23253, 23509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 23253, 23509);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("node")]
        internal static SyntaxNode? AsRootOfNewTreeWithOptionsFrom(this SyntaxNode? node, SyntaxTree oldTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(689, 23667, 23937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 23837, 23926);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(689, 23844, 23856) || ((node != null && DynAbs.Tracing.TraceSender.Conditional_F2(689, 23859, 23918)) || DynAbs.Tracing.TraceSender.Conditional_F3(689, 23921, 23925))) ? f_689_23859_23918(f_689_23859_23908(oldTree, node, f_689_23892_23907(oldTree))) : null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(689, 23667, 23937);

                Microsoft.CodeAnalysis.ParseOptions
                f_689_23892_23907(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(689, 23892, 23907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_689_23859_23908(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                root, Microsoft.CodeAnalysis.ParseOptions
                options)
                {
                    var return_v = this_param.WithRootAndOptions(root, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 23859, 23908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_689_23859_23918(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(689, 23859, 23918);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(689, 23667, 23937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 23667, 23937);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxNodeExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(689, 341, 23944);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 17042, 17069);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(689, 17102, 17121);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 590, 675);
            // LAFHIS
            s_nodeToIdMap = f_690_619_675(); 
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 759, 850);
            // LAFHIS
            s_rootToCurrentNodesMap = f_690_798_850(); 
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 885, 908);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(689, 341, 23944);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(689, 341, 23944);
        }

        // LAFHIS
        static System.Runtime.CompilerServices.ConditionalWeakTable<SyntaxNode, SyntaxAnnotation> f_690_619_675()
        {
            var temp = new System.Runtime.CompilerServices.ConditionalWeakTable<SyntaxNode, SyntaxAnnotation>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 619, 675);
            return temp;
        }

        // LAFHIS
        static System.Runtime.CompilerServices.ConditionalWeakTable<SyntaxNode, CurrentNodes> f_690_798_850()
        {
            var temp = new System.Runtime.CompilerServices.ConditionalWeakTable<SyntaxNode, CurrentNodes>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 798, 850);
            return temp;
        }
    }
}
