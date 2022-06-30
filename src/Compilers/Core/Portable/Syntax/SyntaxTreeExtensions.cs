// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    internal static class SyntaxTreeExtensions
    {
        [Conditional("DEBUG")]
        internal static void VerifySource(this SyntaxTree tree, IEnumerable<TextChangeRange>? changes = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(704, 555, 3060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 713, 739);

                var
                root = f_704_724_738(tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 753, 779);

                var
                text = f_704_764_778(tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 793, 837);

                var
                fullSpan = f_704_808_836(0, f_704_824_835(text))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 851, 875);

                SyntaxNode?
                node = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 1021, 1411) || true) && (changes != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(704, 1021, 1411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 1074, 1126);

                    var
                    change = TextChangeRange.Collapse(changes).Span
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 1144, 1396) || true) && (change != fullSpan)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(704, 1144, 1396);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 1299, 1377);

                        node = f_704_1306_1376(f_704_1306_1360(root, n => n.FullSpan.Contains(change)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(704, 1144, 1396);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(704, 1021, 1411);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 1427, 1504) || true) && (node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(704, 1427, 1504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 1477, 1489);

                    node = root;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(704, 1427, 1504);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 1520, 1545);

                var
                span = f_704_1531_1544(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 1559, 1605);

                var
                textSpanOpt = span.Intersection(fullSpan)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 1619, 1629);

                int
                index
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 1643, 1664);

                char
                found = default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 1678, 1702);

                char
                expected = default
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 1716, 2197) || true) && (textSpanOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(704, 1716, 2197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 1773, 1783);

                    index = 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(704, 1716, 2197);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(704, 1716, 2197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 1849, 1897);

                    var
                    fromText = f_704_1864_1896(text, textSpanOpt.Value)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 1915, 1950);

                    var
                    fromNode = f_704_1930_1949(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 1968, 2016);

                    index = f_704_1976_2015(fromText, fromNode);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 2034, 2182) || true) && (index >= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(704, 2034, 2182);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 2090, 2114);

                        found = f_704_2098_2113(fromNode, index);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 2136, 2163);

                        expected = f_704_2147_2162(fromText, index);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(704, 2034, 2182);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(704, 1716, 2197);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 2213, 3049) || true) && (index >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(704, 2213, 3049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 2261, 2281);

                    index += span.Start;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 2299, 2314);

                    string
                    message
                    = default(string);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 2332, 2987) || true) && (index < f_704_2344_2355(text))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(704, 2332, 2987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 2397, 2446);

                        var
                        position = f_704_2412_2445(f_704_2412_2422(text), index)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 2468, 2505);

                        var
                        line = f_704_2479_2504(f_704_2479_2489(text), position.Line)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 2527, 2557);

                        var
                        allText = f_704_2541_2556(text)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 2654, 2831);

                        message = $"Unexpected difference at offset {index}: Line {position.Line + 1}, Column {position.Character + 1} \"{line.ToString()}\"  (Found: [{found}] Expected: [{expected}])";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(704, 2332, 2987);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(704, 2332, 2987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 2913, 2968);

                        message = "Unexpected difference past end of the file";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(704, 2332, 2987);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 3005, 3034);

                    f_704_3005_3033(false, message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(704, 2213, 3049);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(704, 555, 3060);

                Microsoft.CodeAnalysis.SyntaxNode
                f_704_724_738(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(704, 724, 738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_704_764_778(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(704, 764, 778);
                    return return_v;
                }


                int
                f_704_824_835(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(704, 824, 835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_704_808_836(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(704, 808, 836);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_704_1306_1360(Microsoft.CodeAnalysis.SyntaxNode
                this_param, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren)
                {
                    var return_v = this_param.DescendantNodes(descendIntoChildren);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(704, 1306, 1360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_704_1306_1376(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.LastOrDefault<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(704, 1306, 1376);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_704_1531_1544(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.FullSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(704, 1531, 1544);
                    return return_v;
                }


                string
                f_704_1864_1896(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.ToString(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(704, 1864, 1896);
                    return return_v;
                }


                string
                f_704_1930_1949(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(704, 1930, 1949);
                    return return_v;
                }


                int
                f_704_1976_2015(string
                s1, string
                s2)
                {
                    var return_v = FindFirstDifference(s1, s2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(704, 1976, 2015);
                    return return_v;
                }


                char
                f_704_2098_2113(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(704, 2098, 2113);
                    return return_v;
                }


                char
                f_704_2147_2162(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(704, 2147, 2162);
                    return return_v;
                }


                int
                f_704_2344_2355(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(704, 2344, 2355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextLineCollection
                f_704_2412_2422(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Lines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(704, 2412, 2422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.LinePosition
                f_704_2412_2445(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param, int
                position)
                {
                    var return_v = this_param.GetLinePosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(704, 2412, 2445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextLineCollection
                f_704_2479_2489(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Lines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(704, 2479, 2489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextLine
                f_704_2479_2504(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(704, 2479, 2504);
                    return return_v;
                }


                string
                f_704_2541_2556(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(704, 2541, 2556);
                    return return_v;
                }


                int
                f_704_3005_3033(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(704, 3005, 3033);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(704, 555, 3060);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(704, 555, 3060);
            }
        }

        private static int FindFirstDifference(string s1, string s2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(704, 3246, 3655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 3331, 3350);

                var
                n1 = f_704_3340_3349(s1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 3364, 3383);

                var
                n2 = f_704_3373_3382(s2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 3397, 3422);

                var
                n = f_704_3405_3421(n1, n2)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 3445, 3450);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 3436, 3599) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 3459, 3462)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(704, 3436, 3599))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(704, 3436, 3599);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 3496, 3584) || true) && (f_704_3500_3505(s1, i) != f_704_3509_3514(s2, i))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(704, 3496, 3584);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 3556, 3565);

                            return i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(704, 3496, 3584);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(704, 1, 164);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(704, 1, 164);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 3613, 3644);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(704, 3620, 3630) || (((n1 == n2) && DynAbs.Tracing.TraceSender.Conditional_F2(704, 3633, 3635)) || DynAbs.Tracing.TraceSender.Conditional_F3(704, 3638, 3643))) ? -1 : n + 1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(704, 3246, 3655);

                int
                f_704_3340_3349(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(704, 3340, 3349);
                    return return_v;
                }


                int
                f_704_3373_3382(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(704, 3373, 3382);
                    return return_v;
                }


                int
                f_704_3405_3421(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(704, 3405, 3421);
                    return return_v;
                }


                char
                f_704_3500_3505(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(704, 3500, 3505);
                    return return_v;
                }


                char
                f_704_3509_3514(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(704, 3509, 3514);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(704, 3246, 3655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(704, 3246, 3655);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsHiddenPosition(this SyntaxTree tree, int position, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(704, 3820, 4275);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 3963, 4053) || true) && (!f_704_3968_3991(tree))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(704, 3963, 4053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 4025, 4038);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(704, 3963, 4053);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 4069, 4142);

                var
                lineVisibility = f_704_4090_4141(tree, position, cancellationToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(704, 4156, 4264);

                return lineVisibility == LineVisibility.Hidden || (DynAbs.Tracing.TraceSender.Expression_False(704, 4163, 4263) || lineVisibility == LineVisibility.BeforeFirstLineDirective);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(704, 3820, 4275);

                bool
                f_704_3968_3991(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.HasHiddenRegions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(704, 3968, 3991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LineVisibility
                f_704_4090_4141(Microsoft.CodeAnalysis.SyntaxTree
                this_param, int
                position, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetLineVisibility(position, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(704, 4090, 4141);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(704, 3820, 4275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(704, 3820, 4275);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxTreeExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(704, 409, 4282);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(704, 409, 4282);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(704, 409, 4282);
        }

    }
}
