// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Globalization;
using System.Text;

namespace Roslyn.Test
{
    internal static class StringUtilities
    {
        internal static string EscapeNonPrintableCharacters(string str)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24012, 364, 1372);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24012, 452, 491);

                StringBuilder
                sb = f_24012_471_490()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24012, 507, 1324);
                    foreach (char c in f_24012_526_529_I(str))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(24012, 507, 1324);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24012, 563, 575);

                        bool
                        escape
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(24012, 593, 1086);

                        switch (f_24012_601_638(c))
                        {

                            case UnicodeCategory.Control:
                            case UnicodeCategory.OtherNotAssigned:
                            case UnicodeCategory.ParagraphSeparator:
                            case UnicodeCategory.Surrogate:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(24012, 593, 1086);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24012, 910, 924);

                                escape = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(24012, 950, 956);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(24012, 593, 1086);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(24012, 593, 1086);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24012, 1014, 1035);

                                escape = c >= 0xFFFC;
                                DynAbs.Tracing.TraceSender.TraceBreak(24012, 1061, 1067);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(24012, 593, 1086);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(24012, 1106, 1309) || true) && (escape)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24012, 1106, 1309);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24012, 1158, 1195);

                            f_24012_1158_1194(sb, "\\u{0:X4}", c);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(24012, 1106, 1309);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(24012, 1106, 1309);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(24012, 1277, 1290);

                            f_24012_1277_1289(sb, c);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(24012, 1106, 1309);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(24012, 507, 1324);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(24012, 1, 818);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(24012, 1, 818);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24012, 1340, 1361);

                return f_24012_1347_1360(sb);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24012, 364, 1372);

                System.Text.StringBuilder
                f_24012_471_490()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24012, 471, 490);
                    return return_v;
                }


                System.Globalization.UnicodeCategory
                f_24012_601_638(char
                ch)
                {
                    var return_v = CharUnicodeInfo.GetUnicodeCategory(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24012, 601, 638);
                    return return_v;
                }


                System.Text.StringBuilder
                f_24012_1158_1194(System.Text.StringBuilder
                this_param, string
                format, int
                arg0)
                {
                    var return_v = this_param.AppendFormat(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24012, 1158, 1194);
                    return return_v;
                }


                System.Text.StringBuilder
                f_24012_1277_1289(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24012, 1277, 1289);
                    return return_v;
                }


                string
                f_24012_526_529_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24012, 526, 529);
                    return return_v;
                }


                string
                f_24012_1347_1360(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24012, 1347, 1360);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24012, 364, 1372);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24012, 364, 1372);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static StringUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24012, 310, 1379);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24012, 310, 1379);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24012, 310, 1379);
        }

    }
}
