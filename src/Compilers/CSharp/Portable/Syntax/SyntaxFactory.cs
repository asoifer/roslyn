// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using InternalSyntax = Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax;

namespace Microsoft.CodeAnalysis.CSharp
{
    public static partial class SyntaxFactory
    {
        public static SyntaxTrivia CarriageReturnLineFeed { get; }

        public static SyntaxTrivia LineFeed { get; }

        public static SyntaxTrivia CarriageReturn { get; }

        public static SyntaxTrivia Space { get; }

        public static SyntaxTrivia Tab { get; }

        public static SyntaxTrivia ElasticCarriageReturnLineFeed { get; }

        public static SyntaxTrivia ElasticLineFeed { get; }

        public static SyntaxTrivia ElasticCarriageReturn { get; }

        public static SyntaxTrivia ElasticSpace { get; }

        public static SyntaxTrivia ElasticTab { get; }

        public static SyntaxTrivia ElasticMarker { get; }

        public static SyntaxTrivia EndOfLine(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 5081, 5241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 5155, 5230);

                return f_10001_5162_5229(text, elastic: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 5081, 5241);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10001_5162_5229(string
                text, bool
                elastic)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.EndOfLine(text, elastic: elastic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 5162, 5229);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 5081, 5241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 5081, 5241);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTrivia ElasticEndOfLine(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 5749, 5915);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 5830, 5904);

                return f_10001_5837_5903(text, elastic: true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 5749, 5915);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10001_5837_5903(string
                text, bool
                elastic)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.EndOfLine(text, elastic: elastic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 5837, 5903);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 5749, 5915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 5749, 5915);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Obsolete("Use SyntaxFactory.EndOfLine or SyntaxFactory.ElasticEndOfLine")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static SyntaxTrivia EndOfLine(string text, bool elastic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 5927, 6278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 6199, 6267);

                return f_10001_6206_6266(text, elastic);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 5927, 6278);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10001_6206_6266(string
                text, bool
                elastic)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.EndOfLine(text, elastic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 6206, 6266);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 5927, 6278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 5927, 6278);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTrivia Whitespace(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 6612, 6774);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 6687, 6763);

                return f_10001_6694_6762(text, elastic: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 6612, 6774);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10001_6694_6762(string
                text, bool
                elastic)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Whitespace(text, elastic: elastic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 6694, 6762);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 6612, 6774);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 6612, 6774);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTrivia ElasticWhitespace(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 7257, 7426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 7339, 7415);

                return f_10001_7346_7414(text, elastic: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 7257, 7426);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10001_7346_7414(string
                text, bool
                elastic)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Whitespace(text, elastic: elastic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 7346, 7414);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 7257, 7426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 7257, 7426);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Obsolete("Use SyntaxFactory.Whitespace or SyntaxFactory.ElasticWhitespace")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public static SyntaxTrivia Whitespace(string text, bool elastic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 7438, 7793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 7713, 7782);

                return f_10001_7720_7781(text, elastic);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 7438, 7793);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10001_7720_7781(string
                text, bool
                elastic)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Whitespace(text, elastic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 7720, 7781);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 7438, 7793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 7438, 7793);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTrivia Comment(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 8183, 8323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 8255, 8312);

                return f_10001_8262_8311(text);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 8183, 8323);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10001_8262_8311(string
                text)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Comment(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 8262, 8311);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 8183, 8323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 8183, 8323);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTrivia DisabledText(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 8543, 8693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 8620, 8682);

                return f_10001_8627_8681(text);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 8543, 8693);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10001_8627_8681(string
                text)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.DisabledText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 8627, 8681);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 8543, 8693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 8543, 8693);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTrivia PreprocessingMessage(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 8820, 8986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 8905, 8975);

                return f_10001_8912_8974(text);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 8820, 8986);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10001_8912_8974(string
                text)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.PreprocessingMessage(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 8912, 8974);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 8820, 8986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 8820, 8986);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTrivia SyntaxTrivia(SyntaxKind kind, string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 9849, 10684);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 9943, 10054) || true) && (text == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 9943, 10054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 9993, 10039);

                    throw f_10001_9999_10038(nameof(text));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 9943, 10054);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 10070, 10673);

                switch (kind)
                {

                    case SyntaxKind.DisabledTextTrivia:
                    case SyntaxKind.DocumentationCommentExteriorTrivia:
                    case SyntaxKind.EndOfLineTrivia:
                    case SyntaxKind.MultiLineCommentTrivia:
                    case SyntaxKind.SingleLineCommentTrivia:
                    case SyntaxKind.WhitespaceTrivia:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 10070, 10673);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 10458, 10574);

                        return f_10001_10465_10573(default(SyntaxToken), f_10001_10504_10566(kind, text, null, null), 0, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 10070, 10673);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 10070, 10673);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 10622, 10658);

                        throw f_10001_10628_10657("kind");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 10070, 10673);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 9849, 10684);

                System.ArgumentNullException
                f_10001_9999_10038(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 9999, 10038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10001_10504_10566(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                text, Microsoft.CodeAnalysis.DiagnosticInfo[]?
                diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]?
                annotations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia(kind, text, diagnostics, annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 10504, 10566);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_10465_10573(Microsoft.CodeAnalysis.SyntaxToken
                token, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                triviaNode, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTrivia(token, (Microsoft.CodeAnalysis.GreenNode)triviaNode, position, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 10465, 10573);
                    return return_v;
                }


                System.ArgumentException
                f_10001_10628_10657(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 10628, 10657);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 9849, 10684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 9849, 10684);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Token(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 11056, 11272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 11129, 11261);

                return f_10001_11136_11260(f_10001_11152_11259(f_10001_11194_11207().UnderlyingNode, kind, f_10001_11230_11243().UnderlyingNode));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 11056, 11272);

                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_11194_11207()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 11194, 11207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_11230_11243()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 11230, 11243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_11152_11259(Microsoft.CodeAnalysis.GreenNode?
                leading, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Token(leading, kind, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 11152, 11259);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_11136_11260(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 11136, 11260);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 11056, 11272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 11056, 11272);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Token(SyntaxTriviaList leading, SyntaxKind kind, SyntaxTriviaList trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 11796, 12034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 11922, 12023);

                return f_10001_11929_12022(f_10001_11945_12021(leading.Node, kind, trailing.Node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 11796, 12034);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_11945_12021(Microsoft.CodeAnalysis.GreenNode?
                leading, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Token(leading, kind, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 11945, 12021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_11929_12022(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 11929, 12022);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 11796, 12034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 11796, 12034);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Token(SyntaxTriviaList leading, SyntaxKind kind, string text, string valueText, SyntaxTriviaList trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 13011, 14213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 13168, 13852);

                switch (kind)
                {

                    case SyntaxKind.IdentifierToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 13168, 13852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 13325, 13406);

                        throw f_10001_13331_13405(f_10001_13353_13390(), nameof(kind));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 13168, 13852);

                    case SyntaxKind.CharacterLiteralToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 13168, 13852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 13543, 13622);

                        throw f_10001_13549_13621(f_10001_13571_13606(), nameof(kind));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 13168, 13852);

                    case SyntaxKind.NumericLiteralToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 13168, 13852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 13757, 13837);

                        throw f_10001_13763_13836(f_10001_13785_13821(), nameof(kind));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 13168, 13852);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 13868, 14068) || true) && (!f_10001_13873_13901(kind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 13868, 14068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 13935, 14053);

                    throw f_10001_13941_14052(f_10001_13963_14037(f_10001_13977_14030(), kind), nameof(kind));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 13868, 14068);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 14084, 14202);

                return f_10001_14091_14201(f_10001_14107_14200(leading.Node, kind, text, valueText, trailing.Node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 13011, 14213);

                string
                f_10001_13353_13390()
                {
                    var return_v = CSharpResources.UseVerbatimIdentifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 13353, 13390);
                    return return_v;
                }


                System.ArgumentException
                f_10001_13331_13405(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 13331, 13405);
                    return return_v;
                }


                string
                f_10001_13571_13606()
                {
                    var return_v = CSharpResources.UseLiteralForTokens;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 13571, 13606);
                    return return_v;
                }


                System.ArgumentException
                f_10001_13549_13621(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 13549, 13621);
                    return return_v;
                }


                string
                f_10001_13785_13821()
                {
                    var return_v = CSharpResources.UseLiteralForNumeric;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 13785, 13821);
                    return return_v;
                }


                System.ArgumentException
                f_10001_13763_13836(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 13763, 13836);
                    return return_v;
                }


                bool
                f_10001_13873_13901(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsAnyToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 13873, 13901);
                    return return_v;
                }


                string
                f_10001_13977_14030()
                {
                    var return_v = CSharpResources.ThisMethodCanOnlyBeUsedToCreateTokens;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 13977, 14030);
                    return return_v;
                }


                string
                f_10001_13963_14037(string
                format, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 13963, 14037);
                    return return_v;
                }


                System.ArgumentException
                f_10001_13941_14052(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 13941, 14052);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_14107_14200(Microsoft.CodeAnalysis.GreenNode?
                leading, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                text, string
                valueText, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Token(leading, kind, text, valueText, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 14107, 14200);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_14091_14201(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 14091, 14201);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 13011, 14213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 13011, 14213);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken MissingToken(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 14613, 14843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 14693, 14832);

                return f_10001_14700_14831(f_10001_14716_14830(f_10001_14765_14778().UnderlyingNode, kind, f_10001_14801_14814().UnderlyingNode));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 14613, 14843);

                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_14765_14778()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 14765, 14778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_14801_14814()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 14801, 14814);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_14716_14830(Microsoft.CodeAnalysis.GreenNode?
                leading, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.MissingToken(leading, kind, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 14716, 14830);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_14700_14831(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 14700, 14831);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 14613, 14843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 14613, 14843);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken MissingToken(SyntaxTriviaList leading, SyntaxKind kind, SyntaxTriviaList trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 15430, 15682);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 15563, 15671);

                return f_10001_15570_15670(f_10001_15586_15669(leading.Node, kind, trailing.Node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 15430, 15682);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_15586_15669(Microsoft.CodeAnalysis.GreenNode?
                leading, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.MissingToken(leading, kind, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 15586, 15669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_15570_15670(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 15570, 15670);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 15430, 15682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 15430, 15682);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Identifier(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 15965, 16187);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 16039, 16176);

                return f_10001_16046_16175(f_10001_16062_16174(f_10001_16109_16122().UnderlyingNode, text, f_10001_16145_16158().UnderlyingNode));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 15965, 16187);

                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_16109_16122()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 16109, 16122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_16145_16158()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 16145, 16158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_16062_16174(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Identifier(leading, text, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 16062, 16174);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_16046_16175(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 16046, 16175);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 15965, 16187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 15965, 16187);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Identifier(SyntaxTriviaList leading, string text, SyntaxTriviaList trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 16657, 16901);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 16784, 16890);

                return f_10001_16791_16889(f_10001_16807_16888(leading.Node, text, trailing.Node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 16657, 16901);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_16807_16888(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Identifier(leading, text, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 16807, 16888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_16791_16889(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 16791, 16889);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 16657, 16901);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 16657, 16901);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken VerbatimIdentifier(SyntaxTriviaList leading, string text, string valueText, SyntaxTriviaList trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 17485, 17988);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 17638, 17811) || true) && (f_10001_17642_17688(text, "@", StringComparison.Ordinal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 17638, 17811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 17722, 17796);

                    throw f_10001_17728_17795("text should not start with an @ character.");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 17638, 17811);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 17827, 17977);

                return f_10001_17834_17976(f_10001_17850_17975(SyntaxKind.IdentifierName, leading.Node, "@" + text, valueText, trailing.Node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 17485, 17988);

                bool
                f_10001_17642_17688(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 17642, 17688);
                    return return_v;
                }


                System.ArgumentException
                f_10001_17728_17795(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 17728, 17795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_17850_17975(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                contextualKind, Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, string
                valueText, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Identifier(contextualKind, leading, text, valueText, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 17850, 17975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_17834_17976(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 17834, 17976);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 17485, 17988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 17485, 17988);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Identifier(SyntaxTriviaList leading, SyntaxKind contextualKind, string text, string valueText, SyntaxTriviaList trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 18784, 19093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 18956, 19082);

                return f_10001_18963_19081(f_10001_18979_19080(contextualKind, leading.Node, text, valueText, trailing.Node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 18784, 19093);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_18979_19080(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                contextualKind, Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, string
                valueText, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = InternalSyntax.SyntaxFactory.Identifier(contextualKind, leading, text, valueText, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 18979, 19080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_18963_19081(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 18963, 19081);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 18784, 19093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 18784, 19093);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(int value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 19361, 19526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 19430, 19515);

                return f_10001_19437_19514(f_10001_19445_19506(value, ObjectDisplayOptions.None), value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 19361, 19526);

                string
                f_10001_19445_19506(int
                value, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = ObjectDisplay.FormatLiteral(value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 19445, 19506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_19437_19514(string
                text, int
                value)
                {
                    var return_v = Literal(text, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 19437, 19514);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 19361, 19526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 19361, 19526);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(string text, int value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 19888, 20122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 19970, 20111);

                return f_10001_19977_20110(f_10001_19993_20109(f_10001_20037_20050().UnderlyingNode, text, value, f_10001_20080_20093().UnderlyingNode));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 19888, 20122);

                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_20037_20050()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 20037, 20050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_20080_20093()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 20080, 20093);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_19993_20109(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, int
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 19993, 20109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_19977_20110(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 19977, 20110);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 19888, 20122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 19888, 20122);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(SyntaxTriviaList leading, string text, int value, SyntaxTriviaList trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 20671, 20927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 20806, 20916);

                return f_10001_20813_20915(f_10001_20829_20914(leading.Node, text, value, trailing.Node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 20671, 20927);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_20829_20914(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, int
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 20829, 20914);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_20813_20915(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 20813, 20915);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 20671, 20927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 20671, 20927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(uint value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 21199, 21378);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 21269, 21367);

                return f_10001_21276_21366(f_10001_21284_21358(value, ObjectDisplayOptions.IncludeTypeSuffix), value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 21199, 21378);

                string
                f_10001_21284_21358(uint
                value, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = ObjectDisplay.FormatLiteral(value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 21284, 21358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_21276_21366(string
                text, uint
                value)
                {
                    var return_v = Literal(text, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 21276, 21366);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 21199, 21378);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 21199, 21378);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(string text, uint value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 21744, 21979);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 21827, 21968);

                return f_10001_21834_21967(f_10001_21850_21966(f_10001_21894_21907().UnderlyingNode, text, value, f_10001_21937_21950().UnderlyingNode));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 21744, 21979);

                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_21894_21907()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 21894, 21907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_21937_21950()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 21937, 21950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_21850_21966(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, uint
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 21850, 21966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_21834_21967(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 21834, 21967);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 21744, 21979);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 21744, 21979);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(SyntaxTriviaList leading, string text, uint value, SyntaxTriviaList trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 22532, 22789);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 22668, 22778);

                return f_10001_22675_22777(f_10001_22691_22776(leading.Node, text, value, trailing.Node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 22532, 22789);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_22691_22776(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, uint
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 22691, 22776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_22675_22777(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 22675, 22777);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 22532, 22789);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 22532, 22789);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(long value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 23058, 23237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 23128, 23226);

                return f_10001_23135_23225(f_10001_23143_23217(value, ObjectDisplayOptions.IncludeTypeSuffix), value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 23058, 23237);

                string
                f_10001_23143_23217(long
                value, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = ObjectDisplay.FormatLiteral(value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 23143, 23217);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_23135_23225(string
                text, long
                value)
                {
                    var return_v = Literal(text, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 23135, 23225);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 23058, 23237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 23058, 23237);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(string text, long value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 23599, 23834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 23682, 23823);

                return f_10001_23689_23822(f_10001_23705_23821(f_10001_23749_23762().UnderlyingNode, text, value, f_10001_23792_23805().UnderlyingNode));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 23599, 23834);

                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_23749_23762()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 23749, 23762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_23792_23805()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 23792, 23805);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_23705_23821(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, long
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 23705, 23821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_23689_23822(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 23689, 23822);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 23599, 23834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 23599, 23834);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(SyntaxTriviaList leading, string text, long value, SyntaxTriviaList trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 24383, 24640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 24519, 24629);

                return f_10001_24526_24628(f_10001_24542_24627(leading.Node, text, value, trailing.Node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 24383, 24640);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_24542_24627(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, long
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 24542, 24627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_24526_24628(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 24526, 24628);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 24383, 24640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 24383, 24640);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(ulong value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 24913, 25093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 24984, 25082);

                return f_10001_24991_25081(f_10001_24999_25073(value, ObjectDisplayOptions.IncludeTypeSuffix), value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 24913, 25093);

                string
                f_10001_24999_25073(ulong
                value, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = ObjectDisplay.FormatLiteral(value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 24999, 25073);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_24991_25081(string
                text, ulong
                value)
                {
                    var return_v = Literal(text, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 24991, 25081);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 24913, 25093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 24913, 25093);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(string text, ulong value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 25459, 25695);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 25543, 25684);

                return f_10001_25550_25683(f_10001_25566_25682(f_10001_25610_25623().UnderlyingNode, text, value, f_10001_25653_25666().UnderlyingNode));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 25459, 25695);

                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_25610_25623()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 25610, 25623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_25653_25666()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 25653, 25666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_25566_25682(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, ulong
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 25566, 25682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_25550_25683(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 25550, 25683);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 25459, 25695);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 25459, 25695);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(SyntaxTriviaList leading, string text, ulong value, SyntaxTriviaList trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 26248, 26506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 26385, 26495);

                return f_10001_26392_26494(f_10001_26408_26493(leading.Node, text, value, trailing.Node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 26248, 26506);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_26408_26493(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, ulong
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 26408, 26493);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_26392_26494(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 26392, 26494);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 26248, 26506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 26248, 26506);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(float value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 26774, 26954);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 26845, 26943);

                return f_10001_26852_26942(f_10001_26860_26934(value, ObjectDisplayOptions.IncludeTypeSuffix), value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 26774, 26954);

                string
                f_10001_26860_26934(float
                value, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = ObjectDisplay.FormatLiteral(value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 26860, 26934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_26852_26942(string
                text, float
                value)
                {
                    var return_v = Literal(text, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 26852, 26942);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 26774, 26954);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 26774, 26954);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(string text, float value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 27316, 27552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 27400, 27541);

                return f_10001_27407_27540(f_10001_27423_27539(f_10001_27467_27480().UnderlyingNode, text, value, f_10001_27510_27523().UnderlyingNode));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 27316, 27552);

                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_27467_27480()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 27467, 27480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_27510_27523()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 27510, 27523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_27423_27539(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, float
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 27423, 27539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_27407_27540(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 27407, 27540);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 27316, 27552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 27316, 27552);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(SyntaxTriviaList leading, string text, float value, SyntaxTriviaList trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 28101, 28359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 28238, 28348);

                return f_10001_28245_28347(f_10001_28261_28346(leading.Node, text, value, trailing.Node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 28101, 28359);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_28261_28346(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, float
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 28261, 28346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_28245_28347(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 28245, 28347);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 28101, 28359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 28101, 28359);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(double value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 28628, 28796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 28700, 28785);

                return f_10001_28707_28784(f_10001_28715_28776(value, ObjectDisplayOptions.None), value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 28628, 28796);

                string
                f_10001_28715_28776(double
                value, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = ObjectDisplay.FormatLiteral(value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 28715, 28776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_28707_28784(string
                text, double
                value)
                {
                    var return_v = Literal(text, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 28707, 28784);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 28628, 28796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 28628, 28796);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(string text, double value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 29158, 29395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 29243, 29384);

                return f_10001_29250_29383(f_10001_29266_29382(f_10001_29310_29323().UnderlyingNode, text, value, f_10001_29353_29366().UnderlyingNode));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 29158, 29395);

                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_29310_29323()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 29310, 29323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_29353_29366()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 29353, 29366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_29266_29382(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, double
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 29266, 29382);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_29250_29383(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 29250, 29383);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 29158, 29395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 29158, 29395);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(SyntaxTriviaList leading, string text, double value, SyntaxTriviaList trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 29944, 30203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 30082, 30192);

                return f_10001_30089_30191(f_10001_30105_30190(leading.Node, text, value, trailing.Node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 29944, 30203);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_30105_30190(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, double
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 30105, 30190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_30089_30191(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 30089, 30191);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 29944, 30203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 29944, 30203);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(decimal value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 30443, 30625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 30516, 30614);

                return f_10001_30523_30613(f_10001_30531_30605(value, ObjectDisplayOptions.IncludeTypeSuffix), value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 30443, 30625);

                string
                f_10001_30531_30605(decimal
                value, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = ObjectDisplay.FormatLiteral(value, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 30531, 30605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_30523_30613(string
                text, decimal
                value)
                {
                    var return_v = Literal(text, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 30523, 30613);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 30443, 30625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 30443, 30625);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(string text, decimal value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 30959, 31197);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 31045, 31186);

                return f_10001_31052_31185(f_10001_31068_31184(f_10001_31112_31125().UnderlyingNode, text, value, f_10001_31155_31168().UnderlyingNode));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 30959, 31197);

                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_31112_31125()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 31112, 31125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_31155_31168()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 31155, 31168);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_31068_31184(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, decimal
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 31068, 31184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_31052_31185(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 31052, 31185);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 30959, 31197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 30959, 31197);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(SyntaxTriviaList leading, string text, decimal value, SyntaxTriviaList trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 31718, 31978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 31857, 31967);

                return f_10001_31864_31966(f_10001_31880_31965(leading.Node, text, value, trailing.Node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 31718, 31978);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_31880_31965(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, decimal
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 31880, 31965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_31864_31966(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 31864, 31966);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 31718, 31978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 31718, 31978);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 32215, 32369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 32287, 32358);

                return f_10001_32294_32357(f_10001_32302_32349(value, quote: true), value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 32215, 32369);

                string
                f_10001_32302_32349(string
                value, bool
                quote)
                {
                    var return_v = SymbolDisplay.FormatLiteral(value, quote: quote);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 32302, 32349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_32294_32357(string
                text, string
                value)
                {
                    var return_v = Literal(text, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 32294, 32357);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 32215, 32369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 32215, 32369);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(string text, string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 32739, 32976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 32824, 32965);

                return f_10001_32831_32964(f_10001_32847_32963(f_10001_32891_32904().UnderlyingNode, text, value, f_10001_32934_32947().UnderlyingNode));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 32739, 32976);

                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_32891_32904()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 32891, 32904);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_32934_32947()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 32934, 32947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_32847_32963(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, string
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 32847, 32963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_32831_32964(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 32831, 32964);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 32739, 32976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 32739, 32976);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(SyntaxTriviaList leading, string text, string value, SyntaxTriviaList trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 33533, 33792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 33671, 33781);

                return f_10001_33678_33780(f_10001_33694_33779(leading.Node, text, value, trailing.Node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 33533, 33792);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_33694_33779(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, string
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 33694, 33779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_33678_33780(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 33678, 33780);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 33533, 33792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 33533, 33792);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(char value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 34038, 34261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 34108, 34250);

                return f_10001_34115_34249(f_10001_34123_34241(value, ObjectDisplayOptions.UseQuotes | ObjectDisplayOptions.EscapeNonPrintableCharacters), value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 34038, 34261);

                string
                f_10001_34123_34241(char
                c, Microsoft.CodeAnalysis.ObjectDisplayOptions
                options)
                {
                    var return_v = ObjectDisplay.FormatLiteral(c, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 34123, 34241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_34115_34249(string
                text, char
                value)
                {
                    var return_v = Literal(text, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 34115, 34249);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 34038, 34261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 34038, 34261);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(string text, char value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 34640, 34875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 34723, 34864);

                return f_10001_34730_34863(f_10001_34746_34862(f_10001_34790_34803().UnderlyingNode, text, value, f_10001_34833_34846().UnderlyingNode));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 34640, 34875);

                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_34790_34803()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 34790, 34803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_34833_34846()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 34833, 34846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_34746_34862(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, char
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 34746, 34862);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_34730_34863(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 34730, 34863);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 34640, 34875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 34640, 34875);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Literal(SyntaxTriviaList leading, string text, char value, SyntaxTriviaList trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 35441, 35698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 35577, 35687);

                return f_10001_35584_35686(f_10001_35600_35685(leading.Node, text, value, trailing.Node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 35441, 35698);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_35600_35685(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, char
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 35600, 35685);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_35584_35686(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 35584, 35686);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 35441, 35698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 35441, 35698);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken BadToken(SyntaxTriviaList leading, string text, SyntaxTriviaList trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 36064, 36304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 36189, 36293);

                return f_10001_36196_36292(f_10001_36212_36291(leading.Node, text, trailing.Node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 36064, 36304);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_36212_36291(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.BadToken(leading, text, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 36212, 36291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_36196_36292(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 36196, 36292);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 36064, 36304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 36064, 36304);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken XmlTextLiteral(SyntaxTriviaList leading, string text, string value, SyntaxTriviaList trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 36740, 37013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 36885, 37002);

                return f_10001_36892_37001(f_10001_36908_37000(leading.Node, text, value, trailing.Node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 36740, 37013);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_36908_37000(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, string
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.XmlTextLiteral(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 36908, 37000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_36892_37001(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 36892, 37001);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 36740, 37013);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 36740, 37013);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken XmlEntity(SyntaxTriviaList leading, string text, string value, SyntaxTriviaList trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 37453, 37716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 37593, 37705);

                return f_10001_37600_37704(f_10001_37616_37703(leading.Node, text, value, trailing.Node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 37453, 37716);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_37616_37703(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, string
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.XmlEntity(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 37616, 37703);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_37600_37704(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 37600, 37704);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 37453, 37716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 37453, 37716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static DocumentationCommentTriviaSyntax DocumentationComment(params XmlNodeSyntax[] content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 38107, 38466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 38231, 38455);

                return f_10001_38238_38454(f_10001_38238_38402(f_10001_38238_38328(SyntaxKind.SingleLineDocumentationCommentTrivia, f_10001_38314_38327(content)), f_10001_38365_38401("/// ")), f_10001_38440_38453(""));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 38107, 38466);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                f_10001_38314_38327(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax[]
                nodes)
                {
                    var return_v = List((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>)nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 38314, 38327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax
                f_10001_38238_38328(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = DocumentationCommentTrivia(kind, content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 38238, 38328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_38365_38401(string
                text)
                {
                    var return_v = DocumentationCommentExterior(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 38365, 38401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax
                f_10001_38238_38402(Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax
                node, params Microsoft.CodeAnalysis.SyntaxTrivia[]
                trivia)
                {
                    var return_v = node.WithLeadingTrivia<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax>(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 38238, 38402);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_38440_38453(string
                text)
                {
                    var return_v = EndOfLine(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 38440, 38453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax
                f_10001_38238_38454(Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax
                node, params Microsoft.CodeAnalysis.SyntaxTrivia[]
                trivia)
                {
                    var return_v = node.WithTrailingTrivia<Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax>(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 38238, 38454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 38107, 38466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 38107, 38466);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlSummaryElement(params XmlNodeSyntax[] content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 38723, 38879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 38828, 38868);

                return f_10001_38835_38867(f_10001_38853_38866(content));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 38723, 38879);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                f_10001_38853_38866(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax[]
                nodes)
                {
                    var return_v = List((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>)nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 38853, 38866);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_38835_38867(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlSummaryElement(content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 38835, 38867);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 38723, 38879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 38723, 38879);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlSummaryElement(SyntaxList<XmlNodeSyntax> content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 39136, 39340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 39244, 39329);

                return f_10001_39251_39328(DocumentationCommentXmlNames.SummaryElementName, content);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 39136, 39340);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_39251_39328(string
                localName, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlMultiLineElement(localName, content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 39251, 39328);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 39136, 39340);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 39136, 39340);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlEmptyElementSyntax XmlSeeElement(CrefSyntax cref)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 39589, 39797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 39680, 39786);

                return f_10001_39687_39785(f_10001_39687_39747(DocumentationCommentXmlNames.SeeElementName), f_10001_39762_39784(cref));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 39589, 39797);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
                f_10001_39687_39747(string
                localName)
                {
                    var return_v = XmlEmptyElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 39687, 39747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax
                f_10001_39762_39784(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                cref)
                {
                    var return_v = XmlCrefAttribute(cref);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 39762, 39784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
                f_10001_39687_39785(Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
                this_param, params Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax[]
                items)
                {
                    var return_v = this_param.AddAttributes(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 39687, 39785);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 39589, 39797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 39589, 39797);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlEmptyElementSyntax XmlSeeAlsoElement(CrefSyntax cref)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 40050, 40266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 40145, 40255);

                return f_10001_40152_40254(f_10001_40152_40216(DocumentationCommentXmlNames.SeeAlsoElementName), f_10001_40231_40253(cref));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 40050, 40266);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
                f_10001_40152_40216(string
                localName)
                {
                    var return_v = XmlEmptyElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 40152, 40216);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax
                f_10001_40231_40253(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                cref)
                {
                    var return_v = XmlCrefAttribute(cref);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 40231, 40253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
                f_10001_40152_40254(Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
                this_param, params Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax[]
                items)
                {
                    var return_v = this_param.AddAttributes(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 40152, 40254);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 40050, 40266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 40050, 40266);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlSeeAlsoElement(Uri linkAddress, SyntaxList<XmlNodeSyntax> linkText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 40610, 41008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 40736, 40833);

                XmlElementSyntax
                element = f_10001_40763_40832(DocumentationCommentXmlNames.SeeAlsoElementName, linkText)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 40847, 40997);

                return f_10001_40854_40996(element, f_10001_40875_40995(f_10001_40875_40891(element), f_10001_40906_40994(DocumentationCommentXmlNames.CrefAttributeName, f_10001_40971_40993(linkAddress))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 40610, 41008);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_40763_40832(string
                localName, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlElement(localName, content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 40763, 40832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                f_10001_40875_40891(Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                this_param)
                {
                    var return_v = this_param.StartTag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 40875, 40891);
                    return return_v;
                }


                string
                f_10001_40971_40993(System.Uri
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 40971, 40993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax
                f_10001_40906_40994(string
                name, string
                value)
                {
                    var return_v = XmlTextAttribute(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 40906, 40994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                f_10001_40875_40995(Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                this_param, params Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax[]
                items)
                {
                    var return_v = this_param.AddAttributes(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 40875, 40995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_40854_40996(Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                startTag)
                {
                    var return_v = this_param.WithStartTag(startTag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 40854, 40996);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 40610, 41008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 40610, 41008);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlEmptyElementSyntax XmlThreadSafetyElement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 41148, 41287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 41233, 41276);

                return f_10001_41240_41275(true, false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 41148, 41287);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
                f_10001_41240_41275(bool
                isStatic, bool
                isInstance)
                {
                    var return_v = XmlThreadSafetyElement(isStatic, isInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 41240, 41275);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 41148, 41287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 41148, 41287);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlEmptyElementSyntax XmlThreadSafetyElement(bool isStatic, bool isInstance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 41690, 42162);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 41805, 42151);

                return f_10001_41812_42150(f_10001_41812_41881(DocumentationCommentXmlNames.ThreadSafetyElementName), f_10001_41914_42020(DocumentationCommentXmlNames.StaticAttributeName, f_10001_41981_42019(f_10001_41981_42000(isStatic))), f_10001_42039_42149(DocumentationCommentXmlNames.InstanceAttributeName, f_10001_42108_42148(f_10001_42108_42129(isInstance))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 41690, 42162);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
                f_10001_41812_41881(string
                localName)
                {
                    var return_v = XmlEmptyElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 41812, 41881);
                    return return_v;
                }


                string
                f_10001_41981_42000(bool
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 41981, 42000);
                    return return_v;
                }


                string
                f_10001_41981_42019(string
                this_param)
                {
                    var return_v = this_param.ToLowerInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 41981, 42019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax
                f_10001_41914_42020(string
                name, string
                value)
                {
                    var return_v = XmlTextAttribute(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 41914, 42020);
                    return return_v;
                }


                string
                f_10001_42108_42129(bool
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 42108, 42129);
                    return return_v;
                }


                string
                f_10001_42108_42148(string
                this_param)
                {
                    var return_v = this_param.ToLowerInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 42108, 42148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax
                f_10001_42039_42149(string
                name, string
                value)
                {
                    var return_v = XmlTextAttribute(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 42039, 42149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
                f_10001_41812_42150(Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
                this_param, params Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax[]
                items)
                {
                    var return_v = this_param.AddAttributes(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 41812, 42150);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 41690, 42162);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 41690, 42162);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlNameAttributeSyntax XmlNameAttribute(string parameterName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 42412, 42813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 42512, 42802);

                return f_10001_42519_42801(f_10001_42519_42748(f_10001_42554_42609(DocumentationCommentXmlNames.NameAttributeName), f_10001_42628_42662(SyntaxKind.DoubleQuoteToken), parameterName, f_10001_42713_42747(SyntaxKind.DoubleQuoteToken)), f_10001_42785_42800(" "));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 42412, 42813);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                f_10001_42554_42609(string
                localName)
                {
                    var return_v = XmlName(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 42554, 42609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_42628_42662(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 42628, 42662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_42713_42747(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 42713, 42747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                f_10001_42519_42748(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                name, Microsoft.CodeAnalysis.SyntaxToken
                startQuoteToken, string
                identifier, Microsoft.CodeAnalysis.SyntaxToken
                endQuoteToken)
                {
                    var return_v = XmlNameAttribute(name, startQuoteToken, identifier, endQuoteToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 42519, 42748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_42785_42800(string
                text)
                {
                    var return_v = Whitespace(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 42785, 42800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                f_10001_42519_42801(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                node, params Microsoft.CodeAnalysis.SyntaxTrivia[]
                trivia)
                {
                    var return_v = node.WithLeadingTrivia<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax>(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 42519, 42801);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 42412, 42813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 42412, 42813);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlEmptyElementSyntax XmlPreliminaryElement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 42969, 43140);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 43053, 43129);

                return f_10001_43060_43128(DocumentationCommentXmlNames.PreliminaryElementName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 42969, 43140);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
                f_10001_43060_43128(string
                localName)
                {
                    var return_v = XmlEmptyElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 43060, 43128);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 42969, 43140);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 42969, 43140);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlCrefAttributeSyntax XmlCrefAttribute(CrefSyntax cref)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 43400, 43565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 43495, 43554);

                return f_10001_43502_43553(cref, SyntaxKind.DoubleQuoteToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 43400, 43565);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax
                f_10001_43502_43553(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                cref, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                quoteKind)
                {
                    var return_v = XmlCrefAttribute(cref, quoteKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 43502, 43553);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 43400, 43565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 43400, 43565);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlCrefAttributeSyntax XmlCrefAttribute(CrefSyntax cref, SyntaxKind quoteKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 43939, 44402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 44056, 44132);

                cref = f_10001_44063_44131(cref, f_10001_44082_44105(cref), XmlReplaceBracketTokens);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 44146, 44391);

                return f_10001_44153_44390(f_10001_44153_44337(f_10001_44188_44243(DocumentationCommentXmlNames.CrefAttributeName), f_10001_44262_44278(quoteKind), cref, f_10001_44320_44336(quoteKind)), f_10001_44374_44389(" "));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 43939, 44402);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                f_10001_44082_44105(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                this_param)
                {
                    var return_v = this_param.DescendantTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 44082, 44105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                f_10001_44063_44131(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                root, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                tokens, System.Func<Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.SyntaxToken>
                computeReplacementToken)
                {
                    var return_v = root.ReplaceTokens<Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax>(tokens, computeReplacementToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 44063, 44131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                f_10001_44188_44243(string
                localName)
                {
                    var return_v = XmlName(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 44188, 44243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_44262_44278(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 44262, 44278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_44320_44336(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 44320, 44336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax
                f_10001_44153_44337(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                name, Microsoft.CodeAnalysis.SyntaxToken
                startQuoteToken, Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                cref, Microsoft.CodeAnalysis.SyntaxToken
                endQuoteToken)
                {
                    var return_v = XmlCrefAttribute(name, startQuoteToken, cref, endQuoteToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 44153, 44337);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_44374_44389(string
                text)
                {
                    var return_v = Whitespace(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 44374, 44389);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax
                f_10001_44153_44390(Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax
                node, params Microsoft.CodeAnalysis.SyntaxTrivia[]
                trivia)
                {
                    var return_v = node.WithLeadingTrivia<Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax>(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 44153, 44390);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 43939, 44402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 43939, 44402);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlRemarksElement(params XmlNodeSyntax[] content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 44659, 44815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 44764, 44804);

                return f_10001_44771_44803(f_10001_44789_44802(content));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 44659, 44815);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                f_10001_44789_44802(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax[]
                nodes)
                {
                    var return_v = List((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>)nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 44789, 44802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_44771_44803(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlRemarksElement(content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 44771, 44803);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 44659, 44815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 44659, 44815);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlRemarksElement(SyntaxList<XmlNodeSyntax> content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 45072, 45276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 45180, 45265);

                return f_10001_45187_45264(DocumentationCommentXmlNames.RemarksElementName, content);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 45072, 45276);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_45187_45264(string
                localName, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlMultiLineElement(localName, content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 45187, 45264);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 45072, 45276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 45072, 45276);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlReturnsElement(params XmlNodeSyntax[] content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 45533, 45689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 45638, 45678);

                return f_10001_45645_45677(f_10001_45663_45676(content));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 45533, 45689);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                f_10001_45663_45676(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax[]
                nodes)
                {
                    var return_v = List((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>)nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 45663, 45676);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_45645_45677(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlReturnsElement(content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 45645, 45677);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 45533, 45689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 45533, 45689);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlReturnsElement(SyntaxList<XmlNodeSyntax> content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 45946, 46150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 46054, 46139);

                return f_10001_46061_46138(DocumentationCommentXmlNames.ReturnsElementName, content);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 45946, 46150);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_46061_46138(string
                localName, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlMultiLineElement(localName, content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 46061, 46138);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 45946, 46150);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 45946, 46150);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlValueElement(params XmlNodeSyntax[] content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 46439, 46591);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 46542, 46580);

                return f_10001_46549_46579(f_10001_46565_46578(content));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 46439, 46591);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                f_10001_46565_46578(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax[]
                nodes)
                {
                    var return_v = List((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>)nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 46565, 46578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_46549_46579(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlValueElement(content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 46549, 46579);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 46439, 46591);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 46439, 46591);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlValueElement(SyntaxList<XmlNodeSyntax> content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 46880, 47080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 46986, 47069);

                return f_10001_46993_47068(DocumentationCommentXmlNames.ValueElementName, content);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 46880, 47080);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_46993_47068(string
                localName, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlMultiLineElement(localName, content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 46993, 47068);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 46880, 47080);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 46880, 47080);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlExceptionElement(CrefSyntax cref, params XmlNodeSyntax[] content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 47467, 47650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 47591, 47639);

                return f_10001_47598_47638(cref, f_10001_47624_47637(content));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 47467, 47650);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                f_10001_47624_47637(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax[]
                nodes)
                {
                    var return_v = List((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>)nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 47624, 47637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_47598_47638(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                cref, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlExceptionElement(cref, content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 47598, 47638);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 47467, 47650);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 47467, 47650);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlExceptionElement(CrefSyntax cref, SyntaxList<XmlNodeSyntax> content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 48037, 48371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 48164, 48262);

                XmlElementSyntax
                element = f_10001_48191_48261(DocumentationCommentXmlNames.ExceptionElementName, content)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 48276, 48360);

                return f_10001_48283_48359(element, f_10001_48304_48358(f_10001_48304_48320(element), f_10001_48335_48357(cref)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 48037, 48371);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_48191_48261(string
                localName, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlElement(localName, content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 48191, 48261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                f_10001_48304_48320(Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                this_param)
                {
                    var return_v = this_param.StartTag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 48304, 48320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax
                f_10001_48335_48357(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                cref)
                {
                    var return_v = XmlCrefAttribute(cref);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 48335, 48357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                f_10001_48304_48358(Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                this_param, params Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax[]
                items)
                {
                    var return_v = this_param.AddAttributes(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 48304, 48358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_48283_48359(Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                startTag)
                {
                    var return_v = this_param.WithStartTag(startTag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 48283, 48359);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 48037, 48371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 48037, 48371);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlPermissionElement(CrefSyntax cref, params XmlNodeSyntax[] content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 48760, 48945);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 48885, 48934);

                return f_10001_48892_48933(cref, f_10001_48919_48932(content));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 48760, 48945);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                f_10001_48919_48932(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax[]
                nodes)
                {
                    var return_v = List((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>)nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 48919, 48932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_48892_48933(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                cref, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlPermissionElement(cref, content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 48892, 48933);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 48760, 48945);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 48760, 48945);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlPermissionElement(CrefSyntax cref, SyntaxList<XmlNodeSyntax> content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 49334, 49670);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 49462, 49561);

                XmlElementSyntax
                element = f_10001_49489_49560(DocumentationCommentXmlNames.PermissionElementName, content)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 49575, 49659);

                return f_10001_49582_49658(element, f_10001_49603_49657(f_10001_49603_49619(element), f_10001_49634_49656(cref)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 49334, 49670);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_49489_49560(string
                localName, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlElement(localName, content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 49489, 49560);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                f_10001_49603_49619(Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                this_param)
                {
                    var return_v = this_param.StartTag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 49603, 49619);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax
                f_10001_49634_49656(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                cref)
                {
                    var return_v = XmlCrefAttribute(cref);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 49634, 49656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                f_10001_49603_49657(Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                this_param, params Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax[]
                items)
                {
                    var return_v = this_param.AddAttributes(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 49603, 49657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_49582_49658(Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                startTag)
                {
                    var return_v = this_param.WithStartTag(startTag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 49582, 49658);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 49334, 49670);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 49334, 49670);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlExampleElement(params XmlNodeSyntax[] content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 49951, 50107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 50056, 50096);

                return f_10001_50063_50095(f_10001_50081_50094(content));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 49951, 50107);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                f_10001_50081_50094(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax[]
                nodes)
                {
                    var return_v = List((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>)nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 50081, 50094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_50063_50095(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlExampleElement(content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 50063, 50095);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 49951, 50107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 49951, 50107);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlExampleElement(SyntaxList<XmlNodeSyntax> content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 50388, 50663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 50496, 50592);

                XmlElementSyntax
                element = f_10001_50523_50591(DocumentationCommentXmlNames.ExampleElementName, content)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 50606, 50652);

                return f_10001_50613_50651(element, f_10001_50634_50650(element));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 50388, 50663);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_50523_50591(string
                localName, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlElement(localName, content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 50523, 50591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                f_10001_50634_50650(Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                this_param)
                {
                    var return_v = this_param.StartTag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 50634, 50650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_50613_50651(Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                startTag)
                {
                    var return_v = this_param.WithStartTag(startTag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 50613, 50651);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 50388, 50663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 50388, 50663);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlParaElement(params XmlNodeSyntax[] content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 50937, 51087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 51039, 51076);

                return f_10001_51046_51075(f_10001_51061_51074(content));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 50937, 51087);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                f_10001_51061_51074(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax[]
                nodes)
                {
                    var return_v = List((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>)nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 51061, 51074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_51046_51075(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlParaElement(content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 51046, 51075);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 50937, 51087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 50937, 51087);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlParaElement(SyntaxList<XmlNodeSyntax> content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 51361, 51550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 51466, 51539);

                return f_10001_51473_51538(DocumentationCommentXmlNames.ParaElementName, content);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 51361, 51550);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_51473_51538(string
                localName, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlElement(localName, content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 51473, 51538);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 51361, 51550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 51361, 51550);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlParamElement(string parameterName, params XmlNodeSyntax[] content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 52027, 52216);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 52152, 52205);

                return f_10001_52159_52204(parameterName, f_10001_52190_52203(content));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 52027, 52216);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                f_10001_52190_52203(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax[]
                nodes)
                {
                    var return_v = List((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>)nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 52190, 52203);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_52159_52204(string
                parameterName, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlParamElement(parameterName, content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 52159, 52204);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 52027, 52216);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 52027, 52216);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlParamElement(string parameterName, SyntaxList<XmlNodeSyntax> content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 52693, 53037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 52821, 52919);

                XmlElementSyntax
                element = f_10001_52848_52918(DocumentationCommentXmlNames.ParameterElementName, content)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 52933, 53026);

                return f_10001_52940_53025(element, f_10001_52961_53024(f_10001_52961_52977(element), f_10001_52992_53023(parameterName)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 52693, 53037);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_52848_52918(string
                localName, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlElement(localName, content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 52848, 52918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                f_10001_52961_52977(Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                this_param)
                {
                    var return_v = this_param.StartTag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 52961, 52977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                f_10001_52992_53023(string
                parameterName)
                {
                    var return_v = XmlNameAttribute(parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 52992, 53023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                f_10001_52961_53024(Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                this_param, params Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax[]
                items)
                {
                    var return_v = this_param.AddAttributes(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 52961, 53024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_52940_53025(Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                startTag)
                {
                    var return_v = this_param.WithStartTag(startTag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 52940, 53025);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 52693, 53037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 52693, 53037);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlEmptyElementSyntax XmlParamRefElement(string parameterName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 53357, 53599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 53458, 53588);

                return f_10001_53465_53587(f_10001_53465_53540(DocumentationCommentXmlNames.ParameterReferenceElementName), f_10001_53555_53586(parameterName));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 53357, 53599);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
                f_10001_53465_53540(string
                localName)
                {
                    var return_v = XmlEmptyElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 53465, 53540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                f_10001_53555_53586(string
                parameterName)
                {
                    var return_v = XmlNameAttribute(parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 53555, 53586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
                f_10001_53465_53587(Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
                this_param, params Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax[]
                items)
                {
                    var return_v = this_param.AddAttributes(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 53465, 53587);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 53357, 53599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 53357, 53599);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlEmptyElementSyntax XmlNullKeywordElement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 53814, 53942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 53898, 53931);

                return f_10001_53905_53930("null");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 53814, 53942);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
                f_10001_53905_53930(string
                keyword)
                {
                    var return_v = XmlKeywordElement(keyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 53905, 53930);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 53814, 53942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 53814, 53942);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static XmlEmptyElementSyntax XmlKeywordElement(string keyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 54248, 54533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 54343, 54522);

                return f_10001_54350_54521(f_10001_54350_54410(DocumentationCommentXmlNames.SeeElementName), f_10001_54443_54520(DocumentationCommentXmlNames.LangwordAttributeName, keyword));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 54248, 54533);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
                f_10001_54350_54410(string
                localName)
                {
                    var return_v = XmlEmptyElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 54350, 54410);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax
                f_10001_54443_54520(string
                name, string
                value)
                {
                    var return_v = XmlTextAttribute(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 54443, 54520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
                f_10001_54350_54521(Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
                this_param, params Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax[]
                items)
                {
                    var return_v = this_param.AddAttributes(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 54350, 54521);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 54248, 54533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 54248, 54533);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlPlaceholderElement(params XmlNodeSyntax[] content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 54821, 54985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 54930, 54974);

                return f_10001_54937_54973(f_10001_54959_54972(content));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 54821, 54985);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                f_10001_54959_54972(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax[]
                nodes)
                {
                    var return_v = List((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>)nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 54959, 54972);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_54937_54973(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlPlaceholderElement(content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 54937, 54973);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 54821, 54985);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 54821, 54985);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlPlaceholderElement(SyntaxList<XmlNodeSyntax> content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 55273, 55476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 55385, 55465);

                return f_10001_55392_55464(DocumentationCommentXmlNames.PlaceholderElementName, content);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 55273, 55476);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_55392_55464(string
                localName, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlElement(localName, content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 55392, 55464);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 55273, 55476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 55273, 55476);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlEmptyElementSyntax XmlEmptyElement(string localName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 55726, 55874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 55820, 55863);

                return f_10001_55827_55862(f_10001_55843_55861(localName));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 55726, 55874);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                f_10001_55843_55861(string
                localName)
                {
                    var return_v = XmlName(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 55843, 55861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
                f_10001_55827_55862(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                name)
                {
                    var return_v = XmlEmptyElement(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 55827, 55862);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 55726, 55874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 55726, 55874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlElement(string localName, SyntaxList<XmlNodeSyntax> content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 56232, 56409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 56351, 56398);

                return f_10001_56358_56397(f_10001_56369_56387(localName), content);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 56232, 56409);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                f_10001_56369_56387(string
                localName)
                {
                    var return_v = XmlName(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 56369, 56387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_56358_56397(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                name, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlElement(name, content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 56358, 56397);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 56232, 56409);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 56232, 56409);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlElement(XmlNameSyntax name, SyntaxList<XmlNodeSyntax> content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 56762, 57023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 56883, 57012);

                return f_10001_56890_57011(f_10001_56919_56943(name), content, f_10001_56988_57010(name));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 56762, 57023);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                f_10001_56919_56943(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                name)
                {
                    var return_v = XmlElementStartTag(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 56919, 56943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax
                f_10001_56988_57010(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                name)
                {
                    var return_v = XmlElementEndTag(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 56988, 57010);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_56890_57011(Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                startTag, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content, Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax
                endTag)
                {
                    var return_v = XmlElement(startTag, content, endTag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 56890, 57011);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 56762, 57023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 56762, 57023);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlTextAttributeSyntax XmlTextAttribute(string name, string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 57309, 57478);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 57414, 57467);

                return f_10001_57421_57466(name, f_10001_57444_57465(value));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 57309, 57478);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_57444_57465(string
                value)
                {
                    var return_v = XmlTextLiteral(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 57444, 57465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax
                f_10001_57421_57466(string
                name, params Microsoft.CodeAnalysis.SyntaxToken[]
                textTokens)
                {
                    var return_v = XmlTextAttribute(name, textTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 57421, 57466);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 57309, 57478);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 57309, 57478);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlTextAttributeSyntax XmlTextAttribute(string name, params SyntaxToken[] textTokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 57795, 58021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 57919, 58010);

                return f_10001_57926_58009(f_10001_57943_57956(name), SyntaxKind.DoubleQuoteToken, f_10001_57987_58008(textTokens));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 57795, 58021);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                f_10001_57943_57956(string
                localName)
                {
                    var return_v = XmlName(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 57943, 57956);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10001_57987_58008(params Microsoft.CodeAnalysis.SyntaxToken[]
                tokens)
                {
                    var return_v = TokenList(tokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 57987, 58008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax
                f_10001_57926_58009(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                name, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                quoteKind, Microsoft.CodeAnalysis.SyntaxTokenList
                textTokens)
                {
                    var return_v = XmlTextAttribute(name, quoteKind, textTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 57926, 58009);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 57795, 58021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 57795, 58021);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlTextAttributeSyntax XmlTextAttribute(string name, SyntaxKind quoteKind, SyntaxTokenList textTokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 58456, 58670);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 58597, 58659);

                return f_10001_58604_58658(f_10001_58621_58634(name), quoteKind, textTokens);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 58456, 58670);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                f_10001_58621_58634(string
                localName)
                {
                    var return_v = XmlName(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 58621, 58634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax
                f_10001_58604_58658(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                name, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                quoteKind, Microsoft.CodeAnalysis.SyntaxTokenList
                textTokens)
                {
                    var return_v = XmlTextAttribute(name, quoteKind, textTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 58604, 58658);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 58456, 58670);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 58456, 58670);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlTextAttributeSyntax XmlTextAttribute(XmlNameSyntax name, SyntaxKind quoteKind, SyntaxTokenList textTokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 59105, 59395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 59253, 59384);

                return f_10001_59260_59383(f_10001_59260_59330(name, f_10001_59283_59299(quoteKind), textTokens, f_10001_59313_59329(quoteKind)), f_10001_59367_59382(" "));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 59105, 59395);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_59283_59299(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 59283, 59299);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_59313_59329(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 59313, 59329);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax
                f_10001_59260_59330(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                name, Microsoft.CodeAnalysis.SyntaxToken
                startQuoteToken, Microsoft.CodeAnalysis.SyntaxTokenList
                textTokens, Microsoft.CodeAnalysis.SyntaxToken
                endQuoteToken)
                {
                    var return_v = XmlTextAttribute(name, startQuoteToken, textTokens, endQuoteToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 59260, 59330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_59367_59382(string
                text)
                {
                    var return_v = Whitespace(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 59367, 59382);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax
                f_10001_59260_59383(Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax
                node, params Microsoft.CodeAnalysis.SyntaxTrivia[]
                trivia)
                {
                    var return_v = node.WithLeadingTrivia<Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextAttributeSyntax>(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 59260, 59383);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 59105, 59395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 59105, 59395);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlMultiLineElement(string localName, SyntaxList<XmlNodeSyntax> content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 59750, 59945);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 59878, 59934);

                return f_10001_59885_59933(f_10001_59905_59923(localName), content);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 59750, 59945);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                f_10001_59905_59923(string
                localName)
                {
                    var return_v = XmlName(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 59905, 59923);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_59885_59933(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                name, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content)
                {
                    var return_v = XmlMultiLineElement(name, content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 59885, 59933);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 59750, 59945);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 59750, 59945);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlElementSyntax XmlMultiLineElement(XmlNameSyntax name, SyntaxList<XmlNodeSyntax> content)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 60295, 60565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 60425, 60554);

                return f_10001_60432_60553(f_10001_60461_60485(name), content, f_10001_60530_60552(name));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 60295, 60565);

                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                f_10001_60461_60485(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                name)
                {
                    var return_v = XmlElementStartTag(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 60461, 60485);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax
                f_10001_60530_60552(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
                name)
                {
                    var return_v = XmlElementEndTag(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 60530, 60552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementSyntax
                f_10001_60432_60553(Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
                startTag, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                content, Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementEndTagSyntax
                endTag)
                {
                    var return_v = XmlElement(startTag, content, endTag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 60432, 60553);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 60295, 60565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 60295, 60565);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlTextSyntax XmlNewLine(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 60895, 61019);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 60971, 61008);

                return f_10001_60978_61007(f_10001_60986_61006(text));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 60895, 61019);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_60986_61006(string
                text)
                {
                    var return_v = XmlTextNewLine(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 60986, 61006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextSyntax
                f_10001_60978_61007(params Microsoft.CodeAnalysis.SyntaxToken[]
                textTokens)
                {
                    var return_v = XmlText(textTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 60978, 61007);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 60895, 61019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 60895, 61019);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken XmlTextNewLine(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 61328, 61451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 61406, 61440);

                return f_10001_61413_61439(text, true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 61328, 61451);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_61413_61439(string
                text, bool
                continueXmlDocumentationComment)
                {
                    var return_v = XmlTextNewLine(text, continueXmlDocumentationComment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 61413, 61439);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 61328, 61451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 61328, 61451);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken XmlTextNewLine(SyntaxTriviaList leading, string text, string value, SyntaxTriviaList trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 61903, 62272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 62048, 62261);

                return f_10001_62055_62260(f_10001_62089_62259(leading.Node, text, value, trailing.Node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 61903, 62272);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_62089_62259(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, string
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = InternalSyntax.SyntaxFactory.XmlTextNewLine(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 62089, 62259);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_62055_62260(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 62055, 62260);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 61903, 62272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 61903, 62272);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken XmlTextNewLine(string text, bool continueXmlDocumentationComment)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 62712, 63283);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 62828, 63076);

                var
                token = f_10001_62840_63075(f_10001_62874_63074(f_10001_62940_62953().UnderlyingNode, text, text, f_10001_63045_63058().UnderlyingNode))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 63092, 63243) || true) && (continueXmlDocumentationComment)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 63092, 63243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 63146, 63243);

                    token = token.WithTrailingTrivia(token.TrailingTrivia.Add(f_10001_63204_63240("/// ")));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 63092, 63243);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 63259, 63272);

                return token;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 62712, 63283);

                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_62940_62953()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 62940, 62953);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_63045_63058()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 63045, 63058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_62874_63074(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, string
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = InternalSyntax.SyntaxFactory.XmlTextNewLine(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 62874, 63074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_62840_63075(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 62840, 63075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_63204_63240(string
                text)
                {
                    var return_v = DocumentationCommentExterior(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 63204, 63240);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 62712, 63283);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 62712, 63283);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlTextSyntax XmlText(string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 63548, 63671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 63622, 63660);

                return f_10001_63629_63659(f_10001_63637_63658(value));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 63548, 63671);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_63637_63658(string
                value)
                {
                    var return_v = XmlTextLiteral(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 63637, 63658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextSyntax
                f_10001_63629_63659(params Microsoft.CodeAnalysis.SyntaxToken[]
                textTokens)
                {
                    var return_v = XmlText(textTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 63629, 63659);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 63548, 63671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 63548, 63671);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static XmlTextSyntax XmlText(params SyntaxToken[] textTokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 63944, 64086);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 64037, 64075);

                return f_10001_64044_64074(f_10001_64052_64073(textTokens));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 63944, 64086);

                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10001_64052_64073(params Microsoft.CodeAnalysis.SyntaxToken[]
                tokens)
                {
                    var return_v = TokenList(tokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 64052, 64073);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.XmlTextSyntax
                f_10001_64044_64074(Microsoft.CodeAnalysis.SyntaxTokenList
                textTokens)
                {
                    var return_v = XmlText(textTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 64044, 64074);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 63944, 64086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 63944, 64086);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken XmlTextLiteral(string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 64302, 64899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 64692, 64737);

                string
                encoded = f_10001_64709_64736(f_10001_64709_64725(value))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 64753, 64888);

                return f_10001_64760_64887(f_10001_64793_64805(), encoded, value, f_10001_64874_64886());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 64302, 64899);

                System.Xml.Linq.XText
                f_10001_64709_64725(string
                value)
                {
                    var return_v = new System.Xml.Linq.XText(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 64709, 64725);
                    return return_v;
                }


                string
                f_10001_64709_64736(System.Xml.Linq.XText
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 64709, 64736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10001_64793_64805()
                {
                    var return_v = TriviaList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 64793, 64805);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10001_64874_64886()
                {
                    var return_v = TriviaList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 64874, 64886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_64760_64887(Microsoft.CodeAnalysis.SyntaxTriviaList
                leading, string
                text, string
                value, Microsoft.CodeAnalysis.SyntaxTriviaList
                trailing)
                {
                    var return_v = XmlTextLiteral(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 64760, 64887);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 64302, 64899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 64302, 64899);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken XmlTextLiteral(string text, string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 65184, 65435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 65276, 65424);

                return f_10001_65283_65423(f_10001_65299_65422(f_10001_65350_65363().UnderlyingNode, text, value, f_10001_65393_65406().UnderlyingNode));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 65184, 65435);

                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_65350_65363()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 65350, 65363);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_65393_65406()
                {
                    var return_v = ElasticMarker;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 65393, 65406);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_65299_65422(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, string
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.XmlTextLiteral(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 65299, 65422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_65283_65423(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 65283, 65423);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 65184, 65435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 65184, 65435);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SyntaxToken XmlReplaceBracketTokens(SyntaxToken originalToken, SyntaxToken rewrittenToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 65846, 66587);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 65976, 66246) || true) && (rewrittenToken.IsKind(SyntaxKind.LessThanToken) && (DynAbs.Tracing.TraceSender.Expression_True(10001, 65980, 66096) && f_10001_66031_66096("<", rewrittenToken.Text, StringComparison.Ordinal)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 65976, 66246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 66115, 66246);

                    return f_10001_66122_66245(rewrittenToken.LeadingTrivia, SyntaxKind.LessThanToken, "{", rewrittenToken.ValueText, rewrittenToken.TrailingTrivia);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 65976, 66246);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 66262, 66538) || true) && (rewrittenToken.IsKind(SyntaxKind.GreaterThanToken) && (DynAbs.Tracing.TraceSender.Expression_True(10001, 66266, 66385) && f_10001_66320_66385(">", rewrittenToken.Text, StringComparison.Ordinal)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 66262, 66538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 66404, 66538);

                    return f_10001_66411_66537(rewrittenToken.LeadingTrivia, SyntaxKind.GreaterThanToken, "}", rewrittenToken.ValueText, rewrittenToken.TrailingTrivia);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 66262, 66538);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 66554, 66576);

                return rewrittenToken;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 65846, 66587);

                bool
                f_10001_66031_66096(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 66031, 66096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_66122_66245(Microsoft.CodeAnalysis.SyntaxTriviaList
                leading, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                text, string
                valueText, Microsoft.CodeAnalysis.SyntaxTriviaList
                trailing)
                {
                    var return_v = Token(leading, kind, text, valueText, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 66122, 66245);
                    return return_v;
                }


                bool
                f_10001_66320_66385(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 66320, 66385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_66411_66537(Microsoft.CodeAnalysis.SyntaxTriviaList
                leading, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                text, string
                valueText, Microsoft.CodeAnalysis.SyntaxTriviaList
                trailing)
                {
                    var return_v = Token(leading, kind, text, valueText, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 66411, 66537);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 65846, 66587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 65846, 66587);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTrivia DocumentationCommentExterior(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 66791, 66979);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 66884, 66968);

                return f_10001_66891_66967(text);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 66791, 66979);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10001_66891_66967(string
                text)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxFactory.DocumentationCommentExteriorTrivia(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 66891, 66967);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 66791, 66979);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 66791, 66979);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxList<TNode> List<TNode>() where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 67179, 67319);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 67274, 67308);

                return default(SyntaxList<TNode>);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 67179, 67319);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 67179, 67319);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 67179, 67319);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxList<TNode> SingletonList<TNode>(TNode node) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 67620, 67780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 67734, 67769);

                return f_10001_67741_67768<TNode>(node);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 67620, 67780);

                Microsoft.CodeAnalysis.SyntaxList<TNode>
                f_10001_67741_67768<TNode>(TNode
                node) where TNode : SyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxList<TNode>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 67741, 67768);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 67620, 67780);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 67620, 67780);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxList<TNode> List<TNode>(IEnumerable<TNode> nodes) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 68043, 68209);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 68162, 68198);

                return f_10001_68169_68197<TNode>(nodes);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 68043, 68209);

                Microsoft.CodeAnalysis.SyntaxList<TNode>
                f_10001_68169_68197<TNode>(System.Collections.Generic.IEnumerable<TNode>
                nodes) where TNode : SyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxList<TNode>(nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 68169, 68197);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 68043, 68209);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 68043, 68209);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTokenList TokenList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 68314, 68423);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 68380, 68412);

                return default(SyntaxTokenList);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 68314, 68423);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 68314, 68423);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 68314, 68423);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTokenList TokenList(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 68590, 68718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 68673, 68707);

                return f_10001_68680_68706(token);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 68590, 68718);

                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10001_68680_68706(Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 68680, 68706);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 68590, 68718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 68590, 68718);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTokenList TokenList(params SyntaxToken[] tokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 68878, 69017);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 68971, 69006);

                return f_10001_68978_69005(tokens);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 68878, 69017);

                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10001_68978_69005(params Microsoft.CodeAnalysis.SyntaxToken[]
                tokens)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList(tokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 68978, 69005);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 68878, 69017);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 68878, 69017);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTokenList TokenList(IEnumerable<SyntaxToken> tokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 69191, 69334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 69288, 69323);

                return f_10001_69295_69322(tokens);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 69191, 69334);

                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10001_69295_69322(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                tokens)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList(tokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 69295, 69322);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 69191, 69334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 69191, 69334);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTrivia Trivia(StructuredTriviaSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 69459, 69638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 69546, 69627);

                return f_10001_69553_69626(default(SyntaxToken), f_10001_69592_69602(node), position: 0, index: 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 69459, 69638);

                Microsoft.CodeAnalysis.GreenNode
                f_10001_69592_69602(Microsoft.CodeAnalysis.CSharp.Syntax.StructuredTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 69592, 69602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10001_69553_69626(Microsoft.CodeAnalysis.SyntaxToken
                token, Microsoft.CodeAnalysis.GreenNode
                triviaNode, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTrivia(token, triviaNode, position: position, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 69553, 69626);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 69459, 69638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 69459, 69638);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTriviaList TriviaList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 69743, 69855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 69811, 69844);

                return default(SyntaxTriviaList);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 69743, 69855);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 69743, 69855);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 69743, 69855);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTriviaList TriviaList(SyntaxTrivia trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 70022, 70156);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 70109, 70145);

                return f_10001_70116_70144(trivia);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 70022, 70156);

                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10001_70116_70144(Microsoft.CodeAnalysis.SyntaxTrivia
                trivia)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 70116, 70144);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 70022, 70156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 70022, 70156);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTriviaList TriviaList(params SyntaxTrivia[] trivias)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10001, 70403, 70435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 70406, 70435);
                return f_10001_70406_70435(trivias); DynAbs.Tracing.TraceSender.TraceExitMethod(10001, 70403, 70435);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 70403, 70435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 70403, 70435);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTriviaList TriviaList(IEnumerable<SyntaxTrivia> trivias)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10001, 70689, 70721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 70692, 70721);
                return f_10001_70692_70721(trivias); DynAbs.Tracing.TraceSender.TraceExitMethod(10001, 70689, 70721);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 70689, 70721);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 70689, 70721);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SeparatedSyntaxList<TNode> SeparatedList<TNode>() where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 70916, 71083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 71029, 71072);

                return default(SeparatedSyntaxList<TNode>);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 70916, 71083);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 70916, 71083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 70916, 71083);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SeparatedSyntaxList<TNode> SingletonSeparatedList<TNode>(TNode node) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 71335, 71559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 71467, 71548);

                return f_10001_71474_71547<TNode>(f_10001_71505_71546<TNode>(node, index: 0));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 71335, 71559);

                Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                f_10001_71505_71546<TNode>(TNode
                node, int
                index) where TNode : SyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxNodeOrTokenList((Microsoft.CodeAnalysis.SyntaxNode)node, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 71505, 71546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>
                f_10001_71474_71547<TNode>(Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                list) where TNode : SyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 71474, 71547);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 71335, 71559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 71335, 71559);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SeparatedSyntaxList<TNode> SeparatedList<TNode>(IEnumerable<TNode>? nodes) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 71891, 73300);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 72029, 72138) || true) && (nodes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 72029, 72138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 72080, 72123);

                    return default(SeparatedSyntaxList<TNode>);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 72029, 72138);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 72154, 72199);

                var
                collection = nodes as ICollection<TNode>
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 72215, 72354) || true) && (collection != null && (DynAbs.Tracing.TraceSender.Expression_True(10001, 72219, 72262) && f_10001_72241_72257<TNode>(collection) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 72215, 72354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 72296, 72339);

                    return default(SeparatedSyntaxList<TNode>);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 72215, 72354);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 72370, 73289);
                using (var
                enumerator = f_10001_72394_72415<TNode>(nodes)
                )
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 72449, 72579) || true) && (!f_10001_72454_72475<TNode>(enumerator))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 72449, 72579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 72517, 72560);

                        return default(SeparatedSyntaxList<TNode>);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 72449, 72579);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 72599, 72634);

                    var
                    firstNode = f_10001_72615_72633<TNode>(enumerator)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 72654, 72789) || true) && (!f_10001_72659_72680<TNode>(enumerator))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 72654, 72789);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 72722, 72770);

                        return f_10001_72729_72769<TNode>(firstNode);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 72654, 72789);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 72809, 72904);

                    var
                    builder = f_10001_72823_72903<TNode>((DynAbs.Tracing.TraceSender.Conditional_F1(10001, 72861, 72879) || ((collection != null && DynAbs.Tracing.TraceSender.Conditional_F2(10001, 72882, 72898)) || DynAbs.Tracing.TraceSender.Conditional_F3(10001, 72901, 72902))) ? f_10001_72882_72898<TNode>(collection) : 3)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 72924, 72947);

                    builder.Add(firstNode);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 72967, 73013);

                    var
                    commaToken = f_10001_72984_73012<TNode>(SyntaxKind.CommaToken)
                    ;
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 73033, 73230);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 73076, 73109);

                                builder.AddSeparator(commaToken);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 73131, 73163);

                                builder.Add(f_10001_73143_73161<TNode>(enumerator));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 73033, 73230);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 73033, 73230) || true) && (f_10001_73207_73228<TNode>(enumerator))
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10001, 73033, 73230);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10001, 73033, 73230);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 73250, 73274);

                    return builder.ToList();
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 72370, 73289);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 71891, 73300);

                int
                f_10001_72241_72257<TNode>(System.Collections.Generic.ICollection<TNode>
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 72241, 72257);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<TNode>
                f_10001_72394_72415<TNode>(System.Collections.Generic.IEnumerable<TNode>
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 72394, 72415);
                    return return_v;
                }


                bool
                f_10001_72454_72475<TNode>(System.Collections.Generic.IEnumerator<TNode>
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 72454, 72475);
                    return return_v;
                }


                TNode
                f_10001_72615_72633<TNode>(System.Collections.Generic.IEnumerator<TNode>
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 72615, 72633);
                    return return_v;
                }


                bool
                f_10001_72659_72680<TNode>(System.Collections.Generic.IEnumerator<TNode>
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 72659, 72680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>
                f_10001_72729_72769<TNode>(TNode
                node) where TNode : SyntaxNode

                {
                    var return_v = SingletonSeparatedList<TNode>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 72729, 72769);
                    return return_v;
                }


                int
                f_10001_72882_72898<TNode>(System.Collections.Generic.ICollection<TNode>
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 72882, 72898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.SeparatedSyntaxListBuilder<TNode>
                f_10001_72823_72903<TNode>(int
                size) where TNode : SyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.SeparatedSyntaxListBuilder<TNode>(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 72823, 72903);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_72984_73012<TNode>(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind) where TNode : SyntaxNode

                {
                    var return_v = Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 72984, 73012);
                    return return_v;
                }


                TNode
                f_10001_73143_73161<TNode>(System.Collections.Generic.IEnumerator<TNode>
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 73143, 73161);
                    return return_v;
                }


                bool
                f_10001_73207_73228<TNode>(System.Collections.Generic.IEnumerator<TNode>
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 73207, 73228);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 71891, 73300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 71891, 73300);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SeparatedSyntaxList<TNode> SeparatedList<TNode>(IEnumerable<TNode> nodes, IEnumerable<SyntaxToken> separators) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 73805, 75615);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 74168, 75336) || true) && (nodes != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 74168, 75336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 74219, 74273);

                    IEnumerator<TNode>
                    enumerator = f_10001_74251_74272<TNode>(nodes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 74291, 74378);

                    SeparatedSyntaxListBuilder<TNode>
                    builder = SeparatedSyntaxListBuilder<TNode>.Create()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 74396, 74899) || true) && (separators != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 74396, 74899);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 74460, 74880);
                            foreach (SyntaxToken token in f_10001_74490_74500_I(separators))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 74460, 74880);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 74550, 74743) || true) && (!f_10001_74555_74576<TNode>(enumerator))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 74550, 74743);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 74634, 74716);

                                    throw f_10001_74640_74715<TNode>($"{nameof(nodes)} must not be empty.", nameof(nodes));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 74550, 74743);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 74771, 74803);

                                builder.Add(f_10001_74783_74801<TNode>(enumerator));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 74829, 74857);

                                builder.AddSeparator(token);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 74460, 74880);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10001, 1, 421);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10001, 1, 421);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 74396, 74899);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 74919, 75277) || true) && (f_10001_74923_74944<TNode>(enumerator))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 74919, 75277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 74986, 75018);

                        builder.Add(f_10001_74998_75016<TNode>(enumerator));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 75040, 75258) || true) && (f_10001_75044_75065<TNode>(enumerator))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 75040, 75258);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 75115, 75235);

                            throw f_10001_75121_75234<TNode>($"{nameof(separators)} must have 1 fewer element than {nameof(nodes)}", nameof(separators));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 75040, 75258);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 74919, 75277);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 75297, 75321);

                    return builder.ToList();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 74168, 75336);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 75352, 75545) || true) && (separators != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 75352, 75545);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 75408, 75530);

                    throw f_10001_75414_75529<TNode>($"When {nameof(nodes)} is null, {nameof(separators)} must also be null.", nameof(separators));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 75352, 75545);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 75561, 75604);

                return default(SeparatedSyntaxList<TNode>);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 73805, 75615);

                System.Collections.Generic.IEnumerator<TNode>
                f_10001_74251_74272<TNode>(System.Collections.Generic.IEnumerable<TNode>
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 74251, 74272);
                    return return_v;
                }


                bool
                f_10001_74555_74576<TNode>(System.Collections.Generic.IEnumerator<TNode>
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 74555, 74576);
                    return return_v;
                }


                System.ArgumentException
                f_10001_74640_74715<TNode>(string
                message, string
                paramName) where TNode : SyntaxNode

                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 74640, 74715);
                    return return_v;
                }


                TNode
                f_10001_74783_74801<TNode>(System.Collections.Generic.IEnumerator<TNode>
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 74783, 74801);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                f_10001_74490_74500_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 74490, 74500);
                    return return_v;
                }


                bool
                f_10001_74923_74944<TNode>(System.Collections.Generic.IEnumerator<TNode>
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 74923, 74944);
                    return return_v;
                }


                TNode
                f_10001_74998_75016<TNode>(System.Collections.Generic.IEnumerator<TNode>
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 74998, 75016);
                    return return_v;
                }


                bool
                f_10001_75044_75065<TNode>(System.Collections.Generic.IEnumerator<TNode>
                this_param) where TNode : SyntaxNode

                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 75044, 75065);
                    return return_v;
                }


                System.ArgumentException
                f_10001_75121_75234<TNode>(string
                message, string
                paramName) where TNode : SyntaxNode

                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 75121, 75234);
                    return return_v;
                }


                System.ArgumentException
                f_10001_75414_75529<TNode>(string
                message, string
                paramName) where TNode : SyntaxNode

                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 75414, 75529);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 73805, 75615);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 73805, 75615);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SeparatedSyntaxList<TNode> SeparatedList<TNode>(IEnumerable<SyntaxNodeOrToken> nodesAndTokens) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 76051, 76281);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 76209, 76270);

                return f_10001_76216_76269<TNode>(f_10001_76237_76268<TNode>(nodesAndTokens));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 76051, 76281);

                Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                f_10001_76237_76268<TNode>(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                nodesAndTokens) where TNode : SyntaxNode

                {
                    var return_v = NodeOrTokenList(nodesAndTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 76237, 76268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>
                f_10001_76216_76269<TNode>(Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                nodesAndTokens) where TNode : SyntaxNode

                {
                    var return_v = SeparatedList<TNode>(nodesAndTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 76216, 76269);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 76051, 76281);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 76051, 76281);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SeparatedSyntaxList<TNode> SeparatedList<TNode>(SyntaxNodeOrTokenList nodesAndTokens) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 76712, 77306);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 76861, 77035) || true) && (!f_10001_76866_76910<TNode>(nodesAndTokens))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 76861, 77035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 76944, 77020);

                    throw f_10001_76950_77019<TNode>(f_10001_76972_77018<TNode>());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 76861, 77035);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 77051, 77225) || true) && (!f_10001_77056_77098<TNode>(nodesAndTokens))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 77051, 77225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 77132, 77210);

                    throw f_10001_77138_77209<TNode>(f_10001_77160_77208<TNode>());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 77051, 77225);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 77241, 77295);

                return f_10001_77248_77294<TNode>(nodesAndTokens);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 76712, 77306);

                bool
                f_10001_76866_76910<TNode>(Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                list) where TNode : SyntaxNode

                {
                    var return_v = HasSeparatedNodeTokenPattern(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 76866, 76910);
                    return return_v;
                }


                string
                f_10001_76972_77018<TNode>() where TNode : SyntaxNode

                {
                    var return_v = CodeAnalysisResources.NodeOrTokenOutOfSequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 76972, 77018);
                    return return_v;
                }


                System.ArgumentException
                f_10001_76950_77019<TNode>(string
                message) where TNode : SyntaxNode

                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 76950, 77019);
                    return return_v;
                }


                bool
                f_10001_77056_77098<TNode>(Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                list) where TNode : SyntaxNode

                {
                    var return_v = NodesAreCorrectType<TNode>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 77056, 77098);
                    return return_v;
                }


                string
                f_10001_77160_77208<TNode>() where TNode : SyntaxNode

                {
                    var return_v = CodeAnalysisResources.UnexpectedTypeOfNodeInList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 77160, 77208);
                    return return_v;
                }


                System.ArgumentException
                f_10001_77138_77209<TNode>(string
                message) where TNode : SyntaxNode

                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 77138, 77209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>
                f_10001_77248_77294<TNode>(Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                list) where TNode : SyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 77248, 77294);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 76712, 77306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 76712, 77306);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool NodesAreCorrectType<TNode>(SyntaxNodeOrTokenList list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 77318, 77711);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 77426, 77431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 77433, 77447);
                    for (int
        i = 0
        ,
        n = list.Count
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 77417, 77672) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 77456, 77459)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 77417, 77672))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 77417, 77672);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 77493, 77515);

                        var
                        element = list[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 77533, 77657) || true) && (element.IsNode && (DynAbs.Tracing.TraceSender.Expression_True(10001, 77537, 77583) && !(element.AsNode() is TNode)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 77533, 77657);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 77625, 77638);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 77533, 77657);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10001, 1, 256);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10001, 1, 256);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 77688, 77700);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 77318, 77711);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 77318, 77711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 77318, 77711);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasSeparatedNodeTokenPattern(SyntaxNodeOrTokenList list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 77723, 78105);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 77833, 77838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 77840, 77854);
                    for (int
        i = 0
        ,
        n = list.Count
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 77824, 78066) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 77863, 77866)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 77824, 78066))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 77824, 78066);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 77900, 77922);

                        var
                        element = list[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 77940, 78051) || true) && (element.IsToken == ((i & 1) == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 77940, 78051);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 78019, 78032);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 77940, 78051);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10001, 1, 243);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10001, 1, 243);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 78082, 78094);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 77723, 78105);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 77723, 78105);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 77723, 78105);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxNodeOrTokenList NodeOrTokenList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 78231, 78358);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 78309, 78347);

                return default(SyntaxNodeOrTokenList);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 78231, 78358);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 78231, 78358);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 78231, 78358);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxNodeOrTokenList NodeOrTokenList(IEnumerable<SyntaxNodeOrToken> nodesAndTokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 78610, 78793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 78733, 78782);

                return f_10001_78740_78781(nodesAndTokens);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 78610, 78793);

                Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                f_10001_78740_78781(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                nodesAndTokens)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxNodeOrTokenList(nodesAndTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 78740, 78781);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 78610, 78793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 78610, 78793);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxNodeOrTokenList NodeOrTokenList(params SyntaxNodeOrToken[] nodesAndTokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 79031, 79210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 79150, 79199);

                return f_10001_79157_79198(nodesAndTokens);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 79031, 79210);

                Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                f_10001_79157_79198(params Microsoft.CodeAnalysis.SyntaxNodeOrToken[]
                nodesAndTokens)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxNodeOrTokenList(nodesAndTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 79157, 79198);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 79031, 79210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 79031, 79210);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IdentifierNameSyntax IdentifierName(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 79381, 79519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 79468, 79508);

                return f_10001_79475_79507(f_10001_79490_79506(name));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 79381, 79519);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_79490_79506(string
                text)
                {
                    var return_v = Identifier(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 79490, 79506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10001_79475_79507(Microsoft.CodeAnalysis.SyntaxToken
                identifier)
                {
                    var return_v = IdentifierName(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 79475, 79507);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 79381, 79519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 79381, 79519);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTree SyntaxTree(SyntaxNode root, ParseOptions? options = null, string path = "", Encoding? encoding = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 79700, 79964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 79852, 79953);

                return f_10001_79859_79952(root, options, path, encoding);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 79700, 79964);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10001_79859_79952(Microsoft.CodeAnalysis.SyntaxNode
                root, Microsoft.CodeAnalysis.ParseOptions?
                options, string
                path, System.Text.Encoding?
                encoding)
                {
                    var return_v = CSharpSyntaxTree.Create((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)root, (Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?)options, path, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 79859, 79952);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 79700, 79964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 79700, 79964);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTree ParseSyntaxTree(
                    string text,
                    ParseOptions? options = null,
                    string path = "",
                    Encoding? encoding = null,
                    CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 80338, 80720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 80604, 80709);

                return f_10001_80611_80708(text, options, path, encoding, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 80338, 80720);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10001_80611_80708(string
                text, Microsoft.CodeAnalysis.ParseOptions?
                options, string
                path, System.Text.Encoding?
                encoding, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = CSharpSyntaxTree.ParseText(text, (Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?)options, path, encoding, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 80611, 80708);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 80338, 80720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 80338, 80720);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTree ParseSyntaxTree(
                    SourceText text,
                    ParseOptions? options = null,
                    string path = "",
                    CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 80853, 81189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 81083, 81178);

                return f_10001_81090_81177(text, options, path, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 80853, 81189);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10001_81090_81177(Microsoft.CodeAnalysis.Text.SourceText
                text, Microsoft.CodeAnalysis.ParseOptions?
                options, string
                path, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = CSharpSyntaxTree.ParseText(text, (Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?)options, path, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 81090, 81177);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 80853, 81189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 80853, 81189);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTriviaList ParseLeadingTrivia(string text, int offset = 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 81544, 81726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 81647, 81715);

                return f_10001_81654_81714(text, f_10001_81679_81705(), offset);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 81544, 81726);

                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10001_81679_81705()
                {
                    var return_v = CSharpParseOptions.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 81679, 81705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10001_81654_81714(string
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options, int
                offset)
                {
                    var return_v = ParseLeadingTrivia(text, options, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 81654, 81714);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 81544, 81726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 81544, 81726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxTriviaList ParseLeadingTrivia(string text, CSharpParseOptions? options, int offset = 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 81847, 82161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 81981, 82150);

                // LAFHIS
                var temp = f_10001_82025_82053(text, offset);

                using (var
                lexer = new InternalSyntax.Lexer(temp, options)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 82000, 82063);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 82097, 82135);

                    //return f_10001_82104_82134(lexer);

                    // LAFHIS
                    var toReturn = lexer.LexSyntaxLeadingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 82104, 82134);
                    return toReturn;

                    DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 81981, 82150);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 81847, 82161);

                Microsoft.CodeAnalysis.Text.SourceText
                f_10001_82025_82053(string
                text, int
                offset)
                {
                    var return_v = MakeSourceText(text, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 82025, 82053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                f_10001_82000_82063(Microsoft.CodeAnalysis.Text.SourceText
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                options)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer(text, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 82000, 82063);
                    return return_v;
                }


                //Microsoft.CodeAnalysis.SyntaxTriviaList
                //f_10001_82104_82134(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                //this_param)
                //{
                //    var return_v = this_param.LexSyntaxLeadingTrivia();
                //    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 82104, 82134);
                //    return return_v;
                //}

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 81847, 82161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 81847, 82161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTriviaList ParseTrailingTrivia(string text, int offset = 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 82301, 82605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 82405, 82594);
                using (var
                lexer = f_10001_82424_82506(f_10001_82449_82477(text, offset), f_10001_82479_82505())
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 82540, 82579);

                    return f_10001_82547_82578(lexer);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 82405, 82594);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 82301, 82605);

                Microsoft.CodeAnalysis.Text.SourceText
                f_10001_82449_82477(string
                text, int
                offset)
                {
                    var return_v = MakeSourceText(text, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 82449, 82477);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10001_82479_82505()
                {
                    var return_v = CSharpParseOptions.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 82479, 82505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                f_10001_82424_82506(Microsoft.CodeAnalysis.Text.SourceText
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer(text, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 82424, 82506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10001_82547_82578(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.LexSyntaxTrailingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 82547, 82578);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 82301, 82605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 82301, 82605);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CrefSyntax? ParseCref(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 82772, 84342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 83429, 83498);

                string
                commentText = f_10001_83450_83497(@"/// <see cref=""{0}""/>", text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 83514, 83657);

                SyntaxTriviaList
                leadingTrivia = f_10001_83547_83656(commentText, f_10001_83579_83655(f_10001_83579_83605(), DocumentationMode.Diagnose))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 83671, 83710);

                f_10001_83671_83709(leadingTrivia.Count == 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 83724, 83768);

                SyntaxTrivia
                trivia = leadingTrivia.First()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 83782, 83884);

                DocumentationCommentTriviaSyntax
                structure = (DocumentationCommentTriviaSyntax)trivia.GetStructure()!
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 83898, 83941);

                f_10001_83898_83940(structure.Content.Count == 2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 83955, 84037);

                XmlEmptyElementSyntax
                elementSyntax = (XmlEmptyElementSyntax)f_10001_84016_84033(structure)[1]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 84051, 84101);

                f_10001_84051_84100(elementSyntax.Attributes.Count == 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 84115, 84200);

                XmlAttributeSyntax
                attributeSyntax = (XmlAttributeSyntax)f_10001_84172_84196(elementSyntax)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 84214, 84331);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10001, 84221, 84274) || ((f_10001_84221_84243(attributeSyntax) == SyntaxKind.XmlCrefAttribute && DynAbs.Tracing.TraceSender.Conditional_F2(10001, 84277, 84323)) || DynAbs.Tracing.TraceSender.Conditional_F3(10001, 84326, 84330))) ? f_10001_84277_84323(((XmlCrefAttributeSyntax)attributeSyntax)) : null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 82772, 84342);

                string
                f_10001_83450_83497(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 83450, 83497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10001_83579_83605()
                {
                    var return_v = CSharpParseOptions.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 83579, 83605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10001_83579_83655(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, Microsoft.CodeAnalysis.DocumentationMode
                documentationMode)
                {
                    var return_v = this_param.WithDocumentationMode(documentationMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 83579, 83655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10001_83547_83656(string
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options)
                {
                    var return_v = ParseLeadingTrivia(text, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 83547, 83656);
                    return return_v;
                }


                int
                f_10001_83671_83709(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 83671, 83709);
                    return 0;
                }


                int
                f_10001_83898_83940(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 83898, 83940);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlNodeSyntax>
                f_10001_84016_84033(Microsoft.CodeAnalysis.CSharp.Syntax.DocumentationCommentTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Content;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 84016, 84033);
                    return return_v;
                }


                int
                f_10001_84051_84100(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 84051, 84100);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax>
                f_10001_84172_84196(Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 84172, 84196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10001_84221_84243(Microsoft.CodeAnalysis.CSharp.Syntax.XmlAttributeSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 84221, 84243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                f_10001_84277_84323(Microsoft.CodeAnalysis.CSharp.Syntax.XmlCrefAttributeSyntax
                this_param)
                {
                    var return_v = this_param.Cref;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 84277, 84323);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 82772, 84342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 82772, 84342);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken ParseToken(string text, int offset = 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 84611, 84929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 84701, 84918);
                using (var
                lexer = f_10001_84720_84802(f_10001_84745_84773(text, offset), f_10001_84775_84801())
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 84836, 84903);

                    return f_10001_84843_84902(f_10001_84859_84901(lexer, InternalSyntax.LexerMode.Syntax));
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 84701, 84918);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 84611, 84929);

                Microsoft.CodeAnalysis.Text.SourceText
                f_10001_84745_84773(string
                text, int
                offset)
                {
                    var return_v = MakeSourceText(text, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 84745, 84773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10001_84775_84801()
                {
                    var return_v = CSharpParseOptions.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 84775, 84801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                f_10001_84720_84802(Microsoft.CodeAnalysis.Text.SourceText
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer(text, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 84720, 84802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_84859_84901(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = this_param.Lex(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 84859, 84901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_84843_84902(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken((Microsoft.CodeAnalysis.GreenNode)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 84843, 84902);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 84611, 84929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 84611, 84929);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<SyntaxToken> ParseTokens(string text, int offset = 0, int initialTokenPosition = 0, CSharpParseOptions? options = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 85355, 86185);

                var listYield = new List<SyntaxToken>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 85525, 86174);
                using (var
                lexer = f_10001_85544_85637(f_10001_85569_85597(text, offset), options ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?>(10001, 85599, 85636) ?? f_10001_85610_85636()))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 85671, 85707);

                    var
                    position = initialTokenPosition
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 85725, 86159) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 85725, 86159);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 85778, 85833);

                            var
                            token = f_10001_85790_85832(lexer, InternalSyntax.LexerMode.Syntax)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 85855, 85942);

                            listYield.Add(f_10001_85868_85941(parent: null, token: token, position: position, index: 0));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 85966, 85994);

                            position += f_10001_85978_85993(token);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 86018, 86140) || true) && (f_10001_86022_86032(token) == SyntaxKind.EndOfFileToken)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 86018, 86140);
                                DynAbs.Tracing.TraceSender.TraceBreak(10001, 86111, 86117);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 86018, 86140);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 85725, 86159);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10001, 85725, 86159);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10001, 85725, 86159);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 85525, 86174);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 85355, 86185);

                return listYield;

                Microsoft.CodeAnalysis.Text.SourceText
                f_10001_85569_85597(string
                text, int
                offset)
                {
                    var return_v = MakeSourceText(text, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 85569, 85597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10001_85610_85636()
                {
                    var return_v = CSharpParseOptions.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 85610, 85636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                f_10001_85544_85637(Microsoft.CodeAnalysis.Text.SourceText
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer(text, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 85544, 85637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10001_85790_85832(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = this_param.Lex(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 85790, 85832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_85868_85941(Microsoft.CodeAnalysis.SyntaxNode?
                parent, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxToken(parent: parent, token: (Microsoft.CodeAnalysis.GreenNode)token, position: position, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 85868, 85941);
                    return return_v;
                }


                int
                f_10001_85978_85993(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 85978, 85993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10001_86022_86032(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 86022, 86032);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 85355, 86185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 85355, 86185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static NameSyntax ParseName(string text, int offset = 0, bool consumeFullText = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 86315, 86753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 86432, 86742);
                using (var
                lexer = f_10001_86451_86474(text, offset)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 86489, 86742);
                    using (var
                    parser = f_10001_86509_86526(lexer)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 86560, 86590);

                        var
                        node = f_10001_86571_86589(parser)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 86608, 86673) || true) && (consumeFullText)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 86608, 86673);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 86629, 86673);

                            node = f_10001_86636_86672(parser, node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 86608, 86673);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 86691, 86727);

                        return (NameSyntax)f_10001_86710_86726(node);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 86489, 86742);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 86432, 86742);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 86315, 86753);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                f_10001_86451_86474(string
                text, int
                offset)
                {
                    var return_v = MakeLexer(text, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 86451, 86474);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                f_10001_86509_86526(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                lexer)
                {
                    var return_v = MakeParser(lexer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 86509, 86526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NameSyntax
                f_10001_86571_86589(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.ParseName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 86571, 86589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NameSyntax
                f_10001_86636_86672(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NameSyntax
                node)
                {
                    var return_v = this_param.ConsumeUnexpectedTokens<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NameSyntax>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 86636, 86672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10001_86710_86726(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 86710, 86726);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 86315, 86753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 86315, 86753);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static TypeSyntax ParseTypeName(string text, int offset, bool consumeFullText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 86939, 87182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 87104, 87171);

                return f_10001_87111_87170(text, offset, options: null, consumeFullText);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 86939, 87182);

                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10001_87111_87170(string
                text, int
                offset, Microsoft.CodeAnalysis.ParseOptions?
                options, bool
                consumeFullText)
                {
                    var return_v = ParseTypeName(text, offset, options: options, consumeFullText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 87111, 87170);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 86939, 87182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 86939, 87182);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypeSyntax ParseTypeName(string text, int offset = 0, ParseOptions? options = null, bool consumeFullText = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 87321, 87827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 87472, 87816);
                using (var
                lexer = f_10001_87491_87544(text, offset, options)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 87559, 87816);
                    using (var
                    parser = f_10001_87579_87596(lexer)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 87630, 87664);

                        var
                        node = f_10001_87641_87663(parser)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 87682, 87747) || true) && (consumeFullText)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 87682, 87747);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 87703, 87747);

                            node = f_10001_87710_87746(parser, node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 87682, 87747);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 87765, 87801);

                        return (TypeSyntax)f_10001_87784_87800(node);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 87559, 87816);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 87472, 87816);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 87321, 87827);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                f_10001_87491_87544(string
                text, int
                offset, Microsoft.CodeAnalysis.ParseOptions?
                options)
                {
                    var return_v = MakeLexer(text, offset, (Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?)options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 87491, 87544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                f_10001_87579_87596(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                lexer)
                {
                    var return_v = MakeParser(lexer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 87579, 87596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                f_10001_87641_87663(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.ParseTypeName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 87641, 87663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                f_10001_87710_87746(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                node)
                {
                    var return_v = this_param.ConsumeUnexpectedTokens<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 87710, 87746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10001_87784_87800(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 87784, 87800);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 87321, 87827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 87321, 87827);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ExpressionSyntax ParseExpression(string text, int offset = 0, ParseOptions? options = null, bool consumeFullText = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 88385, 88907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 88544, 88896);
                using (var
                lexer = f_10001_88563_88616(text, offset, options)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 88631, 88896);
                    using (var
                    parser = f_10001_88651_88668(lexer)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 88702, 88738);

                        var
                        node = f_10001_88713_88737(parser)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 88756, 88821) || true) && (consumeFullText)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 88756, 88821);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 88777, 88821);

                            node = f_10001_88784_88820(parser, node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 88756, 88821);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 88839, 88881);

                        return (ExpressionSyntax)f_10001_88864_88880(node);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 88631, 88896);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 88544, 88896);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 88385, 88907);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                f_10001_88563_88616(string
                text, int
                offset, Microsoft.CodeAnalysis.ParseOptions?
                options)
                {
                    var return_v = MakeLexer(text, offset, (Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?)options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 88563, 88616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                f_10001_88651_88668(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                lexer)
                {
                    var return_v = MakeParser(lexer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 88651, 88668);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10001_88713_88737(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.ParseExpression();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 88713, 88737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10001_88784_88820(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.ConsumeUnexpectedTokens<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 88784, 88820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10001_88864_88880(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 88864, 88880);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 88385, 88907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 88385, 88907);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static StatementSyntax ParseStatement(string text, int offset = 0, ParseOptions? options = null, bool consumeFullText = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 89438, 89956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 89595, 89945);
                using (var
                lexer = f_10001_89614_89667(text, offset, options)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 89682, 89945);
                    using (var
                    parser = f_10001_89702_89719(lexer)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 89753, 89788);

                        var
                        node = f_10001_89764_89787(parser)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 89806, 89871) || true) && (consumeFullText)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 89806, 89871);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 89827, 89871);

                            node = f_10001_89834_89870(parser, node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 89806, 89871);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 89889, 89930);

                        return (StatementSyntax)f_10001_89913_89929(node);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 89682, 89945);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 89595, 89945);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 89438, 89956);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                f_10001_89614_89667(string
                text, int
                offset, Microsoft.CodeAnalysis.ParseOptions?
                options)
                {
                    var return_v = MakeLexer(text, offset, (Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?)options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 89614, 89667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                f_10001_89702_89719(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                lexer)
                {
                    var return_v = MakeParser(lexer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 89702, 89719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.StatementSyntax
                f_10001_89764_89787(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.ParseStatement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 89764, 89787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.StatementSyntax
                f_10001_89834_89870(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.StatementSyntax
                node)
                {
                    var return_v = this_param.ConsumeUnexpectedTokens<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.StatementSyntax>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 89834, 89870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10001_89913_89929(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 89913, 89929);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 89438, 89956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 89438, 89956);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberDeclarationSyntax? ParseMemberDeclaration(string text, int offset = 0, ParseOptions? options = null, bool consumeFullText = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 90664, 91300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 90838, 91289);
                using (var
                lexer = f_10001_90857_90910(text, offset, options)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 90925, 91289);
                    using (var
                    parser = f_10001_90945_90962(lexer)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 90996, 91039);

                        var
                        node = f_10001_91007_91038(parser)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 91057, 91146) || true) && (node == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 91057, 91146);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 91115, 91127);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 91057, 91146);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 91166, 91274);

                        return (MemberDeclarationSyntax)f_10001_91198_91273(((DynAbs.Tracing.TraceSender.Conditional_F1(10001, 91199, 91214) || ((consumeFullText && DynAbs.Tracing.TraceSender.Conditional_F2(10001, 91217, 91253)) || DynAbs.Tracing.TraceSender.Conditional_F3(10001, 91256, 91260))) ? f_10001_91217_91253(parser, node) : node));
                        DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 90925, 91289);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 90838, 91289);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 90664, 91300);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                f_10001_90857_90910(string
                text, int
                offset, Microsoft.CodeAnalysis.ParseOptions?
                options)
                {
                    var return_v = MakeLexer(text, offset, (Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?)options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 90857, 90910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                f_10001_90945_90962(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                lexer)
                {
                    var return_v = MakeParser(lexer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 90945, 90962);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberDeclarationSyntax
                f_10001_91007_91038(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.ParseMemberDeclaration();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 91007, 91038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberDeclarationSyntax
                f_10001_91217_91253(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberDeclarationSyntax
                node)
                {
                    var return_v = this_param.ConsumeUnexpectedTokens<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberDeclarationSyntax>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 91217, 91253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10001_91198_91273(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.MemberDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 91198, 91273);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 90664, 91300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 90664, 91300);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CompilationUnitSyntax ParseCompilationUnit(string text, int offset = 0, CSharpParseOptions? options = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 91839, 92425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 92156, 92414);
                using (var
                lexer = f_10001_92175_92207(text, offset, options)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 92222, 92414);
                    using (var
                    parser = f_10001_92242_92259(lexer)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 92293, 92334);

                        var
                        node = f_10001_92304_92333(parser)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 92352, 92399);

                        return (CompilationUnitSyntax)f_10001_92382_92398(node);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 92222, 92414);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 92156, 92414);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 91839, 92425);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                f_10001_92175_92207(string
                text, int
                offset, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                options)
                {
                    var return_v = MakeLexer(text, offset, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 92175, 92207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                f_10001_92242_92259(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                lexer)
                {
                    var return_v = MakeParser(lexer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 92242, 92259);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CompilationUnitSyntax
                f_10001_92304_92333(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.ParseCompilationUnit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 92304, 92333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10001_92382_92398(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 92382, 92398);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 91839, 92425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 91839, 92425);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ParameterListSyntax ParseParameterList(string text, int offset = 0, ParseOptions? options = null, bool consumeFullText = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 92946, 93493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 93111, 93482);
                using (var
                lexer = f_10001_93130_93183(text, offset, options)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 93198, 93482);
                    using (var
                    parser = f_10001_93218_93235(lexer)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 93269, 93321);

                        var
                        node = f_10001_93280_93320(parser)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 93339, 93404) || true) && (consumeFullText)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 93339, 93404);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 93360, 93404);

                            node = f_10001_93367_93403(parser, node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 93339, 93404);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 93422, 93467);

                        return (ParameterListSyntax)f_10001_93450_93466(node);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 93198, 93482);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 93111, 93482);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 92946, 93493);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                f_10001_93130_93183(string
                text, int
                offset, Microsoft.CodeAnalysis.ParseOptions?
                options)
                {
                    var return_v = MakeLexer(text, offset, (Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?)options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 93130, 93183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                f_10001_93218_93235(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                lexer)
                {
                    var return_v = MakeParser(lexer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 93218, 93235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ParameterListSyntax
                f_10001_93280_93320(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.ParseParenthesizedParameterList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 93280, 93320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ParameterListSyntax
                f_10001_93367_93403(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ParameterListSyntax
                node)
                {
                    var return_v = this_param.ConsumeUnexpectedTokens<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ParameterListSyntax>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 93367, 93403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10001_93450_93466(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ParameterListSyntax
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 93450, 93466);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 92946, 93493);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 92946, 93493);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BracketedParameterListSyntax ParseBracketedParameterList(string text, int offset = 0, ParseOptions? options = null, bool consumeFullText = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 94019, 94589);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 94202, 94578);
                using (var
                lexer = f_10001_94221_94274(text, offset, options)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 94289, 94578);
                    using (var
                    parser = f_10001_94309_94326(lexer)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 94360, 94408);

                        var
                        node = f_10001_94371_94407(parser)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 94426, 94491) || true) && (consumeFullText)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 94426, 94491);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 94447, 94491);

                            node = f_10001_94454_94490(parser, node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 94426, 94491);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 94509, 94563);

                        return (BracketedParameterListSyntax)f_10001_94546_94562(node);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 94289, 94578);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 94202, 94578);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 94019, 94589);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                f_10001_94221_94274(string
                text, int
                offset, Microsoft.CodeAnalysis.ParseOptions?
                options)
                {
                    var return_v = MakeLexer(text, offset, (Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?)options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 94221, 94274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                f_10001_94309_94326(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                lexer)
                {
                    var return_v = MakeParser(lexer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 94309, 94326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BracketedParameterListSyntax
                f_10001_94371_94407(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.ParseBracketedParameterList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 94371, 94407);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BracketedParameterListSyntax
                f_10001_94454_94490(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BracketedParameterListSyntax
                node)
                {
                    var return_v = this_param.ConsumeUnexpectedTokens<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BracketedParameterListSyntax>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 94454, 94490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10001_94546_94562(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BracketedParameterListSyntax
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 94546, 94562);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 94019, 94589);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 94019, 94589);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ArgumentListSyntax ParseArgumentList(string text, int offset = 0, ParseOptions? options = null, bool consumeFullText = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 95109, 95652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 95272, 95641);
                using (var
                lexer = f_10001_95291_95344(text, offset, options)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 95359, 95641);
                    using (var
                    parser = f_10001_95379_95396(lexer)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 95430, 95481);

                        var
                        node = f_10001_95441_95480(parser)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 95499, 95564) || true) && (consumeFullText)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 95499, 95564);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 95520, 95564);

                            node = f_10001_95527_95563(parser, node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 95499, 95564);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 95582, 95626);

                        return (ArgumentListSyntax)f_10001_95609_95625(node);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 95359, 95641);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 95272, 95641);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 95109, 95652);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                f_10001_95291_95344(string
                text, int
                offset, Microsoft.CodeAnalysis.ParseOptions?
                options)
                {
                    var return_v = MakeLexer(text, offset, (Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?)options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 95291, 95344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                f_10001_95379_95396(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                lexer)
                {
                    var return_v = MakeParser(lexer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 95379, 95396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ArgumentListSyntax
                f_10001_95441_95480(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.ParseParenthesizedArgumentList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 95441, 95480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ArgumentListSyntax
                f_10001_95527_95563(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ArgumentListSyntax
                node)
                {
                    var return_v = this_param.ConsumeUnexpectedTokens<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ArgumentListSyntax>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 95527, 95563);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10001_95609_95625(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 95609, 95625);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 95109, 95652);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 95109, 95652);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BracketedArgumentListSyntax ParseBracketedArgumentList(string text, int offset = 0, ParseOptions? options = null, bool consumeFullText = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 96176, 96742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 96357, 96731);
                using (var
                lexer = f_10001_96376_96429(text, offset, options)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 96444, 96731);
                    using (var
                    parser = f_10001_96464_96481(lexer)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 96515, 96562);

                        var
                        node = f_10001_96526_96561(parser)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 96580, 96645) || true) && (consumeFullText)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 96580, 96645);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 96601, 96645);

                            node = f_10001_96608_96644(parser, node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 96580, 96645);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 96663, 96716);

                        return (BracketedArgumentListSyntax)f_10001_96699_96715(node);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 96444, 96731);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 96357, 96731);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 96176, 96742);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                f_10001_96376_96429(string
                text, int
                offset, Microsoft.CodeAnalysis.ParseOptions?
                options)
                {
                    var return_v = MakeLexer(text, offset, (Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?)options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 96376, 96429);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                f_10001_96464_96481(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                lexer)
                {
                    var return_v = MakeParser(lexer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 96464, 96481);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BracketedArgumentListSyntax
                f_10001_96526_96561(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.ParseBracketedArgumentList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 96526, 96561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BracketedArgumentListSyntax
                f_10001_96608_96644(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BracketedArgumentListSyntax
                node)
                {
                    var return_v = this_param.ConsumeUnexpectedTokens<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BracketedArgumentListSyntax>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 96608, 96644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10001_96699_96715(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BracketedArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 96699, 96715);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 96176, 96742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 96176, 96742);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AttributeArgumentListSyntax ParseAttributeArgumentList(string text, int offset = 0, ParseOptions? options = null, bool consumeFullText = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 97267, 97833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 97448, 97822);
                using (var
                lexer = f_10001_97467_97520(text, offset, options)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 97535, 97822);
                    using (var
                    parser = f_10001_97555_97572(lexer)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 97606, 97653);

                        var
                        node = f_10001_97617_97652(parser)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 97671, 97736) || true) && (consumeFullText)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 97671, 97736);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 97692, 97736);

                            node = f_10001_97699_97735(parser, node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 97671, 97736);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 97754, 97807);

                        return (AttributeArgumentListSyntax)f_10001_97790_97806(node);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 97535, 97822);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10001, 97448, 97822);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 97267, 97833);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                f_10001_97467_97520(string
                text, int
                offset, Microsoft.CodeAnalysis.ParseOptions?
                options)
                {
                    var return_v = MakeLexer(text, offset, (Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?)options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 97467, 97520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                f_10001_97555_97572(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                lexer)
                {
                    var return_v = MakeParser(lexer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 97555, 97572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AttributeArgumentListSyntax
                f_10001_97617_97652(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param)
                {
                    var return_v = this_param.ParseAttributeArgumentList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 97617, 97652);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AttributeArgumentListSyntax
                f_10001_97699_97735(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AttributeArgumentListSyntax
                node)
                {
                    var return_v = this_param.ConsumeUnexpectedTokens<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AttributeArgumentListSyntax>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 97699, 97735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10001_97790_97806(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.AttributeArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 97790, 97806);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 97267, 97833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 97267, 97833);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SourceText MakeSourceText(string text, int offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 97958, 98122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 98048, 98111);

                return f_10001_98055_98110(f_10001_98055_98091(text, f_10001_98077_98090()), offset);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 97958, 98122);

                System.Text.Encoding
                f_10001_98077_98090()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 98077, 98090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_10001_98055_98091(string
                text, System.Text.Encoding
                encoding)
                {
                    var return_v = SourceText.From(text, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 98055, 98091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_10001_98055_98110(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                start)
                {
                    var return_v = this_param.GetSubText(start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 98055, 98110);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 97958, 98122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 97958, 98122);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static InternalSyntax.Lexer MakeLexer(string text, int offset, CSharpParseOptions? options = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 98134, 98427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 98265, 98416);

                return f_10001_98272_98415(text: f_10001_98321_98349(text, offset), options: options ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?>(10001, 98377, 98414) ?? f_10001_98388_98414()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 98134, 98427);

                Microsoft.CodeAnalysis.Text.SourceText
                f_10001_98321_98349(string
                text, int
                offset)
                {
                    var return_v = MakeSourceText(text, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 98321, 98349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10001_98388_98414()
                {
                    var return_v = CSharpParseOptions.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 98388, 98414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                f_10001_98272_98415(Microsoft.CodeAnalysis.Text.SourceText
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer(text: text, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 98272, 98415);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 98134, 98427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 98134, 98427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static InternalSyntax.LanguageParser MakeParser(InternalSyntax.Lexer lexer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 98439, 98636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 98547, 98625);

                return f_10001_98554_98624(lexer, oldTree: null, changes: null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 98439, 98636);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser
                f_10001_98554_98624(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                lexer, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                oldTree, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextChangeRange>
                changes)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LanguageParser(lexer, oldTree: oldTree, changes: changes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 98554, 98624);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 98439, 98636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 98439, 98636);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool AreEquivalent(SyntaxTree? oldTree, SyntaxTree? newTree, bool topLevel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 99268, 99724);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 99382, 99481) || true) && (oldTree == null && (DynAbs.Tracing.TraceSender.Expression_True(10001, 99386, 99420) && newTree == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 99382, 99481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 99454, 99466);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 99382, 99481);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 99497, 99597) || true) && (oldTree == null || (DynAbs.Tracing.TraceSender.Expression_False(10001, 99501, 99535) || newTree == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 99497, 99597);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 99569, 99582);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 99497, 99597);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 99613, 99713);

                return f_10001_99620_99712(oldTree, newTree, ignoreChildNode: null, topLevel: topLevel);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 99268, 99724);

                bool
                f_10001_99620_99712(Microsoft.CodeAnalysis.SyntaxTree
                before, Microsoft.CodeAnalysis.SyntaxTree
                after, System.Func<Microsoft.CodeAnalysis.CSharp.SyntaxKind, bool>?
                ignoreChildNode, bool
                topLevel)
                {
                    var return_v = SyntaxEquivalence.AreEquivalent(before, after, ignoreChildNode: ignoreChildNode, topLevel: topLevel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 99620, 99712);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 99268, 99724);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 99268, 99724);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool AreEquivalent(SyntaxNode? oldNode, SyntaxNode? newNode, bool topLevel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 100358, 100583);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 100472, 100572);

                return f_10001_100479_100571(oldNode, newNode, ignoreChildNode: null, topLevel: topLevel);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 100358, 100583);

                bool
                f_10001_100479_100571(Microsoft.CodeAnalysis.SyntaxNode?
                before, Microsoft.CodeAnalysis.SyntaxNode?
                after, System.Func<Microsoft.CodeAnalysis.CSharp.SyntaxKind, bool>?
                ignoreChildNode, bool
                topLevel)
                {
                    var return_v = SyntaxEquivalence.AreEquivalent(before, after, ignoreChildNode: ignoreChildNode, topLevel: topLevel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 100479, 100571);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 100358, 100583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 100358, 100583);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool AreEquivalent(SyntaxNode? oldNode, SyntaxNode? newNode, Func<SyntaxKind, bool>? ignoreChildNode = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 101144, 101410);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 101291, 101399);

                return f_10001_101298_101398(oldNode, newNode, ignoreChildNode: ignoreChildNode, topLevel: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 101144, 101410);

                bool
                f_10001_101298_101398(Microsoft.CodeAnalysis.SyntaxNode?
                before, Microsoft.CodeAnalysis.SyntaxNode?
                after, System.Func<Microsoft.CodeAnalysis.CSharp.SyntaxKind, bool>?
                ignoreChildNode, bool
                topLevel)
                {
                    var return_v = SyntaxEquivalence.AreEquivalent(before, after, ignoreChildNode: ignoreChildNode, topLevel: topLevel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 101298, 101398);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 101144, 101410);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 101144, 101410);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool AreEquivalent(SyntaxToken oldToken, SyntaxToken newToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 101679, 101850);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 101780, 101839);

                return f_10001_101787_101838(oldToken, newToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 101679, 101850);

                bool
                f_10001_101787_101838(Microsoft.CodeAnalysis.SyntaxToken
                before, Microsoft.CodeAnalysis.SyntaxToken
                after)
                {
                    var return_v = SyntaxEquivalence.AreEquivalent(before, after);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 101787, 101838);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 101679, 101850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 101679, 101850);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool AreEquivalent(SyntaxTokenList oldList, SyntaxTokenList newList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 102129, 102304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 102236, 102293);

                return f_10001_102243_102292(oldList, newList);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 102129, 102304);

                bool
                f_10001_102243_102292(Microsoft.CodeAnalysis.SyntaxTokenList
                before, Microsoft.CodeAnalysis.SyntaxTokenList
                after)
                {
                    var return_v = SyntaxEquivalence.AreEquivalent(before, after);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 102243, 102292);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 102129, 102304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 102129, 102304);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool AreEquivalent<TNode>(SyntaxList<TNode> oldList, SyntaxList<TNode> newList, bool topLevel)
                    where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 102947, 103218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 103124, 103207);

                return f_10001_103131_103206<TNode>(oldList.Node, newList.Node, null, topLevel);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 102947, 103218);

                bool
                f_10001_103131_103206<TNode>(Microsoft.CodeAnalysis.SyntaxNode?
                before, Microsoft.CodeAnalysis.SyntaxNode?
                after, System.Func<Microsoft.CodeAnalysis.CSharp.SyntaxKind, bool>?
                ignoreChildNode, bool
                topLevel) where TNode : CSharpSyntaxNode

                {
                    var return_v = SyntaxEquivalence.AreEquivalent(before, after, ignoreChildNode, topLevel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 103131, 103206);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 102947, 103218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 102947, 103218);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool AreEquivalent<TNode>(SyntaxList<TNode> oldList, SyntaxList<TNode> newList, Func<SyntaxKind, bool>? ignoreChildNode = null)
                    where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 103788, 104104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 103992, 104093);

                return f_10001_103999_104092<TNode>(oldList.Node, newList.Node, ignoreChildNode, topLevel: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 103788, 104104);

                bool
                f_10001_103999_104092<TNode>(Microsoft.CodeAnalysis.SyntaxNode?
                before, Microsoft.CodeAnalysis.SyntaxNode?
                after, System.Func<Microsoft.CodeAnalysis.CSharp.SyntaxKind, bool>?
                ignoreChildNode, bool
                topLevel) where TNode : SyntaxNode

                {
                    var return_v = SyntaxEquivalence.AreEquivalent(before, after, ignoreChildNode, topLevel: topLevel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 103999, 104092);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 103788, 104104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 103788, 104104);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool AreEquivalent<TNode>(SeparatedSyntaxList<TNode> oldList, SeparatedSyntaxList<TNode> newList, bool topLevel)
                    where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 104747, 105030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 104936, 105019);

                return f_10001_104943_105018<TNode>(oldList.Node, newList.Node, null, topLevel);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 104747, 105030);

                bool
                f_10001_104943_105018<TNode>(Microsoft.CodeAnalysis.SyntaxNode?
                before, Microsoft.CodeAnalysis.SyntaxNode?
                after, System.Func<Microsoft.CodeAnalysis.CSharp.SyntaxKind, bool>?
                ignoreChildNode, bool
                topLevel) where TNode : SyntaxNode

                {
                    var return_v = SyntaxEquivalence.AreEquivalent(before, after, ignoreChildNode, topLevel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 104943, 105018);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 104747, 105030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 104747, 105030);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool AreEquivalent<TNode>(SeparatedSyntaxList<TNode> oldList, SeparatedSyntaxList<TNode> newList, Func<SyntaxKind, bool>? ignoreChildNode = null)
                    where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 105600, 105934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 105822, 105923);

                return f_10001_105829_105922<TNode>(oldList.Node, newList.Node, ignoreChildNode, topLevel: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 105600, 105934);

                bool
                f_10001_105829_105922<TNode>(Microsoft.CodeAnalysis.SyntaxNode?
                before, Microsoft.CodeAnalysis.SyntaxNode?
                after, System.Func<Microsoft.CodeAnalysis.CSharp.SyntaxKind, bool>?
                ignoreChildNode, bool
                topLevel) where TNode : SyntaxNode

                {
                    var return_v = SyntaxEquivalence.AreEquivalent(before, after, ignoreChildNode, topLevel: topLevel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 105829, 105922);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 105600, 105934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 105600, 105934);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TypeSyntax? GetStandaloneType(TypeSyntax? node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 105946, 107161);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 106034, 107122) || true) && (node != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 106034, 107122);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 106084, 106129);

                    var
                    parent = f_10001_106097_106108(node) as ExpressionSyntax
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 106147, 107107) || true) && (parent != null && (DynAbs.Tracing.TraceSender.Expression_True(10001, 106151, 106252) && (f_10001_106170_106181(node) == SyntaxKind.IdentifierName || (DynAbs.Tracing.TraceSender.Expression_False(10001, 106170, 106251) || f_10001_106214_106225(node) == SyntaxKind.GenericName))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 106147, 107107);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 106294, 107088);

                        switch (f_10001_106302_106315(parent))
                        {

                            case SyntaxKind.QualifiedName:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 106294, 107088);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 106425, 106473);

                                var
                                qualifiedName = (QualifiedNameSyntax)parent
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 106503, 106652) || true) && (f_10001_106507_106526(qualifiedName) == node)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 106503, 106652);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 106600, 106621);

                                    return qualifiedName;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 106503, 106652);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10001, 106684, 106690);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 106294, 107088);

                            case SyntaxKind.AliasQualifiedName:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 106294, 107088);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 106781, 106839);

                                var
                                aliasQualifiedName = (AliasQualifiedNameSyntax)parent
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 106869, 107027) || true) && (f_10001_106873_106896(aliasQualifiedName) == node)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 106869, 107027);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 106970, 106996);

                                    return aliasQualifiedName;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 106869, 107027);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10001, 107059, 107065);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 106294, 107088);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 106147, 107107);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 106034, 107122);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 107138, 107150);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 105946, 107161);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10001_106097_106108(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 106097, 106108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10001_106170_106181(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 106170, 106181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10001_106214_106225(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 106214, 106225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10001_106302_106315(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 106302, 106315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10001_106507_106526(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 106507, 106526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10001_106873_106896(Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 106873, 106896);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 105946, 107161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 105946, 107161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ExpressionSyntax GetStandaloneExpression(ExpressionSyntax expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 107616, 107820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 107724, 107809);

                return f_10001_107731_107774(expression) as ExpressionSyntax ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?>(10001, 107731, 107808) ?? expression);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 107616, 107820);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10001_107731_107774(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = SyntaxFactory.GetStandaloneNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 107731, 107774);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 107616, 107820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 107616, 107820);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CSharpSyntaxNode? GetStandaloneNode(CSharpSyntaxNode? node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 108671, 112795);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 108771, 108901) || true) && (node == null || (DynAbs.Tracing.TraceSender.Expression_False(10001, 108775, 108840) || !(node is ExpressionSyntax || (DynAbs.Tracing.TraceSender.Expression_False(10001, 108793, 108839) || node is CrefSyntax))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 108771, 108901);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 108874, 108886);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 108771, 108901);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 108917, 109510);

                switch (f_10001_108925_108936(node))
                {

                    case SyntaxKind.IdentifierName:
                    case SyntaxKind.GenericName:
                    case SyntaxKind.NameMemberCref:
                    case SyntaxKind.IndexerMemberCref:
                    case SyntaxKind.OperatorMemberCref:
                    case SyntaxKind.ConversionOperatorMemberCref:
                    case SyntaxKind.ArrayType:
                    case SyntaxKind.NullableType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 108917, 109510);
                        DynAbs.Tracing.TraceSender.TraceBreak(10001, 109429, 109435);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 108917, 109510);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 108917, 109510);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 109483, 109495);

                        return node;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 108917, 109510);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 109526, 109565);

                CSharpSyntaxNode?
                parent = f_10001_109553_109564(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 109581, 109660) || true) && (parent == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 109581, 109660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 109633, 109645);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 109581, 109660);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 109676, 112756);

                switch (f_10001_109684_109697(parent))
                {

                    case SyntaxKind.QualifiedName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 109676, 112756);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 109783, 109917) || true) && (f_10001_109787_109822(((QualifiedNameSyntax)parent)) == node)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 109783, 109917);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 109880, 109894);

                            return parent;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 109783, 109917);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10001, 109941, 109947);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 109676, 112756);

                    case SyntaxKind.AliasQualifiedName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 109676, 112756);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 110022, 110160) || true) && (f_10001_110026_110065(((AliasQualifiedNameSyntax)parent)) == node)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 110022, 110160);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 110123, 110137);

                            return parent;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 110022, 110160);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10001, 110184, 110190);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 109676, 112756);

                    case SyntaxKind.SimpleMemberAccessExpression:
                    case SyntaxKind.PointerMemberAccessExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 109676, 112756);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 110339, 110481) || true) && (f_10001_110343_110386(((MemberAccessExpressionSyntax)parent)) == node)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 110339, 110481);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 110444, 110458);

                            return parent;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 110339, 110481);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10001, 110505, 110511);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 109676, 112756);

                    case SyntaxKind.MemberBindingExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 109676, 112756);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 110620, 110775) || true) && (f_10001_110624_110668(((MemberBindingExpressionSyntax)parent)) == node)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 110620, 110775);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 110734, 110748);

                                return parent;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 110620, 110775);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10001, 110803, 110809);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 109676, 112756);

                    case SyntaxKind.NameMemberCref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 109676, 112756);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 111056, 111406) || true) && (f_10001_111060_111095(((NameMemberCrefSyntax)parent)) == node)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 111056, 111406);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 111153, 111199);

                            CSharpSyntaxNode?
                            grandparent = f_10001_111185_111198(parent)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 111225, 111383);

                            return (DynAbs.Tracing.TraceSender.Conditional_F1(10001, 111232, 111301) || ((grandparent != null && (DynAbs.Tracing.TraceSender.Expression_True(10001, 111232, 111301) && f_10001_111255_111273(grandparent) == SyntaxKind.QualifiedCref
                            ) && DynAbs.Tracing.TraceSender.Conditional_F2(10001, 111333, 111344)) || DynAbs.Tracing.TraceSender.Conditional_F3(10001, 111376, 111382))) ? grandparent
                            : parent;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 111056, 111406);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10001, 111430, 111436);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 109676, 112756);

                    case SyntaxKind.QualifiedCref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 109676, 112756);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 111508, 111643) || true) && (f_10001_111512_111548(((QualifiedCrefSyntax)parent)) == node)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 111508, 111643);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 111606, 111620);

                            return parent;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 111508, 111643);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10001, 111667, 111673);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 109676, 112756);

                    case SyntaxKind.ArrayCreationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 109676, 112756);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 111755, 111898) || true) && (f_10001_111759_111803(((ArrayCreationExpressionSyntax)parent)) == node)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 111755, 111898);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 111861, 111875);

                            return parent;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 111755, 111898);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10001, 111922, 111928);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 109676, 112756);

                    case SyntaxKind.ObjectCreationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 109676, 112756);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 112011, 112197) || true) && (f_10001_112015_112026(node) == SyntaxKind.NullableType && (DynAbs.Tracing.TraceSender.Expression_True(10001, 112015, 112110) && f_10001_112057_112102(((ObjectCreationExpressionSyntax)parent)) == node))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 112011, 112197);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 112160, 112174);

                            return parent;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 112011, 112197);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10001, 112221, 112227);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 109676, 112756);

                    case SyntaxKind.StackAllocArrayCreationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 109676, 112756);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 112319, 112472) || true) && (f_10001_112323_112377(((StackAllocArrayCreationExpressionSyntax)parent)) == node)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 112319, 112472);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 112435, 112449);

                            return parent;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 112319, 112472);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10001, 112496, 112502);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 109676, 112756);

                    case SyntaxKind.NameColon:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 109676, 112756);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 112570, 112711) || true) && (f_10001_112574_112617(f_10001_112574_112587(parent), SyntaxKind.Subpattern))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 112570, 112711);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 112667, 112688);

                            return f_10001_112674_112687(parent);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 112570, 112711);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10001, 112735, 112741);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 109676, 112756);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 112772, 112784);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 108671, 112795);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10001_108925_108936(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 108925, 108936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10001_109553_109564(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 109553, 109564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10001_109684_109697(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 109684, 109697);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10001_109787_109822(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 109787, 109822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10001_110026_110065(Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 110026, 110065);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10001_110343_110386(Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 110343, 110386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10001_110624_110668(Microsoft.CodeAnalysis.CSharp.Syntax.MemberBindingExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 110624, 110668);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10001_111060_111095(Microsoft.CodeAnalysis.CSharp.Syntax.NameMemberCrefSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 111060, 111095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10001_111185_111198(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 111185, 111198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10001_111255_111273(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 111255, 111273);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.MemberCrefSyntax
                f_10001_111512_111548(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedCrefSyntax
                this_param)
                {
                    var return_v = this_param.Member;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 111512, 111548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax
                f_10001_111759_111803(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayCreationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 111759, 111803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10001_112015_112026(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 112015, 112026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10001_112057_112102(Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 112057, 112102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10001_112323_112377(Microsoft.CodeAnalysis.CSharp.Syntax.StackAllocArrayCreationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 112323, 112377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10001_112574_112587(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 112574, 112587);
                    return return_v;
                }


                bool
                f_10001_112574_112617(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 112574, 112617);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10001_112674_112687(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 112674, 112687);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 108671, 112795);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 108671, 112795);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ConditionalAccessExpressionSyntax? FindConditionalAccessNodeForBinding(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 112951, 114099);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 113085, 113108);

                var
                currentNode = node
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 113124, 113282);

                f_10001_113124_113281(f_10001_113137_113155(currentNode) == SyntaxKind.MemberBindingExpression || (DynAbs.Tracing.TraceSender.Expression_False(10001, 113137, 113280) || f_10001_113223_113241(currentNode) == SyntaxKind.ElementBindingExpression));
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 113467, 114060) || true) && (currentNode != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 113467, 114060);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 113527, 113560);

                        currentNode = f_10001_113541_113559(currentNode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 113578, 113666);

                        f_10001_113578_113665(currentNode != null, "binding should be enclosed in a conditional access");

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 113686, 114045) || true) && (f_10001_113690_113708(currentNode) == SyntaxKind.ConditionalAccessExpression)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 113686, 114045);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 113792, 113856);

                            var
                            condAccess = (ConditionalAccessExpressionSyntax)currentNode
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 113878, 114026) || true) && (condAccess.OperatorToken.EndPosition == f_10001_113922_113935(node))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 113878, 114026);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 113985, 114003);

                                return condAccess;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 113878, 114026);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 113686, 114045);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 113467, 114060);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10001, 113467, 114060);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10001, 113467, 114060);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 114076, 114088);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 112951, 114099);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10001_113137_113155(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 113137, 113155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10001_113223_113241(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 113223, 113241);
                    return return_v;
                }


                int
                f_10001_113124_113281(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 113124, 113281);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10001_113541_113559(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 113541, 113559);
                    return return_v;
                }


                int
                f_10001_113578_113665(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 113578, 113665);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10001_113690_113708(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 113690, 113708);
                    return return_v;
                }


                int
                f_10001_113922_113935(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 113922, 113935);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 112951, 114099);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 112951, 114099);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ExpressionSyntax? GetNonGenericExpression(ExpressionSyntax expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 114326, 116190);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 114435, 116147) || true) && (expression != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 114435, 116147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 114491, 116132);

                    switch (f_10001_114499_114516(expression))
                    {

                        case SyntaxKind.SimpleMemberAccessExpression:
                        case SyntaxKind.PointerMemberAccessExpression:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 114491, 116132);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 114697, 114748);

                            var
                            max = (MemberAccessExpressionSyntax)expression
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 114774, 115108) || true) && (f_10001_114778_114793(f_10001_114778_114786(max)) == SyntaxKind.GenericName)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 114774, 115108);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 114877, 114914);

                                var
                                gn = (GenericNameSyntax)f_10001_114905_114913(max)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 114944, 115081);

                                return f_10001_114951_115080(f_10001_114982_114999(expression), f_10001_115001_115015(max), f_10001_115017_115034(max), f_10001_115036_115079(f_10001_115065_115078(gn)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 114774, 115108);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10001, 115134, 115140);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 114491, 116132);

                        case SyntaxKind.QualifiedName:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 114491, 116132);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 115218, 115259);

                            var
                            qn = (QualifiedNameSyntax)expression
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 115285, 115584) || true) && (f_10001_115289_115304(f_10001_115289_115297(qn)) == SyntaxKind.GenericName)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 115285, 115584);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 115388, 115425);

                                var
                                gn = (GenericNameSyntax)f_10001_115416_115424(qn)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 115455, 115557);

                                return f_10001_115462_115556(f_10001_115490_115497(qn), f_10001_115499_115510(qn), f_10001_115512_115555(f_10001_115541_115554(gn)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 115285, 115584);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10001, 115610, 115616);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 114491, 116132);

                        case SyntaxKind.AliasQualifiedName:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 114491, 116132);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 115699, 115745);

                            var
                            an = (AliasQualifiedNameSyntax)expression
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 115771, 116081) || true) && (f_10001_115775_115789(f_10001_115775_115782(an)) == SyntaxKind.GenericName)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 115771, 116081);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 115873, 115909);

                                var
                                gn = (GenericNameSyntax)f_10001_115901_115908(an)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 115939, 116054);

                                return f_10001_115946_116053(f_10001_115979_115987(an), f_10001_115989_116007(an), f_10001_116009_116052(f_10001_116038_116051(gn)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 115771, 116081);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10001, 116107, 116113);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 114491, 116132);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 114435, 116147);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 116161, 116179);

                return expression;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 114326, 116190);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10001_114499_114516(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 114499, 114516);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10001_114778_114786(Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 114778, 114786);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10001_114778_114793(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 114778, 114793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10001_114905_114913(Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 114905, 114913);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10001_114982_114999(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 114982, 114999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10001_115001_115015(Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 115001, 115015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_115017_115034(Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax
                this_param)
                {
                    var return_v = this_param.OperatorToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 115017, 115034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_115065_115078(Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 115065, 115078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10001_115036_115079(Microsoft.CodeAnalysis.SyntaxToken
                identifier)
                {
                    var return_v = SyntaxFactory.IdentifierName(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 115036, 115079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                f_10001_114951_115080(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                left, Microsoft.CodeAnalysis.SyntaxToken
                operatorToken, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                right)
                {
                    var return_v = SyntaxFactory.BinaryExpression(kind, left, operatorToken, (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 114951, 115080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10001_115289_115297(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 115289, 115297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10001_115289_115304(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 115289, 115304);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10001_115416_115424(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 115416, 115424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10001_115490_115497(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 115490, 115497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_115499_115510(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.DotToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 115499, 115510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_115541_115554(Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 115541, 115554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10001_115512_115555(Microsoft.CodeAnalysis.SyntaxToken
                identifier)
                {
                    var return_v = SyntaxFactory.IdentifierName(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 115512, 115555);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                f_10001_115462_115556(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                left, Microsoft.CodeAnalysis.SyntaxToken
                dotToken, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                right)
                {
                    var return_v = SyntaxFactory.QualifiedName(left, dotToken, (Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 115462, 115556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10001_115775_115782(Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 115775, 115782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10001_115775_115789(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 115775, 115789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10001_115901_115908(Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 115901, 115908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10001_115979_115987(Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Alias;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 115979, 115987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_115989_116007(Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.ColonColonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 115989, 116007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_116038_116051(Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 116038, 116051);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10001_116009_116052(Microsoft.CodeAnalysis.SyntaxToken
                identifier)
                {
                    var return_v = SyntaxFactory.IdentifierName(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 116009, 116052);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax
                f_10001_115946_116053(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                alias, Microsoft.CodeAnalysis.SyntaxToken
                colonColonToken, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                name)
                {
                    var return_v = SyntaxFactory.AliasQualifiedName(alias, colonColonToken, (Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax)name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 115946, 116053);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 114326, 116190);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 114326, 116190);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsCompleteSubmission(SyntaxTree tree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 116458, 120250);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 116539, 116650) || true) && (tree == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 116539, 116650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 116589, 116635);

                    throw f_10001_116595_116634(nameof(tree));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 116539, 116650);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 116664, 116831) || true) && (f_10001_116668_116685(f_10001_116668_116680(tree)) != SourceCodeKind.Script)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 116664, 116831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 116744, 116816);

                    throw f_10001_116750_116815(f_10001_116772_116814());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 116664, 116831);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 116847, 116941) || true) && (f_10001_116851_116879_M(!tree.HasCompilationUnitRoot))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 116847, 116941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 116913, 116926);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 116847, 116941);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 116957, 117013);

                var
                compilation = (CompilationUnitSyntax)f_10001_116998_117012(tree)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 117027, 117114) || true) && (f_10001_117031_117053_M(!compilation.HasErrors))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 117027, 117114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 117087, 117099);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 117027, 117114);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 117130, 117541);
                    foreach (var error in f_10001_117152_117195_I(compilation.EndOfFileToken.GetDiagnostics()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 117130, 117541);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 117229, 117526);

                        switch ((ErrorCode)f_10001_117248_117258(error))
                        {

                            case ErrorCode.ERR_OpenEndedComment:
                            case ErrorCode.ERR_EndifDirectiveExpected:
                            case ErrorCode.ERR_EndRegionDirectiveExpected:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 117229, 117526);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 117494, 117507);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 117229, 117526);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 117130, 117541);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10001, 1, 412);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10001, 1, 412);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 117557, 117613);

                var
                lastNode = f_10001_117572_117612(f_10001_117572_117596(compilation))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 117627, 117708) || true) && (lastNode == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 117627, 117708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 117681, 117693);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 117627, 117708);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 117773, 117962) || true) && (f_10001_117777_117803(lastNode) && (DynAbs.Tracing.TraceSender.Expression_True(10001, 117777, 117835) && f_10001_117807_117835(lastNode)) && (DynAbs.Tracing.TraceSender.Expression_True(10001, 117777, 117900) && f_10001_117839_117900(f_10001_117871_117899(lastNode))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 117773, 117962);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 117934, 117947);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 117773, 117962);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 117978, 118088) || true) && (f_10001_117982_118026(lastNode, SyntaxKind.IncompleteMember))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 117978, 118088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 118060, 118073);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 117978, 118088);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 118337, 118631) || true) && (!f_10001_118342_118385(lastNode, SyntaxKind.GlobalStatement))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 118337, 118631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 118419, 118567);

                    var
                    closingToken = f_10001_118438_118566(lastNode, includeZeroWidth: true, includeSkipped: true, includeDirectives: true, includeDocumentationComments: true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 118585, 118616);

                    return f_10001_118592_118615_M(!closingToken.IsMissing);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 118337, 118631);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 118647, 118701);

                var
                globalStatement = (GlobalStatementSyntax)lastNode
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 118715, 118856);

                var
                token = f_10001_118727_118855(lastNode, includeZeroWidth: true, includeSkipped: true, includeDirectives: true, includeDocumentationComments: true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 118872, 119543) || true) && (token.IsMissing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 118872, 119543);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 119021, 119297) || true) && (f_10001_119025_119042(f_10001_119025_119037(tree)) == SourceCodeKind.Regular || (DynAbs.Tracing.TraceSender.Expression_False(10001, 119025, 119158) || !f_10001_119094_119158(f_10001_119094_119119(globalStatement), SyntaxKind.ExpressionStatement)) || (DynAbs.Tracing.TraceSender.Expression_False(10001, 119025, 119223) || !token.IsKind(SyntaxKind.SemicolonToken)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 119021, 119297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 119265, 119278);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 119021, 119297);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 119317, 119417);

                    token = token.GetPreviousToken(predicate: SyntaxToken.Any, stepInto: CodeAnalysis.SyntaxTrivia.Any);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 119435, 119528) || true) && (token.IsMissing)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 119435, 119528);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 119496, 119509);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 119435, 119528);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 118872, 119543);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 119559, 120211);
                    foreach (var error in f_10001_119581_119603_I(token.GetDiagnostics()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 119559, 120211);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 119637, 120196);

                        switch ((ErrorCode)f_10001_119656_119666(error))
                        {

                            case ErrorCode.ERR_NewlineInConst:

                            // unterminated verbatim string literal:
                            case ErrorCode.ERR_UnterminatedStringLit:

                            // unexpected token following a global statement:
                            case ErrorCode.ERR_GlobalDefinitionOrStatementExpected:
                            case ErrorCode.ERR_EOFExpected:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 119637, 120196);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 120164, 120177);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 119637, 120196);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 119559, 120211);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10001, 1, 653);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10001, 1, 653);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 120227, 120239);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 116458, 120250);

                System.ArgumentNullException
                f_10001_116595_116634(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 116595, 116634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParseOptions
                f_10001_116668_116680(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 116668, 116680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceCodeKind
                f_10001_116668_116685(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 116668, 116685);
                    return return_v;
                }


                string
                f_10001_116772_116814()
                {
                    var return_v = CSharpResources.SyntaxTreeIsNotASubmission;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 116772, 116814);
                    return return_v;
                }


                System.ArgumentException
                f_10001_116750_116815(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 116750, 116815);
                    return return_v;
                }


                bool
                f_10001_116851_116879_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 116851, 116879);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10001_116998_117012(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 116998, 117012);
                    return return_v;
                }


                bool
                f_10001_117031_117053_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 117031, 117053);
                    return return_v;
                }


                int
                f_10001_117248_117258(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 117248, 117258);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10001_117152_117195_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 117152, 117195);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_10001_117572_117596(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.ChildNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 117572, 117596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10001_117572_117612(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.LastOrDefault<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 117572, 117612);
                    return return_v;
                }


                bool
                f_10001_117777_117803(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.HasTrailingTrivia;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 117777, 117803);
                    return return_v;
                }


                bool
                f_10001_117807_117835(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ContainsDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 117807, 117835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10001_117871_117899(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetTrailingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 117871, 117899);
                    return return_v;
                }


                bool
                f_10001_117839_117900(Microsoft.CodeAnalysis.SyntaxTriviaList
                triviaList)
                {
                    var return_v = HasUnterminatedMultiLineComment(triviaList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 117839, 117900);
                    return return_v;
                }


                bool
                f_10001_117982_118026(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 117982, 118026);
                    return return_v;
                }


                bool
                f_10001_118342_118385(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 118342, 118385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_118438_118566(Microsoft.CodeAnalysis.SyntaxNode
                this_param, bool
                includeZeroWidth, bool
                includeSkipped, bool
                includeDirectives, bool
                includeDocumentationComments)
                {
                    var return_v = this_param.GetLastToken(includeZeroWidth: includeZeroWidth, includeSkipped: includeSkipped, includeDirectives: includeDirectives, includeDocumentationComments: includeDocumentationComments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 118438, 118566);
                    return return_v;
                }


                bool
                f_10001_118592_118615_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 118592, 118615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_118727_118855(Microsoft.CodeAnalysis.SyntaxNode
                this_param, bool
                includeZeroWidth, bool
                includeSkipped, bool
                includeDirectives, bool
                includeDocumentationComments)
                {
                    var return_v = this_param.GetLastToken(includeZeroWidth: includeZeroWidth, includeSkipped: includeSkipped, includeDirectives: includeDirectives, includeDocumentationComments: includeDocumentationComments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 118727, 118855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParseOptions
                f_10001_119025_119037(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 119025, 119037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceCodeKind
                f_10001_119025_119042(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 119025, 119042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                f_10001_119094_119119(Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 119094, 119119);
                    return return_v;
                }


                bool
                f_10001_119094_119158(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 119094, 119158);
                    return return_v;
                }


                int
                f_10001_119656_119666(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10001, 119656, 119666);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10001_119581_119603_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 119581, 119603);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 116458, 120250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 116458, 120250);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasUnterminatedMultiLineComment(SyntaxTriviaList triviaList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 120262, 120646);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 120367, 120606);
                    foreach (var trivia in f_10001_120390_120400_I(triviaList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 120367, 120606);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 120434, 120591) || true) && (trivia.ContainsDiagnostics && (DynAbs.Tracing.TraceSender.Expression_True(10001, 120438, 120518) && trivia.Kind() == SyntaxKind.MultiLineCommentTrivia))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10001, 120434, 120591);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 120560, 120572);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 120434, 120591);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10001, 120367, 120606);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10001, 1, 240);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10001, 1, 240);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 120622, 120635);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 120262, 120646);

                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10001_120390_120400_I(Microsoft.CodeAnalysis.SyntaxTriviaList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 120390, 120400);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 120262, 120646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 120262, 120646);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CaseSwitchLabelSyntax CaseSwitchLabel(ExpressionSyntax value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 120736, 120980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 120836, 120969);

                return f_10001_120843_120968(f_10001_120873_120916(SyntaxKind.CaseKeyword), value, f_10001_120925_120967(SyntaxKind.ColonToken));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 120736, 120980);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_120873_120916(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 120873, 120916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_120925_120967(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 120925, 120967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax
                f_10001_120843_120968(Microsoft.CodeAnalysis.SyntaxToken
                keyword, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                value, Microsoft.CodeAnalysis.SyntaxToken
                colonToken)
                {
                    var return_v = SyntaxFactory.CaseSwitchLabel(keyword, value, colonToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 120843, 120968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 120736, 120980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 120736, 120980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static DefaultSwitchLabelSyntax DefaultSwitchLabel()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 121073, 121300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 121157, 121289);

                return f_10001_121164_121288(f_10001_121197_121243(SyntaxKind.DefaultKeyword), f_10001_121245_121287(SyntaxKind.ColonToken));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 121073, 121300);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_121197_121243(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 121197, 121243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_121245_121287(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 121245, 121287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DefaultSwitchLabelSyntax
                f_10001_121164_121288(Microsoft.CodeAnalysis.SyntaxToken
                keyword, Microsoft.CodeAnalysis.SyntaxToken
                colonToken)
                {
                    var return_v = SyntaxFactory.DefaultSwitchLabel(keyword, colonToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 121164, 121288);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 121073, 121300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 121073, 121300);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BlockSyntax Block(params StatementSyntax[] statements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 121380, 121515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 121473, 121504);

                return f_10001_121480_121503(f_10001_121486_121502(statements));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 121380, 121515);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                f_10001_121486_121502(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax[]
                nodes)
                {
                    var return_v = List((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>)nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 121486, 121502);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10001_121480_121503(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                statements)
                {
                    var return_v = Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 121480, 121503);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 121380, 121515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 121380, 121515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BlockSyntax Block(IEnumerable<StatementSyntax> statements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 121595, 121734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 121692, 121723);

                return f_10001_121699_121722(f_10001_121705_121721(statements));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 121595, 121734);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                f_10001_121705_121721(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                nodes)
                {
                    var return_v = List(nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 121705, 121721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10001_121699_121722(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                statements)
                {
                    var return_v = Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 121699, 121722);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 121595, 121734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 121595, 121734);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static PropertyDeclarationSyntax PropertyDeclaration(
                    SyntaxList<AttributeListSyntax> attributeLists,
                    SyntaxTokenList modifiers,
                    TypeSyntax type,
                    ExplicitInterfaceSpecifierSyntax explicitInterfaceSpecifier,
                    SyntaxToken identifier,
                    AccessorListSyntax accessorList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 121746, 122436);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 122119, 122425);

                return f_10001_122126_122424(attributeLists, modifiers, type, explicitInterfaceSpecifier, identifier, accessorList, expressionBody: null, initializer: null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 121746, 122436);

                Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                f_10001_122126_122424(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
                explicitInterfaceSpecifier, Microsoft.CodeAnalysis.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax
                accessorList, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                expressionBody, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                initializer)
                {
                    var return_v = SyntaxFactory.PropertyDeclaration(attributeLists, modifiers, type, explicitInterfaceSpecifier, identifier, accessorList, expressionBody: expressionBody, initializer: initializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 122126, 122424);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 121746, 122436);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 121746, 122436);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ConversionOperatorDeclarationSyntax ConversionOperatorDeclaration(
                    SyntaxList<AttributeListSyntax> attributeLists,
                    SyntaxTokenList modifiers,
                    SyntaxToken implicitOrExplicitKeyword,
                    SyntaxToken operatorKeyword,
                    TypeSyntax type,
                    ParameterListSyntax parameterList,
                    BlockSyntax body,
                    SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 122448, 123364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 122898, 123353);

                return f_10001_122905_123352(attributeLists: attributeLists, modifiers: modifiers, implicitOrExplicitKeyword: implicitOrExplicitKeyword, operatorKeyword: operatorKeyword, type: type, parameterList: parameterList, body: body, expressionBody: null, semicolonToken: semicolonToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 122448, 123364);

                Microsoft.CodeAnalysis.CSharp.Syntax.ConversionOperatorDeclarationSyntax
                f_10001_122905_123352(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.SyntaxToken
                implicitOrExplicitKeyword, Microsoft.CodeAnalysis.SyntaxToken
                operatorKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                body, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                expressionBody, Microsoft.CodeAnalysis.SyntaxToken
                semicolonToken)
                {
                    var return_v = SyntaxFactory.ConversionOperatorDeclaration(attributeLists: attributeLists, modifiers: modifiers, implicitOrExplicitKeyword: implicitOrExplicitKeyword, operatorKeyword: operatorKeyword, type: type, parameterList: parameterList, body: body, expressionBody: expressionBody, semicolonToken: semicolonToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 122905, 123352);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 122448, 123364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 122448, 123364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static OperatorDeclarationSyntax OperatorDeclaration(
                    SyntaxList<AttributeListSyntax> attributeLists,
                    SyntaxTokenList modifiers,
                    TypeSyntax returnType,
                    SyntaxToken operatorKeyword,
                    SyntaxToken operatorToken,
                    ParameterListSyntax parameterList,
                    BlockSyntax body,
                    SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 123376, 124244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 123800, 124233);

                return f_10001_123807_124232(attributeLists: attributeLists, modifiers: modifiers, returnType: returnType, operatorKeyword: operatorKeyword, operatorToken: operatorToken, parameterList: parameterList, body: body, expressionBody: null, semicolonToken: semicolonToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 123376, 124244);

                Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
                f_10001_123807_124232(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                returnType, Microsoft.CodeAnalysis.SyntaxToken
                operatorKeyword, Microsoft.CodeAnalysis.SyntaxToken
                operatorToken, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                body, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                expressionBody, Microsoft.CodeAnalysis.SyntaxToken
                semicolonToken)
                {
                    var return_v = SyntaxFactory.OperatorDeclaration(attributeLists: attributeLists, modifiers: modifiers, returnType: returnType, operatorKeyword: operatorKeyword, operatorToken: operatorToken, parameterList: parameterList, body: body, expressionBody: expressionBody, semicolonToken: semicolonToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 123807, 124232);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 123376, 124244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 123376, 124244);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static UsingDirectiveSyntax UsingDirective(NameEqualsSyntax alias, NameSyntax name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 124333, 124726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 124448, 124715);

                return f_10001_124455_124714(usingKeyword: f_10001_124502_124532(SyntaxKind.UsingKeyword), staticKeyword: default(SyntaxToken), alias: alias, name: name, semicolonToken: f_10001_124681_124713(SyntaxKind.SemicolonToken));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 124333, 124726);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_124502_124532(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 124502, 124532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_124681_124713(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 124681, 124713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                f_10001_124455_124714(Microsoft.CodeAnalysis.SyntaxToken
                usingKeyword, Microsoft.CodeAnalysis.SyntaxToken
                staticKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                alias, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                name, Microsoft.CodeAnalysis.SyntaxToken
                semicolonToken)
                {
                    var return_v = UsingDirective(usingKeyword: usingKeyword, staticKeyword: staticKeyword, alias: alias, name: name, semicolonToken: semicolonToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 124455, 124714);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 124333, 124726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 124333, 124726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ClassOrStructConstraintSyntax ClassOrStructConstraint(SyntaxKind kind, SyntaxToken classOrStructKeyword)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 124824, 125074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 124967, 125063);

                return f_10001_124974_125062(kind, classOrStructKeyword, questionToken: default(SyntaxToken));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 124824, 125074);

                Microsoft.CodeAnalysis.CSharp.Syntax.ClassOrStructConstraintSyntax
                f_10001_124974_125062(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.SyntaxToken
                classOrStructKeyword, Microsoft.CodeAnalysis.SyntaxToken
                questionToken)
                {
                    var return_v = ClassOrStructConstraint(kind, classOrStructKeyword, questionToken: questionToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 124974, 125062);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 124824, 125074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 124824, 125074);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AccessorDeclarationSyntax AccessorDeclaration(SyntaxKind kind, SyntaxList<AttributeListSyntax> attributeLists, SyntaxTokenList modifiers, BlockSyntax body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10001, 125326, 125423);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 125329, 125423);
                return f_10001_125329_125423(kind, attributeLists, modifiers, body, expressionBody: null); DynAbs.Tracing.TraceSender.TraceExitMethod(10001, 125326, 125423);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 125326, 125423);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 125326, 125423);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AccessorDeclarationSyntax AccessorDeclaration(SyntaxKind kind, SyntaxList<AttributeListSyntax> attributeLists, SyntaxTokenList modifiers, SyntaxToken keyword, BlockSyntax body, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10001, 125670, 125792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 125673, 125792);
                return f_10001_125673_125792(kind, attributeLists, modifiers, keyword, body, expressionBody: null, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10001, 125670, 125792);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 125670, 125792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 125670, 125792);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AccessorDeclarationSyntax AccessorDeclaration(SyntaxKind kind, SyntaxList<AttributeListSyntax> attributeLists, SyntaxTokenList modifiers, ArrowExpressionClauseSyntax expressionBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10001, 126016, 126113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 126019, 126113);
                return f_10001_126019_126113(kind, attributeLists, modifiers, body: null, expressionBody); DynAbs.Tracing.TraceSender.TraceExitMethod(10001, 126016, 126113);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 126016, 126113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 126016, 126113);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AccessorDeclarationSyntax AccessorDeclaration(SyntaxKind kind, SyntaxList<AttributeListSyntax> attributeLists, SyntaxTokenList modifiers, SyntaxToken keyword, ArrowExpressionClauseSyntax expressionBody, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10001, 126386, 126508);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 126389, 126508);
                return f_10001_126389_126508(kind, attributeLists, modifiers, keyword, body: null, expressionBody, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10001, 126386, 126508);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 126386, 126508);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 126386, 126508);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static EnumMemberDeclarationSyntax EnumMemberDeclaration(SyntaxList<AttributeListSyntax> attributeLists, SyntaxToken identifier, EqualsValueClauseSyntax equalsValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10001, 126707, 126809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 126710, 126809);
                return f_10001_126710_126809(attributeLists, modifiers: default, identifier, equalsValue); DynAbs.Tracing.TraceSender.TraceExitMethod(10001, 126707, 126809);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 126707, 126809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 126707, 126809);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static NamespaceDeclarationSyntax NamespaceDeclaration(NameSyntax name, SyntaxList<ExternAliasDirectiveSyntax> externs, SyntaxList<UsingDirectiveSyntax> usings, SyntaxList<MemberDeclarationSyntax> members)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10001, 127048, 127165);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 127051, 127165);
                return f_10001_127051_127165(attributeLists: default, modifiers: default, name, externs, usings, members); DynAbs.Tracing.TraceSender.TraceExitMethod(10001, 127048, 127165);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 127048, 127165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 127048, 127165);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static NamespaceDeclarationSyntax NamespaceDeclaration(SyntaxToken namespaceKeyword, NameSyntax name, SyntaxToken openBraceToken, SyntaxList<ExternAliasDirectiveSyntax> externs, SyntaxList<UsingDirectiveSyntax> usings, SyntaxList<MemberDeclarationSyntax> members, SyntaxToken closeBraceToken, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10001, 127519, 127703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 127522, 127703);
                return f_10001_127522_127703(attributeLists: default, modifiers: default, namespaceKeyword, name, openBraceToken, externs, usings, members, closeBraceToken, semicolonToken); DynAbs.Tracing.TraceSender.TraceExitMethod(10001, 127519, 127703);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 127519, 127703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 127519, 127703);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static EventDeclarationSyntax EventDeclaration(SyntaxList<AttributeListSyntax> attributeLists, SyntaxTokenList modifiers, SyntaxToken eventKeyword, TypeSyntax type, ExplicitInterfaceSpecifierSyntax explicitInterfaceSpecifier, SyntaxToken identifier, AccessorListSyntax accessorList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 127795, 128270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 128109, 128259);

                return f_10001_128116_128258(attributeLists, modifiers, eventKeyword, type, explicitInterfaceSpecifier, identifier, accessorList, semicolonToken: default);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 127795, 128270);

                Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
                f_10001_128116_128258(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.SyntaxToken
                eventKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
                explicitInterfaceSpecifier, Microsoft.CodeAnalysis.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax
                accessorList, Microsoft.CodeAnalysis.SyntaxToken
                semicolonToken)
                {
                    var return_v = EventDeclaration(attributeLists, modifiers, eventKeyword, type, explicitInterfaceSpecifier, identifier, accessorList, semicolonToken: semicolonToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 128116, 128258);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 127795, 128270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 127795, 128270);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static EventDeclarationSyntax EventDeclaration(SyntaxList<AttributeListSyntax> attributeLists, SyntaxTokenList modifiers, SyntaxToken eventKeyword, TypeSyntax type, ExplicitInterfaceSpecifierSyntax explicitInterfaceSpecifier, SyntaxToken identifier, SyntaxToken semicolonToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 128361, 128828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 128670, 128817);

                return f_10001_128677_128816(attributeLists, modifiers, eventKeyword, type, explicitInterfaceSpecifier, identifier, accessorList: null, semicolonToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 128361, 128828);

                Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
                f_10001_128677_128816(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.SyntaxToken
                eventKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
                explicitInterfaceSpecifier, Microsoft.CodeAnalysis.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax?
                accessorList, Microsoft.CodeAnalysis.SyntaxToken
                semicolonToken)
                {
                    var return_v = EventDeclaration(attributeLists, modifiers, eventKeyword, type, explicitInterfaceSpecifier, identifier, accessorList: accessorList, semicolonToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 128677, 128816);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 128361, 128828);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 128361, 128828);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SwitchStatementSyntax SwitchStatement(ExpressionSyntax expression, SyntaxList<SwitchSectionSyntax> sections)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 128918, 129740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 129065, 129123);

                bool
                needsParens = !(expression is TupleExpressionSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 129137, 129224);

                var
                openParen = (DynAbs.Tracing.TraceSender.Conditional_F1(10001, 129153, 129164) || ((needsParens && DynAbs.Tracing.TraceSender.Conditional_F2(10001, 129167, 129213)) || DynAbs.Tracing.TraceSender.Conditional_F3(10001, 129216, 129223))) ? f_10001_129167_129213(SyntaxKind.OpenParenToken) : default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 129238, 129327);

                var
                closeParen = (DynAbs.Tracing.TraceSender.Conditional_F1(10001, 129255, 129266) || ((needsParens && DynAbs.Tracing.TraceSender.Conditional_F2(10001, 129269, 129316)) || DynAbs.Tracing.TraceSender.Conditional_F3(10001, 129319, 129326))) ? f_10001_129269_129316(SyntaxKind.CloseParenToken) : default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 129341, 129729);

                return f_10001_129348_129728(attributeLists: default, f_10001_129438_129483(SyntaxKind.SwitchKeyword), openParen, expression, closeParen, f_10001_129588_129634(SyntaxKind.OpenBraceToken), sections, f_10001_129680_129727(SyntaxKind.CloseBraceToken));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 128918, 129740);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_129167_129213(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 129167, 129213);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_129269_129316(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 129269, 129316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_129438_129483(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 129438, 129483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_129588_129634(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 129588, 129634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10001_129680_129727(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 129680, 129727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                f_10001_129348_129728(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                attributeLists, Microsoft.CodeAnalysis.SyntaxToken
                switchKeyword, Microsoft.CodeAnalysis.SyntaxToken
                openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.SyntaxToken
                closeParenToken, Microsoft.CodeAnalysis.SyntaxToken
                openBraceToken, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>
                sections, Microsoft.CodeAnalysis.SyntaxToken
                closeBraceToken)
                {
                    var return_v = SyntaxFactory.SwitchStatement(attributeLists: attributeLists, switchKeyword, openParenToken, expression, closeParenToken, openBraceToken, sections, closeBraceToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 129348, 129728);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 128918, 129740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 128918, 129740);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SwitchStatementSyntax SwitchStatement(ExpressionSyntax expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 129830, 130037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 129935, 130026);

                return f_10001_129942_130025(expression, default(SyntaxList<SwitchSectionSyntax>));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 129830, 130037);

                Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                f_10001_129942_130025(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>
                sections)
                {
                    var return_v = SyntaxFactory.SwitchStatement(expression, sections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 129942, 130025);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 129830, 130037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 129830, 130037);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SimpleLambdaExpressionSyntax SimpleLambdaExpression(ParameterSyntax parameter, CSharpSyntaxNode body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10001, 130178, 130355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 130181, 130355);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10001, 130181, 130206) || ((body is BlockSyntax block
                && DynAbs.Tracing.TraceSender.Conditional_F2(10001, 130226, 130272)) || DynAbs.Tracing.TraceSender.Conditional_F3(10001, 130292, 130355))) ? f_10001_130226_130272(parameter, (BlockSyntax)body, null) : f_10001_130292_130355(parameter, null, body); DynAbs.Tracing.TraceSender.TraceExitMethod(10001, 130178, 130355);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 130178, 130355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 130178, 130355);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SimpleLambdaExpressionSyntax SimpleLambdaExpression(SyntaxToken asyncKeyword, ParameterSyntax parameter, SyntaxToken arrowToken, CSharpSyntaxNode body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10001, 130547, 130776);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 130550, 130776);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10001, 130550, 130575) || ((body is BlockSyntax block
                && DynAbs.Tracing.TraceSender.Conditional_F2(10001, 130595, 130667)) || DynAbs.Tracing.TraceSender.Conditional_F3(10001, 130687, 130776))) ? f_10001_130595_130667(asyncKeyword, parameter, arrowToken, (BlockSyntax)body, null) : f_10001_130687_130776(asyncKeyword, parameter, arrowToken, null, body); DynAbs.Tracing.TraceSender.TraceExitMethod(10001, 130547, 130776);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 130547, 130776);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 130547, 130776);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ParenthesizedLambdaExpressionSyntax ParenthesizedLambdaExpression(CSharpSyntaxNode body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10001, 130905, 130960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 130908, 130960);
                return f_10001_130908_130960(f_10001_130938_130953(), body); DynAbs.Tracing.TraceSender.TraceExitMethod(10001, 130905, 130960);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 130905, 130960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 130905, 130960);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ParenthesizedLambdaExpressionSyntax ParenthesizedLambdaExpression(ParameterListSyntax parameterList, CSharpSyntaxNode body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10001, 131124, 131323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 131127, 131323);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10001, 131127, 131152) || ((body is BlockSyntax block
                && DynAbs.Tracing.TraceSender.Conditional_F2(10001, 131172, 131229)) || DynAbs.Tracing.TraceSender.Conditional_F3(10001, 131249, 131323))) ? f_10001_131172_131229(parameterList, (BlockSyntax)body, null) : f_10001_131249_131323(parameterList, null, body); DynAbs.Tracing.TraceSender.TraceExitMethod(10001, 131124, 131323);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 131124, 131323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 131124, 131323);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ParenthesizedLambdaExpressionSyntax ParenthesizedLambdaExpression(SyntaxToken asyncKeyword, ParameterListSyntax parameterList, SyntaxToken arrowToken, CSharpSyntaxNode body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10001, 131537, 131788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 131540, 131788);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10001, 131540, 131565) || ((body is BlockSyntax block
                && DynAbs.Tracing.TraceSender.Conditional_F2(10001, 131585, 131668)) || DynAbs.Tracing.TraceSender.Conditional_F3(10001, 131688, 131788))) ? f_10001_131585_131668(asyncKeyword, parameterList, arrowToken, (BlockSyntax)body, null) : f_10001_131688_131788(asyncKeyword, parameterList, arrowToken, null, body); DynAbs.Tracing.TraceSender.TraceExitMethod(10001, 131537, 131788);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 131537, 131788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 131537, 131788);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AnonymousMethodExpressionSyntax AnonymousMethodExpression(CSharpSyntaxNode body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10001, 131909, 131964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 131912, 131964);
                return f_10001_131912_131964(parameterList: null, body); DynAbs.Tracing.TraceSender.TraceExitMethod(10001, 131909, 131964);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 131909, 131964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 131909, 131964);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AnonymousMethodExpressionSyntax AnonymousMethodExpression(ParameterListSyntax? parameterList, CSharpSyntaxNode body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10001, 132121, 132358);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 132124, 132358);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10001, 132124, 132149) || ((body is BlockSyntax block
                && DynAbs.Tracing.TraceSender.Conditional_F2(10001, 132169, 132297)) || DynAbs.Tracing.TraceSender.Conditional_F3(10001, 132317, 132358))) ? f_10001_132169_132297(default(SyntaxTokenList), f_10001_132221_132268(SyntaxKind.DelegateKeyword), parameterList, (BlockSyntax)body, null) : throw f_10001_132323_132358(nameof(body)); DynAbs.Tracing.TraceSender.TraceExitMethod(10001, 132121, 132358);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 132121, 132358);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 132121, 132358);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AnonymousMethodExpressionSyntax AnonymousMethodExpression(SyntaxToken asyncKeyword, SyntaxToken delegateKeyword, ParameterListSyntax parameterList, CSharpSyntaxNode body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10001, 132569, 132762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 132572, 132762);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10001, 132572, 132597) || ((body is BlockSyntax block
                && DynAbs.Tracing.TraceSender.Conditional_F2(10001, 132617, 132701)) || DynAbs.Tracing.TraceSender.Conditional_F3(10001, 132721, 132762))) ? f_10001_132617_132701(asyncKeyword, delegateKeyword, parameterList, (BlockSyntax)body, null) : throw f_10001_132727_132762(nameof(body)); DynAbs.Tracing.TraceSender.TraceExitMethod(10001, 132569, 132762);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 132569, 132762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 132569, 132762);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Obsolete("The diagnosticOptions parameter is obsolete due to performance problems, if you are passing non-null use CompilationOptions.SyntaxTreeOptionsProvider instead", error: false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static SyntaxTree ParseSyntaxTree(
                    string text,
                    ParseOptions? options,
                    string path,
                    Encoding? encoding,
                    ImmutableDictionary<string, ReportDiagnostic>? diagnosticOptions,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 132822, 133531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 133388, 133520);

                return f_10001_133395_133519(f_10001_133411_133442(text, encoding), options, path, diagnosticOptions, isGeneratedCode: null, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 132822, 133531);

                Microsoft.CodeAnalysis.Text.SourceText
                f_10001_133411_133442(string
                text, System.Text.Encoding?
                encoding)
                {
                    var return_v = SourceText.From(text, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 133411, 133442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10001_133395_133519(Microsoft.CodeAnalysis.Text.SourceText
                text, Microsoft.CodeAnalysis.ParseOptions?
                options, string
                path, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>?
                diagnosticOptions, bool?
                isGeneratedCode, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = ParseSyntaxTree(text, options, path, diagnosticOptions, isGeneratedCode: isGeneratedCode, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 133395, 133519);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 132822, 133531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 132822, 133531);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Obsolete("The diagnosticOptions parameter is obsolete due to performance problems, if you are passing non-null use CompilationOptions.SyntaxTreeOptionsProvider instead", error: false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static SyntaxTree ParseSyntaxTree(
                    SourceText text,
                    ParseOptions? options,
                    string path,
                    ImmutableDictionary<string, ReportDiagnostic>? diagnosticOptions,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 133590, 134275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 134127, 134264);

                return f_10001_134134_134263(text, options, path, diagnosticOptions, isGeneratedCode: null, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 133590, 134275);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10001_134134_134263(Microsoft.CodeAnalysis.Text.SourceText
                text, Microsoft.CodeAnalysis.ParseOptions?
                options, string
                path, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>?
                diagnosticOptions, bool?
                isGeneratedCode, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = CSharpSyntaxTree.ParseText(text, (Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?)options, path, diagnosticOptions, isGeneratedCode: isGeneratedCode, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 134134, 134263);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 133590, 134275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 133590, 134275);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The diagnosticOptions and isGeneratedCode parameters are obsolete due to performance problems, if you are using them use CompilationOptions.SyntaxTreeOptionsProvider instead", error: false)]
        public static SyntaxTree ParseSyntaxTree(
                    string text,
                    ParseOptions? options,
                    string path,
                    Encoding? encoding,
                    ImmutableDictionary<string, ReportDiagnostic>? diagnosticOptions,
                    bool? isGeneratedCode,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 134334, 135089);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 134952, 135078);

                return f_10001_134959_135077(f_10001_134975_135006(text, encoding), options, path, diagnosticOptions, isGeneratedCode, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 134334, 135089);

                Microsoft.CodeAnalysis.Text.SourceText
                f_10001_134975_135006(string
                text, System.Text.Encoding?
                encoding)
                {
                    var return_v = SourceText.From(text, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 134975, 135006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10001_134959_135077(Microsoft.CodeAnalysis.Text.SourceText
                text, Microsoft.CodeAnalysis.ParseOptions?
                options, string
                path, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>?
                diagnosticOptions, bool?
                isGeneratedCode, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = ParseSyntaxTree(text, options, path, diagnosticOptions, isGeneratedCode, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 134959, 135077);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 134334, 135089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 134334, 135089);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("The diagnosticOptions and isGeneratedCode parameters are obsolete due to performance problems, if you are using them use CompilationOptions.SyntaxTreeOptionsProvider instead", error: false)]
        public static SyntaxTree ParseSyntaxTree(
                    SourceText text,
                    ParseOptions? options,
                    string path,
                    ImmutableDictionary<string, ReportDiagnostic>? diagnosticOptions,
                    bool? isGeneratedCode,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10001, 135148, 135879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10001, 135737, 135868);

                return f_10001_135744_135867(text, options, path, diagnosticOptions, isGeneratedCode, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10001, 135148, 135879);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10001_135744_135867(Microsoft.CodeAnalysis.Text.SourceText
                text, Microsoft.CodeAnalysis.ParseOptions?
                options, string
                path, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>?
                diagnosticOptions, bool?
                isGeneratedCode, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = CSharpSyntaxTree.ParseText(text, (Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?)options, path, diagnosticOptions, isGeneratedCode, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 135744, 135867);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10001, 135148, 135879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10001, 135148, 135879);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static Microsoft.CodeAnalysis.SyntaxTriviaList
        f_10001_70406_70435(params Microsoft.CodeAnalysis.SyntaxTrivia[]
        trivias)
        {
            var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList(trivias);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 70406, 70435);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTriviaList
        f_10001_70692_70721(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
        trivias)
        {
            var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList(trivias);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 70692, 70721);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        f_10001_125329_125423(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        kind, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
        attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
        modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
        body, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
        expressionBody)
        {
            var return_v = SyntaxFactory.AccessorDeclaration(kind, attributeLists, modifiers, body, expressionBody: expressionBody);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 125329, 125423);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        f_10001_125673_125792(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        kind, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
        attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
        modifiers, Microsoft.CodeAnalysis.SyntaxToken
        keyword, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
        body, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
        expressionBody, Microsoft.CodeAnalysis.SyntaxToken
        semicolonToken)
        {
            var return_v = SyntaxFactory.AccessorDeclaration(kind, attributeLists, modifiers, keyword, body, expressionBody: expressionBody, semicolonToken);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 125673, 125792);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        f_10001_126019_126113(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        kind, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
        attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
        modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        body, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
        expressionBody)
        {
            var return_v = SyntaxFactory.AccessorDeclaration(kind, attributeLists, modifiers, body: body, expressionBody);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 126019, 126113);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        f_10001_126389_126508(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        kind, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
        attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
        modifiers, Microsoft.CodeAnalysis.SyntaxToken
        keyword, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        body, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
        expressionBody, Microsoft.CodeAnalysis.SyntaxToken
        semicolonToken)
        {
            var return_v = SyntaxFactory.AccessorDeclaration(kind, attributeLists, modifiers, keyword, body: body, expressionBody, semicolonToken);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 126389, 126508);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
        f_10001_126710_126809(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
        attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
        modifiers, Microsoft.CodeAnalysis.SyntaxToken
        identifier, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
        equalsValue)
        {
            var return_v = EnumMemberDeclaration(attributeLists, modifiers: modifiers, identifier, equalsValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 126710, 126809);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
        f_10001_127051_127165(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
        attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
        modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
        name, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax>
        externs, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>
        usings, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
        members)
        {
            var return_v = NamespaceDeclaration(attributeLists: attributeLists, modifiers: modifiers, name, externs, usings, members);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 127051, 127165);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
        f_10001_127522_127703(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
        attributeLists, Microsoft.CodeAnalysis.SyntaxTokenList
        modifiers, Microsoft.CodeAnalysis.SyntaxToken
        namespaceKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
        name, Microsoft.CodeAnalysis.SyntaxToken
        openBraceToken, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax>
        externs, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax>
        usings, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
        members, Microsoft.CodeAnalysis.SyntaxToken
        closeBraceToken, Microsoft.CodeAnalysis.SyntaxToken
        semicolonToken)
        {
            var return_v = NamespaceDeclaration(attributeLists: attributeLists, modifiers: modifiers, namespaceKeyword, name, openBraceToken, externs, usings, members, closeBraceToken, semicolonToken);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 127522, 127703);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
        f_10001_130226_130272(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
        parameter, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
        block, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
        expressionBody)
        {
            var return_v = SimpleLambdaExpression(parameter, block, expressionBody);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 130226, 130272);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
        f_10001_130292_130355(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
        parameter, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
        block, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        expressionBody)
        {
            var return_v = SimpleLambdaExpression(parameter, block, (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)expressionBody);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 130292, 130355);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
        f_10001_130595_130667(Microsoft.CodeAnalysis.SyntaxToken
        asyncKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
        parameter, Microsoft.CodeAnalysis.SyntaxToken
        arrowToken, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
        block, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
        expressionBody)
        {
            var return_v = SimpleLambdaExpression(asyncKeyword, parameter, arrowToken, block, expressionBody);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 130595, 130667);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
        f_10001_130687_130776(Microsoft.CodeAnalysis.SyntaxToken
        asyncKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
        parameter, Microsoft.CodeAnalysis.SyntaxToken
        arrowToken, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
        block, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        expressionBody)
        {
            var return_v = SimpleLambdaExpression(asyncKeyword, parameter, arrowToken, block, (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)expressionBody);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 130687, 130776);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
        f_10001_130938_130953()
        {
            var return_v = ParameterList();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 130938, 130953);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
        f_10001_130908_130960(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
        parameterList, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        body)
        {
            var return_v = ParenthesizedLambdaExpression(parameterList, body);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 130908, 130960);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
        f_10001_131172_131229(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
        parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
        block, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
        expressionBody)
        {
            var return_v = ParenthesizedLambdaExpression(parameterList, block, expressionBody);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 131172, 131229);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
        f_10001_131249_131323(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
        parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        block, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        expressionBody)
        {
            var return_v = ParenthesizedLambdaExpression(parameterList, block, (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)expressionBody);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 131249, 131323);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
        f_10001_131585_131668(Microsoft.CodeAnalysis.SyntaxToken
        asyncKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
        parameterList, Microsoft.CodeAnalysis.SyntaxToken
        arrowToken, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
        block, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
        expressionBody)
        {
            var return_v = ParenthesizedLambdaExpression(asyncKeyword, parameterList, arrowToken, block, expressionBody);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 131585, 131668);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
        f_10001_131688_131788(Microsoft.CodeAnalysis.SyntaxToken
        asyncKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
        parameterList, Microsoft.CodeAnalysis.SyntaxToken
        arrowToken, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
        block, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        expressionBody)
        {
            var return_v = ParenthesizedLambdaExpression(asyncKeyword, parameterList, arrowToken, block, (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)expressionBody);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 131688, 131788);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
        f_10001_131912_131964(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax?
        parameterList, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        body)
        {
            var return_v = AnonymousMethodExpression(parameterList: parameterList, body);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 131912, 131964);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxToken
        f_10001_132221_132268(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        kind)
        {
            var return_v = SyntaxFactory.Token(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 132221, 132268);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
        f_10001_132169_132297(Microsoft.CodeAnalysis.SyntaxTokenList
        modifiers, Microsoft.CodeAnalysis.SyntaxToken
        delegateKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax?
        parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
        block, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
        expressionBody)
        {
            var return_v = AnonymousMethodExpression(modifiers, delegateKeyword, parameterList, block, expressionBody);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 132169, 132297);
            return return_v;
        }


        static System.ArgumentException
        f_10001_132323_132358(string
        message)
        {
            var return_v = new System.ArgumentException(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 132323, 132358);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
        f_10001_132617_132701(Microsoft.CodeAnalysis.SyntaxToken
        asyncKeyword, Microsoft.CodeAnalysis.SyntaxToken
        delegateKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
        parameterList, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
        block, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
        expressionBody)
        {
            var return_v = AnonymousMethodExpression(asyncKeyword, delegateKeyword, parameterList, block, expressionBody);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 132617, 132701);
            return return_v;
        }


        static System.ArgumentException
        f_10001_132727_132762(string
        message)
        {
            var return_v = new System.ArgumentException(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10001, 132727, 132762);
            return return_v;
        }

    }
}
