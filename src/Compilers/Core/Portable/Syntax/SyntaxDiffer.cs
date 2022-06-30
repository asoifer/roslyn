// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal class SyntaxDiffer
    {
        private const int
        InitialStackSize = 8
        ;

        private const int
        MaxSearchLength = 8
        ;

        private readonly Stack<SyntaxNodeOrToken> _oldNodes;

        private readonly Stack<SyntaxNodeOrToken> _newNodes;

        private readonly List<ChangeRecord> _changes;

        private readonly TextSpan _oldSpan;

        private readonly bool _computeNewText;

        private readonly HashSet<GreenNode> _nodeSimilaritySet;

        private readonly HashSet<string> _tokenTextSimilaritySet;

        private SyntaxDiffer(SyntaxNode oldNode, SyntaxNode newNode, bool computeNewText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(673, 1152, 1460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 612, 670);
                this._oldNodes = f_673_624_670(InitialStackSize); DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 723, 781);
                this._newNodes = f_673_735_781(InitialStackSize); DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 828, 863);
                this._changes = f_673_839_863(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 941, 956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 1003, 1048);
                this._nodeSimilaritySet = f_673_1024_1048(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 1092, 1139);
                this._tokenTextSimilaritySet = f_673_1118_1139(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 1258, 1301);

                f_673_1258_1300(_oldNodes, oldNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 1315, 1358);

                f_673_1315_1357(_newNodes, newNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 1374, 1402);

                _oldSpan = f_673_1385_1401(oldNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 1416, 1449);

                _computeNewText = computeNewText;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(673, 1152, 1460);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 1152, 1460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 1152, 1460);
            }
        }

        internal static IList<TextChange> GetTextChanges(SyntaxTree before, SyntaxTree after)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(673, 1577, 2241);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 1687, 2230) || true) && (before == after)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 1687, 2230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 1740, 1794);

                    return f_673_1747_1793();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 1687, 2230);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 1687, 2230);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 1828, 2230) || true) && (before == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 1828, 2230);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 1880, 1960);

                        return new[] { f_673_1895_1957(f_673_1910_1928(0, 0), f_673_1930_1956(f_673_1930_1945(after))) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 1828, 2230);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 1828, 2230);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 1994, 2230) || true) && (after == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 1994, 2230);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 2045, 2092);

                            throw f_673_2051_2091(nameof(after));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 1994, 2230);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 1994, 2230);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 2158, 2215);

                            return f_673_2165_2214(f_673_2180_2196(before), f_673_2198_2213(after));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 1994, 2230);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 1828, 2230);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 1687, 2230);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(673, 1577, 2241);

                System.Collections.Generic.IList<Microsoft.CodeAnalysis.Text.TextChange>
                f_673_1747_1793()
                {
                    var return_v = SpecializedCollections.EmptyList<TextChange>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 1747, 1793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_673_1910_1928(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 1910, 1928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_673_1930_1945(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 1930, 1945);
                    return return_v;
                }


                string
                f_673_1930_1956(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 1930, 1956);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextChange
                f_673_1895_1957(Microsoft.CodeAnalysis.Text.TextSpan
                span, string
                newText)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextChange(span, newText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 1895, 1957);
                    return return_v;
                }


                System.ArgumentNullException
                f_673_2051_2091(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 2051, 2091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_673_2180_2196(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 2180, 2196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_673_2198_2213(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 2198, 2213);
                    return return_v;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.Text.TextChange>
                f_673_2165_2214(Microsoft.CodeAnalysis.SyntaxNode
                oldNode, Microsoft.CodeAnalysis.SyntaxNode
                newNode)
                {
                    var return_v = GetTextChanges(oldNode, newNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 2165, 2214);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 1577, 2241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 1577, 2241);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IList<TextChange> GetTextChanges(SyntaxNode oldNode, SyntaxNode newNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(673, 2358, 2574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 2471, 2563);

                return f_673_2478_2562(f_673_2478_2534(oldNode, newNode, computeNewText: true));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(673, 2358, 2574);

                Microsoft.CodeAnalysis.SyntaxDiffer
                f_673_2478_2534(Microsoft.CodeAnalysis.SyntaxNode
                oldNode, Microsoft.CodeAnalysis.SyntaxNode
                newNode, bool
                computeNewText)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer(oldNode, newNode, computeNewText: computeNewText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 2478, 2534);
                    return return_v;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.Text.TextChange>
                f_673_2478_2562(Microsoft.CodeAnalysis.SyntaxDiffer
                this_param)
                {
                    var return_v = this_param.ComputeTextChangesFromOld();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 2478, 2562);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 2358, 2574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 2358, 2574);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IList<TextChange> ComputeTextChangesFromOld()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(673, 2586, 2868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 2664, 2692);

                f_673_2664_2691(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 2706, 2756);

                var
                reducedChanges = f_673_2727_2755(this, _changes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 2772, 2857);

                return f_673_2779_2856(f_673_2779_2847(reducedChanges, c => new TextChange(c.Range.Span, c.NewText!)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(673, 2586, 2868);

                int
                f_673_2664_2691(Microsoft.CodeAnalysis.SyntaxDiffer
                this_param)
                {
                    this_param.ComputeChangeRecords();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 2664, 2691);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRangeWithText>
                f_673_2727_2755(Microsoft.CodeAnalysis.SyntaxDiffer
                this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord>
                changeRecords)
                {
                    var return_v = this_param.ReduceChanges(changeRecords);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 2727, 2755);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextChange>
                f_673_2779_2847(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRangeWithText>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRangeWithText, Microsoft.CodeAnalysis.Text.TextChange>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRangeWithText, Microsoft.CodeAnalysis.Text.TextChange>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 2779, 2847);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.Text.TextChange>
                f_673_2779_2856(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextChange>
                source)
                {
                    var return_v = source.ToList<Microsoft.CodeAnalysis.Text.TextChange>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 2779, 2856);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 2586, 2868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 2586, 2868);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IList<TextSpan> GetPossiblyDifferentTextSpans(SyntaxTree? before, SyntaxTree? after)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(673, 2880, 3702);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 3005, 3691) || true) && (f_673_3009_3046(before, after))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 3005, 3691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 3138, 3190);

                    return f_673_3145_3189();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 3005, 3691);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 3005, 3691);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 3224, 3691) || true) && (before == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 3224, 3691);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 3348, 3406);

                        return new[] { f_673_3363_3403(0, f_673_3379_3402(f_673_3379_3395(after!))) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 3224, 3691);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 3224, 3691);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 3440, 3691) || true) && (after == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 3440, 3691);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 3491, 3538);

                            throw f_673_3497_3537(nameof(after));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 3440, 3691);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 3440, 3691);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 3604, 3676);

                            return f_673_3611_3675(f_673_3641_3657(before), f_673_3659_3674(after));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 3440, 3691);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 3224, 3691);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 3005, 3691);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(673, 2880, 3702);

                bool
                f_673_3009_3046(Microsoft.CodeAnalysis.SyntaxTree?
                objA, Microsoft.CodeAnalysis.SyntaxTree?
                objB)
                {
                    var return_v = object.ReferenceEquals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 3009, 3046);
                    return return_v;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.Text.TextSpan>
                f_673_3145_3189()
                {
                    var return_v = SpecializedCollections.EmptyList<TextSpan>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 3145, 3189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_673_3379_3395(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 3379, 3395);
                    return return_v;
                }


                int
                f_673_3379_3402(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 3379, 3402);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_673_3363_3403(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 3363, 3403);
                    return return_v;
                }


                System.ArgumentNullException
                f_673_3497_3537(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 3497, 3537);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_673_3641_3657(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 3641, 3657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_673_3659_3674(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 3659, 3674);
                    return return_v;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.Text.TextSpan>
                f_673_3611_3675(Microsoft.CodeAnalysis.SyntaxNode
                oldNode, Microsoft.CodeAnalysis.SyntaxNode
                newNode)
                {
                    var return_v = GetPossiblyDifferentTextSpans(oldNode, newNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 3611, 3675);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 2880, 3702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 2880, 3702);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IList<TextSpan> GetPossiblyDifferentTextSpans(SyntaxNode oldNode, SyntaxNode newNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(673, 3826, 4048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 3952, 4037);

                return f_673_3959_4036(f_673_3959_4016(oldNode, newNode, computeNewText: false));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(673, 3826, 4048);

                Microsoft.CodeAnalysis.SyntaxDiffer
                f_673_3959_4016(Microsoft.CodeAnalysis.SyntaxNode
                oldNode, Microsoft.CodeAnalysis.SyntaxNode
                newNode, bool
                computeNewText)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer(oldNode, newNode, computeNewText: computeNewText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 3959, 4016);
                    return return_v;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.Text.TextSpan>
                f_673_3959_4036(Microsoft.CodeAnalysis.SyntaxDiffer
                this_param)
                {
                    var return_v = this_param.ComputeSpansInNew();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 3959, 4036);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 3826, 4048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 3826, 4048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IList<TextSpan> ComputeSpansInNew()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(673, 4060, 4927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 4128, 4156);

                f_673_4128_4155(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 4170, 4215);

                var
                reducedChanges = f_673_4191_4214(this, _changes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 4316, 4352);

                var
                newSpans = f_673_4331_4351()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 4366, 4380);

                int
                delta = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 4442, 4884);
                    foreach (var change in f_673_4465_4479_I(reducedChanges))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 4442, 4884);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 4513, 4790) || true) && (change.Range.NewLength > 0)
                        ) // delete-only ranges cannot be expressed as part of new text

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 4513, 4790);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 4647, 4691);

                            int
                            start = change.Range.Span.Start + delta
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 4713, 4771);

                            f_673_4713_4770(newSpans, f_673_4726_4769(start, change.Range.NewLength));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 4513, 4790);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 4810, 4869);

                        delta += change.Range.NewLength - change.Range.Span.Length;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 4442, 4884);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(673, 1, 443);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(673, 1, 443);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 4900, 4916);

                return newSpans;
                DynAbs.Tracing.TraceSender.TraceExitMethod(673, 4060, 4927);

                int
                f_673_4128_4155(Microsoft.CodeAnalysis.SyntaxDiffer
                this_param)
                {
                    this_param.ComputeChangeRecords();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 4128, 4155);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRangeWithText>
                f_673_4191_4214(Microsoft.CodeAnalysis.SyntaxDiffer
                this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord>
                changeRecords)
                {
                    var return_v = this_param.ReduceChanges(changeRecords);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 4191, 4214);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.Text.TextSpan>
                f_673_4331_4351()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.Text.TextSpan>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 4331, 4351);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_673_4726_4769(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 4726, 4769);
                    return return_v;
                }


                int
                f_673_4713_4770(System.Collections.Generic.List<Microsoft.CodeAnalysis.Text.TextSpan>
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 4713, 4770);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRangeWithText>
                f_673_4465_4479_I(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRangeWithText>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 4465, 4479);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 4060, 4927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 4060, 4927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ComputeChangeRecords()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(673, 4939, 7153);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 4999, 7142) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 4999, 7142);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 5110, 7127) || true) && (f_673_5114_5129(_newNodes) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 5110, 7127);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 5232, 5361) || true) && (f_673_5236_5251(_oldNodes) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 5232, 5361);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 5305, 5338);

                                f_673_5305_5337(this, f_673_5321_5336(_oldNodes));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(673, 5232, 5361);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(673, 5383, 5389);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 5110, 7127);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 5110, 7127);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 5431, 7127) || true) && (f_673_5435_5450(_oldNodes) == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 5431, 7127);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 5551, 5680) || true) && (f_673_5555_5570(_newNodes) > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 5551, 5680);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 5624, 5657);

                                    f_673_5624_5656(this, f_673_5640_5655(_newNodes));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 5551, 5680);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(673, 5702, 5708);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(673, 5431, 7127);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 5431, 7127);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 5790, 5819);

                                var
                                action = f_673_5803_5818(this)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 5841, 7108);

                                switch (action.Operation)
                                {

                                    case DiffOp.SkipBoth:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 5841, 7108);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 5966, 6003);

                                        f_673_5966_6002(_oldNodes, action.Count);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 6033, 6070);

                                        f_673_6033_6069(_newNodes, action.Count);
                                        DynAbs.Tracing.TraceSender.TraceBreak(673, 6100, 6106);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 5841, 7108);

                                    case DiffOp.ReduceOld:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 5841, 7108);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 6184, 6220);

                                        f_673_6184_6219(_oldNodes);
                                        DynAbs.Tracing.TraceSender.TraceBreak(673, 6250, 6256);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 5841, 7108);

                                    case DiffOp.ReduceNew:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 5841, 7108);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 6334, 6370);

                                        f_673_6334_6369(_newNodes);
                                        DynAbs.Tracing.TraceSender.TraceBreak(673, 6400, 6406);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 5841, 7108);

                                    case DiffOp.ReduceBoth:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 5841, 7108);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 6485, 6521);

                                        f_673_6485_6520(_oldNodes);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 6551, 6587);

                                        f_673_6551_6586(_newNodes);
                                        DynAbs.Tracing.TraceSender.TraceBreak(673, 6617, 6623);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 5841, 7108);

                                    case DiffOp.InsertNew:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 5841, 7108);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 6701, 6731);

                                        f_673_6701_6730(this, action.Count);
                                        DynAbs.Tracing.TraceSender.TraceBreak(673, 6761, 6767);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 5841, 7108);

                                    case DiffOp.DeleteOld:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 5841, 7108);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 6845, 6875);

                                        f_673_6845_6874(this, action.Count);
                                        DynAbs.Tracing.TraceSender.TraceBreak(673, 6905, 6911);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 5841, 7108);

                                    case DiffOp.ReplaceOldWithNew:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 5841, 7108);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 6997, 7049);

                                        f_673_6997_7048(this, action.Count, action.Count);
                                        DynAbs.Tracing.TraceSender.TraceBreak(673, 7079, 7085);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 5841, 7108);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(673, 5431, 7127);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 5110, 7127);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 4999, 7142);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(673, 4999, 7142);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(673, 4999, 7142);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(673, 4939, 7153);

                int
                f_673_5114_5129(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 5114, 5129);
                    return return_v;
                }


                int
                f_673_5236_5251(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 5236, 5251);
                    return return_v;
                }


                int
                f_673_5321_5336(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 5321, 5336);
                    return return_v;
                }


                int
                f_673_5305_5337(Microsoft.CodeAnalysis.SyntaxDiffer
                this_param, int
                oldNodeCount)
                {
                    this_param.RecordDeleteOld(oldNodeCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 5305, 5337);
                    return 0;
                }


                int
                f_673_5435_5450(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 5435, 5450);
                    return return_v;
                }


                int
                f_673_5555_5570(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 5555, 5570);
                    return return_v;
                }


                int
                f_673_5640_5655(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 5640, 5655);
                    return return_v;
                }


                int
                f_673_5624_5656(Microsoft.CodeAnalysis.SyntaxDiffer
                this_param, int
                newNodeCount)
                {
                    this_param.RecordInsertNew(newNodeCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 5624, 5656);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction
                f_673_5803_5818(Microsoft.CodeAnalysis.SyntaxDiffer
                this_param)
                {
                    var return_v = this_param.GetNextAction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 5803, 5818);
                    return return_v;
                }


                int
                f_673_5966_6002(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                stack, int
                count)
                {
                    RemoveFirst(stack, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 5966, 6002);
                    return 0;
                }


                int
                f_673_6033_6069(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                stack, int
                count)
                {
                    RemoveFirst(stack, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 6033, 6069);
                    return 0;
                }


                int
                f_673_6184_6219(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                stack)
                {
                    ReplaceFirstWithChildren(stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 6184, 6219);
                    return 0;
                }


                int
                f_673_6334_6369(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                stack)
                {
                    ReplaceFirstWithChildren(stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 6334, 6369);
                    return 0;
                }


                int
                f_673_6485_6520(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                stack)
                {
                    ReplaceFirstWithChildren(stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 6485, 6520);
                    return 0;
                }


                int
                f_673_6551_6586(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                stack)
                {
                    ReplaceFirstWithChildren(stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 6551, 6586);
                    return 0;
                }


                int
                f_673_6701_6730(Microsoft.CodeAnalysis.SyntaxDiffer
                this_param, int
                newNodeCount)
                {
                    this_param.RecordInsertNew(newNodeCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 6701, 6730);
                    return 0;
                }


                int
                f_673_6845_6874(Microsoft.CodeAnalysis.SyntaxDiffer
                this_param, int
                oldNodeCount)
                {
                    this_param.RecordDeleteOld(oldNodeCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 6845, 6874);
                    return 0;
                }


                int
                f_673_6997_7048(Microsoft.CodeAnalysis.SyntaxDiffer
                this_param, int
                oldNodeCount, int
                newNodeCount)
                {
                    this_param.RecordReplaceOldWithNew(oldNodeCount, newNodeCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 6997, 7048);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 4939, 7153);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 4939, 7153);
            }
        }

        private enum DiffOp
        {
            None = 0,
            SkipBoth,
            ReduceOld,
            ReduceNew,
            ReduceBoth,
            InsertNew,
            DeleteOld,
            ReplaceOldWithNew
        }

        private struct DiffAction
        {

            public readonly DiffOp Operation;

            public readonly int Count;

            public DiffAction(DiffOp operation, int count)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(673, 7555, 7775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 7634, 7678);

                    f_673_7634_7677(count >= 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 7696, 7723);

                    this.Operation = operation;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 7741, 7760);

                    this.Count = count;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(673, 7555, 7775);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 7555, 7775);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 7555, 7775);
                }
            }
            static DiffAction()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(673, 7416, 7786);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(673, 7416, 7786);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 7416, 7786);
            }

            static int
            f_673_7634_7677(bool
            condition)
            {
                System.Diagnostics.Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 7634, 7677);
                return 0;
            }

        }

        private DiffAction GetNextAction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(673, 7798, 13024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 7857, 7900);

                bool
                oldIsToken = f_673_7875_7891(_oldNodes).IsToken
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 7914, 7957);

                bool
                newIsToken = f_673_7932_7948(_newNodes).IsToken
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 8010, 8030);

                int
                indexOfOldInNew
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 8044, 8069);

                int
                similarityOfOldInNew
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 8083, 8103);

                int
                indexOfNewInOld
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 8117, 8142);

                int
                similarityOfNewInOld
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 8158, 8248);

                f_673_8158_8247(this, _newNodes, f_673_8183_8199(_oldNodes), out indexOfOldInNew, out similarityOfOldInNew);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 8262, 8352);

                f_673_8262_8351(this, _oldNodes, f_673_8287_8303(_newNodes), out indexOfNewInOld, out similarityOfNewInOld);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 8368, 13013) || true) && (indexOfOldInNew == 0 && (DynAbs.Tracing.TraceSender.Expression_True(673, 8372, 8416) && indexOfNewInOld == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 8368, 13013);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 8524, 9335) || true) && (f_673_8528_8576(f_673_8541_8557(_oldNodes), f_673_8559_8575(_newNodes)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 8524, 9335);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 8710, 8752);

                        return f_673_8717_8751(DiffOp.SkipBoth, 1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 8524, 9335);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 8524, 9335);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 8794, 9335) || true) && (!oldIsToken && (DynAbs.Tracing.TraceSender.Expression_True(673, 8798, 8824) && !newIsToken))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 8794, 9335);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 8958, 9002);

                            return f_673_8965_9001(DiffOp.ReduceBoth, 1);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 8794, 9335);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 8794, 9335);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 9265, 9316);

                            return f_673_9272_9315(DiffOp.ReplaceOldWithNew, 1);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 8794, 9335);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 8524, 9335);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 8368, 13013);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 8368, 13013);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 9369, 13013) || true) && (indexOfOldInNew >= 0 || (DynAbs.Tracing.TraceSender.Expression_False(673, 9373, 9417) || indexOfNewInOld >= 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 9369, 13013);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 9621, 12317) || true) && (indexOfNewInOld < 0 || (DynAbs.Tracing.TraceSender.Expression_False(673, 9625, 9692) || similarityOfOldInNew >= similarityOfNewInOld))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 9621, 12317);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 10053, 10866) || true) && (indexOfOldInNew > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 10053, 10866);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 10229, 10249);

                                int
                                indexOfOldInOld
                                = default(int);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 10275, 10300);

                                int
                                similarityOfOldInOld
                                = default(int);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 10326, 10419);

                                f_673_10326_10418(this, _oldNodes, f_673_10351_10367(_oldNodes), out indexOfOldInOld, out similarityOfOldInOld, 1);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 10552, 10650);

                                var
                                oldHasSimilarSibling = (indexOfOldInOld >= 1 && (DynAbs.Tracing.TraceSender.Expression_True(673, 10580, 10648) && similarityOfOldInOld >= similarityOfOldInNew))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 10676, 10843) || true) && (!oldHasSimilarSibling)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 10676, 10843);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 10759, 10816);

                                    return f_673_10766_10815(DiffOp.InsertNew, indexOfOldInNew);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 10676, 10843);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(673, 10053, 10866);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 10890, 11463) || true) && (!newIsToken)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 10890, 11463);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 10955, 11291) || true) && (f_673_10959_11005(f_673_10970_10986(_oldNodes), f_673_10988_11004(_newNodes)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 10955, 11291);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 11063, 11107);

                                    return f_673_11070_11106(DiffOp.ReduceBoth, 1);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 10955, 11291);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 10955, 11291);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 11221, 11264);

                                    return f_673_11228_11263(DiffOp.ReduceNew, 1);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 10955, 11291);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(673, 10890, 11463);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 10890, 11463);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 11389, 11440);

                                return f_673_11396_11439(DiffOp.ReplaceOldWithNew, 1);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(673, 10890, 11463);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 9621, 12317);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 9621, 12317);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 11545, 12298) || true) && (indexOfNewInOld > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 11545, 12298);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 11618, 11675);

                                return f_673_11625_11674(DiffOp.DeleteOld, indexOfNewInOld);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(673, 11545, 12298);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 11545, 12298);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 11725, 12298) || true) && (!oldIsToken)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 11725, 12298);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 11790, 12126) || true) && (f_673_11794_11840(f_673_11805_11821(_oldNodes), f_673_11823_11839(_newNodes)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 11790, 12126);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 11898, 11942);

                                        return f_673_11905_11941(DiffOp.ReduceBoth, 1);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 11790, 12126);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 11790, 12126);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 12056, 12099);

                                        return f_673_12063_12098(DiffOp.ReduceOld, 1);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 11790, 12126);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 11725, 12298);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 11725, 12298);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 12224, 12275);

                                    return f_673_12231_12274(DiffOp.ReplaceOldWithNew, 1);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 11725, 12298);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(673, 11545, 12298);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 9621, 12317);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 9369, 13013);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 9369, 13013);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 12502, 12927) || true) && (!oldIsToken && (DynAbs.Tracing.TraceSender.Expression_True(673, 12506, 12532) && !newIsToken))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 12502, 12927);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 12622, 12682);

                            var
                            sim = f_673_12632_12681(this, f_673_12646_12662(_oldNodes), f_673_12664_12680(_newNodes))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 12704, 12908) || true) && (sim >= f_673_12715_12791(f_673_12724_12740(_oldNodes).FullSpan.Length, f_673_12758_12774(_newNodes).FullSpan.Length))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 12704, 12908);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 12841, 12885);

                                return f_673_12848_12884(DiffOp.ReduceBoth, 1);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(673, 12704, 12908);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 12502, 12927);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 12947, 12998);

                        return f_673_12954_12997(DiffOp.ReplaceOldWithNew, 1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 9369, 13013);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 8368, 13013);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(673, 7798, 13024);

                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_673_7875_7891(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 7875, 7891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_673_7932_7948(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 7932, 7948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_673_8183_8199(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 8183, 8199);
                    return return_v;
                }


                int
                f_673_8158_8247(Microsoft.CodeAnalysis.SyntaxDiffer
                this_param, System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                stack, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node, out int
                index, out int
                similarity)
                {
                    this_param.FindBestMatch(stack, node, out index, out similarity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 8158, 8247);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_673_8287_8303(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 8287, 8303);
                    return return_v;
                }


                int
                f_673_8262_8351(Microsoft.CodeAnalysis.SyntaxDiffer
                this_param, System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                stack, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node, out int
                index, out int
                similarity)
                {
                    this_param.FindBestMatch(stack, node, out index, out similarity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 8262, 8351);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_673_8541_8557(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 8541, 8557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_673_8559_8575(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 8559, 8575);
                    return return_v;
                }


                bool
                f_673_8528_8576(Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node1, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node2)
                {
                    var return_v = AreIdentical(node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 8528, 8576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction
                f_673_8717_8751(Microsoft.CodeAnalysis.SyntaxDiffer.DiffOp
                operation, int
                count)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction(operation, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 8717, 8751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction
                f_673_8965_9001(Microsoft.CodeAnalysis.SyntaxDiffer.DiffOp
                operation, int
                count)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction(operation, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 8965, 9001);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction
                f_673_9272_9315(Microsoft.CodeAnalysis.SyntaxDiffer.DiffOp
                operation, int
                count)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction(operation, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 9272, 9315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_673_10351_10367(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 10351, 10367);
                    return return_v;
                }


                int
                f_673_10326_10418(Microsoft.CodeAnalysis.SyntaxDiffer
                this_param, System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                stack, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node, out int
                index, out int
                similarity, int
                startIndex)
                {
                    this_param.FindBestMatch(stack, node, out index, out similarity, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 10326, 10418);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction
                f_673_10766_10815(Microsoft.CodeAnalysis.SyntaxDiffer.DiffOp
                operation, int
                count)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction(operation, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 10766, 10815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_673_10970_10986(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 10970, 10986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_673_10988_11004(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 10988, 11004);
                    return return_v;
                }


                bool
                f_673_10959_11005(Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node1, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node2)
                {
                    var return_v = AreSimilar(node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 10959, 11005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction
                f_673_11070_11106(Microsoft.CodeAnalysis.SyntaxDiffer.DiffOp
                operation, int
                count)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction(operation, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 11070, 11106);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction
                f_673_11228_11263(Microsoft.CodeAnalysis.SyntaxDiffer.DiffOp
                operation, int
                count)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction(operation, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 11228, 11263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction
                f_673_11396_11439(Microsoft.CodeAnalysis.SyntaxDiffer.DiffOp
                operation, int
                count)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction(operation, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 11396, 11439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction
                f_673_11625_11674(Microsoft.CodeAnalysis.SyntaxDiffer.DiffOp
                operation, int
                count)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction(operation, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 11625, 11674);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_673_11805_11821(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 11805, 11821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_673_11823_11839(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 11823, 11839);
                    return return_v;
                }


                bool
                f_673_11794_11840(Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node1, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node2)
                {
                    var return_v = AreSimilar(node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 11794, 11840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction
                f_673_11905_11941(Microsoft.CodeAnalysis.SyntaxDiffer.DiffOp
                operation, int
                count)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction(operation, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 11905, 11941);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction
                f_673_12063_12098(Microsoft.CodeAnalysis.SyntaxDiffer.DiffOp
                operation, int
                count)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction(operation, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 12063, 12098);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction
                f_673_12231_12274(Microsoft.CodeAnalysis.SyntaxDiffer.DiffOp
                operation, int
                count)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction(operation, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 12231, 12274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_673_12646_12662(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 12646, 12662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_673_12664_12680(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 12664, 12680);
                    return return_v;
                }


                int
                f_673_12632_12681(Microsoft.CodeAnalysis.SyntaxDiffer
                this_param, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node1, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node2)
                {
                    var return_v = this_param.GetSimilarity(node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 12632, 12681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_673_12724_12740(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 12724, 12740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_673_12758_12774(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 12758, 12774);
                    return return_v;
                }


                int
                f_673_12715_12791(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 12715, 12791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction
                f_673_12848_12884(Microsoft.CodeAnalysis.SyntaxDiffer.DiffOp
                operation, int
                count)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction(operation, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 12848, 12884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction
                f_673_12954_12997(Microsoft.CodeAnalysis.SyntaxDiffer.DiffOp
                operation, int
                count)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer.DiffAction(operation, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 12954, 12997);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 7798, 13024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 7798, 13024);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ReplaceFirstWithChildren(Stack<SyntaxNodeOrToken> stack)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(673, 13036, 13649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 13137, 13160);

                var
                node = f_673_13148_13159(stack)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 13176, 13186);

                int
                c = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 13200, 13271);

                var
                children = new SyntaxNodeOrToken[node.ChildNodesAndTokens().Count]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 13285, 13518);
                    foreach (var child in f_673_13307_13333_I(node.ChildNodesAndTokens()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 13285, 13518);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 13367, 13503) || true) && (child.FullSpan.Length > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 13367, 13503);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 13438, 13458);

                            children[c] = child;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 13480, 13484);

                            c++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 13367, 13503);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 13285, 13518);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(673, 1, 234);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(673, 1, 234);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 13543, 13552);

                    for (int
        i = c - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 13534, 13638) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 13562, 13565)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(673, 13534, 13638))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 13534, 13638);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 13599, 13623);

                        f_673_13599_13622(stack, children[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(673, 1, 105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(673, 1, 105);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(673, 13036, 13649);

                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_673_13148_13159(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 13148, 13159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_673_13307_13333_I(Microsoft.CodeAnalysis.ChildSyntaxList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 13307, 13333);
                    return return_v;
                }


                int
                f_673_13599_13622(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 13599, 13622);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 13036, 13649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 13036, 13649);
            }
        }

        private void FindBestMatch(Stack<SyntaxNodeOrToken> stack, in SyntaxNodeOrToken node, out int index, out int similarity, int startIndex = 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(673, 13661, 16739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 13826, 13837);

                index = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 13851, 13867);

                similarity = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 13883, 13893);

                int
                i = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 13907, 16728);
                    foreach (var stackNode in f_673_13933_13938_I(stack))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 13907, 16728);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 13972, 14063) || true) && (i >= MaxSearchLength)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 13972, 14063);
                            DynAbs.Tracing.TraceSender.TraceBreak(673, 14038, 14044);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 13972, 14063);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 14083, 16689) || true) && (i >= startIndex)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 14083, 16689);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 14144, 16670) || true) && (f_673_14148_14177(stackNode, node))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 14144, 16670);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 14227, 14258);

                                var
                                sim = node.FullSpan.Length
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 14284, 14483) || true) && (sim > similarity)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 14284, 14483);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 14362, 14372);

                                    index = i;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 14402, 14419);

                                    similarity = sim;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 14449, 14456);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 14284, 14483);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(673, 14144, 16670);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 14144, 16670);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 14533, 16670) || true) && (f_673_14537_14564(stackNode, node))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 14533, 16670);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 14614, 14655);

                                    var
                                    sim = f_673_14624_14654(this, stackNode, node)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 14862, 15244) || true) && (sim == node.FullSpan.Length && (DynAbs.Tracing.TraceSender.Expression_True(673, 14866, 14909) && node.IsToken))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 14862, 15244);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 14967, 15217) || true) && (stackNode.ToFullString() == node.ToFullString())
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 14967, 15217);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 15084, 15094);

                                            index = i;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 15128, 15145);

                                            similarity = sim;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 15179, 15186);

                                            return;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 14967, 15217);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 14862, 15244);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 15272, 15434) || true) && (sim > similarity)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 15272, 15434);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 15350, 15360);

                                        index = i;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 15390, 15407);

                                        similarity = sim;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 15272, 15434);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 14533, 16670);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 14533, 16670);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 15609, 15619);

                                    int
                                    j = 0
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 15645, 16647);
                                        foreach (var child in f_673_15667_15698_I(stackNode.ChildNodesAndTokens()))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 15645, 16647);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 15756, 15883) || true) && (j >= MaxSearchLength)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 15756, 15883);
                                                DynAbs.Tracing.TraceSender.TraceBreak(673, 15846, 15852);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(673, 15756, 15883);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 15915, 15919);

                                            j++;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 15951, 16620) || true) && (f_673_15955_15980(child, node))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 15951, 16620);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 16046, 16056);

                                                index = i;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 16090, 16124);

                                                similarity = node.FullSpan.Length;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 16158, 16165);

                                                return;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(673, 15951, 16620);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 15951, 16620);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 16231, 16620) || true) && (f_673_16235_16258(child, node))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 16231, 16620);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 16324, 16361);

                                                    var
                                                    sim = f_673_16334_16360(this, child, node)
                                                    ;

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 16395, 16589) || true) && (sim > similarity)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 16395, 16589);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 16489, 16499);

                                                        index = i;
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 16537, 16554);

                                                        similarity = sim;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 16395, 16589);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 16231, 16620);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(673, 15951, 16620);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 15645, 16647);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(673, 1, 1003);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(673, 1, 1003);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 14533, 16670);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(673, 14144, 16670);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 14083, 16689);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 16709, 16713);

                        i++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 13907, 16728);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(673, 1, 2822);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(673, 1, 2822);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(673, 13661, 16739);

                bool
                f_673_14148_14177(Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node1, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node2)
                {
                    var return_v = AreIdentical(node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 14148, 14177);
                    return return_v;
                }


                bool
                f_673_14537_14564(Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node1, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node2)
                {
                    var return_v = AreSimilar(node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 14537, 14564);
                    return return_v;
                }


                int
                f_673_14624_14654(Microsoft.CodeAnalysis.SyntaxDiffer
                this_param, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node1, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node2)
                {
                    var return_v = this_param.GetSimilarity(node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 14624, 14654);
                    return return_v;
                }


                bool
                f_673_15955_15980(Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node1, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node2)
                {
                    var return_v = AreIdentical(node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 15955, 15980);
                    return return_v;
                }


                bool
                f_673_16235_16258(Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node1, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node2)
                {
                    var return_v = AreSimilar(node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 16235, 16258);
                    return return_v;
                }


                int
                f_673_16334_16360(Microsoft.CodeAnalysis.SyntaxDiffer
                this_param, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node1, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                node2)
                {
                    var return_v = this_param.GetSimilarity(node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 16334, 16360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_673_15667_15698_I(Microsoft.CodeAnalysis.ChildSyntaxList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 15667, 15698);
                    return return_v;
                }


                System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_673_13933_13938_I(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 13933, 13938);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 13661, 16739);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 13661, 16739);
            }
        }

        private int GetSimilarity(in SyntaxNodeOrToken node1, in SyntaxNodeOrToken node2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(673, 16751, 19631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 16924, 16934);

                int
                w = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 16948, 16975);

                f_673_16948_16974(_nodeSimilaritySet);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 16989, 17021);

                f_673_16989_17020(_tokenTextSimilaritySet);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 17037, 19595) || true) && (node1.IsToken && (DynAbs.Tracing.TraceSender.Expression_True(673, 17041, 17071) && node2.IsToken))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 17037, 19595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 17105, 17134);

                    var
                    text1 = node1.ToString()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 17152, 17181);

                    var
                    text2 = node2.ToString()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 17201, 17353) || true) && (text1 == text2)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 17201, 17353);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 17316, 17334);

                        w += f_673_17321_17333(text1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 17201, 17353);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 17373, 17583);
                        foreach (var tr in f_673_17392_17416_I(node1.GetLeadingTrivia()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 17373, 17583);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 17458, 17500);

                            f_673_17458_17499(tr.UnderlyingNode is object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 17522, 17564);

                            f_673_17522_17563(_nodeSimilaritySet, tr.UnderlyingNode);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 17373, 17583);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(673, 1, 211);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(673, 1, 211);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 17603, 17814);
                        foreach (var tr in f_673_17622_17647_I(node1.GetTrailingTrivia()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 17603, 17814);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 17689, 17731);

                            f_673_17689_17730(tr.UnderlyingNode is object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 17753, 17795);

                            f_673_17753_17794(_nodeSimilaritySet, tr.UnderlyingNode);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 17603, 17814);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(673, 1, 212);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(673, 1, 212);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 17834, 18149);
                        foreach (var tr in f_673_17853_17877_I(node2.GetLeadingTrivia()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 17834, 18149);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 17919, 17961);

                            f_673_17919_17960(tr.UnderlyingNode is object);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 17983, 18130) || true) && (f_673_17987_18033(_nodeSimilaritySet, tr.UnderlyingNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 17983, 18130);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 18083, 18107);

                                w += tr.FullSpan.Length;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(673, 17983, 18130);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 17834, 18149);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(673, 1, 316);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(673, 1, 316);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 18169, 18485);
                        foreach (var tr in f_673_18188_18213_I(node2.GetTrailingTrivia()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 18169, 18485);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 18255, 18297);

                            f_673_18255_18296(tr.UnderlyingNode is object);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 18319, 18466) || true) && (f_673_18323_18369(_nodeSimilaritySet, tr.UnderlyingNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 18319, 18466);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 18419, 18443);

                                w += tr.FullSpan.Length;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(673, 18319, 18466);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 18169, 18485);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(673, 1, 317);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(673, 1, 317);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 17037, 19595);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 17037, 19595);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 18551, 18918);
                        foreach (var n1 in f_673_18570_18597_I(node1.ChildNodesAndTokens()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 18551, 18918);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 18639, 18681);

                            f_673_18639_18680(n1.UnderlyingNode is object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 18703, 18745);

                            f_673_18703_18744(_nodeSimilaritySet, n1.UnderlyingNode);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 18769, 18899) || true) && (n1.IsToken)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 18769, 18899);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 18833, 18876);

                                f_673_18833_18875(_tokenTextSimilaritySet, n1.ToString());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(673, 18769, 18899);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 18551, 18918);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(673, 1, 368);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(673, 1, 368);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 18938, 19580);
                        foreach (var n2 in f_673_18957_18984_I(node2.ChildNodesAndTokens()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 18938, 19580);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 19026, 19068);

                            f_673_19026_19067(n2.UnderlyingNode is object);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 19090, 19561) || true) && (f_673_19094_19140(_nodeSimilaritySet, n2.UnderlyingNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 19090, 19561);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 19190, 19214);

                                w += n2.FullSpan.Length;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(673, 19090, 19561);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 19090, 19561);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 19264, 19561) || true) && (n2.IsToken)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 19264, 19561);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 19328, 19358);

                                    var
                                    tokenText = n2.ToString()
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 19384, 19538) || true) && (f_673_19388_19431(_tokenTextSimilaritySet, tokenText))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 19384, 19538);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 19489, 19511);

                                        w += f_673_19494_19510(tokenText);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 19384, 19538);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 19264, 19561);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(673, 19090, 19561);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 18938, 19580);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(673, 1, 643);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(673, 1, 643);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 17037, 19595);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 19611, 19620);

                return w;
                DynAbs.Tracing.TraceSender.TraceExitMethod(673, 16751, 19631);

                int
                f_673_16948_16974(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.GreenNode>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 16948, 16974);
                    return 0;
                }


                int
                f_673_16989_17020(System.Collections.Generic.HashSet<string>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 16989, 17020);
                    return 0;
                }


                int
                f_673_17321_17333(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 17321, 17333);
                    return return_v;
                }


                int
                f_673_17458_17499(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 17458, 17499);
                    return 0;
                }


                bool
                f_673_17522_17563(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.GreenNode>
                this_param, Microsoft.CodeAnalysis.GreenNode
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 17522, 17563);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_673_17392_17416_I(Microsoft.CodeAnalysis.SyntaxTriviaList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 17392, 17416);
                    return return_v;
                }


                int
                f_673_17689_17730(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 17689, 17730);
                    return 0;
                }


                bool
                f_673_17753_17794(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.GreenNode>
                this_param, Microsoft.CodeAnalysis.GreenNode
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 17753, 17794);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_673_17622_17647_I(Microsoft.CodeAnalysis.SyntaxTriviaList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 17622, 17647);
                    return return_v;
                }


                int
                f_673_17919_17960(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 17919, 17960);
                    return 0;
                }


                bool
                f_673_17987_18033(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.GreenNode>
                this_param, Microsoft.CodeAnalysis.GreenNode
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 17987, 18033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_673_17853_17877_I(Microsoft.CodeAnalysis.SyntaxTriviaList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 17853, 17877);
                    return return_v;
                }


                int
                f_673_18255_18296(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 18255, 18296);
                    return 0;
                }


                bool
                f_673_18323_18369(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.GreenNode>
                this_param, Microsoft.CodeAnalysis.GreenNode
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 18323, 18369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_673_18188_18213_I(Microsoft.CodeAnalysis.SyntaxTriviaList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 18188, 18213);
                    return return_v;
                }


                int
                f_673_18639_18680(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 18639, 18680);
                    return 0;
                }


                bool
                f_673_18703_18744(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.GreenNode>
                this_param, Microsoft.CodeAnalysis.GreenNode
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 18703, 18744);
                    return return_v;
                }


                bool
                f_673_18833_18875(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 18833, 18875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_673_18570_18597_I(Microsoft.CodeAnalysis.ChildSyntaxList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 18570, 18597);
                    return return_v;
                }


                int
                f_673_19026_19067(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 19026, 19067);
                    return 0;
                }


                bool
                f_673_19094_19140(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.GreenNode>
                this_param, Microsoft.CodeAnalysis.GreenNode
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 19094, 19140);
                    return return_v;
                }


                bool
                f_673_19388_19431(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 19388, 19431);
                    return return_v;
                }


                int
                f_673_19494_19510(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 19494, 19510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_673_18957_18984_I(Microsoft.CodeAnalysis.ChildSyntaxList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 18957, 18984);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 16751, 19631);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 16751, 19631);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool AreIdentical(in SyntaxNodeOrToken node1, in SyntaxNodeOrToken node2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(673, 19643, 19819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 19756, 19808);

                return node1.UnderlyingNode == node2.UnderlyingNode;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(673, 19643, 19819);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 19643, 19819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 19643, 19819);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool AreSimilar(in SyntaxNodeOrToken node1, in SyntaxNodeOrToken node2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(673, 19831, 19991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 19942, 19980);

                return node1.RawKind == node2.RawKind;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(673, 19831, 19991);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 19831, 19991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 19831, 19991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private readonly struct ChangeRecord
        {

            public readonly TextChangeRange Range;

            public readonly Queue<SyntaxNodeOrToken>? OldNodes;

            public readonly Queue<SyntaxNodeOrToken>? NewNodes;

            internal ChangeRecord(TextChangeRange range, Queue<SyntaxNodeOrToken>? oldNodes, Queue<SyntaxNodeOrToken>? newNodes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(673, 20248, 20517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 20397, 20416);

                    this.Range = range;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 20434, 20459);

                    this.OldNodes = oldNodes;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 20477, 20502);

                    this.NewNodes = newNodes;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(673, 20248, 20517);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 20248, 20517);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 20248, 20517);
                }
            }
            static ChangeRecord()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(673, 20003, 20528);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(673, 20003, 20528);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 20003, 20528);
            }
        }

        private void RecordDeleteOld(int oldNodeCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(673, 20540, 20889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 20611, 20661);

                var
                oldSpan = f_673_20625_20660(_oldNodes, 0, oldNodeCount)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 20675, 20729);

                var
                removedNodes = f_673_20694_20728(_oldNodes, oldNodeCount)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 20743, 20780);

                f_673_20743_20779(_oldNodes, oldNodeCount);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 20794, 20878);

                f_673_20794_20877(this, f_673_20807_20876(f_673_20824_20855(oldSpan, 0), removedNodes, null));
                DynAbs.Tracing.TraceSender.TraceExitMethod(673, 20540, 20889);

                Microsoft.CodeAnalysis.Text.TextSpan
                f_673_20625_20660(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                stack, int
                first, int
                length)
                {
                    var return_v = GetSpan(stack, first, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 20625, 20660);
                    return return_v;
                }


                System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?
                f_673_20694_20728(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                stack, int
                n)
                {
                    var return_v = CopyFirst(stack, n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 20694, 20728);
                    return return_v;
                }


                int
                f_673_20743_20779(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                stack, int
                count)
                {
                    RemoveFirst(stack, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 20743, 20779);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.TextChangeRange
                f_673_20824_20855(Microsoft.CodeAnalysis.Text.TextSpan
                span, int
                newLength)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextChangeRange(span, newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 20824, 20855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord
                f_673_20807_20876(Microsoft.CodeAnalysis.Text.TextChangeRange
                range, System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?
                oldNodes, System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?
                newNodes)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord(range, oldNodes, newNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 20807, 20876);
                    return return_v;
                }


                int
                f_673_20794_20877(Microsoft.CodeAnalysis.SyntaxDiffer
                this_param, Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord
                change)
                {
                    this_param.RecordChange(change);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 20794, 20877);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 20540, 20889);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 20540, 20889);
            }
        }

        private void RecordReplaceOldWithNew(int oldNodeCount, int newNodeCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(673, 20901, 22083);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 20998, 22072) || true) && (oldNodeCount == 1 && (DynAbs.Tracing.TraceSender.Expression_True(673, 21002, 21040) && newNodeCount == 1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 20998, 22072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 21192, 21226);

                    var
                    removedNode = f_673_21210_21225(_oldNodes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 21244, 21279);

                    var
                    oldSpan = removedNode.FullSpan
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 21299, 21334);

                    var
                    insertedNode = f_673_21318_21333(_newNodes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 21352, 21388);

                    var
                    newSpan = insertedNode.FullSpan
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 21408, 21494);

                    f_673_21408_21493(this, f_673_21421_21465(oldSpan, newSpan.Length), removedNode, insertedNode);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 20998, 22072);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 20998, 22072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 21560, 21610);

                    var
                    oldSpan = f_673_21574_21609(_oldNodes, 0, oldNodeCount)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 21628, 21682);

                    var
                    removedNodes = f_673_21647_21681(_oldNodes, oldNodeCount)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 21700, 21737);

                    f_673_21700_21736(_oldNodes, oldNodeCount);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 21755, 21805);

                    var
                    newSpan = f_673_21769_21804(_newNodes, 0, newNodeCount)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 21823, 21878);

                    var
                    insertedNodes = f_673_21843_21877(_newNodes, newNodeCount)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 21896, 21933);

                    f_673_21896_21932(_newNodes, newNodeCount);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 21951, 22057);

                    f_673_21951_22056(this, f_673_21964_22055(f_673_21981_22025(oldSpan, newSpan.Length), removedNodes, insertedNodes));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 20998, 22072);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(673, 20901, 22083);

                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_673_21210_21225(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 21210, 21225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_673_21318_21333(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 21318, 21333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextChangeRange
                f_673_21421_21465(Microsoft.CodeAnalysis.Text.TextSpan
                span, int
                newLength)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextChangeRange(span, newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 21421, 21465);
                    return return_v;
                }


                int
                f_673_21408_21493(Microsoft.CodeAnalysis.SyntaxDiffer
                this_param, Microsoft.CodeAnalysis.Text.TextChangeRange
                textChangeRange, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                removedNode, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                insertedNode)
                {
                    this_param.RecordChange(textChangeRange, removedNode, insertedNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 21408, 21493);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_673_21574_21609(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                stack, int
                first, int
                length)
                {
                    var return_v = GetSpan(stack, first, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 21574, 21609);
                    return return_v;
                }


                System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?
                f_673_21647_21681(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                stack, int
                n)
                {
                    var return_v = CopyFirst(stack, n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 21647, 21681);
                    return return_v;
                }


                int
                f_673_21700_21736(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                stack, int
                count)
                {
                    RemoveFirst(stack, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 21700, 21736);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_673_21769_21804(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                stack, int
                first, int
                length)
                {
                    var return_v = GetSpan(stack, first, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 21769, 21804);
                    return return_v;
                }


                System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?
                f_673_21843_21877(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                stack, int
                n)
                {
                    var return_v = CopyFirst(stack, n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 21843, 21877);
                    return return_v;
                }


                int
                f_673_21896_21932(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                stack, int
                count)
                {
                    RemoveFirst(stack, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 21896, 21932);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.TextChangeRange
                f_673_21981_22025(Microsoft.CodeAnalysis.Text.TextSpan
                span, int
                newLength)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextChangeRange(span, newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 21981, 22025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord
                f_673_21964_22055(Microsoft.CodeAnalysis.Text.TextChangeRange
                range, System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?
                oldNodes, System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?
                newNodes)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord(range, oldNodes, newNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 21964, 22055);
                    return return_v;
                }


                int
                f_673_21951_22056(Microsoft.CodeAnalysis.SyntaxDiffer
                this_param, Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord
                change)
                {
                    this_param.RecordChange(change);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 21951, 22056);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 20901, 22083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 20901, 22083);
            }
        }

        private void RecordInsertNew(int newNodeCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(673, 22095, 22563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 22166, 22216);

                var
                newSpan = f_673_22180_22215(_newNodes, 0, newNodeCount)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 22230, 22285);

                var
                insertedNodes = f_673_22250_22284(_newNodes, newNodeCount)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 22299, 22336);

                f_673_22299_22335(_newNodes, newNodeCount);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 22350, 22425);

                int
                start = (DynAbs.Tracing.TraceSender.Conditional_F1(673, 22362, 22381) || ((f_673_22362_22377(_oldNodes) > 0 && DynAbs.Tracing.TraceSender.Conditional_F2(673, 22384, 22409)) || DynAbs.Tracing.TraceSender.Conditional_F3(673, 22412, 22424))) ? f_673_22384_22400(_oldNodes).Position : _oldSpan.End
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 22439, 22552);

                f_673_22439_22551(this, f_673_22452_22550(f_673_22469_22528(f_673_22489_22511(start, 0), newSpan.Length), null, insertedNodes));
                DynAbs.Tracing.TraceSender.TraceExitMethod(673, 22095, 22563);

                Microsoft.CodeAnalysis.Text.TextSpan
                f_673_22180_22215(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                stack, int
                first, int
                length)
                {
                    var return_v = GetSpan(stack, first, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 22180, 22215);
                    return return_v;
                }


                System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?
                f_673_22250_22284(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                stack, int
                n)
                {
                    var return_v = CopyFirst(stack, n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 22250, 22284);
                    return return_v;
                }


                int
                f_673_22299_22335(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                stack, int
                count)
                {
                    RemoveFirst(stack, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 22299, 22335);
                    return 0;
                }


                int
                f_673_22362_22377(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 22362, 22377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_673_22384_22400(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 22384, 22400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_673_22489_22511(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 22489, 22511);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextChangeRange
                f_673_22469_22528(Microsoft.CodeAnalysis.Text.TextSpan
                span, int
                newLength)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextChangeRange(span, newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 22469, 22528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord
                f_673_22452_22550(Microsoft.CodeAnalysis.Text.TextChangeRange
                range, System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?
                oldNodes, System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?
                newNodes)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord(range, oldNodes, newNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 22452, 22550);
                    return return_v;
                }


                int
                f_673_22439_22551(Microsoft.CodeAnalysis.SyntaxDiffer
                this_param, Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord
                change)
                {
                    this_param.RecordChange(change);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 22439, 22551);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 22095, 22563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 22095, 22563);
            }
        }

        private void RecordChange(ChangeRecord change)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(673, 22575, 23447);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 22646, 23399) || true) && (f_673_22650_22664(_changes) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 22646, 23399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 22702, 22742);

                    var
                    last = f_673_22713_22741(_changes, f_673_22722_22736(_changes) - 1)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 22760, 23303) || true) && (last.Range.Span.End == change.Range.Span.Start)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 22760, 23303);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 22893, 23255);

                        _changes[f_673_22902_22916(_changes) - 1] = f_673_22924_23254(f_673_22967_23121(f_673_22987_23073(last.Range.Span.Start, last.Range.Span.Length + change.Range.Span.Length), last.Range.NewLength + change.Range.NewLength), f_673_23148_23187(last.OldNodes, change.OldNodes), f_673_23214_23253(last.NewNodes, change.NewNodes));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 23277, 23284);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 22760, 23303);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 23323, 23384);

                    f_673_23323_23383(change.Range.Span.Start >= last.Range.Span.End);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 22646, 23399);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 23415, 23436);

                f_673_23415_23435(
                            _changes, change);
                DynAbs.Tracing.TraceSender.TraceExitMethod(673, 22575, 23447);

                int
                f_673_22650_22664(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 22650, 22664);
                    return return_v;
                }


                int
                f_673_22722_22736(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 22722, 22736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord
                f_673_22713_22741(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 22713, 22741);
                    return return_v;
                }


                int
                f_673_22902_22916(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 22902, 22916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_673_22987_23073(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 22987, 23073);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextChangeRange
                f_673_22967_23121(Microsoft.CodeAnalysis.Text.TextSpan
                span, int
                newLength)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextChangeRange(span, newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 22967, 23121);
                    return return_v;
                }


                System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?
                f_673_23148_23187(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?
                first, System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?
                next)
                {
                    var return_v = Combine(first, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 23148, 23187);
                    return return_v;
                }


                System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?
                f_673_23214_23253(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?
                first, System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?
                next)
                {
                    var return_v = Combine(first, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 23214, 23253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord
                f_673_22924_23254(Microsoft.CodeAnalysis.Text.TextChangeRange
                range, System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?
                oldNodes, System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?
                newNodes)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord(range, oldNodes, newNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 22924, 23254);
                    return return_v;
                }


                int
                f_673_23323_23383(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 23323, 23383);
                    return 0;
                }


                int
                f_673_23415_23435(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord>
                this_param, Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 23415, 23435);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 22575, 23447);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 22575, 23447);
            }
        }

        private void RecordChange(TextChangeRange textChangeRange, in SyntaxNodeOrToken removedNode, SyntaxNodeOrToken insertedNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(673, 23459, 24905);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 23608, 24495) || true) && (f_673_23612_23626(_changes) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 23608, 24495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 23664, 23704);

                    var
                    last = f_673_23675_23703(_changes, f_673_23684_23698(_changes) - 1)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 23722, 24396) || true) && (last.Range.Span.End == textChangeRange.Span.Start)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 23722, 24396);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 23858, 23894);

                        // LAFHIS
                        DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(last.OldNodes, 673, 23858, 23893).Enqueue(removedNode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 23872, 23893);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 23916, 23953);

                        // LAFHIS
                        DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(last.NewNodes, 673, 23916, 23952).Enqueue(insertedNode);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 23930, 23952);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 23975, 24348);

                        _changes[f_673_23984_23998(_changes) - 1] = f_673_24006_24347(f_673_24049_24209(f_673_24069_24158(last.Range.Span.Start, last.Range.Span.Length + textChangeRange.Span.Length), last.Range.NewLength + textChangeRange.NewLength), last.OldNodes ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?>(673, 24236, 24277) ?? f_673_24253_24277(removedNode)), last.NewNodes ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?>(673, 24304, 24346) ?? f_673_24321_24346(insertedNode)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 24370, 24377);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 23722, 24396);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 24416, 24480);

                    f_673_24416_24479(textChangeRange.Span.Start >= last.Range.Span.End);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 23608, 24495);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 24511, 24612);

                f_673_24511_24611(
                            _changes, f_673_24524_24610(textChangeRange, f_673_24558_24582(removedNode), f_673_24584_24609(insertedNode)));

                Queue<SyntaxNodeOrToken> CreateQueue(SyntaxNodeOrToken nodeOrToken)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(673, 24660, 24894);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 24760, 24803);

                        var
                        queue = f_673_24772_24802()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 24821, 24848);

                        f_673_24821_24847(queue, nodeOrToken);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 24866, 24879);

                        return queue;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(673, 24660, 24894);

                        System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                        f_673_24772_24802()
                        {
                            var return_v = new System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 24772, 24802);
                            return return_v;
                        }


                        int
                        f_673_24821_24847(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                        this_param, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                        item)
                        {
                            this_param.Enqueue(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 24821, 24847);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 24660, 24894);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 24660, 24894);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(673, 23459, 24905);

                int
                f_673_23612_23626(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 23612, 23626);
                    return return_v;
                }


                int
                f_673_23684_23698(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 23684, 23698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord
                f_673_23675_23703(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 23675, 23703);
                    return return_v;
                }


                int
                f_673_23984_23998(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 23984, 23998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_673_24069_24158(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 24069, 24158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextChangeRange
                f_673_24049_24209(Microsoft.CodeAnalysis.Text.TextSpan
                span, int
                newLength)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextChangeRange(span, newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 24049, 24209);
                    return return_v;
                }


                System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_673_24253_24277(Microsoft.CodeAnalysis.SyntaxNodeOrToken
                nodeOrToken)
                {
                    var return_v = CreateQueue(nodeOrToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 24253, 24277);
                    return return_v;
                }


                System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_673_24321_24346(Microsoft.CodeAnalysis.SyntaxNodeOrToken
                nodeOrToken)
                {
                    var return_v = CreateQueue(nodeOrToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 24321, 24346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord
                f_673_24006_24347(Microsoft.CodeAnalysis.Text.TextChangeRange
                range, System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                oldNodes, System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                newNodes)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord(range, oldNodes, newNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 24006, 24347);
                    return return_v;
                }


                int
                f_673_24416_24479(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 24416, 24479);
                    return 0;
                }


                System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_673_24558_24582(Microsoft.CodeAnalysis.SyntaxNodeOrToken
                nodeOrToken)
                {
                    var return_v = CreateQueue(nodeOrToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 24558, 24582);
                    return return_v;
                }


                System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_673_24584_24609(Microsoft.CodeAnalysis.SyntaxNodeOrToken
                nodeOrToken)
                {
                    var return_v = CreateQueue(nodeOrToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 24584, 24609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord
                f_673_24524_24610(Microsoft.CodeAnalysis.Text.TextChangeRange
                range, System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                oldNodes, System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                newNodes)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord(range, oldNodes, newNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 24524, 24610);
                    return return_v;
                }


                int
                f_673_24511_24611(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord>
                this_param, Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 24511, 24611);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 23459, 24905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 23459, 24905);
            }
        }

        private static TextSpan GetSpan(Stack<SyntaxNodeOrToken> stack, int first, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(673, 24917, 25564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 25028, 25060);

                int
                start = -1
                ,
                end = -1
                ,
                i = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 25074, 25420);
                    foreach (var n in f_673_25092_25097_I(stack))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 25074, 25420);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 25131, 25225) || true) && (i == first)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 25131, 25225);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 25187, 25206);

                            start = n.Position;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 25131, 25225);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 25245, 25381) || true) && (i == first + length - 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 25245, 25381);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 25314, 25334);

                            end = n.EndPosition;
                            DynAbs.Tracing.TraceSender.TraceBreak(673, 25356, 25362);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 25245, 25381);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 25401, 25405);

                        i++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 25074, 25420);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(673, 1, 347);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(673, 1, 347);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 25436, 25461);

                f_673_25436_25460(start >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 25475, 25498);

                f_673_25475_25497(end >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 25514, 25553);

                return TextSpan.FromBounds(start, end);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(673, 24917, 25564);

                System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_673_25092_25097_I(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 25092, 25097);
                    return return_v;
                }


                int
                f_673_25436_25460(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 25436, 25460);
                    return 0;
                }


                int
                f_673_25475_25497(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 25475, 25497);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 24917, 25564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 24917, 25564);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TextSpan GetSpan(Queue<SyntaxNodeOrToken> queue, int first, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(673, 25576, 26223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 25687, 25719);

                int
                start = -1
                ,
                end = -1
                ,
                i = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 25733, 26079);
                    foreach (var n in f_673_25751_25756_I(queue))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 25733, 26079);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 25790, 25884) || true) && (i == first)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 25790, 25884);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 25846, 25865);

                            start = n.Position;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 25790, 25884);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 25904, 26040) || true) && (i == first + length - 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 25904, 26040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 25973, 25993);

                            end = n.EndPosition;
                            DynAbs.Tracing.TraceSender.TraceBreak(673, 26015, 26021);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 25904, 26040);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 26060, 26064);

                        i++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 25733, 26079);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(673, 1, 347);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(673, 1, 347);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 26095, 26120);

                f_673_26095_26119(start >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 26134, 26157);

                f_673_26134_26156(end >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 26173, 26212);

                return TextSpan.FromBounds(start, end);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(673, 25576, 26223);

                System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_673_25751_25756_I(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 25751, 25756);
                    return return_v;
                }


                int
                f_673_26095_26119(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 26095, 26119);
                    return 0;
                }


                int
                f_673_26134_26156(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 26134, 26156);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 25576, 26223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 25576, 26223);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Queue<SyntaxNodeOrToken>? Combine(Queue<SyntaxNodeOrToken>? first, Queue<SyntaxNodeOrToken>? next)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(673, 26235, 26748);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 26373, 26471) || true) && (first == null || (DynAbs.Tracing.TraceSender.Expression_False(673, 26377, 26410) || f_673_26394_26405(first) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 26373, 26471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 26444, 26456);

                    return next;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 26373, 26471);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 26487, 26584) || true) && (next == null || (DynAbs.Tracing.TraceSender.Expression_False(673, 26491, 26522) || f_673_26507_26517(next) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 26487, 26584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 26556, 26569);

                    return first;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 26487, 26584);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 26600, 26708);
                    foreach (var nodeOrToken in f_673_26628_26632_I(next))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 26600, 26708);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 26666, 26693);

                        f_673_26666_26692(first, nodeOrToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 26600, 26708);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(673, 1, 109);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(673, 1, 109);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 26724, 26737);

                return first;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(673, 26235, 26748);

                int
                f_673_26394_26405(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 26394, 26405);
                    return return_v;
                }


                int
                f_673_26507_26517(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 26507, 26517);
                    return return_v;
                }


                int
                f_673_26666_26692(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 26666, 26692);
                    return 0;
                }


                System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_673_26628_26632_I(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 26628, 26632);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 26235, 26748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 26235, 26748);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Queue<SyntaxNodeOrToken>? CopyFirst(Stack<SyntaxNodeOrToken> stack, int n)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(673, 26760, 27323);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 26874, 26945) || true) && (n == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 26874, 26945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 26918, 26930);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 26874, 26945);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 26961, 27005);

                var
                queue = f_673_26973_27004(n)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 27021, 27039);

                int
                remaining = n
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 27053, 27283);
                    foreach (var node in f_673_27074_27079_I(stack))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 27053, 27283);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 27113, 27198) || true) && (remaining == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 27113, 27198);
                            DynAbs.Tracing.TraceSender.TraceBreak(673, 27173, 27179);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 27113, 27198);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 27218, 27238);

                        f_673_27218_27237(
                                        queue, node);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 27256, 27268);

                        remaining--;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 27053, 27283);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(673, 1, 231);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(673, 1, 231);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 27299, 27312);

                return queue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(673, 26760, 27323);

                System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_673_26973_27004(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 26973, 27004);
                    return return_v;
                }


                int
                f_673_27218_27237(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param, Microsoft.CodeAnalysis.SyntaxNodeOrToken
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 27218, 27237);
                    return 0;
                }


                System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_673_27074_27079_I(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 27074, 27079);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 26760, 27323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 26760, 27323);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SyntaxNodeOrToken[] ToArray(Stack<SyntaxNodeOrToken> stack, int n)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(673, 27335, 27767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 27441, 27478);

                var
                nodes = new SyntaxNodeOrToken[n]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 27492, 27506);

                int
                i = n - 1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 27520, 27729);
                    foreach (var node in f_673_27541_27546_I(stack))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 27520, 27729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 27580, 27596);

                        nodes[i] = node;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 27614, 27618);

                        i--;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 27638, 27714) || true) && (i < 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 27638, 27714);
                            DynAbs.Tracing.TraceSender.TraceBreak(673, 27689, 27695);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 27638, 27714);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 27520, 27729);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(673, 1, 210);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(673, 1, 210);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 27743, 27756);

                return nodes;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(673, 27335, 27767);

                System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_673_27541_27546_I(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 27541, 27546);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 27335, 27767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 27335, 27767);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void RemoveFirst(Stack<SyntaxNodeOrToken> stack, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(673, 27779, 27980);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 27887, 27892);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 27878, 27969) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 27905, 27908)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(673, 27878, 27969))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 27878, 27969);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 27942, 27954);

                        f_673_27942_27953(stack);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(673, 1, 92);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(673, 1, 92);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(673, 27779, 27980);

                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_673_27942_27953(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 27942, 27953);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 27779, 27980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 27779, 27980);
            }
        }

        private readonly struct ChangeRangeWithText
        {

            public readonly TextChangeRange Range;

            public readonly string? NewText;

            public ChangeRangeWithText(TextChangeRange range, string? newText)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(673, 28160, 28334);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 28259, 28278);

                    this.Range = range;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 28296, 28319);

                    this.NewText = newText;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(673, 28160, 28334);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 28160, 28334);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 28160, 28334);
                }
            }
            static ChangeRangeWithText()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(673, 27992, 28345);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(673, 27992, 28345);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 27992, 28345);
            }
        }

        private List<ChangeRangeWithText> ReduceChanges(List<ChangeRecord> changeRecords)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(673, 28357, 30750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 28463, 28532);

                var
                textChanges = f_673_28481_28531(f_673_28511_28530(changeRecords))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 28548, 28582);

                var
                oldText = f_673_28562_28581()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 28596, 28630);

                var
                newText = f_673_28610_28629()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 28646, 30704);
                    foreach (var cr in f_673_28665_28678_I(changeRecords))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 28646, 30704);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 28788, 30689) || true) && (cr.Range.Span.Length > 0 && (DynAbs.Tracing.TraceSender.Expression_True(673, 28792, 28842) && cr.Range.NewLength > 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 28788, 30689);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 28884, 28905);

                            var
                            range = cr.Range
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 28929, 28960);

                            f_673_28929_28959(cr.OldNodes, oldText);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 28982, 29013);

                            f_673_28982_29012(cr.NewNodes, newText);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 29037, 29060);

                            int
                            commonLeadingCount
                            = default(int);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 29082, 29106);

                            int
                            commonTrailingCount
                            = default(int);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 29128, 29216);

                            f_673_29128_29215(oldText, newText, out commonLeadingCount, out commonTrailingCount);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 29339, 30122) || true) && (commonLeadingCount > 0 || (DynAbs.Tracing.TraceSender.Expression_False(673, 29343, 29392) || commonTrailingCount > 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 29339, 30122);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 29442, 29708);

                                range = f_673_29450_29707(f_673_29500_29615(range.Span.Start + commonLeadingCount, range.Span.Length - (commonLeadingCount + commonTrailingCount)), range.NewLength - (commonLeadingCount + commonTrailingCount));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 29736, 29922) || true) && (commonTrailingCount > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 29736, 29922);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 29821, 29895);

                                    f_673_29821_29894(newText, f_673_29836_29850(newText) - commonTrailingCount, commonTrailingCount);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 29736, 29922);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 29950, 30099) || true) && (commonLeadingCount > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 29950, 30099);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 30034, 30072);

                                    f_673_30034_30071(newText, 0, commonLeadingCount);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 29950, 30099);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(673, 29339, 30122);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 30227, 30441) || true) && (range.Span.Length > 0 || (DynAbs.Tracing.TraceSender.Expression_False(673, 30231, 30275) || range.NewLength > 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 30227, 30441);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 30325, 30418);

                                f_673_30325_30417(textChanges, f_673_30341_30416(range, (DynAbs.Tracing.TraceSender.Conditional_F1(673, 30372, 30387) || ((_computeNewText && DynAbs.Tracing.TraceSender.Conditional_F2(673, 30390, 30408)) || DynAbs.Tracing.TraceSender.Conditional_F3(673, 30411, 30415))) ? f_673_30390_30408(newText) : null));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(673, 30227, 30441);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 28788, 30689);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 28788, 30689);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 30572, 30670);

                            f_673_30572_30669(                    // pure inserts and deletes
                                                textChanges, f_673_30588_30668(cr.Range, (DynAbs.Tracing.TraceSender.Conditional_F1(673, 30622, 30637) || ((_computeNewText && DynAbs.Tracing.TraceSender.Conditional_F2(673, 30640, 30660)) || DynAbs.Tracing.TraceSender.Conditional_F3(673, 30663, 30667))) ? f_673_30640_30660(cr.NewNodes) : null));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 28788, 30689);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(673, 28646, 30704);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(673, 1, 2059);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(673, 1, 2059);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 30720, 30739);

                return textChanges;
                DynAbs.Tracing.TraceSender.TraceExitMethod(673, 28357, 30750);

                int
                f_673_28511_28530(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 28511, 28530);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRangeWithText>
                f_673_28481_28531(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRangeWithText>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 28481, 28531);
                    return return_v;
                }


                System.Text.StringBuilder
                f_673_28562_28581()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 28562, 28581);
                    return return_v;
                }


                System.Text.StringBuilder
                f_673_28610_28629()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 28610, 28629);
                    return return_v;
                }


                int
                f_673_28929_28959(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?
                queue, System.Text.StringBuilder
                builder)
                {
                    CopyText(queue, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 28929, 28959);
                    return 0;
                }


                int
                f_673_28982_29012(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?
                queue, System.Text.StringBuilder
                builder)
                {
                    CopyText(queue, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 28982, 29012);
                    return 0;
                }


                int
                f_673_29128_29215(System.Text.StringBuilder
                oldText, System.Text.StringBuilder
                newText, out int
                commonLeadingCount, out int
                commonTrailingCount)
                {
                    GetCommonEdgeLengths(oldText, newText, out commonLeadingCount, out commonTrailingCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 29128, 29215);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_673_29500_29615(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 29500, 29615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextChangeRange
                f_673_29450_29707(Microsoft.CodeAnalysis.Text.TextSpan
                span, int
                newLength)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextChangeRange(span, newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 29450, 29707);
                    return return_v;
                }


                int
                f_673_29836_29850(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 29836, 29850);
                    return return_v;
                }


                System.Text.StringBuilder
                f_673_29821_29894(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 29821, 29894);
                    return return_v;
                }


                System.Text.StringBuilder
                f_673_30034_30071(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 30034, 30071);
                    return return_v;
                }


                string
                f_673_30390_30408(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 30390, 30408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRangeWithText
                f_673_30341_30416(Microsoft.CodeAnalysis.Text.TextChangeRange
                range, string?
                newText)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRangeWithText(range, newText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 30341, 30416);
                    return return_v;
                }


                int
                f_673_30325_30417(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRangeWithText>
                this_param, Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRangeWithText
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 30325, 30417);
                    return 0;
                }


                string
                f_673_30640_30660(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>?
                queue)
                {
                    var return_v = GetText(queue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 30640, 30660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRangeWithText
                f_673_30588_30668(Microsoft.CodeAnalysis.Text.TextChangeRange
                range, string?
                newText)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRangeWithText(range, newText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 30588, 30668);
                    return return_v;
                }


                int
                f_673_30572_30669(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRangeWithText>
                this_param, Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRangeWithText
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 30572, 30669);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord>
                f_673_28665_28678_I(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 28665, 28678);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 28357, 30750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 28357, 30750);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void GetCommonEdgeLengths(StringBuilder oldText, StringBuilder newText, out int commonLeadingCount, out int commonTrailingCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(673, 30762, 31763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 30930, 30986);

                int
                maxChars = f_673_30945_30985(f_673_30954_30968(oldText), f_673_30970_30984(newText))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 31002, 31025);

                commonLeadingCount = 0;
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 31039, 31275) || true) && (commonLeadingCount < maxChars)
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 31077, 31097)
   , commonLeadingCount++, DynAbs.Tracing.TraceSender.TraceExitCondition(673, 31039, 31275))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 31039, 31275);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 31131, 31260) || true) && (f_673_31135_31162(oldText, commonLeadingCount) != f_673_31166_31193(newText, commonLeadingCount))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 31131, 31260);
                            DynAbs.Tracing.TraceSender.TraceBreak(673, 31235, 31241);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 31131, 31260);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(673, 1, 237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(673, 1, 237);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 31375, 31416);

                maxChars = maxChars - commonLeadingCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 31432, 31456);

                commonTrailingCount = 0;
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 31470, 31752) || true) && (commonTrailingCount < maxChars)
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 31509, 31530)
   , commonTrailingCount++, DynAbs.Tracing.TraceSender.TraceExitCondition(673, 31470, 31752))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 31470, 31752);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 31564, 31737) || true) && (f_673_31568_31617(oldText, f_673_31576_31590(oldText) - commonTrailingCount - 1) != f_673_31621_31670(newText, f_673_31629_31643(newText) - commonTrailingCount - 1))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 31564, 31737);
                            DynAbs.Tracing.TraceSender.TraceBreak(673, 31712, 31718);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 31564, 31737);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(673, 1, 283);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(673, 1, 283);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(673, 30762, 31763);

                int
                f_673_30954_30968(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 30954, 30968);
                    return return_v;
                }


                int
                f_673_30970_30984(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 30970, 30984);
                    return return_v;
                }


                int
                f_673_30945_30985(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 30945, 30985);
                    return return_v;
                }


                char
                f_673_31135_31162(System.Text.StringBuilder
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 31135, 31162);
                    return return_v;
                }


                char
                f_673_31166_31193(System.Text.StringBuilder
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 31166, 31193);
                    return return_v;
                }


                int
                f_673_31576_31590(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 31576, 31590);
                    return return_v;
                }


                char
                f_673_31568_31617(System.Text.StringBuilder
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 31568, 31617);
                    return return_v;
                }


                int
                f_673_31629_31643(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 31629, 31643);
                    return return_v;
                }


                char
                f_673_31621_31670(System.Text.StringBuilder
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 31621, 31670);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 30762, 31763);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 30762, 31763);
            }
        }

        private static string GetText(Queue<SyntaxNodeOrToken>? queue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(673, 31775, 32179);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 31862, 31968) || true) && (queue == null || (DynAbs.Tracing.TraceSender.Expression_False(673, 31866, 31899) || f_673_31883_31894(queue) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 31862, 31968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 31933, 31953);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 31862, 31968);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 31984, 32026);

                var
                span = f_673_31995_32025(queue, 0, f_673_32013_32024(queue))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 32040, 32085);

                var
                builder = f_673_32054_32084(span.Length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 32101, 32126);

                f_673_32101_32125(queue, builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 32142, 32168);

                return f_673_32149_32167(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(673, 31775, 32179);

                int
                f_673_31883_31894(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 31883, 31894);
                    return return_v;
                }


                int
                f_673_32013_32024(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 32013, 32024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_673_31995_32025(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                queue, int
                first, int
                length)
                {
                    var return_v = GetSpan(queue, first, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 31995, 32025);
                    return return_v;
                }


                System.Text.StringBuilder
                f_673_32054_32084(int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 32054, 32084);
                    return return_v;
                }


                int
                f_673_32101_32125(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                queue, System.Text.StringBuilder
                builder)
                {
                    CopyText(queue, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 32101, 32125);
                    return 0;
                }


                string
                f_673_32149_32167(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 32149, 32167);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 31775, 32179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 31775, 32179);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void CopyText(Queue<SyntaxNodeOrToken>? queue, StringBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(673, 32191, 32637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 32300, 32319);

                builder.Length = 0;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 32335, 32626) || true) && (queue != null && (DynAbs.Tracing.TraceSender.Expression_True(673, 32339, 32371) && f_673_32356_32367(queue) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 32335, 32626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 32405, 32454);

                    var
                    writer = f_673_32418_32453(builder)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 32474, 32576);
                        foreach (var n in f_673_32492_32497_I(queue))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(673, 32474, 32576);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 32539, 32557);

                            n.WriteTo(writer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(673, 32474, 32576);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(673, 1, 103);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(673, 1, 103);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 32596, 32611);

                    f_673_32596_32610(
                                    writer);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(673, 32335, 32626);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(673, 32191, 32637);

                int
                f_673_32356_32367(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 32356, 32367);
                    return return_v;
                }


                System.IO.StringWriter
                f_673_32418_32453(System.Text.StringBuilder
                sb)
                {
                    var return_v = new System.IO.StringWriter(sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 32418, 32453);
                    return return_v;
                }


                System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_673_32492_32497_I(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 32492, 32497);
                    return return_v;
                }


                int
                f_673_32596_32610(System.IO.StringWriter
                this_param)
                {
                    this_param.Flush();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 32596, 32610);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(673, 32191, 32637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 32191, 32637);
            }
        }

        static SyntaxDiffer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(673, 429, 32644);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 491, 511);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(673, 540, 559);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(673, 429, 32644);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(673, 429, 32644);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(673, 429, 32644);

        System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
        f_673_624_670(int
        capacity)
        {
            var return_v = new System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 624, 670);
            return return_v;
        }


        System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
        f_673_735_781(int
        capacity)
        {
            var return_v = new System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 735, 781);
            return return_v;
        }


        System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord>
        f_673_839_863()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxDiffer.ChangeRecord>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 839, 863);
            return return_v;
        }


        System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.GreenNode>
        f_673_1024_1048()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.GreenNode>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 1024, 1048);
            return return_v;
        }


        System.Collections.Generic.HashSet<string>
        f_673_1118_1139()
        {
            var return_v = new System.Collections.Generic.HashSet<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 1118, 1139);
            return return_v;
        }


        static int
        f_673_1258_1300(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
        this_param, Microsoft.CodeAnalysis.SyntaxNode
        item)
        {
            this_param.Push((Microsoft.CodeAnalysis.SyntaxNodeOrToken)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 1258, 1300);
            return 0;
        }


        static int
        f_673_1315_1357(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
        this_param, Microsoft.CodeAnalysis.SyntaxNode
        item)
        {
            this_param.Push((Microsoft.CodeAnalysis.SyntaxNodeOrToken)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(673, 1315, 1357);
            return 0;
        }


        static Microsoft.CodeAnalysis.Text.TextSpan
        f_673_1385_1401(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.FullSpan;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(673, 1385, 1401);
            return return_v;
        }

    }
}
