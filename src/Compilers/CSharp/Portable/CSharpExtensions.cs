// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.Syntax;

namespace Microsoft.CodeAnalysis
{
    public static class CSharpExtensions
    {
        public static bool IsKind(this SyntaxToken token, SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 1001, 1137);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 1092, 1126);

                return token.RawKind == (int)kind;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 1001, 1137);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 1001, 1137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 1001, 1137);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsKind(this SyntaxTrivia trivia, SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 1535, 1674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 1628, 1663);

                return trivia.RawKind == (int)kind;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 1535, 1674);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 1535, 1674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 1535, 1674);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsKind([NotNullWhen(true)] this SyntaxNode? node, SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 2064, 2219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 2174, 2208);

                return f_10030_2181_2194_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(node, 10030, 2181, 2194)?.RawKind) == (int)kind;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 2064, 2219);

                int?
                f_10030_2181_2194_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10030, 2181, 2194);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 2064, 2219);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 2064, 2219);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsKind(this SyntaxNodeOrToken nodeOrToken, SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 2641, 2795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 2744, 2784);

                return nodeOrToken.RawKind == (int)kind;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 2641, 2795);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 2641, 2795);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 2641, 2795);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxKind ContextualKind(this SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 2807, 3026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 2897, 3015);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10030, 2904, 2958) || (((object)token.Language == (object)LanguageNames.CSharp && DynAbs.Tracing.TraceSender.Conditional_F2(10030, 2961, 2996)) || DynAbs.Tracing.TraceSender.Conditional_F3(10030, 2999, 3014))) ? (SyntaxKind)token.RawContextualKind : SyntaxKind.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 2807, 3026);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 2807, 3026);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 2807, 3026);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsUnderscoreToken(this SyntaxToken identifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 3038, 3206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 3130, 3195);

                return identifier.ContextualKind() == SyntaxKind.UnderscoreToken;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 3038, 3206);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 3038, 3206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 3038, 3206);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int IndexOf<TNode>(this SyntaxList<TNode> list, SyntaxKind kind)
                    where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 3621, 3804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 3762, 3793);

                // LAFHIS (CAST)
                return list.IndexOf((int)kind);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 3621, 3804);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 3621, 3804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 3621, 3804);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Any<TNode>(this SyntaxList<TNode> list, SyntaxKind kind)
                    where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 3938, 4118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 4076, 4107);

                return list.IndexOf(kind) >= 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 3938, 4118);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 3938, 4118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 3938, 4118);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int IndexOf<TNode>(this SeparatedSyntaxList<TNode> list, SyntaxKind kind)
                    where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 4533, 4725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 4683, 4714);

                return list.IndexOf((int)kind);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 4533, 4725);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 4533, 4725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 4533, 4725);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Any<TNode>(this SeparatedSyntaxList<TNode> list, SyntaxKind kind)
                    where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 4859, 5048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 5006, 5037);

                return list.IndexOf(kind) >= 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 4859, 5048);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 4859, 5048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 4859, 5048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int IndexOf(this SyntaxTriviaList list, SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 5471, 5608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 5566, 5597);

                return list.IndexOf((int)kind);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 5471, 5608);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 5471, 5608);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 5471, 5608);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Any(this SyntaxTriviaList list, SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 5744, 5878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 5836, 5867);

                return list.IndexOf(kind) >= 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 5744, 5878);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 5744, 5878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 5744, 5878);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int IndexOf(this SyntaxTokenList list, SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 6297, 6433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 6391, 6422);

                return list.IndexOf((int)kind);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 6297, 6433);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 6297, 6433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 6297, 6433);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool Any(this SyntaxTokenList list, SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 6807, 6940);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 6898, 6929);

                return list.IndexOf(kind) >= 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 6807, 6940);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 6807, 6940);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 6807, 6940);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxToken FirstOrDefault(this SyntaxTokenList list, SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 6952, 7176);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 7063, 7094);

                int
                index = list.IndexOf(kind)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 7108, 7165);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10030, 7115, 7127) || (((index >= 0) && DynAbs.Tracing.TraceSender.Conditional_F2(10030, 7130, 7141)) || DynAbs.Tracing.TraceSender.Conditional_F3(10030, 7144, 7164))) ? list[index] : default(SyntaxToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 6952, 7176);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 6952, 7176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 6952, 7176);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CSharpExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10030, 566, 7183);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10030, 566, 7183);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 566, 7183);
        }

    }
}

namespace Microsoft.CodeAnalysis.CSharp
{
    public static class CSharpExtensions
    {
        internal static bool IsCSharpKind(int rawKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 7653, 8055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 7724, 7782);

                const int
                FirstVisualBasicKind = (int)SyntaxKind.List + 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 7796, 7851);

