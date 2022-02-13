// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Globalization;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    public static partial class SyntaxFacts
    {
        internal static bool IsHexDigit(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10019, 810, 1007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 874, 996);

                return (c >= '0' && (DynAbs.Tracing.TraceSender.Expression_True(10019, 882, 902) && c <= '9')) || (DynAbs.Tracing.TraceSender.Expression_False(10019, 881, 949) || (c >= 'A' && (DynAbs.Tracing.TraceSender.Expression_True(10019, 928, 948) && c <= 'F'))) || (DynAbs.Tracing.TraceSender.Expression_False(10019, 881, 995) || (c >= 'a' && (DynAbs.Tracing.TraceSender.Expression_True(10019, 974, 994) && c <= 'f')));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10019, 810, 1007);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10019, 810, 1007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10019, 810, 1007);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsBinaryDigit(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10019, 1275, 1380);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 1342, 1369);

                return c == '0' | c == '1';
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10019, 1275, 1380);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10019, 1275, 1380);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10019, 1275, 1380);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsDecDigit(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10019, 1652, 1755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 1716, 1744);

                return c >= '0' && (DynAbs.Tracing.TraceSender.Expression_True(10019, 1723, 1743) && c <= '9');
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10019, 1652, 1755);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10019, 1652, 1755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10019, 1652, 1755);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int HexValue(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10019, 1941, 2119);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 2002, 2030);

                f_10019_2002_2029(f_10019_2015_2028(c));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 2044, 2108);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10019, 2051, 2073) || (((c >= '0' && (DynAbs.Tracing.TraceSender.Expression_True(10019, 2052, 2072) && c <= '9')) && DynAbs.Tracing.TraceSender.Conditional_F2(10019, 2076, 2083)) || DynAbs.Tracing.TraceSender.Conditional_F3(10019, 2086, 2107))) ? c - '0' : (c & 0xdf) - 'A' + 10;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10019, 1941, 2119);

                bool
                f_10019_2015_2028(char
                c)
                {
                    var return_v = IsHexDigit(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10019, 2015, 2028);
                    return return_v;
                }


                int
                f_10019_2002_2029(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10019, 2002, 2029);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10019, 1941, 2119);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10019, 1941, 2119);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int BinaryValue(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10019, 2300, 2435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 2364, 2395);

                f_10019_2364_2394(f_10019_2377_2393(c));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 2409, 2424);

                return c - '0';
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10019, 2300, 2435);

                bool
                f_10019_2377_2393(char
                c)
                {
                    var return_v = IsBinaryDigit(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10019, 2377, 2393);
                    return return_v;
                }


                int
                f_10019_2364_2394(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10019, 2364, 2394);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10019, 2300, 2435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10019, 2300, 2435);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int DecValue(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10019, 2617, 2746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 2678, 2706);

                f_10019_2678_2705(f_10019_2691_2704(c));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 2720, 2735);

                return c - '0';
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10019, 2617, 2746);

                bool
                f_10019_2691_2704(char
                c)
                {
                    var return_v = IsDecDigit(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10019, 2691, 2704);
                    return return_v;
                }


                int
                f_10019_2678_2705(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10019, 2678, 2705);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10019, 2617, 2746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10019, 2617, 2746);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsWhitespace(char ch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10019, 4892, 6523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 5283, 6512);

                return ch == ' '
                || (DynAbs.Tracing.TraceSender.Expression_False(10019, 5290, 5330) || ch == '\t'
                ) || (DynAbs.Tracing.TraceSender.Expression_False(10019, 5290, 5361) || ch == '\v'
                ) || (DynAbs.Tracing.TraceSender.Expression_False(10019, 5290, 5392) || ch == '\f'
                ) || (DynAbs.Tracing.TraceSender.Expression_False(10019, 5290, 5427) || ch == '\u00A0' // NO-BREAK SPACE
                ) || (DynAbs.Tracing.TraceSender.Expression_False(10019, 5290, 6369) || ch == '\uFEFF'
                ) || (DynAbs.Tracing.TraceSender.Expression_False(10019, 5290, 6404) || ch == '\u001A'
                ) || (DynAbs.Tracing.TraceSender.Expression_False(10019, 5290, 6511) || (ch > 255 && (DynAbs.Tracing.TraceSender.Expression_True(10019, 6426, 6510) && f_10019_6438_6476(ch) == UnicodeCategory.SpaceSeparator)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10019, 4892, 6523);

                System.Globalization.UnicodeCategory
                f_10019_6438_6476(char
                ch)
                {
                    var return_v = CharUnicodeInfo.GetUnicodeCategory(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10019, 6438, 6476);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10019, 4892, 6523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10019, 4892, 6523);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsNewLine(char ch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10019, 6718, 7239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 7074, 7228);

                return ch == '\r'
                || (DynAbs.Tracing.TraceSender.Expression_False(10019, 7081, 7122) || ch == '\n'
                ) || (DynAbs.Tracing.TraceSender.Expression_False(10019, 7081, 7157) || ch == '\u0085'
                ) || (DynAbs.Tracing.TraceSender.Expression_False(10019, 7081, 7192) || ch == '\u2028'
                ) || (DynAbs.Tracing.TraceSender.Expression_False(10019, 7081, 7227) || ch == '\u2029');
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10019, 6718, 7239);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10019, 6718, 7239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10019, 6718, 7239);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsIdentifierStartCharacter(char ch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10019, 7460, 7614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 7539, 7603);

                return f_10019_7546_7602(ch);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10019, 7460, 7614);

                bool
                f_10019_7546_7602(char
                ch)
                {
                    var return_v = UnicodeCharacterUtilities.IsIdentifierStartCharacter(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10019, 7546, 7602);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10019, 7460, 7614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10019, 7460, 7614);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsIdentifierPartCharacter(char ch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10019, 7819, 7971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 7897, 7960);

                return f_10019_7904_7959(ch);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10019, 7819, 7971);

                bool
                f_10019_7904_7959(char
                ch)
                {
                    var return_v = UnicodeCharacterUtilities.IsIdentifierPartCharacter(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10019, 7904, 7959);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10019, 7819, 7971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10019, 7819, 7971);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsValidIdentifier(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10019, 8086, 8228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 8160, 8217);

                return f_10019_8167_8216(name);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10019, 8086, 8228);

                bool
                f_10019_8167_8216(string
                name)
                {
                    var return_v = UnicodeCharacterUtilities.IsValidIdentifier(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10019, 8167, 8216);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10019, 8086, 8228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10019, 8086, 8228);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ContainsDroppedIdentifierCharacters(string? name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10019, 8828, 9425);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 8923, 9021) || true) && (f_10019_8927_8959(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10019, 8923, 9021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 8993, 9006);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10019, 8923, 9021);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 9035, 9114) || true) && (f_10019_9039_9046(name, 0) == '@')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10019, 9035, 9114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 9087, 9099);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10019, 9035, 9114);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 9130, 9159);

                int
                nameLength = f_10019_9147_9158(name)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 9182, 9187);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 9173, 9385) || true) && (i < nameLength)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 9205, 9208)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10019, 9173, 9385))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10019, 9173, 9385);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 9242, 9370) || true) && (f_10019_9246_9297(f_10019_9289_9296(name, i)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10019, 9242, 9370);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 9339, 9351);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10019, 9242, 9370);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10019, 1, 213);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10019, 1, 213);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 9401, 9414);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10019, 8828, 9425);

                bool
                f_10019_8927_8959(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10019, 8927, 8959);
                    return return_v;
                }


                char
                f_10019_9039_9046(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10019, 9039, 9046);
                    return return_v;
                }


                int
                f_10019_9147_9158(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10019, 9147, 9158);
                    return return_v;
                }


                char
                f_10019_9289_9296(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10019, 9289, 9296);
                    return return_v;
                }


                bool
                f_10019_9246_9297(char
                ch)
                {
                    var return_v = UnicodeCharacterUtilities.IsFormattingChar(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10019, 9246, 9297);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10019, 8828, 9425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10019, 8828, 9425);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsNonAsciiQuotationMark(char ch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10019, 9437, 10080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 9653, 10069);

                switch (ch)
                {

                    case '\u2018': //LEFT SINGLE QUOTATION MARK
                    case '\u2019': //RIGHT SINGLE QUOTATION MARK
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10019, 9653, 10069);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 9824, 9836);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10019, 9653, 10069);

                    case '\u201C': //LEFT DOUBLE QUOTATION MARK
                    case '\u201D': //RIGHT DOUBLE QUOTATION MARK
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10019, 9653, 10069);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 9981, 9993);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10019, 9653, 10069);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10019, 9653, 10069);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10019, 10041, 10054);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10019, 9653, 10069);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10019, 9437, 10080);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10019, 9437, 10080);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10019, 9437, 10080);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxFacts()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10019, 480, 10087);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10081, 1099, 1204);
            EqualityComparer = f_10081_1171_1203(); 
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10019, 480, 10087);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10019, 480, 10087);
        }

        public static System.Collections.Generic.IEqualityComparer<SyntaxKind> f_10081_1171_1203()
        {
            var temp = new SyntaxKindEqualityComparer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10081, 1171, 1203);
            return temp;
        }
    }
}
