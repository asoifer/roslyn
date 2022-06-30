// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
namespace Microsoft.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class GeneratorAttribute : Attribute
    {
        public string[] Languages { get; }

        public GeneratorAttribute()
        : this(f_548_916_936_C(LanguageNames.CSharp))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(548, 868, 941);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(548, 868, 941);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(548, 868, 941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(548, 868, 941);
            }
        }

        public GeneratorAttribute(string firstLanguage, params string[] additionalLanguages)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(548, 1371, 2114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(548, 653, 687);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(548, 1480, 1609) || true) && (firstLanguage == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(548, 1480, 1609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(548, 1539, 1594);

                    throw f_548_1545_1593(nameof(firstLanguage));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(548, 1480, 1609);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(548, 1625, 1766) || true) && (additionalLanguages == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(548, 1625, 1766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(548, 1690, 1751);

                    throw f_548_1696_1750(nameof(additionalLanguages));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(548, 1625, 1766);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(548, 1782, 1841);

                var
                languages = new string[f_548_1809_1835(additionalLanguages) + 1]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(548, 1855, 1884);

                languages[0] = firstLanguage;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(548, 1907, 1916);
                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(548, 1898, 2060) || true) && (index < f_548_1926_1952(additionalLanguages))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(548, 1954, 1961)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(548, 1898, 2060))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(548, 1898, 2060);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(548, 1995, 2045);

                        languages[index + 1] = additionalLanguages[index];
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(548, 1, 163);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(548, 1, 163);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(548, 2076, 2103);

                this.Languages = languages;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(548, 1371, 2114);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(548, 1371, 2114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(548, 1371, 2114);
            }
        }

        static GeneratorAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(548, 393, 2123);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(548, 393, 2123);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(548, 393, 2123);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(548, 393, 2123);

        static string
        f_548_916_936_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(548, 868, 941);
            return return_v;
        }


        static System.ArgumentNullException
        f_548_1545_1593(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(548, 1545, 1593);
            return return_v;
        }


        static System.ArgumentNullException
        f_548_1696_1750(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(548, 1696, 1750);
            return return_v;
        }


        static int
        f_548_1809_1835(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(548, 1809, 1835);
            return return_v;
        }


        static int
        f_548_1926_1952(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(548, 1926, 1952);
            return return_v;
        }

    }
}
