// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata;
using System.Threading;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.Emit;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal static class EmitHelpers
    {
        internal static EmitDifferenceResult EmitDifference(
                    CSharpCompilation compilation,
                    EmitBaseline baseline,
                    IEnumerable<SemanticEdit> edits,
                    Func<ISymbol, bool> isAddedSymbol,
                    Stream metadataStream,
                    Stream ilStream,
                    Stream pdbStream,
                    ICollection<MethodDefinitionHandle> updatedMethods,
                    CompilationTestData testData,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10941, 589, 4430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 1095, 1141);

                var
                diagnostics = f_10941_1113_1140()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 1157, 1313);

                var
                emitOptions = f_10941_1175_1312(EmitOptions.Default, (DynAbs.Tracing.TraceSender.Conditional_F1(10941, 1222, 1245) || ((baseline.HasPortablePdb && DynAbs.Tracing.TraceSender.Conditional_F2(10941, 1248, 1282)) || DynAbs.Tracing.TraceSender.Conditional_F3(10941, 1285, 1311))) ? DebugInformationFormat.PortablePdb : DebugInformationFormat.Pdb)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 1327, 1417);

                string
                runtimeMDVersion = f_10941_1353_1416(compilation, emitOptions, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 1431, 1569);

                var
                serializationProperties = f_10941_1461_1568(compilation, emitOptions, runtimeMDVersion, baseline.ModuleVersionId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 1583, 1669);

                var
                manifestResources = f_10941_1607_1668()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 1685, 1725);

                PEDeltaAssemblyBuilder
                moduleBeingBuilt
                = default(PEDeltaAssemblyBuilder);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 1775, 2250);

                    moduleBeingBuilt = f_10941_1794_2249(f_10941_1843_1869(compilation), emitOptions: emitOptions, outputKind: f_10941_1951_1981(f_10941_1951_1970(compilation)), serializationProperties: serializationProperties, manifestResources: manifestResources, previousGeneration: baseline, edits: edits, isAddedSymbol: isAddedSymbol);
                }
                catch (NotSupportedException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10941, 2279, 2665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 2414, 2522);

                    f_10941_2414_2521(                // TODO: https://github.com/dotnet/roslyn/issues/9004
                                    diagnostics, ErrorCode.ERR_ModuleEmitFailure, NoLocation.Singleton, f_10941_2485_2509(compilation), f_10941_2511_2520(e));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 2540, 2650);

                    return f_10941_2547_2649(success: false, diagnostics: f_10941_2601_2632(diagnostics), baseline: null);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10941, 2279, 2665);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 2681, 2856) || true) && (testData != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10941, 2681, 2856);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 2735, 2788);

                    f_10941_2735_2787(moduleBeingBuilt, testData.Methods);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 2806, 2841);

                    testData.Module = moduleBeingBuilt;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10941, 2681, 2856);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 2872, 2929);

                var
                definitionMap = f_10941_2892_2928(moduleBeingBuilt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 2943, 2982);

                var
                changes = f_10941_2957_2981(moduleBeingBuilt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 2998, 3030);

                EmitBaseline
                newBaseline = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 3046, 4220) || true) && (f_10941_3050_3317(compilation, moduleBeingBuilt, emittingPdb: true, diagnostics: diagnostics, filterOpt: s => changes.RequiresCompilation(s.GetISymbol()), cancellationToken: cancellationToken))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10941, 3046, 4220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 3617, 3686);

                    var
                    mappedBaseline = f_10941_3638_3685(compilation, moduleBeingBuilt)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 3706, 4205);

                    newBaseline = f_10941_3720_4204(compilation, moduleBeingBuilt, mappedBaseline, definitionMap, changes, metadataStream, ilStream, pdbStream, updatedMethods, diagnostics, DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(testData, 10941, 4091, 4117)?.SymWriterFactory, f_10941_4140_4163(emitOptions), cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10941, 3046, 4220);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 4236, 4419);

                return f_10941_4243_4418(success: newBaseline != null, diagnostics: f_10941_4346_4377(diagnostics), baseline: newBaseline);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10941, 589, 4430);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10941_1113_1140()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 1113, 1140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_10941_1175_1312(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format)
                {
                    var return_v = this_param.WithDebugInformationFormat(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 1175, 1312);
                    return return_v;
                }


                string?
                f_10941_1353_1416(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetRuntimeMetadataVersion(emitOptions, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 1353, 1416);
                    return return_v;
                }


                Microsoft.Cci.ModulePropertiesForSerialization
                f_10941_1461_1568(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions, string?
                targetRuntimeVersion, System.Guid
                moduleVersionId)
                {
                    var return_v = this_param.ConstructModuleSerializationProperties(emitOptions, targetRuntimeVersion, moduleVersionId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 1461, 1568);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                f_10941_1607_1668()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<ResourceDescription>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 1607, 1668);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_10941_1843_1869(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10941, 1843, 1869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10941_1951_1970(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10941, 1951, 1970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10941_1951_1981(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10941, 1951, 1981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.PEDeltaAssemblyBuilder
                f_10941_1794_2249(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                sourceAssembly, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions, Microsoft.CodeAnalysis.OutputKind
                outputKind, Microsoft.Cci.ModulePropertiesForSerialization
                serializationProperties, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                manifestResources, Microsoft.CodeAnalysis.Emit.EmitBaseline
                previousGeneration, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.SemanticEdit>
                edits, System.Func<Microsoft.CodeAnalysis.ISymbol, bool>
                isAddedSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.PEDeltaAssemblyBuilder(sourceAssembly, emitOptions: emitOptions, outputKind: outputKind, serializationProperties: serializationProperties, manifestResources: manifestResources, previousGeneration: previousGeneration, edits: edits, isAddedSymbol: isAddedSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 1794, 2249);
                    return return_v;
                }


                string?
                f_10941_2485_2509(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.AssemblyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10941, 2485, 2509);
                    return return_v;
                }


                string
                f_10941_2511_2520(System.NotSupportedException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10941, 2511, 2520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10941_2414_2521(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 2414, 2521);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10941_2601_2632(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 2601, 2632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitDifferenceResult
                f_10941_2547_2649(bool
                success, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.Emit.EmitBaseline
                baseline)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EmitDifferenceResult(success: success, diagnostics: diagnostics, baseline: baseline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 2547, 2649);
                    return return_v;
                }


                int
                f_10941_2735_2787(Microsoft.CodeAnalysis.CSharp.Emit.PEDeltaAssemblyBuilder
                this_param, System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                methods)
                {
                    this_param.SetMethodTestData(methods);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 2735, 2787);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.CSharpDefinitionMap
                f_10941_2892_2928(Microsoft.CodeAnalysis.CSharp.Emit.PEDeltaAssemblyBuilder
                this_param)
                {
                    var return_v = this_param.PreviousDefinitions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10941, 2892, 2928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.SymbolChanges
                f_10941_2957_2981(Microsoft.CodeAnalysis.CSharp.Emit.PEDeltaAssemblyBuilder
                this_param)
                {
                    var return_v = this_param.Changes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10941, 2957, 2981);
                    return return_v;
                }


                bool
                f_10941_3050_3317(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEDeltaAssemblyBuilder
                moduleBuilder, bool
                emittingPdb, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Predicate<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>?
                filterOpt, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.Compile((Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder)moduleBuilder, emittingPdb: emittingPdb, diagnostics: diagnostics, filterOpt: filterOpt, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 3050, 3317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitBaseline
                f_10941_3638_3685(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Emit.PEDeltaAssemblyBuilder
                moduleBeingBuilt)
                {
                    var return_v = MapToCompilation(compilation, moduleBeingBuilt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 3638, 3685);
                    return return_v;
                }


                string?
                f_10941_4140_4163(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.PdbFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10941, 4140, 4163);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitBaseline?
                f_10941_3720_4204(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEDeltaAssemblyBuilder
                moduleBeingBuilt, Microsoft.CodeAnalysis.Emit.EmitBaseline
                baseline, Microsoft.CodeAnalysis.CSharp.Emit.CSharpDefinitionMap
                definitionMap, Microsoft.CodeAnalysis.Emit.SymbolChanges
                changes, System.IO.Stream
                metadataStream, System.IO.Stream
                ilStream, System.IO.Stream
                pdbStream, System.Collections.Generic.ICollection<System.Reflection.Metadata.MethodDefinitionHandle>
                updatedMethods, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Func<Microsoft.DiaSymReader.ISymWriterMetadataProvider, Microsoft.DiaSymReader.SymUnmanagedWriter>?
                testSymWriterFactory, string?
                pdbFilePath, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.SerializeToDeltaStreams((Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder)moduleBeingBuilt, baseline, (Microsoft.CodeAnalysis.Emit.DefinitionMap)definitionMap, changes, metadataStream, ilStream, pdbStream, updatedMethods, diagnostics, testSymWriterFactory, pdbFilePath, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 3720, 4204);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10941_4346_4377(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 4346, 4377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitDifferenceResult
                f_10941_4243_4418(bool
                success, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.Emit.EmitBaseline?
                baseline)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EmitDifferenceResult(success: success, diagnostics: diagnostics, baseline: baseline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 4243, 4418);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10941, 589, 4430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10941, 589, 4430);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static EmitBaseline MapToCompilation(
                    CSharpCompilation compilation,
                    PEDeltaAssemblyBuilder moduleBeingBuilt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10941, 4935, 7288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 5103, 5164);

                var
                previousGeneration = f_10941_5128_5163(moduleBeingBuilt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 5178, 5238);

                f_10941_5178_5237(previousGeneration.Compilation != compilation);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 5254, 5599) || true) && (previousGeneration.Ordinal == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10941, 5254, 5599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 5558, 5584);

                    return previousGeneration;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10941, 5254, 5599);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 5615, 5691);

                var
                currentSynthesizedMembers = f_10941_5647_5690(moduleBeingBuilt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 5773, 5835);

                var
                anonymousTypeMap = f_10941_5796_5834(moduleBeingBuilt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 5849, 5937);

                var
                sourceAssembly = f_10941_5870_5936(((CSharpCompilation)previousGeneration.Compilation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 5951, 6117);

                var
                sourceContext = f_10941_5971_6116((PEModuleBuilder)previousGeneration.PEModuleBuilder, null, f_10941_6046_6065(), metadataOnly: false, includePrivateMembers: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 6131, 6261);

                var
                otherContext = f_10941_6150_6260(moduleBeingBuilt, null, f_10941_6190_6209(), metadataOnly: false, includePrivateMembers: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 6277, 6536);

                var
                matcher = f_10941_6291_6535(anonymousTypeMap, sourceAssembly, sourceContext, f_10941_6433_6459(compilation), otherContext, currentSynthesizedMembers)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 6552, 6679);

                var
                mappedSynthesizedMembers = f_10941_6583_6678(matcher, previousGeneration.SynthesizedMembers, currentSynthesizedMembers)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 6767, 7050);

                var
                matcherWithAllSynthesizedMembers = f_10941_6806_7049(anonymousTypeMap, sourceAssembly, sourceContext, f_10941_6948_6974(compilation), otherContext, mappedSynthesizedMembers)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10941, 7066, 7277);

                return f_10941_7073_7276(matcherWithAllSynthesizedMembers, previousGeneration, compilation, moduleBeingBuilt, mappedSynthesizedMembers);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10941, 4935, 7288);

                Microsoft.CodeAnalysis.Emit.EmitBaseline
                f_10941_5128_5163(Microsoft.CodeAnalysis.CSharp.Emit.PEDeltaAssemblyBuilder
                this_param)
                {
                    var return_v = this_param.PreviousGeneration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10941, 5128, 5163);
                    return return_v;
                }


                int
                f_10941_5178_5237(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 5178, 5237);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                f_10941_5647_5690(Microsoft.CodeAnalysis.CSharp.Emit.PEDeltaAssemblyBuilder
                this_param)
                {
                    var return_v = this_param.GetAllSynthesizedMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 5647, 5690);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                f_10941_5796_5834(Microsoft.CodeAnalysis.CSharp.Emit.PEDeltaAssemblyBuilder
                this_param)
                {
                    var return_v = this_param.GetAnonymousTypeMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 5796, 5834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_10941_5870_5936(Microsoft.CodeAnalysis.CSharp.CSharpCompilation?
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10941, 5870, 5936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10941_6046_6065()
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 6046, 6065);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitContext
                f_10941_5971_6116(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
                module, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                metadataOnly, bool
                includePrivateMembers)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EmitContext((Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder?)module, syntaxNodeOpt, diagnostics, metadataOnly: metadataOnly, includePrivateMembers: includePrivateMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 5971, 6116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10941_6190_6209()
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 6190, 6209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitContext
                f_10941_6150_6260(Microsoft.CodeAnalysis.CSharp.Emit.PEDeltaAssemblyBuilder
                module, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                metadataOnly, bool
                includePrivateMembers)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EmitContext((Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder)module, syntaxNodeOpt, diagnostics, metadataOnly: metadataOnly, includePrivateMembers: includePrivateMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 6150, 6260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_10941_6433_6459(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10941, 6433, 6459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher
                f_10941_6291_6535(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                anonymousTypeMap, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                sourceAssembly, Microsoft.CodeAnalysis.Emit.EmitContext
                sourceContext, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                otherAssembly, Microsoft.CodeAnalysis.Emit.EmitContext
                otherContext, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                otherSynthesizedMembersOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher(anonymousTypeMap, sourceAssembly, sourceContext, otherAssembly, otherContext, otherSynthesizedMembersOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 6291, 6535);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                f_10941_6583_6678(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher
                this_param, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                previousMembers, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                newMembers)
                {
                    var return_v = this_param.MapSynthesizedMembers(previousMembers, newMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 6583, 6678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_10941_6948_6974(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10941, 6948, 6974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher
                f_10941_6806_7049(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                anonymousTypeMap, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                sourceAssembly, Microsoft.CodeAnalysis.Emit.EmitContext
                sourceContext, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                otherAssembly, Microsoft.CodeAnalysis.Emit.EmitContext
                otherContext, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                otherSynthesizedMembersOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher(anonymousTypeMap, sourceAssembly, sourceContext, otherAssembly, otherContext, otherSynthesizedMembersOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 6806, 7049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitBaseline
                f_10941_7073_7276(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher
                this_param, Microsoft.CodeAnalysis.Emit.EmitBaseline
                baseline, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                targetCompilation, Microsoft.CodeAnalysis.CSharp.Emit.PEDeltaAssemblyBuilder
                targetModuleBuilder, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                mappedSynthesizedMembers)
                {
                    var return_v = this_param.MapBaselineToCompilation(baseline, (Microsoft.CodeAnalysis.Compilation)targetCompilation, (Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder)targetModuleBuilder, mappedSynthesizedMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10941, 7073, 7276);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10941, 4935, 7288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10941, 4935, 7288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EmitHelpers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10941, 539, 7295);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10941, 539, 7295);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10941, 539, 7295);
        }

    }
}
