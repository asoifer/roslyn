// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class UnprocessedDocumentationCommentFinder : CSharpSyntaxWalker
    {
        private readonly DiagnosticBag _diagnostics;

        private readonly CancellationToken _cancellationToken;

        private readonly TextSpan? _filterSpanWithinTree;

        private bool _isValidLocation;

        private UnprocessedDocumentationCommentFinder(DiagnosticBag diagnostics, TextSpan? filterSpanWithinTree, CancellationToken cancellationToken)
        : base(f_10630_858_882_C(SyntaxWalkerDepth.Trivia))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10630, 696, 1058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 506, 518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 620, 641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 667, 683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 908, 935);

                _diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 949, 994);

                _filterSpanWithinTree = filterSpanWithinTree;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 1008, 1047);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10630, 696, 1058);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10630, 696, 1058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10630, 696, 1058);
            }
        }

        public static void ReportUnprocessed(SyntaxTree tree, TextSpan? filterSpanWithinTree, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10630, 1070, 1559);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 1244, 1548) || true) && (f_10630_1248_1292(tree))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10630, 1244, 1548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 1326, 1469);

                    UnprocessedDocumentationCommentFinder
                    finder = f_10630_1373_1468(diagnostics, filterSpanWithinTree, cancellationToken)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 1487, 1533);

                    f_10630_1487_1532(finder, f_10630_1500_1531(tree, cancellationToken));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10630, 1244, 1548);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10630, 1070, 1559);

                bool
                f_10630_1248_1292(Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = tree.ReportDocumentationCommentDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10630, 1248, 1292);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnprocessedDocumentationCommentFinder
                f_10630_1373_1468(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Text.TextSpan?
                filterSpanWithinTree, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UnprocessedDocumentationCommentFinder(diagnostics, filterSpanWithinTree, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10630, 1373, 1468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10630_1500_1531(Microsoft.CodeAnalysis.SyntaxTree
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetRoot(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10630, 1500, 1531);
                    return return_v;
                }


                int
                f_10630_1487_1532(Microsoft.CodeAnalysis.CSharp.UnprocessedDocumentationCommentFinder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10630, 1487, 1532);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10630, 1070, 1559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10630, 1070, 1559);
            }
        }

        private bool IsSyntacticallyFilteredOut(TextSpan fullSpan)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10630, 1571, 1754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 1654, 1743);

                return _filterSpanWithinTree.HasValue && (DynAbs.Tracing.TraceSender.Expression_True(10630, 1661, 1742) && !_filterSpanWithinTree.Value.Contains(fullSpan));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10630, 1571, 1754);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10630, 1571, 1754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10630, 1571, 1754);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void DefaultVisit(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10630, 1766, 3112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 1841, 1891);

                _cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 1907, 2008) || true) && (f_10630_1911_1952(this, f_10630_1938_1951(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10630, 1907, 2008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 1986, 1993);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10630, 1907, 2008);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 2213, 2452) || true) && (f_10630_2217_2242_M(!node.HasStructuredTrivia))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10630, 2213, 2452);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 2276, 2412) || true) && (node.Span.Length > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10630, 2276, 2412);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 2342, 2367);

                        _isValidLocation = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10630, 2276, 2412);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 2430, 2437);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10630, 2213, 2452);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 2468, 3061) || true) && (node is BaseTypeDeclarationSyntax || (DynAbs.Tracing.TraceSender.Expression_False(10630, 2472, 2559) || node is DelegateDeclarationSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(10630, 2472, 2615) || node is EnumMemberDeclarationSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(10630, 2472, 2671) || node is BaseMethodDeclarationSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(10630, 2472, 2729) || node is BasePropertyDeclarationSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(10630, 2472, 2818) || node is BaseFieldDeclarationSyntax))
                ) //includes EventFieldDeclarationSyntax

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10630, 2468, 3061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 3022, 3046);

                    _isValidLocation = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10630, 2468, 3061);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 3077, 3101);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.DefaultVisit(node), 10630, 3077, 3100);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10630, 1766, 3112);

                Microsoft.CodeAnalysis.Text.TextSpan
                f_10630_1938_1951(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.FullSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10630, 1938, 1951);
                    return return_v;
                }


                bool
                f_10630_1911_1952(Microsoft.CodeAnalysis.CSharp.UnprocessedDocumentationCommentFinder
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                fullSpan)
                {
                    var return_v = this_param.IsSyntacticallyFilteredOut(fullSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10630, 1911, 1952);
                    return return_v;
                }


                bool
                f_10630_2217_2242_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10630, 2217, 2242);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10630, 1766, 3112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10630, 1766, 3112);
            }
        }

        public override void VisitLeadingTrivia(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10630, 3124, 3472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 3207, 3257);

                _cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 3273, 3375) || true) && (f_10630_3277_3319(this, token.FullSpan))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10630, 3273, 3375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 3353, 3360);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10630, 3273, 3375);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 3391, 3422);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLeadingTrivia(token), 10630, 3391, 3421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 3436, 3461);

                _isValidLocation = false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10630, 3124, 3472);

                bool
                f_10630_3277_3319(Microsoft.CodeAnalysis.CSharp.UnprocessedDocumentationCommentFinder
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                fullSpan)
                {
                    var return_v = this_param.IsSyntacticallyFilteredOut(fullSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10630, 3277, 3319);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10630, 3124, 3472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10630, 3124, 3472);
            }
        }

        public override void VisitTrivia(SyntaxTrivia trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10630, 3484, 4215);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 3562, 3612);

                _cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 3628, 3731) || true) && (f_10630_3632_3675(this, trivia.FullSpan))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10630, 3628, 3731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 3709, 3716);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10630, 3628, 3731);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 3747, 4165) || true) && (!_isValidLocation && (DynAbs.Tracing.TraceSender.Expression_True(10630, 3751, 3827) && f_10630_3772_3827(trivia.Kind())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10630, 3747, 4165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 3861, 3889);

                    int
                    start = trivia.Position
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 3947, 3968);

                    const int
                    length = 1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 4028, 4150);

                    f_10630_4028_4149(_diagnostics, ErrorCode.WRN_UnprocessedXMLComment, f_10630_4082_4148(trivia.SyntaxTree, f_10630_4120_4147(start, length)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10630, 3747, 4165);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10630, 4179, 4204);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitTrivia(trivia), 10630, 4179, 4203);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10630, 3484, 4215);

                bool
                f_10630_3632_3675(Microsoft.CodeAnalysis.CSharp.UnprocessedDocumentationCommentFinder
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                fullSpan)
                {
                    var return_v = this_param.IsSyntacticallyFilteredOut(fullSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10630, 3632, 3675);
                    return return_v;
                }


                bool
                f_10630_3772_3827(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsDocumentationCommentTrivia(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10630, 3772, 3827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10630_4120_4147(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10630, 4120, 4147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10630_4082_4148(Microsoft.CodeAnalysis.SyntaxTree?
                syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(syntaxTree, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10630, 4082, 4148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10630_4028_4149(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10630, 4028, 4149);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10630, 3484, 4215);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10630, 3484, 4215);
            }
        }

        static UnprocessedDocumentationCommentFinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10630, 385, 4222);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10630, 385, 4222);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10630, 385, 4222);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10630, 385, 4222);

        static Microsoft.CodeAnalysis.SyntaxWalkerDepth
        f_10630_858_882_C(Microsoft.CodeAnalysis.SyntaxWalkerDepth
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10630, 696, 1058);
            return return_v;
        }

    }
}
