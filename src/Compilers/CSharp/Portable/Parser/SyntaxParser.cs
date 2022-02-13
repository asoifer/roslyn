// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    using Microsoft.CodeAnalysis.Syntax.InternalSyntax;
    internal abstract partial class SyntaxParser : IDisposable
    {
        protected readonly Lexer lexer;

        private readonly bool _isIncremental;

        private readonly bool _allowModeReset;

        protected readonly CancellationToken cancellationToken;

        private LexerMode _mode;

        private Blender _firstBlender;

        private BlendedNode _currentNode;

        private SyntaxToken _currentToken;

        private ArrayElement<SyntaxToken>[] _lexedTokens;

        private GreenNode _prevTokenTrailingTrivia;

        private int _firstToken;

        private int _tokenOffset;

        private int _tokenCount;

        private int _resetCount;

        private int _resetStart;

        private static readonly ObjectPool<BlendedNode[]> s_blendedNodesPool;

        private BlendedNode[] _blendedTokens;

        protected SyntaxParser(
                    Lexer lexer,
                    LexerMode mode,
                    CSharp.CSharpSyntaxNode oldTree,
                    IEnumerable<TextChangeRange> changes,
                    bool allowModeReset,
                    bool preLexIfNotIncremental = false,
                    CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10006, 1636, 3103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 688, 693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 726, 740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 773, 788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 884, 889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 1003, 1016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 1063, 1075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 1104, 1128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 1151, 1162);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 1244, 1256);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 1352, 1363);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 1386, 1397);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 1420, 1431);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 1609, 1623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 1999, 2018);

                this.lexer = lexer;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 2032, 2045);

                _mode = mode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 2059, 2092);

                _allowModeReset = allowModeReset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 2106, 2149);

                this.cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 2163, 2199);

                _currentNode = default(BlendedNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 2213, 2246);

                _isIncremental = oldTree != null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 2262, 2635) || true) && (f_10006_2266_2284(this) || (DynAbs.Tracing.TraceSender.Expression_False(10006, 2266, 2302) || allowModeReset))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 2262, 2635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 2336, 2389);

                    _firstBlender = f_10006_2352_2388(lexer, oldTree, changes);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 2407, 2454);

                    _blendedTokens = f_10006_2424_2453(s_blendedNodesPool);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 2262, 2635);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 2262, 2635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 2520, 2553);

                    _firstBlender = default(Blender);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 2571, 2620);

                    _lexedTokens = new ArrayElement<SyntaxToken>[32];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 2262, 2635);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 2944, 3092) || true) && (preLexIfNotIncremental && (DynAbs.Tracing.TraceSender.Expression_True(10006, 2948, 2993) && f_10006_2974_2993_M(!this.IsIncremental)) && (DynAbs.Tracing.TraceSender.Expression_True(10006, 2948, 3029) && !cancellationToken.CanBeCanceled))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 2944, 3092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 3063, 3077);

                    f_10006_3063_3076(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 2944, 3092);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10006, 1636, 3103);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 1636, 3103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 1636, 3103);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 3115, 3676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 3161, 3196);

                var
                blendedTokens = _blendedTokens
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 3210, 3665) || true) && (blendedTokens != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 3210, 3665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 3269, 3291);

                    _blendedTokens = null;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 3309, 3650) || true) && (f_10006_3313_3333(blendedTokens) < 4096)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 3309, 3650);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 3382, 3434);

                        f_10006_3382_3433(blendedTokens, 0, f_10006_3412_3432(blendedTokens));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 3456, 3495);

                        f_10006_3456_3494(s_blendedNodesPool, blendedTokens);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 3309, 3650);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 3309, 3650);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 3577, 3631);

                        f_10006_3577_3630(s_blendedNodesPool, blendedTokens);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 3309, 3650);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 3210, 3665);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 3115, 3676);

                int
                f_10006_3313_3333(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 3313, 3333);
                    return return_v;
                }


                int
                f_10006_3412_3432(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 3412, 3432);
                    return return_v;
                }


                int
                f_10006_3382_3433(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode[]
                array, int
                index, int
                length)
                {
                    Array.Clear((System.Array)array, index, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 3382, 3433);
                    return 0;
                }


                int
                f_10006_3456_3494(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode[]>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode[]
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 3456, 3494);
                    return 0;
                }


                int
                f_10006_3577_3630(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode[]>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode[]
                old)
                {
                    this_param.ForgetTrackedObject(old);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 3577, 3630);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 3115, 3676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 3115, 3676);
            }
        }

        protected void ReInitialize()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 3688, 4127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 3742, 3758);

                _firstToken = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 3772, 3789);

                _tokenOffset = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 3803, 3819);

                _tokenCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 3833, 3849);

                _resetCount = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 3863, 3879);

                _resetStart = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 3893, 3914);

                _currentToken = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 3928, 3960);

                _prevTokenTrailingTrivia = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 3974, 4116) || true) && (f_10006_3978_3996(this) || (DynAbs.Tracing.TraceSender.Expression_False(10006, 3978, 4015) || _allowModeReset))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 3974, 4116);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 4049, 4101);

                    _firstBlender = f_10006_4065_4100(this.lexer, null, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 3974, 4116);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 3688, 4127);

                bool
                f_10006_3978_3996(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    var return_v = this_param.IsIncremental;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 3978, 3996);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender
                f_10006_4065_4100(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                lexer, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                oldTree, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextChangeRange>
                changes)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender(lexer, oldTree, changes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 4065, 4100);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 3688, 4127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 3688, 4127);
            }
        }

        protected bool IsIncremental
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 4192, 4265);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 4228, 4250);

                    return _isIncremental;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 4192, 4265);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 4139, 4276);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 4139, 4276);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void PreLex()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 4288, 4938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 4421, 4500);

                var
                size = f_10006_4432_4499(4096, f_10006_4447_4498(32, f_10006_4460_4493(f_10006_4460_4486(this.lexer.TextWindow)) / 2))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 4514, 4565);

                _lexedTokens = new ArrayElement<SyntaxToken>[size];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 4579, 4602);

                var
                lexer = this.lexer
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 4616, 4633);

                var
                mode = _mode
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 4658, 4663);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 4649, 4927) || true) && (i < size)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 4675, 4678)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 4649, 4927))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 4649, 4927);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 4712, 4740);

                        var
                        token = f_10006_4724_4739(lexer, mode)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 4758, 4784);

                        f_10006_4758_4783(this, token);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 4802, 4912) || true) && (f_10006_4806_4816(token) == SyntaxKind.EndOfFileToken)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 4802, 4912);
                            DynAbs.Tracing.TraceSender.TraceBreak(10006, 4887, 4893);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 4802, 4912);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10006, 1, 279);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10006, 1, 279);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 4288, 4938);

                Microsoft.CodeAnalysis.Text.SourceText
                f_10006_4460_4486(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 4460, 4486);
                    return return_v;
                }


                int
                f_10006_4460_4493(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 4460, 4493);
                    return return_v;
                }


                int
                f_10006_4447_4498(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 4447, 4498);
                    return return_v;
                }


                int
                f_10006_4432_4499(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 4432, 4499);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_4724_4739(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = this_param.Lex(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 4724, 4739);
                    return return_v;
                }


                int
                f_10006_4758_4783(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    this_param.AddLexedToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 4758, 4783);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10006_4806_4816(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 4806, 4816);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 4288, 4938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 4288, 4938);
            }
        }

        protected ResetPoint GetResetPoint()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 4950, 5289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 5011, 5042);

                var
                pos = f_10006_5021_5041()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 5056, 5161) || true) && (_resetCount == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 5056, 5161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 5110, 5128);

                    _resetStart = pos;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 5056, 5161);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 5177, 5191);

                _resetCount++;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 5205, 5278);

                return f_10006_5212_5277(_resetCount, _mode, pos, _prevTokenTrailingTrivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 4950, 5289);

                int
                f_10006_5021_5041()
                {
                    var return_v = CurrentTokenPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 5021, 5041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser.ResetPoint
                f_10006_5212_5277(int
                resetCount, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode, int
                position, Microsoft.CodeAnalysis.GreenNode
                prevTokenTrailingTrivia)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser.ResetPoint(resetCount, mode, position, prevTokenTrailingTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 5212, 5277);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 4950, 5289);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 4950, 5289);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void Reset(ref ResetPoint point)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 5301, 6782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 5368, 5410);

                var
                offset = point.Position - _firstToken
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 5424, 5450);

                f_10006_5424_5449(offset >= 0);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 5466, 5809) || true) && (offset >= _tokenCount)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 5466, 5809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 5596, 5629);

                    f_10006_5596_5628(this, offset - _tokenOffset);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 5756, 5794);

                    offset = point.Position - _firstToken;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 5466, 5809);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 5825, 5844);

                _mode = point.Mode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 5858, 5908);

                f_10006_5858_5907(offset >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(10006, 5871, 5906) && offset < _tokenCount));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 5922, 5944);

                _tokenOffset = offset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 5958, 5979);

                _currentToken = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 5993, 6029);

                _currentNode = default(BlendedNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 6043, 6100);

                _prevTokenTrailingTrivia = point.PrevTokenTrailingTrivia;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 6114, 6771) || true) && (_blendedTokens != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 6114, 6771);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 6246, 6262);
                        // look forward for slots not holding a token
                        for (int
        i = _tokenOffset
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 6237, 6756) || true) && (i < _tokenCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 6281, 6284)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 6237, 6756))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 6237, 6756);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 6326, 6737) || true) && (_blendedTokens[i].Token == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 6326, 6737);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 6504, 6520);

                                _tokenCount = i;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 6546, 6682) || true) && (_tokenCount == _tokenOffset)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 6546, 6682);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 6635, 6655);

                                    f_10006_6635_6654(this);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 6546, 6682);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10006, 6708, 6714);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 6326, 6737);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10006, 1, 520);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10006, 1, 520);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 6114, 6771);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 5301, 6782);

                int
                f_10006_5424_5449(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 5424, 5449);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_5596_5628(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, int
                n)
                {
                    var return_v = this_param.PeekToken(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 5596, 5628);
                    return return_v;
                }


                int
                f_10006_5858_5907(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 5858, 5907);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_6635_6654(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    var return_v = this_param.FetchCurrentToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 6635, 6654);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 5301, 6782);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 5301, 6782);
            }
        }

        protected void Release(ref ResetPoint point)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 6794, 7048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 6863, 6909);

                f_10006_6863_6908(_resetCount == point.ResetCount);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 6923, 6937);

                _resetCount--;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 6951, 7037) || true) && (_resetCount == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 6951, 7037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 7005, 7022);

                    _resetStart = -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 6951, 7037);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 6794, 7048);

                int
                f_10006_6863_6908(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 6863, 6908);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 6794, 7048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 6794, 7048);
            }
        }

        public CSharpParseOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 7118, 7152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 7124, 7150);

                    return f_10006_7131_7149(this.lexer);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 7118, 7152);

                    Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                    f_10006_7131_7149(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 7131, 7149);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 7060, 7163);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 7060, 7163);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsScript
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 7220, 7273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 7226, 7271);

                    return f_10006_7233_7245(f_10006_7233_7240()) == SourceCodeKind.Script;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 7220, 7273);

                    Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                    f_10006_7233_7240()
                    {
                        var return_v = Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 7233, 7240);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SourceCodeKind
                    f_10006_7233_7245(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 7233, 7245);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 7175, 7284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 7175, 7284);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected LexerMode Mode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 7345, 7409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 7381, 7394);

                    return _mode;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 7345, 7409);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 7296, 7784);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 7296, 7784);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 7425, 7773);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 7461, 7758) || true) && (_mode != value)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 7461, 7758);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 7521, 7551);

                        f_10006_7521_7550(_allowModeReset);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 7575, 7589);

                        _mode = value;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 7611, 7632);

                        _currentToken = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 7654, 7690);

                        _currentNode = default(BlendedNode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 7712, 7739);

                        _tokenCount = _tokenOffset;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 7461, 7758);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 7425, 7773);

                    int
                    f_10006_7521_7550(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 7521, 7550);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 7296, 7784);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 7296, 7784);
                }
            }
        }

        protected CSharp.CSharpSyntaxNode CurrentNode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 7866, 8489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 7982, 8019);

                    f_10006_7982_8018(_blendedTokens != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 8252, 8281);

                    var
                    node = _currentNode.Node
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 8299, 8388) || true) && (node != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 8299, 8388);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 8357, 8369);

                        return node;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 8299, 8388);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 8408, 8431);

                    f_10006_8408_8430(
                                    this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 8449, 8474);

                    return _currentNode.Node;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 7866, 8489);

                    int
                    f_10006_7982_8018(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 7982, 8018);
                        return 0;
                    }


                    int
                    f_10006_8408_8430(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                    this_param)
                    {
                        this_param.ReadCurrentNode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 8408, 8430);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 7796, 8500);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 7796, 8500);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected SyntaxKind CurrentNodeKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 8573, 8716);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 8609, 8635);

                    var
                    cn = f_10006_8618_8634(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 8653, 8701);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10006, 8660, 8670) || ((cn != null && DynAbs.Tracing.TraceSender.Conditional_F2(10006, 8673, 8682)) || DynAbs.Tracing.TraceSender.Conditional_F3(10006, 8685, 8700))) ? f_10006_8673_8682(cn) : SyntaxKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 8573, 8716);

                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10006_8618_8634(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                    this_param)
                    {
                        var return_v = this_param.CurrentNode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 8618, 8634);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10006_8673_8682(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 8673, 8682);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 8512, 8727);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 8512, 8727);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void ReadCurrentNode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 8739, 9058);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 8794, 9047) || true) && (_tokenOffset == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 8794, 9047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 8849, 8894);

                    _currentNode = _firstBlender.ReadNode(_mode);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 8794, 9047);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 8794, 9047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 8960, 9032);

                    _currentNode = _blendedTokens[_tokenOffset - 1].Blender.ReadNode(_mode);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 8794, 9047);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 8739, 9058);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 8739, 9058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 8739, 9058);
            }
        }

        protected GreenNode EatNode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 9070, 9804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 9200, 9237);

                f_10006_9200_9236(_blendedTokens != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 9285, 9316);

                var
                result = f_10006_9298_9315(f_10006_9298_9309())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 9392, 9502) || true) && (_tokenOffset >= f_10006_9412_9433(_blendedTokens))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 9392, 9502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 9467, 9487);

                    f_10006_9467_9486(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 9392, 9502);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 9518, 9564);

                _blendedTokens[_tokenOffset++] = _currentNode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 9578, 9605);

                _tokenCount = _tokenOffset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 9692, 9728);

                _currentNode = default(BlendedNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 9742, 9763);

                _currentToken = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 9779, 9793);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 9070, 9804);

                int
                f_10006_9200_9236(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 9200, 9236);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10006_9298_9309()
                {
                    var return_v = CurrentNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 9298, 9309);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10006_9298_9315(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 9298, 9315);
                    return return_v;
                }


                int
                f_10006_9412_9433(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 9412, 9433);
                    return return_v;
                }


                int
                f_10006_9467_9486(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    this_param.AddTokenSlot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 9467, 9486);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 9070, 9804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 9070, 9804);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected SyntaxToken CurrentToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 9875, 9993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 9911, 9978);

                    return _currentToken ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(10006, 9918, 9977) ?? (_currentToken = f_10006_9952_9976(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 9875, 9993);

                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    f_10006_9952_9976(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                    this_param)
                    {
                        var return_v = this_param.FetchCurrentToken();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 9952, 9976);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 9816, 10004);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 9816, 10004);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private SyntaxToken FetchCurrentToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 10016, 10423);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 10080, 10179) || true) && (_tokenOffset >= _tokenCount)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 10080, 10179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 10145, 10164);

                    f_10006_10145_10163(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 10080, 10179);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 10195, 10412) || true) && (_blendedTokens != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 10195, 10412);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 10255, 10297);

                    return _blendedTokens[_tokenOffset].Token;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 10195, 10412);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 10195, 10412);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 10363, 10397);

                    return _lexedTokens[_tokenOffset];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 10195, 10412);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 10016, 10423);

                int
                f_10006_10145_10163(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    this_param.AddNewToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 10145, 10163);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 10016, 10423);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 10016, 10423);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddNewToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 10435, 11189);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 10486, 11178) || true) && (_blendedTokens != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 10486, 11178);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 10546, 11055) || true) && (_tokenCount > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 10546, 11055);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 10607, 10679);

                        f_10006_10607_10678(this, _blendedTokens[_tokenCount - 1].Blender.ReadToken(_mode));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 10546, 11055);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 10546, 11055);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 10761, 11036) || true) && (_currentNode.Token != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 10761, 11036);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 10841, 10869);

                            f_10006_10841_10868(this, _currentNode);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 10761, 11036);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 10761, 11036);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 10967, 11013);

                            f_10006_10967_11012(this, _firstBlender.ReadToken(_mode));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 10761, 11036);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 10546, 11055);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 10486, 11178);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 10486, 11178);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 11121, 11163);

                    f_10006_11121_11162(this, f_10006_11140_11161(this.lexer, _mode));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 10486, 11178);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 10435, 11189);

                int
                f_10006_10607_10678(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode
                tokenResult)
                {
                    this_param.AddToken(tokenResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 10607, 10678);
                    return 0;
                }


                int
                f_10006_10841_10868(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode
                tokenResult)
                {
                    this_param.AddToken(tokenResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 10841, 10868);
                    return 0;
                }


                int
                f_10006_10967_11012(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode
                tokenResult)
                {
                    this_param.AddToken(tokenResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 10967, 11012);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_11140_11161(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LexerMode
                mode)
                {
                    var return_v = this_param.Lex(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 11140, 11161);
                    return return_v;
                }


                int
                f_10006_11121_11162(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    this_param.AddLexedToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 11121, 11162);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 10435, 11189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 10435, 11189);
            }
        }

        private void AddToken(in BlendedNode tokenResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 11254, 11588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 11328, 11368);

                f_10006_11328_11367(tokenResult.Token != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 11382, 11491) || true) && (_tokenCount >= f_10006_11401_11422(_blendedTokens))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 11382, 11491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 11456, 11476);

                    f_10006_11456_11475(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 11382, 11491);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 11507, 11549);

                _blendedTokens[_tokenCount] = tokenResult;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 11563, 11577);

                _tokenCount++;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 11254, 11588);

                int
                f_10006_11328_11367(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 11328, 11367);
                    return 0;
                }


                int
                f_10006_11401_11422(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 11401, 11422);
                    return return_v;
                }


                int
                f_10006_11456_11475(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    this_param.AddTokenSlot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 11456, 11475);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 11254, 11588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 11254, 11588);
            }
        }

        private void AddLexedToken(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 11600, 11919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 11670, 11698);

                f_10006_11670_11697(token != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 11712, 11824) || true) && (_tokenCount >= f_10006_11731_11750(_lexedTokens))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 11712, 11824);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 11784, 11809);

                    f_10006_11784_11808(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 11712, 11824);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 11840, 11880);

                _lexedTokens[_tokenCount].Value = token;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 11894, 11908);

                _tokenCount++;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 11600, 11919);

                int
                f_10006_11670_11697(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 11670, 11697);
                    return 0;
                }


                int
                f_10006_11731_11750(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 11731, 11750);
                    return return_v;
                }


                int
                f_10006_11784_11808(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    this_param.AddLexedTokenSlot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 11784, 11808);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 11600, 11919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 11600, 11919);
            }
        }

        private void AddTokenSlot()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 11931, 13161);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 12155, 13150) || true) && (_tokenOffset > (f_10006_12175_12196(_blendedTokens) >> 1)
                && (DynAbs.Tracing.TraceSender.Expression_True(10006, 12159, 12271) && (_resetStart == -1 || (DynAbs.Tracing.TraceSender.Expression_False(10006, 12224, 12270) || _resetStart > _firstToken))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 12155, 13150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 12305, 12386);

                    int
                    shiftOffset = (DynAbs.Tracing.TraceSender.Conditional_F1(10006, 12323, 12342) || (((_resetStart == -1) && DynAbs.Tracing.TraceSender.Conditional_F2(10006, 12345, 12357)) || DynAbs.Tracing.TraceSender.Conditional_F3(10006, 12360, 12385))) ? _tokenOffset : _resetStart - _firstToken
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 12404, 12447);

                    int
                    shiftCount = _tokenCount - shiftOffset
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 12465, 12495);

                    f_10006_12465_12494(shiftOffset > 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 12513, 12569);

                    _firstBlender = _blendedTokens[shiftOffset - 1].Blender;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 12587, 12737) || true) && (shiftCount > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 12587, 12737);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 12647, 12718);

                        f_10006_12647_12717(_blendedTokens, shiftOffset, _blendedTokens, 0, shiftCount);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 12587, 12737);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 12757, 12784);

                    _firstToken += shiftOffset;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 12802, 12829);

                    _tokenCount -= shiftOffset;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 12847, 12875);

                    _tokenOffset -= shiftOffset;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 12155, 13150);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 12155, 13150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 12941, 12966);

                    var
                    old = _blendedTokens
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 12984, 13044);

                    f_10006_12984_13043(ref _blendedTokens, f_10006_13017_13038(_blendedTokens) * 2);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 13062, 13135);

                    f_10006_13062_13134(s_blendedNodesPool, old, replacement: _blendedTokens);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 12155, 13150);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 11931, 13161);

                int
                f_10006_12175_12196(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 12175, 12196);
                    return return_v;
                }


                int
                f_10006_12465_12494(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 12465, 12494);
                    return 0;
                }


                int
                f_10006_12647_12717(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode[]
                sourceArray, int
                sourceIndex, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 12647, 12717);
                    return 0;
                }


                int
                f_10006_13017_13038(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 13017, 13038);
                    return return_v;
                }


                int
                f_10006_12984_13043(ref Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode[]
                array, int
                newSize)
                {
                    Array.Resize(ref array, newSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 12984, 13043);
                    return 0;
                }


                int
                f_10006_13062_13134(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode[]>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode[]
                old, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode[]
                replacement)
                {
                    this_param.ForgetTrackedObject(old, replacement: replacement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 13062, 13134);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 11931, 13161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 11931, 13161);
            }
        }

        private void AddLexedTokenSlot()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 13173, 14305);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 13402, 14294) || true) && (_tokenOffset > (f_10006_13422_13441(_lexedTokens) >> 1)
                && (DynAbs.Tracing.TraceSender.Expression_True(10006, 13406, 13516) && (_resetStart == -1 || (DynAbs.Tracing.TraceSender.Expression_False(10006, 13469, 13515) || _resetStart > _firstToken))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 13402, 14294);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 13550, 13631);

                    int
                    shiftOffset = (DynAbs.Tracing.TraceSender.Conditional_F1(10006, 13568, 13587) || (((_resetStart == -1) && DynAbs.Tracing.TraceSender.Conditional_F2(10006, 13590, 13602)) || DynAbs.Tracing.TraceSender.Conditional_F3(10006, 13605, 13630))) ? _tokenOffset : _resetStart - _firstToken
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 13649, 13692);

                    int
                    shiftCount = _tokenCount - shiftOffset
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 13710, 13740);

                    f_10006_13710_13739(shiftOffset > 0);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 13758, 13904) || true) && (shiftCount > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 13758, 13904);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 13818, 13885);

                        f_10006_13818_13884(_lexedTokens, shiftOffset, _lexedTokens, 0, shiftCount);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 13758, 13904);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 13924, 13951);

                    _firstToken += shiftOffset;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 13969, 13996);

                    _tokenCount -= shiftOffset;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 14014, 14042);

                    _tokenOffset -= shiftOffset;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 13402, 14294);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 13402, 14294);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 14108, 14173);

                    var
                    tmp = new ArrayElement<SyntaxToken>[f_10006_14148_14167(_lexedTokens) * 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 14191, 14242);

                    f_10006_14191_14241(_lexedTokens, tmp, f_10006_14221_14240(_lexedTokens));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 14260, 14279);

                    _lexedTokens = tmp;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 13402, 14294);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 13173, 14305);

                int
                f_10006_13422_13441(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 13422, 13441);
                    return return_v;
                }


                int
                f_10006_13710_13739(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 13710, 13739);
                    return 0;
                }


                int
                f_10006_13818_13884(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>[]
                sourceArray, int
                sourceIndex, Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 13818, 13884);
                    return 0;
                }


                int
                f_10006_14148_14167(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 14148, 14167);
                    return return_v;
                }


                int
                f_10006_14221_14240(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 14221, 14240);
                    return return_v;
                }


                int
                f_10006_14191_14241(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>[]
                sourceArray, Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>[]
                destinationArray, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, (System.Array)destinationArray, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 14191, 14241);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 13173, 14305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 13173, 14305);
            }
        }

        protected SyntaxToken PeekToken(int n)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 14317, 14773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 14380, 14401);

                f_10006_14380_14400(n >= 0);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 14415, 14521) || true) && (_tokenOffset + n >= _tokenCount)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 14415, 14521);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 14487, 14506);

                        f_10006_14487_14505(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 14415, 14521);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10006, 14415, 14521);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10006, 14415, 14521);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 14537, 14762) || true) && (_blendedTokens != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 14537, 14762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 14597, 14643);

                    return _blendedTokens[_tokenOffset + n].Token;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 14537, 14762);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 14537, 14762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 14709, 14747);

                    return _lexedTokens[_tokenOffset + n];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 14537, 14762);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 14317, 14773);

                int
                f_10006_14380_14400(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 14380, 14400);
                    return 0;
                }


                int
                f_10006_14487_14505(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    this_param.AddNewToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 14487, 14505);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 14317, 14773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 14317, 14773);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected SyntaxToken EatToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 14897, 15048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 14954, 14981);

                var
                ct = f_10006_14963_14980(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 14995, 15013);

                f_10006_14995_15012(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 15027, 15037);

                return ct;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 14897, 15048);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_14963_14980(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 14963, 14980);
                    return return_v;
                }


                int
                f_10006_14995_15012(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    this_param.MoveToNextToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 14995, 15012);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 14897, 15048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 14897, 15048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected SyntaxToken TryEatToken(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 15328, 15386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 15331, 15386);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10006, 15331, 15361) || ((f_10006_15331_15353(f_10006_15331_15348(this)) == kind && DynAbs.Tracing.TraceSender.Conditional_F2(10006, 15364, 15379)) || DynAbs.Tracing.TraceSender.Conditional_F3(10006, 15382, 15386))) ? f_10006_15364_15379(this) : null; DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 15328, 15386);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 15328, 15386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 15328, 15386);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void MoveToNextToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 15399, 15721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 15454, 15515);

                _prevTokenTrailingTrivia = f_10006_15481_15514(_currentToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 15531, 15552);

                _currentToken = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 15568, 15679) || true) && (_blendedTokens != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 15568, 15679);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 15628, 15664);

                    _currentNode = default(BlendedNode);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 15568, 15679);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 15695, 15710);

                _tokenOffset++;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 15399, 15721);

                Microsoft.CodeAnalysis.GreenNode
                f_10006_15481_15514(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetTrailingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 15481, 15514);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 15399, 15721);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 15399, 15721);
            }
        }

        protected void ForceEndOfFile()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 15733, 15863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 15789, 15852);

                _currentToken = f_10006_15805_15851(SyntaxKind.EndOfFileToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 15733, 15863);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_15805_15851(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.Token(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 15805, 15851);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 15733, 15863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 15733, 15863);
            }
        }

        protected SyntaxToken EatToken(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 15987, 16429);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 16059, 16102);

                f_10006_16059_16101(f_10006_16072_16100(kind));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 16118, 16145);

                var
                ct = f_10006_16127_16144(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 16159, 16273) || true) && (f_10006_16163_16170(ct) == kind)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 16159, 16273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 16212, 16230);

                    f_10006_16212_16229(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 16248, 16258);

                    return ct;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 16159, 16273);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 16343, 16418);

                return f_10006_16350_16417(this, kind, f_10006_16375_16397(f_10006_16375_16392(this)), reportError: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 15987, 16429);

                bool
                f_10006_16072_16100(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsAnyToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 16072, 16100);
                    return return_v;
                }


                int
                f_10006_16059_16101(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 16059, 16101);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_16127_16144(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 16127, 16144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10006_16163_16170(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 16163, 16170);
                    return return_v;
                }


                int
                f_10006_16212_16229(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    this_param.MoveToNextToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 16212, 16229);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_16375_16392(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 16375, 16392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10006_16375_16397(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 16375, 16397);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_16350_16417(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                expected, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                actual, bool
                reportError)
                {
                    var return_v = this_param.CreateMissingToken(expected, actual, reportError: reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 16350, 16417);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 15987, 16429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 15987, 16429);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected SyntaxToken EatTokenAsKind(SyntaxKind expected)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 16562, 17059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 16644, 16691);

                f_10006_16644_16690(f_10006_16657_16689(expected));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 16707, 16734);

                var
                ct = f_10006_16716_16733(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 16748, 16866) || true) && (f_10006_16752_16759(ct) == expected)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 16748, 16866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 16805, 16823);

                    f_10006_16805_16822(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 16841, 16851);

                    return ct;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 16748, 16866);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 16882, 16972);

                var
                replacement = f_10006_16900_16971(this, expected, f_10006_16929_16951(f_10006_16929_16946(this)), reportError: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 16986, 17048);

                return f_10006_16993_17047(this, replacement, f_10006_17031_17046(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 16562, 17059);

                bool
                f_10006_16657_16689(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsAnyToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 16657, 16689);
                    return return_v;
                }


                int
                f_10006_16644_16690(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 16644, 16690);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_16716_16733(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 16716, 16733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10006_16752_16759(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 16752, 16759);
                    return return_v;
                }


                int
                f_10006_16805_16822(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    this_param.MoveToNextToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 16805, 16822);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_16929_16946(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 16929, 16946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10006_16929_16951(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 16929, 16951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_16900_16971(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                expected, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                actual, bool
                reportError)
                {
                    var return_v = this_param.CreateMissingToken(expected, actual, reportError: reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 16900, 16971);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_17031_17046(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 17031, 17046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_16993_17047(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                skippedSyntax)
                {
                    var return_v = this_param.AddTrailingSkippedSyntax<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, (Microsoft.CodeAnalysis.GreenNode)skippedSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 16993, 17047);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 16562, 17059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 16562, 17059);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxToken CreateMissingToken(SyntaxKind expected, SyntaxKind actual, bool reportError)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 17071, 17517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 17263, 17312);

                var
                token = f_10006_17275_17311(expected)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 17326, 17477) || true) && (reportError)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 17326, 17477);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 17375, 17462);

                    token = f_10006_17383_17461(this, token, f_10006_17416_17460(this, expected, actual));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 17326, 17477);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 17493, 17506);

                return token;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 17071, 17517);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_17275_17311(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.MissingToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 17275, 17311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10006_17416_17460(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                expected, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                actual)
                {
                    var return_v = this_param.GetExpectedTokenError(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 17416, 17460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_17383_17461(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, params Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics)
                {
                    var return_v = this_param.WithAdditionalDiagnostics<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 17383, 17461);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 17071, 17517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 17071, 17517);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxToken CreateMissingToken(SyntaxKind expected, ErrorCode code, bool reportError)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 17529, 17915);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 17718, 17767);

                var
                token = f_10006_17730_17766(expected)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 17781, 17875) || true) && (reportError)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 17781, 17875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 17830, 17860);

                    token = f_10006_17838_17859(this, token, code);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 17781, 17875);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 17891, 17904);

                return token;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 17529, 17915);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_17730_17766(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.MissingToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 17730, 17766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_17838_17859(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = this_param.AddError<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 17838, 17859);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 17529, 17915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 17529, 17915);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected SyntaxToken EatToken(SyntaxKind kind, bool reportError)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 17927, 18474);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 18017, 18103) || true) && (reportError)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 18017, 18103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 18066, 18088);

                    return f_10006_18073_18087(this, kind);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 18017, 18103);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 18119, 18162);

                f_10006_18119_18161(f_10006_18132_18160(kind));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 18176, 18463) || true) && (f_10006_18180_18202(f_10006_18180_18197(this)) != kind)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 18176, 18463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 18319, 18359);

                    return f_10006_18326_18358(kind);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 18176, 18463);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 18176, 18463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 18425, 18448);

                    return f_10006_18432_18447(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 18176, 18463);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 17927, 18474);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_18073_18087(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = this_param.EatToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 18073, 18087);
                    return return_v;
                }


                bool
                f_10006_18132_18160(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsAnyToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 18132, 18160);
                    return return_v;
                }


                int
                f_10006_18119_18161(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 18119, 18161);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_18180_18197(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 18180, 18197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10006_18180_18202(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 18180, 18202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_18326_18358(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFactory.MissingToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 18326, 18358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_18432_18447(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 18432, 18447);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 17927, 18474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 17927, 18474);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected SyntaxToken EatToken(SyntaxKind kind, ErrorCode code, bool reportError = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 18486, 18890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 18599, 18642);

                f_10006_18599_18641(f_10006_18612_18640(kind));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 18656, 18879) || true) && (f_10006_18660_18682(f_10006_18660_18677(this)) != kind)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 18656, 18879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 18724, 18775);

                    return f_10006_18731_18774(this, kind, code, reportError);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 18656, 18879);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 18656, 18879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 18841, 18864);

                    return f_10006_18848_18863(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 18656, 18879);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 18486, 18890);

                bool
                f_10006_18612_18640(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsAnyToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 18612, 18640);
                    return return_v;
                }


                int
                f_10006_18599_18641(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 18599, 18641);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_18660_18677(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 18660, 18677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10006_18660_18682(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 18660, 18682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_18731_18774(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                expected, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, bool
                reportError)
                {
                    var return_v = this_param.CreateMissingToken(expected, code, reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 18731, 18774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_18848_18863(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 18848, 18863);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 18486, 18890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 18486, 18890);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected SyntaxToken EatTokenWithPrejudice(SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 18902, 19323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 18987, 19017);

                var
                token = f_10006_18999_19016(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 19031, 19074);

                f_10006_19031_19073(f_10006_19044_19072(kind));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 19088, 19246) || true) && (f_10006_19092_19102(token) != kind)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 19088, 19246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 19144, 19231);

                    token = f_10006_19152_19230(this, token, f_10006_19185_19229(this, kind, f_10006_19218_19228(token)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 19088, 19246);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 19262, 19285);

                f_10006_19262_19284(
                            this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 19299, 19312);

                return token;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 18902, 19323);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_18999_19016(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 18999, 19016);
                    return return_v;
                }


                bool
                f_10006_19044_19072(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsAnyToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 19044, 19072);
                    return return_v;
                }


                int
                f_10006_19031_19073(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 19031, 19073);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10006_19092_19102(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 19092, 19102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10006_19218_19228(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 19218, 19228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10006_19185_19229(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                expected, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                actual)
                {
                    var return_v = this_param.GetExpectedTokenError(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 19185, 19229);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_19152_19230(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, params Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics)
                {
                    var return_v = this_param.WithAdditionalDiagnostics<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 19152, 19230);
                    return return_v;
                }


                int
                f_10006_19262_19284(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    this_param.MoveToNextToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 19262, 19284);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 18902, 19323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 18902, 19323);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected SyntaxToken EatTokenWithPrejudice(ErrorCode errorCode, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 19335, 19639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 19446, 19474);

                var
                token = f_10006_19458_19473(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 19488, 19601);

                token = f_10006_19496_19600(this, token, f_10006_19529_19599(f_10006_19539_19568(token), f_10006_19570_19581(token), errorCode, args));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 19615, 19628);

                return token;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 19335, 19639);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_19458_19473(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 19458, 19473);
                    return return_v;
                }


                int
                f_10006_19539_19568(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetLeadingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 19539, 19568);
                    return return_v;
                }


                int
                f_10006_19570_19581(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 19570, 19581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10006_19529_19599(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = MakeError(offset, width, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 19529, 19599);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_19496_19600(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, params Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics)
                {
                    var return_v = this_param.WithAdditionalDiagnostics<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 19496, 19600);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 19335, 19639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 19335, 19639);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected SyntaxToken EatContextualToken(SyntaxKind kind, ErrorCode code, bool reportError = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 19651, 20095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 19774, 19817);

                f_10006_19774_19816(f_10006_19787_19815(kind));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 19833, 20084) || true) && (f_10006_19837_19869(f_10006_19837_19854(this)) != kind)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 19833, 20084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 19911, 19962);

                    return f_10006_19918_19961(this, kind, code, reportError);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 19833, 20084);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 19833, 20084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 20028, 20069);

                    return f_10006_20035_20068(f_10006_20052_20067(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 19833, 20084);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 19651, 20095);

                bool
                f_10006_19787_19815(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsAnyToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 19787, 19815);
                    return return_v;
                }


                int
                f_10006_19774_19816(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 19774, 19816);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_19837_19854(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 19837, 19854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10006_19837_19869(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ContextualKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 19837, 19869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_19918_19961(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                expected, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, bool
                reportError)
                {
                    var return_v = this_param.CreateMissingToken(expected, code, reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 19918, 19961);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_20052_20067(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 20052, 20067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_20035_20068(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = ConvertToKeyword(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 20035, 20068);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 19651, 20095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 19651, 20095);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected SyntaxToken EatContextualToken(SyntaxKind kind, bool reportError = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 20107, 20595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 20214, 20257);

                f_10006_20214_20256(f_10006_20227_20255(kind));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 20273, 20327);

                var
                contextualKind = f_10006_20294_20326(f_10006_20294_20311(this))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 20341, 20584) || true) && (contextualKind != kind)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 20341, 20584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 20401, 20462);

                    return f_10006_20408_20461(this, kind, contextualKind, reportError);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 20341, 20584);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 20341, 20584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 20528, 20569);

                    return f_10006_20535_20568(f_10006_20552_20567(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 20341, 20584);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 20107, 20595);

                bool
                f_10006_20227_20255(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsAnyToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 20227, 20255);
                    return return_v;
                }


                int
                f_10006_20214_20256(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 20214, 20256);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_20294_20311(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 20294, 20311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10006_20294_20326(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ContextualKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 20294, 20326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_20408_20461(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                expected, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                actual, bool
                reportError)
                {
                    var return_v = this_param.CreateMissingToken(expected, actual, reportError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 20408, 20461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_20552_20567(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    var return_v = this_param.EatToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 20552, 20567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_20535_20568(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = ConvertToKeyword(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 20535, 20568);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 20107, 20595);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 20107, 20595);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual SyntaxDiagnosticInfo GetExpectedTokenError(SyntaxKind expected, SyntaxKind actual, int offset, int width)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 20607, 21199);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 20755, 20810);

                var
                code = f_10006_20766_20809(expected, actual)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 20824, 21188) || true) && (code == ErrorCode.ERR_SyntaxError || (DynAbs.Tracing.TraceSender.Expression_False(10006, 20828, 20907) || code == ErrorCode.ERR_IdentifierExpectedKW))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 20824, 21188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 20941, 21054);

                    return f_10006_20948_21053(offset, width, code, f_10006_20994_21023(expected), f_10006_21025_21052(actual));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 20824, 21188);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 20824, 21188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 21120, 21173);

                    return f_10006_21127_21172(offset, width, code);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 20824, 21188);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 20607, 21199);

                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10006_20766_20809(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                expected, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                actual)
                {
                    var return_v = GetExpectedTokenErrorCode(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 20766, 20809);
                    return return_v;
                }


                string
                f_10006_20994_21023(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 20994, 21023);
                    return return_v;
                }


                string
                f_10006_21025_21052(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 21025, 21052);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10006_20948_21053(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo(offset, width, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 20948, 21053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10006_21127_21172(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo(offset, width, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 21127, 21172);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 20607, 21199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 20607, 21199);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual SyntaxDiagnosticInfo GetExpectedTokenError(SyntaxKind expected, SyntaxKind actual)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 21211, 21523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 21336, 21354);

                int
                offset
                = default(int),
                width
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 21368, 21429);

                f_10006_21368_21428(this, out offset, out width);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 21445, 21512);

                return f_10006_21452_21511(this, expected, actual, offset, width);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 21211, 21523);

                int
                f_10006_21368_21428(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, out int
                offset, out int
                width)
                {
                    this_param.GetDiagnosticSpanForMissingToken(out offset, out width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 21368, 21428);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10006_21452_21511(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                expected, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                actual, int
                offset, int
                width)
                {
                    var return_v = this_param.GetExpectedTokenError(expected, actual, offset, width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 21452, 21511);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 21211, 21523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 21211, 21523);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ErrorCode GetExpectedTokenErrorCode(SyntaxKind expected, SyntaxKind actual)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10006, 21535, 22922);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 21650, 22911);

                switch (expected)
                {

                    case SyntaxKind.IdentifierToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 21650, 22911);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 21754, 22087) || true) && (f_10006_21758_21795(actual))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 21754, 22087);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 21845, 21887);

                            return ErrorCode.ERR_IdentifierExpectedKW;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 21754, 22087);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 21754, 22087);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 22024, 22064);

                            return ErrorCode.ERR_IdentifierExpected;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 21754, 22087);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 21650, 22911);

                    case SyntaxKind.SemicolonToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 21650, 22911);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 22160, 22199);

                        return ErrorCode.ERR_SemicolonExpected;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 21650, 22911);

                    case SyntaxKind.CloseParenToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 21650, 22911);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 22463, 22503);

                        return ErrorCode.ERR_CloseParenExpected;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 21650, 22911);

                    case SyntaxKind.OpenBraceToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 21650, 22911);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 22574, 22610);

                        return ErrorCode.ERR_LbraceExpected;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 21650, 22911);

                    case SyntaxKind.CloseBraceToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 21650, 22911);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 22682, 22718);

                        return ErrorCode.ERR_RbraceExpected;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 21650, 22911);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 21650, 22911);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 22863, 22896);

                        return ErrorCode.ERR_SyntaxError;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 21650, 22911);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10006, 21535, 22922);

                bool
                f_10006_21758_21795(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsReservedKeyword(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 21758, 21795);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 21535, 22922);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 21535, 22922);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void GetDiagnosticSpanForMissingToken(out int offset, out int width)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 22934, 24057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 23413, 23451);

                var
                trivia = _prevTokenTrailingTrivia
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 23465, 23914) || true) && (trivia != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 23465, 23914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 23517, 23600);

                    SyntaxList<CSharpSyntaxNode>
                    triviaList = f_10006_23559_23599(trivia)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 23618, 23701);

                    bool
                    prevTokenHasEndOfLineTrivia = triviaList.Any((int)SyntaxKind.EndOfLineTrivia)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 23719, 23899) || true) && (prevTokenHasEndOfLineTrivia)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 23719, 23899);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 23792, 23819);

                        offset = f_10006_23801_23818_M(-trivia.FullWidth);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 23841, 23851);

                        width = 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 23873, 23880);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 23719, 23899);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 23465, 23914);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 23930, 23965);

                SyntaxToken
                ct = f_10006_23947_23964(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 23979, 24015);

                offset = f_10006_23988_24014(ct);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 24029, 24046);

                width = f_10006_24037_24045(ct);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 22934, 24057);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                f_10006_23559_23599(Microsoft.CodeAnalysis.GreenNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 23559, 23599);
                    return return_v;
                }


                int
                f_10006_23801_23818_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 23801, 23818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_23947_23964(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    var return_v = this_param.CurrentToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 23947, 23964);
                    return return_v;
                }


                int
                f_10006_23988_24014(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetLeadingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 23988, 24014);
                    return return_v;
                }


                int
                f_10006_24037_24045(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 24037, 24045);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 22934, 24057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 22934, 24057);
            }
        }

        protected virtual TNode WithAdditionalDiagnostics<TNode>(TNode node, params DiagnosticInfo[] diagnostics) where TNode : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 24069, 24801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 24223, 24278);

                DiagnosticInfo[]
                existingDiags = f_10006_24256_24277<TNode>(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 24292, 24334);

                int
                existingLength = f_10006_24313_24333<TNode>(existingDiags)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 24348, 24790) || true) && (existingLength == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 24348, 24790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 24405, 24451);

                    return f_10006_24412_24450<TNode>(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 24348, 24790);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 24348, 24790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 24517, 24605);

                    DiagnosticInfo[]
                    result = new DiagnosticInfo[f_10006_24562_24582<TNode>(existingDiags) + f_10006_24585_24603<TNode>(diagnostics)]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 24623, 24655);

                    f_10006_24623_24654<TNode>(existingDiags, result, 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 24673, 24716);

                    f_10006_24673_24715<TNode>(diagnostics, result, existingLength);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 24734, 24775);

                    return f_10006_24741_24774<TNode>(node, result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 24348, 24790);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 24069, 24801);

                Microsoft.CodeAnalysis.DiagnosticInfo[]
                f_10006_24256_24277<TNode>(TNode
                this_param) where TNode : GreenNode

                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 24256, 24277);
                    return return_v;
                }


                int
                f_10006_24313_24333<TNode>(Microsoft.CodeAnalysis.DiagnosticInfo[]
                this_param) where TNode : GreenNode

                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 24313, 24333);
                    return return_v;
                }


                TNode
                f_10006_24412_24450<TNode>(TNode
                node, Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics) where TNode : GreenNode

                {
                    var return_v = node.WithDiagnosticsGreen<TNode>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 24412, 24450);
                    return return_v;
                }


                int
                f_10006_24562_24582<TNode>(Microsoft.CodeAnalysis.DiagnosticInfo[]
                this_param) where TNode : GreenNode

                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 24562, 24582);
                    return return_v;
                }


                int
                f_10006_24585_24603<TNode>(Microsoft.CodeAnalysis.DiagnosticInfo[]
                this_param) where TNode : GreenNode

                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 24585, 24603);
                    return return_v;
                }


                int
                f_10006_24623_24654<TNode>(Microsoft.CodeAnalysis.DiagnosticInfo[]
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo[]
                array, int
                index) where TNode : GreenNode

                {
                    this_param.CopyTo((System.Array)array, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 24623, 24654);
                    return 0;
                }


                int
                f_10006_24673_24715<TNode>(Microsoft.CodeAnalysis.DiagnosticInfo[]
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo[]
                array, int
                index) where TNode : GreenNode

                {
                    this_param.CopyTo((System.Array)array, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 24673, 24715);
                    return 0;
                }


                TNode
                f_10006_24741_24774<TNode>(TNode
                node, Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics) where TNode : GreenNode

                {
                    var return_v = node.WithDiagnosticsGreen<TNode>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 24741, 24774);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 24069, 24801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 24069, 24801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected TNode AddError<TNode>(TNode node, ErrorCode code) where TNode : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 24813, 24983);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 24921, 24972);

                return f_10006_24928_24971<TNode>(this, node, code, f_10006_24949_24970<TNode>());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 24813, 24983);

                object[]
                f_10006_24949_24970<TNode>() where TNode : GreenNode

                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 24949, 24970);
                    return return_v;
                }


                TNode
                f_10006_24928_24971<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, TNode
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args) where TNode : GreenNode

                {
                    var return_v = this_param.AddError<TNode>(node, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 24928, 24971);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 24813, 24983);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 24813, 24983);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected TNode AddError<TNode>(TNode node, ErrorCode code, params object[] args) where TNode : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 24995, 27213);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 25125, 25261) || true) && (f_10006_25129_25144_M(!node.IsMissing))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 25125, 25261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 25178, 25246);

                    return f_10006_25185_25245<TNode>(this, node, f_10006_25217_25244<TNode>(node, code, args));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 25125, 25261);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 25277, 25295);

                int
                offset
                = default(int),
                width
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 25311, 25351);

                SyntaxToken
                token = node as SyntaxToken
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 25365, 27109) || true) && (token != null && (DynAbs.Tracing.TraceSender.Expression_True(10006, 25369, 25411) && f_10006_25386_25411<TNode>(token)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 25365, 27109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 26091, 26130);

                    offset = f_10006_26100_26129<TNode>(token);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 26228, 26341);

                    f_10006_26228_26340<TNode>(offset == 0, "Why are we producing a missing token that has both skipped text and leading trivia?");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 26361, 26371);

                    width = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 26389, 26414);

                    bool
                    seenSkipped = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 26432, 26967);
                        foreach (var trivia in f_10006_26455_26475_I(f_10006_26455_26475<TNode>(token)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 26432, 26967);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 26517, 26948) || true) && (f_10006_26521_26532<TNode>(trivia) == SyntaxKind.SkippedTokensTrivia)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 26517, 26948);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 26616, 26635);

                                seenSkipped = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 26661, 26683);

                                width += f_10006_26670_26682<TNode>(trivia);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 26517, 26948);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 26517, 26948);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 26733, 26948) || true) && (seenSkipped)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 26733, 26948);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10006, 26798, 26804);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 26733, 26948);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 26733, 26948);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 26902, 26925);

                                    offset += f_10006_26912_26924<TNode>(trivia);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 26733, 26948);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 26517, 26948);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 26432, 26967);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10006, 1, 536);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10006, 1, 536);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 25365, 27109);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 25365, 27109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 27033, 27094);

                    f_10006_27033_27093<TNode>(this, out offset, out width);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 25365, 27109);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 27125, 27202);

                return f_10006_27132_27201<TNode>(this, node, f_10006_27164_27200<TNode>(offset, width, code, args));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 24995, 27213);

                bool
                f_10006_25129_25144_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 25129, 25144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10006_25217_25244<TNode>(TNode
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args) where TNode : GreenNode

                {
                    var return_v = MakeError((Microsoft.CodeAnalysis.GreenNode)node, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 25217, 25244);
                    return return_v;
                }


                TNode
                f_10006_25185_25245<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, TNode
                node, params Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics) where TNode : GreenNode

                {
                    var return_v = this_param.WithAdditionalDiagnostics<TNode>(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 25185, 25245);
                    return return_v;
                }


                bool
                f_10006_25386_25411<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param) where TNode : GreenNode

                {
                    var return_v = this_param.ContainsSkippedText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 25386, 25411);
                    return return_v;
                }


                int
                f_10006_26100_26129<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param) where TNode : GreenNode

                {
                    var return_v = this_param.GetLeadingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 26100, 26129);
                    return return_v;
                }


                int
                f_10006_26228_26340<TNode>(bool
                condition, string
                message) where TNode : GreenNode

                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 26228, 26340);
                    return 0;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                f_10006_26455_26475<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param) where TNode : GreenNode

                {
                    var return_v = this_param.TrailingTrivia;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 26455, 26475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10006_26521_26532<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param) where TNode : GreenNode

                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 26521, 26532);
                    return return_v;
                }


                int
                f_10006_26670_26682<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param) where TNode : GreenNode

                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 26670, 26682);
                    return return_v;
                }


                int
                f_10006_26912_26924<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param) where TNode : GreenNode

                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 26912, 26924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                f_10006_26455_26475_I(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 26455, 26475);
                    return return_v;
                }


                int
                f_10006_27033_27093<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, out int
                offset, out int
                width) where TNode : GreenNode

                {
                    this_param.GetDiagnosticSpanForMissingToken(out offset, out width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 27033, 27093);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10006_27164_27200<TNode>(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args) where TNode : GreenNode

                {
                    var return_v = MakeError(offset, width, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 27164, 27200);
                    return return_v;
                }


                TNode
                f_10006_27132_27201<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, TNode
                node, params Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics) where TNode : GreenNode

                {
                    var return_v = this_param.WithAdditionalDiagnostics<TNode>(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 27132, 27201);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 24995, 27213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 24995, 27213);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected TNode AddError<TNode>(TNode node, int offset, int length, ErrorCode code, params object[] args) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 27225, 27475);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 27386, 27464);

                return f_10006_27393_27463<TNode>(this, node, f_10006_27425_27462<TNode>(offset, length, code, args));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 27225, 27475);

                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10006_27425_27462<TNode>(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args) where TNode : CSharpSyntaxNode

                {
                    var return_v = MakeError(offset, width, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 27425, 27462);
                    return return_v;
                }


                TNode
                f_10006_27393_27463<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, TNode
                node, params Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.WithAdditionalDiagnostics<TNode>(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 27393, 27463);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 27225, 27475);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 27225, 27475);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected TNode AddError<TNode>(TNode node, CSharpSyntaxNode location, ErrorCode code, params object[] args) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 27487, 27901);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 27726, 27737);

                int
                offset
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 27751, 27790);

                f_10006_27751_27789<TNode>(this, node, location, out offset);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 27804, 27890);

                return f_10006_27811_27889<TNode>(this, node, f_10006_27843_27888<TNode>(offset, f_10006_27861_27875<TNode>(location), code, args));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 27487, 27901);

                bool
                f_10006_27751_27789<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, TNode
                root, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                location, out int
                offset) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.FindOffset((Microsoft.CodeAnalysis.GreenNode)root, location, out offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 27751, 27789);
                    return return_v;
                }


                int
                f_10006_27861_27875<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 27861, 27875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10006_27843_27888<TNode>(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args) where TNode : CSharpSyntaxNode

                {
                    var return_v = MakeError(offset, width, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 27843, 27888);
                    return return_v;
                }


                TNode
                f_10006_27811_27889<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, TNode
                node, params Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.WithAdditionalDiagnostics<TNode>(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 27811, 27889);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 27487, 27901);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 27487, 27901);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected TNode AddErrorToFirstToken<TNode>(TNode node, ErrorCode code) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 27913, 28213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 28040, 28078);

                var
                firstToken = f_10006_28057_28077<TNode>(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 28092, 28202);

                return f_10006_28099_28201<TNode>(this, node, f_10006_28131_28200<TNode>(f_10006_28141_28175<TNode>(firstToken), f_10006_28177_28193<TNode>(firstToken), code));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 27913, 28213);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_28057_28077<TNode>(TNode
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.GetFirstToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 28057, 28077);
                    return return_v;
                }


                int
                f_10006_28141_28175<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.GetLeadingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 28141, 28175);
                    return return_v;
                }


                int
                f_10006_28177_28193<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 28177, 28193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10006_28131_28200<TNode>(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code) where TNode : CSharpSyntaxNode

                {
                    var return_v = MakeError(offset, width, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 28131, 28200);
                    return return_v;
                }


                TNode
                f_10006_28099_28201<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, TNode
                node, params Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.WithAdditionalDiagnostics<TNode>(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 28099, 28201);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 27913, 28213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 27913, 28213);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected TNode AddErrorToFirstToken<TNode>(TNode node, ErrorCode code, params object[] args) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 28225, 28553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 28374, 28412);

                var
                firstToken = f_10006_28391_28411<TNode>(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 28426, 28542);

                return f_10006_28433_28541<TNode>(this, node, f_10006_28465_28540<TNode>(f_10006_28475_28509<TNode>(firstToken), f_10006_28511_28527<TNode>(firstToken), code, args));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 28225, 28553);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_28391_28411<TNode>(TNode
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.GetFirstToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 28391, 28411);
                    return return_v;
                }


                int
                f_10006_28475_28509<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.GetLeadingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 28475, 28509);
                    return return_v;
                }


                int
                f_10006_28511_28527<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 28511, 28527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10006_28465_28540<TNode>(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args) where TNode : CSharpSyntaxNode

                {
                    var return_v = MakeError(offset, width, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 28465, 28540);
                    return return_v;
                }


                TNode
                f_10006_28433_28541<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, TNode
                node, params Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.WithAdditionalDiagnostics<TNode>(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 28433, 28541);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 28225, 28553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 28225, 28553);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected TNode AddErrorToLastToken<TNode>(TNode node, ErrorCode code) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 28565, 28895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 28691, 28702);

                int
                offset
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 28716, 28726);

                int
                width
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 28740, 28799);

                f_10006_28740_28798<TNode>(node, out offset, out width);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 28813, 28884);

                return f_10006_28820_28883<TNode>(this, node, f_10006_28852_28882<TNode>(offset, width, code));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 28565, 28895);

                int
                f_10006_28740_28798<TNode>(TNode
                node, out int
                offset, out int
                width) where TNode : CSharpSyntaxNode

                {
                    GetOffsetAndWidthForLastToken(node, out offset, out width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 28740, 28798);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10006_28852_28882<TNode>(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code) where TNode : CSharpSyntaxNode

                {
                    var return_v = MakeError(offset, width, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 28852, 28882);
                    return return_v;
                }


                TNode
                f_10006_28820_28883<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, TNode
                node, params Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.WithAdditionalDiagnostics<TNode>(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 28820, 28883);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 28565, 28895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 28565, 28895);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected TNode AddErrorToLastToken<TNode>(TNode node, ErrorCode code, params object[] args) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 28907, 29265);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 29055, 29066);

                int
                offset
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 29080, 29090);

                int
                width
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 29104, 29163);

                f_10006_29104_29162<TNode>(node, out offset, out width);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 29177, 29254);

                return f_10006_29184_29253<TNode>(this, node, f_10006_29216_29252<TNode>(offset, width, code, args));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 28907, 29265);

                int
                f_10006_29104_29162<TNode>(TNode
                node, out int
                offset, out int
                width) where TNode : CSharpSyntaxNode

                {
                    GetOffsetAndWidthForLastToken(node, out offset, out width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 29104, 29162);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10006_29216_29252<TNode>(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args) where TNode : CSharpSyntaxNode

                {
                    var return_v = MakeError(offset, width, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 29216, 29252);
                    return return_v;
                }


                TNode
                f_10006_29184_29253<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, TNode
                node, params Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.WithAdditionalDiagnostics<TNode>(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 29184, 29253);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 28907, 29265);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 28907, 29265);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void GetOffsetAndWidthForLastToken<TNode>(TNode node, out int offset, out int width) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10006, 29277, 29938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 29432, 29478);

                var
                lastToken = f_10006_29448_29477<TNode>(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 29492, 29516);

                offset = f_10006_29501_29515<TNode>(node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 29562, 29572);

                width = 0;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 29586, 29927) || true) && (lastToken != null)
                ) //will be null if all tokens are missing

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 29586, 29927);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 29682, 29712);

                    offset -= f_10006_29692_29711<TNode>(lastToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 29755, 29799);

                    offset += f_10006_29765_29798<TNode>(lastToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 29887, 29912);

                    width += f_10006_29896_29911<TNode>(lastToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 29586, 29927);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10006, 29277, 29938);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_29448_29477<TNode>(TNode
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.GetLastNonmissingToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 29448, 29477);
                    return return_v;
                }


                int
                f_10006_29501_29515<TNode>(TNode
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 29501, 29515);
                    return return_v;
                }


                int
                f_10006_29692_29711<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 29692, 29711);
                    return return_v;
                }


                int
                f_10006_29765_29798<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.GetLeadingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 29765, 29798);
                    return return_v;
                }


                int
                f_10006_29896_29911<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 29896, 29911);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 29277, 29938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 29277, 29938);
            }
        }

        protected static SyntaxDiagnosticInfo MakeError(int offset, int width, ErrorCode code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10006, 29950, 30125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 30061, 30114);

                return f_10006_30068_30113(offset, width, code);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10006, 29950, 30125);

                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10006_30068_30113(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo(offset, width, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 30068, 30113);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 29950, 30125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 29950, 30125);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static SyntaxDiagnosticInfo MakeError(int offset, int width, ErrorCode code, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10006, 30137, 30340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 30270, 30329);

                return f_10006_30277_30328(offset, width, code, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10006, 30137, 30340);

                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10006_30277_30328(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo(offset, width, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 30277, 30328);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 30137, 30340);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 30137, 30340);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static SyntaxDiagnosticInfo MakeError(GreenNode node, ErrorCode code, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10006, 30352, 30575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 30478, 30564);

                return f_10006_30485_30563(f_10006_30510_30538(node), f_10006_30540_30550(node), code, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10006, 30352, 30575);

                int
                f_10006_30510_30538(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetLeadingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 30510, 30538);
                    return return_v;
                }


                int
                f_10006_30540_30550(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 30540, 30550);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10006_30485_30563(int
                offset, int
                width, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo(offset, width, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 30485, 30563);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 30352, 30575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 30352, 30575);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static SyntaxDiagnosticInfo MakeError(ErrorCode code, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10006, 30587, 30752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 30697, 30741);

                return f_10006_30704_30740(code, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10006, 30587, 30752);

                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10006_30704_30740(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 30704, 30740);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 30587, 30752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 30587, 30752);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected TNode AddLeadingSkippedSyntax<TNode>(TNode node, GreenNode skippedSyntax) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 30764, 31166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 30903, 30962);

                var
                oldToken = node as SyntaxToken ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken?>(10006, 30918, 30961) ?? f_10006_30941_30961<TNode>(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 30976, 31050);

                var
                newToken = f_10006_30991_31049<TNode>(this, oldToken, skippedSyntax, trailing: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 31064, 31155);

                return f_10006_31071_31154<TNode>(node, oldToken, newToken, f_10006_31130_31153<TNode>(skippedSyntax));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 30764, 31166);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_30941_30961<TNode>(TNode
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.GetFirstToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 30941, 30961);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_30991_31049<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                target, Microsoft.CodeAnalysis.GreenNode
                skippedSyntax, bool
                trailing) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.AddSkippedSyntax(target, skippedSyntax, trailing: trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 30991, 31049);
                    return return_v;
                }


                int
                f_10006_31130_31153<TNode>(Microsoft.CodeAnalysis.GreenNode
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 31130, 31153);
                    return return_v;
                }


                TNode
                f_10006_31071_31154<TNode>(TNode
                root, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                oldToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                newToken, int
                diagnosticOffsetDelta) where TNode : CSharpSyntaxNode

                {
                    var return_v = SyntaxFirstTokenReplacer.Replace(root, oldToken, newToken, diagnosticOffsetDelta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 31071, 31154);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 30764, 31166);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 30764, 31166);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void AddTrailingSkippedSyntax(SyntaxListBuilder list, GreenNode skippedSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 31178, 31405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 31291, 31394);

                list[f_10006_31296_31306(list) - 1] = f_10006_31314_31393(this, f_10006_31357_31377(list, f_10006_31362_31372(list) - 1), skippedSyntax);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 31178, 31405);

                int
                f_10006_31296_31306(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 31296, 31306);
                    return return_v;
                }


                int
                f_10006_31362_31372(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 31362, 31372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_10006_31357_31377(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 31357, 31377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode?
                f_10006_31314_31393(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.GreenNode?
                node, Microsoft.CodeAnalysis.GreenNode
                skippedSyntax)
                {
                    var return_v = this_param.AddTrailingSkippedSyntax<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode?>((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode?)node, skippedSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 31314, 31393);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 31178, 31405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 31178, 31405);
            }
        }

        protected void AddTrailingSkippedSyntax<TNode>(SyntaxListBuilder<TNode> list, GreenNode skippedSyntax) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 31417, 31671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 31575, 31660);

                list[list.Count - 1] = f_10006_31598_31659<TNode>(this, list[list.Count - 1], skippedSyntax);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 31417, 31671);

                TNode?
                f_10006_31598_31659<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, TNode?
                node, Microsoft.CodeAnalysis.GreenNode
                skippedSyntax) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.AddTrailingSkippedSyntax<TNode?>(node, skippedSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 31598, 31659);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 31417, 31671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 31417, 31671);
            }
        }

        protected TNode AddTrailingSkippedSyntax<TNode>(TNode node, GreenNode skippedSyntax) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 31683, 32290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 31823, 31855);

                var
                token = node as SyntaxToken
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 31869, 32279) || true) && (token != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 31869, 32279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 31920, 31997);

                    return (TNode)(object)f_10006_31942_31996<TNode>(this, token, skippedSyntax, trailing: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 31869, 32279);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 31869, 32279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 32063, 32099);

                    var
                    lastToken = f_10006_32079_32098<TNode>(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 32117, 32191);

                    var
                    newToken = f_10006_32132_32190<TNode>(this, lastToken, skippedSyntax, trailing: true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 32209, 32264);

                    return f_10006_32216_32263<TNode>(node, newToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 31869, 32279);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 31683, 32290);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_31942_31996<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                target, Microsoft.CodeAnalysis.GreenNode
                skippedSyntax, bool
                trailing) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.AddSkippedSyntax(target, skippedSyntax, trailing: trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 31942, 31996);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_32079_32098<TNode>(TNode
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.GetLastToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 32079, 32098);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_32132_32190<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                target, Microsoft.CodeAnalysis.GreenNode
                skippedSyntax, bool
                trailing) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.AddSkippedSyntax(target, skippedSyntax, trailing: trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 32132, 32190);
                    return return_v;
                }


                TNode
                f_10006_32216_32263<TNode>(TNode
                root, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                newToken) where TNode : CSharpSyntaxNode

                {
                    var return_v = SyntaxLastTokenReplacer.Replace(root, newToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 32216, 32263);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 31683, 32290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 31683, 32290);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxToken AddSkippedSyntax(SyntaxToken target, GreenNode skippedSyntax, bool trailing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 32567, 37284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 32689, 32728);

                var
                builder = f_10006_32703_32727(4)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 32798, 32837);

                SyntaxDiagnosticInfo
                diagnostic = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 32935, 32960);

                int
                diagnosticOffset = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 32976, 32998);

                int
                currentOffset = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 33012, 35435);
                    foreach (var node in f_10006_33033_33063_I(f_10006_33033_33063(skippedSyntax)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 33012, 35435);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 33097, 33137);

                        SyntaxToken
                        token = node as SyntaxToken
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 33155, 35420) || true) && (token != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 33155, 35420);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 33214, 33252);

                            f_10006_33214_33251(builder, f_10006_33226_33250(token));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 33276, 34805) || true) && (f_10006_33280_33291(token) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 33276, 34805);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 33405, 33487);

                                SyntaxToken
                                tk = f_10006_33422_33486(f_10006_33422_33456(token, null), null)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 33605, 33654);

                                int
                                leadingWidth = f_10006_33624_33653(token)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 33680, 34200) || true) && (leadingWidth > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 33680, 34200);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 33758, 33801);

                                    var
                                    tokenDiagnostics = f_10006_33781_33800(tk)
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 33840, 33845);
                                        for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 33831, 34173) || true) && (i < f_10006_33851_33874(tokenDiagnostics))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 33876, 33879)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 33831, 34173))

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 33831, 34173);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 33945, 33995);

                                            var
                                            d = (SyntaxDiagnosticInfo)tokenDiagnostics[i]
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 34029, 34142);

                                            tokenDiagnostics[i] = f_10006_34051_34141(d.Offset - leadingWidth, d.Width, f_10006_34121_34127(d), f_10006_34129_34140(d));
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10006, 1, 343);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10006, 1, 343);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 33680, 34200);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 34228, 34279);

                                f_10006_34228_34278(
                                                        builder, f_10006_34240_34277(tk));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 33276, 34805);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 33276, 34805);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 34489, 34566);

                                var
                                existing = (SyntaxDiagnosticInfo)f_10006_34526_34565(f_10006_34526_34548(token))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 34592, 34782) || true) && (existing != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 34592, 34782);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 34670, 34692);

                                    diagnostic = existing;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 34722, 34755);

                                    diagnosticOffset = currentOffset;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 34592, 34782);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 33276, 34805);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 34827, 34866);

                            f_10006_34827_34865(builder, f_10006_34839_34864(token));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 34890, 34923);

                            currentOffset += f_10006_34907_34922(token);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 33155, 35420);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 33155, 35420);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 34965, 35420) || true) && (f_10006_34969_34993(node) && (DynAbs.Tracing.TraceSender.Expression_True(10006, 34969, 35015) && diagnostic == null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 34965, 35420);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 35129, 35205);

                                var
                                existing = (SyntaxDiagnosticInfo)f_10006_35166_35204(f_10006_35166_35187(node))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 35227, 35401) || true) && (existing != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 35227, 35401);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 35297, 35319);

                                    diagnostic = existing;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 35345, 35378);

                                    diagnosticOffset = currentOffset;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 35227, 35401);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 34965, 35420);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 33155, 35420);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 33012, 35435);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10006, 1, 2424);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10006, 1, 2424);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 35451, 35483);

                int
                triviaWidth = currentOffset
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 35497, 35531);

                var
                trivia = f_10006_35510_35530(builder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 35616, 35633);

                int
                triviaOffset
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 35647, 36881) || true) && (trailing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 35647, 36881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 35693, 35741);

                    var
                    trailingTrivia = f_10006_35714_35740(target)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 35759, 35791);

                    triviaOffset = f_10006_35774_35790(target);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 35856, 35939);

                    target = f_10006_35865_35938(target, f_10006_35896_35937(trailingTrivia, trivia));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 35647, 36881);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 35647, 36881);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 36161, 36623) || true) && (triviaWidth > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 36161, 36623);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 36222, 36270);

                        var
                        targetDiagnostics = f_10006_36246_36269(target)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 36301, 36306);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 36292, 36604) || true) && (i < f_10006_36312_36336(targetDiagnostics))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 36338, 36341)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 36292, 36604))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 36292, 36604);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 36391, 36442);

                                var
                                d = (SyntaxDiagnosticInfo)targetDiagnostics[i]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 36468, 36581);

                                targetDiagnostics[i] = f_10006_36491_36580(d.Offset + triviaWidth, d.Width, f_10006_36560_36566(d), f_10006_36568_36579(d));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10006, 1, 313);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10006, 1, 313);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 36161, 36623);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 36643, 36689);

                    var
                    leadingTrivia = f_10006_36663_36688(target)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 36707, 36788);

                    target = f_10006_36716_36787(target, f_10006_36746_36786(trivia, leadingTrivia));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 36806, 36823);

                    triviaOffset = 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 35647, 36881);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 36897, 37243) || true) && (diagnostic != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 36897, 37243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 36953, 37021);

                    int
                    newOffset = triviaOffset + diagnosticOffset + diagnostic.Offset
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 37041, 37228);

                    target = f_10006_37050_37227(this, target, f_10006_37105_37208(newOffset, diagnostic.Width, f_10006_37170_37185(diagnostic), f_10006_37187_37207(diagnostic)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 36897, 37243);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 37259, 37273);

                return target;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 32567, 37284);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                f_10006_32703_32727(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 32703, 32727);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.GreenNode>
                f_10006_33033_33063(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.EnumerateNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 33033, 33063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10006_33226_33250(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetLeadingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 33226, 33250);
                    return return_v;
                }


                int
                f_10006_33214_33251(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.GreenNode
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 33214, 33251);
                    return 0;
                }


                int
                f_10006_33280_33291(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 33280, 33291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_33422_33456(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param, Microsoft.CodeAnalysis.GreenNode
                trivia)
                {
                    var return_v = this_param.TokenWithLeadingTrivia(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 33422, 33456);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_33422_33486(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param, Microsoft.CodeAnalysis.GreenNode
                trivia)
                {
                    var return_v = this_param.TokenWithTrailingTrivia(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 33422, 33486);
                    return return_v;
                }


                int
                f_10006_33624_33653(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetLeadingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 33624, 33653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo[]
                f_10006_33781_33800(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 33781, 33800);
                    return return_v;
                }


                int
                f_10006_33851_33874(Microsoft.CodeAnalysis.DiagnosticInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 33851, 33874);
                    return return_v;
                }


                int
                f_10006_34121_34127(Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 34121, 34127);
                    return return_v;
                }


                object[]
                f_10006_34129_34140(Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 34129, 34140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10006_34051_34141(int
                offset, int
                width, int
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo(offset, width, (Microsoft.CodeAnalysis.CSharp.ErrorCode)code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 34051, 34141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SkippedTokensTriviaSyntax
                f_10006_34240_34277(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                tokens)
                {
                    var return_v = SyntaxFactory.SkippedTokensTrivia((Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>)tokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 34240, 34277);
                    return return_v;
                }


                int
                f_10006_34228_34278(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SkippedTokensTriviaSyntax
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.GreenNode)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 34228, 34278);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo[]
                f_10006_34526_34548(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 34526, 34548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10006_34526_34565(Microsoft.CodeAnalysis.DiagnosticInfo[]
                source)
                {
                    var return_v = source.FirstOrDefault<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 34526, 34565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10006_34839_34864(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetTrailingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 34839, 34864);
                    return return_v;
                }


                int
                f_10006_34827_34865(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.GreenNode
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 34827, 34865);
                    return 0;
                }


                int
                f_10006_34907_34922(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 34907, 34922);
                    return return_v;
                }


                bool
                f_10006_34969_34993(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ContainsDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 34969, 34993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo[]
                f_10006_35166_35187(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 35166, 35187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10006_35166_35204(Microsoft.CodeAnalysis.DiagnosticInfo[]
                source)
                {
                    var return_v = source.FirstOrDefault<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 35166, 35204);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.GreenNode>
                f_10006_33033_33063_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.GreenNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 33033, 33063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_10006_35510_35530(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.ToListNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 35510, 35530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10006_35714_35740(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetTrailingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 35714, 35740);
                    return return_v;
                }


                int
                f_10006_35774_35790(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 35774, 35790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_10006_35896_35937(Microsoft.CodeAnalysis.GreenNode
                left, Microsoft.CodeAnalysis.GreenNode?
                right)
                {
                    var return_v = SyntaxList.Concat(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 35896, 35937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_35865_35938(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param, Microsoft.CodeAnalysis.GreenNode?
                trivia)
                {
                    var return_v = this_param.TokenWithTrailingTrivia(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 35865, 35938);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo[]
                f_10006_36246_36269(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 36246, 36269);
                    return return_v;
                }


                int
                f_10006_36312_36336(Microsoft.CodeAnalysis.DiagnosticInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 36312, 36336);
                    return return_v;
                }


                int
                f_10006_36560_36566(Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 36560, 36566);
                    return return_v;
                }


                object[]
                f_10006_36568_36579(Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 36568, 36579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10006_36491_36580(int
                offset, int
                width, int
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo(offset, width, (Microsoft.CodeAnalysis.CSharp.ErrorCode)code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 36491, 36580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10006_36663_36688(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetLeadingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 36663, 36688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_10006_36746_36786(Microsoft.CodeAnalysis.GreenNode?
                left, Microsoft.CodeAnalysis.GreenNode
                right)
                {
                    var return_v = SyntaxList.Concat(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 36746, 36786);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_36716_36787(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param, Microsoft.CodeAnalysis.GreenNode?
                trivia)
                {
                    var return_v = this_param.TokenWithLeadingTrivia(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 36716, 36787);
                    return return_v;
                }


                int
                f_10006_37170_37185(Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 37170, 37185);
                    return return_v;
                }


                object[]
                f_10006_37187_37207(Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 37187, 37207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10006_37105_37208(int
                offset, int
                width, int
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo(offset, width, (Microsoft.CodeAnalysis.CSharp.ErrorCode)code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 37105, 37208);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_37050_37227(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, params Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics)
                {
                    var return_v = this_param.WithAdditionalDiagnostics<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 37050, 37227);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 32567, 37284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 32567, 37284);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool FindOffset(GreenNode root, CSharpSyntaxNode location, out int offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 37892, 39858);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 37999, 38021);

                int
                currentOffset = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 38035, 38046);

                offset = 0;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 38060, 39730) || true) && (root != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 38060, 39730);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 38119, 38124);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 38126, 38144);
                        for (int
        i = 0
        ,
        n = f_10006_38130_38144(root)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 38110, 39715) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 38153, 38156)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 38110, 39715))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 38110, 39715);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 38198, 38226);

                            var
                            child = f_10006_38210_38225(root, i)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 38248, 38393) || true) && (child == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 38248, 38393);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 38361, 38370);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 38248, 38393);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 38486, 38955) || true) && (child == location)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 38486, 38955);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 38871, 38894);

                                offset = currentOffset;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 38920, 38932);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 38486, 38955);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 39068, 39501) || true) && (f_10006_39072_39116(this, child, location, out offset))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 39068, 39501);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 39384, 39440);

                                offset += f_10006_39394_39423(child) + currentOffset;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 39466, 39478);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 39068, 39501);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 39663, 39696);

                            currentOffset += f_10006_39680_39695(child);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10006, 1, 1606);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10006, 1, 1606);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 38060, 39730);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 39834, 39847);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 37892, 39858);

                int
                f_10006_38130_38144(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 38130, 38144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_10006_38210_38225(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 38210, 38225);
                    return return_v;
                }


                bool
                f_10006_39072_39116(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, Microsoft.CodeAnalysis.GreenNode
                root, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                location, out int
                offset)
                {
                    var return_v = this_param.FindOffset(root, location, out offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 39072, 39116);
                    return return_v;
                }


                int
                f_10006_39394_39423(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetLeadingTriviaWidth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 39394, 39423);
                    return return_v;
                }


                int
                f_10006_39680_39695(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 39680, 39695);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 37892, 39858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 37892, 39858);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static SyntaxToken ConvertToKeyword(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10006, 39870, 40581);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 39959, 40541) || true) && (f_10006_39963_39973(token) != f_10006_39977_39997(token))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 39959, 40541);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 40031, 40307);

                    var
                    kw = (DynAbs.Tracing.TraceSender.Conditional_F1(10006, 40040, 40055) || ((f_10006_40040_40055(token) && DynAbs.Tracing.TraceSender.Conditional_F2(10006, 40083, 40184)) || DynAbs.Tracing.TraceSender.Conditional_F3(10006, 40212, 40306))) ? f_10006_40083_40184(token.LeadingTrivia.Node, f_10006_40136_40156(token), token.TrailingTrivia.Node) : f_10006_40212_40306(token.LeadingTrivia.Node, f_10006_40258_40278(token), token.TrailingTrivia.Node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 40325, 40356);

                    var
                    d = f_10006_40333_40355(token)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 40374, 40496) || true) && (d != null && (DynAbs.Tracing.TraceSender.Expression_True(10006, 40378, 40403) && f_10006_40391_40399(d) > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 40374, 40496);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 40445, 40477);

                        kw = f_10006_40450_40476(kw, d);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 40374, 40496);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 40516, 40526);

                    return kw;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 39959, 40541);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 40557, 40570);

                return token;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10006, 39870, 40581);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10006_39963_39973(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 39963, 39973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10006_39977_39997(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ContextualKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 39977, 39997);
                    return return_v;
                }


                bool
                f_10006_40040_40055(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.IsMissing
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 40040, 40055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10006_40136_40156(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ContextualKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 40136, 40156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_40083_40184(Microsoft.CodeAnalysis.GreenNode?
                leading, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = SyntaxFactory.MissingToken(leading, kind, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 40083, 40184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10006_40258_40278(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ContextualKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 40258, 40278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_40212_40306(Microsoft.CodeAnalysis.GreenNode?
                leading, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = SyntaxFactory.Token(leading, kind, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 40212, 40306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo[]
                f_10006_40333_40355(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 40333, 40355);
                    return return_v;
                }


                int
                f_10006_40391_40399(Microsoft.CodeAnalysis.DiagnosticInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 40391, 40399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_40450_40476(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                node, Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics)
                {
                    var return_v = node.WithDiagnosticsGreen<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 40450, 40476);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 39870, 40581);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 39870, 40581);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static SyntaxToken ConvertToIdentifier(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10006, 40593, 40865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 40685, 40716);

                f_10006_40685_40715(f_10006_40698_40714_M(!token.IsMissing));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 40730, 40854);

                return f_10006_40737_40853(f_10006_40760_40770(token), token.LeadingTrivia.Node, f_10006_40798_40808(token), f_10006_40810_40825(token), token.TrailingTrivia.Node);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10006, 40593, 40865);

                bool
                f_10006_40698_40714_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 40698, 40714);
                    return return_v;
                }


                int
                f_10006_40685_40715(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 40685, 40715);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10006_40760_40770(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 40760, 40770);
                    return return_v;
                }


                string
                f_10006_40798_40808(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 40798, 40808);
                    return return_v;
                }


                string
                f_10006_40810_40825(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                this_param)
                {
                    var return_v = this_param.ValueText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 40810, 40825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10006_40737_40853(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                contextualKind, Microsoft.CodeAnalysis.GreenNode?
                leading, string
                text, string
                valueText, Microsoft.CodeAnalysis.GreenNode?
                trailing)
                {
                    var return_v = SyntaxToken.Identifier(contextualKind, leading, text, valueText, trailing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 40737, 40853);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 40593, 40865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 40593, 40865);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal DirectiveStack Directives
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 40936, 40968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 40942, 40966);

                    return f_10006_40949_40965(lexer);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 40936, 40968);

                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                    f_10006_40949_40965(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
                    this_param)
                    {
                        var return_v = this_param.Directives;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 40949, 40965);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 40877, 40979);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 40877, 40979);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected TNode CheckFeatureAvailability<TNode>(TNode node, MessageID feature, bool forceWarning = false)
                    where TNode : GreenNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 41440, 42943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 41607, 41671);

                LanguageVersion
                availableVersion = f_10006_41642_41670<TNode>(f_10006_41642_41654<TNode>(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 41685, 41745);

                LanguageVersion
                requiredVersion = f_10006_41719_41744<TNode>(feature)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 41854, 42520);

                switch (feature)
                {

                    case MessageID.IDS_FeatureModuleAttrLoc:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 41854, 42520);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 41965, 42145);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10006, 41972, 42015) || ((availableVersion >= LanguageVersion.CSharp2
                        && DynAbs.Tracing.TraceSender.Conditional_F2(10006, 42043, 42047)) || DynAbs.Tracing.TraceSender.Conditional_F3(10006, 42075, 42144))) ? node
                        : f_10006_42075_42144<TNode>(this, node, ErrorCode.WRN_NonECMAFeature, f_10006_42125_42143<TNode>(feature));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 41854, 42520);

                    case MessageID.IDS_FeatureAltInterpolatedVerbatimStrings:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 41854, 42520);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 42244, 42505);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10006, 42251, 42286) || ((availableVersion >= requiredVersion
                        && DynAbs.Tracing.TraceSender.Conditional_F2(10006, 42314, 42318)) || DynAbs.Tracing.TraceSender.Conditional_F3(10006, 42346, 42504))) ? node
                        : f_10006_42346_42504<TNode>(this, node, ErrorCode.ERR_AltInterpolatedVerbatimStringsNotAvailable, f_10006_42453_42503<TNode>(requiredVersion));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 41854, 42520);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 42536, 42606);

                var
                info = f_10006_42547_42605<TNode>(feature, f_10006_42592_42604<TNode>(this))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 42620, 42904) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 42620, 42904);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 42670, 42820) || true) && (forceWarning)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 42670, 42820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 42728, 42801);

                        return f_10006_42735_42800<TNode>(this, node, ErrorCode.WRN_ErrorOverride, info, f_10006_42790_42799<TNode>(info));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 42670, 42820);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 42840, 42889);

                    return f_10006_42847_42888<TNode>(this, node, f_10006_42862_42871<TNode>(info), f_10006_42873_42887<TNode>(info));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 42620, 42904);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 42920, 42932);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 41440, 42943);

                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10006_41642_41654<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param) where TNode : GreenNode

                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 41642, 41654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10006_41642_41670<TNode>(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param) where TNode : GreenNode

                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 41642, 41670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10006_41719_41744<TNode>(Microsoft.CodeAnalysis.CSharp.MessageID
                feature) where TNode : GreenNode

                {
                    var return_v = feature.RequiredVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 41719, 41744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10006_42125_42143<TNode>(Microsoft.CodeAnalysis.CSharp.MessageID
                id) where TNode : GreenNode

                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 42125, 42143);
                    return return_v;
                }


                TNode
                f_10006_42075_42144<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, TNode
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args) where TNode : GreenNode

                {
                    var return_v = this_param.AddError<TNode>(node, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 42075, 42144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion
                f_10006_42453_42503<TNode>(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version) where TNode : GreenNode

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 42453, 42503);
                    return return_v;
                }


                TNode
                f_10006_42346_42504<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, TNode
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args) where TNode : GreenNode

                {
                    var return_v = this_param.AddError<TNode>(node, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 42346, 42504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10006_42592_42604<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param) where TNode : GreenNode

                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 42592, 42604);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo?
                f_10006_42547_42605<TNode>(Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options) where TNode : GreenNode

                {
                    var return_v = feature.GetFeatureAvailabilityDiagnosticInfo(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 42547, 42605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10006_42790_42799<TNode>(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                this_param) where TNode : GreenNode

                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 42790, 42799);
                    return return_v;
                }


                TNode
                f_10006_42735_42800<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, TNode
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args) where TNode : GreenNode

                {
                    var return_v = this_param.AddError<TNode>(node, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 42735, 42800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10006_42862_42871<TNode>(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                this_param) where TNode : GreenNode

                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 42862, 42871);
                    return return_v;
                }


                object[]
                f_10006_42873_42887<TNode>(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                this_param) where TNode : GreenNode

                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 42873, 42887);
                    return return_v;
                }


                TNode
                f_10006_42847_42888<TNode>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param, TNode
                node, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args) where TNode : GreenNode

                {
                    var return_v = this_param.AddError<TNode>(node, code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 42847, 42888);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 41440, 42943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 41440, 42943);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected bool IsFeatureEnabled(MessageID feature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 42974, 43106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 43049, 43095);

                return f_10006_43056_43094(f_10006_43056_43068(this), feature);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 42974, 43106);

                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10006_43056_43068(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 43056, 43068);
                    return return_v;
                }


                bool
                f_10006_43056_43094(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = this_param.IsFeatureEnabled(feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 43056, 43094);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 42974, 43106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 42974, 43106);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected bool IsMakingProgress(ref int lastTokenPosition, bool assertIfFalse = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 43569, 43937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 43679, 43710);

                var
                pos = f_10006_43689_43709()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 43724, 43854) || true) && (pos > lastTokenPosition)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10006, 43724, 43854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 43785, 43809);

                    lastTokenPosition = pos;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 43827, 43839);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10006, 43724, 43854);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 43870, 43899);

                f_10006_43870_43898(!assertIfFalse);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 43913, 43926);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 43569, 43937);

                int
                f_10006_43689_43709()
                {
                    var return_v = CurrentTokenPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 43689, 43709);
                    return return_v;
                }


                int
                f_10006_43870_43898(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 43870, 43898);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 43569, 43937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 43569, 43937);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int CurrentTokenPosition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10006, 43982, 44011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 43985, 44011);
                    return _firstToken + _tokenOffset; DynAbs.Tracing.TraceSender.TraceExitMethod(10006, 43982, 44011);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10006, 43982, 44011);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 43982, 44011);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SyntaxParser()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10006, 588, 44019);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10006, 1494, 1574);
            s_blendedNodesPool = f_10006_1515_1574(() => new BlendedNode[32], 2); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10006, 588, 44019);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10006, 588, 44019);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10006, 588, 44019);

        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode[]>
        f_10006_1515_1574(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode[]>.Factory
        factory, int
        size)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode[]>(factory, size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 1515, 1574);
            return return_v;
        }


        bool
        f_10006_2266_2284(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
        this_param)
        {
            var return_v = this_param.IsIncremental;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 2266, 2284);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender
        f_10006_2352_2388(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Lexer
        lexer, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
        oldTree, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextChangeRange>
        changes)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.Blender(lexer, oldTree, changes);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 2352, 2388);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode[]
        f_10006_2424_2453(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.BlendedNode[]>
        this_param)
        {
            var return_v = this_param.Allocate();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 2424, 2453);
            return return_v;
        }


        bool
        f_10006_2974_2993_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 2974, 2993);
            return return_v;
        }


        bool
        f_10006_2997_3029_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 2997, 3029);
            return return_v;
        }


        int
        f_10006_3063_3076(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
        this_param)
        {
            this_param.PreLex();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 3063, 3076);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
        f_10006_15331_15348(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
        this_param)
        {
            var return_v = this_param.CurrentToken;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 15331, 15348);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10006_15331_15353(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10006, 15331, 15353);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
        f_10006_15364_15379(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxParser
        this_param)
        {
            var return_v = this_param.EatToken();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10006, 15364, 15379);
            return return_v;
        }

    }
}
