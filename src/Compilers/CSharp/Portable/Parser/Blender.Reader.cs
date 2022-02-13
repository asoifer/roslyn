// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{

    internal partial struct Blender
    {

        private struct Reader
        {

            private readonly Lexer _lexer;

            private Cursor _oldTreeCursor;

            private ImmutableStack<TextChangeRange> _changes;

            private int _newPosition;

            private int _changeDelta;

            private DirectiveStack _newDirectives;

            private DirectiveStack _oldDirectives;

            private LexerMode _newLexerDrivenMode;

            public Reader(Blender blender)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10028, 998, 1496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 1061, 1085);

                    _lexer = blender._lexer;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 1103, 1143);

                    _oldTreeCursor = blender._oldTreeCursor;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 1161, 1189);

                    _changes = blender._changes;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 1207, 1243);

                    _newPosition = blender._newPosition;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 1261, 1297);

                    _changeDelta = blender._changeDelta;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 1315, 1355);

                    _newDirectives = blender._newDirectives;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 1373, 1413);

                    _oldDirectives = blender._oldDirectives;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 1431, 1481);

                    _newLexerDrivenMode = blender._newLexerDrivenMode;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10028, 998, 1496);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10028, 998, 1496);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10028, 998, 1496);
                }
            }

            internal BlendedNode ReadNodeOrToken(LexerMode mode, bool asToken)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10028, 1512, 5289);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 2055, 5274) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 2055, 5274);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 2257, 2390) || true) && (_oldTreeCursor.IsFinished)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 2257, 2390);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 2336, 2367);

                                return this.ReadNewToken(mode);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 2257, 2390);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 3462, 5255) || true) && (_changeDelta < 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 3462, 5255);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 3675, 3695);

                                this.SkipOldToken();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 3462, 5255);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 3462, 5255);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 3745, 5255) || true) && (_changeDelta > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 3745, 5255);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 3954, 3985);

                                    return this.ReadNewToken(mode);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 3745, 5255);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 3745, 5255);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 4350, 4374);

                                    BlendedNode
                                    blendedNode
                                    = default(BlendedNode);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 4400, 4560) || true) && (this.TryTakeOldNodeOrToken(asToken, out blendedNode))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 4400, 4560);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 4514, 4533);

                                        return blendedNode;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 4400, 4560);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 4749, 5232) || true) && (_oldTreeCursor.CurrentNodeOrToken.IsNode)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 4749, 5232);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 4943, 4994);

                                        _oldTreeCursor = _oldTreeCursor.MoveToFirstChild();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 4749, 5232);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 4749, 5232);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 5185, 5205);

                                        this.SkipOldToken();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 4749, 5232);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 3745, 5255);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 3462, 5255);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 2055, 5274);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10028, 2055, 5274);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10028, 2055, 5274);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10028, 1512, 5289);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10028, 1512, 5289);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10028, 1512, 5289);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void SkipOldToken()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10028, 5305, 6248);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 5365, 5406);

                    f_10028_5365_5405(f_10028_5378_5404_M(!_oldTreeCursor.IsFinished));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 5594, 5645);

                    _oldTreeCursor = _oldTreeCursor.MoveToFirstToken();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 5663, 5708);

                    var
                    node = _oldTreeCursor.CurrentNodeOrToken
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 5767, 5798);

                    _changeDelta += node.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 5816, 5870);

                    _oldDirectives = node.ApplyDirectives(_oldDirectives);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 5888, 5940);

                    _oldTreeCursor = _oldTreeCursor.MoveToNextSibling();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 6210, 6233);

                    this.SkipPastChanges();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10028, 5305, 6248);

                    bool
                    f_10028_5378_5404_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10028, 5378, 5404);
                        return return_v;
                    }


                    int
                    f_10028_5365_5405(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10028, 5365, 5405);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10028, 5305, 6248);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10028, 5305, 6248);
                }
            }

            private void SkipPastChanges()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10028, 6264, 6704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 6327, 6388);

                    var
                    oldPosition = _oldTreeCursor.CurrentNodeOrToken.Position
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 6406, 6689) || true) && (f_10028_6413_6430_M(!_changes.IsEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(10028, 6413, 6473) && oldPosition >= f_10028_6449_6464(_changes).Span.End))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 6406, 6689);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 6515, 6544);

                            var
                            change = f_10028_6528_6543(_changes)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 6568, 6594);

                            _changes = f_10028_6579_6593(_changes);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 6616, 6670);

                            _changeDelta += change.NewLength - change.Span.Length;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 6406, 6689);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10028, 6406, 6689);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10028, 6406, 6689);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10028, 6264, 6704);

                    bool
                    f_10028_6413_6430_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10028, 6413, 6430);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextChangeRange
                    f_10028_6449_6464(System.Collections.Immutable.ImmutableStack<Microsoft.CodeAnalysis.Text.TextChangeRange>
                    this_param)
                    {
                        var return_v = this_param.Peek();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10028, 6449, 6464);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextChangeRange
                    f_10028_6528_6543(System.Collections.Immutable.ImmutableStack<Microsoft.CodeAnalysis.Text.TextChangeRange>
                    this_param)
                    {
                        var return_v = this_param.Peek();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10028, 6528, 6543);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableStack<Microsoft.CodeAnalysis.Text.TextChangeRange>
                    f_10028_6579_6593(System.Collections.Immutable.ImmutableStack<Microsoft.CodeAnalysis.Text.TextChangeRange>
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10028, 6579, 6593);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10028, 6264, 6704);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10028, 6264, 6704);
                }
            }

            private BlendedNode ReadNewToken(LexerMode mode)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10028, 6720, 8023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 6801, 6861);

                    f_10028_6801_6860(_changeDelta > 0 || (DynAbs.Tracing.TraceSender.Expression_False(10028, 6814, 6859) || _oldTreeCursor.IsFinished));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 7049, 7084);

                    var
                    token = this.LexNewToken(mode)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 7541, 7569);

                    var
                    width = f_10028_7553_7568(token)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 7587, 7609);

                    _newPosition += width;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 7627, 7649);

                    _changeDelta -= width;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 7909, 7932);

                    this.SkipPastChanges();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 7952, 8008);

                    return this.CreateBlendedNode(node: null, token: token);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10028, 6720, 8023);

                    int
                    f_10028_6801_6860(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10028, 6801, 6860);
                        return 0;
                    }


                    int
                    f_10028_7553_7568(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    this_param)
                    {
                        var return_v = this_param.FullWidth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10028, 7553, 7568);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10028, 6720, 8023);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10028, 6720, 8023);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private SyntaxToken LexNewToken(LexerMode mode)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10028, 8039, 8685);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 8119, 8269) || true) && (f_10028_8123_8149(_lexer.TextWindow) != _newPosition)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 8119, 8269);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 8207, 8250);

                        f_10028_8207_8249(_lexer, _newPosition, _newDirectives);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 8119, 8269);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 8289, 8413) || true) && (mode >= LexerMode.XmlDocComment)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 8289, 8413);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 8366, 8394);

                        mode |= _newLexerDrivenMode;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 8289, 8413);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 8433, 8466);

                    var
                    token = f_10028_8445_8465(_lexer, ref mode)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 8484, 8519);

                    _newDirectives = f_10028_8501_8518(_lexer);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 8537, 8639);

                    _newLexerDrivenMode = mode & (LexerMode.MaskXmlDocCommentLocation | LexerMode.MaskXmlDocCommentStyle);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 8657, 8670);

                    return token;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10028, 8039, 8685);

                    int
                    f_10028_8123_8149(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                    this_param)
                    {
                        var return_v = this_param.Position;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10028, 8123, 8149);
                        return return_v;
                    }


                    int
                    f_10028_8207_8249(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                    this_param, int
                    position, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                    directives)
                    {
                        this_param.Reset(position, directives);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10028, 8207, 8249);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    f_10028_8445_8465(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                    this_param, ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                    mode)
                    {
                        var return_v = this_param.Lex(ref mode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10028, 8445, 8465);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                    f_10028_8501_8518(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                    this_param)
                    {
                        var return_v = this_param.Directives;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10028, 8501, 8518);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10028, 8039, 8685);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10028, 8039, 8685);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool TryTakeOldNodeOrToken(
                            bool asToken,
                            out BlendedNode blendedNode)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10028, 8701, 10306);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 9016, 9139) || true) && (asToken)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 9016, 9139);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 9069, 9120);

                        _oldTreeCursor = _oldTreeCursor.MoveToFirstToken();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 9016, 9139);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 9349, 9408);

                    var
                    currentNodeOrToken = _oldTreeCursor.CurrentNodeOrToken
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 9426, 9590) || true) && (!CanReuse(currentNodeOrToken))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 9426, 9590);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 9501, 9536);

                        blendedNode = default(BlendedNode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 9558, 9571);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 9426, 9590);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 9747, 9792);

                    _newPosition += currentNodeOrToken.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 9810, 9862);

                    _oldTreeCursor = _oldTreeCursor.MoveToNextSibling();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 9882, 9950);

                    _newDirectives = currentNodeOrToken.ApplyDirectives(_newDirectives);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 9968, 10036);

                    _oldDirectives = currentNodeOrToken.ApplyDirectives(_oldDirectives);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 10056, 10261);


                    // LAFHIS
                    var temp1 = currentNodeOrToken.AsNode();
                    var temp2 = currentNodeOrToken.AsToken().Node;

                    blendedNode = CreateBlendedNode((CSharp.CSharpSyntaxNode)temp1, (SyntaxToken)temp2);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 10279, 10291);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10028, 8701, 10306);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10028, 8701, 10306);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10028, 8701, 10306);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool CanReuse(SyntaxNodeOrToken nodeOrToken)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10028, 10322, 13422);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 10706, 10810) || true) && (nodeOrToken.FullWidth == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 10706, 10810);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 10778, 10791);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 10706, 10810);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 11115, 11224) || true) && (nodeOrToken.ContainsAnnotations)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 11115, 11224);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 11192, 11205);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 11115, 11224);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 11334, 11450) || true) && (this.IntersectsNextChange(nodeOrToken))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 11334, 11450);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 11418, 11431);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 11334, 11450);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 11568, 11835) || true) && (nodeOrToken.ContainsDiagnostics || (DynAbs.Tracing.TraceSender.Expression_False(10028, 11572, 11761) || (nodeOrToken.IsToken && (DynAbs.Tracing.TraceSender.Expression_True(10028, 11629, 11718) && f_10028_11652_11718(((CSharpSyntaxNode)nodeOrToken.AsToken().Node))) && (DynAbs.Tracing.TraceSender.Expression_True(10028, 11629, 11760) && f_10028_11722_11760(nodeOrToken.Parent)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 11568, 11835);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 11803, 11816);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 11568, 11835);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 11942, 12057) || true) && (IsFabricatedToken(nodeOrToken.Kind()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 11942, 12057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 12025, 12038);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 11942, 12057);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 12955, 13197) || true) && ((nodeOrToken.IsToken && (DynAbs.Tracing.TraceSender.Expression_True(10028, 12960, 13014) && nodeOrToken.AsToken().IsMissing)) || (DynAbs.Tracing.TraceSender.Expression_False(10028, 12959, 13123) || (nodeOrToken.IsNode && (DynAbs.Tracing.TraceSender.Expression_True(10028, 13041, 13122) && IsIncomplete((CSharp.CSharpSyntaxNode)nodeOrToken.AsNode())))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 12955, 13197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 13165, 13178);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 12955, 13197);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 13217, 13325) || true) && (f_10028_13221_13252_M(!nodeOrToken.ContainsDirectives))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 13217, 13325);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 13294, 13306);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 13217, 13325);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 13345, 13407);

                    return _newDirectives.IncrementallyEquivalent(_oldDirectives);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10028, 10322, 13422);

                    bool
                    f_10028_11652_11718(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode?
                    this_param)
                    {
                        var return_v = this_param.ContainsSkippedText;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10028, 11652, 11718);
                        return return_v;
                    }


                    bool
                    f_10028_11722_11760(Microsoft.CodeAnalysis.SyntaxNode?
                    this_param)
                    {
                        var return_v = this_param.ContainsDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10028, 11722, 11760);
                        return return_v;
                    }


                    bool
                    f_10028_13221_13252_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10028, 13221, 13252);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10028, 10322, 13422);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10028, 10322, 13422);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool IntersectsNextChange(SyntaxNodeOrToken nodeOrToken)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10028, 13438, 13908);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 13535, 13629) || true) && (f_10028_13539_13555(_changes))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 13535, 13629);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 13597, 13610);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 13535, 13629);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 13649, 13684);

                    var
                    oldSpan = nodeOrToken.FullSpan
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 13702, 13740);

                    var
                    changeSpan = f_10028_13719_13734(_changes).Span
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 13851, 13893);

                    return oldSpan.IntersectsWith(changeSpan);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10028, 13438, 13908);

                    bool
                    f_10028_13539_13555(System.Collections.Immutable.ImmutableStack<Microsoft.CodeAnalysis.Text.TextChangeRange>
                    this_param)
                    {
                        var return_v = this_param.IsEmpty;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10028, 13539, 13555);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextChangeRange
                    f_10028_13719_13734(System.Collections.Immutable.ImmutableStack<Microsoft.CodeAnalysis.Text.TextChangeRange>
                    this_param)
                    {
                        var return_v = this_param.Peek();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10028, 13719, 13734);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10028, 13438, 13908);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10028, 13438, 13908);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static bool IsIncomplete(CSharp.CSharpSyntaxNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10028, 13924, 14275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 14214, 14260);

                    return f_10028_14221_14259(f_10028_14221_14249(f_10028_14221_14231(node)));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10028, 13924, 14275);

                    Microsoft.CodeAnalysis.GreenNode
                    f_10028_14221_14231(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Green;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10028, 14221, 14231);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.GreenNode?
                    f_10028_14221_14249(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetLastTerminal();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10028, 14221, 14249);
                        return return_v;
                    }


                    bool
                    f_10028_14221_14259(Microsoft.CodeAnalysis.GreenNode?
                    this_param)
                    {
                        var return_v = this_param.IsMissing;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10028, 14221, 14259);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10028, 13924, 14275);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10028, 13924, 14275);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static bool IsFabricatedToken(SyntaxKind kind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10028, 14351, 14781);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 14438, 14766);

                    switch (kind)
                    {

                        case SyntaxKind.GreaterThanGreaterThanToken:
                        case SyntaxKind.GreaterThanGreaterThanEqualsToken:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 14438, 14766);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 14634, 14646);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 14438, 14766);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10028, 14438, 14766);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 14702, 14747);

                            return f_10028_14709_14746(kind);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10028, 14438, 14766);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10028, 14351, 14781);

                    bool
                    f_10028_14709_14746(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind)
                    {
                        var return_v = SyntaxFacts.IsContextualKeyword(kind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10028, 14709, 14746);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10028, 14351, 14781);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10028, 14351, 14781);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private BlendedNode CreateBlendedNode(CSharp.CSharpSyntaxNode node, SyntaxToken token)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10028, 14797, 15116);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10028, 14916, 15101);

                    return f_10028_14923_15100(node, token, f_10028_14973_15099(_lexer, _oldTreeCursor, _changes, _newPosition, _changeDelta, _newDirectives, _oldDirectives, _newLexerDrivenMode));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10028, 14797, 15116);

                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender
                    f_10028_14973_15099(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                    lexer, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender.Cursor
                    oldTreeCursor, System.Collections.Immutable.ImmutableStack<Microsoft.CodeAnalysis.Text.TextChangeRange>
                    changes, int
                    newPosition, int
                    changeDelta, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                    newDirectives, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                    oldDirectives, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                    newLexerDrivenMode)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender(lexer, oldTreeCursor, changes, newPosition, changeDelta, newDirectives, oldDirectives, newLexerDrivenMode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10028, 14973, 15099);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode
                    f_10028_14923_15100(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    node, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    token, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender
                    blender)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode(node, token, blender);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10028, 14923, 15100);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10028, 14797, 15116);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10028, 14797, 15116);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static Reader()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10028, 565, 15127);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10028, 565, 15127);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10028, 565, 15127);
            }
        }
    }
}