                const int
                FirstCSharpKind = (int)SyntaxKind.TildeToken
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 7940, 8044);

                return unchecked((uint)(rawKind - FirstVisualBasicKind)) > (FirstCSharpKind - 1 - FirstVisualBasicKind);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 7653, 8055);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 7653, 8055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 7653, 8055);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxKind Kind(this SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 8239, 8439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 8317, 8345);

                var
                rawKind = token.RawKind
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 8359, 8428);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10030, 8366, 8387) || ((f_10030_8366_8387(rawKind) && DynAbs.Tracing.TraceSender.Conditional_F2(10030, 8390, 8409)) || DynAbs.Tracing.TraceSender.Conditional_F3(10030, 8412, 8427))) ? (SyntaxKind)rawKind : SyntaxKind.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 8239, 8439);

                bool
                f_10030_8366_8387(int
                rawKind)
                {
                    var return_v = IsCSharpKind(rawKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 8366, 8387);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 8239, 8439);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 8239, 8439);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxKind Kind(this SyntaxTrivia trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 8625, 8828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 8705, 8734);

                var
                rawKind = trivia.RawKind
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 8748, 8817);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10030, 8755, 8776) || ((f_10030_8755_8776(rawKind) && DynAbs.Tracing.TraceSender.Conditional_F2(10030, 8779, 8798)) || DynAbs.Tracing.TraceSender.Conditional_F3(10030, 8801, 8816))) ? (SyntaxKind)rawKind : SyntaxKind.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 8625, 8828);

                bool
                f_10030_8755_8776(int
                rawKind)
                {
                    var return_v = IsCSharpKind(rawKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 8755, 8776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 8625, 8828);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 8625, 8828);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxKind Kind(this SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 9010, 9207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 9086, 9113);

                var
                rawKind = f_10030_9100_9112(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 9127, 9196);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10030, 9134, 9155) || ((f_10030_9134_9155(rawKind) && DynAbs.Tracing.TraceSender.Conditional_F2(10030, 9158, 9177)) || DynAbs.Tracing.TraceSender.Conditional_F3(10030, 9180, 9195))) ? (SyntaxKind)rawKind : SyntaxKind.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 9010, 9207);

                int
                f_10030_9100_9112(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10030, 9100, 9112);
                    return return_v;
                }


                bool
                f_10030_9134_9155(int
                rawKind)
                {
                    var return_v = IsCSharpKind(rawKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 9134, 9155);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 9010, 9207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 9010, 9207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxKind Kind(this SyntaxNodeOrToken nodeOrToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 9396, 9614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 9486, 9520);

                var
                rawKind = nodeOrToken.RawKind
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 9534, 9603);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10030, 9541, 9562) || ((f_10030_9541_9562(rawKind) && DynAbs.Tracing.TraceSender.Conditional_F2(10030, 9565, 9584)) || DynAbs.Tracing.TraceSender.Conditional_F3(10030, 9587, 9602))) ? (SyntaxKind)rawKind : SyntaxKind.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 9396, 9614);

                bool
                f_10030_9541_9562(int
                rawKind)
                {
                    var return_v = IsCSharpKind(rawKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 9541, 9562);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 9396, 9614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 9396, 9614);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsKeyword(this SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 9626, 9761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 9703, 9750);

                return f_10030_9710_9749(token.Kind());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 9626, 9761);

                bool
                f_10030_9710_9749(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsKeywordKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 9710, 9749);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 9626, 9761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 9626, 9761);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsContextualKeyword(this SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 9773, 9924);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 9860, 9913);

                return f_10030_9867_9912(token.Kind());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 9773, 9924);

                bool
                f_10030_9867_9912(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsContextualKeyword(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 9867, 9912);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 9773, 9924);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 9773, 9924);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsReservedKeyword(this SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 9936, 10083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 10021, 10072);

                return f_10030_10028_10071(token.Kind());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 9936, 10083);

                bool
                f_10030_10028_10071(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsReservedKeyword(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 10028, 10071);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 9936, 10083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 9936, 10083);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsVerbatimStringLiteral(this SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 10095, 10297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 10186, 10286);

                return token.IsKind(SyntaxKind.StringLiteralToken) && (DynAbs.Tracing.TraceSender.Expression_True(10030, 10193, 10261) && f_10030_10240_10257(token.Text) > 0) && (DynAbs.Tracing.TraceSender.Expression_True(10030, 10193, 10285) && f_10030_10265_10278(token.Text, 0) == '@');
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 10095, 10297);

                int
                f_10030_10240_10257(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10030, 10240, 10257);
                    return return_v;
                }


                char
                f_10030_10265_10278(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10030, 10265, 10278);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 10095, 10297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 10095, 10297);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsVerbatimIdentifier(this SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 10309, 10505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 10397, 10494);

                return token.IsKind(SyntaxKind.IdentifierToken) && (DynAbs.Tracing.TraceSender.Expression_True(10030, 10404, 10469) && f_10030_10448_10465(token.Text) > 0) && (DynAbs.Tracing.TraceSender.Expression_True(10030, 10404, 10493) && f_10030_10473_10486(token.Text, 0) == '@');
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 10309, 10505);

                int
                f_10030_10448_10465(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10030, 10448, 10465);
                    return return_v;
                }


                char
                f_10030_10473_10486(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10030, 10473, 10486);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 10309, 10505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 10309, 10505);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static VarianceKind VarianceKindFromToken(this SyntaxToken node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 10517, 10864);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 10613, 10853);

                switch (node.Kind())
                {

                    case SyntaxKind.OutKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 10613, 10853);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 10694, 10718);

                        return VarianceKind.Out;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 10613, 10853);

                    case SyntaxKind.InKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 10613, 10853);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 10763, 10786);

                        return VarianceKind.In;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 10613, 10853);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 10613, 10853);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 10813, 10838);

                        return VarianceKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 10613, 10853);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 10517, 10864);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 10517, 10864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 10517, 10864);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTokenList Insert(this SyntaxTokenList list, int index, params SyntaxToken[] items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 11067, 12078);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 11194, 11331) || true) && (index < 0 || (DynAbs.Tracing.TraceSender.Expression_False(10030, 11198, 11229) || index > list.Count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 11194, 11331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 11263, 11316);

                    throw f_10030_11269_11315(nameof(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 11194, 11331);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 11347, 11460) || true) && (items == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 11347, 11460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 11398, 11445);

                    throw f_10030_11404_11444(nameof(items));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 11347, 11460);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 11476, 12067) || true) && (list.Count == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 11476, 12067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 11529, 11567);

                    return f_10030_11536_11566(items);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 11476, 12067);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 11476, 12067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 11633, 11701);

                    var
                    builder = f_10030_11647_11700(list.Count + f_10030_11687_11699(items))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 11719, 11821) || true) && (index > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 11719, 11821);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 11774, 11802);

                        f_10030_11774_11801(builder, list, 0, index);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 11719, 11821);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 11841, 11860);

                    f_10030_11841_11859(
                                    builder, items);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 11880, 12008) || true) && (index < list.Count)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 11880, 12008);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 11944, 11989);

                        f_10030_11944_11988(builder, list, index, list.Count - index);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 11880, 12008);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 12028, 12052);

                    return f_10030_12035_12051(builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 11476, 12067);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 11067, 12078);

                System.ArgumentOutOfRangeException
                f_10030_11269_11315(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 11269, 11315);
                    return return_v;
                }


                System.ArgumentNullException
                f_10030_11404_11444(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 11404, 11444);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10030_11536_11566(params Microsoft.CodeAnalysis.SyntaxToken[]
                tokens)
                {
                    var return_v = SyntaxFactory.TokenList(tokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 11536, 11566);
                    return return_v;
                }


                int
                f_10030_11687_11699(Microsoft.CodeAnalysis.SyntaxToken[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10030, 11687, 11699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                f_10030_11647_11700(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 11647, 11700);
                    return return_v;
                }


                int
                f_10030_11774_11801(Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxTokenList
                list, int
                offset, int
                length)
                {
                    this_param.Add(list, offset, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 11774, 11801);
                    return 0;
                }


                int
                f_10030_11841_11859(Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxToken[]
                list)
                {
                    this_param.Add(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 11841, 11859);
                    return 0;
                }


                int
                f_10030_11944_11988(Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxTokenList
                list, int
                offset, int
                length)
                {
                    this_param.Add(list, offset, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 11944, 11988);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10030_12035_12051(Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                this_param)
                {
                    var return_v = this_param.ToList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 12035, 12051);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 11067, 12078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 11067, 12078);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken ReplaceTrivia(this SyntaxToken token, IEnumerable<SyntaxTrivia> trivia, Func<SyntaxTrivia, SyntaxTrivia, SyntaxTrivia> computeReplacementTrivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 12651, 12969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 12846, 12958);

                return f_10030_12853_12957(token, trivia: trivia, computeReplacementTrivia: computeReplacementTrivia);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 12651, 12969);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10030_12853_12957(Microsoft.CodeAnalysis.SyntaxToken
                root, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                trivia, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.SyntaxTrivia>
                computeReplacementTrivia)
                {
                    var return_v = Syntax.SyntaxReplacer.Replace(root, trivia: trivia, computeReplacementTrivia: computeReplacementTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 12853, 12957);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 12651, 12969);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 12651, 12969);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxToken ReplaceTrivia(this SyntaxToken token, SyntaxTrivia oldTrivia, SyntaxTrivia newTrivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 13439, 13706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 13575, 13695);

                return f_10030_13582_13694(token, trivia: new[] { oldTrivia }, computeReplacementTrivia: (o, r) => newTrivia);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 13439, 13706);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10030_13582_13694(Microsoft.CodeAnalysis.SyntaxToken
                root, Microsoft.CodeAnalysis.SyntaxTrivia[]
                trivia, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.SyntaxTrivia>?
                computeReplacementTrivia)
                {
                    var return_v = Syntax.SyntaxReplacer.Replace(root, trivia: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>)trivia, computeReplacementTrivia: computeReplacementTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 13582, 13694);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 13439, 13706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 13439, 13706);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Syntax.InternalSyntax.DirectiveStack ApplyDirectives(this SyntaxNode node, Syntax.InternalSyntax.DirectiveStack stack)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 13718, 13971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 13877, 13960);

                return f_10030_13884_13959(((Syntax.InternalSyntax.CSharpSyntaxNode)f_10030_13925_13935(node)), stack);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 13718, 13971);

                Microsoft.CodeAnalysis.GreenNode
                f_10030_13925_13935(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10030, 13925, 13935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                f_10030_13884_13959(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                stack)
                {
                    var return_v = this_param.ApplyDirectives(stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 13884, 13959);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 13718, 13971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 13718, 13971);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Syntax.InternalSyntax.DirectiveStack ApplyDirectives(this SyntaxToken token, Syntax.InternalSyntax.DirectiveStack stack)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 13983, 14239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 14144, 14228);

                return f_10030_14151_14227(((Syntax.InternalSyntax.CSharpSyntaxNode)token.Node!), stack);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 13983, 14239);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                f_10030_14151_14227(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.DirectiveStack
                stack)
                {
                    var return_v = this_param.ApplyDirectives(stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 14151, 14227);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 13983, 14239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 13983, 14239);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Syntax.InternalSyntax.DirectiveStack ApplyDirectives(this SyntaxNodeOrToken nodeOrToken, Syntax.InternalSyntax.DirectiveStack stack)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 14251, 14724);
                Microsoft.CodeAnalysis.SyntaxNode? node = default(Microsoft.CodeAnalysis.SyntaxNode?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 14424, 14548) || true) && (nodeOrToken.IsToken)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 14424, 14548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 14481, 14533);

                    return nodeOrToken.AsToken().ApplyDirectives(stack);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 14424, 14548);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 14564, 14684) || true) && (nodeOrToken.AsNode(out node
                ))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 14564, 14684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 14634, 14669);

                    return node.ApplyDirectives(stack);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 14564, 14684);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 14700, 14713);

                return stack;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 14251, 14724);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 14251, 14724);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 14251, 14724);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SeparatedSyntaxList<TOther> AsSeparatedList<TOther>(this SyntaxNodeOrTokenList list) where TOther : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 15026, 15630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 15177, 15235);

                var
                builder = SeparatedSyntaxListBuilder<SyntaxNode>.Create()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 15249, 15579);
                    foreach (var i in f_10030_15267_15271_I(list))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 15249, 15579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 15305, 15327);

                        var
                        node = i.AsNode()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 15345, 15564) || true) && (node != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 15345, 15564);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 15403, 15429);

                            builder.Add(node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 15345, 15564);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 15345, 15564);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 15511, 15545);

                            builder.AddSeparator(i.AsToken());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 15345, 15564);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 15249, 15579);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10030, 1, 331);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10030, 1, 331);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 15595, 15619);

                return builder.ToList();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 15026, 15630);

                Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                f_10030_15267_15271_I(Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 15267, 15271);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 15026, 15630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 15026, 15630);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IList<DirectiveTriviaSyntax> GetDirectives(this SyntaxNode node, Func<DirectiveTriviaSyntax, bool>? filter = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 15670, 15890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 15825, 15879);

                return f_10030_15832_15878(((CSharpSyntaxNode)node), filter);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 15670, 15890);

                System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                f_10030_15832_15878(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax, bool>?
                filter)
                {
                    var return_v = this_param.GetDirectives(filter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 15832, 15878);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 15670, 15890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 15670, 15890);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static DirectiveTriviaSyntax? GetFirstDirective(this SyntaxNode node, Func<DirectiveTriviaSyntax, bool>? predicate = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 16020, 16246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 16174, 16235);

                return f_10030_16181_16234(((CSharpSyntaxNode)node), predicate);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 16020, 16246);

                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10030_16181_16234(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax, bool>?
                predicate)
                {
                    var return_v = this_param.GetFirstDirective(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 16181, 16234);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 16020, 16246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 16020, 16246);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static DirectiveTriviaSyntax? GetLastDirective(this SyntaxNode node, Func<DirectiveTriviaSyntax, bool>? predicate = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 16375, 16599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 16528, 16588);

                return f_10030_16535_16587(((CSharpSyntaxNode)node), predicate);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 16375, 16599);

                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax?
                f_10030_16535_16587(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax, bool>?
                predicate)
                {
                    var return_v = this_param.GetLastDirective(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 16535, 16587);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 16375, 16599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 16375, 16599);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CompilationUnitSyntax GetCompilationUnitRoot(this SyntaxTree tree, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 16659, 16903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 16830, 16892);

                return (CompilationUnitSyntax)f_10030_16860_16891(tree, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 16659, 16903);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10030_16860_16891(Microsoft.CodeAnalysis.SyntaxTree
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetRoot(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 16860, 16891);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 16659, 16903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 16659, 16903);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasReferenceDirectives([NotNullWhen(true)] this SyntaxTree? tree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 16915, 17156);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 17026, 17068);

                var
                csharpTree = tree as CSharpSyntaxTree
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 17082, 17145);

                return csharpTree != null && (DynAbs.Tracing.TraceSender.Expression_True(10030, 17089, 17144) && f_10030_17111_17144(csharpTree));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 16915, 17156);

                bool
                f_10030_17111_17144(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param)
                {
                    var return_v = this_param.HasReferenceDirectives;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10030, 17111, 17144);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 16915, 17156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 16915, 17156);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasReferenceOrLoadDirectives([NotNullWhen(true)] this SyntaxTree? tree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 17168, 17421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 17285, 17327);

                var
                csharpTree = tree as CSharpSyntaxTree
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 17341, 17410);

                return csharpTree != null && (DynAbs.Tracing.TraceSender.Expression_True(10030, 17348, 17409) && f_10030_17370_17409(csharpTree));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 17168, 17421);

                bool
                f_10030_17370_17409(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param)
                {
                    var return_v = this_param.HasReferenceOrLoadDirectives;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10030, 17370, 17409);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 17168, 17421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 17168, 17421);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsAnyPreprocessorSymbolDefined([NotNullWhen(true)] this SyntaxTree? tree, ImmutableArray<string> conditionalSymbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 17433, 17753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 17595, 17637);

                var
                csharpTree = tree as CSharpSyntaxTree
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 17651, 17742);

                return csharpTree != null && (DynAbs.Tracing.TraceSender.Expression_True(10030, 17658, 17741) && f_10030_17680_17741(csharpTree, conditionalSymbols));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 17433, 17753);

                bool
                f_10030_17680_17741(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, System.Collections.Immutable.ImmutableArray<string>
                conditionalSymbols)
                {
                    var return_v = this_param.IsAnyPreprocessorSymbolDefined(conditionalSymbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 17680, 17741);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 17433, 17753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 17433, 17753);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsPreprocessorSymbolDefined([NotNullWhen(true)] this SyntaxTree? tree, string symbolName, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 17765, 18071);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 17914, 17956);

                var
                csharpTree = tree as CSharpSyntaxTree
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 17970, 18060);

                return csharpTree != null && (DynAbs.Tracing.TraceSender.Expression_True(10030, 17977, 18059) && f_10030_17999_18059(csharpTree, symbolName, position));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 17765, 18071);

                bool
                f_10030_17999_18059(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, string
                symbolName, int
                position)
                {
                    var return_v = this_param.IsPreprocessorSymbolDefined(symbolName, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 17999, 18059);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 17765, 18071);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 17765, 18071);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PragmaWarningState GetPragmaDirectiveWarningState(this SyntaxTree tree, string id, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 18199, 18424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 18336, 18413);

                return f_10030_18343_18412(((CSharpSyntaxTree)tree), id, position);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 18199, 18424);

                Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningState
                f_10030_18343_18412(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, string
                id, int
                position)
                {
                    var return_v = this_param.GetPragmaDirectiveWarningState(id, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 18343, 18412);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 18199, 18424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 18199, 18424);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Conversion ClassifyConversion(this Compilation? compilation, ITypeSymbol source, ITypeSymbol destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 19029, 19462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 19173, 19219);

                var
                cscomp = compilation as CSharpCompilation
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 19233, 19451) || true) && (cscomp != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 19233, 19451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 19285, 19339);

                    return f_10030_19292_19338(cscomp, source, destination);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 19233, 19451);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 19233, 19451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 19405, 19436);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 19233, 19451);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 19029, 19462);

                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10030_19292_19338(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.ITypeSymbol
                source, Microsoft.CodeAnalysis.ITypeSymbol
                destination)
                {
                    var return_v = this_param.ClassifyConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 19292, 19338);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 19029, 19462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 19029, 19462);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SymbolInfo GetSymbolInfo(this SemanticModel? semanticModel, OrderingSyntax node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 19666, 20138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 19851, 19902);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 19916, 20127) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 19916, 20127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 19969, 20023);

                    return f_10030_19976_20022(csmodel, node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 19916, 20127);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 19916, 20127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 20089, 20112);

                    return SymbolInfo.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 19916, 20127);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 19666, 20138);

                Microsoft.CodeAnalysis.SymbolInfo
                f_10030_19976_20022(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetSymbolInfo(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 19976, 20022);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 19666, 20138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 19666, 20138);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SymbolInfo GetSymbolInfo(this SemanticModel? semanticModel, SelectOrGroupClauseSyntax node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 20282, 20765);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 20478, 20529);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 20543, 20754) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 20543, 20754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 20596, 20650);

                    return f_10030_20603_20649(csmodel, node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 20543, 20754);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 20543, 20754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 20716, 20739);

                    return SymbolInfo.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 20543, 20754);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 20282, 20765);

                Microsoft.CodeAnalysis.SymbolInfo
                f_10030_20603_20649(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetSymbolInfo(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 20603, 20649);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 20282, 20765);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 20282, 20765);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SymbolInfo GetSymbolInfo(this SemanticModel? semanticModel, ExpressionSyntax expression, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 21528, 22014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 21721, 21772);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 21786, 22003) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 21786, 22003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 21839, 21899);

                    return f_10030_21846_21898(csmodel, expression, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 21786, 22003);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 21786, 22003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 21965, 21988);

                    return SymbolInfo.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 21786, 22003);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 21528, 22014);

                Microsoft.CodeAnalysis.SymbolInfo
                f_10030_21846_21898(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetSymbolInfo(expression, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 21846, 21898);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 21528, 22014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 21528, 22014);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SymbolInfo GetCollectionInitializerSymbolInfo(this SemanticModel? semanticModel, ExpressionSyntax expression, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 22256, 22784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 22470, 22521);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 22535, 22773) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 22535, 22773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 22588, 22669);

                    return f_10030_22595_22668(csmodel, expression, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 22535, 22773);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 22535, 22773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 22735, 22758);

                    return SymbolInfo.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 22535, 22773);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 22256, 22784);

                Microsoft.CodeAnalysis.SymbolInfo
                f_10030_22595_22668(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetCollectionInitializerSymbolInfo(expression, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 22595, 22668);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 22256, 22784);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 22256, 22784);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SymbolInfo GetSymbolInfo(this SemanticModel? semanticModel, ConstructorInitializerSyntax constructorInitializer, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 22954, 23476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 23171, 23222);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 23236, 23465) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 23236, 23465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 23289, 23361);

                    return f_10030_23296_23360(csmodel, constructorInitializer, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 23236, 23465);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 23236, 23465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 23427, 23450);

                    return SymbolInfo.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 23236, 23465);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 22954, 23476);

                Microsoft.CodeAnalysis.SymbolInfo
                f_10030_23296_23360(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                constructorInitializer, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetSymbolInfo(constructorInitializer, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 23296, 23360);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 22954, 23476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 22954, 23476);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SymbolInfo GetSymbolInfo(this SemanticModel? semanticModel, PrimaryConstructorBaseTypeSyntax constructorInitializer, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 23646, 24172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 23867, 23918);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 23932, 24161) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 23932, 24161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 23985, 24057);

                    return f_10030_23992_24056(csmodel, constructorInitializer, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 23932, 24161);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 23932, 24161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 24123, 24146);

                    return SymbolInfo.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 23932, 24161);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 23646, 24172);

                Microsoft.CodeAnalysis.SymbolInfo
                f_10030_23992_24056(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax
                constructorInitializer, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetSymbolInfo(constructorInitializer, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 23992, 24056);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 23646, 24172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 23646, 24172);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SymbolInfo GetSymbolInfo(this SemanticModel? semanticModel, AttributeSyntax attributeSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 24328, 24823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 24525, 24576);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 24590, 24812) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 24590, 24812);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 24643, 24708);

                    return f_10030_24650_24707(csmodel, attributeSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 24590, 24812);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 24590, 24812);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 24774, 24797);

                    return SymbolInfo.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 24590, 24812);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 24328, 24823);

                Microsoft.CodeAnalysis.SymbolInfo
                f_10030_24650_24707(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetSymbolInfo(attributeSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 24650, 24707);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 24328, 24823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 24328, 24823);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SymbolInfo GetSymbolInfo(this SemanticModel? semanticModel, CrefSyntax crefSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 24971, 25451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 25158, 25209);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 25223, 25440) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 25223, 25440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 25276, 25336);

                    return f_10030_25283_25335(csmodel, crefSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 25223, 25440);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 25223, 25440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 25402, 25425);

                    return SymbolInfo.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 25223, 25440);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 24971, 25451);

                Microsoft.CodeAnalysis.SymbolInfo
                f_10030_25283_25335(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                crefSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetSymbolInfo(crefSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 25283, 25335);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 24971, 25451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 24971, 25451);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SymbolInfo GetSpeculativeSymbolInfo(this SemanticModel? semanticModel, int position, ExpressionSyntax expression, SpeculativeBindingOption bindingOption)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 25755, 26257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 25947, 25998);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 26012, 26246) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 26012, 26246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 26065, 26142);

                    return f_10030_26072_26141(csmodel, position, expression, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 26012, 26246);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 26012, 26246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 26208, 26231);

                    return SymbolInfo.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 26012, 26246);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 25755, 26257);

                Microsoft.CodeAnalysis.SymbolInfo
                f_10030_26072_26141(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption)
                {
                    var return_v = this_param.GetSpeculativeSymbolInfo(position, expression, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 26072, 26141);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 25755, 26257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 25755, 26257);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SymbolInfo GetSpeculativeSymbolInfo(this SemanticModel? semanticModel, int position, CrefSyntax expression, SpeculativeBindingOption bindingOption)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 26572, 27068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 26758, 26809);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 26823, 27057) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 26823, 27057);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 26876, 26953);

                    return f_10030_26883_26952(csmodel, position, expression, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 26823, 27057);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 26823, 27057);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 27019, 27042);

                    return SymbolInfo.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 26823, 27057);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 26572, 27068);

                Microsoft.CodeAnalysis.SymbolInfo
                f_10030_26883_26952(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                expression, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption)
                {
                    var return_v = this_param.GetSpeculativeSymbolInfo(position, (Microsoft.CodeAnalysis.SyntaxNode)expression, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 26883, 26952);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 26572, 27068);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 26572, 27068);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SymbolInfo GetSpeculativeSymbolInfo(this SemanticModel? semanticModel, int position, AttributeSyntax attribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 27410, 27854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 27560, 27611);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 27625, 27843) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 27625, 27843);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 27678, 27739);

                    return f_10030_27685_27738(csmodel, position, attribute);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 27625, 27843);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 27625, 27843);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 27805, 27828);

                    return SymbolInfo.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 27625, 27843);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 27410, 27854);

                Microsoft.CodeAnalysis.SymbolInfo
                f_10030_27685_27738(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attribute)
                {
                    var return_v = this_param.GetSpeculativeSymbolInfo(position, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 27685, 27738);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 27410, 27854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 27410, 27854);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SymbolInfo GetSpeculativeSymbolInfo(this SemanticModel? semanticModel, int position, ConstructorInitializerSyntax constructorInitializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 28338, 28821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 28514, 28565);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 28579, 28810) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 28579, 28810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 28632, 28706);

                    return f_10030_28639_28705(csmodel, position, constructorInitializer);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 28579, 28810);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 28579, 28810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 28772, 28795);

                    return SymbolInfo.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 28579, 28810);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 28338, 28821);

                Microsoft.CodeAnalysis.SymbolInfo
                f_10030_28639_28705(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                constructorInitializer)
                {
                    var return_v = this_param.GetSpeculativeSymbolInfo(position, constructorInitializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 28639, 28705);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 28338, 28821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 28338, 28821);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SymbolInfo GetSpeculativeSymbolInfo(this SemanticModel? semanticModel, int position, PrimaryConstructorBaseTypeSyntax constructorInitializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 29342, 29829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 29522, 29573);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 29587, 29818) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 29587, 29818);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 29640, 29714);

                    return f_10030_29647_29713(csmodel, position, constructorInitializer);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 29587, 29818);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 29587, 29818);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 29780, 29803);

                    return SymbolInfo.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 29587, 29818);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 29342, 29829);

                Microsoft.CodeAnalysis.SymbolInfo
                f_10030_29647_29713(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax
                constructorInitializer)
                {
                    var return_v = this_param.GetSpeculativeSymbolInfo(position, constructorInitializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 29647, 29713);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 29342, 29829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 29342, 29829);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypeInfo GetTypeInfo(this SemanticModel? semanticModel, ConstructorInitializerSyntax constructorInitializer, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 29956, 30476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 30169, 30220);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 30234, 30465) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 30234, 30465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 30287, 30357);

                    return f_10030_30294_30356(csmodel, constructorInitializer, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 30234, 30465);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 30234, 30465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 30423, 30450);

                    return CSharpTypeInfo.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 30234, 30465);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 29956, 30476);

                Microsoft.CodeAnalysis.TypeInfo
                f_10030_30294_30356(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                constructorInitializer, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetTypeInfo(constructorInitializer, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 30294, 30356);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 29956, 30476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 29956, 30476);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypeInfo GetTypeInfo(this SemanticModel? semanticModel, SelectOrGroupClauseSyntax node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 30488, 30969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 30680, 30731);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 30745, 30958) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 30745, 30958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 30798, 30850);

                    return f_10030_30805_30849(csmodel, node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 30745, 30958);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 30745, 30958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 30916, 30943);

                    return CSharpTypeInfo.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 30745, 30958);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 30488, 30969);

                Microsoft.CodeAnalysis.TypeInfo
                f_10030_30805_30849(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetTypeInfo(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 30805, 30849);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 30488, 30969);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 30488, 30969);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypeInfo GetTypeInfo(this SemanticModel? semanticModel, ExpressionSyntax expression, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 31084, 31568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 31273, 31324);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 31338, 31557) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 31338, 31557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 31391, 31449);

                    return f_10030_31398_31448(csmodel, expression, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 31338, 31557);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 31338, 31557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 31515, 31542);

                    return CSharpTypeInfo.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 31338, 31557);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 31084, 31568);

                Microsoft.CodeAnalysis.TypeInfo
                f_10030_31398_31448(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetTypeInfo(expression, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 31398, 31448);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 31084, 31568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 31084, 31568);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypeInfo GetTypeInfo(this SemanticModel? semanticModel, AttributeSyntax attributeSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 31682, 32175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 31875, 31926);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 31940, 32164) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 31940, 32164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 31993, 32056);

                    return f_10030_32000_32055(csmodel, attributeSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 31940, 32164);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 31940, 32164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 32122, 32149);

                    return CSharpTypeInfo.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 31940, 32164);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 31682, 32175);

                Microsoft.CodeAnalysis.TypeInfo
                f_10030_32000_32055(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetTypeInfo(attributeSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 32000, 32055);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 31682, 32175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 31682, 32175);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypeInfo GetSpeculativeTypeInfo(this SemanticModel? semanticModel, int position, ExpressionSyntax expression, SpeculativeBindingOption bindingOption)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 32475, 32975);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 32663, 32714);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 32728, 32964) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 32728, 32964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 32781, 32856);

                    return f_10030_32788_32855(csmodel, position, expression, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 32728, 32964);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 32728, 32964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 32922, 32949);

                    return CSharpTypeInfo.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 32728, 32964);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 32475, 32975);

                Microsoft.CodeAnalysis.TypeInfo
                f_10030_32788_32855(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption)
                {
                    var return_v = this_param.GetSpeculativeTypeInfo(position, expression, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 32788, 32855);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 32475, 32975);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 32475, 32975);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Conversion GetConversion(this SemanticModel? semanticModel, SyntaxNode expression, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 32987, 33475);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 33174, 33225);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 33239, 33464) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 33239, 33464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 33292, 33352);

                    return f_10030_33299_33351(csmodel, expression, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 33239, 33464);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 33239, 33464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 33418, 33449);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 33239, 33464);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 32987, 33475);

                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10030_33299_33351(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                expression, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetConversion(expression, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 33299, 33351);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 32987, 33475);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 32987, 33475);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Conversion GetConversion(this IConversionOperation conversionExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 34066, 34871);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 34177, 34320) || true) && (conversionExpression is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 34177, 34320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 34243, 34305);

                    throw f_10030_34249_34304(nameof(conversionExpression));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 34177, 34320);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 34336, 34860) || true) && (f_10030_34340_34369(conversionExpression) == LanguageNames.CSharp)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 34336, 34860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 34427, 34512);

                    return (Conversion)f_10030_34446_34511(((ConversionOperation)conversionExpression));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 34336, 34860);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 34336, 34860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 34578, 34845);

                    throw f_10030_34584_34844(f_10030_34606_34768(f_10030_34620_34678(), nameof(IConversionOperation)), nameof(conversionExpression));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 34336, 34860);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 34066, 34871);

                System.ArgumentNullException
                f_10030_34249_34304(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 34249, 34304);
                    return return_v;
                }


                string
                f_10030_34340_34369(Microsoft.CodeAnalysis.Operations.IConversionOperation
                this_param)
                {
                    var return_v = this_param.Language;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10030, 34340, 34369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IConvertibleConversion
                f_10030_34446_34511(Microsoft.CodeAnalysis.Operations.ConversionOperation
                this_param)
                {
                    var return_v = this_param.ConversionConvertible;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10030, 34446, 34511);
                    return return_v;
                }


                string
                f_10030_34620_34678()
                {
                    var return_v = CSharpResources.IConversionExpressionIsNotCSharpConversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10030, 34620, 34678);
                    return return_v;
                }


                string
                f_10030_34606_34768(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 34606, 34768);
                    return return_v;
                }


                System.ArgumentException
                f_10030_34584_34844(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 34584, 34844);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 34066, 34871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 34066, 34871);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Conversion GetInConversion(this ICompoundAssignmentOperation compoundAssignment)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 35326, 36152);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 35445, 35584) || true) && (compoundAssignment == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 35445, 35584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 35509, 35569);

                    throw f_10030_35515_35568(nameof(compoundAssignment));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 35445, 35584);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 35600, 36141) || true) && (f_10030_35604_35631(compoundAssignment) == LanguageNames.CSharp)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 35600, 36141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 35689, 35782);

                    return (Conversion)f_10030_35708_35781(((CompoundAssignmentOperation)compoundAssignment));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 35600, 36141);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 35600, 36141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 35848, 36126);

                    throw f_10030_35854_36125(f_10030_35876_36051(f_10030_35890_35963(), nameof(compoundAssignment)), nameof(compoundAssignment));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 35600, 36141);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 35326, 36152);

                System.ArgumentNullException
                f_10030_35515_35568(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 35515, 35568);
                    return return_v;
                }


                string
                f_10030_35604_35631(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Language;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10030, 35604, 35631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IConvertibleConversion
                f_10030_35708_35781(Microsoft.CodeAnalysis.Operations.CompoundAssignmentOperation
                this_param)
                {
                    var return_v = this_param.InConversionConvertible;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10030, 35708, 35781);
                    return return_v;
                }


                string
                f_10030_35890_35963()
                {
                    var return_v = CSharpResources.ICompoundAssignmentOperationIsNotCSharpCompoundAssignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10030, 35890, 35963);
                    return return_v;
                }


                string
                f_10030_35876_36051(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 35876, 36051);
                    return return_v;
                }


                System.ArgumentException
                f_10030_35854_36125(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 35854, 36125);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 35326, 36152);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 35326, 36152);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Conversion GetOutConversion(this ICompoundAssignmentOperation compoundAssignment)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 36604, 37432);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 36724, 36863) || true) && (compoundAssignment == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 36724, 36863);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 36788, 36848);

                    throw f_10030_36794_36847(nameof(compoundAssignment));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 36724, 36863);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 36879, 37421) || true) && (f_10030_36883_36910(compoundAssignment) == LanguageNames.CSharp)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 36879, 37421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 36968, 37062);

                    return (Conversion)f_10030_36987_37061(((CompoundAssignmentOperation)compoundAssignment));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 36879, 37421);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 36879, 37421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 37128, 37406);

                    throw f_10030_37134_37405(f_10030_37156_37331(f_10030_37170_37243(), nameof(compoundAssignment)), nameof(compoundAssignment));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 36879, 37421);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 36604, 37432);

                System.ArgumentNullException
                f_10030_36794_36847(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 36794, 36847);
                    return return_v;
                }


                string
                f_10030_36883_36910(Microsoft.CodeAnalysis.Operations.ICompoundAssignmentOperation
                this_param)
                {
                    var return_v = this_param.Language;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10030, 36883, 36910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Operations.IConvertibleConversion
                f_10030_36987_37061(Microsoft.CodeAnalysis.Operations.CompoundAssignmentOperation
                this_param)
                {
                    var return_v = this_param.OutConversionConvertible;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10030, 36987, 37061);
                    return return_v;
                }


                string
                f_10030_37170_37243()
                {
                    var return_v = CSharpResources.ICompoundAssignmentOperationIsNotCSharpCompoundAssignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10030, 37170, 37243);
                    return return_v;
                }


                string
                f_10030_37156_37331(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 37156, 37331);
                    return return_v;
                }


                System.ArgumentException
                f_10030_37134_37405(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 37134, 37405);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 36604, 37432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 36604, 37432);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Conversion GetSpeculativeConversion(this SemanticModel? semanticModel, int position, ExpressionSyntax expression, SpeculativeBindingOption bindingOption)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 37444, 37954);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 37636, 37687);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 37701, 37943) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 37701, 37943);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 37754, 37831);

                    return f_10030_37761_37830(csmodel, position, expression, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 37701, 37943);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 37701, 37943);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 37897, 37928);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 37701, 37943);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 37444, 37954);

                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10030_37761_37830(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption)
                {
                    var return_v = this_param.GetSpeculativeConversion(position, expression, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 37761, 37830);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 37444, 37954);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 37444, 37954);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ForEachStatementInfo GetForEachStatementInfo(this SemanticModel? semanticModel, ForEachStatementSyntax forEachStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 37966, 38429);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 38125, 38176);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 38190, 38418) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 38190, 38418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 38243, 38300);

                    return f_10030_38250_38299(csmodel, forEachStatement);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 38190, 38418);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 38190, 38418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 38366, 38403);

                    return default(ForEachStatementInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 38190, 38418);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 37966, 38429);

                Microsoft.CodeAnalysis.CSharp.ForEachStatementInfo
                f_10030_38250_38299(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
                node)
                {
                    var return_v = this_param.GetForEachStatementInfo(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 38250, 38299);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 37966, 38429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 37966, 38429);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ForEachStatementInfo GetForEachStatementInfo(this SemanticModel? semanticModel, CommonForEachStatementSyntax forEachStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 38441, 38910);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 38606, 38657);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 38671, 38899) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 38671, 38899);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 38724, 38781);

                    return f_10030_38731_38780(csmodel, forEachStatement);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 38671, 38899);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 38671, 38899);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 38847, 38884);

                    return default(ForEachStatementInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 38671, 38899);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 38441, 38910);

                Microsoft.CodeAnalysis.CSharp.ForEachStatementInfo
                f_10030_38731_38780(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                node)
                {
                    var return_v = this_param.GetForEachStatementInfo(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 38731, 38780);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 38441, 38910);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 38441, 38910);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static DeconstructionInfo GetDeconstructionInfo(this SemanticModel? semanticModel, AssignmentExpressionSyntax assignment)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 38922, 39192);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 39075, 39181);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10030, 39082, 39126) || ((semanticModel is CSharpSemanticModel csmodel && DynAbs.Tracing.TraceSender.Conditional_F2(10030, 39129, 39170)) || DynAbs.Tracing.TraceSender.Conditional_F3(10030, 39173, 39180))) ? f_10030_39129_39170((CSharpSemanticModel)semanticModel, assignment) : default;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 38922, 39192);

                Microsoft.CodeAnalysis.CSharp.DeconstructionInfo
                f_10030_39129_39170(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                node)
                {
                    var return_v = this_param.GetDeconstructionInfo(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 39129, 39170);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 38922, 39192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 38922, 39192);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static DeconstructionInfo GetDeconstructionInfo(this SemanticModel? semanticModel, ForEachVariableStatementSyntax @foreach)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 39204, 39474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 39359, 39463);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10030, 39366, 39410) || ((semanticModel is CSharpSemanticModel csmodel && DynAbs.Tracing.TraceSender.Conditional_F2(10030, 39413, 39452)) || DynAbs.Tracing.TraceSender.Conditional_F3(10030, 39455, 39462))) ? f_10030_39413_39452((CSharpSemanticModel)semanticModel, @foreach) : default;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 39204, 39474);

                Microsoft.CodeAnalysis.CSharp.DeconstructionInfo
                f_10030_39413_39452(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ForEachVariableStatementSyntax
                node)
                {
                    var return_v = this_param.GetDeconstructionInfo(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 39413, 39452);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 39204, 39474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 39204, 39474);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AwaitExpressionInfo GetAwaitExpressionInfo(this SemanticModel? semanticModel, AwaitExpressionSyntax awaitExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 39486, 39942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 39641, 39692);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 39706, 39931) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 39706, 39931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 39759, 39814);

                    return f_10030_39766_39813(csmodel, awaitExpression);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 39706, 39931);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 39706, 39931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 39880, 39916);

                    return default(AwaitExpressionInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 39706, 39931);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 39486, 39942);

                Microsoft.CodeAnalysis.CSharp.AwaitExpressionInfo
                f_10030_39766_39813(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax
                node)
                {
                    var return_v = this_param.GetAwaitExpressionInfo(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 39766, 39813);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 39486, 39942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 39486, 39942);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<ISymbol> GetMemberGroup(this SemanticModel? semanticModel, ExpressionSyntax expression, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 39954, 40472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 40161, 40212);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 40226, 40461) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 40226, 40461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 40279, 40340);

                    return f_10030_40286_40339(csmodel, expression, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 40226, 40461);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 40226, 40461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 40406, 40446);

                    return f_10030_40413_40445();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 40226, 40461);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 39954, 40472);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10030_40286_40339(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetMemberGroup(expression, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 40286, 40339);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10030_40413_40445()
                {
                    var return_v = ImmutableArray.Create<ISymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 40413, 40445);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 39954, 40472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 39954, 40472);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<ISymbol> GetMemberGroup(this SemanticModel? semanticModel, AttributeSyntax attribute, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 40484, 40999);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 40689, 40740);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 40754, 40988) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 40754, 40988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 40807, 40867);

                    return f_10030_40814_40866(csmodel, attribute, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 40754, 40988);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 40754, 40988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 40933, 40973);

                    return f_10030_40940_40972();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 40754, 40988);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 40484, 40999);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10030_40814_40866(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attribute, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetMemberGroup(attribute, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 40814, 40866);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10030_40940_40972()
                {
                    var return_v = ImmutableArray.Create<ISymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 40940, 40972);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 40484, 40999);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 40484, 40999);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<ISymbol> GetMemberGroup(this SemanticModel? semanticModel, ConstructorInitializerSyntax initializer, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 41011, 41543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 41231, 41282);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 41296, 41532) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 41296, 41532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 41349, 41411);

                    return f_10030_41356_41410(csmodel, initializer, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 41296, 41532);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 41296, 41532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 41477, 41517);

                    return f_10030_41484_41516();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 41296, 41532);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 41011, 41543);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10030_41356_41410(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                initializer, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetMemberGroup(initializer, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 41356, 41410);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10030_41484_41516()
                {
                    var return_v = ImmutableArray.Create<ISymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 41484, 41516);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 41011, 41543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 41011, 41543);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<IPropertySymbol> GetIndexerGroup(this SemanticModel? semanticModel, ExpressionSyntax expression, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 41728, 42264);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 41944, 41995);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 42009, 42253) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 42009, 42253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 42062, 42124);

                    return f_10030_42069_42123(csmodel, expression, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 42009, 42253);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 42009, 42253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 42190, 42238);

                    return f_10030_42197_42237();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 42009, 42253);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 41728, 42264);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IPropertySymbol>
                f_10030_42069_42123(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetIndexerGroup(expression, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 42069, 42123);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IPropertySymbol>
                f_10030_42197_42237()
                {
                    var return_v = ImmutableArray.Create<IPropertySymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 42197, 42237);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 41728, 42264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 41728, 42264);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Optional<object> GetConstantValue(this SemanticModel? semanticModel, ExpressionSyntax expression, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 42276, 42784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 42478, 42529);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 42543, 42773) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 42543, 42773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 42596, 42659);

                    return f_10030_42603_42658(csmodel, expression, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 42543, 42773);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 42543, 42773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 42725, 42758);

                    return default(Optional<object>);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 42543, 42773);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 42276, 42784);

                Microsoft.CodeAnalysis.Optional<object>
                f_10030_42603_42658(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetConstantValue(expression, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 42603, 42658);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 42276, 42784);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 42276, 42784);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static QueryClauseInfo GetQueryClauseInfo(this SemanticModel? semanticModel, QueryClauseSyntax node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 42918, 43417);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 43116, 43167);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 43181, 43406) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 43181, 43406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 43234, 43293);

                    return f_10030_43241_43292(csmodel, node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 43181, 43406);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 43181, 43406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 43359, 43391);

                    return default(QueryClauseInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 43181, 43406);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 42918, 43417);

                Microsoft.CodeAnalysis.CSharp.QueryClauseInfo
                f_10030_43241_43292(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetQueryClauseInfo(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 43241, 43292);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 42918, 43417);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 42918, 43417);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IAliasSymbol? GetAliasInfo(this SemanticModel? semanticModel, IdentifierNameSyntax nameSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 43628, 43963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 43827, 43878);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 43892, 43952);

                return f_10030_43907_43951(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 43899, 43951), nameSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 43628, 43963);

                Microsoft.CodeAnalysis.IAliasSymbol?
                f_10030_43907_43951(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                nameSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetAliasInfo(nameSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 43907, 43951);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 43628, 43963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 43628, 43963);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IAliasSymbol? GetSpeculativeAliasInfo(this SemanticModel? semanticModel, int position, IdentifierNameSyntax nameSyntax, SpeculativeBindingOption bindingOption)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 44226, 44577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 44424, 44475);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 44489, 44566);

                return f_10030_44504_44565(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 44496, 44565), position, nameSyntax, bindingOption);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 44226, 44577);

                Microsoft.CodeAnalysis.IAliasSymbol?
                f_10030_44504_44565(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                nameSyntax, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption)
                {
                    var return_v = this_param?.GetSpeculativeAliasInfo(position, nameSyntax, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 44504, 44565);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 44226, 44577);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 44226, 44577);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ControlFlowAnalysis? AnalyzeControlFlow(this SemanticModel? semanticModel, StatementSyntax firstStatement, StatementSyntax lastStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 44702, 45020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 44878, 44929);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 44943, 45009);

                return f_10030_44958_45008(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 44950, 45008), firstStatement, lastStatement);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 44702, 45020);

                Microsoft.CodeAnalysis.ControlFlowAnalysis?
                f_10030_44958_45008(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                firstStatement, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                lastStatement)
                {
                    var return_v = this_param?.AnalyzeControlFlow(firstStatement, lastStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 44958, 45008);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 44702, 45020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 44702, 45020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ControlFlowAnalysis? AnalyzeControlFlow(this SemanticModel? semanticModel, StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 45145, 45407);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 45285, 45336);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 45350, 45396);

                return f_10030_45365_45395(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 45357, 45395), statement);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 45145, 45407);

                Microsoft.CodeAnalysis.ControlFlowAnalysis?
                f_10030_45365_45395(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement)
                {
                    var return_v = this_param?.AnalyzeControlFlow(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 45365, 45395);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 45145, 45407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 45145, 45407);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static DataFlowAnalysis? AnalyzeDataFlow(this SemanticModel? semanticModel, ExpressionSyntax expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 45519, 45775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 45655, 45706);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 45720, 45764);

                return f_10030_45735_45763(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 45727, 45763), expression);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 45519, 45775);

                Microsoft.CodeAnalysis.DataFlowAnalysis?
                f_10030_45735_45763(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    var return_v = this_param?.AnalyzeDataFlow(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 45735, 45763);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 45519, 45775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 45519, 45775);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static DataFlowAnalysis? AnalyzeDataFlow(this SemanticModel? semanticModel, StatementSyntax firstStatement, StatementSyntax lastStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 45897, 46206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 46067, 46118);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 46132, 46195);

                return f_10030_46147_46194(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 46139, 46194), firstStatement, lastStatement);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 45897, 46206);

                Microsoft.CodeAnalysis.DataFlowAnalysis?
                f_10030_46147_46194(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                firstStatement, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                lastStatement)
                {
                    var return_v = this_param?.AnalyzeDataFlow(firstStatement, lastStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 46147, 46194);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 45897, 46206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 45897, 46206);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static DataFlowAnalysis? AnalyzeDataFlow(this SemanticModel? semanticModel, StatementSyntax statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 46328, 46581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 46462, 46513);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 46527, 46570);

                return f_10030_46542_46569(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 46534, 46569), statement);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 46328, 46581);

                Microsoft.CodeAnalysis.DataFlowAnalysis?
                f_10030_46542_46569(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement)
                {
                    var return_v = this_param?.AnalyzeDataFlow(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 46542, 46569);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 46328, 46581);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 46328, 46581);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryGetSpeculativeSemanticModelForMethodBody([NotNullWhen(true)] this SemanticModel? semanticModel, int position, BaseMethodDeclarationSyntax method, [NotNullWhen(true)] out SemanticModel? speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 47032, 47645);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 47281, 47332);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 47346, 47634) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 47346, 47634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 47399, 47498);

                    return f_10030_47406_47497(csmodel, position, method, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 47346, 47634);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 47346, 47634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 47564, 47588);

                    speculativeModel = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 47606, 47619);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 47346, 47634);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 47032, 47645);

                bool
                f_10030_47406_47497(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                method, out Microsoft.CodeAnalysis.SemanticModel?
                speculativeModel)
                {
                    var return_v = this_param.TryGetSpeculativeSemanticModelForMethodBody(position, method, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 47406, 47497);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 47032, 47645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 47032, 47645);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryGetSpeculativeSemanticModelForMethodBody([NotNullWhen(true)] this SemanticModel? semanticModel, int position, AccessorDeclarationSyntax accessor, [NotNullWhen(true)] out SemanticModel? speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 48096, 48711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 48345, 48396);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 48410, 48700) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 48410, 48700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 48463, 48564);

                    return f_10030_48470_48563(csmodel, position, accessor, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 48410, 48700);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 48410, 48700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 48630, 48654);

                    speculativeModel = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 48672, 48685);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 48410, 48700);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 48096, 48711);

                bool
                f_10030_48470_48563(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                accessor, out Microsoft.CodeAnalysis.SemanticModel?
                speculativeModel)
                {
                    var return_v = this_param.TryGetSpeculativeSemanticModelForMethodBody(position, accessor, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 48470, 48563);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 48096, 48711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 48096, 48711);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryGetSpeculativeSemanticModel([NotNullWhen(true)] this SemanticModel? semanticModel, int position, TypeSyntax type, [NotNullWhen(true)] out SemanticModel? speculativeModel, SpeculativeBindingOption bindingOption = SpeculativeBindingOption.BindAsExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 49043, 49708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 49344, 49395);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 49409, 49697) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 49409, 49697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 49462, 49561);

                    return f_10030_49469_49560(csmodel, position, type, out speculativeModel, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 49409, 49697);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 49409, 49697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 49627, 49651);

                    speculativeModel = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 49669, 49682);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 49409, 49697);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 49043, 49708);

                bool
                f_10030_49469_49560(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type, out Microsoft.CodeAnalysis.SemanticModel?
                speculativeModel, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption)
                {
                    var return_v = this_param.TryGetSpeculativeSemanticModel(position, type, out speculativeModel, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 49469, 49560);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 49043, 49708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 49043, 49708);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryGetSpeculativeSemanticModel([NotNullWhen(true)] this SemanticModel? semanticModel, int position, CrefSyntax crefSyntax, [NotNullWhen(true)] out SemanticModel? speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 50040, 50618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 50263, 50314);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 50328, 50607) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 50328, 50607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 50381, 50471);

                    return f_10030_50388_50470(csmodel, position, crefSyntax, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 50328, 50607);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 50328, 50607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 50537, 50561);

                    speculativeModel = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 50579, 50592);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 50328, 50607);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 50040, 50618);

                bool
                f_10030_50388_50470(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                crefSyntax, out Microsoft.CodeAnalysis.SemanticModel?
                speculativeModel)
                {
                    var return_v = this_param.TryGetSpeculativeSemanticModel(position, crefSyntax, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 50388, 50470);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 50040, 50618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 50040, 50618);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryGetSpeculativeSemanticModel([NotNullWhen(true)] this SemanticModel? semanticModel, int position, StatementSyntax statement, [NotNullWhen(true)] out SemanticModel? speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 50941, 51522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 51168, 51219);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 51233, 51511) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 51233, 51511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 51286, 51375);

                    return f_10030_51293_51374(csmodel, position, statement, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 51233, 51511);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 51233, 51511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 51441, 51465);

                    speculativeModel = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 51483, 51496);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 51233, 51511);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 50941, 51522);

                bool
                f_10030_51293_51374(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement, out Microsoft.CodeAnalysis.SemanticModel?
                speculativeModel)
                {
                    var return_v = this_param.TryGetSpeculativeSemanticModel(position, statement, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 51293, 51374);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 50941, 51522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 50941, 51522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryGetSpeculativeSemanticModel([NotNullWhen(true)] this SemanticModel? semanticModel, int position, EqualsValueClauseSyntax initializer, [NotNullWhen(true)] out SemanticModel? speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 51883, 52476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 52120, 52171);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 52185, 52465) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 52185, 52465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 52238, 52329);

                    return f_10030_52245_52328(csmodel, position, initializer, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 52185, 52465);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 52185, 52465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 52395, 52419);

                    speculativeModel = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 52437, 52450);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 52185, 52465);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 51883, 52476);

                bool
                f_10030_52245_52328(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                initializer, out Microsoft.CodeAnalysis.SemanticModel?
                speculativeModel)
                {
                    var return_v = this_param.TryGetSpeculativeSemanticModel(position, initializer, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 52245, 52328);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 51883, 52476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 51883, 52476);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryGetSpeculativeSemanticModel([NotNullWhen(true)] this SemanticModel? semanticModel, int position, ArrowExpressionClauseSyntax expressionBody, [NotNullWhen(true)] out SemanticModel? speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 52813, 53416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 53057, 53108);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 53122, 53405) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 53122, 53405);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 53175, 53269);

                    return f_10030_53182_53268(csmodel, position, expressionBody, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 53122, 53405);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 53122, 53405);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 53335, 53359);

                    speculativeModel = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 53377, 53390);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 53122, 53405);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 52813, 53416);

                bool
                f_10030_53182_53268(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                expressionBody, out Microsoft.CodeAnalysis.SemanticModel?
                speculativeModel)
                {
                    var return_v = this_param.TryGetSpeculativeSemanticModel(position, expressionBody, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 53182, 53268);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 52813, 53416);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 52813, 53416);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryGetSpeculativeSemanticModel([NotNullWhen(true)] this SemanticModel? semanticModel, int position, ConstructorInitializerSyntax constructorInitializer, [NotNullWhen(true)] out SemanticModel? speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 53882, 54502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 54135, 54186);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 54200, 54491) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 54200, 54491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 54253, 54355);

                    return f_10030_54260_54354(csmodel, position, constructorInitializer, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 54200, 54491);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 54200, 54491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 54421, 54445);

                    speculativeModel = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 54463, 54476);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 54200, 54491);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 53882, 54502);

                bool
                f_10030_54260_54354(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                constructorInitializer, out Microsoft.CodeAnalysis.SemanticModel?
                speculativeModel)
                {
                    var return_v = this_param.TryGetSpeculativeSemanticModel(position, constructorInitializer, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 54260, 54354);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 53882, 54502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 53882, 54502);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryGetSpeculativeSemanticModel([NotNullWhen(true)] this SemanticModel? semanticModel, int position, PrimaryConstructorBaseTypeSyntax constructorInitializer, [NotNullWhen(true)] out SemanticModel? speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 54968, 55592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 55225, 55276);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 55290, 55581) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 55290, 55581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 55343, 55445);

                    return f_10030_55350_55444(csmodel, position, constructorInitializer, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 55290, 55581);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 55290, 55581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 55511, 55535);

                    speculativeModel = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 55553, 55566);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 55290, 55581);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 54968, 55592);

                bool
                f_10030_55350_55444(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax
                constructorInitializer, out Microsoft.CodeAnalysis.SemanticModel?
                speculativeModel)
                {
                    var return_v = this_param.TryGetSpeculativeSemanticModel(position, constructorInitializer, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 55350, 55444);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 54968, 55592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 54968, 55592);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryGetSpeculativeSemanticModel([NotNullWhen(true)] this SemanticModel? semanticModel, int position, AttributeSyntax attribute, [NotNullWhen(true)] out SemanticModel? speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 55917, 56498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 56144, 56195);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 56209, 56487) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 56209, 56487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 56262, 56351);

                    return f_10030_56269_56350(csmodel, position, attribute, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 56209, 56487);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 56209, 56487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 56417, 56441);

                    speculativeModel = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 56459, 56472);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 56209, 56487);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 55917, 56498);

                bool
                f_10030_56269_56350(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attribute, out Microsoft.CodeAnalysis.SemanticModel?
                speculativeModel)
                {
                    var return_v = this_param.TryGetSpeculativeSemanticModel(position, attribute, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 56269, 56350);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 55917, 56498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 55917, 56498);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Conversion ClassifyConversion(this SemanticModel? semanticModel, ExpressionSyntax expression, ITypeSymbol destination, bool isExplicitInSource = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 56842, 57352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 57032, 57083);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 57097, 57341) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 57097, 57341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 57150, 57229);

                    return f_10030_57157_57228(csmodel, expression, destination, isExplicitInSource);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 57097, 57341);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 57097, 57341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 57295, 57326);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 57097, 57341);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 56842, 57352);

                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10030_57157_57228(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.ITypeSymbol
                destination, bool
                isExplicitInSource)
                {
                    var return_v = this_param.ClassifyConversion(expression, destination, isExplicitInSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 57157, 57228);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 56842, 57352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 56842, 57352);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Conversion ClassifyConversion(this SemanticModel? semanticModel, int position, ExpressionSyntax expression, ITypeSymbol destination, bool isExplicitInSource = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 57696, 58230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 57900, 57951);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 57965, 58219) || true) && (csmodel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 57965, 58219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 58018, 58107);

                    return f_10030_58025_58106(csmodel, position, expression, destination, isExplicitInSource);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 57965, 58219);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10030, 57965, 58219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 58173, 58204);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10030, 57965, 58219);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 57696, 58230);

                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10030_58025_58106(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.ITypeSymbol
                destination, bool
                isExplicitInSource)
                {
                    var return_v = this_param.ClassifyConversion(position, expression, destination, isExplicitInSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 58025, 58106);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 57696, 58230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 57696, 58230);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ISymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, MemberDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 58367, 58724);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 58576, 58627);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 58641, 58713);

                return f_10030_58656_58712(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 58648, 58712), declarationSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 58367, 58724);

                Microsoft.CodeAnalysis.ISymbol?
                f_10030_58656_58712(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 58656, 58712);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 58367, 58724);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 58367, 58724);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IMethodSymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, CompilationUnitSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 58886, 59247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 59099, 59150);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 59164, 59236);

                return f_10030_59179_59235(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 59171, 59235), declarationSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 58886, 59247);

                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10030_59179_59235(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 59179, 59235);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 58886, 59247);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 58886, 59247);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static INamespaceSymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, NamespaceDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 59444, 59813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 59665, 59716);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 59730, 59802);

                return f_10030_59745_59801(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 59737, 59801), declarationSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 59444, 59813);

                Microsoft.CodeAnalysis.INamespaceSymbol?
                f_10030_59745_59801(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 59745, 59801);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 59444, 59813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 59444, 59813);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static INamedTypeSymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, BaseTypeDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 59946, 60314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 60166, 60217);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 60231, 60303);

                return f_10030_60246_60302(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 60238, 60302), declarationSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 59946, 60314);

                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_10030_60246_60302(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 60246, 60302);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 59946, 60314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 59946, 60314);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static INamedTypeSymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, DelegateDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 60451, 60819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 60671, 60722);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 60736, 60808);

                return f_10030_60751_60807(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 60743, 60807), declarationSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 60451, 60819);

                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_10030_60751_60807(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 60751, 60807);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 60451, 60819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 60451, 60819);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IFieldSymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, EnumMemberDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 60960, 61326);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 61178, 61229);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 61243, 61315);

                return f_10030_61258_61314(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 61250, 61314), declarationSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 60960, 61326);

                Microsoft.CodeAnalysis.IFieldSymbol?
                f_10030_61258_61314(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 61258, 61314);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 60960, 61326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 60960, 61326);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IMethodSymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, BaseMethodDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 61475, 61842);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 61694, 61745);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 61759, 61831);

                return f_10030_61774_61830(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 61766, 61830), declarationSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 61475, 61842);

                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10030_61774_61830(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 61774, 61830);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 61475, 61842);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 61475, 61842);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ISymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, BasePropertyDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 62020, 62383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 62235, 62286);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 62300, 62372);

                return f_10030_62315_62371(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 62307, 62371), declarationSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 62020, 62383);

                Microsoft.CodeAnalysis.ISymbol?
                f_10030_62315_62371(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 62315, 62371);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 62020, 62383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 62020, 62383);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IPropertySymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, PropertyDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 62540, 62907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 62759, 62810);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 62824, 62896);

                return f_10030_62839_62895(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 62831, 62895), declarationSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 62540, 62907);

                Microsoft.CodeAnalysis.IPropertySymbol?
                f_10030_62839_62895(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 62839, 62895);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 62540, 62907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 62540, 62907);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IPropertySymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, IndexerDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 63064, 63430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 63282, 63333);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 63347, 63419);

                return f_10030_63362_63418(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 63354, 63418), declarationSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 63064, 63430);

                Microsoft.CodeAnalysis.IPropertySymbol?
                f_10030_63362_63418(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 63362, 63418);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 63064, 63430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 63064, 63430);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEventSymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, EventDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 63590, 63951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 63803, 63854);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 63868, 63940);

                return f_10030_63883_63939(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 63875, 63939), declarationSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 63590, 63951);

                Microsoft.CodeAnalysis.IEventSymbol?
                f_10030_63883_63939(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 63883, 63939);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 63590, 63951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 63590, 63951);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IPropertySymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, AnonymousObjectMemberDeclaratorSyntax declaratorSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 64127, 64504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 64357, 64408);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 64422, 64493);

                return f_10030_64437_64492(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 64429, 64492), declaratorSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 64127, 64504);

                Microsoft.CodeAnalysis.IPropertySymbol?
                f_10030_64437_64492(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax
                declaratorSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declaratorSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 64437, 64492);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 64127, 64504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 64127, 64504);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static INamedTypeSymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, AnonymousObjectCreationExpressionSyntax declaratorSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 64675, 65055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 64908, 64959);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 64973, 65044);

                return f_10030_64988_65043(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 64980, 65043), declaratorSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 64675, 65055);

                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_10030_64988_65043(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax
                declaratorSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declaratorSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 64988, 65043);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 64675, 65055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 64675, 65055);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static INamedTypeSymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, TupleExpressionSyntax declaratorSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 65195, 65557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 65410, 65461);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 65475, 65546);

                return f_10030_65490_65545(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 65482, 65545), declaratorSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 65195, 65557);

                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_10030_65490_65545(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TupleExpressionSyntax
                declaratorSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declaratorSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 65490, 65545);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 65195, 65557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 65195, 65557);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ISymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, ArgumentSyntax declaratorSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 65700, 66046);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 65899, 65950);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 65964, 66035);

                return f_10030_65979_66034(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 65971, 66034), declaratorSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 65700, 66046);

                Microsoft.CodeAnalysis.ISymbol?
                f_10030_65979_66034(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                declaratorSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declaratorSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 65979, 66034);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 65700, 66046);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 65700, 66046);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IMethodSymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, AccessorDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 66213, 66578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 66430, 66481);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 66495, 66567);

                return f_10030_66510_66566(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 66502, 66566), declarationSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 66213, 66578);

                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10030_66510_66566(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 66510, 66566);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 66213, 66578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 66213, 66578);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ISymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, SingleVariableDesignationSyntax designationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 66716, 67081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 66933, 66984);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 66998, 67070);

                return f_10030_67013_67069(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 67005, 67069), designationSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 66716, 67081);

                Microsoft.CodeAnalysis.ISymbol?
                f_10030_67013_67069(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 67013, 67069);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 66716, 67081);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 66716, 67081);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ISymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, VariableDeclaratorSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 67219, 67577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 67429, 67480);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 67494, 67566);

                return f_10030_67509_67565(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 67501, 67565), declarationSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 67219, 67577);

                Microsoft.CodeAnalysis.ISymbol?
                f_10030_67509_67565(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 67509, 67565);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 67219, 67577);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 67219, 67577);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ISymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, TupleElementSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 67709, 68061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 67913, 67964);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 67978, 68050);

                return f_10030_67993_68049(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 67985, 68049), declarationSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 67709, 68061);

                Microsoft.CodeAnalysis.ISymbol?
                f_10030_67993_68049(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TupleElementSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 67993, 68049);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 67709, 68061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 67709, 68061);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ILabelSymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, LabeledStatementSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 68203, 68564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 68416, 68467);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 68481, 68553);

                return f_10030_68496_68552(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 68488, 68552), declarationSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 68203, 68564);

                Microsoft.CodeAnalysis.ILabelSymbol?
                f_10030_68496_68552(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 68496, 68552);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 68203, 68564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 68203, 68564);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ILabelSymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, SwitchLabelSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 68701, 69057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 68909, 68960);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 68974, 69046);

                return f_10030_68989_69045(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 68981, 69045), declarationSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 68701, 69057);

                Microsoft.CodeAnalysis.ILabelSymbol?
                f_10030_68989_69045(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 68989, 69045);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 68701, 69057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 68701, 69057);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IAliasSymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, UsingDirectiveSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 69225, 69584);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 69436, 69487);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 69501, 69573);

                return f_10030_69516_69572(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 69508, 69572), declarationSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 69225, 69584);

                Microsoft.CodeAnalysis.IAliasSymbol?
                f_10030_69516_69572(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 69516, 69572);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 69225, 69584);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 69225, 69584);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IAliasSymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, ExternAliasDirectiveSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 69754, 70119);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 69971, 70022);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 70036, 70108);

                return f_10030_70051_70107(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 70043, 70107), declarationSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 69754, 70119);

                Microsoft.CodeAnalysis.IAliasSymbol?
                f_10030_70051_70107(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 70051, 70107);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 69754, 70119);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 69754, 70119);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IParameterSymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, ParameterSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 70264, 70622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 70474, 70525);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 70539, 70611);

                return f_10030_70554_70610(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 70546, 70610), declarationSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 70264, 70622);

                Microsoft.CodeAnalysis.IParameterSymbol?
                f_10030_70554_70610(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 70554, 70610);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 70264, 70622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 70264, 70622);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ITypeParameterSymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, TypeParameterSyntax typeParameter, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 70777, 71135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 70991, 71042);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 71056, 71124);

                return f_10030_71071_71123(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 71063, 71123), typeParameter, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 70777, 71135);

                Microsoft.CodeAnalysis.ITypeParameterSymbol?
                f_10030_71071_71123(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax
                typeParameter, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(typeParameter, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 71071, 71123);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 70777, 71135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 70777, 71135);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ILocalSymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, ForEachStatementSyntax forEachStatement, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 71276, 71635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 71488, 71539);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 71553, 71624);

                return f_10030_71568_71623(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 71560, 71623), forEachStatement, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 71276, 71635);

                Microsoft.CodeAnalysis.ILocalSymbol?
                f_10030_71568_71623(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
                forEachStatement, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(forEachStatement, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 71568, 71623);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 71276, 71635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 71276, 71635);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ILocalSymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, CatchDeclarationSyntax catchDeclaration, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 71776, 72135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 71988, 72039);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 72053, 72124);

                return f_10030_72068_72123(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 72060, 72123), catchDeclaration, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 71776, 72135);

                Microsoft.CodeAnalysis.ILocalSymbol?
                f_10030_72068_72123(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax
                catchDeclaration, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(catchDeclaration, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 72068, 72123);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 71776, 72135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 71776, 72135);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IRangeVariableSymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, QueryClauseSyntax queryClause, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 72147, 72499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 72357, 72408);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 72422, 72488);

                return f_10030_72437_72487(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 72429, 72487), queryClause, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 72147, 72499);

                Microsoft.CodeAnalysis.IRangeVariableSymbol?
                f_10030_72437_72487(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                queryClause, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(queryClause, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 72437, 72487);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 72147, 72499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 72147, 72499);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IRangeVariableSymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, JoinIntoClauseSyntax node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 72632, 72973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 72838, 72889);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 72903, 72962);

                return f_10030_72918_72961(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 72910, 72961), node, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 72632, 72973);

                Microsoft.CodeAnalysis.IRangeVariableSymbol?
                f_10030_72918_72961(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 72918, 72961);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 72632, 72973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 72632, 72973);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IRangeVariableSymbol? GetDeclaredSymbol(this SemanticModel? semanticModel, QueryContinuationSyntax node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10030, 73115, 73459);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 73324, 73375);

                var
                csmodel = semanticModel as CSharpSemanticModel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10030, 73389, 73448);

                return f_10030_73404_73447(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(csmodel, 10030, 73396, 73447), node, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10030, 73115, 73459);

                Microsoft.CodeAnalysis.IRangeVariableSymbol?
                f_10030_73404_73447(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param?.GetDeclaredSymbol(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10030, 73404, 73447);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10030, 73115, 73459);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 73115, 73459);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CSharpExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10030, 7238, 73486);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10030, 7238, 73486);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10030, 7238, 73486);
        }

    }
}
