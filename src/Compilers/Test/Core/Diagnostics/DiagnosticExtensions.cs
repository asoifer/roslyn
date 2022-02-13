// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Roslyn.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis
{
    public static class DiagnosticExtensions
    {
        public static void VerifyErrorCodes(this IEnumerable<Diagnostic> actual, params DiagnosticDescription[] expected)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 892, 1087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 1030, 1076);

                f_25002_1030_1075(actual, expected, errorCodeOnly: true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 892, 1087);

                int
                f_25002_1030_1075(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                actual, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected, bool
                errorCodeOnly)
                {
                    Verify(actual, expected, errorCodeOnly: errorCodeOnly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 1030, 1075);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 892, 1087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 892, 1087);
            }
        }

        public static void VerifyErrorCodes(this ImmutableArray<Diagnostic> actual, params DiagnosticDescription[] expected)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 1099, 1311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 1240, 1300);

                f_25002_1240_1299(ref actual, expected);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 1099, 1311);

                int
                f_25002_1240_1299(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                actual, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    actual.VerifyErrorCodes(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 1240, 1299);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 1099, 1311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 1099, 1311);
            }
        }

        internal static void Verify(this DiagnosticBag actual, params DiagnosticDescription[] expected)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 1323, 1516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 1443, 1505);

                f_25002_1443_1504(f_25002_1450_1471(actual), expected, errorCodeOnly: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 1323, 1516);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_25002_1450_1471(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.AsEnumerable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 1450, 1471);
                    return return_v;
                }


                int
                f_25002_1443_1504(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                actual, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected, bool
                errorCodeOnly)
                {
                    Verify(actual, expected, errorCodeOnly: errorCodeOnly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 1443, 1504);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 1323, 1516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 1323, 1516);
            }
        }

        public static void Verify(this IEnumerable<Diagnostic> actual, params DiagnosticDescription[] expected)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 1528, 1714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 1656, 1703);

                f_25002_1656_1702(actual, expected, errorCodeOnly: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 1528, 1714);

                int
                f_25002_1656_1702(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                actual, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected, bool
                errorCodeOnly)
                {
                    Verify(actual, expected, errorCodeOnly: errorCodeOnly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 1656, 1702);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 1528, 1714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 1528, 1714);
            }
        }

        public static void Verify(this IEnumerable<Diagnostic> actual, bool fallbackToErrorCodeOnlyForNonEnglish, params DiagnosticDescription[] expected)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 1726, 2036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 1897, 2025);

                f_25002_1897_2024(actual, expected, errorCodeOnly: fallbackToErrorCodeOnlyForNonEnglish && (DynAbs.Tracing.TraceSender.Expression_True(25002, 1937, 2023) && f_25002_1977_2015() != null));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 1726, 2036);

                System.Globalization.CultureInfo
                f_25002_1977_2015()
                {
                    var return_v = EnsureEnglishUICulture.PreferredOrNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 1977, 2015);
                    return return_v;
                }


                int
                f_25002_1897_2024(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                actual, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected, bool
                errorCodeOnly)
                {
                    Verify(actual, expected, errorCodeOnly: errorCodeOnly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 1897, 2024);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 1726, 2036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 1726, 2036);
            }
        }

        public static void VerifyWithFallbackToErrorCodeOnlyForNonEnglish(this IEnumerable<Diagnostic> actual, params DiagnosticDescription[] expected)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 2048, 2258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 2216, 2247);

                f_25002_2216_2246(actual, true, expected);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 2048, 2258);

                int
                f_25002_2216_2246(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                actual, bool
                fallbackToErrorCodeOnlyForNonEnglish, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    actual.Verify(fallbackToErrorCodeOnlyForNonEnglish, expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 2216, 2246);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 2048, 2258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 2048, 2258);
            }
        }

        public static void Verify(this ImmutableArray<Diagnostic> actual, params DiagnosticDescription[] expected)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 2270, 2462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 2401, 2451);

                // LAFHIS
                //f_25002_2401_2450(ref actual, expected);

                Verify((IEnumerable<Diagnostic>)actual, expected);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 2401, 2450);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 2270, 2462);

                int
                f_25002_2401_2450(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                actual, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    actual.Verify(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 2401, 2450);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 2270, 2462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 2270, 2462);
            }
        }

        private static void Verify(IEnumerable<Diagnostic> actual, DiagnosticDescription[] expected, bool errorCodeOnly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 2474, 4192);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 2611, 2759) || true) && (expected == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25002, 2611, 2759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 2665, 2744);

                    throw f_25002_2671_2743("Must specify expected errors.", nameof(expected));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25002, 2611, 2759);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 2775, 2867);

                var
                includeDefaultSeverity = f_25002_2804_2818(expected) && (DynAbs.Tracing.TraceSender.Expression_True(25002, 2804, 2866) && f_25002_2822_2866(expected, e => e.DefaultSeverity != null))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 2881, 2977);

                var
                includeEffectiveSeverity = f_25002_2912_2926(expected) && (DynAbs.Tracing.TraceSender.Expression_True(25002, 2912, 2976) && f_25002_2930_2976(expected, e => e.EffectiveSeverity != null))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 2991, 3166);

                var
                unmatched = f_25002_3007_3165(f_25002_3007_3120(actual, d => new DiagnosticDescription(d, errorCodeOnly, includeDefaultSeverity, includeEffectiveSeverity)))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 3341, 3730);
                    foreach (var d in f_25002_3359_3367_I(expected))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25002, 3341, 3730);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 3401, 3434);

                        int
                        index = f_25002_3413_3433(unmatched, d)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 3452, 3715) || true) && (index > -1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25002, 3452, 3715);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 3508, 3534);

                            f_25002_3508_3533(unmatched, index);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25002, 3452, 3715);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25002, 3452, 3715);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 3616, 3696);

                            f_25002_3616_3695(false, f_25002_3641_3694(expected, actual));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25002, 3452, 3715);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25002, 3341, 3730);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25002, 1, 390);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25002, 1, 390);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 3840, 3992) || true) && (f_25002_3844_3859(unmatched) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25002, 3840, 3992);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 3897, 3977);

                    f_25002_3897_3976(false, f_25002_3922_3975(expected, actual));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25002, 3840, 3992);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 4102, 4181);

                f_25002_4102_4180(true, f_25002_4126_4179(expected, actual));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 2474, 4192);

                System.ArgumentException
                f_25002_2671_2743(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 2671, 2743);
                    return return_v;
                }


                bool
                f_25002_2804_2818(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                source)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 2804, 2818);
                    return return_v;
                }


                bool
                f_25002_2822_2866(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                source, System.Func<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription, bool>
                predicate)
                {
                    var return_v = source.All<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 2822, 2866);
                    return return_v;
                }


                bool
                f_25002_2912_2926(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                source)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 2912, 2926);
                    return return_v;
                }


                bool
                f_25002_2930_2976(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                source, System.Func<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription, bool>
                predicate)
                {
                    var return_v = source.All<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 2930, 2976);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>
                f_25002_3007_3120(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                source, System.Func<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 3007, 3120);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>
                f_25002_3007_3165(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>
                source)
                {
                    var return_v = source.ToList<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 3007, 3165);
                    return return_v;
                }


                int
                f_25002_3413_3433(System.Collections.Generic.List<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>
                this_param, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                item)
                {
                    var return_v = this_param.IndexOf(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 3413, 3433);
                    return return_v;
                }


                int
                f_25002_3508_3533(System.Collections.Generic.List<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 3508, 3533);
                    return 0;
                }


                string
                f_25002_3641_3694(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                actual)
                {
                    var return_v = DiagnosticDescription.GetAssertText(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 3641, 3694);
                    return return_v;
                }


                bool
                f_25002_3616_3695(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 3616, 3695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                f_25002_3359_3367_I(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 3359, 3367);
                    return return_v;
                }


                int
                f_25002_3844_3859(System.Collections.Generic.List<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 3844, 3859);
                    return return_v;
                }


                string
                f_25002_3922_3975(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                actual)
                {
                    var return_v = DiagnosticDescription.GetAssertText(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 3922, 3975);
                    return return_v;
                }


                bool
                f_25002_3897_3976(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 3897, 3976);
                    return return_v;
                }


                string
                f_25002_4126_4179(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                actual)
                {
                    var return_v = DiagnosticDescription.GetAssertText(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 4126, 4179);
                    return return_v;
                }


                bool
                f_25002_4102_4180(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 4102, 4180);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 2474, 4192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 2474, 4192);
            }
        }

        public static TCompilation VerifyDiagnostics<TCompilation>(this TCompilation c, params DiagnosticDescription[] expected)
                    where TCompilation : Compilation
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 4204, 4559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 4395, 4432);

                var
                diagnostics = f_25002_4413_4431<TCompilation>(c)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 4446, 4475);

                diagnostics.Verify(expected);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 4489, 4523);

                f_25002_4489_4522<TCompilation>(c, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 4539, 4548);

                return c;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 4204, 4559);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_25002_4413_4431<TCompilation>(TCompilation
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 4413, 4431);
                    return return_v;
                }


                int
                f_25002_4489_4522<TCompilation>(TCompilation
                c, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics) where TCompilation : Compilation

                {
                    VerifyAssemblyIds(c, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 4489, 4522);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 4204, 4559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 4204, 4559);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void VerifyAssemblyIds<TCompilation>(
                    TCompilation c, ImmutableArray<Diagnostic> diagnostics) where TCompilation : Compilation
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 4571, 5847);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 4750, 5836);
                    foreach (var diagnostic in f_25002_4777_4788_I(diagnostics))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25002, 4750, 5836);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 5097, 5821) || true) && (f_25002_5101_5164<TCompilation>(c, f_25002_5148_5163<TCompilation>(diagnostic)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25002, 5097, 5821);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 5206, 5272);

                            var
                            assemblyIds = f_25002_5224_5271<TCompilation>(c, diagnostic)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 5294, 5334);

                            f_25002_5294_5333<TCompilation>(assemblyIds.IsEmpty);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 5358, 5406);

                            var
                            diagnosticMessage = f_25002_5382_5405<TCompilation>(diagnostic)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 5428, 5593);
                                foreach (var id in f_25002_5447_5458_I(assemblyIds))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25002, 5428, 5593);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 5508, 5570);

                                    f_25002_5508_5569<TCompilation>(f_25002_5530_5549<TCompilation>(id), diagnosticMessage);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25002, 5428, 5593);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25002, 1, 166);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25002, 1, 166);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25002, 5097, 5821);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25002, 5097, 5821);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 5675, 5741);

                            var
                            assemblyIds = f_25002_5693_5740<TCompilation>(c, diagnostic)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 5763, 5802);

                            f_25002_5763_5801<TCompilation>(assemblyIds.IsEmpty);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25002, 5097, 5821);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25002, 4750, 5836);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25002, 1, 1087);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25002, 1, 1087);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 4571, 5847);

                int
                f_25002_5148_5163<TCompilation>(Microsoft.CodeAnalysis.Diagnostic
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 5148, 5163);
                    return return_v;
                }


                bool
                f_25002_5101_5164<TCompilation>(TCompilation
                this_param, int
                code) where TCompilation : Compilation

                {
                    var return_v = this_param.IsUnreferencedAssemblyIdentityDiagnosticCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 5101, 5164);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                f_25002_5224_5271<TCompilation>(TCompilation
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diagnostic) where TCompilation : Compilation

                {
                    var return_v = this_param.GetUnreferencedAssemblyIdentities(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 5224, 5271);
                    return return_v;
                }


                bool
                f_25002_5294_5333<TCompilation>(bool
                condition) where TCompilation : Compilation

                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 5294, 5333);
                    return return_v;
                }


                string
                f_25002_5382_5405<TCompilation>(Microsoft.CodeAnalysis.Diagnostic
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.GetMessage();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 5382, 5405);
                    return return_v;
                }


                string
                f_25002_5530_5549<TCompilation>(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.GetDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 5530, 5549);
                    return return_v;
                }


                bool
                f_25002_5508_5569<TCompilation>(string
                expectedSubstring, string
                actualString) where TCompilation : Compilation

                {
                    var return_v = CustomAssert.Contains(expectedSubstring, actualString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 5508, 5569);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                f_25002_5447_5458_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 5447, 5458);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                f_25002_5693_5740<TCompilation>(TCompilation
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diagnostic) where TCompilation : Compilation

                {
                    var return_v = this_param.GetUnreferencedAssemblyIdentities(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 5693, 5740);
                    return return_v;
                }


                bool
                f_25002_5763_5801<TCompilation>(bool
                condition) where TCompilation : Compilation

                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 5763, 5801);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_25002_4777_4788_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 4777, 4788);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 4571, 5847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 4571, 5847);
            }
        }

        public static void VerifyAnalyzerOccurrenceCount<TCompilation>(
                    this TCompilation c,
                    DiagnosticAnalyzer[] analyzers,
                    int expectedCount,
                    Action<Exception, DiagnosticAnalyzer, Diagnostic> onAnalyzerException = null)
                    where TCompilation : Compilation
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 5859, 6311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 6195, 6300);

                f_25002_6195_6299<TCompilation>(expectedCount, f_25002_6229_6291<TCompilation>(c, analyzers, null, onAnalyzerException).Length);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 5859, 6311);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_25002_6229_6291<TCompilation>(TCompilation
                c, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[]
                analyzers, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                options, System.Action<System.Exception, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostic>?
                onAnalyzerException) where TCompilation : Compilation

                {
                    var return_v = c.GetAnalyzerDiagnostics<TCompilation>(analyzers, options, onAnalyzerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 6229, 6291);
                    return return_v;
                }


                bool
                f_25002_6195_6299<TCompilation>(int
                expected, int
                actual) where TCompilation : Compilation

                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 6195, 6299);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 5859, 6311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 5859, 6311);
            }
        }

        public static TCompilation VerifyAnalyzerDiagnostics<TCompilation>(
                    this TCompilation c,
                    DiagnosticAnalyzer[] analyzers,
                    AnalyzerOptions options = null,
                    Action<Exception, DiagnosticAnalyzer, Diagnostic> onAnalyzerException = null,
                    params DiagnosticDescription[] expected)
                    where TCompilation : Compilation
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 6323, 6864);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 6730, 6853);

                return f_25002_6737_6852<TCompilation>(c, analyzers, reportSuppressedDiagnostics: false, options, onAnalyzerException, expected);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 6323, 6864);

                TCompilation
                f_25002_6737_6852<TCompilation>(TCompilation
                c, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[]
                analyzers, bool
                reportSuppressedDiagnostics, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                options, System.Action<System.Exception, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostic>?
                onAnalyzerException, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected) where TCompilation : Compilation

                {
                    var return_v = c.VerifyAnalyzerDiagnostics<TCompilation>(analyzers, reportSuppressedDiagnostics: reportSuppressedDiagnostics, options, onAnalyzerException, expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 6737, 6852);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 6323, 6864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 6323, 6864);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TCompilation VerifyAnalyzerDiagnostics<TCompilation>(
                    this TCompilation c,
                    DiagnosticAnalyzer[] analyzers,
                    bool reportSuppressedDiagnostics,
                    AnalyzerOptions options = null,
                    Action<Exception, DiagnosticAnalyzer, Diagnostic> onAnalyzerException = null,
                    params DiagnosticDescription[] expected)
                    where TCompilation : Compilation
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 6876, 7631);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic> diagnostics = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 7330, 7541);

                var
                newCompilation = f_25002_7351_7540<TCompilation>(c, analyzers, options, onAnalyzerException, reportSuppressedDiagnostics, includeCompilerDiagnostics: false, CancellationToken.None, out diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 7555, 7584);

                diagnostics.Verify(expected);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 7598, 7620);

                return newCompilation;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 6876, 7631);

                TCompilation
                f_25002_7351_7540<TCompilation>(TCompilation
                c, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[]
                analyzers, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                options, System.Action<System.Exception, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostic>?
                onAnalyzerException, bool
                reportSuppressedDiagnostics, bool
                includeCompilerDiagnostics, System.Threading.CancellationToken
                cancellationToken, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics) where TCompilation : Compilation

                {
                    var return_v = c.GetCompilationWithAnalyzerDiagnostics<TCompilation>(analyzers, options, onAnalyzerException, reportSuppressedDiagnostics, includeCompilerDiagnostics: includeCompilerDiagnostics, cancellationToken, out diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 7351, 7540);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 6876, 7631);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 6876, 7631);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<Diagnostic> GetAnalyzerDiagnostics<TCompilation>(
                    this TCompilation c,
                    DiagnosticAnalyzer[] analyzers,
                    AnalyzerOptions options = null,
                    Action<Exception, DiagnosticAnalyzer, Diagnostic> onAnalyzerException = null,
                    CancellationToken cancellationToken = default)
                    where TCompilation : Compilation
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 7643, 8207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 8067, 8196);

                return f_25002_8074_8195<TCompilation>(c, analyzers, reportSuppressedDiagnostics: false, options, onAnalyzerException, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 7643, 8207);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_25002_8074_8195<TCompilation>(TCompilation
                c, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[]
                analyzers, bool
                reportSuppressedDiagnostics, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                options, System.Action<System.Exception, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostic>?
                onAnalyzerException, System.Threading.CancellationToken
                cancellationToken) where TCompilation : Compilation

                {
                    var return_v = c.GetAnalyzerDiagnostics<TCompilation>(analyzers, reportSuppressedDiagnostics: reportSuppressedDiagnostics, options, onAnalyzerException, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 8074, 8195);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 7643, 8207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 7643, 8207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<Diagnostic> GetAnalyzerDiagnostics<TCompilation>(
                    this TCompilation c,
                    DiagnosticAnalyzer[] analyzers,
                    bool reportSuppressedDiagnostics,
                    AnalyzerOptions options = null,
                    Action<Exception, DiagnosticAnalyzer, Diagnostic> onAnalyzerException = null,
                    CancellationToken cancellationToken = default)
                    where TCompilation : Compilation
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 8219, 8924);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic> diagnostics = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 8690, 8880);

                _ = f_25002_8694_8879<TCompilation>(c, analyzers, options, onAnalyzerException, reportSuppressedDiagnostics, includeCompilerDiagnostics: false, cancellationToken, out diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 8894, 8913);

                return diagnostics;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 8219, 8924);

                TCompilation
                f_25002_8694_8879<TCompilation>(TCompilation
                c, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[]
                analyzers, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                options, System.Action<System.Exception, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostic>?
                onAnalyzerException, bool
                reportSuppressedDiagnostics, bool
                includeCompilerDiagnostics, System.Threading.CancellationToken
                cancellationToken, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics) where TCompilation : Compilation

                {
                    var return_v = c.GetCompilationWithAnalyzerDiagnostics<TCompilation>(analyzers, options, onAnalyzerException, reportSuppressedDiagnostics, includeCompilerDiagnostics: includeCompilerDiagnostics, cancellationToken, out diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 8694, 8879);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 8219, 8924);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 8219, 8924);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TCompilation VerifySuppressedDiagnostics<TCompilation>(
                    this TCompilation c,
                    DiagnosticAnalyzer[] analyzers,
                    AnalyzerOptions options = null,
                    Action<Exception, DiagnosticAnalyzer, Diagnostic> onAnalyzerException = null,
                    CancellationToken cancellationToken = default,
                    params DiagnosticDescription[] expected)
                    where TCompilation : Compilation
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 8936, 10104);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 9637, 9944) || true) && (f_25002_9641_9674<TCompilation>(f_25002_9641_9650<TCompilation>(c)) == ReportDiagnostic.Default && (DynAbs.Tracing.TraceSender.Expression_True(25002, 9641, 9766) && f_25002_9723_9766<TCompilation>(f_25002_9723_9758<TCompilation>(f_25002_9723_9732<TCompilation>(c)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25002, 9637, 9944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 9800, 9929);

                    _ = f_25002_9804_9928<TCompilation>(c, toggleWarnAsError: true, analyzers, options, onAnalyzerException, expected, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25002, 9637, 9944);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 9960, 10093);

                return f_25002_9967_10092<TCompilation>(c, toggleWarnAsError: false, analyzers, options, onAnalyzerException, expected, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 8936, 10104);

                Microsoft.CodeAnalysis.CompilationOptions
                f_25002_9641_9650<TCompilation>(TCompilation
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 9641, 9650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_25002_9641_9674<TCompilation>(Microsoft.CodeAnalysis.CompilationOptions
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.GeneralDiagnosticOption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 9641, 9674);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_25002_9723_9732<TCompilation>(TCompilation
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 9723, 9732);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_25002_9723_9758<TCompilation>(Microsoft.CodeAnalysis.CompilationOptions
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.SpecificDiagnosticOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 9723, 9758);
                    return return_v;
                }


                bool
                f_25002_9723_9766<TCompilation>(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.IsEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 9723, 9766);
                    return return_v;
                }


                TCompilation
                f_25002_9804_9928<TCompilation>(TCompilation
                c, bool
                toggleWarnAsError, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[]
                analyzers, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                options, System.Action<System.Exception, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostic>?
                onAnalyzerException, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expectedDiagnostics, System.Threading.CancellationToken
                cancellationToken) where TCompilation : Compilation

                {
                    var return_v = c.VerifySuppressedDiagnostics<TCompilation>(toggleWarnAsError: toggleWarnAsError, analyzers, options, onAnalyzerException, expectedDiagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 9804, 9928);
                    return return_v;
                }


                TCompilation
                f_25002_9967_10092<TCompilation>(TCompilation
                c, bool
                toggleWarnAsError, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[]
                analyzers, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                options, System.Action<System.Exception, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostic>?
                onAnalyzerException, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expectedDiagnostics, System.Threading.CancellationToken
                cancellationToken) where TCompilation : Compilation

                {
                    var return_v = c.VerifySuppressedDiagnostics<TCompilation>(toggleWarnAsError: toggleWarnAsError, analyzers, options, onAnalyzerException, expectedDiagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 9967, 10092);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 8936, 10104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 8936, 10104);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TCompilation VerifySuppressedDiagnostics<TCompilation>(
                    this TCompilation c,
                    bool toggleWarnAsError,
                    DiagnosticAnalyzer[] analyzers,
                    AnalyzerOptions options,
                    Action<Exception, DiagnosticAnalyzer, Diagnostic> onAnalyzerException,
                    DiagnosticDescription[] expectedDiagnostics,
                    CancellationToken cancellationToken)
                    where TCompilation : Compilation
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 10116, 13255);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic> diagnostics = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 10603, 12849) || true) && (toggleWarnAsError)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25002, 10603, 12849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 10658, 10832);

                    var
                    toggledOption = (DynAbs.Tracing.TraceSender.Conditional_F1(25002, 10678, 10737) || ((f_25002_10678_10711<TCompilation>(f_25002_10678_10687<TCompilation>(c)) == ReportDiagnostic.Error && DynAbs.Tracing.TraceSender.Conditional_F2(25002, 10761, 10785)) || DynAbs.Tracing.TraceSender.Conditional_F3(25002, 10809, 10831))) ? ReportDiagnostic.Default : ReportDiagnostic.Error
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 10850, 10936);

                    c = (TCompilation)f_25002_10868_10935<TCompilation>(c, f_25002_10882_10934<TCompilation>(f_25002_10882_10891<TCompilation>(c), toggledOption));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 10956, 11046);

                    var
                    builder = f_25002_10970_11045<TCompilation>(f_25002_11018_11044<TCompilation>(expectedDiagnostics))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 11064, 12767);
                        foreach (var expected in f_25002_11089_11108_I(expectedDiagnostics))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25002, 11064, 12767);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 11422, 11573);

                            var
                            defaultSeverityCheck = f_25002_11449_11483_M(!f_25002_11450_11474<TCompilation>(expected).HasValue) || (DynAbs.Tracing.TraceSender.Expression_False(25002, 11449, 11572) || f_25002_11512_11542<TCompilation>(f_25002_11512_11536<TCompilation>(expected)) == DiagnosticSeverity.Warning)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 11595, 11843);

                            var
                            effectiveSeverityCheck = f_25002_11624_11660_M(!f_25002_11625_11651<TCompilation>(expected).HasValue) || (DynAbs.Tracing.TraceSender.Expression_False(25002, 11624, 11752) || f_25002_11690_11722<TCompilation>(f_25002_11690_11716<TCompilation>(expected)) == DiagnosticSeverity.Warning) || (DynAbs.Tracing.TraceSender.Expression_False(25002, 11624, 11842) || f_25002_11782_11814<TCompilation>(f_25002_11782_11808<TCompilation>(expected)) == DiagnosticSeverity.Error)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 11867, 11901);

                            DiagnosticDescription
                            newExpected
                            = default(DiagnosticDescription);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 11923, 12699) || true) && (defaultSeverityCheck && (DynAbs.Tracing.TraceSender.Expression_True(25002, 11927, 11973) && effectiveSeverityCheck))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25002, 11923, 12699);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 12023, 12093);

                                newExpected = f_25002_12037_12092<TCompilation>(expected, f_25002_12065_12091_M(!expected.IsWarningAsError));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 12121, 12555) || true) && (f_25002_12125_12160<TCompilation>(f_25002_12125_12151<TCompilation>(expected)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25002, 12121, 12555);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 12218, 12428);

                                    var
                                    newEffectiveSeverity = (DynAbs.Tracing.TraceSender.Conditional_F1(25002, 12245, 12305) || ((f_25002_12245_12277<TCompilation>(f_25002_12245_12271<TCompilation>(expected)) == DiagnosticSeverity.Error && DynAbs.Tracing.TraceSender.Conditional_F2(25002, 12341, 12367)) || DynAbs.Tracing.TraceSender.Conditional_F3(25002, 12403, 12427))) ? DiagnosticSeverity.Warning : DiagnosticSeverity.Error
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 12458, 12528);

                                    newExpected = f_25002_12472_12527<TCompilation>(newExpected, newEffectiveSeverity);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25002, 12121, 12555);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25002, 11923, 12699);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25002, 11923, 12699);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 12653, 12676);

                                newExpected = expected;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25002, 11923, 12699);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 12723, 12748);

                            f_25002_12723_12747<TCompilation>(
                                                builder, newExpected);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25002, 11064, 12767);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25002, 1, 1704);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25002, 1, 1704);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 12787, 12834);

                    expectedDiagnostics = f_25002_12809_12833<TCompilation>(builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25002, 10603, 12849);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 12865, 13059);

                c = f_25002_12869_13058<TCompilation>(c, analyzers, options, onAnalyzerException, reportSuppressedDiagnostics: true, includeCompilerDiagnostics: true, cancellationToken, out diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 13073, 13133);

                diagnostics = diagnostics.WhereAsArray(d => d.IsSuppressed);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 13147, 13187);

                diagnostics.Verify(expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 13201, 13210);

                return c;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 10116, 13255);

                Microsoft.CodeAnalysis.CompilationOptions
                f_25002_10678_10687<TCompilation>(TCompilation
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 10678, 10687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_25002_10678_10711<TCompilation>(Microsoft.CodeAnalysis.CompilationOptions
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.GeneralDiagnosticOption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 10678, 10711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_25002_10882_10891<TCompilation>(TCompilation
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 10882, 10891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_25002_10882_10934<TCompilation>(Microsoft.CodeAnalysis.CompilationOptions
                this_param, Microsoft.CodeAnalysis.ReportDiagnostic
                value) where TCompilation : Compilation

                {
                    var return_v = this_param.WithGeneralDiagnosticOption(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 10882, 10934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_25002_10868_10935<TCompilation>(TCompilation
                this_param, Microsoft.CodeAnalysis.CompilationOptions
                options) where TCompilation : Compilation

                {
                    var return_v = this_param.WithOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 10868, 10935);
                    return return_v;
                }


                int
                f_25002_11018_11044<TCompilation>(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 11018, 11044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>
                f_25002_10970_11045<TCompilation>(int
                capacity) where TCompilation : Compilation

                {
                    var return_v = ArrayBuilder<DiagnosticDescription>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 10970, 11045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity?
                f_25002_11450_11474<TCompilation>(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.DefaultSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 11450, 11474);
                    return return_v;
                }


                bool
                f_25002_11449_11483_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 11449, 11483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity?
                f_25002_11512_11536<TCompilation>(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.DefaultSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 11512, 11536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_25002_11512_11542<TCompilation>(Microsoft.CodeAnalysis.DiagnosticSeverity?
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 11512, 11542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity?
                f_25002_11625_11651<TCompilation>(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.EffectiveSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 11625, 11651);
                    return return_v;
                }


                bool
                f_25002_11624_11660_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 11624, 11660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity?
                f_25002_11690_11716<TCompilation>(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.EffectiveSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 11690, 11716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_25002_11690_11722<TCompilation>(Microsoft.CodeAnalysis.DiagnosticSeverity?
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 11690, 11722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity?
                f_25002_11782_11808<TCompilation>(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.EffectiveSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 11782, 11808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_25002_11782_11814<TCompilation>(Microsoft.CodeAnalysis.DiagnosticSeverity?
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 11782, 11814);
                    return return_v;
                }


                bool
                f_25002_12065_12091_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 12065, 12091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_25002_12037_12092<TCompilation>(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, bool
                isWarningAsError) where TCompilation : Compilation

                {
                    var return_v = this_param.WithWarningAsError(isWarningAsError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 12037, 12092);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity?
                f_25002_12125_12151<TCompilation>(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.EffectiveSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 12125, 12151);
                    return return_v;
                }


                bool
                f_25002_12125_12160<TCompilation>(Microsoft.CodeAnalysis.DiagnosticSeverity?
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 12125, 12160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity?
                f_25002_12245_12271<TCompilation>(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.EffectiveSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 12245, 12271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_25002_12245_12277<TCompilation>(Microsoft.CodeAnalysis.DiagnosticSeverity?
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 12245, 12277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_25002_12472_12527<TCompilation>(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, Microsoft.CodeAnalysis.DiagnosticSeverity
                effectiveSeverity) where TCompilation : Compilation

                {
                    var return_v = this_param.WithEffectiveSeverity(effectiveSeverity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 12472, 12527);
                    return return_v;
                }


                int
                f_25002_12723_12747<TCompilation>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>
                this_param, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                item) where TCompilation : Compilation

                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 12723, 12747);
                    return 0;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                f_25002_11089_11108_I(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 11089, 11108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                f_25002_12809_12833<TCompilation>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.ToArrayAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 12809, 12833);
                    return return_v;
                }


                TCompilation
                f_25002_12869_13058<TCompilation>(TCompilation
                c, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[]
                analyzers, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                options, System.Action<System.Exception, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostic>
                onAnalyzerException, bool
                reportSuppressedDiagnostics, bool
                includeCompilerDiagnostics, System.Threading.CancellationToken
                cancellationToken, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics) where TCompilation : Compilation

                {
                    var return_v = c.GetCompilationWithAnalyzerDiagnostics<TCompilation>(analyzers, options, onAnalyzerException, reportSuppressedDiagnostics: reportSuppressedDiagnostics, includeCompilerDiagnostics: includeCompilerDiagnostics, cancellationToken, out diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 12869, 13058);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 10116, 13255);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 10116, 13255);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TCompilation GetCompilationWithAnalyzerDiagnostics<TCompilation>(
                    this TCompilation c,
                    DiagnosticAnalyzer[] analyzers,
                    AnalyzerOptions options,
                    Action<Exception, DiagnosticAnalyzer, Diagnostic> onAnalyzerException,
                    bool reportSuppressedDiagnostics,
                    bool includeCompilerDiagnostics,
                    CancellationToken cancellationToken,
                    out ImmutableArray<Diagnostic> diagnostics)
                    where TCompilation : Compilation
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 13267, 15245);
                Microsoft.CodeAnalysis.Compilation newCompilation = default(Microsoft.CodeAnalysis.Compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 13819, 13869);

                var
                analyzersArray = f_25002_13840_13868<TCompilation>(analyzers)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 13883, 14108) || true) && (reportSuppressedDiagnostics != f_25002_13918_13955<TCompilation>(f_25002_13918_13927<TCompilation>(c)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25002, 13883, 14108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 13989, 14093);

                    c = (TCompilation)f_25002_14007_14092<TCompilation>(c, f_25002_14021_14091<TCompilation>(f_25002_14021_14030<TCompilation>(c), reportSuppressedDiagnostics));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25002, 13883, 14108);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 14124, 14182);

                var
                analyzerManager = f_25002_14146_14181<TCompilation>(analyzersArray)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 14196, 14470);

                var
                driver = f_25002_14209_14469<TCompilation>(c, analyzersArray, options, analyzerManager, onAnalyzerException, analyzerExceptionFilter: null, reportAnalyzer: false, severityFilter: SeverityFilter.None, out newCompilation, cancellationToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 14484, 14548);

                f_25002_14484_14547<TCompilation>(f_25002_14502_14538<TCompilation>(newCompilation) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 14562, 14637);

                var
                compilerDiagnostics = f_25002_14588_14636<TCompilation>(newCompilation, cancellationToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 14651, 14727);

                var
                analyzerDiagnostics = f_25002_14677_14726<TCompilation>(f_25002_14677_14719<TCompilation>(driver, newCompilation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 14741, 14897);

                var
                allDiagnostics = (DynAbs.Tracing.TraceSender.Conditional_F1(25002, 14762, 14788) || ((includeCompilerDiagnostics && DynAbs.Tracing.TraceSender.Conditional_F2(25002, 14808, 14857)) || DynAbs.Tracing.TraceSender.Conditional_F3(25002, 14877, 14896))) ? compilerDiagnostics.AddRange(analyzerDiagnostics) : analyzerDiagnostics
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 14911, 14994);

                diagnostics = f_25002_14925_14993<TCompilation>(driver, allDiagnostics, newCompilation);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 15010, 15148) || true) && (!reportSuppressedDiagnostics)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25002, 15010, 15148);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 15076, 15133);

                    f_25002_15076_15132<TCompilation>(diagnostics.All(d => !d.IsSuppressed));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25002, 15010, 15148);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 15164, 15200);

                return (TCompilation)newCompilation;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 13267, 15245);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_25002_13840_13868<TCompilation>(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[]
                items) where TCompilation : Compilation

                {
                    var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 13840, 13868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_25002_13918_13927<TCompilation>(TCompilation
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 13918, 13927);
                    return return_v;
                }


                bool
                f_25002_13918_13955<TCompilation>(Microsoft.CodeAnalysis.CompilationOptions
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.ReportSuppressedDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 13918, 13955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_25002_14021_14030<TCompilation>(TCompilation
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 14021, 14030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_25002_14021_14091<TCompilation>(Microsoft.CodeAnalysis.CompilationOptions
                this_param, bool
                value) where TCompilation : Compilation

                {
                    var return_v = this_param.WithReportSuppressedDiagnostics(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 14021, 14091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_25002_14007_14092<TCompilation>(TCompilation
                this_param, Microsoft.CodeAnalysis.CompilationOptions
                options) where TCompilation : Compilation

                {
                    var return_v = this_param.WithOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 14007, 14092);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                f_25002_14146_14181<TCompilation>(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers) where TCompilation : Compilation

                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager(analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 14146, 14181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                f_25002_14209_14469<TCompilation>(TCompilation
                compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                options, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                analyzerManager, System.Action<System.Exception, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostic>
                onAnalyzerException, System.Func<System.Exception, bool>?
                analyzerExceptionFilter, bool
                reportAnalyzer, Microsoft.CodeAnalysis.Diagnostics.SeverityFilter
                severityFilter, out Microsoft.CodeAnalysis.Compilation
                newCompilation, System.Threading.CancellationToken
                cancellationToken) where TCompilation : Compilation

                {
                    var return_v = AnalyzerDriver.CreateAndAttachToCompilation((Microsoft.CodeAnalysis.Compilation)compilation, analyzers, options, analyzerManager, onAnalyzerException, analyzerExceptionFilter: analyzerExceptionFilter, reportAnalyzer: reportAnalyzer, severityFilter: severityFilter, out newCompilation, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 14209, 14469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModelProvider?
                f_25002_14502_14538<TCompilation>(Microsoft.CodeAnalysis.Compilation
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.SemanticModelProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 14502, 14538);
                    return return_v;
                }


                bool
                f_25002_14484_14547<TCompilation>(bool
                condition) where TCompilation : Compilation

                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 14484, 14547);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_25002_14588_14636<TCompilation>(Microsoft.CodeAnalysis.Compilation
                this_param, System.Threading.CancellationToken
                cancellationToken) where TCompilation : Compilation

                {
                    var return_v = this_param.GetDiagnostics(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 14588, 14636);
                    return return_v;
                }


                System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_25002_14677_14719<TCompilation>(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation) where TCompilation : Compilation

                {
                    var return_v = this_param.GetDiagnosticsAsync(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 14677, 14719);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_25002_14677_14726<TCompilation>(System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.Result;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 14677, 14726);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_25002_14925_14993<TCompilation>(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                reportedDiagnostics, Microsoft.CodeAnalysis.Compilation
                compilation) where TCompilation : Compilation

                {
                    var return_v = this_param.ApplyProgrammaticSuppressions(reportedDiagnostics, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 14925, 14993);
                    return return_v;
                }


                bool
                f_25002_15076_15132<TCompilation>(bool
                condition) where TCompilation : Compilation

                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 15076, 15132);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 13267, 15245);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 13267, 15245);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<Diagnostic> GetEffectiveDiagnostics(this Compilation compilation, IEnumerable<Diagnostic> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 15954, 16200);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 16107, 16189);

                return f_25002_16114_16188(diagnostics, compilation);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 15954, 16200);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_25002_16114_16188(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = CompilationWithAnalyzers.GetEffectiveDiagnostics(diagnostics, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 16114, 16188);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 15954, 16200);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 15954, 16200);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsDiagnosticAnalyzerSuppressed(this DiagnosticAnalyzer analyzer, CompilationOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 16378, 16607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 16514, 16596);

                return f_25002_16521_16595(analyzer, options);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 16378, 16607);

                bool
                f_25002_16521_16595(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.CompilationOptions
                options)
                {
                    var return_v = CompilationWithAnalyzers.IsDiagnosticAnalyzerSuppressed(analyzer, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 16521, 16595);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 16378, 16607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 16378, 16607);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TCompilation VerifyEmitDiagnostics<TCompilation>(this TCompilation c, EmitOptions options, params DiagnosticDescription[] expected)
                    where TCompilation : Compilation
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 16619, 16925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 16835, 16891);

                f_25002_16835_16873<TCompilation>(c, options: options).Verify(expected);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 16905, 16914);

                return c;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 16619, 16925);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_25002_16835_16873<TCompilation>(TCompilation
                c, Microsoft.CodeAnalysis.Emit.EmitOptions
                options) where TCompilation : Compilation

                {
                    var return_v = c.GetEmitDiagnostics<TCompilation>(options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 16835, 16873);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 16619, 16925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 16619, 16925);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<Diagnostic> GetEmitDiagnostics<TCompilation>(
                    this TCompilation c,
                    EmitOptions options = null,
                    IEnumerable<ResourceDescription> manifestResources = null)
                    where TCompilation : Compilation
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 16937, 17452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 17229, 17303);

                var
                pdbStream = (DynAbs.Tracing.TraceSender.Conditional_F1(25002, 17245, 17274) || ((f_25002_17245_17274<TCompilation>() && DynAbs.Tracing.TraceSender.Conditional_F2(25002, 17277, 17281)) || DynAbs.Tracing.TraceSender.Conditional_F3(25002, 17284, 17302))) ? null : f_25002_17284_17302<TCompilation>()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 17317, 17441);

                return f_25002_17324_17440<TCompilation>(f_25002_17324_17428<TCompilation>(c, f_25002_17331_17349<TCompilation>(), pdbStream: pdbStream, options: options, manifestResources: manifestResources));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 16937, 17452);

                bool
                f_25002_17245_17274<TCompilation>() where TCompilation : Compilation

                {
                    var return_v = MonoHelpers.IsRunningOnMono();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 17245, 17274);
                    return return_v;
                }


                System.IO.MemoryStream
                f_25002_17284_17302<TCompilation>() where TCompilation : Compilation

                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 17284, 17302);
                    return return_v;
                }


                System.IO.MemoryStream
                f_25002_17331_17349<TCompilation>() where TCompilation : Compilation

                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 17331, 17349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitResult
                f_25002_17324_17428<TCompilation>(TCompilation
                this_param, System.IO.MemoryStream
                peStream, System.IO.MemoryStream?
                pdbStream, Microsoft.CodeAnalysis.Emit.EmitOptions?
                options, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>?
                manifestResources) where TCompilation : Compilation

                {
                    var return_v = this_param.Emit((System.IO.Stream)peStream, pdbStream: (System.IO.Stream?)pdbStream, options: options, manifestResources: manifestResources);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 17324, 17428);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_25002_17324_17440<TCompilation>(Microsoft.CodeAnalysis.Emit.EmitResult
                this_param) where TCompilation : Compilation

                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 17324, 17440);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 16937, 17452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 16937, 17452);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TCompilation VerifyEmitDiagnostics<TCompilation>(this TCompilation c, params DiagnosticDescription[] expected)
                    where TCompilation : Compilation
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 17464, 17733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 17659, 17722);

                return f_25002_17666_17721<TCompilation>(c, EmitOptions.Default, expected);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 17464, 17733);

                TCompilation
                f_25002_17666_17721<TCompilation>(TCompilation
                c, Microsoft.CodeAnalysis.Emit.EmitOptions
                options, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected) where TCompilation : Compilation

                {
                    var return_v = c.VerifyEmitDiagnostics<TCompilation>(options, expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 17666, 17721);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 17464, 17733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 17464, 17733);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<Diagnostic> GetEmitDiagnostics<TCompilation>(this TCompilation c)
                    where TCompilation : Compilation
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 17745, 17971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 17910, 17960);

                return f_25002_17917_17959<TCompilation>(c, EmitOptions.Default);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 17745, 17971);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_25002_17917_17959<TCompilation>(TCompilation
                c, Microsoft.CodeAnalysis.Emit.EmitOptions
                options) where TCompilation : Compilation

                {
                    var return_v = c.GetEmitDiagnostics<TCompilation>(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 17917, 17959);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 17745, 17971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 17745, 17971);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TCompilation VerifyEmitDiagnostics<TCompilation>(this TCompilation c, IEnumerable<ResourceDescription> manifestResources, params DiagnosticDescription[] expected)
                    where TCompilation : Compilation
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 17983, 18340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 18230, 18306);

                f_25002_18230_18288<TCompilation>(c, manifestResources: manifestResources).Verify(expected);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 18320, 18329);

                return c;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 17983, 18340);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_25002_18230_18288<TCompilation>(TCompilation
                c, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                manifestResources) where TCompilation : Compilation

                {
                    var return_v = c.GetEmitDiagnostics<TCompilation>(manifestResources: manifestResources);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 18230, 18288);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 17983, 18340);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 17983, 18340);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string Concat(this string[] str)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 18352, 18526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 18423, 18515);

                return f_25002_18430_18514(str, f_25002_18444_18463(), (sb, s) => sb.AppendLine(s), sb => sb.ToString());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 18352, 18526);

                System.Text.StringBuilder
                f_25002_18444_18463()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 18444, 18463);
                    return return_v;
                }


                string
                f_25002_18430_18514(string[]
                source, System.Text.StringBuilder
                seed, System.Func<System.Text.StringBuilder, string, System.Text.StringBuilder>
                func, System.Func<System.Text.StringBuilder, string>
                resultSelector)
                {
                    var return_v = source.Aggregate<string, System.Text.StringBuilder, string>(seed, func, resultSelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 18430, 18514);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 18352, 18526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 18352, 18526);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static DiagnosticAnalyzer GetCompilerDiagnosticAnalyzer(string languageName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 18538, 18885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 18646, 18874);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(25002, 18653, 18689) || ((languageName == LanguageNames.CSharp && DynAbs.Tracing.TraceSender.Conditional_F2(25002, 18709, 18786)) || DynAbs.Tracing.TraceSender.Conditional_F3(25002, 18806, 18873))) ? (DiagnosticAnalyzer)f_25002_18729_18786() : f_25002_18806_18873();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 18538, 18885);

                Microsoft.CodeAnalysis.Diagnostics.CSharp.CSharpCompilerDiagnosticAnalyzer
                f_25002_18729_18786()
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CSharp.CSharpCompilerDiagnosticAnalyzer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 18729, 18786);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.VisualBasic.VisualBasicCompilerDiagnosticAnalyzer
                f_25002_18806_18873()
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.VisualBasic.VisualBasicCompilerDiagnosticAnalyzer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 18806, 18873);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 18538, 18885);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 18538, 18885);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableDictionary<string, ImmutableArray<DiagnosticAnalyzer>> GetCompilerDiagnosticAnalyzersMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 18897, 19441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 19035, 19129);

                var
                builder = f_25002_19049_19128()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 19143, 19253);

                f_25002_19143_19252(builder, LanguageNames.CSharp, f_25002_19177_19251(f_25002_19199_19250(LanguageNames.CSharp)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 19267, 19387);

                f_25002_19267_19386(builder, LanguageNames.VisualBasic, f_25002_19306_19385(f_25002_19328_19384(LanguageNames.VisualBasic)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 19401, 19430);

                return f_25002_19408_19429(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 18897, 19441);

                System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>>.Builder
                f_25002_19049_19128()
                {
                    var return_v = ImmutableDictionary.CreateBuilder<string, ImmutableArray<DiagnosticAnalyzer>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 19049, 19128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_25002_19199_19250(string
                languageName)
                {
                    var return_v = GetCompilerDiagnosticAnalyzer(languageName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 19199, 19250);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_25002_19177_19251(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 19177, 19251);
                    return return_v;
                }


                int
                f_25002_19143_19252(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>>.Builder
                this_param, string
                key, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 19143, 19252);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_25002_19328_19384(string
                languageName)
                {
                    var return_v = GetCompilerDiagnosticAnalyzer(languageName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 19328, 19384);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_25002_19306_19385(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 19306, 19385);
                    return return_v;
                }


                int
                f_25002_19267_19386(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>>.Builder
                this_param, string
                key, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 19267, 19386);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>>
                f_25002_19408_19429(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 19408, 19429);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 18897, 19441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 18897, 19441);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AnalyzerReference GetCompilerDiagnosticAnalyzerReference(string languageName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 19453, 19758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 19569, 19628);

                var
                analyzer = f_25002_19584_19627(languageName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 19642, 19747);

                return f_25002_19649_19746(f_25002_19676_19707(analyzer), display: f_25002_19718_19745(f_25002_19718_19736(analyzer)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 19453, 19758);

                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_25002_19584_19627(string
                languageName)
                {
                    var return_v = GetCompilerDiagnosticAnalyzer(languageName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 19584, 19627);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_25002_19676_19707(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 19676, 19707);
                    return return_v;
                }


                System.Type
                f_25002_19718_19736(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 19718, 19736);
                    return return_v;
                }


                string?
                f_25002_19718_19745(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 19718, 19745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerImageReference
                f_25002_19649_19746(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, string?
                display)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerImageReference(analyzers, display: display);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 19649, 19746);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 19453, 19758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 19453, 19758);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableDictionary<string, ImmutableArray<AnalyzerReference>> GetCompilerDiagnosticAnalyzerReferencesMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 19770, 20339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 19916, 20009);

                var
                builder = f_25002_19930_20008()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 20023, 20142);

                f_25002_20023_20141(builder, LanguageNames.CSharp, f_25002_20057_20140(f_25002_20079_20139(LanguageNames.CSharp)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 20156, 20285);

                f_25002_20156_20284(builder, LanguageNames.VisualBasic, f_25002_20195_20283(f_25002_20217_20282(LanguageNames.VisualBasic)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 20299, 20328);

                return f_25002_20306_20327(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 19770, 20339);

                System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AnalyzerReference>>.Builder
                f_25002_19930_20008()
                {
                    var return_v = ImmutableDictionary.CreateBuilder<string, ImmutableArray<AnalyzerReference>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 19930, 20008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerReference
                f_25002_20079_20139(string
                languageName)
                {
                    var return_v = GetCompilerDiagnosticAnalyzerReference(languageName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 20079, 20139);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AnalyzerReference>
                f_25002_20057_20140(Microsoft.CodeAnalysis.Diagnostics.AnalyzerReference
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 20057, 20140);
                    return return_v;
                }


                int
                f_25002_20023_20141(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AnalyzerReference>>.Builder
                this_param, string
                key, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AnalyzerReference>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 20023, 20141);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerReference
                f_25002_20217_20282(string
                languageName)
                {
                    var return_v = GetCompilerDiagnosticAnalyzerReference(languageName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 20217, 20282);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AnalyzerReference>
                f_25002_20195_20283(Microsoft.CodeAnalysis.Diagnostics.AnalyzerReference
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 20195, 20283);
                    return return_v;
                }


                int
                f_25002_20156_20284(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AnalyzerReference>>.Builder
                this_param, string
                key, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AnalyzerReference>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 20156, 20284);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AnalyzerReference>>
                f_25002_20306_20327(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AnalyzerReference>>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 20306, 20327);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 19770, 20339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 19770, 20339);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetExpectedErrorLogHeader(CommonCompiler compiler)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 20351, 21252);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 20449, 20495);

                var
                expectedToolName = f_25002_20472_20494(compiler)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 20509, 20561);

                var
                expectedVersion = f_25002_20531_20560(compiler)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 20575, 20659);

                var
                expectedSemanticVersion = f_25002_20605_20658(f_25002_20605_20634(compiler), fieldCount: 3)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 20673, 20729);

                var
                expectedFileVersion = f_25002_20699_20728(compiler)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 20743, 20792);

                var
                expectedLanguage = f_25002_20766_20791(compiler)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 20808, 21241);

                return f_25002_20815_21240(@"{{
  ""$schema"": ""http://json.schemastore.org/sarif-1.0.0"",
  ""version"": ""1.0.0"",
  ""runs"": [
    {{
      ""tool"": {{
        ""name"": ""{0}"",
        ""version"": ""{1}"",
        ""fileVersion"": ""{2}"",
        ""semanticVersion"": ""{3}"",
        ""language"": ""{4}""
      }},", expectedToolName, expectedVersion, expectedFileVersion, expectedSemanticVersion, expectedLanguage);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 20351, 21252);

                string
                f_25002_20472_20494(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.GetToolName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 20472, 20494);
                    return return_v;
                }


                System.Version?
                f_25002_20531_20560(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.GetAssemblyVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 20531, 20560);
                    return return_v;
                }


                System.Version?
                f_25002_20605_20634(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.GetAssemblyVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 20605, 20634);
                    return return_v;
                }


                string
                f_25002_20605_20658(System.Version?
                this_param, int
                fieldCount)
                {
                    var return_v = this_param.ToString(fieldCount: fieldCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 20605, 20658);
                    return return_v;
                }


                string
                f_25002_20699_20728(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.GetCompilerVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 20699, 20728);
                    return return_v;
                }


                string
                f_25002_20766_20791(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.GetCultureName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 20766, 20791);
                    return return_v;
                }


                string
                f_25002_20815_21240(string
                format, params object?[]
                args)
                {
                    var return_v = string.Format(format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 20815, 21240);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 20351, 21252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 20351, 21252);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string Inspect(this Diagnostic e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25002, 21325, 21493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 21328, 21493);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(25002, 21328, 21349) || ((f_25002_21328_21349(f_25002_21328_21338(e)) && DynAbs.Tracing.TraceSender.Conditional_F2(25002, 21352, 21418)) || DynAbs.Tracing.TraceSender.Conditional_F3(25002, 21437, 21493))) ? $"{f_25002_21355_21365(e)} {f_25002_21368_21372(e)}: {f_25002_21376_21416(e, f_25002_21389_21415())}" : (DynAbs.Tracing.TraceSender.Conditional_F1(25002, 21437, 21460) || ((f_25002_21437_21460(f_25002_21437_21447(e)) && DynAbs.Tracing.TraceSender.Conditional_F2(25002, 21463, 21475)) || DynAbs.Tracing.TraceSender.Conditional_F3(25002, 21478, 21493))) ? "metadata: " : "no location: "; DynAbs.Tracing.TraceSender.TraceExitMethod(25002, 21325, 21493);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 21325, 21493);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 21325, 21493);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string ToString(this Diagnostic d, IFormatProvider formatProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25002, 21506, 21715);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 21611, 21640);

                IFormattable
                formattable = d
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25002, 21654, 21704);

                return f_25002_21661_21703(formattable, null, formatProvider);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25002, 21506, 21715);

                string
                f_25002_21661_21703(System.IFormattable
                this_param, string?
                format, System.IFormatProvider
                formatProvider)
                {
                    var return_v = this_param.ToString(format, formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 21661, 21703);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25002, 21506, 21715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 21506, 21715);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DiagnosticExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25002, 737, 21722);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25002, 737, 21722);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25002, 737, 21722);
        }


        static Microsoft.CodeAnalysis.Location
        f_25002_21328_21338(Microsoft.CodeAnalysis.Diagnostic
        this_param)
        {
            var return_v = this_param.Location;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 21328, 21338);
            return return_v;
        }


        static bool
        f_25002_21328_21349(Microsoft.CodeAnalysis.Location
        this_param)
        {
            var return_v = this_param.IsInSource;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 21328, 21349);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticSeverity
        f_25002_21355_21365(Microsoft.CodeAnalysis.Diagnostic
        this_param)
        {
            var return_v = this_param.Severity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 21355, 21365);
            return return_v;
        }


        static string
        f_25002_21368_21372(Microsoft.CodeAnalysis.Diagnostic
        this_param)
        {
            var return_v = this_param.Id;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 21368, 21372);
            return return_v;
        }


        static System.Globalization.CultureInfo
        f_25002_21389_21415()
        {
            var return_v = CultureInfo.CurrentCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 21389, 21415);
            return return_v;
        }


        static string
        f_25002_21376_21416(Microsoft.CodeAnalysis.Diagnostic
        this_param, System.Globalization.CultureInfo
        formatProvider)
        {
            var return_v = this_param.GetMessage((System.IFormatProvider)formatProvider);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25002, 21376, 21416);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Location
        f_25002_21437_21447(Microsoft.CodeAnalysis.Diagnostic
        this_param)
        {
            var return_v = this_param.Location;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 21437, 21447);
            return return_v;
        }


        static bool
        f_25002_21437_21460(Microsoft.CodeAnalysis.Location
        this_param)
        {
            var return_v = this_param.IsInMetadata;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25002, 21437, 21460);
            return return_v;
        }

    }
}
