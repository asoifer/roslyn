// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using ICSharpCode.Decompiler.Metadata;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.DiaSymReader.Tools;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    public sealed class CompilationVerifier
    {
        private readonly Compilation _compilation;

        private CompilationTestData _testData;

        private readonly IEnumerable<ModuleData> _dependencies;

        private ImmutableArray<Diagnostic> _diagnostics;

        private IModuleSymbol _lazyModuleSymbol;

        private IList<ModuleData> _allModuleData;

        public ImmutableArray<byte> EmittedAssemblyData;

        public ImmutableArray<byte> EmittedAssemblyPdb;

        private readonly Func<IModuleSymbol, CompilationTestData.MethodData, IReadOnlyDictionary<int, string>, bool, string> _visualizeRealIL;

        internal CompilationVerifier(
                    Compilation compilation,
                    Func<IModuleSymbol, CompilationTestData.MethodData, IReadOnlyDictionary<int, string>, bool, string> visualizeRealIL = null,
                    IEnumerable<ModuleData> dependencies = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25016, 1375, 1792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 815, 827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 866, 875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 927, 940);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 1031, 1048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 1085, 1099);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 1346, 1362);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 1662, 1689);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 1703, 1732);

                _dependencies = dependencies;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 1746, 1781);

                _visualizeRealIL = visualizeRealIL;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25016, 1375, 1792);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 1375, 1792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 1375, 1792);
            }
        }

        internal CompilationTestData TestData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 1842, 1854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 1845, 1854);
                    return _testData; DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 1842, 1854);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 1842, 1854);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 1842, 1854);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Compilation Compilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 1896, 1911);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 1899, 1911);
                    return _compilation; DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 1896, 1911);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 1896, 1911);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 1896, 1911);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<Diagnostic> Diagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 1970, 1985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 1973, 1985);
                    return _diagnostics; DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 1970, 1985);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 1970, 1985);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 1970, 1985);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Metadata GetMetadata()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 1998, 3216);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 2054, 2229) || true) && (EmittedAssemblyData == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 2054, 2229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 2119, 2214);

                    throw f_25016_2125_2213("You must call Emit before calling GetAllModuleMetadata.");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 2054, 2229);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 2245, 3205) || true) && (f_25016_2249_2294(f_25016_2249_2280(f_25016_2249_2269(_compilation))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 2245, 3205);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 2328, 2395);

                    var
                    metadata = f_25016_2343_2394(EmittedAssemblyData)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 2413, 2464);

                    f_25016_2413_2463(f_25016_2413_2428(metadata));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 2482, 2498);

                    return metadata;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 2245, 3205);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 2245, 3205);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 2564, 2687);

                    var
                    images = new List<ImmutableArray<byte>>
                                    {
                    DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => EmittedAssemblyData,25016,2577,2686)
                                    }
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 2707, 2890) || true) && (_allModuleData != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 2707, 2890);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 2775, 2871);

                        f_25016_2775_2870(images, f_25016_2791_2869(f_25016_2791_2848(_allModuleData, m => m.Kind == OutputKind.NetModule), m => m.Image));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 2707, 2890);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 2910, 3190);

                    return f_25016_2917_3189(f_25016_2941_3188(images, image =>
                                    {
                                        var metadata = ModuleMetadata.CreateFromImage(image);
                                        metadata.Module.PretendThereArentNoPiaLocalTypes();
                                        return metadata;
                                    }));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 2245, 3205);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 1998, 3216);

                System.InvalidOperationException
                f_25016_2125_2213(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 2125, 2213);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_25016_2249_2269(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 2249, 2269);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_25016_2249_2280(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 2249, 2280);
                    return return_v;
                }


                bool
                f_25016_2249_2294(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 2249, 2294);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_25016_2343_2394(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = ModuleMetadata.CreateFromImage(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 2343, 2394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_25016_2413_2428(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 2413, 2428);
                    return return_v;
                }


                int
                f_25016_2413_2463(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    this_param.PretendThereArentNoPiaLocalTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 2413, 2463);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleData>
                f_25016_2791_2848(System.Collections.Generic.IList<Roslyn.Test.Utilities.ModuleData>
                source, System.Func<Roslyn.Test.Utilities.ModuleData, bool>
                predicate)
                {
                    var return_v = source.Where<Roslyn.Test.Utilities.ModuleData>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 2791, 2848);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                f_25016_2791_2869(System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleData>
                source, System.Func<Roslyn.Test.Utilities.ModuleData, System.Collections.Immutable.ImmutableArray<byte>>
                selector)
                {
                    var return_v = source.Select<Roslyn.Test.Utilities.ModuleData, System.Collections.Immutable.ImmutableArray<byte>>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 2791, 2869);
                    return return_v;
                }


                int
                f_25016_2775_2870(System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<byte>>
                this_param, System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 2775, 2870);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ModuleMetadata>
                f_25016_2941_3188(System.Collections.Generic.List<System.Collections.Immutable.ImmutableArray<byte>>
                source, System.Func<System.Collections.Immutable.ImmutableArray<byte>, Microsoft.CodeAnalysis.ModuleMetadata>
                selector)
                {
                    var return_v = source.Select<System.Collections.Immutable.ImmutableArray<byte>, Microsoft.CodeAnalysis.ModuleMetadata>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 2941, 3188);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyMetadata
                f_25016_2917_3189(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ModuleMetadata>
                modules)
                {
                    var return_v = AssemblyMetadata.Create(modules);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 2917, 3189);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 1998, 3216);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 1998, 3216);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string Dump(string methodName = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 3228, 6465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 3297, 4956);
                using (var
                testEnvironment = f_25016_3326_3373(_dependencies)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 3407, 3503);

                    string
                    mainModuleFullName = f_25016_3435_3502(this, testEnvironment, manifestResources: null, EmitOptions.Default)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 3521, 3588);

                    IList<ModuleData>
                    moduleDatas = f_25016_3553_3587(testEnvironment)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 3606, 3683);

                    var
                    mainModule = f_25016_3623_3682(moduleDatas, md => md.FullName == mainModuleFullName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 3701, 3776);

                    f_25016_3701_3775(moduleDatas, out var dumpDir);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 3796, 3882);

                    string
                    extension = (DynAbs.Tracing.TraceSender.Conditional_F1(25016, 3815, 3863) || ((mainModule.Kind == OutputKind.ConsoleApplication && DynAbs.Tracing.TraceSender.Conditional_F2(25016, 3866, 3872)) || DynAbs.Tracing.TraceSender.Conditional_F3(25016, 3875, 3881))) ? ".exe" : ".dll"
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 3900, 3977);

                    string
                    modulePath = f_25016_3920_3976(dumpDir, f_25016_3942_3963(mainModule) + extension)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 3997, 4170);

                    var
                    decompiler = f_25016_4014_4169(modulePath, new ICSharpCode.Decompiler.DecompilerSettings() { AsyncAwait = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => false, 25016, 4098, 4168) })
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 4190, 4872) || true) && (methodName != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 4190, 4872);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 4254, 4332);

                        var
                        map = f_25016_4264_4331()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 4354, 4419);

                        f_25016_4354_4418(f_25016_4366_4412(f_25016_4366_4398(f_25016_4366_4387(decompiler))), map);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 4443, 4853) || true) && (f_25016_4447_4490(map, methodName, out var method))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 4443, 4853);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 4540, 4598);

                            return f_25016_4547_4597(decompiler, f_25016_4576_4596(method));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 4443, 4853);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 4443, 4853);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 4696, 4830);

                            throw f_25016_4702_4829($"Didn't find method '{methodName}'. Available/distinguishable methods are: \r\n{f_25016_4797_4826("\r\n", f_25016_4817_4825(map))}");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 4443, 4853);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 4190, 4872);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 4892, 4941);

                    return f_25016_4899_4940(decompiler);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(25016, 3297, 4956);
                }

                void listMethods(ICSharpCode.Decompiler.TypeSystem.INamespace @namespace, Dictionary<string, ICSharpCode.Decompiler.TypeSystem.IMethod> result)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 4972, 5622);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 5148, 5457);
                            foreach (var nestedNS in f_25016_5173_5199_I(f_25016_5173_5199(@namespace)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 5148, 5457);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 5241, 5438) || true) && (f_25016_5245_5262(nestedNS) != "System" && (DynAbs.Tracing.TraceSender.Expression_True(25016, 5245, 5335) && f_25016_5303_5320(nestedNS) != "Microsoft"))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 5241, 5438);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 5385, 5415);

                                    f_25016_5385_5414(nestedNS, result);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 5241, 5438);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 5148, 5457);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25016, 1, 310);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25016, 1, 310);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 5477, 5607);
                            foreach (var type in f_25016_5498_5514_I(f_25016_5498_5514(@namespace)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 5477, 5607);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 5556, 5588);

                                f_25016_5556_5587(type, result);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 5477, 5607);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25016, 1, 131);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25016, 1, 131);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 4972, 5622);

                        System.Collections.Generic.IEnumerable<ICSharpCode.Decompiler.TypeSystem.INamespace>
                        f_25016_5173_5199(ICSharpCode.Decompiler.TypeSystem.INamespace
                        this_param)
                        {
                            var return_v = this_param.ChildNamespaces;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 5173, 5199);
                            return return_v;
                        }


                        string
                        f_25016_5245_5262(ICSharpCode.Decompiler.TypeSystem.INamespace
                        this_param)
                        {
                            var return_v = this_param.FullName;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 5245, 5262);
                            return return_v;
                        }


                        string
                        f_25016_5303_5320(ICSharpCode.Decompiler.TypeSystem.INamespace
                        this_param)
                        {
                            var return_v = this_param.FullName;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 5303, 5320);
                            return return_v;
                        }


                        int
                        f_25016_5385_5414(ICSharpCode.Decompiler.TypeSystem.INamespace
                        @namespace, System.Collections.Generic.Dictionary<string, ICSharpCode.Decompiler.TypeSystem.IMethod>
                        result)
                        {
                            listMethods(@namespace, result);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 5385, 5414);
                            return 0;
                        }


                        System.Collections.Generic.IEnumerable<ICSharpCode.Decompiler.TypeSystem.INamespace>
                        f_25016_5173_5199_I(System.Collections.Generic.IEnumerable<ICSharpCode.Decompiler.TypeSystem.INamespace>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 5173, 5199);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<ICSharpCode.Decompiler.TypeSystem.ITypeDefinition>
                        f_25016_5498_5514(ICSharpCode.Decompiler.TypeSystem.INamespace
                        this_param)
                        {
                            var return_v = this_param.Types;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 5498, 5514);
                            return return_v;
                        }


                        int
                        f_25016_5556_5587(ICSharpCode.Decompiler.TypeSystem.ITypeDefinition
                        type, System.Collections.Generic.Dictionary<string, ICSharpCode.Decompiler.TypeSystem.IMethod>
                        result)
                        {
                            listMethodsInType(type, result);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 5556, 5587);
                            return 0;
                        }


                        System.Collections.Generic.IEnumerable<ICSharpCode.Decompiler.TypeSystem.ITypeDefinition>
                        f_25016_5498_5514_I(System.Collections.Generic.IEnumerable<ICSharpCode.Decompiler.TypeSystem.ITypeDefinition>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 5498, 5514);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 4972, 5622);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 4972, 5622);
                    }
                }

                void listMethodsInType(ICSharpCode.Decompiler.TypeSystem.ITypeDefinition type, Dictionary<string, ICSharpCode.Decompiler.TypeSystem.IMethod> result)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 5638, 6454);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 5819, 5961);
                            foreach (var nestedType in f_25016_5846_5862_I(f_25016_5846_5862(type)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 5819, 5961);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 5904, 5942);

                                f_25016_5904_5941(nestedType, result);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 5819, 5961);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25016, 1, 143);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25016, 1, 143);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 5981, 6439);
                            foreach (var method in f_25016_6004_6016_I(f_25016_6004_6016(type)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 5981, 6439);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 6058, 6420) || true) && (f_25016_6062_6097(result, f_25016_6081_6096(method)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 6058, 6420);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 6232, 6263);

                                    f_25016_6232_6262(                        // There is a bug with FullName on methods in generic types
                                                            result, f_25016_6246_6261(method));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 6058, 6420);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 6058, 6420);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 6361, 6397);

                                    f_25016_6361_6396(result, f_25016_6372_6387(method), method);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 6058, 6420);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 5981, 6439);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25016, 1, 459);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25016, 1, 459);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 5638, 6454);

                        System.Collections.Generic.IReadOnlyList<ICSharpCode.Decompiler.TypeSystem.ITypeDefinition>
                        f_25016_5846_5862(ICSharpCode.Decompiler.TypeSystem.ITypeDefinition
                        this_param)
                        {
                            var return_v = this_param.NestedTypes;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 5846, 5862);
                            return return_v;
                        }


                        int
                        f_25016_5904_5941(ICSharpCode.Decompiler.TypeSystem.ITypeDefinition
                        type, System.Collections.Generic.Dictionary<string, ICSharpCode.Decompiler.TypeSystem.IMethod>
                        result)
                        {
                            listMethodsInType(type, result);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 5904, 5941);
                            return 0;
                        }


                        System.Collections.Generic.IReadOnlyList<ICSharpCode.Decompiler.TypeSystem.ITypeDefinition>
                        f_25016_5846_5862_I(System.Collections.Generic.IReadOnlyList<ICSharpCode.Decompiler.TypeSystem.ITypeDefinition>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 5846, 5862);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<ICSharpCode.Decompiler.TypeSystem.IMethod>
                        f_25016_6004_6016(ICSharpCode.Decompiler.TypeSystem.ITypeDefinition
                        this_param)
                        {
                            var return_v = this_param.Methods;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 6004, 6016);
                            return return_v;
                        }


                        string
                        f_25016_6081_6096(ICSharpCode.Decompiler.TypeSystem.IMethod
                        this_param)
                        {
                            var return_v = this_param.FullName;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 6081, 6096);
                            return return_v;
                        }


                        bool
                        f_25016_6062_6097(System.Collections.Generic.Dictionary<string, ICSharpCode.Decompiler.TypeSystem.IMethod>
                        this_param, string
                        key)
                        {
                            var return_v = this_param.ContainsKey(key);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 6062, 6097);
                            return return_v;
                        }


                        string
                        f_25016_6246_6261(ICSharpCode.Decompiler.TypeSystem.IMethod
                        this_param)
                        {
                            var return_v = this_param.FullName;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 6246, 6261);
                            return return_v;
                        }


                        bool
                        f_25016_6232_6262(System.Collections.Generic.Dictionary<string, ICSharpCode.Decompiler.TypeSystem.IMethod>
                        this_param, string
                        key)
                        {
                            var return_v = this_param.Remove(key);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 6232, 6262);
                            return return_v;
                        }


                        string
                        f_25016_6372_6387(ICSharpCode.Decompiler.TypeSystem.IMethod
                        this_param)
                        {
                            var return_v = this_param.FullName;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 6372, 6387);
                            return return_v;
                        }


                        int
                        f_25016_6361_6396(System.Collections.Generic.Dictionary<string, ICSharpCode.Decompiler.TypeSystem.IMethod>
                        this_param, string
                        key, ICSharpCode.Decompiler.TypeSystem.IMethod
                        value)
                        {
                            this_param.Add(key, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 6361, 6396);
                            return 0;
                        }


                        System.Collections.Generic.IEnumerable<ICSharpCode.Decompiler.TypeSystem.IMethod>
                        f_25016_6004_6016_I(System.Collections.Generic.IEnumerable<ICSharpCode.Decompiler.TypeSystem.IMethod>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 6004, 6016);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 5638, 6454);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 5638, 6454);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 3228, 6465);

                Roslyn.Test.Utilities.IRuntimeEnvironment
                f_25016_3326_3373(System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleData>
                additionalDependencies)
                {
                    var return_v = RuntimeEnvironmentFactory.Create(additionalDependencies);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 3326, 3373);
                    return return_v;
                }


                string
                f_25016_3435_3502(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, Roslyn.Test.Utilities.IRuntimeEnvironment
                testEnvironment, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                manifestResources, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions)
                {
                    var return_v = this_param.Emit(testEnvironment, manifestResources: manifestResources, emitOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 3435, 3502);
                    return return_v;
                }


                System.Collections.Generic.IList<Roslyn.Test.Utilities.ModuleData>
                f_25016_3553_3587(Roslyn.Test.Utilities.IRuntimeEnvironment
                this_param)
                {
                    var return_v = this_param.GetAllModuleData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 3553, 3587);
                    return return_v;
                }


                Roslyn.Test.Utilities.ModuleData
                f_25016_3623_3682(System.Collections.Generic.IList<Roslyn.Test.Utilities.ModuleData>
                source, System.Func<Roslyn.Test.Utilities.ModuleData, bool>
                predicate)
                {
                    var return_v = source.Single<Roslyn.Test.Utilities.ModuleData>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 3623, 3682);
                    return return_v;
                }


                string
                f_25016_3701_3775(System.Collections.Generic.IList<Roslyn.Test.Utilities.ModuleData>
                modules, out string
                dumpDirectory)
                {
                    var return_v = RuntimeEnvironmentUtilities.DumpAssemblyData((System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleData>)modules, out dumpDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 3701, 3775);
                    return return_v;
                }


                string
                f_25016_3942_3963(Roslyn.Test.Utilities.ModuleData
                this_param)
                {
                    var return_v = this_param.SimpleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 3942, 3963);
                    return return_v;
                }


                string
                f_25016_3920_3976(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 3920, 3976);
                    return return_v;
                }


                ICSharpCode.Decompiler.CSharp.CSharpDecompiler
                f_25016_4014_4169(string
                fileName, ICSharpCode.Decompiler.DecompilerSettings
                settings)
                {
                    var return_v = new ICSharpCode.Decompiler.CSharp.CSharpDecompiler(fileName, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 4014, 4169);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, ICSharpCode.Decompiler.TypeSystem.IMethod>
                f_25016_4264_4331()
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, ICSharpCode.Decompiler.TypeSystem.IMethod>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 4264, 4331);
                    return return_v;
                }


                ICSharpCode.Decompiler.TypeSystem.IDecompilerTypeSystem
                f_25016_4366_4387(ICSharpCode.Decompiler.CSharp.CSharpDecompiler
                this_param)
                {
                    var return_v = this_param.TypeSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 4366, 4387);
                    return return_v;
                }


                ICSharpCode.Decompiler.TypeSystem.MetadataModule
                f_25016_4366_4398(ICSharpCode.Decompiler.TypeSystem.IDecompilerTypeSystem
                this_param)
                {
                    var return_v = this_param.MainModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 4366, 4398);
                    return return_v;
                }


                ICSharpCode.Decompiler.TypeSystem.INamespace
                f_25016_4366_4412(ICSharpCode.Decompiler.TypeSystem.MetadataModule
                this_param)
                {
                    var return_v = this_param.RootNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 4366, 4412);
                    return return_v;
                }


                int
                f_25016_4354_4418(ICSharpCode.Decompiler.TypeSystem.INamespace
                @namespace, System.Collections.Generic.Dictionary<string, ICSharpCode.Decompiler.TypeSystem.IMethod>
                result)
                {
                    listMethods(@namespace, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 4354, 4418);
                    return 0;
                }


                bool
                f_25016_4447_4490(System.Collections.Generic.Dictionary<string, ICSharpCode.Decompiler.TypeSystem.IMethod>
                this_param, string
                key, out ICSharpCode.Decompiler.TypeSystem.IMethod
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 4447, 4490);
                    return return_v;
                }


                System.Reflection.Metadata.EntityHandle
                f_25016_4576_4596(ICSharpCode.Decompiler.TypeSystem.IMethod
                this_param)
                {
                    var return_v = this_param.MetadataToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 4576, 4596);
                    return return_v;
                }


                string
                f_25016_4547_4597(ICSharpCode.Decompiler.CSharp.CSharpDecompiler
                this_param, params System.Reflection.Metadata.EntityHandle[]
                definitions)
                {
                    var return_v = this_param.DecompileAsString(definitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 4547, 4597);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, ICSharpCode.Decompiler.TypeSystem.IMethod>.KeyCollection
                f_25016_4817_4825(System.Collections.Generic.Dictionary<string, ICSharpCode.Decompiler.TypeSystem.IMethod>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 4817, 4825);
                    return return_v;
                }


                string
                f_25016_4797_4826(string
                separator, System.Collections.Generic.Dictionary<string, ICSharpCode.Decompiler.TypeSystem.IMethod>.KeyCollection
                values)
                {
                    var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<string?>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 4797, 4826);
                    return return_v;
                }


                System.Exception
                f_25016_4702_4829(string
                message)
                {
                    var return_v = new System.Exception(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 4702, 4829);
                    return return_v;
                }


                string
                f_25016_4899_4940(ICSharpCode.Decompiler.CSharp.CSharpDecompiler
                this_param)
                {
                    var return_v = this_param.DecompileWholeModuleAsString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 4899, 4940);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 3228, 6465);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 3228, 6465);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void VerifyTypeIL(string typeName, string expected)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 7065, 8839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 7148, 7206);

                var
                output = f_25016_7161_7205()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 7220, 8712);
                using (var
                testEnvironment = f_25016_7249_7296(_dependencies)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 7330, 7426);

                    string
                    mainModuleFullName = f_25016_7358_7425(this, testEnvironment, manifestResources: null, EmitOptions.Default)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 7444, 7510);

                    IList<ModuleData>
                    moduleData = f_25016_7475_7509(testEnvironment)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 7528, 7604);

                    var
                    mainModule = f_25016_7545_7603(moduleData, md => md.FullName == mainModuleFullName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 7622, 8697);
                    using (var
                    moduleMetadata = f_25016_7650_7712(f_25016_7681_7711(testEnvironment))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 7754, 7833);

                        var
                        peFile = f_25016_7767_7832(mainModuleFullName, f_25016_7798_7831(f_25016_7798_7819(moduleMetadata)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 7855, 7911);

                        var
                        metadataReader = f_25016_7876_7910(moduleMetadata)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 7935, 7954);

                        bool
                        found = false
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 7976, 8596);
                            foreach (var typeDefHandle in f_25016_8006_8036_I(f_25016_8006_8036(metadataReader)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 7976, 8596);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 8086, 8148);

                                var
                                typeDef = f_25016_8100_8147(metadataReader, typeDefHandle)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 8174, 8573) || true) && (f_25016_8178_8216(metadataReader, typeDef.Name) == typeName)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 8174, 8573);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 8286, 8385);

                                    var
                                    disassembler = f_25016_8305_8384(output, default)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 8415, 8467);

                                    f_25016_8415_8466(disassembler, peFile, typeDefHandle);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 8497, 8510);

                                    found = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(25016, 8540, 8546);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 8174, 8573);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 7976, 8596);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(25016, 1, 621);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(25016, 1, 621);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 8618, 8678);

                        f_25016_8618_8677(found, "Could not find type named " + typeName);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(25016, 7622, 8697);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(25016, 7220, 8712);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 8726, 8828);

                f_25016_8726_8827(expected, f_25016_8788_8805(output), escapeQuotes: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 7065, 8839);

                ICSharpCode.Decompiler.PlainTextOutput
                f_25016_7161_7205()
                {
                    var return_v = new ICSharpCode.Decompiler.PlainTextOutput();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 7161, 7205);
                    return return_v;
                }


                Roslyn.Test.Utilities.IRuntimeEnvironment
                f_25016_7249_7296(System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleData>
                additionalDependencies)
                {
                    var return_v = RuntimeEnvironmentFactory.Create(additionalDependencies);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 7249, 7296);
                    return return_v;
                }


                string
                f_25016_7358_7425(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, Roslyn.Test.Utilities.IRuntimeEnvironment
                testEnvironment, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                manifestResources, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions)
                {
                    var return_v = this_param.Emit(testEnvironment, manifestResources: manifestResources, emitOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 7358, 7425);
                    return return_v;
                }


                System.Collections.Generic.IList<Roslyn.Test.Utilities.ModuleData>
                f_25016_7475_7509(Roslyn.Test.Utilities.IRuntimeEnvironment
                this_param)
                {
                    var return_v = this_param.GetAllModuleData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 7475, 7509);
                    return return_v;
                }


                Roslyn.Test.Utilities.ModuleData
                f_25016_7545_7603(System.Collections.Generic.IList<Roslyn.Test.Utilities.ModuleData>
                source, System.Func<Roslyn.Test.Utilities.ModuleData, bool>
                predicate)
                {
                    var return_v = source.Single<Roslyn.Test.Utilities.ModuleData>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 7545, 7603);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_25016_7681_7711(Roslyn.Test.Utilities.IRuntimeEnvironment
                this_param)
                {
                    var return_v = this_param.GetMainImage();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 7681, 7711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_25016_7650_7712(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = ModuleMetadata.CreateFromImage(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 7650, 7712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_25016_7798_7819(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 7798, 7819);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEReader
                f_25016_7798_7831(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.PEReaderOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 7798, 7831);
                    return return_v;
                }


                ICSharpCode.Decompiler.Metadata.PEFile
                f_25016_7767_7832(string
                fileName, System.Reflection.PortableExecutable.PEReader
                reader)
                {
                    var return_v = new ICSharpCode.Decompiler.Metadata.PEFile(fileName, reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 7767, 7832);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_25016_7876_7910(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    var return_v = this_param.GetMetadataReader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 7876, 7910);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinitionHandleCollection
                f_25016_8006_8036(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.TypeDefinitions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 8006, 8036);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_25016_8100_8147(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 8100, 8147);
                    return return_v;
                }


                string
                f_25016_8178_8216(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 8178, 8216);
                    return return_v;
                }


                ICSharpCode.Decompiler.Disassembler.ReflectionDisassembler
                f_25016_8305_8384(ICSharpCode.Decompiler.PlainTextOutput
                output, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new ICSharpCode.Decompiler.Disassembler.ReflectionDisassembler((ICSharpCode.Decompiler.ITextOutput)output, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 8305, 8384);
                    return return_v;
                }


                int
                f_25016_8415_8466(ICSharpCode.Decompiler.Disassembler.ReflectionDisassembler
                this_param, ICSharpCode.Decompiler.Metadata.PEFile
                module, System.Reflection.Metadata.TypeDefinitionHandle
                type)
                {
                    this_param.DisassembleType(module, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 8415, 8466);
                    return 0;
                }


                System.Reflection.Metadata.TypeDefinitionHandleCollection
                f_25016_8006_8036_I(System.Reflection.Metadata.TypeDefinitionHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 8006, 8036);
                    return return_v;
                }


                int
                f_25016_8618_8677(bool
                condition, string
                userMessage)
                {
                    Assert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 8618, 8677);
                    return 0;
                }


                string
                f_25016_8788_8805(ICSharpCode.Decompiler.PlainTextOutput
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 8788, 8805);
                    return return_v;
                }


                bool
                f_25016_8726_8827(string
                expected, string
                actual, bool
                escapeQuotes)
                {
                    var return_v = AssertEx.AssertEqualToleratingWhitespaceDifferences(expected, actual, escapeQuotes: escapeQuotes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 8726, 8827);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 7065, 8839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 7065, 8839);
            }
        }

        public void Emit(string expectedOutput, int? expectedReturnCode, string[] args, IEnumerable<ResourceDescription> manifestResources, EmitOptions emitOptions, Verification peVerify, SignatureDescription[] expectedSignatures)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 8851, 9929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 9098, 9174);

                using var
                testEnvironment = f_25016_9126_9173(_dependencies)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 9190, 9268);

                string
                mainModuleName = f_25016_9214_9267(this, testEnvironment, manifestResources, emitOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 9282, 9334);

                _allModuleData = f_25016_9299_9333(testEnvironment);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 9348, 9381);

                f_25016_9348_9380(testEnvironment, peVerify);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 9397, 9568) || true) && (expectedSignatures != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 9397, 9568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 9461, 9553);

                    f_25016_9461_9552(testEnvironment, expectedSignatures);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 9397, 9568);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 9584, 9918) || true) && (expectedOutput != null || (DynAbs.Tracing.TraceSender.Expression_False(25016, 9588, 9640) || expectedReturnCode != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 9584, 9918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 9674, 9753);

                    var
                    returnCode = f_25016_9691_9752(testEnvironment, mainModuleName, args, expectedOutput)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 9773, 9903) || true) && (expectedReturnCode is int exCode)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 9773, 9903);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 9851, 9884);

                        f_25016_9851_9883(exCode, returnCode);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 9773, 9903);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 9584, 9918);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 8851, 9929);

                Roslyn.Test.Utilities.IRuntimeEnvironment
                f_25016_9126_9173(System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleData>
                additionalDependencies)
                {
                    var return_v = RuntimeEnvironmentFactory.Create(additionalDependencies);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 9126, 9173);
                    return return_v;
                }


                string
                f_25016_9214_9267(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, Roslyn.Test.Utilities.IRuntimeEnvironment
                testEnvironment, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                manifestResources, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions)
                {
                    var return_v = this_param.Emit(testEnvironment, manifestResources, emitOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 9214, 9267);
                    return return_v;
                }


                System.Collections.Generic.IList<Roslyn.Test.Utilities.ModuleData>
                f_25016_9299_9333(Roslyn.Test.Utilities.IRuntimeEnvironment
                this_param)
                {
                    var return_v = this_param.GetAllModuleData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 9299, 9333);
                    return return_v;
                }


                int
                f_25016_9348_9380(Roslyn.Test.Utilities.IRuntimeEnvironment
                this_param, Microsoft.CodeAnalysis.Test.Utilities.Verification
                verification)
                {
                    this_param.Verify(verification);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 9348, 9380);
                    return 0;
                }


                int
                f_25016_9461_9552(Roslyn.Test.Utilities.IRuntimeEnvironment
                appDomainHost, params Microsoft.CodeAnalysis.Test.Utilities.SignatureDescription[]
                expectedSignatures)
                {
                    MetadataSignatureUnitTestHelper.VerifyMemberSignatures(appDomainHost, expectedSignatures);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 9461, 9552);
                    return 0;
                }


                int
                f_25016_9691_9752(Roslyn.Test.Utilities.IRuntimeEnvironment
                this_param, string
                moduleName, string[]
                args, string?
                expectedOutput)
                {
                    var return_v = this_param.Execute(moduleName, args, expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 9691, 9752);
                    return return_v;
                }


                int
                f_25016_9851_9883(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 9851, 9883);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 8851, 9929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 8851, 9929);
            }
        }

        public void EmitAndVerify(params string[] expectedPeVerifyOutput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 10160, 10611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 10250, 10600);
                using (var
                testEnvironment = f_25016_10279_10326(_dependencies)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 10360, 10418);

                    string
                    mainModuleName = f_25016_10384_10417(this, testEnvironment, null, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 10436, 10516);

                    string[]
                    actualOutput = f_25016_10460_10515(testEnvironment, new[] { mainModuleName })
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 10534, 10585);

                    f_25016_10534_10584(expectedPeVerifyOutput, actualOutput);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(25016, 10250, 10600);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 10160, 10611);

                Roslyn.Test.Utilities.IRuntimeEnvironment
                f_25016_10279_10326(System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleData>
                additionalDependencies)
                {
                    var return_v = RuntimeEnvironmentFactory.Create(additionalDependencies);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 10279, 10326);
                    return return_v;
                }


                string
                f_25016_10384_10417(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, Roslyn.Test.Utilities.IRuntimeEnvironment
                testEnvironment, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                manifestResources, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions)
                {
                    var return_v = this_param.Emit(testEnvironment, manifestResources, emitOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 10384, 10417);
                    return return_v;
                }


                string[]
                f_25016_10460_10515(Roslyn.Test.Utilities.IRuntimeEnvironment
                this_param, string[]
                modulesToVerify)
                {
                    var return_v = this_param.VerifyModules(modulesToVerify);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 10460, 10515);
                    return return_v;
                }


                int
                f_25016_10534_10584(string[]
                expected, string[]
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 10534, 10584);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 10160, 10611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 10160, 10611);
            }
        }

        private string Emit(IRuntimeEnvironment testEnvironment, IEnumerable<ResourceDescription> manifestResources, EmitOptions emitOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 10623, 11223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 10781, 10848);

                f_25016_10781_10847(testEnvironment, _compilation, manifestResources, emitOptions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 10864, 10912);

                _diagnostics = f_25016_10879_10911(testEnvironment);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 10926, 10979);

                EmittedAssemblyData = f_25016_10948_10978(testEnvironment);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 10993, 11043);

                EmittedAssemblyPdb = f_25016_11014_11042(testEnvironment);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 11057, 11141);

                _testData = f_25016_11069_11140(((IInternalRuntimeEnvironment)testEnvironment));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 11157, 11212);

                return f_25016_11164_11211(f_25016_11164_11194(f_25016_11164_11185(_compilation)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 10623, 11223);

                int
                f_25016_10781_10847(Roslyn.Test.Utilities.IRuntimeEnvironment
                this_param, Microsoft.CodeAnalysis.Compilation
                mainCompilation, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                manifestResources, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions)
                {
                    this_param.Emit(mainCompilation, manifestResources, emitOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 10781, 10847);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_25016_10879_10911(Roslyn.Test.Utilities.IRuntimeEnvironment
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 10879, 10911);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_25016_10948_10978(Roslyn.Test.Utilities.IRuntimeEnvironment
                this_param)
                {
                    var return_v = this_param.GetMainImage();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 10948, 10978);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_25016_11014_11042(Roslyn.Test.Utilities.IRuntimeEnvironment
                this_param)
                {
                    var return_v = this_param.GetMainPdb();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 11014, 11042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.CompilationTestData
                f_25016_11069_11140(Roslyn.Test.Utilities.IInternalRuntimeEnvironment
                this_param)
                {
                    var return_v = this_param.GetCompilationTestData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 11069, 11140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IAssemblySymbol
                f_25016_11164_11185(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 11164, 11185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_25016_11164_11194(Microsoft.CodeAnalysis.IAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 11164, 11194);
                    return return_v;
                }


                string
                f_25016_11164_11211(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.GetDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 11164, 11211);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 10623, 11223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 10623, 11223);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationVerifier VerifyIL(
                    string qualifiedMethodName,
                    XCData expectedIL,
                    bool realIL = false,
                    string sequencePoints = null,
                    [CallerFilePath] string callerPath = null,
                    [CallerLineNumber] int callerLine = 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 11235, 11693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 11554, 11682);

                return f_25016_11561_11681(this, qualifiedMethodName, f_25016_11595_11611(expectedIL), realIL, sequencePoints, callerPath, callerLine, escapeQuotes: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 11235, 11693);

                string
                f_25016_11595_11611(System.Xml.Linq.XCData
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 11595, 11611);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_25016_11561_11681(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, bool
                realIL, string?
                sequencePoints, string
                callerPath, int
                callerLine, bool
                escapeQuotes)
                {
                    var return_v = this_param.VerifyILImpl(qualifiedMethodName, expectedIL, realIL, sequencePoints, callerPath, callerLine, escapeQuotes: escapeQuotes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 11561, 11681);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 11235, 11693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 11235, 11693);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationVerifier VerifyIL(
                    string qualifiedMethodName,
                    string expectedIL,
                    bool realIL = false,
                    string sequencePoints = null,
                    [CallerFilePath] string callerPath = null,
                    [CallerLineNumber] int callerLine = 0,
                    string source = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 11705, 12207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 12059, 12196);

                return f_25016_12066_12195(this, qualifiedMethodName, expectedIL, realIL, sequencePoints, callerPath, callerLine, escapeQuotes: true, source: source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 11705, 12207);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_25016_12066_12195(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, bool
                realIL, string?
                sequencePoints, string
                callerPath, int
                callerLine, bool
                escapeQuotes, string?
                source)
                {
                    var return_v = this_param.VerifyILImpl(qualifiedMethodName, expectedIL, realIL, sequencePoints, callerPath, callerLine, escapeQuotes: escapeQuotes, source: source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 12066, 12195);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 11705, 12207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 11705, 12207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void VerifyLocalSignature(
                    string qualifiedMethodName,
                    string expectedSignature,
                    [CallerLineNumber] int callerLine = 0,
                    [CallerFilePath] string callerPath = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 12219, 12836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 12465, 12536);

                var
                ilBuilder = f_25016_12481_12525(_testData, qualifiedMethodName).ILBuilder
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 12550, 12629);

                string
                actualSignature = f_25016_12575_12628(ilBuilder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 12643, 12825);

                f_25016_12643_12824(expectedSignature, actualSignature, escapeQuotes: true, expectedValueSourcePath: callerPath, expectedValueSourceLine: callerLine);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 12219, 12836);

                Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
                f_25016_12481_12525(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
                data, string
                qualifiedMethodName)
                {
                    var return_v = data.GetMethodData(qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 12481, 12525);
                    return return_v;
                }


                string
                f_25016_12575_12628(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                builder)
                {
                    var return_v = ILBuilderVisualizer.LocalSignatureToString(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 12575, 12628);
                    return return_v;
                }


                bool
                f_25016_12643_12824(string
                expected, string
                actual, bool
                escapeQuotes, string
                expectedValueSourcePath, int
                expectedValueSourceLine)
                {
                    var return_v = AssertEx.AssertEqualToleratingWhitespaceDifferences(expected, actual, escapeQuotes: escapeQuotes, expectedValueSourcePath: expectedValueSourcePath, expectedValueSourceLine: expectedValueSourceLine);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 12643, 12824);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 12219, 12836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 12219, 12836);
            }
        }

        private CompilationVerifier VerifyILImpl(
                    string qualifiedMethodName,
                    string expectedIL,
                    bool realIL,
                    string sequencePoints,
                    string callerPath,
                    int callerLine,
                    bool escapeQuotes,
                    string source = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 13103, 13678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 13432, 13515);

                string
                actualIL = f_25016_13450_13514(this, qualifiedMethodName, realIL, sequencePoints, source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 13529, 13641);

                f_25016_13529_13640(expectedIL, actualIL, escapeQuotes, callerPath, callerLine);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 13655, 13667);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 13103, 13678);

                string
                f_25016_13450_13514(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, bool
                realIL, string
                sequencePoints, string?
                source)
                {
                    var return_v = this_param.VisualizeIL(qualifiedMethodName, realIL, sequencePoints, source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 13450, 13514);
                    return return_v;
                }


                bool
                f_25016_13529_13640(string
                expected, string
                actual, bool
                escapeQuotes, string
                expectedValueSourcePath, int
                expectedValueSourceLine)
                {
                    var return_v = AssertEx.AssertEqualToleratingWhitespaceDifferences(expected, actual, escapeQuotes, expectedValueSourcePath, expectedValueSourceLine);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 13529, 13640);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 13103, 13678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 13103, 13678);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string VisualizeIL(string qualifiedMethodName, bool realIL = false, string sequencePoints = null, string source = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 13690, 14175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 14067, 14164);

                return f_25016_14074_14163(this, f_25016_14086_14130(_testData, qualifiedMethodName), realIL, sequencePoints, source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 13690, 14175);

                Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
                f_25016_14086_14130(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
                data, string
                qualifiedMethodName)
                {
                    var return_v = data.GetMethodData(qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 14086, 14130);
                    return return_v;
                }


                string
                f_25016_14074_14163(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
                methodData, bool
                realIL, string?
                sequencePoints, string?
                source)
                {
                    var return_v = this_param.VisualizeIL(methodData, realIL, sequencePoints, source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 14074, 14163);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 13690, 14175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 13690, 14175);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string VisualizeIL(CompilationTestData.MethodData methodData, bool realIL, string sequencePoints = null, string source = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 14187, 16749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 14347, 14386);

                Dictionary<int, string>
                markers = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 14402, 15784) || true) && (sequencePoints != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 14402, 15784);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 14462, 14633) || true) && (EmittedAssemblyPdb == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 14462, 14633);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 14534, 14614);

                        throw f_25016_14540_14613($"{nameof(EmittedAssemblyPdb)} is not set");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 14462, 14633);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 14653, 14826) || true) && (EmittedAssemblyData == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 14653, 14826);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 14726, 14807);

                        throw f_25016_14732_14806($"{nameof(EmittedAssemblyData)} is not set");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 14653, 14826);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 14846, 15426);

                    var
                    actualPdbXml = f_25016_14865_15425(pdbStream: f_25016_14922_14968(EmittedAssemblyPdb.ToArray()), peStream: f_25016_15001_15048(EmittedAssemblyData.ToArray()), options: PdbToXmlOptions.ResolveTokens |
                                                 PdbToXmlOptions.ThrowOnError |
                                                 PdbToXmlOptions.ExcludeDocuments |
                                                 PdbToXmlOptions.ExcludeCustomDebugInformation |
                                                 PdbToXmlOptions.ExcludeScopes, methodName: sequencePoints)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 15446, 15680) || true) && (f_25016_15450_15484(actualPdbXml, "<error>"))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 15446, 15680);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 15526, 15661);

                        throw f_25016_15532_15660($"Failed to extract PDB information for method '{sequencePoints}'. PdbToXmlConverter returned:\r\n{actualPdbXml}");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 15446, 15680);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 15700, 15769);

                    markers = f_25016_15710_15768(actualPdbXml, source);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 14402, 15784);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 15800, 15945) || true) && (!realIL)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 15800, 15945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 15845, 15930);

                    return f_25016_15852_15929(methodData.ILBuilder, markers: markers);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 15800, 15945);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 15961, 16300) || true) && (_lazyModuleSymbol == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 15961, 16300);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 16024, 16181);

                    var
                    targetReference = f_25016_16046_16180(EmittedAssemblyData, f_25016_16112_16143(f_25016_16112_16132(_compilation)), display: f_25016_16154_16179(_compilation))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 16199, 16285);

                    _lazyModuleSymbol = f_25016_16219_16284(this, targetReference, MetadataImportOptions.All);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 15961, 16300);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 16316, 16710) || true) && (_lazyModuleSymbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 16316, 16710);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 16379, 16544) || true) && (_visualizeRealIL == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 16379, 16544);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 16449, 16525);

                        throw f_25016_16455_16524("IL visualization function is not set");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 16379, 16544);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 16564, 16695);

                    return f_25016_16571_16694(this, _lazyModuleSymbol, methodData, markers, f_25016_16628_16693(f_25016_16628_16677(_testData.Module, methodData.Method)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 16316, 16710);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 16726, 16738);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 14187, 16749);

                System.InvalidOperationException
                f_25016_14540_14613(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 14540, 14613);
                    return return_v;
                }


                System.InvalidOperationException
                f_25016_14732_14806(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 14732, 14806);
                    return return_v;
                }


                System.IO.MemoryStream
                f_25016_14922_14968(byte[]
                buffer)
                {
                    var return_v = new System.IO.MemoryStream(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 14922, 14968);
                    return return_v;
                }


                System.IO.MemoryStream
                f_25016_15001_15048(byte[]
                buffer)
                {
                    var return_v = new System.IO.MemoryStream(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 15001, 15048);
                    return return_v;
                }


                string
                f_25016_14865_15425(System.IO.MemoryStream
                pdbStream, System.IO.MemoryStream
                peStream, Microsoft.DiaSymReader.Tools.PdbToXmlOptions
                options, string
                methodName)
                {
                    var return_v = PdbToXmlConverter.ToXml(pdbStream: (System.IO.Stream)pdbStream, peStream: (System.IO.Stream)peStream, options: options, methodName: methodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 14865, 15425);
                    return return_v;
                }


                bool
                f_25016_15450_15484(string
                this_param, string
                value)
                {
                    var return_v = this_param.StartsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 15450, 15484);
                    return return_v;
                }


                System.Exception
                f_25016_15532_15660(string
                message)
                {
                    var return_v = new System.Exception(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 15532, 15660);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<int, string>
                f_25016_15710_15768(string
                pdbXml, string?
                source)
                {
                    var return_v = ILValidation.GetSequencePointMarkers(pdbXml, source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 15710, 15768);
                    return return_v;
                }


                string
                f_25016_15852_15929(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                builder, System.Collections.Generic.Dictionary<int, string>?
                markers)
                {
                    var return_v = ILBuilderVisualizer.ILBuilderToString(builder, markers: (System.Collections.Generic.IReadOnlyDictionary<int, string>?)markers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 15852, 15929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_25016_16112_16132(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 16112, 16132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_25016_16112_16143(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 16112, 16143);
                    return return_v;
                }


                string?
                f_25016_16154_16179(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.AssemblyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 16154, 16179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_25016_16046_16180(System.Collections.Immutable.ImmutableArray<byte>
                image, Microsoft.CodeAnalysis.OutputKind
                outputKind, string?
                display)
                {
                    var return_v = LoadTestEmittedExecutableForSymbolValidation(image, outputKind, display: display);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 16046, 16180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IModuleSymbol
                f_25016_16219_16284(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, Microsoft.CodeAnalysis.MetadataReference
                metadataReference, Microsoft.CodeAnalysis.MetadataImportOptions
                importOptions)
                {
                    var return_v = this_param.GetSymbolFromMetadata(metadataReference, importOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 16219, 16284);
                    return return_v;
                }


                System.InvalidOperationException
                f_25016_16455_16524(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 16455, 16524);
                    return return_v;
                }


                Microsoft.Cci.IMethodBody
                f_25016_16628_16677(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder?
                this_param, Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                methodSymbol)
                {
                    var return_v = this_param.GetMethodBody(methodSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 16628, 16677);
                    return return_v;
                }


                bool
                f_25016_16628_16693(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.AreLocalsZeroed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 16628, 16693);
                    return return_v;
                }


                string
                f_25016_16571_16694(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, Microsoft.CodeAnalysis.IModuleSymbol
                arg1, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
                arg2, System.Collections.Generic.Dictionary<int, string>?
                arg3, bool
                arg4)
                {
                    var return_v = this_param._visualizeRealIL(arg1, arg2, (System.Collections.Generic.IReadOnlyDictionary<int, string>?)arg3, arg4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 16571, 16694);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 14187, 16749);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 14187, 16749);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationVerifier VerifyMemberInIL(string methodName, bool expected)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 16761, 16977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 16863, 16940);

                f_25016_16863_16939(expected, f_25016_16886_16938(f_25016_16886_16914(_testData), methodName));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 16954, 16966);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 16761, 16977);

                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                f_25016_16886_16914(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
                this_param)
                {
                    var return_v = this_param.GetMethodsByName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 16886, 16914);
                    return return_v;
                }


                bool
                f_25016_16886_16938(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 16886, 16938);
                    return return_v;
                }


                int
                f_25016_16863_16939(bool
                expected, bool
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 16863, 16939);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 16761, 16977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 16761, 16977);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationVerifier VerifyDiagnostics(params DiagnosticDescription[] expected)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 16989, 17166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 17099, 17129);

                _diagnostics.Verify(expected);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 17143, 17155);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 16989, 17166);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 16989, 17166);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 16989, 17166);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IModuleSymbol GetSymbolFromMetadata(MetadataReference metadataReference, MetadataImportOptions importOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 17178, 17942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 17321, 17575);

                var
                dummy = f_25016_17333_17574(f_25016_17333_17481(f_25016_17333_17437(f_25016_17333_17386(_compilation
                ), metadataReference), "Dummy"), f_25016_17512_17573(f_25016_17512_17532(_compilation), importOptions))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 17591, 17655);

                var
                symbol = f_25016_17604_17654(dummy, metadataReference)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 17671, 17931) || true) && (metadataReference.Properties.Kind == MetadataImageKind.Assembly)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 17671, 17931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 17772, 17821);

                    return f_25016_17779_17820(f_25016_17779_17812(((IAssemblySymbol)symbol)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 17671, 17931);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 17671, 17931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 17887, 17916);

                    return (IModuleSymbol)symbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 17671, 17931);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 17178, 17942);

                Microsoft.CodeAnalysis.Compilation
                f_25016_17333_17386(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.RemoveAllSyntaxTrees();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 17333, 17386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_25016_17333_17437(Microsoft.CodeAnalysis.Compilation
                this_param, params Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = this_param.AddReferences(references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 17333, 17437);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_25016_17333_17481(Microsoft.CodeAnalysis.Compilation
                this_param, string
                assemblyName)
                {
                    var return_v = this_param.WithAssemblyName(assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 17333, 17481);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_25016_17512_17532(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 17512, 17532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_25016_17512_17573(Microsoft.CodeAnalysis.CompilationOptions
                this_param, Microsoft.CodeAnalysis.MetadataImportOptions
                value)
                {
                    var return_v = this_param.WithMetadataImportOptions(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 17512, 17573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_25016_17333_17574(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.CompilationOptions
                options)
                {
                    var return_v = this_param.WithOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 17333, 17574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_25016_17604_17654(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.MetadataReference
                reference)
                {
                    var return_v = this_param.GetAssemblyOrModuleSymbol(reference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 17604, 17654);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IModuleSymbol>
                f_25016_17779_17812(Microsoft.CodeAnalysis.IAssemblySymbol?
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 17779, 17812);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IModuleSymbol
                f_25016_17779_17820(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IModuleSymbol>
                source)
                {
                    var return_v = source.First<Microsoft.CodeAnalysis.IModuleSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 17779, 17820);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 17178, 17942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 17178, 17942);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static MetadataReference LoadTestEmittedExecutableForSymbolValidation(
                    ImmutableArray<byte> image,
                    OutputKind outputKind,
                    string display = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25016, 17954, 18612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 18171, 18230);

                var
                moduleMetadata = f_25016_18192_18229(image)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 18244, 18301);

                f_25016_18244_18300(f_25016_18244_18265(moduleMetadata));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 18317, 18601) || true) && (outputKind == OutputKind.NetModule)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 18317, 18601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 18389, 18442);

                    return f_25016_18396_18441(moduleMetadata, display: display);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 18317, 18601);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25016, 18317, 18601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 18508, 18586);

                    return f_25016_18515_18585(f_25016_18515_18554(moduleMetadata), display: display);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25016, 18317, 18601);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25016, 17954, 18612);

                Microsoft.CodeAnalysis.ModuleMetadata
                f_25016_18192_18229(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = ModuleMetadata.CreateFromImage(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 18192, 18229);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_25016_18244_18265(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 18244, 18265);
                    return return_v;
                }


                int
                f_25016_18244_18300(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    this_param.PretendThereArentNoPiaLocalTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 18244, 18300);
                    return 0;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_25016_18396_18441(Microsoft.CodeAnalysis.ModuleMetadata
                this_param, string?
                display)
                {
                    var return_v = this_param.GetReference(display: display);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 18396, 18441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyMetadata
                f_25016_18515_18554(Microsoft.CodeAnalysis.ModuleMetadata
                module)
                {
                    var return_v = AssemblyMetadata.Create(module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 18515, 18554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_25016_18515_18585(Microsoft.CodeAnalysis.AssemblyMetadata
                this_param, string?
                display)
                {
                    var return_v = this_param.GetReference(display: display);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 18515, 18585);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 17954, 18612);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 17954, 18612);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void VerifyOperationTree(string expectedOperationTree, bool skipImplicitlyDeclaredSymbols = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 18624, 18852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 18754, 18841);

                f_25016_18754_18840(_compilation, expectedOperationTree, skipImplicitlyDeclaredSymbols);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 18624, 18852);

                int
                f_25016_18754_18840(Microsoft.CodeAnalysis.Compilation
                compilation, string
                expectedOperationTree, bool
                skipImplicitlyDeclaredSymbols)
                {
                    compilation.VerifyOperationTree(expectedOperationTree, skipImplicitlyDeclaredSymbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 18754, 18840);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 18624, 18852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 18624, 18852);
            }
        }

        public void VerifyOperationTree(string symbolToVerify, string expectedOperationTree, bool skipImplicitlyDeclaredSymbols = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 18864, 19131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 19017, 19120);

                f_25016_19017_19119(_compilation, symbolToVerify, expectedOperationTree, skipImplicitlyDeclaredSymbols);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 18864, 19131);

                int
                f_25016_19017_19119(Microsoft.CodeAnalysis.Compilation
                compilation, string
                symbolToVerify, string
                expectedOperationTree, bool
                skipImplicitlyDeclaredSymbols)
                {
                    compilation.VerifyOperationTree(symbolToVerify, expectedOperationTree, skipImplicitlyDeclaredSymbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 19017, 19119);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 18864, 19131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 18864, 19131);
            }
        }

        public void VerifySynthesizedFields(string containingTypeName, params string[] expectedFields)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25016, 19302, 19994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 19421, 19476);

                var
                types = f_25016_19433_19475(f_25016_19433_19441().Module)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 19490, 19559);

                f_25016_19490_19558(f_25016_19506_19516(types), t => containingTypeName == t.ToString());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 19573, 19926);

                var
                members = f_25016_19587_19925(f_25016_19587_19898(f_25016_19587_19725(f_25016_19587_19698(f_25016_19587_19629(f_25016_19587_19595().Module), e => e.Key.ToString() == containingTypeName)).Value
                                .Where(s => s.Kind == SymbolKind.Field), f => $"{((IFieldSymbol)f.GetISymbol()).Type.ToString()} {f.Name}"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25016, 19940, 19983);

                f_25016_19940_19982(expectedFields, members);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25016, 19302, 19994);

                Microsoft.CodeAnalysis.CodeGen.CompilationTestData
                f_25016_19433_19441()
                {
                    var return_v = TestData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 19433, 19441);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                f_25016_19433_19475(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder?
                this_param)
                {
                    var return_v = this_param.GetAllSynthesizedMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 19433, 19475);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                f_25016_19506_19516(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 19506, 19516);
                    return return_v;
                }


                int
                f_25016_19490_19558(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                collection, System.Predicate<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                filter)
                {
                    Assert.Contains(collection, filter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 19490, 19558);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.CompilationTestData
                f_25016_19587_19595()
                {
                    var return_v = TestData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25016, 19587, 19595);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                f_25016_19587_19629(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    var return_v = this_param.GetAllSynthesizedMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 19587, 19629);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>>
                f_25016_19587_19698(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                source, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>, bool>
                predicate)
                {
                    var return_v = source.Where<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 19587, 19698);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                f_25016_19587_19725(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>>
                source)
                {
                    var return_v = source.Single<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 19587, 19725);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_25016_19587_19898(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                source, System.Func<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, string>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 19587, 19898);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_25016_19587_19925(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.ToList<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 19587, 19925);
                    return return_v;
                }


                int
                f_25016_19940_19982(string[]
                expected, System.Collections.Generic.List<string>
                actual)
                {
                    AssertEx.SetEqual((System.Collections.Generic.IEnumerable<string>)expected, (System.Collections.Generic.IEnumerable<string>)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25016, 19940, 19982);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25016, 19302, 19994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 19302, 19994);
            }
        }

        static CompilationVerifier()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25016, 730, 20001);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25016, 730, 20001);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25016, 730, 20001);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25016, 730, 20001);
    }
}
