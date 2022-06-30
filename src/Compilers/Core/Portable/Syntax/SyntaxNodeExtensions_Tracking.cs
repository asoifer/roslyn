// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public static partial class SyntaxNodeExtensions
    {
        private static readonly ConditionalWeakTable<SyntaxNode, SyntaxAnnotation> s_nodeToIdMap
        ;

        private static readonly ConditionalWeakTable<SyntaxNode, CurrentNodes> s_rootToCurrentNodesMap
        ;

        internal const string
        IdAnnotationKind = "Id"
        ;

        public static TRoot TrackNodes<TRoot>(this TRoot root, IEnumerable<SyntaxNode> nodes)
                    where TRoot : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(690, 1449, 2240);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 1597, 1710) || true) && (nodes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 1597, 1710);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 1648, 1695);

                    throw f_690_1654_1694(nameof(nodes));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(690, 1597, 1710);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 1769, 2098);
                    foreach (var node in f_690_1790_1795_I(nodes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 1769, 2098);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 1829, 1989) || true) && (!f_690_1834_1858(root, node))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 1829, 1989);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 1900, 1970);

                            throw f_690_1906_1969(f_690_1928_1968());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(690, 1829, 1989);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 2009, 2083);

                        f_690_2009_2082(
                                        s_nodeToIdMap, node, n => new SyntaxAnnotation(IdAnnotationKind));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(690, 1769, 2098);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(690, 1, 330);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(690, 1, 330);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 2114, 2229);

                return f_690_2121_2228(root, nodes, (n, r) => n.HasAnnotation(GetId(n)!) ? r : r.WithAdditionalAnnotations(GetId(n)!));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(690, 1449, 2240);

                System.ArgumentNullException
                f_690_1654_1694(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 1654, 1694);
                    return return_v;
                }


                bool
                f_690_1834_1858(TRoot
                root, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = IsDescendant((Microsoft.CodeAnalysis.SyntaxNode)root, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 1834, 1858);
                    return return_v;
                }


                string
                f_690_1928_1968()
                {
                    var return_v = CodeAnalysisResources.InvalidNodeToTrack;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(690, 1928, 1968);
                    return return_v;
                }


                System.ArgumentException
                f_690_1906_1969(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 1906, 1969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation
                f_690_2009_2082(System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxAnnotation>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                key, System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxAnnotation>.CreateValueCallback
                createValueCallback)
                {
                    var return_v = this_param.GetValue(key, createValueCallback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 2009, 2082);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_690_1790_1795_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 1790, 1795);
                    return return_v;
                }


                TRoot
                f_690_2121_2228(TRoot
                root, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                nodes, System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
                computeReplacementNode)
                {
                    var return_v = root.ReplaceNodes<TRoot, Microsoft.CodeAnalysis.SyntaxNode>(nodes, computeReplacementNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 2121, 2228);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(690, 1449, 2240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(690, 1449, 2240);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TRoot TrackNodes<TRoot>(this TRoot root, params SyntaxNode[] nodes)
                    where TRoot : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(690, 2780, 2991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 2924, 2980);

                return f_690_2931_2979(root, nodes);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(690, 2780, 2991);

                TRoot
                f_690_2931_2979(TRoot
                root, Microsoft.CodeAnalysis.SyntaxNode[]
                nodes)
                {
                    var return_v = root.TrackNodes<TRoot>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>)nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 2931, 2979);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(690, 2780, 2991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(690, 2780, 2991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<TNode> GetCurrentNodes<TNode>(this SyntaxNode root, TNode node)
                    where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(690, 3408, 3770);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 3560, 3671) || true) && (node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 3560, 3671);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 3610, 3656);

                    throw f_690_3616_3655(nameof(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(690, 3560, 3671);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 3687, 3759);

                return f_690_3694_3758(f_690_3694_3742(f_690_3722_3735(root), node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(690, 3408, 3770);

                System.ArgumentNullException
                f_690_3616_3655(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 3616, 3655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_690_3722_3735(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = GetRoot(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 3722, 3735);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.SyntaxNode>
                f_690_3694_3742(Microsoft.CodeAnalysis.SyntaxNode
                trueRoot, TNode
                node)
                {
                    var return_v = GetCurrentNodeFromTrueRoots(trueRoot, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 3694, 3742);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<TNode>
                f_690_3694_3758(System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.OfType<TNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 3694, 3758);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(690, 3408, 3770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(690, 3408, 3770);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TNode GetCurrentNode<TNode>(this SyntaxNode root, TNode node)
                    where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(690, 4186, 4388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 4324, 4377);

                return f_690_4331_4376(f_690_4331_4358(root, node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(690, 4186, 4388);

                System.Collections.Generic.IEnumerable<TNode>
                f_690_4331_4358(Microsoft.CodeAnalysis.SyntaxNode
                root, TNode
                node)
                {
                    var return_v = root.GetCurrentNodes<TNode>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 4331, 4358);
                    return return_v;
                }


                TNode
                f_690_4331_4376(System.Collections.Generic.IEnumerable<TNode>
                source)
                {
                    var return_v = source.SingleOrDefault<TNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 4331, 4376);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(690, 4186, 4388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(690, 4186, 4388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<TNode> GetCurrentNodes<TNode>(this SyntaxNode root, IEnumerable<TNode> nodes)
                    where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(690, 4818, 5409);

                var listYield = new List<TNode>();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 4984, 5097) || true) && (nodes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 4984, 5097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 5035, 5082);

                    throw f_690_5041_5081(nameof(nodes));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(690, 4984, 5097);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 5113, 5142);

                var
                trueRoot = f_690_5128_5141(root)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 5158, 5398);
                    foreach (var node in f_690_5179_5184_I(nodes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 5158, 5398);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 5218, 5383);
                            foreach (var newNode in f_690_5242_5301_I(f_690_5242_5301(f_690_5242_5285(trueRoot, node))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 5218, 5383);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 5343, 5364);

                                listYield.Add(newNode);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(690, 5218, 5383);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(690, 1, 166);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(690, 1, 166);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(690, 5158, 5398);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(690, 1, 241);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(690, 1, 241);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(690, 4818, 5409);

                return listYield;

                System.ArgumentNullException
                f_690_5041_5081(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 5041, 5081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_690_5128_5141(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = GetRoot(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 5128, 5141);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.SyntaxNode>
                f_690_5242_5285(Microsoft.CodeAnalysis.SyntaxNode
                trueRoot, TNode
                node)
                {
                    var return_v = GetCurrentNodeFromTrueRoots(trueRoot, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 5242, 5285);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<TNode>
                f_690_5242_5301(System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.OfType<TNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 5242, 5301);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<TNode>
                f_690_5242_5301_I(System.Collections.Generic.IEnumerable<TNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 5242, 5301);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<TNode>
                f_690_5179_5184_I(System.Collections.Generic.IEnumerable<TNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 5179, 5184);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(690, 4818, 5409);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(690, 4818, 5409);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IReadOnlyList<SyntaxNode> GetCurrentNodeFromTrueRoots(SyntaxNode trueRoot, SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(690, 5421, 5929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 5552, 5573);

                var
                id = f_690_5561_5572(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 5587, 5918) || true) && (id is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 5587, 5918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 5637, 5729);

                    CurrentNodes
                    tracked = f_690_5660_5728(s_rootToCurrentNodesMap, trueRoot, r => new CurrentNodes(r))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 5747, 5775);

                    return f_690_5754_5774(tracked, id);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(690, 5587, 5918);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 5587, 5918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 5841, 5903);

                    return f_690_5848_5902();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(690, 5587, 5918);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(690, 5421, 5929);

                Microsoft.CodeAnalysis.SyntaxAnnotation?
                f_690_5561_5572(Microsoft.CodeAnalysis.SyntaxNode
                original)
                {
                    var return_v = GetId(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 5561, 5572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeExtensions.CurrentNodes
                f_690_5660_5728(System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNodeExtensions.CurrentNodes>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                key, System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNodeExtensions.CurrentNodes>.CreateValueCallback
                createValueCallback)
                {
                    var return_v = this_param.GetValue(key, createValueCallback);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 5660, 5728);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.SyntaxNode>
                f_690_5754_5774(Microsoft.CodeAnalysis.SyntaxNodeExtensions.CurrentNodes
                this_param, Microsoft.CodeAnalysis.SyntaxAnnotation
                id)
                {
                    var return_v = this_param.GetNodes(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 5754, 5774);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.SyntaxNode>
                f_690_5848_5902()
                {
                    var return_v = SpecializedCollections.EmptyReadOnlyList<SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 5848, 5902);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(690, 5421, 5929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(690, 5421, 5929);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SyntaxAnnotation? GetId(SyntaxNode original)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(690, 5941, 6139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 6025, 6046);

                SyntaxAnnotation?
                id
                = default(SyntaxAnnotation?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 6060, 6104);

                f_690_6060_6103(s_nodeToIdMap, original, out id);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 6118, 6128);

                return id;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(690, 5941, 6139);

                bool
                f_690_6060_6103(System.Runtime.CompilerServices.ConditionalWeakTable<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxAnnotation>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                key, out Microsoft.CodeAnalysis.SyntaxAnnotation?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 6060, 6103);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(690, 5941, 6139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(690, 5941, 6139);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SyntaxNode GetRoot(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(690, 6151, 6723);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 6226, 6712) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 6226, 6712);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 6271, 6377) || true) && (f_690_6278_6289(node) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 6271, 6377);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 6339, 6358);

                                node = f_690_6346_6357(node);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(690, 6271, 6377);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(690, 6271, 6377);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(690, 6271, 6377);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 6397, 6697) || true) && (f_690_6401_6425_M(!node.IsStructuredTrivia))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 6397, 6697);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 6467, 6479);

                            return node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(690, 6397, 6697);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 6397, 6697);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 6561, 6627);

                            node = ((IStructuredTriviaSyntax)node).ParentTrivia.Token.Parent!;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 6649, 6678);

                            f_690_6649_6677(node is object);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(690, 6397, 6697);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(690, 6226, 6712);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(690, 6226, 6712);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(690, 6226, 6712);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(690, 6151, 6723);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_690_6278_6289(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(690, 6278, 6289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_690_6346_6357(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(690, 6346, 6357);
                    return return_v;
                }


                bool
                f_690_6401_6425_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(690, 6401, 6425);
                    return return_v;
                }


                int
                f_690_6649_6677(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 6649, 6677);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(690, 6151, 6723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(690, 6151, 6723);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsDescendant(SyntaxNode root, SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(690, 6735, 7463);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 6826, 7423) || true) && (node != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 6826, 7423);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 6879, 6968) || true) && (node == root)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 6879, 6968);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 6937, 6949);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(690, 6879, 6968);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 6988, 7408) || true) && (f_690_6992_7003(node) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 6988, 7408);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 7053, 7072);

                            node = f_690_7060_7071(node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(690, 6988, 7408);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 6988, 7408);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 7114, 7408) || true) && (f_690_7118_7142_M(!node.IsStructuredTrivia))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 7114, 7408);
                                DynAbs.Tracing.TraceSender.TraceBreak(690, 7184, 7190);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(690, 7114, 7408);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 7114, 7408);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 7272, 7338);

                                node = ((IStructuredTriviaSyntax)node).ParentTrivia.Token.Parent!;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 7360, 7389);

                                f_690_7360_7388(node is object);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(690, 7114, 7408);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(690, 6988, 7408);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(690, 6826, 7423);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(690, 6826, 7423);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(690, 6826, 7423);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 7439, 7452);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(690, 6735, 7463);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_690_6992_7003(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(690, 6992, 7003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_690_7060_7071(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(690, 7060, 7071);
                    return return_v;
                }


                bool
                f_690_7118_7142_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(690, 7118, 7142);
                    return return_v;
                }


                int
                f_690_7360_7388(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 7360, 7388);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(690, 6735, 7463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(690, 6735, 7463);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private class CurrentNodes
        {
            private readonly Dictionary<SyntaxAnnotation, IReadOnlyList<SyntaxNode>> _idToNodeMap;

            public CurrentNodes(SyntaxNode root)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(690, 7628, 8711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 7599, 7611);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 7851, 7914);

                    var
                    map = f_690_7861_7913()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 7934, 8559);
                        foreach (var node in f_690_7955_8029_I(f_690_7955_8029(f_690_7955_8004(root, IdAnnotationKind), n => n.AsNode()!)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 7934, 8559);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 8071, 8100);

                            f_690_8071_8099(node is object);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 8122, 8540);
                                foreach (var id in f_690_8141_8178_I(f_690_8141_8178(node, IdAnnotationKind)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 8122, 8540);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 8228, 8251);

                                    List<SyntaxNode>?
                                    list
                                    = default(List<SyntaxNode>?);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 8277, 8474) || true) && (!f_690_8282_8311(map, id, out list))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 8277, 8474);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 8369, 8399);

                                        list = f_690_8376_8398();
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 8429, 8447);

                                        f_690_8429_8446(map, id, list);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(690, 8277, 8474);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 8502, 8517);

                                    f_690_8502_8516(
                                                            list, node);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(690, 8122, 8540);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(690, 1, 419);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(690, 1, 419);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(690, 7934, 8559);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(690, 1, 626);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(690, 1, 626);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 8579, 8696);

                    _idToNodeMap = f_690_8594_8695(map, kv => kv.Key, kv => (IReadOnlyList<SyntaxNode>)ImmutableArray.CreateRange(kv.Value));
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(690, 7628, 8711);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(690, 7628, 8711);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(690, 7628, 8711);
                }
            }

            public IReadOnlyList<SyntaxNode> GetNodes(SyntaxAnnotation id)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(690, 8727, 9149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 8822, 8855);

                    IReadOnlyList<SyntaxNode>?
                    nodes
                    = default(IReadOnlyList<SyntaxNode>?);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 8873, 9134) || true) && (f_690_8877_8916(_idToNodeMap, id, out nodes))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 8873, 9134);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 8958, 8971);

                        return nodes;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(690, 8873, 9134);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(690, 8873, 9134);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(690, 9053, 9115);

                        return f_690_9060_9114();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(690, 8873, 9134);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(690, 8727, 9149);

                    bool
                    f_690_8877_8916(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxAnnotation, System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.SyntaxNode>>
                    this_param, Microsoft.CodeAnalysis.SyntaxAnnotation
                    key, out System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.SyntaxNode>?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 8877, 8916);
                        return return_v;
                    }


                    System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.SyntaxNode>
                    f_690_9060_9114()
                    {
                        var return_v = SpecializedCollections.EmptyReadOnlyList<SyntaxNode>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 9060, 9114);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(690, 8727, 9149);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(690, 8727, 9149);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static CurrentNodes()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(690, 7475, 9160);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(690, 7475, 9160);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(690, 7475, 9160);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(690, 7475, 9160);

            static System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxAnnotation, System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>>
            f_690_7861_7913()
            {
                var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxAnnotation, System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 7861, 7913);
                return return_v;
            }


            static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
            f_690_7955_8004(Microsoft.CodeAnalysis.SyntaxNode
            this_param, string
            annotationKind)
            {
                var return_v = this_param.GetAnnotatedNodesAndTokens(annotationKind);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 7955, 8004);
                return return_v;
            }


            static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
            f_690_7955_8029(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
            source, System.Func<Microsoft.CodeAnalysis.SyntaxNodeOrToken, Microsoft.CodeAnalysis.SyntaxNode>
            selector)
            {
                var return_v = source.Select<Microsoft.CodeAnalysis.SyntaxNodeOrToken, Microsoft.CodeAnalysis.SyntaxNode>(selector);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 7955, 8029);
                return return_v;
            }


            static int
            f_690_8071_8099(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 8071, 8099);
                return 0;
            }


            static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
            f_690_8141_8178(Microsoft.CodeAnalysis.SyntaxNode
            this_param, string
            annotationKind)
            {
                var return_v = this_param.GetAnnotations(annotationKind);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 8141, 8178);
                return return_v;
            }


            static bool
            f_690_8282_8311(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxAnnotation, System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>>
            this_param, Microsoft.CodeAnalysis.SyntaxAnnotation
            key, out System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>?
            value)
            {
                var return_v = this_param.TryGetValue(key, out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 8282, 8311);
                return return_v;
            }


            static System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
            f_690_8376_8398()
            {
                var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 8376, 8398);
                return return_v;
            }


            static int
            f_690_8429_8446(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxAnnotation, System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>>
            this_param, Microsoft.CodeAnalysis.SyntaxAnnotation
            key, System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
            value)
            {
                this_param.Add(key, value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 8429, 8446);
                return 0;
            }


            static int
            f_690_8502_8516(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
            this_param, Microsoft.CodeAnalysis.SyntaxNode
            item)
            {
                this_param.Add(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 8502, 8516);
                return 0;
            }


            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
            f_690_8141_8178_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 8141, 8178);
                return return_v;
            }


            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
            f_690_7955_8029_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 7955, 8029);
                return return_v;
            }


            static System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxAnnotation, System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.SyntaxNode>>
            f_690_8594_8695(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxAnnotation, System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>>
            source, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.SyntaxAnnotation, System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>>, Microsoft.CodeAnalysis.SyntaxAnnotation>
            keySelector, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.SyntaxAnnotation, System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>>, System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.SyntaxNode>>
            elementSelector)
            {
                var return_v = source.ToDictionary<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.SyntaxAnnotation, System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>>, Microsoft.CodeAnalysis.SyntaxAnnotation, System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.SyntaxNode>>(keySelector, elementSelector);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(690, 8594, 8695);
                return return_v;
            }

        }
    }
}
