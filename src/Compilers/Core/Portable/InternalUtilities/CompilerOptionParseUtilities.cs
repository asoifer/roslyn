// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace Roslyn.Utilities
{
    internal static class CompilerOptionParseUtilities
    {
        public static IList<string> ParseFeatureFromMSBuild(string? features)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(313, 561, 894);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(313, 655, 781) || true) && (f_313_659_695(features))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(313, 655, 781);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(313, 729, 766);

                    return f_313_736_765(capacity: 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(313, 655, 781);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(313, 797, 883);

                return f_313_804_882(features, new[] { ';', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(313, 561, 894);

                bool
                f_313_659_695(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(313, 659, 695);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_313_736_765(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.List<string>(capacity: capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(313, 736, 765);
                    return return_v;
                }


                string[]
                f_313_804_882(string
                this_param, char[]
                separator, System.StringSplitOptions
                options)
                {
                    var return_v = this_param.Split(separator, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(313, 804, 882);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(313, 561, 894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(313, 561, 894);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void ParseFeatures(IDictionary<string, string> builder, List<string> values)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(313, 906, 1310);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(313, 1021, 1299);
                    foreach (var commaFeatures in f_313_1051_1057_I(values))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(313, 1021, 1299);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(313, 1091, 1284);
                            foreach (var feature in f_313_1115_1188_I(f_313_1115_1188(commaFeatures, new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(313, 1091, 1284);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(313, 1230, 1265);

                                f_313_1230_1264(builder, feature);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(313, 1091, 1284);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(313, 1, 194);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(313, 1, 194);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(313, 1021, 1299);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(313, 1, 279);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(313, 1, 279);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(313, 906, 1310);

                string[]
                f_313_1115_1188(string
                this_param, char[]
                separator, System.StringSplitOptions
                options)
                {
                    var return_v = this_param.Split(separator, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(313, 1115, 1188);
                    return return_v;
                }


                int
                f_313_1230_1264(System.Collections.Generic.IDictionary<string, string>
                builder, string
                feature)
                {
                    ParseFeatureCore(builder, feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(313, 1230, 1264);
                    return 0;
                }


                string[]
                f_313_1115_1188_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(313, 1115, 1188);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_313_1051_1057_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(313, 1051, 1057);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(313, 906, 1310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(313, 906, 1310);
            }
        }

        private static void ParseFeatureCore(IDictionary<string, string> builder, string feature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(313, 1322, 1796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(313, 1436, 1470);

                int
                equals = f_313_1449_1469(feature, '=')
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(313, 1484, 1785) || true) && (equals > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(313, 1484, 1785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(313, 1532, 1575);

                    string
                    name = f_313_1546_1574(feature, 0, equals)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(313, 1593, 1638);

                    string
                    value = f_313_1608_1637(feature, equals + 1)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(313, 1656, 1678);

                    builder[name] = value;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(313, 1484, 1785);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(313, 1484, 1785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(313, 1744, 1770);

                    builder[feature] = "true";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(313, 1484, 1785);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(313, 1322, 1796);

                int
                f_313_1449_1469(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(313, 1449, 1469);
                    return return_v;
                }


                string
                f_313_1546_1574(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(313, 1546, 1574);
                    return return_v;
                }


                string
                f_313_1608_1637(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(313, 1608, 1637);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(313, 1322, 1796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(313, 1322, 1796);
            }
        }

        static CompilerOptionParseUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(313, 295, 1803);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(313, 295, 1803);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(313, 295, 1803);
        }

    }
}
