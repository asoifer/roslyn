// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;

namespace Microsoft.CodeAnalysis.Syntax
{
    internal static class CommonSyntaxNodeRemover
    {
        public static void GetSeparatorInfo(
                    SyntaxNodeOrTokenList nodesAndSeparators, int nodeIndex, int endOfLineKind,
                    out bool nextTokenIsSeparator, out bool nextSeparatorBelongsToNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(660, 347, 2164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(660, 1518, 1568);

                var
                node = nodesAndSeparators[nodeIndex].AsNode()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(660, 1582, 1611);

                f_660_1582_1610(node is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(660, 1627, 1770);

                nextTokenIsSeparator =
                                nodeIndex + 1 < nodesAndSeparators.Count && (DynAbs.Tracing.TraceSender.Expression_True(660, 1667, 1769) && nodesAndSeparators[nodeIndex + 1].IsToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(660, 1786, 2153);

                nextSeparatorBelongsToNode =
                                nextTokenIsSeparator && (DynAbs.Tracing.TraceSender.Expression_True(660, 1832, 1937) && nodesAndSeparators[nodeIndex + 1].AsToken() is var nextSeparator) && (DynAbs.Tracing.TraceSender.Expression_True(660, 1832, 1989) && f_660_1958_1989_M(!nextSeparator.HasLeadingTrivia)) && (DynAbs.Tracing.TraceSender.Expression_True(660, 1832, 2069) && !f_660_2011_2069(f_660_2029_2053(node), endOfLineKind)) && (DynAbs.Tracing.TraceSender.Expression_True(660, 1832, 2152) && f_660_2090_2152(nextSeparator.TrailingTrivia, endOfLineKind));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(660, 347, 2164);

                int
                f_660_1582_1610(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(660, 1582, 1610);
                    return 0;
                }


                bool
                f_660_1958_1989_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(660, 1958, 1989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_660_2029_2053(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetTrailingTrivia();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(660, 2029, 2053);
                    return return_v;
                }


                bool
                f_660_2011_2069(Microsoft.CodeAnalysis.SyntaxTriviaList
                triviaList, int
                endOfLineKind)
                {
                    var return_v = ContainsEndOfLine(triviaList, endOfLineKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(660, 2011, 2069);
                    return return_v;
                }


                bool
                f_660_2090_2152(Microsoft.CodeAnalysis.SyntaxTriviaList
                triviaList, int
                endOfLineKind)
                {
                    var return_v = ContainsEndOfLine(triviaList, endOfLineKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(660, 2090, 2152);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(660, 347, 2164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(660, 347, 2164);
            }
        }

        private static bool ContainsEndOfLine(SyntaxTriviaList triviaList, int endOfLineKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(660, 2275, 2316);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(660, 2278, 2316);
                return triviaList.IndexOf(endOfLineKind) >= 0; DynAbs.Tracing.TraceSender.TraceExitMethod(660, 2275, 2316);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(660, 2275, 2316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(660, 2275, 2316);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CommonSyntaxNodeRemover()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(660, 285, 2324);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(660, 285, 2324);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(660, 285, 2324);
        }

    }
}
