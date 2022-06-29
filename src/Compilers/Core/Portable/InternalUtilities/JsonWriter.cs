// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;

namespace Roslyn.Utilities
{
    internal sealed class JsonWriter : IDisposable
    {
        private readonly TextWriter _output;

        private int _indent;

        private Pending _pending;

        private enum Pending { None, NewLineAndIndent, CommaNewLineAndIndent };

        private const string
        Indentation = "  "
        ;

        public JsonWriter(TextWriter output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(343, 1256, 1383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 1038, 1045);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 1068, 1075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 1102, 1110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 1317, 1334);

                _output = output;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 1348, 1372);

                _pending = Pending.None;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(343, 1256, 1383);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(343, 1256, 1383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(343, 1256, 1383);
            }
        }

        public void WriteObjectStart()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(343, 1395, 1477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 1450, 1466);

                f_343_1450_1465(this, '{');
                DynAbs.Tracing.TraceSender.TraceExitMethod(343, 1395, 1477);

                int
                f_343_1450_1465(Roslyn.Utilities.JsonWriter
                this_param, char
                c)
                {
                    this_param.WriteStart(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 1450, 1465);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(343, 1395, 1477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(343, 1395, 1477);
            }
        }

        public void WriteObjectStart(string key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(343, 1489, 1612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 1554, 1568);

                f_343_1554_1567(this, key);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 1582, 1601);

                f_343_1582_1600(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(343, 1489, 1612);

                int
                f_343_1554_1567(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 1554, 1567);
                    return 0;
                }


                int
                f_343_1582_1600(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteObjectStart();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 1582, 1600);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(343, 1489, 1612);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(343, 1489, 1612);
            }
        }

        public void WriteObjectEnd()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(343, 1624, 1702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 1677, 1691);

                f_343_1677_1690(this, '}');
                DynAbs.Tracing.TraceSender.TraceExitMethod(343, 1624, 1702);

                int
                f_343_1677_1690(Roslyn.Utilities.JsonWriter
                this_param, char
                c)
                {
                    this_param.WriteEnd(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 1677, 1690);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(343, 1624, 1702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(343, 1624, 1702);
            }
        }

        public void WriteArrayStart()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(343, 1714, 1795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 1768, 1784);

                f_343_1768_1783(this, '[');
                DynAbs.Tracing.TraceSender.TraceExitMethod(343, 1714, 1795);

                int
                f_343_1768_1783(Roslyn.Utilities.JsonWriter
                this_param, char
                c)
                {
                    this_param.WriteStart(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 1768, 1783);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(343, 1714, 1795);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(343, 1714, 1795);
            }
        }

        public void WriteArrayStart(string key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(343, 1807, 1928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 1871, 1885);

                f_343_1871_1884(this, key);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 1899, 1917);

                f_343_1899_1916(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(343, 1807, 1928);

                int
                f_343_1871_1884(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 1871, 1884);
                    return 0;
                }


                int
                f_343_1899_1916(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WriteArrayStart();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 1899, 1916);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(343, 1807, 1928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(343, 1807, 1928);
            }
        }

        public void WriteArrayEnd()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(343, 1940, 2017);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 1992, 2006);

                f_343_1992_2005(this, ']');
                DynAbs.Tracing.TraceSender.TraceExitMethod(343, 1940, 2017);

                int
                f_343_1992_2005(Roslyn.Utilities.JsonWriter
                this_param, char
                c)
                {
                    this_param.WriteEnd(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 1992, 2005);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(343, 1940, 2017);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(343, 1940, 2017);
            }
        }

        public void WriteKey(string key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(343, 2029, 2180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 2086, 2097);

                f_343_2086_2096(this, key);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 2111, 2131);

                f_343_2111_2130(_output, ": ");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 2145, 2169);

                _pending = Pending.None;
                DynAbs.Tracing.TraceSender.TraceExitMethod(343, 2029, 2180);

                int
                f_343_2086_2096(Roslyn.Utilities.JsonWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 2086, 2096);
                    return 0;
                }


                int
                f_343_2111_2130(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 2111, 2130);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(343, 2029, 2180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(343, 2029, 2180);
            }
        }

        public void Write(string key, string? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(343, 2192, 2313);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 2261, 2275);

                f_343_2261_2274(this, key);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 2289, 2302);

                f_343_2289_2301(this, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(343, 2192, 2313);

                int
                f_343_2261_2274(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 2261, 2274);
                    return 0;
                }


                int
                f_343_2289_2301(Roslyn.Utilities.JsonWriter
                this_param, string?
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 2289, 2301);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(343, 2192, 2313);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(343, 2192, 2313);
            }
        }

        public void Write(string key, int value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(343, 2325, 2442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 2390, 2404);

                f_343_2390_2403(this, key);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 2418, 2431);

                f_343_2418_2430(this, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(343, 2325, 2442);

                int
                f_343_2390_2403(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 2390, 2403);
                    return 0;
                }


                int
                f_343_2418_2430(Roslyn.Utilities.JsonWriter
                this_param, int
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 2418, 2430);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(343, 2325, 2442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(343, 2325, 2442);
            }
        }

        public void Write(string key, bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(343, 2454, 2572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 2520, 2534);

                f_343_2520_2533(this, key);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 2548, 2561);

                f_343_2548_2560(this, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(343, 2454, 2572);

                int
                f_343_2520_2533(Roslyn.Utilities.JsonWriter
                this_param, string
                key)
                {
                    this_param.WriteKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 2520, 2533);
                    return 0;
                }


                int
                f_343_2548_2560(Roslyn.Utilities.JsonWriter
                this_param, bool
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 2548, 2560);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(343, 2454, 2572);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(343, 2454, 2572);
            }
        }

        public void Write(string? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(343, 2584, 2837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 2641, 2656);

                f_343_2641_2655(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 2670, 2689);

                f_343_2670_2688(_output, '"');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 2703, 2738);

                f_343_2703_2737(_output, f_343_2717_2736(value));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 2752, 2771);

                f_343_2752_2770(_output, '"');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 2785, 2826);

                _pending = Pending.CommaNewLineAndIndent;
                DynAbs.Tracing.TraceSender.TraceExitMethod(343, 2584, 2837);

                int
                f_343_2641_2655(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WritePending();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 2641, 2655);
                    return 0;
                }


                int
                f_343_2670_2688(System.IO.TextWriter
                this_param, char
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 2670, 2688);
                    return 0;
                }


                string
                f_343_2717_2736(string?
                value)
                {
                    var return_v = EscapeString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 2717, 2736);
                    return return_v;
                }


                int
                f_343_2703_2737(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 2703, 2737);
                    return 0;
                }


                int
                f_343_2752_2770(System.IO.TextWriter
                this_param, char
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 2752, 2770);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(343, 2584, 2837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(343, 2584, 2837);
            }
        }

        public void Write(int value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(343, 2849, 3057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 2902, 2917);

                f_343_2902_2916(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 2931, 2991);

                f_343_2931_2990(_output, f_343_2945_2989(value, f_343_2960_2988()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 3005, 3046);

                _pending = Pending.CommaNewLineAndIndent;
                DynAbs.Tracing.TraceSender.TraceExitMethod(343, 2849, 3057);

                int
                f_343_2902_2916(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WritePending();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 2902, 2916);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_343_2960_2988()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(343, 2960, 2988);
                    return return_v;
                }


                string
                f_343_2945_2989(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 2945, 2989);
                    return return_v;
                }


                int
                f_343_2931_2990(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 2931, 2990);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(343, 2849, 3057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(343, 2849, 3057);
            }
        }

        public void Write(bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(343, 3069, 3258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 3123, 3138);

                f_343_3123_3137(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 3152, 3192);

                f_343_3152_3191(_output, (DynAbs.Tracing.TraceSender.Conditional_F1(343, 3166, 3171) || ((value && DynAbs.Tracing.TraceSender.Conditional_F2(343, 3174, 3180)) || DynAbs.Tracing.TraceSender.Conditional_F3(343, 3183, 3190))) ? "true" : "false");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 3206, 3247);

                _pending = Pending.CommaNewLineAndIndent;
                DynAbs.Tracing.TraceSender.TraceExitMethod(343, 3069, 3258);

                int
                f_343_3123_3137(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WritePending();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 3123, 3137);
                    return 0;
                }


                int
                f_343_3152_3191(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 3152, 3191);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(343, 3069, 3258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(343, 3069, 3258);
            }
        }

        private void WritePending()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(343, 3270, 3816);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 3322, 3406) || true) && (_pending == Pending.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(343, 3322, 3406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 3384, 3391);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(343, 3322, 3406);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 3422, 3518);

                f_343_3422_3517(_pending == Pending.NewLineAndIndent || (DynAbs.Tracing.TraceSender.Expression_False(343, 3435, 3516) || _pending == Pending.CommaNewLineAndIndent));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 3532, 3645) || true) && (_pending == Pending.CommaNewLineAndIndent)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(343, 3532, 3645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 3611, 3630);

                    f_343_3611_3629(_output, ',');
                    DynAbs.Tracing.TraceSender.TraceExitCondition(343, 3532, 3645);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 3661, 3681);

                f_343_3661_3680(
                            _output);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 3706, 3711);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 3697, 3805) || true) && (i < _indent)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 3726, 3729)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(343, 3697, 3805))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(343, 3697, 3805);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 3763, 3790);

                        f_343_3763_3789(_output, Indentation);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(343, 1, 109);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(343, 1, 109);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(343, 3270, 3816);

                int
                f_343_3422_3517(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 3422, 3517);
                    return 0;
                }


                int
                f_343_3611_3629(System.IO.TextWriter
                this_param, char
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 3611, 3629);
                    return 0;
                }


                int
                f_343_3661_3680(System.IO.TextWriter
                this_param)
                {
                    this_param.WriteLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 3661, 3680);
                    return 0;
                }


                int
                f_343_3763_3789(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 3763, 3789);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(343, 3270, 3816);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(343, 3270, 3816);
            }
        }

        private void WriteStart(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(343, 3828, 4015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 3884, 3899);

                f_343_3884_3898(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 3913, 3930);

                f_343_3913_3929(_output, c);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 3944, 3980);

                _pending = Pending.NewLineAndIndent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 3994, 4004);

                _indent++;
                DynAbs.Tracing.TraceSender.TraceExitMethod(343, 3828, 4015);

                int
                f_343_3884_3898(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WritePending();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 3884, 3898);
                    return 0;
                }


                int
                f_343_3913_3929(System.IO.TextWriter
                this_param, char
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 3913, 3929);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(343, 3828, 4015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(343, 3828, 4015);
            }
        }

        private void WriteEnd(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(343, 4027, 4267);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 4081, 4117);

                _pending = Pending.NewLineAndIndent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 4131, 4141);

                _indent--;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 4155, 4170);

                f_343_4155_4169(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 4184, 4201);

                f_343_4184_4200(_output, c);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 4215, 4256);

                _pending = Pending.CommaNewLineAndIndent;
                DynAbs.Tracing.TraceSender.TraceExitMethod(343, 4027, 4267);

                int
                f_343_4155_4169(Roslyn.Utilities.JsonWriter
                this_param)
                {
                    this_param.WritePending();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 4155, 4169);
                    return 0;
                }


                int
                f_343_4184_4200(System.IO.TextWriter
                this_param, char
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 4184, 4200);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(343, 4027, 4267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(343, 4027, 4267);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(343, 4279, 4354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 4325, 4343);

                f_343_4325_4342(_output);
                DynAbs.Tracing.TraceSender.TraceExitMethod(343, 4279, 4354);

                int
                f_343_4325_4342(System.IO.TextWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 4325, 4342);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(343, 4279, 4354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(343, 4279, 4354);
            }
        }

        private static string EscapeString(string? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(343, 4717, 6768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 4791, 4833);

                PooledStringBuilder?
                pooledBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 4847, 4871);

                StringBuilder?
                b = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 4887, 4993) || true) && (f_343_4891_4924(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(343, 4887, 4993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 4958, 4978);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(343, 4887, 4993);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 5009, 5028);

                int
                startIndex = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 5042, 5056);

                int
                count = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 5079, 5084);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 5070, 6388) || true) && (i < f_343_5090_5102(value))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 5104, 5107)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(343, 5070, 6388))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(343, 5070, 6388);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 5141, 5159);

                        char
                        c = f_343_5150_5158(value, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 5179, 6373) || true) && (c == '\"' || (DynAbs.Tracing.TraceSender.Expression_False(343, 5183, 5205) || c == '\\') || (DynAbs.Tracing.TraceSender.Expression_False(343, 5183, 5233) || f_343_5209_5233(c)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(343, 5179, 6373);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 5275, 5531) || true) && (b == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(343, 5275, 5531);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 5338, 5380);

                                f_343_5338_5379(pooledBuilder == null);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 5406, 5456);

                                pooledBuilder = f_343_5422_5455();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 5482, 5508);

                                b = pooledBuilder.Builder;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(343, 5275, 5531);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 5555, 5676) || true) && (count > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(343, 5555, 5676);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 5618, 5653);

                                f_343_5618_5652(b, value, startIndex, count);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(343, 5555, 5676);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 5700, 5719);

                            startIndex = i + 1;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 5741, 5751);

                            count = 0;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 5775, 6264);

                            switch (c)
                            {

                                case '\"':
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(343, 5775, 6264);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 5874, 5891);

                                    f_343_5874_5890(b, "\\\"");
                                    DynAbs.Tracing.TraceSender.TraceBreak(343, 5921, 5927);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(343, 5775, 6264);

                                case '\\':
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(343, 5775, 6264);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 5993, 6010);

                                    f_343_5993_6009(b, "\\\\");
                                    DynAbs.Tracing.TraceSender.TraceBreak(343, 6040, 6046);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(343, 5775, 6264);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(343, 5775, 6264);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 6110, 6149);

                                    f_343_6110_6148(f_343_6123_6147(c));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 6179, 6205);

                                    f_343_6179_6204(b, c);
                                    DynAbs.Tracing.TraceSender.TraceBreak(343, 6235, 6241);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(343, 5775, 6264);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(343, 5179, 6373);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(343, 5179, 6373);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 6346, 6354);

                            count++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(343, 5179, 6373);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(343, 1, 1319);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(343, 1, 1319);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 6404, 6589) || true) && (b == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(343, 6404, 6589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 6451, 6464);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(343, 6404, 6589);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(343, 6404, 6589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 6530, 6574);

                    f_343_6530_6573(pooledBuilder is object);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(343, 6404, 6589);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 6605, 6702) || true) && (count > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(343, 6605, 6702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 6652, 6687);

                    f_343_6652_6686(b, value, startIndex, count);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(343, 6605, 6702);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 6718, 6757);

                return f_343_6725_6756(pooledBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(343, 4717, 6768);

                bool
                f_343_4891_4924(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 4891, 4924);
                    return return_v;
                }


                int
                f_343_5090_5102(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(343, 5090, 5102);
                    return return_v;
                }


                char
                f_343_5150_5158(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(343, 5150, 5158);
                    return return_v;
                }


                bool
                f_343_5209_5233(char
                c)
                {
                    var return_v = ShouldAppendAsUnicode(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 5209, 5233);
                    return return_v;
                }


                int
                f_343_5338_5379(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 5338, 5379);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_343_5422_5455()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 5422, 5455);
                    return return_v;
                }


                System.Text.StringBuilder
                f_343_5618_5652(System.Text.StringBuilder
                this_param, string
                value, int
                startIndex, int
                count)
                {
                    var return_v = this_param.Append(value, startIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 5618, 5652);
                    return return_v;
                }


                System.Text.StringBuilder
                f_343_5874_5890(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 5874, 5890);
                    return return_v;
                }


                System.Text.StringBuilder
                f_343_5993_6009(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 5993, 6009);
                    return return_v;
                }


                bool
                f_343_6123_6147(char
                c)
                {
                    var return_v = ShouldAppendAsUnicode(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 6123, 6147);
                    return return_v;
                }


                int
                f_343_6110_6148(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 6110, 6148);
                    return 0;
                }


                int
                f_343_6179_6204(System.Text.StringBuilder
                builder, char
                c)
                {
                    AppendCharAsUnicode(builder, c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 6179, 6204);
                    return 0;
                }


                int
                f_343_6530_6573(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 6530, 6573);
                    return 0;
                }


                System.Text.StringBuilder
                f_343_6652_6686(System.Text.StringBuilder
                this_param, string
                value, int
                startIndex, int
                count)
                {
                    var return_v = this_param.Append(value, startIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 6652, 6686);
                    return return_v;
                }


                string
                f_343_6725_6756(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 6725, 6756);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(343, 4717, 6768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(343, 4717, 6768);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AppendCharAsUnicode(StringBuilder builder, char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(343, 6780, 6991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 6875, 6897);

                f_343_6875_6896(builder, "\\u");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 6911, 6980);

                f_343_6911_6979(builder, f_343_6932_6960(), "{0:x4}", c);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(343, 6780, 6991);

                System.Text.StringBuilder
                f_343_6875_6896(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 6875, 6896);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_343_6932_6960()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(343, 6932, 6960);
                    return return_v;
                }


                System.Text.StringBuilder
                f_343_6911_6979(System.Text.StringBuilder
                this_param, System.Globalization.CultureInfo
                provider, string
                format, int
                arg0)
                {
                    var return_v = this_param.AppendFormat((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(343, 6911, 6979);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(343, 6780, 6991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(343, 6780, 6991);
            }
        }

        private static bool ShouldAppendAsUnicode(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(343, 7003, 7746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 7471, 7703);

                return c < ' ' || (DynAbs.Tracing.TraceSender.Expression_False(343, 7478, 7523) || c >= (char)0xfffe) || (DynAbs.Tracing.TraceSender.Expression_False(343, 7478, 7597) || (c >= (char)0xd800 && (DynAbs.Tracing.TraceSender.Expression_True(343, 7558, 7596) && c <= (char)0xdfff))) || (DynAbs.Tracing.TraceSender.Expression_False(343, 7478, 7702) || (c == '\u0085' || (DynAbs.Tracing.TraceSender.Expression_False(343, 7654, 7684) || c == '\u2028') || (DynAbs.Tracing.TraceSender.Expression_False(343, 7654, 7701) || c == '\u2029')));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(343, 7003, 7746);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(343, 7003, 7746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(343, 7003, 7746);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static JsonWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(343, 947, 7753);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(343, 1225, 1243);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(343, 947, 7753);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(343, 947, 7753);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(343, 947, 7753);
    }
}
