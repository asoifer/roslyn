// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Symbols;
using Cci = Microsoft.Cci;

namespace Roslyn.Test.Utilities
{
    internal static class CompilationTestDataExtensions
    {
        internal static void VerifyIL(
                    this CompilationTestData.MethodData method,
                    string expectedIL,
                    [CallerLineNumber] int expectedValueSourceLine = 0,
                    [CallerFilePath] string expectedValueSourcePath = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25022, 738, 1662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25022, 1016, 1066);

                const string
                moduleNamePlaceholder = "{#Module#}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25022, 1080, 1118);

                string
                actualIL = GetMethodIL(method)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25022, 1132, 1441) || true) && (f_25022_1136_1177(expectedIL, moduleNamePlaceholder) >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25022, 1132, 1441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25022, 1216, 1260);

                    var
                    module = f_25022_1229_1259(method.Method)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25022, 1278, 1341);

                    var
                    moduleName = f_25022_1295_1340(f_25022_1328_1339(module))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25022, 1359, 1426);

                    expectedIL = f_25022_1372_1425(expectedIL, moduleNamePlaceholder, moduleName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25022, 1132, 1441);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25022, 1457, 1651);

                f_25022_1457_1650(expectedIL, actualIL, escapeQuotes: true, expectedValueSourcePath: expectedValueSourcePath, expectedValueSourceLine: expectedValueSourceLine);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25022, 738, 1662);

                int
                f_25022_1136_1177(string
                this_param, string
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25022, 1136, 1177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.IModuleSymbolInternal
                f_25022_1229_1259(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25022, 1229, 1259);
                    return return_v;
                }


                string
                f_25022_1328_1339(Microsoft.CodeAnalysis.Symbols.IModuleSymbolInternal
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25022, 1328, 1339);
                    return return_v;
                }


                string?
                f_25022_1295_1340(string
                path)
                {
                    var return_v = Path.GetFileNameWithoutExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25022, 1295, 1340);
                    return return_v;
                }


                string
                f_25022_1372_1425(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25022, 1372, 1425);
                    return return_v;
                }


                bool
                f_25022_1457_1650(string
                expected, string
                actual, bool
                escapeQuotes, string
                expectedValueSourcePath, int
                expectedValueSourceLine)
                {
                    var return_v = AssertEx.AssertEqualToleratingWhitespaceDifferences(expected, actual, escapeQuotes: escapeQuotes, expectedValueSourcePath: expectedValueSourcePath, expectedValueSourceLine: expectedValueSourceLine);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25022, 1457, 1650);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25022, 738, 1662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25022, 738, 1662);
            }
        }

        internal static ImmutableArray<KeyValuePair<IMethodSymbolInternal, CompilationTestData.MethodData>> GetExplicitlyDeclaredMethods(this CompilationTestData data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25022, 1674, 1948);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25022, 1858, 1937);

                return f_25022_1865_1936(f_25022_1865_1917(data.Methods, m => !m.Key.IsImplicitlyDeclared));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25022, 1674, 1948);

                System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>>
                f_25022_1865_1917(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                source, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>, bool>
                predicate)
                {
                    var return_v = source.Where<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25022, 1865, 1917);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>>
                f_25022_1865_1936(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>>
                items)
                {
                    var return_v = items.ToImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25022, 1865, 1936);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25022, 1674, 1948);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25022, 1674, 1948);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CompilationTestData.MethodData GetMethodData(this CompilationTestData data, string qualifiedMethodName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25022, 1960, 3515);
                Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData methodData = default(Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25022, 2104, 2138);

                var
                map = f_25022_2114_2137(data)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25022, 2154, 3213) || true) && (!f_25022_2159_2215(map, qualifiedMethodName, out methodData))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25022, 2154, 3213);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25022, 2352, 3198) || true) && (!f_25022_2357_2416(map, qualifiedMethodName + "()", out methodData))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25022, 2352, 3198);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25022, 2537, 2635);

                        var
                        keys = f_25022_2548_2634(f_25022_2548_2556(map), k => k.StartsWith(qualifiedMethodName + "(", StringComparison.Ordinal))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25022, 2657, 3179) || true) && (f_25022_2661_2673(keys) == 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25022, 2657, 3179);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25022, 2728, 2759);

                            methodData = f_25022_2741_2758(map, f_25022_2745_2757(keys));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25022, 2657, 3179);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25022, 2657, 3179);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25022, 2809, 3179) || true) && (f_25022_2813_2825(keys) > 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25022, 2809, 3179);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25022, 2879, 3156);

                                throw f_25022_2885_3155("Could not determine best match for method named: " + qualifiedMethodName + f_25022_3019_3038() +
                                f_25022_3070_3132(f_25022_3082_3101(), f_25022_3103_3131(keys, s => "    " + s)) + f_25022_3135_3154());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25022, 2809, 3179);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25022, 2657, 3179);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25022, 2352, 3198);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25022, 2154, 3213);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25022, 3229, 3470) || true) && (methodData.ILBuilder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25022, 3229, 3470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25022, 3295, 3455);

                    throw f_25022_3301_3454("Could not find ILBuilder matching method '" + qualifiedMethodName + "'. Existing methods:\r\n" + f_25022_3424_3453("\r\n", f_25022_3444_3452(map)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25022, 3229, 3470);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25022, 3486, 3504);

                return methodData;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25022, 1960, 3515);

                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                f_25022_2114_2137(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
                this_param)
                {
                    var return_v = this_param.GetMethodsByName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25022, 2114, 2137);
                    return return_v;
                }


                bool
                f_25022_2159_2215(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                this_param, string
                key, out Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25022, 2159, 2215);
                    return return_v;
                }


                bool
                f_25022_2357_2416(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                this_param, string
                key, out Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25022, 2357, 2416);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25022_2548_2556(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25022, 2548, 2556);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25022_2548_2634(System.Collections.Generic.IEnumerable<string>
                source, System.Func<string, bool>
                predicate)
                {
                    var return_v = source.Where<string>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25022, 2548, 2634);
                    return return_v;
                }


                int
                f_25022_2661_2673(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.Count<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25022, 2661, 2673);
                    return return_v;
                }


                string
                f_25022_2745_2757(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.First<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25022, 2745, 2757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
                f_25022_2741_2758(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25022, 2741, 2758);
                    return return_v;
                }


                int
                f_25022_2813_2825(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.Count<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25022, 2813, 2825);
                    return return_v;
                }


                string
                f_25022_3019_3038()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25022, 3019, 3038);
                    return return_v;
                }


                string
                f_25022_3082_3101()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25022, 3082, 3101);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25022_3103_3131(System.Collections.Generic.IEnumerable<string>
                source, System.Func<string, string>
                selector)
                {
                    var return_v = source.Select<string, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25022, 3103, 3131);
                    return return_v;
                }


                string
                f_25022_3070_3132(string
                separator, System.Collections.Generic.IEnumerable<string>
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25022, 3070, 3132);
                    return return_v;
                }


                string
                f_25022_3135_3154()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25022, 3135, 3154);
                    return return_v;
                }


                System.Reflection.AmbiguousMatchException
                f_25022_2885_3155(string
                message)
                {
                    var return_v = new System.Reflection.AmbiguousMatchException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25022, 2885, 3155);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25022_3444_3452(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25022, 3444, 3452);
                    return return_v;
                }


                string
                f_25022_3424_3453(string
                separator, System.Collections.Generic.IEnumerable<string>
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25022, 3424, 3453);
                    return return_v;
                }


                System.Collections.Generic.KeyNotFoundException
                f_25022_3301_3454(string
                message)
                {
                    var return_v = new System.Collections.Generic.KeyNotFoundException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25022, 3301, 3454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25022, 1960, 3515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25022, 1960, 3515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetMethodIL(this CompilationTestData.MethodData method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25022, 3527, 3704);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25022, 3630, 3693);

                return f_25022_3637_3692(method.ILBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25022, 3527, 3704);

                string
                f_25022_3637_3692(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                builder)
                {
                    var return_v = ILBuilderVisualizer.ILBuilderToString(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25022, 3637, 3692);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25022, 3527, 3704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25022, 3527, 3704);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static EditAndContinueMethodDebugInformation GetEncDebugInfo(this CompilationTestData.MethodData methodData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25022, 3716, 4208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25022, 3880, 4197);

                return f_25022_3887_4196(0, f_25022_3967_4063(f_25022_4009_4062(methodData.ILBuilder.LocalSlotManager)), closures: ImmutableArray<ClosureDebugInfo>.Empty, lambdas: ImmutableArray<LambdaDebugInfo>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25022, 3716, 4208);

                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                f_25022_4009_4062(Microsoft.CodeAnalysis.CodeGen.LocalSlotManager
                this_param)
                {
                    var return_v = this_param.LocalsInOrder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25022, 4009, 4062);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo>
                f_25022_3967_4063(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                locals)
                {
                    var return_v = Cci.MetadataWriter.GetLocalSlotDebugInfos(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25022, 3967, 4063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation
                f_25022_3887_4196(int
                methodOrdinal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo>
                localSlots, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ClosureDebugInfo>
                closures, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LambdaDebugInfo>
                lambdas)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation(methodOrdinal, localSlots, closures: closures, lambdas: lambdas);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25022, 3887, 4196);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25022, 3716, 4208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25022, 3716, 4208);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Func<MethodDefinitionHandle, EditAndContinueMethodDebugInformation> EncDebugInfoProvider(this CompilationTestData.MethodData methodData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25022, 4220, 4449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25022, 4397, 4438);

                return _ => methodData.GetEncDebugInfo();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25022, 4220, 4449);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25022, 4220, 4449);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25022, 4220, 4449);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CompilationTestDataExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25022, 670, 4456);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25022, 670, 4456);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25022, 670, 4456);
        }

    }
}
