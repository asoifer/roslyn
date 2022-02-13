// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    using System.Reflection;
    using Microsoft.CodeAnalysis.Syntax.InternalSyntax;
    internal class DirectiveParser : SyntaxParser
    {
        private const int
        MAX_DIRECTIVE_IDENTIFIER_WIDTH = 128
        ;

        private readonly DirectiveStack _context;

        internal DirectiveParser(Lexer lexer, DirectiveStack context)
        : base(f_10025_716_721_C(lexer), LexerMode.Directive, null, null, false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10025, 634, 817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 787, 806);

                _context = context;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10025, 634, 817);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 634, 817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 634, 817);
            }
        }

        public CSharpSyntaxNode ParseDirective(
                    bool isActive,
                    bool endIsActive,
                    bool isAfterFirstTokenInFile,
                    bool isAfterNonWhitespaceOnLine)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 829, 6295);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 1041, 1086);

                var
                hashPosition = f_10025_1060_1085(lexer.TextWindow)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 1100, 1154);

                var
                hash = f_10025_1111_1153(this, SyntaxKind.HashToken, false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 1168, 1311) || true) && (isAfterNonWhitespaceOnLine)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 1168, 1311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 1232, 1296);

                    hash = f_10025_1239_1295(this, hash, ErrorCode.ERR_BadDirectivePlacement);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 1168, 1311);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 2056, 2080);

                CSharpSyntaxNode
                result
                = default(CSharpSyntaxNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 2094, 2155);

                SyntaxKind
                contextualKind = f_10025_2122_2154(f_10025_2122_2139(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 2169, 6254);

                switch (contextualKind)
                {

                    case SyntaxKind.IfKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 2169, 6254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 2273, 2361);

                        result = f_10025_2282_2360(this, hash, f_10025_2310_2349(this, contextualKind), isActive);
                        DynAbs.Tracing.TraceSender.TraceBreak(10025, 2383, 2389);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 2169, 6254);

                    case SyntaxKind.ElifKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 2169, 6254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 2459, 2562);

                        result = f_10025_2468_2561(this, hash, f_10025_2498_2537(this, contextualKind), isActive, endIsActive);
                        DynAbs.Tracing.TraceSender.TraceBreak(10025, 2584, 2590);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 2169, 6254);

                    case SyntaxKind.ElseKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 2169, 6254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 2660, 2763);

                        result = f_10025_2669_2762(this, hash, f_10025_2699_2738(this, contextualKind), isActive, endIsActive);
                        DynAbs.Tracing.TraceSender.TraceBreak(10025, 2785, 2791);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 2169, 6254);

                    case SyntaxKind.EndIfKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 2169, 6254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 2862, 2966);

                        result = f_10025_2871_2965(this, hash, f_10025_2902_2941(this, contextualKind), isActive, endIsActive);
                        DynAbs.Tracing.TraceSender.TraceBreak(10025, 2988, 2994);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 2169, 6254);

                    case SyntaxKind.RegionKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 2169, 6254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 3066, 3158);

                        result = f_10025_3075_3157(this, hash, f_10025_3107_3146(this, contextualKind), isActive);
                        DynAbs.Tracing.TraceSender.TraceBreak(10025, 3180, 3186);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 2169, 6254);

                    case SyntaxKind.EndRegionKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 2169, 6254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 3261, 3356);

                        result = f_10025_3270_3355(this, hash, f_10025_3305_3344(this, contextualKind), isActive);
                        DynAbs.Tracing.TraceSender.TraceBreak(10025, 3378, 3384);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 2169, 6254);

                    case SyntaxKind.DefineKeyword:
                    case SyntaxKind.UndefKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 2169, 6254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 3503, 3658);

                        result = f_10025_3512_3657(this, hash, f_10025_3551_3590(this, contextualKind), isActive, isAfterFirstTokenInFile && (DynAbs.Tracing.TraceSender.Expression_True(10025, 3602, 3656) && !isAfterNonWhitespaceOnLine));
                        DynAbs.Tracing.TraceSender.TraceBreak(10025, 3680, 3686);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 2169, 6254);

                    case SyntaxKind.ErrorKeyword:
                    case SyntaxKind.WarningKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 2169, 6254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 3806, 3906);

                        result = f_10025_3815_3905(this, hash, f_10025_3855_3894(this, contextualKind), isActive);
                        DynAbs.Tracing.TraceSender.TraceBreak(10025, 3928, 3934);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 2169, 6254);

                    case SyntaxKind.LineKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 2169, 6254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 4004, 4094);

                        result = f_10025_4013_4093(this, hash, f_10025_4043_4082(this, contextualKind), isActive);
                        DynAbs.Tracing.TraceSender.TraceBreak(10025, 4116, 4122);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 2169, 6254);

                    case SyntaxKind.PragmaKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 2169, 6254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 4194, 4286);

                        result = f_10025_4203_4285(this, hash, f_10025_4235_4274(this, contextualKind), isActive);
                        DynAbs.Tracing.TraceSender.TraceBreak(10025, 4308, 4314);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 2169, 6254);

                    case SyntaxKind.ReferenceKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 2169, 6254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 4389, 4540);

                        result = f_10025_4398_4539(this, hash, f_10025_4433_4472(this, contextualKind), isActive, isAfterFirstTokenInFile && (DynAbs.Tracing.TraceSender.Expression_True(10025, 4484, 4538) && !isAfterNonWhitespaceOnLine));
                        DynAbs.Tracing.TraceSender.TraceBreak(10025, 4562, 4568);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 2169, 6254);

                    case SyntaxKind.LoadKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 2169, 6254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 4638, 4784);

                        result = f_10025_4647_4783(this, hash, f_10025_4677_4716(this, contextualKind), isActive, isAfterFirstTokenInFile && (DynAbs.Tracing.TraceSender.Expression_True(10025, 4728, 4782) && !isAfterNonWhitespaceOnLine));
                        DynAbs.Tracing.TraceSender.TraceBreak(10025, 4806, 4812);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 2169, 6254);

                    case SyntaxKind.NullableKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 2169, 6254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 4886, 4980);

                        result = f_10025_4895_4979(this, hash, f_10025_4929_4968(this, contextualKind), isActive);
                        DynAbs.Tracing.TraceSender.TraceBreak(10025, 5002, 5008);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 2169, 6254);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 2169, 6254);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 5058, 6209) || true) && (f_10025_5062_5080(f_10025_5062_5075(lexer)) == SourceCodeKind.Script && (DynAbs.Tracing.TraceSender.Expression_True(10025, 5062, 5154) && contextualKind == SyntaxKind.ExclamationToken) && (DynAbs.Tracing.TraceSender.Expression_True(10025, 5062, 5175) && hashPosition == 0) && (DynAbs.Tracing.TraceSender.Expression_True(10025, 5062, 5202) && f_10025_5179_5202_M(!hash.HasTrailingTrivia)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 5058, 6209);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 5252, 5348);

                            result = f_10025_5261_5347(this, hash, f_10025_5294_5336(this, SyntaxKind.ExclamationToken), isActive);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 5058, 6209);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 5058, 6209);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 5446, 5504);

                            var
                            id = f_10025_5455_5503(this, SyntaxKind.IdentifierToken, false)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 5530, 5585);

                            var
                            end = f_10025_5540_5584(this, ignoreErrors: true)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 5611, 6091) || true) && (!isAfterNonWhitespaceOnLine)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 5611, 6091);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 5700, 6064) || true) && (f_10025_5704_5717_M(!id.IsMissing))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 5700, 6064);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 5783, 5841);

                                    id = f_10025_5788_5840(this, id, ErrorCode.ERR_PPDirectiveExpected);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 5700, 6064);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 5700, 6064);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 5971, 6033);

                                    hash = f_10025_5978_6032(this, hash, ErrorCode.ERR_PPDirectiveExpected);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 5700, 6064);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 5611, 6091);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 6119, 6186);

                            result = f_10025_6128_6185(hash, id, end, isActive);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 5058, 6209);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10025, 6233, 6239);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 2169, 6254);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 6270, 6284);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 829, 6295);

                int
                f_10025_1060_1085(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 1060, 1085);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_1111_1153(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, bool
                reportError)
                {
                    var return_v = this_param.EatToken(kind, reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 1111, 1153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_1239_1295(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 1239, 1295);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_2122_2139(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 2122, 2139);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_2122_2154(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ContextualKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 2122, 2154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_2310_2349(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatContextualToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 2310, 2349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
                f_10025_2282_2360(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hash, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                keyword, bool
                isActive)
                {
                    var return_v = this_param.ParseIfDirective(hash, keyword, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 2282, 2360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_2498_2537(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatContextualToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 2498, 2537);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
                f_10025_2468_2561(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hash, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                keyword, bool
                isActive, bool
                endIsActive)
                {
                    var return_v = this_param.ParseElifDirective(hash, keyword, isActive, endIsActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 2468, 2561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_2699_2738(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatContextualToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 2699, 2738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
                f_10025_2669_2762(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hash, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                keyword, bool
                isActive, bool
                endIsActive)
                {
                    var return_v = this_param.ParseElseDirective(hash, keyword, isActive, endIsActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 2669, 2762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_2902_2941(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatContextualToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 2902, 2941);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
                f_10025_2871_2965(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hash, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                keyword, bool
                isActive, bool
                endIsActive)
                {
                    var return_v = this_param.ParseEndIfDirective(hash, keyword, isActive, endIsActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 2871, 2965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_3107_3146(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatContextualToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 3107, 3146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
                f_10025_3075_3157(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hash, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                keyword, bool
                isActive)
                {
                    var return_v = this_param.ParseRegionDirective(hash, keyword, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 3075, 3157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_3305_3344(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatContextualToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 3305, 3344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
                f_10025_3270_3355(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hash, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                keyword, bool
                isActive)
                {
                    var return_v = this_param.ParseEndRegionDirective(hash, keyword, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 3270, 3355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_3551_3590(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatContextualToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 3551, 3590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
                f_10025_3512_3657(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hash, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                keyword, bool
                isActive, bool
                isFollowingToken)
                {
                    var return_v = this_param.ParseDefineOrUndefDirective(hash, keyword, isActive, isFollowingToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 3512, 3657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_3855_3894(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatContextualToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 3855, 3894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
                f_10025_3815_3905(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hash, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                keyword, bool
                isActive)
                {
                    var return_v = this_param.ParseErrorOrWarningDirective(hash, keyword, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 3815, 3905);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_4043_4082(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatContextualToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 4043, 4082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
                f_10025_4013_4093(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hash, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                id, bool
                isActive)
                {
                    var return_v = this_param.ParseLineDirective(hash, id, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 4013, 4093);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_4235_4274(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatContextualToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 4235, 4274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
                f_10025_4203_4285(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hash, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                pragma, bool
                isActive)
                {
                    var return_v = this_param.ParsePragmaDirective(hash, pragma, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 4203, 4285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_4433_4472(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatContextualToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 4433, 4472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
                f_10025_4398_4539(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hash, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                keyword, bool
                isActive, bool
                isFollowingToken)
                {
                    var return_v = this_param.ParseReferenceDirective(hash, keyword, isActive, isFollowingToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 4398, 4539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_4677_4716(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatContextualToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 4677, 4716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
                f_10025_4647_4783(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hash, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                keyword, bool
                isActive, bool
                isFollowingToken)
                {
                    var return_v = this_param.ParseLoadDirective(hash, keyword, isActive, isFollowingToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 4647, 4783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_4929_4968(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatContextualToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 4929, 4968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
                f_10025_4895_4979(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hash, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token, bool
                isActive)
                {
                    var return_v = this_param.ParseNullableDirective(hash, token, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 4895, 4979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10025_5062_5075(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 5062, 5075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceCodeKind
                f_10025_5062_5080(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 5062, 5080);
                    return return_v;
                }


                bool
                f_10025_5179_5202_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 5179, 5202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_5294_5336(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 5294, 5336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveTriviaSyntax
                f_10025_5261_5347(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hash, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                exclamation, bool
                isActive)
                {
                    var return_v = this_param.ParseShebangDirective(hash, exclamation, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 5261, 5347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_5455_5503(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, bool
                reportError)
                {
                    var return_v = this_param.EatToken(kind, reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 5455, 5503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_5540_5584(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, bool
                ignoreErrors)
                {
                    var return_v = this_param.ParseEndOfDirective(ignoreErrors: ignoreErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 5540, 5584);
                    return return_v;
                }


                bool
                f_10025_5704_5717_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 5704, 5717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_5788_5840(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 5788, 5840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_5978_6032(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 5978, 6032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                f_10025_6128_6185(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.BadDirectiveTrivia(hashToken, identifier, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 6128, 6185);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 829, 6295);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 829, 6295);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DirectiveTriviaSyntax ParseIfDirective(SyntaxToken hash, SyntaxToken keyword, bool isActive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 6307, 6759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 6432, 6466);

                var
                expr = f_10025_6443_6465(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 6480, 6536);

                var
                eod = f_10025_6490_6535(this, ignoreErrors: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 6550, 6587);

                var
                isTrue = f_10025_6563_6586(this, expr)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 6601, 6638);

                var
                branchTaken = isActive && (DynAbs.Tracing.TraceSender.Expression_True(10025, 6619, 6637) && isTrue)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 6652, 6748);

                return f_10025_6659_6747(hash, keyword, expr, eod, isActive, branchTaken, isTrue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 6307, 6759);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10025_6443_6465(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.ParseExpression();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 6443, 6465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_6490_6535(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, bool
                ignoreErrors)
                {
                    var return_v = this_param.ParseEndOfDirective(ignoreErrors: ignoreErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 6490, 6535);
                    return return_v;
                }


                bool
                f_10025_6563_6586(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expr)
                {
                    var return_v = this_param.EvaluateBool(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 6563, 6586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IfDirectiveTriviaSyntax
                f_10025_6659_6747(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                ifKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                condition, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive, bool
                branchTaken, bool
                conditionValue)
                {
                    var return_v = SyntaxFactory.IfDirectiveTrivia(hashToken, ifKeyword, condition, endOfDirectiveToken, isActive, branchTaken, conditionValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 6659, 6747);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 6307, 6759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 6307, 6759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DirectiveTriviaSyntax ParseElifDirective(SyntaxToken hash, SyntaxToken keyword, bool isActive, bool endIsActive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 6771, 8247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 6916, 6950);

                var
                expr = f_10025_6927_6949(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 6964, 7020);

                var
                eod = f_10025_6974_7019(this, ignoreErrors: false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 7034, 8236) || true) && (_context.HasPreviousIfOrElif())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 7034, 8236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 7102, 7139);

                    var
                    isTrue = f_10025_7115_7138(this, expr)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 7157, 7232);

                    var
                    branchTaken = endIsActive && (DynAbs.Tracing.TraceSender.Expression_True(10025, 7175, 7196) && isTrue) && (DynAbs.Tracing.TraceSender.Expression_True(10025, 7175, 7231) && !_context.PreviousBranchTaken())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 7250, 7351);

                    return f_10025_7257_7350(hash, keyword, expr, eod, endIsActive, branchTaken, isTrue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 7034, 8236);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 7034, 8236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 7417, 7542);

                    eod = f_10025_7423_7541(eod, f_10025_7450_7540(f_10025_7468_7515(f_10025_7495_7514(expr)), f_10025_7517_7539(eod)));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 7560, 8221) || true) && (_context.HasUnfinishedRegion())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 7560, 8221);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 7636, 7763);

                        return f_10025_7643_7762(this, f_10025_7657_7719(hash, keyword, eod, isActive), ErrorCode.ERR_EndRegionDirectiveExpected);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 7560, 8221);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 7560, 8221);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 7805, 8221) || true) && (_context.HasUnfinishedIf())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 7805, 8221);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 7877, 8000);

                            return f_10025_7884_7999(this, f_10025_7898_7960(hash, keyword, eod, isActive), ErrorCode.ERR_EndifDirectiveExpected);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 7805, 8221);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 7805, 8221);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 8082, 8202);

                            return f_10025_8089_8201(this, f_10025_8103_8165(hash, keyword, eod, isActive), ErrorCode.ERR_UnexpectedDirective);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 7805, 8221);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 7560, 8221);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 7034, 8236);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 6771, 8247);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10025_6927_6949(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.ParseExpression();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 6927, 6949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_6974_7019(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, bool
                ignoreErrors)
                {
                    var return_v = this_param.ParseEndOfDirective(ignoreErrors: ignoreErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 6974, 7019);
                    return return_v;
                }


                bool
                f_10025_7115_7138(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expr)
                {
                    var return_v = this_param.EvaluateBool(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 7115, 7138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ElifDirectiveTriviaSyntax
                f_10025_7257_7350(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                elifKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                condition, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive, bool
                branchTaken, bool
                conditionValue)
                {
                    var return_v = SyntaxFactory.ElifDirectiveTrivia(hashToken, elifKeyword, condition, endOfDirectiveToken, isActive, branchTaken, conditionValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 7257, 7350);
                    return return_v;
                }


                string
                f_10025_7495_7514(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 7495, 7514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10025_7468_7515(string
                text)
                {
                    var return_v = SyntaxFactory.DisabledText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 7468, 7515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10025_7517_7539(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetLeadingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 7517, 7539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_10025_7450_7540(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                left, Microsoft.CodeAnalysis.GreenNode
                right)
                {
                    var return_v = SyntaxList.Concat((Microsoft.CodeAnalysis.GreenNode)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 7450, 7540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_7423_7541(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param, Microsoft.CodeAnalysis.GreenNode?
                trivia)
                {
                    var return_v = this_param.TokenWithLeadingTrivia(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 7423, 7541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                f_10025_7657_7719(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.BadDirectiveTrivia(hashToken, identifier, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 7657, 7719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                f_10025_7643_7762(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 7643, 7762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                f_10025_7898_7960(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.BadDirectiveTrivia(hashToken, identifier, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 7898, 7960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                f_10025_7884_7999(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 7884, 7999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                f_10025_8103_8165(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.BadDirectiveTrivia(hashToken, identifier, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 8103, 8165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                f_10025_8089_8201(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 8089, 8201);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 6771, 8247);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 6771, 8247);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DirectiveTriviaSyntax ParseElseDirective(SyntaxToken hash, SyntaxToken keyword, bool isActive, bool endIsActive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 8259, 9374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 8404, 8460);

                var
                eod = f_10025_8414_8459(this, ignoreErrors: false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 8474, 9363) || true) && (_context.HasPreviousIfOrElif())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 8474, 9363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 8542, 8607);

                    var
                    branchTaken = endIsActive && (DynAbs.Tracing.TraceSender.Expression_True(10025, 8560, 8606) && !_context.PreviousBranchTaken())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 8625, 8712);

                    return f_10025_8632_8711(hash, keyword, eod, endIsActive, branchTaken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 8474, 9363);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 8474, 9363);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 8746, 9363) || true) && (_context.HasUnfinishedRegion())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 8746, 9363);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 8814, 8941);

                        return f_10025_8821_8940(this, f_10025_8835_8897(hash, keyword, eod, isActive), ErrorCode.ERR_EndRegionDirectiveExpected);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 8746, 9363);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 8746, 9363);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 8975, 9363) || true) && (_context.HasUnfinishedIf())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 8975, 9363);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 9039, 9162);

                            return f_10025_9046_9161(this, f_10025_9060_9122(hash, keyword, eod, isActive), ErrorCode.ERR_EndifDirectiveExpected);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 8975, 9363);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 8975, 9363);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 9228, 9348);

                            return f_10025_9235_9347(this, f_10025_9249_9311(hash, keyword, eod, isActive), ErrorCode.ERR_UnexpectedDirective);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 8975, 9363);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 8746, 9363);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 8474, 9363);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 8259, 9374);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_8414_8459(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, bool
                ignoreErrors)
                {
                    var return_v = this_param.ParseEndOfDirective(ignoreErrors: ignoreErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 8414, 8459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ElseDirectiveTriviaSyntax
                f_10025_8632_8711(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                elseKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive, bool
                branchTaken)
                {
                    var return_v = SyntaxFactory.ElseDirectiveTrivia(hashToken, elseKeyword, endOfDirectiveToken, isActive, branchTaken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 8632, 8711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                f_10025_8835_8897(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.BadDirectiveTrivia(hashToken, identifier, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 8835, 8897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                f_10025_8821_8940(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 8821, 8940);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                f_10025_9060_9122(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.BadDirectiveTrivia(hashToken, identifier, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 9060, 9122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                f_10025_9046_9161(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 9046, 9161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                f_10025_9249_9311(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.BadDirectiveTrivia(hashToken, identifier, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 9249, 9311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                f_10025_9235_9347(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 9235, 9347);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 8259, 9374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 8259, 9374);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DirectiveTriviaSyntax ParseEndIfDirective(SyntaxToken hash, SyntaxToken keyword, bool isActive, bool endIsActive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 9386, 10377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 9532, 9588);

                var
                eod = f_10025_9542_9587(this, ignoreErrors: false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 9602, 10366) || true) && (_context.HasUnfinishedIf())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 9602, 10366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 9666, 9741);

                    return f_10025_9673_9740(hash, keyword, eod, endIsActive);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 9602, 10366);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 9602, 10366);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 9775, 10366) || true) && (_context.HasUnfinishedRegion())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 9775, 10366);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 10038, 10165);

                        return f_10025_10045_10164(this, f_10025_10059_10121(hash, keyword, eod, isActive), ErrorCode.ERR_EndRegionDirectiveExpected);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 9775, 10366);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 9775, 10366);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 10231, 10351);

                        return f_10025_10238_10350(this, f_10025_10252_10314(hash, keyword, eod, isActive), ErrorCode.ERR_UnexpectedDirective);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 9775, 10366);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 9602, 10366);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 9386, 10377);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_9542_9587(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, bool
                ignoreErrors)
                {
                    var return_v = this_param.ParseEndOfDirective(ignoreErrors: ignoreErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 9542, 9587);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.EndIfDirectiveTriviaSyntax
                f_10025_9673_9740(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endIfKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.EndIfDirectiveTrivia(hashToken, endIfKeyword, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 9673, 9740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                f_10025_10059_10121(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.BadDirectiveTrivia(hashToken, identifier, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 10059, 10121);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                f_10025_10045_10164(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 10045, 10164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                f_10025_10252_10314(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.BadDirectiveTrivia(hashToken, identifier, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 10252, 10314);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                f_10025_10238_10350(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 10238, 10350);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 9386, 10377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 9386, 10377);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DirectiveTriviaSyntax ParseRegionDirective(SyntaxToken hash, SyntaxToken keyword, bool isActive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 10389, 10657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 10518, 10646);

                return f_10025_10525_10645(hash, keyword, f_10025_10576_10634(this), isActive);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 10389, 10657);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_10576_10634(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.ParseEndOfDirectiveWithOptionalPreprocessingMessage();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 10576, 10634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.RegionDirectiveTriviaSyntax
                f_10025_10525_10645(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                regionKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.RegionDirectiveTrivia(hashToken, regionKeyword, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 10525, 10645);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 10389, 10657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 10389, 10657);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DirectiveTriviaSyntax ParseEndRegionDirective(SyntaxToken hash, SyntaxToken keyword, bool isActive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 10669, 11461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 10801, 10870);

                var
                eod = f_10025_10811_10869(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 10884, 11450) || true) && (_context.HasUnfinishedRegion())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 10884, 11450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 10952, 11028);

                    return f_10025_10959_11027(hash, keyword, eod, isActive);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 10884, 11450);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 10884, 11450);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 11062, 11450) || true) && (_context.HasUnfinishedIf())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 11062, 11450);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 11126, 11249);

                        return f_10025_11133_11248(this, f_10025_11147_11209(hash, keyword, eod, isActive), ErrorCode.ERR_EndifDirectiveExpected);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 11062, 11450);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 11062, 11450);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 11315, 11435);

                        return f_10025_11322_11434(this, f_10025_11336_11398(hash, keyword, eod, isActive), ErrorCode.ERR_UnexpectedDirective);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 11062, 11450);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 10884, 11450);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 10669, 11461);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_10811_10869(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.ParseEndOfDirectiveWithOptionalPreprocessingMessage();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 10811, 10869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.EndRegionDirectiveTriviaSyntax
                f_10025_10959_11027(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endRegionKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.EndRegionDirectiveTrivia(hashToken, endRegionKeyword, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 10959, 11027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                f_10025_11147_11209(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.BadDirectiveTrivia(hashToken, identifier, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 11147, 11209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                f_10025_11133_11248(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 11133, 11248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                f_10025_11336_11398(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.BadDirectiveTrivia(hashToken, identifier, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 11336, 11398);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                f_10025_11322_11434(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BadDirectiveTriviaSyntax>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 11322, 11434);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 10669, 11461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 10669, 11461);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DirectiveTriviaSyntax ParseDefineOrUndefDirective(SyntaxToken hash, SyntaxToken keyword, bool isActive, bool isFollowingToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 11473, 12336);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 11632, 11767) || true) && (isFollowingToken)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 11632, 11767);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 11686, 11752);

                    keyword = f_10025_11696_11751(this, keyword, ErrorCode.ERR_PPDefFollowsToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 11632, 11767);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 11783, 11870);

                var
                name = f_10025_11794_11869(this, SyntaxKind.IdentifierToken, ErrorCode.ERR_IdentifierExpected)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 11884, 11916);

                name = f_10025_11891_11915(name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 11930, 11995);

                var
                end = f_10025_11940_11994(this, ignoreErrors: f_10025_11979_11993(name))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 12009, 12325) || true) && (f_10025_12013_12025(keyword) == SyntaxKind.DefineKeyword)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 12009, 12325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 12087, 12166);

                    return f_10025_12094_12165(hash, keyword, name, end, isActive);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 12009, 12325);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 12009, 12325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 12232, 12310);

                    return f_10025_12239_12309(hash, keyword, name, end, isActive);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 12009, 12325);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 11473, 12336);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_11696_11751(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 11696, 11751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_11794_11869(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.EatToken(kind, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 11794, 11869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_11891_11915(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                identifier)
                {
                    var return_v = TruncateIdentifier(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 11891, 11915);
                    return return_v;
                }


                bool
                f_10025_11979_11993(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 11979, 11993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_11940_11994(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, bool
                ignoreErrors)
                {
                    var return_v = this_param.ParseEndOfDirective(ignoreErrors: ignoreErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 11940, 11994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_12013_12025(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 12013, 12025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DefineDirectiveTriviaSyntax
                f_10025_12094_12165(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                defineKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                name, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.DefineDirectiveTrivia(hashToken, defineKeyword, name, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 12094, 12165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.UndefDirectiveTriviaSyntax
                f_10025_12239_12309(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                undefKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                name, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.UndefDirectiveTrivia(hashToken, undefKeyword, name, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 12239, 12309);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 11473, 12336);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 11473, 12336);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DirectiveTriviaSyntax ParseErrorOrWarningDirective(SyntaxToken hash, SyntaxToken keyword, bool isActive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 13386, 16871);
                Microsoft.CodeAnalysis.CSharp.LanguageVersion languageVersion = default(Microsoft.CodeAnalysis.CSharp.LanguageVersion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 13523, 13592);

                var
                eod = f_10025_13533_13591(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 13606, 13661);

                bool
                isError = f_10025_13621_13633(keyword) == SyntaxKind.ErrorKeyword
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 13675, 16572) || true) && (isActive)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 13675, 16572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 13721, 13819);

                    var
                    triviaBuilder = f_10025_13741_13818(f_10025_13768_13817())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 13837, 13857);

                    int
                    triviaWidth = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 14069, 14090);

                    bool
                    skipping = true
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 14108, 14603);
                        foreach (var t in f_10025_14126_14148_I(f_10025_14126_14148(keyword)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 14108, 14603);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 14190, 14455) || true) && (skipping)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 14190, 14455);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 14252, 14387) || true) && (f_10025_14256_14262(t) == SyntaxKind.WhitespaceTrivia)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 14252, 14387);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 14351, 14360);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 14252, 14387);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 14415, 14432);

                                skipping = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 14190, 14455);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 14479, 14535);

                            f_10025_14479_14534(
                                                t, triviaBuilder, leading: true, trailing: true);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 14557, 14584);

                            triviaWidth += f_10025_14572_14583(t);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 14108, 14603);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10025, 1, 496);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10025, 1, 496);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 14623, 14833);
                        foreach (var node in f_10025_14644_14661_I(f_10025_14644_14661(eod)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 14623, 14833);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 14703, 14762);

                            f_10025_14703_14761(node, triviaBuilder, leading: true, trailing: true);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 14784, 14814);

                            triviaWidth += f_10025_14799_14813(node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 14623, 14833);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10025, 1, 211);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10025, 1, 211);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 15021, 15082);

                    int
                    triviaOffset = f_10025_15040_15067(eod) - triviaWidth
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 15102, 15146);

                    string
                    errorText = f_10025_15121_15145(triviaBuilder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 15164, 15300);

                    eod = f_10025_15170_15299(this, eod, triviaOffset, triviaWidth, (DynAbs.Tracing.TraceSender.Conditional_F1(10025, 15216, 15223) || ((isError && DynAbs.Tracing.TraceSender.Conditional_F2(10025, 15226, 15254)) || DynAbs.Tracing.TraceSender.Conditional_F3(10025, 15257, 15287))) ? ErrorCode.ERR_ErrorDirective : ErrorCode.WRN_WarningDirective, errorText);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 15320, 16557) || true) && (isError)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 15320, 16557);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 15373, 16538) || true) && (f_10025_15377_15430(errorText, "version", StringComparison.Ordinal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 15373, 16538);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 15480, 15554);

                            string
                            version = f_10025_15497_15553(typeof(CSharpCompiler))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 15580, 15769);

                            eod = f_10025_15586_15768(this, eod, triviaOffset, triviaWidth, ErrorCode.ERR_CompilerAndLanguageVersion, version, f_10025_15712_15767(f_10025_15712_15749(f_10025_15712_15724(this))));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 15373, 16538);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 15373, 16538);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 15867, 15907);

                            const string
                            versionMarker = "version:"
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 15933, 16515) || true) && (f_10025_15937_15965(f_10025_15937_15949(this)) != LanguageVersion.Preview && (DynAbs.Tracing.TraceSender.Expression_True(10025, 15937, 16086) && f_10025_16025_16086(errorText, versionMarker, StringComparison.Ordinal)) && (DynAbs.Tracing.TraceSender.Expression_True(10025, 15937, 16216) && f_10025_16119_16216(f_10025_16149_16190(errorText, f_10025_16169_16189(versionMarker)), out languageVersion)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 15933, 16515);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 16274, 16336);

                                ErrorCode
                                error = f_10025_16292_16335(f_10025_16292_16320(f_10025_16292_16304(this)))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 16366, 16488);

                                eod = f_10025_16372_16487(this, eod, triviaOffset, triviaWidth, error, "version", f_10025_16436_16486(languageVersion));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 15933, 16515);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 15373, 16538);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 15320, 16557);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 13675, 16572);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 16588, 16860) || true) && (isError)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 16588, 16860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 16633, 16705);

                    return f_10025_16640_16704(hash, keyword, eod, isActive);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 16588, 16860);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 16588, 16860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 16771, 16845);

                    return f_10025_16778_16844(hash, keyword, eod, isActive);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 16588, 16860);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 13386, 16871);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_13533_13591(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.ParseEndOfDirectiveWithOptionalPreprocessingMessage();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 13533, 13591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_13621_13633(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 13621, 13633);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_10025_13768_13817()
                {
                    var return_v = System.Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 13768, 13817);
                    return return_v;
                }


                System.IO.StringWriter
                f_10025_13741_13818(System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = new System.IO.StringWriter((System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 13741, 13818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                f_10025_14126_14148(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.TrailingTrivia;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 14126, 14148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_14256_14262(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 14256, 14262);
                    return return_v;
                }


                int
                f_10025_14479_14534(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param, System.IO.StringWriter
                writer, bool
                leading, bool
                trailing)
                {
                    this_param.WriteTo((System.IO.TextWriter)writer, leading: leading, trailing: trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 14479, 14534);
                    return 0;
                }


                int
                f_10025_14572_14583(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 14572, 14583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                f_10025_14126_14148_I(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 14126, 14148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                f_10025_14644_14661(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.LeadingTrivia;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 14644, 14661);
                    return return_v;
                }


                int
                f_10025_14703_14761(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param, System.IO.StringWriter
                writer, bool
                leading, bool
                trailing)
                {
                    this_param.WriteTo((System.IO.TextWriter)writer, leading: leading, trailing: trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 14703, 14761);
                    return 0;
                }


                int
                f_10025_14799_14813(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 14799, 14813);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                f_10025_14644_14661_I(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 14644, 14661);
                    return return_v;
                }


                int
                f_10025_15040_15067(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetLeadingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 15040, 15067);
                    return return_v;
                }


                string
                f_10025_15121_15145(System.IO.StringWriter
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 15121, 15145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_15170_15299(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, int
                offset, int
                length, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, offset, length, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 15170, 15299);
                    return return_v;
                }


                bool
                f_10025_15377_15430(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 15377, 15430);
                    return return_v;
                }


                string
                f_10025_15497_15553(System.Type
                type)
                {
                    var return_v = CommonCompiler.GetProductVersion(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 15497, 15553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10025_15712_15724(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 15712, 15724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10025_15712_15749(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.SpecifiedLanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 15712, 15749);
                    return return_v;
                }


                string
                f_10025_15712_15767(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = version.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 15712, 15767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_15586_15768(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, int
                offset, int
                length, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, offset, length, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 15586, 15768);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10025_15937_15949(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 15937, 15949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10025_15937_15965(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 15937, 15965);
                    return return_v;
                }


                bool
                f_10025_16025_16086(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 16025, 16086);
                    return return_v;
                }


                int
                f_10025_16169_16189(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 16169, 16189);
                    return return_v;
                }


                string
                f_10025_16149_16190(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 16149, 16190);
                    return return_v;
                }


                bool
                f_10025_16119_16216(string
                version, out Microsoft.CodeAnalysis.CSharp.LanguageVersion
                result)
                {
                    var return_v = LanguageVersionFacts.TryParse(version, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 16119, 16216);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10025_16292_16304(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 16292, 16304);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10025_16292_16320(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 16292, 16320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10025_16292_16335(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = version.GetErrorCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 16292, 16335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion
                f_10025_16436_16486(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 16436, 16486);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_16372_16487(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, int
                offset, int
                length, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, offset, length, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 16372, 16487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ErrorDirectiveTriviaSyntax
                f_10025_16640_16704(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                errorKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.ErrorDirectiveTrivia(hashToken, errorKeyword, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 16640, 16704);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.WarningDirectiveTriviaSyntax
                f_10025_16778_16844(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                warningKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.WarningDirectiveTrivia(hashToken, warningKeyword, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 16778, 16844);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 13386, 16871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 13386, 16871);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DirectiveTriviaSyntax ParseLineDirective(SyntaxToken hash, SyntaxToken id, bool isActive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 16883, 18860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 17005, 17022);

                SyntaxToken
                line
                = default(SyntaxToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 17036, 17060);

                SyntaxToken
                file = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 17074, 17105);

                bool
                sawLineButNotFile = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 17119, 18627);

                switch (f_10025_17127_17149(f_10025_17127_17144(this)))
                {

                    case SyntaxKind.DefaultKeyword:
                    case SyntaxKind.HiddenKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 17119, 18627);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 17284, 17307);

                        line = f_10025_17291_17306(this);
                        DynAbs.Tracing.TraceSender.TraceBreak(10025, 17329, 17335);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 17119, 18627);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 17119, 18627);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 17383, 17492);

                        line = f_10025_17390_17491(this, SyntaxKind.NumericLiteralToken, ErrorCode.ERR_InvalidLineNumber, reportError: isActive);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 17514, 17539);

                        sawLineButNotFile = true;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 17634, 18165) || true) && (isActive && (DynAbs.Tracing.TraceSender.Expression_True(10025, 17638, 17665) && f_10025_17650_17665_M(!line.IsMissing)) && (DynAbs.Tracing.TraceSender.Expression_True(10025, 17638, 17712) && f_10025_17669_17678(line) == SyntaxKind.NumericLiteralToken))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 17634, 18165);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 17762, 18142) || true) && ((int)f_10025_17771_17781(line) < 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 17762, 18142);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 17843, 17903);

                                line = f_10025_17850_17902(this, line, ErrorCode.ERR_InvalidLineNumber);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 17762, 18142);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 17762, 18142);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 17961, 18142) || true) && ((int)f_10025_17970_17980(line) > 0xfeefed)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 17961, 18142);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 18049, 18115);

                                    line = f_10025_18056_18114(this, line, ErrorCode.WRN_TooManyLinesForDebugger);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 17961, 18142);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 17762, 18142);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 17634, 18165);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 18189, 18582) || true) && (f_10025_18193_18215(f_10025_18193_18210(this)) == SyntaxKind.StringLiteralToken && (DynAbs.Tracing.TraceSender.Expression_True(10025, 18193, 18379) && (f_10025_18278_18292(line) || (DynAbs.Tracing.TraceSender.Expression_False(10025, 18278, 18329) || f_10025_18296_18325(line) > 0) || (DynAbs.Tracing.TraceSender.Expression_False(10025, 18278, 18378) || f_10025_18333_18374(f_10025_18333_18350(this)) > 0))))
                        ) //require separation between line number and file name

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 18189, 18582);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 18484, 18507);

                            file = f_10025_18491_18506(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 18533, 18559);

                            sawLineButNotFile = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 18189, 18582);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10025, 18606, 18612);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 17119, 18627);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 18643, 18757);

                var
                end = f_10025_18653_18756(this, ignoreErrors: f_10025_18692_18706(line) || (DynAbs.Tracing.TraceSender.Expression_False(10025, 18692, 18719) || !isActive), afterLineNumber: sawLineButNotFile)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 18771, 18849);

                return f_10025_18778_18848(hash, id, line, file, end, isActive);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 16883, 18860);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_17127_17144(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 17127, 17144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_17127_17149(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 17127, 17149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_17291_17306(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 17291, 17306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_17390_17491(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, bool
                reportError)
                {
                    var return_v = this_param.EatToken(kind, code, reportError: reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 17390, 17491);
                    return return_v;
                }


                bool
                f_10025_17650_17665_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 17650, 17665);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_17669_17678(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 17669, 17678);
                    return return_v;
                }


                object
                f_10025_17771_17781(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 17771, 17781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_17850_17902(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 17850, 17902);
                    return return_v;
                }


                object
                f_10025_17970_17980(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 17970, 17980);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_18056_18114(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 18056, 18114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_18193_18210(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 18193, 18210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_18193_18215(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 18193, 18215);
                    return return_v;
                }


                bool
                f_10025_18278_18292(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 18278, 18292);
                    return return_v;
                }


                int
                f_10025_18296_18325(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetTrailingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 18296, 18325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_18333_18350(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 18333, 18350);
                    return return_v;
                }


                int
                f_10025_18333_18374(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetLeadingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 18333, 18374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_18491_18506(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 18491, 18506);
                    return return_v;
                }


                bool
                f_10025_18692_18706(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 18692, 18706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_18653_18756(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, bool
                ignoreErrors, bool
                afterLineNumber)
                {
                    var return_v = this_param.ParseEndOfDirective(ignoreErrors: ignoreErrors, afterLineNumber: afterLineNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 18653, 18756);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LineDirectiveTriviaSyntax
                f_10025_18778_18848(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                lineKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                line, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken?
                file, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.LineDirectiveTrivia(hashToken, lineKeyword, line, file, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 18778, 18848);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 16883, 18860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 16883, 18860);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DirectiveTriviaSyntax ParseReferenceDirective(SyntaxToken hash, SyntaxToken keyword, bool isActive, bool isFollowingToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 18872, 19788);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 19027, 19454) || true) && (isActive)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 19027, 19454);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 19073, 19439) || true) && (f_10025_19077_19089(f_10025_19077_19084()) == SourceCodeKind.Regular)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 19073, 19439);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 19157, 19244);

                        keyword = f_10025_19167_19243(this, keyword, ErrorCode.ERR_ReferenceDirectiveOnlyAllowedInScripts);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 19073, 19439);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 19073, 19439);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 19286, 19439) || true) && (isFollowingToken)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 19286, 19439);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 19348, 19420);

                            keyword = f_10025_19358_19419(this, keyword, ErrorCode.ERR_PPReferenceFollowsToken);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 19286, 19439);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 19073, 19439);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 19027, 19454);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 19470, 19587);

                SyntaxToken
                file = f_10025_19489_19586(this, SyntaxKind.StringLiteralToken, ErrorCode.ERR_ExpectedPPFile, reportError: isActive)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 19603, 19681);

                var
                end = f_10025_19613_19680(this, ignoreErrors: f_10025_19652_19666(file) || (DynAbs.Tracing.TraceSender.Expression_False(10025, 19652, 19679) || !isActive))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 19695, 19777);

                return f_10025_19702_19776(hash, keyword, file, end, isActive);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 18872, 19788);

                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10025_19077_19084()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 19077, 19084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceCodeKind
                f_10025_19077_19089(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 19077, 19089);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_19167_19243(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 19167, 19243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_19358_19419(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 19358, 19419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_19489_19586(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, bool
                reportError)
                {
                    var return_v = this_param.EatToken(kind, code, reportError: reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 19489, 19586);
                    return return_v;
                }


                bool
                f_10025_19652_19666(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 19652, 19666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_19613_19680(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, bool
                ignoreErrors)
                {
                    var return_v = this_param.ParseEndOfDirective(ignoreErrors: ignoreErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 19613, 19680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ReferenceDirectiveTriviaSyntax
                f_10025_19702_19776(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                referenceKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                file, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.ReferenceDirectiveTrivia(hashToken, referenceKeyword, file, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 19702, 19776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 18872, 19788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 18872, 19788);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DirectiveTriviaSyntax ParseLoadDirective(SyntaxToken hash, SyntaxToken keyword, bool isActive, bool isFollowingToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 19800, 20696);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 19950, 20367) || true) && (isActive)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 19950, 20367);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 19996, 20352) || true) && (f_10025_20000_20012(f_10025_20000_20007()) == SourceCodeKind.Regular)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 19996, 20352);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 20080, 20162);

                        keyword = f_10025_20090_20161(this, keyword, ErrorCode.ERR_LoadDirectiveOnlyAllowedInScripts);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 19996, 20352);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 19996, 20352);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 20204, 20352) || true) && (isFollowingToken)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 20204, 20352);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 20266, 20333);

                            keyword = f_10025_20276_20332(this, keyword, ErrorCode.ERR_PPLoadFollowsToken);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 20204, 20352);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 19996, 20352);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 19950, 20367);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 20383, 20500);

                SyntaxToken
                file = f_10025_20402_20499(this, SyntaxKind.StringLiteralToken, ErrorCode.ERR_ExpectedPPFile, reportError: isActive)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 20516, 20594);

                var
                end = f_10025_20526_20593(this, ignoreErrors: f_10025_20565_20579(file) || (DynAbs.Tracing.TraceSender.Expression_False(10025, 20565, 20592) || !isActive))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 20608, 20685);

                return f_10025_20615_20684(hash, keyword, file, end, isActive);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 19800, 20696);

                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10025_20000_20007()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 20000, 20007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceCodeKind
                f_10025_20000_20012(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 20000, 20012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_20090_20161(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 20090, 20161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_20276_20332(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 20276, 20332);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_20402_20499(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, bool
                reportError)
                {
                    var return_v = this_param.EatToken(kind, code, reportError: reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 20402, 20499);
                    return return_v;
                }


                bool
                f_10025_20565_20579(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 20565, 20579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_20526_20593(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, bool
                ignoreErrors)
                {
                    var return_v = this_param.ParseEndOfDirective(ignoreErrors: ignoreErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 20526, 20593);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LoadDirectiveTriviaSyntax
                f_10025_20615_20684(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                loadKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                file, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.LoadDirectiveTrivia(hashToken, loadKeyword, file, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 20615, 20684);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 19800, 20696);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 19800, 20696);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DirectiveTriviaSyntax ParseNullableDirective(SyntaxToken hash, SyntaxToken token, bool isActive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 20708, 22104);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 20837, 20983) || true) && (isActive)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 20837, 20983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 20883, 20968);

                    token = f_10025_20891_20967(this, token, MessageID.IDS_FeatureNullableReferenceTypes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 20837, 20983);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 20999, 21385);

                SyntaxToken
                setting = f_10025_21021_21043(f_10025_21021_21038(this)) switch
                {
                    SyntaxKind.EnableKeyword when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 21083, 21121) && DynAbs.Tracing.TraceSender.Expression_True(10025, 21083, 21121))
    => f_10025_21111_21121(this),
                    SyntaxKind.DisableKeyword when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 21140, 21179) && DynAbs.Tracing.TraceSender.Expression_True(10025, 21140, 21179))
    => f_10025_21169_21179(this),
                    SyntaxKind.RestoreKeyword when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 21198, 21237) && DynAbs.Tracing.TraceSender.Expression_True(10025, 21198, 21237))
    => f_10025_21227_21237(this),
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 21256, 21369) && DynAbs.Tracing.TraceSender.Expression_True(10025, 21256, 21369))
    => f_10025_21261_21369(this, SyntaxKind.DisableKeyword, ErrorCode.ERR_NullableDirectiveQualifierExpected, reportError: isActive)
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 21401, 21863);

                SyntaxToken
                target = f_10025_21422_21444(f_10025_21422_21439(this)) switch
                {
                    SyntaxKind.WarningsKeyword when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 21484, 21524) && DynAbs.Tracing.TraceSender.Expression_True(10025, 21484, 21524))
    => f_10025_21514_21524(this),
                    SyntaxKind.AnnotationsKeyword when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 21543, 21586) && DynAbs.Tracing.TraceSender.Expression_True(10025, 21543, 21586))
    => f_10025_21576_21586(this),
                    SyntaxKind.EndOfDirectiveToken when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 21605, 21643) && DynAbs.Tracing.TraceSender.Expression_True(10025, 21605, 21643))
    => null,
                    SyntaxKind.EndOfFileToken when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 21662, 21695) && DynAbs.Tracing.TraceSender.Expression_True(10025, 21662, 21695))
    => null,
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 21714, 21847) && DynAbs.Tracing.TraceSender.Expression_True(10025, 21714, 21847))
    => f_10025_21719_21847(this, SyntaxKind.WarningsKeyword, ErrorCode.ERR_NullableDirectiveTargetExpected, reportError: f_10025_21816_21834_M(!setting.IsMissing) && (DynAbs.Tracing.TraceSender.Expression_True(10025, 21816, 21846) && isActive))
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 21879, 21989);

                var
                end = f_10025_21889_21988(this, ignoreErrors: f_10025_21928_21945(setting) || (DynAbs.Tracing.TraceSender.Expression_False(10025, 21928, 21974) || f_10025_21949_21966_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(target, 10025, 21949, 21966)?.IsMissing) == true) || (DynAbs.Tracing.TraceSender.Expression_False(10025, 21928, 21987) || !isActive))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 22003, 22093);

                return f_10025_22010_22092(hash, token, setting, target, end, isActive);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 20708, 22104);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_20891_20967(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = this_param.CheckFeatureAvailability<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 20891, 20967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_21021_21038(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 21021, 21038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_21021_21043(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 21021, 21043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_21111_21121(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 21111, 21121);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_21169_21179(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 21169, 21179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_21227_21237(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 21227, 21237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_21261_21369(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, bool
                reportError)
                {
                    var return_v = this_param.EatToken(kind, code, reportError: reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 21261, 21369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_21422_21439(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 21422, 21439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_21422_21444(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 21422, 21444);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_21514_21524(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 21514, 21524);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_21576_21586(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 21576, 21586);
                    return return_v;
                }


                bool
                f_10025_21816_21834_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 21816, 21834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_21719_21847(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, bool
                reportError)
                {
                    var return_v = this_param.EatToken(kind, code, reportError: reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 21719, 21847);
                    return return_v;
                }


                bool
                f_10025_21928_21945(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 21928, 21945);
                    return return_v;
                }


                bool?
                f_10025_21949_21966_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 21949, 21966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_21889_21988(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, bool
                ignoreErrors)
                {
                    var return_v = this_param.ParseEndOfDirective(ignoreErrors: ignoreErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 21889, 21988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.NullableDirectiveTriviaSyntax
                f_10025_22010_22092(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                nullableKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                settingToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken?
                targetToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.NullableDirectiveTrivia(hashToken, nullableKeyword, settingToken, targetToken, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 22010, 22092);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 20708, 22104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 20708, 22104);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DirectiveTriviaSyntax ParsePragmaDirective(SyntaxToken hash, SyntaxToken pragma, bool isActive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 22116, 29027);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 22244, 22376) || true) && (isActive)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 22244, 22376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 22290, 22361);

                    pragma = f_10025_22299_22360(this, pragma, MessageID.IDS_FeaturePragma);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 22244, 22376);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 22392, 22414);

                bool
                hasError = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 22428, 29016) || true) && (f_10025_22432_22464(f_10025_22432_22449(this)) == SyntaxKind.WarningKeyword)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 22428, 29016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 22527, 22592);

                    var
                    warning = f_10025_22541_22591(this, SyntaxKind.WarningKeyword)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 22610, 22628);

                    SyntaxToken
                    style
                    = default(SyntaxToken);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 22646, 26520) || true) && (f_10025_22650_22672(f_10025_22650_22667(this)) == SyntaxKind.DisableKeyword || (DynAbs.Tracing.TraceSender.Expression_False(10025, 22650, 22756) || f_10025_22705_22727(f_10025_22705_22722(this)) == SyntaxKind.RestoreKeyword))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 22646, 26520);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 22798, 22822);

                        style = f_10025_22806_22821(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 22846, 22909);

                        var
                        ids = f_10025_22856_22908(10)
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 22931, 25822) || true) && (f_10025_22938_22960(f_10025_22938_22955(this)) != SyntaxKind.EndOfDirectiveToken)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 22931, 25822);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 23044, 23059);

                                SyntaxToken
                                id
                                = default(SyntaxToken);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 23085, 23115);

                                ExpressionSyntax
                                idExpression
                                = default(ExpressionSyntax);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 23143, 25445) || true) && (f_10025_23147_23169(f_10025_23147_23164(this)) == SyntaxKind.NumericLiteralToken)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 23143, 25445);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 23929, 23950);

                                    id = f_10025_23934_23949(this);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 23980, 24068);

                                    idExpression = f_10025_23995_24067(SyntaxKind.NumericLiteralExpression, id);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 23143, 25445);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 23143, 25445);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 24126, 25445) || true) && (f_10025_24130_24152(f_10025_24130_24147(this)) == SyntaxKind.IdentifierToken)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 24126, 25445);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 24963, 24984);

                                        id = f_10025_24968_24983(this);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 25014, 25062);

                                        idExpression = f_10025_25029_25061(id);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 24126, 25445);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 24126, 25445);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 25176, 25300);

                                        id = f_10025_25181_25299(this, SyntaxKind.NumericLiteralToken, ErrorCode.WRN_IdentifierOrNumericLiteralExpected, reportError: isActive);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 25330, 25418);

                                        idExpression = f_10025_25345_25417(SyntaxKind.NumericLiteralExpression, id);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 24126, 25445);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 23143, 25445);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 25473, 25519);

                                hasError = hasError || (DynAbs.Tracing.TraceSender.Expression_False(10025, 25484, 25518) || f_10025_25496_25518(id));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 25545, 25567);

                                ids.Add(idExpression);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 25595, 25737) || true) && (f_10025_25599_25621(f_10025_25599_25616(this)) != SyntaxKind.CommaToken)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 25595, 25737);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10025, 25704, 25710);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 25595, 25737);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 25765, 25799);

                                ids.AddSeparator(f_10025_25782_25797(this));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 22931, 25822);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10025, 22931, 25822);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10025, 22931, 25822);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 25846, 25923);

                        var
                        end = f_10025_25856_25922(this, hasError || (DynAbs.Tracing.TraceSender.Expression_False(10025, 25881, 25902) || !isActive), afterPragma: true)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 25945, 26054);

                        return f_10025_25952_26053(hash, pragma, warning, style, ids.ToList(), end, isActive);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 22646, 26520);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 22646, 26520);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 26136, 26240);

                        style = f_10025_26144_26239(this, SyntaxKind.DisableKeyword, ErrorCode.WRN_IllegalPPWarning, reportError: isActive);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 26262, 26336);

                        var
                        end = f_10025_26272_26335(this, ignoreErrors: true, afterPragma: true)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 26358, 26501);

                        return f_10025_26365_26500(hash, pragma, warning, style, default(SeparatedSyntaxList<ExpressionSyntax>), end, isActive);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 22646, 26520);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 22428, 29016);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 22428, 29016);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 26554, 29016) || true) && (f_10025_26558_26580(f_10025_26558_26575(this)) == SyntaxKind.ChecksumKeyword)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 26554, 29016);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 26644, 26675);

                        var
                        checksum = f_10025_26659_26674(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 26693, 26805);

                        var
                        file = f_10025_26704_26804(this, SyntaxKind.StringLiteralToken, ErrorCode.WRN_IllegalPPChecksum, reportError: isActive)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 26823, 26954);

                        var
                        guid = f_10025_26834_26953(this, SyntaxKind.StringLiteralToken, ErrorCode.WRN_IllegalPPChecksum, reportError: isActive && (DynAbs.Tracing.TraceSender.Expression_True(10025, 26925, 26952) && f_10025_26937_26952_M(!file.IsMissing)))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 26972, 27271) || true) && (isActive && (DynAbs.Tracing.TraceSender.Expression_True(10025, 26976, 27003) && f_10025_26988_27003_M(!guid.IsMissing)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 26972, 27271);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 27045, 27054);

                            Guid
                            tmp
                            = default(Guid);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 27076, 27252) || true) && (!Guid.TryParse(f_10025_27095_27109(guid), out tmp))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 27076, 27252);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 27169, 27229);

                                guid = f_10025_27176_27228(this, guid, ErrorCode.WRN_IllegalPPChecksum);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 27076, 27252);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 26972, 27271);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 27291, 27423);

                        var
                        bytes = f_10025_27303_27422(this, SyntaxKind.StringLiteralToken, ErrorCode.WRN_IllegalPPChecksum, reportError: isActive && (DynAbs.Tracing.TraceSender.Expression_True(10025, 27394, 27421) && f_10025_27406_27421_M(!guid.IsMissing)))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 27441, 28150) || true) && (isActive && (DynAbs.Tracing.TraceSender.Expression_True(10025, 27445, 27473) && f_10025_27457_27473_M(!bytes.IsMissing)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 27441, 28150);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 27515, 28131) || true) && (f_10025_27519_27541(f_10025_27519_27534(bytes)) % 2 != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 27515, 28131);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 27600, 27662);

                                bytes = f_10025_27608_27661(this, bytes, ErrorCode.WRN_IllegalPPChecksum);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 27515, 28131);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 27515, 28131);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 27760, 28108);
                                    foreach (char c in f_10025_27779_27794_I(f_10025_27779_27794(bytes)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 27760, 28108);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 27852, 28081) || true) && (!f_10025_27857_27882(c))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 27852, 28081);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 27948, 28010);

                                            bytes = f_10025_27956_28009(this, bytes, ErrorCode.WRN_IllegalPPChecksum);
                                            DynAbs.Tracing.TraceSender.TraceBreak(10025, 28044, 28050);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 27852, 28081);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 27760, 28108);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10025, 1, 349);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10025, 1, 349);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 27515, 28131);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 27441, 28150);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 28170, 28261);

                        hasError = f_10025_28181_28205(file) | f_10025_28208_28232(guid) | f_10025_28235_28260(bytes);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 28279, 28357);

                        var
                        eod = f_10025_28289_28356(this, ignoreErrors: hasError, afterPragma: true)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 28375, 28484);

                        return f_10025_28382_28483(hash, pragma, checksum, file, guid, bytes, eod, isActive);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 26554, 29016);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 26554, 29016);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 28550, 28657);

                        var
                        warning = f_10025_28564_28656(this, SyntaxKind.WarningKeyword, ErrorCode.WRN_IllegalPragma, reportError: isActive)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 28675, 28748);

                        var
                        style = f_10025_28687_28747(this, SyntaxKind.DisableKeyword, reportError: false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 28766, 28840);

                        var
                        eod = f_10025_28776_28839(this, ignoreErrors: true, afterPragma: true)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 28858, 29001);

                        return f_10025_28865_29000(hash, pragma, warning, style, default(SeparatedSyntaxList<ExpressionSyntax>), eod, isActive);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 26554, 29016);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 22428, 29016);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 22116, 29027);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_22299_22360(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = this_param.CheckFeatureAvailability<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 22299, 22360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_22432_22449(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 22432, 22449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_22432_22464(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ContextualKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 22432, 22464);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_22541_22591(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatContextualToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 22541, 22591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_22650_22667(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 22650, 22667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_22650_22672(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 22650, 22672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_22705_22722(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 22705, 22722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_22705_22727(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 22705, 22727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_22806_22821(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 22806, 22821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax>
                f_10025_22856_22908(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax>(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 22856, 22908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_22938_22955(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 22938, 22955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_22938_22960(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 22938, 22960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_23147_23164(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 23147, 23164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_23147_23169(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 23147, 23169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_23934_23949(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 23934, 23949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LiteralExpressionSyntax
                f_10025_23995_24067(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = SyntaxFactory.LiteralExpression(kind, token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 23995, 24067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_24130_24147(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 24130, 24147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_24130_24152(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 24130, 24152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_24968_24983(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 24968, 24983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IdentifierNameSyntax
                f_10025_25029_25061(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                identifier)
                {
                    var return_v = SyntaxFactory.IdentifierName(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 25029, 25061);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_25181_25299(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, bool
                reportError)
                {
                    var return_v = this_param.EatToken(kind, code, reportError: reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 25181, 25299);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LiteralExpressionSyntax
                f_10025_25345_25417(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = SyntaxFactory.LiteralExpression(kind, token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 25345, 25417);
                    return return_v;
                }


                bool
                f_10025_25496_25518(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ContainsDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 25496, 25518);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_25599_25616(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 25599, 25616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_25599_25621(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 25599, 25621);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_25782_25797(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 25782, 25797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_25856_25922(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, bool
                ignoreErrors, bool
                afterPragma)
                {
                    var return_v = this_param.ParseEndOfDirective(ignoreErrors, afterPragma: afterPragma);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 25856, 25922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PragmaWarningDirectiveTriviaSyntax
                f_10025_25952_26053(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                pragmaKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                warningKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                disableOrRestoreKeyword, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax>
                errorCodes, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.PragmaWarningDirectiveTrivia(hashToken, pragmaKeyword, warningKeyword, disableOrRestoreKeyword, errorCodes, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 25952, 26053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_26144_26239(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, bool
                reportError)
                {
                    var return_v = this_param.EatToken(kind, code, reportError: reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 26144, 26239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_26272_26335(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, bool
                ignoreErrors, bool
                afterPragma)
                {
                    var return_v = this_param.ParseEndOfDirective(ignoreErrors: ignoreErrors, afterPragma: afterPragma);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 26272, 26335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PragmaWarningDirectiveTriviaSyntax
                f_10025_26365_26500(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                pragmaKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                warningKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                disableOrRestoreKeyword, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax>
                errorCodes, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.PragmaWarningDirectiveTrivia(hashToken, pragmaKeyword, warningKeyword, disableOrRestoreKeyword, errorCodes, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 26365, 26500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_26558_26575(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 26558, 26575);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_26558_26580(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 26558, 26580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_26659_26674(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 26659, 26674);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_26704_26804(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, bool
                reportError)
                {
                    var return_v = this_param.EatToken(kind, code, reportError: reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 26704, 26804);
                    return return_v;
                }


                bool
                f_10025_26937_26952_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 26937, 26952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_26834_26953(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, bool
                reportError)
                {
                    var return_v = this_param.EatToken(kind, code, reportError: reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 26834, 26953);
                    return return_v;
                }


                bool
                f_10025_26988_27003_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 26988, 27003);
                    return return_v;
                }


                string
                f_10025_27095_27109(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 27095, 27109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_27176_27228(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 27176, 27228);
                    return return_v;
                }


                bool
                f_10025_27406_27421_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 27406, 27421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_27303_27422(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, bool
                reportError)
                {
                    var return_v = this_param.EatToken(kind, code, reportError: reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 27303, 27422);
                    return return_v;
                }


                bool
                f_10025_27457_27473_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 27457, 27473);
                    return return_v;
                }


                string
                f_10025_27519_27534(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 27519, 27534);
                    return return_v;
                }


                int
                f_10025_27519_27541(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 27519, 27541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_27608_27661(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 27608, 27661);
                    return return_v;
                }


                string
                f_10025_27779_27794(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 27779, 27794);
                    return return_v;
                }


                bool
                f_10025_27857_27882(char
                c)
                {
                    var return_v = SyntaxFacts.IsHexDigit(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 27857, 27882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_27956_28009(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 27956, 28009);
                    return return_v;
                }


                string
                f_10025_27779_27794_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 27779, 27794);
                    return return_v;
                }


                bool
                f_10025_28181_28205(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ContainsDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 28181, 28205);
                    return return_v;
                }


                bool
                f_10025_28208_28232(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ContainsDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 28208, 28232);
                    return return_v;
                }


                bool
                f_10025_28235_28260(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ContainsDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 28235, 28260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_28289_28356(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, bool
                ignoreErrors, bool
                afterPragma)
                {
                    var return_v = this_param.ParseEndOfDirective(ignoreErrors: ignoreErrors, afterPragma: afterPragma);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 28289, 28356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PragmaChecksumDirectiveTriviaSyntax
                f_10025_28382_28483(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                pragmaKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                checksumKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                file, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                guid, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                bytes, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.PragmaChecksumDirectiveTrivia(hashToken, pragmaKeyword, checksumKeyword, file, guid, bytes, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 28382, 28483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_28564_28656(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, bool
                reportError)
                {
                    var return_v = this_param.EatToken(kind, code, reportError: reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 28564, 28656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_28687_28747(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, bool
                reportError)
                {
                    var return_v = this_param.EatToken(kind, reportError: reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 28687, 28747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_28776_28839(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, bool
                ignoreErrors, bool
                afterPragma)
                {
                    var return_v = this_param.ParseEndOfDirective(ignoreErrors: ignoreErrors, afterPragma: afterPragma);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 28776, 28839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PragmaWarningDirectiveTriviaSyntax
                f_10025_28865_29000(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                pragmaKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                warningKeyword, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                disableOrRestoreKeyword, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax>
                errorCodes, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.PragmaWarningDirectiveTrivia(hashToken, pragmaKeyword, warningKeyword, disableOrRestoreKeyword, errorCodes, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 28865, 29000);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 22116, 29027);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 22116, 29027);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DirectiveTriviaSyntax ParseShebangDirective(SyntaxToken hash, SyntaxToken exclamation, bool isActive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 29039, 29515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 29334, 29357);

                f_10025_29334_29356(isActive);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 29371, 29504);

                return f_10025_29378_29503(hash, exclamation, f_10025_29434_29492(this), isActive);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 29039, 29515);

                int
                f_10025_29334_29356(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 29334, 29356);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_29434_29492(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.ParseEndOfDirectiveWithOptionalPreprocessingMessage();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 29434, 29492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ShebangDirectiveTriviaSyntax
                f_10025_29378_29503(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                hashToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                exclamationToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                endOfDirectiveToken, bool
                isActive)
                {
                    var return_v = SyntaxFactory.ShebangDirectiveTrivia(hashToken, exclamationToken, endOfDirectiveToken, isActive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 29378, 29503);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 29039, 29515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 29039, 29515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxToken ParseEndOfDirectiveWithOptionalPreprocessingMessage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 29527, 30744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 29625, 29654);

                StringBuilder
                builder = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 29670, 30220) || true) && (f_10025_29674_29696(f_10025_29674_29691(this)) != SyntaxKind.EndOfDirectiveToken && (DynAbs.Tracing.TraceSender.Expression_True(10025, 29674, 29802) && f_10025_29751_29773(f_10025_29751_29768(this)) != SyntaxKind.EndOfFileToken))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 29670, 30220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 29836, 29893);

                    builder = f_10025_29846_29892(f_10025_29864_29891(f_10025_29864_29881(this)));
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 29913, 30205) || true) && (f_10025_29920_29942(f_10025_29920_29937(this)) != SyntaxKind.EndOfDirectiveToken && (DynAbs.Tracing.TraceSender.Expression_True(10025, 29920, 30055) && f_10025_30004_30026(f_10025_30004_30021(this)) != SyntaxKind.EndOfFileToken))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 29913, 30205);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 30097, 30125);

                            var
                            token = f_10025_30109_30124(this)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 30149, 30186);

                            f_10025_30149_30185(
                                                builder, f_10025_30164_30184(token));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 29913, 30205);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10025, 29913, 30205);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10025, 29913, 30205);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 29670, 30220);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 30236, 30478);

                SyntaxToken
                endOfDirective = (DynAbs.Tracing.TraceSender.Conditional_F1(10025, 30265, 30321) || ((f_10025_30265_30287(f_10025_30265_30282(this)) == SyntaxKind.EndOfDirectiveToken
                && DynAbs.Tracing.TraceSender.Conditional_F2(10025, 30366, 30381)) || DynAbs.Tracing.TraceSender.Conditional_F3(10025, 30426, 30477))) ? f_10025_30366_30381(this) : f_10025_30426_30477(SyntaxKind.EndOfDirectiveToken)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 30494, 30695) || true) && (builder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 30494, 30695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 30547, 30680);

                    endOfDirective = f_10025_30564_30679(endOfDirective, f_10025_30624_30678(f_10025_30659_30677(builder)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 30494, 30695);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 30711, 30733);

                return endOfDirective;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 29527, 30744);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_29674_29691(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 29674, 29691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_29674_29696(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 29674, 29696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_29751_29768(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 29751, 29768);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_29751_29773(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 29751, 29773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_29864_29881(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 29864, 29881);
                    return return_v;
                }


                int
                f_10025_29864_29891(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 29864, 29891);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10025_29846_29892(int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 29846, 29892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_29920_29937(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 29920, 29937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_29920_29942(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 29920, 29942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_30004_30021(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 30004, 30021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_30004_30026(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 30004, 30026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_30109_30124(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 30109, 30124);
                    return return_v;
                }


                string
                f_10025_30164_30184(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 30164, 30184);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10025_30149_30185(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 30149, 30185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_30265_30282(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 30265, 30282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_30265_30287(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 30265, 30287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_30366_30381(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 30366, 30381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_30426_30477(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 30426, 30477);
                    return return_v;
                }


                string
                f_10025_30659_30677(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 30659, 30677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10025_30624_30678(string
                text)
                {
                    var return_v = SyntaxFactory.PreprocessingMessage(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 30624, 30678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_30564_30679(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                trivia)
                {
                    var return_v = this_param.TokenWithLeadingTrivia((Microsoft.CodeAnalysis.GreenNode)trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 30564, 30679);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 29527, 30744);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 29527, 30744);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxToken ParseEndOfDirective(bool ignoreErrors, bool afterPragma = false, bool afterLineNumber = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 30756, 32759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 30895, 30952);

                var
                skippedTokens = f_10025_30915_30951()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 31047, 32141) || true) && (f_10025_31051_31073(f_10025_31051_31068(this)) != SyntaxKind.EndOfDirectiveToken && (DynAbs.Tracing.TraceSender.Expression_True(10025, 31051, 31179) && f_10025_31128_31150(f_10025_31128_31145(this)) != SyntaxKind.EndOfFileToken))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 31047, 32141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 31213, 31268);

                    skippedTokens = f_10025_31229_31267(10);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 31288, 31842) || true) && (!ignoreErrors)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 31288, 31842);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 31347, 31397);

                        var
                        errorCode = ErrorCode.ERR_EndOfPPLineExpected
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 31419, 31712) || true) && (afterPragma)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 31419, 31712);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 31484, 31530);

                            errorCode = ErrorCode.WRN_EndOfPPLineExpected;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 31419, 31712);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 31419, 31712);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 31580, 31712) || true) && (afterLineNumber)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 31580, 31712);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 31649, 31689);

                                errorCode = ErrorCode.ERR_MissingPPFile;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 31580, 31712);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 31419, 31712);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 31736, 31823);

                        skippedTokens.Add(f_10025_31754_31821(this, f_10025_31768_31809(f_10025_31768_31783(this)), errorCode));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 31288, 31842);
                    }
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 31862, 32126) || true) && (f_10025_31869_31891(f_10025_31869_31886(this)) != SyntaxKind.EndOfDirectiveToken && (DynAbs.Tracing.TraceSender.Expression_True(10025, 31869, 32004) && f_10025_31953_31975(f_10025_31953_31970(this)) != SyntaxKind.EndOfFileToken))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 31862, 32126);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 32046, 32107);

                            skippedTokens.Add(f_10025_32064_32105(f_10025_32064_32079(this)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 31862, 32126);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10025, 31862, 32126);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10025, 31862, 32126);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 31047, 32141);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 32242, 32484);

                SyntaxToken
                endOfDirective = (DynAbs.Tracing.TraceSender.Conditional_F1(10025, 32271, 32327) || ((f_10025_32271_32293(f_10025_32271_32288(this)) == SyntaxKind.EndOfDirectiveToken
                && DynAbs.Tracing.TraceSender.Conditional_F2(10025, 32372, 32387)) || DynAbs.Tracing.TraceSender.Conditional_F3(10025, 32432, 32483))) ? f_10025_32372_32387(this) : f_10025_32432_32483(SyntaxKind.EndOfDirectiveToken)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 32500, 32710) || true) && (f_10025_32504_32525_M(!skippedTokens.IsNull))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 32500, 32710);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 32559, 32695);

                    endOfDirective = f_10025_32576_32694(endOfDirective, f_10025_32636_32693(skippedTokens.ToList()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 32500, 32710);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 32726, 32748);

                return endOfDirective;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 30756, 32759);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                f_10025_30915_30951()
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 30915, 30951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_31051_31068(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 31051, 31068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_31051_31073(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 31051, 31073);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_31128_31145(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 31128, 31145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_31128_31150(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 31128, 31150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                f_10025_31229_31267(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 31229, 31267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_31768_31783(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 31768, 31783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_31768_31809(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node)
                {
                    var return_v = node.WithoutDiagnosticsGreen<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 31768, 31809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_31754_31821(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 31754, 31821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_31869_31886(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 31869, 31886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_31869_31891(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 31869, 31891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_31953_31970(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 31953, 31970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_31953_31975(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 31953, 31975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_32064_32079(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 32064, 32079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_32064_32105(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node)
                {
                    var return_v = node.WithoutDiagnosticsGreen<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 32064, 32105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_32271_32288(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 32271, 32288);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_32271_32293(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 32271, 32293);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_32372_32387(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 32372, 32387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_32432_32483(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 32432, 32483);
                    return return_v;
                }


                bool
                f_10025_32504_32525_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 32504, 32525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SkippedTokensTriviaSyntax
                f_10025_32636_32693(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
                tokens)
                {
                    var return_v = SyntaxFactory.SkippedTokensTrivia(tokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 32636, 32693);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_32576_32694(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SkippedTokensTriviaSyntax
                trivia)
                {
                    var return_v = this_param.TokenWithLeadingTrivia((Microsoft.CodeAnalysis.GreenNode)trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 32576, 32694);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 30756, 32759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 30756, 32759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ExpressionSyntax ParseExpression()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 32771, 32878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 32838, 32867);

                return f_10025_32845_32866(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 32771, 32878);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10025_32845_32866(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.ParseLogicalOr();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 32845, 32866);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 32771, 32878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 32771, 32878);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ExpressionSyntax ParseLogicalOr()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 32890, 33330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 32956, 32990);

                var
                left = f_10025_32967_32989(this)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 33004, 33291) || true) && (f_10025_33011_33033(f_10025_33011_33028(this)) == SyntaxKind.BarBarToken)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 33004, 33291);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 33093, 33118);

                        var
                        op = f_10025_33102_33117(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 33136, 33171);

                        var
                        right = f_10025_33148_33170(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 33189, 33276);

                        left = f_10025_33196_33275(SyntaxKind.LogicalOrExpression, left, op, right);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 33004, 33291);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10025, 33004, 33291);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10025, 33004, 33291);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 33307, 33319);

                return left;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 32890, 33330);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10025_32967_32989(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.ParseLogicalAnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 32967, 32989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_33011_33028(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 33011, 33028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_33011_33033(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 33011, 33033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_33102_33117(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 33102, 33117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10025_33148_33170(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.ParseLogicalAnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 33148, 33170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BinaryExpressionSyntax
                f_10025_33196_33275(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                left, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                operatorToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                right)
                {
                    var return_v = SyntaxFactory.BinaryExpression(kind, left, operatorToken, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 33196, 33275);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 32890, 33330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 32890, 33330);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ExpressionSyntax ParseLogicalAnd()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 33342, 33792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 33409, 33441);

                var
                left = f_10025_33420_33440(this)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 33455, 33753) || true) && (f_10025_33462_33484(f_10025_33462_33479(this)) == SyntaxKind.AmpersandAmpersandToken)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 33455, 33753);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 33556, 33581);

                        var
                        op = f_10025_33565_33580(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 33599, 33632);

                        var
                        right = f_10025_33611_33631(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 33650, 33738);

                        left = f_10025_33657_33737(SyntaxKind.LogicalAndExpression, left, op, right);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 33455, 33753);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10025, 33455, 33753);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10025, 33455, 33753);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 33769, 33781);

                return left;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 33342, 33792);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10025_33420_33440(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.ParseEquality();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 33420, 33440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_33462_33479(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 33462, 33479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_33462_33484(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 33462, 33484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_33565_33580(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 33565, 33580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10025_33611_33631(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.ParseEquality();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 33611, 33631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BinaryExpressionSyntax
                f_10025_33657_33737(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                left, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                operatorToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                right)
                {
                    var return_v = SyntaxFactory.BinaryExpression(kind, left, operatorToken, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 33657, 33737);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 33342, 33792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 33342, 33792);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ExpressionSyntax ParseEquality()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 33804, 34320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 33869, 33903);

                var
                left = f_10025_33880_33902(this)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 33917, 34281) || true) && (f_10025_33924_33946(f_10025_33924_33941(this)) == SyntaxKind.EqualsEqualsToken || (DynAbs.Tracing.TraceSender.Expression_False(10025, 33924, 34041) || f_10025_33982_34004(f_10025_33982_33999(this)) == SyntaxKind.ExclamationEqualsToken))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 33917, 34281);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 34075, 34100);

                        var
                        op = f_10025_34084_34099(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 34118, 34151);

                        var
                        right = f_10025_34130_34150(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 34169, 34266);

                        left = f_10025_34176_34265(f_10025_34207_34247(f_10025_34239_34246(op)), left, op, right);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 33917, 34281);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10025, 33917, 34281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10025, 33917, 34281);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 34297, 34309);

                return left;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 33804, 34320);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10025_33880_33902(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.ParseLogicalNot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 33880, 33902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_33924_33941(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 33924, 33941);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_33924_33946(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 33924, 33946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_33982_33999(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 33982, 33999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_33982_34004(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 33982, 34004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_34084_34099(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 34084, 34099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10025_34130_34150(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.ParseEquality();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 34130, 34150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_34239_34246(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 34239, 34246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_34207_34247(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                token)
                {
                    var return_v = SyntaxFacts.GetBinaryExpression(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 34207, 34247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BinaryExpressionSyntax
                f_10025_34176_34265(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                left, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                operatorToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                right)
                {
                    var return_v = SyntaxFactory.BinaryExpression(kind, left, operatorToken, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 34176, 34265);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 33804, 34320);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 33804, 34320);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ExpressionSyntax ParseLogicalNot()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 34332, 34706);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 34399, 34652) || true) && (f_10025_34403_34425(f_10025_34403_34420(this)) == SyntaxKind.ExclamationToken)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 34399, 34652);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 34490, 34515);

                    var
                    op = f_10025_34499_34514(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 34533, 34637);

                    return f_10025_34540_34636(SyntaxKind.LogicalNotExpression, op, f_10025_34613_34635(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 34399, 34652);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 34668, 34695);

                return f_10025_34675_34694(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 34332, 34706);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_34403_34420(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 34403, 34420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_34403_34425(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 34403, 34425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_34499_34514(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 34499, 34514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10025_34613_34635(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.ParseLogicalNot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 34613, 34635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PrefixUnaryExpressionSyntax
                f_10025_34540_34636(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                operatorToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                operand)
                {
                    var return_v = SyntaxFactory.PrefixUnaryExpression(kind, operatorToken, operand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 34540, 34636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10025_34675_34694(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.ParsePrimary();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 34675, 34694);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 34332, 34706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 34332, 34706);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ExpressionSyntax ParsePrimary()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 34718, 35758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 34782, 34813);

                var
                k = f_10025_34790_34812(f_10025_34790_34807(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 34827, 35747);

                switch (k)
                {

                    case SyntaxKind.OpenParenToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 34827, 35747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 34923, 34950);

                        var
                        open = f_10025_34934_34949(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 34972, 35006);

                        var
                        expr = f_10025_34983_35005(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 35028, 35082);

                        var
                        close = f_10025_35040_35081(this, SyntaxKind.CloseParenToken)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 35104, 35168);

                        return f_10025_35111_35167(open, expr, close);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 34827, 35747);

                    case SyntaxKind.IdentifierToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 34827, 35747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 35240, 35293);

                        var
                        identifier = f_10025_35257_35292(f_10025_35276_35291(this))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 35315, 35363);

                        return f_10025_35322_35362(identifier);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 34827, 35747);

                    case SyntaxKind.TrueKeyword:
                    case SyntaxKind.FalseKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 34827, 35747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 35478, 35571);

                        return f_10025_35485_35570(f_10025_35517_35552(k), f_10025_35554_35569(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 34827, 35747);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 34827, 35747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 35619, 35732);

                        return f_10025_35626_35731(f_10025_35655_35730(this, SyntaxKind.IdentifierToken, ErrorCode.ERR_InvalidPreprocExpr));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 34827, 35747);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 34718, 35758);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_34790_34807(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 34790, 34807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_34790_34812(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 34790, 34812);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_34934_34949(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 34934, 34949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10025_34983_35005(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.ParseExpression();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 34983, 35005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_35040_35081(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 35040, 35081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ParenthesizedExpressionSyntax
                f_10025_35111_35167(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                openParenToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                closeParenToken)
                {
                    var return_v = SyntaxFactory.ParenthesizedExpression(openParenToken, expression, closeParenToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 35111, 35167);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_35276_35291(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 35276, 35291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_35257_35292(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                identifier)
                {
                    var return_v = TruncateIdentifier(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 35257, 35292);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IdentifierNameSyntax
                f_10025_35322_35362(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                identifier)
                {
                    var return_v = SyntaxFactory.IdentifierName(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 35322, 35362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_35517_35552(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                token)
                {
                    var return_v = SyntaxFacts.GetLiteralExpression(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 35517, 35552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_35554_35569(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 35554, 35569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LiteralExpressionSyntax
                f_10025_35485_35570(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = SyntaxFactory.LiteralExpression(kind, token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 35485, 35570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_35655_35730(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.EatToken(kind, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 35655, 35730);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IdentifierNameSyntax
                f_10025_35626_35731(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                identifier)
                {
                    var return_v = SyntaxFactory.IdentifierName(identifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 35626, 35731);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 34718, 35758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 34718, 35758);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SyntaxToken TruncateIdentifier(SyntaxToken identifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10025, 35944, 36566);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 36038, 36523) || true) && (f_10025_36042_36058(identifier) > MAX_DIRECTIVE_IDENTIFIER_WIDTH)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 36038, 36523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 36125, 36169);

                    var
                    leading = f_10025_36139_36168(identifier)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 36187, 36233);

                    var
                    trailing = f_10025_36202_36232(identifier)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 36253, 36289);

                    string
                    text = f_10025_36267_36288(identifier)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 36307, 36381);

                    string
                    identifierPart = f_10025_36331_36380(text, 0, MAX_DIRECTIVE_IDENTIFIER_WIDTH)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 36401, 36508);

                    identifier = f_10025_36414_36507(SyntaxKind.IdentifierToken, leading, text, identifierPart, trailing);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 36038, 36523);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 36537, 36555);

                return identifier;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10025, 35944, 36566);

                int
                f_10025_36042_36058(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 36042, 36058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10025_36139_36168(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetLeadingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 36139, 36168);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10025_36202_36232(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetTrailingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 36202, 36232);
                    return return_v;
                }


                string
                f_10025_36267_36288(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 36267, 36288);
                    return return_v;
                }


                string
                f_10025_36331_36380(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 36331, 36380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_36414_36507(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                contextualKind, Microsoft.CodeAnalysis.GreenNode
                leading, string
                text, string
                valueText, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxFactory.Identifier(contextualKind, leading, text, valueText, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 36414, 36507);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 35944, 36566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 35944, 36566);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool EvaluateBool(ExpressionSyntax expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 36578, 36820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 36651, 36679);

                var
                result = f_10025_36664_36678(this, expr)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 36693, 36780) || true) && (result is bool)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 36693, 36780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 36745, 36765);

                    return (bool)result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 36693, 36780);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 36796, 36809);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 36578, 36820);

                object
                f_10025_36664_36678(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expr)
                {
                    var return_v = this_param.Evaluate(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 36664, 36678);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 36578, 36820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 36578, 36820);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private object Evaluate(ExpressionSyntax expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 36832, 39333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 36903, 39293);

                switch (f_10025_36911_36920(expr))
                {

                    case SyntaxKind.ParenthesizedExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 36903, 39293);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 37016, 37082);

                        return f_10025_37023_37081(this, f_10025_37032_37080(((ParenthesizedExpressionSyntax)expr)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 36903, 39293);

                    case SyntaxKind.TrueLiteralExpression:
                    case SyntaxKind.FalseLiteralExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 36903, 39293);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 37217, 37268);

                        return f_10025_37224_37267(f_10025_37224_37261(((LiteralExpressionSyntax)expr)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 36903, 39293);

                    case SyntaxKind.LogicalAndExpression:
                    case SyntaxKind.BitwiseAndExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 36903, 39293);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 37400, 37511);

                        return f_10025_37407_37456(this, f_10025_37420_37455(((BinaryExpressionSyntax)expr))) && (DynAbs.Tracing.TraceSender.Expression_True(10025, 37407, 37510) && f_10025_37460_37510(this, f_10025_37473_37509(((BinaryExpressionSyntax)expr))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 36903, 39293);

                    case SyntaxKind.LogicalOrExpression:
                    case SyntaxKind.BitwiseOrExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 36903, 39293);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 37641, 37752);

                        return f_10025_37648_37697(this, f_10025_37661_37696(((BinaryExpressionSyntax)expr))) || (DynAbs.Tracing.TraceSender.Expression_False(10025, 37648, 37751) || f_10025_37701_37751(this, f_10025_37714_37750(((BinaryExpressionSyntax)expr))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 36903, 39293);

                    case SyntaxKind.EqualsExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 36903, 39293);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 37825, 37941);

                        return f_10025_37832_37940(f_10025_37846_37891(this, f_10025_37855_37890(((BinaryExpressionSyntax)expr))), f_10025_37893_37939(this, f_10025_37902_37938(((BinaryExpressionSyntax)expr))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 36903, 39293);

                    case SyntaxKind.NotEqualsExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 36903, 39293);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 38017, 38134);

                        return !f_10025_38025_38133(f_10025_38039_38084(this, f_10025_38048_38083(((BinaryExpressionSyntax)expr))), f_10025_38086_38132(this, f_10025_38095_38131(((BinaryExpressionSyntax)expr))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 36903, 39293);

                    case SyntaxKind.LogicalNotExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 36903, 39293);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 38211, 38277);

                        return !f_10025_38219_38276(this, f_10025_38232_38275(((PrefixUnaryExpressionSyntax)expr)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 36903, 39293);

                    case SyntaxKind.IdentifierName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 36903, 39293);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 38976, 39038);

                        string
                        id = f_10025_38988_39037(f_10025_38988_39027(((IdentifierNameSyntax)expr)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 39060, 39079);

                        bool
                        constantValue
                        = default(bool);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 39101, 39235) || true) && (f_10025_39105_39141(id, out constantValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 39101, 39235);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 39191, 39212);

                            return constantValue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 39101, 39235);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 39257, 39278);

                        return f_10025_39264_39277(this, id);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 36903, 39293);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 39309, 39322);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 36832, 39333);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10025_36911_36920(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 36911, 36920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10025_37032_37080(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ParenthesizedExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 37032, 37080);
                    return return_v;
                }


                object
                f_10025_37023_37081(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expr)
                {
                    var return_v = this_param.Evaluate(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 37023, 37081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_37224_37261(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LiteralExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Token;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 37224, 37261);
                    return return_v;
                }


                object
                f_10025_37224_37267(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 37224, 37267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10025_37420_37455(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BinaryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 37420, 37455);
                    return return_v;
                }


                bool
                f_10025_37407_37456(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expr)
                {
                    var return_v = this_param.EvaluateBool(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 37407, 37456);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10025_37473_37509(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BinaryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 37473, 37509);
                    return return_v;
                }


                bool
                f_10025_37460_37510(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expr)
                {
                    var return_v = this_param.EvaluateBool(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 37460, 37510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10025_37661_37696(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BinaryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 37661, 37696);
                    return return_v;
                }


                bool
                f_10025_37648_37697(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expr)
                {
                    var return_v = this_param.EvaluateBool(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 37648, 37697);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10025_37714_37750(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BinaryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 37714, 37750);
                    return return_v;
                }


                bool
                f_10025_37701_37751(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expr)
                {
                    var return_v = this_param.EvaluateBool(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 37701, 37751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10025_37855_37890(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BinaryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 37855, 37890);
                    return return_v;
                }


                object
                f_10025_37846_37891(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expr)
                {
                    var return_v = this_param.Evaluate(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 37846, 37891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10025_37902_37938(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BinaryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 37902, 37938);
                    return return_v;
                }


                object
                f_10025_37893_37939(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expr)
                {
                    var return_v = this_param.Evaluate(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 37893, 37939);
                    return return_v;
                }


                bool
                f_10025_37832_37940(object
                objA, object
                objB)
                {
                    var return_v = object.Equals(objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 37832, 37940);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10025_38048_38083(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BinaryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 38048, 38083);
                    return return_v;
                }


                object
                f_10025_38039_38084(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expr)
                {
                    var return_v = this_param.Evaluate(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 38039, 38084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10025_38095_38131(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BinaryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 38095, 38131);
                    return return_v;
                }


                object
                f_10025_38086_38132(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expr)
                {
                    var return_v = this_param.Evaluate(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 38086, 38132);
                    return return_v;
                }


                bool
                f_10025_38025_38133(object
                objA, object
                objB)
                {
                    var return_v = object.Equals(objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 38025, 38133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                f_10025_38232_38275(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.PrefixUnaryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 38232, 38275);
                    return return_v;
                }


                bool
                f_10025_38219_38276(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.ExpressionSyntax
                expr)
                {
                    var return_v = this_param.EvaluateBool(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 38219, 38276);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10025_38988_39027(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 38988, 39027);
                    return return_v;
                }


                string
                f_10025_38988_39037(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 38988, 39037);
                    return return_v;
                }


                bool
                f_10025_39105_39141(string
                value, out bool
                result)
                {
                    var return_v = bool.TryParse(value, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 39105, 39141);
                    return return_v;
                }


                bool
                f_10025_39264_39277(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, string
                id)
                {
                    var return_v = this_param.IsDefined(id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10025, 39264, 39277);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 36832, 39333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 36832, 39333);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsDefined(string id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10025, 39345, 39818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 39403, 39441);

                var
                defState = _context.IsDefined(id)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 39455, 39807);

                switch (defState)
                {

                    default:
                    case DefineState.Unspecified:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 39455, 39807);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 39582, 39635);

                        return f_10025_39589_39601(this).PreprocessorSymbols.Contains(id);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 39455, 39807);

                    case DefineState.Defined:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 39455, 39807);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 39700, 39712);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 39455, 39807);

                    case DefineState.Undefined:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10025, 39455, 39807);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 39779, 39792);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10025, 39455, 39807);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10025, 39345, 39818);

                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10025_39589_39601(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10025, 39589, 39601);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10025, 39345, 39818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 39345, 39818);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DirectiveParser()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10025, 452, 39825);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10025, 532, 568);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10025, 452, 39825);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10025, 452, 39825);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10025, 452, 39825);

        static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
        f_10025_716_721_C(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10025, 634, 817);
            return return_v;
        }

    }
}
