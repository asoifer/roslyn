// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{

    internal readonly partial struct Blender
    {

        private readonly Lexer _lexer;

        private readonly Cursor _oldTreeCursor;

        private readonly ImmutableStack<TextChangeRange> _changes;

        private readonly int _newPosition;

        private readonly int _changeDelta;

        private readonly DirectiveStack _newDirectives;

        private readonly DirectiveStack _oldDirectives;

        private readonly LexerMode _newLexerDrivenMode;

        public Blender(Lexer lexer, CSharp.CSharpSyntaxNode oldTree, IEnumerable<TextChangeRange> changes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10013, 1585, 3914);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 1708, 1736);

                // LAFHIS

                //f_10013_1708_1735(lexer != null);
                Debug.Assert(lexer != null);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 1708, 1735);

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 1750, 1765);

                _lexer = lexer;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 1779, 1831);

                //_changes = f_10013_1790_1830();
                _changes = ImmutableStack.Create<TextChangeRange>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 1790, 1830);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 1847, 3313) || true) && (changes != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10013, 1847, 3313);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 2882, 2932);

                    var
                    collapsed = TextChangeRange.Collapse(changes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 3178, 3240);

                    var
                    affectedRange = ExtendToAffectedRange(oldTree, collapsed)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 3258, 3298);

                    //_changes = f_10013_3269_3297(_changes, affectedRange);
                    _changes = _changes.Push(affectedRange);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 3269, 3297);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10013, 1847, 3313);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 3329, 3722) || true) && (oldTree == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10013, 3329, 3722);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 3456, 3486);

                    // LAFHIS
                    //_oldTreeCursor = f_10013_3473_3485();
                    _oldTreeCursor = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender.Cursor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 3473, 3485);

                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 3504, 3545);

                    //_newPosition = f_10013_3519_3544(lexer.TextWindow);
                    _newPosition = lexer.TextWindow.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10013, 3519, 3544);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10013, 3329, 3722);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10013, 3329, 3722);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 3611, 3672);

                    _oldTreeCursor = Cursor.FromRoot(oldTree).MoveToFirstChild();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 3690, 3707);

                    _newPosition = 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10013, 3329, 3722);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 3738, 3755);

                _changeDelta = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 3769, 3810);

                _newDirectives = default(DirectiveStack);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 3824, 3865);

                _oldDirectives = default(DirectiveStack);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 3879, 3903);

                _newLexerDrivenMode = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10013, 1585, 3914);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10013, 1585, 3914);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10013, 1585, 3914);
            }
        }

        private Blender(
                    Lexer lexer,
                    Cursor oldTreeCursor,
                    ImmutableStack<TextChangeRange> changes,
                    int newPosition,
                    int changeDelta,
                    DirectiveStack newDirectives,
                    DirectiveStack oldDirectives,
                    LexerMode newLexerDrivenMode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10013, 3926, 4808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 4271, 4299);

                // LAFHIS
                //f_10013_4271_4298(lexer != null);
                Debug.Assert(lexer != null);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 4271, 4298);

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 4313, 4343);

                //f_10013_4313_4342(changes != null);
                Debug.Assert(changes != null);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 4313, 4342);

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 4357, 4388);

                //f_10013_4357_4387(newPosition >= 0);
                Debug.Assert(newPosition >= 0);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 4357, 4387);

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 4402, 4417);

                _lexer = lexer;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 4431, 4462);

                _oldTreeCursor = oldTreeCursor;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 4476, 4495);

                _changes = changes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 4509, 4536);

                _newPosition = newPosition;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 4550, 4577);

                _changeDelta = changeDelta;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 4591, 4622);

                _newDirectives = newDirectives;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 4636, 4667);

                _oldDirectives = oldDirectives;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 4681, 4797);

                _newLexerDrivenMode = newLexerDrivenMode & (LexerMode.MaskXmlDocCommentLocation | LexerMode.MaskXmlDocCommentStyle);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10013, 3926, 4808);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10013, 3926, 4808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10013, 3926, 4808);
            }
        }

        private static TextChangeRange ExtendToAffectedRange(
                    CSharp.CSharpSyntaxNode oldTree,
                    TextChangeRange changeRange)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10013, 5098, 7727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 5555, 5582);

                const int
                maxLookahead = 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 5765, 5807);

                var
                lastCharIndex = f_10013_5785_5802(oldTree) - 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 5914, 5987);

                var
                start = f_10013_5926_5986(f_10013_5935_5982(changeRange.Span.Start, lastCharIndex), 0)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 6366, 6371);

                    // the first iteration aligns us with the change start. subsequent iteration move us to
                    // the left by maxLookahead tokens.  We only need to do this as long as we're not at the
                    // start of the tree.  Also, the tokens we get back may be zero width.  In that case we
                    // need to keep on looking backward.
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 6357, 6952) || true) && (start > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10013, 6373, 6403) && i <= maxLookahead))
        ; DynAbs.Tracing.TraceSender.TraceExitCondition(10013, 6357, 6952))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10013, 6357, 6952);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 6438, 6500);

                        var
                        token = f_10013_6450_6499(oldTree, start, findInsideTrivia: false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 6518, 6607);

                        f_10013_6518_6606(token.Kind() != SyntaxKind.None, "how could we not get a real token back?");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 6627, 6667);

                        start = f_10013_6635_6666(0, token.Position - 1);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 6849, 6937) || true) && (token.FullWidth > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10013, 6849, 6937);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 6914, 6918);

                            i++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10013, 6849, 6937);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10013, 1, 596);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10013, 1, 596);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 6968, 7481) || true) && (IsInsideInterpolation(oldTree, start))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10013, 6968, 7481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 7323, 7412);

                    var
                    column = f_10013_7336_7390(f_10013_7336_7354(oldTree), f_10013_7367_7389(start, 0)).Span.Start.Character
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 7430, 7466);

                    start = f_10013_7438_7465(start - column, 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10013, 6968, 7481);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 7497, 7562);

                var
                finalSpan = TextSpan.FromBounds(start, changeRange.Span.End)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 7576, 7651);

                var
                finalLength = changeRange.NewLength + (changeRange.Span.Start - start)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 7665, 7716);

                return f_10013_7672_7715(finalSpan, finalLength);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10013, 5098, 7727);

                int
                f_10013_5785_5802(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10013, 5785, 5802);
                    return return_v;
                }


                int
                f_10013_5935_5982(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 5935, 5982);
                    return return_v;
                }


                int
                f_10013_5926_5986(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 5926, 5986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10013_6450_6499(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, int
                position, bool
                findInsideTrivia)
                {
                    var return_v = this_param.FindToken(position, findInsideTrivia: findInsideTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 6450, 6499);
                    return return_v;
                }


                int
                f_10013_6518_6606(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 6518, 6606);
                    return 0;
                }


                int
                f_10013_6635_6666(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 6635, 6666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10013_7336_7354(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10013, 7336, 7354);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10013_7367_7389(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 7367, 7389);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_10013_7336_7390(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetLineSpan(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 7336, 7390);
                    return return_v;
                }


                int
                f_10013_7438_7465(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 7438, 7465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextChangeRange
                f_10013_7672_7715(Microsoft.CodeAnalysis.Text.TextSpan
                span, int
                newLength)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextChangeRange(span, newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 7672, 7715);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10013, 5098, 7727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10013, 5098, 7727);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsInsideInterpolation(CSharp.CSharpSyntaxNode oldTree, int start)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10013, 7739, 8270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 7849, 7911);

                var
                token = f_10013_7861_7910(oldTree, start, findInsideTrivia: false)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 7934, 7955);
                    for (var
        parent = token.Parent
        ; // for each parent
        (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 7925, 8230) || true) && (parent != null)
        ;
        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 8026, 8048)
        , parent = f_10013_8035_8048(parent), DynAbs.Tracing.TraceSender.TraceExitCondition(10013, 7925, 8230))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10013, 7925, 8230);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 8082, 8215) || true) && (f_10013_8086_8099(parent) == SyntaxKind.InterpolatedStringExpression)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10013, 8082, 8215);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 8184, 8196);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10013, 8082, 8215);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10013, 1, 306);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10013, 1, 306);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 8246, 8259);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10013, 7739, 8270);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10013_7861_7910(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, int
                position, bool
                findInsideTrivia)
                {
                    var return_v = this_param.FindToken(position, findInsideTrivia: findInsideTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 7861, 7910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10013_8035_8048(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10013, 8035, 8048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10013_8086_8099(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 8086, 8099);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10013, 7739, 8270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10013, 7739, 8270);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BlendedNode ReadNode(LexerMode mode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10013, 8282, 8406);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 8350, 8395);

                return ReadNodeOrToken(mode, asToken: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10013, 8282, 8406);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10013, 8282, 8406);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10013, 8282, 8406);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BlendedNode ReadToken(LexerMode mode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10013, 8418, 8542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 8487, 8531);

                return ReadNodeOrToken(mode, asToken: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10013, 8418, 8542);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10013, 8418, 8542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10013, 8418, 8542);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BlendedNode ReadNodeOrToken(LexerMode mode, bool asToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10013, 8554, 8744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 8644, 8674);

                var
                reader = f_10013_8657_8673(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10013, 8688, 8733);

                return reader.ReadNodeOrToken(mode, asToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10013, 8554, 8744);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender.Reader
                f_10013_8657_8673(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender
                blender)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender.Reader(blender);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 8657, 8673);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10013, 8554, 8744);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10013, 8554, 8744);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static Blender()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10013, 567, 8751);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10013, 567, 8751);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10013, 567, 8751);
        }

        int
        f_10013_1708_1735(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 1708, 1735);
            return 0;
        }


        System.Collections.Immutable.ImmutableStack<Microsoft.CodeAnalysis.Text.TextChangeRange>
        f_10013_1790_1830()
        {
            var return_v = ImmutableStack.Create<TextChangeRange>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 1790, 1830);
            return return_v;
        }


        System.Collections.Immutable.ImmutableStack<Microsoft.CodeAnalysis.Text.TextChangeRange>
        f_10013_3269_3297(System.Collections.Immutable.ImmutableStack<Microsoft.CodeAnalysis.Text.TextChangeRange>
        this_param, Microsoft.CodeAnalysis.Text.TextChangeRange
        value)
        {
            var return_v = this_param.Push(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 3269, 3297);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender.Cursor
        f_10013_3473_3485()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender.Cursor();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 3473, 3485);
            return return_v;
        }


        int
        f_10013_3519_3544(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
        this_param)
        {
            var return_v = this_param.Position;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10013, 3519, 3544);
            return return_v;
        }


        int
        f_10013_4271_4298(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 4271, 4298);
            return 0;
        }


        int
        f_10013_4313_4342(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 4313, 4342);
            return 0;
        }


        int
        f_10013_4357_4387(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10013, 4357, 4387);
            return 0;
        }

    }
}
