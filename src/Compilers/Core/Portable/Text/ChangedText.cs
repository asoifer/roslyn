// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Text
{
    internal sealed class ChangedText : SourceText
    {
        private readonly SourceText _newText;

        private readonly ChangeInfo _info;

        public ChangedText(SourceText oldText, SourceText newText, ImmutableArray<TextChangeRange> changeRanges)
        : base(checksumAlgorithm: f_713_741_785_C(f_713_760_785(oldText)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(713, 616, 1419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 551, 559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 598, 603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 811, 847);

                f_713_811_846(newText != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 861, 971);

                f_713_861_970(newText is CompositeText || (DynAbs.Tracing.TraceSender.Expression_False(713, 874, 920) || newText is SubText) || (DynAbs.Tracing.TraceSender.Expression_False(713, 874, 945) || newText is StringText) || (DynAbs.Tracing.TraceSender.Expression_False(713, 874, 969) || newText is LargeText));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 985, 1021);

                f_713_985_1020(oldText != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 1035, 1068);

                f_713_1035_1067(oldText != newText);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 1082, 1120);

                f_713_1082_1119(f_713_1095_1118_M(!changeRanges.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 1134, 1195);

                f_713_1134_1194(oldText, newText, changeRanges);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 1211, 1230);

                _newText = newText;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 1267, 1408);

                _info = f_713_1275_1407(changeRanges, f_713_1304_1342(oldText), (DynAbs.Tracing.TraceSender.Conditional_F1(713, 1344, 1368) || (((oldText is ChangedText) && DynAbs.Tracing.TraceSender.Conditional_F2(713, 1371, 1399)) || DynAbs.Tracing.TraceSender.Conditional_F3(713, 1402, 1406))) ? ((ChangedText)oldText)._info : null);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(713, 616, 1419);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(713, 616, 1419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 616, 1419);
            }
        }

        private static void RequiresChangeRangesAreValid(
                    SourceText oldText, SourceText newText, ImmutableArray<TextChangeRange> changeRanges)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(713, 1431, 2596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 1604, 1624);

                var
                deltaLength = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 1638, 1745);
                    foreach (var change in f_713_1661_1673_I(changeRanges))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 1638, 1745);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 1692, 1745);

                        deltaLength += change.NewLength - change.Span.Length;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(713, 1638, 1745);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(713, 1, 108);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(713, 1, 108);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 1761, 1949) || true) && (f_713_1765_1779(oldText) + deltaLength != f_713_1797_1811(newText))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 1761, 1949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 1830, 1949);

                    throw f_713_1836_1948("Delta length difference of change ranges didn't match before/after text length.");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(713, 1761, 1949);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 1965, 1982);

                var
                position = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 1996, 2585);
                    foreach (var change in f_713_2019_2031_I(changeRanges))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 1996, 2585);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 2065, 2203) || true) && (change.Span.Start < position)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 2065, 2203);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 2120, 2203);

                            throw f_713_2126_2202("Change preceded current position in oldText");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(713, 2065, 2203);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 2223, 2365) || true) && (change.Span.Start > f_713_2247_2261(oldText))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 2223, 2365);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 2284, 2365);

                            throw f_713_2290_2364("Change start was after the end of oldText");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(713, 2223, 2365);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 2385, 2523) || true) && (change.Span.End > f_713_2407_2421(oldText))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 2385, 2523);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 2444, 2523);

                            throw f_713_2450_2522("Change end was after the end of oldText");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(713, 2385, 2523);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 2543, 2570);

                        position = change.Span.End;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(713, 1996, 2585);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(713, 1, 590);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(713, 1, 590);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(713, 1431, 2596);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_713_1661_1673_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 1661, 1673);
                    return return_v;
                }


                int
                f_713_1765_1779(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 1765, 1779);
                    return return_v;
                }


                int
                f_713_1797_1811(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 1797, 1811);
                    return return_v;
                }


                System.InvalidOperationException
                f_713_1836_1948(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 1836, 1948);
                    return return_v;
                }


                System.InvalidOperationException
                f_713_2126_2202(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 2126, 2202);
                    return return_v;
                }


                int
                f_713_2247_2261(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 2247, 2261);
                    return return_v;
                }


                System.InvalidOperationException
                f_713_2290_2364(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 2290, 2364);
                    return return_v;
                }


                int
                f_713_2407_2421(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 2407, 2421);
                    return return_v;
                }


                System.InvalidOperationException
                f_713_2450_2522(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 2450, 2522);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_713_2019_2031_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 2019, 2031);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(713, 1431, 2596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 1431, 2596);
            }
        }
        private class ChangeInfo
        {
            public ImmutableArray<TextChangeRange> ChangeRanges { get; }

            public WeakReference<SourceText> WeakOldText { get; }

            public ChangeInfo? Previous { get; private set; }

            public ChangeInfo(ImmutableArray<TextChangeRange> changeRanges, WeakReference<SourceText> weakOldText, ChangeInfo? previous)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(713, 3052, 3375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 2918, 2971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 2987, 3036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 3209, 3242);

                    this.ChangeRanges = changeRanges;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 3260, 3291);

                    this.WeakOldText = weakOldText;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 3309, 3334);

                    this.Previous = previous;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 3352, 3360);

                    f_713_3352_3359(this);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(713, 3052, 3375);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(713, 3052, 3375);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 3052, 3375);
                }
            }

            private void Clean()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(713, 3417, 4239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 3559, 3587);

                    ChangeInfo?
                    lastInfo = this
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 3622, 3633);
                        for (ChangeInfo?
        info = this
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 3605, 3899) || true) && (info != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 3649, 3669)
        , info = f_713_3656_3669(info), DynAbs.Tracing.TraceSender.TraceExitCondition(713, 3605, 3899))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 3605, 3899);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 3711, 3727);

                            SourceText?
                            tmp
                            = default(SourceText?);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 3749, 3880) || true) && (f_713_3753_3791(f_713_3753_3769(info), out tmp))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 3749, 3880);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 3841, 3857);

                                lastInfo = info;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(713, 3749, 3880);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(713, 1, 295);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(713, 1, 295);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 3995, 4012);

                    ChangeInfo?
                    prev
                    = default(ChangeInfo?);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 4030, 4224) || true) && (lastInfo != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 4030, 4224);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 4095, 4120);

                            prev = f_713_4102_4119(lastInfo);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 4142, 4167);

                            lastInfo.Previous = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 4189, 4205);

                            lastInfo = prev;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(713, 4030, 4224);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(713, 4030, 4224);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(713, 4030, 4224);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(713, 3417, 4239);

                    Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo?
                    f_713_3656_3669(Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo
                    this_param)
                    {
                        var return_v = this_param.Previous;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 3656, 3669);
                        return return_v;
                    }


                    System.WeakReference<Microsoft.CodeAnalysis.Text.SourceText>
                    f_713_3753_3769(Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo
                    this_param)
                    {
                        var return_v = this_param.WeakOldText;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 3753, 3769);
                        return return_v;
                    }


                    bool
                    f_713_3753_3791(System.WeakReference<Microsoft.CodeAnalysis.Text.SourceText>
                    this_param, out Microsoft.CodeAnalysis.Text.SourceText?
                    target)
                    {
                        var return_v = this_param.TryGetTarget(out target);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 3753, 3791);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo?
                    f_713_4102_4119(Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo
                    this_param)
                    {
                        var return_v = this_param.Previous;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 4102, 4119);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(713, 3417, 4239);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 3417, 4239);
                }
            }

            static ChangeInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(713, 2608, 4250);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(713, 2608, 4250);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 2608, 4250);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(713, 2608, 4250);

            static int
            f_713_3352_3359(Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo
            this_param)
            {
                this_param.Clean();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 3352, 3359);
                return 0;
            }

        }

        public override Encoding? Encoding
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(713, 4321, 4354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 4327, 4352);

                    return f_713_4334_4351(_newText);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(713, 4321, 4354);

                    System.Text.Encoding?
                    f_713_4334_4351(Microsoft.CodeAnalysis.Text.SourceText
                    this_param)
                    {
                        var return_v = this_param.Encoding;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 4334, 4351);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(713, 4262, 4365);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 4262, 4365);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IEnumerable<TextChangeRange> Changes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(713, 4445, 4479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 4451, 4477);

                    return f_713_4458_4476(_info);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(713, 4445, 4479);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                    f_713_4458_4476(Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo
                    this_param)
                    {
                        var return_v = this_param.ChangeRanges;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 4458, 4476);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(713, 4377, 4490);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 4377, 4490);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Length
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(713, 4553, 4584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 4559, 4582);

                    return f_713_4566_4581(_newText);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(713, 4553, 4584);

                    int
                    f_713_4566_4581(Microsoft.CodeAnalysis.Text.SourceText
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 4566, 4581);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(713, 4502, 4595);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 4502, 4595);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int StorageSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(713, 4665, 4701);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 4671, 4699);

                    return f_713_4678_4698(_newText);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(713, 4665, 4701);

                    int
                    f_713_4678_4698(Microsoft.CodeAnalysis.Text.SourceText
                    this_param)
                    {
                        var return_v = this_param.StorageSize;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 4678, 4698);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(713, 4607, 4712);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 4607, 4712);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<SourceText> Segments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(713, 4802, 4835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 4808, 4833);

                    return f_713_4815_4832(_newText);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(713, 4802, 4835);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.SourceText>
                    f_713_4815_4832(Microsoft.CodeAnalysis.Text.SourceText
                    this_param)
                    {
                        var return_v = this_param.Segments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 4815, 4832);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(713, 4724, 4846);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 4724, 4846);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override SourceText StorageKey
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(713, 4922, 4957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 4928, 4955);

                    return f_713_4935_4954(_newText);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(713, 4922, 4957);

                    Microsoft.CodeAnalysis.Text.SourceText
                    f_713_4935_4954(Microsoft.CodeAnalysis.Text.SourceText
                    this_param)
                    {
                        var return_v = this_param.StorageKey;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 4935, 4954);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(713, 4858, 4968);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 4858, 4968);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override char this[int position]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(713, 5044, 5078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 5050, 5076);

                    return f_713_5057_5075(_newText, position);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(713, 5044, 5078);

                    char
                    f_713_5057_5075(Microsoft.CodeAnalysis.Text.SourceText
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 5057, 5075);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(713, 5044, 5078);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 5044, 5078);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString(TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(713, 5101, 5214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 5172, 5203);

                return f_713_5179_5202(_newText, span);
                DynAbs.Tracing.TraceSender.TraceExitMethod(713, 5101, 5214);

                string
                f_713_5179_5202(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.ToString(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 5179, 5202);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(713, 5101, 5214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 5101, 5214);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override SourceText GetSubText(TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(713, 5226, 5347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 5303, 5336);

                return f_713_5310_5335(_newText, span);
                DynAbs.Tracing.TraceSender.TraceExitMethod(713, 5226, 5347);

                Microsoft.CodeAnalysis.Text.SourceText
                f_713_5310_5335(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetSubText(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 5310, 5335);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(713, 5226, 5347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 5226, 5347);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(713, 5359, 5559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 5481, 5548);

                f_713_5481_5547(_newText, sourceIndex, destination, destinationIndex, count);
                DynAbs.Tracing.TraceSender.TraceExitMethod(713, 5359, 5559);

                int
                f_713_5481_5547(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                sourceIndex, char[]
                destination, int
                destinationIndex, int
                count)
                {
                    this_param.CopyTo(sourceIndex, destination, destinationIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 5481, 5547);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(713, 5359, 5559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 5359, 5559);
            }
        }

        public override SourceText WithChanges(IEnumerable<TextChange> changes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(713, 5571, 6398);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 6021, 6080);

                var
                changed = f_713_6035_6064(_newText, changes) as ChangedText
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 6094, 6387) || true) && (changed != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 6094, 6387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 6147, 6222);

                    return f_713_6154_6221(this, changed._newText, f_713_6194_6220(changed._info));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(713, 6094, 6387);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 6094, 6387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 6360, 6372);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(713, 6094, 6387);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(713, 5571, 6398);

                Microsoft.CodeAnalysis.Text.SourceText
                f_713_6035_6064(Microsoft.CodeAnalysis.Text.SourceText
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextChange>
                changes)
                {
                    var return_v = this_param.WithChanges(changes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 6035, 6064);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_713_6194_6220(Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo
                this_param)
                {
                    var return_v = this_param.ChangeRanges;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 6194, 6220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.ChangedText
                f_713_6154_6221(Microsoft.CodeAnalysis.Text.ChangedText
                oldText, Microsoft.CodeAnalysis.Text.SourceText
                newText, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                changeRanges)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.ChangedText((Microsoft.CodeAnalysis.Text.SourceText)oldText, newText, changeRanges);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 6154, 6221);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(713, 5571, 6398);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 5571, 6398);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IReadOnlyList<TextChangeRange> GetChangeRanges(SourceText oldText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(713, 6410, 8029);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 6517, 6634) || true) && (oldText == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 6517, 6634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 6570, 6619);

                    throw f_713_6576_6618(nameof(oldText));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(713, 6517, 6634);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 6650, 6751) || true) && (this == oldText)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 6650, 6751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 6703, 6736);

                    return TextChangeRange.NoChanges;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(713, 6650, 6751);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 6810, 6836);

                SourceText?
                actualOldText
                = default(SourceText?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 6850, 7123) || true) && (f_713_6854_6903(f_713_6854_6871(_info), out actualOldText) && (DynAbs.Tracing.TraceSender.Expression_True(713, 6854, 6931) && actualOldText == oldText))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 6850, 7123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 7082, 7108);

                    return f_713_7089_7107(_info);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(713, 6850, 7123);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 7257, 7501) || true) && (f_713_7261_7283(this, oldText))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 7257, 7501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 7317, 7364);

                    var
                    changes = f_713_7331_7363(oldText, this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 7382, 7486) || true) && (f_713_7386_7399(changes) > 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 7382, 7486);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 7445, 7467);

                        return f_713_7452_7466(changes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(713, 7382, 7486);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(713, 7257, 7501);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 7646, 7902) || true) && (actualOldText != null && (DynAbs.Tracing.TraceSender.Expression_True(713, 7650, 7724) && f_713_7675_7719(f_713_7675_7713(actualOldText, oldText)) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 7646, 7902);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 7861, 7887);

                    return f_713_7868_7886(_info);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(713, 7646, 7902);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 7918, 8018);

                return f_713_7925_8017(f_713_7947_8016(f_713_7967_7998(0, f_713_7983_7997(oldText)), f_713_8000_8015(_newText)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(713, 6410, 8029);

                System.ArgumentNullException
                f_713_6576_6618(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 6576, 6618);
                    return return_v;
                }


                System.WeakReference<Microsoft.CodeAnalysis.Text.SourceText>
                f_713_6854_6871(Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo
                this_param)
                {
                    var return_v = this_param.WeakOldText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 6854, 6871);
                    return return_v;
                }


                bool
                f_713_6854_6903(System.WeakReference<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, out Microsoft.CodeAnalysis.Text.SourceText?
                target)
                {
                    var return_v = this_param.TryGetTarget(out target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 6854, 6903);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_713_7089_7107(Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo
                this_param)
                {
                    var return_v = this_param.ChangeRanges;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 7089, 7107);
                    return return_v;
                }


                bool
                f_713_7261_7283(Microsoft.CodeAnalysis.Text.ChangedText
                this_param, Microsoft.CodeAnalysis.Text.SourceText
                oldText)
                {
                    var return_v = this_param.IsChangedFrom(oldText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 7261, 7283);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>>
                f_713_7331_7363(Microsoft.CodeAnalysis.Text.SourceText
                oldText, Microsoft.CodeAnalysis.Text.ChangedText
                newText)
                {
                    var return_v = GetChangesBetween(oldText, newText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 7331, 7363);
                    return return_v;
                }


                int
                f_713_7386_7399(System.Collections.Generic.IReadOnlyList<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 7386, 7399);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_713_7452_7466(System.Collections.Generic.IReadOnlyList<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>>
                changeSets)
                {
                    var return_v = Merge(changeSets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 7452, 7466);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_713_7675_7713(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.SourceText
                oldText)
                {
                    var return_v = this_param.GetChangeRanges(oldText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 7675, 7713);
                    return return_v;
                }


                int
                f_713_7675_7719(System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Text.TextChangeRange>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 7675, 7719);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_713_7868_7886(Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo
                this_param)
                {
                    var return_v = this_param.ChangeRanges;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 7868, 7886);
                    return return_v;
                }


                int
                f_713_7983_7997(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 7983, 7997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_713_7967_7998(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 7967, 7998);
                    return return_v;
                }


                int
                f_713_8000_8015(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 8000, 8015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextChangeRange
                f_713_7947_8016(Microsoft.CodeAnalysis.Text.TextSpan
                span, int
                newLength)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextChangeRange(span, newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 7947, 8016);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_713_7925_8017(Microsoft.CodeAnalysis.Text.TextChangeRange
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 7925, 8017);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(713, 6410, 8029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 6410, 8029);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsChangedFrom(SourceText oldText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(713, 8041, 8436);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 8129, 8141);
                    for (ChangeInfo?
        info = _info
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 8112, 8396) || true) && (info != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 8157, 8177)
        , info = f_713_8164_8177(info), DynAbs.Tracing.TraceSender.TraceExitCondition(713, 8112, 8396))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 8112, 8396);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 8211, 8228);

                        SourceText?
                        text
                        = default(SourceText?);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 8246, 8381) || true) && (f_713_8250_8289(f_713_8250_8266(info), out text) && (DynAbs.Tracing.TraceSender.Expression_True(713, 8250, 8308) && text == oldText))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 8246, 8381);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 8350, 8362);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(713, 8246, 8381);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(713, 1, 285);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(713, 1, 285);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 8412, 8425);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(713, 8041, 8436);

                Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo?
                f_713_8164_8177(Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo
                this_param)
                {
                    var return_v = this_param.Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 8164, 8177);
                    return return_v;
                }


                System.WeakReference<Microsoft.CodeAnalysis.Text.SourceText>
                f_713_8250_8266(Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo
                this_param)
                {
                    var return_v = this_param.WeakOldText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 8250, 8266);
                    return return_v;
                }


                bool
                f_713_8250_8289(System.WeakReference<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, out Microsoft.CodeAnalysis.Text.SourceText?
                target)
                {
                    var return_v = this_param.TryGetTarget(out target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 8250, 8289);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(713, 8041, 8436);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 8041, 8436);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IReadOnlyList<ImmutableArray<TextChangeRange>> GetChangesBetween(SourceText oldText, ChangedText newText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(713, 8448, 9346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 8593, 8648);

                var
                list = f_713_8604_8647()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 8664, 8699);

                ChangeInfo?
                change = newText._info
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 8713, 8743);

                f_713_8713_8742(list, f_713_8722_8741(change));
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 8759, 9223) || true) && (change != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 8759, 9223);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 8814, 8840);

                        SourceText?
                        actualOldText
                        = default(SourceText?);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 8858, 8909);

                        f_713_8858_8908(f_713_8858_8876(change), out actualOldText);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 8929, 9030) || true) && (actualOldText == oldText)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 8929, 9030);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 8999, 9011);

                            return list;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(713, 8929, 9030);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 9050, 9075);

                        change = f_713_9059_9074(change);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 9093, 9208) || true) && (change != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 9093, 9208);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 9153, 9189);

                            f_713_9153_9188(list, 0, f_713_9168_9187(change));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(713, 9093, 9208);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(713, 8759, 9223);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(713, 8759, 9223);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(713, 8759, 9223);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 9296, 9309);

                f_713_9296_9308(
                            // did not find old text, so not connected?
                            list);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 9323, 9335);

                return list;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(713, 8448, 9346);

                System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>>
                f_713_8604_8647()
                {
                    var return_v = new System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 8604, 8647);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_713_8722_8741(Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo
                this_param)
                {
                    var return_v = this_param.ChangeRanges;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 8722, 8741);
                    return return_v;
                }


                int
                f_713_8713_8742(System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 8713, 8742);
                    return 0;
                }


                System.WeakReference<Microsoft.CodeAnalysis.Text.SourceText>
                f_713_8858_8876(Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo
                this_param)
                {
                    var return_v = this_param.WeakOldText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 8858, 8876);
                    return return_v;
                }


                bool
                f_713_8858_8908(System.WeakReference<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, out Microsoft.CodeAnalysis.Text.SourceText?
                target)
                {
                    var return_v = this_param.TryGetTarget(out target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 8858, 8908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo?
                f_713_9059_9074(Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo
                this_param)
                {
                    var return_v = this_param.Previous;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 9059, 9074);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_713_9168_9187(Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo
                this_param)
                {
                    var return_v = this_param.ChangeRanges;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 9168, 9187);
                    return return_v;
                }


                int
                f_713_9153_9188(System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>>
                this_param, int
                index, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                item)
                {
                    this_param.Insert(index, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 9153, 9188);
                    return 0;
                }


                int
                f_713_9296_9308(System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 9296, 9308);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(713, 8448, 9346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 8448, 9346);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<TextChangeRange> Merge(IReadOnlyList<ImmutableArray<TextChangeRange>> changeSets)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(713, 9358, 9781);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 9494, 9529);

                f_713_9494_9528(f_713_9507_9523(changeSets) > 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 9545, 9572);

                var
                merged = f_713_9558_9571(changeSets, 0)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 9595, 9600);
                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 9586, 9740) || true) && (i < f_713_9606_9622(changeSets))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 9624, 9627)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(713, 9586, 9740))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 9586, 9740);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 9661, 9725);

                        merged = f_713_9670_9724(merged, f_713_9710_9723(changeSets, i));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(713, 1, 155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(713, 1, 155);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 9756, 9770);

                return merged;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(713, 9358, 9781);

                int
                f_713_9507_9523(System.Collections.Generic.IReadOnlyList<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 9507, 9523);
                    return return_v;
                }


                int
                f_713_9494_9528(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 9494, 9528);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_713_9558_9571(System.Collections.Generic.IReadOnlyList<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 9558, 9571);
                    return return_v;
                }


                int
                f_713_9606_9622(System.Collections.Generic.IReadOnlyList<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 9606, 9622);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_713_9710_9723(System.Collections.Generic.IReadOnlyList<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 9710, 9723);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_713_9670_9724(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                oldChanges, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                newChanges)
                {
                    var return_v = TextChangeRangeExtensions.Merge(oldChanges, newChanges);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 9670, 9724);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(713, 9358, 9781);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 9358, 9781);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override TextLineCollection GetLinesCore()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(713, 9945, 14307);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 10022, 10042);

                SourceText?
                oldText
                = default(SourceText?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 10056, 10088);

                TextLineCollection?
                oldLineInfo
                = default(TextLineCollection?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 10104, 10329) || true) && (!f_713_10109_10152(f_713_10109_10126(_info), out oldText) || (DynAbs.Tracing.TraceSender.Expression_False(713, 10108, 10193) || !f_713_10157_10193(oldText, out oldLineInfo)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 10104, 10329);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 10287, 10314);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetLinesCore(), 713, 10294, 10313);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(713, 10104, 10329);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 10447, 10496);

                var
                lineStarts = f_713_10464_10495()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 10510, 10528);

                f_713_10510_10527(lineStarts, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 10594, 10611);

                var
                position = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 10738, 10752);

                var
                delta = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 10915, 10938);

                var
                endsWithCR = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 10954, 13474);
                    foreach (var change in f_713_10977_10995_I(f_713_10977_10995(_info)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 10954, 13474);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 11108, 12345) || true) && (change.Span.Start > position)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 11108, 12345);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 11182, 11497) || true) && (endsWithCR && (DynAbs.Tracing.TraceSender.Expression_True(713, 11186, 11234) && f_713_11200_11226(_newText, position + delta) == '\n'))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 11182, 11497);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 11450, 11474);

                                f_713_11450_11473(                        // remove last added line start (it was due to previous CR)
                                                                          // a new line start including the LF will be added next
                                                        lineStarts);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(713, 11182, 11497);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 11521, 11613);

                            var
                            lps = f_713_11531_11612(oldLineInfo, TextSpan.FromBounds(position, change.Span.Start))
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 11644, 11666);
                                for (int
            i = lps.Start.Line + 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 11635, 11808) || true) && (i <= lps.End.Line)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 11687, 11690)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(713, 11635, 11808))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 11635, 11808);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 11740, 11785);

                                    f_713_11740_11784(lineStarts, oldLineInfo[i].Start + delta);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(713, 1, 174);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(713, 1, 174);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 11832, 11884);

                            endsWithCR = f_713_11845_11875(oldText, change.Span.Start - 1) == '\r';

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 12121, 12326) || true) && (endsWithCR && (DynAbs.Tracing.TraceSender.Expression_True(713, 12125, 12173) && change.Span.Start < f_713_12159_12173(oldText)) && (DynAbs.Tracing.TraceSender.Expression_True(713, 12125, 12211) && f_713_12177_12203(oldText, change.Span.Start) == '\n'))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 12121, 12326);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 12261, 12303);

                                f_713_12261_12302(lineStarts, change.Span.Start + delta);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(713, 12121, 12326);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(713, 11108, 12345);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 12443, 13345) || true) && (change.NewLength > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 12443, 13345);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 12509, 12553);

                            var
                            changeStart = change.Span.Start + delta
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 12575, 12642);

                            var
                            text = f_713_12586_12641(this, f_713_12597_12640(changeStart, change.NewLength))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 12666, 12962) || true) && (endsWithCR && (DynAbs.Tracing.TraceSender.Expression_True(713, 12670, 12699) && f_713_12684_12691(text, 0) == '\n'))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 12666, 12962);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 12915, 12939);

                                f_713_12915_12938(                        // remove last added line start (it was due to previous CR)
                                                                          // a new line start including the LF will be added next
                                                        lineStarts);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(713, 12666, 12962);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 13099, 13104);

                                // Skip first line (it is always at offset 0 and corresponds to the previous line)
                                for (int
            i = 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 13090, 13254) || true) && (i < f_713_13110_13126(f_713_13110_13120(text)))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 13128, 13131)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(713, 13090, 13254))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 13090, 13254);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 13181, 13231);

                                    f_713_13181_13230(lineStarts, changeStart + f_713_13210_13220(text)[i].Start);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(713, 1, 165);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(713, 1, 165);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 13278, 13326);

                            endsWithCR = f_713_13291_13317(text, change.NewLength - 1) == '\r';
                            DynAbs.Tracing.TraceSender.TraceExitCondition(713, 12443, 13345);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 13365, 13392);

                        position = change.Span.End;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 13410, 13459);

                        delta += (change.NewLength - change.Span.Length);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(713, 10954, 13474);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(713, 1, 2521);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(713, 1, 2521);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 13564, 14225) || true) && (position < f_713_13579_13593(oldText))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 13564, 14225);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 13627, 13922) || true) && (endsWithCR && (DynAbs.Tracing.TraceSender.Expression_True(713, 13631, 13679) && f_713_13645_13671(_newText, position + delta) == '\n'))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 13627, 13922);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 13879, 13903);

                        f_713_13879_13902(                    // remove last added line start (it was due to previous CR)
                                                              // a new line start including the LF will be added next
                                            lineStarts);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(713, 13627, 13922);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 13942, 14031);

                    var
                    lps = f_713_13952_14030(oldLineInfo, TextSpan.FromBounds(position, f_713_14014_14028(oldText)))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 14058, 14080);
                        for (int
        i = lps.Start.Line + 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 14049, 14210) || true) && (i <= lps.End.Line)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 14101, 14104)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(713, 14049, 14210))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(713, 14049, 14210);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 14146, 14191);

                            f_713_14146_14190(lineStarts, oldLineInfo[i].Start + delta);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(713, 1, 162);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(713, 1, 162);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(713, 13564, 14225);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 14241, 14296);

                return f_713_14248_14295(this, f_713_14267_14294(lineStarts));
                DynAbs.Tracing.TraceSender.TraceExitMethod(713, 9945, 14307);

                System.WeakReference<Microsoft.CodeAnalysis.Text.SourceText>
                f_713_10109_10126(Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo
                this_param)
                {
                    var return_v = this_param.WeakOldText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 10109, 10126);
                    return return_v;
                }


                bool
                f_713_10109_10152(System.WeakReference<Microsoft.CodeAnalysis.Text.SourceText>
                this_param, out Microsoft.CodeAnalysis.Text.SourceText?
                target)
                {
                    var return_v = this_param.TryGetTarget(out target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 10109, 10152);
                    return return_v;
                }


                bool
                f_713_10157_10193(Microsoft.CodeAnalysis.Text.SourceText
                this_param, out Microsoft.CodeAnalysis.Text.TextLineCollection?
                lines)
                {
                    var return_v = this_param.TryGetLines(out lines);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 10157, 10193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                f_713_10464_10495()
                {
                    var return_v = ArrayBuilder<int>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 10464, 10495);
                    return return_v;
                }


                int
                f_713_10510_10527(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 10510, 10527);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_713_10977_10995(Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo
                this_param)
                {
                    var return_v = this_param.ChangeRanges;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 10977, 10995);
                    return return_v;
                }


                char
                f_713_11200_11226(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 11200, 11226);
                    return return_v;
                }


                int
                f_713_11450_11473(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    this_param.RemoveLast();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 11450, 11473);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.LinePositionSpan
                f_713_11531_11612(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetLinePositionSpan(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 11531, 11612);
                    return return_v;
                }


                int
                f_713_11740_11784(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 11740, 11784);
                    return 0;
                }


                char
                f_713_11845_11875(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 11845, 11875);
                    return return_v;
                }


                int
                f_713_12159_12173(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 12159, 12173);
                    return return_v;
                }


                char
                f_713_12177_12203(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 12177, 12203);
                    return return_v;
                }


                int
                f_713_12261_12302(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 12261, 12302);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_713_12597_12640(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 12597, 12640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_713_12586_12641(Microsoft.CodeAnalysis.Text.ChangedText
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetSubText(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 12586, 12641);
                    return return_v;
                }


                char
                f_713_12684_12691(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 12684, 12691);
                    return return_v;
                }


                int
                f_713_12915_12938(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    this_param.RemoveLast();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 12915, 12938);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.TextLineCollection
                f_713_13110_13120(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Lines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 13110, 13120);
                    return return_v;
                }


                int
                f_713_13110_13126(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 13110, 13126);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextLineCollection
                f_713_13210_13220(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Lines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 13210, 13220);
                    return return_v;
                }


                int
                f_713_13181_13230(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 13181, 13230);
                    return 0;
                }


                char
                f_713_13291_13317(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 13291, 13317);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_713_10977_10995_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 10977, 10995);
                    return return_v;
                }


                int
                f_713_13579_13593(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 13579, 13593);
                    return return_v;
                }


                char
                f_713_13645_13671(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 13645, 13671);
                    return return_v;
                }


                int
                f_713_13879_13902(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    this_param.RemoveLast();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 13879, 13902);
                    return 0;
                }


                int
                f_713_14014_14028(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 14014, 14028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.LinePositionSpan
                f_713_13952_14030(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetLinePositionSpan(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 13952, 14030);
                    return return_v;
                }


                int
                f_713_14146_14190(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 14146, 14190);
                    return 0;
                }


                int[]
                f_713_14267_14294(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    var return_v = this_param.ToArrayAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 14267, 14294);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText.LineInfo
                f_713_14248_14295(Microsoft.CodeAnalysis.Text.ChangedText
                text, int[]
                lineStarts)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.SourceText.LineInfo((Microsoft.CodeAnalysis.Text.SourceText)text, lineStarts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 14248, 14295);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(713, 9945, 14307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 9945, 14307);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        internal static class TestAccessor
        {
            public static ImmutableArray<TextChangeRange> Merge(ImmutableArray<TextChangeRange> oldChanges, ImmutableArray<TextChangeRange> newChanges)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(713, 14535, 14593);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(713, 14538, 14593);
                    return f_713_14538_14593(oldChanges, newChanges); DynAbs.Tracing.TraceSender.TraceExitMethod(713, 14535, 14593);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(713, 14535, 14593);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 14535, 14593);
                }
                throw new System.Exception("Slicer error: unreachable code");

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_713_14538_14593(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                oldChanges, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                newChanges)
                {
                    var return_v = TextChangeRangeExtensions.Merge(oldChanges, newChanges);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 14538, 14593);
                    return return_v;
                }

            }

            static TestAccessor()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(713, 14319, 14605);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(713, 14319, 14605);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 14319, 14605);
            }

        }

        static ChangedText()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(713, 460, 14612);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(713, 460, 14612);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(713, 460, 14612);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(713, 460, 14612);

        static Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
        f_713_760_785(Microsoft.CodeAnalysis.Text.SourceText
        this_param)
        {
            var return_v = this_param.ChecksumAlgorithm;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 760, 785);
            return return_v;
        }


        static int
        f_713_811_846(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 811, 846);
            return 0;
        }


        static int
        f_713_861_970(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 861, 970);
            return 0;
        }


        static int
        f_713_985_1020(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 985, 1020);
            return 0;
        }


        static int
        f_713_1035_1067(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 1035, 1067);
            return 0;
        }


        bool
        f_713_1095_1118_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(713, 1095, 1118);
            return return_v;
        }


        static int
        f_713_1082_1119(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 1082, 1119);
            return 0;
        }


        static int
        f_713_1134_1194(Microsoft.CodeAnalysis.Text.SourceText
        oldText, Microsoft.CodeAnalysis.Text.SourceText
        newText, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
        changeRanges)
        {
            RequiresChangeRangesAreValid(oldText, newText, changeRanges);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 1134, 1194);
            return 0;
        }


        static System.WeakReference<Microsoft.CodeAnalysis.Text.SourceText>
        f_713_1304_1342(Microsoft.CodeAnalysis.Text.SourceText
        target)
        {
            var return_v = new System.WeakReference<Microsoft.CodeAnalysis.Text.SourceText>(target);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 1304, 1342);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo
        f_713_1275_1407(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
        changeRanges, System.WeakReference<Microsoft.CodeAnalysis.Text.SourceText>
        weakOldText, Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo?
        previous)
        {
            var return_v = new Microsoft.CodeAnalysis.Text.ChangedText.ChangeInfo(changeRanges, weakOldText, previous);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(713, 1275, 1407);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
        f_713_741_785_C(Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(713, 616, 1419);
            return return_v;
        }

    }
}
