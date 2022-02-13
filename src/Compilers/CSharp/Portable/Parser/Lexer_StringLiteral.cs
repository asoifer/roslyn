// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    internal partial class Lexer
    {
        private void ScanStringLiteral(ref TokenInfo info, bool allowEscapes = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10021, 582, 3988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 683, 726);

                var
                quoteCharacter = f_10021_704_725(TextWindow)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 740, 3977) || true) && (quoteCharacter == '\'' || (DynAbs.Tracing.TraceSender.Expression_False(10021, 744, 791) || quoteCharacter == '"'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 740, 3977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 825, 850);

                    f_10021_825_849(TextWindow);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 868, 888);

                    _builder.Length = 0;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 906, 2545) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 906, 2545);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 959, 991);

                            char
                            ch = f_10021_969_990(TextWindow)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 1013, 2526) || true) && (ch == '\\' && (DynAbs.Tracing.TraceSender.Expression_True(10021, 1017, 1043) && allowEscapes))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 1013, 2526);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 1169, 1177);

                                char
                                c2
                                = default(char);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 1203, 1240);

                                ch = f_10021_1208_1239(this, out c2);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 1266, 1286);

                                f_10021_1266_1285(_builder, ch);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 1312, 1461) || true) && (c2 != SlidingTextWindow.InvalidCharacter)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 1312, 1461);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 1414, 1434);

                                    f_10021_1414_1433(_builder, c2);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 1312, 1461);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 1013, 2526);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 1013, 2526);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 1511, 2526) || true) && (ch == quoteCharacter)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 1511, 2526);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 1585, 1610);

                                    f_10021_1585_1609(TextWindow);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10021, 1636, 1642);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 1511, 2526);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 1511, 2526);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 1692, 2526) || true) && (f_10021_1696_1721(ch) || (DynAbs.Tracing.TraceSender.Expression_False(10021, 1696, 1826) || (ch == SlidingTextWindow.InvalidCharacter && (DynAbs.Tracing.TraceSender.Expression_True(10021, 1755, 1825) && f_10021_1799_1825(TextWindow)))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 1692, 2526);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 2197, 2232);

                                        f_10021_2197_2231(f_10021_2210_2226(TextWindow) > 0);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 2258, 2302);

                                        f_10021_2258_2301(this, ErrorCode.ERR_NewlineInConst);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10021, 2328, 2334);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 1692, 2526);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 1692, 2526);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 2432, 2457);

                                        f_10021_2432_2456(TextWindow);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 2483, 2503);

                                        f_10021_2483_2502(_builder, ch);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 1692, 2526);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 1511, 2526);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 1013, 2526);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 906, 2545);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10021, 906, 2545);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10021, 906, 2545);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 2565, 2602);

                    info.Text = f_10021_2577_2601(TextWindow, true);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 2620, 3833) || true) && (quoteCharacter == '\'')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 2620, 3833);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 2688, 2733);

                        info.Kind = SyntaxKind.CharacterLiteralToken;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 2755, 2957) || true) && (f_10021_2759_2774(_builder) != 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 2755, 2957);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 2829, 2934);

                            f_10021_2829_2933(this, (DynAbs.Tracing.TraceSender.Conditional_F1(10021, 2843, 2865) || (((f_10021_2844_2859(_builder) != 0) && DynAbs.Tracing.TraceSender.Conditional_F2(10021, 2868, 2901)) || DynAbs.Tracing.TraceSender.Conditional_F3(10021, 2904, 2932))) ? ErrorCode.ERR_TooManyCharsInConst : ErrorCode.ERR_EmptyCharConst);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 2755, 2957);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 2981, 3395) || true) && (f_10021_2985_3000(_builder) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 2981, 3395);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 3054, 3101);

                            info.StringValue = f_10021_3073_3100(TextWindow, _builder);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 3127, 3164);

                            info.CharValue = f_10021_3144_3163(info.StringValue, 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 2981, 3395);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 2981, 3395);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 3262, 3294);

                            info.StringValue = string.Empty;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 3320, 3372);

                            info.CharValue = SlidingTextWindow.InvalidCharacter;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 2981, 3395);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 2620, 3833);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 2620, 3833);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 3477, 3519);

                        info.Kind = SyntaxKind.StringLiteralToken;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 3541, 3814) || true) && (f_10021_3545_3560(_builder) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 3541, 3814);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 3614, 3661);

                            info.StringValue = f_10021_3633_3660(TextWindow, _builder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 3541, 3814);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 3541, 3814);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 3759, 3791);

                            info.StringValue = string.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 3541, 3814);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 2620, 3833);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 740, 3977);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 740, 3977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 3899, 3927);

                    info.Kind = SyntaxKind.None;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 3945, 3962);

                    info.Text = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 740, 3977);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10021, 582, 3988);

                char
                f_10021_704_725(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 704, 725);
                    return return_v;
                }


                int
                f_10021_825_849(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 825, 849);
                    return 0;
                }


                char
                f_10021_969_990(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 969, 990);
                    return return_v;
                }


                char
                f_10021_1208_1239(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, out char
                surrogateCharacter)
                {
                    var return_v = this_param.ScanEscapeSequence(out surrogateCharacter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 1208, 1239);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10021_1266_1285(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 1266, 1285);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10021_1414_1433(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 1414, 1433);
                    return return_v;
                }


                int
                f_10021_1585_1609(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 1585, 1609);
                    return 0;
                }


                bool
                f_10021_1696_1721(char
                ch)
                {
                    var return_v = SyntaxFacts.IsNewLine(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 1696, 1721);
                    return return_v;
                }


                bool
                f_10021_1799_1825(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.IsReallyAtEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 1799, 1825);
                    return return_v;
                }


                int
                f_10021_2210_2226(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10021, 2210, 2226);
                    return return_v;
                }


                int
                f_10021_2197_2231(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 2197, 2231);
                    return 0;
                }


                int
                f_10021_2258_2301(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    this_param.AddError(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 2258, 2301);
                    return 0;
                }


                int
                f_10021_2432_2456(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 2432, 2456);
                    return 0;
                }


                System.Text.StringBuilder
                f_10021_2483_2502(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 2483, 2502);
                    return return_v;
                }


                string
                f_10021_2577_2601(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, bool
                intern)
                {
                    var return_v = this_param.GetText(intern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 2577, 2601);
                    return return_v;
                }


                int
                f_10021_2759_2774(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10021, 2759, 2774);
                    return return_v;
                }


                int
                f_10021_2844_2859(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10021, 2844, 2859);
                    return return_v;
                }


                int
                f_10021_2829_2933(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    this_param.AddError(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 2829, 2933);
                    return 0;
                }


                int
                f_10021_2985_3000(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10021, 2985, 3000);
                    return return_v;
                }


                string
                f_10021_3073_3100(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, System.Text.StringBuilder
                text)
                {
                    var return_v = this_param.Intern(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 3073, 3100);
                    return return_v;
                }


                char
                f_10021_3144_3163(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10021, 3144, 3163);
                    return return_v;
                }


                int
                f_10021_3545_3560(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10021, 3545, 3560);
                    return return_v;
                }


                string
                f_10021_3633_3660(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, System.Text.StringBuilder
                text)
                {
                    var return_v = this_param.Intern(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 3633, 3660);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10021, 582, 3988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 582, 3988);
            }
        }

        private char ScanEscapeSequence(out char surrogateCharacter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10021, 4000, 5889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 4085, 4117);

                var
                start = f_10021_4097_4116(TextWindow)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 4131, 4187);

                surrogateCharacter = SlidingTextWindow.InvalidCharacter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 4201, 4233);

                char
                ch = f_10021_4211_4232(TextWindow)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 4247, 4272);

                f_10021_4247_4271(ch == '\\');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 4288, 4315);

                ch = f_10021_4293_4314(TextWindow);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 4329, 5852);

                switch (ch)
                {

                    case '\'':
                    case '"':
                    case '\\':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 4329, 5852);
                        DynAbs.Tracing.TraceSender.TraceBreak(10021, 4528, 4534);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 4329, 5852);

                    case '0':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 4329, 5852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 4644, 4658);

                        ch = '\u0000';
                        DynAbs.Tracing.TraceSender.TraceBreak(10021, 4680, 4686);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 4329, 5852);

                    case 'a':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 4329, 5852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 4735, 4749);

                        ch = '\u0007';
                        DynAbs.Tracing.TraceSender.TraceBreak(10021, 4771, 4777);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 4329, 5852);

                    case 'b':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 4329, 5852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 4826, 4840);

                        ch = '\u0008';
                        DynAbs.Tracing.TraceSender.TraceBreak(10021, 4862, 4868);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 4329, 5852);

                    case 'f':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 4329, 5852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 4917, 4931);

                        ch = '\u000c';
                        DynAbs.Tracing.TraceSender.TraceBreak(10021, 4953, 4959);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 4329, 5852);

                    case 'n':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 4329, 5852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 5008, 5022);

                        ch = '\u000a';
                        DynAbs.Tracing.TraceSender.TraceBreak(10021, 5044, 5050);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 4329, 5852);

                    case 'r':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 4329, 5852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 5099, 5113);

                        ch = '\u000d';
                        DynAbs.Tracing.TraceSender.TraceBreak(10021, 5135, 5141);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 4329, 5852);

                    case 't':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 4329, 5852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 5190, 5204);

                        ch = '\u0009';
                        DynAbs.Tracing.TraceSender.TraceBreak(10021, 5226, 5232);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 4329, 5852);

                    case 'v':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 4329, 5852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 5281, 5295);

                        ch = '\u000b';
                        DynAbs.Tracing.TraceSender.TraceBreak(10021, 5317, 5323);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 4329, 5852);

                    case 'x':
                    case 'u':
                    case 'U':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 4329, 5852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 5426, 5450);

                        f_10021_5426_5449(TextWindow, start);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 5472, 5499);

                        SyntaxDiagnosticInfo
                        error
                        = default(SyntaxDiagnosticInfo);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 5521, 5616);

                        ch = f_10021_5526_5615(TextWindow, surrogateCharacter: out surrogateCharacter, info: out error);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 5638, 5654);

                        f_10021_5638_5653(this, error);
                        DynAbs.Tracing.TraceSender.TraceBreak(10021, 5676, 5682);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 4329, 5852);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 4329, 5852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 5730, 5809);

                        f_10021_5730_5808(this, start, f_10021_5751_5770(TextWindow) - start, ErrorCode.ERR_IllegalEscape);
                        DynAbs.Tracing.TraceSender.TraceBreak(10021, 5831, 5837);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 4329, 5852);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 5868, 5878);

                return ch;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10021, 4000, 5889);

                int
                f_10021_4097_4116(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10021, 4097, 4116);
                    return return_v;
                }


                char
                f_10021_4211_4232(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.NextChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 4211, 4232);
                    return return_v;
                }


                int
                f_10021_4247_4271(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 4247, 4271);
                    return 0;
                }


                char
                f_10021_4293_4314(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.NextChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 4293, 4314);
                    return return_v;
                }


                int
                f_10021_5426_5449(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                position)
                {
                    this_param.Reset(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 5426, 5449);
                    return 0;
                }


                char
                f_10021_5526_5615(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, out char
                surrogateCharacter, out Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                info)
                {
                    var return_v = this_param.NextUnicodeEscape(out surrogateCharacter, out info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 5526, 5615);
                    return return_v;
                }


                int
                f_10021_5638_5653(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                error)
                {
                    this_param.AddError(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 5638, 5653);
                    return 0;
                }


                int
                f_10021_5751_5770(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10021, 5751, 5770);
                    return return_v;
                }


                int
                f_10021_5730_5808(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, int
                position, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    this_param.AddError(position, width, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 5730, 5808);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10021, 4000, 5889);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 4000, 5889);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ScanVerbatimStringLiteral(ref TokenInfo info, bool allowNewlines = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10021, 5901, 8477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 6011, 6031);

                _builder.Length = 0;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 6047, 8466) || true) && (f_10021_6051_6072(TextWindow) == '@' && (DynAbs.Tracing.TraceSender.Expression_True(10021, 6051, 6112) && f_10021_6083_6105(TextWindow, 1) == '"'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 6047, 8466);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 6146, 6172);

                    f_10021_6146_6171(TextWindow, 2);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 6190, 6208);

                    bool
                    done = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 6226, 6234);

                    char
                    ch
                    = default(char);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 6252, 6272);

                    _builder.Length = 0;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 6290, 8105) || true) && (!done)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 6290, 8105);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 6344, 8086);

                            switch (ch = f_10021_6357_6378(TextWindow))
                            {

                                case '"':
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 6344, 8086);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 6467, 6492);

                                    f_10021_6467_6491(TextWindow);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 6522, 6967) || true) && (f_10021_6526_6547(TextWindow) == '"')
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 6522, 6967);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 6715, 6740);

                                        f_10021_6715_6739(                                // Doubled quote -- skip & put the single quote in the string
                                                                        TextWindow);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 6774, 6794);

                                        f_10021_6774_6793(_builder, ch);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 6522, 6967);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 6522, 6967);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 6924, 6936);

                                        done = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 6522, 6967);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10021, 6999, 7005);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 6344, 8086);

                                case SlidingTextWindow.InvalidCharacter:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 6344, 8086);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 7103, 7244) || true) && (!f_10021_7108_7134(TextWindow))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 7103, 7244);

                                        goto default;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 7103, 7244);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 7444, 7495);

                                    f_10021_7444_7494(
                                                                // Reached the end of the source without finding the end-quote.  Give
                                                                // an error back at the starting point.
                                                                this, ErrorCode.ERR_UnterminatedStringLit);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 7525, 7537);

                                    done = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(10021, 7567, 7573);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 6344, 8086);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 6344, 8086);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 7639, 7920) || true) && (!allowNewlines && (DynAbs.Tracing.TraceSender.Expression_True(10021, 7643, 7686) && f_10021_7661_7686(ch)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 7639, 7920);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 7752, 7803);

                                        f_10021_7752_7802(this, ErrorCode.ERR_UnterminatedStringLit);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 7837, 7849);

                                        done = true;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10021, 7883, 7889);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 7639, 7920);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 7952, 7977);

                                    f_10021_7952_7976(
                                                                TextWindow);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 8007, 8027);

                                    f_10021_8007_8026(_builder, ch);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10021, 8057, 8063);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 6344, 8086);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 6290, 8105);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10021, 6290, 8105);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10021, 6290, 8105);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 8125, 8167);

                    info.Kind = SyntaxKind.StringLiteralToken;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 8185, 8223);

                    info.Text = f_10021_8197_8222(TextWindow, false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 8241, 8280);

                    info.StringValue = f_10021_8260_8279(_builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 6047, 8466);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 6047, 8466);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 8346, 8374);

                    info.Kind = SyntaxKind.None;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 8392, 8409);

                    info.Text = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 8427, 8451);

                    info.StringValue = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 6047, 8466);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10021, 5901, 8477);

                char
                f_10021_6051_6072(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 6051, 6072);
                    return return_v;
                }


                char
                f_10021_6083_6105(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 6083, 6105);
                    return return_v;
                }


                int
                f_10021_6146_6171(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                n)
                {
                    this_param.AdvanceChar(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 6146, 6171);
                    return 0;
                }


                char
                f_10021_6357_6378(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 6357, 6378);
                    return return_v;
                }


                int
                f_10021_6467_6491(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 6467, 6491);
                    return 0;
                }


                char
                f_10021_6526_6547(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 6526, 6547);
                    return return_v;
                }


                int
                f_10021_6715_6739(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 6715, 6739);
                    return 0;
                }


                System.Text.StringBuilder
                f_10021_6774_6793(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 6774, 6793);
                    return return_v;
                }


                bool
                f_10021_7108_7134(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.IsReallyAtEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 7108, 7134);
                    return return_v;
                }


                int
                f_10021_7444_7494(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    this_param.AddError(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 7444, 7494);
                    return 0;
                }


                bool
                f_10021_7661_7686(char
                ch)
                {
                    var return_v = SyntaxFacts.IsNewLine(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 7661, 7686);
                    return return_v;
                }


                int
                f_10021_7752_7802(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    this_param.AddError(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 7752, 7802);
                    return 0;
                }


                int
                f_10021_7952_7976(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 7952, 7976);
                    return 0;
                }


                System.Text.StringBuilder
                f_10021_8007_8026(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 8007, 8026);
                    return return_v;
                }


                string
                f_10021_8197_8222(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, bool
                intern)
                {
                    var return_v = this_param.GetText(intern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 8197, 8222);
                    return return_v;
                }


                string
                f_10021_8260_8279(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 8260, 8279);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10021, 5901, 8477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 5901, 8477);
            }
        }

        private void ScanInterpolatedStringLiteral(bool isVerbatim, ref TokenInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10021, 8489, 9746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 9520, 9554);

                SyntaxDiagnosticInfo
                error = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 9568, 9591);

                bool
                closeQuoteMissing
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 9605, 9700);

                f_10021_9605_9699(this, null, isVerbatim, ref info, ref error, out closeQuoteMissing);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 9714, 9735);

                f_10021_9714_9734(this, error);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10021, 8489, 9746);

                int
                f_10021_9605_9699(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.Interpolation>
                interpolations, bool
                isVerbatim, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info, ref Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo?
                error, out bool
                closeQuoteMissing)
                {
                    this_param.ScanInterpolatedStringLiteralTop(interpolations, isVerbatim, ref info, ref error, out closeQuoteMissing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 9605, 9699);
                    return 0;
                }


                int
                f_10021_9714_9734(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                error)
                {
                    this_param.AddError(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 9714, 9734);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10021, 8489, 9746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 8489, 9746);
            }
        }

        internal void ScanInterpolatedStringLiteralTop(ArrayBuilder<Interpolation> interpolations, bool isVerbatim, ref TokenInfo info, ref SyntaxDiagnosticInfo error, out bool closeQuoteMissing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10021, 9758, 10244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 9970, 10035);

                var
                subScanner = f_10021_9987_10034(this, isVerbatim)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 10049, 10142);

                f_10021_10049_10141(subScanner, interpolations, ref info, out closeQuoteMissing);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 10156, 10181);

                error = subScanner.error;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 10195, 10233);

                info.Text = f_10021_10207_10232(TextWindow, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10021, 9758, 10244);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.InterpolatedStringScanner
                f_10021_9987_10034(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                lexer, bool
                isVerbatim)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.InterpolatedStringScanner(lexer, isVerbatim);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 9987, 10034);
                    return return_v;
                }


                int
                f_10021_10049_10141(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.InterpolatedStringScanner
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.Interpolation>
                interpolations, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info, out bool
                closeQuoteMissing)
                {
                    this_param.ScanInterpolatedStringLiteralTop(interpolations, ref info, out closeQuoteMissing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 10049, 10141);
                    return 0;
                }


                string
                f_10021_10207_10232(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, bool
                intern)
                {
                    var return_v = this_param.GetText(intern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 10207, 10232);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10021, 9758, 10244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 9758, 10244);
            }
        }

        internal struct Interpolation
        {

            public readonly int OpenBracePosition;

            public readonly int ColonPosition;

            public readonly int CloseBracePosition;

            public readonly bool CloseBraceMissing;

            public bool ColonMissing
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10021, 10541, 10562);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 10544, 10562);
                        return ColonPosition <= 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10021, 10541, 10562);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10021, 10541, 10562);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 10541, 10562);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool HasColon
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10021, 10598, 10618);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 10601, 10618);
                        return ColonPosition > 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10021, 10598, 10618);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10021, 10598, 10618);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 10598, 10618);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public int LastPosition
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10021, 10657, 10723);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 10660, 10723);
                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10021, 10660, 10677) || ((CloseBraceMissing && DynAbs.Tracing.TraceSender.Conditional_F2(10021, 10680, 10702)) || DynAbs.Tracing.TraceSender.Conditional_F3(10021, 10705, 10723))) ? CloseBracePosition - 1 : CloseBracePosition; DynAbs.Tracing.TraceSender.TraceExitMethod(10021, 10657, 10723);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10021, 10657, 10723);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 10657, 10723);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public int FormatEndPosition
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10021, 10767, 10792);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 10770, 10792);
                        return CloseBracePosition - 1; DynAbs.Tracing.TraceSender.TraceExitMethod(10021, 10767, 10792);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10021, 10767, 10792);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 10767, 10792);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public Interpolation(int openBracePosition, int colonPosition, int closeBracePosition, bool closeBraceMissing)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10021, 10807, 11185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 10950, 10993);

                    this.OpenBracePosition = openBracePosition;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 11011, 11046);

                    this.ColonPosition = colonPosition;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 11064, 11109);

                    this.CloseBracePosition = closeBracePosition;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 11127, 11170);

                    this.CloseBraceMissing = closeBraceMissing;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10021, 10807, 11185);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10021, 10807, 11185);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 10807, 11185);
                }
            }
            static Interpolation()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10021, 10256, 11196);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10021, 10256, 11196);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 10256, 11196);
            }
        }

        internal static SyntaxToken RescanInterpolatedString(InterpolatedStringExpressionSyntax interpolatedString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10021, 11406, 12088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 11538, 11579);

                var
                text = f_10021_11549_11578(interpolatedString)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 11593, 11639);

                var
                kind = SyntaxKind.InterpolatedStringToken
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 11834, 12077);

                return f_10021_11841_12076(f_10021_11881_11934(f_10021_11881_11915(interpolatedString)), text, kind, text, f_10021_12022_12075(f_10021_12022_12055(interpolatedString)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10021, 11406, 12088);

                string
                f_10021_11549_11578(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolatedStringExpressionSyntax
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 11549, 11578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10021_11881_11915(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolatedStringExpressionSyntax
                this_param)
                {
                    var return_v = this_param.GetFirstToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 11881, 11915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10021_11881_11934(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetLeadingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 11881, 11934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10021_12022_12055(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.InterpolatedStringExpressionSyntax
                this_param)
                {
                    var return_v = this_param.GetLastToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 12022, 12055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10021_12022_12075(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetTrailingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 12022, 12075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10021_11841_12076(Microsoft.CodeAnalysis.GreenNode
                leading, string
                text, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                value, Microsoft.CodeAnalysis.GreenNode
                trailing)
                {
                    var return_v = SyntaxFactory.Literal(leading, text, kind, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 11841, 12076);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10021, 11406, 12088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 11406, 12088);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private class InterpolatedStringScanner
        {
            public readonly Lexer lexer;

            public bool isVerbatim;

            public bool allowNewlines;

            public SyntaxDiagnosticInfo error;

            public InterpolatedStringScanner(
                            Lexer lexer,
                            bool isVerbatim)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10021, 12331, 12592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 12186, 12191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 12218, 12228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 12255, 12268);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 12311, 12316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 12461, 12480);

                    this.lexer = lexer;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 12498, 12527);

                    this.isVerbatim = isVerbatim;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 12545, 12577);

                    this.allowNewlines = isVerbatim;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10021, 12331, 12592);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10021, 12331, 12592);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 12331, 12592);
                }
            }

            private bool IsAtEnd()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10021, 12608, 12722);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 12663, 12707);

                    return f_10021_12670_12706(this, isVerbatim && (DynAbs.Tracing.TraceSender.Expression_True(10021, 12678, 12705) && allowNewlines));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10021, 12608, 12722);

                    bool
                    f_10021_12670_12706(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.InterpolatedStringScanner
                    this_param, bool
                    allowNewline)
                    {
                        var return_v = this_param.IsAtEnd(allowNewline);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 12670, 12706);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10021, 12608, 12722);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 12608, 12722);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool IsAtEnd(bool allowNewline)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10021, 12738, 13055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 12810, 12848);

                    char
                    ch = f_10021_12820_12847(lexer.TextWindow)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 12866, 13040);

                    return
                                        !allowNewline && (DynAbs.Tracing.TraceSender.Expression_True(10021, 12894, 12936) && f_10021_12911_12936(ch)) || (DynAbs.Tracing.TraceSender.Expression_False(10021, 12894, 13039) || (ch == SlidingTextWindow.InvalidCharacter && (DynAbs.Tracing.TraceSender.Expression_True(10021, 12962, 13038) && f_10021_13006_13038(lexer.TextWindow))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10021, 12738, 13055);

                    char
                    f_10021_12820_12847(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.PeekChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 12820, 12847);
                        return return_v;
                    }


                    bool
                    f_10021_12911_12936(char
                    ch)
                    {
                        var return_v = SyntaxFacts.IsNewLine(ch);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 12911, 12936);
                        return return_v;
                    }


                    bool
                    f_10021_13006_13038(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.IsReallyAtEnd();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 13006, 13038);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10021, 12738, 13055);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 12738, 13055);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal void ScanInterpolatedStringLiteralTop(ArrayBuilder<Interpolation> interpolations, ref TokenInfo info, out bool closeQuoteMissing)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10021, 13071, 14893);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 13242, 13867) || true) && (isVerbatim)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 13242, 13867);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 13298, 13518);

                        f_10021_13298_13517((f_10021_13338_13365(lexer.TextWindow) == '@' && (DynAbs.Tracing.TraceSender.Expression_True(10021, 13338, 13411) && f_10021_13376_13404(lexer.TextWindow, 1) == '$')) || (DynAbs.Tracing.TraceSender.Expression_False(10021, 13337, 13516) || (f_10021_13442_13469(lexer.TextWindow) == '$' && (DynAbs.Tracing.TraceSender.Expression_True(10021, 13442, 13515) && f_10021_13480_13508(lexer.TextWindow, 1) == '@'))));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 13575, 13606);

                        f_10021_13575_13605(
                                            // @$ or $@
                                            lexer.TextWindow);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 13628, 13659);

                        f_10021_13628_13658(lexer.TextWindow);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 13242, 13867);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 13242, 13867);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 13741, 13790);

                        f_10021_13741_13789(f_10021_13754_13781(lexer.TextWindow) == '$');
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 13812, 13843);

                        f_10021_13812_13842(lexer.TextWindow);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 13242, 13867);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 13887, 13936);

                    f_10021_13887_13935(f_10021_13900_13927(lexer.TextWindow) == '"');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 13954, 13985);

                    f_10021_13954_13984(lexer.TextWindow);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 14008, 14062);

                    f_10021_14008_14061(this, interpolations);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 14080, 14811) || true) && (f_10021_14084_14111(lexer.TextWindow) != '"')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 14080, 14811);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 14160, 14184);

                        f_10021_14160_14183(f_10021_14173_14182(this));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 14206, 14529) || true) && (error == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 14206, 14529);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 14273, 14362);

                            int
                            position = (DynAbs.Tracing.TraceSender.Conditional_F1(10021, 14288, 14301) || ((f_10021_14288_14301(this, true) && DynAbs.Tracing.TraceSender.Conditional_F2(10021, 14304, 14333)) || DynAbs.Tracing.TraceSender.Conditional_F3(10021, 14336, 14361))) ? f_10021_14304_14329(lexer.TextWindow) - 1 : f_10021_14336_14361(lexer.TextWindow)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 14388, 14506);

                            error = f_10021_14396_14505(lexer, position, 1, (DynAbs.Tracing.TraceSender.Conditional_F1(10021, 14425, 14435) || ((isVerbatim && DynAbs.Tracing.TraceSender.Conditional_F2(10021, 14438, 14473)) || DynAbs.Tracing.TraceSender.Conditional_F3(10021, 14476, 14504))) ? ErrorCode.ERR_UnterminatedStringLit : ErrorCode.ERR_NewlineInConst);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 14206, 14529);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 14553, 14578);

                        closeQuoteMissing = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 14080, 14811);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 14080, 14811);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 14708, 14739);

                        f_10021_14708_14738(                    // found the closing quote
                                            lexer.TextWindow);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 14766, 14792);

                        closeQuoteMissing = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 14080, 14811);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 14831, 14878);

                    info.Kind = SyntaxKind.InterpolatedStringToken;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10021, 13071, 14893);

                    char
                    f_10021_13338_13365(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.PeekChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 13338, 13365);
                        return return_v;
                    }


                    char
                    f_10021_13376_13404(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param, int
                    delta)
                    {
                        var return_v = this_param.PeekChar(delta);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 13376, 13404);
                        return return_v;
                    }


                    char
                    f_10021_13442_13469(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.PeekChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 13442, 13469);
                        return return_v;
                    }


                    char
                    f_10021_13480_13508(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param, int
                    delta)
                    {
                        var return_v = this_param.PeekChar(delta);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 13480, 13508);
                        return return_v;
                    }


                    int
                    f_10021_13298_13517(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 13298, 13517);
                        return 0;
                    }


                    int
                    f_10021_13575_13605(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 13575, 13605);
                        return 0;
                    }


                    int
                    f_10021_13628_13658(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 13628, 13658);
                        return 0;
                    }


                    char
                    f_10021_13754_13781(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.PeekChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 13754, 13781);
                        return return_v;
                    }


                    int
                    f_10021_13741_13789(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 13741, 13789);
                        return 0;
                    }


                    int
                    f_10021_13812_13842(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 13812, 13842);
                        return 0;
                    }


                    char
                    f_10021_13900_13927(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.PeekChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 13900, 13927);
                        return return_v;
                    }


                    int
                    f_10021_13887_13935(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 13887, 13935);
                        return 0;
                    }


                    int
                    f_10021_13954_13984(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 13954, 13984);
                        return 0;
                    }


                    int
                    f_10021_14008_14061(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.InterpolatedStringScanner
                    this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.Interpolation>
                    interpolations)
                    {
                        this_param.ScanInterpolatedStringLiteralContents(interpolations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 14008, 14061);
                        return 0;
                    }


                    char
                    f_10021_14084_14111(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.PeekChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 14084, 14111);
                        return return_v;
                    }


                    bool
                    f_10021_14173_14182(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.InterpolatedStringScanner
                    this_param)
                    {
                        var return_v = this_param.IsAtEnd();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 14173, 14182);
                        return return_v;
                    }


                    int
                    f_10021_14160_14183(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 14160, 14183);
                        return 0;
                    }


                    bool
                    f_10021_14288_14301(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.InterpolatedStringScanner
                    this_param, bool
                    allowNewline)
                    {
                        var return_v = this_param.IsAtEnd(allowNewline);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 14288, 14301);
                        return return_v;
                    }


                    int
                    f_10021_14304_14329(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10021, 14304, 14329);
                        return return_v;
                    }


                    int
                    f_10021_14336_14361(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10021, 14336, 14361);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                    f_10021_14396_14505(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                    this_param, int
                    position, int
                    width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code)
                    {
                        var return_v = this_param.MakeError(position, width, code);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 14396, 14505);
                        return return_v;
                    }


                    int
                    f_10021_14708_14738(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 14708, 14738);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10021, 13071, 14893);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 13071, 14893);
                }
            }

            private void ScanInterpolatedStringLiteralContents(ArrayBuilder<Interpolation> interpolations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10021, 14909, 19651);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 15036, 19636) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 15036, 19636);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 15089, 15250) || true) && (f_10021_15093_15102(this))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 15089, 15250);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 15220, 15227);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 15089, 15250);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 15274, 19617);

                            switch (f_10021_15282_15309(lexer.TextWindow))
                            {

                                case '"' when f_10021_15373_15402(this):
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 15274, 19617);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 15825, 15832);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 15274, 19617);

                                case '"':
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 15274, 19617);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 15897, 16196) || true) && (isVerbatim && (DynAbs.Tracing.TraceSender.Expression_True(10021, 15901, 15950) && f_10021_15915_15943(lexer.TextWindow, 1) == '"'))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 15897, 16196);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 16016, 16047);

                                        f_10021_16016_16046(lexer.TextWindow);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 16086, 16117);

                                        f_10021_16086_16116(lexer.TextWindow);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 16156, 16165);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 15897, 16196);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 16286, 16293);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 15274, 19617);

                                case '}':
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 15274, 19617);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 16358, 16394);

                                    var
                                    pos = f_10021_16368_16393(lexer.TextWindow)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 16424, 16455);

                                    f_10021_16424_16454(lexer.TextWindow);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 16561, 16948) || true) && (f_10021_16565_16592(lexer.TextWindow) == '}')
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 16561, 16948);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 16665, 16696);

                                        f_10021_16665_16695(lexer.TextWindow);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 16561, 16948);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 16561, 16948);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 16767, 16948) || true) && (error == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 16767, 16948);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 16850, 16917);

                                            error = f_10021_16858_16916(lexer, pos, 1, ErrorCode.ERR_UnescapedCurly, "}");
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 16767, 16948);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 16561, 16948);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 16978, 16987);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 15274, 19617);

                                case '{':
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 15274, 19617);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 17052, 18640) || true) && (f_10021_17056_17084(lexer.TextWindow, 1) == '{')
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 17052, 18640);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 17157, 17188);

                                        f_10021_17157_17187(lexer.TextWindow);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 17222, 17253);

                                        f_10021_17222_17252(lexer.TextWindow);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 17052, 18640);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 17052, 18640);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 17383, 17433);

                                        int
                                        openBracePosition = f_10021_17407_17432(lexer.TextWindow)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 17467, 17498);

                                        f_10021_17467_17497(lexer.TextWindow);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 17532, 17554);

                                        int
                                        colonPosition = 0
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 17588, 17664);

                                        f_10021_17588_17663(this, '}', true, ref colonPosition);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 17698, 17749);

                                        int
                                        closeBracePosition = f_10021_17723_17748(lexer.TextWindow)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 17783, 17814);

                                        bool
                                        closeBraceMissing = false
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 17848, 18461) || true) && (f_10021_17852_17879(lexer.TextWindow) == '}')
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 17848, 18461);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 17960, 17991);

                                            f_10021_17960_17990(lexer.TextWindow);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 17848, 18461);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 17848, 18461);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 18137, 18162);

                                            closeBraceMissing = true;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 18200, 18426) || true) && (error == null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 18200, 18426);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 18299, 18387);

                                                error = f_10021_18307_18386(lexer, openBracePosition - 1, 2, ErrorCode.ERR_UnclosedExpressionHole);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 18200, 18426);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 17848, 18461);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 18497, 18609);

                                        f_10021_18512_18608(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(interpolations, 10021, 18497, 18608), f_10021_18517_18607(openBracePosition, colonPosition, closeBracePosition, closeBraceMissing));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 17052, 18640);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 18670, 18679);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 15274, 19617);

                                case '\\':
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 15274, 19617);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 18745, 18869) || true) && (isVerbatim)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 18745, 18869);

                                        goto default;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 18745, 18869);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 18901, 18945);

                                    var
                                    escapeStart = f_10021_18919_18944(lexer.TextWindow)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 18975, 18983);

                                    char
                                    c2
                                    = default(char);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 19013, 19056);

                                    char
                                    ch = f_10021_19023_19055(lexer, out c2)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 19086, 19338) || true) && ((ch == '{' || (DynAbs.Tracing.TraceSender.Expression_False(10021, 19091, 19113) || ch == '}')) && (DynAbs.Tracing.TraceSender.Expression_True(10021, 19090, 19131) && error == null))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 19086, 19338);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 19197, 19307);

                                        error = f_10021_19205_19306(lexer, escapeStart, f_10021_19234_19259(lexer.TextWindow) - escapeStart, ErrorCode.ERR_EscapedCurly, ch);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 19086, 19338);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 19370, 19379);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 15274, 19617);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 15274, 19617);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 19524, 19555);

                                    f_10021_19524_19554(                            // found some other character in the string portion
                                                                lexer.TextWindow);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 19585, 19594);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 15274, 19617);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 15036, 19636);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10021, 15036, 19636);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10021, 15036, 19636);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10021, 14909, 19651);

                    bool
                    f_10021_15093_15102(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.InterpolatedStringScanner
                    this_param)
                    {
                        var return_v = this_param.IsAtEnd();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 15093, 15102);
                        return return_v;
                    }


                    char
                    f_10021_15282_15309(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.PeekChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 15282, 15309);
                        return return_v;
                    }


                    bool
                    f_10021_15373_15402(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.InterpolatedStringScanner
                    this_param)
                    {
                        var return_v = this_param.RecoveringFromRunawayLexing();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 15373, 15402);
                        return return_v;
                    }


                    char
                    f_10021_15915_15943(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param, int
                    delta)
                    {
                        var return_v = this_param.PeekChar(delta);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 15915, 15943);
                        return return_v;
                    }


                    int
                    f_10021_16016_16046(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 16016, 16046);
                        return 0;
                    }


                    int
                    f_10021_16086_16116(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 16086, 16116);
                        return 0;
                    }


                    int
                    f_10021_16368_16393(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10021, 16368, 16393);
                        return return_v;
                    }


                    int
                    f_10021_16424_16454(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 16424, 16454);
                        return 0;
                    }


                    char
                    f_10021_16565_16592(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.PeekChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 16565, 16592);
                        return return_v;
                    }


                    int
                    f_10021_16665_16695(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 16665, 16695);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                    f_10021_16858_16916(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                    this_param, int
                    position, int
                    width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, params object[]
                    args)
                    {
                        var return_v = this_param.MakeError(position, width, code, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 16858, 16916);
                        return return_v;
                    }


                    char
                    f_10021_17056_17084(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param, int
                    delta)
                    {
                        var return_v = this_param.PeekChar(delta);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 17056, 17084);
                        return return_v;
                    }


                    int
                    f_10021_17157_17187(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 17157, 17187);
                        return 0;
                    }


                    int
                    f_10021_17222_17252(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 17222, 17252);
                        return 0;
                    }


                    int
                    f_10021_17407_17432(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10021, 17407, 17432);
                        return return_v;
                    }


                    int
                    f_10021_17467_17497(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 17467, 17497);
                        return 0;
                    }


                    int
                    f_10021_17588_17663(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.InterpolatedStringScanner
                    this_param, char
                    endingChar, bool
                    isHole, ref int
                    colonPosition)
                    {
                        this_param.ScanInterpolatedStringLiteralHoleBalancedText(endingChar, isHole, ref colonPosition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 17588, 17663);
                        return 0;
                    }


                    int
                    f_10021_17723_17748(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10021, 17723, 17748);
                        return return_v;
                    }


                    char
                    f_10021_17852_17879(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.PeekChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 17852, 17879);
                        return return_v;
                    }


                    int
                    f_10021_17960_17990(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 17960, 17990);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                    f_10021_18307_18386(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                    this_param, int
                    position, int
                    width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code)
                    {
                        var return_v = this_param.MakeError(position, width, code);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 18307, 18386);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.Interpolation
                    f_10021_18517_18607(int
                    openBracePosition, int
                    colonPosition, int
                    closeBracePosition, bool
                    closeBraceMissing)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.Interpolation(openBracePosition, colonPosition, closeBracePosition, closeBraceMissing);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 18517, 18607);
                        return return_v;
                    }


                    int
                    f_10021_18512_18608(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.Interpolation>
                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.Interpolation
                    item)
                    {
                        this_param?.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 18512, 18608);
                        return 0;
                    }


                    int
                    f_10021_18919_18944(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10021, 18919, 18944);
                        return return_v;
                    }


                    char
                    f_10021_19023_19055(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                    this_param, out char
                    surrogateCharacter)
                    {
                        var return_v = this_param.ScanEscapeSequence(out surrogateCharacter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 19023, 19055);
                        return return_v;
                    }


                    int
                    f_10021_19234_19259(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10021, 19234, 19259);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                    f_10021_19205_19306(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                    this_param, int
                    position, int
                    width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, params object[]
                    args)
                    {
                        var return_v = this_param.MakeError(position, width, code, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 19205, 19306);
                        return return_v;
                    }


                    int
                    f_10021_19524_19554(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 19524, 19554);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10021, 14909, 19651);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 14909, 19651);
                }
            }

            private void ScanFormatSpecifier()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10021, 19667, 22489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 19734, 19783);

                    f_10021_19734_19782(f_10021_19747_19774(lexer.TextWindow) == ':');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 19801, 19832);

                    f_10021_19801_19831(lexer.TextWindow);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 19850, 22474) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 19850, 22474);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 19903, 19941);

                            char
                            ch = f_10021_19913_19940(lexer.TextWindow)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 19963, 22455) || true) && (ch == '\\' && (DynAbs.Tracing.TraceSender.Expression_True(10021, 19967, 19992) && !isVerbatim))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 19963, 22455);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 20118, 20154);

                                var
                                pos = f_10021_20128_20153(lexer.TextWindow)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 20180, 20188);

                                char
                                c2
                                = default(char);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 20214, 20252);

                                ch = f_10021_20219_20251(lexer, out c2);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 20278, 20472) || true) && ((ch == '{' || (DynAbs.Tracing.TraceSender.Expression_False(10021, 20283, 20305) || ch == '}')) && (DynAbs.Tracing.TraceSender.Expression_True(10021, 20282, 20323) && error == null))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 20278, 20472);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 20381, 20445);

                                    error = f_10021_20389_20444(lexer, pos, 1, ErrorCode.ERR_EscapedCurly, ch);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 20278, 20472);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 19963, 22455);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 19963, 22455);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 20522, 22455) || true) && (ch == '"')
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 20522, 22455);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 20585, 21013) || true) && (isVerbatim && (DynAbs.Tracing.TraceSender.Expression_True(10021, 20589, 20638) && f_10021_20603_20631(lexer.TextWindow, 1) == '"'))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 20585, 21013);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 20696, 20727);

                                        f_10021_20696_20726(lexer.TextWindow);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 20757, 20788);

                                        f_10021_20757_20787(lexer.TextWindow);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 20585, 21013);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 20585, 21013);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 20902, 20909);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 20585, 21013);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 20522, 22455);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 20522, 22455);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 21063, 22455) || true) && (ch == '{')
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 21063, 22455);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 21126, 21162);

                                        var
                                        pos = f_10021_21136_21161(lexer.TextWindow)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 21188, 21219);

                                        f_10021_21188_21218(lexer.TextWindow);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 21312, 21671) || true) && (f_10021_21316_21343(lexer.TextWindow) == '{')
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 21312, 21671);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 21408, 21439);

                                            f_10021_21408_21438(lexer.TextWindow);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 21312, 21671);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 21312, 21671);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 21502, 21671) || true) && (error == null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 21502, 21671);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 21577, 21644);

                                                error = f_10021_21585_21643(lexer, pos, 1, ErrorCode.ERR_UnescapedCurly, "{");
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 21502, 21671);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 21312, 21671);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 21063, 22455);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 21063, 22455);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 21721, 22455) || true) && (ch == '}')
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 21721, 22455);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 21784, 22145) || true) && (f_10021_21788_21816(lexer.TextWindow, 1) == '}')
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 21784, 22145);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 21881, 21912);

                                                f_10021_21881_21911(lexer.TextWindow);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 21942, 21973);

                                                f_10021_21942_21972(lexer.TextWindow);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 21784, 22145);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 21784, 22145);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 22087, 22094);

                                                return;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 21784, 22145);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 21721, 22455);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 21721, 22455);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 22195, 22455) || true) && (f_10021_22199_22208(this))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 22195, 22455);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 22258, 22265);

                                                return;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 22195, 22455);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 22195, 22455);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 22401, 22432);

                                                f_10021_22401_22431(lexer.TextWindow);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 22195, 22455);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 21721, 22455);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 21063, 22455);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 20522, 22455);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 19963, 22455);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 19850, 22474);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10021, 19850, 22474);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10021, 19850, 22474);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10021, 19667, 22489);

                    char
                    f_10021_19747_19774(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.PeekChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 19747, 19774);
                        return return_v;
                    }


                    int
                    f_10021_19734_19782(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 19734, 19782);
                        return 0;
                    }


                    int
                    f_10021_19801_19831(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 19801, 19831);
                        return 0;
                    }


                    char
                    f_10021_19913_19940(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.PeekChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 19913, 19940);
                        return return_v;
                    }


                    int
                    f_10021_20128_20153(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10021, 20128, 20153);
                        return return_v;
                    }


                    char
                    f_10021_20219_20251(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                    this_param, out char
                    surrogateCharacter)
                    {
                        var return_v = this_param.ScanEscapeSequence(out surrogateCharacter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 20219, 20251);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                    f_10021_20389_20444(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                    this_param, int
                    position, int
                    width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, params object[]
                    args)
                    {
                        var return_v = this_param.MakeError(position, width, code, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 20389, 20444);
                        return return_v;
                    }


                    char
                    f_10021_20603_20631(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param, int
                    delta)
                    {
                        var return_v = this_param.PeekChar(delta);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 20603, 20631);
                        return return_v;
                    }


                    int
                    f_10021_20696_20726(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 20696, 20726);
                        return 0;
                    }


                    int
                    f_10021_20757_20787(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 20757, 20787);
                        return 0;
                    }


                    int
                    f_10021_21136_21161(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10021, 21136, 21161);
                        return return_v;
                    }


                    int
                    f_10021_21188_21218(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 21188, 21218);
                        return 0;
                    }


                    char
                    f_10021_21316_21343(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.PeekChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 21316, 21343);
                        return return_v;
                    }


                    int
                    f_10021_21408_21438(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 21408, 21438);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                    f_10021_21585_21643(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                    this_param, int
                    position, int
                    width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, params object[]
                    args)
                    {
                        var return_v = this_param.MakeError(position, width, code, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 21585, 21643);
                        return return_v;
                    }


                    char
                    f_10021_21788_21816(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param, int
                    delta)
                    {
                        var return_v = this_param.PeekChar(delta);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 21788, 21816);
                        return return_v;
                    }


                    int
                    f_10021_21881_21911(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 21881, 21911);
                        return 0;
                    }


                    int
                    f_10021_21942_21972(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 21942, 21972);
                        return 0;
                    }


                    bool
                    f_10021_22199_22208(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.InterpolatedStringScanner
                    this_param)
                    {
                        var return_v = this_param.IsAtEnd();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 22199, 22208);
                        return return_v;
                    }


                    int
                    f_10021_22401_22431(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 22401, 22431);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10021, 19667, 22489);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 19667, 22489);
                }
            }

            private void ScanInterpolatedStringLiteralHoleBalancedText(char endingChar, bool isHole, ref int colonPosition)
            {
                while (true)
                {
                    if (IsAtEnd())
                    {
                        // the caller will complain
                        return;
                    }

                    char ch = lexer.TextWindow.PeekChar();
                    switch (ch)
                    {
                        case '#':
                            // preprocessor directives not allowed.
                            if (error == null)
                            {
                                error = lexer.MakeError(lexer.TextWindow.Position, 1, ErrorCode.ERR_SyntaxError, endingChar.ToString());
                            }

                            lexer.TextWindow.AdvanceChar();
                            continue;
                        case '$':
                            if (lexer.TextWindow.PeekChar(1) == '"' || lexer.TextWindow.PeekChar(1) == '@' && lexer.TextWindow.PeekChar(2) == '"')
                            {
                                bool isVerbatimSubstring = lexer.TextWindow.PeekChar(1) == '@';
                                var interpolations = (ArrayBuilder<Interpolation>)null;
                                var info = default(TokenInfo);
                                bool wasVerbatim = this.isVerbatim;
                                bool wasAllowNewlines = this.allowNewlines;
                                try
                                {
                                    this.isVerbatim = isVerbatimSubstring;
                                    this.allowNewlines &= isVerbatim;
                                    bool closeQuoteMissing;
                                    ScanInterpolatedStringLiteralTop(interpolations, ref info, out closeQuoteMissing);
                                }
                                finally
                                {
                                    this.isVerbatim = wasVerbatim;
                                    this.allowNewlines = wasAllowNewlines;
                                }
                                continue;
                            }

                            goto default;
                        case ':':
                            // the first colon not nested within matching delimiters is the start of the format string
                            if (isHole)
                            {
                                Debug.Assert(colonPosition == 0);
                                colonPosition = lexer.TextWindow.Position;
                                ScanFormatSpecifier();
                                return;
                            }

                            goto default;
                        case '}':
                        case ')':
                        case ']':
                            if (ch == endingChar)
                            {
                                return;
                            }

                            if (error == null)
                            {
                                error = lexer.MakeError(lexer.TextWindow.Position, 1, ErrorCode.ERR_SyntaxError, endingChar.ToString());
                            }

                            goto default;
                        case '"' when RecoveringFromRunawayLexing():
                            // When recovering from mismatched delimiters, we consume the next
                            // quote character as the close quote for the interpolated string. In
                            // practice this gets us out of trouble in scenarios we've encountered.
                            // See, for example, https://github.com/dotnet/roslyn/issues/44789
                            return;
                        case '"':
                        case '\'':
                            // handle string or character literal inside an expression hole.
                            ScanInterpolatedStringLiteralNestedString();
                            continue;
                        case '@':
                            if (lexer.TextWindow.PeekChar(1) == '"' && !RecoveringFromRunawayLexing())
                            {
                                // check for verbatim string inside an expression hole.
                                ScanInterpolatedStringLiteralNestedVerbatimString();
                                continue;
                            }
                            else if (lexer.TextWindow.PeekChar(1) == '$' && lexer.TextWindow.PeekChar(2) == '"')
                            {
                                lexer.CheckFeatureAvailability(MessageID.IDS_FeatureAltInterpolatedVerbatimStrings);
                                var interpolations = (ArrayBuilder<Interpolation>)null;
                                var info = default(TokenInfo);
                                bool wasVerbatim = this.isVerbatim;
                                bool wasAllowNewlines = this.allowNewlines;
                                try
                                {
                                    this.isVerbatim = true;
                                    this.allowNewlines = true;
                                    bool closeQuoteMissing;
                                    ScanInterpolatedStringLiteralTop(interpolations, ref info, out closeQuoteMissing);
                                }
                                finally
                                {
                                    this.isVerbatim = wasVerbatim;
                                    this.allowNewlines = wasAllowNewlines;
                                }
                                continue;
                            }

                            goto default;
                        case '/':
                            switch (lexer.TextWindow.PeekChar(1))
                            {
                                case '/':
                                    if (isVerbatim && allowNewlines)
                                    {
                                        lexer.TextWindow.AdvanceChar(); // skip /
                                        lexer.TextWindow.AdvanceChar(); // skip /
                                        while (!IsAtEnd(false))
                                        {
                                            lexer.TextWindow.AdvanceChar(); // skip // comment character
                                        }
                                    }
                                    else
                                    {
                                        // error: single-line comment not allowed in an interpolated string
                                        if (error == null)
                                        {
                                            error = lexer.MakeError(lexer.TextWindow.Position, 2, ErrorCode.ERR_SingleLineCommentInExpressionHole);
                                        }

                                        lexer.TextWindow.AdvanceChar();
                                        lexer.TextWindow.AdvanceChar();
                                    }
                                    continue;
                                case '*':
                                    // check for and scan /* comment */
                                    ScanInterpolatedStringLiteralNestedComment();
                                    continue;
                                default:
                                    lexer.TextWindow.AdvanceChar();
                                    continue;
                            }
                        case '{':
                            // TODO: after the colon this has no special meaning.
                            ScanInterpolatedStringLiteralHoleBracketed('{', '}');
                            continue;
                        case '(':
                            // TODO: after the colon this has no special meaning.
                            ScanInterpolatedStringLiteralHoleBracketed('(', ')');
                            continue;
                        case '[':
                            // TODO: after the colon this has no special meaning.
                            ScanInterpolatedStringLiteralHoleBracketed('[', ']');
                            continue;
                        default:
                            // part of code in the expression hole
                            lexer.TextWindow.AdvanceChar();
                            continue;
                    }
                }
            }

            private bool RecoveringFromRunawayLexing()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10021, 31850, 31871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 31853, 31871);
                    return this.error != null; DynAbs.Tracing.TraceSender.TraceExitMethod(10021, 31850, 31871);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10021, 31850, 31871);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 31850, 31871);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void ScanInterpolatedStringLiteralNestedComment()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10021, 31888, 32781);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 31978, 32027);

                    f_10021_31978_32026(f_10021_31991_32018(lexer.TextWindow) == '/');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 32045, 32076);

                    f_10021_32045_32075(lexer.TextWindow);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 32094, 32143);

                    f_10021_32094_32142(f_10021_32107_32134(lexer.TextWindow) == '*');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 32161, 32192);

                    f_10021_32161_32191(lexer.TextWindow);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 32210, 32766) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 32210, 32766);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 32263, 32412) || true) && (f_10021_32267_32276(this))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 32263, 32412);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 32326, 32333);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 32263, 32412);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 32436, 32473);

                            var
                            ch = f_10021_32445_32472(lexer.TextWindow)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 32495, 32526);

                            f_10021_32495_32525(lexer.TextWindow);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 32548, 32747) || true) && (ch == '*' && (DynAbs.Tracing.TraceSender.Expression_True(10021, 32552, 32599) && f_10021_32565_32592(lexer.TextWindow) == '/'))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 32548, 32747);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 32649, 32680);

                                f_10021_32649_32679(lexer.TextWindow);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 32717, 32724);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 32548, 32747);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 32210, 32766);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10021, 32210, 32766);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10021, 32210, 32766);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10021, 31888, 32781);

                    char
                    f_10021_31991_32018(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.PeekChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 31991, 32018);
                        return return_v;
                    }


                    int
                    f_10021_31978_32026(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 31978, 32026);
                        return 0;
                    }


                    int
                    f_10021_32045_32075(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 32045, 32075);
                        return 0;
                    }


                    char
                    f_10021_32107_32134(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.PeekChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 32107, 32134);
                        return return_v;
                    }


                    int
                    f_10021_32094_32142(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 32094, 32142);
                        return 0;
                    }


                    int
                    f_10021_32161_32191(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 32161, 32191);
                        return 0;
                    }


                    bool
                    f_10021_32267_32276(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.InterpolatedStringScanner
                    this_param)
                    {
                        var return_v = this_param.IsAtEnd();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 32267, 32276);
                        return return_v;
                    }


                    char
                    f_10021_32445_32472(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.PeekChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 32445, 32472);
                        return return_v;
                    }


                    int
                    f_10021_32495_32525(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 32495, 32525);
                        return 0;
                    }


                    char
                    f_10021_32565_32592(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.PeekChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 32565, 32592);
                        return return_v;
                    }


                    int
                    f_10021_32649_32679(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 32649, 32679);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10021, 31888, 32781);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 31888, 32781);
                }
            }

            private void ScanInterpolatedStringLiteralNestedString()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10021, 32797, 32999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 32886, 32921);

                    var
                    discarded = default(TokenInfo)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 32939, 32984);

                    f_10021_32939_32983(lexer, ref discarded, true);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10021, 32797, 32999);

                    int
                    f_10021_32939_32983(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                    this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                    info, bool
                    allowEscapes)
                    {
                        this_param.ScanStringLiteral(ref info, allowEscapes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 32939, 32983);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10021, 32797, 32999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 32797, 32999);
                }
            }

            private void ScanInterpolatedStringLiteralNestedVerbatimString()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10021, 33015, 33257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 33112, 33147);

                    var
                    discarded = default(TokenInfo)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 33165, 33242);

                    f_10021_33165_33241(lexer, ref discarded, allowNewlines: allowNewlines);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10021, 33015, 33257);

                    int
                    f_10021_33165_33241(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                    this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                    info, bool
                    allowNewlines)
                    {
                        this_param.ScanVerbatimStringLiteral(ref info, allowNewlines: allowNewlines);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 33165, 33241);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10021, 33015, 33257);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 33015, 33257);
                }
            }

            private void ScanInterpolatedStringLiteralHoleBracketed(char start, char end)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10021, 33273, 33882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 33383, 33434);

                    f_10021_33383_33433(start == f_10021_33405_33432(lexer.TextWindow));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 33452, 33483);

                    f_10021_33452_33482(lexer.TextWindow);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 33501, 33515);

                    int
                    colon = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 33533, 33602);

                    f_10021_33533_33601(this, end, false, ref colon);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 33620, 33867) || true) && (f_10021_33624_33651(lexer.TextWindow) == end)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 33620, 33867);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10021, 33700, 33731);

                        f_10021_33700_33730(lexer.TextWindow);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 33620, 33867);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10021, 33620, 33867);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10021, 33620, 33867);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10021, 33273, 33882);

                    char
                    f_10021_33405_33432(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.PeekChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 33405, 33432);
                        return return_v;
                    }


                    int
                    f_10021_33383_33433(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 33383, 33433);
                        return 0;
                    }


                    int
                    f_10021_33452_33482(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 33452, 33482);
                        return 0;
                    }


                    int
                    f_10021_33533_33601(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.InterpolatedStringScanner
                    this_param, char
                    endingChar, bool
                    isHole, ref int
                    colonPosition)
                    {
                        this_param.ScanInterpolatedStringLiteralHoleBalancedText(endingChar, isHole, ref colonPosition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 33533, 33601);
                        return 0;
                    }


                    char
                    f_10021_33624_33651(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.PeekChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 33624, 33651);
                        return return_v;
                    }


                    int
                    f_10021_33700_33730(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        this_param.AdvanceChar();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10021, 33700, 33730);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10021, 33273, 33882);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 33273, 33882);
                }
            }

            static InterpolatedStringScanner()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10021, 12100, 33893);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10021, 12100, 33893);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10021, 12100, 33893);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10021, 12100, 33893);
        }
    }
}
