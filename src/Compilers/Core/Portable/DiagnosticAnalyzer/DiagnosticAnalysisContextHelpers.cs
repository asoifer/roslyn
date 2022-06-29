// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Microsoft.CodeAnalysis.Operations;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal static class DiagnosticAnalysisContextHelpers
    {
        internal static void VerifyArguments<TContext>(Action<TContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(257, 615, 743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 711, 732);

                f_257_711_731(action);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(257, 615, 743);

                int
                f_257_711_731(System.Action<TContext>
                action)
                {
                    VerifyAction(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 711, 731);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(257, 615, 743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(257, 615, 743);
            }
        }

        internal static void VerifyArguments<TContext>(Action<TContext> action, ImmutableArray<SymbolKind> symbolKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(257, 755, 968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 891, 912);

                f_257_891_911(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 926, 957);

                f_257_926_956(symbolKinds);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(257, 755, 968);

                int
                f_257_891_911(System.Action<TContext>
                action)
                {
                    VerifyAction(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 891, 911);
                    return 0;
                }


                int
                f_257_926_956(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolKind>
                symbolKinds)
                {
                    VerifySymbolKinds(symbolKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 926, 956);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(257, 755, 968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(257, 755, 968);
            }
        }

        internal static void VerifyArguments<TContext, TLanguageKindEnum>(Action<TContext> action, ImmutableArray<TLanguageKindEnum> syntaxKinds)
                    where TLanguageKindEnum : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(257, 980, 1265);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 1188, 1209);

                f_257_1188_1208(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 1223, 1254);

                f_257_1223_1253(syntaxKinds);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(257, 980, 1265);

                int
                f_257_1188_1208(System.Action<TContext>
                action)
                {
                    VerifyAction(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 1188, 1208);
                    return 0;
                }


                int
                f_257_1223_1253(System.Collections.Immutable.ImmutableArray<TLanguageKindEnum>
                syntaxKinds)
                {
                    VerifySyntaxKinds(syntaxKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 1223, 1253);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(257, 980, 1265);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(257, 980, 1265);
            }
        }

        internal static void VerifyArguments<TContext>(Action<TContext> action, ImmutableArray<OperationKind> operationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(257, 1277, 1502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 1419, 1440);

                f_257_1419_1439(action);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 1454, 1491);

                f_257_1454_1490(operationKinds);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(257, 1277, 1502);

                int
                f_257_1419_1439(System.Action<TContext>
                action)
                {
                    VerifyAction(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 1419, 1439);
                    return 0;
                }


                int
                f_257_1454_1490(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind>
                operationKinds)
                {
                    VerifyOperationKinds(operationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 1454, 1490);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(257, 1277, 1502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(257, 1277, 1502);
            }
        }

        internal static void VerifyArguments(Diagnostic diagnostic, Compilation? compilation, Func<Diagnostic, bool> isSupportedDiagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(257, 1514, 2902);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 1670, 1821) || true) && (diagnostic is DiagnosticWithInfo)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(257, 1670, 1821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 1799, 1806);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(257, 1670, 1821);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 1837, 1960) || true) && (diagnostic == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(257, 1837, 1960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 1893, 1945);

                    throw f_257_1899_1944(nameof(diagnostic));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(257, 1837, 1960);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 1976, 2112) || true) && (compilation != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(257, 1976, 2112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 2033, 2097);

                    f_257_2033_2096(diagnostic, compilation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(257, 1976, 2112);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 2128, 2346) || true) && (!f_257_2133_2166(isSupportedDiagnostic, diagnostic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(257, 2128, 2346);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 2200, 2331);

                    throw f_257_2206_2330(f_257_2228_2309(f_257_2242_2293(), f_257_2295_2308(diagnostic)), nameof(diagnostic));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(257, 2128, 2346);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 2362, 2891) || true) && (!f_257_2367_2425(f_257_2411_2424(diagnostic)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(257, 2362, 2891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 2747, 2876);

                    throw f_257_2753_2875(f_257_2775_2854(f_257_2789_2838(), f_257_2840_2853(diagnostic)), nameof(diagnostic));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(257, 2362, 2891);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(257, 1514, 2902);

                System.ArgumentNullException
                f_257_1899_1944(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 1899, 1944);
                    return return_v;
                }


                int
                f_257_2033_2096(Microsoft.CodeAnalysis.Diagnostic
                diagnostic, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    VerifyDiagnosticLocationsInCompilation(diagnostic, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 2033, 2096);
                    return 0;
                }


                bool
                f_257_2133_2166(System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 2133, 2166);
                    return return_v;
                }


                string
                f_257_2242_2293()
                {
                    var return_v = CodeAnalysisResources.UnsupportedDiagnosticReported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 2242, 2293);
                    return return_v;
                }


                string
                f_257_2295_2308(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 2295, 2308);
                    return return_v;
                }


                string
                f_257_2228_2309(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 2228, 2309);
                    return return_v;
                }


                System.ArgumentException
                f_257_2206_2330(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 2206, 2330);
                    return return_v;
                }


                string
                f_257_2411_2424(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 2411, 2424);
                    return return_v;
                }


                bool
                f_257_2367_2425(string
                name)
                {
                    var return_v = UnicodeCharacterUtilities.IsValidIdentifier(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 2367, 2425);
                    return return_v;
                }


                string
                f_257_2789_2838()
                {
                    var return_v = CodeAnalysisResources.InvalidDiagnosticIdReported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 2789, 2838);
                    return return_v;
                }


                string
                f_257_2840_2853(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 2840, 2853);
                    return return_v;
                }


                string
                f_257_2775_2854(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 2775, 2854);
                    return return_v;
                }


                System.ArgumentException
                f_257_2753_2875(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 2753, 2875);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(257, 1514, 2902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(257, 1514, 2902);
            }
        }

        internal static void VerifyDiagnosticLocationsInCompilation(Diagnostic diagnostic, Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(257, 2914, 3454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 3046, 3133);

                f_257_3046_3132(f_257_3084_3097(diagnostic), f_257_3099_3118(diagnostic), compilation);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 3149, 3443) || true) && (f_257_3153_3183(diagnostic) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(257, 3149, 3443);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 3225, 3428);
                        foreach (var location in f_257_3250_3280_I(f_257_3250_3280(diagnostic)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(257, 3225, 3428);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 3322, 3409);

                            f_257_3322_3408(f_257_3360_3373(diagnostic), f_257_3375_3394(diagnostic), compilation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(257, 3225, 3428);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(257, 1, 204);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(257, 1, 204);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(257, 3149, 3443);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(257, 2914, 3454);

                string
                f_257_3084_3097(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 3084, 3097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_257_3099_3118(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 3099, 3118);
                    return return_v;
                }


                int
                f_257_3046_3132(string
                id, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    VerifyDiagnosticLocationInCompilation(id, location, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 3046, 3132);
                    return 0;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                f_257_3153_3183(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.AdditionalLocations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 3153, 3183);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                f_257_3250_3280(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.AdditionalLocations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 3250, 3280);
                    return return_v;
                }


                string
                f_257_3360_3373(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 3360, 3373);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_257_3375_3394(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 3375, 3394);
                    return return_v;
                }


                int
                f_257_3322_3408(string
                id, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    VerifyDiagnosticLocationInCompilation(id, location, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 3322, 3408);
                    return 0;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                f_257_3250_3280_I(System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 3250, 3280);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(257, 2914, 3454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(257, 2914, 3454);
            }
        }

        private static void VerifyDiagnosticLocationInCompilation(string id, Location location, Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(257, 3466, 4483);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 3603, 3683) || true) && (f_257_3607_3627_M(!location.IsInSource))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(257, 3603, 3683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 3661, 3668);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(257, 3603, 3683);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 3699, 3741);

                f_257_3699_3740(f_257_3712_3731(location) != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 3755, 4097) || true) && (!f_257_3760_3811(compilation, f_257_3791_3810(location)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(257, 3755, 4097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 3934, 4082);

                    throw f_257_3940_4081(f_257_3962_4066(f_257_3976_4031(), id, f_257_4037_4065(f_257_4037_4056(location))), "diagnostic");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(257, 3755, 4097);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 4113, 4472) || true) && (location.SourceSpan.End > f_257_4143_4169(f_257_4143_4162(location)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(257, 4113, 4472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 4292, 4457);

                    throw f_257_4298_4456(f_257_4320_4441(f_257_4334_4385(), id, f_257_4391_4410(location), f_257_4412_4440(f_257_4412_4431(location))), "diagnostic");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(257, 4113, 4472);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(257, 3466, 4483);

                bool
                f_257_3607_3627_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 3607, 3627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_257_3712_3731(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 3712, 3731);
                    return return_v;
                }


                int
                f_257_3699_3740(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 3699, 3740);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_257_3791_3810(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 3791, 3810);
                    return return_v;
                }


                bool
                f_257_3760_3811(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.ContainsSyntaxTree(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 3760, 3811);
                    return return_v;
                }


                string
                f_257_3976_4031()
                {
                    var return_v = CodeAnalysisResources.InvalidDiagnosticLocationReported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 3976, 4031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_257_4037_4056(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 4037, 4056);
                    return return_v;
                }


                string
                f_257_4037_4065(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 4037, 4065);
                    return return_v;
                }


                string
                f_257_3962_4066(string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 3962, 4066);
                    return return_v;
                }


                System.ArgumentException
                f_257_3940_4081(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 3940, 4081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_257_4143_4162(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 4143, 4162);
                    return return_v;
                }


                int
                f_257_4143_4169(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 4143, 4169);
                    return return_v;
                }


                string
                f_257_4334_4385()
                {
                    var return_v = CodeAnalysisResources.InvalidDiagnosticSpanReported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 4334, 4385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_257_4391_4410(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 4391, 4410);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_257_4412_4431(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 4412, 4431);
                    return return_v;
                }


                string
                f_257_4412_4440(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 4412, 4440);
                    return return_v;
                }


                string
                f_257_4320_4441(string
                format, string
                arg0, Microsoft.CodeAnalysis.Text.TextSpan
                arg1, string
                arg2)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 4320, 4441);
                    return return_v;
                }


                System.ArgumentException
                f_257_4298_4456(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 4298, 4456);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(257, 3466, 4483);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(257, 3466, 4483);
            }
        }

        private static void VerifyAction<TContext>(Action<TContext> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(257, 4495, 5116);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 4587, 4702) || true) && (action == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(257, 4587, 4702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 4639, 4687);

                    throw f_257_4645_4686(nameof(action));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(257, 4587, 4702);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 4878, 5105) || true) && (f_257_4882_4951(f_257_4882_4904(action)!, typeof(AsyncStateMachineAttribute)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(257, 4878, 5105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 4985, 5090);

                    throw f_257_4991_5089(f_257_5013_5072(), nameof(action));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(257, 4878, 5105);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(257, 4495, 5116);

                System.ArgumentNullException
                f_257_4645_4686(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 4645, 4686);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_257_4882_4904(System.Action<TContext>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 4882, 4904);
                    return return_v;
                }


                bool
                f_257_4882_4951(System.Reflection.MethodInfo
                element, System.Type
                attributeType)
                {
                    var return_v = element.IsDefined(attributeType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 4882, 4951);
                    return return_v;
                }


                string
                f_257_5013_5072()
                {
                    var return_v = CodeAnalysisResources.AsyncAnalyzerActionCannotBeRegistered;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 5013, 5072);
                    return return_v;
                }


                System.ArgumentException
                f_257_4991_5089(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 4991, 5089);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(257, 4495, 5116);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(257, 4495, 5116);
            }
        }

        private static void VerifySymbolKinds(ImmutableArray<SymbolKind> symbolKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(257, 5128, 5550);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 5230, 5357) || true) && (symbolKinds.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(257, 5230, 5357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 5289, 5342);

                    throw f_257_5295_5341(nameof(symbolKinds));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(257, 5230, 5357);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 5373, 5539) || true) && (symbolKinds.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(257, 5373, 5539);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 5430, 5524);

                    throw f_257_5436_5523(f_257_5458_5501(), nameof(symbolKinds));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(257, 5373, 5539);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(257, 5128, 5550);

                System.ArgumentNullException
                f_257_5295_5341(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 5295, 5341);
                    return return_v;
                }


                string
                f_257_5458_5501()
                {
                    var return_v = CodeAnalysisResources.ArgumentCannotBeEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 5458, 5501);
                    return return_v;
                }


                System.ArgumentException
                f_257_5436_5523(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 5436, 5523);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(257, 5128, 5550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(257, 5128, 5550);
            }
        }

        private static void VerifySyntaxKinds<TLanguageKindEnum>(ImmutableArray<TLanguageKindEnum> syntaxKinds)
                    where TLanguageKindEnum : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(257, 5562, 6056);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 5736, 5863) || true) && (syntaxKinds.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(257, 5736, 5863);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 5795, 5848);

                    throw f_257_5801_5847(nameof(syntaxKinds));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(257, 5736, 5863);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 5879, 6045) || true) && (syntaxKinds.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(257, 5879, 6045);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 5936, 6030);

                    throw f_257_5942_6029(f_257_5964_6007(), nameof(syntaxKinds));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(257, 5879, 6045);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(257, 5562, 6056);

                System.ArgumentNullException
                f_257_5801_5847(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 5801, 5847);
                    return return_v;
                }


                string
                f_257_5964_6007()
                {
                    var return_v = CodeAnalysisResources.ArgumentCannotBeEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 5964, 6007);
                    return return_v;
                }


                System.ArgumentException
                f_257_5942_6029(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 5942, 6029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(257, 5562, 6056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(257, 5562, 6056);
            }
        }

        private static void VerifyOperationKinds(ImmutableArray<OperationKind> operationKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(257, 6068, 6511);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 6179, 6312) || true) && (operationKinds.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(257, 6179, 6312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 6241, 6297);

                    throw f_257_6247_6296(nameof(operationKinds));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(257, 6179, 6312);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 6328, 6500) || true) && (operationKinds.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(257, 6328, 6500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 6388, 6485);

                    throw f_257_6394_6484(f_257_6416_6459(), nameof(operationKinds));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(257, 6328, 6500);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(257, 6068, 6511);

                System.ArgumentNullException
                f_257_6247_6296(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 6247, 6296);
                    return return_v;
                }


                string
                f_257_6416_6459()
                {
                    var return_v = CodeAnalysisResources.ArgumentCannotBeEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(257, 6416, 6459);
                    return return_v;
                }


                System.ArgumentException
                f_257_6394_6484(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 6394, 6484);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(257, 6068, 6511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(257, 6068, 6511);
            }
        }

        internal static void VerifyArguments<TKey, TValue>(TKey key, AnalysisValueProvider<TKey, TValue> valueProvider)
                    where TKey : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(257, 6523, 6956);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 6691, 6800) || true) && (key == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(257, 6691, 6800);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 6740, 6785);

                    throw f_257_6746_6784(nameof(key));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(257, 6691, 6800);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 6816, 6945) || true) && (valueProvider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(257, 6816, 6945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 6875, 6930);

                    throw f_257_6881_6929(nameof(valueProvider));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(257, 6816, 6945);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(257, 6523, 6956);

                System.ArgumentNullException
                f_257_6746_6784(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 6746, 6784);
                    return return_v;
                }


                System.ArgumentNullException
                f_257_6881_6929(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 6881, 6929);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(257, 6523, 6956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(257, 6523, 6956);
            }
        }

        internal static ControlFlowGraph GetControlFlowGraph(IOperation operation, Func<IOperation, ControlFlowGraph>? getControlFlowGraph, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(257, 6968, 7435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 7161, 7217);

                IOperation
                rootOperation = f_257_7188_7216(operation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(257, 7231, 7424);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(257, 7238, 7265) || ((getControlFlowGraph != null && DynAbs.Tracing.TraceSender.Conditional_F2(257, 7285, 7319)) || DynAbs.Tracing.TraceSender.Conditional_F3(257, 7339, 7423))) ? f_257_7285_7319(getControlFlowGraph, rootOperation) : f_257_7339_7423(rootOperation, nameof(rootOperation), cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(257, 6968, 7435);

                Microsoft.CodeAnalysis.IOperation
                f_257_7188_7216(Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = operation.GetRootOperation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 7188, 7216);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_257_7285_7319(System.Func<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                this_param, Microsoft.CodeAnalysis.IOperation
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 7285, 7319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_257_7339_7423(Microsoft.CodeAnalysis.IOperation
                operation, string
                argumentNameForException, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = ControlFlowGraph.CreateCore(operation, argumentNameForException, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(257, 7339, 7423);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(257, 6968, 7435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(257, 6968, 7435);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DiagnosticAnalysisContextHelpers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(257, 544, 7442);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(257, 544, 7442);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(257, 544, 7442);
        }

    }
}
