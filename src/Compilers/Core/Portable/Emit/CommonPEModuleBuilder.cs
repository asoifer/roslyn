// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.Emit.NoPia;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Emit
{
    internal abstract class CommonPEModuleBuilder : Cci.IUnit, Cci.IModuleReference
    {
        internal readonly DebugDocumentsBuilder DebugDocumentsBuilder;

        internal readonly IEnumerable<ResourceDescription> ManifestResources;

        internal readonly Cci.ModulePropertiesForSerialization SerializationProperties;

        internal readonly OutputKind OutputKind;

        internal IEnumerable<Cci.IWin32Resource> Win32Resources;

        internal Cci.ResourceSection Win32ResourceSection;

        internal Stream SourceLinkStreamOpt;

        internal Cci.IMethodReference PEEntryPoint;

        internal Cci.IMethodReference DebugEntryPoint;

        private readonly ConcurrentDictionary<IMethodSymbolInternal, Cci.IMethodBody> _methodBodyMap;

        private readonly TokenMap _referencesInILMap;

        private readonly ItemTokenMap<string> _stringsInILMap;

        private readonly ItemTokenMap<Cci.DebugSourceDocument> _sourceDocumentsInILMap;

        private ImmutableArray<Cci.AssemblyReferenceAlias> _lazyAssemblyReferenceAliases;

        private ImmutableArray<Cci.ManagedResource> _lazyManagedResources;

        private IEnumerable<EmbeddedText> _embeddedTexts;

        internal ConcurrentDictionary<IMethodSymbolInternal, CompilationTestData.MethodData> TestData { get; private set; }

        internal EmitOptions EmitOptions { get; }

        internal DebugInformationFormat DebugInformationFormat
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 2354, 2391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 2357, 2391);
                    return f_286_2357_2391(f_286_2357_2368()); DynAbs.Tracing.TraceSender.TraceExitMethod(286, 2354, 2391);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 2354, 2391);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 2354, 2391);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal HashAlgorithmName PdbChecksumAlgorithm
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 2450, 2485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 2453, 2485);
                    return f_286_2453_2485(f_286_2453_2464()); DynAbs.Tracing.TraceSender.TraceExitMethod(286, 2450, 2485);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 2450, 2485);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 2450, 2485);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CommonPEModuleBuilder(
                    IEnumerable<ResourceDescription> manifestResources,
                    EmitOptions emitOptions,
                    OutputKind outputKind,
                    Cci.ModulePropertiesForSerialization serializationProperties,
                    Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(286, 2498, 3429);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 855, 876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 938, 955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 1021, 1044);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 1084, 1094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 1146, 1160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 1200, 1220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 1247, 1266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 1309, 1321);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 1362, 1377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 1468, 1482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 1519, 1545);
                this._referencesInILMap = new(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 1594, 1617);
                this._stringsInILMap = new(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 1683, 1714);
                this._sourceDocumentsInILMap = new(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 1928, 1999);
                this._embeddedTexts = f_286_1945_1999(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 2119, 2234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 2246, 2287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 2804, 2844);

                f_286_2804_2843(manifestResources != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 2858, 2904);

                f_286_2858_2903(serializationProperties != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 2918, 2952);

                f_286_2918_2951(compilation != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 2968, 3006);

                ManifestResources = manifestResources;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 3020, 3144);

                DebugDocumentsBuilder = f_286_3044_3143(f_286_3070_3113(f_286_3070_3089(compilation)), f_286_3115_3142(compilation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 3158, 3182);

                OutputKind = outputKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 3196, 3246);

                SerializationProperties = serializationProperties;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 3260, 3378);

                _methodBodyMap = f_286_3277_3377(ReferenceEqualityComparer.Instance);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 3392, 3418);

                EmitOptions = emitOptions;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(286, 2498, 3429);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 2498, 3429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 2498, 3429);
            }
        }

        public abstract int CurrentGenerationOrdinal { get; }

        public abstract string Name { get; }

        internal abstract string ModuleName { get; }

        internal abstract Cci.IAssemblyReference Translate(IAssemblySymbolInternal symbol, DiagnosticBag diagnostics);

        internal abstract Cci.ITypeReference Translate(ITypeSymbolInternal symbol, SyntaxNode syntaxOpt, DiagnosticBag diagnostics);

        internal abstract Cci.IMethodReference Translate(IMethodSymbolInternal symbol, DiagnosticBag diagnostics, bool needDeclaration);

        internal abstract bool SupportsPrivateImplClass { get; }

        internal abstract Compilation CommonCompilation { get; }

        internal abstract IModuleSymbolInternal CommonSourceModule { get; }

        internal abstract IAssemblySymbolInternal CommonCorLibrary { get; }

        internal abstract CommonModuleCompilationState CommonModuleCompilationState { get; }

        internal abstract void CompilationFinished();

        internal abstract ImmutableDictionary<ISymbolInternal, ImmutableArray<ISymbolInternal>> GetAllSynthesizedMembers();

        internal abstract CommonEmbeddedTypesManager CommonEmbeddedTypesManagerOpt { get; }

        internal abstract Cci.ITypeReference EncTranslateType(ITypeSymbolInternal type, DiagnosticBag diagnostics);

        public abstract IEnumerable<Cci.ICustomAttribute> GetSourceAssemblyAttributes(bool isRefAssembly);

        public abstract IEnumerable<Cci.SecurityAttribute> GetSourceAssemblySecurityAttributes();

        public abstract IEnumerable<Cci.ICustomAttribute> GetSourceModuleAttributes();

        internal abstract Cci.ICustomAttribute SynthesizeAttribute(WellKnownMember attributeConstructor);

        public abstract ImmutableArray<Cci.ExportedType> GetExportedTypes(DiagnosticBag diagnostics);

        public abstract bool GenerateVisualBasicStylePdb { get; }

        public abstract IEnumerable<string> LinkedAssembliesDebugInfo { get; }

        public abstract ImmutableArray<Cci.UsedNamespaceOrType> GetImports();

        public abstract string DefaultNamespace { get; }

        protected abstract Cci.IAssemblyReference GetCorLibraryReferenceToEmit(EmitContext context);

        protected abstract IEnumerable<Cci.IAssemblyReference> GetAssemblyReferencesFromAddedModules(DiagnosticBag diagnostics);

        protected abstract void AddEmbeddedResourcesFromAddedModules(ArrayBuilder<Cci.ManagedResource> builder, DiagnosticBag diagnostics);

        public abstract Cci.ITypeReference GetPlatformType(Cci.PlatformType platformType, EmitContext context);

        public abstract bool IsPlatformType(Cci.ITypeReference typeRef, Cci.PlatformType platformType);

        public abstract IEnumerable<Cci.INamespaceTypeDefinition> GetTopLevelTypeDefinitions(EmitContext context);

        public IEnumerable<Cci.INamespaceTypeDefinition> GetTopLevelTypeDefinitionsCore(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 8076, 8647);

                var listYield = new List<Cci.INamespaceTypeDefinition>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 8201, 8340);
                    foreach (var typeDef in f_286_8225_8270_I(f_286_8225_8270(this, context)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 8201, 8340);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 8304, 8325);

                        listYield.Add(typeDef);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(286, 8201, 8340);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(286, 1, 140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(286, 1, 140);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 8356, 8485);
                    foreach (var typeDef in f_286_8380_8415_I(f_286_8380_8415(this, context)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 8356, 8485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 8449, 8470);

                        listYield.Add(typeDef);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(286, 8356, 8485);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(286, 1, 130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(286, 1, 130);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 8501, 8636);
                    foreach (var typeDef in f_286_8525_8566_I(f_286_8525_8566(this, context)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 8501, 8636);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 8600, 8621);

                        listYield.Add(typeDef);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(286, 8501, 8636);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(286, 1, 136);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(286, 1, 136);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 8076, 8647);

                return listYield;

                System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                f_286_8225_8270(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetAdditionalTopLevelTypeDefinitions(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 8225, 8270);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                f_286_8225_8270_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 8225, 8270);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                f_286_8380_8415(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetEmbeddedTypeDefinitions(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 8380, 8415);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                f_286_8380_8415_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 8380, 8415);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                f_286_8525_8566(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetTopLevelSourceTypeDefinitions(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 8525, 8566);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                f_286_8525_8566_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 8525, 8566);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 8076, 8647);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 8076, 8647);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract IEnumerable<Cci.INamespaceTypeDefinition> GetAdditionalTopLevelTypeDefinitions(EmitContext context);

        public abstract IEnumerable<Cci.INamespaceTypeDefinition> GetAnonymousTypeDefinitions(EmitContext context);

        public abstract IEnumerable<Cci.INamespaceTypeDefinition> GetEmbeddedTypeDefinitions(EmitContext context);

        public abstract IEnumerable<Cci.INamespaceTypeDefinition> GetTopLevelSourceTypeDefinitions(EmitContext context);

        public abstract IEnumerable<Cci.IFileReference> GetFiles(EmitContext context);

        public abstract MultiDictionary<Cci.DebugSourceDocument, Cci.DefinitionWithLocation> GetSymbolToLocationMap();

        public int DebugDocumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 10723, 10766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 10726, 10766);
                    return f_286_10726_10766(DebugDocumentsBuilder); DynAbs.Tracing.TraceSender.TraceExitMethod(286, 10723, 10766);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 10723, 10766);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 10723, 10766);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 10829, 10851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 10832, 10851);
                f_286_10832_10851(visitor, this); DynAbs.Tracing.TraceSender.TraceExitMethod(286, 10829, 10851);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 10829, 10851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 10829, 10851);
            }

            int
            f_286_10832_10851(Microsoft.Cci.MetadataVisitor
            this_param, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
            module)
            {
                this_param.Visit(module);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 10832, 10851);
                return 0;
            }

        }

        IEnumerable<Cci.ICustomAttribute> Cci.IReference.GetAttributes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 10948, 11013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 10951, 11013);
                return f_286_10951_11013(); DynAbs.Tracing.TraceSender.TraceExitMethod(286, 10948, 11013);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 10948, 11013);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 10948, 11013);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
            f_286_10951_11013()
            {
                var return_v = SpecializedCollections.EmptyEnumerable<Cci.ICustomAttribute>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 10951, 11013);
                return return_v;
            }

        }

        Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 11026, 11204);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 11115, 11167);

                f_286_11115_11166(f_286_11128_11165(context.Module, this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 11181, 11193);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 11026, 11204);

                bool
                f_286_11128_11165(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                objA, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 11128, 11165);
                    return return_v;
                }


                int
                f_286_11115_11166(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 11115, 11166);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 11026, 11204);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 11026, 11204);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Symbols.ISymbolInternal Cci.IReference.GetInternalSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 11275, 11282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 11278, 11282);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(286, 11275, 11282);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 11275, 11282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 11275, 11282);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract ISourceAssemblySymbolInternal SourceAssemblyOpt { get; }

        public int HintNumberOfMethodDefinitions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 11916, 11952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 11919, 11952);
                    return (int)(f_286_11925_11945(_methodBodyMap) * 1.5); DynAbs.Tracing.TraceSender.TraceExitMethod(286, 11916, 11952);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 11916, 11952);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 11916, 11952);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Cci.IMethodBody GetMethodBody(IMethodSymbolInternal methodSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 11965, 12515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 12064, 12130);

                f_286_12064_12129(f_286_12077_12106(methodSymbol) == f_286_12110_12128());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 12144, 12184);

                f_286_12144_12183(f_286_12157_12182(methodSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 12198, 12285);

                f_286_12198_12284(f_286_12211_12275(((IMethodSymbol)f_286_12227_12252(methodSymbol))) == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 12324, 12345);

                Cci.IMethodBody
                body
                = default(Cci.IMethodBody);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 12361, 12476) || true) && (f_286_12365_12415(_methodBodyMap, methodSymbol, out body))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 12361, 12476);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 12449, 12461);

                    return body;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(286, 12361, 12476);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 12492, 12504);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 11965, 12515);

                Microsoft.CodeAnalysis.Symbols.IModuleSymbolInternal
                f_286_12077_12106(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 12077, 12106);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.IModuleSymbolInternal
                f_286_12110_12128()
                {
                    var return_v = CommonSourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 12110, 12128);
                    return return_v;
                }


                int
                f_286_12064_12129(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 12064, 12129);
                    return 0;
                }


                bool
                f_286_12157_12182(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 12157, 12182);
                    return return_v;
                }


                int
                f_286_12144_12183(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 12144, 12183);
                    return 0;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_286_12227_12252(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                this_param)
                {
                    var return_v = this_param.GetISymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 12227, 12252);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_286_12211_12275(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.PartialDefinitionPart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 12211, 12275);
                    return return_v;
                }


                int
                f_286_12198_12284(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 12198, 12284);
                    return 0;
                }


                bool
                f_286_12365_12415(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.Cci.IMethodBody>
                this_param, Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                key, out Microsoft.Cci.IMethodBody
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 12365, 12415);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 11965, 12515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 11965, 12515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void SetMethodBody(IMethodSymbolInternal methodSymbol, Cci.IMethodBody body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 12527, 13055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 12635, 12701);

                f_286_12635_12700(f_286_12648_12677(methodSymbol) == f_286_12681_12699());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 12715, 12755);

                f_286_12715_12754(f_286_12728_12753(methodSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 12769, 12856);

                f_286_12769_12855(f_286_12782_12846(((IMethodSymbol)f_286_12798_12823(methodSymbol))) == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 12893, 12989);

                f_286_12893_12988(body == null || (DynAbs.Tracing.TraceSender.Expression_False(286, 12906, 12987) || (object)methodSymbol == f_286_12946_12987(f_286_12946_12967(body))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 13005, 13044);

                f_286_13005_13043(
                            _methodBodyMap, methodSymbol, body);
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 12527, 13055);

                Microsoft.CodeAnalysis.Symbols.IModuleSymbolInternal
                f_286_12648_12677(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 12648, 12677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.IModuleSymbolInternal
                f_286_12681_12699()
                {
                    var return_v = CommonSourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 12681, 12699);
                    return return_v;
                }


                int
                f_286_12635_12700(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 12635, 12700);
                    return 0;
                }


                bool
                f_286_12728_12753(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 12728, 12753);
                    return return_v;
                }


                int
                f_286_12715_12754(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 12715, 12754);
                    return 0;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_286_12798_12823(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                this_param)
                {
                    var return_v = this_param.GetISymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 12798, 12823);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_286_12782_12846(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.PartialDefinitionPart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 12782, 12846);
                    return return_v;
                }


                int
                f_286_12769_12855(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 12769, 12855);
                    return 0;
                }


                Microsoft.Cci.IMethodDefinition
                f_286_12946_12967(Microsoft.Cci.IMethodBody
                this_param)
                {
                    var return_v = this_param.MethodDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 12946, 12967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_286_12946_12987(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.GetInternalSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 12946, 12987);
                    return return_v;
                }


                int
                f_286_12893_12988(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 12893, 12988);
                    return 0;
                }


                int
                f_286_13005_13043(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.Cci.IMethodBody>
                dict, Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                key, Microsoft.Cci.IMethodBody?
                value)
                {
                    dict.Add<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.Cci.IMethodBody?>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 13005, 13043);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 12527, 13055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 12527, 13055);
            }
        }

        internal void SetPEEntryPoint(IMethodSymbolInternal method, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 13067, 13388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 13178, 13237);

                f_286_13178_13236(method == null || (DynAbs.Tracing.TraceSender.Expression_False(286, 13191, 13235) || f_286_13209_13235(this, method)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 13251, 13292);

                f_286_13251_13291(f_286_13264_13290(OutputKind));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 13308, 13377);

                PEEntryPoint = f_286_13323_13376(this, method, diagnostics, needDeclaration: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 13067, 13388);

                bool
                f_286_13209_13235(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                method)
                {
                    var return_v = this_param.IsSourceDefinition(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 13209, 13235);
                    return return_v;
                }


                int
                f_286_13178_13236(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 13178, 13236);
                    return 0;
                }


                bool
                f_286_13264_13290(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsApplication();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 13264, 13290);
                    return return_v;
                }


                int
                f_286_13251_13291(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 13251, 13291);
                    return 0;
                }


                Microsoft.Cci.IMethodReference
                f_286_13323_13376(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal?
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                needDeclaration)
                {
                    var return_v = this_param.Translate(symbol, diagnostics, needDeclaration: needDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 13323, 13376);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 13067, 13388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 13067, 13388);
            }
        }

        internal void SetDebugEntryPoint(IMethodSymbolInternal method, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 13400, 13672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 13514, 13573);

                f_286_13514_13572(method == null || (DynAbs.Tracing.TraceSender.Expression_False(286, 13527, 13571) || f_286_13545_13571(this, method)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 13589, 13661);

                DebugEntryPoint = f_286_13607_13660(this, method, diagnostics, needDeclaration: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 13400, 13672);

                bool
                f_286_13545_13571(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                method)
                {
                    var return_v = this_param.IsSourceDefinition(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 13545, 13571);
                    return return_v;
                }


                int
                f_286_13514_13572(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 13514, 13572);
                    return 0;
                }


                Microsoft.Cci.IMethodReference
                f_286_13607_13660(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal?
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                needDeclaration)
                {
                    var return_v = this_param.Translate(symbol, diagnostics, needDeclaration: needDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 13607, 13660);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 13400, 13672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 13400, 13672);
            }
        }

        private bool IsSourceDefinition(IMethodSymbolInternal method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 13684, 13857);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 13770, 13846);

                return f_286_13777_13800(method) == f_286_13804_13822() && (DynAbs.Tracing.TraceSender.Expression_True(286, 13777, 13845) && f_286_13826_13845(method));
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 13684, 13857);

                Microsoft.CodeAnalysis.Symbols.IModuleSymbolInternal
                f_286_13777_13800(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 13777, 13800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.IModuleSymbolInternal
                f_286_13804_13822()
                {
                    var return_v = CommonSourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 13804, 13822);
                    return return_v;
                }


                bool
                f_286_13826_13845(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 13826, 13845);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 13684, 13857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 13684, 13857);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Cci.IAssemblyReference GetCorLibrary(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 13976, 14132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 14065, 14121);

                return f_286_14072_14120(this, f_286_14082_14098(), context.Diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 13976, 14132);

                Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal
                f_286_14082_14098()
                {
                    var return_v = CommonCorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 14082, 14098);
                    return return_v;
                }


                Microsoft.Cci.IAssemblyReference
                f_286_14072_14120(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(symbol, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 14072, 14120);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 13976, 14132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 13976, 14132);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Cci.IAssemblyReference GetContainingAssembly(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 14144, 14332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 14241, 14321);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(286, 14248, 14282) || ((OutputKind == OutputKind.NetModule && DynAbs.Tracing.TraceSender.Conditional_F2(286, 14285, 14289)) || DynAbs.Tracing.TraceSender.Conditional_F3(286, 14292, 14320))) ? null : (Cci.IAssemblyReference)this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 14144, 14332);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 14144, 14332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 14144, 14332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<string> GetStrings()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 14464, 14576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 14528, 14565);

                return f_286_14535_14564(_stringsInILMap);
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 14464, 14576);

                System.Collections.Generic.IEnumerable<string>
                f_286_14535_14564(Microsoft.CodeAnalysis.CodeGen.ItemTokenMap<string>
                this_param)
                {
                    var return_v = this_param.GetAllItems();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 14535, 14564);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 14464, 14576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 14464, 14576);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint GetFakeSymbolTokenForIL(Cci.IReference symbol, SyntaxNode syntaxNode, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 14588, 15051);
                bool added = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 14721, 14794);

                uint
                token = f_286_14734_14793(_referencesInILMap, symbol, out added)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 14808, 15013) || true) && (added)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 14808, 15013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 14851, 14998);

                    f_286_14851_14997(symbol, f_286_14900_14996(this, syntaxNode, diagnostics, metadataOnly: false, includePrivateMembers: true));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(286, 14808, 15013);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 15027, 15040);

                return token;
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 14588, 15051);

                uint
                f_286_14734_14793(Microsoft.CodeAnalysis.CodeGen.TokenMap
                this_param, Microsoft.Cci.IReference
                item, out bool
                referenceAdded)
                {
                    var return_v = this_param.GetOrAddTokenFor(item, out referenceAdded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 14734, 14793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitContext
                f_286_14900_14996(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                module, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                metadataOnly, bool
                includePrivateMembers)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EmitContext(module, syntaxNodeOpt, diagnostics, metadataOnly: metadataOnly, includePrivateMembers: includePrivateMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 14900, 14996);
                    return return_v;
                }


                int
                f_286_14851_14997(Microsoft.Cci.IReference
                reference, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    ReferenceDependencyWalker.VisitReference(reference, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 14851, 14997);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 14588, 15051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 14588, 15051);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint GetFakeSymbolTokenForIL(Cci.ISignature symbol, SyntaxNode syntaxNode, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 15063, 15526);
                bool added = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 15196, 15269);

                uint
                token = f_286_15209_15268(_referencesInILMap, symbol, out added)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 15283, 15488) || true) && (added)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 15283, 15488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 15326, 15473);

                    f_286_15326_15472(symbol, f_286_15375_15471(this, syntaxNode, diagnostics, metadataOnly: false, includePrivateMembers: true));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(286, 15283, 15488);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 15502, 15515);

                return token;
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 15063, 15526);

                uint
                f_286_15209_15268(Microsoft.CodeAnalysis.CodeGen.TokenMap
                this_param, Microsoft.Cci.ISignature
                item, out bool
                referenceAdded)
                {
                    var return_v = this_param.GetOrAddTokenFor(item, out referenceAdded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 15209, 15268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitContext
                f_286_15375_15471(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                module, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                metadataOnly, bool
                includePrivateMembers)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EmitContext(module, syntaxNodeOpt, diagnostics, metadataOnly: metadataOnly, includePrivateMembers: includePrivateMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 15375, 15471);
                    return return_v;
                }


                int
                f_286_15326_15472(Microsoft.Cci.ISignature
                signature, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    ReferenceDependencyWalker.VisitSignature(signature, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 15326, 15472);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 15063, 15526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 15063, 15526);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint GetSourceDocumentIndexForIL(Cci.DebugSourceDocument document)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 15538, 15705);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 15636, 15694);

                return f_286_15643_15693(_sourceDocumentsInILMap, document);
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 15538, 15705);

                uint
                f_286_15643_15693(Microsoft.CodeAnalysis.CodeGen.ItemTokenMap<Microsoft.Cci.DebugSourceDocument>
                this_param, Microsoft.Cci.DebugSourceDocument
                item)
                {
                    var return_v = this_param.GetOrAddTokenFor(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 15643, 15693);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 15538, 15705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 15538, 15705);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Cci.DebugSourceDocument GetSourceDocumentFromIndex(uint token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 15717, 15870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 15813, 15859);

                return f_286_15820_15858(_sourceDocumentsInILMap, token);
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 15717, 15870);

                Microsoft.Cci.DebugSourceDocument
                f_286_15820_15858(Microsoft.CodeAnalysis.CodeGen.ItemTokenMap<Microsoft.Cci.DebugSourceDocument>
                this_param, uint
                token)
                {
                    var return_v = this_param.GetItem(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 15820, 15858);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 15717, 15870);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 15717, 15870);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object GetReferenceFromToken(uint token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 15882, 16006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 15954, 15995);

                return f_286_15961_15994(_referencesInILMap, token);
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 15882, 16006);

                object
                f_286_15961_15994(Microsoft.CodeAnalysis.CodeGen.TokenMap
                this_param, uint
                token)
                {
                    var return_v = this_param.GetItem(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 15961, 15994);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 15882, 16006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 15882, 16006);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public uint GetFakeStringTokenForIL(string str)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 16018, 16146);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 16090, 16135);

                return f_286_16097_16134(_stringsInILMap, str);
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 16018, 16146);

                uint
                f_286_16097_16134(Microsoft.CodeAnalysis.CodeGen.ItemTokenMap<string>
                this_param, string
                item)
                {
                    var return_v = this_param.GetOrAddTokenFor(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 16097, 16134);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 16018, 16146);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 16018, 16146);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string GetStringFromToken(uint token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 16158, 16276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 16227, 16265);

                return f_286_16234_16264(_stringsInILMap, token);
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 16158, 16276);

                string
                f_286_16234_16264(Microsoft.CodeAnalysis.CodeGen.ItemTokenMap<string>
                this_param, uint
                token)
                {
                    var return_v = this_param.GetItem(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 16234, 16264);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 16158, 16276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 16158, 16276);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ReadOnlySpan<object> ReferencesInIL()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 16288, 16408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 16357, 16397);

                return f_286_16364_16396(_referencesInILMap);
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 16288, 16408);

                System.ReadOnlySpan<object>
                f_286_16364_16396(Microsoft.CodeAnalysis.CodeGen.TokenMap
                this_param)
                {
                    var return_v = this_param.GetAllItems();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 16364, 16396);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 16288, 16408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 16288, 16408);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<Cci.AssemblyReferenceAlias> GetAssemblyReferenceAliases(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 16518, 16977);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 16641, 16913) || true) && (_lazyAssemblyReferenceAliases.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 16641, 16913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 16718, 16898);

                    f_286_16718_16897(ref _lazyAssemblyReferenceAliases, f_286_16801_16843(this, context), default(ImmutableArray<Cci.AssemblyReferenceAlias>));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(286, 16641, 16913);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 16929, 16966);

                return _lazyAssemblyReferenceAliases;
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 16518, 16977);

                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.AssemblyReferenceAlias>
                f_286_16801_16843(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.CalculateAssemblyReferenceAliases(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 16801, 16843);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.AssemblyReferenceAlias>
                f_286_16718_16897(ref System.Collections.Immutable.ImmutableArray<Microsoft.Cci.AssemblyReferenceAlias>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.AssemblyReferenceAlias>
                value, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.AssemblyReferenceAlias>
                comparand)
                {
                    var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 16718, 16897);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 16518, 16977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 16518, 16977);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Cci.AssemblyReferenceAlias> CalculateAssemblyReferenceAliases(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 16989, 18010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 17119, 17187);

                var
                result = f_286_17132_17186()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 17203, 17948);
                    foreach (var assemblyAndAliases in f_286_17238_17313_I(f_286_17238_17313(f_286_17238_17282(f_286_17238_17255()))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 17203, 17948);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 17347, 17387);

                        var
                        assembly = assemblyAndAliases.Item1
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 17405, 17444);

                        var
                        aliases = assemblyAndAliases.Item2
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 17473, 17478);

                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 17464, 17933) || true) && (i < aliases.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 17500, 17503)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(286, 17464, 17933))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 17464, 17933);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 17545, 17571);

                                string
                                alias = aliases[i]
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 17661, 17914) || true) && (alias != MetadataReferenceProperties.GlobalAlias && (DynAbs.Tracing.TraceSender.Expression_True(286, 17665, 17749) && aliases.IndexOf(alias, 0, i) < 0))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 17661, 17914);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 17799, 17891);

                                    f_286_17799_17890(result, f_286_17810_17889(alias, f_286_17848_17888(this, assembly, context.Diagnostics)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(286, 17661, 17914);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(286, 1, 470);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(286, 1, 470);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(286, 17203, 17948);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(286, 1, 746);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(286, 1, 746);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 17964, 17999);

                return f_286_17971_17998(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 16989, 18010);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.AssemblyReferenceAlias>
                f_286_17132_17186()
                {
                    var return_v = ArrayBuilder<Cci.AssemblyReferenceAlias>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 17132, 17186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_286_17238_17255()
                {
                    var return_v = CommonCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 17238, 17255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager
                f_286_17238_17282(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.GetBoundReferenceManager();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 17238, 17282);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<(Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal, System.Collections.Immutable.ImmutableArray<string>)>
                f_286_17238_17313(Microsoft.CodeAnalysis.CommonReferenceManager
                this_param)
                {
                    var return_v = this_param.GetReferencedAssemblyAliases();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 17238, 17313);
                    return return_v;
                }


                Microsoft.Cci.IAssemblyReference
                f_286_17848_17888(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(symbol, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 17848, 17888);
                    return return_v;
                }


                Microsoft.Cci.AssemblyReferenceAlias
                f_286_17810_17889(string
                name, Microsoft.Cci.IAssemblyReference
                assembly)
                {
                    var return_v = new Microsoft.Cci.AssemblyReferenceAlias(name, assembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 17810, 17889);
                    return return_v;
                }


                int
                f_286_17799_17890(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.AssemblyReferenceAlias>
                this_param, Microsoft.Cci.AssemblyReferenceAlias
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 17799, 17890);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<(Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal, System.Collections.Immutable.ImmutableArray<string>)>
                f_286_17238_17313_I(System.Collections.Generic.IEnumerable<(Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal, System.Collections.Immutable.ImmutableArray<string>)>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 17238, 17313);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.AssemblyReferenceAlias>
                f_286_17971_17998(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.AssemblyReferenceAlias>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 17971, 17998);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 16989, 18010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 16989, 18010);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<Cci.IAssemblyReference> GetAssemblyReferences(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 18022, 18795);

                var listYield = new List<Cci.IAssemblyReference>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 18132, 18206);

                Cci.IAssemblyReference
                corLibrary = f_286_18168_18205(this, context)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 18363, 18458) || true) && (corLibrary != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 18363, 18458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 18419, 18443);

                    listYield.Add(corLibrary);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(286, 18363, 18458);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 18474, 18784) || true) && (OutputKind != OutputKind.NetModule)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 18474, 18784);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 18611, 18769);
                        foreach (var aRef in f_286_18632_18690_I(f_286_18632_18690(this, context.Diagnostics)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 18611, 18769);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 18732, 18750);

                            listYield.Add(aRef);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(286, 18611, 18769);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(286, 1, 159);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(286, 1, 159);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(286, 18474, 18784);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 18022, 18795);

                return listYield;

                Microsoft.Cci.IAssemblyReference
                f_286_18168_18205(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetCorLibraryReferenceToEmit(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 18168, 18205);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IAssemblyReference>
                f_286_18632_18690(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetAssemblyReferencesFromAddedModules(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 18632, 18690);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IAssemblyReference>
                f_286_18632_18690_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.IAssemblyReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 18632, 18690);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 18022, 18795);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 18022, 18795);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<Cci.ManagedResource> GetResources(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 18807, 19884);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 18908, 19168) || true) && (context.IsRefAssembly)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 18908, 19168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 19104, 19153);

                    return ImmutableArray<Cci.ManagedResource>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(286, 18908, 19168);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 19184, 19828) || true) && (_lazyManagedResources.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 19184, 19828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 19253, 19315);

                    var
                    builder = f_286_19267_19314()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 19335, 19486);
                        foreach (ResourceDescription r in f_286_19369_19386_I(ManifestResources))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 19335, 19486);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 19428, 19467);

                            f_286_19428_19466(builder, f_286_19440_19465(r, this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(286, 19335, 19486);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(286, 1, 152);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(286, 1, 152);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 19506, 19740) || true) && (OutputKind != OutputKind.NetModule)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 19506, 19740);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 19654, 19721);

                        f_286_19654_19720(this, builder, context.Diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(286, 19506, 19740);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 19760, 19813);

                    _lazyManagedResources = f_286_19784_19812(builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(286, 19184, 19828);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 19844, 19873);

                return _lazyManagedResources;
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 18807, 19884);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ManagedResource>
                f_286_19267_19314()
                {
                    var return_v = ArrayBuilder<Cci.ManagedResource>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 19267, 19314);
                    return return_v;
                }


                Microsoft.Cci.ManagedResource
                f_286_19440_19465(Microsoft.CodeAnalysis.ResourceDescription
                this_param, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                moduleBeingBuilt)
                {
                    var return_v = this_param.ToManagedResource(moduleBeingBuilt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 19440, 19465);
                    return return_v;
                }


                int
                f_286_19428_19466(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ManagedResource>
                this_param, Microsoft.Cci.ManagedResource
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 19428, 19466);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                f_286_19369_19386_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 19369, 19386);
                    return return_v;
                }


                int
                f_286_19654_19720(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ManagedResource>
                builder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.AddEmbeddedResourcesFromAddedModules(builder, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 19654, 19720);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ManagedResource>
                f_286_19784_19812(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ManagedResource>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 19784, 19812);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 18807, 19884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 18807, 19884);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<EmbeddedText> EmbeddedTexts
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 19967, 20040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 20003, 20025);

                    return _embeddedTexts;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(286, 19967, 20040);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 19896, 20185);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 19896, 20185);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 20054, 20174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 20090, 20118);

                    f_286_20090_20117(value != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 20136, 20159);

                    _embeddedTexts = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(286, 20054, 20174);

                    int
                    f_286_20090_20117(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 20090, 20117);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 19896, 20185);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 19896, 20185);
                }
            }
        }

        internal bool SaveTestData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 20224, 20243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 20227, 20243);
                    return f_286_20227_20235() != null; DynAbs.Tracing.TraceSender.TraceExitMethod(286, 20224, 20243);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 20224, 20243);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 20224, 20243);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void SetMethodTestData(IMethodSymbolInternal method, ILBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 20256, 20446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 20361, 20435);

                f_286_20361_20434(f_286_20361_20369(), method, f_286_20382_20433(builder, method));
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 20256, 20446);

                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                f_286_20361_20369()
                {
                    var return_v = TestData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 20361, 20369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
                f_286_20382_20433(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                ilBuilder, Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                method)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData(ilBuilder, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 20382, 20433);
                    return return_v;
                }


                int
                f_286_20361_20434(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                dict, Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                key, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
                value)
                {
                    dict.Add<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 20361, 20434);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 20256, 20446);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 20256, 20446);
            }
        }

        internal void SetMethodTestData(ConcurrentDictionary<IMethodSymbolInternal, CompilationTestData.MethodData> methods)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 20458, 20674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 20599, 20630);

                f_286_20599_20629(f_286_20612_20620() == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 20644, 20663);

                TestData = methods;
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 20458, 20674);

                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                f_286_20612_20620()
                {
                    var return_v = TestData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 20612, 20620);
                    return return_v;
                }


                int
                f_286_20599_20629(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 20599, 20629);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 20458, 20674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 20458, 20674);
            }
        }

        static CommonPEModuleBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(286, 719, 20681);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(286, 719, 20681);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 719, 20681);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(286, 719, 20681);

        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>
        f_286_1945_1999()
        {
            var return_v = SpecializedCollections.EmptyEnumerable<EmbeddedText>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 1945, 1999);
            return return_v;
        }


        Microsoft.CodeAnalysis.Emit.EmitOptions
        f_286_2357_2368()
        {
            var return_v = EmitOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 2357, 2368);
            return return_v;
        }


        Microsoft.CodeAnalysis.Emit.DebugInformationFormat
        f_286_2357_2391(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param)
        {
            var return_v = this_param.DebugInformationFormat;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 2357, 2391);
            return return_v;
        }


        Microsoft.CodeAnalysis.Emit.EmitOptions
        f_286_2453_2464()
        {
            var return_v = EmitOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 2453, 2464);
            return return_v;
        }


        System.Security.Cryptography.HashAlgorithmName
        f_286_2453_2485(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param)
        {
            var return_v = this_param.PdbChecksumAlgorithm;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 2453, 2485);
            return return_v;
        }


        static int
        f_286_2804_2843(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 2804, 2843);
            return 0;
        }


        static int
        f_286_2858_2903(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 2858, 2903);
            return 0;
        }


        static int
        f_286_2918_2951(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 2918, 2951);
            return 0;
        }


        static Microsoft.CodeAnalysis.CompilationOptions
        f_286_3070_3089(Microsoft.CodeAnalysis.Compilation
        this_param)
        {
            var return_v = this_param.Options;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 3070, 3089);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SourceReferenceResolver?
        f_286_3070_3113(Microsoft.CodeAnalysis.CompilationOptions
        this_param)
        {
            var return_v = this_param.SourceReferenceResolver;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 3070, 3113);
            return return_v;
        }


        static bool
        f_286_3115_3142(Microsoft.CodeAnalysis.Compilation
        this_param)
        {
            var return_v = this_param.IsCaseSensitive;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 3115, 3142);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Emit.DebugDocumentsBuilder
        f_286_3044_3143(Microsoft.CodeAnalysis.SourceReferenceResolver?
        resolverOpt, bool
        isDocumentNameCaseSensitive)
        {
            var return_v = new Microsoft.CodeAnalysis.Emit.DebugDocumentsBuilder(resolverOpt, isDocumentNameCaseSensitive);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 3044, 3143);
            return return_v;
        }


        static System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.Cci.IMethodBody>
        f_286_3277_3377(Roslyn.Utilities.ReferenceEqualityComparer
        comparer)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.Cci.IMethodBody>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 3277, 3377);
            return return_v;
        }


        int
        f_286_10726_10766(Microsoft.CodeAnalysis.Emit.DebugDocumentsBuilder
        this_param)
        {
            var return_v = this_param.DebugDocumentCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 10726, 10766);
            return return_v;
        }


        int
        f_286_11925_11945(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.Cci.IMethodBody>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 11925, 11945);
            return return_v;
        }


        System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
        f_286_20227_20235()
        {
            var return_v = TestData;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 20227, 20235);
            return return_v;
        }

    }
    internal abstract class PEModuleBuilder<TCompilation, TSourceModuleSymbol, TAssemblySymbol, TTypeSymbol, TNamedTypeSymbol, TMethodSymbol, TSyntaxNode, TEmbeddedTypesManager, TModuleCompilationState> : CommonPEModuleBuilder, ITokenDeferral
            where TCompilation : Compilation
            where TSourceModuleSymbol : class, IModuleSymbolInternal
            where TAssemblySymbol : class, IAssemblySymbolInternal
            where TTypeSymbol : class, ITypeSymbolInternal
            where TNamedTypeSymbol : class, TTypeSymbol, INamedTypeSymbolInternal
            where TMethodSymbol : class, IMethodSymbolInternal
            where TSyntaxNode : SyntaxNode
            where TEmbeddedTypesManager : CommonEmbeddedTypesManager
            where TModuleCompilationState : ModuleCompilationState<TNamedTypeSymbol, TMethodSymbol>
    {
        internal readonly TSourceModuleSymbol SourceModule;

        internal readonly TCompilation Compilation;

        private PrivateImplementationDetails _privateImplementationDetails;

        private ArrayMethods _lazyArrayMethods;

        private HashSet<string> _namesOfTopLevelTypes;

        internal readonly TModuleCompilationState CompilationState;

        public Cci.RootModuleType RootModuleType { get; }

        public abstract TEmbeddedTypesManager EmbeddedTypesManagerOpt { get; }

        protected PEModuleBuilder(
                    TCompilation compilation,
                    TSourceModuleSymbol sourceModule,
                    Cci.ModulePropertiesForSerialization serializationProperties,
                    IEnumerable<ResourceDescription> manifestResources,
                    OutputKind outputKind,
                    EmitOptions emitOptions,
                    TModuleCompilationState compilationState)
        : base(f_286_22555_22572_C(manifestResources), emitOptions, outputKind, serializationProperties, compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(286, 22153, 22906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 21651, 21663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 21705, 21716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 21766, 21795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 21827, 21844);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 21879, 21900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 21955, 21971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 21982, 22059);
                this.RootModuleType = f_286_22034_22058(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 33024, 33165);
                this._synthesizedTypeMembers = f_286_33063_33165(ReferenceEqualityComparer.Instance); DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 33282, 33314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 22661, 22696);

                f_286_22661_22695(sourceModule != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 22710, 22756);

                f_286_22710_22755(serializationProperties != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 22772, 22798);

                Compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 22812, 22840);

                SourceModule = sourceModule;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 22854, 22895);

                this.CompilationState = compilationState;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(286, 22153, 22906);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 22153, 22906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 22153, 22906);
            }
        }

        internal sealed override void CompilationFinished()
        {
            this.CompilationState.Freeze();
        }

        internal override IAssemblySymbolInternal CommonCorLibrary
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 23107, 23120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 23110, 23120);
                    return f_286_23110_23120(); DynAbs.Tracing.TraceSender.TraceExitMethod(286, 23107, 23120);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 23107, 23120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 23107, 23120);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract TAssemblySymbol CorLibrary { get; }

        internal abstract Cci.INamedTypeReference GetSystemType(TSyntaxNode syntaxOpt, DiagnosticBag diagnostics);

        internal abstract Cci.INamedTypeReference GetSpecialType(SpecialType specialType, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics);

        internal sealed override Cci.ITypeReference EncTranslateType(ITypeSymbolInternal type, DiagnosticBag diagnostics)
        {
            return EncTranslateLocalVariableType((TTypeSymbol)type, diagnostics);
        }

        internal virtual Cci.ITypeReference EncTranslateLocalVariableType(TTypeSymbol type, DiagnosticBag diagnostics)
        {
            return Translate(type, null, diagnostics);
        }

        protected bool HaveDeterminedTopLevelTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 23957, 24002);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 23963, 24000);

                    return _namesOfTopLevelTypes != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(286, 23957, 24002);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 23890, 24013);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 23890, 24013);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected bool ContainsTopLevelType(string fullEmittedName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 24025, 24175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 24109, 24164);

                return f_286_24116_24163(_namesOfTopLevelTypes, fullEmittedName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 24025, 24175);

                bool
                f_286_24116_24163(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 24116, 24163);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 24025, 24175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 24025, 24175);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Returns all top-level (not nested) types defined in the module. 
        /// </summary>
        public override IEnumerable<Cci.INamespaceTypeDefinition> GetTopLevelTypeDefinitions(EmitContext context)
        {
            Cci.TypeReferenceIndexer typeReferenceIndexer = null;
            HashSet<string> names;

            // First time through, we need to collect emitted names of all top level types.
            if (_namesOfTopLevelTypes == null)
            {
                names = new HashSet<string>();
            }
            else
            {
                names = null;
            }

            // First time through, we need to push things through TypeReferenceIndexer
            // to make sure we collect all to be embedded NoPia types and members.
            if (EmbeddedTypesManagerOpt != null && !EmbeddedTypesManagerOpt.IsFrozen)
            {
                typeReferenceIndexer = new Cci.TypeReferenceIndexer(context);
                Debug.Assert(names != null);

                // Run this reference indexer on the assembly- and module-level attributes first.
                // We'll run it on all other types below.
                // The purpose is to trigger Translate on all types.
                Dispatch(typeReferenceIndexer);
            }

            AddTopLevelType(names, RootModuleType);
            VisitTopLevelType(typeReferenceIndexer, RootModuleType);
            yield return RootModuleType;

            foreach (var typeDef in GetAnonymousTypeDefinitions(context))
            {
                AddTopLevelType(names, typeDef);
                VisitTopLevelType(typeReferenceIndexer, typeDef);
                yield return typeDef;
            }

            foreach (var typeDef in GetTopLevelTypeDefinitionsCore(context))
            {
                AddTopLevelType(names, typeDef);
                VisitTopLevelType(typeReferenceIndexer, typeDef);
                yield return typeDef;
            }

            var privateImpl = PrivateImplClass;
            if (privateImpl != null)
            {
                AddTopLevelType(names, privateImpl);
                VisitTopLevelType(typeReferenceIndexer, privateImpl);
                yield return privateImpl;
            }

            if (EmbeddedTypesManagerOpt != null)
            {
                foreach (var embedded in EmbeddedTypesManagerOpt.GetTypes(context.Diagnostics, names))
                {
                    AddTopLevelType(names, embedded);
                    yield return embedded;
                }
            }

            if (names != null)
            {
                Debug.Assert(_namesOfTopLevelTypes == null);
                _namesOfTopLevelTypes = names;
            }
        }

        public virtual ImmutableArray<TNamedTypeSymbol> GetAdditionalTopLevelTypes(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 27144, 27185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 27147, 27185);
                return ImmutableArray<TNamedTypeSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(286, 27144, 27185);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 27144, 27185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 27144, 27185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual ImmutableArray<TNamedTypeSymbol> GetEmbeddedTypes(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 27303, 27344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 27306, 27344);
                return ImmutableArray<TNamedTypeSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(286, 27303, 27344);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 27303, 27344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 27303, 27344);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract Cci.IAssemblyReference Translate(TAssemblySymbol symbol, DiagnosticBag diagnostics);

        internal abstract Cci.ITypeReference Translate(TTypeSymbol symbol, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics);

        internal abstract Cci.IMethodReference Translate(TMethodSymbol symbol, DiagnosticBag diagnostics, bool needDeclaration);

        internal sealed override Cci.IAssemblyReference Translate(IAssemblySymbolInternal symbol, DiagnosticBag diagnostics)
        {
            return Translate((TAssemblySymbol)symbol, diagnostics);
        }

        internal sealed override Cci.ITypeReference Translate(ITypeSymbolInternal symbol, SyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            return Translate((TTypeSymbol)symbol, (TSyntaxNode)syntaxNodeOpt, diagnostics);
        }

        internal sealed override Cci.IMethodReference Translate(IMethodSymbolInternal symbol, DiagnosticBag diagnostics, bool needDeclaration)
        {
            return Translate((TMethodSymbol)symbol, diagnostics, needDeclaration);
        }

        internal sealed override IModuleSymbolInternal CommonSourceModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 28530, 28545);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 28533, 28545);
                    return SourceModule; DynAbs.Tracing.TraceSender.TraceExitMethod(286, 28530, 28545);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 28530, 28545);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 28530, 28545);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override Compilation CommonCompilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 28611, 28625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 28614, 28625);
                    return Compilation; DynAbs.Tracing.TraceSender.TraceExitMethod(286, 28611, 28625);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 28611, 28625);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 28611, 28625);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override CommonModuleCompilationState CommonModuleCompilationState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 28719, 28738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 28722, 28738);
                    return CompilationState; DynAbs.Tracing.TraceSender.TraceExitMethod(286, 28719, 28738);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 28719, 28738);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 28719, 28738);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override CommonEmbeddedTypesManager CommonEmbeddedTypesManagerOpt
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 28831, 28857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 28834, 28857);
                    return f_286_28834_28857(); DynAbs.Tracing.TraceSender.TraceExitMethod(286, 28831, 28857);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 28831, 28857);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 28831, 28857);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal MetadataConstant CreateConstant(
            TTypeSymbol type,
            object value,
            TSyntaxNode syntaxNodeOpt,
            DiagnosticBag diagnostics)
        {
            return new MetadataConstant(Translate(type, syntaxNodeOpt, diagnostics), value);
        }

        private static void AddTopLevelType(HashSet<string> names, Cci.INamespaceTypeDefinition type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(286, 29177, 29414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 29295, 29403);

                f_286_29295_29402_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(names, 286, 29295, 29402)?.Add(f_286_29306_29401(f_286_29341_29359(type), f_286_29361_29400(type))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(286, 29177, 29414);

                string
                f_286_29341_29359(Microsoft.Cci.INamespaceTypeDefinition
                this_param)
                {
                    var return_v = this_param.NamespaceName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 29341, 29359);
                    return return_v;
                }


                string
                f_286_29361_29400(Microsoft.Cci.INamespaceTypeDefinition
                namedType)
                {
                    var return_v = Cci.MetadataWriter.GetMangledName((Microsoft.Cci.INamedTypeReference)namedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 29361, 29400);
                    return return_v;
                }


                string
                f_286_29306_29401(string
                qualifier, string
                name)
                {
                    var return_v = MetadataHelpers.BuildQualifiedName(qualifier, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 29306, 29401);
                    return return_v;
                }


                bool?
                f_286_29295_29402_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 29295, 29402);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 29177, 29414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 29177, 29414);
            }
        }

        private static void VisitTopLevelType(Cci.TypeReferenceIndexer noPiaIndexer, Cci.INamespaceTypeDefinition type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(286, 29426, 29620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 29562, 29609);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(noPiaIndexer, 286, 29562, 29608)?.Visit(type), 286, 29575, 29608);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(286, 29426, 29620);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 29426, 29620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 29426, 29620);
            }
        }

        internal Cci.IFieldReference GetModuleVersionId(Cci.ITypeReference mvidType, TSyntaxNode syntaxOpt, DiagnosticBag diagnostics)
        {
            PrivateImplementationDetails details = GetPrivateImplClass(syntaxOpt, diagnostics);
            EnsurePrivateImplementationDetailsStaticConstructor(details, syntaxOpt, diagnostics);

            return details.GetModuleVersionId(mvidType);
        }

        internal Cci.IFieldReference GetInstrumentationPayloadRoot(int analysisKind, Cci.ITypeReference payloadType, TSyntaxNode syntaxOpt, DiagnosticBag diagnostics)
        {
            PrivateImplementationDetails details = GetPrivateImplClass(syntaxOpt, diagnostics);
            EnsurePrivateImplementationDetailsStaticConstructor(details, syntaxOpt, diagnostics);

            return details.GetOrAddInstrumentationPayloadRoot(analysisKind, payloadType);
        }

        private void EnsurePrivateImplementationDetailsStaticConstructor(PrivateImplementationDetails details, TSyntaxNode syntaxOpt, DiagnosticBag diagnostics)
        {
            if (details.GetMethod(WellKnownMemberNames.StaticConstructorName) == null)
            {
                details.TryAddSynthesizedMethod(CreatePrivateImplementationDetailsStaticConstructor(details, syntaxOpt, diagnostics));
            }
        }

        protected abstract Cci.IMethodDefinition CreatePrivateImplementationDetailsStaticConstructor(PrivateImplementationDetails details, TSyntaxNode syntaxOpt, DiagnosticBag diagnostics);
        private sealed class SynthesizedDefinitions
        {
            public ConcurrentQueue<Cci.INestedTypeDefinition> NestedTypes;

            public ConcurrentQueue<Cci.IMethodDefinition> Methods;

            public ConcurrentQueue<Cci.IPropertyDefinition> Properties;

            public ConcurrentQueue<Cci.IFieldDefinition> Fields;

            public ImmutableArray<ISymbolInternal> GetAllMembers()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 31723, 32921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 31810, 31868);

                    var
                    builder = f_286_31824_31867()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 31888, 32107) || true) && (Fields != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 31888, 32107);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 31948, 32088);
                            foreach (var field in f_286_31970_31976_I(Fields))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 31948, 32088);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 32026, 32065);

                                f_286_32026_32064(builder, f_286_32038_32063(field));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(286, 31948, 32088);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(286, 1, 141);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(286, 1, 141);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(286, 31888, 32107);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 32127, 32350) || true) && (Methods != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 32127, 32350);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 32188, 32331);
                            foreach (var method in f_286_32211_32218_I(Methods))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 32188, 32331);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 32268, 32308);

                                f_286_32268_32307(builder, f_286_32280_32306(method));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(286, 32188, 32331);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(286, 1, 144);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(286, 1, 144);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(286, 32127, 32350);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 32370, 32603) || true) && (Properties != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 32370, 32603);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 32434, 32584);
                            foreach (var property in f_286_32459_32469_I(Properties))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 32434, 32584);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 32519, 32561);

                                f_286_32519_32560(builder, f_286_32531_32559(property));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(286, 32434, 32584);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(286, 1, 151);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(286, 1, 151);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(286, 32370, 32603);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 32623, 32850) || true) && (NestedTypes != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 32623, 32850);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 32688, 32831);
                            foreach (var type in f_286_32709_32720_I(NestedTypes))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 32688, 32831);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 32770, 32808);

                                f_286_32770_32807(builder, f_286_32782_32806(type));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(286, 32688, 32831);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(286, 1, 144);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(286, 1, 144);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(286, 32623, 32850);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 32870, 32906);

                    return f_286_32877_32905(builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(286, 31723, 32921);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                    f_286_31824_31867()
                    {
                        var return_v = ArrayBuilder<ISymbolInternal>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 31824, 31867);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                    f_286_32038_32063(Microsoft.Cci.IFieldDefinition
                    this_param)
                    {
                        var return_v = this_param.GetInternalSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 32038, 32063);
                        return return_v;
                    }


                    int
                    f_286_32026_32064(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                    this_param, Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 32026, 32064);
                        return 0;
                    }


                    System.Collections.Concurrent.ConcurrentQueue<Microsoft.Cci.IFieldDefinition>
                    f_286_31970_31976_I(System.Collections.Concurrent.ConcurrentQueue<Microsoft.Cci.IFieldDefinition>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 31970, 31976);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                    f_286_32280_32306(Microsoft.Cci.IMethodDefinition
                    this_param)
                    {
                        var return_v = this_param.GetInternalSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 32280, 32306);
                        return return_v;
                    }


                    int
                    f_286_32268_32307(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                    this_param, Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 32268, 32307);
                        return 0;
                    }


                    System.Collections.Concurrent.ConcurrentQueue<Microsoft.Cci.IMethodDefinition>
                    f_286_32211_32218_I(System.Collections.Concurrent.ConcurrentQueue<Microsoft.Cci.IMethodDefinition>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 32211, 32218);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                    f_286_32531_32559(Microsoft.Cci.IPropertyDefinition
                    this_param)
                    {
                        var return_v = this_param.GetInternalSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 32531, 32559);
                        return return_v;
                    }


                    int
                    f_286_32519_32560(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                    this_param, Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 32519, 32560);
                        return 0;
                    }


                    System.Collections.Concurrent.ConcurrentQueue<Microsoft.Cci.IPropertyDefinition>
                    f_286_32459_32469_I(System.Collections.Concurrent.ConcurrentQueue<Microsoft.Cci.IPropertyDefinition>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 32459, 32469);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                    f_286_32782_32806(Microsoft.Cci.INestedTypeDefinition
                    this_param)
                    {
                        var return_v = this_param.GetInternalSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 32782, 32806);
                        return return_v;
                    }


                    int
                    f_286_32770_32807(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                    this_param, Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 32770, 32807);
                        return 0;
                    }


                    System.Collections.Concurrent.ConcurrentQueue<Microsoft.Cci.INestedTypeDefinition>
                    f_286_32709_32720_I(System.Collections.Concurrent.ConcurrentQueue<Microsoft.Cci.INestedTypeDefinition>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 32709, 32720);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                    f_286_32877_32905(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 32877, 32905);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 31723, 32921);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 31723, 32921);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SynthesizedDefinitions()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(286, 31370, 32932);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 31488, 31499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 31560, 31567);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 31630, 31640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 31700, 31706);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(286, 31370, 32932);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 31370, 32932);
            }


            static SynthesizedDefinitions()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(286, 31370, 32932);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(286, 31370, 32932);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 31370, 32932);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(286, 31370, 32932);
        }

        private readonly ConcurrentDictionary<TNamedTypeSymbol, SynthesizedDefinitions> _synthesizedTypeMembers;

        private ConcurrentDictionary<INamespaceSymbolInternal, ConcurrentQueue<INamespaceOrTypeSymbolInternal>> _lazySynthesizedNamespaceMembers;

        internal abstract IEnumerable<Cci.INestedTypeDefinition> GetSynthesizedNestedTypes(TNamedTypeSymbol container);

        /// <summary>
        /// Returns null if there are no compiler generated types.
        /// </summary>
        public IEnumerable<Cci.INestedTypeDefinition> GetSynthesizedTypes(TNamedTypeSymbol container)
        {
            IEnumerable<Cci.INestedTypeDefinition> declareTypes = GetSynthesizedNestedTypes(container);
            IEnumerable<Cci.INestedTypeDefinition> compileEmitTypes = null;

            if (_synthesizedTypeMembers.TryGetValue(container, out var defs))
            {
                compileEmitTypes = defs.NestedTypes;
            }

            if (declareTypes == null)
            {
                return compileEmitTypes;
            }

            if (compileEmitTypes == null)
            {
                return declareTypes;
            }

            return declareTypes.Concat(compileEmitTypes);
        }

        private SynthesizedDefinitions GetOrAddSynthesizedDefinitions(TNamedTypeSymbol container)
        {
            Debug.Assert(container.IsDefinition);
            return _synthesizedTypeMembers.GetOrAdd(container, _ => new SynthesizedDefinitions());
        }

        public void AddSynthesizedDefinition(TNamedTypeSymbol container, Cci.IMethodDefinition method)
        {
            Debug.Assert(method != null);

            SynthesizedDefinitions defs = GetOrAddSynthesizedDefinitions(container);
            if (defs.Methods == null)
            {
                Interlocked.CompareExchange(ref defs.Methods, new ConcurrentQueue<Cci.IMethodDefinition>(), null);
            }

            defs.Methods.Enqueue(method);
        }

        public void AddSynthesizedDefinition(TNamedTypeSymbol container, Cci.IPropertyDefinition property)
        {
            Debug.Assert(property != null);

            SynthesizedDefinitions defs = GetOrAddSynthesizedDefinitions(container);
            if (defs.Properties == null)
            {
                Interlocked.CompareExchange(ref defs.Properties, new ConcurrentQueue<Cci.IPropertyDefinition>(), null);
            }

            defs.Properties.Enqueue(property);
        }

        public void AddSynthesizedDefinition(TNamedTypeSymbol container, Cci.IFieldDefinition field)
        {
            Debug.Assert(field != null);

            SynthesizedDefinitions defs = GetOrAddSynthesizedDefinitions(container);
            if (defs.Fields == null)
            {
                Interlocked.CompareExchange(ref defs.Fields, new ConcurrentQueue<Cci.IFieldDefinition>(), null);
            }

            defs.Fields.Enqueue(field);
        }

        public void AddSynthesizedDefinition(TNamedTypeSymbol container, Cci.INestedTypeDefinition nestedType)
        {
            Debug.Assert(nestedType != null);

            SynthesizedDefinitions defs = GetOrAddSynthesizedDefinitions(container);
            if (defs.NestedTypes == null)
            {
                Interlocked.CompareExchange(ref defs.NestedTypes, new ConcurrentQueue<Cci.INestedTypeDefinition>(), null);
            }

            defs.NestedTypes.Enqueue(nestedType);
        }

        public void AddSynthesizedDefinition(INamespaceSymbolInternal container, INamespaceOrTypeSymbolInternal typeOrNamespace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 36599, 37229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 36744, 36782);

                f_286_36744_36781(typeOrNamespace != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 36796, 37064) || true) && (_lazySynthesizedNamespaceMembers == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 36796, 37064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 36874, 37049);

                    f_286_36874_37048(ref _lazySynthesizedNamespaceMembers, f_286_36940_37041(), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(286, 36796, 37064);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 37080, 37218);

                f_286_37080_37217(f_286_37080_37192(
                            _lazySynthesizedNamespaceMembers, container, _ => new ConcurrentQueue<INamespaceOrTypeSymbolInternal>()), typeOrNamespace);
                DynAbs.Tracing.TraceSender.TraceExitMethod(286, 36599, 37229);

                int
                f_286_36744_36781(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 36744, 36781);
                    return 0;
                }


                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal, System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Symbols.INamespaceOrTypeSymbolInternal>>
                f_286_36940_37041()
                {
                    var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal, System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Symbols.INamespaceOrTypeSymbolInternal>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 36940, 37041);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal, System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Symbols.INamespaceOrTypeSymbolInternal>>?
                f_286_36874_37048(ref System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal, System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Symbols.INamespaceOrTypeSymbolInternal>>?
                location1, System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal, System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Symbols.INamespaceOrTypeSymbolInternal>>
                value, System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal, System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Symbols.INamespaceOrTypeSymbolInternal>>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 36874, 37048);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Symbols.INamespaceOrTypeSymbolInternal>
                f_286_37080_37192(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal, System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Symbols.INamespaceOrTypeSymbolInternal>>
                this_param, Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal
                key, System.Func<Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal, System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Symbols.INamespaceOrTypeSymbolInternal>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 37080, 37192);
                    return return_v;
                }


                int
                f_286_37080_37217(System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Symbols.INamespaceOrTypeSymbolInternal>
                this_param, Microsoft.CodeAnalysis.Symbols.INamespaceOrTypeSymbolInternal
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 37080, 37217);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 36599, 37229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 36599, 37229);
            }
        }

        /// <summary>
        /// Returns null if there are no synthesized fields.
        /// </summary>
        public IEnumerable<Cci.IFieldDefinition> GetSynthesizedFields(TNamedTypeSymbol container)
            => _synthesizedTypeMembers.TryGetValue(container, out var defs) ? defs.Fields : null;

        /// <summary>
        /// Returns null if there are no synthesized properties.
        /// </summary>
        public IEnumerable<Cci.IPropertyDefinition> GetSynthesizedProperties(TNamedTypeSymbol container)
            => _synthesizedTypeMembers.TryGetValue(container, out var defs) ? defs.Properties : null;

        /// <summary>
        /// Returns null if there are no synthesized methods.
        /// </summary>
        public IEnumerable<Cci.IMethodDefinition> GetSynthesizedMethods(TNamedTypeSymbol container)
            => _synthesizedTypeMembers.TryGetValue(container, out var defs) ? defs.Methods : null;

        internal override ImmutableDictionary<ISymbolInternal, ImmutableArray<ISymbolInternal>> GetAllSynthesizedMembers()
        {
            var builder = ImmutableDictionary.CreateBuilder<ISymbolInternal, ImmutableArray<ISymbolInternal>>();

            foreach (var entry in _synthesizedTypeMembers)
            {
                builder.Add(entry.Key, entry.Value.GetAllMembers());
            }

            var namespaceMembers = _lazySynthesizedNamespaceMembers;
            if (namespaceMembers != null)
            {
                foreach (var entry in namespaceMembers)
                {
                    builder.Add(entry.Key, entry.Value.ToImmutableArray<ISymbolInternal>());
                }
            }

            return builder.ToImmutable();
        }

        #region Token Mapping

        Cci.IFieldReference ITokenDeferral.GetFieldForData(ImmutableArray<byte> data, SyntaxNode syntaxNode, DiagnosticBag diagnostics)
        {
            Debug.Assert(this.SupportsPrivateImplClass);

            var privateImpl = this.GetPrivateImplClass((TSyntaxNode)syntaxNode, diagnostics);

            // map a field to the block (that makes it addressable via a token)
            return privateImpl.CreateDataField(data);
        }

        public abstract Cci.IMethodReference GetInitArrayHelper();

        public ArrayMethods ArrayMethods
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 39626, 40078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 39662, 39702);

                    ArrayMethods
                    result = _lazyArrayMethods
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 39722, 40029) || true) && (result == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 39722, 40029);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 39782, 39810);

                        result = f_286_39791_39809();

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 39834, 40010) || true) && (f_286_39838_39902(ref _lazyArrayMethods, result, null) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(286, 39834, 40010);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 39960, 39987);

                            result = _lazyArrayMethods;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(286, 39834, 40010);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(286, 39722, 40029);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 40049, 40063);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(286, 39626, 40078);

                    Microsoft.CodeAnalysis.CodeGen.ArrayMethods
                    f_286_39791_39809()
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeGen.ArrayMethods();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 39791, 39809);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ArrayMethods
                    f_286_39838_39902(ref Microsoft.CodeAnalysis.CodeGen.ArrayMethods
                    location1, Microsoft.CodeAnalysis.CodeGen.ArrayMethods
                    value, Microsoft.CodeAnalysis.CodeGen.ArrayMethods
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 39838, 39902);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 39569, 40089);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 39569, 40089);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        #endregion

        #region Private Implementation Details Type

        internal PrivateImplementationDetails GetPrivateImplClass(TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            var result = _privateImplementationDetails;

            if ((result == null) && this.SupportsPrivateImplClass)
            {
                result = new PrivateImplementationDetails(
                        this,
                        this.SourceModule.Name,
                        Compilation.GetSubmissionSlotIndex(),
                        this.GetSpecialType(SpecialType.System_Object, syntaxNodeOpt, diagnostics),
                        this.GetSpecialType(SpecialType.System_ValueType, syntaxNodeOpt, diagnostics),
                        this.GetSpecialType(SpecialType.System_Byte, syntaxNodeOpt, diagnostics),
                        this.GetSpecialType(SpecialType.System_Int16, syntaxNodeOpt, diagnostics),
                        this.GetSpecialType(SpecialType.System_Int32, syntaxNodeOpt, diagnostics),
                        this.GetSpecialType(SpecialType.System_Int64, syntaxNodeOpt, diagnostics),
                        SynthesizeAttribute(WellKnownMember.System_Runtime_CompilerServices_CompilerGeneratedAttribute__ctor));

                if (Interlocked.CompareExchange(ref _privateImplementationDetails, result, null) != null)
                {
                    result = _privateImplementationDetails;
                }
            }

            return result;
        }

        internal PrivateImplementationDetails PrivateImplClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 41733, 41778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 41739, 41776);

                    return _privateImplementationDetails;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(286, 41733, 41778);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 41654, 41789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 41654, 41789);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(286, 41873, 41893);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(286, 41879, 41891);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(286, 41873, 41893);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(286, 41801, 41904);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 41801, 41904);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        #endregion

        public sealed override Cci.ITypeReference GetPlatformType(Cci.PlatformType platformType, EmitContext context)
        {
            Debug.Assert((object)this == context.Module);

            switch (platformType)
            {
                case Cci.PlatformType.SystemType:
                    return GetSystemType((TSyntaxNode)context.SyntaxNodeOpt, context.Diagnostics);

                default:
                    return GetSpecialType((SpecialType)platformType, (TSyntaxNode)context.SyntaxNodeOpt, context.Diagnostics);
            }
        }

        static PEModuleBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(286, 20788, 42509);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(286, 20788, 42509);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(286, 20788, 42509);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(286, 20788, 42509);

        Microsoft.Cci.RootModuleType
        f_286_22034_22058()
        {
            var return_v = new Microsoft.Cci.RootModuleType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 22034, 22058);
            return return_v;
        }


        static int
        f_286_22661_22695(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 22661, 22695);
            return 0;
        }


        static int
        f_286_22710_22755(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 22710, 22755);
            return 0;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
        f_286_22555_22572_C(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(286, 22153, 22906);
            return return_v;
        }


        TAssemblySymbol
        f_286_23110_23120()
        {
            var return_v = CorLibrary;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 23110, 23120);
            return return_v;
        }


        TEmbeddedTypesManager
        f_286_28834_28857()
        {
            var return_v = EmbeddedTypesManagerOpt;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(286, 28834, 28857);
            return return_v;
        }


        System.Collections.Concurrent.ConcurrentDictionary<TNamedTypeSymbol, Microsoft.CodeAnalysis.Emit.PEModuleBuilder<TCompilation, TSourceModuleSymbol, TAssemblySymbol, TTypeSymbol, TNamedTypeSymbol, TMethodSymbol, TSyntaxNode, TEmbeddedTypesManager, TModuleCompilationState>.SynthesizedDefinitions>
        f_286_33063_33165(Roslyn.Utilities.ReferenceEqualityComparer
        comparer)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<TNamedTypeSymbol, Microsoft.CodeAnalysis.Emit.PEModuleBuilder<TCompilation, TSourceModuleSymbol, TAssemblySymbol, TTypeSymbol, TNamedTypeSymbol, TMethodSymbol, TSyntaxNode, TEmbeddedTypesManager, TModuleCompilationState>.SynthesizedDefinitions>((System.Collections.Generic.IEqualityComparer<TNamedTypeSymbol>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(286, 33063, 33165);
            return return_v;
        }

    }
}
