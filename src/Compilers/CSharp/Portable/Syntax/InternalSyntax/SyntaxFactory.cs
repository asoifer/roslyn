// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    using Microsoft.CodeAnalysis.Syntax.InternalSyntax;
    internal static partial class SyntaxFactory
    {
        private const string
        CrLf = "\r\n"
        ;

        internal static readonly SyntaxTrivia CarriageReturnLineFeed;

        internal static readonly SyntaxTrivia LineFeed;

        internal static readonly SyntaxTrivia CarriageReturn;

        internal static readonly SyntaxTrivia Space;

        internal static readonly SyntaxTrivia Tab;

        internal static readonly SyntaxTrivia ElasticCarriageReturnLineFeed;

        internal static readonly SyntaxTrivia ElasticLineFeed;

        internal static readonly SyntaxTrivia ElasticCarriageReturn;

        internal static readonly SyntaxTrivia ElasticSpace;

        internal static readonly SyntaxTrivia ElasticTab;

        internal static readonly SyntaxTrivia ElasticZeroSpace;

        private static SyntaxToken s_xmlCarriageReturnLineFeed;

        private static SyntaxToken XmlCarriageReturnLineFeed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 1683, 1825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 1719, 1810);

                    return s_xmlCarriageReturnLineFeed ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(10004, 1726, 1809) ?? (s_xmlCarriageReturnLineFeed = f_10004_1788_1808(CrLf)));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 1683, 1825);

                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    f_10004_1788_1808(string
                    text)
                    {
                        var return_v = XmlTextNewLine(text);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 1788, 1808);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 1606, 1836);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 1606, 1836);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static SyntaxTrivia EndOfLine(string text, bool elastic = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 2371, 3551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 2469, 2496);

                SyntaxTrivia
                trivia = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 2550, 3091);

                switch (text)
                {

                    case "\r":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10004, 2550, 3091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 2628, 2714);

                        trivia = (DynAbs.Tracing.TraceSender.Conditional_F1(10004, 2637, 2644) || ((elastic && DynAbs.Tracing.TraceSender.Conditional_F2(10004, 2647, 2682)) || DynAbs.Tracing.TraceSender.Conditional_F3(10004, 2685, 2713))) ? SyntaxFactory.ElasticCarriageReturn : SyntaxFactory.CarriageReturn;
                        DynAbs.Tracing.TraceSender.TraceBreak(10004, 2736, 2742);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10004, 2550, 3091);

                    case "\n":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10004, 2550, 3091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 2792, 2866);

                        trivia = (DynAbs.Tracing.TraceSender.Conditional_F1(10004, 2801, 2808) || ((elastic && DynAbs.Tracing.TraceSender.Conditional_F2(10004, 2811, 2840)) || DynAbs.Tracing.TraceSender.Conditional_F3(10004, 2843, 2865))) ? SyntaxFactory.ElasticLineFeed : SyntaxFactory.LineFeed;
                        DynAbs.Tracing.TraceSender.TraceBreak(10004, 2888, 2894);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10004, 2550, 3091);

                    case "\r\n":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10004, 2550, 3091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 2946, 3048);

                        trivia = (DynAbs.Tracing.TraceSender.Conditional_F1(10004, 2955, 2962) || ((elastic && DynAbs.Tracing.TraceSender.Conditional_F2(10004, 2965, 3008)) || DynAbs.Tracing.TraceSender.Conditional_F3(10004, 3011, 3047))) ? SyntaxFactory.ElasticCarriageReturnLineFeed : SyntaxFactory.CarriageReturnLineFeed;
                        DynAbs.Tracing.TraceSender.TraceBreak(10004, 3070, 3076);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10004, 2550, 3091);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 3194, 3275) || true) && (trivia != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10004, 3194, 3275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 3246, 3260);

                    return trivia;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10004, 3194, 3275);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 3291, 3354);

                trivia = f_10004_3300_3353(SyntaxKind.EndOfLineTrivia, text);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 3368, 3443) || true) && (!elastic)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10004, 3368, 3443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 3414, 3428);

                    return trivia;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10004, 3368, 3443);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 3459, 3540);

                return f_10004_3466_3539(trivia, new[] { f_10004_3502_3536() });
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 2371, 3551);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10004_3300_3353(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                text)
                {
                    var return_v = SyntaxTrivia.Create(kind, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 3300, 3353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation
                f_10004_3502_3536()
                {
                    var return_v = SyntaxAnnotation.ElasticAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10004, 3502, 3536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10004_3466_3539(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                node, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                annotations)
                {
                    var return_v = node.WithAnnotationsGreen<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>)annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 3466, 3539);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 2371, 3551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 2371, 3551);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxTrivia Whitespace(string text, bool elastic = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 3563, 3927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 3662, 3730);

                var
                trivia = f_10004_3675_3729(SyntaxKind.WhitespaceTrivia, text)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 3744, 3819) || true) && (!elastic)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10004, 3744, 3819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 3790, 3804);

                    return trivia;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10004, 3744, 3819);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 3835, 3916);

                return f_10004_3842_3915(trivia, new[] { f_10004_3878_3912() });
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 3563, 3927);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10004_3675_3729(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                text)
                {
                    var return_v = SyntaxTrivia.Create(kind, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 3675, 3729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxAnnotation
                f_10004_3878_3912()
                {
                    var return_v = SyntaxAnnotation.ElasticAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10004, 3878, 3912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10004_3842_3915(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                node, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                annotations)
                {
                    var return_v = node.WithAnnotationsGreen<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxAnnotation>)annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 3842, 3915);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 3563, 3927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 3563, 3927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxTrivia Comment(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 3939, 4327);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 4013, 4316) || true) && (f_10004_4017_4064(text, "/*", StringComparison.Ordinal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10004, 4013, 4316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 4098, 4166);

                    return f_10004_4105_4165(SyntaxKind.MultiLineCommentTrivia, text);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10004, 4013, 4316);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10004, 4013, 4316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 4232, 4301);

                    return f_10004_4239_4300(SyntaxKind.SingleLineCommentTrivia, text);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10004, 4013, 4316);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 3939, 4327);

                bool
                f_10004_4017_4064(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 4017, 4064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10004_4105_4165(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                text)
                {
                    var return_v = SyntaxTrivia.Create(kind, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 4105, 4165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10004_4239_4300(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                text)
                {
                    var return_v = SyntaxTrivia.Create(kind, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 4239, 4300);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 3939, 4327);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 3939, 4327);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxTrivia ConflictMarker(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10004, 4409, 4470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 4412, 4470);
                return f_10004_4412_4470(SyntaxKind.ConflictMarkerTrivia, text); DynAbs.Tracing.TraceSender.TraceExitMethod(10004, 4409, 4470);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 4409, 4470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 4409, 4470);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxTrivia DisabledText(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 4483, 4637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 4562, 4626);

                return f_10004_4569_4625(SyntaxKind.DisabledTextTrivia, text);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 4483, 4637);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10004_4569_4625(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                text)
                {
                    var return_v = SyntaxTrivia.Create(kind, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 4569, 4625);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 4483, 4637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 4483, 4637);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxTrivia PreprocessingMessage(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 4649, 4819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 4736, 4808);

                return f_10004_4743_4807(SyntaxKind.PreprocessingMessageTrivia, text);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 4649, 4819);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10004_4743_4807(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                text)
                {
                    var return_v = SyntaxTrivia.Create(kind, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 4743, 4807);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 4649, 4819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 4649, 4819);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken Token(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 4831, 4947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 4904, 4936);

                return f_10004_4911_4935(kind);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 4831, 4947);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_4911_4935(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxToken.Create(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 4911, 4935);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 4831, 4947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 4831, 4947);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken Token(GreenNode leading, SyntaxKind kind, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 4959, 5135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 5073, 5124);

                return f_10004_5080_5123(kind, leading, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 4959, 5135);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_5080_5123(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxToken.Create(kind, leading, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 5080, 5123);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 4959, 5135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 4959, 5135);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken Token(GreenNode leading, SyntaxKind kind, string text, string valueText, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 5147, 5911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 5292, 5335);

                f_10004_5292_5334(f_10004_5305_5333(kind));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 5349, 5398);

                f_10004_5349_5397(kind != SyntaxKind.IdentifierToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 5412, 5467);

                f_10004_5412_5466(kind != SyntaxKind.CharacterLiteralToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 5481, 5534);

                f_10004_5481_5533(kind != SyntaxKind.NumericLiteralToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 5550, 5597);

                string
                defaultText = f_10004_5571_5596(kind)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 5611, 5900);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10004, 5618, 5766) || ((kind >= SyntaxToken.FirstTokenWithWellKnownText && (DynAbs.Tracing.TraceSender.Expression_True(10004, 5618, 5715) && kind <= SyntaxToken.LastTokenWithWellKnownText) && (DynAbs.Tracing.TraceSender.Expression_True(10004, 5618, 5738) && text == defaultText) && (DynAbs.Tracing.TraceSender.Expression_True(10004, 5618, 5766) && valueText == defaultText
                ) && DynAbs.Tracing.TraceSender.Conditional_F2(10004, 5786, 5816)) || DynAbs.Tracing.TraceSender.Conditional_F3(10004, 5836, 5899))) ? f_10004_5786_5816(leading, kind, trailing) : f_10004_5836_5899(kind, leading, text, valueText, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 5147, 5911);

                bool
                f_10004_5305_5333(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsAnyToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 5305, 5333);
                    return return_v;
                }


                int
                f_10004_5292_5334(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 5292, 5334);
                    return 0;
                }


                int
                f_10004_5349_5397(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 5349, 5397);
                    return 0;
                }


                int
                f_10004_5412_5466(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 5412, 5466);
                    return 0;
                }


                int
                f_10004_5481_5533(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 5481, 5533);
                    return 0;
                }


                string
                f_10004_5571_5596(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 5571, 5596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_5786_5816(Microsoft.CodeAnalysis.GreenNode
                leading, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = Token(leading, kind, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 5786, 5816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_5836_5899(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, string
                text, string
                value, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxToken.WithValue(kind, leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 5836, 5899);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 5147, 5911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 5147, 5911);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken MissingToken(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 5923, 6067);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 6005, 6056);

                return f_10004_6012_6055(kind, null, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 5923, 6067);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_6012_6055(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxToken.CreateMissing(kind, leading, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 6012, 6055);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 5923, 6067);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 5923, 6067);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken MissingToken(GreenNode leading, SyntaxKind kind, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 6079, 6269);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 6200, 6258);

                return f_10004_6207_6257(kind, leading, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 6079, 6269);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_6207_6257(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxToken.CreateMissing(kind, leading, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 6207, 6257);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 6079, 6269);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 6079, 6269);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken Identifier(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 6281, 6438);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 6357, 6427);

                return f_10004_6364_6426(SyntaxKind.IdentifierToken, null, text, text, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 6281, 6438);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_6364_6426(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                contextualKind, Microsoft.CodeAnalysis.GreenNode
                leading, string
                text, string
                valueText, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = Identifier(contextualKind, leading, text, valueText, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 6364, 6426);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 6281, 6438);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 6281, 6438);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken Identifier(GreenNode leading, string text, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 6450, 6653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 6565, 6642);

                return f_10004_6572_6641(SyntaxKind.IdentifierToken, leading, text, text, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 6450, 6653);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_6572_6641(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                contextualKind, Microsoft.CodeAnalysis.GreenNode
                leading, string
                text, string
                valueText, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = Identifier(contextualKind, leading, text, valueText, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 6572, 6641);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 6450, 6653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 6450, 6653);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken Identifier(SyntaxKind contextualKind, GreenNode leading, string text, string valueText, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 6665, 6918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 6825, 6907);

                return f_10004_6832_6906(contextualKind, leading, text, valueText, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 6665, 6918);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_6832_6906(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                contextualKind, Microsoft.CodeAnalysis.GreenNode
                leading, string
                text, string
                valueText, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxToken.Identifier(contextualKind, leading, text, valueText, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 6832, 6906);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 6665, 6918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 6665, 6918);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken Literal(GreenNode leading, string text, int value, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 6930, 7157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 7053, 7146);

                return f_10004_7060_7145(SyntaxKind.NumericLiteralToken, leading, text, value, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 6930, 7157);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_7060_7145(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, string
                text, int
                value, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxToken.WithValue(kind, leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 7060, 7145);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 6930, 7157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 6930, 7157);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken Literal(GreenNode leading, string text, uint value, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 7169, 7397);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 7293, 7386);

                return f_10004_7300_7385(SyntaxKind.NumericLiteralToken, leading, text, value, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 7169, 7397);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_7300_7385(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, string
                text, uint
                value, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxToken.WithValue(kind, leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 7300, 7385);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 7169, 7397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 7169, 7397);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken Literal(GreenNode leading, string text, long value, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 7409, 7637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 7533, 7626);

                return f_10004_7540_7625(SyntaxKind.NumericLiteralToken, leading, text, value, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 7409, 7637);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_7540_7625(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, string
                text, long
                value, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxToken.WithValue(kind, leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 7540, 7625);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 7409, 7637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 7409, 7637);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken Literal(GreenNode leading, string text, ulong value, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 7649, 7878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 7774, 7867);

                return f_10004_7781_7866(SyntaxKind.NumericLiteralToken, leading, text, value, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 7649, 7878);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_7781_7866(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, string
                text, ulong
                value, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxToken.WithValue(kind, leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 7781, 7866);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 7649, 7878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 7649, 7878);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken Literal(GreenNode leading, string text, float value, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 7890, 8119);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 8015, 8108);

                return f_10004_8022_8107(SyntaxKind.NumericLiteralToken, leading, text, value, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 7890, 8119);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_8022_8107(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, string
                text, float
                value, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxToken.WithValue(kind, leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 8022, 8107);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 7890, 8119);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 7890, 8119);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken Literal(GreenNode leading, string text, double value, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 8131, 8361);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 8257, 8350);

                return f_10004_8264_8349(SyntaxKind.NumericLiteralToken, leading, text, value, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 8131, 8361);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_8264_8349(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, string
                text, double
                value, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxToken.WithValue(kind, leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 8264, 8349);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 8131, 8361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 8131, 8361);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken Literal(GreenNode leading, string text, decimal value, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 8373, 8604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 8500, 8593);

                return f_10004_8507_8592(SyntaxKind.NumericLiteralToken, leading, text, value, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 8373, 8604);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_8507_8592(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, string
                text, decimal
                value, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxToken.WithValue(kind, leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 8507, 8592);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 8373, 8604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 8373, 8604);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken Literal(GreenNode leading, string text, string value, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 8616, 8845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 8742, 8834);

                return f_10004_8749_8833(SyntaxKind.StringLiteralToken, leading, text, value, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 8616, 8845);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_8749_8833(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, string
                text, string
                value, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxToken.WithValue(kind, leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 8749, 8833);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 8616, 8845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 8616, 8845);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken Literal(GreenNode leading, string text, SyntaxKind kind, string value, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 8857, 9078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 9000, 9067);

                return f_10004_9007_9066(kind, leading, text, value, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 8857, 9078);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_9007_9066(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, string
                text, string
                value, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxToken.WithValue(kind, leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 9007, 9066);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 8857, 9078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 8857, 9078);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken Literal(GreenNode leading, string text, char value, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 9090, 9320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 9214, 9309);

                return f_10004_9221_9308(SyntaxKind.CharacterLiteralToken, leading, text, value, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 9090, 9320);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_9221_9308(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, string
                text, char
                value, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxToken.WithValue(kind, leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 9221, 9308);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 9090, 9320);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 9090, 9320);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken BadToken(GreenNode leading, string text, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 9332, 9537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 9445, 9526);

                return f_10004_9452_9525(SyntaxKind.BadToken, leading, text, text, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 9332, 9537);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_9452_9525(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, string
                text, string
                value, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxToken.WithValue(kind, leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 9452, 9525);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 9332, 9537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 9332, 9537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken XmlTextLiteral(GreenNode leading, string text, string value, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 9549, 9786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 9682, 9775);

                return f_10004_9689_9774(SyntaxKind.XmlTextLiteralToken, leading, text, value, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 9549, 9786);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_9689_9774(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, string
                text, string
                value, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxToken.WithValue(kind, leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 9689, 9774);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 9549, 9786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 9549, 9786);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken XmlTextNewLine(GreenNode leading, string text, string value, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 9798, 10212);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 9931, 10085) || true) && (leading == null && (DynAbs.Tracing.TraceSender.Expression_True(10004, 9935, 9970) && trailing == null) && (DynAbs.Tracing.TraceSender.Expression_True(10004, 9935, 9986) && text == CrLf) && (DynAbs.Tracing.TraceSender.Expression_True(10004, 9935, 10003) && value == CrLf))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10004, 9931, 10085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 10037, 10070);

                    return f_10004_10044_10069();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10004, 9931, 10085);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 10101, 10201);

                return f_10004_10108_10200(SyntaxKind.XmlTextLiteralNewLineToken, leading, text, value, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 9798, 10212);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_10044_10069()
                {
                    var return_v = XmlCarriageReturnLineFeed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10004, 10044, 10069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_10108_10200(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, string
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = SyntaxToken.WithValue(kind, leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 10108, 10200);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 9798, 10212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 9798, 10212);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken XmlTextNewLine(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 10224, 10407);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 10304, 10396);

                return f_10004_10311_10395(SyntaxKind.XmlTextLiteralNewLineToken, null, text, text, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 10224, 10407);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_10311_10395(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, string
                text, string
                value, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxToken.WithValue(kind, leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 10311, 10395);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 10224, 10407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 10224, 10407);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken XmlEntity(GreenNode leading, string text, string value, GreenNode trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 10419, 10653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 10547, 10642);

                return f_10004_10554_10641(SyntaxKind.XmlEntityLiteralToken, leading, text, value, trailing);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 10419, 10653);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10004_10554_10641(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode
                leading, string
                text, string
                value, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxToken.WithValue(kind, leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 10554, 10641);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 10419, 10653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 10419, 10653);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxTrivia DocumentationCommentExteriorTrivia(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 10665, 10857);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 10766, 10846);

                return f_10004_10773_10845(SyntaxKind.DocumentationCommentExteriorTrivia, text);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 10665, 10857);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10004_10773_10845(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                text)
                {
                    var return_v = SyntaxTrivia.Create(kind, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 10773, 10845);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 10665, 10857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 10665, 10857);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxList<TNode> List<TNode>() where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 10869, 11015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 10970, 11004);

                return default(SyntaxList<TNode>);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 10869, 11015);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 10869, 11015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 10869, 11015);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxList<TNode> List<TNode>(TNode node) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 11027, 11201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 11138, 11190);

                return f_10004_11145_11189<TNode>(f_10004_11167_11188<TNode>(node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 11027, 11201);

                Microsoft.CodeAnalysis.GreenNode
                f_10004_11167_11188<TNode>(TNode
                child) where TNode : CSharpSyntaxNode

                {
                    var return_v = SyntaxList.List((Microsoft.CodeAnalysis.GreenNode)child);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 11167, 11188);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<TNode>
                f_10004_11145_11189<TNode>(Microsoft.CodeAnalysis.GreenNode
                node) where TNode : CSharpSyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<TNode>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 11145, 11189);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 11027, 11201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 11027, 11201);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxList<TNode> List<TNode>(TNode node0, TNode node1) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 11213, 11409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 11338, 11398);

                return f_10004_11345_11397<TNode>(f_10004_11367_11396<TNode>(node0, node1));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 11213, 11409);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
                f_10004_11367_11396<TNode>(TNode
                child0, TNode
                child1) where TNode : CSharpSyntaxNode

                {
                    var return_v = SyntaxList.List((Microsoft.CodeAnalysis.GreenNode)child0, (Microsoft.CodeAnalysis.GreenNode)child1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 11367, 11396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<TNode>
                f_10004_11345_11397<TNode>(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
                node) where TNode : CSharpSyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<TNode>((Microsoft.CodeAnalysis.GreenNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 11345, 11397);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 11213, 11409);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 11213, 11409);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static GreenNode ListNode(CSharpSyntaxNode node0, CSharpSyntaxNode node1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 11421, 11576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 11528, 11565);

                return f_10004_11535_11564(node0, node1);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 11421, 11576);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
                f_10004_11535_11564(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                child0, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                child1)
                {
                    var return_v = SyntaxList.List((Microsoft.CodeAnalysis.GreenNode)child0, (Microsoft.CodeAnalysis.GreenNode)child1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 11535, 11564);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 11421, 11576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 11421, 11576);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxList<TNode> List<TNode>(TNode node0, TNode node1, TNode node2) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 11588, 11804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 11726, 11793);

                return f_10004_11733_11792<TNode>(f_10004_11755_11791<TNode>(node0, node1, node2));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 11588, 11804);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
                f_10004_11755_11791<TNode>(TNode
                child0, TNode
                child1, TNode
                child2) where TNode : CSharpSyntaxNode

                {
                    var return_v = SyntaxList.List((Microsoft.CodeAnalysis.GreenNode)child0, (Microsoft.CodeAnalysis.GreenNode)child1, (Microsoft.CodeAnalysis.GreenNode)child2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 11755, 11791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<TNode>
                f_10004_11733_11792<TNode>(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
                node) where TNode : CSharpSyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<TNode>((Microsoft.CodeAnalysis.GreenNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 11733, 11792);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 11588, 11804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 11588, 11804);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static GreenNode ListNode(CSharpSyntaxNode node0, CSharpSyntaxNode node1, CSharpSyntaxNode node2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 11816, 12002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 11947, 11991);

                return f_10004_11954_11990(node0, node1, node2);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 11816, 12002);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
                f_10004_11954_11990(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                child0, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                child1, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                child2)
                {
                    var return_v = SyntaxList.List((Microsoft.CodeAnalysis.GreenNode)child0, (Microsoft.CodeAnalysis.GreenNode)child1, (Microsoft.CodeAnalysis.GreenNode)child2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 11954, 11990);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 11816, 12002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 11816, 12002);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxList<TNode> List<TNode>(params TNode[] nodes) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 12014, 12315);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 12135, 12254) || true) && (nodes != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10004, 12135, 12254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 12186, 12239);

                    return f_10004_12193_12238<TNode>(f_10004_12215_12237<TNode>(nodes));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10004, 12135, 12254);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 12270, 12304);

                return default(SyntaxList<TNode>);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 12014, 12315);

                Microsoft.CodeAnalysis.GreenNode
                f_10004_12215_12237<TNode>(TNode[]
                nodes) where TNode : CSharpSyntaxNode

                {
                    var return_v = SyntaxList.List((Microsoft.CodeAnalysis.GreenNode?[])nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 12215, 12237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<TNode>
                f_10004_12193_12238<TNode>(Microsoft.CodeAnalysis.GreenNode
                node) where TNode : CSharpSyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<TNode>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 12193, 12238);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 12014, 12315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 12014, 12315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static GreenNode ListNode(params ArrayElement<GreenNode>[] nodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 12327, 12467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 12426, 12456);

                return f_10004_12433_12455(nodes);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 12327, 12467);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
                f_10004_12433_12455(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                children)
                {
                    var return_v = SyntaxList.List(children);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 12433, 12455);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 12327, 12467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 12327, 12467);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SeparatedSyntaxList<TNode> SeparatedList<TNode>(TNode node) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 12479, 12697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 12608, 12686);

                return f_10004_12615_12685<TNode>(f_10004_12646_12684<TNode>(node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 12479, 12697);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                f_10004_12646_12684<TNode>(TNode
                node) where TNode : CSharpSyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>((Microsoft.CodeAnalysis.GreenNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 12646, 12684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<TNode>
                f_10004_12615_12685<TNode>(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                list) where TNode : CSharpSyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<TNode>((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 12615, 12685);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 12479, 12697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 12479, 12697);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SeparatedSyntaxList<TNode> SeparatedList<TNode>(SyntaxToken token) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 12709, 12935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 12845, 12924);

                return f_10004_12852_12923<TNode>(f_10004_12883_12922<TNode>(token));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 12709, 12935);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                f_10004_12883_12922<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node) where TNode : CSharpSyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>((Microsoft.CodeAnalysis.GreenNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 12883, 12922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<TNode>
                f_10004_12852_12923<TNode>(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                list) where TNode : CSharpSyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<TNode>((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 12852, 12923);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 12709, 12935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 12709, 12935);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SeparatedSyntaxList<TNode> SeparatedList<TNode>(TNode node1, SyntaxToken token, TNode node2) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 12947, 13230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 13109, 13219);

                return f_10004_13116_13218<TNode>(f_10004_13147_13217<TNode>(f_10004_13180_13216<TNode>(node1, token, node2)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 12947, 13230);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
                f_10004_13180_13216<TNode>(TNode
                child0, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                child1, TNode
                child2) where TNode : CSharpSyntaxNode

                {
                    var return_v = SyntaxList.List((Microsoft.CodeAnalysis.GreenNode)child0, (Microsoft.CodeAnalysis.GreenNode)child1, (Microsoft.CodeAnalysis.GreenNode)child2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 13180, 13216);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                f_10004_13147_13217<TNode>(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
                node) where TNode : CSharpSyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>((Microsoft.CodeAnalysis.GreenNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 13147, 13217);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<TNode>
                f_10004_13116_13218<TNode>(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                list) where TNode : CSharpSyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<TNode>((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 13116, 13218);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 12947, 13230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 12947, 13230);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SeparatedSyntaxList<TNode> SeparatedList<TNode>(params CSharpSyntaxNode[] nodes) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 13242, 13590);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 13392, 13520) || true) && (nodes != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10004, 13392, 13520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 13443, 13505);

                    return f_10004_13450_13504<TNode>(f_10004_13481_13503<TNode>(nodes));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10004, 13392, 13520);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 13536, 13579);

                return default(SeparatedSyntaxList<TNode>);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 13242, 13590);

                Microsoft.CodeAnalysis.GreenNode
                f_10004_13481_13503<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode[]
                nodes) where TNode : CSharpSyntaxNode

                {
                    var return_v = SyntaxList.List((Microsoft.CodeAnalysis.GreenNode?[])nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 13481, 13503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<TNode>
                f_10004_13450_13504<TNode>(Microsoft.CodeAnalysis.GreenNode
                list) where TNode : CSharpSyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<TNode>((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.GreenNode>)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 13450, 13504);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 13242, 13590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 13242, 13590);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<SyntaxTrivia> GetWellKnownTrivia()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 13602, 14153);

                var listYield = new List<SyntaxTrivia>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 13689, 13725);

                listYield.Add(CarriageReturnLineFeed);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 13739, 13761);

                listYield.Add(LineFeed);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 13775, 13803);

                listYield.Add(CarriageReturn);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 13817, 13836);

                listYield.Add(Space);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 13850, 13867);

                listYield.Add(Tab);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 13883, 13926);

                listYield.Add(ElasticCarriageReturnLineFeed);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 13940, 13969);

                listYield.Add(ElasticLineFeed);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 13983, 14018);

                listYield.Add(ElasticCarriageReturn);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 14032, 14058);

                listYield.Add(ElasticSpace);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 14072, 14096);

                listYield.Add(ElasticTab);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 14112, 14142);

                listYield.Add(ElasticZeroSpace);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 13602, 14153);

                return listYield;
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 13602, 14153);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 13602, 14153);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<SyntaxToken> GetWellKnownTokens()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10004, 14165, 14302);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 14251, 14291);

                return f_10004_14258_14290();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10004, 14165, 14302);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                f_10004_14258_14290()
                {
                    var return_v = SyntaxToken.GetWellKnownTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 14258, 14290);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10004, 14165, 14302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 14165, 14302);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10004, 437, 14309);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 518, 531);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 580, 620);
            CarriageReturnLineFeed = f_10004_605_620(CrLf); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 669, 695);
            LineFeed = f_10004_680_695("\n"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 744, 776);
            CarriageReturn = f_10004_761_776("\r"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 825, 848);
            Space = f_10004_833_848(" "); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 897, 919);
            Tab = f_10004_903_919("\t"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 970, 1032);
            ElasticCarriageReturnLineFeed = f_10004_1002_1032(CrLf, elastic: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 1081, 1129);
            ElasticLineFeed = f_10004_1099_1129("\n", elastic: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 1178, 1232);
            ElasticCarriageReturn = f_10004_1202_1232("\r", elastic: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 1281, 1326);
            ElasticSpace = f_10004_1296_1326(" ", elastic: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 1375, 1419);
            ElasticTab = f_10004_1388_1419("\t", elastic: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 1470, 1528);
            ElasticZeroSpace = f_10004_1489_1528(string.Empty, elastic: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10004, 1568, 1595);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10004, 437, 14309);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10004, 437, 14309);
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
        f_10004_605_620(string
        text)
        {
            var return_v = EndOfLine(text);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 605, 620);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
        f_10004_680_695(string
        text)
        {
            var return_v = EndOfLine(text);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 680, 695);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
        f_10004_761_776(string
        text)
        {
            var return_v = EndOfLine(text);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 761, 776);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
        f_10004_833_848(string
        text)
        {
            var return_v = Whitespace(text);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 833, 848);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
        f_10004_903_919(string
        text)
        {
            var return_v = Whitespace(text);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 903, 919);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
        f_10004_1002_1032(string
        text, bool
        elastic)
        {
            var return_v = EndOfLine(text, elastic: elastic);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 1002, 1032);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
        f_10004_1099_1129(string
        text, bool
        elastic)
        {
            var return_v = EndOfLine(text, elastic: elastic);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 1099, 1129);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
        f_10004_1202_1232(string
        text, bool
        elastic)
        {
            var return_v = EndOfLine(text, elastic: elastic);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 1202, 1232);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
        f_10004_1296_1326(string
        text, bool
        elastic)
        {
            var return_v = Whitespace(text, elastic: elastic);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 1296, 1326);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
        f_10004_1388_1419(string
        text, bool
        elastic)
        {
            var return_v = Whitespace(text, elastic: elastic);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 1388, 1419);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
        f_10004_1489_1528(string
        text, bool
        elastic)
        {
            var return_v = Whitespace(text, elastic: elastic);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 1489, 1528);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
        f_10004_4412_4470(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        kind, string
        text)
        {
            var return_v = SyntaxTrivia.Create(kind, text);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10004, 4412, 4470);
            return return_v;
        }

    }
}
