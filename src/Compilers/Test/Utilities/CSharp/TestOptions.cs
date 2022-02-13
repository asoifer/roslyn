// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Roslyn.Test.Utilities;
using Microsoft.CodeAnalysis.Emit;

namespace Microsoft.CodeAnalysis.CSharp.Test.Utilities
{
    public static class TestOptions
    {
        public static readonly CSharpParseOptions Regular;

        public static readonly CSharpParseOptions Script;

        public static readonly CSharpParseOptions Regular6;

        public static readonly CSharpParseOptions Regular7;

        public static readonly CSharpParseOptions Regular7_1;

        public static readonly CSharpParseOptions Regular7_2;

        public static readonly CSharpParseOptions Regular7_3;

        public static readonly CSharpParseOptions RegularDefault;

        public static readonly CSharpParseOptions RegularPreview;

        public static readonly CSharpParseOptions Regular8;

        public static readonly CSharpParseOptions Regular9;

        public static readonly CSharpParseOptions RegularWithDocumentationComments;

        public static readonly CSharpParseOptions RegularWithLegacyStrongName;

        public static readonly CSharpParseOptions WithoutImprovedOverloadCandidates;

        public static readonly CSharpParseOptions WithCovariantReturns;

        public static readonly CSharpParseOptions WithoutCovariantReturns;

        public static readonly CSharpParseOptions RegularWithExtendedPartialMethods;

        private static readonly SmallDictionary<string, string> s_experimentalFeatures;

        public static readonly CSharpParseOptions ExperimentalParseOptions;

        public static readonly CSharpParseOptions Regular6WithV7SwitchBinder;

        public static readonly CSharpParseOptions RegularWithoutRecursivePatterns;

        public static readonly CSharpParseOptions RegularWithRecursivePatterns;

        public static readonly CSharpParseOptions RegularWithoutPatternCombinators;

        public static readonly CSharpParseOptions RegularWithPatternCombinators;

        public static readonly CSharpCompilationOptions ReleaseDll;

        public static readonly CSharpCompilationOptions ReleaseExe;

        public static readonly CSharpCompilationOptions ReleaseDebugDll;

        public static readonly CSharpCompilationOptions ReleaseDebugExe;

        public static readonly CSharpCompilationOptions DebugDll;

        public static readonly CSharpCompilationOptions DebugExe;

        public static readonly CSharpCompilationOptions ReleaseWinMD;

        public static readonly CSharpCompilationOptions DebugWinMD;

        public static readonly CSharpCompilationOptions ReleaseModule;

        public static readonly CSharpCompilationOptions DebugModule;

        public static readonly CSharpCompilationOptions UnsafeReleaseDll;

        public static readonly CSharpCompilationOptions UnsafeReleaseExe;

        public static readonly CSharpCompilationOptions UnsafeDebugDll;

        public static readonly CSharpCompilationOptions UnsafeDebugExe;

        public static readonly CSharpCompilationOptions SigningReleaseDll;

        public static readonly CSharpCompilationOptions SigningReleaseExe;

        public static readonly CSharpCompilationOptions SigningReleaseModule;

        public static readonly CSharpCompilationOptions SigningDebugDll;

        public static readonly EmitOptions NativePdbEmit;

        public static CSharpParseOptions WithStrictFeature(this CSharpParseOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21010, 6600, 6834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 6708, 6823);

                return f_21010_6715_6822(options, f_21010_6736_6821(f_21010_6736_6752(options), new[] { f_21010_6768_6818("strict", "true") }));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21010, 6600, 6834);

