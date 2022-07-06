// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

#if NETCOREAPP
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Test.Utilities;
using static Roslyn.Test.Utilities.RuntimeEnvironmentUtilities;

namespace Roslyn.Test.Utilities.CoreClr
{
    public class CoreCLRRuntimeEnvironment : IRuntimeEnvironment, IInternalRuntimeEnvironment
    {
        static CoreCLRRuntimeEnvironment()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25140, 725, 827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 784, 816);

                f_25140_784_815();
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25140, 725, 827);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25140, 725, 827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25140, 725, 827);
            }
        }

        private readonly IEnumerable<ModuleData> _additionalDependencies;

        private EmitData _emitData;

        private readonly CompilationTestData _testData;

        public CoreCLRRuntimeEnvironment(IEnumerable<ModuleData> additionalDependencies = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25140, 1038, 1210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 880, 903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 931, 940);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 988, 1025);
                this._testData = f_25140_1000_1025(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 1150, 1199);

                _additionalDependencies = additionalDependencies;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25140, 1038, 1210);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25140, 1038, 1210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25140, 1038, 1210);
            }
        }

        public void Emit(
                    Compilation mainCompilation,
                    IEnumerable<ResourceDescription> manifestResources,
                    EmitOptions emitOptions,
                    bool usePdbForDebugging = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25140, 1222, 3422);
                string dumpDir = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 1455, 1481);

                f_25140_1455_1480(_testData.Methods);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 1497, 1543);

                var
                diagnostics = f_25140_1515_1542()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 1557, 1599);

                var
                dependencies = f_25140_1576_1598()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 1613, 1733);

                var
                mainOutput = f_25140_1630_1732(mainCompilation, manifestResources, dependencies, diagnostics, _testData, emitOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 1749, 1776);

                _emitData = f_25140_1761_1775();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 1790, 1846);

                _emitData.Diagnostics = f_25140_1814_1845(diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 1862, 3411) || true) && (mainOutput.HasValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25140, 1862, 3411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 1919, 1961);

                    var
                    mainImage = mainOutput.Value.Assembly
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 1979, 2014);

                    var
                    mainPdb = mainOutput.Value.Pdb
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 2032, 2347);

                    _emitData.MainModule = f_25140_2055_2346(f_25140_2092_2125(f_25140_2092_2116(mainCompilation)), f_25140_2148_2182(f_25140_2148_2171(mainCompilation)), mainImage, pdb: (DynAbs.Tracing.TraceSender.Conditional_F1(25140, 2242, 2260) || ((usePdbForDebugging && DynAbs.Tracing.TraceSender.Conditional_F2(25140, 2263, 2270)) || DynAbs.Tracing.TraceSender.Conditional_F3(25140, 2273, 2302))) ? mainPdb : default(ImmutableArray<byte>), inMemoryModule: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 2365, 2399);

                    _emitData.MainModulePdb = mainPdb;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 2417, 2456);

                    _emitData.AllModuleData = dependencies;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 2809, 2865);

                    f_25140_2809_2864(
                                    // We need to add the main module so that it gets checked against already loaded assembly names.
                                    // If an assembly is loaded directly via PEVerify(image) another assembly of the same full name
                                    // can't be loaded as a dependency (via Assembly.ReflectionOnlyLoad) in the same domain.
                                    _emitData.AllModuleData, 0, _emitData.MainModule);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 2883, 2937);

                    _emitData.RuntimeData = f_25140_2907_2936(dependencies);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25140, 1862, 3411);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25140, 1862, 3411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 3003, 3051);

                    f_25140_3003_3050(dependencies, out dumpDir);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 3340, 3396);

                    throw f_25140_3346_3395(_emitData.Diagnostics, dumpDir);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25140, 1862, 3411);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25140, 1222, 3422);

                int
                f_25140_1455_1480(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 1455, 1480);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_25140_1515_1542()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 1515, 1542);
                    return return_v;
                }


                System.Collections.Generic.List<Roslyn.Test.Utilities.ModuleData>
                f_25140_1576_1598()
                {
                    var return_v = new System.Collections.Generic.List<Roslyn.Test.Utilities.ModuleData>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 1576, 1598);
                    return return_v;
                }


                Roslyn.Test.Utilities.EmitOutput?
                f_25140_1630_1732(Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                manifestResources, System.Collections.Generic.List<Roslyn.Test.Utilities.ModuleData>
                dependencies, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CodeGen.CompilationTestData
                testData, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions)
                {
                    var return_v = EmitCompilation(compilation, manifestResources, dependencies, diagnostics, testData, emitOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 1630, 1732);
                    return return_v;
                }


                Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment.EmitData
                f_25140_1761_1775()
                {
                    var return_v = new Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment.EmitData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 1761, 1775);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_25140_1814_1845(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 1814, 1845);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IAssemblySymbol
                f_25140_2092_2116(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25140, 2092, 2116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_25140_2092_2125(Microsoft.CodeAnalysis.IAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25140, 2092, 2125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_25140_2148_2171(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25140, 2148, 2171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_25140_2148_2182(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25140, 2148, 2182);
                    return return_v;
                }


                Roslyn.Test.Utilities.ModuleData
                f_25140_2055_2346(Microsoft.CodeAnalysis.AssemblyIdentity
                identity, Microsoft.CodeAnalysis.OutputKind
                kind, System.Collections.Immutable.ImmutableArray<byte>
                image, System.Collections.Immutable.ImmutableArray<byte>
                pdb, bool
                inMemoryModule)
                {
                    var return_v = new Roslyn.Test.Utilities.ModuleData(identity, kind, image, pdb: pdb, inMemoryModule: inMemoryModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 2055, 2346);
                    return return_v;
                }


                int
                f_25140_2809_2864(System.Collections.Generic.List<Roslyn.Test.Utilities.ModuleData>
                this_param, int
                index, Roslyn.Test.Utilities.ModuleData
                item)
                {
                    this_param.Insert(index, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 2809, 2864);
                    return 0;
                }


                Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment.RuntimeData
                f_25140_2907_2936(System.Collections.Generic.List<Roslyn.Test.Utilities.ModuleData>
                dependencies)
                {
                    var return_v = new Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment.RuntimeData((System.Collections.Generic.IList<Roslyn.Test.Utilities.ModuleData>)dependencies);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 2907, 2936);
                    return return_v;
                }


                string
                f_25140_3003_3050(System.Collections.Generic.List<Roslyn.Test.Utilities.ModuleData>
                modules, out string
                dumpDirectory)
                {
                    var return_v = DumpAssemblyData((System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleData>)modules, out dumpDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 3003, 3050);
                    return return_v;
                }


                Roslyn.Test.Utilities.EmitException
                f_25140_3346_3395(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, string
                directory)
                {
                    var return_v = new Roslyn.Test.Utilities.EmitException((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, directory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 3346, 3395);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25140, 1222, 3422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25140, 1222, 3422);
            }
        }

        public int Execute(string moduleName, string[] args, string expectedOutput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25140, 3434, 3977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 3534, 3563);

                var
                emitData = f_25140_3549_3562(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 3577, 3622);

                emitData.RuntimeData.ExecuteRequested = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 3636, 3736);

                var (ExitCode, Output) = f_25140_3661_3735(f_25140_3661_3681(emitData), f_25140_3690_3704(this), args, f_25140_3712_3734_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(expectedOutput, 25140, 3712, 3734)?.Length));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 3752, 3934) || true) && (expectedOutput != null && (DynAbs.Tracing.TraceSender.Expression_True(25140, 3756, 3820) && f_25140_3782_3803(expectedOutput) != f_25140_3807_3820(Output)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25140, 3752, 3934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 3854, 3919);

                    throw f_25140_3860_3918(expectedOutput, Output, moduleName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25140, 3752, 3934);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 3950, 3966);

                return ExitCode;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25140, 3434, 3977);

                Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment.EmitData
                f_25140_3549_3562(Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment
                this_param)
                {
                    var return_v = this_param.GetEmitData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 3549, 3562);
                    return return_v;
                }


                TestExecutionLoadContext
                f_25140_3661_3681(Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment.EmitData
                this_param)
                {
                    var return_v = this_param.LoadContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25140, 3661, 3681);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_25140_3690_3704(Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment
                this_param)
                {
                    var return_v = this_param.GetMainImage();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 3690, 3704);
                    return return_v;
                }


                int?
                f_25140_3712_3734_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25140, 3712, 3734);
                    return return_v;
                }


                (int ExitCode, string Output)
                f_25140_3661_3735(TestExecutionLoadContext
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                mainImage, string[]
                mainArgs, int?
                expectedOutputLength)
                {
                    var return_v = this_param.Execute(mainImage, mainArgs, expectedOutputLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 3661, 3735);
                    return return_v;
                }


                string
                f_25140_3782_3803(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 3782, 3803);
                    return return_v;
                }


                string
                f_25140_3807_3820(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 3807, 3820);
                    return return_v;
                }


                Roslyn.Test.Utilities.ExecutionException
                f_25140_3860_3918(string
                expectedOutput, string
                actualOutput, string
                exePath)
                {
                    var return_v = new Roslyn.Test.Utilities.ExecutionException(expectedOutput, actualOutput, exePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 3860, 3918);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25140, 3434, 3977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25140, 3434, 3977);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private EmitData GetEmitData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25140, 4020, 4116);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 4023, 4116);
                return _emitData ?? (DynAbs.Tracing.TraceSender.Expression_Null<Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment.EmitData>(25140, 4023, 4116) ?? throw f_25140_4042_4116("Must call Emit before calling this method")); DynAbs.Tracing.TraceSender.TraceExitMethod(25140, 4020, 4116);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25140, 4020, 4116);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25140, 4020, 4116);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.InvalidOperationException
            f_25140_4042_4116(string
            message)
            {
                var return_v = new System.InvalidOperationException(message);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 4042, 4116);
                return return_v;
            }

        }

        public IList<ModuleData> GetAllModuleData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25140, 4173, 4203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 4176, 4203);
                return f_25140_4176_4189(this).AllModuleData; DynAbs.Tracing.TraceSender.TraceExitMethod(25140, 4173, 4203);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25140, 4173, 4203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25140, 4173, 4203);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment.EmitData
            f_25140_4176_4189(Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment
            this_param)
            {
                var return_v = this_param.GetEmitData();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 4176, 4189);
                return return_v;
            }

        }

        public ImmutableArray<Diagnostic> GetDiagnostics()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25140, 4267, 4295);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 4270, 4295);
                return f_25140_4270_4283(this).Diagnostics; DynAbs.Tracing.TraceSender.TraceExitMethod(25140, 4267, 4295);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25140, 4267, 4295);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25140, 4267, 4295);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment.EmitData
            f_25140_4270_4283(Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment
            this_param)
            {
                var return_v = this_param.GetEmitData();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 4270, 4283);
                return return_v;
            }

        }

        public ImmutableArray<byte> GetMainImage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25140, 4351, 4384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 4354, 4384);
                return f_25140_4354_4367(this).MainModule.Image; DynAbs.Tracing.TraceSender.TraceExitMethod(25140, 4351, 4384);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25140, 4351, 4384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25140, 4351, 4384);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment.EmitData
            f_25140_4354_4367(Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment
            this_param)
            {
                var return_v = this_param.GetEmitData();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 4354, 4367);
                return return_v;
            }

        }

        public ImmutableArray<byte> GetMainPdb()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25140, 4438, 4468);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 4441, 4468);
                return f_25140_4441_4454(this).MainModulePdb; DynAbs.Tracing.TraceSender.TraceExitMethod(25140, 4438, 4468);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25140, 4438, 4468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25140, 4438, 4468);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment.EmitData
            f_25140_4441_4454(Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment
            this_param)
            {
                var return_v = this_param.GetEmitData();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 4441, 4454);
                return return_v;
            }

        }

        public SortedSet<string> GetMemberSignaturesFromMetadata(string fullyQualifiedTypeName, string memberName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25140, 4588, 4685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 4604, 4685);
                return f_25140_4604_4685(f_25140_4604_4617(this), fullyQualifiedTypeName, memberName); DynAbs.Tracing.TraceSender.TraceExitMethod(25140, 4588, 4685);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25140, 4588, 4685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25140, 4588, 4685);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment.EmitData
            f_25140_4604_4617(Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment
            this_param)
            {
                var return_v = this_param.GetEmitData();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 4604, 4617);
                return return_v;
            }


            System.Collections.Generic.SortedSet<string>
            f_25140_4604_4685(Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment.EmitData
            this_param, string
            fullyQualifiedTypeName, string
            memberName)
            {
                var return_v = this_param.GetMemberSignaturesFromMetadata(fullyQualifiedTypeName, memberName);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 4604, 4685);
                return return_v;
            }

        }

        public void Verify(Verification verification)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25140, 4698, 4955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 4768, 4797);

                var
                emitData = f_25140_4783_4796(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 4811, 4857);

                emitData.RuntimeData.PeverifyRequested = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25140, 4698, 4955);

                Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment.EmitData
                f_25140_4783_4796(Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironment
                this_param)
                {
                    var return_v = this_param.GetEmitData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 4783, 4796);
                    return return_v;
                }

                // TODO(https://github.com/dotnet/coreclr/issues/295): Implement peverify
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25140, 4698, 4955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25140, 4698, 4955);
            }
        }

        public string[] VerifyModules(string[] modulesToVerify)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25140, 4967, 5157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 5134, 5146);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25140, 4967, 5157);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25140, 4967, 5157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25140, 4967, 5157);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        CompilationTestData IInternalRuntimeEnvironment.GetCompilationTestData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25140, 5169, 5294);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 5266, 5283);

                return _testData;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25140, 5169, 5294);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25140, 5169, 5294);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25140, 5169, 5294);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25140, 5306, 5473);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25140, 5306, 5473);
                // We need Dispose to satisfy the IRuntimeEnvironment interface, but 
                // we don't really need it.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25140, 5306, 5473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25140, 5306, 5473);
            }
        }

        public void CaptureOutput(Action action, int expectedLength, out string output, out string errorOutput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25140, 5602, 5685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 5605, 5685);
                f_25140_5605_5685(action, expectedLength, out output, out errorOutput); DynAbs.Tracing.TraceSender.TraceExitMethod(25140, 5602, 5685);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25140, 5602, 5685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25140, 5602, 5685);
            }

            int
            f_25140_5605_5685(System.Action
            action, int
            expectedLength, out string
            output, out string
            errorOutput)
            {
                SharedConsole.CaptureOutput(action, expectedLength, out output, out errorOutput);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 5605, 5685);
                return 0;
            }

        }
        private sealed class RuntimeData
        {
            internal TestExecutionLoadContext LoadContext { get; }

            internal bool PeverifyRequested { get; set; }

            internal bool ExecuteRequested { get; set; }

            internal bool Disposed { get; set; }

            internal int ConflictCount { get; set; }

            public RuntimeData(IList<ModuleData> dependencies)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(25140, 6046, 6201);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 5755, 5809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 5823, 5868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 5882, 5926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 5940, 5976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 5990, 6030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 6129, 6186);

                    LoadContext = f_25140_6143_6185(dependencies);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(25140, 6046, 6201);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25140, 6046, 6201);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25140, 6046, 6201);
                }
            }

            static RuntimeData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25140, 5698, 6212);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25140, 5698, 6212);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25140, 5698, 6212);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25140, 5698, 6212);

            static TestExecutionLoadContext
            f_25140_6143_6185(System.Collections.Generic.IList<Roslyn.Test.Utilities.ModuleData>
            dependencies)
            {
                var return_v = new TestExecutionLoadContext(dependencies);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 6143, 6185);
                return return_v;
            }

        }
        private sealed class EmitData
        {
            internal RuntimeData RuntimeData;

            internal TestExecutionLoadContext LoadContext
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25140, 6373, 6400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 6376, 6400);
                        return f_25140_6376_6400_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(RuntimeData, 25140, 6376, 6400)?.LoadContext); DynAbs.Tracing.TraceSender.TraceExitMethod(25140, 6373, 6400);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25140, 6373, 6400);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25140, 6373, 6400);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal List<ModuleData> AllModuleData;

            internal ModuleData MainModule;

            internal ImmutableArray<byte> MainModulePdb;

            internal ImmutableArray<Diagnostic> Diagnostics;

            public SortedSet<string> GetMemberSignaturesFromMetadata(string fullyQualifiedTypeName, string memberName)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25140, 6758, 7032);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 6897, 7017);

                    return f_25140_6904_7016(f_25140_6904_6915(), fullyQualifiedTypeName, memberName, f_25140_6984_7015(AllModuleData, x => x.Id));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25140, 6758, 7032);

                    TestExecutionLoadContext
                    f_25140_6904_6915()
                    {
                        var return_v = LoadContext;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25140, 6904, 6915);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleDataId>
                    f_25140_6984_7015(System.Collections.Generic.List<Roslyn.Test.Utilities.ModuleData>
                    source, System.Func<Roslyn.Test.Utilities.ModuleData, Roslyn.Test.Utilities.ModuleDataId>
                    selector)
                    {
                        var return_v = source.Select<Roslyn.Test.Utilities.ModuleData, Roslyn.Test.Utilities.ModuleDataId>(selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 6984, 7015);
                        return return_v;
                    }


                    System.Collections.Generic.SortedSet<string>
                    f_25140_6904_7016(TestExecutionLoadContext
                    this_param, string
                    fullyQualifiedTypeName, string
                    memberName, System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleDataId>
                    searchModules)
                    {
                        var return_v = this_param.GetMemberSignaturesFromMetadata(fullyQualifiedTypeName, memberName, searchModules);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 6904, 7016);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25140, 6758, 7032);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25140, 6758, 7032);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public EmitData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25140, 6224, 7043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 6299, 6310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 6517, 6530);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25140, 6609, 6619);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25140, 6224, 7043);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25140, 6224, 7043);
            }


            static EmitData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25140, 6224, 7043);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25140, 6224, 7043);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25140, 6224, 7043);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25140, 6224, 7043);

            TestExecutionLoadContext?
            f_25140_6376_6400_M(TestExecutionLoadContext?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25140, 6376, 6400);
                return return_v;
            }

        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25140, 619, 7050);

        static int
        f_25140_784_815()
        {
            SharedConsole.OverrideConsole();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 784, 815);
            return 0;
        }


        Microsoft.CodeAnalysis.CodeGen.CompilationTestData
        f_25140_1000_1025()
        {
            var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25140, 1000, 1025);
            return return_v;
        }

    }
}
#endif
