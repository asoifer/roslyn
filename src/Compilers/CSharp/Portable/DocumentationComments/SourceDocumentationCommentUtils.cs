// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static class SourceDocumentationCommentUtils
    {
        internal static string GetAndCacheDocumentationComment(Symbol symbol, bool expandIncludes, ref string lazyXmlText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10936, 638, 1285);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 964, 1239) || true) && (lazyXmlText == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10936, 964, 1239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 1021, 1146);

                    string
                    xmlText = f_10936_1038_1145(symbol, expandIncludes, default(CancellationToken))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 1164, 1224);

                    f_10936_1164_1223(ref lazyXmlText, xmlText, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10936, 964, 1239);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 1255, 1274);

                return lazyXmlText;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10936, 638, 1285);

                string
                f_10936_1038_1145(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, bool
                processIncludes, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = DocumentationCommentCompiler.GetDocumentationCommentXml(symbol, processIncludes, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10936, 1038, 1145);
                    return return_v;
                }


                string?
                f_10936_1164_1223(ref string?
                location1, string
                value, string?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10936, 1164, 1223);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10936, 638, 1285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10936, 638, 1285);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<DocumentationCommentTriviaSyntax> GetDocumentationCommentTriviaFromSyntaxNode(CSharpSyntaxNode syntaxNode, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10936, 1297, 5369);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 1486, 1674) || true) && (f_10936_1490_1537(f_10936_1490_1519(f_10936_1490_1511(syntaxNode))) < DocumentationMode.Parse)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10936, 1486, 1674);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 1597, 1659);

                    return ImmutableArray<DocumentationCommentTriviaSyntax>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10936, 1486, 1674);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 1866, 2490) || true) && (f_10936_1870_1887(syntaxNode) == SyntaxKind.VariableDeclarator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10936, 1866, 2490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 1954, 1989);

                    CSharpSyntaxNode
                    curr = syntaxNode
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 2007, 2352) || true) && ((object)curr != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10936, 2007, 2352);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 2076, 2106);

                            SyntaxKind
                            kind = f_10936_2094_2105(curr)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 2128, 2290) || true) && (kind == SyntaxKind.FieldDeclaration || (DynAbs.Tracing.TraceSender.Expression_False(10936, 2132, 2211) || kind == SyntaxKind.EventFieldDeclaration))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10936, 2128, 2290);
                                DynAbs.Tracing.TraceSender.TraceBreak(10936, 2261, 2267);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10936, 2128, 2290);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 2314, 2333);

                            curr = f_10936_2321_2332(curr);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10936, 2007, 2352);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10936, 2007, 2352);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10936, 2007, 2352);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 2372, 2475) || true) && ((object)curr != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10936, 2372, 2475);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 2438, 2456);

                        syntaxNode = curr;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10936, 2372, 2475);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10936, 1866, 2490);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 2506, 2568);

                ArrayBuilder<DocumentationCommentTriviaSyntax>
                builder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 2582, 2611);

                bool
                seenOtherTrivia = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 2625, 5120);
                    foreach (var trivia in f_10936_2648_2687_I(f_10936_2648_2677(syntaxNode).Reverse()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10936, 2625, 5120);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 2721, 5105);

                        switch (trivia.Kind())
                        {

                            case SyntaxKind.SingleLineDocumentationCommentTrivia:
                            case SyntaxKind.MultiLineDocumentationCommentTrivia:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10936, 2721, 5105);
                                {

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 2968, 4378) || true) && (seenOtherTrivia)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10936, 2968, 4378);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 3366, 3407);

                                        var
                                        tree = (SyntaxTree)trivia.SyntaxTree
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 3441, 3913) || true) && (f_10936_3445_3489(tree))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10936, 3441, 3913);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 3563, 3591);

                                            int
                                            start = trivia.Position
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 3669, 3690);

                                            const int
                                            length = 1
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 3770, 3878);

                                            f_10936_3770_3877(diagnostics, ErrorCode.WRN_UnprocessedXMLComment, f_10936_3823_3876(tree, f_10936_3848_3875(start, length)));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10936, 3441, 3913);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10936, 2968, 4378);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10936, 2968, 4378);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 4043, 4242) || true) && (builder == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10936, 4043, 4242);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 4136, 4207);

                                            builder = f_10936_4146_4206();
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10936, 4043, 4242);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 4278, 4347);

                                        f_10936_4278_4346(
                                                                        builder, trivia.GetStructure());
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10936, 2968, 4378);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10936, 4408, 4414);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10936, 2721, 5105);

                            case SyntaxKind.WhitespaceTrivia:
                            case SyntaxKind.EndOfLineTrivia:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10936, 2721, 5105);
                                DynAbs.Tracing.TraceSender.TraceBreak(10936, 4651, 4657);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10936, 2721, 5105);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10936, 2721, 5105);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 4927, 5054) || true) && (builder != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10936, 4927, 5054);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 5004, 5027);

                                    seenOtherTrivia = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10936, 4927, 5054);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10936, 5080, 5086);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10936, 2721, 5105);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10936, 2625, 5120);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10936, 1, 2496);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10936, 1, 2496);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 5136, 5266) || true) && (builder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10936, 5136, 5266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 5189, 5251);

                    return ImmutableArray<DocumentationCommentTriviaSyntax>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10936, 5136, 5266);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 5282, 5308);

                f_10936_5282_5307(
                            builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10936, 5322, 5358);

                return f_10936_5329_5357(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10936, 1297, 5369);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10936_1490_1511(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10936, 1490, 1511);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParseOptions
                f_10936_1490_1519(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10936, 1490, 1519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DocumentationMode
                f_10936_1490_1537(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.DocumentationMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10936, 1490, 1537);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10936_1870_1887(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10936, 1870, 1887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10936_2094_2105(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10936, 2094, 2105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10936_2321_2332(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10936, 2321, 2332);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10936_2648_2677(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLeadingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10936, 2648, 2677);
                    return return_v;
                }


                bool
                f_10936_3445_3489(Microsoft.CodeAnalysis.SyntaxTree?
                tree)
                {
                    var return_v = tree.ReportDocumentationCommentDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10936, 3445, 3489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10936_3848_3875(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10936, 3848, 3875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10936_3823_3876(Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(syntaxTree, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10936, 3823, 3876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10936_3770_3877(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SourceLocation
                location)
                {
                    var return_v = diagnostics.Add(code, (Microsoft.CodeAnalysis.Location)location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10936, 3770, 3877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax>
                f_10936_4146_4206()
                {
                    var return_v = ArrayBuilder<DocumentationCommentTriviaSyntax>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10936, 4146, 4206);
                    return return_v;
                }


                int
                f_10936_4278_4346(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax>
                this_param, Microsoft.CodeAnalysis.SyntaxNode?
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax?)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10936, 4278, 4346);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList.Reversed
                f_10936_2648_2687_I(Microsoft.CodeAnalysis.SyntaxTriviaList.Reversed
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10936, 2648, 2687);
                    return return_v;
                }


                int
                f_10936_5282_5307(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax>
                this_param)
                {
                    this_param.ReverseContents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10936, 5282, 5307);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax>
                f_10936_5329_5357(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10936, 5329, 5357);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10936, 1297, 5369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10936, 1297, 5369);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SourceDocumentationCommentUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10936, 568, 5376);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10936, 568, 5376);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10936, 568, 5376);
        }

    }
}