                System.Collections.Generic.IReadOnlyDictionary<string, string>
                f_21010_6736_6752(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.Features;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 6736, 6752);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<string, string>
                f_21010_6768_6818(string
                key, string
                value)
                {
                    var return_v = new System.Collections.Generic.KeyValuePair<string, string>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 6768, 6818);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>
                f_21010_6736_6821(System.Collections.Generic.IReadOnlyDictionary<string, string>
                first, System.Collections.Generic.KeyValuePair<string, string>[]
                second)
                {
                    var return_v = first.Concat<System.Collections.Generic.KeyValuePair<string, string>>((System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 6736, 6821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_21010_6715_6822(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>
                features)
                {
                    var return_v = this_param.WithFeatures(features);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 6715, 6822);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 6600, 6834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 6600, 6834);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpParseOptions WithPEVerifyCompatFeature(this CSharpParseOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21010, 6846, 7097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 6962, 7086);

                return f_21010_6969_7085(options, f_21010_6990_7084(f_21010_6990_7006(options), new[] { f_21010_7022_7081("peverify-compat", "true") }));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21010, 6846, 7097);

                System.Collections.Generic.IReadOnlyDictionary<string, string>
                f_21010_6990_7006(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.Features;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 6990, 7006);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<string, string>
                f_21010_7022_7081(string
                key, string
                value)
                {
                    var return_v = new System.Collections.Generic.KeyValuePair<string, string>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 7022, 7081);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>
                f_21010_6990_7084(System.Collections.Generic.IReadOnlyDictionary<string, string>
                first, System.Collections.Generic.KeyValuePair<string, string>[]
                second)
                {
                    var return_v = first.Concat<System.Collections.Generic.KeyValuePair<string, string>>((System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 6990, 7084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_21010_6969_7085(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>
                features)
                {
                    var return_v = this_param.WithFeatures(features);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 6969, 7085);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 6846, 7097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 6846, 7097);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpParseOptions WithLocalFunctionsFeature(this CSharpParseOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21010, 7109, 7251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 7225, 7240);

                return options;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21010, 7109, 7251);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 7109, 7251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 7109, 7251);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpParseOptions WithRefsFeature(this CSharpParseOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21010, 7263, 7395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 7369, 7384);

                return options;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21010, 7263, 7395);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 7263, 7395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 7263, 7395);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpParseOptions WithTuplesFeature(this CSharpParseOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21010, 7407, 7541);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 7515, 7530);

                return options;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21010, 7407, 7541);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 7407, 7541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 7407, 7541);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpParseOptions WithNullablePublicOnly(this CSharpParseOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21010, 7553, 7726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 7666, 7715);

                return f_21010_7673_7714(options, "nullablePublicOnly");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21010, 7553, 7726);

                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_21010_7673_7714(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options, string
                feature)
                {
                    var return_v = options.WithFeature(feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 7673, 7714);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 7553, 7726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 7553, 7726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpParseOptions WithFeature(this CSharpParseOptions options, string feature, string value = "true")
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21010, 7738, 8003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 7879, 7992);

                return f_21010_7886_7991(options, f_21010_7907_7990(f_21010_7907_7923(options), new[] { f_21010_7939_7987(feature, value) }));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21010, 7738, 8003);

                System.Collections.Generic.IReadOnlyDictionary<string, string>
                f_21010_7907_7923(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.Features;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 7907, 7923);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<string, string>
                f_21010_7939_7987(string
                key, string
                value)
                {
                    var return_v = new System.Collections.Generic.KeyValuePair<string, string>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 7939, 7987);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>
                f_21010_7907_7990(System.Collections.Generic.IReadOnlyDictionary<string, string>
                first, System.Collections.Generic.KeyValuePair<string, string>[]
                second)
                {
                    var return_v = first.Concat<System.Collections.Generic.KeyValuePair<string, string>>((System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 7907, 7990);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_21010_7886_7991(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>
                features)
                {
                    var return_v = this_param.WithFeatures(features);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 7886, 7991);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 7738, 8003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 7738, 8003);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CSharpParseOptions WithExperimental(this CSharpParseOptions options, params MessageID[] features)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21010, 8015, 8843);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 8153, 8301) || true) && (f_21010_8157_8172(features) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 8153, 8301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 8211, 8286);

                    throw f_21010_8217_8285("Need at least one feature to enable");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 8153, 8301);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 8317, 8369);

                var
                list = f_21010_8328_8368()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 8383, 8757);
                    foreach (var feature in f_21010_8407_8415_I(features))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 8383, 8757);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 8449, 8486);

                        var
                        name = f_21010_8460_8485(feature)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 8504, 8667) || true) && (name == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21010, 8504, 8667);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 8562, 8648);

                            throw f_21010_8568_8647($"{feature} is not a valid experimental feature");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 8504, 8667);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 8685, 8742);

                        f_21010_8685_8741(list, f_21010_8694_8740(name, "true"));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21010, 8383, 8757);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21010, 1, 375);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21010, 1, 375);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 8773, 8832);

                return f_21010_8780_8831(options, f_21010_8801_8830(f_21010_8801_8817(options), list));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21010, 8015, 8843);

                int
                f_21010_8157_8172(Microsoft.CodeAnalysis.CSharp.MessageID[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 8157, 8172);
                    return return_v;
                }


                System.InvalidOperationException
                f_21010_8217_8285(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 8217, 8285);
                    return return_v;
                }


                System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>>
                f_21010_8328_8368()
                {
                    var return_v = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 8328, 8368);
                    return return_v;
                }


                string?
                f_21010_8460_8485(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredFeature();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 8460, 8485);
                    return return_v;
                }


                System.InvalidOperationException
                f_21010_8568_8647(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 8568, 8647);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<string, string>
                f_21010_8694_8740(string
                key, string
                value)
                {
                    var return_v = new System.Collections.Generic.KeyValuePair<string, string>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 8694, 8740);
                    return return_v;
                }


                int
                f_21010_8685_8741(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>>
                this_param, System.Collections.Generic.KeyValuePair<string, string>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 8685, 8741);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MessageID[]
                f_21010_8407_8415_I(Microsoft.CodeAnalysis.CSharp.MessageID[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 8407, 8415);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyDictionary<string, string>
                f_21010_8801_8817(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.Features;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21010, 8801, 8817);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>
                f_21010_8801_8830(System.Collections.Generic.IReadOnlyDictionary<string, string>
                first, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>>
                second)
                {
                    var return_v = first.Concat<System.Collections.Generic.KeyValuePair<string, string>>((System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 8801, 8830);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_21010_8780_8831(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>
                features)
                {
                    var return_v = this_param.WithFeatures(features);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 8780, 8831);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 8015, 8843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 8015, 8843);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpCompilationOptions WithSpecificDiagnosticOptions(this CSharpCompilationOptions options, string key, ReportDiagnostic value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21010, 8855, 9148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 9023, 9137);

                return f_21010_9030_9136(options, f_21010_9068_9135(ImmutableDictionary<string, ReportDiagnostic>.Empty, key, value));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21010, 8855, 9148);

                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_21010_9068_9135(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param, string
                key, Microsoft.CodeAnalysis.ReportDiagnostic
                value)
                {
                    var return_v = this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 9068, 9135);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_21010_9030_9136(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                values)
                {
                    var return_v = this_param.WithSpecificDiagnosticOptions(values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 9030, 9136);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 8855, 9148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 8855, 9148);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CSharpCompilationOptions WithSpecificDiagnosticOptions(this CSharpCompilationOptions options, string key1, string key2, ReportDiagnostic value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21010, 9160, 9485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 9342, 9474);

                return f_21010_9349_9473(options, f_21010_9387_9472(f_21010_9387_9455(ImmutableDictionary<string, ReportDiagnostic>.Empty, key1, value), key2, value));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21010, 9160, 9485);

                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_21010_9387_9455(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param, string
                key, Microsoft.CodeAnalysis.ReportDiagnostic
                value)
                {
                    var return_v = this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 9387, 9455);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_21010_9387_9472(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param, string
                key, Microsoft.CodeAnalysis.ReportDiagnostic
                value)
                {
                    var return_v = this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 9387, 9472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_21010_9349_9473(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                values)
                {
                    var return_v = this_param.WithSpecificDiagnosticOptions(values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 9349, 9473);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 9160, 9485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 9160, 9485);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CSharpCompilationOptions CreateTestOptions(OutputKind outputKind, OptimizationLevel optimizationLevel, bool allowUnsafe = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21010, 10303, 10452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 10306, 10452);
                return f_21010_10306_10452(outputKind, optimizationLevel: optimizationLevel, warningLevel: Diagnostic.MaxWarningLevel, allowUnsafe: allowUnsafe); DynAbs.Tracing.TraceSender.TraceExitMethod(21010, 10303, 10452);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21010, 10303, 10452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 10303, 10452);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TestOptions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21010, 467, 10460);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 557, 663);
            Regular = f_21010_567_663(kind: SourceCodeKind.Regular, documentationMode: DocumentationMode.Parse); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 716, 764);
            Script = f_21010_725_764(Regular, SourceCodeKind.Script); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 817, 880);
            Regular6 = f_21010_828_880(Regular, LanguageVersion.CSharp6); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 933, 996);
            Regular7 = f_21010_944_996(Regular, LanguageVersion.CSharp7); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1049, 1116);
            Regular7_1 = f_21010_1062_1116(Regular, LanguageVersion.CSharp7_1); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1169, 1236);
            Regular7_2 = f_21010_1182_1236(Regular, LanguageVersion.CSharp7_2); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1289, 1356);
            Regular7_3 = f_21010_1302_1356(Regular, LanguageVersion.CSharp7_3); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1409, 1478);
            RegularDefault = f_21010_1426_1478(Regular, LanguageVersion.Default); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1531, 1600);
            RegularPreview = f_21010_1548_1600(Regular, LanguageVersion.Preview); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1653, 1716);
            Regular8 = f_21010_1664_1716(Regular, LanguageVersion.CSharp8); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1769, 1832);
            Regular9 = f_21010_1780_1832(Regular, LanguageVersion.CSharp9); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 1885, 1977);
            RegularWithDocumentationComments = f_21010_1920_1977(Regular, DocumentationMode.Diagnose); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 2030, 2110);
            RegularWithLegacyStrongName = f_21010_2060_2110(Regular, "UseLegacyStrongNameProvider"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 2163, 2297);
            WithoutImprovedOverloadCandidates = f_21010_2199_2297(Regular, f_21010_2227_2292(MessageID.IDS_FeatureImprovedOverloadCandidates) - 1); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 2350, 2469);
            WithCovariantReturns = f_21010_2373_2469(Regular, f_21010_2401_2468(MessageID.IDS_FeatureCovariantReturnsForOverrides)); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 2522, 2600);
            WithoutCovariantReturns = f_21010_2548_2600(Regular, LanguageVersion.CSharp8); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 2655, 2705);
            RegularWithExtendedPartialMethods = RegularPreview; DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 2774, 2838);
            s_experimentalFeatures = f_21010_2799_2838(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 2891, 3105);
            ExperimentalParseOptions = f_21010_2931_3105(f_21010_2931_3068(kind: SourceCodeKind.Regular, documentationMode: DocumentationMode.None, languageVersion: LanguageVersion.Preview), s_experimentalFeatures); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 3436, 3557);
            Regular6WithV7SwitchBinder = f_21010_3465_3557(Regular6, new Dictionary<string, string>() { { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "testV7SwitchBinder", 21010, 3487, 3556), "true" } }); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 3612, 3656);
            RegularWithoutRecursivePatterns = Regular7_3; DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 3709, 3748);
            RegularWithRecursivePatterns = Regular8; DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 3801, 3844);
            RegularWithoutPatternCombinators = Regular8; DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 3897, 3943);
            RegularWithPatternCombinators = RegularPreview; DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4004, 4098);
            ReleaseDll = f_21010_4017_4098(OutputKind.DynamicallyLinkedLibrary, OptimizationLevel.Release); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4157, 4245);
            ReleaseExe = f_21010_4170_4245(OutputKind.ConsoleApplication, OptimizationLevel.Release); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4306, 4358);
            ReleaseDebugDll = f_21010_4324_4358(ReleaseDll, true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4419, 4471);
            ReleaseDebugExe = f_21010_4437_4471(ReleaseExe, true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4532, 4622);
            DebugDll = f_21010_4543_4622(OutputKind.DynamicallyLinkedLibrary, OptimizationLevel.Debug); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4681, 4765);
            DebugExe = f_21010_4692_4765(OutputKind.ConsoleApplication, OptimizationLevel.Debug); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4826, 4920);
            ReleaseWinMD = f_21010_4841_4920(OutputKind.WindowsRuntimeMetadata, OptimizationLevel.Release); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 4979, 5069);
            DebugWinMD = f_21010_4992_5069(OutputKind.WindowsRuntimeMetadata, OptimizationLevel.Debug); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 5130, 5212);
            ReleaseModule = f_21010_5146_5212(OutputKind.NetModule, OptimizationLevel.Release); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 5271, 5349);
            DebugModule = f_21010_5285_5349(OutputKind.NetModule, OptimizationLevel.Debug); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 5410, 5461);
            UnsafeReleaseDll = f_21010_5429_5461(ReleaseDll, true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 5520, 5571);
            UnsafeReleaseExe = f_21010_5539_5571(ReleaseExe, true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 5632, 5679);
            UnsafeDebugDll = f_21010_5649_5679(DebugDll, true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 5738, 5785);
            UnsafeDebugExe = f_21010_5755_5785(DebugExe, true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 5846, 5952);
            SigningReleaseDll = f_21010_5866_5952(ReleaseDll, SigningTestHelpers.DefaultDesktopStrongNameProvider); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 6011, 6117);
            SigningReleaseExe = f_21010_6031_6117(ReleaseExe, SigningTestHelpers.DefaultDesktopStrongNameProvider); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 6176, 6288);
            SigningReleaseModule = f_21010_6199_6288(ReleaseModule, SigningTestHelpers.DefaultDesktopStrongNameProvider); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 6347, 6449);
            SigningDebugDll = f_21010_6365_6449(DebugDll, SigningTestHelpers.DefaultDesktopStrongNameProvider); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21010, 6497, 6587);
            NativePdbEmit = f_21010_6513_6587(EmitOptions.Default, DebugInformationFormat.Pdb); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21010, 467, 10460);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21010, 467, 10460);
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        f_21010_567_663(Microsoft.CodeAnalysis.SourceCodeKind
        kind, Microsoft.CodeAnalysis.DocumentationMode
        documentationMode)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpParseOptions(kind: kind, documentationMode: documentationMode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 567, 663);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        f_21010_725_764(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        this_param, Microsoft.CodeAnalysis.SourceCodeKind
        kind)
        {
            var return_v = this_param.WithKind(kind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 725, 764);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        f_21010_828_880(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        this_param, Microsoft.CodeAnalysis.CSharp.LanguageVersion
        version)
        {
            var return_v = this_param.WithLanguageVersion(version);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 828, 880);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        f_21010_944_996(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        this_param, Microsoft.CodeAnalysis.CSharp.LanguageVersion
        version)
        {
            var return_v = this_param.WithLanguageVersion(version);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 944, 996);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        f_21010_1062_1116(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        this_param, Microsoft.CodeAnalysis.CSharp.LanguageVersion
        version)
        {
            var return_v = this_param.WithLanguageVersion(version);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1062, 1116);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        f_21010_1182_1236(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        this_param, Microsoft.CodeAnalysis.CSharp.LanguageVersion
        version)
        {
            var return_v = this_param.WithLanguageVersion(version);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1182, 1236);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        f_21010_1302_1356(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        this_param, Microsoft.CodeAnalysis.CSharp.LanguageVersion
        version)
        {
            var return_v = this_param.WithLanguageVersion(version);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1302, 1356);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        f_21010_1426_1478(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        this_param, Microsoft.CodeAnalysis.CSharp.LanguageVersion
        version)
        {
            var return_v = this_param.WithLanguageVersion(version);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1426, 1478);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        f_21010_1548_1600(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        this_param, Microsoft.CodeAnalysis.CSharp.LanguageVersion
        version)
        {
            var return_v = this_param.WithLanguageVersion(version);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1548, 1600);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        f_21010_1664_1716(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        this_param, Microsoft.CodeAnalysis.CSharp.LanguageVersion
        version)
        {
            var return_v = this_param.WithLanguageVersion(version);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1664, 1716);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        f_21010_1780_1832(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        this_param, Microsoft.CodeAnalysis.CSharp.LanguageVersion
        version)
        {
            var return_v = this_param.WithLanguageVersion(version);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1780, 1832);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        f_21010_1920_1977(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        this_param, Microsoft.CodeAnalysis.DocumentationMode
        documentationMode)
        {
            var return_v = this_param.WithDocumentationMode(documentationMode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 1920, 1977);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        f_21010_2060_2110(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        options, string
        feature)
        {
            var return_v = options.WithFeature(feature);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2060, 2110);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.LanguageVersion
        f_21010_2227_2292(Microsoft.CodeAnalysis.CSharp.MessageID
        feature)
        {
            var return_v = feature.RequiredVersion();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2227, 2292);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        f_21010_2199_2297(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        this_param, Microsoft.CodeAnalysis.CSharp.LanguageVersion
        version)
        {
            var return_v = this_param.WithLanguageVersion(version);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2199, 2297);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.LanguageVersion
        f_21010_2401_2468(Microsoft.CodeAnalysis.CSharp.MessageID
        feature)
        {
            var return_v = feature.RequiredVersion();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2401, 2468);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        f_21010_2373_2469(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        this_param, Microsoft.CodeAnalysis.CSharp.LanguageVersion
        version)
        {
            var return_v = this_param.WithLanguageVersion(version);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2373, 2469);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        f_21010_2548_2600(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        this_param, Microsoft.CodeAnalysis.CSharp.LanguageVersion
        version)
        {
            var return_v = this_param.WithLanguageVersion(version);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2548, 2600);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SmallDictionary<string, string>
        f_21010_2799_2838()
        {
            var return_v = new Microsoft.CodeAnalysis.SmallDictionary<string, string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2799, 2838);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        f_21010_2931_3068(Microsoft.CodeAnalysis.SourceCodeKind
        kind, Microsoft.CodeAnalysis.DocumentationMode
        documentationMode, Microsoft.CodeAnalysis.CSharp.LanguageVersion
        languageVersion)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpParseOptions(kind: kind, documentationMode: documentationMode, languageVersion: languageVersion);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2931, 3068);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        f_21010_2931_3105(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        this_param, Microsoft.CodeAnalysis.SmallDictionary<string, string>
        features)
        {
            var return_v = this_param.WithFeatures((System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>)features);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 2931, 3105);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        f_21010_3465_3557(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        this_param, System.Collections.Generic.Dictionary<string, string>
        features)
        {
            var return_v = this_param.WithFeatures((System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>)features);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 3465, 3557);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_21010_4017_4098(Microsoft.CodeAnalysis.OutputKind
        outputKind, Microsoft.CodeAnalysis.OptimizationLevel
        optimizationLevel)
        {
            var return_v = CreateTestOptions(outputKind, optimizationLevel);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4017, 4098);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_21010_4170_4245(Microsoft.CodeAnalysis.OutputKind
        outputKind, Microsoft.CodeAnalysis.OptimizationLevel
        optimizationLevel)
        {
            var return_v = CreateTestOptions(outputKind, optimizationLevel);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4170, 4245);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_21010_4324_4358(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, bool
        debugPlusMode)
        {
            var return_v = this_param.WithDebugPlusMode(debugPlusMode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4324, 4358);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_21010_4437_4471(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, bool
        debugPlusMode)
        {
            var return_v = this_param.WithDebugPlusMode(debugPlusMode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4437, 4471);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_21010_4543_4622(Microsoft.CodeAnalysis.OutputKind
        outputKind, Microsoft.CodeAnalysis.OptimizationLevel
        optimizationLevel)
        {
            var return_v = CreateTestOptions(outputKind, optimizationLevel);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4543, 4622);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_21010_4692_4765(Microsoft.CodeAnalysis.OutputKind
        outputKind, Microsoft.CodeAnalysis.OptimizationLevel
        optimizationLevel)
        {
            var return_v = CreateTestOptions(outputKind, optimizationLevel);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4692, 4765);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_21010_4841_4920(Microsoft.CodeAnalysis.OutputKind
        outputKind, Microsoft.CodeAnalysis.OptimizationLevel
        optimizationLevel)
        {
            var return_v = CreateTestOptions(outputKind, optimizationLevel);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4841, 4920);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_21010_4992_5069(Microsoft.CodeAnalysis.OutputKind
        outputKind, Microsoft.CodeAnalysis.OptimizationLevel
        optimizationLevel)
        {
            var return_v = CreateTestOptions(outputKind, optimizationLevel);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 4992, 5069);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_21010_5146_5212(Microsoft.CodeAnalysis.OutputKind
        outputKind, Microsoft.CodeAnalysis.OptimizationLevel
        optimizationLevel)
        {
            var return_v = CreateTestOptions(outputKind, optimizationLevel);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 5146, 5212);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_21010_5285_5349(Microsoft.CodeAnalysis.OutputKind
        outputKind, Microsoft.CodeAnalysis.OptimizationLevel
        optimizationLevel)
        {
            var return_v = CreateTestOptions(outputKind, optimizationLevel);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 5285, 5349);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_21010_5429_5461(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, bool
        enabled)
        {
            var return_v = this_param.WithAllowUnsafe(enabled);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 5429, 5461);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_21010_5539_5571(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, bool
        enabled)
        {
            var return_v = this_param.WithAllowUnsafe(enabled);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 5539, 5571);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_21010_5649_5679(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, bool
        enabled)
        {
            var return_v = this_param.WithAllowUnsafe(enabled);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 5649, 5679);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_21010_5755_5785(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, bool
        enabled)
        {
            var return_v = this_param.WithAllowUnsafe(enabled);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 5755, 5785);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_21010_5866_5952(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, Microsoft.CodeAnalysis.StrongNameProvider
        provider)
        {
            var return_v = this_param.WithStrongNameProvider(provider);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 5866, 5952);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_21010_6031_6117(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, Microsoft.CodeAnalysis.StrongNameProvider
        provider)
        {
            var return_v = this_param.WithStrongNameProvider(provider);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 6031, 6117);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_21010_6199_6288(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, Microsoft.CodeAnalysis.StrongNameProvider
        provider)
        {
            var return_v = this_param.WithStrongNameProvider(provider);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 6199, 6288);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_21010_6365_6449(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, Microsoft.CodeAnalysis.StrongNameProvider
        provider)
        {
            var return_v = this_param.WithStrongNameProvider(provider);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 6365, 6449);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Emit.EmitOptions
        f_21010_6513_6587(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
        format)
        {
            var return_v = this_param.WithDebugInformationFormat(format);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 6513, 6587);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_21010_10306_10452(Microsoft.CodeAnalysis.OutputKind
        outputKind, Microsoft.CodeAnalysis.OptimizationLevel
        optimizationLevel, int
        warningLevel, bool
        allowUnsafe)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions(outputKind, optimizationLevel: optimizationLevel, warningLevel: warningLevel, allowUnsafe: allowUnsafe);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21010, 10306, 10452);
            return return_v;
        }

    }
}

