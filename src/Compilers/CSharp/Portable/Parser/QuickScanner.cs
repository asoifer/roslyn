// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    internal partial class Lexer
    {
        internal const int
        MaxCachedTokenSize = 42
        ;

        private enum QuickScanState : byte
        {
            Initial,
            FollowingWhite,
            FollowingCR,
            Ident,
            Number,
            Punctuation,
            Dot,
            CompoundPunctStart,
            DoneAfterNext,
            // we are relying on Bad state immediately following Done 
            // to be able to detect exiting conditions in one "state >= Done" test.
            // And we are also relying on this to be the last item in the enum.
            Done,
            Bad = Done + 1
        }

        private enum CharFlags : byte
        {
            White,      // simple whitespace (space/tab)
            CR,         // carriage return
            LF,         // line feed
            Letter,     // letter
            Digit,      // digit 0-9
            Punct,      // some simple punctuation (parens, braces, comma, equals, question)
            Dot,        // dot is different from other punctuation when followed by a digit (Ex: .9 )
            CompoundPunctStart, // may be a part of compound punctuation. will be used only if followed by (not white) && (not punct)
            Slash,      // /
            Complex,    // complex - causes scanning to abort
            EndOfFile,  // legal type character (except !, which is contextually dictionary lookup
        }

        private static readonly byte[,] s_stateTransitions;

        private SyntaxToken QuickScanSyntaxToken()
        {
            this.Start();
            var state = QuickScanState.Initial;
            int i = TextWindow.Offset;
            int n = TextWindow.CharacterWindowCount;
            n = Math.Min(n, i + MaxCachedTokenSize);

            int hashCode = Hash.FnvOffsetBias;

            //localize frequently accessed fields
            var charWindow = TextWindow.CharacterWindow;
            var charPropLength = s_charProperties.Length;

            for (; i < n; i++)
            {
                char c = charWindow[i];
                int uc = unchecked((int)c);

                var flags = uc < charPropLength ? (CharFlags)s_charProperties[uc] : CharFlags.Complex;

                state = (QuickScanState)s_stateTransitions[(int)state, (int)flags];
                // NOTE: that Bad > Done and it is the only state like that
                // as a result, we will exit the loop on either Bad or Done.
                // the assert below will validate that these are the only states on which we exit
                // Also note that we must exit on Done or Bad
                // since the state machine does not have transitions for these states 
                // and will promptly fail if we do not exit.
                if (state >= QuickScanState.Done)
                {
                    goto exitWhile;
                }

                hashCode = unchecked((hashCode ^ uc) * Hash.FnvPrime);
            }

            state = QuickScanState.Bad; // ran out of characters in window
exitWhile:

            TextWindow.AdvanceChar(i - TextWindow.Offset);
            Debug.Assert(state == QuickScanState.Bad || state == QuickScanState.Done, "can only exit with Bad or Done");

            if (state == QuickScanState.Done)
            {
                // this is a good token!
                var token = _cache.LookupToken(
                    TextWindow.CharacterWindow,
                    TextWindow.LexemeRelativeStart,
                    i - TextWindow.LexemeRelativeStart,
                    hashCode,
                    _createQuickTokenFunction);
                return token;
            }
            else
            {
                TextWindow.Reset(TextWindow.LexemeStartPosition);
                return null;
            }
        }

        private readonly Func<SyntaxToken> _createQuickTokenFunction;

        private SyntaxToken CreateQuickToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10015, 12497, 12839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10015, 12571, 12605);

                var
                quickWidth = f_10015_12588_12604(TextWindow)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10015, 12627, 12676);

                f_10015_12627_12675(TextWindow, f_10015_12644_12674(TextWindow));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10015, 12690, 12724);

                var
                token = f_10015_12702_12723(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10015, 12749, 12793);

                f_10015_12749_12792(quickWidth == f_10015_12776_12791(token));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10015, 12815, 12828);

                return token;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10015, 12497, 12839);

                int
                f_10015_12588_12604(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10015, 12588, 12604);
                    return return_v;
                }


                int
                f_10015_12644_12674(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.LexemeStartPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10015, 12644, 12674);
                    return return_v;
                }


                int
                f_10015_12627_12675(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                position)
                {
                    this_param.Reset(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10015, 12627, 12675);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10015_12702_12723(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.LexSyntaxToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10015, 12702, 12723);
                    return return_v;
                }


                int
                f_10015_12776_12791(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10015, 12776, 12791);
                    return return_v;
                }


                int
                f_10015_12749_12792(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10015, 12749, 12792);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10015, 12497, 12839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10015, 12497, 12839);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly byte[] s_charProperties;
    }
}
