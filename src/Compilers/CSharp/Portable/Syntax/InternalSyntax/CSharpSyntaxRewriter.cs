// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    using Microsoft.CodeAnalysis.Syntax.InternalSyntax;

#nullable enable
    internal partial class CSharpSyntaxRewriter : CSharpSyntaxVisitor<CSharpSyntaxNode>
#nullable disable
    {
        protected readonly bool VisitIntoStructuredTrivia;

        public CSharpSyntaxRewriter(bool visitIntoStructuredTrivia = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10823, 586, 748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 548, 573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 678, 737);

                this.VisitIntoStructuredTrivia = visitIntoStructuredTrivia;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10823, 586, 748);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10823, 586, 748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10823, 586, 748);
            }
        }

        public override CSharpSyntaxNode VisitToken(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10823, 760, 1454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 847, 897);

                var
                leading = f_10823_861_896(this, f_10823_876_895(token))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 911, 963);

                var
                trailing = f_10823_926_962(this, f_10823_941_961(token))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 979, 1414) || true) && (leading != f_10823_994_1013(token) || (DynAbs.Tracing.TraceSender.Expression_False(10823, 983, 1049) || trailing != f_10823_1029_1049(token)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10823, 979, 1414);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 1083, 1229) || true) && (leading != f_10823_1098_1117(token))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10823, 1083, 1229);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 1159, 1210);

                        token = f_10823_1167_1209(token, leading.Node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10823, 1083, 1229);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 1249, 1399) || true) && (trailing != f_10823_1265_1285(token))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10823, 1249, 1399);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 1327, 1380);

                        token = f_10823_1335_1379(token, trailing.Node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10823, 1249, 1399);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10823, 979, 1414);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 1430, 1443);

                return token;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10823, 760, 1454);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                f_10823_876_895(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.LeadingTrivia;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10823, 876, 895);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                f_10823_861_896(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxRewriter
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                list)
                {
                    var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10823, 861, 896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                f_10823_941_961(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.TrailingTrivia;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10823, 941, 961);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                f_10823_926_962(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxRewriter
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                list)
                {
                    var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10823, 926, 962);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                f_10823_994_1013(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.LeadingTrivia;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10823, 994, 1013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                f_10823_1029_1049(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.TrailingTrivia;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10823, 1029, 1049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                f_10823_1098_1117(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.LeadingTrivia;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10823, 1098, 1117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10823_1167_1209(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param, Microsoft.CodeAnalysis.GreenNode?
                trivia)
                {
                    var return_v = this_param.TokenWithLeadingTrivia(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10823, 1167, 1209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                f_10823_1265_1285(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.TrailingTrivia;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10823, 1265, 1285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10823_1335_1379(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param, Microsoft.CodeAnalysis.GreenNode?
                trivia)
                {
                    var return_v = this_param.TokenWithTrailingTrivia(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10823, 1335, 1379);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10823, 760, 1454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10823, 760, 1454);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxList<TNode> VisitList<TNode>(SyntaxList<TNode> list) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10823, 1466, 2433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 1587, 1622);

                SyntaxListBuilder
                alternate = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 1645, 1650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 1652, 1666);
                    for (int
        i = 0
        ,
        n = list.Count
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 1636, 2282) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 1675, 1678)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10823, 1636, 2282))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10823, 1636, 2282);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 1712, 1731);

                        var
                        item = list[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 1749, 1780);

                        var
                        visited = f_10823_1763_1779<TNode>(this, item)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 1798, 1989) || true) && (item != visited && (DynAbs.Tracing.TraceSender.Expression_True(10823, 1802, 1838) && alternate == null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10823, 1798, 1989);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 1880, 1917);

                            alternate = f_10823_1892_1916<TNode>(n);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 1939, 1970);

                            f_10823_1939_1969<TNode>(alternate, list, 0, i);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10823, 1798, 1989);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 2009, 2267) || true) && (alternate != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10823, 2009, 2267);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 2072, 2203);

                            f_10823_2072_2202<TNode>(visited != null && (DynAbs.Tracing.TraceSender.Expression_True(10823, 2085, 2135) && f_10823_2104_2116<TNode>(visited) != SyntaxKind.None), "Cannot remove node using Syntax.InternalSyntax.SyntaxRewriter.");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 2225, 2248);

                            f_10823_2225_2247<TNode>(alternate, visited);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10823, 2009, 2267);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10823, 1, 647);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10823, 1, 647);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 2298, 2394) || true) && (alternate != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10823, 2298, 2394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 2353, 2379);

                    return f_10823_2360_2378<TNode>(alternate);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10823, 2298, 2394);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 2410, 2422);

                return list;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10823, 1466, 2433);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                f_10823_1763_1779<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxRewriter
                this_param, TNode?
                node) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10823, 1763, 1779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                f_10823_1892_1916<TNode>(int
                size) where TNode : CSharpSyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10823, 1892, 1916);
                    return return_v;
                }


                int
                f_10823_1939_1969<TNode>(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<TNode>
                list, int
                offset, int
                length) where TNode : CSharpSyntaxNode

                {
                    this_param.AddRange<TNode>(list, offset, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10823, 1939, 1969);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10823_2104_2116<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10823, 2104, 2116);
                    return return_v;
                }


                int
                f_10823_2072_2202<TNode>(bool
                condition, string
                message) where TNode : CSharpSyntaxNode

                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10823, 2072, 2202);
                    return 0;
                }


                int
                f_10823_2225_2247<TNode>(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                item) where TNode : CSharpSyntaxNode

                {
                    this_param.Add((Microsoft.CodeAnalysis.GreenNode)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10823, 2225, 2247);
                    return 0;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>
                f_10823_2360_2378<TNode>(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.ToList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10823, 2360, 2378);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10823, 1466, 2433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10823, 1466, 2433);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SeparatedSyntaxList<TNode> VisitList<TNode>(SeparatedSyntaxList<TNode> list) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10823, 2445, 3074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 2789, 2859);

                var
                withSeps = (SyntaxList<CSharpSyntaxNode>)list.GetWithSeparators()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 2873, 2911);

                var
                result = f_10823_2886_2910<TNode>(this, withSeps)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 2925, 3035) || true) && (result != withSeps)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10823, 2925, 3035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 2981, 3020);

                    return result.AsSeparatedList<TNode>();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10823, 2925, 3035);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10823, 3051, 3063);

                return list;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10823, 2445, 3074);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                f_10823_2886_2910<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxRewriter
                this_param, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                list) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10823, 2886, 2910);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10823, 2445, 3074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10823, 2445, 3074);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CSharpSyntaxRewriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10823, 405, 3081);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10823, 405, 3081);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10823, 405, 3081);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10823, 405, 3081);
    }
}
