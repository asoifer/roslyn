// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    internal static class SyntaxReplacer
    {
        internal static SyntaxNode Replace<TNode>(
                    SyntaxNode root,
                    IEnumerable<TNode>? nodes = null,
                    Func<TNode, TNode, SyntaxNode>? computeReplacementNode = null,
                    IEnumerable<SyntaxToken>? tokens = null,
                    Func<SyntaxToken, SyntaxToken, SyntaxToken>? computeReplacementToken = null,
                    IEnumerable<SyntaxTrivia>? trivia = null,
                    Func<SyntaxTrivia, SyntaxTrivia, SyntaxTrivia>? computeReplacementTrivia = null)
                    where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10811, 535, 1473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 1086, 1271);

                var
                replacer = f_10811_1101_1270<TNode>(nodes, computeReplacementNode, tokens, computeReplacementToken, trivia, computeReplacementTrivia)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 1287, 1462) || true) && (f_10811_1291_1307<TNode>(replacer))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 1287, 1462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 1341, 1369);

                    return f_10811_1348_1368<TNode>(replacer, root);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 1287, 1462);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 1287, 1462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 1435, 1447);

                    return root;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 1287, 1462);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10811, 535, 1473);

                Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.Replacer<TNode>
                f_10811_1101_1270<TNode>(System.Collections.Generic.IEnumerable<TNode>?
                nodes, System.Func<TNode, TNode, Microsoft.CodeAnalysis.SyntaxNode>?
                computeReplacementNode, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>?
                tokens, System.Func<Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.SyntaxToken>?
                computeReplacementToken, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>?
                trivia, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.SyntaxTrivia>?
                computeReplacementTrivia) where TNode : SyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.Replacer<TNode>(nodes, computeReplacementNode, tokens, computeReplacementToken, trivia, computeReplacementTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 1101, 1270);
                    return return_v;
                }


                bool
                f_10811_1291_1307<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.Replacer<TNode>
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.HasWork;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10811, 1291, 1307);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10811_1348_1368<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.Replacer<TNode>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node) where TNode : SyntaxNode

                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 1348, 1368);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 535, 1473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 535, 1473);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken Replace(
                    SyntaxToken root,
                    IEnumerable<SyntaxNode>? nodes = null,
                    Func<SyntaxNode, SyntaxNode, SyntaxNode>? computeReplacementNode = null,
                    IEnumerable<SyntaxToken>? tokens = null,
                    Func<SyntaxToken, SyntaxToken, SyntaxToken>? computeReplacementToken = null,
                    IEnumerable<SyntaxTrivia>? trivia = null,
                    Func<SyntaxTrivia, SyntaxTrivia, SyntaxTrivia>? computeReplacementTrivia = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10811, 1485, 2405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 2008, 2198);

                var
                replacer = f_10811_2023_2197(nodes, computeReplacementNode, tokens, computeReplacementToken, trivia, computeReplacementTrivia)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 2214, 2394) || true) && (f_10811_2218_2234(replacer))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 2214, 2394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 2268, 2301);

                    return f_10811_2275_2300(replacer, root);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 2214, 2394);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 2214, 2394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 2367, 2379);

                    return root;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 2214, 2394);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10811, 1485, 2405);

                Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.Replacer<Microsoft.CodeAnalysis.SyntaxNode>
                f_10811_2023_2197(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>?
                nodes, System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>?
                computeReplacementNode, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>?
                tokens, System.Func<Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.SyntaxToken>?
                computeReplacementToken, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>?
                trivia, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.SyntaxTrivia>?
                computeReplacementTrivia)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.Replacer<Microsoft.CodeAnalysis.SyntaxNode>(nodes, computeReplacementNode, tokens, computeReplacementToken, trivia, computeReplacementTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 2023, 2197);
                    return return_v;
                }


                bool
                f_10811_2218_2234(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.Replacer<Microsoft.CodeAnalysis.SyntaxNode>
                this_param)
                {
                    var return_v = this_param.HasWork;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10811, 2218, 2234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10811_2275_2300(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.Replacer<Microsoft.CodeAnalysis.SyntaxNode>
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = this_param.VisitToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 2275, 2300);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 1485, 2405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 1485, 2405);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private class Replacer<TNode> : CSharpSyntaxRewriter where TNode : SyntaxNode
        {
            private readonly Func<TNode, TNode, SyntaxNode>? _computeReplacementNode;

            private readonly Func<SyntaxToken, SyntaxToken, SyntaxToken>? _computeReplacementToken;

            private readonly Func<SyntaxTrivia, SyntaxTrivia, SyntaxTrivia>? _computeReplacementTrivia;

            private readonly HashSet<SyntaxNode> _nodeSet;

            private readonly HashSet<SyntaxToken> _tokenSet;

            private readonly HashSet<SyntaxTrivia> _triviaSet;

            private readonly HashSet<TextSpan> _spanSet;

            private readonly TextSpan _totalSpan;

            private readonly bool _visitIntoStructuredTrivia;

            private readonly bool _shouldVisitTrivia;

            public Replacer(
                            IEnumerable<TNode>? nodes,
                            Func<TNode, TNode, SyntaxNode>? computeReplacementNode,
                            IEnumerable<SyntaxToken>? tokens,
                            Func<SyntaxToken, SyntaxToken, SyntaxToken>? computeReplacementToken,
                            IEnumerable<SyntaxTrivia>? trivia,
                            Func<SyntaxTrivia, SyntaxTrivia, SyntaxTrivia>? computeReplacementTrivia)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10811, 3231, 4815);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 2568, 2591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 2668, 2692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 2772, 2797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 2851, 2859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 2912, 2921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 2975, 2985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 3035, 3043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 3133, 3159);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 3196, 3214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 3678, 3727);

                    _computeReplacementNode = computeReplacementNode;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 3745, 3796);

                    _computeReplacementToken = computeReplacementToken;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 3814, 3867);

                    _computeReplacementTrivia = computeReplacementTrivia;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 3887, 3957);

                    _nodeSet = (DynAbs.Tracing.TraceSender.Conditional_F1(10811, 3898, 3911) || ((nodes != null && DynAbs.Tracing.TraceSender.Conditional_F2(10811, 3914, 3944)) || DynAbs.Tracing.TraceSender.Conditional_F3(10811, 3947, 3956))) ? f_10811_3914_3944(nodes) : s_noNodes;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 3975, 4050);

                    _tokenSet = (DynAbs.Tracing.TraceSender.Conditional_F1(10811, 3987, 4001) || ((tokens != null && DynAbs.Tracing.TraceSender.Conditional_F2(10811, 4004, 4036)) || DynAbs.Tracing.TraceSender.Conditional_F3(10811, 4039, 4049))) ? f_10811_4004_4036(tokens) : s_noTokens;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 4068, 4145);

                    _triviaSet = (DynAbs.Tracing.TraceSender.Conditional_F1(10811, 4081, 4095) || ((trivia != null && DynAbs.Tracing.TraceSender.Conditional_F2(10811, 4098, 4131)) || DynAbs.Tracing.TraceSender.Conditional_F3(10811, 4134, 4144))) ? f_10811_4098_4131(trivia) : s_noTrivia;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 4165, 4383);

                    _spanSet = f_10811_4176_4382(f_10811_4220_4381(f_10811_4220_4252(_nodeSet, n => n.FullSpan), f_10811_4282_4380(f_10811_4282_4315(_tokenSet, t => t.FullSpan), f_10811_4345_4379(_triviaSet, t => t.FullSpan))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 4403, 4443);

                    _totalSpan = f_10811_4416_4442(_spanSet);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 4463, 4708);

                    _visitIntoStructuredTrivia =
                    f_10811_4513_4560(_nodeSet, n => n.IsPartOfStructuredTrivia()) || (DynAbs.Tracing.TraceSender.Expression_False(10811, 4513, 4633) || f_10811_4585_4633(_tokenSet, t => t.IsPartOfStructuredTrivia())) || (DynAbs.Tracing.TraceSender.Expression_False(10811, 4513, 4707) || f_10811_4658_4707(_triviaSet, t => t.IsPartOfStructuredTrivia()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 4728, 4800);

                    _shouldVisitTrivia = f_10811_4749_4765(_triviaSet) > 0 || (DynAbs.Tracing.TraceSender.Expression_False(10811, 4749, 4799) || _visitIntoStructuredTrivia);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10811, 3231, 4815);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 3231, 4815);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 3231, 4815);
                }
            }

            private static readonly HashSet<SyntaxNode> s_noNodes;

            private static readonly HashSet<SyntaxToken> s_noTokens;

            private static readonly HashSet<SyntaxTrivia> s_noTrivia;

            public override bool VisitIntoStructuredTrivia
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10811, 5208, 5305);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 5252, 5286);

                        return _visitIntoStructuredTrivia;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10811, 5208, 5305);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 5129, 5320);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 5129, 5320);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool HasWork
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10811, 5388, 5514);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 5432, 5495);

                        return f_10811_5439_5453(_nodeSet) + f_10811_5456_5471(_tokenSet) + f_10811_5474_5490(_triviaSet) > 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10811, 5388, 5514);

                        int
                        f_10811_5439_5453(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10811, 5439, 5453);
                            return return_v;
                        }


                        int
                        f_10811_5456_5471(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxToken>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10811, 5456, 5471);
                            return return_v;
                        }


                        int
                        f_10811_5474_5490(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTrivia>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10811, 5474, 5490);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 5336, 5529);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 5336, 5529);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static TextSpan ComputeTotalSpan(IEnumerable<TextSpan> spans)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10811, 5545, 6281);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 5647, 5665);

                    bool
                    first = true
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 5683, 5697);

                    int
                    start = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 5715, 5727);

                    int
                    end = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 5747, 6206);
                        foreach (var span in f_10811_5768_5773_I(spans))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 5747, 6206);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 5815, 6187) || true) && (first)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 5815, 6187);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 5874, 5893);

                                start = span.Start;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 5919, 5934);

                                end = span.End;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 5960, 5974);

                                first = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 5815, 6187);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 5815, 6187);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 6072, 6108);

                                start = f_10811_6080_6107(start, span.Start);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 6134, 6164);

                                end = f_10811_6140_6163(end, span.End);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 5815, 6187);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 5747, 6206);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10811, 1, 460);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10811, 1, 460);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 6226, 6266);

                    return f_10811_6233_6265(start, end - start);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10811, 5545, 6281);

                    int
                    f_10811_6080_6107(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Min(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 6080, 6107);
                        return return_v;
                    }


                    int
                    f_10811_6140_6163(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Max(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 6140, 6163);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextSpan>
                    f_10811_5768_5773_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextSpan>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 5768, 5773);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_10811_6233_6265(int
                    start, int
                    length)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 6233, 6265);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 5545, 6281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 5545, 6281);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool ShouldVisit(TextSpan span)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10811, 6297, 7139);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 6429, 6703) || true) && (!span.IntersectsWith(_totalSpan))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 6429, 6703);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 6671, 6684);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 6429, 6703);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 6723, 7091);
                        foreach (var s in f_10811_6741_6749_I(_spanSet))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 6723, 7091);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 6791, 7072) || true) && (span.IntersectsWith(s))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 6791, 7072);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 7037, 7049);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 6791, 7072);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 6723, 7091);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10811, 1, 369);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10811, 1, 369);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 7111, 7124);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10811, 6297, 7139);

                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Text.TextSpan>
                    f_10811_6741_6749_I(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Text.TextSpan>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 6741, 6749);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 6297, 7139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 6297, 7139);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [return: NotNullIfNotNull("node")]
            public override SyntaxNode? Visit(SyntaxNode? node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10811, 7155, 7829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 7287, 7316);

                    SyntaxNode?
                    rewritten = node
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 7336, 7777) || true) && (node != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 7336, 7777);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 7394, 7531) || true) && (f_10811_7398_7429(this, f_10811_7415_7428(node)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 7394, 7531);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 7479, 7508);

                            rewritten = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10811, 7491, 7507);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 7394, 7531);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 7555, 7758) || true) && (f_10811_7559_7582(_nodeSet, node) && (DynAbs.Tracing.TraceSender.Expression_True(10811, 7559, 7617) && _computeReplacementNode != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 7555, 7758);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 7667, 7735);

                            rewritten = f_10811_7679_7734(this, node, rewritten!);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 7555, 7758);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 7336, 7777);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 7797, 7814);

                    return rewritten;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10811, 7155, 7829);

                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_10811_7415_7428(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.FullSpan;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10811, 7415, 7428);
                        return return_v;
                    }


                    bool
                    f_10811_7398_7429(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.Replacer<TNode>
                    this_param, Microsoft.CodeAnalysis.Text.TextSpan
                    span)
                    {
                        var return_v = this_param.ShouldVisit(span);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 7398, 7429);
                        return return_v;
                    }


                    bool
                    f_10811_7559_7582(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 7559, 7582);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10811_7679_7734(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.Replacer<TNode>
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    arg1, Microsoft.CodeAnalysis.SyntaxNode
                    arg2)
                    {
                        var return_v = this_param._computeReplacementNode((TNode)arg1, (TNode)arg2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 7679, 7734);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 7155, 7829);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 7155, 7829);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxToken VisitToken(SyntaxToken token)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10811, 7845, 8384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 7935, 7957);

                    var
                    rewritten = token
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 7977, 8131) || true) && (_shouldVisitTrivia && (DynAbs.Tracing.TraceSender.Expression_True(10811, 7981, 8035) && f_10811_8003_8035(this, token.FullSpan)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 7977, 8131);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 8077, 8112);

                        rewritten = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitToken(token), 10811, 8089, 8111);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 7977, 8131);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 8151, 8332) || true) && (f_10811_8155_8180(_tokenSet, token) && (DynAbs.Tracing.TraceSender.Expression_True(10811, 8155, 8216) && _computeReplacementToken != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 8151, 8332);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 8258, 8313);

                        rewritten = f_10811_8270_8312(this, token, rewritten);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 8151, 8332);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 8352, 8369);

                    return rewritten;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10811, 7845, 8384);

                    bool
                    f_10811_8003_8035(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.Replacer<TNode>
                    this_param, Microsoft.CodeAnalysis.Text.TextSpan
                    span)
                    {
                        var return_v = this_param.ShouldVisit(span);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 8003, 8035);
                        return return_v;
                    }


                    bool
                    f_10811_8155_8180(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxToken>
                    this_param, Microsoft.CodeAnalysis.SyntaxToken
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 8155, 8180);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10811_8270_8312(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.Replacer<TNode>
                    this_param, Microsoft.CodeAnalysis.SyntaxToken
                    arg1, Microsoft.CodeAnalysis.SyntaxToken
                    arg2)
                    {
                        var return_v = this_param._computeReplacementToken(arg1, arg2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 8270, 8312);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 7845, 8384);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 7845, 8384);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxTrivia VisitListElement(SyntaxTrivia trivia)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10811, 8400, 8992);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 8499, 8522);

                    var
                    rewritten = trivia
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 8542, 8734) || true) && (f_10811_8546_8576(this) && (DynAbs.Tracing.TraceSender.Expression_True(10811, 8546, 8599) && trivia.HasStructure) && (DynAbs.Tracing.TraceSender.Expression_True(10811, 8546, 8636) && f_10811_8603_8636(this, trivia.FullSpan)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 8542, 8734);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 8678, 8715);

                        rewritten = f_10811_8690_8714(this, trivia);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 8542, 8734);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 8754, 8940) || true) && (f_10811_8758_8785(_triviaSet, trivia) && (DynAbs.Tracing.TraceSender.Expression_True(10811, 8758, 8822) && _computeReplacementTrivia != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 8754, 8940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 8864, 8921);

                        rewritten = f_10811_8876_8920(this, trivia, rewritten);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 8754, 8940);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 8960, 8977);

                    return rewritten;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10811, 8400, 8992);

                    bool
                    f_10811_8546_8576(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.Replacer<TNode>
                    this_param)
                    {
                        var return_v = this_param.VisitIntoStructuredTrivia;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10811, 8546, 8576);
                        return return_v;
                    }


                    bool
                    f_10811_8603_8636(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.Replacer<TNode>
                    this_param, Microsoft.CodeAnalysis.Text.TextSpan
                    span)
                    {
                        var return_v = this_param.ShouldVisit(span);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 8603, 8636);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTrivia
                    f_10811_8690_8714(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.Replacer<TNode>
                    this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                    trivia)
                    {
                        var return_v = this_param.VisitTrivia(trivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 8690, 8714);
                        return return_v;
                    }


                    bool
                    f_10811_8758_8785(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTrivia>
                    this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 8758, 8785);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTrivia
                    f_10811_8876_8920(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.Replacer<TNode>
                    this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                    arg1, Microsoft.CodeAnalysis.SyntaxTrivia
                    arg2)
                    {
                        var return_v = this_param._computeReplacementTrivia(arg1, arg2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 8876, 8920);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 8400, 8992);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 8400, 8992);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static Replacer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10811, 2417, 9003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 4875, 4912);
                s_noNodes = f_10811_4887_4912(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 4972, 5011);
                s_noTokens = f_10811_4985_5011(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 5072, 5112);
                s_noTrivia = f_10811_5085_5112(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10811, 2417, 9003);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 2417, 9003);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10811, 2417, 9003);

            System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>
            f_10811_3914_3944(System.Collections.Generic.IEnumerable<TNode>
            collection)
            {
                var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>)collection);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 3914, 3944);
                return return_v;
            }


            System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxToken>
            f_10811_4004_4036(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
            collection)
            {
                var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxToken>(collection);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 4004, 4036);
                return return_v;
            }


            System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTrivia>
            f_10811_4098_4131(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
            collection)
            {
                var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTrivia>(collection);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 4098, 4131);
                return return_v;
            }


            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextSpan>
            f_10811_4220_4252(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>
            source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.Text.TextSpan>
            selector)
            {
                var return_v = source.Select<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.Text.TextSpan>(selector);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 4220, 4252);
                return return_v;
            }


            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextSpan>
            f_10811_4282_4315(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxToken>
            source, System.Func<Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.Text.TextSpan>
            selector)
            {
                var return_v = source.Select<Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.Text.TextSpan>(selector);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 4282, 4315);
                return return_v;
            }


            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextSpan>
            f_10811_4345_4379(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTrivia>
            source, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.Text.TextSpan>
            selector)
            {
                var return_v = source.Select<Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.Text.TextSpan>(selector);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 4345, 4379);
                return return_v;
            }


            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextSpan>
            f_10811_4282_4380(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextSpan>
            first, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextSpan>
            second)
            {
                var return_v = first.Concat<Microsoft.CodeAnalysis.Text.TextSpan>(second);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 4282, 4380);
                return return_v;
            }


            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextSpan>
            f_10811_4220_4381(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextSpan>
            first, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextSpan>
            second)
            {
                var return_v = first.Concat<Microsoft.CodeAnalysis.Text.TextSpan>(second);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 4220, 4381);
                return return_v;
            }


            System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Text.TextSpan>
            f_10811_4176_4382(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextSpan>
            collection)
            {
                var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Text.TextSpan>(collection);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 4176, 4382);
                return return_v;
            }


            Microsoft.CodeAnalysis.Text.TextSpan
            f_10811_4416_4442(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Text.TextSpan>
            spans)
            {
                var return_v = ComputeTotalSpan((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextSpan>)spans);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 4416, 4442);
                return return_v;
            }


            bool
            f_10811_4513_4560(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>
            source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
            predicate)
            {
                var return_v = source.Any<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 4513, 4560);
                return return_v;
            }


            bool
            f_10811_4585_4633(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxToken>
            source, System.Func<Microsoft.CodeAnalysis.SyntaxToken, bool>
            predicate)
            {
                var return_v = source.Any<Microsoft.CodeAnalysis.SyntaxToken>(predicate);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 4585, 4633);
                return return_v;
            }


            bool
            f_10811_4658_4707(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTrivia>
            source, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, bool>
            predicate)
            {
                var return_v = source.Any<Microsoft.CodeAnalysis.SyntaxTrivia>(predicate);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 4658, 4707);
                return return_v;
            }


            int
            f_10811_4749_4765(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTrivia>
            this_param)
            {
                var return_v = this_param.Count;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10811, 4749, 4765);
                return return_v;
            }


            static System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>
            f_10811_4887_4912()
            {
                var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 4887, 4912);
                return return_v;
            }


            static System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxToken>
            f_10811_4985_5011()
            {
                var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxToken>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 4985, 5011);
                return return_v;
            }


            static System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTrivia>
            f_10811_5085_5112()
            {
                var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTrivia>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 5085, 5112);
                return return_v;
            }

        }

        internal static SyntaxNode ReplaceNodeInList(SyntaxNode root, SyntaxNode originalNode, IEnumerable<SyntaxNode> newNodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10811, 9015, 9255);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 9160, 9244);

                return f_10811_9167_9243(f_10811_9167_9231(originalNode, newNodes, ListEditKind.Replace), root);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10811, 9015, 9255);

                Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.NodeListEditor
                f_10811_9167_9231(Microsoft.CodeAnalysis.SyntaxNode
                originalNode, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                replacementNodes, Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.ListEditKind
                editKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.NodeListEditor(originalNode, replacementNodes, editKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 9167, 9231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10811_9167_9243(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.NodeListEditor
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 9167, 9243);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 9015, 9255);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 9015, 9255);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxNode InsertNodeInList(SyntaxNode root, SyntaxNode nodeInList, IEnumerable<SyntaxNode> nodesToInsert, bool insertBefore)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10811, 9267, 9578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 9433, 9567);

                return f_10811_9440_9566(f_10811_9440_9554(nodeInList, nodesToInsert, (DynAbs.Tracing.TraceSender.Conditional_F1(10811, 9486, 9498) || ((insertBefore && DynAbs.Tracing.TraceSender.Conditional_F2(10811, 9501, 9526)) || DynAbs.Tracing.TraceSender.Conditional_F3(10811, 9529, 9553))) ? ListEditKind.InsertBefore : ListEditKind.InsertAfter), root);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10811, 9267, 9578);

                Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.NodeListEditor
                f_10811_9440_9554(Microsoft.CodeAnalysis.SyntaxNode
                originalNode, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                replacementNodes, Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.ListEditKind
                editKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.NodeListEditor(originalNode, replacementNodes, editKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 9440, 9554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10811_9440_9566(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.NodeListEditor
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 9440, 9566);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 9267, 9578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 9267, 9578);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxNode ReplaceTokenInList(SyntaxNode root, SyntaxToken tokenInList, IEnumerable<SyntaxToken> newTokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10811, 9590, 9832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 9736, 9821);

                return f_10811_9743_9820(f_10811_9743_9808(tokenInList, newTokens, ListEditKind.Replace), root);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10811, 9590, 9832);

                Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.TokenListEditor
                f_10811_9743_9808(Microsoft.CodeAnalysis.SyntaxToken
                originalToken, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                newTokens, Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.ListEditKind
                editKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.TokenListEditor(originalToken, newTokens, editKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 9743, 9808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10811_9743_9820(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.TokenListEditor
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 9743, 9820);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 9590, 9832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 9590, 9832);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxNode InsertTokenInList(SyntaxNode root, SyntaxToken tokenInList, IEnumerable<SyntaxToken> newTokens, bool insertBefore)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10811, 9844, 10151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 10008, 10140);

                return f_10811_10015_10139(f_10811_10015_10127(tokenInList, newTokens, (DynAbs.Tracing.TraceSender.Conditional_F1(10811, 10059, 10071) || ((insertBefore && DynAbs.Tracing.TraceSender.Conditional_F2(10811, 10074, 10099)) || DynAbs.Tracing.TraceSender.Conditional_F3(10811, 10102, 10126))) ? ListEditKind.InsertBefore : ListEditKind.InsertAfter), root);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10811, 9844, 10151);

                Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.TokenListEditor
                f_10811_10015_10127(Microsoft.CodeAnalysis.SyntaxToken
                originalToken, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                newTokens, Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.ListEditKind
                editKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.TokenListEditor(originalToken, newTokens, editKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 10015, 10127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10811_10015_10139(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.TokenListEditor
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 10015, 10139);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 9844, 10151);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 9844, 10151);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxNode ReplaceTriviaInList(SyntaxNode root, SyntaxTrivia triviaInList, IEnumerable<SyntaxTrivia> newTrivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10811, 10163, 10411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 10313, 10400);

                return f_10811_10320_10399(f_10811_10320_10387(triviaInList, newTrivia, ListEditKind.Replace), root);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10811, 10163, 10411);

                Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.TriviaListEditor
                f_10811_10320_10387(Microsoft.CodeAnalysis.SyntaxTrivia
                originalTrivia, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                newTrivia, Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.ListEditKind
                editKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.TriviaListEditor(originalTrivia, newTrivia, editKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 10320, 10387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10811_10320_10399(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.TriviaListEditor
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 10320, 10399);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 10163, 10411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 10163, 10411);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxNode InsertTriviaInList(SyntaxNode root, SyntaxTrivia triviaInList, IEnumerable<SyntaxTrivia> newTrivia, bool insertBefore)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10811, 10423, 10736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 10591, 10725);

                return f_10811_10598_10724(f_10811_10598_10712(triviaInList, newTrivia, (DynAbs.Tracing.TraceSender.Conditional_F1(10811, 10644, 10656) || ((insertBefore && DynAbs.Tracing.TraceSender.Conditional_F2(10811, 10659, 10684)) || DynAbs.Tracing.TraceSender.Conditional_F3(10811, 10687, 10711))) ? ListEditKind.InsertBefore : ListEditKind.InsertAfter), root);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10811, 10423, 10736);

                Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.TriviaListEditor
                f_10811_10598_10712(Microsoft.CodeAnalysis.SyntaxTrivia
                originalTrivia, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                newTrivia, Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.ListEditKind
                editKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.TriviaListEditor(originalTrivia, newTrivia, editKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 10598, 10712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10811_10598_10724(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.TriviaListEditor
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 10598, 10724);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 10423, 10736);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 10423, 10736);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken ReplaceTriviaInList(SyntaxToken root, SyntaxTrivia triviaInList, IEnumerable<SyntaxTrivia> newTrivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10811, 10748, 11003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 10900, 10992);

                return f_10811_10907_10991(f_10811_10907_10974(triviaInList, newTrivia, ListEditKind.Replace), root);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10811, 10748, 11003);

                Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.TriviaListEditor
                f_10811_10907_10974(Microsoft.CodeAnalysis.SyntaxTrivia
                originalTrivia, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                newTrivia, Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.ListEditKind
                editKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.TriviaListEditor(originalTrivia, newTrivia, editKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 10907, 10974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10811_10907_10991(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.TriviaListEditor
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = this_param.VisitToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 10907, 10991);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 10748, 11003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 10748, 11003);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken InsertTriviaInList(SyntaxToken root, SyntaxTrivia triviaInList, IEnumerable<SyntaxTrivia> newTrivia, bool insertBefore)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10811, 11015, 11335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 11185, 11324);

                return f_10811_11192_11323(f_10811_11192_11306(triviaInList, newTrivia, (DynAbs.Tracing.TraceSender.Conditional_F1(10811, 11238, 11250) || ((insertBefore && DynAbs.Tracing.TraceSender.Conditional_F2(10811, 11253, 11278)) || DynAbs.Tracing.TraceSender.Conditional_F3(10811, 11281, 11305))) ? ListEditKind.InsertBefore : ListEditKind.InsertAfter), root);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10811, 11015, 11335);

                Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.TriviaListEditor
                f_10811_11192_11306(Microsoft.CodeAnalysis.SyntaxTrivia
                originalTrivia, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                newTrivia, Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.ListEditKind
                editKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.TriviaListEditor(originalTrivia, newTrivia, editKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 11192, 11306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10811_11192_11323(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.TriviaListEditor
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = this_param.VisitToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 11192, 11323);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 11015, 11335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 11015, 11335);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private enum ListEditKind
        {
            InsertBefore,
            InsertAfter,
            Replace
        }

        private static InvalidOperationException GetItemNotListElementException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10811, 11480, 11665);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 11578, 11654);

                return f_10811_11585_11653(f_10811_11615_11652());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10811, 11480, 11665);

                string
                f_10811_11615_11652()
                {
                    var return_v = CodeAnalysisResources.MissingListItem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10811, 11615, 11652);
                    return return_v;
                }


                System.InvalidOperationException
                f_10811_11585_11653(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 11585, 11653);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 11480, 11665);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 11480, 11665);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private abstract class BaseListEditor : CSharpSyntaxRewriter
        {
            private readonly TextSpan _elementSpan;

            private readonly bool _visitTrivia;

            private readonly bool _visitIntoStructuredTrivia;

            protected readonly ListEditKind editKind;

            public BaseListEditor(
                            TextSpan elementSpan,
                            ListEditKind editKind,
                            bool visitTrivia,
                            bool visitIntoStructuredTrivia)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10811, 11986, 12436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 11837, 11849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 11886, 11912);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 11961, 11969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 12204, 12231);

                    _elementSpan = elementSpan;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 12249, 12274);

                    this.editKind = editKind;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 12292, 12348);

                    _visitTrivia = visitTrivia || (DynAbs.Tracing.TraceSender.Expression_False(10811, 12307, 12347) || visitIntoStructuredTrivia);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 12366, 12421);

                    _visitIntoStructuredTrivia = visitIntoStructuredTrivia;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10811, 11986, 12436);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 11986, 12436);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 11986, 12436);
                }
            }

            public override bool VisitIntoStructuredTrivia
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10811, 12531, 12628);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 12575, 12609);

                        return _visitIntoStructuredTrivia;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10811, 12531, 12628);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 12452, 12643);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 12452, 12643);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private bool ShouldVisit(TextSpan span)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10811, 12659, 13051);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 12731, 13003) || true) && (span.IntersectsWith(_elementSpan))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 12731, 13003);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 12972, 12984);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 12731, 13003);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 13023, 13036);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10811, 12659, 13051);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 12659, 13051);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 12659, 13051);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [return: NotNullIfNotNull("node")]
            public override SyntaxNode? Visit(SyntaxNode? node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10811, 13067, 13514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 13199, 13228);

                    SyntaxNode?
                    rewritten = node
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 13248, 13462) || true) && (node != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 13248, 13462);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 13306, 13443) || true) && (f_10811_13310_13341(this, f_10811_13327_13340(node)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 13306, 13443);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 13391, 13420);

                            rewritten = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10811, 13403, 13419);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 13306, 13443);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 13248, 13462);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 13482, 13499);

                    return rewritten;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10811, 13067, 13514);

                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_10811_13327_13340(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.FullSpan;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10811, 13327, 13340);
                        return return_v;
                    }


                    bool
                    f_10811_13310_13341(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.BaseListEditor
                    this_param, Microsoft.CodeAnalysis.Text.TextSpan
                    span)
                    {
                        var return_v = this_param.ShouldVisit(span);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 13310, 13341);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 13067, 13514);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 13067, 13514);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxToken VisitToken(SyntaxToken token)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10811, 13530, 13862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 13620, 13642);

                    var
                    rewritten = token
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 13662, 13810) || true) && (_visitTrivia && (DynAbs.Tracing.TraceSender.Expression_True(10811, 13666, 13714) && f_10811_13682_13714(this, token.FullSpan)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 13662, 13810);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 13756, 13791);

                        rewritten = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitToken(token), 10811, 13768, 13790);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 13662, 13810);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 13830, 13847);

                    return rewritten;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10811, 13530, 13862);

                    bool
                    f_10811_13682_13714(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.BaseListEditor
                    this_param, Microsoft.CodeAnalysis.Text.TextSpan
                    span)
                    {
                        var return_v = this_param.ShouldVisit(span);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 13682, 13714);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 13530, 13862);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 13530, 13862);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxTrivia VisitListElement(SyntaxTrivia trivia)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10811, 13878, 14264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 13977, 14000);

                    var
                    rewritten = trivia
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 14020, 14212) || true) && (f_10811_14024_14054(this) && (DynAbs.Tracing.TraceSender.Expression_True(10811, 14024, 14077) && trivia.HasStructure) && (DynAbs.Tracing.TraceSender.Expression_True(10811, 14024, 14114) && f_10811_14081_14114(this, trivia.FullSpan)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 14020, 14212);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 14156, 14193);

                        rewritten = f_10811_14168_14192(this, trivia);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 14020, 14212);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 14232, 14249);

                    return rewritten;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10811, 13878, 14264);

                    bool
                    f_10811_14024_14054(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.BaseListEditor
                    this_param)
                    {
                        var return_v = this_param.VisitIntoStructuredTrivia;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10811, 14024, 14054);
                        return return_v;
                    }


                    bool
                    f_10811_14081_14114(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.BaseListEditor
                    this_param, Microsoft.CodeAnalysis.Text.TextSpan
                    span)
                    {
                        var return_v = this_param.ShouldVisit(span);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 14081, 14114);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTrivia
                    f_10811_14168_14192(Microsoft.CodeAnalysis.CSharp.Syntax.SyntaxReplacer.BaseListEditor
                    this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                    trivia)
                    {
                        var return_v = this_param.VisitTrivia(trivia);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 14168, 14192);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 13878, 14264);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 13878, 14264);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static BaseListEditor()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10811, 11677, 14275);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10811, 11677, 14275);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 11677, 14275);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10811, 11677, 14275);
        }
        private class NodeListEditor : BaseListEditor
        {
            private readonly SyntaxNode _originalNode;

            private readonly IEnumerable<SyntaxNode> _newNodes;

            public NodeListEditor(
                            SyntaxNode originalNode,
                            IEnumerable<SyntaxNode> replacementNodes,
                            ListEditKind editKind)
            : base(f_10811_14668_14685_C(f_10811_14668_14685(originalNode)), editKind, false, f_10811_14704_14743(originalNode))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10811, 14480, 14868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 14385, 14398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 14454, 14463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 14777, 14806);

                    _originalNode = originalNode;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 14824, 14853);

                    _newNodes = replacementNodes;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10811, 14480, 14868);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 14480, 14868);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 14480, 14868);
                }
            }

            [return: NotNullIfNotNull("node")]
            public override SyntaxNode? Visit(SyntaxNode? node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10811, 14884, 15200);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 15016, 15141) || true) && (node == _originalNode)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 15016, 15141);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 15083, 15122);

                        throw f_10811_15089_15121();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 15016, 15141);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 15161, 15185);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10811, 15168, 15184);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10811, 14884, 15200);

                    System.InvalidOperationException
                    f_10811_15089_15121()
                    {
                        var return_v = GetItemNotListElementException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 15089, 15121);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 14884, 15200);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 14884, 15200);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SeparatedSyntaxList<TNode> VisitList<TNode>(SeparatedSyntaxList<TNode> list)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10811, 15216, 16223);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 15341, 16153) || true) && (_originalNode is TNode)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 15341, 16153);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 15409, 15456);

                        var
                        index = list.IndexOf(_originalNode)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 15478, 16134) || true) && (index >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(10811, 15482, 15514) && index < list.Count))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 15478, 16134);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 15564, 16111);

                            switch (this.editKind)
                            {

                                case ListEditKind.Replace:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 15564, 16111);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 15703, 15775);

                                    return list.ReplaceRange((TNode)_originalNode, f_10811_15750_15773<TNode>(_newNodes));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 15564, 16111);

                                case ListEditKind.InsertAfter:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 15564, 16111);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 15871, 15931);

                                    return list.InsertRange(index + 1, f_10811_15906_15929<TNode>(_newNodes));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 15564, 16111);

                                case ListEditKind.InsertBefore:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 15564, 16111);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 16028, 16084);

                                    return list.InsertRange(index, f_10811_16059_16082<TNode>(_newNodes));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 15564, 16111);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 15478, 16134);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 15341, 16153);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 16173, 16208);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitList<TNode>(list), 10811, 16180, 16207);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10811, 15216, 16223);

                    System.Collections.Generic.IEnumerable<TNode>
                    f_10811_15750_15773<TNode>(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                    source)
                    {
                        var return_v = source.Cast<TNode>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 15750, 15773);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<TNode>
                    f_10811_15906_15929<TNode>(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                    source)
                    {
                        var return_v = source.Cast<TNode>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 15906, 15929);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<TNode>
                    f_10811_16059_16082<TNode>(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                    source)
                    {
                        var return_v = source.Cast<TNode>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 16059, 16082);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 15216, 16223);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 15216, 16223);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxList<TNode> VisitList<TNode>(SyntaxList<TNode> list)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10811, 16239, 17228);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 16346, 17158) || true) && (_originalNode is TNode)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 16346, 17158);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 16414, 16461);

                        var
                        index = list.IndexOf(_originalNode)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 16483, 17139) || true) && (index >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(10811, 16487, 16519) && index < list.Count))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 16483, 17139);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 16569, 17116);

                            switch (this.editKind)
                            {

                                case ListEditKind.Replace:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 16569, 17116);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 16708, 16780);

                                    return list.ReplaceRange((TNode)_originalNode, f_10811_16755_16778<TNode>(_newNodes));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 16569, 17116);

                                case ListEditKind.InsertAfter:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 16569, 17116);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 16876, 16936);

                                    return list.InsertRange(index + 1, f_10811_16911_16934<TNode>(_newNodes));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 16569, 17116);

                                case ListEditKind.InsertBefore:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 16569, 17116);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 17033, 17089);

                                    return list.InsertRange(index, f_10811_17064_17087<TNode>(_newNodes));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 16569, 17116);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 16483, 17139);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 16346, 17158);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 17178, 17213);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitList<TNode>(list), 10811, 17185, 17212);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10811, 16239, 17228);

                    System.Collections.Generic.IEnumerable<TNode>
                    f_10811_16755_16778<TNode>(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                    source)
                    {
                        var return_v = source.Cast<TNode>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 16755, 16778);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<TNode>
                    f_10811_16911_16934<TNode>(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                    source)
                    {
                        var return_v = source.Cast<TNode>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 16911, 16934);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<TNode>
                    f_10811_17064_17087<TNode>(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                    source)
                    {
                        var return_v = source.Cast<TNode>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 17064, 17087);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 16239, 17228);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 16239, 17228);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static NodeListEditor()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10811, 14287, 17239);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10811, 14287, 17239);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 14287, 17239);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10811, 14287, 17239);

            static Microsoft.CodeAnalysis.Text.TextSpan
            f_10811_14668_14685(Microsoft.CodeAnalysis.SyntaxNode
            this_param)
            {
                var return_v = this_param.Span;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10811, 14668, 14685);
                return return_v;
            }


            static bool
            f_10811_14704_14743(Microsoft.CodeAnalysis.SyntaxNode
            this_param)
            {
                var return_v = this_param.IsPartOfStructuredTrivia();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 14704, 14743);
                return return_v;
            }


            static Microsoft.CodeAnalysis.Text.TextSpan
            f_10811_14668_14685_C(Microsoft.CodeAnalysis.Text.TextSpan
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10811, 14480, 14868);
                return return_v;
            }

        }
        private class TokenListEditor : BaseListEditor
        {
            private readonly SyntaxToken _originalToken;

            private readonly IEnumerable<SyntaxToken> _newTokens;

            public TokenListEditor(
                            SyntaxToken originalToken,
                            IEnumerable<SyntaxToken> newTokens,
                            ListEditKind editKind)
            : base(f_10811_17634_17652_C(originalToken.Span), editKind, false, originalToken.IsPartOfStructuredTrivia())
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10811, 17449, 17832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 17422, 17432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 17745, 17776);

                    _originalToken = originalToken;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 17794, 17817);

                    _newTokens = newTokens;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10811, 17449, 17832);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 17449, 17832);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 17449, 17832);
                }
            }

            public override SyntaxToken VisitToken(SyntaxToken token)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10811, 17848, 18130);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 17938, 18065) || true) && (token == _originalToken)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 17938, 18065);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 18007, 18046);

                        throw f_10811_18013_18045();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 17938, 18065);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 18085, 18115);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitToken(token), 10811, 18092, 18114);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10811, 17848, 18130);

                    System.InvalidOperationException
                    f_10811_18013_18045()
                    {
                        var return_v = GetItemNotListElementException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10811, 18013, 18045);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 17848, 18130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 17848, 18130);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxTokenList VisitList(SyntaxTokenList list)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10811, 18146, 18931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 18242, 18283);

                    var
                    index = list.IndexOf(_originalToken)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 18301, 18868) || true) && (index >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(10811, 18305, 18337) && index < list.Count))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 18301, 18868);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 18379, 18849);

                        switch (this.editKind)
                        {

                            case ListEditKind.Replace:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 18379, 18849);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 18506, 18559);

                                return list.ReplaceRange(_originalToken, _newTokens);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 18379, 18849);

                            case ListEditKind.InsertAfter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 18379, 18849);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 18647, 18694);

                                return list.InsertRange(index + 1, _newTokens);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 18379, 18849);

                            case ListEditKind.InsertBefore:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 18379, 18849);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 18783, 18826);

                                return list.InsertRange(index, _newTokens);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 18379, 18849);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 18301, 18868);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 18888, 18916);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitList(list), 10811, 18895, 18915);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10811, 18146, 18931);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 18146, 18931);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 18146, 18931);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static TokenListEditor()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10811, 17251, 18942);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10811, 17251, 18942);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 17251, 18942);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10811, 17251, 18942);

            static Microsoft.CodeAnalysis.Text.TextSpan
            f_10811_17634_17652_C(Microsoft.CodeAnalysis.Text.TextSpan
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10811, 17449, 17832);
                return return_v;
            }

        }
        private class TriviaListEditor : BaseListEditor
        {
            private readonly SyntaxTrivia _originalTrivia;

            private readonly IEnumerable<SyntaxTrivia> _newTrivia;

            public TriviaListEditor(
                            SyntaxTrivia originalTrivia,
                            IEnumerable<SyntaxTrivia> newTrivia,
                            ListEditKind editKind)
            : base(f_10811_19345_19364_C(originalTrivia.Span), editKind, true, originalTrivia.IsPartOfStructuredTrivia())
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10811, 19156, 19546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 19129, 19139);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 19457, 19490);

                    _originalTrivia = originalTrivia;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 19508, 19531);

                    _newTrivia = newTrivia;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10811, 19156, 19546);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 19156, 19546);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 19156, 19546);
                }
            }

            public override SyntaxTriviaList VisitList(SyntaxTriviaList list)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10811, 19562, 20351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 19660, 19702);

                    var
                    index = list.IndexOf(_originalTrivia)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 19720, 20288) || true) && (index >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(10811, 19724, 19756) && index < list.Count))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 19720, 20288);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 19798, 20269);

                        switch (this.editKind)
                        {

                            case ListEditKind.Replace:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 19798, 20269);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 19925, 19979);

                                return list.ReplaceRange(_originalTrivia, _newTrivia);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 19798, 20269);

                            case ListEditKind.InsertAfter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 19798, 20269);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 20067, 20114);

                                return list.InsertRange(index + 1, _newTrivia);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 19798, 20269);

                            case ListEditKind.InsertBefore:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10811, 19798, 20269);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 20203, 20246);

                                return list.InsertRange(index, _newTrivia);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 19798, 20269);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10811, 19720, 20288);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10811, 20308, 20336);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitList(list), 10811, 20315, 20335);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10811, 19562, 20351);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10811, 19562, 20351);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 19562, 20351);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static TriviaListEditor()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10811, 18954, 20362);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10811, 18954, 20362);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 18954, 20362);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10811, 18954, 20362);

            static Microsoft.CodeAnalysis.Text.TextSpan
            f_10811_19345_19364_C(Microsoft.CodeAnalysis.Text.TextSpan
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10811, 19156, 19546);
                return return_v;
            }

        }

        static SyntaxReplacer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10811, 482, 20369);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10811, 482, 20369);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10811, 482, 20369);
        }

    }
}
