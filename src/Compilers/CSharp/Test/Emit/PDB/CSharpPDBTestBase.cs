// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.IO;
using System.Linq;
using System.Xml;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests.PDB
{
    public class CSharpPDBTestBase : CSharpTestBase
    {
        public static void TestSequencePoints(string markup, CSharpCompilationOptions compilationOptions, CSharpParseOptions parseOptions = null, string methodName = "")
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23123, 593, 1469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 779, 793);

                int?
                position
                = default(int?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 807, 830);

                TextSpan?
                expectedSpan
                = default(TextSpan?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 844, 858);

                string
                source
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 872, 958);

                f_23123_872_957(markup, out source, out position, out expectedSpan);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 974, 1102);

                var
                compilation = f_23123_992_1101(source, options: compilationOptions, parseOptions: parseOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 1116, 1205);

                f_23123_1116_1204(f_23123_1116_1144(compilation).Where(d => d.Severity == DiagnosticSeverity.Error));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 1221, 1301);

                var
                pdb = f_23123_1231_1300(compilation, qualifiedMethodName: methodName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 1315, 1415);

                bool
                hasBreakpoint = f_23123_1336_1414(expectedSpan.GetValueOrDefault(), source, pdb)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 1431, 1458);

                f_23123_1431_1457(hasBreakpoint);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23123, 593, 1469);

                int
                f_23123_872_957(string
                input, out string
                output, out int?
                cursorPosition, out Microsoft.CodeAnalysis.Text.TextSpan?
                textSpan)
                {
                    MarkupTestFile.GetPositionAndSpan(input, out output, out cursorPosition, out textSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 872, 957);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23123_992_1101(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                parseOptions)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, parseOptions: parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 992, 1101);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_23123_1116_1144(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 1116, 1144);
                    return return_v;
                }


                int
                f_23123_1116_1204(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                actual, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    actual.Verify(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 1116, 1204);
                    return 0;
                }


                string
                f_23123_1231_1300(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName)
                {
                    var return_v = PdbValidation.GetPdbXml((Microsoft.CodeAnalysis.Compilation)compilation, qualifiedMethodName: qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 1231, 1300);
                    return return_v;
                }


                bool
                f_23123_1336_1414(Microsoft.CodeAnalysis.Text.TextSpan
                span, string
                source, string
                pdb)
                {
                    var return_v = CheckIfSpanWithinSequencePoints(span, source, pdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 1336, 1414);
                    return return_v;
                }


                int
                f_23123_1431_1457(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 1431, 1457);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23123, 593, 1469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23123, 593, 1469);
            }
        }

        public static bool CheckIfSpanWithinSequencePoints(TextSpan span, string source, string pdb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23123, 1481, 2974);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 1649, 1684);

                var
                text = f_23123_1660_1683(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 1698, 1757);

                var
                startLine = f_23123_1714_1756(f_23123_1714_1724(text), span.Start)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 1771, 1811);

                var
                startRow = startLine.LineNumber + 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 1825, 1876);

                var
                startColumn = span.Start - startLine.Start + 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 1892, 1947);

                var
                endLine = f_23123_1906_1946(f_23123_1906_1916(text), span.End)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 1961, 1997);

                var
                endRow = endLine.LineNumber + 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 2011, 2056);

                var
                endColumn = span.End - endLine.Start + 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 2072, 2123);

                var
                doc = new XmlDocument() { XmlResolver = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => (XmlResolver)null, 23123, 2082, 2122) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 2137, 2306);
                using (var
                reader = new XmlTextReader(f_23123_2175_2196(pdb)) { DtdProcessing = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => DtdProcessing.Prohibit, 23123, 2157, 2240) }
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 2274, 2291);

                    f_23123_2274_2290(doc, reader);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(23123, 2137, 2306);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 2322, 2934);
                    foreach (XmlNode entry in f_23123_2348_2390_I(f_23123_2348_2390(doc, "sequencePoints")))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(23123, 2322, 2934);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 2424, 2919);
                            foreach (XmlElement item in f_23123_2452_2468_I(f_23123_2452_2468(entry)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(23123, 2424, 2919);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 2510, 2900) || true) && (f_23123_2514_2533(startRow) == f_23123_2537_2567(item, "startLine") && (DynAbs.Tracing.TraceSender.Expression_True(23123, 2514, 2654) && f_23123_2596_2618(startColumn) == f_23123_2622_2654(item, "startColumn")) && (DynAbs.Tracing.TraceSender.Expression_True(23123, 2514, 2732) && f_23123_2683_2700(endRow) == f_23123_2704_2732(item, "endLine")) && (DynAbs.Tracing.TraceSender.Expression_True(23123, 2514, 2815) && f_23123_2761_2781(endColumn) == f_23123_2785_2815(item, "endColumn")))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23123, 2510, 2900);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 2865, 2877);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(23123, 2510, 2900);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(23123, 2424, 2919);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(23123, 1, 496);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(23123, 1, 496);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(23123, 2322, 2934);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(23123, 1, 613);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(23123, 1, 613);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23123, 2950, 2963);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23123, 1481, 2974);

                Microsoft.CodeAnalysis.Text.SourceText
                f_23123_1660_1683(string
                text)
                {
                    var return_v = SourceText.From(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 1660, 1683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextLineCollection
                f_23123_1714_1724(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Lines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23123, 1714, 1724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextLine
                f_23123_1714_1756(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param, int
                position)
                {
                    var return_v = this_param.GetLineFromPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 1714, 1756);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextLineCollection
                f_23123_1906_1916(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Lines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23123, 1906, 1916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextLine
                f_23123_1906_1946(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param, int
                position)
                {
                    var return_v = this_param.GetLineFromPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 1906, 1946);
                    return return_v;
                }


                System.IO.StringReader
                f_23123_2175_2196(string
                s)
                {
                    var return_v = new System.IO.StringReader(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 2175, 2196);
                    return return_v;
                }


                int
                f_23123_2274_2290(System.Xml.XmlDocument
                this_param, System.Xml.XmlTextReader
                reader)
                {
                    this_param.Load((System.Xml.XmlReader)reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 2274, 2290);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_23123_2348_2390(System.Xml.XmlDocument
                this_param, string
                name)
                {
                    var return_v = this_param.GetElementsByTagName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 2348, 2390);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_23123_2452_2468(System.Xml.XmlNode?
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23123, 2452, 2468);
                    return return_v;
                }


                string
                f_23123_2514_2533(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 2514, 2533);
                    return return_v;
                }


                string
                f_23123_2537_2567(System.Xml.XmlElement?
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 2537, 2567);
                    return return_v;
                }


                string
                f_23123_2596_2618(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 2596, 2618);
                    return return_v;
                }


                string
                f_23123_2622_2654(System.Xml.XmlElement
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 2622, 2654);
                    return return_v;
                }


                string
                f_23123_2683_2700(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 2683, 2700);
                    return return_v;
                }


                string
                f_23123_2704_2732(System.Xml.XmlElement
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 2704, 2732);
                    return return_v;
                }


                string
                f_23123_2761_2781(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 2761, 2781);
                    return return_v;
                }


                string
                f_23123_2785_2815(System.Xml.XmlElement
                this_param, string
                name)
                {
                    var return_v = this_param.GetAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 2785, 2815);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_23123_2452_2468_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 2452, 2468);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_23123_2348_2390_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23123, 2348, 2390);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23123, 1481, 2974);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23123, 1481, 2974);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CSharpPDBTestBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(23123, 529, 2981);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(23123, 529, 2981);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23123, 529, 2981);
        }


        static CSharpPDBTestBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23123, 529, 2981);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23123, 529, 2981);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23123, 529, 2981);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23123, 529, 2981);
    }
}
