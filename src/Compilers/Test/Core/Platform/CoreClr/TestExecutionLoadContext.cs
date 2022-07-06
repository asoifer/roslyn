// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

#if NETCOREAPP
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.Loader;
using System.Text;
using Roslyn.Test.Utilities;
using Roslyn.Utilities;

namespace Roslyn.Test.Utilities.CoreClr
{
    internal sealed class TestExecutionLoadContext : AssemblyLoadContext
    {
        private readonly ImmutableDictionary<string, ModuleData> _dependencies;

        public TestExecutionLoadContext(IList<ModuleData> dependencies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25143, 864, 1055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 838, 851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 952, 1044);

                _dependencies = f_25143_968_1043(dependencies, d => d.FullName, f_25143_1020_1042());
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25143, 864, 1055);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25143, 864, 1055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25143, 864, 1055);
            }
        }

        protected override Assembly Load(AssemblyName assemblyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25143, 1067, 1893);
                Roslyn.Test.Utilities.ModuleData moduleData = default(Roslyn.Test.Utilities.ModuleData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 1151, 1199);

                var
                comparer = f_25143_1166_1198()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 1213, 1265);

                var
                comparison = StringComparison.OrdinalIgnoreCase
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 1279, 1672) || true) && (f_25143_1283_1334(f_25143_1283_1300(assemblyName), "System.", comparison) || (DynAbs.Tracing.TraceSender.Expression_False(25143, 1283, 1409) || f_25143_1355_1409(f_25143_1355_1372(assemblyName), "Microsoft.", comparison)) || (DynAbs.Tracing.TraceSender.Expression_False(25143, 1283, 1476) || f_25143_1430_1476(comparer, f_25143_1446_1463(assemblyName), "mscorlib")) || (DynAbs.Tracing.TraceSender.Expression_False(25143, 1283, 1541) || f_25143_1497_1541(comparer, f_25143_1513_1530(assemblyName), "System")) || (DynAbs.Tracing.TraceSender.Expression_False(25143, 1283, 1611) || f_25143_1562_1611(comparer, f_25143_1578_1595(assemblyName), "netstandard")))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25143, 1279, 1672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 1645, 1657);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25143, 1279, 1672);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 1688, 1854) || true) && (f_25143_1692_1760(_dependencies, f_25143_1718_1739(assemblyName), out moduleData))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25143, 1688, 1854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 1794, 1839);

                    return f_25143_1801_1838(this, moduleData.Image);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25143, 1688, 1854);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 1870, 1882);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25143, 1067, 1893);

                System.StringComparer
                f_25143_1166_1198()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25143, 1166, 1198);
                    return return_v;
                }


                string?
                f_25143_1283_1300(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25143, 1283, 1300);
                    return return_v;
                }


                bool
                f_25143_1283_1334(string?
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25143, 1283, 1334);
                    return return_v;
                }


                string
                f_25143_1355_1372(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25143, 1355, 1372);
                    return return_v;
                }


                bool
                f_25143_1355_1409(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25143, 1355, 1409);
                    return return_v;
                }


                string
                f_25143_1446_1463(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25143, 1446, 1463);
                    return return_v;
                }


                bool
                f_25143_1430_1476(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25143, 1430, 1476);
                    return return_v;
                }


                string
                f_25143_1513_1530(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25143, 1513, 1530);
                    return return_v;
                }


                bool
                f_25143_1497_1541(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25143, 1497, 1541);
                    return return_v;
                }


                string
                f_25143_1578_1595(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25143, 1578, 1595);
                    return return_v;
                }


                bool
                f_25143_1562_1611(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25143, 1562, 1611);
                    return return_v;
                }


                string
                f_25143_1718_1739(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25143, 1718, 1739);
                    return return_v;
                }


                bool
                f_25143_1692_1760(System.Collections.Immutable.ImmutableDictionary<string, Roslyn.Test.Utilities.ModuleData>
                this_param, string
                key, out Roslyn.Test.Utilities.ModuleData
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25143, 1692, 1760);
                    return return_v;
                }


                System.Reflection.Assembly
                f_25143_1801_1838(Roslyn.Test.Utilities.CoreClr.TestExecutionLoadContext
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                mainImage)
                {
                    var return_v = this_param.LoadImageAsAssembly(mainImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25143, 1801, 1838);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25143, 1067, 1893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25143, 1067, 1893);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Assembly LoadImageAsAssembly(ImmutableArray<byte> mainImage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25143, 1905, 2161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 1998, 2150);
                using (var
                assemblyStream = f_25143_2026_2063(mainImage.ToArray())
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 2097, 2135);

                    return f_25143_2104_2134(this, assemblyStream);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(25143, 1998, 2150);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25143, 1905, 2161);

                System.IO.MemoryStream
                f_25143_2026_2063(byte[]
                buffer)
                {
                    var return_v = new System.IO.MemoryStream(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25143, 2026, 2063);
                    return return_v;
                }


                System.Reflection.Assembly
                f_25143_2104_2134(Roslyn.Test.Utilities.CoreClr.TestExecutionLoadContext
                this_param, System.IO.MemoryStream
                assembly)
                {
                    var return_v = this_param.LoadFromStream((System.IO.Stream)assembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25143, 2104, 2134);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25143, 1905, 2161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25143, 1905, 2161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal (int ExitCode, string Output) Execute(ImmutableArray<byte> mainImage, string[] mainArgs, int? expectedOutputLength)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25143, 2173, 3419);
                string stdOut = default(string);
                string stdErr = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 2322, 2372);

                var
                mainAssembly = f_25143_2341_2371(this, mainImage)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 2386, 2427);

                var
                entryPoint = f_25143_2403_2426(mainAssembly)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 2443, 2571);

                f_25143_2443_2570(entryPoint, "Attempting to execute an assembly that has no entrypoint; is your test trying to execute a DLL?");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 2587, 2604);

                int
                exitCode = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 2618, 3323);

                f_25143_2618_3322(() =>
                            {
                                var count = entryPoint.GetParameters().Length;
                                object[] args;
                                if (count == 0)
                                {
                                    args = Array.Empty<object>();
                                }
                                else if (count == 1)
                                {
                                    args = new[] { mainArgs ?? Array.Empty<string>() };
                                }
                                else
                                {
                                    throw new Exception("Unrecognized entry point");
                                }

                                exitCode = entryPoint.Invoke(null, args) is int exit ? exit : 0;
                            }, expectedOutputLength ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(25143, 3264, 3289) ?? 0), out stdOut, out stdErr);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 3339, 3368);

                var
                output = stdOut + stdErr
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 3382, 3408);

                return (exitCode, output);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25143, 2173, 3419);

                System.Reflection.Assembly
                f_25143_2341_2371(Roslyn.Test.Utilities.CoreClr.TestExecutionLoadContext
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                mainImage)
                {
                    var return_v = this_param.LoadImageAsAssembly(mainImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25143, 2341, 2371);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_25143_2403_2426(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.EntryPoint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25143, 2403, 2426);
                    return return_v;
                }


                int
                f_25143_2443_2570(System.Reflection.MethodInfo?
                @object, string
                message)
                {
                    AssertEx.NotNull(@object, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25143, 2443, 2570);
                    return 0;
                }


                int
                f_25143_2618_3322(System.Action
                action, int
                expectedLength, out string
                output, out string
                errorOutput)
                {
                    SharedConsole.CaptureOutput(action, expectedLength, out output, out errorOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25143, 2618, 3322);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25143, 2173, 3419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25143, 2173, 3419);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SortedSet<string> GetMemberSignaturesFromMetadata(string fullyQualifiedTypeName, string memberName, IEnumerable<ModuleDataId> searchModules)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25143, 3431, 4367);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 3639, 3680);

                    var
                    signatures = f_25143_3656_3679()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 3698, 4132);
                        foreach (var id in f_25143_3717_3730_I(searchModules))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25143, 3698, 4132);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 3772, 3813);

                            var
                            name = f_25143_3783_3812(id.FullName)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 3835, 3877);

                            var
                            assembly = f_25143_3850_3876(this, name)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 3899, 4113);
                                foreach (var signature in f_25143_3925_4014_I(f_25143_3925_4014(assembly, fullyQualifiedTypeName, memberName)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25143, 3899, 4113);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 4064, 4090);

                                    f_25143_4064_4089(signatures, signature);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25143, 3899, 4113);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(25143, 1, 215);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(25143, 1, 215);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25143, 3698, 4132);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25143, 1, 435);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25143, 1, 435);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 4150, 4168);

                    return signatures;
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(25143, 4197, 4356);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25143, 4250, 4341);

                    throw f_25143_4256_4340($"Error getting signatures {fullyQualifiedTypeName}.{memberName}", ex);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(25143, 4197, 4356);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25143, 3431, 4367);

                System.Collections.Generic.SortedSet<string>
                f_25143_3656_3679()
                {
                    var return_v = new System.Collections.Generic.SortedSet<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25143, 3656, 3679);
                    return return_v;
                }


                System.Reflection.AssemblyName
                f_25143_3783_3812(string
                assemblyName)
                {
                    var return_v = new System.Reflection.AssemblyName(assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25143, 3783, 3812);
                    return return_v;
                }


                System.Reflection.Assembly
                f_25143_3850_3876(Roslyn.Test.Utilities.CoreClr.TestExecutionLoadContext
                this_param, System.Reflection.AssemblyName
                assemblyName)
                {
                    var return_v = this_param.LoadFromAssemblyName(assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25143, 3850, 3876);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25143_3925_4014(System.Reflection.Assembly
                assembly, string
                fullyQualifiedTypeName, string
                memberName)
                {
                    var return_v = MetadataSignatureHelper.GetMemberSignatures(assembly, fullyQualifiedTypeName, memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25143, 3925, 4014);
                    return return_v;
                }


                bool
                f_25143_4064_4089(System.Collections.Generic.SortedSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25143, 4064, 4089);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25143_3925_4014_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25143, 3925, 4014);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleDataId>
                f_25143_3717_3730_I(System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleDataId>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25143, 3717, 3730);
                    return return_v;
                }


                System.Exception
                f_25143_4256_4340(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.Exception(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25143, 4256, 4340);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25143, 3431, 4367);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25143, 3431, 4367);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TestExecutionLoadContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25143, 696, 4374);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25143, 696, 4374);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25143, 696, 4374);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25143, 696, 4374);

        static System.StringComparer
        f_25143_1020_1042()
        {
            var return_v = StringComparer.Ordinal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25143, 1020, 1042);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableDictionary<string, Roslyn.Test.Utilities.ModuleData>
        f_25143_968_1043(System.Collections.Generic.IList<Roslyn.Test.Utilities.ModuleData>
        source, System.Func<Roslyn.Test.Utilities.ModuleData, string>
        keySelector, System.StringComparer
        keyComparer)
        {
            var return_v = source.ToImmutableDictionary<Roslyn.Test.Utilities.ModuleData, string>(keySelector, (System.Collections.Generic.IEqualityComparer<string>)keyComparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25143, 968, 1043);
            return return_v;
        }

    }
}
#endif
