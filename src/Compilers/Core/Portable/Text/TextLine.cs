// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Text
{

    public readonly struct TextLine : IEquatable<TextLine>
    {

        private readonly SourceText? _text;

        private readonly int _start;

        private readonly int _endIncludingBreaks;

        private TextLine(SourceText text, int start, int endIncludingBreaks)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(732, 620, 821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 713, 726);

                _text = text;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 740, 755);

                _start = start;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 769, 810);

                _endIncludingBreaks = endIncludingBreaks;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(732, 620, 821);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(732, 620, 821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(732, 620, 821);
            }
        }

        public static TextLine FromSpan(SourceText text, TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(732, 1238, 3207);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 1326, 1437) || true) && (text == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(732, 1326, 1437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 1376, 1422);

                    throw f_732_1382_1421(nameof(text));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(732, 1326, 1437);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 1453, 1626) || true) && (span.Start > f_732_1470_1481(text) || (DynAbs.Tracing.TraceSender.Expression_False(732, 1457, 1499) || span.Start < 0) || (DynAbs.Tracing.TraceSender.Expression_False(732, 1457, 1525) || span.End > f_732_1514_1525(text)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(732, 1453, 1626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 1559, 1611);

                    throw f_732_1565_1610(nameof(span));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(732, 1453, 1626);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 1642, 3196) || true) && (f_732_1646_1657(text) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(732, 1642, 3196);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 1743, 1991) || true) && (span.Start > 0 && (DynAbs.Tracing.TraceSender.Expression_True(732, 1747, 1825) && !f_732_1766_1825(f_732_1804_1824(text, span.Start - 1))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(732, 1743, 1991);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 1867, 1972);

                        throw f_732_1873_1971(nameof(span), f_732_1919_1970());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(732, 1743, 1991);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 2011, 2045);

                    bool
                    endIncludesLineBreak = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 2063, 2230) || true) && (span.End > span.Start)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(732, 2063, 2230);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 2130, 2211);

                        endIncludesLineBreak = f_732_2153_2210(f_732_2191_2209(text, span.End - 1));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(732, 2063, 2230);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 2250, 2724) || true) && (!endIncludesLineBreak && (DynAbs.Tracing.TraceSender.Expression_True(732, 2254, 2301) && span.End < f_732_2290_2301(text)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(732, 2250, 2724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 2343, 2413);

                        var
                        lineBreakLen = f_732_2362_2412(text, span.End)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 2435, 2705) || true) && (lineBreakLen > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(732, 2435, 2705);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 2568, 2596);

                            endIncludesLineBreak = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 2622, 2682);

                            span = f_732_2629_2681(span.Start, span.Length + lineBreakLen);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(732, 2435, 2705);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(732, 2250, 2724);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 2800, 3015) || true) && (span.End < f_732_2815_2826(text) && (DynAbs.Tracing.TraceSender.Expression_True(732, 2804, 2851) && !endIncludesLineBreak))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(732, 2800, 3015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 2893, 2996);

                        throw f_732_2899_2995(nameof(span), f_732_2945_2994());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(732, 2800, 3015);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 3035, 3083);

                    return f_732_3042_3082(text, span.Start, span.End);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(732, 1642, 3196);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(732, 1642, 3196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 3149, 3181);

                    return f_732_3156_3180(text, 0, 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(732, 1642, 3196);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(732, 1238, 3207);

                System.ArgumentNullException
                f_732_1382_1421(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(732, 1382, 1421);
                    return return_v;
                }


                int
                f_732_1470_1481(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(732, 1470, 1481);
                    return return_v;
                }


                int
                f_732_1514_1525(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(732, 1514, 1525);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_732_1565_1610(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(732, 1565, 1610);
                    return return_v;
                }


                int
                f_732_1646_1657(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(732, 1646, 1657);
                    return return_v;
                }


                char
                f_732_1804_1824(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(732, 1804, 1824);
                    return return_v;
                }


                bool
                f_732_1766_1825(char
                c)
                {
                    var return_v = TextUtilities.IsAnyLineBreakCharacter(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(732, 1766, 1825);
                    return return_v;
                }


                string
                f_732_1919_1970()
                {
                    var return_v = CodeAnalysisResources.SpanDoesNotIncludeStartOfLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(732, 1919, 1970);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_732_1873_1971(string
                paramName, string
                message)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(732, 1873, 1971);
                    return return_v;
                }


                char
                f_732_2191_2209(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(732, 2191, 2209);
                    return return_v;
                }


                bool
                f_732_2153_2210(char
                c)
                {
                    var return_v = TextUtilities.IsAnyLineBreakCharacter(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(732, 2153, 2210);
                    return return_v;
                }


                int
                f_732_2290_2301(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(732, 2290, 2301);
                    return return_v;
                }


                int
                f_732_2362_2412(Microsoft.CodeAnalysis.Text.SourceText
                text, int
                index)
                {
                    var return_v = TextUtilities.GetLengthOfLineBreak(text, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(732, 2362, 2412);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_732_2629_2681(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(732, 2629, 2681);
                    return return_v;
                }


                int
                f_732_2815_2826(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(732, 2815, 2826);
                    return return_v;
                }


                string
                f_732_2945_2994()
                {
                    var return_v = CodeAnalysisResources.SpanDoesNotIncludeEndOfLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(732, 2945, 2994);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_732_2899_2995(string
                paramName, string
                message)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(732, 2899, 2995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextLine
                f_732_3042_3082(Microsoft.CodeAnalysis.Text.SourceText
                text, int
                start, int
                endIncludingBreaks)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextLine(text, start, endIncludingBreaks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(732, 3042, 3082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextLine
                f_732_3156_3180(Microsoft.CodeAnalysis.Text.SourceText
                text, int
                start, int
                endIncludingBreaks)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextLine(text, start, endIncludingBreaks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(732, 3156, 3180);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(732, 1238, 3207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(732, 1238, 3207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SourceText? Text
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(732, 3349, 3370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 3355, 3368);

                    return _text;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(732, 3349, 3370);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(732, 3301, 3381);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(732, 3301, 3381);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int LineNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(732, 3532, 3665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 3595, 3650);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(732, 3602, 3615) || ((_text != null && DynAbs.Tracing.TraceSender.Conditional_F2(732, 3618, 3645)) || DynAbs.Tracing.TraceSender.Conditional_F3(732, 3648, 3649))) ? f_732_3618_3645(f_732_3618_3629(_text), _start) : 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(732, 3532, 3665);

                    Microsoft.CodeAnalysis.Text.TextLineCollection
                    f_732_3618_3629(Microsoft.CodeAnalysis.Text.SourceText
                    this_param)
                    {
                        var return_v = this_param.Lines;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(732, 3618, 3629);
                        return return_v;
                    }


                    int
                    f_732_3618_3645(Microsoft.CodeAnalysis.Text.TextLineCollection
                    this_param, int
                    position)
                    {
                        var return_v = this_param.IndexOf(position);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(732, 3618, 3645);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(732, 3486, 3676);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(732, 3486, 3676);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int Start
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(732, 3826, 3848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 3832, 3846);

                    return _start;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(732, 3826, 3848);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(732, 3785, 3859);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(732, 3785, 3859);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int End
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(732, 4034, 4092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 4040, 4090);

                    return _endIncludingBreaks - this.LineBreakLength;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(732, 4034, 4092);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(732, 3995, 4103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(732, 3995, 4103);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private int LineBreakLength
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(732, 4167, 4619);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 4203, 4344) || true) && (_text == null || (DynAbs.Tracing.TraceSender.Expression_False(732, 4207, 4241) || f_732_4224_4236(_text) == 0) || (DynAbs.Tracing.TraceSender.Expression_False(732, 4207, 4274) || _endIncludingBreaks == _start))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(732, 4203, 4344);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 4316, 4325);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(732, 4203, 4344);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 4364, 4383);

                    int
                    startLineBreak
                    = default(int);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 4401, 4421);

                    int
                    lineBreakLength
                    = default(int);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 4439, 4563);

                    f_732_4439_4562(_text, _endIncludingBreaks - 1, out startLineBreak, out lineBreakLength);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 4581, 4604);

                    return lineBreakLength;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(732, 4167, 4619);

                    int
                    f_732_4224_4236(Microsoft.CodeAnalysis.Text.SourceText
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(732, 4224, 4236);
                        return return_v;
                    }


                    int
                    f_732_4439_4562(Microsoft.CodeAnalysis.Text.SourceText
                    text, int
                    index, out int
                    startLinebreak, out int
                    lengthLinebreak)
                    {
                        TextUtilities.GetStartAndLengthOfLineBreakEndingAt(text, index, out startLinebreak, out lengthLinebreak);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(732, 4439, 4562);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(732, 4115, 4630);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(732, 4115, 4630);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int EndIncludingLineBreak
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(732, 4819, 4854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 4825, 4852);

                    return _endIncludingBreaks;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(732, 4819, 4854);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(732, 4762, 4865);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(732, 4762, 4865);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TextSpan Span
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(732, 5031, 5088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 5037, 5086);

                    return TextSpan.FromBounds(this.Start, this.End);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(732, 5031, 5088);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(732, 4986, 5099);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(732, 4986, 5099);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TextSpan SpanIncludingLineBreak
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(732, 5279, 5354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 5285, 5352);

                    return TextSpan.FromBounds(this.Start, this.EndIncludingLineBreak);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(732, 5279, 5354);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(732, 5216, 5365);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(732, 5216, 5365);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(732, 5377, 5652);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 5435, 5641) || true) && (_text == null || (DynAbs.Tracing.TraceSender.Expression_False(732, 5439, 5473) || f_732_5456_5468(_text) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(732, 5435, 5641);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 5507, 5527);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(732, 5435, 5641);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(732, 5435, 5641);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 5593, 5626);

                    return f_732_5600_5625(_text, this.Span);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(732, 5435, 5641);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(732, 5377, 5652);

                int
                f_732_5456_5468(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(732, 5456, 5468);
                    return return_v;
                }


                string
                f_732_5600_5625(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.ToString(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(732, 5600, 5625);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(732, 5377, 5652);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(732, 5377, 5652);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(TextLine left, TextLine right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(732, 5664, 5787);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 5750, 5776);

                return left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(732, 5664, 5787);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(732, 5664, 5787);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(732, 5664, 5787);
            }
        }

        public static bool operator !=(TextLine left, TextLine right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(732, 5799, 5923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 5885, 5912);

                return !left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(732, 5799, 5923);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(732, 5799, 5923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(732, 5799, 5923);
            }
        }

        public bool Equals(TextLine other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(732, 5935, 6145);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 5994, 6134);

                return other._text == _text
                && (DynAbs.Tracing.TraceSender.Expression_True(732, 6001, 6064) && other._start == _start
                ) && (DynAbs.Tracing.TraceSender.Expression_True(732, 6001, 6133) && other._endIncludingBreaks == _endIncludingBreaks);
                DynAbs.Tracing.TraceSender.TraceExitMethod(732, 5935, 6145);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(732, 5935, 6145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(732, 5935, 6145);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(732, 6157, 6359);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 6222, 6319) || true) && (obj is TextLine)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(732, 6222, 6319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 6275, 6304);

                    return Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(732, 6222, 6319);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 6335, 6348);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(732, 6157, 6359);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(732, 6157, 6359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(732, 6157, 6359);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(732, 6371, 6510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(732, 6429, 6499);

                return f_732_6436_6498(_text, f_732_6456_6497(_start, _endIncludingBreaks));
                DynAbs.Tracing.TraceSender.TraceExitMethod(732, 6371, 6510);

                int
                f_732_6456_6497(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(732, 6456, 6497);
                    return return_v;
                }


                int
                f_732_6436_6498(Microsoft.CodeAnalysis.Text.SourceText?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(732, 6436, 6498);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(732, 6371, 6510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(732, 6371, 6510);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static TextLine()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(732, 413, 6517);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(732, 413, 6517);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(732, 413, 6517);
        }
    }
}
