// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public sealed partial class AnalyzerConfig
    {
        internal readonly struct SectionNameMatcher
        {

            private readonly ImmutableArray<(int minValue, int maxValue)> _numberRangePairs;

            internal Regex Regex { get; }

            internal SectionNameMatcher(
                            Regex regex,
                            ImmutableArray<(int minValue, int maxValue)> numberRangePairs)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(118, 780, 1129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 951, 1027);

                    f_118_951_1026(f_118_964_994(f_118_964_987(regex)) - 1 == numberRangePairs.Length);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 1045, 1059);

                    Regex = regex;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 1077, 1114);

                    _numberRangePairs = numberRangePairs;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(118, 780, 1129);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(118, 780, 1129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(118, 780, 1129);
                }
            }

            public bool IsMatch(string s)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(118, 1145, 2105);
                    int matchedNum = default(int);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 1207, 1321) || true) && (_numberRangePairs.IsEmpty)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 1207, 1321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 1278, 1302);

                        return f_118_1285_1301(Regex, s);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(118, 1207, 1321);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 1341, 1368);

                    var
                    match = f_118_1353_1367(Regex, s)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 1386, 1478) || true) && (f_118_1390_1404_M(!match.Success))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 1386, 1478);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 1446, 1459);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(118, 1386, 1478);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 1496, 1561);

                    f_118_1496_1560(f_118_1509_1527(f_118_1509_1521(match)) - 1 == _numberRangePairs.Length);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 1588, 1593);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 1579, 2060) || true) && (i < _numberRangePairs.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 1625, 1628)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(118, 1579, 2060))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 1579, 2060);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 1670, 1718);

                            var (minValue, maxValue) = _numberRangePairs[i];

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 1791, 2041) || true) && (!f_118_1796_1855(f_118_1809_1834(f_118_1809_1828(f_118_1809_1821(match), i + 1)), out matchedNum) || (DynAbs.Tracing.TraceSender.Expression_False(118, 1795, 1905) || matchedNum < minValue) || (DynAbs.Tracing.TraceSender.Expression_False(118, 1795, 1955) || matchedNum > maxValue))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 1791, 2041);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 2005, 2018);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(118, 1791, 2041);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(118, 1, 482);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(118, 1, 482);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 2078, 2090);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(118, 1145, 2105);

                    bool
                    f_118_1285_1301(System.Text.RegularExpressions.Regex
                    this_param, string
                    input)
                    {
                        var return_v = this_param.IsMatch(input);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 1285, 1301);
                        return return_v;
                    }


                    System.Text.RegularExpressions.Match
                    f_118_1353_1367(System.Text.RegularExpressions.Regex
                    this_param, string
                    input)
                    {
                        var return_v = this_param.Match(input);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 1353, 1367);
                        return return_v;
                    }


                    bool
                    f_118_1390_1404_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 1390, 1404);
                        return return_v;
                    }


                    System.Text.RegularExpressions.GroupCollection
                    f_118_1509_1521(System.Text.RegularExpressions.Match
                    this_param)
                    {
                        var return_v = this_param.Groups;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 1509, 1521);
                        return return_v;
                    }


                    int
                    f_118_1509_1527(System.Text.RegularExpressions.GroupCollection
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 1509, 1527);
                        return return_v;
                    }


                    int
                    f_118_1496_1560(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 1496, 1560);
                        return 0;
                    }


                    System.Text.RegularExpressions.GroupCollection
                    f_118_1809_1821(System.Text.RegularExpressions.Match
                    this_param)
                    {
                        var return_v = this_param.Groups;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 1809, 1821);
                        return return_v;
                    }


                    System.Text.RegularExpressions.Group
                    f_118_1809_1828(System.Text.RegularExpressions.GroupCollection
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 1809, 1828);
                        return return_v;
                    }


                    string
                    f_118_1809_1834(System.Text.RegularExpressions.Group
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 1809, 1834);
                        return return_v;
                    }


                    bool
                    f_118_1796_1855(string
                    s, out int
                    result)
                    {
                        var return_v = int.TryParse(s, out result);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 1796, 1855);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(118, 1145, 2105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(118, 1145, 2105);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static SectionNameMatcher()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(118, 536, 2116);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(118, 536, 2116);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(118, 536, 2116);
            }

            static int[]
            f_118_964_987(System.Text.RegularExpressions.Regex
            this_param)
            {
                var return_v = this_param.GetGroupNumbers();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 964, 987);
                return return_v;
            }


            static int
            f_118_964_994(int[]
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 964, 994);
                return return_v;
            }


            static int
            f_118_951_1026(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 951, 1026);
                return 0;
            }

        }

        internal static SectionNameMatcher? TryCreateSectionNameMatcher(string sectionName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(118, 2349, 4758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 3197, 3226);

                var
                sb = f_118_3206_3225()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 3240, 3255);

                f_118_3240_3254(sb, '^');

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 3996, 4200) || true) && (!f_118_4001_4026(sectionName, "/"))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 3996, 4200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 4060, 4077);

                    f_118_4060_4076(sb, ".*/");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(118, 3996, 4200);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 3996, 4200);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 4111, 4200) || true) && (f_118_4115_4129(sectionName, 0) != '/')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 4111, 4200);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 4170, 4185);

                        f_118_4170_4184(sb, '/');
                        DynAbs.Tracing.TraceSender.TraceExitCondition(118, 4111, 4200);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(118, 3996, 4200);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 4216, 4262);

                var
                lexer = f_118_4228_4261(sectionName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 4276, 4356);

                var
                numberRangePairs = f_118_4299_4355()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 4370, 4551) || true) && (!f_118_4375_4448(ref lexer, sb, parsingChoice: false, numberRangePairs))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 4370, 4551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 4482, 4506);

                    f_118_4482_4505(numberRangePairs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 4524, 4536);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(118, 4370, 4551);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 4565, 4580);

                f_118_4565_4579(sb, '$');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 4594, 4747);

                return f_118_4601_4746(f_118_4642_4689(f_118_4652_4665(sb), RegexOptions.Compiled), f_118_4708_4745(numberRangePairs));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(118, 2349, 4758);

                System.Text.StringBuilder
                f_118_3206_3225()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 3206, 3225);
                    return return_v;
                }


                System.Text.StringBuilder
                f_118_3240_3254(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 3240, 3254);
                    return return_v;
                }


                bool
                f_118_4001_4026(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 4001, 4026);
                    return return_v;
                }


                System.Text.StringBuilder
                f_118_4060_4076(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 4060, 4076);
                    return return_v;
                }


                char
                f_118_4115_4129(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 4115, 4129);
                    return return_v;
                }


                System.Text.StringBuilder
                f_118_4170_4184(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 4170, 4184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameLexer
                f_118_4228_4261(string
                sectionName)
                {
                    var return_v = new Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameLexer(sectionName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 4228, 4261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(int minValue, int maxValue)>
                f_118_4299_4355()
                {
                    var return_v = ArrayBuilder<(int minValue, int maxValue)>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 4299, 4355);
                    return return_v;
                }


                bool
                f_118_4375_4448(ref Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameLexer
                lexer, System.Text.StringBuilder
                sb, bool
                parsingChoice, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(int minValue, int maxValue)>
                numberRangePairs)
                {
                    var return_v = TryCompilePathList(ref lexer, sb, parsingChoice: parsingChoice, numberRangePairs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 4375, 4448);
                    return return_v;
                }


                int
                f_118_4482_4505(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(int minValue, int maxValue)>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 4482, 4505);
                    return 0;
                }


                System.Text.StringBuilder
                f_118_4565_4579(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 4565, 4579);
                    return return_v;
                }


                string
                f_118_4652_4665(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 4652, 4665);
                    return return_v;
                }


                System.Text.RegularExpressions.Regex
                f_118_4642_4689(string
                pattern, System.Text.RegularExpressions.RegexOptions
                options)
                {
                    var return_v = new System.Text.RegularExpressions.Regex(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 4642, 4689);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<(int minValue, int maxValue)>
                f_118_4708_4745(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(int minValue, int maxValue)>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 4708, 4745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameMatcher
                f_118_4601_4746(System.Text.RegularExpressions.Regex
                regex, System.Collections.Immutable.ImmutableArray<(int minValue, int maxValue)>
                numberRangePairs)
                {
                    var return_v = new Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameMatcher(regex, numberRangePairs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 4601, 4746);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(118, 2349, 4758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(118, 2349, 4758);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsAbsoluteEditorConfigPath(string sectionName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(118, 4895, 8140);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 6511, 6574);

                SectionNameLexer
                nameLexer = f_118_6540_6573(sectionName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 6588, 6614);

                bool
                sawStartChar = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 6628, 6649);

                int
                logicalIndex = 0
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 6663, 8095) || true) && (f_118_6670_6687_M(!nameLexer.IsDone))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 6663, 8095);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 6721, 6843) || true) && (nameLexer.Lex() != TokenKind.SimpleCharacter)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 6721, 6843);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 6811, 6824);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(118, 6721, 6843);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 6861, 6910);

                        var
                        simpleChar = nameLexer.EatCurrentCharacter()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 6981, 8047) || true) && (logicalIndex == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 6981, 8047);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 7044, 7309) || true) && (simpleChar == '/')
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 7044, 7309);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 7115, 7135);

                                sawStartChar = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(118, 7044, 7309);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 7044, 7309);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 7185, 7309) || true) && (Path.DirectorySeparatorChar == '/')
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 7185, 7309);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 7273, 7286);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(118, 7185, 7309);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(118, 7044, 7309);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(118, 6981, 8047);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 6981, 8047);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 7428, 8047) || true) && (!sawStartChar && (DynAbs.Tracing.TraceSender.Expression_True(118, 7432, 7484) && Path.DirectorySeparatorChar == '\\'))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 7428, 8047);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 7526, 8028) || true) && (logicalIndex == 1 && (DynAbs.Tracing.TraceSender.Expression_True(118, 7530, 7568) && simpleChar != ':'))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 7526, 8028);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 7618, 7631);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(118, 7526, 8028);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 7526, 8028);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 7681, 8028) || true) && (logicalIndex == 2)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 7681, 8028);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 7752, 8005) || true) && (simpleChar != '/')
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 7752, 8005);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 7831, 7844);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(118, 7752, 8005);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 7752, 8005);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 7958, 7978);

                                            sawStartChar = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(118, 7752, 8005);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(118, 7681, 8028);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(118, 7526, 8028);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(118, 7428, 8047);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(118, 6981, 8047);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 8065, 8080);

                        logicalIndex++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(118, 6663, 8095);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(118, 6663, 8095);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(118, 6663, 8095);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 8109, 8129);

                return sawStartChar;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(118, 4895, 8140);

                Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameLexer
                f_118_6540_6573(string
                sectionName)
                {
                    var return_v = new Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameLexer(sectionName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 6540, 6573);
                    return return_v;
                }


                bool
                f_118_6670_6687_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 6670, 6687);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(118, 4895, 8140);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(118, 4895, 8140);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryCompilePathList(
                    ref SectionNameLexer lexer,
                    StringBuilder sb,
                    bool parsingChoice,
                    ArrayBuilder<(int minValue, int maxValue)> numberRangePairs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(118, 8552, 12684);
                int intStart = default(int);
                int intEnd = default(int);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 8795, 12554) || true) && (f_118_8802_8815_M(!lexer.IsDone))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 8795, 12554);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 8849, 8877);

                        var
                        tokenKind = lexer.Lex()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 8895, 12539);

                        switch (tokenKind)
                        {

                            case TokenKind.BadToken:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 8895, 12539);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 9048, 9061);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(118, 8895, 12539);

                            case TokenKind.SimpleCharacter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 8895, 12539);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 9196, 9260);

                                f_118_9196_9259(                        // Matches just this character
                                                        sb, f_118_9206_9258(f_118_9219_9257(lexer.EatCurrentCharacter())));
                                DynAbs.Tracing.TraceSender.TraceBreak(118, 9286, 9292);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(118, 8895, 12539);

                            case TokenKind.Question:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 8895, 12539);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 9425, 9440);

                                f_118_9425_9439(                        // '?' matches any single character
                                                        sb, '.');
                                DynAbs.Tracing.TraceSender.TraceBreak(118, 9466, 9472);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(118, 8895, 12539);

                            case TokenKind.Star:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 8895, 12539);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 9715, 9734);

                                f_118_9715_9733(                        // Matches any string of characters except directory separator
                                                                        // Directory separator is defined in editorconfig spec as '/'
                                                        sb, "[^/]*");
                                DynAbs.Tracing.TraceSender.TraceBreak(118, 9760, 9766);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(118, 8895, 12539);

                            case TokenKind.StarStar:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 8895, 12539);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 9899, 9915);

                                f_118_9899_9914(                        // Matches any string of characters
                                                        sb, ".*");
                                DynAbs.Tracing.TraceSender.TraceBreak(118, 9941, 9947);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(118, 8895, 12539);

                            case TokenKind.OpenCurly:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 8895, 12539);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 10109, 10126);

                                f_118_10109_10125_M(lexer.Position--);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 10394, 10470);

                                (string numStart, string numEnd)?
                                rangeOpt = f_118_10439_10469(ref lexer)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 10496, 11788) || true) && (rangeOpt is null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 10496, 11788);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 10650, 10814) || true) && (!f_118_10655_10704(ref lexer, sb, numberRangePairs))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 10650, 10814);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 10770, 10783);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(118, 10650, 10814);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(118, 10923, 10929);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(118, 10496, 11788);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 10496, 11788);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 11043, 11107);

                                    (string numStart, string numEnd) = rangeOpt.GetValueOrDefault();

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 11137, 11718) || true) && (f_118_11141_11181(numStart, out intStart) && (DynAbs.Tracing.TraceSender.Expression_True(118, 11141, 11221) && f_118_11185_11221(numEnd, out intEnd)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 11137, 11718);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 11287, 11358);

                                        var
                                        pair = (DynAbs.Tracing.TraceSender.Conditional_F1(118, 11298, 11315) || ((intStart < intEnd && DynAbs.Tracing.TraceSender.Conditional_F2(118, 11318, 11336)) || DynAbs.Tracing.TraceSender.Conditional_F3(118, 11339, 11357))) ? (intStart, intEnd) : (intEnd, intStart)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 11392, 11419);

                                        f_118_11392_11418(numberRangePairs, pair);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 11574, 11598);

                                        f_118_11574_11597(                                // Group allowing any digit sequence. The validity will be checked outside of the regex
                                                                        sb, "(-?[0-9]+)");
                                        DynAbs.Tracing.TraceSender.TraceBreak(118, 11681, 11687);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(118, 11137, 11718);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 11748, 11761);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(118, 10496, 11788);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(118, 8895, 12539);

                            case TokenKind.CloseCurly:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 8895, 12539);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 11936, 11957);

                                return parsingChoice;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(118, 8895, 12539);

                            case TokenKind.Comma:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 8895, 12539);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 12101, 12122);

                                return parsingChoice;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(118, 8895, 12539);

                            case TokenKind.OpenBracket:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 8895, 12539);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 12197, 12212);

                                f_118_12197_12211(sb, '[');

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 12238, 12380) || true) && (!f_118_12243_12282(ref lexer, sb))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 12238, 12380);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 12340, 12353);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(118, 12238, 12380);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(118, 12406, 12412);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(118, 8895, 12539);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 8895, 12539);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 12468, 12520);

                                throw f_118_12474_12519(tokenKind);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(118, 8895, 12539);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(118, 8795, 12554);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(118, 8795, 12554);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(118, 8795, 12554);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 12651, 12673);

                return !parsingChoice;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(118, 8552, 12684);

                bool
                f_118_8802_8815_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 8802, 8815);
                    return return_v;
                }


                string
                f_118_9219_9257(char
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 9219, 9257);
                    return return_v;
                }


                string
                f_118_9206_9258(string
                str)
                {
                    var return_v = Regex.Escape(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 9206, 9258);
                    return return_v;
                }


                System.Text.StringBuilder
                f_118_9196_9259(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 9196, 9259);
                    return return_v;
                }


                System.Text.StringBuilder
                f_118_9425_9439(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 9425, 9439);
                    return return_v;
                }


                System.Text.StringBuilder
                f_118_9715_9733(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 9715, 9733);
                    return return_v;
                }


                System.Text.StringBuilder
                f_118_9899_9914(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 9899, 9914);
                    return return_v;
                }


                int
                f_118_10109_10125_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 10109, 10125);
                    return return_v;
                }


                (string numStart, string numEnd)?
                f_118_10439_10469(ref Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameLexer
                lexer)
                {
                    var return_v = TryParseNumberRange(ref lexer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 10439, 10469);
                    return return_v;
                }


                bool
                f_118_10655_10704(ref Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameLexer
                lexer, System.Text.StringBuilder
                sb, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(int minValue, int maxValue)>
                numberRangePairs)
                {
                    var return_v = TryCompileChoice(ref lexer, sb, numberRangePairs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 10655, 10704);
                    return return_v;
                }


                bool
                f_118_11141_11181(string
                s, out int
                result)
                {
                    var return_v = int.TryParse(s, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 11141, 11181);
                    return return_v;
                }


                bool
                f_118_11185_11221(string
                s, out int
                result)
                {
                    var return_v = int.TryParse(s, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 11185, 11221);
                    return return_v;
                }


                int
                f_118_11392_11418(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(int minValue, int maxValue)>
                this_param, (int, int)
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 11392, 11418);
                    return 0;
                }


                System.Text.StringBuilder
                f_118_11574_11597(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 11574, 11597);
                    return return_v;
                }


                System.Text.StringBuilder
                f_118_12197_12211(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 12197, 12211);
                    return return_v;
                }


                bool
                f_118_12243_12282(ref Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameLexer
                lexer, System.Text.StringBuilder
                sb)
                {
                    var return_v = TryCompileCharacterClass(ref lexer, sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 12243, 12282);
                    return return_v;
                }


                System.Exception
                f_118_12474_12519(Microsoft.CodeAnalysis.AnalyzerConfig.TokenKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 12474, 12519);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(118, 8552, 12684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(118, 8552, 12684);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryCompileCharacterClass(ref SectionNameLexer lexer, StringBuilder sb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(118, 12999, 14850);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 13535, 13684) || true) && (f_118_13539_13552_M(!lexer.IsDone) && (DynAbs.Tracing.TraceSender.Expression_True(118, 13539, 13585) && lexer.CurrentCharacter == '!'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 13535, 13684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 13619, 13634);

                    f_118_13619_13633(sb, '^');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 13652, 13669);

                    f_118_13652_13668_M(lexer.Position++);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(118, 13535, 13684);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 13698, 14757) || true) && (f_118_13705_13718_M(!lexer.IsDone))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 13698, 14757);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 13752, 13798);

                        var
                        currentChar = lexer.EatCurrentCharacter()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 13816, 14742);

                        switch (currentChar)
                        {

                            case '-':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 13816, 14742);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 14048, 14071);

                                f_118_14048_14070(                        // '-' means the same thing in regex as it does in the glob, so
                                                                          // put it in verbatim
                                                        sb, currentChar);
                                DynAbs.Tracing.TraceSender.TraceBreak(118, 14097, 14103);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(118, 13816, 14742);

                            case '\\':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 13816, 14742);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 14212, 14326) || true) && (lexer.IsDone)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 14212, 14326);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 14286, 14299);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(118, 14212, 14326);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 14352, 14368);

                                f_118_14352_14367(sb, '\\');
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 14394, 14433);

                                f_118_14394_14432(sb, lexer.EatCurrentCharacter());
                                DynAbs.Tracing.TraceSender.TraceBreak(118, 14459, 14465);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(118, 13816, 14742);

                            case ']':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 13816, 14742);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 14524, 14547);

                                f_118_14524_14546(sb, currentChar);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 14573, 14585);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(118, 13816, 14742);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 13816, 14742);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 14643, 14691);

                                f_118_14643_14690(sb, f_118_14653_14689(f_118_14666_14688(currentChar)));
                                DynAbs.Tracing.TraceSender.TraceBreak(118, 14717, 14723);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(118, 13816, 14742);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(118, 13698, 14757);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(118, 13698, 14757);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(118, 13698, 14757);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 14826, 14839);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(118, 12999, 14850);

                bool
                f_118_13539_13552_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 13539, 13552);
                    return return_v;
                }


                System.Text.StringBuilder
                f_118_13619_13633(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 13619, 13633);
                    return return_v;
                }


                int
                f_118_13652_13668_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 13652, 13668);
                    return return_v;
                }


                bool
                f_118_13705_13718_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 13705, 13718);
                    return return_v;
                }


                System.Text.StringBuilder
                f_118_14048_14070(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 14048, 14070);
                    return return_v;
                }


                System.Text.StringBuilder
                f_118_14352_14367(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 14352, 14367);
                    return return_v;
                }


                System.Text.StringBuilder
                f_118_14394_14432(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 14394, 14432);
                    return return_v;
                }


                System.Text.StringBuilder
                f_118_14524_14546(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 14524, 14546);
                    return return_v;
                }


                string
                f_118_14666_14688(char
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 14666, 14688);
                    return return_v;
                }


                string
                f_118_14653_14689(string
                str)
                {
                    var return_v = Regex.Escape(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 14653, 14689);
                    return return_v;
                }


                System.Text.StringBuilder
                f_118_14643_14690(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 14643, 14690);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(118, 12999, 14850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(118, 12999, 14850);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryCompileChoice(
                    ref SectionNameLexer lexer,
                    StringBuilder sb,
                    ArrayBuilder<(int, int)> numberRangePairs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(118, 15133, 16499);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 15323, 15423) || true) && (lexer.Lex() != TokenKind.OpenCurly)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 15323, 15423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 15395, 15408);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(118, 15323, 15423);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 15498, 15515);

                f_118_15498_15514(
                            // Start a non-capturing group for the choice
                            sb, "(?:");
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 15634, 16425) || true) && (f_118_15641_15713(ref lexer, sb, parsingChoice: true, numberRangePairs))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 15634, 16425);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 15879, 15921);

                        char
                        lastChar = lexer[lexer.Position - 1]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 15939, 16410) || true) && (lastChar == ',')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 15939, 16410);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 16039, 16054);

                            f_118_16039_16053(                    // Another option
                                                sb, "|");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(118, 15939, 16410);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 15939, 16410);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 16096, 16410) || true) && (lastChar == '}')
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 16096, 16410);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 16209, 16224);

                                f_118_16209_16223(                    // Close out the capture group
                                                    sb, ")");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 16246, 16258);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(118, 16096, 16410);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 16096, 16410);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 16340, 16391);

                                throw f_118_16346_16390(lastChar);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(118, 16096, 16410);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(118, 15939, 16410);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(118, 15634, 16425);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(118, 15634, 16425);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(118, 15634, 16425);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 16475, 16488);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(118, 15133, 16499);

                System.Text.StringBuilder
                f_118_15498_15514(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 15498, 15514);
                    return return_v;
                }


                bool
                f_118_15641_15713(ref Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameLexer
                lexer, System.Text.StringBuilder
                sb, bool
                parsingChoice, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(int, int)>
                numberRangePairs)
                {
                    var return_v = TryCompilePathList(ref lexer, sb, parsingChoice: parsingChoice, numberRangePairs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 15641, 15713);
                    return return_v;
                }


                System.Text.StringBuilder
                f_118_16039_16053(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 16039, 16053);
                    return return_v;
                }


                System.Text.StringBuilder
                f_118_16209_16223(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 16209, 16223);
                    return return_v;
                }


                System.Exception
                f_118_16346_16390(char
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 16346, 16390);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(118, 15133, 16499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(118, 15133, 16499);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static (string numStart, string numEnd)? TryParseNumberRange(ref SectionNameLexer lexer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(118, 16865, 18055);
                char c = default(char);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 16986, 17013);

                var
                saved = lexer.Position
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 17027, 17167) || true) && (lexer.Lex() != TokenKind.OpenCurly)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 17027, 17167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 17099, 17122);

                    lexer.Position = saved;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 17140, 17152);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(118, 17027, 17167);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 17183, 17219);

                var
                numStart = lexer.TryLexNumber()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 17233, 17388) || true) && (numStart is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 17233, 17388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 17320, 17343);

                    lexer.Position = saved;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 17361, 17373);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(118, 17233, 17388);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 17457, 17685) || true) && (!lexer.TryEatCurrentCharacter(out c
                ) || (DynAbs.Tracing.TraceSender.Expression_False(118, 17461, 17514) || c != '.') || (DynAbs.Tracing.TraceSender.Expression_False(118, 17461, 17571) || !lexer.TryEatCurrentCharacter(out c)) || (DynAbs.Tracing.TraceSender.Expression_False(118, 17461, 17583) || c != '.'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 17457, 17685);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 17617, 17640);

                    lexer.Position = saved;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 17658, 17670);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(118, 17457, 17685);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 17736, 17770);

                var
                numEnd = lexer.TryLexNumber()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 17784, 18002) || true) && (numEnd is null || (DynAbs.Tracing.TraceSender.Expression_False(118, 17788, 17818) || lexer.IsDone) || (DynAbs.Tracing.TraceSender.Expression_False(118, 17788, 17857) || lexer.Lex() != TokenKind.CloseCurly))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 17784, 18002);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 17934, 17957);

                    lexer.Position = saved;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 17975, 17987);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(118, 17784, 18002);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 18018, 18044);

                return (numStart, numEnd);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(118, 16865, 18055);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(118, 16865, 18055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(118, 16865, 18055);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private struct SectionNameLexer
        {

            private readonly string _sectionName;

            public int Position { get; set; }

            public SectionNameLexer(string sectionName)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(118, 18225, 18374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 18301, 18328);

                    _sectionName = sectionName;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 18346, 18359);

                    Position = 0;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(118, 18225, 18374);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(118, 18225, 18374);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(118, 18225, 18374);
                }
            }

            public bool IsDone
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(118, 18409, 18443);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 18412, 18443);
                        return Position >= f_118_18424_18443(_sectionName); DynAbs.Tracing.TraceSender.TraceExitMethod(118, 18409, 18443);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(118, 18409, 18443);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(118, 18409, 18443);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public TokenKind Lex()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(118, 18460, 20508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 18515, 18542);

                    int
                    lexemeStart = Position
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 18560, 20493);

                    switch (f_118_18568_18590(_sectionName, Position))
                    {

                        case '*':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 18560, 20493);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 18698, 18725);

                                int
                                nextPos = Position + 1
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 18755, 19221) || true) && (nextPos < f_118_18769_18788(_sectionName) && (DynAbs.Tracing.TraceSender.Expression_True(118, 18759, 18853) && f_118_18825_18846(_sectionName, nextPos) == '*'))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 18755, 19221);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 18919, 18933);

                                    Position += DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => 2, 118, 18919, 18927);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 18967, 18993);

                                    return TokenKind.StarStar;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(118, 18755, 19221);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 18755, 19221);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 19123, 19134);

                                    f_118_19123_19133_M(Position++);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 19168, 19190);

                                    return TokenKind.Star;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(118, 18755, 19221);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(118, 18560, 20493);

                        case '?':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 18560, 20493);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 19307, 19318);

                            f_118_19307_19317_M(Position++);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 19344, 19370);

                            return TokenKind.Question;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(118, 18560, 20493);

                        case '{':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 18560, 20493);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 19429, 19440);

                            f_118_19429_19439_M(Position++);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 19466, 19493);

                            return TokenKind.OpenCurly;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(118, 18560, 20493);

                        case ',':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 18560, 20493);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 19552, 19563);

                            f_118_19552_19562_M(Position++);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 19589, 19612);

                            return TokenKind.Comma;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(118, 18560, 20493);

                        case '}':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 18560, 20493);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 19671, 19682);

                            f_118_19671_19681_M(Position++);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 19708, 19736);

                            return TokenKind.CloseCurly;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(118, 18560, 20493);

                        case '[':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 18560, 20493);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 19795, 19806);

                            f_118_19795_19805_M(Position++);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 19832, 19861);

                            return TokenKind.OpenBracket;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(118, 18560, 20493);

                        case '\\':
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 18560, 20493);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 20021, 20032);

                                f_118_20021_20031_M(Position++);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 20062, 20195) || true) && (IsDone)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 20062, 20195);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 20138, 20164);

                                    return TokenKind.BadToken;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(118, 20062, 20195);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 20227, 20260);

                                return TokenKind.SimpleCharacter;
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(118, 18560, 20493);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 18560, 20493);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 20441, 20474);

                            return TokenKind.SimpleCharacter;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(118, 18560, 20493);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(118, 18460, 20508);

                    char
                    f_118_18568_18590(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 18568, 18590);
                        return return_v;
                    }


                    int
                    f_118_18769_18788(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 18769, 18788);
                        return return_v;
                    }


                    char
                    f_118_18825_18846(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 18825, 18846);
                        return return_v;
                    }


                    int
                    f_118_19123_19133_M(int
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 19123, 19133);
                        return return_v;
                    }


                    int
                    f_118_19307_19317_M(int
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 19307, 19317);
                        return return_v;
                    }


                    int
                    f_118_19429_19439_M(int
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 19429, 19439);
                        return return_v;
                    }


                    int
                    f_118_19552_19562_M(int
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 19552, 19562);
                        return return_v;
                    }


                    int
                    f_118_19671_19681_M(int
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 19671, 19681);
                        return return_v;
                    }


                    int
                    f_118_19795_19805_M(int
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 19795, 19805);
                        return return_v;
                    }


                    int
                    f_118_20021_20031_M(int
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 20021, 20031);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(118, 18460, 20508);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(118, 18460, 20508);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public char CurrentCharacter
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(118, 20553, 20578);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 20556, 20578);
                        return f_118_20556_20578(_sectionName, Position); DynAbs.Tracing.TraceSender.TraceExitMethod(118, 20553, 20578);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(118, 20553, 20578);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(118, 20553, 20578);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public char EatCurrentCharacter()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(118, 20787, 20814);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 20790, 20814);
                    return f_118_20790_20814(_sectionName, f_118_20803_20813_M(Position++)); DynAbs.Tracing.TraceSender.TraceExitMethod(118, 20787, 20814);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(118, 20787, 20814);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(118, 20787, 20814);
                }
                throw new System.Exception("Slicer error: unreachable code");

                int
                f_118_20803_20813_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 20803, 20813);
                    return return_v;
                }


                char
                f_118_20790_20814(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 20790, 20814);
                    return return_v;
                }

            }

            public bool TryEatCurrentCharacter(out char nextChar)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(118, 21056, 21431);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 21142, 21416) || true) && (IsDone)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 21142, 21416);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 21194, 21213);

                        nextChar = default;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 21235, 21248);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(118, 21142, 21416);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 21142, 21416);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 21330, 21363);

                        nextChar = EatCurrentCharacter();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 21385, 21397);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(118, 21142, 21416);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(118, 21056, 21431);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(118, 21056, 21431);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(118, 21056, 21431);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public char this[int position] => f_118_21481_21503(_sectionName, position);

            public string? TryLexNumber()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(118, 21714, 22648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 21776, 21794);

                    bool
                    start = true
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 21812, 21841);

                    var
                    sb = f_118_21821_21840()
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 21861, 22479) || true) && (f_118_21868_21875_M(!IsDone))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 21861, 22479);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 21917, 21953);

                            char
                            currentChar = CurrentCharacter
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 21975, 22424) || true) && (start && (DynAbs.Tracing.TraceSender.Expression_True(118, 21979, 22006) && currentChar == '-'))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 21975, 22424);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 22056, 22067);

                                f_118_22056_22066_M(Position++);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 22093, 22108);

                                f_118_22093_22107(sb, '-');
                                DynAbs.Tracing.TraceSender.TraceExitCondition(118, 21975, 22424);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 21975, 22424);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 22158, 22424) || true) && (f_118_22162_22187(currentChar))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 22158, 22424);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 22237, 22248);

                                    f_118_22237_22247_M(Position++);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 22274, 22297);

                                    f_118_22274_22296(sb, currentChar);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(118, 22158, 22424);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(118, 22158, 22424);
                                    DynAbs.Tracing.TraceSender.TraceBreak(118, 22395, 22401);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(118, 22158, 22424);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(118, 21975, 22424);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 22446, 22460);

                            start = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(118, 21861, 22479);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(118, 21861, 22479);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(118, 21861, 22479);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 22499, 22523);

                    var
                    str = f_118_22509_22522(sb)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(118, 22541, 22633);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(118, 22548, 22577) || ((f_118_22548_22558(str) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(118, 22548, 22577) || str == "-"
                    ) && DynAbs.Tracing.TraceSender.Conditional_F2(118, 22601, 22605)) || DynAbs.Tracing.TraceSender.Conditional_F3(118, 22629, 22632))) ? null
                    : str;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(118, 21714, 22648);

                    System.Text.StringBuilder
                    f_118_21821_21840()
                    {
                        var return_v = new System.Text.StringBuilder();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 21821, 21840);
                        return return_v;
                    }


                    bool
                    f_118_21868_21875_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 21868, 21875);
                        return return_v;
                    }


                    int
                    f_118_22056_22066_M(int
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 22056, 22066);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_118_22093_22107(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 22093, 22107);
                        return return_v;
                    }


                    bool
                    f_118_22162_22187(char
                    c)
                    {
                        var return_v = char.IsDigit(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 22162, 22187);
                        return return_v;
                    }


                    int
                    f_118_22237_22247_M(int
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 22237, 22247);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_118_22274_22296(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 22274, 22296);
                        return return_v;
                    }


                    string
                    f_118_22509_22522(System.Text.StringBuilder
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(118, 22509, 22522);
                        return return_v;
                    }


                    int
                    f_118_22548_22558(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 22548, 22558);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(118, 21714, 22648);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(118, 21714, 22648);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static SectionNameLexer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(118, 18067, 22659);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(118, 18067, 22659);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(118, 18067, 22659);
            }

            int
            f_118_18424_18443(string
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 18424, 18443);
                return return_v;
            }


            char
            f_118_20556_20578(string
            this_param, int
            i0)
            {
                var return_v = this_param[i0];
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 20556, 20578);
                return return_v;
            }


            char
            f_118_21481_21503(string
            this_param, int
            i0)
            {
                var return_v = this_param[i0];
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(118, 21481, 21503);
                return return_v;
            }

        }

        private enum TokenKind
        {
            BadToken,
            SimpleCharacter,
            Star,
            StarStar,
            Question,
            OpenCurly,
            CloseCurly,
            Comma,
            DoubleDot,
            OpenBracket,
        }
    }
}
