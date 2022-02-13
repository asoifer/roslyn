// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis.Syntax.InternalSyntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    [Flags]
    internal enum LexerMode
    {
        Syntax = 0x0001,
        DebuggerSyntax = 0x0002,
        Directive = 0x0004,
        XmlDocComment = 0x0008,
        XmlElementTag = 0x0010,
        XmlAttributeTextQuote = 0x0020,
        XmlAttributeTextDoubleQuote = 0x0040,
        XmlCrefQuote = 0x0080,
        XmlCrefDoubleQuote = 0x0100,
        XmlNameQuote = 0x0200,
        XmlNameDoubleQuote = 0x0400,
        XmlCDataSectionText = 0x0800,
        XmlCommentText = 0x1000,
        XmlProcessingInstructionText = 0x2000,
        XmlCharacter = 0x4000,
        MaskLexMode = 0xFFFF,

        // The following are lexer driven, which is to say the lexer can push a change back to the
        // blender. There is in general no need to use a whole bit per enum value, but the debugging
        // experience is bad if you don't do that.

        XmlDocCommentLocationStart = 0x00000,
        XmlDocCommentLocationInterior = 0x10000,
        XmlDocCommentLocationExterior = 0x20000,
        XmlDocCommentLocationEnd = 0x40000,
        MaskXmlDocCommentLocation = 0xF0000,

        XmlDocCommentStyleSingleLine = 0x000000,
        XmlDocCommentStyleDelimited = 0x100000,
        MaskXmlDocCommentStyle = 0x300000,

        None = 0
    }

    // Needs to match LexMode.XmlDocCommentLocation*
    internal enum XmlDocCommentLocation
    {
        Start = 0,
        Interior = 1,
        Exterior = 2,
        End = 4
    }

    // Needs to match LexMode.XmlDocCommentStyle*
    internal enum XmlDocCommentStyle
    {
        SingleLine = 0,
        Delimited = 1
    }
    internal partial class Lexer : AbstractLexer
    {
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10014, 2159, 183578);
        static Lexer()
        {
            static int
        f_10014_93077_93093(string
        this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 93077, 93093);
                return return_v;
            }

            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10014, 2159, 183578);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 2238, 2267);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 7631, 7642);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 93052, 93093);
            s_conflictMarkerLength = f_10014_93077_93093("<<<<<<<"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10015, 840, 863);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10015, 2496, 10022);
            s_stateTransitions = new byte[,]
                    {
            // Initial
            {
                (byte)QuickScanState.Initial,             // White
                (byte)QuickScanState.Initial,             // CR
                (byte)QuickScanState.Initial,             // LF
                (byte)QuickScanState.Ident,               // Letter
                (byte)QuickScanState.Number,              // Digit
                (byte)QuickScanState.Punctuation,         // Punct
                (byte)QuickScanState.Dot,                 // Dot
                (byte)QuickScanState.CompoundPunctStart,  // Compound
                (byte)QuickScanState.Bad,                 // Slash
                (byte)QuickScanState.Bad,                 // Complex
                (byte)QuickScanState.Bad,                 // EndOfFile
            },

            // Following White
            {
                (byte)QuickScanState.FollowingWhite,      // White
                (byte)QuickScanState.FollowingCR,         // CR
                (byte)QuickScanState.DoneAfterNext,       // LF
                (byte)QuickScanState.Done,                // Letter
                (byte)QuickScanState.Done,                // Digit
                (byte)QuickScanState.Done,                // Punct
                (byte)QuickScanState.Done,                // Dot
                (byte)QuickScanState.Done,                // Compound
                (byte)QuickScanState.Bad,                 // Slash
                (byte)QuickScanState.Bad,                 // Complex
                (byte)QuickScanState.Done,                // EndOfFile
            },

            // Following CR
            {
                (byte)QuickScanState.Done,                // White
                (byte)QuickScanState.Done,                // CR
                (byte)QuickScanState.DoneAfterNext,       // LF
                (byte)QuickScanState.Done,                // Letter
                (byte)QuickScanState.Done,                // Digit
                (byte)QuickScanState.Done,                // Punct
                (byte)QuickScanState.Done,                // Dot
                (byte)QuickScanState.Done,                // Compound
                (byte)QuickScanState.Done,                // Slash
                (byte)QuickScanState.Done,                // Complex
                (byte)QuickScanState.Done,                // EndOfFile
            },

            // Identifier
            {
                (byte)QuickScanState.FollowingWhite,      // White
                (byte)QuickScanState.FollowingCR,         // CR
                (byte)QuickScanState.DoneAfterNext,       // LF
                (byte)QuickScanState.Ident,               // Letter
                (byte)QuickScanState.Ident,               // Digit
                (byte)QuickScanState.Done,                // Punct
                (byte)QuickScanState.Done,                // Dot
                (byte)QuickScanState.Done,                // Compound
                (byte)QuickScanState.Bad,                 // Slash
                (byte)QuickScanState.Bad,                 // Complex
                (byte)QuickScanState.Done,                // EndOfFile
            },

            // Number
            {
                (byte)QuickScanState.FollowingWhite,      // White
                (byte)QuickScanState.FollowingCR,         // CR
                (byte)QuickScanState.DoneAfterNext,       // LF
                (byte)QuickScanState.Bad,                 // Letter (might be 'e' or 'x' or suffix)
                (byte)QuickScanState.Number,              // Digit
                (byte)QuickScanState.Done,                // Punct
                (byte)QuickScanState.Bad,                 // Dot (Number is followed by a dot - too complex for us to handle here).
                (byte)QuickScanState.Done,                // Compound
                (byte)QuickScanState.Bad,                 // Slash
                (byte)QuickScanState.Bad,                 // Complex
                (byte)QuickScanState.Done,                // EndOfFile
            },

            // Punctuation
            {
                (byte)QuickScanState.FollowingWhite,      // White
                (byte)QuickScanState.FollowingCR,         // CR
                (byte)QuickScanState.DoneAfterNext,       // LF
                (byte)QuickScanState.Done,                // Letter
                (byte)QuickScanState.Done,                // Digit
                (byte)QuickScanState.Done,                // Punct
                (byte)QuickScanState.Done,                // Dot
                (byte)QuickScanState.Done,                // Compound
                (byte)QuickScanState.Bad,                 // Slash
                (byte)QuickScanState.Bad,                 // Complex
                (byte)QuickScanState.Done,                // EndOfFile
            },

            // Dot
            {
                (byte)QuickScanState.FollowingWhite,      // White
                (byte)QuickScanState.FollowingCR,         // CR
                (byte)QuickScanState.DoneAfterNext,       // LF
                (byte)QuickScanState.Done,                // Letter
                (byte)QuickScanState.Number,              // Digit
                (byte)QuickScanState.Done,                // Punct
                (byte)QuickScanState.Bad,                 // Dot (DotDot range token, exit so that we handle it in subsequent scanning code)
                (byte)QuickScanState.Done,                // Compound
                (byte)QuickScanState.Bad,                 // Slash
                (byte)QuickScanState.Bad,                 // Complex
                (byte)QuickScanState.Done,                // EndOfFile
            },

            // Compound Punctuation
            {
                (byte)QuickScanState.FollowingWhite,      // White
                (byte)QuickScanState.FollowingCR,         // CR
                (byte)QuickScanState.DoneAfterNext,       // LF
                (byte)QuickScanState.Done,                // Letter
                (byte)QuickScanState.Done,                // Digit
                (byte)QuickScanState.Bad,                 // Punct
                (byte)QuickScanState.Done,                // Dot
                (byte)QuickScanState.Bad,                 // Compound
                (byte)QuickScanState.Bad,                 // Slash
                (byte)QuickScanState.Bad,                 // Complex
                (byte)QuickScanState.Done,                // EndOfFile
            },

            // Done after next
            {
                (byte)QuickScanState.Done,                // White
                (byte)QuickScanState.Done,                // CR
                (byte)QuickScanState.Done,                // LF
                (byte)QuickScanState.Done,                // Letter
                (byte)QuickScanState.Done,                // Digit
                (byte)QuickScanState.Done,                // Punct
                (byte)QuickScanState.Done,                // Dot
                (byte)QuickScanState.Done,                // Compound
                (byte)QuickScanState.Done,                // Slash
                (byte)QuickScanState.Done,                // Complex
                (byte)QuickScanState.Done,                // EndOfFile
            },
                    }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10015, 13228, 25445);
            s_charProperties = new[]
                    {
            // 0 .. 31
            (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex,
            (byte)CharFlags.Complex,
            (byte)CharFlags.White,   // TAB
            (byte)CharFlags.LF,      // LF
            (byte)CharFlags.White,   // VT
            (byte)CharFlags.White,   // FF
            (byte)CharFlags.CR,      // CR
            (byte)CharFlags.Complex,
            (byte)CharFlags.Complex,
            (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex,
            (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex,

            // 32 .. 63
            (byte)CharFlags.White,    // SPC
            (byte)CharFlags.CompoundPunctStart,    // !
            (byte)CharFlags.Complex,  // "
            (byte)CharFlags.Complex,  // #
            (byte)CharFlags.Complex,  // $
            (byte)CharFlags.CompoundPunctStart, // %
            (byte)CharFlags.CompoundPunctStart, // &
            (byte)CharFlags.Complex,  // '
            (byte)CharFlags.Punct,    // (
            (byte)CharFlags.Punct,    // )
            (byte)CharFlags.CompoundPunctStart, // *
            (byte)CharFlags.CompoundPunctStart, // +
            (byte)CharFlags.Punct,    // ,
            (byte)CharFlags.CompoundPunctStart, // -
            (byte)CharFlags.Dot,      // .
            (byte)CharFlags.Slash,    // /
            (byte)CharFlags.Digit,    // 0
            (byte)CharFlags.Digit,    // 1
            (byte)CharFlags.Digit,    // 2
            (byte)CharFlags.Digit,    // 3
            (byte)CharFlags.Digit,    // 4
            (byte)CharFlags.Digit,    // 5
            (byte)CharFlags.Digit,    // 6
            (byte)CharFlags.Digit,    // 7
            (byte)CharFlags.Digit,    // 8
            (byte)CharFlags.Digit,    // 9
            (byte)CharFlags.CompoundPunctStart,  // :
            (byte)CharFlags.Punct,    // ;
            (byte)CharFlags.CompoundPunctStart,  // <
            (byte)CharFlags.CompoundPunctStart,  // =
            (byte)CharFlags.CompoundPunctStart,  // >
            (byte)CharFlags.CompoundPunctStart,  // ?

            // 64 .. 95
            (byte)CharFlags.Complex,  // @
            (byte)CharFlags.Letter,   // A
            (byte)CharFlags.Letter,   // B
            (byte)CharFlags.Letter,   // C
            (byte)CharFlags.Letter,   // D
            (byte)CharFlags.Letter,   // E
            (byte)CharFlags.Letter,   // F
            (byte)CharFlags.Letter,   // G
            (byte)CharFlags.Letter,   // H
            (byte)CharFlags.Letter,   // I
            (byte)CharFlags.Letter,   // J
            (byte)CharFlags.Letter,   // K
            (byte)CharFlags.Letter,   // L
            (byte)CharFlags.Letter,   // M
            (byte)CharFlags.Letter,   // N
            (byte)CharFlags.Letter,   // O
            (byte)CharFlags.Letter,   // P
            (byte)CharFlags.Letter,   // Q
            (byte)CharFlags.Letter,   // R
            (byte)CharFlags.Letter,   // S
            (byte)CharFlags.Letter,   // T
            (byte)CharFlags.Letter,   // U
            (byte)CharFlags.Letter,   // V
            (byte)CharFlags.Letter,   // W
            (byte)CharFlags.Letter,   // X
            (byte)CharFlags.Letter,   // Y
            (byte)CharFlags.Letter,   // Z
            (byte)CharFlags.Punct,    // [
            (byte)CharFlags.Complex,  // \
            (byte)CharFlags.Punct,    // ]
            (byte)CharFlags.CompoundPunctStart,    // ^
            (byte)CharFlags.Letter,   // _

            // 96 .. 127
            (byte)CharFlags.Complex,  // `
            (byte)CharFlags.Letter,   // a
            (byte)CharFlags.Letter,   // b
            (byte)CharFlags.Letter,   // c
            (byte)CharFlags.Letter,   // d
            (byte)CharFlags.Letter,   // e
            (byte)CharFlags.Letter,   // f
            (byte)CharFlags.Letter,   // g
            (byte)CharFlags.Letter,   // h
            (byte)CharFlags.Letter,   // i
            (byte)CharFlags.Letter,   // j
            (byte)CharFlags.Letter,   // k
            (byte)CharFlags.Letter,   // l
            (byte)CharFlags.Letter,   // m
            (byte)CharFlags.Letter,   // n
            (byte)CharFlags.Letter,   // o
            (byte)CharFlags.Letter,   // p
            (byte)CharFlags.Letter,   // q
            (byte)CharFlags.Letter,   // r
            (byte)CharFlags.Letter,   // s
            (byte)CharFlags.Letter,   // t
            (byte)CharFlags.Letter,   // u
            (byte)CharFlags.Letter,   // v
            (byte)CharFlags.Letter,   // w
            (byte)CharFlags.Letter,   // x
            (byte)CharFlags.Letter,   // y
            (byte)CharFlags.Letter,   // z
            (byte)CharFlags.Punct,    // {
            (byte)CharFlags.CompoundPunctStart,  // |
            (byte)CharFlags.Punct,    // }
            (byte)CharFlags.CompoundPunctStart,    // ~
            (byte)CharFlags.Complex,

            // 128 .. 159
            (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex,
            (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex,
            (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex,
            (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex,

            // 160 .. 191
            (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex,
            (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Letter, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex,
            (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Letter, (byte)CharFlags.Complex, (byte)CharFlags.Complex,
            (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Letter, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex, (byte)CharFlags.Complex,

            // 192 .. 
            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter,
            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter,
            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Complex,
            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter,

            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter,
            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter,
            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Complex,
            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter,

            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter,
            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter,
            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter,
            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter,

            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter,
            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter,
            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter,
            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter,

            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter,
            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter,
            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter,
            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter,

            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter,
            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter,
            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter,
            (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter, (byte)CharFlags.Letter
        }; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10014, 2159, 183578);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 2159, 183578);
        }

        private const int
        TriviaListInitialCapacity = 8
        ;

        private readonly CSharpParseOptions _options;

        private LexerMode _mode;

        private readonly StringBuilder _builder;

        private char[] _identBuffer;

        private int _identLen;

        private DirectiveStack _directives;

        private readonly LexerCache _cache;

        private readonly bool _allowPreprocessorDirectives;

        private readonly bool _interpolationFollowedByColon;

        private DocumentationCommentParser _xmlParser;

        private int _badTokenCount;

        internal struct TokenInfo
        {

            internal SyntaxKind Kind;

            internal SyntaxKind ContextualKind;

            internal string Text;

            internal SpecialType ValueKind;

            internal bool RequiresTextForXmlEntity;

            internal bool HasIdentifierEscapeSequence;

            internal string StringValue;

            internal char CharValue;

            internal int IntValue;

            internal uint UintValue;

            internal long LongValue;

            internal ulong UlongValue;

            internal float FloatValue;

            internal double DoubleValue;

            internal decimal DecimalValue;

            internal bool IsVerbatim;
            static TokenInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10014, 2842, 3594);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10014, 2842, 3594);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 2842, 3594);
            }
        }

        static Microsoft.CodeAnalysis.Text.SourceText
f_10014_3768_3772_C(Microsoft.CodeAnalysis.Text.SourceText
i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10014, 3606, 4213);
            return return_v;
        }

        public Lexer(SourceText text, CSharpParseOptions options, bool allowPreprocessorDirectives = true, bool interpolationFollowedByColon = false)
        : base(f_10014_3768_3772_C(text))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10014, 3606, 4213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 2316, 2324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 2355, 2360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 2402, 2410);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 2436, 2448);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 2471, 2480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 2564, 2570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 2603, 2631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 2664, 2693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 2739, 2749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 2772, 2786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 9584, 9631);
                this._leadingTriviaCache = f_10014_9606_9631(10);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 9668, 9716);
                this._trailingTriviaCache = f_10014_9691_9716(10);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 102603, 102634);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10015, 12459, 12484);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 3798, 3828);

                f_10014_3798_3827(options != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 3844, 3863);

                _options = options;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 3877, 3908);

                _builder = f_10014_3888_3907();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 3922, 3950);

                _identBuffer = new char[32];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 3964, 3990);

                _cache = f_10014_3973_3989();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 4004, 4054);

                _createQuickTokenFunction = this.CreateQuickToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 4068, 4127);

                _allowPreprocessorDirectives = allowPreprocessorDirectives;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 4141, 4202);

                _interpolationFollowedByColon = interpolationFollowedByColon;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10014, 3606, 4213);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 3606, 4213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 3606, 4213);
            }

            Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
            f_10014_9691_9716(int
            size)
            {
                var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder(size);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 9691, 9716);
                return return_v;
            }

            Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
            f_10014_9606_9631(int size)
            {
                var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder(size);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 9606, 9631);
                return return_v;
            }

            int
f_10014_3798_3827(bool
condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 3798, 3827);
                return 0;
            }


            System.Text.StringBuilder
            f_10014_3888_3907()
            {
                var return_v = new System.Text.StringBuilder();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 3888, 3907);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerCache
            f_10014_3973_3989()
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerCache();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 3973, 3989);
                return return_v;
            }
        }

        public override void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 4225, 4444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 4280, 4294);

                f_10014_4280_4293(_cache);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 4310, 4402) || true) && (_xmlParser != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 4310, 4402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 4366, 4387);

                    f_10014_4366_4386(_xmlParser);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 4310, 4402);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 4418, 4433);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Dispose(), 10014, 4418, 4432);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 4225, 4444);

                int
                f_10014_4280_4293(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerCache
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 4280, 4293);
                    return 0;
                }


                int
                f_10014_4366_4386(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 4366, 4386);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 4225, 4444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 4225, 4444);
            }
        }

        public bool SuppressDocumentationCommentParse
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 4526, 4594);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 4532, 4592);

                    return f_10014_4539_4565(_options) < DocumentationMode.Parse;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 4526, 4594);

                    Microsoft.CodeAnalysis.DocumentationMode
                    f_10014_4539_4565(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                    this_param)
                    {
                        var return_v = this_param.DocumentationMode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 4539, 4565);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 4456, 4605);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 4456, 4605);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CSharpParseOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 4675, 4699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 4681, 4697);

                    return _options;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 4675, 4699);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 4617, 4710);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 4617, 4710);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public DirectiveStack Directives
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 4779, 4806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 4785, 4804);

                    return _directives;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 4779, 4806);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 4722, 4817);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 4722, 4817);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool InterpolationFollowedByColon
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 5077, 5165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 5113, 5150);

                    return _interpolationFollowedByColon;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 5077, 5165);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 5012, 5176);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 5012, 5176);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void Reset(int position, DirectiveStack directives)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 5188, 5353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 5271, 5303);

                f_10014_5271_5302(this.TextWindow, position);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 5317, 5342);

                _directives = directives;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 5188, 5353);

                int
                f_10014_5271_5302(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                position)
                {
                    this_param.Reset(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 5271, 5302);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 5188, 5353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 5188, 5353);
            }
        }

        private static LexerMode ModeOf(LexerMode mode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10014, 5365, 5484);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 5437, 5473);

                return mode & LexerMode.MaskLexMode;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10014, 5365, 5484);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 5365, 5484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 5365, 5484);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ModeIs(LexerMode mode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 5496, 5596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 5556, 5585);

                return f_10014_5563_5576(_mode) == mode;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 5496, 5596);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                f_10014_5563_5576(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = ModeOf(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 5563, 5576);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 5496, 5596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 5496, 5596);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static XmlDocCommentLocation LocationOf(LexerMode mode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10014, 5608, 5795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 5696, 5784);

                return (XmlDocCommentLocation)((int)(mode & LexerMode.MaskXmlDocCommentLocation) >> 16);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10014, 5608, 5795);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 5608, 5795);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 5608, 5795);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool LocationIs(XmlDocCommentLocation location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 5807, 5935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 5887, 5924);

                return f_10014_5894_5911(_mode) == location;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 5807, 5935);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlDocCommentLocation
                f_10014_5894_5911(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = LocationOf(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 5894, 5911);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 5807, 5935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 5807, 5935);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void MutateLocation(XmlDocCommentLocation location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 5947, 6144);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 6031, 6077);

                _mode &= ~LexerMode.MaskXmlDocCommentLocation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 6091, 6133);

                _mode |= (LexerMode)((int)location << 16);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 5947, 6144);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 5947, 6144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 5947, 6144);
            }
        }

        private static XmlDocCommentStyle StyleOf(LexerMode mode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10014, 6156, 6331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 6238, 6320);

                return (XmlDocCommentStyle)((int)(mode & LexerMode.MaskXmlDocCommentStyle) >> 20);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10014, 6156, 6331);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 6156, 6331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 6156, 6331);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool StyleIs(XmlDocCommentStyle style)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 6343, 6456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 6414, 6445);

                return f_10014_6421_6435(_mode) == style;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 6343, 6456);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlDocCommentStyle
                f_10014_6421_6435(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = StyleOf(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 6421, 6435);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 6343, 6456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 6343, 6456);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool InDocumentationComment
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 6528, 7409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 6564, 7394);

                    switch (f_10014_6572_6585(_mode))
                    {

                        case LexerMode.XmlDocComment:
                        case LexerMode.XmlElementTag:
                        case LexerMode.XmlAttributeTextQuote:
                        case LexerMode.XmlAttributeTextDoubleQuote:
                        case LexerMode.XmlCrefQuote:
                        case LexerMode.XmlCrefDoubleQuote:
                        case LexerMode.XmlNameQuote:
                        case LexerMode.XmlNameDoubleQuote:
                        case LexerMode.XmlCDataSectionText:
                        case LexerMode.XmlCommentText:
                        case LexerMode.XmlProcessingInstructionText:
                        case LexerMode.XmlCharacter:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 6564, 7394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 7294, 7306);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 6564, 7394);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 6564, 7394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 7362, 7375);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 6564, 7394);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 6528, 7409);

                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                    f_10014_6572_6585(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                    mode)
                    {
                        var return_v = ModeOf(mode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 6572, 6585);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 6468, 7420);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 6468, 7420);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxToken Lex(ref LexerMode mode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 7432, 7588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 7499, 7522);

                var
                result = f_10014_7512_7521(this, mode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 7536, 7549);

                mode = _mode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 7563, 7577);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 7432, 7588);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_7512_7521(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = this_param.Lex(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 7512, 7521);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 7432, 7588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 7432, 7588);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int TokensLexed;

        public SyntaxToken Lex(LexerMode mode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 7663, 9546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 7737, 7751);

                TokensLexed++;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 7773, 7786);

                _mode = mode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 7800, 8111);

                switch (_mode)
                {

                    case LexerMode.Syntax:
                    case LexerMode.DebuggerSyntax:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 7800, 8111);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 7939, 7999);

                        return f_10014_7946_7973(this) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(10014, 7946, 7998) ?? f_10014_7977_7998(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 7800, 8111);

                    case LexerMode.Directive:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 7800, 8111);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 8064, 8096);

                        return f_10014_8071_8095(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 7800, 8111);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 8127, 9535);

                switch (f_10014_8135_8148(_mode))
                {

                    case LexerMode.XmlDocComment:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 8127, 9535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 8233, 8259);

                        return f_10014_8240_8258(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 8127, 9535);

                    case LexerMode.XmlElementTag:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 8127, 9535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 8328, 8364);

                        return f_10014_8335_8363(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 8127, 9535);

                    case LexerMode.XmlAttributeTextQuote:
                    case LexerMode.XmlAttributeTextDoubleQuote:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 8127, 9535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 8502, 8541);

                        return f_10014_8509_8540(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 8127, 9535);

                    case LexerMode.XmlCDataSectionText:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 8127, 9535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 8616, 8658);

                        return f_10014_8623_8657(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 8127, 9535);

                    case LexerMode.XmlCommentText:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 8127, 9535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 8728, 8765);

                        return f_10014_8735_8764(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 8127, 9535);

                    case LexerMode.XmlProcessingInstructionText:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 8127, 9535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 8849, 8900);

                        return f_10014_8856_8899(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 8127, 9535);

                    case LexerMode.XmlCrefQuote:
                    case LexerMode.XmlCrefDoubleQuote:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 8127, 9535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 9020, 9056);

                        return f_10014_9027_9055(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 8127, 9535);

                    case LexerMode.XmlNameQuote:
                    case LexerMode.XmlNameDoubleQuote:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 8127, 9535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 9282, 9318);

                        return f_10014_9289_9317(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 8127, 9535);

                    case LexerMode.XmlCharacter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 8127, 9535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 9386, 9416);

                        return f_10014_9393_9415(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 8127, 9535);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 8127, 9535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 9464, 9520);

                        throw f_10014_9470_9519(f_10014_9505_9518(_mode));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 8127, 9535);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 7663, 9546);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_7946_7973(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.QuickScanSyntaxToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 7946, 7973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_7977_7998(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.LexSyntaxToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 7977, 7998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_8071_8095(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.LexDirectiveToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 8071, 8095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                f_10014_8135_8148(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = ModeOf(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 8135, 8148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_8240_8258(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.LexXmlToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 8240, 8258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_8335_8363(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.LexXmlElementTagToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 8335, 8363);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_8509_8540(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.LexXmlAttributeTextToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 8509, 8540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_8623_8657(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.LexXmlCDataSectionTextToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 8623, 8657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_8735_8764(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.LexXmlCommentTextToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 8735, 8764);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_8856_8899(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.LexXmlProcessingInstructionTextToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 8856, 8899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_9027_9055(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.LexXmlCrefOrNameToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 9027, 9055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_9289_9317(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.LexXmlCrefOrNameToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 9289, 9317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_9393_9415(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.LexXmlCharacter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 9393, 9415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                f_10014_9505_9518(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = ModeOf(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 9505, 9518);
                    return return_v;
                }


                System.Exception
                f_10014_9470_9519(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 9470, 9519);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 7663, 9546);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 7663, 9546);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxListBuilder _leadingTriviaCache;

        private SyntaxListBuilder _trailingTriviaCache;

        private static int GetFullWidth(SyntaxListBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10014, 9729, 10079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 9812, 9826);

                int
                width = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 9842, 10039) || true) && (builder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 9842, 10039);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 9904, 9909);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 9895, 10024) || true) && (i < f_10014_9915_9928(builder))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 9930, 9933)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 9895, 10024))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 9895, 10024);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 9975, 10005);

                            width += f_10014_9984_10004(f_10014_9984_9994(builder, i));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10014, 1, 130);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10014, 1, 130);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 9842, 10039);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 10055, 10068);

                return width;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10014, 9729, 10079);

                int
                f_10014_9915_9928(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 9915, 9928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_10014_9984_9994(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 9984, 9994);
                    return return_v;
                }


                int
                f_10014_9984_10004(Microsoft.CodeAnalysis.GreenNode?
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 9984, 10004);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 9729, 10079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 9729, 10079);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxToken LexSyntaxToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 10091, 10848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 10152, 10180);

                f_10014_10152_10179(_leadingTriviaCache);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 10194, 10313);

                f_10014_10194_10312(this, afterFirstToken: f_10014_10232_10251(TextWindow) > 0, isTrailing: false, triviaList: ref _leadingTriviaCache);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 10327, 10361);

                var
                leading = _leadingTriviaCache
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 10377, 10412);

                var
                tokenInfo = default(TokenInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 10428, 10441);

                f_10014_10428_10440(
                            this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 10455, 10491);

                f_10014_10455_10490(this, ref tokenInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 10505, 10556);

                var
                errors = f_10014_10518_10555(this, f_10014_10533_10554(leading))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 10572, 10601);

                f_10014_10572_10600(
                            _trailingTriviaCache);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 10615, 10715);

                f_10014_10615_10714(this, afterFirstToken: true, isTrailing: true, triviaList: ref _trailingTriviaCache);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 10729, 10765);

                var
                trailing = _trailingTriviaCache
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 10781, 10837);

                return f_10014_10788_10836(this, ref tokenInfo, leading, trailing, errors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 10091, 10848);

                int
                f_10014_10152_10179(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 10152, 10179);
                    return 0;
                }


                int
                f_10014_10232_10251(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 10232, 10251);
                    return return_v;
                }


                int
                f_10014_10194_10312(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, bool
                afterFirstToken, bool
                isTrailing, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                triviaList)
                {
                    // LAFHIS
                    //this_param.LexSyntaxTrivia(afterFirstToken: afterFirstToken, isTrailing: isTrailing, ref triviaList: triviaList);
                    this_param.LexSyntaxTrivia(afterFirstToken, isTrailing, ref triviaList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 10194, 10312);
                    return 0;
                }

                int
