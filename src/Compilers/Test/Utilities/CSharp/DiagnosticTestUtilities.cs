// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{

    public struct ErrorDescription
    {

        public bool IsWarning;

        public int Code, Line, Column;

        public string[] Parameters;

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21007, 839, 1029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 897, 1018);

                return f_21007_904_1017("Line={0}, Column={1}, Code={2}, IsWarning={3}", this.Line, this.Column, this.Code, this.IsWarning);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21007, 839, 1029);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21007, 839, 1029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21007, 839, 1029);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static ErrorDescription()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21007, 681, 1036);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21007, 681, 1036);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21007, 681, 1036);
        }

        string
        f_21007_904_1017(string
        format, params object?[]
        args)
        {
            var return_v = string.Format(format, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 904, 1017);
            return return_v;
        }

    }
    public abstract class DiagnosticsUtils
    {
        public static void VerifyErrorCodes(CSharpCompilation comp, params ErrorDescription[] expectedErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21007, 1244, 1500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 1370, 1411);

                var
                actualErrors = f_21007_1389_1410(comp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 1425, 1489);

                f_21007_1425_1488(actualErrors, expectedErrors);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21007, 1244, 1500);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21007, 1244, 1500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21007, 1244, 1500);
            }
        }

        [Obsolete("Use VerifyDiagnostics", true)]
        public static void TestDiagnostics(string source, params string[] diagStrings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21007, 1657, 2002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 1811, 1863);

                var
                comp = f_21007_1822_1862(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 1877, 1917);

                var
                diagnostics = f_21007_1895_1916(comp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 1931, 1991);

                f_21007_1931_1990(diagnostics, diagStrings);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21007, 1657, 2002);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21007, 1657, 2002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21007, 1657, 2002);
            }
        }

        [Obsolete("Use VerifyDiagnostics", true)]
        public static void TestDiagnosticsExact(string source, params string[] diagStrings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21007, 2159, 2576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 2318, 2370);

                var
                comp = f_21007_2329_2369(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 2384, 2424);

                var
                diagnostics = f_21007_2402_2423(comp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 2438, 2491);

                f_21007_2438_2490(f_21007_2451_2469(diagStrings), diagnostics.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 2505, 2565);

                f_21007_2505_2564(diagnostics, diagStrings);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21007, 2159, 2576);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21007, 2159, 2576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21007, 2159, 2576);
            }
        }

        public static CSharpCompilation VerifyErrorsAndGetCompilationWithMscorlib(string text, params ErrorDescription[] expectedErrorDesp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21007, 2733, 2991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 2889, 2980);

                return f_21007_2896_2979(new string[] { text }, expectedErrorDesp);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21007, 2733, 2991);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21007, 2733, 2991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21007, 2733, 2991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal static CSharpCompilation VerifyErrorsAndGetCompilationWithMscorlib(string[] srcs, params ErrorDescription[] expectedErrorDesp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21007, 3148, 3566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 3318, 3410);

                var
                comp = f_21007_3329_3409(srcs, parseOptions: TestOptions.RegularPreview)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 3424, 3465);

                var
                actualErrors = f_21007_3443_3464(comp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 3479, 3529);

                f_21007_3479_3528(actualErrors, expectedErrorDesp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 3543, 3555);

                return comp;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21007, 3148, 3566);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21007, 3148, 3566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21007, 3148, 3566);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal static CSharpCompilation VerifyErrorsAndGetCompilationWithMscorlib(string text, IEnumerable<MetadataReference> refs, params ErrorDescription[] expectedErrorDesp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21007, 3723, 4040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 3928, 4029);

                return f_21007_3935_4028(new List<string> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => text, 21007, 3977, 4002) }, refs, expectedErrorDesp);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21007, 3723, 4040);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21007, 3723, 4040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21007, 3723, 4040);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal static CSharpCompilation VerifyErrorsAndGetCompilationWithMscorlib(List<string> srcs, IEnumerable<MetadataReference> refs, params ErrorDescription[] expectedErrorDesp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21007, 4197, 4636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 4408, 4525);

                var
                synTrees = f_21007_4423_4524((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from text in srcs
                                                                                                      select SyntaxFactory.ParseSyntaxTree(text), 21007, 4424, 4513)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 4541, 4625);

                return f_21007_4548_4624(synTrees, refs, expectedErrorDesp);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21007, 4197, 4636);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21007, 4197, 4636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21007, 4197, 4636);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal static CSharpCompilation VerifyErrorsAndGetCompilationWithMscorlib(SyntaxTree[] trees, IEnumerable<MetadataReference> refs, params ErrorDescription[] expectedErrorDesp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21007, 4793, 5120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 5005, 5109);

                return f_21007_5012_5108(trees, f_21007_5049_5088(refs, f_21007_5061_5087()), expectedErrorDesp);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21007, 4793, 5120);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21007, 4793, 5120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21007, 4793, 5120);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected internal static CSharpCompilation VerifyErrorsAndGetCompilation(IEnumerable<SyntaxTree> synTrees, IEnumerable<MetadataReference> refs = null, params ErrorDescription[] expectedErrorDesp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21007, 5277, 5801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 5498, 5641);

                var
                comp = f_21007_5509_5640(assemblyName: "DiagnosticsTest", options: TestOptions.ReleaseDll, syntaxTrees: synTrees, references: refs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 5655, 5696);

                var
                actualErrors = f_21007_5674_5695(comp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 5712, 5762);

                f_21007_5712_5761(actualErrors, expectedErrorDesp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 5778, 5790);

                return comp;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21007, 5277, 5801);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21007, 5277, 5801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21007, 5277, 5801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void VerifyErrorCodes(IEnumerable<Diagnostic> actualErrors, params ErrorDescription[] expectedErrorDesp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21007, 5958, 9470);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 6101, 6156) || true) && (expectedErrorDesp == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21007, 6101, 6156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 6149, 6156);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21007, 6101, 6156);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 6172, 6218);

                int
                expectedLength = f_21007_6193_6217(expectedErrorDesp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 6232, 6272);

                int
                actualLength = f_21007_6251_6271(actualErrors)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 6288, 6668);

                f_21007_6288_6667(expectedLength == actualLength, f_21007_6367_6666("ErrCount {0} != {1}{2}Actual errors are:{2}{3}", expectedLength, actualLength, f_21007_6546_6565(), (DynAbs.Tracing.TraceSender.Conditional_F1(21007, 6588, 6605) || ((actualLength == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(21007, 6608, 6616)) || DynAbs.Tracing.TraceSender.Conditional_F3(21007, 6619, 6665))) ? "<none>" : f_21007_6619_6665(f_21007_6631_6650(), actualErrors)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 6684, 7829);

                var
                actualSortedDesp = f_21007_6707_7828((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from ae in
                                                        (from e in actualErrors
                                                         let lineSpan = e.Location.GetMappedLineSpan()
                                                         select new ErrorDescription
                                                         {
                                                             Code = e.Code,
                                                             Line = lineSpan.IsValid ? lineSpan.StartLinePosition.Line + 1 : 0,
                                                             Column = lineSpan.IsValid ? lineSpan.StartLinePosition.Character + 1 : 0,
                                                             IsWarning = e.Severity == DiagnosticSeverity.Warning,
                                                             Parameters = (e.Arguments != null && e.Arguments.Count > 0 && e.Arguments[0] != null) ?
                                                                e.Arguments.Select(x => x != null ? x.ToString() : null).ToArray() : Array.Empty<string>()
                                                         })
                                                                                                              orderby ae.Code, ae.Line, ae.Column
                                                                                                              select ae, 21007, 6708, 7818)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 7845, 8034);

                var
                expectedSortedDesp = f_21007_7870_8033((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from ee in expectedErrorDesp
                                                                                                                orderby ee.Code, ee.Line, ee.Column
                                                                                                                select ee, 21007, 7871, 8023)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 8050, 8062);

                int
                idx = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 8111, 9459);
                    foreach (var experr in f_21007_8134_8152_I(expectedSortedDesp))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21007, 8111, 9459);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 8186, 8332) || true) && (idx < f_21007_8199_8221(actualSortedDesp) && (DynAbs.Tracing.TraceSender.Expression_True(21007, 8193, 8265) && actualSortedDesp[idx].Code < experr.Code))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21007, 8186, 8332);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 8307, 8313);

                                idx++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21007, 8186, 8332);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(21007, 8186, 8332);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(21007, 8186, 8332);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 8352, 8479) || true) && (idx >= f_21007_8363_8385(actualSortedDesp))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21007, 8352, 8479);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 8427, 8460);

                            idx = f_21007_8433_8455(actualSortedDesp) - 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21007, 8352, 8479);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 8499, 8534);

                        var
                        acterr = f_21007_8512_8533(actualSortedDesp, idx)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 8554, 8593);

                        f_21007_8554_8592(experr.Code, acterr.Code);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 8611, 8937) || true) && (experr.Line > 0 && (DynAbs.Tracing.TraceSender.Expression_True(21007, 8615, 8651) && experr.Column > 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21007, 8611, 8937);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 8693, 8791);

                            f_21007_8693_8790(experr.Line == acterr.Line, f_21007_8733_8789("Line {0}!={1}", experr.Line, acterr.Line));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 8813, 8918);

                            f_21007_8813_8917(experr.Column == acterr.Column, f_21007_8857_8916("Col {0}!={1}", experr.Column, acterr.Column));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21007, 8611, 8937);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 8957, 9080);

                        f_21007_8957_9079(experr.IsWarning == acterr.IsWarning, f_21007_9007_9078("IsWarning {0}!={1}", experr.IsWarning, acterr.IsWarning));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 9176, 9418) || true) && (experr.Parameters != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21007, 9176, 9418);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 9247, 9399);

                            f_21007_9247_9398(f_21007_9259_9309(experr.Parameters, acterr.Parameters), f_21007_9311_9397("Param: {0}!={1}", f_21007_9344_9369(experr.Parameters), f_21007_9371_9396(acterr.Parameters)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21007, 9176, 9418);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 9438, 9444);

                        idx++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21007, 8111, 9459);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21007, 1, 1349);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21007, 1, 1349);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21007, 5958, 9470);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21007, 5958, 9470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21007, 5958, 9470);
            }
        }

        public static void VerifyErrorCodesNoLineColumn(IEnumerable<Diagnostic> actualErrors, params ErrorDescription[] expectedErrorDesp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21007, 9627, 11050);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 9782, 9837) || true) && (expectedErrorDesp == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21007, 9782, 9837);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 9830, 9837);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21007, 9782, 9837);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 10108, 10174);

                f_21007_10108_10173(f_21007_10123_10147(expectedErrorDesp), 0, f_21007_10152_10172(actualErrors));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 10190, 10350);

                var
                expectedCodes = f_21007_10210_10349((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from e in expectedErrorDesp
                                                                                                             orderby e.Code
                                                                                                             group e by e.Code, 21007, 10211, 10339)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 10366, 10515);

                var
                actualCodes = f_21007_10384_10514((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from e in actualErrors
                                                                                                           orderby e.Code
                                                                                                           group e by e.Code, 21007, 10385, 10504)))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 10531, 11039);
                    foreach (var expectedGroup in f_21007_10561_10574_I(expectedCodes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21007, 10531, 11039);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 10608, 10687);

                        var
                        actualGroup = f_21007_10626_10686(actualCodes, x => x.Key == expectedGroup.Key)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 10705, 10774);

                        var
                        actualGroupCount = (DynAbs.Tracing.TraceSender.Conditional_F1(21007, 10728, 10747) || ((actualGroup != null && DynAbs.Tracing.TraceSender.Conditional_F2(21007, 10750, 10769)) || DynAbs.Tracing.TraceSender.Conditional_F3(21007, 10772, 10773))) ? f_21007_10750_10769(actualGroup) : 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21007, 10965, 11024);

                        f_21007_10965_11023(f_21007_10980_11001(expectedGroup), 0, actualGroupCount);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21007, 10531, 11039);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21007, 1, 509);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21007, 1, 509);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21007, 9627, 11050);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21007, 9627, 11050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21007, 9627, 11050);
            }
        }

        public DiagnosticsUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(21007, 1044, 11057);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(21007, 1044, 11057);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21007, 1044, 11057);
        }


        static DiagnosticsUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21007, 1044, 11057);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21007, 1044, 11057);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21007, 1044, 11057);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(21007, 1044, 11057);

        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
        f_21007_1389_1410(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.GetDiagnostics();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 1389, 1410);
            return return_v;
        }


        static int
        f_21007_1425_1488(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
        actualErrors, params Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription[]
        expectedErrorDesp)
        {
            DiagnosticsUtils.VerifyErrorCodes((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)actualErrors, expectedErrorDesp);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 1425, 1488);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21007_1822_1862(string
        source)
        {
            var return_v = CSharpTestBase.CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 1822, 1862);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
        f_21007_1895_1916(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.GetDiagnostics();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 1895, 1916);
            return return_v;
        }

        [Obsolete("Use VerifyDiagnostics", true)]
        static int
        f_21007_1931_1990(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
        diagnostics, params string[]
        diagStrings)
        {
            CompilingTestBase.TestDiagnostics((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, diagStrings);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 1931, 1990);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21007_2329_2369(string
        source)
        {
            var return_v = CSharpTestBase.CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 2329, 2369);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
        f_21007_2402_2423(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.GetDiagnostics();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 2402, 2423);
            return return_v;
        }


        static int
        f_21007_2451_2469(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21007, 2451, 2469);
            return return_v;
        }


        static int
        f_21007_2438_2490(int
        expected, int
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 2438, 2490);
            return 0;
        }

        [Obsolete("Use VerifyDiagnostics", true)]
        static int
        f_21007_2505_2564(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
        diagnostics, params string[]
        diagStrings)
        {
            CompilingTestBase.TestDiagnostics((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, diagStrings);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 2505, 2564);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21007_2896_2979(string[]
        srcs, params Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription[]
        expectedErrorDesp)
        {
            var return_v = VerifyErrorsAndGetCompilationWithMscorlib(srcs, expectedErrorDesp);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 2896, 2979);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21007_3329_3409(string[]
        source, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        parseOptions)
        {
            var return_v = CSharpTestBase.CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions: parseOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 3329, 3409);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
        f_21007_3443_3464(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.GetDiagnostics();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 3443, 3464);
            return return_v;
        }


        static int
        f_21007_3479_3528(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
        actualErrors, params Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription[]
        expectedErrorDesp)
        {
            VerifyErrorCodes((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)actualErrors, expectedErrorDesp);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 3479, 3528);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21007_3935_4028(System.Collections.Generic.List<string>
        srcs, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
        refs, params Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription[]
        expectedErrorDesp)
        {
            var return_v = VerifyErrorsAndGetCompilationWithMscorlib(srcs, refs, expectedErrorDesp);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 3935, 4028);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree[]
        f_21007_4423_4524(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
        source)
        {
            var return_v = source.ToArray<Microsoft.CodeAnalysis.SyntaxTree>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 4423, 4524);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21007_4548_4624(Microsoft.CodeAnalysis.SyntaxTree[]
        trees, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
        refs, params Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription[]
        expectedErrorDesp)
        {
            var return_v = VerifyErrorsAndGetCompilationWithMscorlib(trees, refs, expectedErrorDesp);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 4548, 4624);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_21007_5061_5087()
        {
            var return_v = CSharpTestBase.MscorlibRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21007, 5061, 5087);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
        f_21007_5049_5088(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
        source, Microsoft.CodeAnalysis.MetadataReference
        value)
        {
            var return_v = source.Concat<Microsoft.CodeAnalysis.MetadataReference>(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 5049, 5088);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21007_5012_5108(Microsoft.CodeAnalysis.SyntaxTree[]
        synTrees, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
        refs, params Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription[]
        expectedErrorDesp)
        {
            var return_v = VerifyErrorsAndGetCompilation((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>)synTrees, refs, expectedErrorDesp);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 5012, 5108);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21007_5509_5640(string
        assemblyName, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        options, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
        syntaxTrees, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
        references)
        {
            var return_v = CSharpCompilation.Create(assemblyName: assemblyName, options: options, syntaxTrees: syntaxTrees, references: references);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 5509, 5640);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
        f_21007_5674_5695(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.GetDiagnostics();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 5674, 5695);
            return return_v;
        }


        static int
        f_21007_5712_5761(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
        actualErrors, params Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription[]
        expectedErrorDesp)
        {
            VerifyErrorCodes((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)actualErrors, expectedErrorDesp);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 5712, 5761);
            return 0;
        }


        static int
        f_21007_6193_6217(Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21007, 6193, 6217);
            return return_v;
        }


        static int
        f_21007_6251_6271(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
        source)
        {
            var return_v = source.Count<Microsoft.CodeAnalysis.Diagnostic>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 6251, 6271);
            return return_v;
        }


        static string
        f_21007_6546_6565()
        {
            var return_v = Environment.NewLine;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21007, 6546, 6565);
            return return_v;
        }


        static string
        f_21007_6631_6650()
        {
            var return_v = Environment.NewLine;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21007, 6631, 6650);
            return return_v;
        }


        static string
        f_21007_6619_6665(string
        separator, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
        values)
        {
            var return_v = string.Join(separator, values);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 6619, 6665);
            return return_v;
        }


        static string
        f_21007_6367_6666(string
        format, params object?[]
        args)
        {
            var return_v = String.Format(format, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 6367, 6666);
            return return_v;
        }


        static int
        f_21007_6288_6667(bool
        condition, string
        userMessage)
        {
            Assert.True(condition, userMessage);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 6288, 6667);
            return 0;
        }


        static System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription>
        f_21007_6707_7828(System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription>
        source)
        {
            var return_v = source.ToList<Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 6707, 7828);
            return return_v;
        }


        static System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription>
        f_21007_7870_8033(System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription>
        source)
        {
            var return_v = source.ToList<Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 7870, 8033);
            return return_v;
        }


        static int
        f_21007_8199_8221(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21007, 8199, 8221);
            return return_v;
        }


        static int
        f_21007_8363_8385(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21007, 8363, 8385);
            return return_v;
        }


        static int
        f_21007_8433_8455(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21007, 8433, 8455);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription
        f_21007_8512_8533(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription>
        this_param, int
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21007, 8512, 8533);
            return return_v;
        }


        static int
        f_21007_8554_8592(int
        expected, int
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 8554, 8592);
            return 0;
        }


        static string
        f_21007_8733_8789(string
        format, int
        arg0, int
        arg1)
        {
            var return_v = String.Format(format, (object)arg0, (object)arg1);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 8733, 8789);
            return return_v;
        }


        static int
        f_21007_8693_8790(bool
        condition, string
        userMessage)
        {
            Assert.True(condition, userMessage);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 8693, 8790);
            return 0;
        }


        static string
        f_21007_8857_8916(string
        format, int
        arg0, int
        arg1)
        {
            var return_v = String.Format(format, (object)arg0, (object)arg1);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 8857, 8916);
            return return_v;
        }


        static int
        f_21007_8813_8917(bool
        condition, string
        userMessage)
        {
            Assert.True(condition, userMessage);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 8813, 8917);
            return 0;
        }


        static string
        f_21007_9007_9078(string
        format, bool
        arg0, bool
        arg1)
        {
            var return_v = String.Format(format, (object)arg0, (object)arg1);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 9007, 9078);
            return return_v;
        }


        static int
        f_21007_8957_9079(bool
        condition, string
        userMessage)
        {
            Assert.True(condition, userMessage);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 8957, 9079);
            return 0;
        }


        static bool
        f_21007_9259_9309(string[]
        first, string[]
        second)
        {
            var return_v = first.SequenceEqual<string>((System.Collections.Generic.IEnumerable<string>)second);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 9259, 9309);
            return return_v;
        }


        static int
        f_21007_9344_9369(string[]
        source)
        {
            var return_v = source.Count<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 9344, 9369);
            return return_v;
        }


        static int
        f_21007_9371_9396(string[]
        source)
        {
            var return_v = source.Count<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 9371, 9396);
            return return_v;
        }


        static string
        f_21007_9311_9397(string
        format, int
        arg0, int
        arg1)
        {
            var return_v = String.Format(format, (object)arg0, (object)arg1);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 9311, 9397);
            return return_v;
        }


        static int
        f_21007_9247_9398(bool
        condition, string
        userMessage)
        {
            Assert.True(condition, userMessage);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 9247, 9398);
            return 0;
        }


        static System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription>
        f_21007_8134_8152_I(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 8134, 8152);
            return return_v;
        }


        static int
        f_21007_10123_10147(Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21007, 10123, 10147);
            return return_v;
        }


        static int
        f_21007_10152_10172(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
        source)
        {
            var return_v = source.Count<Microsoft.CodeAnalysis.Diagnostic>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 10152, 10172);
            return return_v;
        }


        static int
        f_21007_10108_10173(int
        actual, int
        low, int
        high)
        {
            Assert.InRange(actual, low, high);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 10108, 10173);
            return 0;
        }


        static System.Collections.Generic.List<System.Linq.IGrouping<int, Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription>>
        f_21007_10210_10349(System.Collections.Generic.IEnumerable<System.Linq.IGrouping<int, Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription>>
        source)
        {
            var return_v = source.ToList<System.Linq.IGrouping<int, Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 10210, 10349);
            return return_v;
        }


        static System.Collections.Generic.List<System.Linq.IGrouping<int, Microsoft.CodeAnalysis.Diagnostic>>
        f_21007_10384_10514(System.Collections.Generic.IEnumerable<System.Linq.IGrouping<int, Microsoft.CodeAnalysis.Diagnostic>>
        source)
        {
            var return_v = source.ToList<System.Linq.IGrouping<int, Microsoft.CodeAnalysis.Diagnostic>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 10384, 10514);
            return return_v;
        }


        static System.Linq.IGrouping<int, Microsoft.CodeAnalysis.Diagnostic>
        f_21007_10626_10686(System.Collections.Generic.List<System.Linq.IGrouping<int, Microsoft.CodeAnalysis.Diagnostic>>
        source, System.Func<System.Linq.IGrouping<int, Microsoft.CodeAnalysis.Diagnostic>, bool>
        predicate)
        {
            var return_v = source.SingleOrDefault<System.Linq.IGrouping<int, Microsoft.CodeAnalysis.Diagnostic>>(predicate);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 10626, 10686);
            return return_v;
        }


        static int
        f_21007_10750_10769(System.Linq.IGrouping<int, Microsoft.CodeAnalysis.Diagnostic>
        source)
        {
            var return_v = source.Count<Microsoft.CodeAnalysis.Diagnostic>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 10750, 10769);
            return return_v;
        }


        static int
        f_21007_10980_11001(System.Linq.IGrouping<int, Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription>
        source)
        {
            var return_v = source.Count<Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 10980, 11001);
            return return_v;
        }


        static int
        f_21007_10965_11023(int
        actual, int
        low, int
        high)
        {
            Assert.InRange(actual, low, high);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 10965, 11023);
            return 0;
        }


        static System.Collections.Generic.List<System.Linq.IGrouping<int, Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription>>
        f_21007_10561_10574_I(System.Collections.Generic.List<System.Linq.IGrouping<int, Microsoft.CodeAnalysis.CSharp.UnitTests.ErrorDescription>>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21007, 10561, 10574);
            return return_v;
        }

    }
}
