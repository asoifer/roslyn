// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Roslyn.Utilities;
using Xunit;
using ReferenceEqualityComparer = Roslyn.Utilities.ReferenceEqualityComparer;

namespace Roslyn.Test.Utilities
{
    public static class AssertXml
    {
        public static void Equal(string expected, string actual)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25001, 1104, 1354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 1185, 1343);

                f_25001_1185_1342(f_25001_1191_1215(expected), f_25001_1217_1239(actual), message: null, expectedValueSourcePath: null, expectedValueSourceLine: 0, expectedIsXmlLiteral: true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25001, 1104, 1354);

                System.Xml.Linq.XElement
                f_25001_1191_1215(string
                text)
                {
                    var return_v = XElement.Parse(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 1191, 1215);
                    return return_v;
                }


                System.Xml.Linq.XElement
                f_25001_1217_1239(string
                text)
                {
                    var return_v = XElement.Parse(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 1217, 1239);
                    return return_v;
                }


                int
                f_25001_1185_1342(System.Xml.Linq.XElement
                expectedRoot, System.Xml.Linq.XElement
                actualRoot, string
                message, string
                expectedValueSourcePath, int
                expectedValueSourceLine, bool
                expectedIsXmlLiteral)
                {
                    Equal(expectedRoot, actualRoot, message: message, expectedValueSourcePath: expectedValueSourcePath, expectedValueSourceLine: expectedValueSourceLine, expectedIsXmlLiteral: expectedIsXmlLiteral);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 1185, 1342);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25001, 1104, 1354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25001, 1104, 1354);
            }
        }

        public static void Equal(XElement expected, XElement actual)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25001, 1366, 1589);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 1451, 1578);

                f_25001_1451_1577(expected, actual, message: null, expectedValueSourcePath: null, expectedValueSourceLine: 0, expectedIsXmlLiteral: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25001, 1366, 1589);

                int
                f_25001_1451_1577(System.Xml.Linq.XElement
                expectedRoot, System.Xml.Linq.XElement
                actualRoot, string
                message, string
                expectedValueSourcePath, int
                expectedValueSourceLine, bool
                expectedIsXmlLiteral)
                {
                    Equal(expectedRoot, actualRoot, message: message, expectedValueSourcePath: expectedValueSourcePath, expectedValueSourceLine: expectedValueSourceLine, expectedIsXmlLiteral: expectedIsXmlLiteral);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 1451, 1577);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25001, 1366, 1589);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25001, 1366, 1589);
            }
        }

        public static void Equal(
                    XElement expectedRoot,
                    XElement actualRoot,
                    string message,
                    string expectedValueSourcePath,
                    int expectedValueSourceLine,
                    bool expectedIsXmlLiteral)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25001, 1709, 2588);
                System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement> firstMismatch = default(System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 1985, 2577) || true) && (!f_25001_1990_2082(expectedRoot, actualRoot, ShallowElementComparer.Instance, out firstMismatch))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25001, 1985, 2577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 2116, 2562);

                    f_25001_2116_2561(false, message +
                    f_25001_2172_2560(f_25001_2212_2260(expectedRoot, expectedIsXmlLiteral), f_25001_2287_2333(actualRoot, expectedIsXmlLiteral), expectedRoot, firstMismatch, expectedValueSourcePath, expectedValueSourceLine, expectedIsXmlLiteral));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25001, 1985, 2577);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25001, 1709, 2588);

                bool
                f_25001_1990_2082(System.Xml.Linq.XElement
                expectedRoot, System.Xml.Linq.XElement
                actualRoot, System.Collections.Generic.IEqualityComparer<System.Xml.Linq.XElement>
                shallowComparer, out System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>
                firstMismatch)
                {
                    var return_v = CheckEqual(expectedRoot, actualRoot, shallowComparer, out firstMismatch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 1990, 2082);
                    return return_v;
                }


                string
                f_25001_2212_2260(System.Xml.Linq.XElement
                node, bool
                expectedIsXmlLiteral)
                {
                    var return_v = GetXmlString(node, expectedIsXmlLiteral);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 2212, 2260);
                    return return_v;
                }


                string
                f_25001_2287_2333(System.Xml.Linq.XElement
                node, bool
                expectedIsXmlLiteral)
                {
                    var return_v = GetXmlString(node, expectedIsXmlLiteral);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 2287, 2333);
                    return return_v;
                }


                string
                f_25001_2172_2560(string
                expected, string
                actual, System.Xml.Linq.XElement
                expectedRoot, System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>
                firstMismatch, string
                expectedValueSourcePath, int
                expectedValueSourceLine, bool
                expectedIsXmlLiteral)
                {
                    var return_v = GetAssertText(expected, actual, expectedRoot, firstMismatch, expectedValueSourcePath, expectedValueSourceLine, expectedIsXmlLiteral);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 2172, 2560);
                    return return_v;
                }


                bool
                f_25001_2116_2561(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 2116, 2561);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25001, 1709, 2588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25001, 1709, 2588);
            }
        }

        private static string GetXmlString(XElement node, bool expectedIsXmlLiteral)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25001, 2600, 3227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 2701, 3216);
                using (var
                sw = f_25001_2717_2763(f_25001_2734_2762())
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 2797, 3024);

                    var
                    ws = new XmlWriterSettings()
                    {
                        IndentChars = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => (DynAbs.Tracing.TraceSender.Conditional_F1(25001, 2884, 2904) || ((expectedIsXmlLiteral && DynAbs.Tracing.TraceSender.Conditional_F2(25001, 2907, 2913)) || DynAbs.Tracing.TraceSender.Conditional_F3(25001, 2916, 2920))) ? "    " : "  ", 25001, 2806, 3023),
                        OmitXmlDeclaration = true,
                        Indent = true
                    }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 3044, 3160);
                    using (var
                    w = f_25001_3059_3083(sw, ws)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 3125, 3141);

                        f_25001_3125_3140(node, w);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(25001, 3044, 3160);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 3180, 3201);

                    return f_25001_3187_3200(sw);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(25001, 2701, 3216);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25001, 2600, 3227);

                System.Globalization.CultureInfo
                f_25001_2734_2762()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25001, 2734, 2762);
                    return return_v;
                }


                System.IO.StringWriter
                f_25001_2717_2763(System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = new System.IO.StringWriter((System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 2717, 2763);
                    return return_v;
                }


                System.Xml.XmlWriter
                f_25001_3059_3083(System.IO.StringWriter
                output, System.Xml.XmlWriterSettings
                settings)
                {
                    var return_v = XmlWriter.Create((System.IO.TextWriter)output, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 3059, 3083);
                    return return_v;
                }


                int
                f_25001_3125_3140(System.Xml.Linq.XElement
                this_param, System.Xml.XmlWriter
                writer)
                {
                    this_param.WriteTo(writer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 3125, 3140);
                    return 0;
                }


                string
                f_25001_3187_3200(System.IO.StringWriter
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 3187, 3200);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25001, 2600, 3227);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25001, 2600, 3227);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetAssertText(
                    string expected,
                    string actual,
                    XElement expectedRoot,
                    Tuple<XElement, XElement> firstMismatch,
                    string expectedValueSourcePath,
                    int expectedValueSourceLine,
                    bool expectedIsXmlLiteral)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25001, 3400, 5554);
                string link = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 3736, 3783);

                StringBuilder
                assertText = f_25001_3763_3782()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 3799, 3938);

                string
                actualString = (DynAbs.Tracing.TraceSender.Conditional_F1(25001, 3821, 3841) || ((expectedIsXmlLiteral && DynAbs.Tracing.TraceSender.Conditional_F2(25001, 3844, 3879)) || DynAbs.Tracing.TraceSender.Conditional_F3(25001, 3882, 3937))) ? f_25001_3844_3879(actual, " />\r\n", "/>\r\n") : f_25001_3882_3937("@\"{0}\"", f_25001_3908_3936(actual, "\"", "\"\""))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 3952, 4097);

                string
                expectedString = (DynAbs.Tracing.TraceSender.Conditional_F1(25001, 3976, 3996) || ((expectedIsXmlLiteral && DynAbs.Tracing.TraceSender.Conditional_F2(25001, 3999, 4036)) || DynAbs.Tracing.TraceSender.Conditional_F3(25001, 4039, 4096))) ? f_25001_3999_4036(expected, " />\r\n", "/>\r\n") : f_25001_4039_4096("@\"{0}\"", f_25001_4065_4095(expected, "\"", "\"\""))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 4113, 5498) || true) && (f_25001_4117_4289(actualString, f_25001_4184_4220(expectedString, c => c == '\n') + 1, expectedValueSourcePath, expectedValueSourceLine, out link))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25001, 4113, 5498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 4323, 4351);

                    f_25001_4323_4350(assertText, link);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25001, 4113, 5498);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25001, 4113, 5498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 4417, 4451);

                    f_25001_4417_4450(assertText, "Expected");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 4469, 4499);

                    f_25001_4469_4498(assertText, "====");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 4517, 4555);

                    f_25001_4517_4554(assertText, expectedString);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 4573, 4597);

                    f_25001_4573_4596(assertText);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 4617, 5287) || true) && (f_25001_4621_4640(firstMismatch) != expectedRoot)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25001, 4617, 5287);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 4698, 4740);

                        f_25001_4698_4739(assertText, "First Difference");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 4762, 4792);

                        f_25001_4762_4791(assertText, "====");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 4814, 4857);

                        f_25001_4814_4856(assertText, "Expected Fragment");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 4879, 4909);

                        f_25001_4879_4908(assertText, "----");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 4931, 4985);

                        f_25001_4931_4984(assertText, f_25001_4953_4983(f_25001_4953_4972(firstMismatch)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 5007, 5031);

                        f_25001_5007_5030(assertText);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 5053, 5094);

                        f_25001_5053_5093(assertText, "Actual Fragment");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 5116, 5146);

                        f_25001_5116_5145(assertText, "----");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 5168, 5222);

                        f_25001_5168_5221(assertText, f_25001_5190_5220(f_25001_5190_5209(firstMismatch)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 5244, 5268);

                        f_25001_5244_5267(assertText);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25001, 4617, 5287);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 5307, 5339);

                    f_25001_5307_5338(
                                    assertText, "Actual");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 5357, 5387);

                    f_25001_5357_5386(assertText, "====");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 5405, 5441);

                    f_25001_5405_5440(assertText, actualString);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 5459, 5483);

                    f_25001_5459_5482(assertText);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25001, 4113, 5498);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 5514, 5543);

                return f_25001_5521_5542(assertText);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25001, 3400, 5554);

                System.Text.StringBuilder
                f_25001_3763_3782()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 3763, 3782);
                    return return_v;
                }


                string
                f_25001_3844_3879(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 3844, 3879);
                    return return_v;
                }


                string
                f_25001_3908_3936(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 3908, 3936);
                    return return_v;
                }


                string
                f_25001_3882_3937(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 3882, 3937);
                    return return_v;
                }


                string
                f_25001_3999_4036(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 3999, 4036);
                    return return_v;
                }


                string
                f_25001_4065_4095(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 4065, 4095);
                    return return_v;
                }


                string
                f_25001_4039_4096(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 4039, 4096);
                    return return_v;
                }


                int
                f_25001_4184_4220(string
                source, System.Func<char, bool>
                predicate)
                {
                    var return_v = source.Count<char>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 4184, 4220);
                    return return_v;
                }


                bool
                f_25001_4117_4289(string
                actualString, int
                expectedLineCount, string
                expectedValueSourcePath, int
                expectedValueSourceLine, out string
                link)
                {
                    var return_v = AssertEx.TryGenerateExpectedSourceFileAndGetDiffLink(actualString, expectedLineCount, expectedValueSourcePath, expectedValueSourceLine, out link);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 4117, 4289);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25001_4323_4350(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 4323, 4350);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25001_4417_4450(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 4417, 4450);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25001_4469_4498(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 4469, 4498);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25001_4517_4554(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 4517, 4554);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25001_4573_4596(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 4573, 4596);
                    return return_v;
                }


                System.Xml.Linq.XElement
                f_25001_4621_4640(System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25001, 4621, 4640);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25001_4698_4739(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 4698, 4739);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25001_4762_4791(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 4762, 4791);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25001_4814_4856(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 4814, 4856);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25001_4879_4908(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 4879, 4908);
                    return return_v;
                }


                System.Xml.Linq.XElement
                f_25001_4953_4972(System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25001, 4953, 4972);
                    return return_v;
                }


                string
                f_25001_4953_4983(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 4953, 4983);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25001_4931_4984(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 4931, 4984);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25001_5007_5030(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 5007, 5030);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25001_5053_5093(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 5053, 5093);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25001_5116_5145(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 5116, 5145);
                    return return_v;
                }


                System.Xml.Linq.XElement
                f_25001_5190_5209(System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25001, 5190, 5209);
                    return return_v;
                }


                string
                f_25001_5190_5220(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 5190, 5220);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25001_5168_5221(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 5168, 5221);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25001_5244_5267(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 5244, 5267);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25001_5307_5338(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 5307, 5338);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25001_5357_5386(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 5357, 5386);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25001_5405_5440(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 5405, 5440);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25001_5459_5482(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 5459, 5482);
                    return return_v;
                }


                string
                f_25001_5521_5542(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 5521, 5542);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25001, 3400, 5554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25001, 3400, 5554);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CheckEqual(XElement expectedRoot, XElement actualRoot, IEqualityComparer<XElement> shallowComparer, out Tuple<XElement, XElement> firstMismatch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25001, 5896, 8664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 6085, 6120);

                f_25001_6085_6119(expectedRoot);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 6134, 6167);

                f_25001_6134_6166(actualRoot);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 6181, 6219);

                f_25001_6181_6218(shallowComparer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 6235, 6328);

                Tuple<XElement, XElement>
                rootPair = f_25001_6272_6327(expectedRoot, actualRoot)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 6344, 6502) || true) && (!f_25001_6349_6397(shallowComparer, expectedRoot, actualRoot))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25001, 6344, 6502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 6431, 6456);

                    firstMismatch = rootPair;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 6474, 6487);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25001, 6344, 6502);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 6518, 6598);

                Stack<Tuple<XElement, XElement>>
                stack = f_25001_6559_6597()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 6612, 6633);

                f_25001_6612_6632(stack, rootPair);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 6649, 8590) || true) && (f_25001_6656_6667(stack) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25001, 6649, 8590);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 6705, 6750);

                        Tuple<XElement, XElement>
                        pair = f_25001_6738_6749(stack)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 6768, 6789);

                        firstMismatch = pair;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 6855, 6916);

                        f_25001_6855_6915(f_25001_6868_6914(shallowComparer, f_25001_6891_6901(pair), f_25001_6903_6913(pair)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 6977, 7032);

                        XElement[]
                        children1 = f_25001_7000_7031(f_25001_7000_7021(f_25001_7000_7010(pair)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 7050, 7159);

                        MultiDictionary<XElement, XElement>
                        children2Dict = f_25001_7102_7158(shallowComparer)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 7179, 7202);

                        int
                        children2Count = 0
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 7220, 7400);
                            foreach (XElement child in f_25001_7247_7268_I(f_25001_7247_7268(f_25001_7247_7257(pair))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25001, 7220, 7400);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 7310, 7342);

                                f_25001_7310_7341(children2Dict, child, child);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 7364, 7381);

                                children2Count++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25001, 7220, 7400);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25001, 1, 181);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25001, 1, 181);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 7420, 7532) || true) && (f_25001_7424_7440(children1) != children2Count)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25001, 7420, 7532);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 7500, 7513);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25001, 7420, 7532);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 7552, 7644);

                        HashSet<XElement>
                        children2Used = f_25001_7586_7643(ReferenceEqualityComparer.Instance)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 7662, 8439);
                            foreach (XElement child1 in f_25001_7690_7699_I(children1))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25001, 7662, 8439);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 7741, 7764);

                                XElement
                                child2 = null
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 7786, 8084);
                                    foreach (var candidate in f_25001_7812_7833_I(f_25001_7812_7833(children2Dict, child1)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25001, 7786, 8084);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 7883, 8061) || true) && (!f_25001_7888_7921(children2Used, candidate))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25001, 7883, 8061);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 7979, 7998);

                                            child2 = candidate;
                                            DynAbs.Tracing.TraceSender.TraceBreak(25001, 8028, 8034);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(25001, 7883, 8061);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(25001, 7786, 8084);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25001, 1, 299);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(25001, 1, 299);
                                }
                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 8108, 8420) || true) && (child2 == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25001, 8108, 8420);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 8176, 8189);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25001, 8108, 8420);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25001, 8108, 8420);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 8287, 8313);

                                    f_25001_8287_8312(children2Used, child2);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 8339, 8397);

                                    f_25001_8339_8396(stack, f_25001_8350_8395(child1, child2));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25001, 8108, 8420);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25001, 7662, 8439);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25001, 1, 778);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25001, 1, 778);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 8459, 8575) || true) && (f_25001_8463_8482(children2Used) < f_25001_8485_8501(children1))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25001, 8459, 8575);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 8543, 8556);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25001, 8459, 8575);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25001, 6649, 8590);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25001, 6649, 8590);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25001, 6649, 8590);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 8606, 8627);

                firstMismatch = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 8641, 8653);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25001, 5896, 8664);

                bool
                f_25001_6085_6119(System.Xml.Linq.XElement
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 6085, 6119);
                    return return_v;
                }


                bool
                f_25001_6134_6166(System.Xml.Linq.XElement
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 6134, 6166);
                    return return_v;
                }


                bool
                f_25001_6181_6218(System.Collections.Generic.IEqualityComparer<System.Xml.Linq.XElement>
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 6181, 6218);
                    return return_v;
                }


                System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>
                f_25001_6272_6327(System.Xml.Linq.XElement
                item1, System.Xml.Linq.XElement
                item2)
                {
                    var return_v = new System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 6272, 6327);
                    return return_v;
                }


                bool
                f_25001_6349_6397(System.Collections.Generic.IEqualityComparer<System.Xml.Linq.XElement>
                this_param, System.Xml.Linq.XElement
                x, System.Xml.Linq.XElement
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 6349, 6397);
                    return return_v;
                }


                System.Collections.Generic.Stack<System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>>
                f_25001_6559_6597()
                {
                    var return_v = new System.Collections.Generic.Stack<System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 6559, 6597);
                    return return_v;
                }


                int
                f_25001_6612_6632(System.Collections.Generic.Stack<System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>>
                this_param, System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 6612, 6632);
                    return 0;
                }


                int
                f_25001_6656_6667(System.Collections.Generic.Stack<System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25001, 6656, 6667);
                    return return_v;
                }


                System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>
                f_25001_6738_6749(System.Collections.Generic.Stack<System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 6738, 6749);
                    return return_v;
                }


                System.Xml.Linq.XElement
                f_25001_6891_6901(System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25001, 6891, 6901);
                    return return_v;
                }


                System.Xml.Linq.XElement
                f_25001_6903_6913(System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25001, 6903, 6913);
                    return return_v;
                }


                bool
                f_25001_6868_6914(System.Collections.Generic.IEqualityComparer<System.Xml.Linq.XElement>
                this_param, System.Xml.Linq.XElement
                x, System.Xml.Linq.XElement
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 6868, 6914);
                    return return_v;
                }


                int
                f_25001_6855_6915(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 6855, 6915);
                    return 0;
                }


                System.Xml.Linq.XElement
                f_25001_7000_7010(System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25001, 7000, 7010);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                f_25001_7000_7021(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.Elements();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 7000, 7021);
                    return return_v;
                }


                System.Xml.Linq.XElement[]
                f_25001_7000_7031(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                source)
                {
                    var return_v = source.ToArray<System.Xml.Linq.XElement>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 7000, 7031);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<System.Xml.Linq.XElement, System.Xml.Linq.XElement>
                f_25001_7102_7158(System.Collections.Generic.IEqualityComparer<System.Xml.Linq.XElement>
                comparer)
                {
                    var return_v = new Roslyn.Utilities.MultiDictionary<System.Xml.Linq.XElement, System.Xml.Linq.XElement>(comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 7102, 7158);
                    return return_v;
                }


                System.Xml.Linq.XElement
                f_25001_7247_7257(System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25001, 7247, 7257);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                f_25001_7247_7268(System.Xml.Linq.XElement
                this_param)
                {
                    var return_v = this_param.Elements();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 7247, 7268);
                    return return_v;
                }


                bool
                f_25001_7310_7341(Roslyn.Utilities.MultiDictionary<System.Xml.Linq.XElement, System.Xml.Linq.XElement>
                this_param, System.Xml.Linq.XElement
                k, System.Xml.Linq.XElement
                v)
                {
                    var return_v = this_param.Add(k, v);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 7310, 7341);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                f_25001_7247_7268_I(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 7247, 7268);
                    return return_v;
                }


                int
                f_25001_7424_7440(System.Xml.Linq.XElement[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25001, 7424, 7440);
                    return return_v;
                }


                System.Collections.Generic.HashSet<System.Xml.Linq.XElement>
                f_25001_7586_7643(Roslyn.Utilities.ReferenceEqualityComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<System.Xml.Linq.XElement>((System.Collections.Generic.IEqualityComparer<System.Xml.Linq.XElement>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 7586, 7643);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<System.Xml.Linq.XElement, System.Xml.Linq.XElement>.ValueSet
                f_25001_7812_7833(Roslyn.Utilities.MultiDictionary<System.Xml.Linq.XElement, System.Xml.Linq.XElement>
                this_param, System.Xml.Linq.XElement
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25001, 7812, 7833);
                    return return_v;
                }


                bool
                f_25001_7888_7921(System.Collections.Generic.HashSet<System.Xml.Linq.XElement>
                this_param, System.Xml.Linq.XElement
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 7888, 7921);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<System.Xml.Linq.XElement, System.Xml.Linq.XElement>.ValueSet
                f_25001_7812_7833_I(Roslyn.Utilities.MultiDictionary<System.Xml.Linq.XElement, System.Xml.Linq.XElement>.ValueSet
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 7812, 7833);
                    return return_v;
                }


                bool
                f_25001_8287_8312(System.Collections.Generic.HashSet<System.Xml.Linq.XElement>
                this_param, System.Xml.Linq.XElement
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 8287, 8312);
                    return return_v;
                }


                System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>
                f_25001_8350_8395(System.Xml.Linq.XElement
                item1, System.Xml.Linq.XElement
                item2)
                {
                    var return_v = new System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 8350, 8395);
                    return return_v;
                }


                int
                f_25001_8339_8396(System.Collections.Generic.Stack<System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>>
                this_param, System.Tuple<System.Xml.Linq.XElement, System.Xml.Linq.XElement>
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 8339, 8396);
                    return 0;
                }


                System.Xml.Linq.XElement[]
                f_25001_7690_7699_I(System.Xml.Linq.XElement[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 7690, 7699);
                    return return_v;
                }


                int
                f_25001_8463_8482(System.Collections.Generic.HashSet<System.Xml.Linq.XElement>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25001, 8463, 8482);
                    return return_v;
                }


                int
                f_25001_8485_8501(System.Xml.Linq.XElement[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25001, 8485, 8501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25001, 5896, 8664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25001, 5896, 8664);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private class ShallowElementComparer : IEqualityComparer<XElement>
        {
            public static readonly IEqualityComparer<XElement> Instance;

            private ShallowElementComparer()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25001, 8874, 8910);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25001, 8874, 8910);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25001, 8874, 8910);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25001, 8874, 8910);
                }
            }

            public bool Equals(XElement element1, XElement element2)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25001, 8926, 9332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 9015, 9046);

                    f_25001_9015_9045(element1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 9064, 9095);

                    f_25001_9064_9094(element2);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 9115, 9317);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(25001, 9122, 9156) || ((f_25001_9122_9135(element1) == "customDebugInfo"
                    && DynAbs.Tracing.TraceSender.Conditional_F2(25001, 9180, 9222)) || DynAbs.Tracing.TraceSender.Conditional_F3(25001, 9246, 9316))) ? f_25001_9180_9199(element1) == f_25001_9203_9222(element2) : f_25001_9246_9316(AssertXml.NameAndAttributeComparer.Instance, element1, element2);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25001, 8926, 9332);

                    bool
                    f_25001_9015_9045(System.Xml.Linq.XElement
                    @object)
                    {
                        var return_v = CustomAssert.NotNull((object)@object);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 9015, 9045);
                        return return_v;
                    }


                    bool
                    f_25001_9064_9094(System.Xml.Linq.XElement
                    @object)
                    {
                        var return_v = CustomAssert.NotNull((object)@object);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 9064, 9094);
                        return return_v;
                    }


                    System.Xml.Linq.XName
                    f_25001_9122_9135(System.Xml.Linq.XElement
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25001, 9122, 9135);
                        return return_v;
                    }


                    string
                    f_25001_9180_9199(System.Xml.Linq.XElement
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 9180, 9199);
                        return return_v;
                    }


                    string
                    f_25001_9203_9222(System.Xml.Linq.XElement
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 9203, 9222);
                        return return_v;
                    }


                    bool
                    f_25001_9246_9316(System.Collections.Generic.IEqualityComparer<System.Xml.Linq.XElement>
                    this_param, System.Xml.Linq.XElement
                    x, System.Xml.Linq.XElement
                    y)
                    {
                        var return_v = this_param.Equals(x, y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 9246, 9316);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25001, 8926, 9332);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25001, 8926, 9332);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public int GetHashCode(XElement element)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25001, 9348, 9470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 9421, 9455);

                    return f_25001_9428_9454(f_25001_9428_9440(element));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25001, 9348, 9470);

                    System.Xml.Linq.XName
                    f_25001_9428_9440(System.Xml.Linq.XElement
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25001, 9428, 9440);
                        return return_v;
                    }


                    int
                    f_25001_9428_9454(System.Xml.Linq.XName
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 9428, 9454);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25001, 9348, 9470);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25001, 9348, 9470);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ShallowElementComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25001, 8676, 9481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 8818, 8857);
                Instance = f_25001_8829_8857(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25001, 8676, 9481);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25001, 8676, 9481);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25001, 8676, 9481);

            static Roslyn.Test.Utilities.AssertXml.ShallowElementComparer
            f_25001_8829_8857()
            {
                var return_v = new Roslyn.Test.Utilities.AssertXml.ShallowElementComparer();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 8829, 8857);
                return return_v;
            }

        }
        private class NameAndAttributeComparer : IEqualityComparer<XElement>
        {
            public static readonly IEqualityComparer<XElement> Instance;

            private NameAndAttributeComparer()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25001, 9856, 9894);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25001, 9856, 9894);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25001, 9856, 9894);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25001, 9856, 9894);
                }
            }

            public bool Equals(XElement element1, XElement element2)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25001, 9910, 10516);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 9999, 10030);

                    f_25001_9999_10029(element1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 10048, 10079);

                    f_25001_10048_10078(element2);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 10099, 10207) || true) && (f_25001_10103_10116(element1) != f_25001_10120_10133(element2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25001, 10099, 10207);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 10175, 10188);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25001, 10099, 10207);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 10227, 10324);

                    IEnumerable<Tuple<XName, string>>
                    attributes1 = f_25001_10275_10323(f_25001_10275_10296(element1), MakeAttributeTuple)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 10342, 10439);

                    IEnumerable<Tuple<XName, string>>
                    attributes2 = f_25001_10390_10438(f_25001_10390_10411(element2), MakeAttributeTuple)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 10459, 10501);

                    return f_25001_10466_10500(attributes1, attributes2);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25001, 9910, 10516);

                    bool
                    f_25001_9999_10029(System.Xml.Linq.XElement
                    @object)
                    {
                        var return_v = CustomAssert.NotNull((object)@object);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 9999, 10029);
                        return return_v;
                    }


                    bool
                    f_25001_10048_10078(System.Xml.Linq.XElement
                    @object)
                    {
                        var return_v = CustomAssert.NotNull((object)@object);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 10048, 10078);
                        return return_v;
                    }


                    System.Xml.Linq.XName
                    f_25001_10103_10116(System.Xml.Linq.XElement
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25001, 10103, 10116);
                        return return_v;
                    }


                    System.Xml.Linq.XName
                    f_25001_10120_10133(System.Xml.Linq.XElement
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25001, 10120, 10133);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>
                    f_25001_10275_10296(System.Xml.Linq.XElement
                    this_param)
                    {
                        var return_v = this_param.Attributes();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 10275, 10296);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<System.Tuple<System.Xml.Linq.XName, string>>
                    f_25001_10275_10323(System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>
                    source, System.Func<System.Xml.Linq.XAttribute, System.Tuple<System.Xml.Linq.XName, string>>
                    selector)
                    {
                        var return_v = source.Select<System.Xml.Linq.XAttribute, System.Tuple<System.Xml.Linq.XName, string>>(selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 10275, 10323);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>
                    f_25001_10390_10411(System.Xml.Linq.XElement
                    this_param)
                    {
                        var return_v = this_param.Attributes();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 10390, 10411);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<System.Tuple<System.Xml.Linq.XName, string>>
                    f_25001_10390_10438(System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>
                    source, System.Func<System.Xml.Linq.XAttribute, System.Tuple<System.Xml.Linq.XName, string>>
                    selector)
                    {
                        var return_v = source.Select<System.Xml.Linq.XAttribute, System.Tuple<System.Xml.Linq.XName, string>>(selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 10390, 10438);
                        return return_v;
                    }


                    bool
                    f_25001_10466_10500(System.Collections.Generic.IEnumerable<System.Tuple<System.Xml.Linq.XName, string>>
                    source1, System.Collections.Generic.IEnumerable<System.Tuple<System.Xml.Linq.XName, string>>
                    source2)
                    {
                        var return_v = source1.SetEquals<System.Tuple<System.Xml.Linq.XName, string>>(source2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 10466, 10500);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25001, 9910, 10516);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25001, 9910, 10516);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public int GetHashCode(XElement element)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25001, 10532, 10654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 10605, 10639);

                    return f_25001_10612_10638(f_25001_10612_10624(element));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25001, 10532, 10654);

                    System.Xml.Linq.XName
                    f_25001_10612_10624(System.Xml.Linq.XElement
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25001, 10612, 10624);
                        return return_v;
                    }


                    int
                    f_25001_10612_10638(System.Xml.Linq.XName
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 10612, 10638);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25001, 10532, 10654);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25001, 10532, 10654);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static Tuple<XName, string> MakeAttributeTuple(XAttribute attribute)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25001, 10670, 10859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 10779, 10844);

                    return f_25001_10786_10843(f_25001_10811_10825(attribute), f_25001_10827_10842(attribute));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25001, 10670, 10859);

                    System.Xml.Linq.XName
                    f_25001_10811_10825(System.Xml.Linq.XAttribute
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25001, 10811, 10825);
                        return return_v;
                    }


                    string
                    f_25001_10827_10842(System.Xml.Linq.XAttribute
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25001, 10827, 10842);
                        return return_v;
                    }


                    System.Tuple<System.Xml.Linq.XName, string>
                    f_25001_10786_10843(System.Xml.Linq.XName
                    item1, string
                    item2)
                    {
                        var return_v = new System.Tuple<System.Xml.Linq.XName, string>(item1, item2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 10786, 10843);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25001, 10670, 10859);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25001, 10670, 10859);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static NameAndAttributeComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25001, 9654, 10870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25001, 9798, 9839);
                Instance = f_25001_9809_9839(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25001, 9654, 10870);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25001, 9654, 10870);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25001, 9654, 10870);

            static Roslyn.Test.Utilities.AssertXml.NameAndAttributeComparer
            f_25001_9809_9839()
            {
                var return_v = new Roslyn.Test.Utilities.AssertXml.NameAndAttributeComparer();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25001, 9809, 9839);
                return return_v;
            }

        }

        static AssertXml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25001, 1058, 10877);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25001, 1058, 10877);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25001, 1058, 10877);
        }

    }
}
