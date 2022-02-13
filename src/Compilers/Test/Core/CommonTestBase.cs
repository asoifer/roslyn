// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Operations;
using Roslyn.Test.Utilities;
using Roslyn.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    public enum Verification
    {
        Passes = 0,
        Fails,
        Skipped
    }
    public abstract partial class CommonTestBase : TestBase
    {
        internal CompilationVerifier CompileAndVerifyCommon(
                    Compilation compilation,
                    IEnumerable<ResourceDescription> manifestResources = null,
                    IEnumerable<ModuleData> dependencies = null,
                    Action<IModuleSymbol> sourceSymbolValidator = null,
                    Action<PEAssembly> assemblyValidator = null,
                    Action<IModuleSymbol> symbolValidator = null,
                    SignatureDescription[] expectedSignatures = null,
                    string expectedOutput = null,
                    int? expectedReturnCode = null,
                    string[] args = null,
                    EmitOptions emitOptions = null,
                    Verification verify = Verification.Passes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25015, 1013, 3382);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 1727, 1761);

                f_25015_1727_1760(compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 1777, 2046);

                f_25015_1777_2045(expectedOutput == null || (DynAbs.Tracing.TraceSender.Expression_False(25015, 1795, 1970) || (f_25015_1839_1869(f_25015_1839_1858(compilation)) == OutputKind.ConsoleApplication || (DynAbs.Tracing.TraceSender.Expression_False(25015, 1839, 1969) || f_25015_1906_1936(f_25015_1906_1925(compilation)) == OutputKind.WindowsApplication))), "Compilation must be executable if output is expected.");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 2062, 2242) || true) && (sourceSymbolValidator != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 2062, 2242);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 2129, 2179);

                    var
                    module = f_25015_2142_2178(f_25015_2142_2170(f_25015_2142_2162(compilation)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 2197, 2227);

                    f_25015_2197_2226(sourceSymbolValidator, module);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 2062, 2242);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 2258, 2292);

                CompilationVerifier
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 2308, 2848);

                var
                verifier = f_25015_2323_2847(this, compilation, dependencies, manifestResources, expectedSignatures, expectedOutput, expectedReturnCode, args ?? (DynAbs.Tracing.TraceSender.Expression_Null<string[]?>(25015, 2628, 2657) ?? f_25015_2636_2657()), assemblyValidator, symbolValidator, emitOptions, verify)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 2864, 3105) || true) && (result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 2864, 3105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 2916, 2934);

                    result = verifier;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 2864, 3105);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 2864, 3105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 3062, 3090);

                    f_25015_3062_3089(verifier);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 2864, 3105);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 3312, 3341);

                f_25015_3312_3340(result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 3357, 3371);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25015, 1013, 3382);

                bool
                f_25015_1727_1760(Microsoft.CodeAnalysis.Compilation
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 1727, 1760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_25015_1839_1858(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 1839, 1858);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_25015_1839_1869(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 1839, 1869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_25015_1906_1925(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 1906, 1925);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_25015_1906_1936(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 1906, 1936);
                    return return_v;
                }


                bool
                f_25015_1777_2045(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 1777, 2045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IAssemblySymbol
                f_25015_2142_2162(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 2142, 2162);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IModuleSymbol>
                f_25015_2142_2170(Microsoft.CodeAnalysis.IAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 2142, 2170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IModuleSymbol
                f_25015_2142_2178(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IModuleSymbol>
                source)
                {
                    var return_v = source.First<Microsoft.CodeAnalysis.IModuleSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 2142, 2178);
                    return return_v;
                }


                int
                f_25015_2197_2226(System.Action<Microsoft.CodeAnalysis.IModuleSymbol>
                this_param, Microsoft.CodeAnalysis.IModuleSymbol
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 2197, 2226);
                    return 0;
                }


                string[]
                f_25015_2636_2657()
                {
                    var return_v = Array.Empty<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 2636, 2657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_25015_2323_2847(Microsoft.CodeAnalysis.Test.Utilities.CommonTestBase
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleData>?
                dependencies, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>?
                manifestResources, Microsoft.CodeAnalysis.Test.Utilities.SignatureDescription[]?
                expectedSignatures, string?
                expectedOutput, int?
                expectedReturnCode, string[]
                args, System.Action<Microsoft.CodeAnalysis.PEAssembly>?
                assemblyValidator, System.Action<Microsoft.CodeAnalysis.IModuleSymbol>?
                symbolValidator, Microsoft.CodeAnalysis.Emit.EmitOptions?
                emitOptions, Microsoft.CodeAnalysis.Test.Utilities.Verification
                verify)
                {
                    var return_v = this_param.Emit(compilation, dependencies, manifestResources, expectedSignatures, expectedOutput, expectedReturnCode, args, assemblyValidator, symbolValidator, emitOptions, verify);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 2323, 2847);
                    return return_v;
                }


                bool
                f_25015_3062_3089(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                @object)
                {
                    var return_v = CustomAssert.Null((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 3062, 3089);
                    return return_v;
                }


                bool
                f_25015_3312_3340(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 3312, 3340);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 1013, 3382);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 1013, 3382);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CompilationVerifier CompileAndVerifyFieldMarshalCommon(Compilation compilation, Dictionary<string, byte[]> expectedBlobs, bool isField = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25015, 3394, 3947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 3570, 3936);

                return f_25015_3577_3935(this, compilation, (s, _omitted1) =>
                                {
                                    CustomAssert.True(expectedBlobs.ContainsKey(s), "Expecting marshalling blob for " + (isField ? "field " : "parameter ") + s);
                                    return expectedBlobs[s];
                                }, isField);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25015, 3394, 3947);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_25015_3577_3935(Microsoft.CodeAnalysis.Test.Utilities.CommonTestBase
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, System.Func<string, Microsoft.CodeAnalysis.PEAssembly, byte[]>
                getExpectedBlob, bool
                isField)
                {
                    var return_v = this_param.CompileAndVerifyFieldMarshalCommon(compilation, getExpectedBlob, isField);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 3577, 3935);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 3394, 3947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 3394, 3947);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CompilationVerifier CompileAndVerifyFieldMarshalCommon(Compilation compilation, Func<string, PEAssembly, byte[]> getExpectedBlob, bool isField = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25015, 3959, 4313);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 4143, 4302);

                return f_25015_4150_4301(this, compilation, assemblyValidator: (assembly) => MetadataValidation.MarshalAsMetadataValidator(assembly, getExpectedBlob, isField));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25015, 3959, 4313);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_25015_4150_4301(Microsoft.CodeAnalysis.Test.Utilities.CommonTestBase
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, System.Action<Microsoft.CodeAnalysis.PEAssembly>
                assemblyValidator)
                {
                    var return_v = this_param.CompileAndVerifyCommon(compilation, assemblyValidator: assemblyValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 4150, 4301);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 3959, 4313);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 3959, 4313);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void RunValidators(CompilationVerifier verifier, Action<PEAssembly> assemblyValidator, Action<IModuleSymbol> symbolValidator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25015, 4325, 5415);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 4491, 4563);

                f_25015_4491_4562(assemblyValidator != null || (DynAbs.Tracing.TraceSender.Expression_False(25015, 4509, 4561) || symbolValidator != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 4579, 4624);

                var
                emittedMetadata = f_25015_4601_4623(verifier)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 4640, 4918) || true) && (assemblyValidator != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 4640, 4918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 4703, 4772);

                    f_25015_4703_4771(MetadataImageKind.Assembly, f_25015_4750_4770(emittedMetadata));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 4792, 4857);

                    var
                    assembly = f_25015_4807_4856(((AssemblyMetadata)emittedMetadata))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 4875, 4903);

                    f_25015_4875_4902(assemblyValidator, assembly);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 4640, 4918);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 4934, 5404) || true) && (symbolValidator != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 4934, 5404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 4995, 5208);

                    var
                    reference = (DynAbs.Tracing.TraceSender.Conditional_F1(25015, 5011, 5061) || ((f_25015_5011_5031(emittedMetadata) == MetadataImageKind.Assembly
                    && DynAbs.Tracing.TraceSender.Conditional_F2(25015, 5085, 5135)) || DynAbs.Tracing.TraceSender.Conditional_F3(25015, 5159, 5207))) ? f_25015_5085_5135(((AssemblyMetadata)emittedMetadata)) : f_25015_5159_5207(((ModuleMetadata)emittedMetadata))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 5228, 5341);

                    var
                    moduleSymbol = f_25015_5247_5340(verifier, reference, f_25015_5289_5339(f_25015_5289_5317(f_25015_5289_5309(verifier))))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 5359, 5389);

                    f_25015_5359_5388(symbolValidator, moduleSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 4934, 5404);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25015, 4325, 5415);

                bool
                f_25015_4491_4562(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 4491, 4562);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Metadata
                f_25015_4601_4623(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param)
                {
                    var return_v = this_param.GetMetadata();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 4601, 4623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataImageKind
                f_25015_4750_4770(Microsoft.CodeAnalysis.Metadata
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 4750, 4770);
                    return return_v;
                }


                bool
                f_25015_4703_4771(Microsoft.CodeAnalysis.MetadataImageKind
                expected, Microsoft.CodeAnalysis.MetadataImageKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 4703, 4771);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEAssembly?
                f_25015_4807_4856(Microsoft.CodeAnalysis.AssemblyMetadata
                this_param)
                {
                    var return_v = this_param.GetAssembly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 4807, 4856);
                    return return_v;
                }


                int
                f_25015_4875_4902(System.Action<Microsoft.CodeAnalysis.PEAssembly>
                this_param, Microsoft.CodeAnalysis.PEAssembly?
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 4875, 4902);
                    return 0;
                }


                Microsoft.CodeAnalysis.MetadataImageKind
                f_25015_5011_5031(Microsoft.CodeAnalysis.Metadata
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 5011, 5031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_25015_5085_5135(Microsoft.CodeAnalysis.AssemblyMetadata
                this_param)
                {
                    var return_v = this_param.GetReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 5085, 5135);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_25015_5159_5207(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    var return_v = this_param.GetReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 5159, 5207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_25015_5289_5309(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 5289, 5309);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_25015_5289_5317(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 5289, 5317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataImportOptions
                f_25015_5289_5339(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.MetadataImportOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 5289, 5339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IModuleSymbol
                f_25015_5247_5340(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, Microsoft.CodeAnalysis.PortableExecutableReference
                metadataReference, Microsoft.CodeAnalysis.MetadataImportOptions
                importOptions)
                {
                    var return_v = this_param.GetSymbolFromMetadata((Microsoft.CodeAnalysis.MetadataReference)metadataReference, importOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 5247, 5340);
                    return return_v;
                }


                int
                f_25015_5359_5388(System.Action<Microsoft.CodeAnalysis.IModuleSymbol>
                this_param, Microsoft.CodeAnalysis.IModuleSymbol
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 5359, 5388);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 4325, 5415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 4325, 5415);
            }
        }

        internal CompilationVerifier Emit(
                    Compilation compilation,
                    IEnumerable<ModuleData> dependencies,
                    IEnumerable<ResourceDescription> manifestResources,
                    SignatureDescription[] expectedSignatures,
                    string expectedOutput,
                    int? expectedReturnCode,
                    string[] args,
                    Action<PEAssembly> assemblyValidator,
                    Action<IModuleSymbol> symbolValidator,
                    EmitOptions emitOptions,
                    Verification verify)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25015, 5427, 6570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 5973, 6056);

                var
                verifier = f_25015_5988_6055(compilation, VisualizeRealIL, dependencies)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 6072, 6188);

                f_25015_6072_6187(
                            verifier, expectedOutput, expectedReturnCode, args, manifestResources, emitOptions, verify, expectedSignatures);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 6204, 6527) || true) && (assemblyValidator != null || (DynAbs.Tracing.TraceSender.Expression_False(25015, 6208, 6260) || symbolValidator != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 6204, 6527);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 6452, 6512);

                    f_25015_6452_6511(verifier, assemblyValidator, symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 6204, 6527);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 6543, 6559);

                return verifier;
                DynAbs.Tracing.TraceSender.TraceExitMethod(25015, 5427, 6570);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_25015_5988_6055(Microsoft.CodeAnalysis.Compilation
                compilation, System.Func<Microsoft.CodeAnalysis.IModuleSymbol, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData, System.Collections.Generic.IReadOnlyDictionary<int, string>, bool, string>
                visualizeRealIL, System.Collections.Generic.IEnumerable<Roslyn.Test.Utilities.ModuleData>
                dependencies)
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier(compilation, visualizeRealIL, dependencies);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 5988, 6055);
                    return return_v;
                }


                int
                f_25015_6072_6187(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                expectedOutput, int?
                expectedReturnCode, string[]
                args, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                manifestResources, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions, Microsoft.CodeAnalysis.Test.Utilities.Verification
                peVerify, Microsoft.CodeAnalysis.Test.Utilities.SignatureDescription[]
                expectedSignatures)
                {
                    this_param.Emit(expectedOutput, expectedReturnCode, args, manifestResources, emitOptions, peVerify, expectedSignatures);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 6072, 6187);
                    return 0;
                }


                int
                f_25015_6452_6511(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, System.Action<Microsoft.CodeAnalysis.PEAssembly>?
                assemblyValidator, System.Action<Microsoft.CodeAnalysis.IModuleSymbol>
                symbolValidator)
                {
                    RunValidators(verifier, assemblyValidator, symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 6452, 6511);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 5427, 6570);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 5427, 6570);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<byte> ReadFromFile(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25015, 6815, 6971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 6900, 6960);

                return f_25015_6907_6959(f_25015_6935_6958(path));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25015, 6815, 6971);

                byte[]
                f_25015_6935_6958(string
                path)
                {
                    var return_v = File.ReadAllBytes(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 6935, 6958);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_25015_6907_6959(params byte[]
                items)
                {
                    var return_v = ImmutableArray.Create<byte>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 6907, 6959);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 6815, 6971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 6815, 6971);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void EmitILToArray(
                    string ilSource,
                    bool appendDefaultHeader,
                    bool includePdb,
                    out ImmutableArray<byte> assemblyBytes,
                    out ImmutableArray<byte> pdbBytes,
                    bool autoInherit = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25015, 6983, 7999);
                string assemblyPath = default(string);
                string pdbPath = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 7281, 7409);

                f_25015_7281_7408(ilSource, appendDefaultHeader, includePdb, autoInherit, out assemblyPath, out pdbPath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 7425, 7460);

                f_25015_7425_7459(assemblyPath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 7474, 7522);

                f_25015_7474_7521(pdbPath != null, includePdb);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 7538, 7669);
                using (f_25015_7545_7577(assemblyPath))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 7611, 7654);

                    assemblyBytes = f_25015_7627_7653(assemblyPath);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(25015, 7538, 7669);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 7685, 7988) || true) && (pdbPath != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 7685, 7988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 7738, 7866);
                    using (f_25015_7745_7772(pdbPath))
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 7814, 7847);

                        pdbBytes = f_25015_7825_7846(pdbPath);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(25015, 7738, 7866);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 7685, 7988);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 7685, 7988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 7932, 7973);

                    pdbBytes = default(ImmutableArray<byte>);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 7685, 7988);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25015, 6983, 7999);

                int
                f_25015_7281_7408(string
                declarations, bool
                appendDefaultHeader, bool
                includePdb, bool
                autoInherit, out string
                assemblyPath, out string
                pdbPath)
                {
                    IlasmUtilities.IlasmTempAssembly(declarations, appendDefaultHeader, includePdb, autoInherit, out assemblyPath, out pdbPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 7281, 7408);
                    return 0;
                }


                bool
                f_25015_7425_7459(string
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 7425, 7459);
                    return return_v;
                }


                bool
                f_25015_7474_7521(bool
                expected, bool
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 7474, 7521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
                f_25015_7545_7577(string
                path)
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DisposableFile(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 7545, 7577);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_25015_7627_7653(string
                path)
                {
                    var return_v = ReadFromFile(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 7627, 7653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
                f_25015_7745_7772(string
                path)
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DisposableFile(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 7745, 7772);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_25015_7825_7846(string
                path)
                {
                    var return_v = ReadFromFile(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 7825, 7846);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 6983, 7999);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 6983, 7999);
            }
        }

        internal static MetadataReference CompileIL(string ilSource, bool prependDefaultHeader = true, bool embedInteropTypes = false, bool autoInherit = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25015, 8011, 8475);
                System.Collections.Immutable.ImmutableArray<byte> assemblyBytes = default(System.Collections.Immutable.ImmutableArray<byte>);
                System.Collections.Immutable.ImmutableArray<byte> pdbBytes = default(System.Collections.Immutable.ImmutableArray<byte>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 8187, 8344);

                f_25015_8187_8343(ilSource, prependDefaultHeader, includePdb: false, assemblyBytes: out assemblyBytes, pdbBytes: out pdbBytes, autoInherit: autoInherit);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 8358, 8464);

                return f_25015_8365_8463(f_25015_8365_8412(assemblyBytes), embedInteropTypes: embedInteropTypes);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25015, 8011, 8475);

                int
                f_25015_8187_8343(string
                ilSource, bool
                appendDefaultHeader, bool
                includePdb, out System.Collections.Immutable.ImmutableArray<byte>
                assemblyBytes, out System.Collections.Immutable.ImmutableArray<byte>
                pdbBytes, bool
                autoInherit)
                {
                    EmitILToArray(ilSource, appendDefaultHeader, includePdb: includePdb, out assemblyBytes, out pdbBytes, autoInherit: autoInherit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 8187, 8343);
                    return 0;
                }


                Microsoft.CodeAnalysis.AssemblyMetadata
                f_25015_8365_8412(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = AssemblyMetadata.CreateFromImage(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 8365, 8412);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_25015_8365_8463(Microsoft.CodeAnalysis.AssemblyMetadata
                this_param, bool
                embedInteropTypes)
                {
                    var return_v = this_param.GetReference(embedInteropTypes: embedInteropTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 8365, 8463);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 8011, 8475);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 8011, 8475);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static MetadataReference GetILModuleReference(string ilSource, bool prependDefaultHeader = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25015, 8487, 8841);
                System.Collections.Immutable.ImmutableArray<byte> assemblyBytes = default(System.Collections.Immutable.ImmutableArray<byte>);
                System.Collections.Immutable.ImmutableArray<byte> pdbBytes = default(System.Collections.Immutable.ImmutableArray<byte>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 8617, 8748);

                f_25015_8617_8747(ilSource, prependDefaultHeader, includePdb: false, assemblyBytes: out assemblyBytes, pdbBytes: out pdbBytes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 8762, 8830);

                return f_25015_8769_8829(f_25015_8769_8814(assemblyBytes));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25015, 8487, 8841);

                int
                f_25015_8617_8747(string
                ilSource, bool
                appendDefaultHeader, bool
                includePdb, out System.Collections.Immutable.ImmutableArray<byte>
                assemblyBytes, out System.Collections.Immutable.ImmutableArray<byte>
                pdbBytes)
                {
                    EmitILToArray(ilSource, appendDefaultHeader, includePdb: includePdb, out assemblyBytes, out pdbBytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 8617, 8747);
                    return 0;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_25015_8769_8814(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = ModuleMetadata.CreateFromImage(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 8769, 8814);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_25015_8769_8829(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    var return_v = this_param.GetReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 8769, 8829);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 8487, 8841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 8487, 8841);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected CSharp.CSharpCompilation CreateCSharpCompilation(
                    XCData code,
                    CSharp.CSharpParseOptions parseOptions = null,
                    CSharp.CSharpCompilationOptions compilationOptions = null,
                    string assemblyName = null,
                    IEnumerable<MetadataReference> referencedAssemblies = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25015, 8923, 9427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 9279, 9416);

                return f_25015_9286_9415(this, assemblyName, code, parseOptions, compilationOptions, referencedAssemblies, referencedCompilations: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25015, 8923, 9427);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_25015_9286_9415(Microsoft.CodeAnalysis.Test.Utilities.CommonTestBase
                this_param, string?
                assemblyName, System.Xml.Linq.XCData
                code, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                parseOptions, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
                compilationOptions, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
                referencedAssemblies, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Compilation>
                referencedCompilations)
                {
                    var return_v = this_param.CreateCSharpCompilation(assemblyName, code, parseOptions, compilationOptions, referencedAssemblies, referencedCompilations: referencedCompilations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 9286, 9415);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 8923, 9427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 8923, 9427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected CSharp.CSharpCompilation CreateCSharpCompilation(
                    string assemblyName,
                    XCData code,
                    CSharp.CSharpParseOptions parseOptions = null,
                    CSharp.CSharpCompilationOptions compilationOptions = null,
                    IEnumerable<MetadataReference> referencedAssemblies = null,
                    IEnumerable<Compilation> referencedCompilations = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25015, 9439, 10108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 9857, 10097);

                return f_25015_9864_10096(this, assemblyName, f_25015_9937_9947(code), parseOptions, compilationOptions, referencedAssemblies, referencedCompilations);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25015, 9439, 10108);

                string
                f_25015_9937_9947(System.Xml.Linq.XCData
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 9937, 9947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_25015_9864_10096(Microsoft.CodeAnalysis.Test.Utilities.CommonTestBase
                this_param, string
                assemblyName, string
                code, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                parseOptions, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
                compilationOptions, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
                referencedAssemblies, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Compilation>?
                referencedCompilations)
                {
                    var return_v = this_param.CreateCSharpCompilation(assemblyName, code, parseOptions, compilationOptions, referencedAssemblies, referencedCompilations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 9864, 10096);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 9439, 10108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 9439, 10108);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected VisualBasic.VisualBasicCompilation CreateVisualBasicCompilation(
                    XCData code,
                    VisualBasic.VisualBasicParseOptions parseOptions = null,
                    VisualBasic.VisualBasicCompilationOptions compilationOptions = null,
                    string assemblyName = null,
                    IEnumerable<MetadataReference> referencedAssemblies = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25015, 10120, 10664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 10511, 10653);

                return f_25015_10518_10652(this, assemblyName, code, parseOptions, compilationOptions, referencedAssemblies, referencedCompilations: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25015, 10120, 10664);

                Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation
                f_25015_10518_10652(Microsoft.CodeAnalysis.Test.Utilities.CommonTestBase
                this_param, string?
                assemblyName, System.Xml.Linq.XCData
                code, Microsoft.CodeAnalysis.VisualBasic.VisualBasicParseOptions?
                parseOptions, Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilationOptions?
                compilationOptions, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
                referencedAssemblies, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Compilation>
                referencedCompilations)
                {
                    var return_v = this_param.CreateVisualBasicCompilation(assemblyName, code, parseOptions, compilationOptions, referencedAssemblies, referencedCompilations: referencedCompilations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 10518, 10652);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 10120, 10664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 10120, 10664);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected VisualBasic.VisualBasicCompilation CreateVisualBasicCompilation(
                    string assemblyName,
                    XCData code,
                    VisualBasic.VisualBasicParseOptions parseOptions = null,
                    VisualBasic.VisualBasicCompilationOptions compilationOptions = null,
                    IEnumerable<MetadataReference> referencedAssemblies = null,
                    IEnumerable<Compilation> referencedCompilations = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25015, 10676, 11385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 11129, 11374);

                return f_25015_11136_11373(this, assemblyName, f_25015_11214_11224(code), parseOptions, compilationOptions, referencedAssemblies, referencedCompilations);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25015, 10676, 11385);

                string
                f_25015_11214_11224(System.Xml.Linq.XCData
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 11214, 11224);
                    return return_v;
                }


                Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation
                f_25015_11136_11373(Microsoft.CodeAnalysis.Test.Utilities.CommonTestBase
                this_param, string
                assemblyName, string
                code, Microsoft.CodeAnalysis.VisualBasic.VisualBasicParseOptions?
                parseOptions, Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilationOptions?
                compilationOptions, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
                referencedAssemblies, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Compilation>?
                referencedCompilations)
                {
                    var return_v = this_param.CreateVisualBasicCompilation(assemblyName, code, parseOptions, compilationOptions, referencedAssemblies, referencedCompilations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 11136, 11373);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 10676, 11385);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 10676, 11385);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected CSharp.CSharpCompilation CreateCSharpCompilation(
                    string code,
                    CSharp.CSharpParseOptions parseOptions = null,
                    CSharp.CSharpCompilationOptions compilationOptions = null,
                    string assemblyName = null,
                    IEnumerable<MetadataReference> referencedAssemblies = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25015, 11397, 11901);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 11753, 11890);

                return f_25015_11760_11889(this, assemblyName, code, parseOptions, compilationOptions, referencedAssemblies, referencedCompilations: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25015, 11397, 11901);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_25015_11760_11889(Microsoft.CodeAnalysis.Test.Utilities.CommonTestBase
                this_param, string?
                assemblyName, string
                code, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
                parseOptions, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
                compilationOptions, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
                referencedAssemblies, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Compilation>
                referencedCompilations)
                {
                    var return_v = this_param.CreateCSharpCompilation(assemblyName, code, parseOptions, compilationOptions, referencedAssemblies, referencedCompilations: referencedCompilations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 11760, 11889);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 11397, 11901);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 11397, 11901);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected CSharp.CSharpCompilation CreateCSharpCompilation(
                    string assemblyName,
                    string code,
                    CSharp.CSharpParseOptions parseOptions = null,
                    CSharp.CSharpCompilationOptions compilationOptions = null,
                    IEnumerable<MetadataReference> referencedAssemblies = null,
                    IEnumerable<Compilation> referencedCompilations = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25015, 11913, 13693);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 12331, 12435) || true) && (assemblyName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 12331, 12435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 12389, 12420);

                    assemblyName = f_25015_12404_12419();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 12331, 12435);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 12451, 12671) || true) && (parseOptions == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 12451, 12671);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 12509, 12656);

                    parseOptions = f_25015_12524_12655(f_25015_12524_12609(f_25015_12524_12557(), CSharp.LanguageVersion.Default), DocumentationMode.None);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 12451, 12671);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 12687, 12860) || true) && (compilationOptions == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 12687, 12860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 12751, 12845);

                    compilationOptions = f_25015_12772_12844(OutputKind.DynamicallyLinkedLibrary);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 12687, 12860);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 12876, 12923);

                var
                references = f_25015_12893_12922()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 12937, 13394) || true) && (referencedAssemblies == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 12937, 13394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 13003, 13031);

                    f_25015_13003_13030(references, f_25015_13018_13029());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 13049, 13075);

                    f_25015_13049_13074(references, f_25015_13064_13073());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 13093, 13123);

                    f_25015_13093_13122(references, f_25015_13108_13121());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 13191, 13220);

                    f_25015_13191_13219(                //TODO: references.Add(MsCSRef);
                                    references, f_25015_13206_13218());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 13238, 13271);

                    f_25015_13238_13270(references, f_25015_13253_13269());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 12937, 13394);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 12937, 13394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 13337, 13379);

                    f_25015_13337_13378(references, referencedAssemblies);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 12937, 13394);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 13410, 13472);

                f_25015_13410_13471(this, referencedCompilations, references);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 13488, 13565);

                var
                tree = f_25015_13499_13564(code, options: parseOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 13581, 13682);

                return f_25015_13588_13681(assemblyName, new[] { tree }, references, compilationOptions);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25015, 11913, 13693);

                string
                f_25015_12404_12419()
                {
                    var return_v = GetUniqueName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 12404, 12419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_25015_12524_12557()
                {
                    var return_v = CSharp.CSharpParseOptions.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 12524, 12557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_25015_12524_12609(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = this_param.WithLanguageVersion(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 12524, 12609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_25015_12524_12655(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, Microsoft.CodeAnalysis.DocumentationMode
                documentationMode)
                {
                    var return_v = this_param.WithDocumentationMode(documentationMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 12524, 12655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_25015_12772_12844(Microsoft.CodeAnalysis.OutputKind
                outputKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions(outputKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 12772, 12844);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                f_25015_12893_12922()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 12893, 12922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_25015_13018_13029()
                {
                    var return_v = MscorlibRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 13018, 13029);
                    return return_v;
                }


                int
                f_25015_13003_13030(System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 13003, 13030);
                    return 0;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_25015_13064_13073()
                {
                    var return_v = SystemRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 13064, 13073);
                    return return_v;
                }


                int
                f_25015_13049_13074(System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 13049, 13074);
                    return 0;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_25015_13108_13121()
                {
                    var return_v = SystemCoreRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 13108, 13121);
                    return return_v;
                }


                int
                f_25015_13093_13122(System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 13093, 13122);
                    return 0;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_25015_13206_13218()
                {
                    var return_v = SystemXmlRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 13206, 13218);
                    return return_v;
                }


                int
                f_25015_13191_13219(System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 13191, 13219);
                    return 0;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_25015_13253_13269()
                {
                    var return_v = SystemXmlLinqRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 13253, 13269);
                    return return_v;
                }


                int
                f_25015_13238_13270(System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 13238, 13270);
                    return 0;
                }


                int
                f_25015_13337_13378(System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 13337, 13378);
                    return 0;
                }


                int
                f_25015_13410_13471(Microsoft.CodeAnalysis.Test.Utilities.CommonTestBase
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Compilation>?
                referencedCompilations, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references)
                {
                    this_param.AddReferencedCompilations(referencedCompilations, references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 13410, 13471);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_25015_13499_13564(string
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options)
                {
                    var return_v = CSharp.SyntaxFactory.ParseSyntaxTree(text, options: (Microsoft.CodeAnalysis.ParseOptions)options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 13499, 13564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_25015_13588_13681(string
                assemblyName, Microsoft.CodeAnalysis.SyntaxTree[]
                syntaxTrees, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CSharp.CSharpCompilation.Create(assemblyName, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>)syntaxTrees, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 13588, 13681);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 11913, 13693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 11913, 13693);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected VisualBasic.VisualBasicCompilation CreateVisualBasicCompilation(
                    string code,
                    VisualBasic.VisualBasicParseOptions parseOptions = null,
                    VisualBasic.VisualBasicCompilationOptions compilationOptions = null,
                    string assemblyName = null,
                    IEnumerable<MetadataReference> referencedAssemblies = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25015, 13705, 14249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 14096, 14238);

                return f_25015_14103_14237(this, assemblyName, code, parseOptions, compilationOptions, referencedAssemblies, referencedCompilations: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25015, 13705, 14249);

                Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation
                f_25015_14103_14237(Microsoft.CodeAnalysis.Test.Utilities.CommonTestBase
                this_param, string?
                assemblyName, string
                code, Microsoft.CodeAnalysis.VisualBasic.VisualBasicParseOptions?
                parseOptions, Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilationOptions?
                compilationOptions, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>?
                referencedAssemblies, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Compilation>
                referencedCompilations)
                {
                    var return_v = this_param.CreateVisualBasicCompilation(assemblyName, code, parseOptions, compilationOptions, referencedAssemblies, referencedCompilations: referencedCompilations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 14103, 14237);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 13705, 14249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 13705, 14249);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected VisualBasic.VisualBasicCompilation CreateVisualBasicCompilation(
                    string assemblyName,
                    string code,
                    VisualBasic.VisualBasicParseOptions parseOptions = null,
                    VisualBasic.VisualBasicCompilationOptions compilationOptions = null,
                    IEnumerable<MetadataReference> referencedAssemblies = null,
                    IEnumerable<Compilation> referencedCompilations = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25015, 14261, 16007);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 14714, 14818) || true) && (assemblyName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 14714, 14818);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 14772, 14803);

                    assemblyName = f_25015_14787_14802();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 14714, 14818);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 14834, 14966) || true) && (parseOptions == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 14834, 14966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 14892, 14951);

                    parseOptions = f_25015_14907_14950();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 14834, 14966);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 14982, 15165) || true) && (compilationOptions == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 14982, 15165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 15046, 15150);

                    compilationOptions = f_25015_15067_15149(OutputKind.DynamicallyLinkedLibrary);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 14982, 15165);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 15181, 15228);

                var
                references = f_25015_15198_15227()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 15242, 15691) || true) && (referencedAssemblies == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 15242, 15691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 15308, 15336);

                    f_25015_15308_15335(references, f_25015_15323_15334());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 15354, 15380);

                    f_25015_15354_15379(references, f_25015_15369_15378());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 15398, 15428);

                    f_25015_15398_15427(references, f_25015_15413_15426());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 15446, 15470);

                    f_25015_15446_15469(references, f_25015_15461_15468());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 15488, 15517);

                    f_25015_15488_15516(references, f_25015_15503_15515());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 15535, 15568);

                    f_25015_15535_15567(references, f_25015_15550_15566());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 15242, 15691);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 15242, 15691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 15634, 15676);

                    f_25015_15634_15675(references, referencedAssemblies);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 15242, 15691);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 15707, 15769);

                f_25015_15707_15768(this, referencedCompilations, references);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 15785, 15869);

                var
                tree = f_25015_15796_15868(code, options: parseOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 15885, 15996);

                return f_25015_15892_15995(assemblyName, new[] { tree }, references, compilationOptions);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25015, 14261, 16007);

                string
                f_25015_14787_14802()
                {
                    var return_v = GetUniqueName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 14787, 14802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.VisualBasic.VisualBasicParseOptions
                f_25015_14907_14950()
                {
                    var return_v = VisualBasic.VisualBasicParseOptions.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 14907, 14950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilationOptions
                f_25015_15067_15149(Microsoft.CodeAnalysis.OutputKind
                outputKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilationOptions(outputKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 15067, 15149);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                f_25015_15198_15227()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 15198, 15227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_25015_15323_15334()
                {
                    var return_v = MscorlibRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 15323, 15334);
                    return return_v;
                }


                int
                f_25015_15308_15335(System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 15308, 15335);
                    return 0;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_25015_15369_15378()
                {
                    var return_v = SystemRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 15369, 15378);
                    return return_v;
                }


                int
                f_25015_15354_15379(System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 15354, 15379);
                    return 0;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_25015_15413_15426()
                {
                    var return_v = SystemCoreRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 15413, 15426);
                    return return_v;
                }


                int
                f_25015_15398_15427(System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 15398, 15427);
                    return 0;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_25015_15461_15468()
                {
                    var return_v = MsvbRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 15461, 15468);
                    return return_v;
                }


                int
                f_25015_15446_15469(System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 15446, 15469);
                    return 0;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_25015_15503_15515()
                {
                    var return_v = SystemXmlRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 15503, 15515);
                    return return_v;
                }


                int
                f_25015_15488_15516(System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 15488, 15516);
                    return 0;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_25015_15550_15566()
                {
                    var return_v = SystemXmlLinqRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 15550, 15566);
                    return return_v;
                }


                int
                f_25015_15535_15567(System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 15535, 15567);
                    return 0;
                }


                int
                f_25015_15634_15675(System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 15634, 15675);
                    return 0;
                }


                int
                f_25015_15707_15768(Microsoft.CodeAnalysis.Test.Utilities.CommonTestBase
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Compilation>?
                referencedCompilations, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references)
                {
                    this_param.AddReferencedCompilations(referencedCompilations, references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 15707, 15768);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_25015_15796_15868(string
                text, Microsoft.CodeAnalysis.VisualBasic.VisualBasicParseOptions
                options)
                {
                    var return_v = VisualBasic.VisualBasicSyntaxTree.ParseText(text, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 15796, 15868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation
                f_25015_15892_15995(string
                assemblyName, Microsoft.CodeAnalysis.SyntaxTree[]
                syntaxTrees, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references, Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilationOptions
                options)
                {
                    var return_v = VisualBasic.VisualBasicCompilation.Create(assemblyName, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>)syntaxTrees, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 15892, 15995);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 14261, 16007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 14261, 16007);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddReferencedCompilations(IEnumerable<Compilation> referencedCompilations, List<MetadataReference> references)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25015, 16019, 16443);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 16167, 16432) || true) && (referencedCompilations != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 16167, 16432);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 16235, 16417);
                        foreach (var referencedCompilation in f_25015_16273_16295_I(referencedCompilations))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 16235, 16417);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 16337, 16398);

                            f_25015_16337_16397(references, f_25015_16352_16396(referencedCompilation));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 16235, 16417);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25015, 1, 183);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25015, 1, 183);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 16167, 16432);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(25015, 16019, 16443);

                Microsoft.CodeAnalysis.MetadataReference
                f_25015_16352_16396(Microsoft.CodeAnalysis.Compilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 16352, 16396);
                    return return_v;
                }


                int
                f_25015_16337_16397(System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 16337, 16397);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Compilation>
                f_25015_16273_16295_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Compilation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 16273, 16295);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 16019, 16443);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 16019, 16443);
            }
        }

        internal static MetadataReference AsReference(Compilation comp, bool useCompilationReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25015, 16455, 16674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 16573, 16663);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(25015, 16580, 16603) || ((useCompilationReference && DynAbs.Tracing.TraceSender.Conditional_F2(25015, 16606, 16632)) || DynAbs.Tracing.TraceSender.Conditional_F3(25015, 16635, 16662))) ? f_25015_16606_16632(comp) : f_25015_16635_16662(comp);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25015, 16455, 16674);

                Microsoft.CodeAnalysis.CompilationReference
                f_25015_16606_16632(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.ToMetadataReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 16606, 16632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_25015_16635_16662(Microsoft.CodeAnalysis.Compilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 16635, 16662);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 16455, 16674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 16455, 16674);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string WithWindowsLineBreaks(string source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25015, 16757, 16803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 16760, 16803);
                return f_25015_16760_16803(source, f_25015_16775_16794(), "\r\n"); DynAbs.Tracing.TraceSender.TraceExitMethod(25015, 16757, 16803);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 16757, 16803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 16757, 16803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract string VisualizeRealIL(IModuleSymbol peModule, CompilationTestData.MethodData methodData, IReadOnlyDictionary<int, string> markers, bool areLocalsZeroed);

        internal static Cci.ModulePropertiesForSerialization GetDefaultModulePropertiesForSerialization()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25015, 17112, 18594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 17234, 18583);

                return f_25015_17241_18582(persistentIdentifier: default(Guid), corFlags: CorFlags.ILOnly, fileAlignment: Cci.ModulePropertiesForSerialization.DefaultFileAlignment32Bit, sectionAlignment: Cci.ModulePropertiesForSerialization.DefaultSectionAlignment, targetRuntimeVersion: "v4.0.30319", machine: 0, baseAddress: Cci.ModulePropertiesForSerialization.DefaultExeBaseAddress32Bit, sizeOfHeapReserve: Cci.ModulePropertiesForSerialization.DefaultSizeOfHeapReserve32Bit, sizeOfHeapCommit: Cci.ModulePropertiesForSerialization.DefaultSizeOfHeapCommit32Bit, sizeOfStackReserve: Cci.ModulePropertiesForSerialization.DefaultSizeOfStackReserve32Bit, sizeOfStackCommit: Cci.ModulePropertiesForSerialization.DefaultSizeOfStackCommit32Bit, dllCharacteristics: f_25015_18204_18305(enableHighEntropyVA: true, configureToExecuteInAppContainer: false), subsystem: Subsystem.WindowsCui, imageCharacteristics: Characteristics.Dll, majorSubsystemVersion: 0, minorSubsystemVersion: 0, linkerMajorVersion: 0, linkerMinorVersion: 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25015, 17112, 18594);

                System.Reflection.PortableExecutable.DllCharacteristics
                f_25015_18204_18305(bool
                enableHighEntropyVA, bool
                configureToExecuteInAppContainer)
                {
                    var return_v = Compilation.GetDllCharacteristics(enableHighEntropyVA: enableHighEntropyVA, configureToExecuteInAppContainer: configureToExecuteInAppContainer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 18204, 18305);
                    return return_v;
                }


                Microsoft.Cci.ModulePropertiesForSerialization
                f_25015_17241_18582(System.Guid
                persistentIdentifier, System.Reflection.PortableExecutable.CorFlags
                corFlags, ushort
                fileAlignment, ushort
                sectionAlignment, string
                targetRuntimeVersion, int
                machine, ulong
                baseAddress, ulong
                sizeOfHeapReserve, ulong
                sizeOfHeapCommit, ulong
                sizeOfStackReserve, ulong
                sizeOfStackCommit, System.Reflection.PortableExecutable.DllCharacteristics
                dllCharacteristics, System.Reflection.PortableExecutable.Subsystem
                subsystem, System.Reflection.PortableExecutable.Characteristics
                imageCharacteristics, int
                majorSubsystemVersion, int
                minorSubsystemVersion, int
                linkerMajorVersion, int
                linkerMinorVersion)
                {
                    var return_v = new Microsoft.Cci.ModulePropertiesForSerialization(persistentIdentifier: persistentIdentifier, corFlags: corFlags, fileAlignment: (int)fileAlignment, sectionAlignment: (int)sectionAlignment, targetRuntimeVersion: targetRuntimeVersion, machine: (System.Reflection.PortableExecutable.Machine)machine, baseAddress: baseAddress, sizeOfHeapReserve: sizeOfHeapReserve, sizeOfHeapCommit: sizeOfHeapCommit, sizeOfStackReserve: sizeOfStackReserve, sizeOfStackCommit: sizeOfStackCommit, dllCharacteristics: dllCharacteristics, subsystem: subsystem, imageCharacteristics: imageCharacteristics, majorSubsystemVersion: (ushort)majorSubsystemVersion, minorSubsystemVersion: (ushort)minorSubsystemVersion, linkerMajorVersion: (byte)linkerMajorVersion, linkerMinorVersion: (byte)linkerMinorVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 17241, 18582);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 17112, 18594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 17112, 18594);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void AssertDeclaresType(PEModuleSymbol peModule, WellKnownType type, Accessibility expectedAccessibility)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25015, 18606, 18946);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 18745, 18810);

                var
                name = MetadataTypeName.FromFullName(f_25015_18786_18808(type))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 18824, 18935);

                f_25015_18824_18934(expectedAccessibility, f_25015_18866_18933(f_25015_18866_18911(peModule, ref name)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25015, 18606, 18946);

                string
                f_25015_18786_18808(Microsoft.CodeAnalysis.WellKnownType
                id)
                {
                    var return_v = id.GetMetadataName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 18786, 18808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_25015_18866_18911(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName)
                {
                    var return_v = this_param.LookupTopLevelMetadataType(ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 18866, 18911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_25015_18866_18933(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 18866, 18933);
                    return return_v;
                }


                bool
                f_25015_18824_18934(Microsoft.CodeAnalysis.Accessibility
                expected, Microsoft.CodeAnalysis.Accessibility
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 18824, 18934);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 18606, 18946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 18606, 18946);
            }
        }

        internal static SignatureDescription Signature(string fullyQualifiedTypeName, string memberName, string expectedSignature = "")
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25015, 20038, 20428);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 20190, 20417);

                return new SignatureDescription()
                {
                    FullyQualifiedTypeName = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => fullyQualifiedTypeName, 25015, 20197, 20416),
                    MemberName = memberName,
                    ExpectedSignature = expectedSignature
                };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25015, 20038, 20428);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 20038, 20428);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 20038, 20428);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void VerifyParentOperations(SemanticModel model)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25015, 20502, 21134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 20591, 20637);

                var
                parentMap = f_25015_20607_20636(model)
                ;

                // check parent for each child
                foreach (var (child, parent) in parentMap)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 20877, 20918);

                    f_25015_20877_20917(f_25015_20896_20908(child), parent);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 20938, 21108) || true) && (parent == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 20938, 21108);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 21053, 21089);

                        f_25015_21053_21088(child);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 20938, 21108);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25015, 20502, 21134);

                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.IOperation>
                f_25015_20607_20636(Microsoft.CodeAnalysis.SemanticModel
                model)
                {
                    var return_v = GetParentOperationsMap(model);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 20607, 20636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25015_20896_20908(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 20896, 20908);
                    return return_v;
                }


                bool
                f_25015_20877_20917(Microsoft.CodeAnalysis.IOperation?
                expected, Microsoft.CodeAnalysis.IOperation
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 20877, 20917);
                    return return_v;
                }


                int
                f_25015_21053_21088(Microsoft.CodeAnalysis.IOperation
                root)
                {
                    VerifyOperationTreeContracts(root);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 21053, 21088);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 20502, 21134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 20502, 21134);
            }
        }

        private static Dictionary<IOperation, IOperation> GetParentOperationsMap(SemanticModel model)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25015, 21146, 21907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 21305, 21351);

                var
                topOperations = f_25015_21325_21350()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 21365, 21403);

                var
                root = f_25015_21376_21402(f_25015_21376_21392(model))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 21419, 21468);

                f_25015_21419_21467(model, root, topOperations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 21568, 21619);

                var
                map = f_25015_21578_21618()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 21633, 21869);
                    foreach (var topOperation in f_25015_21662_21675_I(topOperations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 21633, 21869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 21763, 21791);

                        f_25015_21763_21790(                // this is top of the operation tree
                                        map, topOperation, null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 21811, 21854);

                        f_25015_21811_21853(topOperation, map);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 21633, 21869);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25015, 1, 237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25015, 1, 237);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 21885, 21896);

                return map;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25015, 21146, 21907);

                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>
                f_25015_21325_21350()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 21325, 21350);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_25015_21376_21392(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 21376, 21392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25015_21376_21402(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 21376, 21402);
                    return return_v;
                }


                int
                f_25015_21419_21467(Microsoft.CodeAnalysis.SemanticModel
                model, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>
                topOperations)
                {
                    CollectTopOperations(model, node, topOperations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 21419, 21467);
                    return 0;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.IOperation>
                f_25015_21578_21618()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 21578, 21618);
                    return return_v;
                }


                int
                f_25015_21763_21790(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.IOperation>
                this_param, Microsoft.CodeAnalysis.IOperation
                key, Microsoft.CodeAnalysis.IOperation
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 21763, 21790);
                    return 0;
                }


                int
                f_25015_21811_21853(Microsoft.CodeAnalysis.IOperation
                operation, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.IOperation>
                map)
                {
                    CollectParentOperations(operation, map);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 21811, 21853);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>
                f_25015_21662_21675_I(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 21662, 21675);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 21146, 21907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 21146, 21907);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void CollectParentOperations(IOperation operation, Dictionary<IOperation, IOperation> map)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25015, 21919, 22322);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 22125, 22311);
                    foreach (var child in f_25015_22147_22180_I(f_25015_22147_22180(f_25015_22147_22165(operation))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 22125, 22311);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 22214, 22240);

                        f_25015_22214_22239(map, child, operation);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 22260, 22296);

                        f_25015_22260_22295(child, map);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 22125, 22311);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25015, 1, 187);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25015, 1, 187);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25015, 21919, 22322);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25015_22147_22165(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 22147, 22165);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25015_22147_22180(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.WhereNotNull<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 22147, 22180);
                    return return_v;
                }


                int
                f_25015_22214_22239(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.IOperation>
                this_param, Microsoft.CodeAnalysis.IOperation
                key, Microsoft.CodeAnalysis.IOperation
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 22214, 22239);
                    return 0;
                }


                int
                f_25015_22260_22295(Microsoft.CodeAnalysis.IOperation
                operation, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.IOperation>
                map)
                {
                    CollectParentOperations(operation, map);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 22260, 22295);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25015_22147_22180_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 22147, 22180);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 21919, 22322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 21919, 22322);
            }
        }

        private static void CollectTopOperations(SemanticModel model, SyntaxNode node, HashSet<IOperation> topOperations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25015, 22334, 22994);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 22472, 22983);
                    foreach (var child in f_25015_22494_22511_I(f_25015_22494_22511(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 22472, 22983);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 22545, 22587);

                        var
                        operation = f_25015_22561_22586(model, child)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 22605, 22840) || true) && (operation != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 22605, 22840);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 22712, 22741);

                            f_25015_22712_22740(                    // found top operation
                                                topOperations, operation);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 22812, 22821);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 22605, 22840);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 22918, 22968);

                        f_25015_22918_22967(model, child, topOperations);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 22472, 22983);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25015, 1, 512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25015, 1, 512);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25015, 22334, 22994);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_25015_22494_22511(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 22494, 22511);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25015_22561_22586(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetOperation(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 22561, 22586);
                    return return_v;
                }


                bool
                f_25015_22712_22740(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>
                this_param, Microsoft.CodeAnalysis.IOperation
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 22712, 22740);
                    return return_v;
                }


                int
                f_25015_22918_22967(Microsoft.CodeAnalysis.SemanticModel
                model, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>
                topOperations)
                {
                    CollectTopOperations(model, node, topOperations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 22918, 22967);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_25015_22494_22511_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 22494, 22511);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 22334, 22994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 22334, 22994);
            }
        }

        internal static void VerifyClone(SemanticModel model)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25015, 23006, 24593);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 23084, 24582);
                    foreach (var node in f_25015_23105_23149_I(f_25015_23105_23149(f_25015_23105_23131(f_25015_23105_23121(model)))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 23084, 24582);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 23183, 23224);

                        var
                        operation = f_25015_23199_23223(model, node)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 23242, 23333) || true) && (operation == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 23242, 23333);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 23305, 23314);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 23242, 23333);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 23353, 23417);

                        var
                        clonedOperation = f_25015_23375_23416(operation)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 23437, 23487);

                        f_25015_23437_23486(model, f_25015_23462_23485(operation));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 23505, 23561);

                        f_25015_23505_23560(model, f_25015_23530_23559(clonedOperation));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 23579, 23651);

                        f_25015_23579_23650(model, f_25015_23607_23649(((Operation)operation)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 23669, 23781);

                        f_25015_23669_23780(f_25015_23687_23729(((Operation)operation)), f_25015_23731_23779(((Operation)clonedOperation)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 23877, 23961);

                        var
                        original = f_25015_23892_23960(f_25015_23931_23948(model), operation)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 23979, 24067);

                        var
                        cloned = f_25015_23992_24066(f_25015_24031_24048(model), clonedOperation)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 24087, 24124);

                        f_25015_24087_24123(original, cloned);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 24240, 24314);

                        var
                        originalSet = f_25015_24258_24313(f_25015_24282_24312(operation))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 24332, 24410);

                        var
                        clonedSet = f_25015_24348_24409(f_25015_24372_24408(clonedOperation))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 24430, 24485);

                        f_25015_24430_24484(f_25015_24449_24466(originalSet), f_25015_24468_24483(clonedSet));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 24503, 24567);

                        f_25015_24503_24566(0, f_25015_24525_24565(f_25015_24525_24557(originalSet, clonedSet)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 23084, 24582);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25015, 1, 1499);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25015, 1, 1499);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25015, 23006, 24593);

                Microsoft.CodeAnalysis.SyntaxTree
                f_25015_23105_23121(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 23105, 23121);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25015_23105_23131(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 23105, 23131);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_25015_23105_23149(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 23105, 23149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25015_23199_23223(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetOperation(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 23199, 23223);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_25015_23375_23416(Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = OperationCloner.CloneOperation(operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 23375, 23416);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel?
                f_25015_23462_23485(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.SemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 23462, 23485);
                    return return_v;
                }


                bool
                f_25015_23437_23486(Microsoft.CodeAnalysis.SemanticModel
                expected, Microsoft.CodeAnalysis.SemanticModel?
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object?)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 23437, 23486);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel?
                f_25015_23530_23559(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.SemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 23530, 23559);
                    return return_v;
                }


                bool
                f_25015_23505_23560(Microsoft.CodeAnalysis.SemanticModel
                expected, Microsoft.CodeAnalysis.SemanticModel?
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object?)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 23505, 23560);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel?
                f_25015_23607_23649(Microsoft.CodeAnalysis.Operation
                this_param)
                {
                    var return_v = this_param.OwningSemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 23607, 23649);
                    return return_v;
                }


                bool
                f_25015_23579_23650(Microsoft.CodeAnalysis.SemanticModel
                expected, Microsoft.CodeAnalysis.SemanticModel?
                actual)
                {
                    var return_v = CustomAssert.NotSame((object)expected, (object?)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 23579, 23650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel?
                f_25015_23687_23729(Microsoft.CodeAnalysis.Operation
                this_param)
                {
                    var return_v = this_param.OwningSemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 23687, 23729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel?
                f_25015_23731_23779(Microsoft.CodeAnalysis.Operation
                this_param)
                {
                    var return_v = this_param.OwningSemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 23731, 23779);
                    return return_v;
                }


                bool
                f_25015_23669_23780(Microsoft.CodeAnalysis.SemanticModel?
                expected, Microsoft.CodeAnalysis.SemanticModel?
                actual)
                {
                    var return_v = CustomAssert.Same((object?)expected, (object?)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 23669, 23780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_25015_23931_23948(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 23931, 23948);
                    return return_v;
                }


                string
                f_25015_23892_23960(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = OperationTreeVerifier.GetOperationTree(compilation, operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 23892, 23960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_25015_24031_24048(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 24031, 24048);
                    return return_v;
                }


                string
                f_25015_23992_24066(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = OperationTreeVerifier.GetOperationTree(compilation, operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 23992, 24066);
                    return return_v;
                }


                bool
                f_25015_24087_24123(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 24087, 24123);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25015_24282_24312(Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = operation.DescendantsAndSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 24282, 24312);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>
                f_25015_24258_24313(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 24258, 24313);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25015_24372_24408(Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = operation.DescendantsAndSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 24372, 24408);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>
                f_25015_24348_24409(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 24348, 24409);
                    return return_v;
                }


                int
                f_25015_24449_24466(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 24449, 24466);
                    return return_v;
                }


                int
                f_25015_24468_24483(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 24468, 24483);
                    return return_v;
                }


                bool
                f_25015_24430_24484(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 24430, 24484);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25015_24525_24557(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>
                first, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>
                second)
                {
                    var return_v = first.Intersect<Microsoft.CodeAnalysis.IOperation>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 24525, 24557);
                    return return_v;
                }


                int
                f_25015_24525_24565(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.Count<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 24525, 24565);
                    return return_v;
                }


                bool
                f_25015_24503_24566(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 24503, 24566);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_25015_23105_23149_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 23105, 23149);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 23006, 24593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 23006, 24593);
            }
        }

        private static void VerifyOperationTreeContracts(IOperation root)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25015, 24605, 25336);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 24695, 24753);

                var
                semanticModel = f_25015_24715_24752(((Operation)root))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 24767, 24828);

                var
                set = f_25015_24777_24827(f_25015_24801_24826(root))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 24844, 25325);
                    foreach (var child in f_25015_24866_24891_I(f_25015_24866_24891(root)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 24844, 25325);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 25011, 25070);

                        f_25015_25011_25069(semanticModel, set, f_25015_25056_25068(child));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 25231, 25310);

                        f_25015_25231_25309(f_25015_25249_25267(semanticModel).FullSpan.Contains(f_25015_25286_25307(f_25015_25286_25298(child))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 24844, 25325);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25015, 1, 482);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25015, 1, 482);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25015, 24605, 25336);

                Microsoft.CodeAnalysis.SemanticModel?
                f_25015_24715_24752(Microsoft.CodeAnalysis.Operation
                this_param)
                {
                    var return_v = this_param.OwningSemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 24715, 24752);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25015_24801_24826(Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = operation.DescendantsAndSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 24801, 24826);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>
                f_25015_24777_24827(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                collection)
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 24777, 24827);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25015_24866_24891(Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = operation.DescendantsAndSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 24866, 24891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25015_25056_25068(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 25056, 25068);
                    return return_v;
                }


                int
                f_25015_25011_25069(Microsoft.CodeAnalysis.SemanticModel?
                semanticModel, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>
                set, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    VerifyOperationTreeSpine(semanticModel, set, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 25011, 25069);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25015_25249_25267(Microsoft.CodeAnalysis.SemanticModel?
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 25249, 25267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_25015_25286_25298(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 25286, 25298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_25015_25286_25307(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.FullSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 25286, 25307);
                    return return_v;
                }


                bool
                f_25015_25231_25309(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 25231, 25309);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_25015_24866_24891_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 24866, 24891);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 24605, 25336);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 24605, 25336);
            }
        }

        private static void VerifyOperationTreeSpine(
                    SemanticModel semanticModel, HashSet<IOperation> set, SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25015, 25348, 25826);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 25502, 25815) || true) && (node != f_25015_25517_25535(semanticModel))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 25502, 25815);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 25569, 25618);

                        var
                        operation = f_25015_25585_25617(semanticModel, node)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 25636, 25761) || true) && (operation != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 25636, 25761);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 25699, 25742);

                            f_25015_25699_25741(f_25015_25717_25740(set, operation));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 25636, 25761);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 25781, 25800);

                        node = f_25015_25788_25799(node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 25502, 25815);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25015, 25502, 25815);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25015, 25502, 25815);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25015, 25348, 25826);

                Microsoft.CodeAnalysis.SyntaxNode
                f_25015_25517_25535(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 25517, 25535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_25015_25585_25617(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode?
                node)
                {
                    var return_v = this_param.GetOperation(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 25585, 25617);
                    return return_v;
                }


                bool
                f_25015_25717_25740(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>
                this_param, Microsoft.CodeAnalysis.IOperation
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 25717, 25740);
                    return return_v;
                }


                bool
                f_25015_25699_25741(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 25699, 25741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_25015_25788_25799(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 25788, 25799);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 25348, 25826);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 25348, 25826);
            }
        }

        public static IEnumerable<object[]> ExternalPdbFormats
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25015, 25973, 26575);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 26009, 26560) || true) && (f_25015_26013_26045())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 26009, 26560);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 26087, 26308);

                        return new List<object[]>()
                    {
                        DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => new object[] { DebugInformationFormat.Pdb },25015,26094,26307),                        new object[] { DebugInformationFormat.PortablePdb }
                    };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 26009, 26560);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25015, 26009, 26560);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 26390, 26541);

                        return new List<object[]>()
                    {
                        DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => new object[] { DebugInformationFormat.PortablePdb },25015,26397,26540)
                    };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25015, 26009, 26560);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25015, 25973, 26575);

                    bool
                    f_25015_26013_26045()
                    {
                        var return_v = ExecutionConditionUtil.IsWindows;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 26013, 26045);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 25894, 26586);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 25894, 26586);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static IEnumerable<object[]> PdbFormats
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25015, 26645, 26795);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25015, 26661, 26795);
                    return new List<object[]>(f_25015_26680_26698())
            {
                DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => new object[] { DebugInformationFormat.Embedded },25015,26661,26795)
            }; DynAbs.Tracing.TraceSender.TraceExitMethod(25015, 26645, 26795);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25015, 26645, 26795);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 26645, 26795);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CommonTestBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(25015, 917, 26825);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(25015, 917, 26825);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 917, 26825);
        }


        static CommonTestBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25015, 917, 26825);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25015, 917, 26825);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25015, 917, 26825);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25015, 917, 26825);

        static string
        f_25015_16775_16794()
        {
            var return_v = Environment.NewLine;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 16775, 16794);
            return return_v;
        }


        static string
        f_25015_16760_16803(string
        this_param, string
        oldValue, string
        newValue)
        {
            var return_v = this_param.Replace(oldValue, newValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25015, 16760, 16803);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<object[]>
        f_25015_26680_26698()
        {
            var return_v = ExternalPdbFormats;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25015, 26680, 26698);
            return return_v;
        }

    }
}
