// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    internal static class SyntaxNodeRemover
    {
        internal static TRoot? RemoveNodes<TRoot>(TRoot root,
                        IEnumerable<SyntaxNode> nodes,
                        SyntaxRemoveOptions options)
                    where TRoot : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10809, 532, 1489);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 742, 820) || true) && (nodes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 742, 820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 793, 805);

                    return root;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 742, 820);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 836, 868);

                var
                nodeArray = f_10809_852_867<TRoot>(nodes)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 884, 970) || true) && (f_10809_888_904<TRoot>(nodeArray) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 884, 970);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 943, 955);

                    return root;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 884, 970);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 986, 1044);

                var
                remover = f_10809_1000_1043<TRoot>(f_10809_1018_1033<TRoot>(nodes), options)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 1058, 1091);

                var
                result = f_10809_1071_1090<TRoot>(remover, root)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 1107, 1151);

                var
                residualTrivia = f_10809_1128_1150<TRoot>(remover)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 1259, 1440) || true) && (result != null && (DynAbs.Tracing.TraceSender.Expression_True(10809, 1263, 1305) && residualTrivia.Count > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 1259, 1440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 1339, 1425);

                    result = f_10809_1348_1424<TRoot>(result, f_10809_1374_1423<TRoot>(f_10809_1374_1400<TRoot>(result), residualTrivia));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 1259, 1440);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 1456, 1478);

                return (TRoot?)result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10809, 532, 1489);

                Microsoft.CodeAnalysis.SyntaxNode[]
                f_10809_852_867<TRoot>(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source) where TRoot : SyntaxNode

                {
                    var return_v = source.ToArray<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 852, 867);
                    return return_v;
                }


                int
                f_10809_888_904<TRoot>(Microsoft.CodeAnalysis.SyntaxNode[]
                this_param) where TRoot : SyntaxNode

                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 888, 904);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode[]
                f_10809_1018_1033<TRoot>(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source) where TRoot : SyntaxNode

                {
                    var return_v = source.ToArray<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 1018, 1033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                f_10809_1000_1043<TRoot>(Microsoft.CodeAnalysis.SyntaxNode[]
                nodesToRemove, Microsoft.CodeAnalysis.SyntaxRemoveOptions
                options) where TRoot : SyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover(nodesToRemove, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 1000, 1043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10809_1071_1090<TRoot>(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                this_param, TRoot
                node) where TRoot : SyntaxNode

                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 1071, 1090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10809_1128_1150<TRoot>(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                this_param) where TRoot : SyntaxNode

                {
                    var return_v = this_param.ResidualTrivia;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 1128, 1150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10809_1374_1400<TRoot>(Microsoft.CodeAnalysis.SyntaxNode
                this_param) where TRoot : SyntaxNode

                {
                    var return_v = this_param.GetTrailingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 1374, 1400);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                f_10809_1374_1423<TRoot>(Microsoft.CodeAnalysis.SyntaxTriviaList
                first, Microsoft.CodeAnalysis.SyntaxTriviaList
                second) where TRoot : SyntaxNode

                {
                    var return_v = first.Concat<Microsoft.CodeAnalysis.SyntaxTrivia>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 1374, 1423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10809_1348_1424<TRoot>(Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                trivia) where TRoot : SyntaxNode

                {
                    var return_v = node.WithTrailingTrivia<Microsoft.CodeAnalysis.SyntaxNode>(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 1348, 1424);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10809, 532, 1489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10809, 532, 1489);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private class SyntaxRemover : CSharpSyntaxRewriter
        {
            private readonly HashSet<SyntaxNode> _nodesToRemove;

            private readonly SyntaxRemoveOptions _options;

            private readonly TextSpan _searchSpan;

            private readonly SyntaxTriviaListBuilder _residualTrivia;

            private HashSet<SyntaxNode>? _directivesToKeep;

            public SyntaxRemover(
                            SyntaxNode[] nodesToRemove,
                            SyntaxRemoveOptions options)
            : base(f_10809_2025_2077_C(f_10809_2025_2077(nodesToRemove, n => n.IsPartOfStructuredTrivia())))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10809, 1888, 2352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 1613, 1627);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 1679, 1687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 1795, 1810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 1854, 1871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 2111, 2167);

                    _nodesToRemove = f_10809_2128_2166(nodesToRemove);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 2185, 2204);

                    _options = options;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 2222, 2268);

                    _searchSpan = f_10809_2236_2267(nodesToRemove);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 2286, 2337);

                    _residualTrivia = f_10809_2304_2336();
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10809, 1888, 2352);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10809, 1888, 2352);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10809, 1888, 2352);
                }
            }

            private static TextSpan ComputeTotalSpan(SyntaxNode[] nodes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10809, 2368, 2903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 2461, 2491);

                    var
                    span0 = f_10809_2473_2490(nodes[0])
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 2509, 2533);

                    int
                    start = span0.Start
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 2551, 2571);

                    int
                    end = span0.End
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 2600, 2605);

                        for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 2591, 2828) || true) && (i < f_10809_2611_2623(nodes))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 2625, 2628)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 2591, 2828))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 2591, 2828);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 2670, 2699);

                            var
                            span = f_10809_2681_2698(nodes[i])
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 2721, 2757);

                            start = f_10809_2729_2756(start, span.Start);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 2779, 2809);

                            end = f_10809_2785_2808(end, span.End);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10809, 1, 238);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10809, 1, 238);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 2848, 2888);

                    return f_10809_2855_2887(start, end - start);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10809, 2368, 2903);

                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_10809_2473_2490(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.FullSpan;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 2473, 2490);
                        return return_v;
                    }


                    int
                    f_10809_2611_2623(Microsoft.CodeAnalysis.SyntaxNode[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 2611, 2623);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_10809_2681_2698(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.FullSpan;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 2681, 2698);
                        return return_v;
                    }


                    int
                    f_10809_2729_2756(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Min(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 2729, 2756);
                        return return_v;
                    }


                    int
                    f_10809_2785_2808(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Max(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 2785, 2808);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_10809_2855_2887(int
                    start, int
                    length)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 2855, 2887);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10809, 2368, 2903);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10809, 2368, 2903);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal SyntaxTriviaList ResidualTrivia
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10809, 2992, 3318);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 3036, 3299) || true) && (_residualTrivia != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 3036, 3299);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 3113, 3145);

                            return f_10809_3120_3144(_residualTrivia);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 3036, 3299);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 3036, 3299);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 3243, 3276);

                            return default(SyntaxTriviaList);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 3036, 3299);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10809, 2992, 3318);

                        Microsoft.CodeAnalysis.SyntaxTriviaList
                        f_10809_3120_3144(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                        this_param)
                        {
                            var return_v = this_param.ToList();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 3120, 3144);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10809, 2919, 3333);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10809, 2919, 3333);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private void AddResidualTrivia(SyntaxTriviaList trivia, bool requiresNewLine = false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10809, 3349, 3690);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 3467, 3627) || true) && (requiresNewLine)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 3467, 3627);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 3528, 3608);

                        f_10809_3528_3607(this, f_10809_3546_3566(trivia) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.SyntaxTrivia?>(10809, 3546, 3606) ?? f_10809_3570_3606()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 3467, 3627);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 3647, 3675);

                    f_10809_3647_3674(
                                    _residualTrivia, trivia);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10809, 3349, 3690);

                    Microsoft.CodeAnalysis.SyntaxTrivia?
                    f_10809_3546_3566(Microsoft.CodeAnalysis.SyntaxTriviaList
                    list)
                    {
                        var return_v = GetEndOfLine(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 3546, 3566);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTrivia
                    f_10809_3570_3606()
                    {
                        var return_v = SyntaxFactory.CarriageReturnLineFeed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 3570, 3606);
                        return return_v;
                    }


                    int
                    f_10809_3528_3607(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                    eolTrivia)
                    {
                        this_param.AddEndOfLine((Microsoft.CodeAnalysis.SyntaxTrivia?)eolTrivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 3528, 3607);
                        return 0;
                    }


                    int
                    f_10809_3647_3674(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                    this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                    list)
                    {
                        this_param.Add(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 3647, 3674);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10809, 3349, 3690);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10809, 3349, 3690);
                }
            }

            private void AddEndOfLine(SyntaxTrivia? eolTrivia)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10809, 3706, 4103);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 3789, 3880) || true) && (f_10809_3793_3812_M(!eolTrivia.HasValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 3789, 3880);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 3854, 3861);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 3789, 3880);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 3900, 4088) || true) && (f_10809_3904_3925(_residualTrivia) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10809, 3904, 3990) || !f_10809_3935_3990(f_10809_3947_3989(_residualTrivia, f_10809_3963_3984(_residualTrivia) - 1))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 3900, 4088);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 4032, 4069);

                        f_10809_4032_4068(_residualTrivia, eolTrivia.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 3900, 4088);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10809, 3706, 4103);

                    bool
                    f_10809_3793_3812_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 3793, 3812);
                        return return_v;
                    }


                    int
                    f_10809_3904_3925(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 3904, 3925);
                        return return_v;
                    }


                    int
                    f_10809_3963_3984(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 3963, 3984);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTrivia
                    f_10809_3947_3989(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 3947, 3989);
                        return return_v;
                    }


                    bool
                    f_10809_3935_3990(Microsoft.CodeAnalysis.SyntaxTrivia
                    trivia)
                    {
                        var return_v = IsEndOfLine(trivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 3935, 3990);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                    f_10809_4032_4068(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                    this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                    item)
                    {
                        var return_v = this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 4032, 4068);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10809, 3706, 4103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10809, 3706, 4103);
                }
            }

            private static bool IsEndOfLine(SyntaxTrivia trivia)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10809, 4465, 4735);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 4550, 4720);

                    return trivia.Kind() == SyntaxKind.EndOfLineTrivia
                    || (DynAbs.Tracing.TraceSender.Expression_False(10809, 4557, 4676) || trivia.Kind() == SyntaxKind.SingleLineCommentTrivia
                    ) || (DynAbs.Tracing.TraceSender.Expression_False(10809, 4557, 4719) || trivia.IsDirective);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10809, 4465, 4735);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10809, 4465, 4735);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10809, 4465, 4735);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static SyntaxTrivia? GetEndOfLine(SyntaxTriviaList list)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10809, 4896, 5507);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 4993, 5460);
                        foreach (var trivia in f_10809_5016_5020_I(list))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 4993, 5460);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 5062, 5196) || true) && (trivia.Kind() == SyntaxKind.EndOfLineTrivia)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 5062, 5196);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 5159, 5173);

                                return trivia;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 5062, 5196);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 5220, 5441) || true) && (trivia.IsDirective && (DynAbs.Tracing.TraceSender.Expression_True(10809, 5224, 5302) && trivia.GetStructure() is DirectiveTriviaSyntax directive))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 5220, 5441);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 5352, 5418);

                                return f_10809_5359_5417(directive.EndOfDirectiveToken.TrailingTrivia);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 5220, 5441);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 4993, 5460);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10809, 1, 468);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10809, 1, 468);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 5480, 5492);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10809, 4896, 5507);

                    Microsoft.CodeAnalysis.SyntaxTrivia?
                    f_10809_5359_5417(Microsoft.CodeAnalysis.SyntaxTriviaList
                    list)
                    {
                        var return_v = GetEndOfLine(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 5359, 5417);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTriviaList
                    f_10809_5016_5020_I(Microsoft.CodeAnalysis.SyntaxTriviaList
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 5016, 5020);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10809, 4896, 5507);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10809, 4896, 5507);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool IsForRemoval(SyntaxNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10809, 5523, 5650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 5598, 5635);

                    return f_10809_5605_5634(_nodesToRemove, node);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10809, 5523, 5650);

                    bool
                    f_10809_5605_5634(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 5605, 5634);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10809, 5523, 5650);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10809, 5523, 5650);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool ShouldVisit(SyntaxNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10809, 5666, 5862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 5740, 5847);

                    return node.FullSpan.IntersectsWith(_searchSpan) || (DynAbs.Tracing.TraceSender.Expression_False(10809, 5747, 5846) || (_residualTrivia != null && (DynAbs.Tracing.TraceSender.Expression_True(10809, 5793, 5845) && f_10809_5820_5841(_residualTrivia) > 0)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10809, 5666, 5862);

                    int
                    f_10809_5820_5841(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 5820, 5841);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10809, 5666, 5862);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10809, 5666, 5862);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [return: NotNullIfNotNull("node")]
            public override SyntaxNode? Visit(SyntaxNode? node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10809, 5878, 6495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 6010, 6036);

                    SyntaxNode?
                    result = node
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 6056, 6446) || true) && (node != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 6056, 6446);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 6114, 6427) || true) && (f_10809_6118_6141(this, node))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 6114, 6427);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 6191, 6212);

                            f_10809_6191_6211(this, node);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 6238, 6252);

                            result = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 6114, 6427);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 6114, 6427);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 6302, 6427) || true) && (f_10809_6306_6328(this, node))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 6302, 6427);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 6378, 6404);

                                result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10809, 6387, 6403);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 6302, 6427);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 6114, 6427);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 6056, 6446);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 6466, 6480);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10809, 5878, 6495);

                    bool
                    f_10809_6118_6141(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        var return_v = this_param.IsForRemoval(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 6118, 6141);
                        return return_v;
                    }


                    int
                    f_10809_6191_6211(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        this_param.AddTrivia(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 6191, 6211);
                        return 0;
                    }


                    bool
                    f_10809_6306_6328(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        var return_v = this_param.ShouldVisit(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 6306, 6328);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10809, 5878, 6495);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10809, 5878, 6495);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxToken VisitToken(SyntaxToken token)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10809, 6511, 7322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 6601, 6628);

                    SyntaxToken
                    result = token
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 6743, 6870) || true) && (f_10809_6747_6777(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 6743, 6870);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 6819, 6851);

                        result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitToken(token), 10809, 6828, 6850);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 6743, 6870);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 6950, 7273) || true) && (result.Kind() != SyntaxKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10809, 6954, 7013) && _residualTrivia != null) && (DynAbs.Tracing.TraceSender.Expression_True(10809, 6954, 7042) && f_10809_7017_7038(_residualTrivia) > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 6950, 7273);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 7084, 7126);

                        f_10809_7084_7125(_residualTrivia, result.LeadingTrivia);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 7148, 7208);

                        result = result.WithLeadingTrivia(f_10809_7182_7206(_residualTrivia));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 7230, 7254);

                        f_10809_7230_7253(_residualTrivia);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 6950, 7273);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 7293, 7307);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10809, 6511, 7322);

                    bool
                    f_10809_6747_6777(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param)
                    {
                        var return_v = this_param.VisitIntoStructuredTrivia;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 6747, 6777);
                        return return_v;
                    }


                    int
                    f_10809_7017_7038(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 7017, 7038);
                        return return_v;
                    }


                    int
                    f_10809_7084_7125(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                    this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                    list)
                    {
                        this_param.Add(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 7084, 7125);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxTriviaList
                    f_10809_7182_7206(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                    this_param)
                    {
                        var return_v = this_param.ToList();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 7182, 7206);
                        return return_v;
                    }


                    int
                    f_10809_7230_7253(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 7230, 7253);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10809, 6511, 7322);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10809, 6511, 7322);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SeparatedSyntaxList<TNode> VisitList<TNode>(SeparatedSyntaxList<TNode> list)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10809, 7417, 10912);
                    bool nextTokenIsSeparator = default(bool);
                    bool nextSeparatorBelongsToNode = default(bool);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 7542, 7582);

                    var
                    withSeps = list.GetWithSeparators()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 7600, 7633);

                    bool
                    removeNextSeparator = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 7653, 7700);

                    SyntaxNodeOrTokenListBuilder?
                    alternate = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 7727, 7732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 7734, 7752);
                        for (int
        i = 0
        ,
        n = withSeps.Count
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 7718, 10712) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 7761, 7764)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 7718, 10712))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 7718, 10712);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 7806, 7829);

                            var
                            item = withSeps[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 7851, 7877);

                            SyntaxNodeOrToken
                            visited
                            = default(SyntaxNodeOrToken);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 7901, 10274) || true) && (item.IsToken)
                            ) // separator

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 7901, 10274);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 7980, 8347) || true) && (removeNextSeparator)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 7980, 8347);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 8061, 8089);

                                    removeNextSeparator = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 8119, 8156);

                                    visited = default(SyntaxNodeOrToken);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 7980, 8347);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 7980, 8347);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 8270, 8320);

                                    visited = f_10809_8280_8319<TNode>(this, item.AsToken());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 7980, 8347);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 7901, 10274);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 7901, 10274);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 8445, 8478);

                                var
                                node = (TNode)item.AsNode()!
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 8506, 10251) || true) && (f_10809_8510_8533(this, (SyntaxNode)node))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 8506, 10251);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 8591, 8821) || true) && (alternate == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 8591, 8821);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 8678, 8726);

                                        alternate = f_10809_8690_8725<TNode>(n);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 8760, 8790);

                                        f_10809_8760_8789<TNode>(alternate, withSeps, 0, i);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 8591, 8821);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 8853, 9075);

                                    f_10809_8853_9074<TNode>(withSeps, i, SyntaxKind.EndOfLineTrivia, out nextTokenIsSeparator, out nextSeparatorBelongsToNode);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 9107, 10022) || true) && (!nextSeparatorBelongsToNode && (DynAbs.Tracing.TraceSender.Expression_True(10809, 9111, 9194) && f_10809_9175_9190<TNode>(alternate) > 0) && (DynAbs.Tracing.TraceSender.Expression_True(10809, 9111, 9269) && alternate[f_10809_9241_9256<TNode>(alternate) - 1].IsToken))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 9107, 10022);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 9335, 9392);

                                        var
                                        separator = alternate[f_10809_9361_9376(alternate) - 1].AsToken()
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 9426, 9458);

                                        f_10809_9426_9457(this, separator, node);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 9492, 9515);

                                        f_10809_9492_9514<TNode>(alternate);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 9107, 10022);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 9107, 10022);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 9581, 10022) || true) && (nextTokenIsSeparator)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 9581, 10022);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 9671, 9713);

                                            var
                                            separator = withSeps[i + 1].AsToken()
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 9747, 9779);

                                            f_10809_9747_9778(this, node, separator);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 9813, 9840);

                                            removeNextSeparator = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 9581, 10022);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 9581, 10022);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 9970, 9991);

                                            f_10809_9970_9990(this, node);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 9581, 10022);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 9107, 10022);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 10054, 10072);

                                    visited = default;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 8506, 10251);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 8506, 10251);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 10186, 10224);

                                    visited = f_10809_10196_10223(this, node);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 8506, 10251);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 7901, 10274);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 10298, 10515) || true) && (item != visited && (DynAbs.Tracing.TraceSender.Expression_True(10809, 10302, 10338) && alternate == null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 10298, 10515);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 10388, 10436);

                                alternate = f_10809_10400_10435<TNode>(n);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 10462, 10492);

                                f_10809_10462_10491<TNode>(alternate, withSeps, 0, i);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 10298, 10515);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 10539, 10693) || true) && (alternate != null && (DynAbs.Tracing.TraceSender.Expression_True(10809, 10543, 10597) && visited.Kind() != SyntaxKind.None))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 10539, 10693);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 10647, 10670);

                                f_10809_10647_10669<TNode>(alternate, visited);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 10539, 10693);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10809, 1, 2995);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10809, 1, 2995);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 10732, 10865) || true) && (alternate != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 10732, 10865);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 10795, 10846);

                        return f_10809_10802_10820<TNode>(alternate).AsSeparatedList<TNode>();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 10732, 10865);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 10885, 10897);

                    return list;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10809, 7417, 10912);

                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10809_8280_8319<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxToken
                    separator)
                    {
                        var return_v = this_param.VisitListSeparator(separator);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 8280, 8319);
                        return return_v;
                    }


                    bool
                    f_10809_8510_8533(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        var return_v = this_param.IsForRemoval(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 8510, 8533);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder
                    f_10809_8690_8725<TNode>(int
                    size)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder(size);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 8690, 8725);
                        return return_v;
                    }


                    int
                    f_10809_8760_8789<TNode>(Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder
                    this_param, Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                    list, int
                    offset, int
                    length)
                    {
                        this_param.Add(list, offset, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 8760, 8789);
                        return 0;
                    }


                    int
                    f_10809_8853_9074<TNode>(Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                    nodesAndSeparators, int
                    nodeIndex, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    endOfLineKind, out bool
                    nextTokenIsSeparator, out bool
                    nextSeparatorBelongsToNode)
                    {
                        CommonSyntaxNodeRemover.GetSeparatorInfo(nodesAndSeparators, nodeIndex, (int)endOfLineKind, out nextTokenIsSeparator, out nextSeparatorBelongsToNode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 8853, 9074);
                        return 0;
                    }


                    int
                    f_10809_9175_9190<TNode>(Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 9175, 9190);
                        return return_v;
                    }


                    int
                    f_10809_9241_9256<TNode>(Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 9241, 9256);
                        return return_v;
                    }


                    int
                    f_10809_9361_9376(Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 9361, 9376);
                        return return_v;
                    }


                    int
                    f_10809_9426_9457(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxToken
                    token, Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        this_param.AddTrivia(token, node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 9426, 9457);
                        return 0;
                    }


                    int
                    f_10809_9492_9514<TNode>(Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder
                    this_param)
                    {
                        this_param.RemoveLast();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 9492, 9514);
                        return 0;
                    }


                    int
                    f_10809_9747_9778(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    node, Microsoft.CodeAnalysis.SyntaxToken
                    token)
                    {
                        this_param.AddTrivia(node, token);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 9747, 9778);
                        return 0;
                    }


                    int
                    f_10809_9970_9990(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        this_param.AddTrivia(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 9970, 9990);
                        return 0;
                    }


                    SyntaxNode?
                    f_10809_10196_10223(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, SyntaxNode
                    node)
                    {
                        var return_v = this_param.VisitListElement(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 10196, 10223);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder
                    f_10809_10400_10435<TNode>(int
                    size)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder(size);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 10400, 10435);
                        return return_v;
                    }


                    int
                    f_10809_10462_10491<TNode>(Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder
                    this_param, Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                    list, int
                    offset, int
                    length)
                    {
                        this_param.Add(list, offset, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 10462, 10491);
                        return 0;
                    }


                    int
                    f_10809_10647_10669<TNode>(Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder
                    this_param, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 10647, 10669);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                    f_10809_10802_10820<TNode>(Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder
                    this_param)
                    {
                        var return_v = this_param.ToList();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 10802, 10820);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10809, 7417, 10912);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10809, 7417, 10912);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void AddTrivia(SyntaxNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10809, 10928, 12236);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 11000, 11364) || true) && ((_options & SyntaxRemoveOptions.KeepLeadingTrivia) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 11000, 11364);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 11101, 11149);

                        f_10809_11101_11148(this, f_10809_11124_11147(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 11000, 11364);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 11000, 11364);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 11191, 11364) || true) && ((_options & SyntaxRemoveOptions.KeepEndOfLine) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 11191, 11364);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 11288, 11345);

                            f_10809_11288_11344(this, f_10809_11306_11343(f_10809_11319_11342(node)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 11191, 11364);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 11000, 11364);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 11384, 11617) || true) && ((_options & (SyntaxRemoveOptions.KeepDirectives | SyntaxRemoveOptions.KeepUnbalancedDirectives)) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 11384, 11617);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 11531, 11598);

                        f_10809_11531_11597(this, node, f_10809_11556_11596(this, f_10809_11571_11580(node), f_10809_11582_11595(node)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 11384, 11617);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 11637, 12004) || true) && ((_options & SyntaxRemoveOptions.KeepTrailingTrivia) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 11637, 12004);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 11739, 11788);

                        f_10809_11739_11787(this, f_10809_11762_11786(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 11637, 12004);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 11637, 12004);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 11830, 12004) || true) && ((_options & SyntaxRemoveOptions.KeepEndOfLine) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 11830, 12004);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 11927, 11985);

                            f_10809_11927_11984(this, f_10809_11945_11983(f_10809_11958_11982(node)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 11830, 12004);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 11637, 12004);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 12024, 12221) || true) && ((_options & SyntaxRemoveOptions.AddElasticMarker) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 12024, 12221);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 12124, 12202);

                        f_10809_12124_12201(this, f_10809_12147_12200(f_10809_12172_12199()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 12024, 12221);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10809, 10928, 12236);

                    Microsoft.CodeAnalysis.SyntaxTriviaList
                    f_10809_11124_11147(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTrivia();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 11124, 11147);
                        return return_v;
                    }


                    int
                    f_10809_11101_11148(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                    trivia)
                    {
                        this_param.AddResidualTrivia(trivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 11101, 11148);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxTriviaList
                    f_10809_11319_11342(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTrivia();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 11319, 11342);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTrivia?
                    f_10809_11306_11343(Microsoft.CodeAnalysis.SyntaxTriviaList
                    list)
                    {
                        var return_v = GetEndOfLine(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 11306, 11343);
                        return return_v;
                    }


                    int
                    f_10809_11288_11344(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxTrivia?
                    eolTrivia)
                    {
                        this_param.AddEndOfLine(eolTrivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 11288, 11344);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_10809_11571_11580(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Span;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 11571, 11580);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_10809_11582_11595(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.FullSpan;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 11582, 11595);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_10809_11556_11596(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.Text.TextSpan
                    span, Microsoft.CodeAnalysis.Text.TextSpan
                    fullSpan)
                    {
                        var return_v = this_param.GetRemovedSpan(span, fullSpan);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 11556, 11596);
                        return return_v;
                    }


                    int
                    f_10809_11531_11597(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    node, Microsoft.CodeAnalysis.Text.TextSpan
                    span)
                    {
                        this_param.AddDirectives(node, span);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 11531, 11597);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxTriviaList
                    f_10809_11762_11786(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetTrailingTrivia();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 11762, 11786);
                        return return_v;
                    }


                    int
                    f_10809_11739_11787(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                    trivia)
                    {
                        this_param.AddResidualTrivia(trivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 11739, 11787);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxTriviaList
                    f_10809_11958_11982(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetTrailingTrivia();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 11958, 11982);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTrivia?
                    f_10809_11945_11983(Microsoft.CodeAnalysis.SyntaxTriviaList
                    list)
                    {
                        var return_v = GetEndOfLine(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 11945, 11983);
                        return return_v;
                    }


                    int
                    f_10809_11927_11984(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxTrivia?
                    eolTrivia)
                    {
                        this_param.AddEndOfLine(eolTrivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 11927, 11984);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxTrivia
                    f_10809_12172_12199()
                    {
                        var return_v = SyntaxFactory.ElasticMarker;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 12172, 12199);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTriviaList
                    f_10809_12147_12200(Microsoft.CodeAnalysis.SyntaxTrivia
                    trivia)
                    {
                        var return_v = SyntaxFactory.TriviaList(trivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 12147, 12200);
                        return return_v;
                    }


                    int
                    f_10809_12124_12201(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                    trivia)
                    {
                        this_param.AddResidualTrivia(trivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 12124, 12201);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10809, 10928, 12236);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10809, 10928, 12236);
                }
            }

            private void AddTrivia(SyntaxToken token, SyntaxNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10809, 12252, 14242);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 12343, 12379);

                    f_10809_12343_12378(f_10809_12356_12367(node) is object);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 12397, 13189) || true) && ((_options & SyntaxRemoveOptions.KeepLeadingTrivia) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 12397, 13189);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 12498, 12542);

                        f_10809_12498_12541(this, token.LeadingTrivia);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 12564, 12609);

                        f_10809_12564_12608(this, token.TrailingTrivia);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 12631, 12679);

                        f_10809_12631_12678(this, f_10809_12654_12677(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 12397, 13189);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 12397, 13189);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 12721, 13189) || true) && ((_options & SyntaxRemoveOptions.KeepEndOfLine) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 12721, 13189);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 13012, 13125);

                            var
                            eol = f_10809_13022_13055(token.LeadingTrivia) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.SyntaxTrivia?>(10809, 13022, 13124) ?? f_10809_13090_13124(token.TrailingTrivia))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 13147, 13170);

                            f_10809_13147_13169(this, eol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 12721, 13189);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 12397, 13189);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 13209, 13623) || true) && ((_options & (SyntaxRemoveOptions.KeepDirectives | SyntaxRemoveOptions.KeepUnbalancedDirectives)) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 13209, 13623);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 13356, 13420);

                        var
                        span = TextSpan.FromBounds(token.Span.Start, node.Span.End)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 13442, 13518);

                        var
                        fullSpan = TextSpan.FromBounds(token.FullSpan.Start, node.FullSpan.End)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 13540, 13604);

                        f_10809_13540_13603(this, f_10809_13559_13570(node), f_10809_13572_13602(this, span, fullSpan));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 13209, 13623);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 13643, 14010) || true) && ((_options & SyntaxRemoveOptions.KeepTrailingTrivia) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 13643, 14010);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 13745, 13794);

                        f_10809_13745_13793(this, f_10809_13768_13792(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 13643, 14010);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 13643, 14010);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 13836, 14010) || true) && ((_options & SyntaxRemoveOptions.KeepEndOfLine) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 13836, 14010);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 13933, 13991);

                            f_10809_13933_13990(this, f_10809_13951_13989(f_10809_13964_13988(node)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 13836, 14010);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 13643, 14010);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 14030, 14227) || true) && ((_options & SyntaxRemoveOptions.AddElasticMarker) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 14030, 14227);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 14130, 14208);

                        f_10809_14130_14207(this, f_10809_14153_14206(f_10809_14178_14205()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 14030, 14227);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10809, 12252, 14242);

                    Microsoft.CodeAnalysis.SyntaxNode?
                    f_10809_12356_12367(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 12356, 12367);
                        return return_v;
                    }


                    int
                    f_10809_12343_12378(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 12343, 12378);
                        return 0;
                    }


                    int
                    f_10809_12498_12541(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                    trivia)
                    {
                        this_param.AddResidualTrivia(trivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 12498, 12541);
                        return 0;
                    }


                    int
                    f_10809_12564_12608(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                    trivia)
                    {
                        this_param.AddResidualTrivia(trivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 12564, 12608);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxTriviaList
                    f_10809_12654_12677(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTrivia();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 12654, 12677);
                        return return_v;
                    }


                    int
                    f_10809_12631_12678(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                    trivia)
                    {
                        this_param.AddResidualTrivia(trivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 12631, 12678);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxTrivia?
                    f_10809_13022_13055(Microsoft.CodeAnalysis.SyntaxTriviaList
                    list)
                    {
                        var return_v = GetEndOfLine(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 13022, 13055);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTrivia?
                    f_10809_13090_13124(Microsoft.CodeAnalysis.SyntaxTriviaList
                    list)
                    {
                        var return_v = GetEndOfLine(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 13090, 13124);
                        return return_v;
                    }


                    int
                    f_10809_13147_13169(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxTrivia?
                    eolTrivia)
                    {
                        this_param.AddEndOfLine(eolTrivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 13147, 13169);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10809_13559_13570(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 13559, 13570);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_10809_13572_13602(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.Text.TextSpan
                    span, Microsoft.CodeAnalysis.Text.TextSpan
                    fullSpan)
                    {
                        var return_v = this_param.GetRemovedSpan(span, fullSpan);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 13572, 13602);
                        return return_v;
                    }


                    int
                    f_10809_13540_13603(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    node, Microsoft.CodeAnalysis.Text.TextSpan
                    span)
                    {
                        this_param.AddDirectives(node, span);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 13540, 13603);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxTriviaList
                    f_10809_13768_13792(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetTrailingTrivia();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 13768, 13792);
                        return return_v;
                    }


                    int
                    f_10809_13745_13793(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                    trivia)
                    {
                        this_param.AddResidualTrivia(trivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 13745, 13793);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxTriviaList
                    f_10809_13964_13988(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetTrailingTrivia();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 13964, 13988);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTrivia?
                    f_10809_13951_13989(Microsoft.CodeAnalysis.SyntaxTriviaList
                    list)
                    {
                        var return_v = GetEndOfLine(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 13951, 13989);
                        return return_v;
                    }


                    int
                    f_10809_13933_13990(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxTrivia?
                    eolTrivia)
                    {
                        this_param.AddEndOfLine(eolTrivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 13933, 13990);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxTrivia
                    f_10809_14178_14205()
                    {
                        var return_v = SyntaxFactory.ElasticMarker;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 14178, 14205);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTriviaList
                    f_10809_14153_14206(Microsoft.CodeAnalysis.SyntaxTrivia
                    trivia)
                    {
                        var return_v = SyntaxFactory.TriviaList(trivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 14153, 14206);
                        return return_v;
                    }


                    int
                    f_10809_14130_14207(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                    trivia)
                    {
                        this_param.AddResidualTrivia(trivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 14130, 14207);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10809, 12252, 14242);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10809, 12252, 14242);
                }
            }

            private void AddTrivia(SyntaxNode node, SyntaxToken token)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10809, 14258, 16252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 14349, 14385);

                    f_10809_14349_14384(f_10809_14362_14373(node) is object);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 14403, 14767) || true) && ((_options & SyntaxRemoveOptions.KeepLeadingTrivia) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 14403, 14767);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 14504, 14552);

                        f_10809_14504_14551(this, f_10809_14527_14550(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 14403, 14767);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 14403, 14767);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 14594, 14767) || true) && ((_options & SyntaxRemoveOptions.KeepEndOfLine) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 14594, 14767);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 14691, 14748);

                            f_10809_14691_14747(this, f_10809_14709_14746(f_10809_14722_14745(node)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 14594, 14767);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 14403, 14767);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 14787, 15201) || true) && ((_options & (SyntaxRemoveOptions.KeepDirectives | SyntaxRemoveOptions.KeepUnbalancedDirectives)) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 14787, 15201);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 14934, 14998);

                        var
                        span = TextSpan.FromBounds(node.Span.Start, token.Span.End)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 15020, 15096);

                        var
                        fullSpan = TextSpan.FromBounds(node.FullSpan.Start, token.FullSpan.End)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 15118, 15182);

                        f_10809_15118_15181(this, f_10809_15137_15148(node), f_10809_15150_15180(this, span, fullSpan));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 14787, 15201);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 15221, 16020) || true) && ((_options & SyntaxRemoveOptions.KeepTrailingTrivia) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 15221, 16020);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 15323, 15372);

                        f_10809_15323_15371(this, f_10809_15346_15370(node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 15394, 15438);

                        f_10809_15394_15437(this, token.LeadingTrivia);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 15460, 15505);

                        f_10809_15460_15504(this, token.TrailingTrivia);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 15221, 16020);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 15221, 16020);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 15547, 16020) || true) && ((_options & SyntaxRemoveOptions.KeepEndOfLine) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 15547, 16020);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 15838, 15956);

                            var
                            eol = f_10809_15848_15886(f_10809_15861_15885(node)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.SyntaxTrivia?>(10809, 15848, 15955) ?? f_10809_15921_15955(token.TrailingTrivia))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 15978, 16001);

                            f_10809_15978_16000(this, eol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 15547, 16020);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 15221, 16020);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 16040, 16237) || true) && ((_options & SyntaxRemoveOptions.AddElasticMarker) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 16040, 16237);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 16140, 16218);

                        f_10809_16140_16217(this, f_10809_16163_16216(f_10809_16188_16215()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 16040, 16237);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10809, 14258, 16252);

                    Microsoft.CodeAnalysis.SyntaxNode?
                    f_10809_14362_14373(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 14362, 14373);
                        return return_v;
                    }


                    int
                    f_10809_14349_14384(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 14349, 14384);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxTriviaList
                    f_10809_14527_14550(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTrivia();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 14527, 14550);
                        return return_v;
                    }


                    int
                    f_10809_14504_14551(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                    trivia)
                    {
                        this_param.AddResidualTrivia(trivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 14504, 14551);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxTriviaList
                    f_10809_14722_14745(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTrivia();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 14722, 14745);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTrivia?
                    f_10809_14709_14746(Microsoft.CodeAnalysis.SyntaxTriviaList
                    list)
                    {
                        var return_v = GetEndOfLine(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 14709, 14746);
                        return return_v;
                    }


                    int
                    f_10809_14691_14747(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxTrivia?
                    eolTrivia)
                    {
                        this_param.AddEndOfLine(eolTrivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 14691, 14747);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10809_15137_15148(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 15137, 15148);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_10809_15150_15180(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.Text.TextSpan
                    span, Microsoft.CodeAnalysis.Text.TextSpan
                    fullSpan)
                    {
                        var return_v = this_param.GetRemovedSpan(span, fullSpan);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 15150, 15180);
                        return return_v;
                    }


                    int
                    f_10809_15118_15181(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    node, Microsoft.CodeAnalysis.Text.TextSpan
                    span)
                    {
                        this_param.AddDirectives(node, span);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 15118, 15181);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxTriviaList
                    f_10809_15346_15370(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetTrailingTrivia();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 15346, 15370);
                        return return_v;
                    }


                    int
                    f_10809_15323_15371(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                    trivia)
                    {
                        this_param.AddResidualTrivia(trivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 15323, 15371);
                        return 0;
                    }


                    int
                    f_10809_15394_15437(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                    trivia)
                    {
                        this_param.AddResidualTrivia(trivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 15394, 15437);
                        return 0;
                    }


                    int
                    f_10809_15460_15504(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                    trivia)
                    {
                        this_param.AddResidualTrivia(trivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 15460, 15504);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxTriviaList
                    f_10809_15861_15885(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetTrailingTrivia();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 15861, 15885);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTrivia?
                    f_10809_15848_15886(Microsoft.CodeAnalysis.SyntaxTriviaList
                    list)
                    {
                        var return_v = GetEndOfLine(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 15848, 15886);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTrivia?
                    f_10809_15921_15955(Microsoft.CodeAnalysis.SyntaxTriviaList
                    list)
                    {
                        var return_v = GetEndOfLine(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 15921, 15955);
                        return return_v;
                    }


                    int
                    f_10809_15978_16000(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxTrivia?
                    eolTrivia)
                    {
                        this_param.AddEndOfLine(eolTrivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 15978, 16000);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxTrivia
                    f_10809_16188_16215()
                    {
                        var return_v = SyntaxFactory.ElasticMarker;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 16188, 16215);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTriviaList
                    f_10809_16163_16216(Microsoft.CodeAnalysis.SyntaxTrivia
                    trivia)
                    {
                        var return_v = SyntaxFactory.TriviaList(trivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 16163, 16216);
                        return return_v;
                    }


                    int
                    f_10809_16140_16217(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                    trivia)
                    {
                        this_param.AddResidualTrivia(trivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 16140, 16217);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10809, 14258, 16252);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10809, 14258, 16252);
                }
            }

            private TextSpan GetRemovedSpan(TextSpan span, TextSpan fullSpan)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10809, 16268, 16854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 16366, 16393);

                    var
                    removedSpan = fullSpan
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 16413, 16596) || true) && ((_options & SyntaxRemoveOptions.KeepLeadingTrivia) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 16413, 16596);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 16514, 16577);

                        removedSpan = TextSpan.FromBounds(span.Start, removedSpan.End);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 16413, 16596);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 16616, 16800) || true) && ((_options & SyntaxRemoveOptions.KeepTrailingTrivia) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 16616, 16800);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 16718, 16781);

                        removedSpan = TextSpan.FromBounds(removedSpan.Start, span.End);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 16616, 16800);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 16820, 16839);

                    return removedSpan;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10809, 16268, 16854);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10809, 16268, 16854);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10809, 16268, 16854);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void AddDirectives(SyntaxNode node, TextSpan span)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10809, 16870, 19554);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 16961, 19539) || true) && (f_10809_16965_16988(node))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 16961, 19539);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 17030, 17302) || true) && (_directivesToKeep == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 17030, 17302);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 17109, 17155);

                            _directivesToKeep = f_10809_17129_17154();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 17030, 17302);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 17030, 17302);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 17253, 17279);

                            f_10809_17253_17278(_directivesToKeep);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 17030, 17302);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 17326, 17599);

                        var
                        directivesInSpan = f_10809_17349_17598(f_10809_17349_17499(f_10809_17349_17428(node, span, n => n.ContainsDirectives, descendIntoTrivia: true), tr => tr.IsDirective), tr => (DirectiveTriviaSyntax)tr.GetStructure()!)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 17623, 19520);
                            foreach (var directive in f_10809_17649_17665_I(directivesInSpan))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 17623, 19520);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 17715, 19252) || true) && ((_options & SyntaxRemoveOptions.KeepDirectives) != 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 17715, 19252);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 17829, 17862);

                                    f_10809_17829_17861(_directivesToKeep, directive);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 17715, 19252);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 17715, 19252);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 17920, 19252) || true) && (f_10809_17924_17940(directive) == SyntaxKind.DefineDirectiveTrivia || (DynAbs.Tracing.TraceSender.Expression_False(10809, 17924, 18060) || f_10809_18009_18025(directive) == SyntaxKind.UndefDirectiveTrivia))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 17920, 19252);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 18232, 18265);

                                        f_10809_18232_18264(                            // always keep #define and #undef, even if we are only keeping unbalanced directives
                                                                    _directivesToKeep, directive);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 17920, 19252);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 17920, 19252);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 18323, 19252) || true) && (f_10809_18327_18358(directive))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 18323, 19252);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 18548, 18605);

                                            var
                                            relatedDirectives = f_10809_18572_18604(directive)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 18635, 18710);

                                            var
                                            balanced = f_10809_18650_18709(relatedDirectives, rd => rd.FullSpan.OverlapsWith(span))
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 18742, 19225) || true) && (!balanced)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 18742, 19225);
                                                try
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 18945, 19194);
                                                    foreach (var unbalancedDirective in f_10809_18981_19042_I(f_10809_18981_19042(relatedDirectives, rd => rd.FullSpan.OverlapsWith(span))))
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 18945, 19194);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 19116, 19159);

                                                        f_10809_19116_19158(_directivesToKeep, unbalancedDirective);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 18945, 19194);
                                                    }
                                                }
                                                catch (System.Exception)
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10809, 1, 250);
                                                    throw;
                                                }
                                                finally
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10809, 1, 250);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 18742, 19225);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 18323, 19252);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 17920, 19252);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 17715, 19252);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 19280, 19497) || true) && (f_10809_19284_19321(_directivesToKeep, directive))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 19280, 19497);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 19379, 19470);

                                    f_10809_19379_19469(this, f_10809_19397_19445(f_10809_19422_19444(directive)), requiresNewLine: true);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 19280, 19497);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 17623, 19520);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10809, 1, 1898);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10809, 1, 1898);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 16961, 19539);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10809, 16870, 19554);

                    bool
                    f_10809_16965_16988(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.ContainsDirectives;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 16965, 16988);
                        return return_v;
                    }


                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>
                    f_10809_17129_17154()
                    {
                        var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 17129, 17154);
                        return return_v;
                    }


                    int
                    f_10809_17253_17278(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 17253, 17278);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                    f_10809_17349_17428(Microsoft.CodeAnalysis.SyntaxNode
                    this_param, Microsoft.CodeAnalysis.Text.TextSpan
                    span, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                    descendIntoChildren, bool
                    descendIntoTrivia)
                    {
                        var return_v = this_param.DescendantTrivia(span, descendIntoChildren, descendIntoTrivia: descendIntoTrivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 17349, 17428);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                    f_10809_17349_17499(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                    source, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>
                    predicate)
                    {
                        var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxTrivia>(predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 17349, 17499);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                    f_10809_17349_17598(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                    source, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                    selector)
                    {
                        var return_v = source.Select<Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>(selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 17349, 17598);
                        return return_v;
                    }


                    bool
                    f_10809_17829_17861(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                    item)
                    {
                        var return_v = this_param.Add((Microsoft.CodeAnalysis.SyntaxNode)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 17829, 17861);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10809_17924_17940(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 17924, 17940);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10809_18009_18025(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 18009, 18025);
                        return return_v;
                    }


                    bool
                    f_10809_18232_18264(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                    item)
                    {
                        var return_v = this_param.Add((Microsoft.CodeAnalysis.SyntaxNode)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 18232, 18264);
                        return return_v;
                    }


                    bool
                    f_10809_18327_18358(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                    directive)
                    {
                        var return_v = HasRelatedDirectives(directive);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 18327, 18358);
                        return return_v;
                    }


                    System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                    f_10809_18572_18604(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.GetRelatedDirectives();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 18572, 18604);
                        return return_v;
                    }


                    bool
                    f_10809_18650_18709(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                    source, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax, bool>
                    predicate)
                    {
                        var return_v = source.All<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>(predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 18650, 18709);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                    f_10809_18981_19042(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                    source, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax, bool>
                    predicate)
                    {
                        var return_v = source.Where<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>(predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 18981, 19042);
                        return return_v;
                    }


                    bool
                    f_10809_19116_19158(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                    item)
                    {
                        var return_v = this_param.Add((Microsoft.CodeAnalysis.SyntaxNode)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 19116, 19158);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                    f_10809_18981_19042_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 18981, 19042);
                        return return_v;
                    }


                    bool
                    f_10809_19284_19321(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                    item)
                    {
                        var return_v = this_param.Contains((Microsoft.CodeAnalysis.SyntaxNode)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 19284, 19321);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTrivia
                    f_10809_19422_19444(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.ParentTrivia;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10809, 19422, 19444);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTriviaList
                    f_10809_19397_19445(Microsoft.CodeAnalysis.SyntaxTrivia
                    trivia)
                    {
                        var return_v = SyntaxFactory.TriviaList(trivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 19397, 19445);
                        return return_v;
                    }


                    int
                    f_10809_19379_19469(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxNodeRemover.SyntaxRemover
                    this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                    trivia, bool
                    requiresNewLine)
                    {
                        this_param.AddResidualTrivia(trivia, requiresNewLine: requiresNewLine);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 19379, 19469);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                    f_10809_17649_17665_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 17649, 17665);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10809, 16870, 19554);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10809, 16870, 19554);
                }
            }

            private static bool HasRelatedDirectives(DirectiveTriviaSyntax directive)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10809, 19570, 20215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 19676, 20200);

                    switch (f_10809_19684_19700(directive))
                    {

                        case SyntaxKind.IfDirectiveTrivia:
                        case SyntaxKind.ElseDirectiveTrivia:
                        case SyntaxKind.ElifDirectiveTrivia:
                        case SyntaxKind.EndIfDirectiveTrivia:
                        case SyntaxKind.RegionDirectiveTrivia:
                        case SyntaxKind.EndRegionDirectiveTrivia:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 19676, 20200);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 20100, 20112);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 19676, 20200);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10809, 19676, 20200);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10809, 20168, 20181);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10809, 19676, 20200);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10809, 19570, 20215);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10809_19684_19700(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 19684, 19700);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10809, 19570, 20215);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10809, 19570, 20215);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static SyntaxRemover()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10809, 1501, 20226);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10809, 1501, 20226);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10809, 1501, 20226);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10809, 1501, 20226);

            static bool
            f_10809_2025_2077(Microsoft.CodeAnalysis.SyntaxNode[]
            source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
            predicate)
            {
                var return_v = source.Any<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 2025, 2077);
                return return_v;
            }


            System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>
            f_10809_2128_2166(Microsoft.CodeAnalysis.SyntaxNode[]
            collection)
            {
                var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>)collection);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 2128, 2166);
                return return_v;
            }


            Microsoft.CodeAnalysis.Text.TextSpan
            f_10809_2236_2267(Microsoft.CodeAnalysis.SyntaxNode[]
            nodes)
            {
                var return_v = ComputeTotalSpan(nodes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 2236, 2267);
                return return_v;
            }


            Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
            f_10809_2304_2336()
            {
                var return_v = SyntaxTriviaListBuilder.Create();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10809, 2304, 2336);
                return return_v;
            }


            static bool
            f_10809_2025_2077_C(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10809, 1888, 2352);
                return return_v;
            }

        }

        static SyntaxNodeRemover()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10809, 476, 20233);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10809, 476, 20233);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10809, 476, 20233);
        }

    }
}
