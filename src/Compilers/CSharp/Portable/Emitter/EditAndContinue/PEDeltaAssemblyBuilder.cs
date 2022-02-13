// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal sealed class PEDeltaAssemblyBuilder : PEAssemblyBuilderBase, IPEDeltaAssemblyBuilder
    {
        private readonly EmitBaseline _previousGeneration;

        private readonly CSharpDefinitionMap _previousDefinitions;

        private readonly SymbolChanges _changes;

        private readonly CSharpSymbolMatcher.DeepTranslator _deepTranslator;

        public PEDeltaAssemblyBuilder(
                    SourceAssemblySymbol sourceAssembly,
                    EmitOptions emitOptions,
                    OutputKind outputKind,
                    Cci.ModulePropertiesForSerialization serializationProperties,
                    IEnumerable<ResourceDescription> manifestResources,
                    EmitBaseline previousGeneration,
                    IEnumerable<SemanticEdit> edits,
                    Func<ISymbol, bool> isAddedSymbol)
        : base(f_10942_1564_1578_C(sourceAssembly), emitOptions, outputKind, serializationProperties, manifestResources, additionalTypes: ImmutableArray<NamedTypeSymbol>.Empty)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10942, 1109, 4929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 881, 900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 948, 968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 1010, 1018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 1081, 1096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 1729, 1786);

                var
                initialBaseline = f_10942_1751_1785(previousGeneration)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 1800, 1913);

                var
                context = f_10942_1814_1912(this, null, f_10942_1842_1861(), metadataOnly: false, includePrivateMembers: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 2188, 2291);

                var
                metadataSymbols = f_10942_2210_2290(initialBaseline, f_10942_2254_2289(sourceAssembly))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 2305, 2376);

                var
                metadataDecoder = (MetadataDecoder)metadataSymbols.MetadataDecoder
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 2390, 2479);

                var
                metadataAssembly = (PEAssemblySymbol)f_10942_2431_2478(f_10942_2431_2459(metadataDecoder))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 2495, 2616);

                var
                matchToMetadata = f_10942_2517_2615(metadataSymbols.AnonymousTypes, sourceAssembly, context, metadataAssembly)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 2632, 2675);

                CSharpSymbolMatcher
                matchToPrevious = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 2689, 3461) || true) && (previousGeneration.Ordinal > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10942, 2689, 3461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 2757, 2847);

                    var
                    previousAssembly = f_10942_2780_2846(((CSharpCompilation)previousGeneration.Compilation))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 2865, 3033);

                    var
                    previousContext = f_10942_2887_3032((PEModuleBuilder)previousGeneration.PEModuleBuilder, null, f_10942_2962_2981(), metadataOnly: false, includePrivateMembers: true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 3053, 3446);

                    matchToPrevious = f_10942_3071_3445(f_10942_3117_3152(previousGeneration), sourceAssembly: sourceAssembly, sourceContext: context, otherAssembly: previousAssembly, otherContext: previousContext, otherSynthesizedMembersOpt: previousGeneration.SynthesizedMembers);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10942, 2689, 3461);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 3477, 3582);

                _previousDefinitions = f_10942_3500_3581(edits, metadataDecoder, matchToMetadata, matchToPrevious);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 3596, 3637);

                _previousGeneration = previousGeneration;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 3651, 3730);

                _changes = f_10942_3662_3729(_previousDefinitions, edits, isAddedSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 4803, 4918);

                _deepTranslator = f_10942_4821_4917(f_10942_4860_4916(sourceAssembly, SpecialType.System_Object));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10942, 1109, 4929);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10942, 1109, 4929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10942, 1109, 4929);
            }
        }

        public override int CurrentGenerationOrdinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10942, 4986, 5020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 4989, 5020);
                    return _previousGeneration.Ordinal + 1; DynAbs.Tracing.TraceSender.TraceExitMethod(10942, 4986, 5020);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10942, 4986, 5020);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10942, 4986, 5020);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Cci.ITypeReference EncTranslateLocalVariableType(TypeSymbol type, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10942, 5033, 5719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 5408, 5462);

                var
                visited = (TypeSymbol)f_10942_5434_5461(_deepTranslator, type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 5476, 5514);

                f_10942_5476_5513((object)visited != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 5655, 5708);

                return f_10942_5662_5707(this, visited ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>(10942, 5672, 5687) ?? type), null, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10942, 5033, 5719);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10942_5434_5461(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.DeepTranslator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 5434, 5461);
                    return return_v;
                }


                int
                f_10942_5476_5513(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 5476, 5513);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_10942_5662_5707(Microsoft.CodeAnalysis.CSharp.Emit.PEDeltaAssemblyBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 5662, 5707);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10942, 5033, 5719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10942, 5033, 5719);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static EmitBaseline.MetadataSymbols GetOrCreateMetadataSymbols(EmitBaseline initialBaseline, CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10942, 5731, 7194);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 5887, 6026) || true) && (initialBaseline.LazyMetadataSymbols != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10942, 5887, 6026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 5968, 6011);

                    return initialBaseline.LazyMetadataSymbols;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10942, 5887, 6026);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 6042, 6098);

                var
                originalMetadata = f_10942_6065_6097(initialBaseline)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 6330, 6391);

                var
                metadataCompilation = f_10942_6356_6390(compilation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 6407, 6492);

                ImmutableDictionary<AssemblyIdentity, AssemblyIdentity>
                assemblyReferenceIdentityMap
                = default(ImmutableDictionary<AssemblyIdentity, AssemblyIdentity>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 6506, 6716);

                var
                metadataAssembly = f_10942_6529_6715(f_10942_6529_6575(metadataCompilation), f_10942_6612_6653(originalMetadata), MetadataImportOptions.All, out assemblyReferenceIdentityMap)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 6730, 6804);

                var
                metadataDecoder = f_10942_6752_6803(f_10942_6772_6802(metadataAssembly))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 6818, 6929);

                var
                metadataAnonymousTypes = f_10942_6847_6928(f_10942_6879_6910(originalMetadata), metadataDecoder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 6943, 7069);

                var
                metadataSymbols = f_10942_6965_7068(metadataAnonymousTypes, metadataDecoder, assemblyReferenceIdentityMap)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 7085, 7183);

                return f_10942_7092_7182(ref initialBaseline.LazyMetadataSymbols, metadataSymbols);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10942, 5731, 7194);

                Microsoft.CodeAnalysis.ModuleMetadata
                f_10942_6065_6097(Microsoft.CodeAnalysis.Emit.EmitBaseline
                this_param)
                {
                    var return_v = this_param.OriginalMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10942, 6065, 6097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10942_6356_6390(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.RemoveAllSyntaxTrees();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 6356, 6390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                f_10942_6529_6575(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetBoundReferenceManager();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 6529, 6575);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyMetadata
                f_10942_6612_6653(Microsoft.CodeAnalysis.ModuleMetadata
                module)
                {
                    var return_v = AssemblyMetadata.Create(module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 6612, 6653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                f_10942_6529_6715(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                this_param, Microsoft.CodeAnalysis.AssemblyMetadata
                metadata, Microsoft.CodeAnalysis.MetadataImportOptions
                importOptions, out System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.AssemblyIdentity>
                assemblyReferenceIdentityMap)
                {
                    var return_v = this_param.CreatePEAssemblyForAssemblyMetadata(metadata, importOptions, out assemblyReferenceIdentityMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 6529, 6715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10942_6772_6802(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                this_param)
                {
                    var return_v = this_param.PrimaryModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10942, 6772, 6802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                f_10942_6752_6803(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 6752, 6803);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_10942_6879_6910(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    var return_v = this_param.MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10942, 6879, 6910);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                f_10942_6847_6928(System.Reflection.Metadata.MetadataReader
                reader, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                metadataDecoder)
                {
                    var return_v = GetAnonymousTypeMapFromMetadata(reader, metadataDecoder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 6847, 6928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitBaseline.MetadataSymbols
                f_10942_6965_7068(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                anonymousTypes, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                metadataDecoder, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.AssemblyIdentity>
                assemblyReferenceIdentityMap)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EmitBaseline.MetadataSymbols(anonymousTypes, (object)metadataDecoder, assemblyReferenceIdentityMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 6965, 7068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitBaseline.MetadataSymbols
                f_10942_7092_7182(ref Microsoft.CodeAnalysis.Emit.EmitBaseline.MetadataSymbols?
                target, Microsoft.CodeAnalysis.Emit.EmitBaseline.MetadataSymbols
                value)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 7092, 7182);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10942, 5731, 7194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10942, 5731, 7194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IReadOnlyDictionary<AnonymousTypeKey, AnonymousTypeValue> GetAnonymousTypeMapFromMetadata(MetadataReader reader, MetadataDecoder metadataDecoder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10942, 7239, 8880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 7425, 7493);

                var
                result = f_10942_7438_7492()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 7507, 8841);
                    foreach (var handle in f_10942_7530_7552_I(f_10942_7530_7552(reader)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10942, 7507, 8841);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 7586, 7629);

                        var
                        def = f_10942_7596_7628(reader, handle)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 7647, 7741) || true) && (f_10942_7651_7671_M(!def.Namespace.IsNil))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10942, 7647, 7741);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 7713, 7722);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10942, 7647, 7741);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 7759, 7912) || true) && (!reader.StringComparer.StartsWith(def.Name, GeneratedNames.AnonymousNamePrefix))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10942, 7759, 7912);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 7884, 7893);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10942, 7759, 7912);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 7930, 7976);

                        var
                        metadataName = f_10942_7949_7975(reader, def.Name)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 7994, 8006);

                        short
                        arity
                        = default(short);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 8024, 8114);

                        var
                        name = f_10942_8035_8113(metadataName, out arity)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 8132, 8142);

                        int
                        index
                        = default(int);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 8160, 8826) || true) && (f_10942_8164_8229(name, out index))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10942, 8160, 8826);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 8271, 8335);

                            var
                            builder = f_10942_8285_8334()
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 8357, 8770) || true) && (f_10942_8361_8405(reader, def, builder))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10942, 8357, 8770);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 8455, 8522);

                                var
                                type = (NamedTypeSymbol)f_10942_8483_8521(metadataDecoder, handle)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 8548, 8602);

                                var
                                key = f_10942_8558_8601(f_10942_8579_8600(builder))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 8628, 8698);

                                var
                                value = f_10942_8640_8697(name, index, f_10942_8676_8696(type))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 8724, 8747);

                                f_10942_8724_8746(result, key, value);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10942, 8357, 8770);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 8792, 8807);

                            f_10942_8792_8806(builder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10942, 8160, 8826);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10942, 7507, 8841);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10942, 1, 1335);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10942, 1, 1335);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 8855, 8869);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10942, 7239, 8880);

                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                f_10942_7438_7492()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 7438, 7492);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinitionHandleCollection
                f_10942_7530_7552(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.TypeDefinitions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10942, 7530, 7552);
                    return return_v;
                }


                System.Reflection.Metadata.TypeDefinition
                f_10942_7596_7628(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                handle)
                {
                    var return_v = this_param.GetTypeDefinition(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 7596, 7628);
                    return return_v;
                }


                bool
                f_10942_7651_7671_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10942, 7651, 7671);
                    return return_v;
                }


                string
                f_10942_7949_7975(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 7949, 7975);
                    return return_v;
                }


                string
                f_10942_8035_8113(string
                emittedTypeName, out short
                arity)
                {
                    var return_v = MetadataHelpers.InferTypeArityAndUnmangleMetadataName(emittedTypeName, out arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 8035, 8113);
                    return return_v;
                }


                bool
                f_10942_8164_8229(string
                name, out int
                index)
                {
                    var return_v = GeneratedNames.TryParseAnonymousTypeTemplateName(name, out index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 8164, 8229);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Emit.AnonymousTypeKeyField>
                f_10942_8285_8334()
                {
                    var return_v = ArrayBuilder<AnonymousTypeKeyField>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 8285, 8334);
                    return return_v;
                }


                bool
                f_10942_8361_8405(System.Reflection.Metadata.MetadataReader
                reader, System.Reflection.Metadata.TypeDefinition
                def, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Emit.AnonymousTypeKeyField>
                builder)
                {
                    var return_v = TryGetAnonymousTypeKey(reader, def, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 8361, 8405);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10942_8483_8521(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                token)
                {
                    var return_v = this_param.GetTypeOfToken((System.Reflection.Metadata.EntityHandle)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 8483, 8521);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.AnonymousTypeKeyField>
                f_10942_8579_8600(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Emit.AnonymousTypeKeyField>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 8579, 8600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.AnonymousTypeKey
                f_10942_8558_8601(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.AnonymousTypeKeyField>
                fields)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.AnonymousTypeKey(fields);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 8558, 8601);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                f_10942_8676_8696(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 8676, 8696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.AnonymousTypeValue
                f_10942_8640_8697(string
                name, int
                uniqueIndex, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.AnonymousTypeValue(name, uniqueIndex, (Microsoft.Cci.ITypeDefinition)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 8640, 8697);
                    return return_v;
                }


                int
                f_10942_8724_8746(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                this_param, Microsoft.CodeAnalysis.Emit.AnonymousTypeKey
                key, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 8724, 8746);
                    return 0;
                }


                int
                f_10942_8792_8806(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Emit.AnonymousTypeKeyField>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 8792, 8806);
                    return 0;
                }


                System.Reflection.Metadata.TypeDefinitionHandleCollection
                f_10942_7530_7552_I(System.Reflection.Metadata.TypeDefinitionHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 7530, 7552);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10942, 7239, 8880);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10942, 7239, 8880);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryGetAnonymousTypeKey(
                    MetadataReader reader,
                    TypeDefinition def,
                    ArrayBuilder<AnonymousTypeKeyField> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10942, 8892, 9640);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 9087, 9603);
                    foreach (var typeParameterHandle in f_10942_9123_9149_I(def.GetGenericParameters()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10942, 9087, 9603);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 9183, 9251);

                        var
                        typeParameter = f_10942_9203_9250(reader, typeParameterHandle)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 9269, 9286);

                        string
                        fieldName
                        = default(string);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 9304, 9485) || true) && (!f_10942_9309_9411(f_10942_9359_9395(reader, typeParameter.Name), out fieldName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10942, 9304, 9485);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 9453, 9466);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10942, 9304, 9485);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 9505, 9588);

                        f_10942_9505_9587(
                                        builder, f_10942_9517_9586(fieldName, isKey: false, ignoreCase: false));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10942, 9087, 9603);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10942, 1, 517);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10942, 1, 517);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 9617, 9629);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10942, 8892, 9640);

                System.Reflection.Metadata.GenericParameter
                f_10942_9203_9250(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.GenericParameterHandle
                handle)
                {
                    var return_v = this_param.GetGenericParameter(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 9203, 9250);
                    return return_v;
                }


                string
                f_10942_9359_9395(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 9359, 9395);
                    return return_v;
                }


                bool
                f_10942_9309_9411(string
                typeParameterName, out string
                propertyName)
                {
                    var return_v = GeneratedNames.TryParseAnonymousTypeParameterName(typeParameterName, out propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 9309, 9411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.AnonymousTypeKeyField
                f_10942_9517_9586(string
                name, bool
                isKey, bool
                ignoreCase)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.AnonymousTypeKeyField(name, isKey: isKey, ignoreCase: ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 9517, 9586);
                    return return_v;
                }


                int
                f_10942_9505_9587(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Emit.AnonymousTypeKeyField>
                this_param, Microsoft.CodeAnalysis.Emit.AnonymousTypeKeyField
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 9505, 9587);
                    return 0;
                }


                System.Reflection.Metadata.GenericParameterHandleCollection
                f_10942_9123_9149_I(System.Reflection.Metadata.GenericParameterHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 9123, 9149);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10942, 8892, 9640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10942, 8892, 9640);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal EmitBaseline PreviousGeneration
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10942, 9717, 9752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 9723, 9750);

                    return _previousGeneration;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10942, 9717, 9752);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10942, 9652, 9763);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10942, 9652, 9763);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal CSharpDefinitionMap PreviousDefinitions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10942, 9848, 9884);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 9854, 9882);

                    return _previousDefinitions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10942, 9848, 9884);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10942, 9775, 9895);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10942, 9775, 9895);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool SupportsPrivateImplClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10942, 9979, 10188);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 10160, 10173);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10942, 9979, 10188);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10942, 9907, 10199);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10942, 9907, 10199);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IReadOnlyDictionary<AnonymousTypeKey, AnonymousTypeValue> GetAnonymousTypeMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10942, 10211, 10626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 10322, 10403);

                var
                anonymousTypes = f_10942_10343_10402(f_10942_10343_10380(this.Compilation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 10484, 10579);

                f_10942_10484_10578(f_10942_10497_10577(f_10942_10497_10533(_previousGeneration), p => anonymousTypes.ContainsKey(p.Key)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 10593, 10615);

                return anonymousTypes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10942, 10211, 10626);

                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                f_10942_10343_10380(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.AnonymousTypeManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10942, 10343, 10380);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                f_10942_10343_10402(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param)
                {
                    var return_v = this_param.GetAnonymousTypeMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 10343, 10402);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                f_10942_10497_10533(Microsoft.CodeAnalysis.Emit.EmitBaseline
                this_param)
                {
                    var return_v = this_param.AnonymousTypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10942, 10497, 10533);
                    return return_v;
                }


                bool
                f_10942_10497_10577(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                source, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>, bool>
                predicate)
                {
                    var return_v = source.All<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 10497, 10577);
                    return return_v;
                }


                int
                f_10942_10484_10578(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 10484, 10578);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10942, 10211, 10626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10942, 10211, 10626);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IEnumerable<Cci.INamespaceTypeDefinition> GetTopLevelTypeDefinitions(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10942, 10638, 11058);

                var listYield = new List<Cci.INamespaceTypeDefinition>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 10768, 10898);
                    foreach (var typeDef in f_10942_10792_10828_I(f_10942_10792_10828(this, context)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10942, 10768, 10898);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 10862, 10883);

                        listYield.Add(typeDef);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10942, 10768, 10898);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10942, 1, 131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10942, 1, 131);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 10914, 11047);
                    foreach (var typeDef in f_10942_10938_10977_I(f_10942_10938_10977(this, context)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10942, 10914, 11047);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 11011, 11032);

                        listYield.Add(typeDef);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10942, 10914, 11047);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10942, 1, 134);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10942, 1, 134);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10942, 10638, 11058);

                return listYield;

                System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                f_10942_10792_10828(Microsoft.CodeAnalysis.CSharp.Emit.PEDeltaAssemblyBuilder
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetAnonymousTypeDefinitions(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 10792, 10828);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                f_10942_10792_10828_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 10792, 10828);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                f_10942_10938_10977(Microsoft.CodeAnalysis.CSharp.Emit.PEDeltaAssemblyBuilder
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetTopLevelTypeDefinitionsCore(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 10938, 10977);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                f_10942_10938_10977_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 10938, 10977);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10942, 10638, 11058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10942, 10638, 11058);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IEnumerable<Cci.INamespaceTypeDefinition> GetTopLevelSourceTypeDefinitions(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10942, 11070, 11275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 11206, 11264);

                return f_10942_11213_11263(_changes, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10942, 11070, 11275);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                f_10942_11213_11263(Microsoft.CodeAnalysis.Emit.SymbolChanges
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetTopLevelSourceTypeDefinitions(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 11213, 11263);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10942, 11070, 11275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10942, 11070, 11275);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override VariableSlotAllocator TryCreateVariableSlotAllocator(MethodSymbol method, MethodSymbol topLevelMethod, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10942, 11287, 11600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 11459, 11589);

                return f_10942_11466_11588(_previousDefinitions, _previousGeneration, Compilation, method, topLevelMethod, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10942, 11287, 11600);

                Microsoft.CodeAnalysis.CodeGen.VariableSlotAllocator
                f_10942_11466_11588(Microsoft.CodeAnalysis.CSharp.Emit.CSharpDefinitionMap
                this_param, Microsoft.CodeAnalysis.Emit.EmitBaseline
                baseline, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                topLevelMethod, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.TryCreateVariableSlotAllocator(baseline, (Microsoft.CodeAnalysis.Compilation)compilation, (Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal)method, (Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal)topLevelMethod, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 11466, 11588);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10942, 11287, 11600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10942, 11287, 11600);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<AnonymousTypeKey> GetPreviousAnonymousTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10942, 11612, 11803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 11715, 11792);

                return f_10942_11722_11791(f_10942_11749_11790(f_10942_11749_11785(_previousGeneration)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10942, 11612, 11803);

                System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                f_10942_11749_11785(Microsoft.CodeAnalysis.Emit.EmitBaseline
                this_param)
                {
                    var return_v = this_param.AnonymousTypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10942, 11749, 11785);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey>
                f_10942_11749_11790(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10942, 11749, 11790);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey>
                f_10942_11722_11791(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey>
                items)
                {
                    var return_v = ImmutableArray.CreateRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 11722, 11791);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10942, 11612, 11803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10942, 11612, 11803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override int GetNextAnonymousTypeIndex()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10942, 11815, 11955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 11889, 11944);

                return f_10942_11896_11943(_previousGeneration);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10942, 11815, 11955);

                int
                f_10942_11896_11943(Microsoft.CodeAnalysis.Emit.EmitBaseline
                this_param)
                {
                    var return_v = this_param.GetNextAnonymousTypeIndex();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 11896, 11943);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10942, 11815, 11955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10942, 11815, 11955);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool TryGetAnonymousTypeName(AnonymousTypeManager.AnonymousTypeTemplateSymbol template, out string name, out int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10942, 11967, 12301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 12129, 12193);

                f_10942_12129_12192(this.Compilation == f_10942_12162_12191(template));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 12207, 12290);

                return f_10942_12214_12289(_previousDefinitions, template, out name, out index);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10942, 11967, 12301);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10942_12162_12191(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10942, 12162, 12191);
                    return return_v;
                }


                int
                f_10942_12129_12192(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 12129, 12192);
                    return 0;
                }


                bool
                f_10942_12214_12289(Microsoft.CodeAnalysis.CSharp.Emit.CSharpDefinitionMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                template, out string
                name, out int
                index)
                {
                    var return_v = this_param.TryGetAnonymousTypeName(template, out name, out index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 12214, 12289);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10942, 11967, 12301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10942, 11967, 12301);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SymbolChanges Changes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10942, 12368, 12392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 12374, 12390);

                    return _changes;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10942, 12368, 12392);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10942, 12313, 12403);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10942, 12313, 12403);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void OnCreatedIndices(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10942, 12415, 12903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 12495, 12551);

                var
                embeddedTypesManager = f_10942_12522_12550(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 12565, 12892) || true) && (embeddedTypesManager != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10942, 12565, 12892);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 12631, 12877);
                        foreach (var embeddedType in f_10942_12660_12702_I(f_10942_12660_12702(embeddedTypesManager.EmbeddedTypesMap)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10942, 12631, 12877);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 12744, 12858);

                            f_10942_12744_12857(diagnostics, f_10942_12760_12841(ErrorCode.ERR_EncNoPIAReference, f_10942_12814_12840(embeddedType)), f_10942_12843_12856());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10942, 12631, 12877);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10942, 1, 247);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10942, 1, 247);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10942, 12565, 12892);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10942, 12415, 12903);

                Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                f_10942_12522_12550(Microsoft.CodeAnalysis.CSharp.Emit.PEDeltaAssemblyBuilder
                this_param)
                {
                    var return_v = this_param.EmbeddedTypesManagerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10942, 12522, 12550);
                    return return_v;
                }


                System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter>
                f_10942_12660_12702(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter, Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedType>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10942, 12660, 12702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10942_12814_12840(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                this_param)
                {
                    var return_v = this_param.AdaptedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10942, 12814, 12840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10942_12760_12841(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 12760, 12841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10942_12843_12856()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10942, 12843, 12856);
                    return return_v;
                }


                int
                f_10942_12744_12857(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 12744, 12857);
                    return 0;
                }


                System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter>
                f_10942_12660_12702_I(System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 12660, 12702);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10942, 12415, 12903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10942, 12415, 12903);
            }
        }

        internal override bool IsEncDelta
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10942, 12973, 12993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10942, 12979, 12991);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10942, 12973, 12993);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10942, 12915, 13004);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10942, 12915, 13004);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PEDeltaAssemblyBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10942, 741, 13011);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10942, 741, 13011);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10942, 741, 13011);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10942, 741, 13011);

        Microsoft.CodeAnalysis.Emit.EmitBaseline
        f_10942_1751_1785(Microsoft.CodeAnalysis.Emit.EmitBaseline
        this_param)
        {
            var return_v = this_param.InitialBaseline;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10942, 1751, 1785);
            return return_v;
        }


        Microsoft.CodeAnalysis.DiagnosticBag
        f_10942_1842_1861()
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 1842, 1861);
            return return_v;
        }


        Microsoft.CodeAnalysis.Emit.EmitContext
        f_10942_1814_1912(Microsoft.CodeAnalysis.CSharp.Emit.PEDeltaAssemblyBuilder
        module, Microsoft.CodeAnalysis.SyntaxNode
        syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, bool
        metadataOnly, bool
        includePrivateMembers)
        {
            var return_v = new Microsoft.CodeAnalysis.Emit.EmitContext((Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder)module, syntaxNodeOpt, diagnostics, metadataOnly: metadataOnly, includePrivateMembers: includePrivateMembers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 1814, 1912);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10942_2254_2289(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        this_param)
        {
            var return_v = this_param.DeclaringCompilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10942, 2254, 2289);
            return return_v;
        }


        Microsoft.CodeAnalysis.Emit.EmitBaseline.MetadataSymbols
        f_10942_2210_2290(Microsoft.CodeAnalysis.Emit.EmitBaseline
        initialBaseline, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation)
        {
            var return_v = GetOrCreateMetadataSymbols(initialBaseline, compilation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 2210, 2290);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        f_10942_2431_2459(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
        this_param)
        {
            var return_v = this_param.ModuleSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10942, 2431, 2459);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10942_2431_2478(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        this_param)
        {
            var return_v = this_param.ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10942, 2431, 2478);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher
        f_10942_2517_2615(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
        anonymousTypeMap, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        sourceAssembly, Microsoft.CodeAnalysis.Emit.EmitContext
        sourceContext, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
        otherAssembly)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher(anonymousTypeMap, sourceAssembly, sourceContext, otherAssembly);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 2517, 2615);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        f_10942_2780_2846(Microsoft.CodeAnalysis.CSharp.CSharpCompilation?
        this_param)
        {
            var return_v = this_param.SourceAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10942, 2780, 2846);
            return return_v;
        }


        Microsoft.CodeAnalysis.DiagnosticBag
        f_10942_2962_2981()
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 2962, 2981);
            return return_v;
        }


        Microsoft.CodeAnalysis.Emit.EmitContext
        f_10942_2887_3032(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
        module, Microsoft.CodeAnalysis.SyntaxNode
        syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, bool
        metadataOnly, bool
        includePrivateMembers)
        {
            var return_v = new Microsoft.CodeAnalysis.Emit.EmitContext((Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder?)module, syntaxNodeOpt, diagnostics, metadataOnly: metadataOnly, includePrivateMembers: includePrivateMembers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 2887, 3032);
            return return_v;
        }


        System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
        f_10942_3117_3152(Microsoft.CodeAnalysis.Emit.EmitBaseline
        this_param)
        {
            var return_v = this_param.AnonymousTypeMap;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10942, 3117, 3152);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher
        f_10942_3071_3445(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
        anonymousTypeMap, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        sourceAssembly, Microsoft.CodeAnalysis.Emit.EmitContext
        sourceContext, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        otherAssembly, Microsoft.CodeAnalysis.Emit.EmitContext
        otherContext, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
        otherSynthesizedMembersOpt)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher(anonymousTypeMap, sourceAssembly: sourceAssembly, sourceContext: sourceContext, otherAssembly: otherAssembly, otherContext: otherContext, otherSynthesizedMembersOpt: otherSynthesizedMembersOpt);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 3071, 3445);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Emit.CSharpDefinitionMap
        f_10942_3500_3581(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.SemanticEdit>
        edits, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
        metadataDecoder, Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher
        mapToMetadata, Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher?
        mapToPrevious)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.CSharpDefinitionMap(edits, metadataDecoder, mapToMetadata, mapToPrevious);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 3500, 3581);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolChanges
        f_10942_3662_3729(Microsoft.CodeAnalysis.CSharp.Emit.CSharpDefinitionMap
        definitionMap, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.SemanticEdit>
        edits, System.Func<Microsoft.CodeAnalysis.ISymbol, bool>
        isAddedSymbol)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolChanges((Microsoft.CodeAnalysis.Emit.DefinitionMap)definitionMap, edits, isAddedSymbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 3662, 3729);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10942_4860_4916(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        this_param, Microsoft.CodeAnalysis.SpecialType
        type)
        {
            var return_v = this_param.GetSpecialType(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 4860, 4916);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.DeepTranslator
        f_10942_4821_4917(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        systemObject)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.DeepTranslator(systemObject);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10942, 4821, 4917);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        f_10942_1564_1578_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10942, 1109, 4929);
            return return_v;
        }

    }
}
