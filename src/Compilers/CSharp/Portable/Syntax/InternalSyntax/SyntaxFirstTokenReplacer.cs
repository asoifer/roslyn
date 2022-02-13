// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    internal class SyntaxFirstTokenReplacer : CSharpSyntaxRewriter
    {
        private readonly SyntaxToken _oldToken;

        private readonly SyntaxToken _newToken;

        private readonly int _diagnosticOffsetDelta;

        private bool _foundOldToken;

        private SyntaxFirstTokenReplacer(SyntaxToken oldToken, SyntaxToken newToken, int diagnosticOffsetDelta)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10011, 726, 1019);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 563, 572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 612, 621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 653, 675);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 699, 713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 854, 875);

                _oldToken = oldToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 889, 910);

                _newToken = newToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 924, 971);

                _diagnosticOffsetDelta = diagnosticOffsetDelta;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 985, 1008);

                _foundOldToken = false;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10011, 726, 1019);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10011, 726, 1019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10011, 726, 1019);
            }
        }

        internal static TRoot Replace<TRoot>(TRoot root, SyntaxToken oldToken, SyntaxToken newToken, int diagnosticOffsetDelta)
                    where TRoot : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10011, 1031, 1454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 1219, 1306);

                var
                replacer = f_10011_1234_1305<TRoot>(oldToken, newToken, diagnosticOffsetDelta)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 1320, 1362);

                var
                newRoot = (TRoot)f_10011_1341_1361<TRoot>(replacer, root)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 1376, 1414);

                f_10011_1376_1413<TRoot>(replacer._foundOldToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 1428, 1443);

                return newRoot;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10011, 1031, 1454);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxFirstTokenReplacer
                f_10011_1234_1305<TRoot>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                oldToken, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                newToken, int
                diagnosticOffsetDelta) where TRoot : CSharpSyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxFirstTokenReplacer(oldToken, newToken, diagnosticOffsetDelta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10011, 1234, 1305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                f_10011_1341_1361<TRoot>(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxFirstTokenReplacer
                this_param, TRoot
                node) where TRoot : CSharpSyntaxNode

                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10011, 1341, 1361);
                    return return_v;
                }


                int
                f_10011_1376_1413<TRoot>(bool
                condition) where TRoot : CSharpSyntaxNode

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10011, 1376, 1413);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10011, 1031, 1454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10011, 1031, 1454);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override CSharpSyntaxNode Visit(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10011, 1466, 2187);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 1552, 2148) || true) && (node != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10011, 1552, 2148);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 1602, 2133) || true) && (!_foundOldToken)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10011, 1602, 2133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 1663, 1695);

                        var
                        token = node as SyntaxToken
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 1717, 2018) || true) && (token != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10011, 1717, 2018);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 1784, 1817);

                            f_10011_1784_1816(token == _oldToken);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 1843, 1865);

                            _foundOldToken = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 1891, 1908);

                            return _newToken;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10011, 1717, 2018);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 2042, 2114);

                        return f_10011_2049_2113(DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10011, 2072, 2088), _diagnosticOffsetDelta);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10011, 1602, 2133);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10011, 1552, 2148);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 2164, 2176);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10011, 1466, 2187);

                int
                f_10011_1784_1816(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10011, 1784, 1816);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                f_10011_2049_2113(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                node, int
                diagnosticOffsetDelta)
                {
                    var return_v = UpdateDiagnosticOffset(node, diagnosticOffsetDelta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10011, 2049, 2113);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10011, 1466, 2187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10011, 1466, 2187);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TSyntax UpdateDiagnosticOffset<TSyntax>(TSyntax node, int diagnosticOffsetDelta) where TSyntax : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10011, 2199, 3404);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 2352, 2408);

                DiagnosticInfo[]
                oldDiagnostics = f_10011_2386_2407<TSyntax>(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 2422, 2539) || true) && (oldDiagnostics == null || (DynAbs.Tracing.TraceSender.Expression_False(10011, 2426, 2478) || f_10011_2452_2473<TSyntax>(oldDiagnostics) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10011, 2422, 2539);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 2512, 2524);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10011, 2422, 2539);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 2555, 2598);

                var
                numDiagnostics = f_10011_2576_2597<TSyntax>(oldDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 2612, 2681);

                DiagnosticInfo[]
                newDiagnostics = new DiagnosticInfo[numDiagnostics]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 2704, 2709);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 2695, 3330) || true) && (i < numDiagnostics)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 2731, 2734)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10011, 2695, 3330))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10011, 2695, 3330);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 2768, 2817);

                        DiagnosticInfo
                        oldDiagnostic = oldDiagnostics[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 2835, 2916);

                        SyntaxDiagnosticInfo
                        oldSyntaxDiagnostic = oldDiagnostic as SyntaxDiagnosticInfo
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 2934, 3315);

                        newDiagnostics[i] = (DynAbs.Tracing.TraceSender.Conditional_F1(10011, 2954, 2981) || ((oldSyntaxDiagnostic == null && DynAbs.Tracing.TraceSender.Conditional_F2(10011, 3005, 3018)) || DynAbs.Tracing.TraceSender.Conditional_F3(10011, 3042, 3314))) ? oldDiagnostic : f_10011_3042_3314<TSyntax>(oldSyntaxDiagnostic.Offset + diagnosticOffsetDelta, oldSyntaxDiagnostic.Width, f_10011_3233_3257<TSyntax>(oldSyntaxDiagnostic), f_10011_3284_3313<TSyntax>(oldSyntaxDiagnostic));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10011, 1, 636);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10011, 1, 636);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10011, 3344, 3393);

                return f_10011_3351_3392<TSyntax>(node, newDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10011, 2199, 3404);

                Microsoft.CodeAnalysis.DiagnosticInfo[]
                f_10011_2386_2407<TSyntax>(TSyntax
                this_param) where TSyntax : CSharpSyntaxNode

                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10011, 2386, 2407);
                    return return_v;
                }


                int
                f_10011_2452_2473<TSyntax>(Microsoft.CodeAnalysis.DiagnosticInfo[]
                this_param) where TSyntax : CSharpSyntaxNode

                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10011, 2452, 2473);
                    return return_v;
                }


                int
                f_10011_2576_2597<TSyntax>(Microsoft.CodeAnalysis.DiagnosticInfo[]
                this_param) where TSyntax : CSharpSyntaxNode

                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10011, 2576, 2597);
                    return return_v;
                }


                int
                f_10011_3233_3257<TSyntax>(Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                this_param) where TSyntax : CSharpSyntaxNode

                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10011, 3233, 3257);
                    return return_v;
                }


                object[]
                f_10011_3284_3313<TSyntax>(Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                this_param) where TSyntax : CSharpSyntaxNode

                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10011, 3284, 3313);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10011_3042_3314<TSyntax>(int
                offset, int
                width, int
                code, params object[]
                args) where TSyntax : CSharpSyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo(offset, width, (Microsoft.CodeAnalysis.CSharp.ErrorCode)code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10011, 3042, 3314);
                    return return_v;
                }


                TSyntax
                f_10011_3351_3392<TSyntax>(TSyntax
                node, Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics) where TSyntax : CSharpSyntaxNode

                {
                    var return_v = node.WithDiagnosticsGreen<TSyntax>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10011, 3351, 3392);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10011, 2199, 3404);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10011, 2199, 3404);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxFirstTokenReplacer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10011, 455, 3411);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10011, 455, 3411);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10011, 455, 3411);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10011, 455, 3411);
    }
}
