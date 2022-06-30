// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Syntax
{
    internal abstract partial class SyntaxList : SyntaxNode
    {
        internal SyntaxList(InternalSyntax.SyntaxList green, SyntaxNode? parent, int position)
        : base(f_674_512_517_C(green), parent, position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(674, 405, 558);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(674, 405, 558);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(674, 405, 558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(674, 405, 558);
            }
        }

        public override string Language
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(674, 626, 714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(674, 662, 699);

                    throw f_674_668_698();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(674, 626, 714);

                    System.Exception
                    f_674_668_698()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(674, 668, 698);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(674, 570, 725);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(674, 570, 725);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override SyntaxTree SyntaxTreeCore
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(674, 840, 866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(674, 843, 866);
                    return f_674_843_866(this.Parent!); DynAbs.Tracing.TraceSender.TraceExitMethod(674, 840, 866);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(674, 840, 866);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(674, 840, 866);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected internal override SyntaxNode ReplaceCore<TNode>(IEnumerable<TNode>? nodes = null, Func<TNode, TNode, SyntaxNode>? computeReplacementNode = null, IEnumerable<SyntaxToken>? tokens = null, Func<SyntaxToken, SyntaxToken, SyntaxToken>? computeReplacementToken = null, IEnumerable<SyntaxTrivia>? trivia = null, Func<SyntaxTrivia, SyntaxTrivia, SyntaxTrivia>? computeReplacementTrivia = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(674, 879, 1347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(674, 1299, 1336);

                throw f_674_1305_1335();
                DynAbs.Tracing.TraceSender.TraceExitMethod(674, 879, 1347);

                System.Exception
                f_674_1305_1335()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(674, 1305, 1335);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(674, 879, 1347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(674, 879, 1347);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal override SyntaxNode ReplaceNodeInListCore(SyntaxNode originalNode, IEnumerable<SyntaxNode> replacementNodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(674, 1359, 1559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(674, 1511, 1548);

                throw f_674_1517_1547();
                DynAbs.Tracing.TraceSender.TraceExitMethod(674, 1359, 1559);

                System.Exception
                f_674_1517_1547()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(674, 1517, 1547);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(674, 1359, 1559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(674, 1359, 1559);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal override SyntaxNode InsertNodesInListCore(SyntaxNode nodeInList, IEnumerable<SyntaxNode> nodesToInsert, bool insertBefore)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(674, 1571, 1785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(674, 1737, 1774);

                throw f_674_1743_1773();
                DynAbs.Tracing.TraceSender.TraceExitMethod(674, 1571, 1785);

                System.Exception
                f_674_1743_1773()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(674, 1743, 1773);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(674, 1571, 1785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(674, 1571, 1785);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal override SyntaxNode ReplaceTokenInListCore(SyntaxToken originalToken, IEnumerable<SyntaxToken> newTokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(674, 1797, 1994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(674, 1946, 1983);

                throw f_674_1952_1982();
                DynAbs.Tracing.TraceSender.TraceExitMethod(674, 1797, 1994);

                System.Exception
                f_674_1952_1982()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(674, 1952, 1982);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(674, 1797, 1994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(674, 1797, 1994);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal override SyntaxNode InsertTokensInListCore(SyntaxToken originalToken, IEnumerable<SyntaxToken> newTokens, bool insertBefore)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(674, 2006, 2222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(674, 2174, 2211);

                throw f_674_2180_2210();
                DynAbs.Tracing.TraceSender.TraceExitMethod(674, 2006, 2222);

                System.Exception
                f_674_2180_2210()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(674, 2180, 2210);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(674, 2006, 2222);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(674, 2006, 2222);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal override SyntaxNode ReplaceTriviaInListCore(SyntaxTrivia originalTrivia, IEnumerable<SyntaxTrivia> newTrivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(674, 2234, 2435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(674, 2387, 2424);

                throw f_674_2393_2423();
                DynAbs.Tracing.TraceSender.TraceExitMethod(674, 2234, 2435);

                System.Exception
                f_674_2393_2423()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(674, 2393, 2423);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(674, 2234, 2435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(674, 2234, 2435);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal override SyntaxNode InsertTriviaInListCore(SyntaxTrivia originalTrivia, IEnumerable<SyntaxTrivia> newTrivia, bool insertBefore)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(674, 2447, 2666);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(674, 2618, 2655);

                throw f_674_2624_2654();
                DynAbs.Tracing.TraceSender.TraceExitMethod(674, 2447, 2666);

                System.Exception
                f_674_2624_2654()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(674, 2624, 2654);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(674, 2447, 2666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(674, 2447, 2666);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal override SyntaxNode RemoveNodesCore(IEnumerable<SyntaxNode> nodes, SyntaxRemoveOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(674, 2678, 2865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(674, 2817, 2854);

                throw f_674_2823_2853();
                DynAbs.Tracing.TraceSender.TraceExitMethod(674, 2678, 2865);

                System.Exception
                f_674_2823_2853()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(674, 2823, 2853);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(674, 2678, 2865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(674, 2678, 2865);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal override SyntaxNode NormalizeWhitespaceCore(string indentation, string eol, bool elasticTrivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(674, 2877, 3064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(674, 3016, 3053);

                throw f_674_3022_3052();
                DynAbs.Tracing.TraceSender.TraceExitMethod(674, 2877, 3064);

                System.Exception
                f_674_3022_3052()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(674, 3022, 3052);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(674, 2877, 3064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(674, 2877, 3064);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool IsEquivalentToCore(SyntaxNode node, bool topLevel = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(674, 3076, 3231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(674, 3183, 3220);

                throw f_674_3189_3219();
                DynAbs.Tracing.TraceSender.TraceExitMethod(674, 3076, 3231);

                System.Exception
                f_674_3189_3219()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(674, 3189, 3219);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(674, 3076, 3231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(674, 3076, 3231);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxList()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(674, 333, 3238);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(674, 333, 3238);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(674, 333, 3238);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(674, 333, 3238);

        static Microsoft.CodeAnalysis.GreenNode
        f_674_512_517_C(Microsoft.CodeAnalysis.GreenNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(674, 405, 558);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxTree
        f_674_843_866(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.SyntaxTree;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(674, 843, 866);
            return return_v;
        }

    }
}