f_10014_10428_10440(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 10428, 10440);
                    return 0;
                }


                int
                f_10014_10455_10490(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info)
                {
                    this_param.ScanSyntaxToken(ref info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 10455, 10490);
                    return 0;
                }


                int
                f_10014_10533_10554(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                builder)
                {
                    var return_v = GetFullWidth(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 10533, 10554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
                f_10014_10518_10555(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, int
                leadingTriviaWidth)
                {
                    var return_v = this_param.GetErrors(leadingTriviaWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 10518, 10555);
                    return return_v;
                }


                int
                f_10014_10572_10600(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 10572, 10600);
                    return 0;
                }


                int
                f_10014_10615_10714(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, bool
                afterFirstToken, bool
                isTrailing, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                triviaList)
                {
                    // LAFHIS
                    //this_param.LexSyntaxTrivia(afterFirstToken: afterFirstToken, isTrailing: isTrailing, ref triviaList:triviaList);
                    this_param.LexSyntaxTrivia(afterFirstToken, isTrailing, ref triviaList);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 10615, 10714);
                    return 0;
                }

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
        f_10014_10788_10836(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
        this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
        info, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
        leading, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
        trailing, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
        errors)
                {
                    var return_v = this_param.Create(ref info, leading, trailing, errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 10788, 10836);
                    return return_v;
                }
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 10091, 10848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 10091, 10848);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxTriviaList LexSyntaxLeadingTrivia()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 10860, 11268);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 10935, 10963);

                f_10014_10935_10962(_leadingTriviaCache);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 10977, 11096);

                f_10014_10977_11095(this, afterFirstToken: f_10014_11015_11034(TextWindow) > 0, isTrailing: false, triviaList: ref _leadingTriviaCache);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 11110, 11257);

                return f_10014_11117_11256(default(Microsoft.CodeAnalysis.SyntaxToken), f_10014_11200_11232(_leadingTriviaCache), position: 0, index: 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 10860, 11268);

                int
                f_10014_10935_10962(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 10935, 10962);
                    return 0;
                }


                int
                f_10014_11015_11034(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 11015, 11034);
                    return return_v;
                }


                int
                f_10014_10977_11095(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, bool
                afterFirstToken, bool
                isTrailing, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                triviaList)
                {
                    // LAFHIS
                    //this_param.LexSyntaxTrivia(afterFirstToken: afterFirstToken, isTrailing: isTrailing, ref triviaList:triviaList);
                    this_param.LexSyntaxTrivia(afterFirstToken, isTrailing, ref triviaList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 10977, 11095);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_10014_11200_11232(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.ToListNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 11200, 11232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10014_11117_11256(Microsoft.CodeAnalysis.SyntaxToken
                token, Microsoft.CodeAnalysis.GreenNode?
                node, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList(token, node, position: position, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 11117, 11256);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 10860, 11268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 10860, 11268);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxTriviaList LexSyntaxTrailingTrivia()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 11280, 11672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 11356, 11385);

                f_10014_11356_11384(_trailingTriviaCache);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 11399, 11499);

                f_10014_11399_11498(this, afterFirstToken: true, isTrailing: true, triviaList: ref _trailingTriviaCache);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 11513, 11661);

                return f_10014_11520_11660(default(Microsoft.CodeAnalysis.SyntaxToken), f_10014_11603_11636(_trailingTriviaCache), position: 0, index: 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 11280, 11672);

                int
                f_10014_11356_11384(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 11356, 11384);
                    return 0;
                }


                int
                f_10014_11399_11498(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, bool
                afterFirstToken, bool
                isTrailing, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                triviaList)
                {
                    // LAFHIS
                    //this_param.LexSyntaxTrivia(afterFirstToken: afterFirstToken, isTrailing: isTrailing, ref triviaList:triviaList);
                    this_param.LexSyntaxTrivia(afterFirstToken, isTrailing, ref triviaList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 11399, 11498);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_10014_11603_11636(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.ToListNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 11603, 11636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10014_11520_11660(Microsoft.CodeAnalysis.SyntaxToken
                token, Microsoft.CodeAnalysis.GreenNode?
                node, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList(token, node, position: position, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 11520, 11660);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 11280, 11672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 11280, 11672);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxToken Create(ref TokenInfo info, SyntaxListBuilder leading, SyntaxListBuilder trailing, SyntaxDiagnosticInfo[] errors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 11684, 16772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 11841, 11923);

                f_10014_11841_11922(info.Kind != SyntaxKind.IdentifierToken || (DynAbs.Tracing.TraceSender.Expression_False(10014, 11854, 11921) || info.StringValue != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 11939, 11979);

                var
                leadingNode = f_10014_11965_11978(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(leading, 10014, 11957, 11978))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 11993, 12035);

                var
                trailingNode = f_10014_12021_12034(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(trailing, 10014, 12012, 12034))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 12051, 12069);

                SyntaxToken
                token
                = default(SyntaxToken);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 12083, 16517) || true) && (info.RequiresTextForXmlEntity)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 12083, 16517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 12150, 12245);

                    token = f_10014_12158_12244(leadingNode, info.Kind, info.Text, info.StringValue, trailingNode);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 12083, 16517);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 12083, 16517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 12311, 16502);

                    switch (info.Kind)
                    {

                        case SyntaxKind.IdentifierToken:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 12311, 16502);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 12428, 12538);

                            token = f_10014_12436_12537(info.ContextualKind, leadingNode, info.Text, info.StringValue, trailingNode);
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 12564, 12570);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 12311, 16502);

                        case SyntaxKind.NumericLiteralToken:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 12311, 16502);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 12654, 14398);

                            switch (info.ValueKind)
                            {

                                case SpecialType.System_Int32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 12654, 14398);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 12798, 12881);

                                    token = f_10014_12806_12880(leadingNode, info.Text, info.IntValue, trailingNode);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10014, 12915, 12921);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 12654, 14398);

                                case SpecialType.System_UInt32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 12654, 14398);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 13016, 13100);

                                    token = f_10014_13024_13099(leadingNode, info.Text, info.UintValue, trailingNode);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10014, 13134, 13140);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 12654, 14398);

                                case SpecialType.System_Int64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 12654, 14398);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 13234, 13318);

                                    token = f_10014_13242_13317(leadingNode, info.Text, info.LongValue, trailingNode);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10014, 13352, 13358);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 12654, 14398);

                                case SpecialType.System_UInt64:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 12654, 14398);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 13453, 13538);

                                    token = f_10014_13461_13537(leadingNode, info.Text, info.UlongValue, trailingNode);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10014, 13572, 13578);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 12654, 14398);

                                case SpecialType.System_Single:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 12654, 14398);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 13673, 13758);

                                    token = f_10014_13681_13757(leadingNode, info.Text, info.FloatValue, trailingNode);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10014, 13792, 13798);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 12654, 14398);

                                case SpecialType.System_Double:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 12654, 14398);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 13893, 13979);

                                    token = f_10014_13901_13978(leadingNode, info.Text, info.DoubleValue, trailingNode);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10014, 14013, 14019);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 12654, 14398);

                                case SpecialType.System_Decimal:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 12654, 14398);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 14115, 14202);

                                    token = f_10014_14123_14201(leadingNode, info.Text, info.DecimalValue, trailingNode);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10014, 14236, 14242);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 12654, 14398);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 12654, 14398);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 14314, 14371);

                                    throw f_10014_14320_14370(info.ValueKind);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 12654, 14398);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 14426, 14432);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 12311, 16502);

                        case SyntaxKind.InterpolatedStringToken:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 12311, 16502);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 14658, 14748);

                            token = f_10014_14666_14747(leadingNode, info.Text, info.Kind, info.Text, trailingNode);
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 14774, 14780);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 12311, 16502);

                        case SyntaxKind.StringLiteralToken:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 12311, 16502);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 14863, 14960);

                            token = f_10014_14871_14959(leadingNode, info.Text, info.Kind, info.StringValue, trailingNode);
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 14986, 14992);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 12311, 16502);

                        case SyntaxKind.CharacterLiteralToken:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 12311, 16502);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 15078, 15162);

                            token = f_10014_15086_15161(leadingNode, info.Text, info.CharValue, trailingNode);
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 15188, 15194);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 12311, 16502);

                        case SyntaxKind.XmlTextLiteralNewLineToken:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 12311, 16502);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 15285, 15378);

                            token = f_10014_15293_15377(leadingNode, info.Text, info.StringValue, trailingNode);
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 15404, 15410);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 12311, 16502);

                        case SyntaxKind.XmlTextLiteralToken:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 12311, 16502);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 15494, 15587);

                            token = f_10014_15502_15586(leadingNode, info.Text, info.StringValue, trailingNode);
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 15613, 15619);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 12311, 16502);

                        case SyntaxKind.XmlEntityLiteralToken:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 12311, 16502);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 15705, 15793);

                            token = f_10014_15713_15792(leadingNode, info.Text, info.StringValue, trailingNode);
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 15819, 15825);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 12311, 16502);

                        case SyntaxKind.EndOfDocumentationCommentToken:
                        case SyntaxKind.EndOfFileToken:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 12311, 16502);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 15973, 16039);

                            token = f_10014_15981_16038(leadingNode, info.Kind, trailingNode);
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 16065, 16071);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 12311, 16502);

                        case SyntaxKind.None:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 12311, 16502);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 16140, 16209);

                            token = f_10014_16148_16208(leadingNode, info.Text, trailingNode);
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 16235, 16241);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 12311, 16502);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 12311, 16502);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 16299, 16359);

                            f_10014_16299_16358(f_10014_16312_16357(info.Kind));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 16385, 16451);

                            token = f_10014_16393_16450(leadingNode, info.Kind, trailingNode);
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 16477, 16483);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 12311, 16502);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 12083, 16517);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 16533, 16732) || true) && (errors != null && (DynAbs.Tracing.TraceSender.Expression_True(10014, 16537, 16640) && (f_10014_16556_16582(_options) >= DocumentationMode.Diagnose || (DynAbs.Tracing.TraceSender.Expression_False(10014, 16556, 16639) || f_10014_16616_16639_M(!InDocumentationComment)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 16533, 16732);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 16674, 16717);

                    token = f_10014_16682_16716(token, errors);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 16533, 16732);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 16748, 16761);

                return token;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 11684, 16772);

                int
                f_10014_11841_11922(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 11841, 11922);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_10014_11965_11978(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param?.ToListNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 11965, 11978);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_10014_12021_12034(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param?.ToListNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 12021, 12034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_12158_12244(Microsoft.CodeAnalysis.GreenNode?
                leading, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                text, string
                valueText, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = SyntaxFactory.Token(leading, kind, text, valueText, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 12158, 12244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_12436_12537(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                contextualKind, Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, string
                valueText, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = SyntaxFactory.Identifier(contextualKind, leading, text, valueText, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 12436, 12537);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_12806_12880(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, int
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 12806, 12880);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_13024_13099(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, uint
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 13024, 13099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_13242_13317(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, long
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 13242, 13317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_13461_13537(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, ulong
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 13461, 13537);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_13681_13757(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, float
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 13681, 13757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_13901_13978(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, double
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 13901, 13978);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_14123_14201(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, decimal
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 14123, 14201);
                    return return_v;
                }


                System.Exception
                f_10014_14320_14370(Microsoft.CodeAnalysis.SpecialType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 14320, 14370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_14666_14747(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = SyntaxFactory.Literal(leading, text, kind, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 14666, 14747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_14871_14959(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, string
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = SyntaxFactory.Literal(leading, text, kind, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 14871, 14959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_15086_15161(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, char
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = SyntaxFactory.Literal(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 15086, 15161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_15293_15377(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, string
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = SyntaxFactory.XmlTextNewLine(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 15293, 15377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_15502_15586(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, string
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = SyntaxFactory.XmlTextLiteral(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 15502, 15586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_15713_15792(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, string
                value, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = SyntaxFactory.XmlEntity(leading, text, value, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 15713, 15792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_15981_16038(Microsoft.CodeAnalysis.GreenNode?
                leading, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = SyntaxFactory.Token(leading, kind, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 15981, 16038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_16148_16208(Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = SyntaxFactory.BadToken(leading, text, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 16148, 16208);
                    return return_v;
                }


                bool
                f_10014_16312_16357(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsPunctuationOrKeyword(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 16312, 16357);
                    return return_v;
                }


                int
                f_10014_16299_16358(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 16299, 16358);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_16393_16450(Microsoft.CodeAnalysis.GreenNode?
                leading, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = SyntaxFactory.Token(leading, kind, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 16393, 16450);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DocumentationMode
                f_10014_16556_16582(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.DocumentationMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 16556, 16582);
                    return return_v;
                }


                bool
                f_10014_16616_16639_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 16616, 16639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_16682_16716(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
                diagnostics)
                {
                    var return_v = node.WithDiagnosticsGreen<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>((Microsoft.CodeAnalysis.DiagnosticInfo[])diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 16682, 16716);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 11684, 16772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 11684, 16772);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ScanSyntaxToken(ref TokenInfo info)
        {
            // Initialize for new token scan
            info.Kind = SyntaxKind.None;
            info.ContextualKind = SyntaxKind.None;
            info.Text = null;
            char character;
            char surrogateCharacter = SlidingTextWindow.InvalidCharacter;
            bool isEscaped = false;
            int startingPosition = TextWindow.Position;

            // Start scanning the token
            character = TextWindow.PeekChar();
            switch (character)
            {
                case '\"':
                case '\'':
                    this.ScanStringLiteral(ref info);
                    break;

                case '/':
                    TextWindow.AdvanceChar();
                    if (TextWindow.PeekChar() == '=')
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.SlashEqualsToken;
                    }
                    else
                    {
                        info.Kind = SyntaxKind.SlashToken;
                    }

                    break;

                case '.':
                    if (!this.ScanNumericLiteral(ref info))
                    {
                        TextWindow.AdvanceChar();
                        if (TextWindow.PeekChar() == '.')
                        {
                            TextWindow.AdvanceChar();
                            if (TextWindow.PeekChar() == '.')
                            {
                                // Triple-dot: explicitly reject this, to allow triple-dot
                                // to be added to the language without a breaking change.
                                // (without this, 0...2 would parse as (0)..(.2), i.e. a range from 0 to 0.2)
                                this.AddError(ErrorCode.ERR_TripleDotNotAllowed);
                            }

                            info.Kind = SyntaxKind.DotDotToken;
                        }
                        else
                        {
                            info.Kind = SyntaxKind.DotToken;
                        }
                    }

                    break;

                case ',':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.CommaToken;
                    break;

                case ':':
                    TextWindow.AdvanceChar();
                    if (TextWindow.PeekChar() == ':')
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.ColonColonToken;
                    }
                    else
                    {
                        info.Kind = SyntaxKind.ColonToken;
                    }

                    break;

                case ';':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.SemicolonToken;
                    break;

                case '~':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.TildeToken;
                    break;

                case '!':
                    TextWindow.AdvanceChar();
                    if (TextWindow.PeekChar() == '=')
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.ExclamationEqualsToken;
                    }
                    else
                    {
                        info.Kind = SyntaxKind.ExclamationToken;
                    }

                    break;

                case '=':
                    TextWindow.AdvanceChar();
                    if ((character = TextWindow.PeekChar()) == '=')
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.EqualsEqualsToken;
                    }
                    else if (character == '>')
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.EqualsGreaterThanToken;
                    }
                    else
                    {
                        info.Kind = SyntaxKind.EqualsToken;
                    }

                    break;

                case '*':
                    TextWindow.AdvanceChar();
                    if (TextWindow.PeekChar() == '=')
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.AsteriskEqualsToken;
                    }
                    else
                    {
                        info.Kind = SyntaxKind.AsteriskToken;
                    }

                    break;

                case '(':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.OpenParenToken;
                    break;

                case ')':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.CloseParenToken;
                    break;

                case '{':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.OpenBraceToken;
                    break;

                case '}':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.CloseBraceToken;
                    break;

                case '[':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.OpenBracketToken;
                    break;

                case ']':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.CloseBracketToken;
                    break;

                case '?':
                    TextWindow.AdvanceChar();
                    if (TextWindow.PeekChar() == '?')
                    {
                        TextWindow.AdvanceChar();

                        if (TextWindow.PeekChar() == '=')
                        {
                            TextWindow.AdvanceChar();
                            info.Kind = SyntaxKind.QuestionQuestionEqualsToken;
                        }
                        else
                        {
                            info.Kind = SyntaxKind.QuestionQuestionToken;
                        }
                    }
                    else
                    {
                        info.Kind = SyntaxKind.QuestionToken;
                    }

                    break;

                case '+':
                    TextWindow.AdvanceChar();
                    if ((character = TextWindow.PeekChar()) == '=')
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.PlusEqualsToken;
                    }
                    else if (character == '+')
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.PlusPlusToken;
                    }
                    else
                    {
                        info.Kind = SyntaxKind.PlusToken;
                    }

                    break;

                case '-':
                    TextWindow.AdvanceChar();
                    if ((character = TextWindow.PeekChar()) == '=')
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.MinusEqualsToken;
                    }
                    else if (character == '-')
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.MinusMinusToken;
                    }
                    else if (character == '>')
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.MinusGreaterThanToken;
                    }
                    else
                    {
                        info.Kind = SyntaxKind.MinusToken;
                    }

                    break;

                case '%':
                    TextWindow.AdvanceChar();
                    if (TextWindow.PeekChar() == '=')
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.PercentEqualsToken;
                    }
                    else
                    {
                        info.Kind = SyntaxKind.PercentToken;
                    }

                    break;

                case '&':
                    TextWindow.AdvanceChar();
                    if ((character = TextWindow.PeekChar()) == '=')
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.AmpersandEqualsToken;
                    }
                    else if (TextWindow.PeekChar() == '&')
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.AmpersandAmpersandToken;
                    }
                    else
                    {
                        info.Kind = SyntaxKind.AmpersandToken;
                    }

                    break;

                case '^':
                    TextWindow.AdvanceChar();
                    if (TextWindow.PeekChar() == '=')
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.CaretEqualsToken;
                    }
                    else
                    {
                        info.Kind = SyntaxKind.CaretToken;
                    }

                    break;

                case '|':
                    TextWindow.AdvanceChar();
                    if (TextWindow.PeekChar() == '=')
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.BarEqualsToken;
                    }
                    else if (TextWindow.PeekChar() == '|')
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.BarBarToken;
                    }
                    else
                    {
                        info.Kind = SyntaxKind.BarToken;
                    }

                    break;

                case '<':
                    TextWindow.AdvanceChar();
                    if (TextWindow.PeekChar() == '=')
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.LessThanEqualsToken;
                    }
                    else if (TextWindow.PeekChar() == '<')
                    {
                        TextWindow.AdvanceChar();
                        if (TextWindow.PeekChar() == '=')
                        {
                            TextWindow.AdvanceChar();
                            info.Kind = SyntaxKind.LessThanLessThanEqualsToken;
                        }
                        else
                        {
                            info.Kind = SyntaxKind.LessThanLessThanToken;
                        }
                    }
                    else
                    {
                        info.Kind = SyntaxKind.LessThanToken;
                    }

                    break;

                case '>':
                    TextWindow.AdvanceChar();
                    if (TextWindow.PeekChar() == '=')
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.GreaterThanEqualsToken;
                    }
                    else
                    {
                        info.Kind = SyntaxKind.GreaterThanToken;
                    }

                    break;

                case '@':
                    if (TextWindow.PeekChar(1) == '"')
                    {
                        this.ScanVerbatimStringLiteral(ref info);
                    }
                    else if (TextWindow.PeekChar(1) == '$' && TextWindow.PeekChar(2) == '"')
                    {
                        this.ScanInterpolatedStringLiteral(isVerbatim: true, ref info);
                        CheckFeatureAvailability(MessageID.IDS_FeatureAltInterpolatedVerbatimStrings);
                        break;
                    }
                    else if (!this.ScanIdentifierOrKeyword(ref info))
                    {
                        TextWindow.AdvanceChar();
                        info.Text = TextWindow.GetText(intern: true);
                        this.AddError(ErrorCode.ERR_ExpectedVerbatimLiteral);
                    }

                    break;

                case '$':
                    if (TextWindow.PeekChar(1) == '"')
                    {
                        this.ScanInterpolatedStringLiteral(isVerbatim: false, ref info);
                        CheckFeatureAvailability(MessageID.IDS_FeatureInterpolatedStrings);
                        break;
                    }
                    else if (TextWindow.PeekChar(1) == '@' && TextWindow.PeekChar(2) == '"')
                    {
                        this.ScanInterpolatedStringLiteral(isVerbatim: true, ref info);
                        CheckFeatureAvailability(MessageID.IDS_FeatureInterpolatedStrings);
                        break;
                    }
                    else if (this.ModeIs(LexerMode.DebuggerSyntax))
                    {
                        goto case 'a';
                    }

                    goto default;

                // All the 'common' identifier characters are represented directly in
                // these switch cases for optimal perf.  Calling IsIdentifierChar() functions is relatively
                // expensive.
                case 'a':
                case 'b':
                case 'c':
                case 'd':
                case 'e':
                case 'f':
                case 'g':
                case 'h':
                case 'i':
                case 'j':
                case 'k':
                case 'l':
                case 'm':
                case 'n':
                case 'o':
                case 'p':
                case 'q':
                case 'r':
                case 's':
                case 't':
                case 'u':
                case 'v':
                case 'w':
                case 'x':
                case 'y':
                case 'z':
                case 'A':
                case 'B':
                case 'C':
                case 'D':
                case 'E':
                case 'F':
                case 'G':
                case 'H':
                case 'I':
                case 'J':
                case 'K':
                case 'L':
                case 'M':
                case 'N':
                case 'O':
                case 'P':
                case 'Q':
                case 'R':
                case 'S':
                case 'T':
                case 'U':
                case 'V':
                case 'W':
                case 'X':
                case 'Y':
                case 'Z':
                case '_':
                    this.ScanIdentifierOrKeyword(ref info);
                    break;

                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    this.ScanNumericLiteral(ref info);
                    break;

                case '\\':
                    {
                        // Could be unicode escape. Try that.
                        character = TextWindow.PeekCharOrUnicodeEscape(out surrogateCharacter);

                        isEscaped = true;
                        if (SyntaxFacts.IsIdentifierStartCharacter(character))
                        {
                            goto case 'a';
                        }

                        goto default;
                    }

                case SlidingTextWindow.InvalidCharacter:
                    if (!TextWindow.IsReallyAtEnd())
                    {
                        goto default;
                    }

                    if (_directives.HasUnfinishedIf())
                    {
                        this.AddError(ErrorCode.ERR_EndifDirectiveExpected);
                    }

                    if (_directives.HasUnfinishedRegion())
                    {
                        this.AddError(ErrorCode.ERR_EndRegionDirectiveExpected);
                    }

                    info.Kind = SyntaxKind.EndOfFileToken;
                    break;

                default:
                    if (SyntaxFacts.IsIdentifierStartCharacter(character))
                    {
                        goto case 'a';
                    }

                    if (isEscaped)
                    {
                        SyntaxDiagnosticInfo error;
                        TextWindow.NextCharOrUnicodeEscape(out surrogateCharacter, out error);
                        AddError(error);
                    }
                    else
                    {
                        TextWindow.AdvanceChar();
                    }

                    if (_badTokenCount++ > 200)
                    {
                        // If we get too many characters that we cannot make sense of, absorb the rest of the input.
                        int end = TextWindow.Text.Length;
                        int width = end - startingPosition;
                        info.Text = TextWindow.Text.ToString(new TextSpan(startingPosition, width));
                        TextWindow.Reset(end);
                    }
                    else
                    {
                        info.Text = TextWindow.GetText(intern: true);
                    }

                    this.AddError(ErrorCode.ERR_UnexpectedCharacter, info.Text);
                    break;
            }
        }

        private void CheckFeatureAvailability(MessageID feature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 35211, 35483);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 35292, 35357);

                var
                info = f_10014_35303_35356(feature, f_10014_35348_35355())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 35371, 35472) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 35371, 35472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 35421, 35457);

                    f_10014_35421_35456(this, f_10014_35430_35439(info), f_10014_35441_35455(info));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 35371, 35472);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 35211, 35483);

                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10014_35348_35355()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 35348, 35355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo?
                f_10014_35303_35356(Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options)
                {
                    var return_v = feature.GetFeatureAvailabilityDiagnosticInfo(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 35303, 35356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10014_35430_35439(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 35430, 35439);
                    return return_v;
                }


                object[]
                f_10014_35441_35455(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 35441, 35455);
                    return return_v;
                }


                int
                f_10014_35421_35456(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    this_param.AddError(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 35421, 35456);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 35211, 35483);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 35211, 35483);
            }
        }

        private bool ScanInteger()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 35514, 35824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 35565, 35597);

                int
                start = f_10014_35577_35596(TextWindow)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 35611, 35619);

                char
                ch
                = default(char);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 35633, 35762) || true) && ((ch = f_10014_35646_35667(TextWindow)) >= '0' && (DynAbs.Tracing.TraceSender.Expression_True(10014, 35640, 35688) && ch <= '9'))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 35633, 35762);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 35722, 35747);

                        f_10014_35722_35746(TextWindow);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 35633, 35762);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10014, 35633, 35762);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10014, 35633, 35762);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 35778, 35813);

                return start < f_10014_35793_35812(TextWindow);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 35514, 35824);

                int
                f_10014_35577_35596(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 35577, 35596);
                    return return_v;
                }


                char
                f_10014_35646_35667(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 35646, 35667);
                    return return_v;
                }


                int
                f_10014_35722_35746(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 35722, 35746);
                    return 0;
                }


                int
                f_10014_35793_35812(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 35793, 35812);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 35514, 35824);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 35514, 35824);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ScanNumericLiteralSingleInteger(ref bool underscoreInWrongPlace, ref bool usedUnderscore, ref bool firstCharWasUnderscore, bool isHex, bool isBinary)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 35920, 37321);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 36107, 36412) || true) && (f_10014_36111_36132(TextWindow) == '_')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 36107, 36412);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 36173, 36397) || true) && (isHex || (DynAbs.Tracing.TraceSender.Expression_False(10014, 36177, 36194) || isBinary))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 36173, 36397);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 36236, 36266);

                        firstCharWasUnderscore = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 36173, 36397);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 36173, 36397);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 36348, 36378);

                        underscoreInWrongPlace = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 36173, 36397);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 36107, 36412);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 36428, 36463);

                bool
                lastCharWasUnderscore = false
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 36477, 37190) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 36477, 37190);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 36522, 36554);

                        char
                        ch = f_10014_36532_36553(TextWindow)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 36572, 37132) || true) && (ch == '_')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 36572, 37132);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 36627, 36649);

                            usedUnderscore = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 36671, 36700);

                            lastCharWasUnderscore = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 36572, 37132);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 36572, 37132);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 36742, 37132) || true) && (!((DynAbs.Tracing.TraceSender.Conditional_F1(10014, 36748, 36753) || ((isHex && DynAbs.Tracing.TraceSender.Conditional_F2(10014, 36756, 36782)) || DynAbs.Tracing.TraceSender.Conditional_F3(10014, 36813, 36910))) ? f_10014_36756_36782(ch) : (DynAbs.Tracing.TraceSender.Conditional_F1(10014, 36813, 36821) || ((isBinary && DynAbs.Tracing.TraceSender.Conditional_F2(10014, 36824, 36853)) || DynAbs.Tracing.TraceSender.Conditional_F3(10014, 36884, 36910))) ? f_10014_36824_36853(ch) : f_10014_36884_36910(ch)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 36742, 37132);
                                DynAbs.Tracing.TraceSender.TraceBreak(10014, 36953, 36959);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 36742, 37132);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 36742, 37132);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 37041, 37061);

                                f_10014_37041_37060(_builder, ch);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 37083, 37113);

                                lastCharWasUnderscore = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 36742, 37132);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 36572, 37132);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 37150, 37175);

                        f_10014_37150_37174(TextWindow);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 36477, 37190);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10014, 36477, 37190);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10014, 36477, 37190);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 37206, 37310) || true) && (lastCharWasUnderscore)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 37206, 37310);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 37265, 37295);

                    underscoreInWrongPlace = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 37206, 37310);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 35920, 37321);

                char
                f_10014_36111_36132(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 36111, 36132);
                    return return_v;
                }


                char
                f_10014_36532_36553(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 36532, 36553);
                    return return_v;
                }


                bool
                f_10014_36756_36782(char
                c)
                {
                    var return_v = SyntaxFacts.IsHexDigit(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 36756, 36782);
                    return return_v;
                }


                bool
                f_10014_36824_36853(char
                c)
                {
                    var return_v = SyntaxFacts.IsBinaryDigit(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 36824, 36853);
                    return return_v;
                }


                bool
                f_10014_36884_36910(char
                c)
                {
                    var return_v = SyntaxFacts.IsDecDigit(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 36884, 36910);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10014_37041_37060(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 37041, 37060);
                    return return_v;
                }


                int
                f_10014_37150_37174(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 37150, 37174);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 35920, 37321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 35920, 37321);
            }
        }

        private bool ScanNumericLiteral(ref TokenInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 37333, 51664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 37409, 37441);

                int
                start = f_10014_37421_37440(TextWindow)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 37455, 37463);

                char
                ch
                = default(char);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 37477, 37496);

                bool
                isHex = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 37510, 37532);

                bool
                isBinary = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 37546, 37570);

                bool
                hasDecimal = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 37584, 37609);

                bool
                hasExponent = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 37623, 37640);

                info.Text = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 37654, 37688);

                info.ValueKind = SpecialType.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 37702, 37719);

                f_10014_37702_37718(_builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 37733, 37757);

                bool
                hasUSuffix = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 37771, 37795);

                bool
                hasLSuffix = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 37809, 37845);

                bool
                underscoreInWrongPlace = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 37859, 37887);

                bool
                usedUnderscore = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 37901, 37937);

                bool
                firstCharWasUnderscore = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 37953, 37980);

                ch = f_10014_37958_37979(TextWindow);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 37994, 38507) || true) && (ch == '0')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 37994, 38507);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 38041, 38069);

                    ch = f_10014_38046_38068(TextWindow, 1);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 38087, 38492) || true) && (ch == 'x' || (DynAbs.Tracing.TraceSender.Expression_False(10014, 38091, 38113) || ch == 'X'))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 38087, 38492);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 38155, 38181);

                        f_10014_38155_38180(TextWindow, 2);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 38203, 38216);

                        isHex = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 38087, 38492);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 38087, 38492);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 38258, 38492) || true) && (ch == 'b' || (DynAbs.Tracing.TraceSender.Expression_False(10014, 38262, 38284) || ch == 'B'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 38258, 38492);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 38326, 38387);

                            f_10014_38326_38386(this, MessageID.IDS_FeatureBinaryLiteral);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 38409, 38435);

                            f_10014_38409_38434(TextWindow, 2);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 38457, 38473);

                            isBinary = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 38258, 38492);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 38087, 38492);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 37994, 38507);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 38523, 45101) || true) && (isHex || (DynAbs.Tracing.TraceSender.Expression_False(10014, 38527, 38544) || isBinary))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 38523, 45101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 38731, 38856);

                    f_10014_38731_38855(this, ref underscoreInWrongPlace, ref usedUnderscore, ref firstCharWasUnderscore, isHex, isBinary);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 38876, 39869) || true) && ((ch = f_10014_38886_38907(TextWindow)) == 'L' || (DynAbs.Tracing.TraceSender.Expression_False(10014, 38880, 38928) || ch == 'l'))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 38876, 39869);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 38970, 39128) || true) && (ch == 'l')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 38970, 39128);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 39033, 39105);

                            f_10014_39033_39104(this, f_10014_39047_39066(TextWindow), 1, ErrorCode.WRN_LowercaseEllSuffix);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 38970, 39128);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 39152, 39177);

                        f_10014_39152_39176(
                                            TextWindow);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 39199, 39217);

                        hasLSuffix = true;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 39239, 39433) || true) && ((ch = f_10014_39249_39270(TextWindow)) == 'u' || (DynAbs.Tracing.TraceSender.Expression_False(10014, 39243, 39291) || ch == 'U'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 39239, 39433);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 39341, 39366);

                            f_10014_39341_39365(TextWindow);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 39392, 39410);

                            hasUSuffix = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 39239, 39433);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 38876, 39869);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 38876, 39869);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 39475, 39869) || true) && ((ch = f_10014_39485_39506(TextWindow)) == 'u' || (DynAbs.Tracing.TraceSender.Expression_False(10014, 39479, 39527) || ch == 'U'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 39475, 39869);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 39569, 39594);

                            f_10014_39569_39593(TextWindow);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 39616, 39634);

                            hasUSuffix = true;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 39656, 39850) || true) && ((ch = f_10014_39666_39687(TextWindow)) == 'L' || (DynAbs.Tracing.TraceSender.Expression_False(10014, 39660, 39708) || ch == 'l'))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 39656, 39850);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 39758, 39783);

                                f_10014_39758_39782(TextWindow);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 39809, 39827);

                                hasLSuffix = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 39656, 39850);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 39475, 39869);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 38876, 39869);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 38523, 45101);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 38523, 45101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 39935, 40074);

                    f_10014_39935_40073(this, ref underscoreInWrongPlace, ref usedUnderscore, ref firstCharWasUnderscore, isHex: false, isBinary: false);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 40094, 40608) || true) && (f_10014_40098_40135(this, LexerMode.DebuggerSyntax) && (DynAbs.Tracing.TraceSender.Expression_True(10014, 40098, 40167) && f_10014_40139_40160(TextWindow) == '#'))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 40094, 40608);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 40300, 40325);

                        f_10014_40300_40324(                    // Previously, in DebuggerSyntax mode, "123#" was a valid identifier.
                                            TextWindow);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 40347, 40411);

                        info.StringValue = info.Text = f_10014_40378_40410(TextWindow, intern: true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 40433, 40472);

                        info.Kind = SyntaxKind.IdentifierToken;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 40494, 40555);

                        f_10014_40494_40554(this, f_10014_40508_40553(ErrorCode.ERR_LegacyObjectIdSyntax));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 40577, 40589);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 40094, 40608);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 40628, 41453) || true) && ((ch = f_10014_40638_40659(TextWindow)) == '.')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 40628, 41453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 40709, 40742);

                        var
                        ch2 = f_10014_40719_40741(TextWindow, 1)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 40764, 41434) || true) && (ch2 >= '0' && (DynAbs.Tracing.TraceSender.Expression_True(10014, 40768, 40792) && ch2 <= '9'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 40764, 41434);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 40842, 40860);

                            hasDecimal = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 40886, 40906);

                            f_10014_40886_40905(_builder, ch);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 40932, 40957);

                            f_10014_40932_40956(TextWindow);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 40985, 41124);

                            f_10014_40985_41123(this, ref underscoreInWrongPlace, ref usedUnderscore, ref firstCharWasUnderscore, isHex: false, isBinary: false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 40764, 41434);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 40764, 41434);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 41174, 41434) || true) && (f_10014_41178_41193(_builder) == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 41174, 41434);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 41348, 41372);

                                f_10014_41348_41371(                        // we only have the dot so far.. (no preceding number or following number)
                                                        TextWindow, start);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 41398, 41411);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 41174, 41434);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 40764, 41434);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 40628, 41453);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 41473, 42584) || true) && ((ch = f_10014_41483_41504(TextWindow)) == 'E' || (DynAbs.Tracing.TraceSender.Expression_False(10014, 41477, 41525) || ch == 'e'))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 41473, 42584);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 41567, 41587);

                        f_10014_41567_41586(_builder, ch);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 41609, 41634);

                        f_10014_41609_41633(TextWindow);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 41656, 41675);

                        hasExponent = true;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 41697, 41893) || true) && ((ch = f_10014_41707_41728(TextWindow)) == '-' || (DynAbs.Tracing.TraceSender.Expression_False(10014, 41701, 41749) || ch == '+'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 41697, 41893);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 41799, 41819);

                            f_10014_41799_41818(_builder, ch);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 41845, 41870);

                            f_10014_41845_41869(TextWindow);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 41697, 41893);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 41917, 42565) || true) && (!(((ch = f_10014_41930_41951(TextWindow)) >= '0' && (DynAbs.Tracing.TraceSender.Expression_True(10014, 41924, 41972) && ch <= '9')) || (DynAbs.Tracing.TraceSender.Expression_False(10014, 41923, 41986) || ch == '_')))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 41917, 42565);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 42131, 42183);

                            f_10014_42131_42182(                        // use this for now (CS0595), cant use CS0594 as we dont know 'type'
                                                    this, f_10014_42145_42181(ErrorCode.ERR_InvalidReal));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 42284, 42305);

                            f_10014_42284_42304(                        // add dummy exponent, so parser does not blow up
                                                    _builder, '0');
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 41917, 42565);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 41917, 42565);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 42403, 42542);

                            f_10014_42403_42541(this, ref underscoreInWrongPlace, ref usedUnderscore, ref firstCharWasUnderscore, isHex: false, isBinary: false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 41917, 42565);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 41473, 42584);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 42604, 45086) || true) && (hasExponent || (DynAbs.Tracing.TraceSender.Expression_False(10014, 42608, 42633) || hasDecimal))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 42604, 45086);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 42675, 43476) || true) && ((ch = f_10014_42685_42706(TextWindow)) == 'f' || (DynAbs.Tracing.TraceSender.Expression_False(10014, 42679, 42727) || ch == 'F'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 42675, 43476);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 42777, 42802);

                            f_10014_42777_42801(TextWindow);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 42828, 42871);

                            info.ValueKind = SpecialType.System_Single;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 42675, 43476);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 42675, 43476);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 42921, 43476) || true) && (ch == 'D' || (DynAbs.Tracing.TraceSender.Expression_False(10014, 42925, 42947) || ch == 'd'))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 42921, 43476);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 42997, 43022);

                                f_10014_42997_43021(TextWindow);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 43048, 43091);

                                info.ValueKind = SpecialType.System_Double;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 42921, 43476);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 42921, 43476);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 43141, 43476) || true) && (ch == 'm' || (DynAbs.Tracing.TraceSender.Expression_False(10014, 43145, 43167) || ch == 'M'))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 43141, 43476);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 43217, 43242);

                                    f_10014_43217_43241(TextWindow);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 43268, 43312);

                                    info.ValueKind = SpecialType.System_Decimal;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 43141, 43476);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 43141, 43476);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 43410, 43453);

                                    info.ValueKind = SpecialType.System_Double;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 43141, 43476);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 42921, 43476);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 42675, 43476);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 42604, 45086);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 42604, 45086);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 43518, 45086) || true) && ((ch = f_10014_43528_43549(TextWindow)) == 'f' || (DynAbs.Tracing.TraceSender.Expression_False(10014, 43522, 43570) || ch == 'F'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 43518, 45086);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 43612, 43637);

                            f_10014_43612_43636(TextWindow);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 43659, 43702);

                            info.ValueKind = SpecialType.System_Single;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 43518, 45086);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 43518, 45086);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 43744, 45086) || true) && (ch == 'D' || (DynAbs.Tracing.TraceSender.Expression_False(10014, 43748, 43770) || ch == 'd'))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 43744, 45086);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 43812, 43837);

                                f_10014_43812_43836(TextWindow);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 43859, 43902);

                                info.ValueKind = SpecialType.System_Double;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 43744, 45086);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 43744, 45086);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 43944, 45086) || true) && (ch == 'm' || (DynAbs.Tracing.TraceSender.Expression_False(10014, 43948, 43970) || ch == 'M'))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 43944, 45086);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 44012, 44037);

                                    f_10014_44012_44036(TextWindow);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 44059, 44103);

                                    info.ValueKind = SpecialType.System_Decimal;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 43944, 45086);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 43944, 45086);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 44145, 45086) || true) && (ch == 'L' || (DynAbs.Tracing.TraceSender.Expression_False(10014, 44149, 44171) || ch == 'l'))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 44145, 45086);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 44213, 44371) || true) && (ch == 'l')
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 44213, 44371);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 44276, 44348);

                                            f_10014_44276_44347(this, f_10014_44290_44309(TextWindow), 1, ErrorCode.WRN_LowercaseEllSuffix);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 44213, 44371);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 44395, 44420);

                                        f_10014_44395_44419(
                                                            TextWindow);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 44442, 44460);

                                        hasLSuffix = true;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 44482, 44676) || true) && ((ch = f_10014_44492_44513(TextWindow)) == 'u' || (DynAbs.Tracing.TraceSender.Expression_False(10014, 44486, 44534) || ch == 'U'))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 44482, 44676);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 44584, 44609);

                                            f_10014_44584_44608(TextWindow);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 44635, 44653);

                                            hasUSuffix = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 44482, 44676);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 44145, 45086);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 44145, 45086);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 44718, 45086) || true) && (ch == 'u' || (DynAbs.Tracing.TraceSender.Expression_False(10014, 44722, 44744) || ch == 'U'))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 44718, 45086);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 44786, 44804);

                                            hasUSuffix = true;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 44826, 44851);

                                            f_10014_44826_44850(TextWindow);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 44873, 45067) || true) && ((ch = f_10014_44883_44904(TextWindow)) == 'L' || (DynAbs.Tracing.TraceSender.Expression_False(10014, 44877, 44925) || ch == 'l'))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 44873, 45067);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 44975, 45000);

                                                f_10014_44975_44999(TextWindow);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 45026, 45044);

                                                hasLSuffix = true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 44873, 45067);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 44718, 45086);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 44145, 45086);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 43944, 45086);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 43744, 45086);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 43518, 45086);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 42604, 45086);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 38523, 45101);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 45117, 45593) || true) && (underscoreInWrongPlace)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 45117, 45593);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 45177, 45267);

                    f_10014_45177_45266(this, f_10014_45191_45265(this, start, f_10014_45208_45227(TextWindow) - start, ErrorCode.ERR_InvalidNumber));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 45117, 45593);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 45117, 45593);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 45301, 45593) || true) && (firstCharWasUnderscore)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 45301, 45593);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 45361, 45430);

                        f_10014_45361_45429(this, MessageID.IDS_FeatureLeadingDigitSeparator);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 45301, 45593);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 45301, 45593);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 45464, 45593) || true) && (usedUnderscore)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 45464, 45593);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 45516, 45578);

                            f_10014_45516_45577(this, MessageID.IDS_FeatureDigitSeparator);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 45464, 45593);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 45301, 45593);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 45117, 45593);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 45609, 45652);

                info.Kind = SyntaxKind.NumericLiteralToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 45666, 45703);

                info.Text = f_10014_45678_45702(TextWindow, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 45717, 45749);

                f_10014_45717_45748(info.Text != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 45763, 45807);

                var
                valueText = f_10014_45779_45806(TextWindow, _builder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 45821, 45831);

                ulong
                val
                = default(ulong);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 45845, 51625);

                switch (info.ValueKind)
                {

                    case SpecialType.System_Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 45845, 51625);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 45954, 46003);

                        info.FloatValue = f_10014_45972_46002(this, valueText);
                        DynAbs.Tracing.TraceSender.TraceBreak(10014, 46025, 46031);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 45845, 51625);

                    case SpecialType.System_Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 45845, 51625);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 46102, 46152);

                        info.DoubleValue = f_10014_46121_46151(this, valueText);
                        DynAbs.Tracing.TraceSender.TraceBreak(10014, 46174, 46180);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 45845, 51625);

                    case SpecialType.System_Decimal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 45845, 51625);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 46252, 46332);

                        info.DecimalValue = f_10014_46272_46331(this, valueText, start, f_10014_46311_46330(TextWindow));
                        DynAbs.Tracing.TraceSender.TraceBreak(10014, 46354, 46360);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 45845, 51625);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 45845, 51625);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 46408, 46883) || true) && (f_10014_46412_46443(valueText))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 46408, 46883);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 46493, 46659) || true) && (!underscoreInWrongPlace)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 46493, 46659);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 46578, 46632);

                                f_10014_46578_46631(this, f_10014_46592_46630(ErrorCode.ERR_InvalidNumber));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 46493, 46659);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 46685, 46693);

                            val = 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 46408, 46883);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 46408, 46883);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 46806, 46860);

                            val = f_10014_46812_46859(this, valueText, isHex, isBinary);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 46408, 46883);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 47218, 50519) || true) && (!hasUSuffix && (DynAbs.Tracing.TraceSender.Expression_True(10014, 47222, 47248) && !hasLSuffix))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 47218, 50519);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 47298, 48550) || true) && (val <= Int32.MaxValue)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 47298, 48550);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 47381, 47423);

                                info.ValueKind = SpecialType.System_Int32;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 47453, 47478);

                                info.IntValue = (int)val;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 47298, 48550);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 47298, 48550);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 47536, 48550) || true) && (val <= UInt32.MaxValue)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 47536, 48550);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 47620, 47663);

                                    info.ValueKind = SpecialType.System_UInt32;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 47693, 47720);

                                    info.UintValue = (uint)val;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 47536, 48550);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 47536, 48550);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 47951, 48550) || true) && (val <= Int64.MaxValue)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 47951, 48550);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 48034, 48076);

                                        info.ValueKind = SpecialType.System_Int64;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 48106, 48133);

                                        info.LongValue = (long)val;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 47951, 48550);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 47951, 48550);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 48247, 48290);

                                        info.ValueKind = SpecialType.System_UInt64;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 48320, 48342);

                                        info.UlongValue = val;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 47951, 48550);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 47536, 48550);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 47298, 48550);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 47218, 50519);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 47218, 50519);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 48600, 50519) || true) && (hasUSuffix && (DynAbs.Tracing.TraceSender.Expression_True(10014, 48604, 48629) && !hasLSuffix))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 48600, 50519);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 48831, 49251) || true) && (val <= UInt32.MaxValue)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 48831, 49251);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 48915, 48958);

                                    info.ValueKind = SpecialType.System_UInt32;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 48988, 49015);

                                    info.UintValue = (uint)val;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 48831, 49251);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 48831, 49251);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 49129, 49172);

                                    info.ValueKind = SpecialType.System_UInt64;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 49202, 49224);

                                    info.UlongValue = val;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 48831, 49251);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 48600, 50519);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 48600, 50519);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 49451, 50519) || true) && (!hasUSuffix & hasLSuffix)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 49451, 50519);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 49529, 50128) || true) && (val <= Int64.MaxValue)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 49529, 50128);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 49612, 49654);

                                        info.ValueKind = SpecialType.System_Int64;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 49684, 49711);

                                        info.LongValue = (long)val;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 49529, 50128);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 49529, 50128);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 49825, 49868);

                                        info.ValueKind = SpecialType.System_UInt64;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 49898, 49920);

                                        info.UlongValue = val;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 49529, 50128);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 49451, 50519);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 49451, 50519);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 50340, 50379);

                                    f_10014_50340_50378(hasUSuffix && (DynAbs.Tracing.TraceSender.Expression_True(10014, 50353, 50377) && hasLSuffix));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 50405, 50448);

                                    info.ValueKind = SpecialType.System_UInt64;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 50474, 50496);

                                    info.UlongValue = val;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 49451, 50519);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 48600, 50519);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 47218, 50519);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10014, 50543, 50549);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 45845, 51625);

                        // Note, the following portion of the spec is not implemented here. It is implemented
                        // in the unary minus analysis.

                        // * When a decimal-integer-literal with the value 2147483648 (231) and no integer-type-suffix appears
                        //   as the token immediately following a unary minus operator token (§7.7.2), the result is a constant
                        //   of type int with the value −2147483648 (−231). In all other situations, such a decimal-integer-
                        //   literal is of type uint.
                        // * When a decimal-integer-literal with the value 9223372036854775808 (263) and no integer-type-suffix
                        //   or the integer-type-suffix L or l appears as the token immediately following a unary minus operator
                        //   token (§7.7.2), the result is a constant of type long with the value −9223372036854775808 (−263).
                        //   In all other situations, such a decimal-integer-literal is of type ulong.
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 51641, 51653);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 37333, 51664);

                int
                f_10014_37421_37440(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 37421, 37440);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10014_37702_37718(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 37702, 37718);
                    return return_v;
                }


                char
                f_10014_37958_37979(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 37958, 37979);
                    return return_v;
                }


                char
                f_10014_38046_38068(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 38046, 38068);
                    return return_v;
                }


                int
                f_10014_38155_38180(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                n)
                {
                    this_param.AdvanceChar(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 38155, 38180);
                    return 0;
                }


                int
                f_10014_38326_38386(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    this_param.CheckFeatureAvailability(feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 38326, 38386);
                    return 0;
                }


                int
                f_10014_38409_38434(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                n)
                {
                    this_param.AdvanceChar(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 38409, 38434);
                    return 0;
                }


                int
                f_10014_38731_38855(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref bool
                underscoreInWrongPlace, ref bool
                usedUnderscore, ref bool
                firstCharWasUnderscore, bool
                isHex, bool
                isBinary)
                {
                    this_param.ScanNumericLiteralSingleInteger(ref underscoreInWrongPlace, ref usedUnderscore, ref firstCharWasUnderscore, isHex, isBinary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 38731, 38855);
                    return 0;
                }


                char
                f_10014_38886_38907(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 38886, 38907);
                    return return_v;
                }


                int
                f_10014_39047_39066(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 39047, 39066);
                    return return_v;
                }


                int
                f_10014_39033_39104(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, int
                position, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    this_param.AddError(position, width, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 39033, 39104);
                    return 0;
                }


                int
                f_10014_39152_39176(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 39152, 39176);
                    return 0;
                }


                char
                f_10014_39249_39270(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 39249, 39270);
                    return return_v;
                }


                int
                f_10014_39341_39365(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 39341, 39365);
                    return 0;
                }


                char
                f_10014_39485_39506(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 39485, 39506);
                    return return_v;
                }


                int
                f_10014_39569_39593(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 39569, 39593);
                    return 0;
                }


                char
                f_10014_39666_39687(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 39666, 39687);
                    return return_v;
                }


                int
                f_10014_39758_39782(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 39758, 39782);
                    return 0;
                }


                int
                f_10014_39935_40073(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref bool
                underscoreInWrongPlace, ref bool
                usedUnderscore, ref bool
                firstCharWasUnderscore, bool
                isHex, bool
                isBinary)
                {
                    this_param.ScanNumericLiteralSingleInteger(ref underscoreInWrongPlace, ref usedUnderscore, ref firstCharWasUnderscore, isHex: isHex, isBinary: isBinary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 39935, 40073);
                    return 0;
                }


                bool
                f_10014_40098_40135(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = this_param.ModeIs(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 40098, 40135);
                    return return_v;
                }


                char
                f_10014_40139_40160(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 40139, 40160);
                    return return_v;
                }


                int
                f_10014_40300_40324(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 40300, 40324);
                    return 0;
                }


                string
                f_10014_40378_40410(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, bool
                intern)
                {
                    var return_v = this_param.GetText(intern: intern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 40378, 40410);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10014_40508_40553(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = MakeError(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 40508, 40553);
                    return return_v;
                }


                int
                f_10014_40494_40554(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                error)
                {
                    this_param.AddError(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 40494, 40554);
                    return 0;
                }


                char
                f_10014_40638_40659(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 40638, 40659);
                    return return_v;
                }


                char
                f_10014_40719_40741(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 40719, 40741);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10014_40886_40905(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 40886, 40905);
                    return return_v;
                }


                int
                f_10014_40932_40956(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 40932, 40956);
                    return 0;
                }


                int
                f_10014_40985_41123(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref bool
                underscoreInWrongPlace, ref bool
                usedUnderscore, ref bool
                firstCharWasUnderscore, bool
                isHex, bool
                isBinary)
                {
                    this_param.ScanNumericLiteralSingleInteger(ref underscoreInWrongPlace, ref usedUnderscore, ref firstCharWasUnderscore, isHex: isHex, isBinary: isBinary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 40985, 41123);
                    return 0;
                }


                int
                f_10014_41178_41193(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 41178, 41193);
                    return return_v;
                }


                int
                f_10014_41348_41371(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                position)
                {
                    this_param.Reset(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 41348, 41371);
                    return 0;
                }


                char
                f_10014_41483_41504(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 41483, 41504);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10014_41567_41586(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 41567, 41586);
                    return return_v;
                }


                int
                f_10014_41609_41633(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 41609, 41633);
                    return 0;
                }


                char
                f_10014_41707_41728(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 41707, 41728);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10014_41799_41818(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 41799, 41818);
                    return return_v;
                }


                int
                f_10014_41845_41869(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 41845, 41869);
                    return 0;
                }


                char
                f_10014_41930_41951(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 41930, 41951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10014_42145_42181(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = MakeError(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 42145, 42181);
                    return return_v;
                }


                int
                f_10014_42131_42182(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                error)
                {
                    this_param.AddError(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 42131, 42182);
                    return 0;
                }


                System.Text.StringBuilder
                f_10014_42284_42304(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 42284, 42304);
                    return return_v;
                }


                int
                f_10014_42403_42541(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref bool
                underscoreInWrongPlace, ref bool
                usedUnderscore, ref bool
                firstCharWasUnderscore, bool
                isHex, bool
                isBinary)
                {
                    this_param.ScanNumericLiteralSingleInteger(ref underscoreInWrongPlace, ref usedUnderscore, ref firstCharWasUnderscore, isHex: isHex, isBinary: isBinary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 42403, 42541);
                    return 0;
                }


                char
                f_10014_42685_42706(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 42685, 42706);
                    return return_v;
                }


                int
                f_10014_42777_42801(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 42777, 42801);
                    return 0;
                }


                int
                f_10014_42997_43021(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 42997, 43021);
                    return 0;
                }


                int
                f_10014_43217_43241(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 43217, 43241);
                    return 0;
                }


                char
                f_10014_43528_43549(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 43528, 43549);
                    return return_v;
                }


                int
                f_10014_43612_43636(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 43612, 43636);
                    return 0;
                }


                int
                f_10014_43812_43836(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 43812, 43836);
                    return 0;
                }


                int
                f_10014_44012_44036(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 44012, 44036);
                    return 0;
                }


                int
                f_10014_44290_44309(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 44290, 44309);
                    return return_v;
                }


                int
                f_10014_44276_44347(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, int
                position, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    this_param.AddError(position, width, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 44276, 44347);
                    return 0;
                }


                int
                f_10014_44395_44419(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 44395, 44419);
                    return 0;
                }


                char
                f_10014_44492_44513(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 44492, 44513);
                    return return_v;
                }


                int
                f_10014_44584_44608(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 44584, 44608);
                    return 0;
                }


                int
                f_10014_44826_44850(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 44826, 44850);
                    return 0;
                }


                char
                f_10014_44883_44904(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 44883, 44904);
                    return return_v;
                }


                int
                f_10014_44975_44999(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 44975, 44999);
                    return 0;
                }


                int
                f_10014_45208_45227(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 45208, 45227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10014_45191_45265(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, int
                position, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.MakeError(position, width, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 45191, 45265);
                    return return_v;
                }


                int
                f_10014_45177_45266(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                error)
                {
                    this_param.AddError(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 45177, 45266);
                    return 0;
                }


                int
                f_10014_45361_45429(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    this_param.CheckFeatureAvailability(feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 45361, 45429);
                    return 0;
                }


                int
                f_10014_45516_45577(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    this_param.CheckFeatureAvailability(feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 45516, 45577);
                    return 0;
                }


                string
                f_10014_45678_45702(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, bool
                intern)
                {
                    var return_v = this_param.GetText(intern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 45678, 45702);
                    return return_v;
                }


                int
                f_10014_45717_45748(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 45717, 45748);
                    return 0;
                }


                string
                f_10014_45779_45806(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, System.Text.StringBuilder
                text)
                {
                    var return_v = this_param.Intern(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 45779, 45806);
                    return return_v;
                }


                float
                f_10014_45972_46002(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, string
                text)
                {
                    var return_v = this_param.GetValueSingle(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 45972, 46002);
                    return return_v;
                }


                double
                f_10014_46121_46151(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, string
                text)
                {
                    var return_v = this_param.GetValueDouble(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 46121, 46151);
                    return return_v;
                }


                int
                f_10014_46311_46330(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 46311, 46330);
                    return return_v;
                }


                decimal
                f_10014_46272_46331(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, string
                text, int
                start, int
                end)
                {
                    var return_v = this_param.GetValueDecimal(text, start, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 46272, 46331);
                    return return_v;
                }


                bool
                f_10014_46412_46443(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 46412, 46443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10014_46592_46630(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = MakeError(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 46592, 46630);
                    return return_v;
                }


                int
                f_10014_46578_46631(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                error)
                {
                    this_param.AddError(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 46578, 46631);
                    return 0;
                }


                ulong
                f_10014_46812_46859(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, string
                text, bool
                isHex, bool
                isBinary)
                {
                    var return_v = this_param.GetValueUInt64(text, isHex, isBinary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 46812, 46859);
                    return return_v;
                }


                int
                f_10014_50340_50378(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 50340, 50378);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 37333, 51664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 37333, 51664);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryParseBinaryUInt64(string text, out ulong value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10014, 51814, 52529);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 51909, 51919);

                value = 0;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 51933, 52492);
                    foreach (char c in f_10014_51952_51956_I(text))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 51933, 52492);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 52072, 52183) || true) && ((value & 0x8000000000000000) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 52072, 52183);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 52151, 52164);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 52072, 52183);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 52388, 52432);

                        var
                        bit = (ulong)f_10014_52405_52431(c)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 52450, 52477);

                        value = (value << 1) | bit;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 51933, 52492);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10014, 1, 560);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10014, 1, 560);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 52506, 52518);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10014, 51814, 52529);

                int
                f_10014_52405_52431(char
                c)
                {
                    var return_v = SyntaxFacts.BinaryValue(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 52405, 52431);
                    return return_v;
                }


                string
                f_10014_51952_51956_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 51952, 51956);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 51814, 52529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 51814, 52529);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int GetValueInt32(string text, bool isHex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 52571, 53027);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 52646, 52657);

                int
                result
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 52671, 52986) || true) && (!f_10014_52676_52798(text, (DynAbs.Tracing.TraceSender.Conditional_F1(10014, 52697, 52702) || ((isHex && DynAbs.Tracing.TraceSender.Conditional_F2(10014, 52705, 52735)) || DynAbs.Tracing.TraceSender.Conditional_F3(10014, 52738, 52755))) ? NumberStyles.AllowHexSpecifier : NumberStyles.None, f_10014_52757_52785(), out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 52671, 52986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 52919, 52971);

                    f_10014_52919_52970(                //we've already lexed the literal, so the error must be from overflow
                                    this, f_10014_52933_52969(ErrorCode.ERR_IntOverflow));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 52671, 52986);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 53002, 53016);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 52571, 53027);

                System.Globalization.CultureInfo
                f_10014_52757_52785()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 52757, 52785);
                    return return_v;
                }


                bool
                f_10014_52676_52798(string
                s, System.Globalization.NumberStyles
                style, System.Globalization.CultureInfo
                provider, out int
                result)
                {
                    var return_v = Int32.TryParse(s, style, (System.IFormatProvider)provider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 52676, 52798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10014_52933_52969(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = MakeError(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 52933, 52969);
                    return return_v;
                }


                int
                f_10014_52919_52970(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                error)
                {
                    this_param.AddError(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 52919, 52970);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 52571, 53027);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 52571, 53027);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ulong GetValueUInt64(string text, bool isHex, bool isBinary)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 53127, 53840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 53220, 53233);

                ulong
                result
                = default(ulong);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 53247, 53799) || true) && (isBinary)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 53247, 53799);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 53293, 53449) || true) && (!f_10014_53298_53336(text, out result))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 53293, 53449);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 53378, 53430);

                        f_10014_53378_53429(this, f_10014_53392_53428(ErrorCode.ERR_IntOverflow));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 53293, 53449);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 53247, 53799);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 53247, 53799);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 53483, 53799) || true) && (!f_10014_53488_53611(text, (DynAbs.Tracing.TraceSender.Conditional_F1(10014, 53510, 53515) || ((isHex && DynAbs.Tracing.TraceSender.Conditional_F2(10014, 53518, 53548)) || DynAbs.Tracing.TraceSender.Conditional_F3(10014, 53551, 53568))) ? NumberStyles.AllowHexSpecifier : NumberStyles.None, f_10014_53570_53598(), out result))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 53483, 53799);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 53732, 53784);

                        f_10014_53732_53783(                //we've already lexed the literal, so the error must be from overflow
                                        this, f_10014_53746_53782(ErrorCode.ERR_IntOverflow));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 53483, 53799);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 53247, 53799);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 53815, 53829);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 53127, 53840);

                bool
                f_10014_53298_53336(string
                text, out ulong
                value)
                {
                    var return_v = TryParseBinaryUInt64(text, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 53298, 53336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10014_53392_53428(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = MakeError(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 53392, 53428);
                    return return_v;
                }


                int
                f_10014_53378_53429(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                error)
                {
                    this_param.AddError(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 53378, 53429);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_10014_53570_53598()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 53570, 53598);
                    return return_v;
                }


                bool
                f_10014_53488_53611(string
                s, System.Globalization.NumberStyles
                style, System.Globalization.CultureInfo
                provider, out ulong
                result)
                {
                    var return_v = UInt64.TryParse(s, style, (System.IFormatProvider)provider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 53488, 53611);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10014_53746_53782(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = MakeError(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 53746, 53782);
                    return return_v;
                }


                int
                f_10014_53732_53783(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                error)
                {
                    this_param.AddError(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 53732, 53783);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 53127, 53840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 53127, 53840);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private double GetValueDouble(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 53852, 54236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 53919, 53933);

                double
                result
                = default(double);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 53947, 54195) || true) && (!f_10014_53952_53995(text, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 53947, 54195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 54116, 54180);

                    f_10014_54116_54179(                //we've already lexed the literal, so the error must be from overflow
                                    this, f_10014_54130_54178(ErrorCode.ERR_FloatOverflow, "double"));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 53947, 54195);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 54211, 54225);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 53852, 54236);

                bool
                f_10014_53952_53995(string
                s, out double
                d)
                {
                    var return_v = RealParser.TryParseDouble(s, out d);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 53952, 53995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10014_54130_54178(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = MakeError(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 54130, 54178);
                    return return_v;
                }


                int
                f_10014_54116_54179(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                error)
                {
                    this_param.AddError(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 54116, 54179);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 53852, 54236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 53852, 54236);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private float GetValueSingle(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 54248, 54628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 54314, 54327);

                float
                result
                = default(float);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 54341, 54587) || true) && (!f_10014_54346_54388(text, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 54341, 54587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 54509, 54572);

                    f_10014_54509_54571(                //we've already lexed the literal, so the error must be from overflow
                                    this, f_10014_54523_54570(ErrorCode.ERR_FloatOverflow, "float"));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 54341, 54587);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 54603, 54617);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 54248, 54628);

                bool
                f_10014_54346_54388(string
                s, out float
                f)
                {
                    var return_v = RealParser.TryParseFloat(s, out f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 54346, 54388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10014_54523_54570(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = MakeError(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 54523, 54570);
                    return return_v;
                }


                int
                f_10014_54509_54571(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                error)
                {
                    this_param.AddError(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 54509, 54571);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 54248, 54628);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 54248, 54628);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private decimal GetValueDecimal(string text, int start, int end)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 54640, 56665);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 56239, 56254);

                decimal
                result
                = default(decimal);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 56268, 56624) || true) && (!f_10014_56273_56398(text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, f_10014_56357_56385(), out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 56268, 56624);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 56519, 56609);

                    f_10014_56519_56608(                //we've already lexed the literal, so the error must be from overflow
                                    this, f_10014_56533_56607(this, start, end - start, ErrorCode.ERR_FloatOverflow, "decimal"));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 56268, 56624);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 56640, 56654);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 54640, 56665);

                System.Globalization.CultureInfo
                f_10014_56357_56385()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 56357, 56385);
                    return return_v;
                }


                bool
                f_10014_56273_56398(string
                s, System.Globalization.NumberStyles
                style, System.Globalization.CultureInfo
                provider, out decimal
                result)
                {
                    var return_v = decimal.TryParse(s, style, (System.IFormatProvider)provider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 56273, 56398);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10014_56533_56607(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, int
                position, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = this_param.MakeError(position, width, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 56533, 56607);
                    return return_v;
                }


                int
                f_10014_56519_56608(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                error)
                {
                    this_param.AddError(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 56519, 56608);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 54640, 56665);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 54640, 56665);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ResetIdentBuffer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 56677, 56758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 56733, 56747);

                _identLen = 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 56677, 56758);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 56677, 56758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 56677, 56758);
            }
        }

        private void AddIdentChar(char ch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 56770, 56995);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 56829, 56937) || true) && (_identLen >= f_10014_56846_56865(_identBuffer))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 56829, 56937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 56899, 56922);

                    f_10014_56899_56921(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 56829, 56937);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 56953, 56984);

                _identBuffer[_identLen++] = ch;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 56770, 56995);

                int
                f_10014_56846_56865(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 56846, 56865);
                    return return_v;
                }


                int
                f_10014_56899_56921(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    this_param.GrowIdentBuffer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 56899, 56921);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 56770, 56995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 56770, 56995);
            }
        }

        private void GrowIdentBuffer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 57007, 57215);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 57062, 57106);

                var
                tmp = new char[f_10014_57081_57100(_identBuffer) * 2]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 57120, 57171);

                f_10014_57120_57170(_identBuffer, tmp, f_10014_57150_57169(_identBuffer));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 57185, 57204);

                _identBuffer = tmp;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 57007, 57215);

                int
                f_10014_57081_57100(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 57081, 57100);
                    return return_v;
                }


                int
                f_10014_57150_57169(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 57150, 57169);
                    return return_v;
                }


                int
                f_10014_57120_57170(char[]
                sourceArray, char[]
                destinationArray, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, (System.Array)destinationArray, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 57120, 57170);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 57007, 57215);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 57007, 57215);
            }
        }

        private bool ScanIdentifier(ref TokenInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 57227, 57496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 57299, 57485);

                return
                f_10014_57323_57356(this, ref info) || (DynAbs.Tracing.TraceSender.Expression_False(10014, 57323, 57484) || ((DynAbs.Tracing.TraceSender.Conditional_F1(10014, 57378, 57407) || ((f_10014_57378_57407() && DynAbs.Tracing.TraceSender.Conditional_F2(10014, 57410, 57447)) || DynAbs.Tracing.TraceSender.Conditional_F3(10014, 57450, 57483))) ? f_10014_57410_57447(this, ref info) : f_10014_57450_57483(this, ref info)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 57227, 57496);

                bool
                f_10014_57323_57356(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info)
                {
                    var return_v = this_param.ScanIdentifier_FastPath(ref info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 57323, 57356);
                    return return_v;
                }


                bool
                f_10014_57378_57407()
                {
                    var return_v = InXmlCrefOrNameAttributeValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 57378, 57407);
                    return return_v;
                }


                bool
                f_10014_57410_57447(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info)
                {
                    var return_v = this_param.ScanIdentifier_CrefSlowPath(ref info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 57410, 57447);
                    return return_v;
                }


                bool
                f_10014_57450_57483(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info)
                {
                    var return_v = this_param.ScanIdentifier_SlowPath(ref info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 57450, 57483);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 57227, 57496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 57227, 57496);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ScanIdentifier_FastPath(ref TokenInfo info)
        {
            if ((_mode & LexerMode.MaskLexMode) == LexerMode.DebuggerSyntax)
            {
                // Debugger syntax is wonky.  Can't use the fast path for it.
                return false;
            }

            var currentOffset = TextWindow.Offset;
            var characterWindow = TextWindow.CharacterWindow;
            var characterWindowCount = TextWindow.CharacterWindowCount;

            var startOffset = currentOffset;

            while (true)
            {
                if (currentOffset == characterWindowCount)
                {
                    // no more contiguous characters.  Fall back to slow path
                    return false;
                }

                switch (characterWindow[currentOffset])
                {
                    case '&':
                        // CONSIDER: This method is performance critical, so
                        // it might be safer to kick out at the top (as for
                        // LexerMode.DebuggerSyntax).

                        // If we're in a cref, this could be the start of an
                        // xml entity that belongs in the identifier.
                        if (InXmlCrefOrNameAttributeValue)
                        {
                            // Fall back on the slow path.
                            return false;
                        }

                        // Otherwise, end the identifier.
                        goto case '\0';
                    case '\0':
                    case ' ':
                    case '\r':
                    case '\n':
                    case '\t':
                    case '!':
                    case '%':
                    case '(':
                    case ')':
                    case '*':
                    case '+':
                    case ',':
                    case '-':
                    case '.':
                    case '/':
                    case ':':
                    case ';':
                    case '<':
                    case '=':
                    case '>':
                    case '?':
                    case '[':
                    case ']':
                    case '^':
                    case '{':
                    case '|':
                    case '}':
                    case '~':
                    case '"':
                    case '\'':
                        // All of the following characters are not valid in an 
                        // identifier.  If we see any of them, then we know we're
                        // done.
                        var length = currentOffset - startOffset;
                        TextWindow.AdvanceChar(length);
                        info.Text = info.StringValue = TextWindow.Intern(characterWindow, startOffset, length);
                        info.IsVerbatim = false;
                        return true;
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        if (currentOffset == startOffset)
                        {
                            return false;
                        }
                        else
                        {
                            goto case 'A';
                        }
                    case 'A':
                    case 'B':
                    case 'C':
                    case 'D':
                    case 'E':
                    case 'F':
                    case 'G':
                    case 'H':
                    case 'I':
                    case 'J':
                    case 'K':
                    case 'L':
                    case 'M':
                    case 'N':
                    case 'O':
                    case 'P':
                    case 'Q':
                    case 'R':
                    case 'S':
                    case 'T':
                    case 'U':
                    case 'V':
                    case 'W':
                    case 'X':
                    case 'Y':
                    case 'Z':
                    case '_':
                    case 'a':
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'e':
                    case 'f':
                    case 'g':
                    case 'h':
                    case 'i':
                    case 'j':
                    case 'k':
                    case 'l':
                    case 'm':
                    case 'n':
                    case 'o':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                    case 'u':
                    case 'v':
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        // All of these characters are valid inside an identifier.
                        // consume it and keep processing.
                        currentOffset++;
                        continue;

                    // case '@':  verbatim identifiers are handled in the slow path
                    // case '\\': unicode escapes are handled in the slow path
                    default:
                        // Any other character is something we cannot handle.  i.e.
                        // unicode chars or an escape.  Just break out and move to
                        // the slow path.
                        return false;
                }
            }
        }

        private bool ScanIdentifier_SlowPath(ref TokenInfo info)
        {
            int start = TextWindow.Position;
            this.ResetIdentBuffer();

            info.IsVerbatim = TextWindow.PeekChar() == '@';
            if (info.IsVerbatim)
            {
                TextWindow.AdvanceChar();
            }

            bool isObjectAddress = false;

            while (true)
            {
                char surrogateCharacter = SlidingTextWindow.InvalidCharacter;
                bool isEscaped = false;
                char ch = TextWindow.PeekChar();
top:
                switch (ch)
                {
                    case '\\':
                        if (!isEscaped && TextWindow.IsUnicodeEscape())
                        {
                            // ^^^^^^^ otherwise \u005Cu1234 looks just like \u1234! (i.e. escape within escape)
                            info.HasIdentifierEscapeSequence = true;
                            isEscaped = true;
                            ch = TextWindow.PeekUnicodeEscape(out surrogateCharacter);
                            goto top;
                        }

                        goto default;
                    case '$':
                        if (!this.ModeIs(LexerMode.DebuggerSyntax) || _identLen > 0)
                        {
                            goto LoopExit;
                        }

                        break;
                    case SlidingTextWindow.InvalidCharacter:
                        if (!TextWindow.IsReallyAtEnd())
                        {
                            goto default;
                        }

                        goto LoopExit;
                    case '_':
                    case 'A':
                    case 'B':
                    case 'C':
                    case 'D':
                    case 'E':
                    case 'F':
                    case 'G':
                    case 'H':
                    case 'I':
                    case 'J':
                    case 'K':
                    case 'L':
                    case 'M':
                    case 'N':
                    case 'O':
                    case 'P':
                    case 'Q':
                    case 'R':
                    case 'S':
                    case 'T':
                    case 'U':
                    case 'V':
                    case 'W':
                    case 'X':
                    case 'Y':
                    case 'Z':
                    case 'a':
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'e':
                    case 'f':
                    case 'g':
                    case 'h':
                    case 'i':
                    case 'j':
                    case 'k':
                    case 'l':
                    case 'm':
                    case 'n':
                    case 'o':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                    case 'u':
                    case 'v':
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        {
                            // Again, these are the 'common' identifier characters...
                            break;
                        }

                    case '0':
                        {
                            if (_identLen == 0)
                            {
                                // Debugger syntax allows @0x[hexdigit]+ for object address identifiers.
                                if (info.IsVerbatim &&
                                    this.ModeIs(LexerMode.DebuggerSyntax) &&
                                    (char.ToLower(TextWindow.PeekChar(1)) == 'x'))
                                {
                                    isObjectAddress = true;
                                }
                                else
                                {
                                    goto LoopExit;
                                }
                            }

                            // Again, these are the 'common' identifier characters...
                            break;
                        }
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        {
                            if (_identLen == 0)
                            {
                                goto LoopExit;
                            }

                            // Again, these are the 'common' identifier characters...
                            break;
                        }

                    case ' ':
                    case '\t':
                    case '.':
                    case ';':
                    case '(':
                    case ')':
                    case ',':
                        // ...and these are the 'common' stop characters.
                        goto LoopExit;
                    case '<':
                        if (_identLen == 0 && this.ModeIs(LexerMode.DebuggerSyntax) && TextWindow.PeekChar(1) == '>')
                        {
                            // In DebuggerSyntax mode, identifiers are allowed to begin with <>.
                            TextWindow.AdvanceChar(2);
                            this.AddIdentChar('<');
                            this.AddIdentChar('>');
                            continue;
                        }

                        goto LoopExit;
                    default:
                        {
                            // This is the 'expensive' call
                            if (_identLen == 0 && ch > 127 && SyntaxFacts.IsIdentifierStartCharacter(ch))
                            {
                                break;
                            }
                            else if (_identLen > 0 && ch > 127 && SyntaxFacts.IsIdentifierPartCharacter(ch))
                            {
                                //// BUG 424819 : Handle identifier chars > 0xFFFF via surrogate pairs
                                if (UnicodeCharacterUtilities.IsFormattingChar(ch))
                                {
                                    if (isEscaped)
                                    {
                                        SyntaxDiagnosticInfo error;
                                        TextWindow.NextCharOrUnicodeEscape(out surrogateCharacter, out error);
                                        AddError(error);
                                    }
                                    else
                                    {
                                        TextWindow.AdvanceChar();
                                    }

                                    continue; // Ignore formatting characters
                                }

                                break;
                            }
                            else
                            {
                                // Not a valid identifier character, so bail.
                                goto LoopExit;
                            }
                        }
                }

                if (isEscaped)
                {
                    SyntaxDiagnosticInfo error;
                    TextWindow.NextCharOrUnicodeEscape(out surrogateCharacter, out error);
                    AddError(error);
                }
                else
                {
                    TextWindow.AdvanceChar();
                }

                this.AddIdentChar(ch);
                if (surrogateCharacter != SlidingTextWindow.InvalidCharacter)
                {
                    this.AddIdentChar(surrogateCharacter);
                }
            }

LoopExit:
            var width = TextWindow.Width; // exact size of input characters
            if (_identLen > 0)
            {
                info.Text = TextWindow.GetInternedText();

                // id buffer is identical to width in input
                if (_identLen == width)
                {
                    info.StringValue = info.Text;
                }
                else
                {
                    info.StringValue = TextWindow.Intern(_identBuffer, 0, _identLen);
                }

                if (isObjectAddress)
                {
                    // @0x[hexdigit]+
                    const int objectAddressOffset = 2;
                    Debug.Assert(string.Equals(info.Text.Substring(0, objectAddressOffset + 1), "@0x", StringComparison.OrdinalIgnoreCase));
                    var valueText = TextWindow.Intern(_identBuffer, objectAddressOffset, _identLen - objectAddressOffset);
                    // Verify valid hex value.
                    if ((valueText.Length == 0) || !valueText.All(IsValidHexDigit))
                    {
                        goto Fail;
                    }
                    // Parse hex value to check for overflow.
                    this.GetValueUInt64(valueText, isHex: true, isBinary: false);
                }

                return true;
            }

Fail:
            info.Text = null;
            info.StringValue = null;
            TextWindow.Reset(start);
            return false;
        }

        private static bool IsValidHexDigit(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10014, 74677, 74925);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 74745, 74834) || true) && ((c >= '0') && (DynAbs.Tracing.TraceSender.Expression_True(10014, 74749, 74773) && (c <= '9')))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 74745, 74834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 74807, 74819);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 74745, 74834);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 74848, 74868);

                c = f_10014_74852_74867(c);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 74882, 74914);

                return (c >= 'a') && (DynAbs.Tracing.TraceSender.Expression_True(10014, 74889, 74913) && (c <= 'f'));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10014, 74677, 74925);

                char
                f_10014_74852_74867(char
                c)
                {
                    var return_v = char.ToLower(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 74852, 74867);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 74677, 74925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 74677, 74925);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ScanIdentifier_CrefSlowPath(ref TokenInfo info)
        {
            Debug.Assert(InXmlCrefOrNameAttributeValue);

            int start = TextWindow.Position;
            this.ResetIdentBuffer();

            if (AdvanceIfMatches('@'))
            {
                // In xml name attribute values, the '@' is part of the value text of the identifier
                // (to match dev11).
                if (InXmlNameAttributeValue)
                {
                    AddIdentChar('@');
                }
                else
                {
                    info.IsVerbatim = true;
                }
            }

            while (true)
            {
                int beforeConsumed = TextWindow.Position;
                char consumedChar;
                char consumedSurrogate;

                if (TextWindow.PeekChar() == '&')
                {
                    if (!TextWindow.TryScanXmlEntity(out consumedChar, out consumedSurrogate))
                    {
                        // If it's not a valid entity, then it's not part of the identifier.
                        TextWindow.Reset(beforeConsumed);
                        goto LoopExit;
                    }
                }
                else
                {
                    consumedChar = TextWindow.NextChar();
                    consumedSurrogate = SlidingTextWindow.InvalidCharacter;
                }

                // NOTE: If the surrogate is non-zero, then consumedChar won't match
                // any of the cases below (UTF-16 guarantees that members of surrogate
                // pairs aren't separately valid).

                bool isEscaped = false;
top:
                switch (consumedChar)
                {
                    case '\\':
                        // NOTE: For completeness, we should allow xml entities in unicode escape
                        // sequences (DevDiv #16321).  Since it is not currently a priority, we will
                        // try to make the interim behavior sensible: we will only attempt to scan
                        // a unicode escape if NONE of the characters are XML entities (including
                        // the backslash, which we have already consumed).
                        // When we're ready to implement this behavior, we can drop the position
                        // check and use AdvanceIfMatches instead of PeekChar.
                        if (!isEscaped && (TextWindow.Position == beforeConsumed + 1) &&
                            (TextWindow.PeekChar() == 'u' || TextWindow.PeekChar() == 'U'))
                        {
                            Debug.Assert(consumedSurrogate == SlidingTextWindow.InvalidCharacter, "Since consumedChar == '\\'");

                            info.HasIdentifierEscapeSequence = true;

                            TextWindow.Reset(beforeConsumed);
                            // ^^^^^^^ otherwise \u005Cu1234 looks just like \u1234! (i.e. escape within escape)
                            isEscaped = true;
                            SyntaxDiagnosticInfo error;
                            consumedChar = TextWindow.NextUnicodeEscape(out consumedSurrogate, out error);
                            AddCrefError(error);
                            goto top;
                        }

                        goto default;

                    case '_':
                    case 'A':
                    case 'B':
                    case 'C':
                    case 'D':
                    case 'E':
                    case 'F':
                    case 'G':
                    case 'H':
                    case 'I':
                    case 'J':
                    case 'K':
                    case 'L':
                    case 'M':
                    case 'N':
                    case 'O':
                    case 'P':
                    case 'Q':
                    case 'R':
                    case 'S':
                    case 'T':
                    case 'U':
                    case 'V':
                    case 'W':
                    case 'X':
                    case 'Y':
                    case 'Z':
                    case 'a':
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'e':
                    case 'f':
                    case 'g':
                    case 'h':
                    case 'i':
                    case 'j':
                    case 'k':
                    case 'l':
                    case 'm':
                    case 'n':
                    case 'o':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                    case 'u':
                    case 'v':
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        {
                            // Again, these are the 'common' identifier characters...
                            break;
                        }

                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        {
                            if (_identLen == 0)
                            {
                                TextWindow.Reset(beforeConsumed);
                                goto LoopExit;
                            }

                            // Again, these are the 'common' identifier characters...
                            break;
                        }

                    case ' ':
                    case '$':
                    case '\t':
                    case '.':
                    case ';':
                    case '(':
                    case ')':
                    case ',':
                    case '<':
                        // ...and these are the 'common' stop characters.
                        TextWindow.Reset(beforeConsumed);
                        goto LoopExit;
                    case SlidingTextWindow.InvalidCharacter:
                        if (!TextWindow.IsReallyAtEnd())
                        {
                            goto default;
                        }

                        TextWindow.Reset(beforeConsumed);
                        goto LoopExit;
                    default:
                        {
                            // This is the 'expensive' call
                            if (_identLen == 0 && consumedChar > 127 && SyntaxFacts.IsIdentifierStartCharacter(consumedChar))
                            {
                                break;
                            }
                            else if (_identLen > 0 && consumedChar > 127 && SyntaxFacts.IsIdentifierPartCharacter(consumedChar))
                            {
                                //// BUG 424819 : Handle identifier chars > 0xFFFF via surrogate pairs
                                if (UnicodeCharacterUtilities.IsFormattingChar(consumedChar))
                                {
                                    continue; // Ignore formatting characters
                                }

                                break;
                            }
                            else
                            {
                                // Not a valid identifier character, so bail.
                                TextWindow.Reset(beforeConsumed);
                                goto LoopExit;
                            }
                        }
                }

                this.AddIdentChar(consumedChar);
                if (consumedSurrogate != SlidingTextWindow.InvalidCharacter)
                {
                    this.AddIdentChar(consumedSurrogate);
                }
            }

LoopExit:
            if (_identLen > 0)
            {
                // NOTE: If we don't intern the string value, then we won't get a hit
                // in the keyword dictionary!  (It searches for a key using identity.)
                // The text does not have to be interned (and probably shouldn't be
                // if it contains entities (else-case).

                var width = TextWindow.Width; // exact size of input characters

                // id buffer is identical to width in input
                if (_identLen == width)
                {
                    info.StringValue = TextWindow.GetInternedText();
                    info.Text = info.StringValue;
                }
                else
                {
                    info.StringValue = TextWindow.Intern(_identBuffer, 0, _identLen);
                    info.Text = TextWindow.GetText(intern: false);
                }

                return true;
            }
            else
            {
                info.Text = null;
                info.StringValue = null;
                TextWindow.Reset(start);
                return false;
            }
        }

        private bool ScanIdentifierOrKeyword(ref TokenInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 84807, 86932);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 84888, 84926);

                info.ContextualKind = SyntaxKind.None;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 84942, 86921) || true) && (f_10014_84946_84975(this, ref info))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 84942, 86921);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 85069, 86749) || true) && (!info.IsVerbatim && (DynAbs.Tracing.TraceSender.Expression_True(10014, 85073, 85126) && !info.HasIdentifierEscapeSequence))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 85069, 86749);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 85168, 86419) || true) && (f_10014_85172_85204(this, LexerMode.Directive))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 85168, 86419);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 85254, 85329);

                            SyntaxKind
                            keywordKind = f_10014_85279_85328(info.Text)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 85355, 85834) || true) && (f_10014_85359_85415(keywordKind))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 85355, 85834);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 85566, 85605);

                                info.Kind = SyntaxKind.IdentifierToken;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 85635, 85669);

                                info.ContextualKind = keywordKind;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 85355, 85834);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 85355, 85834);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 85783, 85807);

                                info.Kind = keywordKind;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 85355, 85834);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 85168, 86419);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 85168, 86419);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 85932, 86396) || true) && (!f_10014_85937_85987(_cache, info.Text, out info.Kind))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 85932, 86396);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 86045, 86106);

                                info.ContextualKind = info.Kind = SyntaxKind.IdentifierToken;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 85932, 86396);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 85932, 86396);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 86164, 86396) || true) && (f_10014_86168_86210(info.Kind))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 86164, 86396);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 86268, 86300);

                                    info.ContextualKind = info.Kind;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 86330, 86369);

                                    info.Kind = SyntaxKind.IdentifierToken;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 86164, 86396);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 85932, 86396);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 85168, 86419);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 86443, 86587) || true) && (info.Kind == SyntaxKind.None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 86443, 86587);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 86525, 86564);

                            info.Kind = SyntaxKind.IdentifierToken;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 86443, 86587);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 85069, 86749);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 85069, 86749);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 86669, 86730);

                        info.ContextualKind = info.Kind = SyntaxKind.IdentifierToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 85069, 86749);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 86769, 86781);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 84942, 86921);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 84942, 86921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 86847, 86875);

                    info.Kind = SyntaxKind.None;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 86893, 86906);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 84942, 86921);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 84807, 86932);

                bool
                f_10014_84946_84975(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info)
                {
                    var return_v = this_param.ScanIdentifier(ref info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 84946, 84975);
                    return return_v;
                }


                bool
                f_10014_85172_85204(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = this_param.ModeIs(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 85172, 85204);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10014_85279_85328(string
                text)
                {
                    var return_v = SyntaxFacts.GetPreprocessorKeywordKind(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 85279, 85328);
                    return return_v;
                }


                bool
                f_10014_85359_85415(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsPreprocessorContextualKeyword(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 85359, 85415);
                    return return_v;
                }


                bool
                f_10014_85937_85987(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerCache
                this_param, string
                key, out Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.TryGetKeywordKind(key, out kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 85937, 85987);
                    return return_v;
                }


                bool
                f_10014_86168_86210(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsContextualKeyword(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 86168, 86210);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 84807, 86932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 84807, 86932);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LexSyntaxTrivia(bool afterFirstToken, bool isTrailing, ref SyntaxListBuilder triviaList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 86944, 92840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 87070, 87110);

                bool
                onlyWhitespaceOnLine = !isTrailing
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 87126, 92829) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 87126, 92829);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 87171, 87184);

                        f_10014_87171_87183(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 87202, 87234);

                        char
                        ch = f_10014_87212_87233(TextWindow)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 87252, 87760) || true) && (ch == ' ')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 87252, 87760);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 87307, 87361);

                            f_10014_87307_87360(this, f_10014_87322_87343(this), ref triviaList);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 87383, 87392);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 87252, 87760);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 87252, 87760);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 87434, 87760) || true) && (ch > 127)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 87434, 87760);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 87488, 87741) || true) && (f_10014_87492_87520(ch))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 87488, 87741);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 87570, 87579);

                                    ch = ' ';
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 87488, 87741);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 87488, 87741);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 87629, 87741) || true) && (f_10014_87633_87658(ch))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 87629, 87741);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 87708, 87718);

                                        ch = '\n';
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 87629, 87741);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 87488, 87741);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 87434, 87760);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 87252, 87760);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 87780, 92814);

                        switch (ch)
                        {

                            case ' ':
                            case '\t':       // Horizontal tab
                            case '\v':       // Vertical Tab
                            case '\f':       // Form-feed
                            case '\u001A':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 87780, 92814);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 88064, 88118);

                                f_10014_88064_88117(this, f_10014_88079_88100(this), ref triviaList);
                                DynAbs.Tracing.TraceSender.TraceBreak(10014, 88144, 88150);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 87780, 92814);

                            case '/':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 87780, 92814);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 88207, 90931) || true) && ((ch = f_10014_88217_88239(TextWindow, 1)) == '/')
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 88207, 90931);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 88305, 88992) || true) && (f_10014_88309_88348_M(!this.SuppressDocumentationCommentParse) && (DynAbs.Tracing.TraceSender.Expression_True(10014, 88309, 88381) && f_10014_88352_88374(TextWindow, 2) == '/') && (DynAbs.Tracing.TraceSender.Expression_True(10014, 88309, 88414) && f_10014_88385_88407(TextWindow, 3) != '/'))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 88305, 88992);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 88670, 88800) || true) && (isTrailing)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 88670, 88800);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 88758, 88765);

                                            return;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 88670, 88800);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 88836, 88921);

                                        f_10014_88836_88920(
                                                                        this, f_10014_88851_88903(this, XmlDocCommentStyle.SingleLine), ref triviaList);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10014, 88955, 88961);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 88305, 88992);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 89083, 89106);

                                    f_10014_89083_89105(
                                                                // normal single line comment
                                                                this);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 89136, 89173);

                                    var
                                    text = f_10014_89147_89172(TextWindow, false)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 89203, 89263);

                                    f_10014_89203_89262(this, f_10014_89218_89245(text), ref triviaList);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 89293, 89322);

                                    onlyWhitespaceOnLine = false;
                                    DynAbs.Tracing.TraceSender.TraceBreak(10014, 89352, 89358);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 88207, 90931);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 88207, 90931);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 89416, 90931) || true) && (ch == '*')
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 89416, 90931);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 89487, 90239) || true) && (f_10014_89491_89530_M(!this.SuppressDocumentationCommentParse) && (DynAbs.Tracing.TraceSender.Expression_True(10014, 89491, 89563) && f_10014_89534_89556(TextWindow, 2) == '*') && (DynAbs.Tracing.TraceSender.Expression_True(10014, 89491, 89629) && f_10014_89600_89622(TextWindow, 3) != '*') && (DynAbs.Tracing.TraceSender.Expression_True(10014, 89491, 89662) && f_10014_89633_89655(TextWindow, 3) != '/'))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 89487, 90239);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 89918, 90048) || true) && (isTrailing)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 89918, 90048);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 90006, 90013);

                                                return;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 89918, 90048);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 90084, 90168);

                                            f_10014_90084_90167(
                                                                            this, f_10014_90099_90150(this, XmlDocCommentStyle.Delimited), ref triviaList);
                                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 90202, 90208);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 89487, 90239);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 90271, 90289);

                                        bool
                                        isTerminated
                                        = default(bool);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 90319, 90363);

                                        f_10014_90319_90362(this, out isTerminated);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 90393, 90650) || true) && (!isTerminated)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 90393, 90650);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 90573, 90619);

                                            f_10014_90573_90618(                                // The comment didn't end.  Report an error at the start point.
                                                                            this, ErrorCode.ERR_OpenEndedComment);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 90393, 90650);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 90682, 90719);

                                        var
                                        text = f_10014_90693_90718(TextWindow, false)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 90749, 90809);

                                        f_10014_90749_90808(this, f_10014_90764_90791(text), ref triviaList);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 90839, 90868);

                                        onlyWhitespaceOnLine = false;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10014, 90898, 90904);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 89416, 90931);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 88207, 90931);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 90998, 91005);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 87780, 92814);

                            case '\r':
                            case '\n':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 87780, 92814);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 91095, 91148);

                                f_10014_91095_91147(this, f_10014_91110_91130(this), ref triviaList);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 91174, 91280) || true) && (isTrailing)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 91174, 91280);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 91246, 91253);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 91174, 91280);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 91308, 91336);

                                onlyWhitespaceOnLine = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(10014, 91362, 91368);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 87780, 92814);

                            case '#':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 87780, 92814);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 91425, 91804) || true) && (_allowPreprocessorDirectives)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 91425, 91804);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 91515, 91620);

                                    f_10014_91515_91619(this, afterFirstToken, isTrailing || (DynAbs.Tracing.TraceSender.Expression_False(10014, 91567, 91602) || !onlyWhitespaceOnLine), ref triviaList);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10014, 91650, 91656);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 91425, 91804);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 91425, 91804);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 91770, 91777);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 91425, 91804);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 87780, 92814);

                            case '=':
                            case '<':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 87780, 92814);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 92385, 92695) || true) && (!isTrailing)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 92385, 92695);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 92458, 92668) || true) && (f_10014_92462_92486(this))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 92458, 92668);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 92552, 92597);

                                        f_10014_92552_92596(this, ref triviaList);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10014, 92631, 92637);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 92458, 92668);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 92385, 92695);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 92723, 92730);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 87780, 92814);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 87780, 92814);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 92788, 92795);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 87780, 92814);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 87126, 92829);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10014, 87126, 92829);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10014, 87126, 92829);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 86944, 92840);

                int
                f_10014_87171_87183(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 87171, 87183);
                    return 0;
                }


                char
                f_10014_87212_87233(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 87212, 87233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10014_87322_87343(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.ScanWhitespace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 87322, 87343);
                    return return_v;
                }


                int
                f_10014_87307_87360(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                trivia, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                list)
                {
                    this_param.AddTrivia((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode)trivia, ref list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 87307, 87360);
                    return 0;
                }


                bool
                f_10014_87492_87520(char
                ch)
                {
                    var return_v = SyntaxFacts.IsWhitespace(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 87492, 87520);
                    return return_v;
                }


                bool
                f_10014_87633_87658(char
                ch)
                {
                    var return_v = SyntaxFacts.IsNewLine(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 87633, 87658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10014_88079_88100(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.ScanWhitespace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 88079, 88100);
                    return return_v;
                }


                int
                f_10014_88064_88117(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                trivia, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                list)
                {
                    this_param.AddTrivia((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode)trivia, ref list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 88064, 88117);
                    return 0;
                }


                char
                f_10014_88217_88239(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 88217, 88239);
                    return return_v;
                }


                bool
                f_10014_88309_88348_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 88309, 88348);
                    return return_v;
                }


                char
                f_10014_88352_88374(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 88352, 88374);
                    return return_v;
                }


                char
                f_10014_88385_88407(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 88385, 88407);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                f_10014_88851_88903(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlDocCommentStyle
                style)
                {
                    var return_v = this_param.LexXmlDocComment(style);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 88851, 88903);
                    return return_v;
                }


                int
                f_10014_88836_88920(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                trivia, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                list)
                {
                    this_param.AddTrivia(trivia, ref list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 88836, 88920);
                    return 0;
                }


                int
                f_10014_89083_89105(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    this_param.ScanToEndOfLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 89083, 89105);
                    return 0;
                }


                string
                f_10014_89147_89172(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, bool
                intern)
                {
                    var return_v = this_param.GetText(intern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 89147, 89172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10014_89218_89245(string
                text)
                {
                    var return_v = SyntaxFactory.Comment(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 89218, 89245);
                    return return_v;
                }


                int
                f_10014_89203_89262(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                trivia, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                list)
                {
                    this_param.AddTrivia((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode)trivia, ref list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 89203, 89262);
                    return 0;
                }


                bool
                f_10014_89491_89530_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 89491, 89530);
                    return return_v;
                }


                char
                f_10014_89534_89556(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 89534, 89556);
                    return return_v;
                }


                char
                f_10014_89600_89622(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 89600, 89622);
                    return return_v;
                }


                char
                f_10014_89633_89655(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 89633, 89655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                f_10014_90099_90150(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlDocCommentStyle
                style)
                {
                    var return_v = this_param.LexXmlDocComment(style);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 90099, 90150);
                    return return_v;
                }


                int
                f_10014_90084_90167(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                trivia, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                list)
                {
                    this_param.AddTrivia(trivia, ref list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 90084, 90167);
                    return 0;
                }


                bool
                f_10014_90319_90362(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, out bool
                isTerminated)
                {
                    var return_v = this_param.ScanMultiLineComment(out isTerminated);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 90319, 90362);
                    return return_v;
                }


                int
                f_10014_90573_90618(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    this_param.AddError(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 90573, 90618);
                    return 0;
                }


                string
                f_10014_90693_90718(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, bool
                intern)
                {
                    var return_v = this_param.GetText(intern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 90693, 90718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10014_90764_90791(string
                text)
                {
                    var return_v = SyntaxFactory.Comment(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 90764, 90791);
                    return return_v;
                }


                int
                f_10014_90749_90808(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                trivia, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                list)
                {
                    this_param.AddTrivia((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode)trivia, ref list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 90749, 90808);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                f_10014_91110_91130(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.ScanEndOfLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 91110, 91130);
                    return return_v;
                }


                int
                f_10014_91095_91147(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                trivia, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                list)
                {
                    this_param.AddTrivia(trivia, ref list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 91095, 91147);
                    return 0;
                }


                int
                f_10014_91515_91619(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, bool
                afterFirstToken, bool
                afterNonWhitespaceOnLine, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                triviaList)
                {
                    this_param.LexDirectiveAndExcludedTrivia(afterFirstToken, afterNonWhitespaceOnLine, ref triviaList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 91515, 91619);
                    return 0;
                }


                bool
                f_10014_92462_92486(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.IsConflictMarkerTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 92462, 92486);
                    return return_v;
                }


                int
                f_10014_92552_92596(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                triviaList)
                {
                    this_param.LexConflictMarkerTrivia(ref triviaList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 92552, 92596);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 86944, 92840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 86944, 92840);
            }
        }

        private static readonly int s_conflictMarkerLength;

        private bool IsConflictMarkerTrivia()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 93106, 94197);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 93168, 93203);

                var
                position = f_10014_93183_93202(TextWindow)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 93217, 93244);

                var
                text = f_10014_93228_93243(TextWindow)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 93258, 94157) || true) && (position == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10014, 93262, 93320) || f_10014_93279_93320(f_10014_93301_93319(text, position - 1))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 93258, 94157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 93354, 93383);

                    var
                    firstCh = f_10014_93368_93382(text, position)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 93401, 93466);

                    f_10014_93401_93465(firstCh == '<' || (DynAbs.Tracing.TraceSender.Expression_False(10014, 93414, 93446) || firstCh == '=') || (DynAbs.Tracing.TraceSender.Expression_False(10014, 93414, 93464) || firstCh == '>'));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 93486, 94142) || true) && ((position + s_conflictMarkerLength) <= f_10014_93529_93540(text))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 93486, 94142);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 93591, 93596);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 93598, 93624);
                            for (int
        i = 0
        ,
        n = s_conflictMarkerLength
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 93582, 93840) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 93633, 93636)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 93582, 93840))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 93582, 93840);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 93686, 93817) || true) && (f_10014_93690_93708(text, position + i) != firstCh)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 93686, 93817);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 93777, 93790);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 93686, 93817);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10014, 1, 259);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10014, 1, 259);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 93864, 93967) || true) && (firstCh == '=')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 93864, 93967);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 93932, 93944);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 93864, 93967);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 93991, 94123);

                        return (position + s_conflictMarkerLength) < f_10014_94036_94047(text) && (DynAbs.Tracing.TraceSender.Expression_True(10014, 93998, 94122) && f_10014_94076_94115(text, position + s_conflictMarkerLength) == ' ');
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 93486, 94142);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 93258, 94157);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 94173, 94186);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 93106, 94197);

                int
                f_10014_93183_93202(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 93183, 93202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_10014_93228_93243(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 93228, 93243);
                    return return_v;
                }


                char
                f_10014_93301_93319(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 93301, 93319);
                    return return_v;
                }


                bool
                f_10014_93279_93320(char
                ch)
                {
                    var return_v = SyntaxFacts.IsNewLine(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 93279, 93320);
                    return return_v;
                }


                char
                f_10014_93368_93382(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 93368, 93382);
                    return return_v;
                }


                int
                f_10014_93401_93465(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 93401, 93465);
                    return 0;
                }


                int
                f_10014_93529_93540(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 93529, 93540);
                    return return_v;
                }


                char
                f_10014_93690_93708(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 93690, 93708);
                    return return_v;
                }


                int
                f_10014_94036_94047(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 94036, 94047);
                    return return_v;
                }


                char
                f_10014_94076_94115(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 94076, 94115);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 93106, 94197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 93106, 94197);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LexConflictMarkerTrivia(ref SyntaxListBuilder triviaList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 94209, 95161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 94304, 94317);

                f_10014_94304_94316(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 94333, 94458);

                f_10014_94333_94457(
                            this, f_10014_94347_94366(TextWindow), s_conflictMarkerLength, ErrorCode.ERR_Merge_conflict_marker_encountered);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 94474, 94515);

                var
                startCh = f_10014_94488_94514(this.TextWindow)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 94679, 94719);

                f_10014_94679_94718(this, ref triviaList);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 94792, 94835);

                f_10014_94792_94834(this, ref triviaList);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 95037, 95150) || true) && (startCh == '=')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 95037, 95150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 95089, 95135);

                    f_10014_95089_95134(this, ref triviaList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 95037, 95150);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 94209, 95161);

                int
                f_10014_94304_94316(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 94304, 94316);
                    return 0;
                }


                int
                f_10014_94347_94366(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 94347, 94366);
                    return return_v;
                }


                int
                f_10014_94333_94457(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, int
                position, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    this_param.AddError(position, width, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 94333, 94457);
                    return 0;
                }


                char
                f_10014_94488_94514(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 94488, 94514);
                    return return_v;
                }


                int
                f_10014_94679_94718(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                triviaList)
                {
                    this_param.LexConflictMarkerHeader(ref triviaList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 94679, 94718);
                    return 0;
                }


                int
                f_10014_94792_94834(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                triviaList)
                {
                    this_param.LexConflictMarkerEndOfLine(ref triviaList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 94792, 94834);
                    return 0;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                f_10014_95089_95134(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                triviaList)
                {
                    var return_v = this_param.LexConflictMarkerDisabledText(ref triviaList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 95089, 95134);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 94209, 95161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 94209, 95161);
            }
        }

        private SyntaxListBuilder LexConflictMarkerDisabledText(ref SyntaxListBuilder triviaList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 95173, 96395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 95426, 95439);

                f_10014_95426_95438(            // Consume everything from the start of the mid-conflict marker to the start of the next
                                                // end-conflict marker.
                            this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 95455, 95488);

                var
                hitEndConflictMarker = false
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 95502, 96041) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 95502, 96041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 95547, 95583);

                        var
                        ch = f_10014_95556_95582(this.TextWindow)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 95601, 95712) || true) && (ch == SlidingTextWindow.InvalidCharacter)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 95601, 95712);
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 95687, 95693);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 95601, 95712);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 95818, 95976) || true) && (ch == '>' && (DynAbs.Tracing.TraceSender.Expression_True(10014, 95822, 95859) && f_10014_95835_95859(this)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 95818, 95976);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 95901, 95929);

                            hitEndConflictMarker = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 95951, 95957);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 95818, 95976);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 95996, 96026);

                        f_10014_95996_96025(
                                        this.TextWindow);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 95502, 96041);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10014, 95502, 96041);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10014, 95502, 96041);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 96057, 96221) || true) && (f_10014_96061_96082(this.TextWindow) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 96057, 96221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 96120, 96206);

                    f_10014_96120_96205(this, f_10014_96135_96188(f_10014_96162_96187(TextWindow, false)), ref triviaList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 96057, 96221);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 96237, 96350) || true) && (hitEndConflictMarker)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 96237, 96350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 96295, 96335);

                    f_10014_96295_96334(this, ref triviaList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 96237, 96350);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 96366, 96384);

                return triviaList;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 95173, 96395);

                int
                f_10014_95426_95438(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 95426, 95438);
                    return 0;
                }


                char
                f_10014_95556_95582(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 95556, 95582);
                    return return_v;
                }


                bool
                f_10014_95835_95859(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.IsConflictMarkerTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 95835, 95859);
                    return return_v;
                }


                int
                f_10014_95996_96025(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 95996, 96025);
                    return 0;
                }


                int
                f_10014_96061_96082(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 96061, 96082);
                    return return_v;
                }


                string
                f_10014_96162_96187(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, bool
                intern)
                {
                    var return_v = this_param.GetText(intern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 96162, 96187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10014_96135_96188(string
                text)
                {
                    var return_v = SyntaxFactory.DisabledText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 96135, 96188);
                    return return_v;
                }


                int
                f_10014_96120_96205(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                trivia, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                list)
                {
                    this_param.AddTrivia((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode)trivia, ref list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 96120, 96205);
                    return 0;
                }


                int
                f_10014_96295_96334(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                triviaList)
                {
                    this_param.LexConflictMarkerTrivia(ref triviaList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 96295, 96334);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 95173, 96395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 95173, 96395);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LexConflictMarkerEndOfLine(ref SyntaxListBuilder triviaList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 96407, 96855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 96505, 96518);

                f_10014_96505_96517(this);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 96532, 96667) || true) && (f_10014_96539_96588(f_10014_96561_96587(this.TextWindow)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 96532, 96667);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 96622, 96652);

                        f_10014_96622_96651(this.TextWindow);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 96532, 96667);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10014, 96532, 96667);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10014, 96532, 96667);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 96683, 96844) || true) && (f_10014_96687_96708(this.TextWindow) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 96683, 96844);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 96746, 96829);

                    f_10014_96746_96828(this, f_10014_96761_96811(f_10014_96785_96810(TextWindow, false)), ref triviaList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 96683, 96844);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 96407, 96855);

                int
                f_10014_96505_96517(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 96505, 96517);
                    return 0;
                }


                char
                f_10014_96561_96587(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 96561, 96587);
                    return return_v;
                }


                bool
                f_10014_96539_96588(char
                ch)
                {
                    var return_v = SyntaxFacts.IsNewLine(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 96539, 96588);
                    return return_v;
                }


                int
                f_10014_96622_96651(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 96622, 96651);
                    return 0;
                }


                int
                f_10014_96687_96708(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 96687, 96708);
                    return return_v;
                }


                string
                f_10014_96785_96810(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, bool
                intern)
                {
                    var return_v = this_param.GetText(intern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 96785, 96810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10014_96761_96811(string
                text)
                {
                    var return_v = SyntaxFactory.EndOfLine(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 96761, 96811);
                    return return_v;
                }


                int
                f_10014_96746_96828(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                trivia, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                list)
                {
                    this_param.AddTrivia((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode)trivia, ref list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 96746, 96828);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 96407, 96855);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 96407, 96855);
            }
        }

        private void LexConflictMarkerHeader(ref SyntaxListBuilder triviaList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 96867, 97381);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 96962, 97266) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 96962, 97266);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 97007, 97043);

                        var
                        ch = f_10014_97016_97042(this.TextWindow)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 97061, 97201) || true) && (ch == SlidingTextWindow.InvalidCharacter || (DynAbs.Tracing.TraceSender.Expression_False(10014, 97065, 97134) || f_10014_97109_97134(ch)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 97061, 97201);
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 97176, 97182);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 97061, 97201);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 97221, 97251);

                        f_10014_97221_97250(
                                        this.TextWindow);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 96962, 97266);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10014, 96962, 97266);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10014, 96962, 97266);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 97282, 97370);

                f_10014_97282_97369(
                            this, f_10014_97297_97352(f_10014_97326_97351(TextWindow, false)), ref triviaList);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 96867, 97381);

                char
                f_10014_97016_97042(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 97016, 97042);
                    return return_v;
                }


                bool
                f_10014_97109_97134(char
                ch)
                {
                    var return_v = SyntaxFacts.IsNewLine(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 97109, 97134);
                    return return_v;
                }


                int
                f_10014_97221_97250(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 97221, 97250);
                    return 0;
                }


                string
                f_10014_97326_97351(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, bool
                intern)
                {
                    var return_v = this_param.GetText(intern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 97326, 97351);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10014_97297_97352(string
                text)
                {
                    var return_v = SyntaxFactory.ConflictMarker(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 97297, 97352);
                    return return_v;
                }


                int
                f_10014_97282_97369(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                trivia, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                list)
                {
                    this_param.AddTrivia((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode)trivia, ref list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 97282, 97369);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 96867, 97381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 96867, 97381);
            }
        }

        private void AddTrivia(CSharpSyntaxNode trivia, ref SyntaxListBuilder list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 97393, 97817);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 97493, 97636) || true) && (f_10014_97497_97511(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 97493, 97636);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 97545, 97621);

                    trivia = f_10014_97554_97620(trivia, f_10014_97582_97619(this, leadingTriviaWidth: 0));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 97493, 97636);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 97652, 97773) || true) && (list == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 97652, 97773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 97702, 97758);

                    list = f_10014_97709_97757(TriviaListInitialCapacity);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 97652, 97773);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 97789, 97806);

                f_10014_97789_97805(
                            list, trivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 97393, 97817);

                bool
                f_10014_97497_97511(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 97497, 97511);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
                f_10014_97582_97619(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, int
                leadingTriviaWidth)
                {
                    var return_v = this_param.GetErrors(leadingTriviaWidth: leadingTriviaWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 97582, 97619);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                f_10014_97554_97620(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
                diagnostics)
                {
                    var return_v = node.WithDiagnosticsGreen<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>((Microsoft.CodeAnalysis.DiagnosticInfo[])diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 97554, 97620);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                f_10014_97709_97757(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 97709, 97757);
                    return return_v;
                }


                int
                f_10014_97789_97805(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.GreenNode)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 97789, 97805);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 97393, 97817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 97393, 97817);
            }
        }

        private bool ScanMultiLineComment(out bool isTerminated)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 97829, 98928);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 97910, 98917) || true) && (f_10014_97914_97935(TextWindow) == '/' && (DynAbs.Tracing.TraceSender.Expression_True(10014, 97914, 97975) && f_10014_97946_97968(TextWindow, 1) == '*'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 97910, 98917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 98009, 98035);

                    f_10014_98009_98034(TextWindow, 2);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 98055, 98063);

                    char
                    ch
                    = default(char);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 98081, 98752) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 98081, 98752);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 98134, 98733) || true) && ((ch = f_10014_98144_98165(TextWindow)) == SlidingTextWindow.InvalidCharacter && (DynAbs.Tracing.TraceSender.Expression_True(10014, 98138, 98234) && f_10014_98208_98234(TextWindow)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 98134, 98733);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 98284, 98305);

                                isTerminated = false;
                                DynAbs.Tracing.TraceSender.TraceBreak(10014, 98331, 98337);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 98134, 98733);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 98134, 98733);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 98387, 98733) || true) && (ch == '*' && (DynAbs.Tracing.TraceSender.Expression_True(10014, 98391, 98433) && f_10014_98404_98426(TextWindow, 1) == '/'))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 98387, 98733);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 98483, 98509);

                                    f_10014_98483_98508(TextWindow, 2);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 98535, 98555);

                                    isTerminated = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(10014, 98581, 98587);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 98387, 98733);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 98387, 98733);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 98685, 98710);

                                    f_10014_98685_98709(TextWindow);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 98387, 98733);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 98134, 98733);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 98081, 98752);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10014, 98081, 98752);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10014, 98081, 98752);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 98772, 98784);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 97910, 98917);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 97910, 98917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 98850, 98871);

                    isTerminated = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 98889, 98902);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 97910, 98917);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 97829, 98928);

                char
                f_10014_97914_97935(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 97914, 97935);
                    return return_v;
                }


                char
                f_10014_97946_97968(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 97946, 97968);
                    return return_v;
                }


                int
                f_10014_98009_98034(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                n)
                {
                    this_param.AdvanceChar(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 98009, 98034);
                    return 0;
                }


                char
                f_10014_98144_98165(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 98144, 98165);
                    return return_v;
                }


                bool
                f_10014_98208_98234(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.IsReallyAtEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 98208, 98234);
                    return return_v;
                }


                char
                f_10014_98404_98426(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 98404, 98426);
                    return return_v;
                }


                int
                f_10014_98483_98508(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                n)
                {
                    this_param.AdvanceChar(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 98483, 98508);
                    return 0;
                }


                int
                f_10014_98685_98709(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 98685, 98709);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 97829, 98928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 97829, 98928);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ScanToEndOfLine()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 98940, 99253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 98995, 99003);

                char
                ch
                = default(char);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 99017, 99242) || true) && (!f_10014_99025_99074(ch = f_10014_99052_99073(TextWindow)) && (DynAbs.Tracing.TraceSender.Expression_True(10014, 99024, 99168) && (ch != SlidingTextWindow.InvalidCharacter || (DynAbs.Tracing.TraceSender.Expression_False(10014, 99096, 99167) || !f_10014_99141_99167(TextWindow)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 99017, 99242);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 99202, 99227);

                        f_10014_99202_99226(TextWindow);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 99017, 99242);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10014, 99017, 99242);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10014, 99017, 99242);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 98940, 99253);

                char
                f_10014_99052_99073(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 99052, 99073);
                    return return_v;
                }


                bool
                f_10014_99025_99074(char
                ch)
                {
                    var return_v = SyntaxFacts.IsNewLine(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 99025, 99074);
                    return return_v;
                }


                bool
                f_10014_99141_99167(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.IsReallyAtEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 99141, 99167);
                    return return_v;
                }


                int
                f_10014_99202_99226(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 99202, 99226);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 98940, 99253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 98940, 99253);
            }
        }

        private CSharpSyntaxNode ScanEndOfLine()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 99475, 100406);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 99540, 99548);

                char
                ch
                = default(char);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 99562, 100395);

                switch (ch = f_10014_99575_99596(TextWindow))
                {

                    case '\r':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 99562, 100395);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 99662, 99687);

                        f_10014_99662_99686(TextWindow);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 99709, 99910) || true) && (f_10014_99713_99734(TextWindow) == '\n')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 99709, 99910);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 99792, 99817);

                            f_10014_99792_99816(TextWindow);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 99843, 99887);

                            return SyntaxFactory.CarriageReturnLineFeed;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 99709, 99910);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 99934, 99970);

                        return SyntaxFactory.CarriageReturn;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 99562, 100395);

                    case '\n':
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 99562, 100395);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 100020, 100045);

                        f_10014_100020_100044(TextWindow);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 100067, 100097);

                        return SyntaxFactory.LineFeed;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 99562, 100395);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 99562, 100395);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 100145, 100344) || true) && (f_10014_100149_100174(ch))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 100145, 100344);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 100224, 100249);

                            f_10014_100224_100248(TextWindow);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 100275, 100321);

                            return f_10014_100282_100320(f_10014_100306_100319(ch));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 100145, 100344);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 100368, 100380);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 99562, 100395);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 99475, 100406);

                char
                f_10014_99575_99596(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 99575, 99596);
                    return return_v;
                }


                int
                f_10014_99662_99686(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 99662, 99686);
                    return 0;
                }


                char
                f_10014_99713_99734(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 99713, 99734);
                    return return_v;
                }


                int
                f_10014_99792_99816(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 99792, 99816);
                    return 0;
                }


                int
                f_10014_100020_100044(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 100020, 100044);
                    return 0;
                }


                bool
                f_10014_100149_100174(char
                ch)
                {
                    var return_v = SyntaxFacts.IsNewLine(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 100149, 100174);
                    return return_v;
                }


                int
                f_10014_100224_100248(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 100224, 100248);
                    return 0;
                }


                string
                f_10014_100306_100319(char
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 100306, 100319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10014_100282_100320(string
                text)
                {
                    var return_v = SyntaxFactory.EndOfLine(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 100282, 100320);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 99475, 100406);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 99475, 100406);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxTrivia ScanWhitespace()
        {
            if (_createWhitespaceTriviaFunction == null)
            {
                _createWhitespaceTriviaFunction = this.CreateWhitespaceTrivia;
            }

            int hashCode = Hash.FnvOffsetBias;  // FNV base
            bool onlySpaces = true;

top:
            char ch = TextWindow.PeekChar();

            switch (ch)
            {
                case '\t':       // Horizontal tab
                case '\v':       // Vertical Tab
                case '\f':       // Form-feed
                case '\u001A':
                    onlySpaces = false;
                    goto case ' ';

                case ' ':
                    TextWindow.AdvanceChar();
                    hashCode = Hash.CombineFNVHash(hashCode, ch);
                    goto top;

                case '\r':      // Carriage Return
                case '\n':      // Line-feed
                    break;

                default:
                    if (ch > 127 && SyntaxFacts.IsWhitespace(ch))
                    {
                        goto case '\t';
                    }

                    break;
            }

            if (TextWindow.Width == 1 && onlySpaces)
            {
                return SyntaxFactory.Space;
            }
            else
            {
                var width = TextWindow.Width;

                if (width < MaxCachedTokenSize)
                {
                    return _cache.LookupTrivia(
                        TextWindow.CharacterWindow,
                        TextWindow.LexemeRelativeStart,
                        width,
                        hashCode,
                        _createWhitespaceTriviaFunction);
                }
                else
                {
                    return _createWhitespaceTriviaFunction();
                }
            }
        }

        private Func<SyntaxTrivia> _createWhitespaceTriviaFunction;

        private SyntaxTrivia CreateWhitespaceTrivia()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 102647, 102794);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 102717, 102783);

                return f_10014_102724_102782(f_10014_102749_102781(TextWindow, intern: true));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 102647, 102794);

                string
                f_10014_102749_102781(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, bool
                intern)
                {
                    var return_v = this_param.GetText(intern: intern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 102749, 102781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10014_102724_102782(string
                text)
                {
                    var return_v = SyntaxFactory.Whitespace(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 102724, 102782);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 102647, 102794);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 102647, 102794);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LexDirectiveAndExcludedTrivia(
                    bool afterFirstToken,
                    bool afterNonWhitespaceOnLine,
                    ref SyntaxListBuilder triviaList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 102806, 103418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 103000, 103111);

                var
                directive = f_10014_103016_103110(this, true, true, afterFirstToken, afterNonWhitespaceOnLine, ref triviaList)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 103179, 103239);

                var
                branching = directive as BranchingDirectiveTriviaSyntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 103253, 103407) || true) && (branching != null && (DynAbs.Tracing.TraceSender.Expression_True(10014, 103257, 103300) && f_10014_103278_103300_M(!branching.BranchTaken)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 103253, 103407);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 103334, 103392);

                    f_10014_103334_103391(this, true, ref triviaList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 103253, 103407);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 102806, 103418);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                f_10014_103016_103110(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, bool
                isActive, bool
                endIsActive, bool
                afterFirstToken, bool
                afterNonWhitespaceOnLine, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                triviaList)
                {
                    var return_v = this_param.LexSingleDirective(isActive, endIsActive, afterFirstToken, afterNonWhitespaceOnLine, ref triviaList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 103016, 103110);
                    return return_v;
                }


                bool
                f_10014_103278_103300_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 103278, 103300);
                    return return_v;
                }


                int
                f_10014_103334_103391(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, bool
                endIsActive, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                triviaList)
                {
                    this_param.LexExcludedDirectivesAndTrivia(endIsActive, ref triviaList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 103334, 103391);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 102806, 103418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 102806, 103418);
            }
        }

        private void LexExcludedDirectivesAndTrivia(bool endIsActive, ref SyntaxListBuilder triviaList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 103430, 104537);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 103550, 104526) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 103550, 104526);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 103595, 103622);

                        bool
                        hasFollowingDirective
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 103640, 103699);

                        var
                        text = f_10014_103651_103698(this, out hasFollowingDirective)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 103717, 103831) || true) && (text != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 103717, 103831);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 103775, 103812);

                            f_10014_103775_103811(this, text, ref triviaList);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 103717, 103831);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 103851, 103944) || true) && (!hasFollowingDirective)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 103851, 103944);
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 103919, 103925);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 103851, 103944);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 103964, 104054);

                        var
                        directive = f_10014_103980_104053(this, false, endIsActive, false, false, ref triviaList)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 104072, 104132);

                        var
                        branching = directive as BranchingDirectiveTriviaSyntax
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 104150, 104511) || true) && (f_10014_104154_104168(directive) == SyntaxKind.EndIfDirectiveTrivia || (DynAbs.Tracing.TraceSender.Expression_False(10014, 104154, 104251) || (branching != null && (DynAbs.Tracing.TraceSender.Expression_True(10014, 104208, 104250) && f_10014_104229_104250(branching)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 104150, 104511);
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 104293, 104299);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 104150, 104511);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 104150, 104511);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 104341, 104511) || true) && (f_10014_104345_104359(directive) == SyntaxKind.IfDirectiveTrivia)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 104341, 104511);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 104433, 104492);

                                f_10014_104433_104491(this, false, ref triviaList);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 104341, 104511);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 104150, 104511);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 103550, 104526);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10014, 103550, 104526);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10014, 103550, 104526);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 103430, 104537);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                f_10014_103651_103698(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, out bool
                followedByDirective)
                {
                    var return_v = this_param.LexDisabledText(out followedByDirective);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 103651, 103698);
                    return return_v;
                }


                int
                f_10014_103775_103811(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                trivia, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                list)
                {
                    this_param.AddTrivia(trivia, ref list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 103775, 103811);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                f_10014_103980_104053(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, bool
                isActive, bool
                endIsActive, bool
                afterFirstToken, bool
                afterNonWhitespaceOnLine, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                triviaList)
                {
                    var return_v = this_param.LexSingleDirective(isActive, endIsActive, afterFirstToken, afterNonWhitespaceOnLine, ref triviaList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 103980, 104053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10014_104154_104168(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 104154, 104168);
                    return return_v;
                }


                bool
                f_10014_104229_104250(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BranchingDirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.BranchTaken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 104229, 104250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10014_104345_104359(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 104345, 104359);
                    return return_v;
                }


                int
                f_10014_104433_104491(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, bool
                endIsActive, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                triviaList)
                {
                    this_param.LexExcludedDirectivesAndTrivia(endIsActive, ref triviaList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 104433, 104491);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 103430, 104537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 103430, 104537);
            }
        }

        private CSharpSyntaxNode LexSingleDirective(
                    bool isActive,
                    bool endIsActive,
                    bool afterFirstToken,
                    bool afterNonWhitespaceOnLine,
                    ref SyntaxListBuilder triviaList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 104549, 105479);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 104803, 104988) || true) && (f_10014_104807_104854(f_10014_104832_104853(TextWindow)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 104803, 104988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 104888, 104901);

                    f_10014_104888_104900(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 104919, 104973);

                    f_10014_104919_104972(this, f_10014_104934_104955(this), ref triviaList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 104803, 104988);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 105004, 105031);

                CSharpSyntaxNode
                directive
                = default(CSharpSyntaxNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 105045, 105066);

                var
                saveMode = _mode
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 105082, 105281);
                using (var
                dp = f_10014_105098_105136(this, _directives)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 105170, 105266);

                    directive = f_10014_105182_105265(dp, isActive, endIsActive, afterFirstToken, afterNonWhitespaceOnLine);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(10014, 105082, 105281);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 105297, 105339);

                f_10014_105297_105338(
                            this, directive, ref triviaList);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 105353, 105406);

                _directives = f_10014_105367_105405(directive, _directives);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 105420, 105437);

                _mode = saveMode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 105451, 105468);

                return directive;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 104549, 105479);

                char
                f_10014_104832_104853(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 104832, 104853);
                    return return_v;
                }


                bool
                f_10014_104807_104854(char
                ch)
                {
                    var return_v = SyntaxFacts.IsWhitespace(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 104807, 104854);
                    return return_v;
                }


                int
                f_10014_104888_104900(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 104888, 104900);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                f_10014_104934_104955(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.ScanWhitespace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 104934, 104955);
                    return return_v;
                }


                int
                f_10014_104919_104972(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
                trivia, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                list)
                {
                    this_param.AddTrivia((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode)trivia, ref list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 104919, 104972);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                f_10014_105098_105136(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                lexer, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                context)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser(lexer, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 105098, 105136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                f_10014_105182_105265(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveParser
                this_param, bool
                isActive, bool
                endIsActive, bool
                isAfterFirstTokenInFile, bool
                isAfterNonWhitespaceOnLine)
                {
                    var return_v = this_param.ParseDirective(isActive, endIsActive, isAfterFirstTokenInFile, isAfterNonWhitespaceOnLine);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 105182, 105265);
                    return return_v;
                }


                int
                f_10014_105297_105338(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                trivia, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                list)
                {
                    this_param.AddTrivia(trivia, ref list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 105297, 105338);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                f_10014_105367_105405(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                stack)
                {
                    var return_v = this_param.ApplyDirectives(stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 105367, 105405);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 104549, 105479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 104549, 105479);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CSharpSyntaxNode LexDisabledText(out bool followedByDirective)
        {
            this.Start();

            int lastLineStart = TextWindow.Position;
            int lines = 0;
            bool allWhitespace = true;

            while (true)
            {
                char ch = TextWindow.PeekChar();
                switch (ch)
                {
                    case SlidingTextWindow.InvalidCharacter:
                        if (!TextWindow.IsReallyAtEnd())
                        {
                            goto default;
                        }

                        followedByDirective = false;
                        return TextWindow.Width > 0 ? SyntaxFactory.DisabledText(TextWindow.GetText(false)) : null;
                    case '#':
                        if (!_allowPreprocessorDirectives) goto default;
                        followedByDirective = true;
                        if (lastLineStart < TextWindow.Position && !allWhitespace)
                        {
                            goto default;
                        }

                        TextWindow.Reset(lastLineStart);  // reset so directive parser can consume the starting whitespace on this line
                        return TextWindow.Width > 0 ? SyntaxFactory.DisabledText(TextWindow.GetText(false)) : null;
                    case '\r':
                    case '\n':
                        this.ScanEndOfLine();
                        lastLineStart = TextWindow.Position;
                        allWhitespace = true;
                        lines++;
                        break;
                    default:
                        if (SyntaxFacts.IsNewLine(ch))
                        {
                            goto case '\n';
                        }

                        allWhitespace = allWhitespace && SyntaxFacts.IsWhitespace(ch);
                        TextWindow.AdvanceChar();
                        break;
                }
            }
        }

        private SyntaxToken LexDirectiveToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 107600, 108019);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 107664, 107677);

                f_10014_107664_107676(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 107691, 107727);

                TokenInfo
                info = default(TokenInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 107741, 107775);

                f_10014_107741_107774(this, ref info);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 107789, 107840);

                var
                errors = f_10014_107802_107839(this, leadingTriviaWidth: 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 107854, 107946);

                var
                trailing = f_10014_107869_107945(this, info.Kind == SyntaxKind.EndOfDirectiveToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 107960, 108008);

                return f_10014_107967_108007(this, ref info, null, trailing, errors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 107600, 108019);

                int
                f_10014_107664_107676(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 107664, 107676);
                    return 0;
                }


                bool
                f_10014_107741_107774(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info)
                {
                    var return_v = this_param.ScanDirectiveToken(ref info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 107741, 107774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
                f_10014_107802_107839(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, int
                leadingTriviaWidth)
                {
                    var return_v = this_param.GetErrors(leadingTriviaWidth: leadingTriviaWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 107802, 107839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                f_10014_107869_107945(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, bool
                includeEndOfLine)
                {
                    var return_v = this_param.LexDirectiveTrailingTrivia(includeEndOfLine);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 107869, 107945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_107967_108007(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                leading, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                trailing, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
                errors)
                {
                    var return_v = this_param.Create(ref info, leading, trailing, errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 107967, 108007);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 107600, 108019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 107600, 108019);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ScanDirectiveToken(ref TokenInfo info)
        {
            char character;
            char surrogateCharacter;
            bool isEscaped = false;

            switch (character = TextWindow.PeekChar())
            {
                case SlidingTextWindow.InvalidCharacter:
                    if (!TextWindow.IsReallyAtEnd())
                    {
                        goto default;
                    }
                    // don't consume end characters here
                    info.Kind = SyntaxKind.EndOfDirectiveToken;
                    break;

                case '\r':
                case '\n':
                    // don't consume end characters here
                    info.Kind = SyntaxKind.EndOfDirectiveToken;
                    break;

                case '#':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.HashToken;
                    break;

                case '(':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.OpenParenToken;
                    break;

                case ')':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.CloseParenToken;
                    break;

                case ',':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.CommaToken;
                    break;

                case '!':
                    TextWindow.AdvanceChar();
                    if (TextWindow.PeekChar() == '=')
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.ExclamationEqualsToken;
                    }
                    else
                    {
                        info.Kind = SyntaxKind.ExclamationToken;
                    }

                    break;

                case '=':
                    TextWindow.AdvanceChar();
                    if (TextWindow.PeekChar() == '=')
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.EqualsEqualsToken;
                    }
                    else
                    {
                        info.Kind = SyntaxKind.EqualsToken;
                    }

                    break;

                case '&':
                    if (TextWindow.PeekChar(1) == '&')
                    {
                        TextWindow.AdvanceChar(2);
                        info.Kind = SyntaxKind.AmpersandAmpersandToken;
                        break;
                    }

                    goto default;

                case '|':
                    if (TextWindow.PeekChar(1) == '|')
                    {
                        TextWindow.AdvanceChar(2);
                        info.Kind = SyntaxKind.BarBarToken;
                        break;
                    }

                    goto default;

                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    this.ScanInteger();
                    info.Kind = SyntaxKind.NumericLiteralToken;
                    info.Text = TextWindow.GetText(true);
                    info.ValueKind = SpecialType.System_Int32;
                    info.IntValue = this.GetValueInt32(info.Text, false);
                    break;

                case '\"':
                    this.ScanStringLiteral(ref info, false);
                    break;

                case '\\':
                    {
                        // Could be unicode escape. Try that.
                        character = TextWindow.PeekCharOrUnicodeEscape(out surrogateCharacter);
                        isEscaped = true;
                        if (SyntaxFacts.IsIdentifierStartCharacter(character))
                        {
                            this.ScanIdentifierOrKeyword(ref info);
                            break;
                        }

                        goto default;
                    }

                default:
                    if (!isEscaped && SyntaxFacts.IsNewLine(character))
                    {
                        goto case '\n';
                    }

                    if (SyntaxFacts.IsIdentifierStartCharacter(character))
                    {
                        this.ScanIdentifierOrKeyword(ref info);
                    }
                    else
                    {
                        // unknown single character
                        if (isEscaped)
                        {
                            SyntaxDiagnosticInfo error;
                            TextWindow.NextCharOrUnicodeEscape(out surrogateCharacter, out error);
                            AddError(error);
                        }
                        else
                        {
                            TextWindow.AdvanceChar();
                        }

                        info.Kind = SyntaxKind.None;
                        info.Text = TextWindow.GetText(true);
                    }

                    break;
            }

            Debug.Assert(info.Kind != SyntaxKind.None || info.Text != null);
            return info.Kind != SyntaxKind.None;
        }

        private SyntaxListBuilder LexDirectiveTrailingTrivia(bool includeEndOfLine)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 113577, 114597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 113677, 113709);

                SyntaxListBuilder
                trivia = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 113725, 113745);

                CSharpSyntaxNode
                tr
                = default(CSharpSyntaxNode);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 113759, 114556) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 113759, 114556);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 113804, 113834);

                        var
                        pos = f_10014_113814_113833(TextWindow)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 113852, 113883);

                        tr = f_10014_113857_113882(this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 113901, 114541) || true) && (tr == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 113901, 114541);
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 113957, 113963);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 113901, 114541);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 113901, 114541);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 114005, 114541) || true) && (f_10014_114009_114016(tr) == SyntaxKind.EndOfLineTrivia)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 114005, 114541);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 114088, 114384) || true) && (includeEndOfLine)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 114088, 114384);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 114158, 114184);

                                    f_10014_114158_114183(this, tr, ref trivia);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 114088, 114384);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 114088, 114384);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 114339, 114361);

                                    f_10014_114339_114360(                        // don't consume end of line...
                                                            TextWindow, pos);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 114088, 114384);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10014, 114408, 114414);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 114005, 114541);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 114005, 114541);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 114496, 114522);

                                f_10014_114496_114521(this, tr, ref trivia);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 114005, 114541);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 113901, 114541);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 113759, 114556);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10014, 113759, 114556);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10014, 113759, 114556);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 114572, 114586);

                return trivia;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 113577, 114597);

                int
                f_10014_113814_113833(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 113814, 113833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                f_10014_113857_113882(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.LexDirectiveTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 113857, 113882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10014_114009_114016(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 114009, 114016);
                    return return_v;
                }


                int
                f_10014_114158_114183(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                trivia, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder?
                list)
                {
                    this_param.AddTrivia(trivia, ref list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 114158, 114183);
                    return 0;
                }


                int
                f_10014_114339_114360(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                position)
                {
                    this_param.Reset(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 114339, 114360);
                    return 0;
                }


                int
                f_10014_114496_114521(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                trivia, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder?
                list)
                {
                    this_param.AddTrivia(trivia, ref list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 114496, 114521);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 113577, 114597);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 113577, 114597);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CSharpSyntaxNode LexDirectiveTrivia()
        {
            CSharpSyntaxNode trivia = null;

            this.Start();
            char ch = TextWindow.PeekChar();
            switch (ch)
            {
                case '/':
                    if (TextWindow.PeekChar(1) == '/')
                    {
                        // normal single line comment
                        this.ScanToEndOfLine();
                        var text = TextWindow.GetText(false);
                        trivia = SyntaxFactory.Comment(text);
                    }

                    break;
                case '\r':
                case '\n':
                    trivia = this.ScanEndOfLine();
                    break;
                case ' ':
                case '\t':       // Horizontal tab
                case '\v':       // Vertical Tab
                case '\f':       // Form-feed
                    trivia = this.ScanWhitespace();
                    break;

                default:
                    if (SyntaxFacts.IsWhitespace(ch))
                    {
                        goto case ' ';
                    }

                    if (SyntaxFacts.IsNewLine(ch))
                    {
                        goto case '\n';
                    }

                    break;
            }

            return trivia;
        }

        private CSharpSyntaxNode LexXmlDocComment(XmlDocCommentStyle style)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 116015, 117496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 116107, 116128);

                var
                saveMode = _mode
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 116142, 116160);

                bool
                isTerminated
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 116176, 116349);

                var
                mode = (DynAbs.Tracing.TraceSender.Conditional_F1(10014, 116187, 116225) || ((style == XmlDocCommentStyle.SingleLine
                && DynAbs.Tracing.TraceSender.Conditional_F2(10014, 116249, 116287)) || DynAbs.Tracing.TraceSender.Conditional_F3(10014, 116311, 116348))) ? LexerMode.XmlDocCommentStyleSingleLine
                : LexerMode.XmlDocCommentStyleDelimited
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 116363, 116586) || true) && (_xmlParser == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 116363, 116586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 116419, 116475);

                    _xmlParser = f_10014_116432_116474(this, mode);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 116363, 116586);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 116363, 116586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 116541, 116571);

                    f_10014_116541_116570(_xmlParser, mode);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 116363, 116586);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 116602, 116674);

                var
                docComment = f_10014_116619_116673(_xmlParser, out isTerminated)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 116860, 116980);

                f_10014_116860_116979(f_10014_116873_116915(this, XmlDocCommentLocation.End) || (DynAbs.Tracing.TraceSender.Expression_False(10014, 116873, 116978) || f_10014_116919_116940(TextWindow) == SlidingTextWindow.InvalidCharacter));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 116996, 117013);

                _mode = saveMode;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 117029, 117451) || true) && (!isTerminated)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 117029, 117451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 117340, 117436);

                    f_10014_117340_117435(                // The comment didn't end.  Report an error at the start point.
                                                          // NOTE: report this error even if the DocumentationMode is less than diagnose - the comment
                                                          // would be malformed as a non-doc comment as well.
                                    this, f_10014_117354_117384(TextWindow), f_10014_117386_117402(TextWindow), ErrorCode.ERR_OpenEndedComment);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 117029, 117451);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 117467, 117485);

                return docComment;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 116015, 117496);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                f_10014_116432_116474(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                lexer, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                modeflags)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser(lexer, modeflags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 116432, 116474);
                    return return_v;
                }


                int
                f_10014_116541_116570(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                modeflags)
                {
                    this_param.ReInitialize(modeflags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 116541, 116570);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentTriviaSyntax
                f_10014_116619_116673(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DocumentationCommentParser
                this_param, out bool
                isTerminated)
                {
                    var return_v = this_param.ParseDocumentationComment(out isTerminated);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 116619, 116673);
                    return return_v;
                }


                bool
                f_10014_116873_116915(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlDocCommentLocation
                location)
                {
                    var return_v = this_param.LocationIs(location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 116873, 116915);
                    return return_v;
                }


                char
                f_10014_116919_116940(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 116919, 116940);
                    return return_v;
                }


                int
                f_10014_116860_116979(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 116860, 116979);
                    return 0;
                }


                int
                f_10014_117354_117384(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.LexemeStartPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 117354, 117384);
                    return return_v;
                }


                int
                f_10014_117386_117402(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 117386, 117402);
                    return return_v;
                }


                int
                f_10014_117340_117435(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, int
                position, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    this_param.AddError(position, width, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 117340, 117435);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 116015, 117496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 116015, 117496);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxToken LexXmlToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 117612, 118051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 117670, 117714);

                TokenInfo
                xmlTokenInfo = default(TokenInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 117730, 117763);

                SyntaxListBuilder
                leading = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 117777, 117825);

                f_10014_117777_117824(this, ref leading);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 117841, 117854);

                f_10014_117841_117853(
                            this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 117868, 117904);

                f_10014_117868_117903(this, ref xmlTokenInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 117918, 117969);

                var
                errors = f_10014_117931_117968(this, f_10014_117946_117967(leading))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 117985, 118040);

                return f_10014_117992_118039(this, ref xmlTokenInfo, leading, null, errors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 117612, 118051);

                int
                f_10014_117777_117824(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder?
                trivia)
                {
                    this_param.LexXmlDocCommentLeadingTrivia(ref trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 117777, 117824);
                    return 0;
                }


                int
                f_10014_117841_117853(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 117841, 117853);
                    return 0;
                }


                bool
                f_10014_117868_117903(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info)
                {
                    var return_v = this_param.ScanXmlToken(ref info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 117868, 117903);
                    return return_v;
                }


                int
                f_10014_117946_117967(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                builder)
                {
                    var return_v = GetFullWidth(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 117946, 117967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
                f_10014_117931_117968(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, int
                leadingTriviaWidth)
                {
                    var return_v = this_param.GetErrors(leadingTriviaWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 117931, 117968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_117992_118039(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                leading, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                trailing, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
                errors)
                {
                    var return_v = this_param.Create(ref info, leading, trailing, errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 117992, 118039);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 117612, 118051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 117612, 118051);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ScanXmlToken(ref TokenInfo info)
        {
            char ch;

            Debug.Assert(!this.LocationIs(XmlDocCommentLocation.Start));
            Debug.Assert(!this.LocationIs(XmlDocCommentLocation.Exterior));

            if (this.LocationIs(XmlDocCommentLocation.End))
            {
                info.Kind = SyntaxKind.EndOfDocumentationCommentToken;
                return true;
            }

            switch (ch = TextWindow.PeekChar())
            {
                case '&':
                    this.ScanXmlEntity(ref info);
                    info.Kind = SyntaxKind.XmlEntityLiteralToken;
                    break;

                case '<':
                    this.ScanXmlTagStart(ref info);
                    break;

                case '\r':
                case '\n':
                    ScanXmlTextLiteralNewLineToken(ref info);
                    break;

                case SlidingTextWindow.InvalidCharacter:
                    if (!TextWindow.IsReallyAtEnd())
                    {
                        goto default;
                    }

                    info.Kind = SyntaxKind.EndOfDocumentationCommentToken;
                    break;

                default:
                    if (SyntaxFacts.IsNewLine(ch))
                    {
                        goto case '\n';
                    }

                    this.ScanXmlText(ref info);
                    info.Kind = SyntaxKind.XmlTextLiteralToken;
                    break;
            }

            Debug.Assert(info.Kind != SyntaxKind.None || info.Text != null);
            return info.Kind != SyntaxKind.None;
        }

        private void ScanXmlTextLiteralNewLineToken(ref TokenInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 119771, 120100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 119859, 119880);

                f_10014_119859_119879(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 119894, 119959);

                info.StringValue = info.Text = f_10014_119925_119958(TextWindow, intern: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 119973, 120023);

                info.Kind = SyntaxKind.XmlTextLiteralNewLineToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 120037, 120089);

                f_10014_120037_120088(this, XmlDocCommentLocation.Exterior);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 119771, 120100);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                f_10014_119859_119879(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    var return_v = this_param.ScanEndOfLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 119859, 119879);
                    return return_v;
                }


                string
                f_10014_119925_119958(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, bool
                intern)
                {
                    var return_v = this_param.GetText(intern: intern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 119925, 119958);
                    return return_v;
                }


                int
                f_10014_120037_120088(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlDocCommentLocation
                location)
                {
                    this_param.MutateLocation(location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 120037, 120088);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 119771, 120100);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 119771, 120100);
            }
        }

        private void ScanXmlTagStart(ref TokenInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 120112, 121871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 120185, 120228);

                f_10014_120185_120227(f_10014_120198_120219(TextWindow) == '<');

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 120244, 121860) || true) && (f_10014_120248_120270(TextWindow, 1) == '!')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 120244, 121860);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 120311, 121309) || true) && (f_10014_120315_120337(TextWindow, 2) == '-'
                    && (DynAbs.Tracing.TraceSender.Expression_True(10014, 120315, 120398) && f_10014_120369_120391(TextWindow, 3) == '-'))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 120311, 121309);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 120440, 120466);

                        f_10014_120440_120465(TextWindow, 4);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 120488, 120532);

                        info.Kind = SyntaxKind.XmlCommentStartToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 120311, 121309);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 120311, 121309);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 120574, 121309) || true) && (f_10014_120578_120600(TextWindow, 2) == '['
                        && (DynAbs.Tracing.TraceSender.Expression_True(10014, 120578, 120661) && f_10014_120632_120654(TextWindow, 3) == 'C'
                        ) && (DynAbs.Tracing.TraceSender.Expression_True(10014, 120578, 120715) && f_10014_120686_120708(TextWindow, 4) == 'D'
                        ) && (DynAbs.Tracing.TraceSender.Expression_True(10014, 120578, 120769) && f_10014_120740_120762(TextWindow, 5) == 'A'
                        ) && (DynAbs.Tracing.TraceSender.Expression_True(10014, 120578, 120823) && f_10014_120794_120816(TextWindow, 6) == 'T'
                        ) && (DynAbs.Tracing.TraceSender.Expression_True(10014, 120578, 120877) && f_10014_120848_120870(TextWindow, 7) == 'A'
                        ) && (DynAbs.Tracing.TraceSender.Expression_True(10014, 120578, 120931) && f_10014_120902_120924(TextWindow, 8) == '['))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 120574, 121309);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 120973, 120999);

                            f_10014_120973_120998(TextWindow, 9);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 121021, 121063);

                            info.Kind = SyntaxKind.XmlCDataStartToken;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 120574, 121309);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 120574, 121309);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 121206, 121231);

                            f_10014_121206_121230(                    // TODO: Take the < by itself, I guess?
                                                TextWindow);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 121253, 121290);

                            info.Kind = SyntaxKind.LessThanToken;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 120574, 121309);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 120311, 121309);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 120244, 121860);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 120244, 121860);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 121343, 121860) || true) && (f_10014_121347_121369(TextWindow, 1) == '/')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 121343, 121860);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 121410, 121436);

                        f_10014_121410_121435(TextWindow, 2);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 121454, 121496);

                        info.Kind = SyntaxKind.LessThanSlashToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 121343, 121860);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 121343, 121860);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 121530, 121860) || true) && (f_10014_121534_121556(TextWindow, 1) == '?')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 121530, 121860);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 121597, 121623);

                            f_10014_121597_121622(TextWindow, 2);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 121641, 121699);

                            info.Kind = SyntaxKind.XmlProcessingInstructionStartToken;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 121530, 121860);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 121530, 121860);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 121765, 121790);

                            f_10014_121765_121789(TextWindow);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 121808, 121845);

                            info.Kind = SyntaxKind.LessThanToken;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 121530, 121860);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 121343, 121860);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 120244, 121860);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 120112, 121871);

                char
                f_10014_120198_120219(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 120198, 120219);
                    return return_v;
                }


                int
                f_10014_120185_120227(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 120185, 120227);
                    return 0;
                }


                char
                f_10014_120248_120270(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 120248, 120270);
                    return return_v;
                }


                char
                f_10014_120315_120337(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 120315, 120337);
                    return return_v;
                }


                char
                f_10014_120369_120391(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 120369, 120391);
                    return return_v;
                }


                int
                f_10014_120440_120465(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                n)
                {
                    this_param.AdvanceChar(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 120440, 120465);
                    return 0;
                }


                char
                f_10014_120578_120600(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 120578, 120600);
                    return return_v;
                }


                char
                f_10014_120632_120654(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 120632, 120654);
                    return return_v;
                }


                char
                f_10014_120686_120708(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 120686, 120708);
                    return return_v;
                }


                char
                f_10014_120740_120762(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 120740, 120762);
                    return return_v;
                }


                char
                f_10014_120794_120816(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 120794, 120816);
                    return return_v;
                }


                char
                f_10014_120848_120870(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 120848, 120870);
                    return return_v;
                }


                char
                f_10014_120902_120924(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 120902, 120924);
                    return return_v;
                }


                int
                f_10014_120973_120998(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                n)
                {
                    this_param.AdvanceChar(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 120973, 120998);
                    return 0;
                }


                int
                f_10014_121206_121230(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 121206, 121230);
                    return 0;
                }


                char
                f_10014_121347_121369(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 121347, 121369);
                    return return_v;
                }


                int
                f_10014_121410_121435(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                n)
                {
                    this_param.AdvanceChar(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 121410, 121435);
                    return 0;
                }


                char
                f_10014_121534_121556(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                delta)
                {
                    var return_v = this_param.PeekChar(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 121534, 121556);
                    return return_v;
                }


                int
                f_10014_121597_121622(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                n)
                {
                    this_param.AdvanceChar(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 121597, 121622);
                    return 0;
                }


                int
                f_10014_121765_121789(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 121765, 121789);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 120112, 121871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 120112, 121871);
            }
        }

        private void ScanXmlEntity(ref TokenInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 121883, 127495);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 121954, 121978);

                info.StringValue = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 121994, 122037);

                f_10014_121994_122036(f_10014_122007_122028(TextWindow) == '&');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 122051, 122076);

                f_10014_122051_122075(TextWindow);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 122090, 122107);

                f_10014_122090_122106(_builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 122121, 122153);

                XmlParseErrorCode?
                error = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 122167, 122193);

                object[]
                errorArgs = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 122209, 122217);

                char
                ch
                = default(char);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 122231, 126618) || true) && (f_10014_122235_122281(ch = f_10014_122259_122280(TextWindow)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 122231, 126618);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 122315, 122958) || true) && (f_10014_122322_122363(ch = f_10014_122341_122362(TextWindow)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 122315, 122958);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 122872, 122897);

                            f_10014_122872_122896(                    // Important bit of information here: none of \0, \r, \n, and crucially for
                                                                      // delimited comments, * are considered Xml name characters. Also, since
                                                                      // entities appear in xml text and attribute text, it's relevant here that
                                                                      // none of <, /, >, ', ", =, are Xml name characters. Note that - and ] are
                                                                      // irrelevant--entities do not appear in comments or cdata.

                                                TextWindow);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 122919, 122939);

                            f_10014_122919_122938(_builder, ch);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 122315, 122958);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10014, 122315, 122958);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10014, 122315, 122958);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 122978, 123822);

                    switch (f_10014_122986_123005(_builder))
                    {

                        case "lt":
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 122978, 123822);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 123083, 123106);

                            info.StringValue = "<";
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 123132, 123138);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 122978, 123822);

                        case "gt":
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 122978, 123822);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 123196, 123219);

                            info.StringValue = ">";
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 123245, 123251);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 122978, 123822);

                        case "amp":
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 122978, 123822);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 123310, 123333);

                            info.StringValue = "&";
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 123359, 123365);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 122978, 123822);

                        case "apos":
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 122978, 123822);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 123425, 123448);

                            info.StringValue = "'";
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 123474, 123480);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 122978, 123822);

                        case "quot":
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 122978, 123822);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 123540, 123564);

                            info.StringValue = "\"";
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 123590, 123596);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 122978, 123822);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 122978, 123822);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 123652, 123703);

                            error = XmlParseErrorCode.XML_RefUndefinedEntity_1;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 123729, 123771);

                            errorArgs = new[] { f_10014_123749_123768(_builder) };
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 123797, 123803);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 122978, 123822);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 122231, 126618);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 122231, 126618);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 123856, 126618) || true) && (ch == '#')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 123856, 126618);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 123903, 123928);

                        f_10014_123903_123927(TextWindow);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 123946, 123988);

                        bool
                        isHex = f_10014_123959_123980(TextWindow) == 'x'
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 124006, 124025);

                        uint
                        charValue = 0
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 124045, 125072) || true) && (isHex)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 124045, 125072);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 124096, 124121);

                            f_10014_124096_124120(TextWindow);
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 124148, 124550) || true) && (f_10014_124155_124205(ch = f_10014_124183_124204(TextWindow)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 124148, 124550);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 124255, 124280);

                                    f_10014_124255_124279(TextWindow);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 124354, 124527) || true) && (charValue <= 0x7FFFFFF)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 124354, 124527);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 124438, 124500);

                                        charValue = (charValue << 4) + (uint)f_10014_124475_124499(ch);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 124354, 124527);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 124148, 124550);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10014, 124148, 124550);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10014, 124148, 124550);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 124045, 125072);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 124045, 125072);
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 124632, 125053) || true) && (f_10014_124639_124689(ch = f_10014_124667_124688(TextWindow)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 124632, 125053);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 124739, 124764);

                                    f_10014_124739_124763(TextWindow);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 124838, 125030) || true) && (charValue <= 0x7FFFFFF)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 124838, 125030);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 124922, 125003);

                                        charValue = (charValue << 3) + (charValue << 1) + (uint)f_10014_124978_125002(ch);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 124838, 125030);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 124632, 125053);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10014, 124632, 125053);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10014, 124632, 125053);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 124045, 125072);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 125092, 125233) || true) && (f_10014_125096_125117(TextWindow) != ';')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 125092, 125233);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 125166, 125214);

                            error = XmlParseErrorCode.XML_InvalidCharEntity;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 125092, 125233);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 125253, 126000) || true) && (f_10014_125257_125295(charValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 125253, 126000);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 125337, 125355);

                            char
                            lowSurrogate
                            = default(char);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 125377, 125463);

                            char
                            highSurrogate = f_10014_125398_125462(charValue, out lowSurrogate)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 125487, 125518);

                            f_10014_125487_125517(
                                                _builder, highSurrogate);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 125540, 125697) || true) && (lowSurrogate != SlidingTextWindow.InvalidCharacter)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 125540, 125697);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 125644, 125674);

                                f_10014_125644_125673(_builder, lowSurrogate);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 125540, 125697);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 125721, 125760);

                            info.StringValue = f_10014_125740_125759(_builder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 125253, 126000);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 125253, 126000);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 125842, 125981) || true) && (error == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 125842, 125981);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 125909, 125958);

                                error = XmlParseErrorCode.XML_InvalidUnicodeChar;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 125842, 125981);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 125253, 126000);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 123856, 126618);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 123856, 126618);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 126066, 126603) || true) && (f_10014_126070_126098(ch) || (DynAbs.Tracing.TraceSender.Expression_False(10014, 126070, 126127) || f_10014_126102_126127(ch)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 126066, 126603);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 126169, 126307) || true) && (error == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 126169, 126307);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 126236, 126284);

                                error = XmlParseErrorCode.XML_InvalidWhitespace;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 126169, 126307);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 126066, 126603);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 126066, 126603);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 126389, 126584) || true) && (error == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 126389, 126584);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 126456, 126499);

                                error = XmlParseErrorCode.XML_InvalidToken;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 126525, 126561);

                                errorArgs = new[] { f_10014_126545_126558(ch) };
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 126389, 126584);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 126066, 126603);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 123856, 126618);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 122231, 126618);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 126634, 126661);

                ch = f_10014_126639_126660(TextWindow);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 126675, 127007) || true) && (ch == ';')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 126675, 127007);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 126722, 126747);

                    f_10014_126722_126746(TextWindow);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 126675, 127007);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 126675, 127007);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 126813, 126992) || true) && (error == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 126813, 126992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 126872, 126915);

                        error = XmlParseErrorCode.XML_InvalidToken;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 126937, 126973);

                        errorArgs = new[] { f_10014_126957_126970(ch) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 126813, 126992);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 126675, 127007);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 127182, 127219);

                info.Text = f_10014_127194_127218(TextWindow, true);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 127233, 127339) || true) && (info.StringValue == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 127233, 127339);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 127295, 127324);

                    info.StringValue = info.Text;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 127233, 127339);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 127355, 127484) || true) && (error != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 127355, 127484);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 127406, 127469);

                    f_10014_127406_127468(this, f_10014_127420_127431(error), errorArgs ?? (DynAbs.Tracing.TraceSender.Expression_Null<object[]?>(10014, 127433, 127467) ?? f_10014_127446_127467()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 127355, 127484);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 121883, 127495);

                char
                f_10014_122007_122028(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 122007, 122028);
                    return return_v;
                }


                int
                f_10014_121994_122036(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 121994, 122036);
                    return 0;
                }


                int
                f_10014_122051_122075(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 122051, 122075);
                    return 0;
                }


                System.Text.StringBuilder
                f_10014_122090_122106(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 122090, 122106);
                    return return_v;
                }


                char
                f_10014_122259_122280(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 122259, 122280);
                    return return_v;
                }


                bool
                f_10014_122235_122281(char
                ch)
                {
                    var return_v = IsXmlNameStartChar(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 122235, 122281);
                    return return_v;
                }


                char
                f_10014_122341_122362(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 122341, 122362);
                    return return_v;
                }


                bool
                f_10014_122322_122363(char
                ch)
                {
                    var return_v = IsXmlNameChar(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 122322, 122363);
                    return return_v;
                }


                int
                f_10014_122872_122896(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 122872, 122896);
                    return 0;
                }


                System.Text.StringBuilder
                f_10014_122919_122938(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 122919, 122938);
                    return return_v;
                }


                string
                f_10014_122986_123005(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 122986, 123005);
                    return return_v;
                }


                string
                f_10014_123749_123768(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 123749, 123768);
                    return return_v;
                }


                int
                f_10014_123903_123927(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 123903, 123927);
                    return 0;
                }


                char
                f_10014_123959_123980(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 123959, 123980);
                    return return_v;
                }


                int
                f_10014_124096_124120(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 124096, 124120);
                    return 0;
                }


                char
                f_10014_124183_124204(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 124183, 124204);
                    return return_v;
                }


                bool
                f_10014_124155_124205(char
                c)
                {
                    var return_v = SyntaxFacts.IsHexDigit(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 124155, 124205);
                    return return_v;
                }


                int
                f_10014_124255_124279(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 124255, 124279);
                    return 0;
                }


                int
                f_10014_124475_124499(char
                c)
                {
                    var return_v = SyntaxFacts.HexValue(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 124475, 124499);
                    return return_v;
                }


                char
                f_10014_124667_124688(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 124667, 124688);
                    return return_v;
                }


                bool
                f_10014_124639_124689(char
                c)
                {
                    var return_v = SyntaxFacts.IsDecDigit(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 124639, 124689);
                    return return_v;
                }


                int
                f_10014_124739_124763(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 124739, 124763);
                    return 0;
                }


                int
                f_10014_124978_125002(char
                c)
                {
                    var return_v = SyntaxFacts.DecValue(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 124978, 125002);
                    return return_v;
                }


                char
                f_10014_125096_125117(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 125096, 125117);
                    return return_v;
                }


                bool
                f_10014_125257_125295(uint
                charValue)
                {
                    var return_v = MatchesProductionForXmlChar(charValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 125257, 125295);
                    return return_v;
                }


                char
                f_10014_125398_125462(uint
                codepoint, out char
                lowSurrogate)
                {
                    var return_v = SlidingTextWindow.GetCharsFromUtf32(codepoint, out lowSurrogate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 125398, 125462);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10014_125487_125517(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 125487, 125517);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10014_125644_125673(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 125644, 125673);
                    return return_v;
                }


                string
                f_10014_125740_125759(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 125740, 125759);
                    return return_v;
                }


                bool
                f_10014_126070_126098(char
                ch)
                {
                    var return_v = SyntaxFacts.IsWhitespace(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 126070, 126098);
                    return return_v;
                }


                bool
                f_10014_126102_126127(char
                ch)
                {
                    var return_v = SyntaxFacts.IsNewLine(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 126102, 126127);
                    return return_v;
                }


                string
                f_10014_126545_126558(char
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 126545, 126558);
                    return return_v;
                }


                char
                f_10014_126639_126660(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 126639, 126660);
                    return return_v;
                }


                int
                f_10014_126722_126746(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 126722, 126746);
                    return 0;
                }


                string
                f_10014_126957_126970(char
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 126957, 126970);
                    return return_v;
                }


                string
                f_10014_127194_127218(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, bool
                intern)
                {
                    var return_v = this_param.GetText(intern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 127194, 127218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                f_10014_127420_127431(Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 127420, 127431);
                    return return_v;
                }


                object[]
                f_10014_127446_127467()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 127446, 127467);
                    return return_v;
                }


                int
                f_10014_127406_127468(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                code, params object[]
                args)
                {
                    this_param.AddError(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 127406, 127468);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 121883, 127495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 121883, 127495);
            }
        }

        private static bool MatchesProductionForXmlChar(uint charValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10014, 127507, 128092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 127770, 128081);

                return
                                charValue == 0x9 || (DynAbs.Tracing.TraceSender.Expression_False(10014, 127794, 127847) || charValue == 0xA) || (DynAbs.Tracing.TraceSender.Expression_False(10014, 127794, 127884) || charValue == 0xD) || (DynAbs.Tracing.TraceSender.Expression_False(10014, 127794, 127947) || (charValue >= 0x20 && (DynAbs.Tracing.TraceSender.Expression_True(10014, 127906, 127946) && charValue <= 0xD7FF))) || (DynAbs.Tracing.TraceSender.Expression_False(10014, 127794, 128012) || (charValue >= 0xE000 && (DynAbs.Tracing.TraceSender.Expression_True(10014, 127969, 128011) && charValue <= 0xFFFD))) || (DynAbs.Tracing.TraceSender.Expression_False(10014, 127794, 128080) || (charValue >= 0x10000 && (DynAbs.Tracing.TraceSender.Expression_True(10014, 128034, 128079) && charValue <= 0x10FFFF)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10014, 127507, 128092);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 127507, 128092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 127507, 128092);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ScanXmlText(ref TokenInfo info)
        {
            // Collect "]]>" strings into their own XmlText.
            if (TextWindow.PeekChar() == ']' && TextWindow.PeekChar(1) == ']' && TextWindow.PeekChar(2) == '>')
            {
                TextWindow.AdvanceChar(3);
                info.StringValue = info.Text = TextWindow.GetText(false);
                this.AddError(XmlParseErrorCode.XML_CDataEndTagNotAllowed);
                return;
            }

            while (true)
            {
                var ch = TextWindow.PeekChar();
                switch (ch)
                {
                    case SlidingTextWindow.InvalidCharacter:
                        if (!TextWindow.IsReallyAtEnd())
                        {
                            goto default;
                        }

                        info.StringValue = info.Text = TextWindow.GetText(false);
                        return;
                    case '&':
                    case '<':
                    case '\r':
                    case '\n':
                        info.StringValue = info.Text = TextWindow.GetText(false);
                        return;

                    case '*':
                        if (this.StyleIs(XmlDocCommentStyle.Delimited) && TextWindow.PeekChar(1) == '/')
                        {
                            // we're at the end of the comment, but don't lex it yet.
                            info.StringValue = info.Text = TextWindow.GetText(false);
                            return;
                        }

                        goto default;

                    case ']':
                        if (TextWindow.PeekChar(1) == ']' && TextWindow.PeekChar(2) == '>')
                        {
                            info.StringValue = info.Text = TextWindow.GetText(false);
                            return;
                        }

                        goto default;

                    default:
                        if (SyntaxFacts.IsNewLine(ch))
                        {
                            goto case '\n';
                        }

                        TextWindow.AdvanceChar();
                        break;
                }
            }
        }

        private SyntaxToken LexXmlElementTagToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 130525, 131405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 130593, 130632);

                TokenInfo
                tagInfo = default(TokenInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 130648, 130681);

                SyntaxListBuilder
                leading = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 130695, 130757);

                f_10014_130695_130756(this, ref leading);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 130773, 130786);

                f_10014_130773_130785(
                            this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 130800, 130841);

                f_10014_130800_130840(this, ref tagInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 130855, 130906);

                var
                errors = f_10014_130868_130905(this, f_10014_130883_130904(leading))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 130976, 131328) || true) && (errors == null && (DynAbs.Tracing.TraceSender.Expression_True(10014, 130980, 131039) && tagInfo.ContextualKind == SyntaxKind.None) && (DynAbs.Tracing.TraceSender.Expression_True(10014, 130980, 131085) && tagInfo.Kind == SyntaxKind.IdentifierToken))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 130976, 131328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 131119, 131204);

                    SyntaxToken
                    token = f_10014_131139_131203(tagInfo.Text, leading)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 131222, 131313) || true) && (token != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 131222, 131313);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 131281, 131294);

                        return token;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 131222, 131313);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 130976, 131328);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 131344, 131394);

                return f_10014_131351_131393(this, ref tagInfo, leading, null, errors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 130525, 131405);

                int
                f_10014_130695_130756(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder?
                trivia)
                {
                    this_param.LexXmlDocCommentLeadingTriviaWithWhitespace(ref trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 130695, 130756);
                    return 0;
                }


                int
                f_10014_130773_130785(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 130773, 130785);
                    return 0;
                }


                bool
                f_10014_130800_130840(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info)
                {
                    var return_v = this_param.ScanXmlElementTagToken(ref info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 130800, 130840);
                    return return_v;
                }


                int
                f_10014_130883_130904(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                builder)
                {
                    var return_v = GetFullWidth(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 130883, 130904);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
                f_10014_130868_130905(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, int
                leadingTriviaWidth)
                {
                    var return_v = this_param.GetErrors(leadingTriviaWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 130868, 130905);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_131139_131203(string
                text, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                leading)
                {
                    var return_v = DocumentationCommentXmlTokens.LookupToken(text, leading);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 131139, 131203);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_131351_131393(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                leading, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                trailing, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]?
                errors)
                {
                    var return_v = this_param.Create(ref info, leading, trailing, errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 131351, 131393);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 130525, 131405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 130525, 131405);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ScanXmlElementTagToken(ref TokenInfo info)
        {
            char ch;

            Debug.Assert(!this.LocationIs(XmlDocCommentLocation.Start));
            Debug.Assert(!this.LocationIs(XmlDocCommentLocation.Exterior));

            if (this.LocationIs(XmlDocCommentLocation.End))
            {
                info.Kind = SyntaxKind.EndOfDocumentationCommentToken;
                return true;
            }

            switch (ch = TextWindow.PeekChar())
            {
                case '<':
                    this.ScanXmlTagStart(ref info);
                    break;

                case '>':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.GreaterThanToken;
                    break;

                case '/':
                    if (TextWindow.PeekChar(1) == '>')
                    {
                        TextWindow.AdvanceChar(2);
                        info.Kind = SyntaxKind.SlashGreaterThanToken;
                        break;
                    }

                    goto default;

                case '"':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.DoubleQuoteToken;
                    break;

                case '\'':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.SingleQuoteToken;
                    break;

                case '=':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.EqualsToken;
                    break;

                case ':':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.ColonToken;
                    break;

                case '\r':
                case '\n':
                    // Assert?
                    break;

                case SlidingTextWindow.InvalidCharacter:
                    if (!TextWindow.IsReallyAtEnd())
                    {
                        goto default;
                    }

                    info.Kind = SyntaxKind.EndOfDocumentationCommentToken;
                    break;

                case '*':
                    if (this.StyleIs(XmlDocCommentStyle.Delimited) && TextWindow.PeekChar(1) == '/')
                    {
                        // Assert? We should have gotten this in the leading trivia.
                        Debug.Assert(false, "Should have picked up leading indentationTrivia, but didn't.");
                        break;
                    }

                    goto default;

                default:
                    if (IsXmlNameStartChar(ch))
                    {
                        this.ScanXmlName(ref info);
                        info.StringValue = info.Text;
                        info.Kind = SyntaxKind.IdentifierToken;
                    }
                    else if (SyntaxFacts.IsWhitespace(ch) || SyntaxFacts.IsNewLine(ch))
                    {
                        // whitespace! needed to do a better job with trivia
                        Debug.Assert(false, "Should have picked up leading indentationTrivia, but didn't.");
                    }
                    else
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.None;
                        info.StringValue = info.Text = TextWindow.GetText(false);
                    }

                    break;
            }

            Debug.Assert(info.Kind != SyntaxKind.None || info.Text != null);
            return info.Kind != SyntaxKind.None;
        }

        private void ScanXmlName(ref TokenInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 135112, 136189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 135181, 135213);

                int
                start = f_10014_135193_135212(TextWindow)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 135229, 136081) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 135229, 136081);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 135274, 135306);

                        char
                        ch = f_10014_135284_135305(TextWindow)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 135497, 136066) || true) && (ch != ':' && (DynAbs.Tracing.TraceSender.Expression_True(10014, 135501, 135531) && f_10014_135514_135531(ch)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 135497, 136066);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 135934, 135959);

                            f_10014_135934_135958(                    // Although ':' is a name char, we don't include it in ScanXmlName
                                                                      // since it is its own token. This enables the parser to add structure
                                                                      // to colon-separated names.

                                                // TODO: Could put a big switch here for common cases
                                                // if this is a perf bottleneck.
                                                TextWindow);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 135497, 136066);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 135497, 136066);
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 136041, 136047);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 135497, 136066);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 135229, 136081);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10014, 135229, 136081);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10014, 135229, 136081);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 136097, 136178);

                info.Text = f_10014_136109_136177(TextWindow, start, f_10014_136135_136154(TextWindow) - start, intern: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 135112, 136189);

                int
                f_10014_135193_135212(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 135193, 135212);
                    return return_v;
                }


                char
                f_10014_135284_135305(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 135284, 135305);
                    return return_v;
                }


                bool
                f_10014_135514_135531(char
                ch)
                {
                    var return_v = IsXmlNameChar(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 135514, 135531);
                    return return_v;
                }


                int
                f_10014_135934_135958(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 135934, 135958);
                    return 0;
                }


                int
                f_10014_136135_136154(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 136135, 136154);
                    return return_v;
                }


                string
                f_10014_136109_136177(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                position, int
                length, bool
                intern)
                {
                    var return_v = this_param.GetText(position, length, intern: intern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 136109, 136177);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 135112, 136189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 135112, 136189);
            }
        }

        private static bool IsXmlNameStartChar(char ch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10014, 136385, 136622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 136503, 136549);

                return f_10014_136510_136548(ch);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10014, 136385, 136622);

                bool
                f_10014_136510_136548(char
                ch)
                {
                    var return_v = XmlCharType.IsStartNCNameCharXml4e(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 136510, 136548);
                    return return_v;
                }

                // return XmlCharType.IsStartNameSingleChar(ch);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 136385, 136622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 136385, 136622);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsXmlNameChar(char ch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10014, 136820, 137041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 136933, 136974);

                return f_10014_136940_136973(ch);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10014, 136820, 137041);

                bool
                f_10014_136940_136973(char
                ch)
                {
                    var return_v = XmlCharType.IsNCNameCharXml4e(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 136940, 136973);
                    return return_v;
                }

                //return XmlCharType.IsNameSingleChar(ch);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 136820, 137041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 136820, 137041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxToken LexXmlAttributeTextToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 137318, 137759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 137389, 137425);

                TokenInfo
                info = default(TokenInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 137441, 137474);

                SyntaxListBuilder
                leading = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 137488, 137536);

                f_10014_137488_137535(this, ref leading);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 137552, 137565);

                f_10014_137552_137564(
                            this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 137579, 137620);

                f_10014_137579_137619(this, ref info);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 137634, 137685);

                var
                errors = f_10014_137647_137684(this, f_10014_137662_137683(leading))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 137701, 137748);

                return f_10014_137708_137747(this, ref info, leading, null, errors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 137318, 137759);

                int
                f_10014_137488_137535(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder?
                trivia)
                {
                    this_param.LexXmlDocCommentLeadingTrivia(ref trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 137488, 137535);
                    return 0;
                }


                int
                f_10014_137552_137564(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 137552, 137564);
                    return 0;
                }


                bool
                f_10014_137579_137619(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info)
                {
                    var return_v = this_param.ScanXmlAttributeTextToken(ref info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 137579, 137619);
                    return return_v;
                }


                int
                f_10014_137662_137683(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                builder)
                {
                    var return_v = GetFullWidth(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 137662, 137683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
                f_10014_137647_137684(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, int
                leadingTriviaWidth)
                {
                    var return_v = this_param.GetErrors(leadingTriviaWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 137647, 137684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_137708_137747(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                leading, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                trailing, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
                errors)
                {
                    var return_v = this_param.Create(ref info, leading, trailing, errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 137708, 137747);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 137318, 137759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 137318, 137759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ScanXmlAttributeTextToken(ref TokenInfo info)
        {
            Debug.Assert(!this.LocationIs(XmlDocCommentLocation.Start));
            Debug.Assert(!this.LocationIs(XmlDocCommentLocation.Exterior));

            if (this.LocationIs(XmlDocCommentLocation.End))
            {
                info.Kind = SyntaxKind.EndOfDocumentationCommentToken;
                return true;
            }

            char ch;
            switch (ch = TextWindow.PeekChar())
            {
                case '"':
                    if (this.ModeIs(LexerMode.XmlAttributeTextDoubleQuote))
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.DoubleQuoteToken;
                        break;
                    }

                    goto default;

                case '\'':
                    if (this.ModeIs(LexerMode.XmlAttributeTextQuote))
                    {
                        TextWindow.AdvanceChar();
                        info.Kind = SyntaxKind.SingleQuoteToken;
                        break;
                    }

                    goto default;

                case '&':
                    this.ScanXmlEntity(ref info);
                    info.Kind = SyntaxKind.XmlEntityLiteralToken;
                    break;

                case '<':
                    TextWindow.AdvanceChar();
                    info.Kind = SyntaxKind.LessThanToken;
                    break;

                case '\r':
                case '\n':
                    ScanXmlTextLiteralNewLineToken(ref info);
                    break;

                case SlidingTextWindow.InvalidCharacter:
                    if (!TextWindow.IsReallyAtEnd())
                    {
                        goto default;
                    }

                    info.Kind = SyntaxKind.EndOfDocumentationCommentToken;
                    break;

                default:
                    if (SyntaxFacts.IsNewLine(ch))
                    {
                        goto case '\n';
                    }

                    this.ScanXmlAttributeText(ref info);
                    info.Kind = SyntaxKind.XmlTextLiteralToken;
                    break;
            }

            Debug.Assert(info.Kind != SyntaxKind.None || info.Text != null);
            return info.Kind != SyntaxKind.None;
        }

        private void ScanXmlAttributeText(ref TokenInfo info)
        {
            while (true)
            {
                var ch = TextWindow.PeekChar();
                switch (ch)
                {
                    case '"':
                        if (this.ModeIs(LexerMode.XmlAttributeTextDoubleQuote))
                        {
                            info.StringValue = info.Text = TextWindow.GetText(false);
                            return;
                        }

                        goto default;

                    case '\'':
                        if (this.ModeIs(LexerMode.XmlAttributeTextQuote))
                        {
                            info.StringValue = info.Text = TextWindow.GetText(false);
                            return;
                        }

                        goto default;

                    case '&':
                    case '<':
                    case '\r':
                    case '\n':
                        info.StringValue = info.Text = TextWindow.GetText(false);
                        return;

                    case SlidingTextWindow.InvalidCharacter:
                        if (!TextWindow.IsReallyAtEnd())
                        {
                            goto default;
                        }

                        info.StringValue = info.Text = TextWindow.GetText(false);
                        return;

                    case '*':
                        if (this.StyleIs(XmlDocCommentStyle.Delimited) && TextWindow.PeekChar(1) == '/')
                        {
                            // we're at the end of the comment, but don't lex it yet.
                            info.StringValue = info.Text = TextWindow.GetText(false);
                            return;
                        }

                        goto default;

                    default:
                        if (SyntaxFacts.IsNewLine(ch))
                        {
                            goto case '\n';
                        }

                        TextWindow.AdvanceChar();
                        break;
                }
            }
        }

        private SyntaxToken LexXmlCharacter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 142545, 143074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 142607, 142643);

                TokenInfo
                info = default(TokenInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 142751, 142784);

                SyntaxListBuilder
                leading = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 142798, 142860);

                f_10014_142798_142859(this, ref leading);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 142876, 142889);

                f_10014_142876_142888(
                            this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 142903, 142935);

                f_10014_142903_142934(this, ref info);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 142949, 143000);

                var
                errors = f_10014_142962_142999(this, f_10014_142977_142998(leading))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 143016, 143063);

                return f_10014_143023_143062(this, ref info, leading, null, errors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 142545, 143074);

                int
                f_10014_142798_142859(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder?
                trivia)
                {
                    this_param.LexXmlDocCommentLeadingTriviaWithWhitespace(ref trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 142798, 142859);
                    return 0;
                }


                int
                f_10014_142876_142888(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 142876, 142888);
                    return 0;
                }


                bool
                f_10014_142903_142934(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info)
                {
                    var return_v = this_param.ScanXmlCharacter(ref info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 142903, 142934);
                    return return_v;
                }


                int
                f_10014_142977_142998(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                builder)
                {
                    var return_v = GetFullWidth(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 142977, 142998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
                f_10014_142962_142999(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, int
                leadingTriviaWidth)
                {
                    var return_v = this_param.GetErrors(leadingTriviaWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 142962, 142999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_143023_143062(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                leading, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                trailing, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
                errors)
                {
                    var return_v = this_param.Create(ref info, leading, trailing, errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 143023, 143062);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 142545, 143074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 142545, 143074);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ScanXmlCharacter(ref TokenInfo info)
        {
            Debug.Assert(!this.LocationIs(XmlDocCommentLocation.Start));
            Debug.Assert(!this.LocationIs(XmlDocCommentLocation.Exterior));

            if (this.LocationIs(XmlDocCommentLocation.End))
            {
                info.Kind = SyntaxKind.EndOfDocumentationCommentToken;
                return true;
            }

            switch (TextWindow.PeekChar())
            {
                case '&':
                    this.ScanXmlEntity(ref info);
                    info.Kind = SyntaxKind.XmlEntityLiteralToken;
                    break;
                case SlidingTextWindow.InvalidCharacter:
                    if (!TextWindow.IsReallyAtEnd())
                    {
                        goto default;
                    }
                    info.Kind = SyntaxKind.EndOfFileToken;
                    break;
                default:
                    info.Kind = SyntaxKind.XmlTextLiteralToken;
                    info.Text = info.StringValue = TextWindow.NextChar().ToString();
                    break;
            }

            return true;
        }

        private SyntaxToken LexXmlCrefOrNameToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 144660, 145195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 144728, 144764);

                TokenInfo
                info = default(TokenInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 144872, 144905);

                SyntaxListBuilder
                leading = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 144919, 144981);

                f_10014_144919_144980(this, ref leading);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 144997, 145010);

                f_10014_144997_145009(
                            this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 145024, 145056);

                f_10014_145024_145055(this, ref info);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 145070, 145121);

                var
                errors = f_10014_145083_145120(this, f_10014_145098_145119(leading))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 145137, 145184);

                return f_10014_145144_145183(this, ref info, leading, null, errors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 144660, 145195);

                int
                f_10014_144919_144980(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder?
                trivia)
                {
                    this_param.LexXmlDocCommentLeadingTriviaWithWhitespace(ref trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 144919, 144980);
                    return 0;
                }


                int
                f_10014_144997_145009(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 144997, 145009);
                    return 0;
                }


                bool
                f_10014_145024_145055(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info)
                {
                    var return_v = this_param.ScanXmlCrefToken(ref info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 145024, 145055);
                    return return_v;
                }


                int
                f_10014_145098_145119(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                builder)
                {
                    var return_v = GetFullWidth(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 145098, 145119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
                f_10014_145083_145120(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, int
                leadingTriviaWidth)
                {
                    var return_v = this_param.GetErrors(leadingTriviaWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 145083, 145120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_145144_145183(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                leading, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                trailing, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
                errors)
                {
                    var return_v = this_param.Create(ref info, leading, trailing, errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 145144, 145183);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 144660, 145195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 144660, 145195);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ScanXmlCrefToken(ref TokenInfo info)
        {
            Debug.Assert(!this.LocationIs(XmlDocCommentLocation.Start));
            Debug.Assert(!this.LocationIs(XmlDocCommentLocation.Exterior));

            if (this.LocationIs(XmlDocCommentLocation.End))
            {
                info.Kind = SyntaxKind.EndOfDocumentationCommentToken;
                return true;
            }

            int beforeConsumed = TextWindow.Position;
            char consumedChar = TextWindow.NextChar();
            char consumedSurrogate = SlidingTextWindow.InvalidCharacter;

            // This first switch is for special characters.  If we see the corresponding
            // XML entities, we DO NOT want to take these actions.
            switch (consumedChar)
            {
                case '"':
                    if (this.ModeIs(LexerMode.XmlCrefDoubleQuote) || this.ModeIs(LexerMode.XmlNameDoubleQuote))
                    {
                        info.Kind = SyntaxKind.DoubleQuoteToken;
                        return true;
                    }

                    break;

                case '\'':
                    if (this.ModeIs(LexerMode.XmlCrefQuote) || this.ModeIs(LexerMode.XmlNameQuote))
                    {
                        info.Kind = SyntaxKind.SingleQuoteToken;
                        return true;
                    }

                    break;

                case '<':
                    info.Text = TextWindow.GetText(intern: false);
                    this.AddError(XmlParseErrorCode.XML_LessThanInAttributeValue, info.Text); //ErrorCode.WRN_XMLParseError
                    return true;

                case SlidingTextWindow.InvalidCharacter:
                    if (!TextWindow.IsReallyAtEnd())
                    {
                        goto default;
                    }

                    info.Kind = SyntaxKind.EndOfDocumentationCommentToken;
                    return true;

                case '\r':
                case '\n':
                    TextWindow.Reset(beforeConsumed);
                    ScanXmlTextLiteralNewLineToken(ref info);
                    break;

                case '&':
                    TextWindow.Reset(beforeConsumed);
                    if (!TextWindow.TryScanXmlEntity(out consumedChar, out consumedSurrogate))
                    {
                        TextWindow.Reset(beforeConsumed);
                        this.ScanXmlEntity(ref info);
                        info.Kind = SyntaxKind.XmlEntityLiteralToken;
                        return true;
                    }

                    // TryScanXmlEntity advances even when it returns false.
                    break;

                case '{':
                    consumedChar = '<';
                    break;

                case '}':
                    consumedChar = '>';
                    break;

                default:
                    if (SyntaxFacts.IsNewLine(consumedChar))
                    {
                        goto case '\n';
                    }

                    break;
            }

            Debug.Assert(TextWindow.Position > beforeConsumed, "First character or entity has been consumed.");

            // NOTE: None of these cases will be matched if the surrogate is non-zero (UTF-16 rules)
            // so we don't need to check for that explicitly.

            // NOTE: there's a lot of overlap between this switch and the one in
            // ScanSyntaxToken, but we probably don't want to share code because
            // ScanSyntaxToken is really hot code and this switch does some extra
            // work.
            switch (consumedChar)
            {
                //// Single-Character Punctuation/Operators ////
                case '(':
                    info.Kind = SyntaxKind.OpenParenToken;
                    break;
                case ')':
                    info.Kind = SyntaxKind.CloseParenToken;
                    break;
                case '[':
                    info.Kind = SyntaxKind.OpenBracketToken;
                    break;
                case ']':
                    info.Kind = SyntaxKind.CloseBracketToken;
                    break;
                case ',':
                    info.Kind = SyntaxKind.CommaToken;
                    break;
                case '.':
                    if (AdvanceIfMatches('.'))
                    {
                        if (TextWindow.PeekChar() == '.')
                        {
                            // See documentation in ScanSyntaxToken
                            this.AddCrefError(ErrorCode.ERR_UnexpectedCharacter, ".");
                        }

                        info.Kind = SyntaxKind.DotDotToken;
                    }
                    else
                    {
                        info.Kind = SyntaxKind.DotToken;
                    }
                    break;
                case '?':
                    info.Kind = SyntaxKind.QuestionToken;
                    break;
                case '&':
                    info.Kind = SyntaxKind.AmpersandToken;
                    break;
                case '*':
                    info.Kind = SyntaxKind.AsteriskToken;
                    break;
                case '|':
                    info.Kind = SyntaxKind.BarToken;
                    break;
                case '^':
                    info.Kind = SyntaxKind.CaretToken;
                    break;
                case '%':
                    info.Kind = SyntaxKind.PercentToken;
                    break;
                case '/':
                    info.Kind = SyntaxKind.SlashToken;
                    break;
                case '~':
                    info.Kind = SyntaxKind.TildeToken;
                    break;

                // NOTE: Special case - convert curly brackets into angle brackets.
                case '{':
                    info.Kind = SyntaxKind.LessThanToken;
                    break;
                case '}':
                    info.Kind = SyntaxKind.GreaterThanToken;
                    break;

                //// Multi-Character Punctuation/Operators ////
                case ':':
                    if (AdvanceIfMatches(':')) info.Kind = SyntaxKind.ColonColonToken;
                    else info.Kind = SyntaxKind.ColonToken;
                    break;
                case '=':
                    if (AdvanceIfMatches('=')) info.Kind = SyntaxKind.EqualsEqualsToken;
                    else info.Kind = SyntaxKind.EqualsToken;
                    break;
                case '!':
                    if (AdvanceIfMatches('=')) info.Kind = SyntaxKind.ExclamationEqualsToken;
                    else info.Kind = SyntaxKind.ExclamationToken;
                    break;
                case '>':
                    if (AdvanceIfMatches('=')) info.Kind = SyntaxKind.GreaterThanEqualsToken;
                    // GreaterThanGreaterThanToken is synthesized in the parser since it is ambiguous (with closing nested type parameter lists)
                    // else if (AdvanceIfMatches('>')) info.Kind = SyntaxKind.GreaterThanGreaterThanToken;
                    else info.Kind = SyntaxKind.GreaterThanToken;
                    break;
                case '<':
                    if (AdvanceIfMatches('=')) info.Kind = SyntaxKind.LessThanEqualsToken;
                    else if (AdvanceIfMatches('<')) info.Kind = SyntaxKind.LessThanLessThanToken;
                    else info.Kind = SyntaxKind.LessThanToken;
                    break;
                case '+':
                    if (AdvanceIfMatches('+')) info.Kind = SyntaxKind.PlusPlusToken;
                    else info.Kind = SyntaxKind.PlusToken;
                    break;
                case '-':
                    if (AdvanceIfMatches('-')) info.Kind = SyntaxKind.MinusMinusToken;
                    else info.Kind = SyntaxKind.MinusToken;
                    break;
            }

            if (info.Kind != SyntaxKind.None)
            {
                Debug.Assert(info.Text == null, "Haven't tried to set it yet.");
                Debug.Assert(info.StringValue == null, "Haven't tried to set it yet.");

                string valueText = SyntaxFacts.GetText(info.Kind);
                string actualText = TextWindow.GetText(intern: false);
                if (!string.IsNullOrEmpty(valueText) && actualText != valueText)
                {
                    info.RequiresTextForXmlEntity = true;
                    info.Text = actualText;
                    info.StringValue = valueText;
                }
            }
            else
            {
                // If we didn't match any of the above cases, then we either have an
                // identifier or an unexpected character.

                TextWindow.Reset(beforeConsumed);

                if (this.ScanIdentifier(ref info) && info.Text.Length > 0)
                {
                    // ACASEY:  All valid identifier characters should be valid in XML attribute values,
                    // but I don't want to add an assert because XML character classification is expensive.
                    // check to see if it is an actual keyword
                    // NOTE: name attribute values don't respect keywords - everything is an identifier.
                    SyntaxKind keywordKind;
                    if (!InXmlNameAttributeValue && !info.IsVerbatim && !info.HasIdentifierEscapeSequence && _cache.TryGetKeywordKind(info.StringValue, out keywordKind))
                    {
                        if (SyntaxFacts.IsContextualKeyword(keywordKind))
                        {
                            info.Kind = SyntaxKind.IdentifierToken;
                            info.ContextualKind = keywordKind;
                            // Don't need to set any special flags to store the original text of an identifier.
                        }
                        else
                        {
                            info.Kind = keywordKind;
                            info.RequiresTextForXmlEntity = info.Text != info.StringValue;
                        }
                    }
                    else
                    {
                        info.ContextualKind = info.Kind = SyntaxKind.IdentifierToken;
                    }
                }
                else
                {
                    if (consumedChar == '@')
                    {
                        // Saw '@', but it wasn't followed by an identifier (otherwise ScanIdentifier would have succeeded).
                        if (TextWindow.PeekChar() == '@')
                        {
                            TextWindow.NextChar();
                            info.Text = TextWindow.GetText(intern: true);
                            info.StringValue = ""; // Can't be null for an identifier.
                        }
                        else
                        {
                            this.ScanXmlEntity(ref info);
                        }
                        info.Kind = SyntaxKind.IdentifierToken;
                        this.AddError(ErrorCode.ERR_ExpectedVerbatimLiteral);
                    }
                    else if (TextWindow.PeekChar() == '&')
                    {
                        this.ScanXmlEntity(ref info);
                        info.Kind = SyntaxKind.XmlEntityLiteralToken;
                        this.AddCrefError(ErrorCode.ERR_UnexpectedCharacter, info.Text);
                    }
                    else
                    {
                        char bad = TextWindow.NextChar();
                        info.Text = TextWindow.GetText(intern: false);

                        // If it's valid in XML, then it was unexpected in cref mode.
                        // Otherwise, it's just bad XML.
                        if (MatchesProductionForXmlChar((uint)bad))
                        {
                            this.AddCrefError(ErrorCode.ERR_UnexpectedCharacter, info.Text);
                        }
                        else
                        {
                            this.AddError(XmlParseErrorCode.XML_InvalidUnicodeChar);
                        }
                    }
                }
            }

            Debug.Assert(info.Kind != SyntaxKind.None || info.Text != null);
            return info.Kind != SyntaxKind.None;
        }

        private bool AdvanceIfMatches(char ch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 158539, 159386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 158602, 158638);

                char
                peekCh = f_10014_158616_158637(TextWindow)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 158652, 158872) || true) && ((peekCh == ch) || (DynAbs.Tracing.TraceSender.Expression_False(10014, 158656, 158719) || (peekCh == '{' && (DynAbs.Tracing.TraceSender.Expression_True(10014, 158692, 158718) && ch == '<'))) || (DynAbs.Tracing.TraceSender.Expression_False(10014, 158656, 158768) || (peekCh == '}' && (DynAbs.Tracing.TraceSender.Expression_True(10014, 158741, 158767) && ch == '>'))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 158652, 158872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 158802, 158827);

                    f_10014_158802_158826(TextWindow);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 158845, 158857);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 158652, 158872);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 158888, 159346) || true) && (peekCh == '&')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 158888, 159346);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 158939, 158969);

                    int
                    pos = f_10014_158949_158968(TextWindow)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 158989, 159003);

                    char
                    nextChar
                    = default(char);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 159021, 159040);

                    char
                    nextSurrogate
                    = default(char);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 159058, 159289) || true) && (f_10014_159062_159122(TextWindow, out nextChar, out nextSurrogate) && (DynAbs.Tracing.TraceSender.Expression_True(10014, 159062, 159161) && nextChar == ch) && (DynAbs.Tracing.TraceSender.Expression_True(10014, 159062, 159216) && nextSurrogate == SlidingTextWindow.InvalidCharacter))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 159058, 159289);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 159258, 159270);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 159058, 159289);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 159309, 159331);

                    f_10014_159309_159330(
                                    TextWindow, pos);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 158888, 159346);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 159362, 159375);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 158539, 159386);

                char
                f_10014_158616_158637(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 158616, 158637);
                    return return_v;
                }


                int
                f_10014_158802_158826(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    this_param.AdvanceChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 158802, 158826);
                    return 0;
                }


                int
                f_10014_158949_158968(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 158949, 158968);
                    return return_v;
                }


                bool
                f_10014_159062_159122(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, out char
                ch, out char
                surrogate)
                {
                    var return_v = this_param.TryScanXmlEntity(out ch, out surrogate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 159062, 159122);
                    return return_v;
                }


                int
                f_10014_159309_159330(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param, int
                position)
                {
                    this_param.Reset(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 159309, 159330);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 158539, 159386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 158539, 159386);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool InXmlCrefOrNameAttributeValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 159646, 160092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 159682, 160077);

                    switch (_mode & LexerMode.MaskLexMode)
                    {

                        case LexerMode.XmlCrefQuote:
                        case LexerMode.XmlCrefDoubleQuote:
                        case LexerMode.XmlNameQuote:
                        case LexerMode.XmlNameDoubleQuote:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 159682, 160077);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 159977, 159989);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 159682, 160077);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 159682, 160077);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 160045, 160058);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 159682, 160077);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 159646, 160092);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 159579, 160103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 159579, 160103);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool InXmlNameAttributeValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 160349, 160689);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 160385, 160674);

                    switch (_mode & LexerMode.MaskLexMode)
                    {

                        case LexerMode.XmlNameQuote:
                        case LexerMode.XmlNameDoubleQuote:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 160385, 160674);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 160574, 160586);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 160385, 160674);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 160385, 160674);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 160642, 160655);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 160385, 160674);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 160349, 160689);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 160288, 160700);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 160288, 160700);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void AddCrefError(ErrorCode code, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 160884, 161024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 160972, 161013);

                f_10014_160972_161012(this, f_10014_160990_161011(code, args));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 160884, 161024);

                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10014_160990_161011(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = MakeError(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 160990, 161011);
                    return return_v;
                }


                int
                f_10014_160972_161012(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                info)
                {
                    this_param.AddCrefError((Microsoft.CodeAnalysis.DiagnosticInfo)info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 160972, 161012);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 160884, 161024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 160884, 161024);
            }
        }

        private void AddCrefError(DiagnosticInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 161208, 161415);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 161279, 161404) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 161279, 161404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 161329, 161389);

                    f_10014_161329_161388(this, ErrorCode.WRN_ErrorOverride, info, f_10014_161378_161387(info));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 161279, 161404);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 161208, 161415);

                int
                f_10014_161378_161387(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10014, 161378, 161387);
                    return return_v;
                }


                int
                f_10014_161329_161388(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    this_param.AddError(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 161329, 161388);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 161208, 161415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 161208, 161415);
            }
        }

        private SyntaxToken LexXmlCDataSectionTextToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 161537, 161984);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 161611, 161647);

                TokenInfo
                info = default(TokenInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 161663, 161696);

                SyntaxListBuilder
                leading = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 161710, 161758);

                f_10014_161710_161757(this, ref leading);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 161774, 161787);

                f_10014_161774_161786(
                            this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 161801, 161845);

                f_10014_161801_161844(this, ref info);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 161859, 161910);

                var
                errors = f_10014_161872_161909(this, f_10014_161887_161908(leading))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 161926, 161973);

                return f_10014_161933_161972(this, ref info, leading, null, errors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 161537, 161984);

                int
                f_10014_161710_161757(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder?
                trivia)
                {
                    this_param.LexXmlDocCommentLeadingTrivia(ref trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 161710, 161757);
                    return 0;
                }


                int
                f_10014_161774_161786(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 161774, 161786);
                    return 0;
                }


                bool
                f_10014_161801_161844(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info)
                {
                    var return_v = this_param.ScanXmlCDataSectionTextToken(ref info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 161801, 161844);
                    return return_v;
                }


                int
                f_10014_161887_161908(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                builder)
                {
                    var return_v = GetFullWidth(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 161887, 161908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
                f_10014_161872_161909(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, int
                leadingTriviaWidth)
                {
                    var return_v = this_param.GetErrors(leadingTriviaWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 161872, 161909);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_161933_161972(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                leading, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                trailing, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
                errors)
                {
                    var return_v = this_param.Create(ref info, leading, trailing, errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 161933, 161972);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 161537, 161984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 161537, 161984);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ScanXmlCDataSectionTextToken(ref TokenInfo info)
        {
            char ch;

            Debug.Assert(!this.LocationIs(XmlDocCommentLocation.Start));
            Debug.Assert(!this.LocationIs(XmlDocCommentLocation.Exterior));

            if (this.LocationIs(XmlDocCommentLocation.End))
            {
                info.Kind = SyntaxKind.EndOfDocumentationCommentToken;
                return true;
            }

            switch (ch = TextWindow.PeekChar())
            {
                case ']':
                    if (TextWindow.PeekChar(1) == ']' && TextWindow.PeekChar(2) == '>')
                    {
                        TextWindow.AdvanceChar(3);
                        info.Kind = SyntaxKind.XmlCDataEndToken;
                        break;
                    }

                    goto default;

                case '\r':
                case '\n':
                    ScanXmlTextLiteralNewLineToken(ref info);
                    break;

                case SlidingTextWindow.InvalidCharacter:
                    if (!TextWindow.IsReallyAtEnd())
                    {
                        goto default;
                    }

                    info.Kind = SyntaxKind.EndOfDocumentationCommentToken;
                    break;

                default:
                    if (SyntaxFacts.IsNewLine(ch))
                    {
                        goto case '\n';
                    }

                    this.ScanXmlCDataSectionText(ref info);
                    info.Kind = SyntaxKind.XmlTextLiteralToken;
                    break;
            }

            return true;
        }

        private void ScanXmlCDataSectionText(ref TokenInfo info)
        {
            while (true)
            {
                var ch = TextWindow.PeekChar();
                switch (ch)
                {
                    case ']':
                        if (TextWindow.PeekChar(1) == ']' && TextWindow.PeekChar(2) == '>')
                        {
                            info.StringValue = info.Text = TextWindow.GetText(false);
                            return;
                        }

                        goto default;

                    case '\r':
                    case '\n':
                        info.StringValue = info.Text = TextWindow.GetText(false);
                        return;

                    case SlidingTextWindow.InvalidCharacter:
                        if (!TextWindow.IsReallyAtEnd())
                        {
                            goto default;
                        }

                        info.StringValue = info.Text = TextWindow.GetText(false);
                        return;

                    case '*':
                        if (this.StyleIs(XmlDocCommentStyle.Delimited) && TextWindow.PeekChar(1) == '/')
                        {
                            // we're at the end of the comment, but don't lex it yet.
                            info.StringValue = info.Text = TextWindow.GetText(false);
                            return;
                        }

                        goto default;

                    default:
                        if (SyntaxFacts.IsNewLine(ch))
                        {
                            goto case '\n';
                        }

                        TextWindow.AdvanceChar();
                        break;
                }
            }
        }

        private SyntaxToken LexXmlCommentTextToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 165642, 166079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 165711, 165747);

                TokenInfo
                info = default(TokenInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 165763, 165796);

                SyntaxListBuilder
                leading = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 165810, 165858);

                f_10014_165810_165857(this, ref leading);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 165874, 165887);

                f_10014_165874_165886(
                            this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 165901, 165940);

                f_10014_165901_165939(this, ref info);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 165954, 166005);

                var
                errors = f_10014_165967_166004(this, f_10014_165982_166003(leading))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 166021, 166068);

                return f_10014_166028_166067(this, ref info, leading, null, errors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 165642, 166079);

                int
                f_10014_165810_165857(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder?
                trivia)
                {
                    this_param.LexXmlDocCommentLeadingTrivia(ref trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 165810, 165857);
                    return 0;
                }


                int
                f_10014_165874_165886(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 165874, 165886);
                    return 0;
                }


                bool
                f_10014_165901_165939(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info)
                {
                    var return_v = this_param.ScanXmlCommentTextToken(ref info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 165901, 165939);
                    return return_v;
                }


                int
                f_10014_165982_166003(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                builder)
                {
                    var return_v = GetFullWidth(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 165982, 166003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
                f_10014_165967_166004(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, int
                leadingTriviaWidth)
                {
                    var return_v = this_param.GetErrors(leadingTriviaWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 165967, 166004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_166028_166067(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                leading, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                trailing, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
                errors)
                {
                    var return_v = this_param.Create(ref info, leading, trailing, errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 166028, 166067);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 165642, 166079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 165642, 166079);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ScanXmlCommentTextToken(ref TokenInfo info)
        {
            char ch;

            Debug.Assert(!this.LocationIs(XmlDocCommentLocation.Start));
            Debug.Assert(!this.LocationIs(XmlDocCommentLocation.Exterior));

            if (this.LocationIs(XmlDocCommentLocation.End))
            {
                info.Kind = SyntaxKind.EndOfDocumentationCommentToken;
                return true;
            }

            switch (ch = TextWindow.PeekChar())
            {
                case '-':
                    if (TextWindow.PeekChar(1) == '-')
                    {
                        if (TextWindow.PeekChar(2) == '>')
                        {
                            TextWindow.AdvanceChar(3);
                            info.Kind = SyntaxKind.XmlCommentEndToken;
                            break;
                        }
                        else
                        {
                            TextWindow.AdvanceChar(2);
                            info.Kind = SyntaxKind.MinusMinusToken;
                            break;
                        }
                    }

                    goto default;

                case '\r':
                case '\n':
                    ScanXmlTextLiteralNewLineToken(ref info);
                    break;

                case SlidingTextWindow.InvalidCharacter:
                    if (!TextWindow.IsReallyAtEnd())
                    {
                        goto default;
                    }
                    info.Kind = SyntaxKind.EndOfDocumentationCommentToken;
                    break;

                default:
                    if (SyntaxFacts.IsNewLine(ch))
                    {
                        goto case '\n';
                    }

                    this.ScanXmlCommentText(ref info);
                    info.Kind = SyntaxKind.XmlTextLiteralToken;
                    break;
            }

            return true;
        }

        private void ScanXmlCommentText(ref TokenInfo info)
        {
            while (true)
            {
                var ch = TextWindow.PeekChar();
                switch (ch)
                {
                    case '-':
                        if (TextWindow.PeekChar(1) == '-')
                        {
                            info.StringValue = info.Text = TextWindow.GetText(false);
                            return;
                        }

                        goto default;

                    case '\r':
                    case '\n':
                        info.StringValue = info.Text = TextWindow.GetText(false);
                        return;

                    case SlidingTextWindow.InvalidCharacter:
                        if (!TextWindow.IsReallyAtEnd())
                        {
                            goto default;
                        }

                        info.StringValue = info.Text = TextWindow.GetText(false);
                        return;

                    case '*':
                        if (this.StyleIs(XmlDocCommentStyle.Delimited) && TextWindow.PeekChar(1) == '/')
                        {
                            // we're at the end of the comment, but don't lex it yet.
                            info.StringValue = info.Text = TextWindow.GetText(false);
                            return;
                        }

                        goto default;

                    default:
                        if (SyntaxFacts.IsNewLine(ch))
                        {
                            goto case '\n';
                        }

                        TextWindow.AdvanceChar();
                        break;
                }
            }
        }

        private SyntaxToken LexXmlProcessingInstructionTextToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 170041, 170506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 170124, 170160);

                TokenInfo
                info = default(TokenInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 170176, 170209);

                SyntaxListBuilder
                leading = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 170223, 170271);

                f_10014_170223_170270(this, ref leading);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 170287, 170300);

                f_10014_170287_170299(
                            this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 170314, 170367);

                f_10014_170314_170366(this, ref info);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 170381, 170432);

                var
                errors = f_10014_170394_170431(this, f_10014_170409_170430(leading))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 170448, 170495);

                return f_10014_170455_170494(this, ref info, leading, null, errors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 170041, 170506);

                int
                f_10014_170223_170270(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder?
                trivia)
                {
                    this_param.LexXmlDocCommentLeadingTrivia(ref trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 170223, 170270);
                    return 0;
                }


                int
                f_10014_170287_170299(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 170287, 170299);
                    return 0;
                }


                bool
                f_10014_170314_170366(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info)
                {
                    var return_v = this_param.ScanXmlProcessingInstructionTextToken(ref info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 170314, 170366);
                    return return_v;
                }


                int
                f_10014_170409_170430(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                builder)
                {
                    var return_v = GetFullWidth(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 170409, 170430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
                f_10014_170394_170431(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, int
                leadingTriviaWidth)
                {
                    var return_v = this_param.GetErrors(leadingTriviaWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 170394, 170431);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10014_170455_170494(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer.TokenInfo
                info, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                leading, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                trailing, Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo[]
                errors)
                {
                    var return_v = this_param.Create(ref info, leading, trailing, errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 170455, 170494);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 170041, 170506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 170041, 170506);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ScanXmlProcessingInstructionTextToken(ref TokenInfo info)
        {
            char ch;

            Debug.Assert(!this.LocationIs(XmlDocCommentLocation.Start));
            Debug.Assert(!this.LocationIs(XmlDocCommentLocation.Exterior));

            if (this.LocationIs(XmlDocCommentLocation.End))
            {
                info.Kind = SyntaxKind.EndOfDocumentationCommentToken;
                return true;
            }

            switch (ch = TextWindow.PeekChar())
            {
                case '?':
                    if (TextWindow.PeekChar(1) == '>')
                    {
                        TextWindow.AdvanceChar(2);
                        info.Kind = SyntaxKind.XmlProcessingInstructionEndToken;
                        break;
                    }

                    goto default;

                case '\r':
                case '\n':
                    ScanXmlTextLiteralNewLineToken(ref info);
                    break;

                case SlidingTextWindow.InvalidCharacter:
                    if (!TextWindow.IsReallyAtEnd())
                    {
                        goto default;
                    }

                    info.Kind = SyntaxKind.EndOfDocumentationCommentToken;
                    break;

                default:
                    if (SyntaxFacts.IsNewLine(ch))
                    {
                        goto case '\n';
                    }

                    this.ScanXmlProcessingInstructionText(ref info);
                    info.Kind = SyntaxKind.XmlTextLiteralToken;
                    break;
            }

            return true;
        }

        private void ScanXmlProcessingInstructionText(ref TokenInfo info)
        {
            while (true)
            {
                var ch = TextWindow.PeekChar();
                switch (ch)
                {
                    case '?':
                        if (TextWindow.PeekChar(1) == '>')
                        {
                            info.StringValue = info.Text = TextWindow.GetText(false);
                            return;
                        }

                        goto default;

                    case '\r':
                    case '\n':
                        info.StringValue = info.Text = TextWindow.GetText(false);
                        return;

                    case SlidingTextWindow.InvalidCharacter:
                        if (!TextWindow.IsReallyAtEnd())
                        {
                            goto default;
                        }

                        info.StringValue = info.Text = TextWindow.GetText(false);
                        return;

                    case '*':
                        if (this.StyleIs(XmlDocCommentStyle.Delimited) && TextWindow.PeekChar(1) == '/')
                        {
                            // we're at the end of the comment, but don't lex it yet.
                            info.StringValue = info.Text = TextWindow.GetText(false);
                            return;
                        }

                        goto default;

                    default:
                        if (SyntaxFacts.IsNewLine(ch))
                        {
                            goto case '\n';
                        }

                        TextWindow.AdvanceChar();
                        break;
                }
            }
        }

        private void LexXmlDocCommentLeadingTrivia(ref SyntaxListBuilder trivia)
        {
            var start = TextWindow.Position;
            this.Start();

            if (this.LocationIs(XmlDocCommentLocation.Start) && this.StyleIs(XmlDocCommentStyle.Delimited))
            {
                // Read the /** that begins an XML doc comment. Since these are recognized only
                // when the trailing character is not a '*', we wind up in the interior of the
                // doc comment at the end.

                if (TextWindow.PeekChar() == '/'
                    && TextWindow.PeekChar(1) == '*'
                    && TextWindow.PeekChar(2) == '*'
                    && TextWindow.PeekChar(3) != '*')
                {
                    TextWindow.AdvanceChar(3);
                    var text = TextWindow.GetText(true);
                    this.AddTrivia(SyntaxFactory.DocumentationCommentExteriorTrivia(text), ref trivia);
                    this.MutateLocation(XmlDocCommentLocation.Interior);
                    return;
                }
            }
            else if (this.LocationIs(XmlDocCommentLocation.Start) || this.LocationIs(XmlDocCommentLocation.Exterior))
            {
                // We're in the exterior of an XML doc comment and need to eat the beginnings of
                // lines, for single line and delimited comments. We chew up white space until
                // a non-whitespace character, and then make the right decision depending on
                // what kind of comment we're in.

                while (true)
                {
                    char ch = TextWindow.PeekChar();
                    switch (ch)
                    {
                        case ' ':
                        case '\t':
                        case '\v':
                        case '\f':
                            TextWindow.AdvanceChar();
                            break;

                        case '/':
                            if (this.StyleIs(XmlDocCommentStyle.SingleLine) && TextWindow.PeekChar(1) == '/' && TextWindow.PeekChar(2) == '/' && TextWindow.PeekChar(3) != '/')
                            {
                                TextWindow.AdvanceChar(3);
                                var text = TextWindow.GetText(true);
                                this.AddTrivia(SyntaxFactory.DocumentationCommentExteriorTrivia(text), ref trivia);
                                this.MutateLocation(XmlDocCommentLocation.Interior);
                                return;
                            }

                            goto default;

                        case '*':
                            if (this.StyleIs(XmlDocCommentStyle.Delimited))
                            {
                                while (TextWindow.PeekChar() == '*' && TextWindow.PeekChar(1) != '/')
                                {
                                    TextWindow.AdvanceChar();
                                }

                                var text = TextWindow.GetText(true);
                                if (!String.IsNullOrEmpty(text))
                                {
                                    this.AddTrivia(SyntaxFactory.DocumentationCommentExteriorTrivia(text), ref trivia);
                                }

                                // This setup ensures that on the final line of a comment, if we have
                                // the string "  */", the "*/" part is separated from the whitespace
                                // and therefore recognizable as the end of the comment.

                                if (TextWindow.PeekChar() == '*' && TextWindow.PeekChar(1) == '/')
                                {
                                    TextWindow.AdvanceChar(2);
                                    this.AddTrivia(SyntaxFactory.DocumentationCommentExteriorTrivia("*/"), ref trivia);
                                    this.MutateLocation(XmlDocCommentLocation.End);
                                }
                                else
                                {
                                    this.MutateLocation(XmlDocCommentLocation.Interior);
                                }

                                return;
                            }

                            goto default;

                        default:
                            if (SyntaxFacts.IsWhitespace(ch))
                            {
                                goto case ' ';
                            }

                            // so here we have something else. if this is a single-line xml
                            // doc comment, that means we're on a line that's no longer a doc
                            // comment, so we need to rewind. if we're in a delimited doc comment,
                            // then that means we hit pay dirt and we're back into xml text.

                            if (this.StyleIs(XmlDocCommentStyle.SingleLine))
                            {
                                TextWindow.Reset(start);
                                this.MutateLocation(XmlDocCommentLocation.End);
                            }
                            else // XmlDocCommentStyle.Delimited
                            {
                                Debug.Assert(this.StyleIs(XmlDocCommentStyle.Delimited));

                                var text = TextWindow.GetText(true);
                                if (!String.IsNullOrEmpty(text))
                                    this.AddTrivia(SyntaxFactory.DocumentationCommentExteriorTrivia(text), ref trivia);
                                this.MutateLocation(XmlDocCommentLocation.Interior);
                            }

                            return;
                    }
                }
            }
            else if (!this.LocationIs(XmlDocCommentLocation.End) && this.StyleIs(XmlDocCommentStyle.Delimited))
            {
                if (TextWindow.PeekChar() == '*' && TextWindow.PeekChar(1) == '/')
                {
                    TextWindow.AdvanceChar(2);
                    var text = TextWindow.GetText(true);
                    this.AddTrivia(SyntaxFactory.DocumentationCommentExteriorTrivia(text), ref trivia);
                    this.MutateLocation(XmlDocCommentLocation.End);
                }
            }
        }

        private void LexXmlDocCommentLeadingTriviaWithWhitespace(ref SyntaxListBuilder trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10014, 180998, 181631);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 181109, 181620) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 181109, 181620);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 181154, 181201);

                        f_10014_181154_181200(this, ref trivia);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 181221, 181253);

                        char
                        ch = f_10014_181231_181252(TextWindow)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 181271, 181605) || true) && (f_10014_181275_181322(this, XmlDocCommentLocation.Interior) && (DynAbs.Tracing.TraceSender.Expression_True(10014, 181275, 181406) && (f_10014_181348_181376(ch) || (DynAbs.Tracing.TraceSender.Expression_False(10014, 181348, 181405) || f_10014_181380_181405(ch)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 181271, 181605);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10014, 181448, 181498);

                            f_10014_181448_181497(this, ref trivia);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 181271, 181605);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10014, 181271, 181605);
                            DynAbs.Tracing.TraceSender.TraceBreak(10014, 181580, 181586);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 181271, 181605);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10014, 181109, 181620);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10014, 181109, 181620);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10014, 181109, 181620);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10014, 180998, 181631);

                int
                f_10014_181154_181200(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                trivia)
                {
                    this_param.LexXmlDocCommentLeadingTrivia(ref trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 181154, 181200);
                    return 0;
                }


                char
                f_10014_181231_181252(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.PeekChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 181231, 181252);
                    return return_v;
                }


                bool
                f_10014_181275_181322(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.XmlDocCommentLocation
                location)
                {
                    var return_v = this_param.LocationIs(location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 181275, 181322);
                    return return_v;
                }


                bool
                f_10014_181348_181376(char
                ch)
                {
                    var return_v = SyntaxFacts.IsWhitespace(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 181348, 181376);
                    return return_v;
                }


                bool
                f_10014_181380_181405(char
                ch)
                {
                    var return_v = SyntaxFacts.IsNewLine(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 181380, 181405);
                    return return_v;
                }


                int
                f_10014_181448_181497(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, ref Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                trivia)
                {
                    this_param.LexXmlWhitespaceAndNewLineTrivia(ref trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10014, 181448, 181497);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10014, 180998, 181631);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10014, 180998, 181631);
            }
        }

        private void LexXmlWhitespaceAndNewLineTrivia(ref SyntaxListBuilder trivia)
        {
            this.Start();
            if (this.LocationIs(XmlDocCommentLocation.Interior))
            {
                char ch = TextWindow.PeekChar();
                switch (ch)
                {
                    case ' ':
                    case '\t':       // Horizontal tab
                    case '\v':       // Vertical Tab
                    case '\f':       // Form-feed
                        this.AddTrivia(this.ScanWhitespace(), ref trivia);
                        break;

                    case '\r':
                    case '\n':
                        this.AddTrivia(this.ScanEndOfLine(), ref trivia);
                        this.MutateLocation(XmlDocCommentLocation.Exterior);
                        return;

                    case '*':
                        if (this.StyleIs(XmlDocCommentStyle.Delimited) && TextWindow.PeekChar(1) == '/')
                        {
                            // we're at the end of the comment, but don't add as trivia here.
                            return;
                        }

                        goto default;

                    default:
                        if (SyntaxFacts.IsWhitespace(ch))
                        {
                            goto case ' ';
                        }

                        if (SyntaxFacts.IsNewLine(ch))
                        {
                            goto case '\n';
                        }

                        return;
                }
            }
        }
    }
} 














