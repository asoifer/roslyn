// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class DiagnosticAnalyzerAttribute : Attribute
    {
        public string[] Languages { get; }

        public DiagnosticAnalyzerAttribute(string firstLanguage, params string[] additionalLanguages)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(260, 1105, 1857);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(260, 680, 714);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(260, 1223, 1352) || true) && (firstLanguage == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(260, 1223, 1352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(260, 1282, 1337);

                    throw f_260_1288_1336(nameof(firstLanguage));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(260, 1223, 1352);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(260, 1368, 1509) || true) && (additionalLanguages == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(260, 1368, 1509);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(260, 1433, 1494);

                    throw f_260_1439_1493(nameof(additionalLanguages));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(260, 1368, 1509);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(260, 1525, 1584);

                var
                languages = new string[f_260_1552_1578(additionalLanguages) + 1]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(260, 1598, 1627);

                languages[0] = firstLanguage;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(260, 1650, 1659);
                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(260, 1641, 1803) || true) && (index < f_260_1669_1695(additionalLanguages))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(260, 1697, 1704)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(260, 1641, 1803))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(260, 1641, 1803);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(260, 1738, 1788);

                        languages[index + 1] = additionalLanguages[index];
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(260, 1, 163);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(260, 1, 163);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(260, 1819, 1846);

                this.Languages = languages;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(260, 1105, 1857);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(260, 1105, 1857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(260, 1105, 1857);
            }
        }

        static DiagnosticAnalyzerAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(260, 411, 1864);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(260, 411, 1864);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(260, 411, 1864);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(260, 411, 1864);

        static System.ArgumentNullException
        f_260_1288_1336(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(260, 1288, 1336);
            return return_v;
        }


        static System.ArgumentNullException
        f_260_1439_1493(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(260, 1439, 1493);
            return return_v;
        }


        static int
        f_260_1552_1578(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(260, 1552, 1578);
            return return_v;
        }


        static int
        f_260_1669_1695(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(260, 1669, 1695);
            return return_v;
        }

    }
}
