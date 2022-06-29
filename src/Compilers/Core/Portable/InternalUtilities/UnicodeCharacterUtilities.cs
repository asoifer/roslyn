// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Roslyn.Utilities
{
    internal static partial class UnicodeCharacterUtilities
    {
        public static bool IsIdentifierStartCharacter(char ch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(394, 498, 1277);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 712, 979) || true) && (ch < 'a')
                ) // '\u0061'

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(394, 712, 979);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 770, 868) || true) && (ch < 'A')
                    ) // '\u0041'

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(394, 770, 868);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 836, 849);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(394, 770, 868);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 888, 952);

                    return ch <= 'Z'  // '\u005A'
                    || (DynAbs.Tracing.TraceSender.Expression_False(394, 895, 951) || ch == '_');
                    DynAbs.Tracing.TraceSender.TraceExitCondition(394, 712, 979);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 995, 1081) || true) && (ch <= 'z')
                ) // '\u007A'

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(394, 995, 1081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 1054, 1066);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(394, 995, 1081);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 1097, 1190) || true) && (ch <= '\u007F')
                ) // max ASCII

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(394, 1097, 1190);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 1162, 1175);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(394, 1097, 1190);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 1206, 1266);

                return f_394_1213_1265(f_394_1226_1264(ch));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(394, 498, 1277);

                System.Globalization.UnicodeCategory
                f_394_1226_1264(char
                ch)
                {
                    var return_v = CharUnicodeInfo.GetUnicodeCategory(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(394, 1226, 1264);
                    return return_v;
                }


                bool
                f_394_1213_1265(System.Globalization.UnicodeCategory
                cat)
                {
                    var return_v = IsLetterChar(cat);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(394, 1213, 1265);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(394, 498, 1277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(394, 498, 1277);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsIdentifierPartCharacter(char ch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(394, 1480, 2637);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 1796, 2130) || true) && (ch < 'a')
                ) // '\u0061'

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(394, 1796, 2130);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 1854, 2019) || true) && (ch < 'A')
                    ) // '\u0041'

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(394, 1854, 2019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 1920, 1988);

                        return ch >= '0'  // '\u0030'
                        && (DynAbs.Tracing.TraceSender.Expression_True(394, 1927, 1987) && ch <= '9');
                        DynAbs.Tracing.TraceSender.TraceExitCondition(394, 1854, 2019);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 2039, 2103);

                    return ch <= 'Z'  // '\u005A'
                    || (DynAbs.Tracing.TraceSender.Expression_False(394, 2046, 2102) || ch == '_');
                    DynAbs.Tracing.TraceSender.TraceExitCondition(394, 1796, 2130);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 2146, 2232) || true) && (ch <= 'z')
                ) // '\u007A'

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(394, 2146, 2232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 2205, 2217);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(394, 2146, 2232);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 2248, 2341) || true) && (ch <= '\u007F')
                ) // max ASCII

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(394, 2248, 2341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 2313, 2326);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(394, 2248, 2341);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 2357, 2418);

                UnicodeCategory
                cat = f_394_2379_2417(ch)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 2432, 2626);

                return f_394_2439_2456(cat) || (DynAbs.Tracing.TraceSender.Expression_False(394, 2439, 2500) || f_394_2477_2500(cat)) || (DynAbs.Tracing.TraceSender.Expression_False(394, 2439, 2542) || f_394_2521_2542(cat)) || (DynAbs.Tracing.TraceSender.Expression_False(394, 2439, 2583) || f_394_2563_2583(cat)) || (DynAbs.Tracing.TraceSender.Expression_False(394, 2439, 2625) || f_394_2604_2625(cat));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(394, 1480, 2637);

                System.Globalization.UnicodeCategory
                f_394_2379_2417(char
                ch)
                {
                    var return_v = CharUnicodeInfo.GetUnicodeCategory(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(394, 2379, 2417);
                    return return_v;
                }


                bool
                f_394_2439_2456(System.Globalization.UnicodeCategory
                cat)
                {
                    var return_v = IsLetterChar(cat);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(394, 2439, 2456);
                    return return_v;
                }


                bool
                f_394_2477_2500(System.Globalization.UnicodeCategory
                cat)
                {
                    var return_v = IsDecimalDigitChar(cat);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(394, 2477, 2500);
                    return return_v;
                }


                bool
                f_394_2521_2542(System.Globalization.UnicodeCategory
                cat)
                {
                    var return_v = IsConnectingChar(cat);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(394, 2521, 2542);
                    return return_v;
                }


                bool
                f_394_2563_2583(System.Globalization.UnicodeCategory
                cat)
                {
                    var return_v = IsCombiningChar(cat);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(394, 2563, 2583);
                    return return_v;
                }


                bool
                f_394_2604_2625(System.Globalization.UnicodeCategory
                cat)
                {
                    var return_v = IsFormattingChar(cat);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(394, 2604, 2625);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(394, 1480, 2637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(394, 1480, 2637);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsValidIdentifier([NotNullWhen(returnValue: true)] string? name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(394, 2760, 3396);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 2868, 2966) || true) && (f_394_2872_2904(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(394, 2868, 2966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 2938, 2951);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(394, 2868, 2966);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 2982, 3084) || true) && (!f_394_2987_3022(f_394_3014_3021(name, 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(394, 2982, 3084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 3056, 3069);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(394, 2982, 3084);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 3100, 3129);

                int
                nameLength = f_394_3117_3128(name)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 3152, 3157);
                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 3143, 3357) || true) && (i < nameLength)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 3175, 3178)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(394, 3143, 3357)) //NB: start at 1

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(394, 3143, 3357);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 3229, 3342) || true) && (!f_394_3234_3268(f_394_3260_3267(name, i)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(394, 3229, 3342);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 3310, 3323);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(394, 3229, 3342);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(394, 1, 215);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(394, 1, 215);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 3373, 3385);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(394, 2760, 3396);

                bool
                f_394_2872_2904(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(394, 2872, 2904);
                    return return_v;
                }


                char
                f_394_3014_3021(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(394, 3014, 3021);
                    return return_v;
                }


                bool
                f_394_2987_3022(char
                ch)
                {
                    var return_v = IsIdentifierStartCharacter(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(394, 2987, 3022);
                    return return_v;
                }


                int
                f_394_3117_3128(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(394, 3117, 3128);
                    return return_v;
                }


                char
                f_394_3260_3267(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(394, 3260, 3267);
                    return return_v;
                }


                bool
                f_394_3234_3268(char
                ch)
                {
                    var return_v = IsIdentifierPartCharacter(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(394, 3234, 3268);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(394, 2760, 3396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(394, 2760, 3396);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsLetterChar(UnicodeCategory cat)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(394, 3408, 4142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 3704, 4102);

                switch (cat)
                {

                    case UnicodeCategory.UppercaseLetter:
                    case UnicodeCategory.LowercaseLetter:
                    case UnicodeCategory.TitlecaseLetter:
                    case UnicodeCategory.ModifierLetter:
                    case UnicodeCategory.OtherLetter:
                    case UnicodeCategory.LetterNumber:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(394, 3704, 4102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 4075, 4087);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(394, 3704, 4102);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 4118, 4131);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(394, 3408, 4142);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(394, 3408, 4142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(394, 3408, 4142);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsCombiningChar(UnicodeCategory cat)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(394, 4154, 4652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 4422, 4612);

                switch (cat)
                {

                    case UnicodeCategory.NonSpacingMark:
                    case UnicodeCategory.SpacingCombiningMark:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(394, 4422, 4612);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 4585, 4597);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(394, 4422, 4612);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 4628, 4641);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(394, 4154, 4652);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(394, 4154, 4652);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(394, 4154, 4652);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsDecimalDigitChar(UnicodeCategory cat)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(394, 4664, 4991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 4931, 4980);

                return cat == UnicodeCategory.DecimalDigitNumber;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(394, 4664, 4991);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(394, 4664, 4991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(394, 4664, 4991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsConnectingChar(UnicodeCategory cat)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(394, 5003, 5328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 5266, 5317);

                return cat == UnicodeCategory.ConnectorPunctuation;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(394, 5003, 5328);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(394, 5003, 5328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(394, 5003, 5328);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsFormattingChar(char ch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(394, 5545, 5765);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 5678, 5754);

                return ch > 127 && (DynAbs.Tracing.TraceSender.Expression_True(394, 5685, 5753) && f_394_5697_5753(f_394_5714_5752(ch)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(394, 5545, 5765);

                System.Globalization.UnicodeCategory
                f_394_5714_5752(char
                ch)
                {
                    var return_v = CharUnicodeInfo.GetUnicodeCategory(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(394, 5714, 5752);
                    return return_v;
                }


                bool
                f_394_5697_5753(System.Globalization.UnicodeCategory
                cat)
                {
                    var return_v = IsFormattingChar(cat);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(394, 5697, 5753);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(394, 5545, 5765);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(394, 5545, 5765);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsFormattingChar(UnicodeCategory cat)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(394, 5983, 6294);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(394, 6246, 6283);

                return cat == UnicodeCategory.Format;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(394, 5983, 6294);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(394, 5983, 6294);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(394, 5983, 6294);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static UnicodeCharacterUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(394, 426, 6301);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(394, 426, 6301);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(394, 426, 6301);
        }

    }
}
