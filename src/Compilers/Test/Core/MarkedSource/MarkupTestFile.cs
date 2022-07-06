// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Roslyn.Test.Utilities
{
    public static class MarkupTestFile
    {
        private const string
        PositionString = "$$"
        ;

        private const string
        SpanStartString = "[|"
        ;

        private const string
        SpanEndString = "|]"
        ;

        private const string
        NamedSpanStartString = "{|"
        ;

        private const string
        NamedSpanEndString = "|}"
        ;

        private static readonly Regex s_namedSpanStartRegex;

        private static void Parse(
                    string input, out string output, out int? position, out IDictionary<string, ArrayBuilder<TextSpan>> spans)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25098, 2299, 8074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 2470, 2486);

                position = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 2500, 2565);

                var
                tempSpans = f_25098_2516_2564()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 2581, 2621);

                var
                outputBuilder = f_25098_2601_2620()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 2637, 2665);

                var
                currentIndexInInput = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 2679, 2705);

                var
                inputOutputOffset = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 2885, 2949);

                var
                spanStartStack = f_25098_2906_2948()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 2963, 3032);

                var
                namedSpanStartStack = f_25098_2989_3031()
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 3048, 7396) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25098, 3048, 7396);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 3093, 3149);

                        var
                        matches = f_25098_3107_3148()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 3167, 3229);

                        f_25098_3167_3228(input, PositionString, currentIndexInInput, matches);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 3247, 3310);

                        f_25098_3247_3309(input, SpanStartString, currentIndexInInput, matches);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 3328, 3389);

                        f_25098_3328_3388(input, SpanEndString, currentIndexInInput, matches);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 3407, 3473);

                        f_25098_3407_3472(input, NamedSpanEndString, currentIndexInInput, matches);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 3493, 3575);

                        var
                        namedSpanStartMatch = f_25098_3519_3574(s_namedSpanStartRegex, input, currentIndexInInput)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 3593, 3753) || true) && (f_25098_3597_3624(namedSpanStartMatch))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25098, 3593, 3753);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 3666, 3734);

                            f_25098_3666_3733(matches, (f_25098_3679_3704(namedSpanStartMatch), f_25098_3706_3731(namedSpanStartMatch)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25098, 3593, 3753);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 3773, 3913) || true) && (f_25098_3777_3790(matches) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25098, 3773, 3913);
                            DynAbs.Tracing.TraceSender.TraceBreak(25098, 3888, 3894);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25098, 3773, 3913);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 3933, 4022);

                        var
                        orderedMatches = f_25098_3954_4021(f_25098_3954_4012(matches, (t1, t2) => t1.matchIndex - t2.matchIndex))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 4040, 5034) || true) && (f_25098_4044_4064(orderedMatches) >= 2 && (DynAbs.Tracing.TraceSender.Expression_True(25098, 4044, 4153) && (f_25098_4095_4115(spanStartStack) > 0 || (DynAbs.Tracing.TraceSender.Expression_False(25098, 4095, 4152) || f_25098_4123_4148(namedSpanStartStack) > 0))) && (DynAbs.Tracing.TraceSender.Expression_True(25098, 4044, 4228) && matches[0].matchIndex == matches[1].matchIndex - 1))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25098, 4040, 5034);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 4670, 5015) || true) && ((matches[0].name == SpanStartString && (DynAbs.Tracing.TraceSender.Expression_True(25098, 4675, 4745) && matches[1].name == SpanEndString) && (DynAbs.Tracing.TraceSender.Expression_True(25098, 4675, 4774) && !f_25098_4750_4774(spanStartStack))) || (DynAbs.Tracing.TraceSender.Expression_False(25098, 4674, 4915) || (matches[0].name == SpanStartString && (DynAbs.Tracing.TraceSender.Expression_True(25098, 4805, 4880) && matches[1].name == NamedSpanEndString) && (DynAbs.Tracing.TraceSender.Expression_True(25098, 4805, 4914) && !f_25098_4885_4914(namedSpanStartStack)))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25098, 4670, 5015);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 4965, 4992);

                                f_25098_4965_4991(orderedMatches, 0);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25098, 4670, 5015);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25098, 4040, 5034);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 5107, 5147);

                        var
                        firstMatch = f_25098_5124_5146(orderedMatches)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 5167, 5213);

                        var
                        matchIndexInInput = firstMatch.matchIndex
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 5231, 5265);

                        var
                        matchString = firstMatch.name
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 5285, 5348);

                        var
                        matchIndexInOutput = matchIndexInInput - inputOutputOffset
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 5366, 5466);

                        f_25098_5366_5465(outputBuilder, f_25098_5387_5464(input, currentIndexInInput, matchIndexInInput - currentIndexInInput));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 5486, 5547);

                        currentIndexInInput = matchIndexInInput + f_25098_5528_5546(matchString);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 5565, 5605);

                        inputOutputOffset += f_25098_5586_5604(matchString);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 5625, 7381);

                        switch (f_25098_5633_5660(matchString, 0, 2))
                        {

                            case PositionString:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25098, 5625, 7381);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 5748, 5948) || true) && (f_25098_5752_5769(position))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25098, 5748, 5948);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 5827, 5921);

                                    throw f_25098_5833_5920(f_25098_5855_5919("Saw multiple occurrences of {0}", PositionString));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25098, 5748, 5948);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 5976, 6006);

                                position = matchIndexInOutput;
                                DynAbs.Tracing.TraceSender.TraceBreak(25098, 6032, 6038);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25098, 5625, 7381);

                            case SpanStartString:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25098, 5625, 7381);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 6109, 6165);

                                f_25098_6109_6164(spanStartStack, (matchIndexInOutput, string.Empty));
                                DynAbs.Tracing.TraceSender.TraceBreak(25098, 6191, 6197);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25098, 5625, 7381);

                            case SpanEndString:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25098, 5625, 7381);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 6266, 6487) || true) && (f_25098_6270_6290(spanStartStack) == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25098, 6266, 6487);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 6353, 6460);

                                    throw f_25098_6359_6459(f_25098_6381_6458("Saw {0} without matching {1}", SpanEndString, SpanStartString));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25098, 6266, 6487);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 6515, 6570);

                                f_25098_6515_6569(spanStartStack, tempSpans, matchIndexInOutput);
                                DynAbs.Tracing.TraceSender.TraceBreak(25098, 6596, 6602);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25098, 5625, 7381);

                            case NamedSpanStartString:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25098, 5625, 7381);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 6678, 6725);

                                var
                                name = f_25098_6689_6724(f_25098_6689_6718(f_25098_6689_6715(namedSpanStartMatch), 1))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 6751, 6804);

                                f_25098_6751_6803(namedSpanStartStack, (matchIndexInOutput, name));
                                DynAbs.Tracing.TraceSender.TraceBreak(25098, 6830, 6836);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25098, 5625, 7381);

                            case NamedSpanEndString:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25098, 5625, 7381);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 6910, 7146) || true) && (f_25098_6914_6939(namedSpanStartStack) == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25098, 6910, 7146);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 7002, 7119);

                                    throw f_25098_7008_7118(f_25098_7030_7117("Saw {0} without matching {1}", NamedSpanEndString, NamedSpanStartString));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25098, 6910, 7146);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 7174, 7234);

                                f_25098_7174_7233(namedSpanStartStack, tempSpans, matchIndexInOutput);
                                DynAbs.Tracing.TraceSender.TraceBreak(25098, 7260, 7266);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25098, 5625, 7381);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25098, 5625, 7381);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 7324, 7362);

                                throw f_25098_7330_7361();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25098, 5625, 7381);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25098, 3048, 7396);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25098, 3048, 7396);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25098, 3048, 7396);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 7412, 7596) || true) && (f_25098_7416_7436(spanStartStack) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25098, 7412, 7596);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 7474, 7581);

                    throw f_25098_7480_7580(f_25098_7502_7579("Saw {0} without matching {1}", SpanStartString, SpanEndString));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25098, 7412, 7596);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 7612, 7809) || true) && (f_25098_7616_7641(namedSpanStartStack) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25098, 7612, 7809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 7679, 7794);

                    throw f_25098_7685_7793(f_25098_7707_7792("Saw {0} without matching {1}", NamedSpanEndString, NamedSpanEndString));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25098, 7612, 7809);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 7877, 7936);

                f_25098_7877_7935(
                            // Append the remainder of the string.
                            outputBuilder, f_25098_7898_7934(input, currentIndexInInput));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 7950, 7984);

                output = f_25098_7959_7983(outputBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 7998, 8063);

                spans = f_25098_8006_8062(tempSpans, kvp => kvp.Key, kvp => kvp.Value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25098, 2299, 8074);

                System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>
                f_25098_2516_2564()
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 2516, 2564);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25098_2601_2620()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 2601, 2620);
                    return return_v;
                }


                System.Collections.Generic.Stack<(int matchIndex, string name)>
                f_25098_2906_2948()
                {
                    var return_v = new System.Collections.Generic.Stack<(int matchIndex, string name)>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 2906, 2948);
                    return return_v;
                }


                System.Collections.Generic.Stack<(int matchIndex, string name)>
                f_25098_2989_3031()
                {
                    var return_v = new System.Collections.Generic.Stack<(int matchIndex, string name)>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 2989, 3031);
                    return return_v;
                }


                System.Collections.Generic.List<(int matchIndex, string name)>
                f_25098_3107_3148()
                {
                    var return_v = new System.Collections.Generic.List<(int matchIndex, string name)>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 3107, 3148);
                    return return_v;
                }


                int
                f_25098_3167_3228(string
                input, string
                value, int
                currentIndex, System.Collections.Generic.List<(int matchIndex, string name)>
                matches)
                {
                    AddMatch(input, value, currentIndex, matches);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 3167, 3228);
                    return 0;
                }


                int
                f_25098_3247_3309(string
                input, string
                value, int
                currentIndex, System.Collections.Generic.List<(int matchIndex, string name)>
                matches)
                {
                    AddMatch(input, value, currentIndex, matches);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 3247, 3309);
                    return 0;
                }


                int
                f_25098_3328_3388(string
                input, string
                value, int
                currentIndex, System.Collections.Generic.List<(int matchIndex, string name)>
                matches)
                {
                    AddMatch(input, value, currentIndex, matches);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 3328, 3388);
                    return 0;
                }


                int
                f_25098_3407_3472(string
                input, string
                value, int
                currentIndex, System.Collections.Generic.List<(int matchIndex, string name)>
                matches)
                {
                    AddMatch(input, value, currentIndex, matches);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 3407, 3472);
                    return 0;
                }


                System.Text.RegularExpressions.Match
                f_25098_3519_3574(System.Text.RegularExpressions.Regex
                this_param, string
                input, int
                startat)
                {
                    var return_v = this_param.Match(input, startat);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 3519, 3574);
                    return return_v;
                }


                bool
                f_25098_3597_3624(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25098, 3597, 3624);
                    return return_v;
                }


                int
                f_25098_3679_3704(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25098, 3679, 3704);
                    return return_v;
                }


                string
                f_25098_3706_3731(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25098, 3706, 3731);
                    return return_v;
                }


                int
                f_25098_3666_3733(System.Collections.Generic.List<(int matchIndex, string name)>
                this_param, (int Index, string Value)
                item)
                {
                    this_param.Add(((int matchIndex, string name))item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 3666, 3733);
                    return 0;
                }


                int
                f_25098_3777_3790(System.Collections.Generic.List<(int matchIndex, string name)>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25098, 3777, 3790);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<(int matchIndex, string name)>
                f_25098_3954_4012(System.Collections.Generic.List<(int matchIndex, string name)>
                source, System.Comparison<(int matchIndex, string name)>
                compare)
                {
                    var return_v = source.OrderBy<(int matchIndex, string name)>(compare);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 3954, 4012);
                    return return_v;
                }


                System.Collections.Generic.List<(int matchIndex, string name)>
                f_25098_3954_4021(System.Linq.IOrderedEnumerable<(int matchIndex, string name)>
                source)
                {
                    var return_v = source.ToList<(int matchIndex, string name)>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 3954, 4021);
                    return return_v;
                }


                int
                f_25098_4044_4064(System.Collections.Generic.List<(int matchIndex, string name)>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25098, 4044, 4064);
                    return return_v;
                }


                int
                f_25098_4095_4115(System.Collections.Generic.Stack<(int matchIndex, string name)>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25098, 4095, 4115);
                    return return_v;
                }


                int
                f_25098_4123_4148(System.Collections.Generic.Stack<(int matchIndex, string name)>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25098, 4123, 4148);
                    return return_v;
                }


                bool
                f_25098_4750_4774(System.Collections.Generic.Stack<(int matchIndex, string name)>
                source)
                {
                    var return_v = source.IsEmpty<(int matchIndex, string name)>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 4750, 4774);
                    return return_v;
                }


                bool
                f_25098_4885_4914(System.Collections.Generic.Stack<(int matchIndex, string name)>
                source)
                {
                    var return_v = source.IsEmpty<(int matchIndex, string name)>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 4885, 4914);
                    return return_v;
                }


                int
                f_25098_4965_4991(System.Collections.Generic.List<(int matchIndex, string name)>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 4965, 4991);
                    return 0;
                }


                (int matchIndex, string name)
                f_25098_5124_5146(System.Collections.Generic.List<(int matchIndex, string name)>
                source)
                {
                    var return_v = source.First<(int matchIndex, string name)>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 5124, 5146);
                    return return_v;
                }


                string
                f_25098_5387_5464(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 5387, 5464);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25098_5366_5465(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 5366, 5465);
                    return return_v;
                }


                int
                f_25098_5528_5546(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25098, 5528, 5546);
                    return return_v;
                }


                int
                f_25098_5586_5604(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25098, 5586, 5604);
                    return return_v;
                }


                string
                f_25098_5633_5660(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 5633, 5660);
                    return return_v;
                }


                bool
                f_25098_5752_5769(int?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25098, 5752, 5769);
                    return return_v;
                }


                string
                f_25098_5855_5919(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 5855, 5919);
                    return return_v;
                }


                System.ArgumentException
                f_25098_5833_5920(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 5833, 5920);
                    return return_v;
                }


                int
                f_25098_6109_6164(System.Collections.Generic.Stack<(int matchIndex, string name)>
                this_param, (int matchIndexInOutput, string Empty)
                item)
                {
                    this_param.Push(((int matchIndex, string name))item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 6109, 6164);
                    return 0;
                }


                int
                f_25098_6270_6290(System.Collections.Generic.Stack<(int matchIndex, string name)>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25098, 6270, 6290);
                    return return_v;
                }


                string
                f_25098_6381_6458(string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 6381, 6458);
                    return return_v;
                }


                System.ArgumentException
                f_25098_6359_6459(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 6359, 6459);
                    return return_v;
                }


                int
                f_25098_6515_6569(System.Collections.Generic.Stack<(int matchIndex, string name)>
                spanStartStack, System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>
                spans, int
                finalIndex)
                {
                    PopSpan(spanStartStack, (System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>)spans, finalIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 6515, 6569);
                    return 0;
                }


                System.Text.RegularExpressions.GroupCollection
                f_25098_6689_6715(System.Text.RegularExpressions.Match
                this_param)
                {
                    var return_v = this_param.Groups;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25098, 6689, 6715);
                    return return_v;
                }


                System.Text.RegularExpressions.Group
                f_25098_6689_6718(System.Text.RegularExpressions.GroupCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25098, 6689, 6718);
                    return return_v;
                }


                string
                f_25098_6689_6724(System.Text.RegularExpressions.Group
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25098, 6689, 6724);
                    return return_v;
                }


                int
                f_25098_6751_6803(System.Collections.Generic.Stack<(int matchIndex, string name)>
                this_param, (int matchIndexInOutput, string name)
                item)
                {
                    this_param.Push(((int matchIndex, string name))item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 6751, 6803);
                    return 0;
                }


                int
                f_25098_6914_6939(System.Collections.Generic.Stack<(int matchIndex, string name)>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25098, 6914, 6939);
                    return return_v;
                }


                string
                f_25098_7030_7117(string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 7030, 7117);
                    return return_v;
                }


                System.ArgumentException
                f_25098_7008_7118(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 7008, 7118);
                    return return_v;
                }


                int
                f_25098_7174_7233(System.Collections.Generic.Stack<(int matchIndex, string name)>
                spanStartStack, System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>
                spans, int
                finalIndex)
                {
                    PopSpan(spanStartStack, (System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>)spans, finalIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 7174, 7233);
                    return 0;
                }


                System.InvalidOperationException
                f_25098_7330_7361()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 7330, 7361);
                    return return_v;
                }


                int
                f_25098_7416_7436(System.Collections.Generic.Stack<(int matchIndex, string name)>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25098, 7416, 7436);
                    return return_v;
                }


                string
                f_25098_7502_7579(string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 7502, 7579);
                    return return_v;
                }


                System.ArgumentException
                f_25098_7480_7580(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 7480, 7580);
                    return return_v;
                }


                int
                f_25098_7616_7641(System.Collections.Generic.Stack<(int matchIndex, string name)>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25098, 7616, 7641);
                    return return_v;
                }


                string
                f_25098_7707_7792(string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 7707, 7792);
                    return return_v;
                }


                System.ArgumentException
                f_25098_7685_7793(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 7685, 7793);
                    return return_v;
                }


                string
                f_25098_7898_7934(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 7898, 7934);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25098_7877_7935(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 7877, 7935);
                    return return_v;
                }


                string
                f_25098_7959_7983(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 7959, 7983);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>
                f_25098_8006_8062(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>
                source, System.Func<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>, string>
                keySelector, System.Func<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>
                elementSelector)
                {
                    var return_v = source.ToDictionary<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>, string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>(keySelector, elementSelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 8006, 8062);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25098, 2299, 8074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25098, 2299, 8074);
            }
        }

        private static V GetOrAdd<K, V>(IDictionary<K, V> dictionary, K key, Func<K, V> function)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25098, 8086, 8403);
                V value = default(V);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 8200, 8363) || true) && (!f_25098_8205_8247(dictionary, key, out value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25098, 8200, 8363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 8281, 8303);

                    value = f_25098_8289_8302(function, key);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 8321, 8348);

                    f_25098_8321_8347(dictionary, key, value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25098, 8200, 8363);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 8379, 8392);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25098, 8086, 8403);

                bool
                f_25098_8205_8247(System.Collections.Generic.IDictionary<K, V>
                this_param, K
                key, out V
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 8205, 8247);
                    return return_v;
                }


                V
                f_25098_8289_8302(System.Func<K, V>
                this_param, K
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 8289, 8302);
                    return return_v;
                }


                int
                f_25098_8321_8347(System.Collections.Generic.IDictionary<K, V>
                this_param, K
                key, V
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 8321, 8347);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25098, 8086, 8403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25098, 8086, 8403);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void PopSpan(
                    Stack<(int matchIndex, string name)> spanStartStack,
                    IDictionary<string, ArrayBuilder<TextSpan>> spans,
                    int finalIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25098, 8415, 8844);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 8627, 8673);

                var (matchIndex, name) = f_25098_8652_8672(spanStartStack);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 8689, 8744);

                var
                span = TextSpan.FromBounds(matchIndex, finalIndex)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 8758, 8833);

                f_25098_8758_8832(f_25098_8758_8822(spans, name, _ => ArrayBuilder<TextSpan>.GetInstance()), span);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25098, 8415, 8844);

                (int matchIndex, string name)
                f_25098_8652_8672(System.Collections.Generic.Stack<(int matchIndex, string name)>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 8652, 8672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>
                f_25098_8758_8822(System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>
                dictionary, string
                key, System.Func<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>
                function)
                {
                    var return_v = GetOrAdd(dictionary, key, function);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 8758, 8822);
                    return return_v;
                }


                int
                f_25098_8758_8832(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 8758, 8832);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25098, 8415, 8844);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25098, 8415, 8844);
            }
        }

        private static void AddMatch(string input, string value, int currentIndex, List<(int, string)> matches)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25098, 8856, 9173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 8984, 9057);

                var
                index = f_25098_8996_9056(input, value, currentIndex, StringComparison.Ordinal)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 9071, 9162) || true) && (index >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25098, 9071, 9162);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 9119, 9147);

                    f_25098_9119_9146(matches, (index, value));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25098, 9071, 9162);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25098, 8856, 9173);

                int
                f_25098_8996_9056(string
                this_param, string
                value, int
                startIndex, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, startIndex, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 8996, 9056);
                    return return_v;
                }


                int
                f_25098_9119_9146(System.Collections.Generic.List<(int, string)>
                this_param, (int index, string value)
                item)
                {
                    this_param.Add(((int, string))item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 9119, 9146);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25098, 8856, 9173);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25098, 8856, 9173);
            }
        }

        private static void GetPositionAndSpans(
                    string input, out string output, out int? cursorPositionOpt, out ImmutableArray<TextSpan> spans)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25098, 9185, 9668);
                System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>> dictionary = default(System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 9360, 9428);

                f_25098_9360_9427(input, out output, out cursorPositionOpt, out dictionary);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 9444, 9536);

                var
                builder = f_25098_9458_9535(dictionary, string.Empty, _ => ArrayBuilder<TextSpan>.GetInstance())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 9550, 9606);

                f_25098_9550_9605(builder, (left, right) => left.Start - right.Start);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 9620, 9657);

                spans = f_25098_9628_9656(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25098, 9185, 9668);

                int
                f_25098_9360_9427(string
                input, out string
                output, out int?
                position, out System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>
                spans)
                {
                    Parse(input, out output, out position, out spans);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 9360, 9427);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>
                f_25098_9458_9535(System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>
                dictionary, string
                key, System.Func<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>
                function)
                {
                    var return_v = GetOrAdd(dictionary, key, function);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 9458, 9535);
                    return return_v;
                }


                int
                f_25098_9550_9605(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>
                this_param, System.Comparison<Microsoft.CodeAnalysis.Text.TextSpan>
                compare)
                {
                    this_param.Sort(compare);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 9550, 9605);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextSpan>
                f_25098_9628_9656(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 9628, 9656);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25098, 9185, 9668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25098, 9185, 9668);
            }
        }

        public static void GetPositionAndSpans(
                    string input, out string output, out int? cursorPositionOpt, out IDictionary<string, ImmutableArray<TextSpan>> spans)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25098, 9680, 10055);
                System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>> dictionary = default(System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 9875, 9943);

                f_25098_9875_9942(input, out output, out cursorPositionOpt, out dictionary);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 9957, 10044);

                spans = f_25098_9965_10043(dictionary, kvp => kvp.Key, kvp => kvp.Value.ToImmutableAndFree());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25098, 9680, 10055);

                int
                f_25098_9875_9942(string
                input, out string
                output, out int?
                position, out System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>
                spans)
                {
                    Parse(input, out output, out position, out spans);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 9875, 9942);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextSpan>>
                f_25098_9965_10043(System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>
                source, System.Func<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>, string>
                keySelector, System.Func<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextSpan>>
                elementSelector)
                {
                    var return_v = source.ToDictionary<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextSpan>>, string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextSpan>>(keySelector, elementSelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 9965, 10043);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25098, 9680, 10055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25098, 9680, 10055);
            }
        }

        public static void GetSpans(string input, out string output, out IDictionary<string, ImmutableArray<TextSpan>> spans)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25098, 10198, 10277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 10201, 10277);
                f_25098_10201_10277(input, out output, out var cursorPositionOpt, out spans); 
                DynAbs.Tracing.TraceSender.TraceExitMethod(25098, 10198, 10277);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25098, 10198, 10277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25098, 10198, 10277);
            }

            int
            f_25098_10201_10277(string
            input, out string
            output, out int?
            cursorPositionOpt, out System.Collections.Generic.IDictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextSpan>>
            spans)
            {
                GetPositionAndSpans(input, out output, out cursorPositionOpt, out spans);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 10201, 10277);
                return 0;
            }

        }

        public static void GetPositionAndSpans(string input, out string output, out int cursorPosition, out ImmutableArray<TextSpan> spans)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25098, 10290, 10562);
                int? pos = default(int?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 10446, 10510);

                f_25098_10446_10509(input, out output, out pos, out spans);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 10524, 10551);

                cursorPosition = f_25098_10541_10550(pos);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25098, 10290, 10562);

                int
                f_25098_10446_10509(string
                input, out string
                output, out int?
                cursorPositionOpt, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextSpan>
                spans)
                {
                    GetPositionAndSpans(input, out output, out cursorPositionOpt, out spans);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 10446, 10509);
                    return 0;
                }


                int
                f_25098_10541_10550(int?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25098, 10541, 10550);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25098, 10290, 10562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25098, 10290, 10562);
            }
        }

        public static void GetPosition(string input, out string output, out int? cursorPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25098, 10676, 10773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 10679, 10773);
                f_25098_10679_10773(input, out output, out cursorPosition, out var spans); 
                DynAbs.Tracing.TraceSender.TraceExitMethod(25098, 10676, 10773);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25098, 10676, 10773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25098, 10676, 10773);
            }

            int
            f_25098_10679_10773(string
            input, out string
            output, out int?
            cursorPositionOpt, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextSpan>
            spans)
            {
                GetPositionAndSpans(input, out output, out cursorPositionOpt, out spans);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 10679, 10773);
                return 0;
            }

        }

        public static void GetPosition(string input, out string output, out int cursorPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25098, 10887, 10963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 10890, 10963);
                f_25098_10890_10963(input, out output, out cursorPosition, out var spans); 
                DynAbs.Tracing.TraceSender.TraceExitMethod(25098, 10887, 10963);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25098, 10887, 10963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25098, 10887, 10963);
            }

            int
            f_25098_10890_10963(string
            input, out string
            output, out int
            cursorPosition, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextSpan>
            spans)
            {
                GetPositionAndSpans(input, out output, out cursorPosition, out spans);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 10890, 10963);
                return 0;
            }

        }

        public static void GetPositionAndSpan(string input, out string output, out int? cursorPosition, out TextSpan? textSpan)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25098, 10976, 11304);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextSpan> spans = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextSpan>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 11120, 11215);

                f_25098_11120_11214(input, out output, out cursorPosition, out spans);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 11229, 11293);

                textSpan = (DynAbs.Tracing.TraceSender.Conditional_F1(25098, 11240, 11257) || ((spans.Length == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(25098, 11260, 11264)) || DynAbs.Tracing.TraceSender.Conditional_F3(25098, 11267, 11292))) ? null : (TextSpan?)spans.Single();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25098, 10976, 11304);

                int
                f_25098_11120_11214(string
                input, out string
                output, out int?
                cursorPositionOpt, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextSpan>
                spans)
                {
                    GetPositionAndSpans(input, out output, out cursorPositionOpt, out spans);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 11120, 11214);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25098, 10976, 11304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25098, 10976, 11304);
            }
        }

        public static void GetPositionAndSpan(string input, out string output, out int cursorPosition, out TextSpan textSpan)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25098, 11316, 11583);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextSpan> spans = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextSpan>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 11458, 11532);

                f_25098_11458_11531(input, out output, out cursorPosition, out spans);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 11546, 11572);

                textSpan = spans.Single();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25098, 11316, 11583);

                int
                f_25098_11458_11531(string
                input, out string
                output, out int
                cursorPosition, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextSpan>
                spans)
                {
                    GetPositionAndSpans(input, out output, out cursorPosition, out spans);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 11458, 11531);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25098, 11316, 11583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25098, 11316, 11583);
            }
        }

        public static void GetSpans(string input, out string output, out ImmutableArray<TextSpan> spans)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25098, 11595, 11791);
                int? pos = default(int?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 11716, 11780);

                f_25098_11716_11779(input, out output, out pos, out spans);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25098, 11595, 11791);

                int
                f_25098_11716_11779(string
                input, out string
                output, out int?
                cursorPositionOpt, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextSpan>
                spans)
                {
                    GetPositionAndSpans(input, out output, out cursorPositionOpt, out spans);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 11716, 11779);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25098, 11595, 11791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25098, 11595, 11791);
            }
        }

        public static void GetSpan(string input, out string output, out TextSpan textSpan)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25098, 11803, 12025);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextSpan> spans = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextSpan>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 11910, 11974);

                f_25098_11910_11973(input, out output, out spans);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 11988, 12014);

                textSpan = spans.Single();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25098, 11803, 12025);

                int
                f_25098_11910_11973(string
                input, out string
                output, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextSpan>
                spans)
                {
                    GetSpans(input, out output, out spans);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 11910, 11973);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25098, 11803, 12025);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25098, 11803, 12025);
            }
        }

        static MarkupTestFile()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25098, 1787, 12032);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 1859, 1880);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 1912, 1934);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 1966, 1986);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 2018, 2045);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 2077, 2102);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25098, 2145, 2286);
            s_namedSpanStartRegex = f_25098_2169_2286(@"\{\| ([-_.A-Za-z0-9\+]+) \:", RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25098, 1787, 12032);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25098, 1787, 12032);
        }


        static System.Text.RegularExpressions.Regex
        f_25098_2169_2286(string
        pattern, System.Text.RegularExpressions.RegexOptions
        options)
        {
            var return_v = new System.Text.RegularExpressions.Regex(pattern, options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25098, 2169, 2286);
            return return_v;
        }

    }
}
